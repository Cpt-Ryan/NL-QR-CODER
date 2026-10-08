Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            StorageConfiguration.Load()
        Catch ex As StorageConfigurationException
            MessageBox.Show(ex.Message, "Configuration Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub OpenPanelButton_Click(sender As Object, e As EventArgs) Handles OpenPanelButton.Click
        If WallsRB.Checked Then
            WallPanelForm.Show()
        End If

        If CeilingRB.Checked Then
            CeilingPanelForm.Show()
        End If

        If CornerRB.Checked Then
            CornerPanelForm.Show()
        End If

        If FloorsRB.Checked Then
            FloorPanelForm.Show()
        End If

        If TeesRB.Checked Then
            TeePanelForm.Show()
        End If

        If DEVSTR.Checked Then
            QrStringEditorForm.Show()
        End If

    End Sub


    Private Sub PartNumberTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PartNumberTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
            FindQrCodeButton.PerformClick()
        End If
    End Sub
    Private Sub FindQrCodeButton_Click(sender As Object, e As EventArgs) Handles FindQrCodeButton.Click
        Dim partNumber As String = PartNumberTextBox.Text.Trim()
        Dim previousImage As System.Drawing.Image = QrCodePictureBox.Image
        QrCodePictureBox.Image = Nothing
        FoundPartLabel.Text = String.Empty
        FoundPartLabel.Visible = False
        If previousImage IsNot Nothing Then previousImage.Dispose()

        If String.IsNullOrWhiteSpace(partNumber) Then
            MessageBox.Show("Please enter a part number.")
            PartNumberTextBox.Focus()
            Return
        End If

        If partNumber.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) >= 0 OrElse
           partNumber = "." OrElse partNumber = ".." Then
            MessageBox.Show("Please enter a valid part number without a file extension.")
            Return
        End If

        Try
            Dim settings = StorageConfiguration.Load()
            Dim imagePath As String = System.IO.Path.Combine(settings.PrimaryQrFolder, partNumber & ".jpg")
            ' Copy into memory so the network file is not left locked.
            Using sourceImage As System.Drawing.Image = System.Drawing.Image.FromFile(imagePath)
                QrCodePictureBox.Image = New System.Drawing.Bitmap(sourceImage)
            End Using
            QrCodePictureBox.SizeMode = PictureBoxSizeMode.Zoom
            FoundPartLabel.Text = "Part Number: " & partNumber
            FoundPartLabel.Visible = True
        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show("No JPG was found for part number: " & partNumber)
        Catch ex As Exception
            MessageBox.Show("Unable to load the QR code image." &
                            Environment.NewLine & ex.Message)
        End Try
    End Sub

End Class