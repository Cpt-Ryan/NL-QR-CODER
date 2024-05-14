Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms

Public Class Walls


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'This is to make sure they can have bottom locks if Exterior is checked if they choose FB as well
        If Exterior.Checked Then

        Else
            If CheckBox1.Checked Then
                TextBox3.Enabled = False
                TextBox4.Enabled = False

            Else
                TextBox3.Enabled = True
                TextBox4.Enabled = True
            End If
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If DoubleMaleBox.Checked Then
            Button2.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox9.Text = TextBox5.Text
        TextBox10.Text = TextBox6.Text
        TextBox11.Text = TextBox7.Text
        TextBox12.Text = TextBox8.Text
    End Sub
    Private Sub Exterior_CheckedChanged(sender As Object, e As EventArgs) Handles Exterior.CheckedChanged
        If Exterior.Checked Then
            'Hide all Lock Holes for exterior Radio Button
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
            'Turn off double male and FB functionality for Exterior 
            CheckBox1.Enabled = False
            'CheckBox1.Checked = False
            DoubleMaleBox.Enabled = False
            If DoubleMaleBox.Checked Then
                GroupBox2.Visible = False
            End If


        Else
            'Show lock locations text boxes
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            CheckBox1.Enabled = True
            DoubleMaleBox.Enabled = False
            If DoubleMaleBox.Checked Then
                GroupBox2.Visible = True
            End If

            If CheckBox1.Checked Then
                TextBox3.Enabled = False
                TextBox4.Enabled = False
            End If
        End If
    End Sub

    Private Sub DoubleMaleBox_CheckedChanged(sender As Object, e As EventArgs) Handles DoubleMaleBox.CheckedChanged
        'Hide Symetrical button untill Double male is chosen
        If DoubleMaleBox.Checked Then
            GroupBox2.Visible = True
        Else
            GroupBox2.Visible = False
            Button2.Visible = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        QRCode.Image = Nothing 'clear any old qr code in box
        Dim PartNumber As String
        PartNumber = InputBox("Please Metal Part Number:", "Input Required")

        '***************************************Panel Size*************************************************************

        Dim NomPanelWidthAsString As String = WallWidth.Text
        Dim NomPanelHeightAsString As String = WallHeight.Text
        Dim QRString As String
        Dim ShearPanelWidth As Double
        Dim ShearPanelHeight As Double

        ' Try to convert NomPanelWidthAsString to a Double
        If Double.TryParse(NomPanelWidthAsString, ShearPanelWidth) Then
            ' Conversion successful, now add 1.53125 to ShearPanelWidth
            ShearPanelWidth += 1.53125
        Else
            ' Conversion failed, show an error message
            MessageBox.Show("Please enter a valid number for the panel Width.")
            Return
        End If

        ' Try to convert NomPanelWidthAsString to a Double
        If Double.TryParse(NomPanelHeightAsString, ShearPanelHeight) Then
            ' Conversion successful, now add 1.03125 to ShearPanelHeight
            ShearPanelHeight += 1.03125
        Else
            ' Conversion failed, show an error message
            MessageBox.Show("Please enter a valid number for the panel Height.")
            Return
        End If


        '*****************************************Corner Punches******************************************************


        Dim CornerNotch1 As PointF
        Dim CornerNotch1String As String
        Dim CornerNotch2 As PointF
        Dim CornerNotch2String As String
        Dim CornerNotch3 As PointF
        Dim CornerNotch3String As String
        Dim CornerNotch4 As PointF
        Dim CornerNotch4String As String
        Dim Xcorneroffset As Double = 0.03125
        Dim Ycorneroffset As Double = 0.1875

        'Origin (bottom)
        CornerNotch1 = New PointF(0 - Xcorneroffset, Ycorneroffset)
        CornerNotch1String = $",L2,{CornerNotch1.X},{CornerNotch1.Y}"

        'Fixed Side Leading edge Corner (top)
        CornerNotch2 = New PointF(0 - Xcorneroffset, ShearPanelWidth - Ycorneroffset)
        CornerNotch2String = $",R2,{CornerNotch2.X},{CornerNotch2.Y}"

        'Adjustable Side Trailing edge Corner (top)
        CornerNotch3 = New PointF(ShearPanelHeight + Xcorneroffset, ShearPanelWidth - Ycorneroffset)
        CornerNotch3String = $",R2,{CornerNotch3.X},{CornerNotch3.Y}"

        'Fixed Side Trailing edge Corner (bottom)
        CornerNotch4 = New PointF(ShearPanelHeight + Xcorneroffset, Ycorneroffset)
        CornerNotch4String = $",L2,{CornerNotch4.X},{CornerNotch4.Y}"

        Dim NotchString As String

        If Exterior.Checked Then
            NotchString = (CornerNotch4String & CornerNotch3String & CornerNotch2String & CornerNotch1String)
        Else
            NotchString = (CornerNotch2String & CornerNotch1String & CornerNotch4String & CornerNotch3String)
        End If


        '*****************************************Lock Holes***********************************************************

        'Function to interate through text boxes and convert strings into doubles
        Dim convertedValues As Dictionary(Of String, Double) = ConvertTextBoxesToDoubles()

        Dim T1y As Double = convertedValues("TextBox1")
        Dim T2y As Double = convertedValues("TextBox2")
        Dim B1y As Double = convertedValues("TextBox3")
        Dim B2y As Double = convertedValues("TextBox4")
        Dim S1x As Double = convertedValues("TextBox5")
        Dim S2x As Double = convertedValues("TextBox6")
        Dim S3x As Double = convertedValues("TextBox7")
        Dim S4x As Double = convertedValues("TextBox8")
        Dim DMS1x As Double = convertedValues("TextBox9")
        Dim DMS2x As Double = convertedValues("TextBox10")
        Dim DMS3x As Double = convertedValues("TextBox11")
        Dim DMS4x As Double = convertedValues("TextBox12")

        'Top Locks and Bottom Locks
        Dim TXoffset As Double = 1.4375
        Dim TYoffset As Double = 0.8125
        Dim Byoffset As Double = 0.71875
        Dim T1String As String

        'T1
        '
        If T1y = 0 Then
            T1String = String.Empty
        ElseIf T1y > 19 Then 'Making sure the Left Side wont try and reach to far 
            Dim T1 As PointF = New PointF(TXoffset, T1y + TYoffset)
            T1String = $",R7,{T1.X},{T1.Y}"
        Else
            Dim T1 As PointF = New PointF(TXoffset, T1y + TYoffset)
            T1String = $",L7,{T1.X},{T1.Y}"
        End If

        Dim T2String As String
        'T2

        If T2y = 0 Then
            T2String = String.Empty
        ElseIf T2y < 19 Then 'Making sure the Right Side wont colide with left side
            Dim T2 As PointF = New PointF(TXoffset, T2y + TYoffset)
            T2String = $",L7,{T2.X},{T2.Y}"
        Else
            Dim T2 As PointF = New PointF(TXoffset, T2y + TYoffset)
            T2String = $",R7,{T2.X},{T2.Y}"
        End If

        Dim TopLockString As String = T2String & T1String

        '************************Bottom Locks*********************
        'Need to look at if staements for choosing L and R
        'B1
        Dim B1String As String
        If B1y = 0 Then
            B1String = String.Empty
        ElseIf B1y > 19 Then 'Making sure the Left Side wont try and reach to far 
            Dim B1 As PointF = New PointF(ShearPanelHeight - TXoffset, B1y + Byoffset)
            B1String = $",R7,{B1.X},{B1.Y}"
        Else
            Dim B1 As PointF = New PointF(ShearPanelHeight - TXoffset, B1y + Byoffset)
            B1String = $",L7,{B1.X},{B1.Y}"
        End If

        'B2
        Dim B2String As String
        If B2y = 0 Then
            B2String = String.Empty
        ElseIf B2y < 19 Then 'Making sure the Right side will not colide the left side
            Dim B2 As PointF = New PointF(ShearPanelHeight - TXoffset, B2y + Byoffset)
            B2String = $",L7,{B2.X},{B2.Y}"
        Else
            Dim B2 As PointF = New PointF(ShearPanelHeight - TXoffset, B2y + Byoffset)
            B2String = $",R7,{B2.X},{B2.Y}"
        End If

        Dim BottomLocksString = B2String & B1String

        '*****************************Side Locks****************

        Dim SYoffset = 1.6875
        Dim Sxoffset = 0.5
        'S1
        Dim S1String As String
        If S1x = 0 Then
            S1String = String.Empty
        Else
            Dim S1 As PointF = New PointF(S1x + Sxoffset, SYoffset)
            S1String = $",L7,{S1.X},{S1.Y}"
        End If

        'S2
        Dim S2String As String
        If S2x = 0 Then
            S2String = String.Empty
        Else
            Dim S2 As PointF = New PointF(S2x + Sxoffset, SYoffset)
            S2String = $",L7,{S2.X},{S2.Y}"
        End If

        'S3
        Dim S3String As String
        If S3x = 0 Then
            S3String = String.Empty
        Else
            Dim S3 As PointF = New PointF(S3x + Sxoffset, SYoffset)
            S3String = $",L7,{S3.X},{S3.Y}"
        End If

        'S4
        Dim S4String As String
        If S4x = 0 Then
            S4String = String.Empty
        Else
            Dim S4 As PointF = New PointF(S4x + Sxoffset, SYoffset)
            S4String = $",L7,{S4.X},{S4.Y}"
        End If

        Dim SideLockString As String = S4String & S3String & S2String & S1String
        '***************************Double Male Locks*************************

        'DMS1
        Dim DMS1String As String
        If DMS1x = 0 Then
            DMS1String = String.Empty
        Else
            Dim DMS1 As PointF = New PointF(DMS1x + Sxoffset, ShearPanelWidth - SYoffset)
            DMS1String = $",R7,{DMS1.X},{DMS1.Y}"
        End If

        'DMS2
        Dim DMS2String As String
        If DMS2x = 0 Then
            DMS2String = String.Empty
        Else
            Dim DMS2 As PointF = New PointF(DMS2x + Sxoffset, ShearPanelWidth - SYoffset)
            DMS2String = $",R7,{DMS2.X},{DMS2.Y}"
        End If

        'DMS3
        Dim DMS3String As String
        If DMS3x = 0 Then
            DMS3String = String.Empty
        Else
            Dim DMS3 As PointF = New PointF(DMS3x + Sxoffset, ShearPanelWidth - SYoffset)
            DMS3String = $",R7,{DMS3.X},{DMS3.Y}"
        End If

        'DMS4
        Dim DMS4String As String
        If DMS4x = 0 Then
            DMS4String = String.Empty
        Else
            Dim DMS4 As PointF = New PointF(DMS4x + Sxoffset, ShearPanelWidth - SYoffset)
            DMS4String = $",R7,{DMS4.X},{DMS4.Y}"
        End If

        Dim LockString As String
        If DoubleMaleBox.Checked Then
            LockString = (TopLockString & BottomLocksString & S1String & S2String & S3String & S4String & DMS1String & DMS2String & DMS3String & DMS4String)
        Else
            LockString = (TopLockString & SideLockString & BottomLocksString)
        End If

        '*****************************************String Builing*******************************************************
        Dim AdjustmentConstants As String = $",Q,1,BL,{ShearPanelHeight},BW,{ShearPanelWidth},PL,{ShearPanelHeight - 1.125},PW,{ShearPanelWidth - 1.5625},GA,0,GL,1,LB,2,TB,1,FS,2,AS,2"
        'Ignore the lock text boxes if exterior is checked
        If Exterior.Checked Then
            QRString = (PartNumber & "-EXT-Wall" & AdjustmentConstants & NotchString)
        Else
            QRString = (PartNumber & "-INT-Wall" & AdjustmentConstants & LockString & NotchString)

        End If

        TextBox13.Text = QRString.ToString

        If ShearPanelWidth < 12.5 Then
            MessageBox.Show("QR Code not Generated" & vbCrLf & "The Roll Former is unable to form anything with a shear Width smaller than 12.5"". Check BW Value", "Warning")
        ElseIf ShearPanelHeight > 190.25 Then
            MessageBox.Show("QR Code not Generated" & vbCrLf & "The Roll Former is unable to feed any piece that is Longer than 16' (190.25""). Check BL Value", "Warning")
        ElseIf DEV.Checked Then 'DEV module to not save and write qr code
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

        ' Handle TextBox9 to TextBox12 within GroupBox2
        Dim groupBox As System.Windows.Forms.GroupBox = TryCast(Me.Controls("GroupBox2"), System.Windows.Forms.GroupBox)
        If groupBox IsNot Nothing Then
            For i As Integer = 9 To 12
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




End Class