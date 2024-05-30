<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ceilings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ceilings))
        Label2 = New Label()
        Label1 = New Label()
        PanelWidth = New TextBox()
        PanelLenght = New TextBox()
        PanelType = New GroupBox()
        CNT = New RadioButton()
        OSFE = New RadioButton()
        OSMA = New RadioButton()
        MetalType = New GroupBox()
        EXT = New RadioButton()
        INT = New RadioButton()
        S1 = New Label()
        S2 = New Label()
        S3 = New Label()
        S4 = New Label()
        S5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        StringBox = New TextBox()
        PictureBox1 = New PictureBox()
        QRCode = New PictureBox()
        DEV = New CheckBox()
        Label3 = New Label()
        Part = New CheckBox()
        Label4 = New Label()
        SPL = New CheckBox()
        SPLWidth = New TextBox()
        SPLLength = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Thickness = New CheckBox()
        DEVTEXT = New Button()
        PN = New Label()
        PanelType.SuspendLayout()
        MetalType.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(QRCode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(138, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 15)
        Label2.TabIndex = 5
        Label2.Text = "Panel Length"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 4
        Label1.Text = "Panel Width "
        ' 
        ' PanelWidth
        ' 
        PanelWidth.Location = New Point(12, 36)
        PanelWidth.Name = "PanelWidth"
        PanelWidth.Size = New Size(100, 23)
        PanelWidth.TabIndex = 6
        ' 
        ' PanelLenght
        ' 
        PanelLenght.Location = New Point(138, 36)
        PanelLenght.Name = "PanelLenght"
        PanelLenght.Size = New Size(100, 23)
        PanelLenght.TabIndex = 7
        ' 
        ' PanelType
        ' 
        PanelType.Controls.Add(CNT)
        PanelType.Controls.Add(OSFE)
        PanelType.Controls.Add(OSMA)
        PanelType.Location = New Point(283, 12)
        PanelType.Name = "PanelType"
        PanelType.Size = New Size(200, 100)
        PanelType.TabIndex = 8
        PanelType.TabStop = False
        PanelType.Text = "Panel Type"
        ' 
        ' CNT
        ' 
        CNT.AutoSize = True
        CNT.Location = New Point(8, 69)
        CNT.Name = "CNT"
        CNT.Size = New Size(60, 19)
        CNT.TabIndex = 2
        CNT.Text = "Center"
        CNT.UseVisualStyleBackColor = True
        ' 
        ' OSFE
        ' 
        OSFE.AutoSize = True
        OSFE.Location = New Point(8, 44)
        OSFE.Name = "OSFE"
        OSFE.Size = New Size(107, 19)
        OSFE.TabIndex = 1
        OSFE.Text = "Outside Female"
        OSFE.UseVisualStyleBackColor = True
        ' 
        ' OSMA
        ' 
        OSMA.AutoSize = True
        OSMA.Checked = True
        OSMA.Location = New Point(8, 19)
        OSMA.Name = "OSMA"
        OSMA.Size = New Size(95, 19)
        OSMA.TabIndex = 0
        OSMA.TabStop = True
        OSMA.Text = "Outside Male"
        OSMA.UseVisualStyleBackColor = True
        ' 
        ' MetalType
        ' 
        MetalType.Controls.Add(EXT)
        MetalType.Controls.Add(INT)
        MetalType.Location = New Point(499, 12)
        MetalType.Name = "MetalType"
        MetalType.Size = New Size(90, 74)
        MetalType.TabIndex = 9
        MetalType.TabStop = False
        MetalType.Text = "Metal Type"
        ' 
        ' EXT
        ' 
        EXT.AutoSize = True
        EXT.Location = New Point(6, 44)
        EXT.Name = "EXT"
        EXT.Size = New Size(65, 19)
        EXT.TabIndex = 1
        EXT.Text = "Exterior"
        EXT.UseVisualStyleBackColor = True
        ' 
        ' INT
        ' 
        INT.AutoSize = True
        INT.Checked = True
        INT.Location = New Point(6, 19)
        INT.Name = "INT"
        INT.Size = New Size(63, 19)
        INT.TabIndex = 0
        INT.TabStop = True
        INT.Text = "Interior"
        INT.UseVisualStyleBackColor = True
        ' 
        ' S1
        ' 
        S1.AutoSize = True
        S1.Location = New Point(19, 26)
        S1.Name = "S1"
        S1.Size = New Size(19, 15)
        S1.TabIndex = 10
        S1.Text = "S1"
        ' 
        ' S2
        ' 
        S2.AutoSize = True
        S2.Location = New Point(19, 57)
        S2.Name = "S2"
        S2.Size = New Size(19, 15)
        S2.TabIndex = 11
        S2.Text = "S2"
        ' 
        ' S3
        ' 
        S3.AutoSize = True
        S3.Location = New Point(19, 86)
        S3.Name = "S3"
        S3.Size = New Size(19, 15)
        S3.TabIndex = 12
        S3.Text = "S3"
        ' 
        ' S4
        ' 
        S4.AutoSize = True
        S4.Location = New Point(19, 115)
        S4.Name = "S4"
        S4.Size = New Size(19, 15)
        S4.TabIndex = 13
        S4.Text = "S4"
        ' 
        ' S5
        ' 
        S5.AutoSize = True
        S5.Location = New Point(19, 144)
        S5.Name = "S5"
        S5.Size = New Size(19, 15)
        S5.TabIndex = 14
        S5.Text = "S5"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(44, 23)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 15
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(44, 52)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 16
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(44, 81)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 17
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(44, 110)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 18
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(44, 139)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 19
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(S1)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(S2)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(S3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(S4)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(S5)
        GroupBox1.Location = New Point(12, 133)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(175, 179)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "Side Lock Holes"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(196, 292)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 46)
        Button1.TabIndex = 21
        Button1.Text = "Generate String"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' StringBox
        ' 
        StringBox.Location = New Point(12, 357)
        StringBox.Multiline = True
        StringBox.Name = "StringBox"
        StringBox.Size = New Size(374, 110)
        StringBox.TabIndex = 22
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(429, 133)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(617, 425)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' QRCode
        ' 
        QRCode.Location = New Point(241, 133)
        QRCode.Name = "QRCode"
        QRCode.Size = New Size(157, 142)
        QRCode.SizeMode = PictureBoxSizeMode.Zoom
        QRCode.TabIndex = 24
        QRCode.TabStop = False
        ' 
        ' DEV
        ' 
        DEV.AutoSize = True
        DEV.Location = New Point(345, 320)
        DEV.Name = "DEV"
        DEV.Size = New Size(70, 19)
        DEV.TabIndex = 25
        DEV.Text = "DEV Test"
        DEV.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 45)
        Label3.TabIndex = 26
        Label3.Text = "It is ok to leave lock locations " & vbCrLf & "empty, if the textbox is empty " & vbCrLf & "the program will ignore it "
        ' 
        ' Part
        ' 
        Part.AutoSize = True
        Part.Location = New Point(596, 17)
        Part.Name = "Part"
        Part.RightToLeft = RightToLeft.Yes
        Part.Size = New Size(71, 19)
        Part.TabIndex = 27
        Part.Text = "Partition"
        Part.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(688, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(320, 45)
        Label4.TabIndex = 28
        Label4.Text = "Note: For partition Ceilings check this box " & vbCrLf & "and make a Outside Male or Female the partition lenght" & vbCrLf & "Ex. ( STD 4' Partition has a 2' Male side and a 2' Female side)"
        ' 
        ' SPL
        ' 
        SPL.AutoSize = True
        SPL.Location = New Point(610, 78)
        SPL.Name = "SPL"
        SPL.RightToLeft = RightToLeft.Yes
        SPL.Size = New Size(57, 19)
        SPL.TabIndex = 29
        SPL.Text = "Splice"
        SPL.UseVisualStyleBackColor = True
        ' 
        ' SPLWidth
        ' 
        SPLWidth.Enabled = False
        SPLWidth.Location = New Point(700, 86)
        SPLWidth.Name = "SPLWidth"
        SPLWidth.Size = New Size(100, 23)
        SPLWidth.TabIndex = 30
        ' 
        ' SPLLength
        ' 
        SPLLength.Enabled = False
        SPLLength.Location = New Point(847, 86)
        SPLLength.Name = "SPLLength"
        SPLLength.Size = New Size(100, 23)
        SPLLength.TabIndex = 31
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(700, 70)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 15)
        Label5.TabIndex = 32
        Label5.Text = "Shear Width"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(847, 68)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 15)
        Label6.TabIndex = 33
        Label6.Text = "Shear Length "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(688, 112)
        Label7.Name = "Label7"
        Label7.Size = New Size(199, 15)
        Label7.TabIndex = 34
        Label7.Text = "Note: Horizontal Splices on INT Only"
        ' 
        ' Thickness
        ' 
        Thickness.AutoSize = True
        Thickness.Location = New Point(505, 92)
        Thickness.Name = "Thickness"
        Thickness.Size = New Size(91, 19)
        Thickness.TabIndex = 35
        Thickness.Text = "5"" Thickness"
        Thickness.UseVisualStyleBackColor = True
        ' 
        ' DEVTEXT
        ' 
        DEVTEXT.Location = New Point(291, 473)
        DEVTEXT.Name = "DEVTEXT"
        DEVTEXT.Size = New Size(95, 38)
        DEVTEXT.TabIndex = 36
        DEVTEXT.Text = "Edit String"
        DEVTEXT.UseVisualStyleBackColor = True
        DEVTEXT.Visible = False
        ' 
        ' PN
        ' 
        PN.AutoSize = True
        PN.Location = New Point(12, 339)
        PN.Name = "PN"
        PN.Size = New Size(41, 15)
        PN.TabIndex = 38
        PN.Text = "Label8"
        PN.Visible = False
        ' 
        ' Ceilings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1058, 563)
        Controls.Add(PN)
        Controls.Add(DEVTEXT)
        Controls.Add(Thickness)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(SPLLength)
        Controls.Add(SPLWidth)
        Controls.Add(SPL)
        Controls.Add(Label4)
        Controls.Add(Part)
        Controls.Add(Label3)
        Controls.Add(DEV)
        Controls.Add(QRCode)
        Controls.Add(PictureBox1)
        Controls.Add(StringBox)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Controls.Add(MetalType)
        Controls.Add(PanelType)
        Controls.Add(PanelLenght)
        Controls.Add(PanelWidth)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Ceilings"
        Text = "Ceilings"
        PanelType.ResumeLayout(False)
        PanelType.PerformLayout()
        MetalType.ResumeLayout(False)
        MetalType.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(QRCode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelWidth As TextBox
    Friend WithEvents PanelLenght As TextBox
    Friend WithEvents PanelType As GroupBox
    Friend WithEvents CNT As RadioButton
    Friend WithEvents OSFE As RadioButton
    Friend WithEvents OSMA As RadioButton
    Friend WithEvents MetalType As GroupBox
    Friend WithEvents EXT As RadioButton
    Friend WithEvents INT As RadioButton
    Friend WithEvents S1 As Label
    Friend WithEvents S2 As Label
    Friend WithEvents S3 As Label
    Friend WithEvents S4 As Label
    Friend WithEvents S5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents StringBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents QRCode As PictureBox
    Friend WithEvents DEV As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Part As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SPL As CheckBox
    Friend WithEvents SPLWidth As TextBox
    Friend WithEvents SPLLength As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Thickness As CheckBox
    Friend WithEvents DEVTEXT As Button
    Friend WithEvents PN As Label
End Class
