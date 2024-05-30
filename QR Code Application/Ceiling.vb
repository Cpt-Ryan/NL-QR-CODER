Imports System.Drawing.Text
Imports DocumentFormat.OpenXml.Office2010.Word
Imports QRCoder

Public Class Ceilings
    'This is filtering the UI to hide and show relevant options, good luck decifering 
    Private Sub OSFE_CheckedChanged(sender As Object, e As EventArgs) Handles OSFE.CheckedChanged, OSMA.CheckedChanged, CNT.CheckedChanged, INT.CheckedChanged
        GroupBox1.Enabled = Not EXT.Checked And Not OSFE.Checked
    End Sub

    Private Sub EXT_CheckedChanged(sender As Object, e As EventArgs) Handles EXT.CheckedChanged
        GroupBox1.Enabled = Not EXT.Checked
    End Sub
    Private Sub SPL_CheckedChanged(sender As Object, e As EventArgs) Handles SPL.CheckedChanged
        If SPL.Checked Then
            SPLWidth.Enabled = True
            SPLLength.Enabled = True
            Part.Checked = False
            PanelWidth.Enabled = False
            PanelLenght.Enabled = False
            PanelWidth.Text = 24
            PanelLenght.Text = 72
            Thickness.Checked = False
            Thickness.Enabled = False
        Else
            SPLWidth.Enabled = False
            SPLLength.Enabled = False
            PanelWidth.Enabled = True
            PanelLenght.Enabled = True
            PanelWidth.Text = ""
            PanelLenght.Text = ""
            Thickness.Enabled = True
        End If
    End Sub

    Private Sub Part_CheckedChanged(sender As Object, e As EventArgs) Handles Part.CheckedChanged
        If Part.Checked Then
            SPL.Checked = False
            CNT.Enabled = False
        Else
            CNT.Enabled = True
        End If
    End Sub
    'Actually building the string
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        QRCode.Image = Nothing 'clear any old qr code in box
        Dim PartNumber As String
        PartNumber = InputBox("Please Metal Part Number:", "Input Required")
        PN.Text = PartNumber
        Dim NomPanelWidth As String = PanelWidth.Text
        Dim NomPanelLength As String = PanelLenght.Text
        Dim ShearPanelWidth As Double
        Dim ShearPanelLenght As Double
        PN.Visible = True
        DEVTEXT.Visible = True


        ' Try to convert NomPanelWidth to a Double
        If Double.TryParse(NomPanelWidth, ShearPanelWidth) Then
            ' Conversion successful, now add 1.53125 to ShearPanelWidth
            If EXT.Checked Then 'If EXT checked
                If OSFE.Checked Or OSMA.Checked Then 'if Outside panel
                    ShearPanelWidth += 0.40625
                Else 'if Center Panel
                    ShearPanelWidth += 1.53125
                End If

            Else 'If INT checked
                If OSFE.Checked Or OSMA.Checked Then 'if Outside panel
                    ShearPanelWidth -= 2.4375
                Else 'if Center Panel
                    ShearPanelWidth += 1.53125
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
            Else 'If INT checked
                ShearPanelLenght -= 6.4375
            End If
        Else
            ' Conversion failed, show an error message
            MessageBox.Show("Please enter a valid number for the panel Length.")
            Return
        End If

        If Part.Checked Then
            If INT.Checked Then
                ShearPanelWidth += 2
            End If
        End If

        If Thickness.Checked And INT.Checked Then
            ShearPanelLenght -= 2
            ShearPanelWidth -= 1
        End If

        Dim shearsplWidth As String = SPLWidth.Text
        Dim shearsplLength As String = SPLLength.Text
        Dim SpliceWidth As Double
        Dim SpliceLength As Double

        If SPL.Checked Then
            ' Attempt to convert the text box values to double
            If Double.TryParse(shearsplWidth, SpliceWidth) AndAlso Double.TryParse(shearsplLength, SpliceLength) Then
                ShearPanelWidth = SpliceWidth
                ShearPanelLenght = SpliceLength
            Else
                ' Handle the case where conversion fails, e.g., show a message to the user
                MessageBox.Show("Please enter valid numeric values for SPL Width and Length.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
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
            EXTCornerNotchString = (CN4String & CN3String & CN2String & CN1String)
        Else
            EXTCornerNotchString = (CN1String & CN2String & CN3String & CN4String)

        End If



        '******************************************************INT Corner Notches*************************************************
        Dim INTXoffset As Double = 1
        Dim INTYoffset As Double = 0.375

        Dim INTCN1 As PointF
        Dim INTCN1String As String
        Dim INTCN2 As PointF
        Dim INTCN2String As String
        Dim INTCN3 As PointF
        Dim INTCN3String As String
        Dim INTCN4 As PointF
        Dim INTCN4String As String

        'Origin
        INTCN1 = New PointF(INTXoffset, INTYoffset)
        INTCN1String = $",L9,{INTCN1.X},{INTCN1.Y}"

        'Top Leading Edge
        If CNT.Checked Then
            INTCN2 = New PointF(INTXoffset, ShearPanelWidth - INTYoffset)
            INTCN2String = $",R8,{INTCN2.X},{INTCN2.Y}"
        Else 'Panel is Outisde
            INTCN2String = String.Empty
        End If

        'Top Trailing Edge
        If CNT.Checked Then
            INTCN3 = New PointF(ShearPanelLenght - INTXoffset, ShearPanelWidth - INTYoffset)
            INTCN3String = $",R9,{INTCN3.X},{INTCN3.Y}"
        Else 'Panel is Outside
            INTCN3String = String.Empty
        End If

        'Bottom Trailing Edge
        INTCN4 = New PointF(ShearPanelLenght - INTXoffset, INTYoffset)
        INTCN4String = $",L8,{INTCN4.X},{INTCN4.Y}"

        Dim INTCornerNotchString As String
        If OSMA.Checked Then
            INTCornerNotchString = (INTCN1String & INTCN2String & INTCN3String & INTCN4String)
        ElseIf OSFE.Checked Then
            INTCornerNotchString = (INTCN4String & INTCN2String & INTCN3String & INTCN1String)
        Else 'Center
            INTCornerNotchString = (INTCN1String & INTCN2String & INTCN3String & INTCN4String)
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

        Dim YValue As Double = 1.6875
        Dim SXoffset As Double = 3.21875

        If Thickness.Checked Then
            SXoffset = 4.21875
        End If

        Dim S1 As PointF
        Dim S1String As String

        If S1x = 0 Then
            S1String = String.Empty

        Else
            S1 = New PointF(S1x - SXoffset, YValue)
            S1String = $",L7,{S1.X},{S1.Y}"
        End If

        Dim S2 As PointF
        Dim S2String As String

        If S2x = 0 Then
            S2String = String.Empty
        Else
            S2 = New PointF(S2x - SXoffset, YValue)
            S2String = $",L7,{S2.X},{S2.Y}"
        End If

        Dim S3 As PointF
        Dim S3String As String

        If S3x = 0 Then
            S3String = String.Empty
        Else
            S3 = New PointF(S3x - SXoffset, YValue)
            S3String = $",L7,{S3.X},{S3.Y}"
        End If

        Dim S4 As PointF
        Dim S4String As String

        If S4x = 0 Then
            S4String = String.Empty
        Else
            S4 = New PointF(S4x - SXoffset, YValue)
            S4String = $",L7,{S4.X},{S4.Y}"
        End If

        Dim S5 As PointF
        Dim S5String As String

        If S5x = 0 Then
            S5String = String.Empty
        Else
            S5 = New PointF(S5x - SXoffset, YValue)
            S5String = $",L7,{S5.X},{S5.Y}"
        End If

        '****************************************************Ghost Punches*******************************************************************
        'There is a current problem with the 45degree punch for outside ceilings, instead of fixing it it was opted to do this fix instead. 
        'under normal QR code string the Right Side conerpunches Ram them selves into the part. To fix this we give it Ghost holes off the part
        'so that it tries to punch the Ghost Holes first then punches the corners without Raming the Sheetmetal Part

        Dim LeadGhost As PointF
        Dim LeadGhostString As String
        LeadGhost = New PointF(-1, ShearPanelWidth)
        LeadGhostString = $",R7,{LeadGhost.X},{LeadGhost.Y}"

        Dim TrailGhost As PointF
        Dim TrailGhostString
        TrailGhost = New PointF(ShearPanelLenght + 1, ShearPanelWidth)
        TrailGhostString = $",R7,{TrailGhost.X},{TrailGhost.Y}"

        Dim GhostString As String = (LeadGhostString & TrailGhostString)

        'SideLockString = (S1String & S2String & S3String & S4String & S5String)
        SideLockString = (S5String & S4String & S3String & S2String & S1String)

        Dim Type As String

        If OSMA.Checked Then
            Type = "-OSMA"
        ElseIf OSFE.Checked Then
            Type = "-OSFE"
        Else 'CNT checked
            Type = "-CNT"
        End If

        If Thickness.Checked Then
            Type = "-5""" & Type
        End If


        Dim Constants As String
        If INT.Checked Then
            If CNT.Checked Then 'Code is for INT Center
                Constants = $",Q,1,BL,{ShearPanelLenght},BW,{ShearPanelWidth},PL,{ShearPanelLenght - 0.3125},PW,{ShearPanelWidth - 1.5625},GA,0,GL,0,LB,0,TB,0,FS,2,AS,2"
            Else 'OS Panel and INT checked
                If OSFE.Checked Then 'OSFE INT
                    Constants = $",Q,1,BL,{ShearPanelLenght},BW,{ShearPanelWidth},PL,{ShearPanelLenght - 0.3125},PW,{ShearPanelWidth - 0.96875},GA,0,GL,0,LB,0,TB,0,FS,2,AS,1{GhostString}"
                Else 'OSMA INT
                    Constants = $",Q,1,BL,{ShearPanelLenght},BW,{ShearPanelWidth},PL,{ShearPanelLenght - 0.3125},PW,{ShearPanelWidth - 0.96875},GA,0,GL,0,LB,0,TB,0,FS,2,AS,1{GhostString}"
                End If

            End If
        Else 'EXT Checked
            If CNT.Checked Then 'Code is for EXT CNT
                Constants = $",Q,1,BL,{ShearPanelLenght},BW,{ShearPanelWidth},PL,{ShearPanelLenght - 0.5},PW,{ShearPanelWidth - 1.5625},GA,0,GL,1,LB,1,TB,1,FS,2,AS,2"
            Else 'EXT OS Panel
                Constants = $",Q,1,BL,{ShearPanelLenght},BW,{ShearPanelWidth},PL,{ShearPanelLenght - 0.5},PW,{ShearPanelWidth - 1.03125},GA,0,GL,1,LB,1,TB,1,FS,2,AS,0"
            End If

        End If



        Dim QRString As String

        If INT.Checked Then
            QRString = (PartNumber & Type & "-INT-Ceiling" & Constants & SideLockString & INTCornerNotchString)
        Else 'EXT
            QRString = (PartNumber & Type & "-EXT-Ceiling" & Constants & EXTCornerNotchString)
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