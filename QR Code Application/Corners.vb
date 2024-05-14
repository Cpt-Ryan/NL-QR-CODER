Imports DocumentFormat.OpenXml.Wordprocessing

Public Class Corners
    Private Sub FBCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FBCheckBox.CheckedChanged
        If FBCheckBox.Checked Then
            TextBox3.Enabled = False
            TextBox4.Enabled = False
        Else
            If EXT.Checked Then
                TextBox3.Enabled = False
                TextBox4.Enabled = False
            Else
                TextBox3.Enabled = True
                TextBox4.Enabled = True
            End If

        End If


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
            FBCheckBox.Checked = False
            FBCheckBox.Enabled = False
        Else 'INT checked
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            FBCheckBox.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        QRCode.Image = Nothing 'clear any old qr code in box
        Dim PartNumber As String
        PartNumber = InputBox("Please Metal Part Number:", "Input Required")

        Dim MALEG As String = MaleLeg.Text
        Dim FELEG As String = FemaleLeg.Text
        Dim Height As String = PanelHeight.Text
        Dim ShearMALeg As Double
        Dim ShearFELeg As Double
        Dim ShearHeight As Double

        ' Try to convert MALEG to a Double
        If Double.TryParse(MALEG, ShearMALeg) Then

            If EXT.Checked Then 'If EXT checked
                ShearMALeg += 0

            Else 'If INT checked
                ShearMALeg += 0
            End If
        Else
            ' Conversion failed, show an error message
            MessageBox.Show("Please enter a valid number Male Leg Length.")
            Return
        End If

        ' Try to convert FELEG to a Double
        If Double.TryParse(FELEG, ShearFELeg) Then

            If EXT.Checked Then 'If EXT checked
                ShearFELeg += 0

            Else 'If INT checked
                ShearFELeg += 0
            End If
        Else
            ' Conversion failed, show an error message
            MessageBox.Show("Please enter a valid number Female Leg Length.")
            Return
        End If

        ' Try to convert Height to a Double
        If Double.TryParse(Height, ShearHeight) Then
            ShearHeight += 1.03125
        Else
            ' Conversion failed, show an error message
            MessageBox.Show("Please enter a valid number Panel Height.")
            Return
        End If

        Dim ShearWidth As Double
        If EXT.Checked Then 'EXT
            ShearWidth = ShearMALeg + ShearFELeg + 1.4375
        Else 'INT
            ShearWidth = ShearMALeg + ShearFELeg - 6.65625
        End If


        'Dim ShearString As String = (ShearMALeg & "," & ShearFELeg & "," & ShearHeight & "," & ShearWidth)
        'StringBox.Text = ShearString


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
        'StringBox.Text = CNString

        '***************************************************Center Notches***************************************************************************
        Dim EXTCenterOffset As Double = 0.71875
        Dim INTCenterOffset As Double = 0.6875

        Dim LCenterNotch As PointF
        Dim LCNString As String
        Dim TCenterNotch As PointF
        Dim TCNString As String

        If EXT.Checked Then
            LCenterNotch = New PointF(-0.29025, ShearFELeg + EXTCenterOffset)
            LCNString = $",L4,{LCenterNotch.X},{LCenterNotch.Y}"

            TCenterNotch = New PointF(ShearHeight + 0.29025, ShearFELeg + EXTCenterOffset)
            TCNString = $",L4,{TCenterNotch.X},{TCenterNotch.Y}"
        Else 'INT 

            LCenterNotch = New PointF(-0.09375, ShearFELeg - 4 + INTCenterOffset)
            LCNString = $",R4,{LCenterNotch.X},{LCenterNotch.Y}"

            TCenterNotch = New PointF(ShearHeight + 0.09375, ShearFELeg - 4 + INTCenterOffset)
            TCNString = $",R4,{TCenterNotch.X},{TCenterNotch.Y}"

        End If
        Dim CCNString As String = (LCNString & TCNString)



        '******************************************************Locks******************************************************************************


        'Function to interate through text boxes and convert strings into doubles
        Dim convertedValues As Dictionary(Of String, Double) = ConvertTextBoxesToDoubles()

        Dim TMy As Double = convertedValues("TextBox1")
        Dim TFy As Double = convertedValues("TextBox2")
        Dim BMy As Double = convertedValues("TextBox3")
        Dim BFy As Double = convertedValues("TextBox4")
        Dim S1y As Double = convertedValues("TextBox5")
        Dim S2y As Double = convertedValues("TextBox6")
        Dim S3y As Double = convertedValues("TextBox7")
        Dim S4y As Double = convertedValues("TextBox8")

        '*****************************************************Top Locks*******************************************************************************


        'Top Male Lock
        Dim TM As PointF
        Dim TMString As String
        If TMy = 0 Then
            TMString = String.Empty
        Else
            TM = New PointF(1.4375, TMy + 0.8125)
            TMString = $",L7,{TM.X},{TM.Y}"
        End If

        'Top Female Lock
        Dim TF As PointF
        Dim TFString As String
        If TFy = 0 Then
            TFString = String.Empty
        Else
            TF = New PointF(1.4375, TFy + 0.8125)
            TFString = $",R7,{TF.X},{TF.Y}"
        End If

        Dim TopLockString As String = (TMString & TFString)


        '****************************************************Bottom Locks****************************************************************************

        'Bottom Female Lock
        Dim BF As PointF
        Dim BFString As String

        If BFy = 0 Then
            BFString = String.Empty
        Else
            BF = New PointF(ShearHeight - 1.4375, ShearWidth - BFy - 0.8125)
            BFString = $",R7,{BF.X},{BF.Y}"
        End If

        Dim BM As PointF
        Dim BMString As String

        If BMy = 0 Then
            BMString = String.Empty
        Else
            BM = New PointF(ShearHeight - 1.4375, BMy + 0.8125)
            BMString = $",L7,{BM.X},{BM.Y}"
        End If

        Dim BottomLocksString As String = (BFString & BMString)


        'StringBox.Text = (TopLockString & BottomLocksString)

        '**************************************************Side Locks**********************************************************************************

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

        Dim SideLockString As String = (S1String & S2String & S3String & S4String)

        'StringBox.Text = SideLockString

        '**********************************************************String Building********************************************

        Dim Constants As String
        Constants = ($",Q,1,BL,{ShearHeight},BW,{ShearWidth},PL,{ShearHeight - 1.125},PW,{ShearWidth - 1.5625},GA,0,GL,0,LB,2,TB,1,FS,2,AS,2")

        Dim QRString As String
        'QRString = (PartNumber & "-Corner" & Constants & TopLockString & SideLockString & BottomLocksString & CNString & CCNString)
        If EXT.Checked Then
            QRString = (PartNumber & "-EXT-Corner" & Constants & TopLockString & SideLockString & BottomLocksString & CNString & CCNString)
        ElseIf INT.Checked Then
            QRString = (PartNumber & "-INT-Corner" & Constants & TopLockString & SideLockString & BottomLocksString & CNString & CCNString)
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
    'This Sub loops through the Lock Hole Text boxes and Creates a dictionary of them 

    Private Function ConvertTextBoxesToDoubles() As Dictionary(Of String, Double)
        Dim textBoxValues As New Dictionary(Of String, Double)()

        ' Handle TextBox1 to TextBox8 directly on the form
        For i As Integer = 1 To 8
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
        Return textBoxValues
    End Function

    Private Sub STD_CheckedChanged(sender As Object, e As EventArgs) Handles STD.CheckedChanged
        If STD.Checked Then
            MaleLeg.Text = 12
            FemaleLeg.Text = 12
            TextBox1.Text = 6
            TextBox2.Enabled = False
            TextBox4.Text = 6
            TextBox3.Enabled = False
        Else
            MaleLeg.Text = ""
            FemaleLeg.Text = ""
            TextBox1.Text = ""
            TextBox2.Enabled = True
            TextBox4.Text = ""
            TextBox3.Enabled = True
        End If

    End Sub
End Class