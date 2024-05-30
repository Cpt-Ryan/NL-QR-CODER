Imports DocumentFormat.OpenXml.Wordprocessing

Public Class Edit_Text
    Public Property QRString As String
    Public Property PartNumber As String

    Private Sub Edit_Text_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Use the received data, for example, display it in a TextBox
        TextBox1.Text = QRString
        Label1.Text = PartNumber
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DEV.Checked Then
            Dim qrImage As Bitmap = DEVQRGEN(QRString, PartNumber)
            QRCode.Image = qrImage
        Else
            Dim qrImage As Bitmap = QRGEN(QRString, PartNumber)
            QRCode.Image = qrImage
        End If
    End Sub
End Class