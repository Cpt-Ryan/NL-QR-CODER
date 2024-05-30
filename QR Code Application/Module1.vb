Imports QRCoder
Imports System.Drawing
Imports ClosedXML.Excel

Module QRCodeModule

    Function QRGEN(ByVal QRString As String, ByVal PartNumber As String) As Bitmap
        Dim baseSavePath As String = ("\\10.10.3.97\Drawing Library\ROLLFORMER QR CODES\QR Codes")
        Dim filename As String = $"{PartNumber}.jpg"
        Dim SavePath As String = System.IO.Path.Combine(baseSavePath, filename)

        Dim Gen As New QRCodeGenerator()
        Dim Data As QRCodeData = Gen.CreateQrCode(QRString, QRCodeGenerator.ECCLevel.Q)
        Dim Code As New QRCode(Data)
        Dim bm As Bitmap = Code.GetGraphic(6)

        bm.Save(SavePath, Imaging.ImageFormat.Jpeg)

        'Writes the String to a excel sheet for record keeping
        ' Now handle the Excel part using ClosedXML
        Using workbook As New XLWorkbook("\\10.10.3.97\Drawing Library\ROLLFORMER QR CODES\QR Code Strings.xlsm")
            ' Get reference to the first worksheet in the workbook
            Dim worksheet As IXLWorksheet = workbook.Worksheet(1)

            ' Check if the part number already exists in Column B
            Dim partNumberCell = worksheet.Columns("B").CellsUsed().FirstOrDefault(Function(c) c.Value.ToString() = PartNumber)

            If partNumberCell IsNot Nothing Then
                ' Part number already exists, overwrite the existing row
                Dim row = partNumberCell.WorksheetRow()

                row.Clear(XLClearOptions.Contents)

                ' Update the hyperlink and text in column A for the existing row
                row.Cell(1).SetHyperlink(New XLHyperlink(SavePath)) ' Set hyperlink to the QR code image
                row.Cell(1).Value = "Open QR Code Image" ' Set text for hyperlink

                ' Write the part number in column B
                row.Cell(2).Value = PartNumber

                ' Split QRString by comma and update the data in the existing row
                Dim dataItems() As String = QRString.Split(","c)
                Dim colIndex As Integer = 3 ' Start from column C
                For Each item As String In dataItems
                    row.Cell(colIndex).Value = item
                    colIndex += 1
                Next
            Else
                ' Part number doesn't exist, add a new row
                Dim lastUsedRow As Integer = worksheet.LastRowUsed().RowNumber() + 1
                worksheet.Cell(lastUsedRow, 2).Value = PartNumber ' Write the part number in column B

                ' Set hyperlink to the QR code image and text for hyperlink in column A for the new row
                Dim hyperlink As New XLHyperlink(SavePath)
                worksheet.Cell(lastUsedRow, 1).SetHyperlink(hyperlink)
                worksheet.Cell(lastUsedRow, 1).Value = "Open QR Code Image"

                ' Split QRString by comma and update the data in the new row
                Dim dataItems() As String = QRString.Split(","c)
                Dim colIndex As Integer = 3 ' Start from column C
                For Each item As String In dataItems
                    worksheet.Cell(lastUsedRow, colIndex).Value = item
                    colIndex += 1
                Next
            End If

            ' Save the workbook with the updated or new data
            workbook.Save()
        End Using

        ' Return the generated Bitmap
        Return bm
    End Function

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

