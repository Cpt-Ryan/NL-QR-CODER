Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If WallsRB.Checked Then
            Walls.Show()
        End If

        If CeilingRB.Checked Then
            Ceilings.Show()
        End If

        If CornerRB.Checked Then
            Corners.Show()
        End If

        If FloorsRB.Checked Then
            Floors.Show()
        End If

        If TeesRB.Checked Then
            Tees.Show()
        End If

        If DEVSTR.Checked Then
            Edit_Text.Show()
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim partNumber As String = FindPN.Text.Trim()
        Dim previousImage As System.Drawing.Image = QRCode.Image
        QRCode.Image = Nothing
        FoundPartLabel.Text = String.Empty
        FoundPartLabel.Visible = False
        If previousImage IsNot Nothing Then previousImage.Dispose()

        If String.IsNullOrWhiteSpace(partNumber) Then
            MessageBox.Show("Please enter a part number.")
            FindPN.Focus()
            Return
        End If

        If partNumber.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) >= 0 OrElse
           partNumber = "." OrElse partNumber = ".." Then
            MessageBox.Show("Please enter a valid part number without a file extension.")
            Return
        End If

        Dim folder As String = "\\10.10.3.97\drawing_library\ROLLFORMER QR CODES\QR Codes"
        Dim imagePath As String = System.IO.Path.Combine(folder, partNumber & ".jpg")

        Try
            ' Copy into memory so the network file is not left locked.
            Using sourceImage As System.Drawing.Image = System.Drawing.Image.FromFile(imagePath)
                QRCode.Image = New System.Drawing.Bitmap(sourceImage)
            End Using
            QRCode.SizeMode = PictureBoxSizeMode.Zoom
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