Imports DocumentFormat.OpenXml.Wordprocessing

Public Class QrStringEditorForm
    Public Property QRString As String
    Public Property PartNumber As String

    Private Sub Edit_Text_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Use the received data, for example, display it in a TextBox
        TextBox1.Text = QRString
        TextBox2.Text = PartNumber
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PartNumber = TextBox2.Text
        QRString = TextBox1.Text
        If DEV.Checked Then
            Dim qrImage As Bitmap = DEVQRGEN(QRString, PartNumber)
            QRCode.Image = qrImage
        Else
            Dim FoamDate As Date
            FoamDate = InputBox("Please enter the Foam Date in the format of MM/DD/YY:", "Input Required")
            Try
                Dim qrImage As Bitmap = QRGEN(QRString, PartNumber, FoamDate)
                QRCode.Image = qrImage
            Catch ex As StorageConfigurationException
                MessageBox.Show(ex.Message, "Configuration Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub
End Class