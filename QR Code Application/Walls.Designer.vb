<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Walls
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Walls))
        FormedWidth = New TextBox()
        FormedHeight = New TextBox()
        FormedWidthLabel = New Label()
        FormedHeightLabel = New Label()
        CornerXOverlap = New TextBox()
        CornerYOverlap = New TextBox()
        CornerXOverlapLabel = New Label()
        CornerYOverlapLabel = New Label()
        WallWidth = New TextBox()
        Label1 = New Label()
        WallHeight = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        FBCB = New CheckBox()
        GroupBox1 = New GroupBox()
        Exterior = New RadioButton()
        Interior = New RadioButton()
        Label9 = New Label()
        S1 = New Label()
        S2 = New Label()
        S3 = New Label()
        S4 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        DoubleMaleBox = New CheckBox()
        TextBox9 = New TextBox()
        DMS1 = New Label()
        DMS2 = New Label()
        DMS3 = New Label()
        DMS4 = New Label()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        TextBox12 = New TextBox()
        GroupBox2 = New GroupBox()
        Button1 = New Button()
        QRStringlabel = New Label()
        TextBox13 = New TextBox()
        PictureBox1 = New PictureBox()
        QRCode = New PictureBox()
        ToolTip1 = New ToolTip(components)
        SoftPartCheckBox = New CheckBox()
        DEV = New CheckBox()
        Button2 = New Button()
        Label10 = New Label()
        Thickness = New CheckBox()
        PN = New Label()
        DEVTEXT = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(QRCode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FormedWidth
        ' 
        FormedWidth.Location = New Point(30, 127)
        FormedWidth.Margin = New Padding(3, 4, 3, 4)
        FormedWidth.Name = "FormedWidth"
        FormedWidth.Size = New Size(114, 27)
        FormedWidth.TabIndex = 49
        ' 
        ' FormedHeight
        ' 
        FormedHeight.Location = New Point(177, 127)
        FormedHeight.Margin = New Padding(3, 4, 3, 4)
        FormedHeight.Name = "FormedHeight"
        FormedHeight.Size = New Size(114, 27)
        FormedHeight.TabIndex = 51
        ' 
        ' FormedWidthLabel
        ' 
        FormedWidthLabel.AutoSize = True
        FormedWidthLabel.Location = New Point(33, 100)
        FormedWidthLabel.Name = "FormedWidthLabel"
        FormedWidthLabel.Size = New Size(140, 20)
        FormedWidthLabel.TabIndex = 48
        FormedWidthLabel.Text = "Formed Width (PW)"
        ' 
        ' FormedHeightLabel
        ' 
        FormedHeightLabel.AutoSize = True
        FormedHeightLabel.Location = New Point(177, 100)
        FormedHeightLabel.Name = "FormedHeightLabel"
        FormedHeightLabel.Size = New Size(138, 20)
        FormedHeightLabel.TabIndex = 50
        FormedHeightLabel.Text = "Formed Height (PL)"
        ' 
        ' CornerXOverlap
        ' 
        CornerXOverlap.Location = New Point(594, 63)
        CornerXOverlap.Margin = New Padding(3, 4, 3, 4)
        CornerXOverlap.Name = "CornerXOverlap"
        CornerXOverlap.Size = New Size(114, 27)
        CornerXOverlap.TabIndex = 53
        CornerXOverlap.Text = "0.59375"
        ' 
        ' CornerYOverlap
        ' 
        CornerYOverlap.Location = New Point(594, 127)
        CornerYOverlap.Margin = New Padding(3, 4, 3, 4)
        CornerYOverlap.Name = "CornerYOverlap"
        CornerYOverlap.Size = New Size(114, 27)
        CornerYOverlap.TabIndex = 55
        CornerYOverlap.Text = "0.8125"
        ' 
        ' CornerXOverlapLabel
        ' 
        CornerXOverlapLabel.AutoSize = True
        CornerXOverlapLabel.Location = New Point(594, 32)
        CornerXOverlapLabel.Name = "CornerXOverlapLabel"
        CornerXOverlapLabel.Size = New Size(112, 20)
        CornerXOverlapLabel.TabIndex = 52
        CornerXOverlapLabel.Text = "Corner Notch-X"
        ' 
        ' CornerYOverlapLabel
        ' 
        CornerYOverlapLabel.AutoSize = True
        CornerYOverlapLabel.Location = New Point(594, 100)
        CornerYOverlapLabel.Name = "CornerYOverlapLabel"
        CornerYOverlapLabel.Size = New Size(111, 20)
        CornerYOverlapLabel.TabIndex = 54
        CornerYOverlapLabel.Text = "Corner Notch-Y"
        ' 
        ' WallWidth
        ' 
        WallWidth.Location = New Point(30, 63)
        WallWidth.Margin = New Padding(3, 4, 3, 4)
        WallWidth.Name = "WallWidth"
        WallWidth.Size = New Size(114, 27)
        WallWidth.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 20)
        Label1.TabIndex = 1
        Label1.Text = "Shear Width"
        ' 
        ' WallHeight
        ' 
        WallHeight.Location = New Point(177, 63)
        WallHeight.Margin = New Padding(3, 4, 3, 4)
        WallHeight.Name = "WallHeight"
        WallHeight.Size = New Size(114, 27)
        WallHeight.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(177, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 20)
        Label2.TabIndex = 3
        Label2.Text = "Shear Height"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(33, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 20)
        Label3.TabIndex = 4
        Label3.Text = "Top Locks (Flat Y)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(34, 220)
        Label4.Name = "Label4"
        Label4.Size = New Size(25, 20)
        Label4.TabIndex = 5
        Label4.Text = "T1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(33, 256)
        Label5.Name = "Label5"
        Label5.Size = New Size(25, 20)
        Label5.TabIndex = 6
        Label5.Text = "T2"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(63, 216)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(114, 27)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(63, 252)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(114, 27)
        TextBox2.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(34, 316)
        Label6.Name = "Label6"
        Label6.Size = New Size(149, 20)
        Label6.TabIndex = 9
        Label6.Text = "Bottom Locks (Flat Y)"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(34, 348)
        Label7.Name = "Label7"
        Label7.Size = New Size(26, 20)
        Label7.TabIndex = 10
        Label7.Text = "B1"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(34, 387)
        Label8.Name = "Label8"
        Label8.Size = New Size(26, 20)
        Label8.TabIndex = 11
        Label8.Text = "B2"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(63, 344)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(114, 27)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(63, 383)
        TextBox4.Margin = New Padding(3, 4, 3, 4)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(114, 27)
        TextBox4.TabIndex = 13
        ' 
        ' FBCB
        ' 
        FBCB.AutoSize = True
        FBCB.Location = New Point(370, 119)
        FBCB.Margin = New Padding(3, 4, 3, 4)
        FBCB.Name = "FBCB"
        FBCB.Size = New Size(133, 24)
        FBCB.TabIndex = 14
        FBCB.Text = "Female Bottom"
        FBCB.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Exterior)
        GroupBox1.Controls.Add(Interior)
        GroupBox1.Location = New Point(353, 19)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(229, 92)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Metal Type"
        ' 
        ' Exterior
        ' 
        Exterior.AutoSize = True
        Exterior.Location = New Point(17, 59)
        Exterior.Margin = New Padding(3, 4, 3, 4)
        Exterior.Name = "Exterior"
        Exterior.Size = New Size(81, 24)
        Exterior.TabIndex = 1
        Exterior.Text = "Exterior"
        Exterior.UseVisualStyleBackColor = True
        ' 
        ' Interior
        ' 
        Interior.AutoSize = True
        Interior.Checked = True
        Interior.Location = New Point(17, 25)
        Interior.Margin = New Padding(3, 4, 3, 4)
        Interior.Name = "Interior"
        Interior.Size = New Size(78, 24)
        Interior.TabIndex = 0
        Interior.TabStop = True
        Interior.Text = "Interior"
        Interior.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(34, 451)
        Label9.Name = "Label9"
        Label9.Size = New Size(129, 20)
        Label9.TabIndex = 16
        Label9.Text = "Side Locks (Flat X)"
        ' 
        ' S1
        ' 
        S1.AutoSize = True
        S1.Location = New Point(34, 489)
        S1.Name = "S1"
        S1.Size = New Size(25, 20)
        S1.TabIndex = 17
        S1.Text = "S1"
        ' 
        ' S2
        ' 
        S2.AutoSize = True
        S2.Location = New Point(33, 528)
        S2.Name = "S2"
        S2.Size = New Size(25, 20)
        S2.TabIndex = 18
        S2.Text = "S2"
        ' 
        ' S3
        ' 
        S3.AutoSize = True
        S3.Location = New Point(33, 567)
        S3.Name = "S3"
        S3.Size = New Size(25, 20)
        S3.TabIndex = 19
        S3.Text = "S3"
        ' 
        ' S4
        ' 
        S4.AutoSize = True
        S4.Location = New Point(33, 605)
        S4.Name = "S4"
        S4.Size = New Size(25, 20)
        S4.TabIndex = 20
        S4.Text = "S4"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(63, 485)
        TextBox5.Margin = New Padding(3, 4, 3, 4)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(114, 27)
        TextBox5.TabIndex = 21
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(62, 524)
        TextBox6.Margin = New Padding(3, 4, 3, 4)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(114, 27)
        TextBox6.TabIndex = 22
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(62, 563)
        TextBox7.Margin = New Padding(3, 4, 3, 4)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(114, 27)
        TextBox7.TabIndex = 23
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(62, 601)
        TextBox8.Margin = New Padding(3, 4, 3, 4)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(114, 27)
        TextBox8.TabIndex = 24
        ' 
        ' DoubleMaleBox
        ' 
        DoubleMaleBox.AutoSize = True
        DoubleMaleBox.Location = New Point(370, 148)
        DoubleMaleBox.Margin = New Padding(3, 4, 3, 4)
        DoubleMaleBox.Name = "DoubleMaleBox"
        DoubleMaleBox.Size = New Size(117, 24)
        DoubleMaleBox.TabIndex = 25
        DoubleMaleBox.Text = "Double Male"
        DoubleMaleBox.UseVisualStyleBackColor = True
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(58, 39)
        TextBox9.Margin = New Padding(3, 4, 3, 4)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(114, 27)
        TextBox9.TabIndex = 28
        ' 
        ' DMS1
        ' 
        DMS1.AutoSize = True
        DMS1.Location = New Point(8, 43)
        DMS1.Name = "DMS1"
        DMS1.Size = New Size(49, 20)
        DMS1.TabIndex = 29
        DMS1.Text = "DMS1"
        ' 
        ' DMS2
        ' 
        DMS2.AutoSize = True
        DMS2.Location = New Point(8, 81)
        DMS2.Name = "DMS2"
        DMS2.Size = New Size(49, 20)
        DMS2.TabIndex = 30
        DMS2.Text = "DMS2"
        ' 
        ' DMS3
        ' 
        DMS3.AutoSize = True
        DMS3.Location = New Point(8, 120)
        DMS3.Name = "DMS3"
        DMS3.Size = New Size(49, 20)
        DMS3.TabIndex = 31
        DMS3.Text = "DMS3"
        ' 
        ' DMS4
        ' 
        DMS4.AutoSize = True
        DMS4.Location = New Point(8, 159)
        DMS4.Name = "DMS4"
        DMS4.Size = New Size(49, 20)
        DMS4.TabIndex = 32
        DMS4.Text = "DMS4"
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(58, 77)
        TextBox10.Margin = New Padding(3, 4, 3, 4)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(114, 27)
        TextBox10.TabIndex = 33
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(58, 116)
        TextBox11.Margin = New Padding(3, 4, 3, 4)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(114, 27)
        TextBox11.TabIndex = 34
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(58, 155)
        TextBox12.Margin = New Padding(3, 4, 3, 4)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(114, 27)
        TextBox12.TabIndex = 35
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(DMS4)
        GroupBox2.Controls.Add(TextBox12)
        GroupBox2.Controls.Add(TextBox11)
        GroupBox2.Controls.Add(TextBox9)
        GroupBox2.Controls.Add(TextBox10)
        GroupBox2.Controls.Add(DMS1)
        GroupBox2.Controls.Add(DMS2)
        GroupBox2.Controls.Add(DMS3)
        GroupBox2.Location = New Point(184, 451)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(194, 207)
        GroupBox2.TabIndex = 36
        GroupBox2.TabStop = False
        GroupBox2.Text = "Double Male Side Locks"
        GroupBox2.Visible = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(393, 383)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 63)
        Button1.TabIndex = 37
        Button1.Text = "Generate String"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' QRStringlabel
        ' 
        QRStringlabel.AutoSize = True
        QRStringlabel.Location = New Point(393, 427)
        QRStringlabel.Name = "QRStringlabel"
        QRStringlabel.Size = New Size(0, 20)
        QRStringlabel.TabIndex = 38
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(385, 485)
        TextBox13.Margin = New Padding(3, 4, 3, 4)
        TextBox13.Multiline = True
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(322, 183)
        TextBox13.TabIndex = 39
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(721, 16)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(525, 679)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 40
        PictureBox1.TabStop = False
        ' 
        ' QRCode
        ' 
        QRCode.Location = New Point(536, 203)
        QRCode.Margin = New Padding(3, 4, 3, 4)
        QRCode.Name = "QRCode"
        QRCode.Size = New Size(179, 172)
        QRCode.SizeMode = PictureBoxSizeMode.Zoom
        QRCode.TabIndex = 41
        QRCode.TabStop = False
        ' 
        ' DEV
        ' 
        SoftPartCheckBox.AutoSize = True
        SoftPartCheckBox.Checked = True
        SoftPartCheckBox.CheckState = CheckState.Checked
        SoftPartCheckBox.Location = New Point(393, 348)
        SoftPartCheckBox.Name = "SoftPartCheckBox"
        SoftPartCheckBox.Size = New Size(100, 24)
        SoftPartCheckBox.TabIndex = 48
        SoftPartCheckBox.Text = "Soft Part"
        SoftPartCheckBox.UseVisualStyleBackColor = True
        DEV.AutoSize = True
        DEV.Location = New Point(573, 424)
        DEV.Margin = New Padding(3, 4, 3, 4)
        DEV.Name = "DEV"
        DEV.Size = New Size(87, 24)
        DEV.TabIndex = 42
        DEV.Text = "Dev Test"
        DEV.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(192, 387)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 56)
        Button2.TabIndex = 43
        Button2.Text = "Symetrical Locks"
        Button2.UseVisualStyleBackColor = True
        Button2.Visible = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(203, 296)
        Label10.Name = "Label10"
        Label10.Size = New Size(335, 40)
        Label10.TabIndex = 44
        Label10.Text = "It is ok to leave lock locations empty, " + vbCrLf + "if the textbox is empty the program will ignore it "
        ' 
        ' Thickness
        ' 
        Thickness.AutoSize = True
        Thickness.Location = New Point(370, 177)
        Thickness.Margin = New Padding(3, 4, 3, 4)
        Thickness.Name = "Thickness"
        Thickness.Size = New Size(111, 24)
        Thickness.TabIndex = 45
        Thickness.Text = "5"" Thickness"
        Thickness.UseVisualStyleBackColor = True
        ' 
        ' PN
        ' 
        PN.AutoSize = True
        PN.Location = New Point(391, 461)
        PN.Name = "PN"
        PN.Size = New Size(61, 20)
        PN.TabIndex = 46
        PN.Text = "Label11"
        PN.Visible = False
        ' 
        ' DEVTEXT
        ' 
        DEVTEXT.Location = New Point(608, 677)
        DEVTEXT.Margin = New Padding(3, 4, 3, 4)
        DEVTEXT.Name = "DEVTEXT"
        DEVTEXT.Size = New Size(99, 45)
        DEVTEXT.TabIndex = 47
        DEVTEXT.Text = "Edit String"
        DEVTEXT.UseVisualStyleBackColor = True
        DEVTEXT.Visible = False
        ' 
        ' Walls
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1245, 772)
        Controls.Add(DEVTEXT)
        Controls.Add(PN)
        Controls.Add(FormedHeight)
        Controls.Add(FormedWidth)
        Controls.Add(FormedHeightLabel)
        Controls.Add(FormedWidthLabel)
        Controls.Add(CornerYOverlap)
        Controls.Add(CornerXOverlap)
        Controls.Add(CornerYOverlapLabel)
        Controls.Add(CornerXOverlapLabel)
        Controls.Add(Thickness)
        Controls.Add(Label10)
        Controls.Add(Button2)
        Controls.Add(SoftPartCheckBox)
        Controls.Add(DEV)
        Controls.Add(QRCode)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox13)
        Controls.Add(QRStringlabel)
        Controls.Add(Button1)
        Controls.Add(GroupBox2)
        Controls.Add(DoubleMaleBox)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(S4)
        Controls.Add(S3)
        Controls.Add(S2)
        Controls.Add(S1)
        Controls.Add(Label9)
        Controls.Add(GroupBox1)
        Controls.Add(FBCB)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(WallHeight)
        Controls.Add(Label1)
        Controls.Add(WallWidth)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Walls"
        Text = "Walls"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(QRCode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents WallWidth As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents WallHeight As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents FBCB As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Exterior As RadioButton
    Friend WithEvents Interior As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents S1 As Label
    Friend WithEvents S2 As Label
    Friend WithEvents S3 As Label
    Friend WithEvents S4 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents DoubleMaleBox As CheckBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents DMS1 As Label
    Friend WithEvents DMS2 As Label
    Friend WithEvents DMS3 As Label
    Friend WithEvents DMS4 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents QRStringlabel As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents QRCode As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SoftPartCheckBox As CheckBox
    Friend WithEvents DEV As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Thickness As CheckBox
    Friend WithEvents PN As Label
    Friend WithEvents DEVTEXT As Button
    Friend WithEvents FormedWidth As TextBox
    Friend WithEvents FormedHeight As TextBox
    Friend WithEvents FormedWidthLabel As Label
    Friend WithEvents FormedHeightLabel As Label
    Friend WithEvents CornerXOverlap As TextBox
    Friend WithEvents CornerYOverlap As TextBox
    Friend WithEvents CornerXOverlapLabel As Label
    Friend WithEvents CornerYOverlapLabel As Label
End Class
