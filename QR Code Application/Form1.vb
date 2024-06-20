Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If WallsRB.Checked Then
            Walls.Show()
        End If

        If CeilingRB.Checked Then
            Ceilings.Show()
        End If

        If CornerRB.Checked Then
            Corners.show
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


End Class
