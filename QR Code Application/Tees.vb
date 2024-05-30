Public Class Tees
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles FETEERB.CheckedChanged
        If FETEERB.Checked Then
            GroupBox3.Enabled = False
            Button2.Visible = False
        Else
            GroupBox3.Enabled = True
        End If
    End Sub
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        If EXT.Checked Or FETEERB.Checked Then
            GroupBox3.Enabled = False
        Else
            Button2.Visible = True

        End If
    End Sub
    Private Sub MATEERB_CheckedChanged(sender As Object, e As EventArgs) Handles MATEERB.CheckedChanged
        If EXT.Checked Then
            GroupBox3.Enabled = False
            STD_CheckedChanged(sender, e)
        Else
            GroupBox3.Enabled = True
            STD_CheckedChanged(sender, e)
        End If
    End Sub

    Private Sub FEINT_CheckedChanged(sender As Object, e As EventArgs) Handles FEINT.CheckedChanged
        If FETEERB.Checked Then
            GroupBox3.Enabled = False
            STD_CheckedChanged(sender, e)
        Else
            GroupBox3.Enabled = True
            STD_CheckedChanged(sender, e)
        End If
    End Sub

    Private Sub MAINT_CheckedChanged(sender As Object, e As EventArgs) Handles MAINT.CheckedChanged
        If FETEERB.Checked Then
            GroupBox3.Enabled = False
        Else
            GroupBox3.Enabled = True
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox11.Text = TextBox7.Text
        TextBox12.Text = TextBox8.Text
        TextBox13.Text = TextBox9.Text
        TextBox14.Text = TextBox10.Text
    End Sub

    Private Sub EXT_CheckedChanged(sender As Object, e As EventArgs) Handles EXT.CheckedChanged
        If EXT.Checked Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
            GroupBox3.Enabled = False
        Else
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            TextBox9.Enabled = True
            TextBox10.Enabled = True
            GroupBox3.Enabled = True
        End If
    End Sub

    Private Sub STD_CheckedChanged(sender As Object, e As EventArgs) Handles STD.CheckedChanged
        If STD.Checked Then
            If MATEERB.Checked Then
                MALEG.Text = 12
                FELEG.Text = 12
                TEELength.Text = 12
                TextBox1.Text = 6
                TextBox2.Enabled = False
                TextBox3.Enabled = True
                TextBox3.Text = 6
                TextBox4.Enabled = False
                TextBox5.Text = 6
                TextBox6.Enabled = False
            ElseIf FETEERB.Checked Then
                MALEG.Text = 12
                FELEG.Text = 12
                TEELength.Text = 12
                TextBox1.Text = 6
                TextBox2.Enabled = False
                TextBox3.Enabled = False
                TextBox4.Enabled = False
                TextBox5.Text = 6
                TextBox6.Enabled = True
                TextBox6.Text = 6
            End If
        Else
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        QRCode.Image = Nothing 'clear any old qr code in box
        Dim PartNumber As String
        PartNumber = InputBox("Please Metal Part Number:", "Input Required")
        PN.Text = PartNumber
        PN.Visible = True
        DEVTEXT.Visible = True
        Dim NomMAleg As String = MALEG.Text
        Dim NomFELeg As String = FELEG.Text
        Dim NomTEELeg As String = TEELength.Text
        Dim NomPanelHeight As String = Height.Text
        Dim ShearHeight As Double
        Dim ShearMALeg As Double
        Dim ShearFELeg As Double
        Dim ShearTEELeg As Double

        ' Try to convert to a Double
        If Double.TryParse(NomMAleg, ShearMALeg) Then
            ShearMALeg -= 1.59375
        Else
            ' Conversion failed, show an error message
            MessageBox.Show("Please enter a valid Male Leg Length")
            Return
        End If

        If Double.TryParse(NomFELeg, ShearFELeg) Then
            ShearFELeg -= 1.59375
        Else
            ' Conversion failed, show an error message
            MessageBox.Show("Please enter a valid Female Leg Length")
            Return
        End If

        If Double.TryParse(NomTEELeg, ShearTEELeg) Then
            ShearTEELeg -= 3.5625
        Else
            ' Conversion failed, show an error message
            MessageBox.Show("Please enter a valid Tee Leg Length")
            Return
        End If

        If Double.TryParse(NomPanelHeight, ShearHeight) Then
            ShearHeight += 1.03125
        Else
            ' Conversion failed, show an error message
            MessageBox.Show("Please enter a valid Panel Height")
            Return
        End If

        Dim ShearWidth As Double
        If EXT.Checked Then
            ShearWidth = (ShearMALeg + 1.59375) + (ShearFELeg + 1.59375) + 1.53125
        ElseIf MAINT.Checked Then
            'INT checked
            ShearWidth = ShearTEELeg + ShearMALeg + 0.5
        ElseIf FEINT.Checked Then
            ShearWidth = ShearTEELeg + ShearFELeg + 0.5
        End If

        'StringBox.Text = (ShearWidth & "," & ShearHeight)

        '*************************************************Corner Notches********************************************************************


        Dim CN1 As PointF
        Dim CN1String As String
        Dim CN2 As PointF
        Dim CN2String As String
        Dim CN3 As PointF
        Dim CN3String As String
        Dim CN4 As PointF
        Dim CN4String As String

        Dim Xoffset As Double = 0.03125
        Dim Yoffset As Double = 0.1875

        'Origin
        CN1 = New PointF(-Xoffset, Yoffset)
        CN1String = $",L2,{CN1.X},{CN1.Y}"

        'Leading Edge top Corner
        CN2 = New PointF(-Xoffset, ShearWidth - Yoffset)
        CN2String = $",R2,{CN2.X},{CN2.Y}"

        'Trailing Edge top corner
        CN3 = New PointF(ShearHeight + Xoffset, ShearWidth - Yoffset)
        CN3String = $",R2,{CN3.X},{CN3.Y}"

        'Trailing Edge bottom corner
        CN4 = New PointF(ShearHeight + Xoffset, Yoffset)
        CN4String = $",L2,{CN4.X},{CN4.Y}"

        Dim CNString As String = (CN1String & CN2String & CN3String & CN4String)





        '***************************************************Center Notches***************************************************************************
        Dim TopCNTNotch As PointF
        Dim TopNotchString As String
        Dim BottomCNTNotch As PointF
        Dim BottomNotchString As String

        Dim XValue As Double = 0.09375


        If FEINT.Checked Then
            TopCNTNotch = New PointF(-XValue, ShearTEELeg + 0.25)
            TopNotchString = $",L4,{TopCNTNotch.X},{TopCNTNotch.Y}"

            BottomCNTNotch = New PointF(ShearHeight + XValue, ShearTEELeg + 0.25)
            BottomNotchString = $",L4,{BottomCNTNotch.X},{BottomCNTNotch.Y}"
        ElseIf MAINT.Checked Then
            TopCNTNotch = New PointF(-XValue, ShearMALeg + 0.25)
            TopNotchString = $",L4,{TopCNTNotch.X},{TopCNTNotch.Y}"

            BottomCNTNotch = New PointF(ShearHeight + XValue, ShearMALeg + 0.25)
            BottomNotchString = $",L4,{BottomCNTNotch.X},{BottomCNTNotch.Y}"
        Else ' EXT checked
            TopNotchString = String.Empty
            BottomNotchString = String.Empty

        End If

        Dim CNTNotchString As String
        CNTNotchString = (TopNotchString & BottomNotchString)



        '*******************************************************Top Locks******************************************************************************
        'Function to interate through text boxes and convert strings into doubles
        Dim convertedValues As Dictionary(Of String, Double) = ConvertTextBoxesToDoubles()

        'Collectiong all the lock hole locations
        Dim TM1y As Double = convertedValues("TextBox1")
        Dim TF1y As Double = convertedValues("TextBox2")
        Dim TT1y As Double = convertedValues("TextBox3")
        Dim BM1y As Double = convertedValues("TextBox4")
        Dim BF1y As Double = convertedValues("TextBox5")
        Dim BT1y As Double = convertedValues("TextBox6")
        Dim S1y As Double = convertedValues("TextBox7")
        Dim S2y As Double = convertedValues("TextBox8")
        Dim S3y As Double = convertedValues("TextBox9")
        Dim S4y As Double = convertedValues("TextBox10")
        Dim TS1y As Double = convertedValues("TextBox11")
        Dim TS2y As Double = convertedValues("TextBox12")
        Dim TS3y As Double = convertedValues("TextBox13")
        Dim TS4y As Double = convertedValues("TextBox14")

        Dim TSYOffset As Double = 0.8125
        Dim TSXOffset As Double = 1.4375

        'Top Male Lock
        Dim TM1 As PointF
        Dim TM1String As String
        If TM1y = 0 Then
            TM1String = String.Empty
        Else
            TM1 = New PointF(TSXOffset, TM1y + TSYOffset)
            TM1String = $",L7,{TM1.X},{TM1.Y}"
        End If

        'Top Female Lock 
        Dim TF1 As PointF
        Dim TF1String As String
        If TF1y = 0 Then
            TF1String = String.Empty
        Else
            TF1 = New PointF(TSXOffset, ShearWidth - TF1y - TSYOffset)
            TF1String = $",R7,{TF1.X},{TF1.Y}"
        End If

        'Top Tee Lock 
        Dim TT1 As PointF
        Dim TT1String As String
        If TT1y = 0 Then
            TT1String = String.Empty
        Else
            TT1 = New PointF(TSXOffset, TT1y + TSYOffset)
            TT1String = $",L7,{TT1.X},{TT1.Y}"
        End If

        Dim TopLocksString As String
        TopLocksString = (TM1String & TF1String & TT1String)


        '*****************************************************************Bottom Locks***********************************************

        'Bottom Male Lock 
        Dim BM1 As PointF
        Dim BM1String As String
        If BM1y = 0 Then
            BM1String = String.Empty
        Else
            BM1 = New PointF(ShearHeight - TSXOffset, BM1y + TSYOffset)
            BM1String = $",L7,{BM1.X},{BM1.Y}"
        End If

        'Bottom Female Lock
        Dim BF1 As PointF
        Dim BF1String As String
        If BF1y = 0 Then
            BF1String = String.Empty
        Else
            BF1 = New PointF(ShearHeight - TSXOffset, ShearWidth - BF1y - TSYOffset)
            BF1String = $",R7,{BF1.X},{BF1.Y}"
        End If

        'Bottom Tee Lock 
        Dim BT1 As PointF
        Dim BT1String As String
        If BT1y = 0 Then
            BT1String = String.Empty
        Else
            BT1 = New PointF(ShearHeight - TSXOffset, ShearWidth - BT1y - TSYOffset)
            BT1String = $",L7,{BT1.X},{BT1.Y}"
        End If

        Dim BottomLocksString As String
        BottomLocksString = (BM1String & BF1String & BT1String)
        'StringBox.Text = ("Top" & TM1String & TF1String & TT1String & "Bottom" & BM1String & BF1String & BT1String)

        '******************************************************Male Side Locks**************************************************

        Dim SIDEyOffset As Double = 1.6875
        Dim SIDExOffset As Double = 0.5

        'Top Lock
        Dim S1 As PointF
        Dim S1String As String

        If S1y = 0 Then
            S1String = String.Empty
        Else
            S1 = New PointF(S1y + SIDExOffset, SIDEyOffset)
            S1String = $",L7,{S1.X},{S1.Y}"
        End If

        'Second Lock
        Dim S2 As PointF
        Dim S2String As String

        If S2y = 0 Then
            S2String = String.Empty
        Else
            S2 = New PointF(S2y + SIDExOffset, SIDEyOffset)
            S2String = $",L7,{S2.X},{S2.Y}"
        End If

        'Thrid Side Lock
        Dim S3 As PointF
        Dim S3String As String

        If S3y = 0 Then
            S3String = String.Empty
        Else
            S3 = New PointF(S3y + SIDExOffset, SIDEyOffset)
            S3String = $",L7,{S3.X},{S3.Y}"
        End If

        'Fourth Side Lock
        Dim S4 As PointF
        Dim S4String As String

        If S4y = 0 Then
            S4String = String.Empty
        Else
            S4 = New PointF(S4y + SIDExOffset, SIDEyOffset)
            S4String = $",L7,{S4.X},{S4.Y}"
        End If

        'StringBox.Text = (S1String & S2String & S3String & S4String)

        Dim SideLockString As String
        SideLockString = (S1String & S2String & S3String & S4String)


        '***************************************************************Male TEE Locks************************************************

        'Top Lock
        Dim TS1 As PointF
        Dim TS1String As String

        If TS1y = 0 Then
            TS1String = String.Empty
        Else
            TS1 = New PointF(TS1y + SIDExOffset, SIDEyOffset)
            TS1String = $",L7,{TS1.X},{TS1.Y}"
        End If

        'Second Lock
        Dim TS2 As PointF
        Dim TS2String As String

        If TS2y = 0 Then
            TS2String = String.Empty
        Else
            TS2 = New PointF(TS2y + SIDExOffset, SIDEyOffset)
            TS2String = $",L7,{TS2.X},{TS2.Y}"
        End If

        'Thrid Side Lock
        Dim TS3 As PointF
        Dim TS3String As String

        If TS3y = 0 Then
            TS3String = String.Empty
        Else
            TS3 = New PointF(TS3y + SIDExOffset, SIDEyOffset)
            TS3String = $",L7,{TS3.X},{TS3.Y}"
        End If

        'Fourth Side Lock
        Dim TS4 As PointF
        Dim TS4String As String

        If TS4y = 0 Then
            TS4String = String.Empty
        Else
            TS4 = New PointF(TS4y + SIDExOffset, SIDEyOffset)
            TS4String = $",L7,{TS4.X},{TS4.Y}"
        End If

        Dim TeeSideLocksString As String
        TeeSideLocksString = (TS1String & TS2String & TS3String & TS4String)
        'StringBox.Text = TeeSideLocksString


        '**********************************************************String Building********************************************

        Dim Constants As String
        Constants = ($",Q,1,BL,{ShearHeight},BW,{ShearWidth},PL,{ShearHeight - 1.125},PW,{ShearWidth - 1.5625},GA,0,GL,1,LB,2,TB,1,FS,2,AS,2")

        Dim Type As String
        If MATEERB.Checked Then
            If MAINT.Checked Then
                Type = "-INT-MTMS"
            ElseIf FEINT.Checked Then
                Type = "-INT-MTFS"
            Else ' EXT.checked
                Type = "-EXT-Tee"
            End If

        ElseIf FETEERB.Checked Then
            If MAINT.Checked Then
                Type = "-INT-FTMS"
            ElseIf FEINT.Checked Then
                Type = "-INT-FTFS"
            Else ' EXT.checked
                Type = "-EXT-Tee"
            End If

        End If

        Dim QRString As String

        If MAINT.Checked Then
            QRString = (PartNumber & Type & Constants & SideLockString & TM1String & BM1String & BT1String & CNString & CNTNotchString)
        ElseIf FEINT.Checked Then
            QRString = (PartNumber & Type & Constants & TeeSideLocksString & TF1String & BF1String & TT1String & CNString & CNTNotchString)
        Else
            'EXT
            QRString = (PartNumber & Type & Constants & CNString)
        End If

        StringBox.Text = QRString
        If ShearWidth < 12.5 Then
            MessageBox.Show("QR Code not Generated" & vbCrLf & "The Roll Former is unable to form anything with a shear Width smaller than 12.5"". Check BW Value", "Warning")
        ElseIf ShearHeight > 190.25 Then
            MessageBox.Show("QR Code not Generated" & vbCrLf & "The Roll Former is unable to feed any piece that is Longer than 16' (190.25""). Check BL Value", "Warning")
        ElseIf DEV.Checked Then
            Dim qrImage As Bitmap = DEVQRGEN(QRString, PartNumber)
            QRCode.Image = qrImage
        Else
            Dim qrImage As Bitmap = QRGEN(QRString, PartNumber)
            QRCode.Image = qrImage

        End If


    End Sub

    Private Function ConvertTextBoxesToDoubles() As Dictionary(Of String, Double)
        Dim textBoxValues As New Dictionary(Of String, Double)()

        ' Handle TextBox1 to TextBox8 directly on the form
        For i As Integer = 1 To 10
            Dim textBox As TextBox = TryCast(Me.Controls($"TextBox{i}"), TextBox)
            If textBox IsNot Nothing Then
                Dim value As Double = 0 ' Default to 0
                ' If the textBox is enabled, attempt to parse its content; if it's disabled, value remains 0
                If textBox.Enabled Then
                    Double.TryParse(textBox.Text, value)
                End If
                textBoxValues(textBox.Name) = value
            End If
        Next

        Dim groupBox As System.Windows.Forms.GroupBox = TryCast(Me.Controls("GroupBox3"), System.Windows.Forms.GroupBox)
        If groupBox IsNot Nothing Then
            For i As Integer = 11 To 14
                Dim textBox As TextBox = TryCast(groupBox.Controls($"TextBox{i}"), TextBox)
                If textBox IsNot Nothing Then
                    Dim value As Double = 0 ' Default to 0
                    ' If the textBox is enabled, attempt to parse its content; if it's disabled, value remains 0
                    If textBox.Enabled Then
                        Double.TryParse(textBox.Text, value)
                    End If
                    textBoxValues(textBox.Name) = value
                End If
            Next
        End If

        Return textBoxValues
    End Function

    Private Sub DEVTEXT_Click(sender As Object, e As EventArgs) Handles DEVTEXT.Click
        ' Create an instance of the Edit_Text form
        Dim editTextForm As New Edit_Text()

        ' Pass the data to the Edit_Text form
        editTextForm.QRString = StringBox.Text
        editTextForm.PartNumber = PN.Text

        ' Show the Edit_Text form
        editTextForm.ShowDialog()
    End Sub

End Class