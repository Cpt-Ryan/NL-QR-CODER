Imports QRCoder
Imports System.Drawing
Imports ClosedXML.Excel

Module QRCodeModule

    Function QRGEN(ByVal QRString As String, ByVal PartNumber As String, ByVal FoamDate As Date?, Optional ByVal IsSoftPart As Boolean = False) As Bitmap
        Dim baseSavePath As String = ("\\10.10.3.97\drawing_library\ROLLFORMER QR CODES\QR Codes")
        Dim baseSavePath2 As String = ("\\10.27.1.207\ProdCtl_PDFs\ROLLFORMER QR CODES")
        Dim filename As String = $"{PartNumber}.jpg"
        Dim SavePath As String = System.IO.Path.Combine(baseSavePath, filename)
        Dim SavePath2 As String = System.IO.Path.Combine(baseSavePath2, filename)

        If IsSoftPart AndAlso Not FoamDate.HasValue Then
            Throw New ArgumentException("A foam date is required for soft parts.", NameOf(FoamDate))
        End If

        ' Prepare the selected worksheet before writing any image files.
        Using workbook As New XLWorkbook("\\10.10.3.97\drawing_library\ROLLFORMER QR CODES\QR Code Strings.xlsm")
            WriteQRRecord(workbook, QRString, PartNumber, SavePath, FoamDate, IsSoftPart)
            Using gen As New QRCodeGenerator()
                Using data As QRCodeData = gen.CreateQrCode(QRString, QRCodeGenerator.ECCLevel.Q)
                    Using code As New QRCode(data)
                        Dim bm As Bitmap = code.GetGraphic(6)
                        Try
                            bm.Save(SavePath, Imaging.ImageFormat.Jpeg)
                            bm.Save(SavePath2, Imaging.ImageFormat.Jpeg)
                            workbook.Save()
                            Return bm
                        Catch
                            bm.Dispose()
                            Throw
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    ' Kept separate from network I/O so the column mapping can be verified safely.
    Public Sub WriteQRRecord(workbook As XLWorkbook, QRString As String,
                             PartNumber As String, imagePath As String,
                             FoamDate As Date?, IsSoftPart As Boolean)
        If IsSoftPart AndAlso Not FoamDate.HasValue Then
            Throw New ArgumentException("A foam date is required for soft parts.", NameOf(FoamDate))
        End If

        Dim sheetName As String = If(IsSoftPart, "SoftParts", "HardParts")
        Dim worksheet As IXLWorksheet = Nothing
        If Not workbook.TryGetWorksheet(sheetName, worksheet) Then
            Throw New InvalidOperationException("The workbook is missing the '" & sheetName & "' worksheet.")
        End If
        Dim partColumn As Integer = If(IsSoftPart, 3, 2)
        Dim dataColumn As Integer = partColumn + 1
        Dim partNumberCell = worksheet.Column(partColumn).CellsUsed().FirstOrDefault(
            Function(c) c.Address.RowNumber > 1 AndAlso c.GetString() = PartNumber)
        Dim rowNumber As Integer
        If partNumberCell IsNot Nothing Then
            rowNumber = partNumberCell.Address.RowNumber
            worksheet.Row(rowNumber).Clear(XLClearOptions.Contents)
        Else
            Dim lastRow = worksheet.LastRowUsed()
            rowNumber = If(lastRow Is Nothing, 2, Math.Max(2, lastRow.RowNumber() + 1))
        End If

        Dim row = worksheet.Row(rowNumber)
        row.Cell(1).SetHyperlink(New XLHyperlink(imagePath))
        row.Cell(1).Value = "Open QR Code Image"
        If IsSoftPart Then
            row.Cell(2).Value = FoamDate.Value.Date
            row.Cell(2).Style.DateFormat.Format = "mm/dd/yyyy"
        End If
        row.Cell(partColumn).Value = PartNumber
        Dim dataItems() As String = QRString.Split(","c)
        For i As Integer = 0 To dataItems.Length - 1
            row.Cell(dataColumn + i).Value = dataItems(i)
        Next
    End Sub

End Module

Module DevQRcode 'The same QR function but it just return the bitmap no saving jpeg or adding to excel file 
    Function DEVQRGEN(ByVal QRString As String, ByVal PartNumber As String) As Bitmap
        Dim Gen As New QRCodeGenerator()
        Dim Data As QRCodeData = Gen.CreateQrCode(QRString, QRCodeGenerator.ECCLevel.Q)
        Dim Code As New QRCode(Data)
        Dim bm As Bitmap = Code.GetGraphic(6)

        Return bm

    End Function

End Module

