Imports System.Drawing.Text
Imports DocumentFormat.OpenXml.Office2010.Word
Imports QRCoder

Public Class CeilingPanelForm
    Private defaultCeilingDiagram As Image
    Private interiorOutsideDiagram As Bitmap
    Private interiorCenterDiagram As Bitmap
    Private exteriorDiagram As Bitmap

    Public Sub New()
        InitializeComponent()
        defaultCeilingDiagram = PictureBox1.Image
        Using stream = GetType(CeilingPanelForm).Assembly.GetManifestResourceStream("QR_Code_Application.Images.CeilingInteriorOutside.png")
            Using source As Image = Image.FromStream(stream)
                interiorOutsideDiagram = New Bitmap(source)
            End Using
        End Using
        Using stream = GetType(CeilingPanelForm).Assembly.GetManifestResourceStream("QR_Code_Application.Images.CeilingInteriorCenter.png")
            Using source As Image = Image.FromStream(stream)
                interiorCenterDiagram = New Bitmap(source)
            End Using
        End Using
        Using stream = GetType(CeilingPanelForm).Assembly.GetManifestResourceStream("QR_Code_Application.Images.CeilingExterior.png")
            Using source As Image = Image.FromStream(stream)
                exteriorDiagram = New Bitmap(source)
            End Using
        End Using
        UpdateCeilingDiagram()
    End Sub

    Private Sub UpdateCeilingDiagram()
        ' CheckedChanged can fire while InitializeComponent is still creating controls.
        If interiorOutsideDiagram Is Nothing OrElse interiorCenterDiagram Is Nothing OrElse exteriorDiagram Is Nothing Then Return
        If EXT.Checked Then
            PictureBox1.Image = exteriorDiagram
        ElseIf INT.Checked AndAlso (OSMA.Checked OrElse OSFE.Checked) Then
            PictureBox1.Image = interiorOutsideDiagram
        ElseIf INT.Checked AndAlso CNT.Checked Then
            PictureBox1.Image = interiorCenterDiagram
        Else
            PictureBox1.Image = defaultCeilingDiagram
        End If
    End Sub

    Private Sub CeilingPanelForm_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        If interiorOutsideDiagram IsNot Nothing Then interiorOutsideDiagram.Dispose()
        If interiorCenterDiagram IsNot Nothing Then interiorCenterDiagram.Dispose()
        If exteriorDiagram IsNot Nothing Then exteriorDiagram.Dispose()
    End Sub

    'This is filtering the UI to hide and show relevant options, good luck decifering 
    Private Sub OSFE_CheckedChanged(sender As Object, e As EventArgs) Handles OSFE.CheckedChanged, OSMA.CheckedChanged, CNT.CheckedChanged, INT.CheckedChanged
        GroupBox1.Enabled = Not EXT.Checked And Not OSFE.Checked
        UpdateCeilingDiagram()
    End Sub

    Private Sub EXT_CheckedChanged(sender As Object, e As EventArgs) Handles EXT.CheckedChanged
        GroupBox1.Enabled = Not EXT.Checked
        UpdateCeilingDiagram()
    End Sub
    'Actually building the string
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        QRCode.Image = Nothing 'clear any old qr code in box
        Dim PartNumber As String
        Dim FoamDate As Date? = Nothing
        Dim isSoftPart As Boolean = SoftPartCheckBox.Checked
        PartNumber = InputBox("Please Metal Part Number:", "Input Required")
        If String.IsNullOrWhiteSpace(PartNumber) Then Return
        If isSoftPart Then
            Using dateDialog As New FoamDateDialog()
                If dateDialog.ShowDialog(Me) <> DialogResult.OK Then Return
                FoamDate = dateDialog.SelectedDate
            End Using
        End If
        PN.Text = PartNumber
        Dim NomPanelWidth As String = PanelWidth.Text
        Dim NomPanelLength As String = PanelLenght.Text
        Dim ShearPanelWidth As Double
        Dim ShearPanelLenght As Double
        PN.Visible = True
        DEVTEXT.Visible = True


        If Not Double.TryParse(NomPanelWidth, ShearPanelWidth) Then
            MessageBox.Show("Please enter a valid number for the Shear Width.")
            Return
        End If

        If Not Double.TryParse(NomPanelLength, ShearPanelLenght) Then
            MessageBox.Show("Please enter a valid number for the Shear Length.")
            Return
        End If

        If Thickness.Checked And INT.Checked Then
            ShearPanelLenght -= 2
            ShearPanelWidth -= 1
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

        Dim S1 As PointF
        Dim S1String As String

        If S1x = 0 Then
            S1String = String.Empty

        Else
            S1 = New PointF(S1x, YValue)
            S1String = $",L7,{S1.X},{S1.Y}"
        End If

        Dim S2 As PointF
        Dim S2String As String

        If S2x = 0 Then
            S2String = String.Empty
        Else
            S2 = New PointF(S2x, YValue)
            S2String = $",L7,{S2.X},{S2.Y}"
        End If

        Dim S3 As PointF
        Dim S3String As String

        If S3x = 0 Then
            S3String = String.Empty
        Else
            S3 = New PointF(S3x, YValue)
            S3String = $",L7,{S3.X},{S3.Y}"
        End If

        Dim S4 As PointF
        Dim S4String As String

        If S4x = 0 Then
            S4String = String.Empty
        Else
            S4 = New PointF(S4x, YValue)
            S4String = $",L7,{S4.X},{S4.Y}"
        End If

        Dim S5 As PointF
        Dim S5String As String

        If S5x = 0 Then
            S5String = String.Empty
        Else
            S5 = New PointF(S5x, YValue)
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
            Try
                Dim qrImage As Bitmap = QRGEN(QRString, PartNumber, FoamDate, isSoftPart)
                QRCode.Image = qrImage
            Catch ex As Exception
                MessageBox.Show("Unable to complete saving the QR code and Excel record." &
                                Environment.NewLine & "Some files may already have been saved." &
                                Environment.NewLine & ex.Message, "Save failed")
            End Try
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

        ' Inputs are spacings; blank/zero boxes remain omitted from the QR string.
        Dim position As Double = 0
        For i As Integer = 1 To 5
            Dim key As String = $"TextBox{i}"
            Dim spacing As Double = textBoxValues(key)
            If spacing <> 0 Then
                position += spacing
                textBoxValues(key) = position
            End If
        Next

        Return textBoxValues
    End Function

    Private Sub DEVTEXT_Click(sender As Object, e As EventArgs) Handles DEVTEXT.Click
        ' Create an instance of the QrStringEditorForm form
        Dim editTextForm As New QrStringEditorForm()

        ' Pass the data to the QrStringEditorForm form
        editTextForm.QRString = StringBox.Text
        editTextForm.PartNumber = PN.Text

        ' Show the QrStringEditorForm form
        editTextForm.ShowDialog()
    End Sub
End Class