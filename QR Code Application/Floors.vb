Imports QRCoder

Public Class Floors
    Private Sub OSFE_CheckedChanged(sender As Object, e As EventArgs) Handles OSFE.CheckedChanged
        If OSFE.Checked Then
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub EXT_CheckedChanged(sender As Object, e As EventArgs) Handles EXT.CheckedChanged
        If EXT.Checked Then
            GroupBox1.Enabled = False
            OSMA.Text = "Outside Male"
            OSFE.Text = "Outside Female"
            CNT.Text = "Center"
            L1.Text = "Panel Width"
            L2.Text = "Panel Length"

        Else
            GroupBox1.Enabled = True
            OSMA.Text = "Outside Male Splice"
            OSFE.Text = "Outside Female Splice"
            CNT.Text = "Center Splice"
            L1.Text = "Metal Shear Splice Width"
            L2.Text = "Metal Shear Length"
        End If
    End Sub

    Private Sub OSMA_CheckedChanged(sender As Object, e As EventArgs) Handles OSMA.CheckedChanged
        If EXT.Checked Then
            GroupBox1.Enabled = False
        Else
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub INT_CheckedChanged(sender As Object, e As EventArgs) Handles INT.CheckedChanged
        If OSFE.Checked Then
            GroupBox1.Enabled = False
        Else
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub CNT_CheckedChanged(sender As Object, e As EventArgs) Handles CNT.CheckedChanged
        If EXT.Checked Then
            GroupBox1.Enabled = False
        Else
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        QRCode.Image = Nothing 'clear any old qr code in box
        Dim PartNumber As String
        PartNumber = InputBox("Please Metal Part Number:", "Input Required")
        Dim NomPanelWidth As String = PanelWidth.Text
        Dim NomPanelLength As String = PanelLenght.Text
        Dim ShearPanelWidth As Double
        Dim ShearPanelLenght As Double

        ' Try to convert NomPanelWidth to a Double
        If Double.TryParse(NomPanelWidth, ShearPanelWidth) Then
            ' Conversion successful, now add 1.53125 to ShearPanelWidth
            If EXT.Checked Then 'If EXT checked
                If OSFE.Checked Or OSMA.Checked Then 'if Outside panel
                    ShearPanelWidth += 0.40625
                Else 'if Center Panel
                    ShearPanelWidth += 1.53125
                End If
                'This is adding nothing becuase for int floors We are using the Shear size instead of panel size because of the splicing 
            Else 'If INT checked
                If OSFE.Checked Or OSMA.Checked Then 'if Outside panel
                    ShearPanelWidth -= 0
                Else 'if Center Panel
                    ShearPanelWidth += 0
                End If
            End If
        Else
            ' Conversion failed, show an error message
            MessageBox.Show("Please enter a valid number for the panel Width.")
            Return
        End If

        ' Try to convert NomPanelLength to a Double
        If Double.TryParse(NomPanelLength, ShearPanelLenght) Then
            ' Conversion successful, now add 1.53125 to ShearPanelWidth
            If EXT.Checked Then
                ShearPanelLenght -= 0.6875
            Else 'If INT checked Still using shear size for INT so no offset 
                ShearPanelLenght -= 0
            End If
        Else
            ' Conversion failed, show an error message
            MessageBox.Show("Please enter a valid number for the panel Length.")
            Return
        End If

        '*******************************************Exterior Corner Notches*******************************************************
        Dim EXTXoffset As Double = 0.34375
        Dim EXTYoffSet As Double = 0.1875

        Dim CN1 As PointF
        Dim CN1String As String
        Dim CN2 As PointF
        Dim CN2String As String
        Dim CN3 As PointF
        Dim CN3String As String
        Dim CN4 As PointF
        Dim CN4String As String

        'Origin
        CN1 = New PointF(0 - EXTXoffset, EXTYoffSet)
        CN1String = $",L2,{CN1.X},{CN1.Y}"

        'Top Leading edge
        If CNT.Checked Then
            CN2 = New PointF(0 - EXTXoffset, ShearPanelWidth - EXTYoffSet)
            CN2String = $",R2,{CN2.X},{CN2.Y}"
        Else 'If OS is checked
            CN2 = New PointF(0 - EXTXoffset, ShearPanelWidth + EXTXoffset)
            CN2String = $",R2,{CN2.X},{CN2.Y}"
        End If


        'Top Trailing Edge
        If CNT.Checked Then
            CN3 = New PointF(ShearPanelLenght + EXTXoffset, ShearPanelWidth - EXTYoffSet)
            CN3String = $",R2,{CN3.X},{CN3.Y}"
        Else
            CN3 = New PointF(ShearPanelLenght + EXTXoffset, ShearPanelWidth + EXTXoffset)
            CN3String = $",R2,{CN3.X},{CN3.Y}"
        End If


        'Bottom Traing Edge
        CN4 = New PointF(ShearPanelLenght + EXTXoffset, EXTYoffSet)
        CN4String = $",L2,{CN4.X},{CN4.Y}"

        'Exterior Notch String
        Dim EXTCornerNotchString As String
        If CNT.Checked Or OSMA.Checked Then
            EXTCornerNotchString = (CN1String & CN2String & CN3String & CN4String)
        Else
            EXTCornerNotchString = (CN4String & CN3String & CN2String & CN1String)
        End If

        '******************************************************INT Corner Notches*************************************************
        Dim Xoffset As Double = 0.062
        Dim Yoffset As Double = 0.162

        Dim INTCN1 As PointF
        Dim INTCN1String As String
        Dim INTCN2 As PointF
        Dim INTCN2String As String
        Dim INTCN3 As PointF
        Dim INTCN3String As String
        Dim INTCN4 As PointF
        Dim INTCN4String As String

        'Origin
        INTCN1 = New PointF(0 - Xoffset, Yoffset)
        INTCN1String = $",L1,{INTCN1.X},{INTCN1.Y}"

        'Top Leading Edge
        If CNT.Checked Then
            INTCN2 = New PointF(0 - Xoffset, ShearPanelWidth - Yoffset)
            INTCN2String = $",R1,{INTCN2.X},{INTCN2.Y}"
        Else 'OS Checked
            INTCN2String = String.Empty
        End If

        'Top Trailing Edge
        If CNT.Checked Then
            INTCN3 = New PointF(ShearPanelLenght + Xoffset, ShearPanelWidth - Yoffset)
            INTCN3String = $",R1.{INTCN3.X},{INTCN3.Y}"
        Else 'OS Checked 
            INTCN3String = String.Empty
        End If

        'Bottom Trailing Edge
        INTCN4 = New PointF(ShearPanelLenght + Xoffset, Yoffset)
        INTCN4String = $",L1,{INTCN4.X},{INTCN4.Y}"

        Dim INTCornerNotchString As String
        Dim QRString As String

        If CNT.Checked Then
            INTCornerNotchString = (INTCN4String & INTCN3String & INTCN2String & INTCN1String)
        Else 'Outside checked
            INTCornerNotchString = (INTCN4String & INTCN1String)
        End If



        '******************************************************Side Lock Holes*****************************************************************

        'Function to interate through text boxes and convert strings into doubles
        Dim convertedValues As Dictionary(Of String, Double) = ConvertTextBoxesToDoubles()

        Dim S1x As Double = convertedValues("TextBox1")
        Dim S2x As Double = convertedValues("TextBox2")
        Dim S3x As Double = convertedValues("TextBox3")
        Dim S4x As Double = convertedValues("TextBox4")
        Dim S5x As Double = convertedValues("TextBox5")
        Dim SideLockString As String

        Dim YValue As Double = 1.3125
        Dim SXoffset As Double = 3.21875

        Dim S1 As PointF
        Dim S1String As String

        If S1x = 0 Then
            S1String = String.Empty
        Else
            S1 = New PointF(S1x - SXoffset, YValue)
            S1String = $",L5,{S1.X},{S1.Y}"
        End If

        Dim S2 As PointF
        Dim S2String As String

        If S2x = 0 Then
            S2String = String.Empty
        Else
            S2 = New PointF(S2x - SXoffset, YValue)
            S2String = $",L5,{S2.X},{S2.Y}"
        End If

        Dim S3 As PointF
        Dim S3String As String

        If S3x = 0 Then
            S3String = String.Empty
        Else
            S3 = New PointF(S3x - SXoffset, YValue)
            S3String = $",L5,{S3.X},{S3.Y}"
        End If

        Dim S4 As PointF
        Dim S4String As String

        If S4x = 0 Then
            S4String = String.Empty
        Else
            S4 = New PointF(S4x - SXoffset, YValue)
            S4String = $",L5,{S4.X},{S4.Y}"
        End If

        Dim S5 As PointF
        Dim S5String As String

        If S5x = 0 Then
            S5String = String.Empty
        Else
            S5 = New PointF(S5x - SXoffset, YValue)
            S5String = $",L5,{S5.X},{S5.Y}"
        End If

        SideLockString = (S1String & S2String & S3String & S4String & S5String)


        Dim Constants As String
        If INT.Checked Then
            If CNT.Checked Then
                Constants = $",Q,1,BL,{ShearPanelLenght},BW,{ShearPanelWidth},PL,{ShearPanelLenght - 0.3125},PW,{ShearPanelWidth - 0.78125},GA,1,GL,0,LB,0,TB,0,FS,0,AS,0"
            Else 'OS MA or FE
                Constants = $",Q,1,BL,{ShearPanelLenght},BW,{ShearPanelWidth},PL,{ShearPanelLenght - 0.3125},PW,{ShearPanelWidth - 0.46875},GA,1,GL,0,LB,0,TB,0,FS,0,AS,1"
            End If

        ElseIf EXT.Checked Then
            If CNT.Checked Then
                Constants = $",Q,1,BL,{ShearPanelLenght},BW,{ShearPanelWidth},PL,{ShearPanelLenght - 0.5},PW,{ShearPanelWidth - 1.5625},GA,0,GL,1,LB,1,TB,1,FS,2,AS,2"
            Else 'OS MA or FE
                Constants = $",Q,1,BL,{ShearPanelLenght},BW,{ShearPanelWidth},PL,{ShearPanelLenght - 0.5},PW,{ShearPanelWidth - 1.03125},GA,0,GL,1,LB,1,TB,1,FS,2,AS,0"
            End If


        End If

        If INT.Checked Then
            QRString = (PartNumber & "-INT-Floor" & Constants & SideLockString & INTCornerNotchString)
        Else
            QRString = (PartNumber & "-EXT-Floors" & Constants & EXTCornerNotchString)
        End If

        StringBox.Text = (QRString)

        If ShearPanelWidth < 12.5 Then
            MessageBox.Show("QR Code not Generated" & vbCrLf & "The Roll Former is unable to form anything with a shear Width smaller than 12.5"". Check BW Value", "Warning")
        ElseIf ShearPanelLenght > 190.25 Then
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

        ' Handle TextBox1 to TextBox5 within GroupBox1
        Dim groupBox As System.Windows.Forms.GroupBox = TryCast(Me.Controls("GroupBox1"), System.Windows.Forms.GroupBox)
        If groupBox IsNot Nothing Then
            For i As Integer = 1 To 5
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