<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeePanelForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeePanelForm))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        FETEERB = New RadioButton()
        MATEERB = New RadioButton()
        GroupBox2 = New GroupBox()
        EXT = New RadioButton()
        FEINT = New RadioButton()
        MAINT = New RadioButton()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        GroupBox3 = New GroupBox()
        TextBox13 = New TextBox()
        TextBox12 = New TextBox()
        TextBox11 = New TextBox()
        Label21 = New Label()
        TextBox14 = New TextBox()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        MALEG = New TextBox()
        FELEG = New TextBox()
        Height = New TextBox()
        TEELength = New TextBox()
        StringBox = New TextBox()
        Button1 = New Button()
        QRCode = New PictureBox()
        PictureBox1 = New PictureBox()
        SoftPartCheckBox = New CheckBox()
        DEV = New CheckBox()
        Button2 = New Button()
        Label22 = New Label()
        STD = New CheckBox()
        PN = New Label()
        DEVTEXT = New Button()
        Thickness = New CheckBox()
        FBCheck = New CheckBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(QRCode, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 20)
        Label1.TabIndex = 0
        Label1.Text = "Male Leg Length"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(168, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 20)
        Label2.TabIndex = 1
        Label2.Text = "Female Leg Length"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(319, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 20)
        Label3.TabIndex = 2
        Label3.Text = "Shear Height"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(459, 33)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 20)
        Label4.TabIndex = 3
        Label4.Text = "Tee Leg Length"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(FETEERB)
        GroupBox1.Controls.Add(MATEERB)
        GroupBox1.Location = New Point(582, 33)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(152, 113)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Panel Type"
        ' 
        ' FETEERB
        ' 
        FETEERB.AutoSize = True
        FETEERB.BackgroundImageLayout = ImageLayout.None
        FETEERB.Location = New Point(7, 63)
        FETEERB.Margin = New Padding(3, 4, 3, 4)
        FETEERB.Name = "FETEERB"
        FETEERB.Size = New Size(105, 24)
        FETEERB.TabIndex = 1
        FETEERB.Text = "Female Tee"
        FETEERB.UseVisualStyleBackColor = True
        ' 
        ' MATEERB
        ' 
        MATEERB.AutoSize = True
        MATEERB.Checked = True
        MATEERB.Location = New Point(7, 29)
        MATEERB.Margin = New Padding(3, 4, 3, 4)
        MATEERB.Name = "MATEERB"
        MATEERB.Size = New Size(90, 24)
        MATEERB.TabIndex = 0
        MATEERB.TabStop = True
        MATEERB.Text = "Male Tee"
        MATEERB.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(EXT)
        GroupBox2.Controls.Add(FEINT)
        GroupBox2.Controls.Add(MAINT)
        GroupBox2.Location = New Point(582, 155)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(152, 133)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Metal Type"
        ' 
        ' EXT
        ' 
        EXT.AutoSize = True
        EXT.Location = New Point(7, 96)
        EXT.Margin = New Padding(3, 4, 3, 4)
        EXT.Name = "EXT"
        EXT.Size = New Size(81, 24)
        EXT.TabIndex = 2
        EXT.Text = "Exterior"
        EXT.UseVisualStyleBackColor = True
        ' 
        ' FEINT
        ' 
        FEINT.AutoSize = True
        FEINT.Location = New Point(7, 63)
        FEINT.Margin = New Padding(3, 4, 3, 4)
        FEINT.Name = "FEINT"
        FEINT.Size = New Size(130, 24)
        FEINT.TabIndex = 1
        FEINT.Text = "Female Interior"
        FEINT.UseVisualStyleBackColor = True
        ' 
        ' MAINT
        ' 
        MAINT.AutoSize = True
        MAINT.Checked = True
        MAINT.Location = New Point(7, 29)
        MAINT.Margin = New Padding(3, 4, 3, 4)
        MAINT.Name = "MAINT"
        MAINT.Size = New Size(115, 24)
        MAINT.TabIndex = 0
        MAINT.TabStop = True
        MAINT.Text = "Male Interior"
        MAINT.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(14, 101)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 20)
        Label5.TabIndex = 6
        Label5.Text = "Top Locks"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(21, 127)
        Label6.Name = "Label6"
        Label6.Size = New Size(38, 20)
        Label6.TabIndex = 7
        Label6.Text = "TM1"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(21, 165)
        Label7.Name = "Label7"
        Label7.Size = New Size(32, 20)
        Label7.TabIndex = 8
        Label7.Text = "TF1"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(21, 204)
        Label8.Name = "Label8"
        Label8.Size = New Size(33, 20)
        Label8.TabIndex = 9
        Label8.Text = "TT1"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(17, 249)
        Label9.Name = "Label9"
        Label9.Size = New Size(99, 20)
        Label9.TabIndex = 10
        Label9.Text = "Bottom Locks"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(21, 284)
        Label10.Name = "Label10"
        Label10.Size = New Size(39, 20)
        Label10.TabIndex = 11
        Label10.Text = "BM1"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(21, 323)
        Label11.Name = "Label11"
        Label11.Size = New Size(33, 20)
        Label11.TabIndex = 12
        Label11.Text = "BF1"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(21, 361)
        Label12.Name = "Label12"
        Label12.Size = New Size(33, 20)
        Label12.TabIndex = 13
        Label12.Text = "BT1"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(14, 401)
        Label13.Name = "Label13"
        Label13.Size = New Size(115, 20)
        Label13.TabIndex = 14
        Label13.Text = "Male Side Locks"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(27, 431)
        Label14.Name = "Label14"
        Label14.Size = New Size(25, 20)
        Label14.TabIndex = 15
        Label14.Text = "S1"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(29, 471)
        Label15.Name = "Label15"
        Label15.Size = New Size(25, 20)
        Label15.TabIndex = 16
        Label15.Text = "S2"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(29, 508)
        Label16.Name = "Label16"
        Label16.Size = New Size(25, 20)
        Label16.TabIndex = 17
        Label16.Text = "S3"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(27, 544)
        Label17.Name = "Label17"
        Label17.Size = New Size(25, 20)
        Label17.TabIndex = 18
        Label17.Text = "S4"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(TextBox13)
        GroupBox3.Controls.Add(TextBox12)
        GroupBox3.Controls.Add(TextBox11)
        GroupBox3.Controls.Add(Label21)
        GroupBox3.Controls.Add(TextBox14)
        GroupBox3.Controls.Add(Label20)
        GroupBox3.Controls.Add(Label19)
        GroupBox3.Controls.Add(Label18)
        GroupBox3.Location = New Point(215, 401)
        GroupBox3.Margin = New Padding(3, 4, 3, 4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 4, 3, 4)
        GroupBox3.Size = New Size(190, 192)
        GroupBox3.TabIndex = 19
        GroupBox3.TabStop = False
        GroupBox3.Text = "Tee Locks"
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(51, 104)
        TextBox13.Margin = New Padding(3, 4, 3, 4)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(114, 27)
        TextBox13.TabIndex = 6
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(51, 65)
        TextBox12.Margin = New Padding(3, 4, 3, 4)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(114, 27)
        TextBox12.TabIndex = 5
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(51, 27)
        TextBox11.Margin = New Padding(3, 4, 3, 4)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(114, 27)
        TextBox11.TabIndex = 4
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(16, 147)
        Label21.Name = "Label21"
        Label21.Size = New Size(33, 20)
        Label21.TabIndex = 3
        Label21.Text = "TS4"
        ' 
        ' TextBox14
        ' 
        TextBox14.Location = New Point(51, 143)
        TextBox14.Margin = New Padding(3, 4, 3, 4)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(114, 27)
        TextBox14.TabIndex = 30
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(16, 107)
        Label20.Name = "Label20"
        Label20.Size = New Size(33, 20)
        Label20.TabIndex = 2
        Label20.Text = "TS3"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(16, 69)
        Label19.Name = "Label19"
        Label19.Size = New Size(33, 20)
        Label19.TabIndex = 1
        Label19.Text = "TS2"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(16, 31)
        Label18.Name = "Label18"
        Label18.Size = New Size(33, 20)
        Label18.TabIndex = 0
        Label18.Text = "TS1"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(62, 123)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(114, 27)
        TextBox1.TabIndex = 20
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(62, 161)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(114, 27)
        TextBox2.TabIndex = 21
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(62, 200)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(114, 27)
        TextBox3.TabIndex = 22
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(62, 280)
        TextBox4.Margin = New Padding(3, 4, 3, 4)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(114, 27)
        TextBox4.TabIndex = 23
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(63, 319)
        TextBox5.Margin = New Padding(3, 4, 3, 4)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(114, 27)
        TextBox5.TabIndex = 24
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(63, 357)
        TextBox6.Margin = New Padding(3, 4, 3, 4)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(114, 27)
        TextBox6.TabIndex = 25
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(62, 427)
        TextBox7.Margin = New Padding(3, 4, 3, 4)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(114, 27)
        TextBox7.TabIndex = 26
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(63, 465)
        TextBox8.Margin = New Padding(3, 4, 3, 4)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(114, 27)
        TextBox8.TabIndex = 27
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(62, 504)
        TextBox9.Margin = New Padding(3, 4, 3, 4)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(114, 27)
        TextBox9.TabIndex = 28
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(63, 540)
        TextBox10.Margin = New Padding(3, 4, 3, 4)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(114, 27)
        TextBox10.TabIndex = 29
        ' 
        ' MALEG
        ' 
        MALEG.Location = New Point(21, 57)
        MALEG.Margin = New Padding(3, 4, 3, 4)
        MALEG.Name = "MALEG"
        MALEG.Size = New Size(114, 27)
        MALEG.TabIndex = 31
        ' 
        ' FELEG
        ' 
        FELEG.Location = New Point(176, 57)
        FELEG.Margin = New Padding(3, 4, 3, 4)
        FELEG.Name = "FELEG"
        FELEG.Size = New Size(114, 27)
        FELEG.TabIndex = 32
        ' 
        ' Height
        ' 
        Height.Location = New Point(319, 57)
        Height.Margin = New Padding(3, 4, 3, 4)
        Height.Name = "Height"
        Height.Size = New Size(114, 27)
        Height.TabIndex = 33
        ' 
        ' TEELength
        ' 
        TEELength.Location = New Point(459, 57)
        TEELength.Margin = New Padding(3, 4, 3, 4)
        TEELength.Name = "TEELength"
        TEELength.Size = New Size(114, 27)
        TEELength.TabIndex = 34
        ' 
        ' StringBox
        ' 
        StringBox.Location = New Point(432, 560)
        StringBox.Margin = New Padding(3, 4, 3, 4)
        StringBox.Multiline = True
        StringBox.Name = "StringBox"
        StringBox.Size = New Size(362, 172)
        StringBox.TabIndex = 35
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(683, 486)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(126, 63)
        Button1.TabIndex = 36
        Button1.Text = "Generate QR Code"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' QRCode
        ' 
        QRCode.Location = New Point(459, 344)
        QRCode.Margin = New Padding(3, 4, 3, 4)
        QRCode.Name = "QRCode"
        QRCode.Size = New Size(162, 184)
        QRCode.SizeMode = PictureBoxSizeMode.Zoom
        QRCode.TabIndex = 37
        QRCode.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(833, 33)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(432, 788)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 38
        PictureBox1.TabStop = False
        ' 
        ' SoftPartCheckBox
        ' 
        SoftPartCheckBox.AutoSize = True
        SoftPartCheckBox.Checked = True
        SoftPartCheckBox.CheckState = CheckState.Checked
        SoftPartCheckBox.Location = New Point(685, 427)
        SoftPartCheckBox.Margin = New Padding(3, 4, 3, 4)
        SoftPartCheckBox.Name = "SoftPartCheckBox"
        SoftPartCheckBox.Size = New Size(87, 24)
        SoftPartCheckBox.TabIndex = 99
        SoftPartCheckBox.Text = "Soft Part"
        SoftPartCheckBox.UseVisualStyleBackColor = True
        ' 
        ' DEV
        ' 
        DEV.AutoSize = True
        DEV.Location = New Point(685, 454)
        DEV.Margin = New Padding(3, 4, 3, 4)
        DEV.Name = "DEV"
        DEV.Size = New Size(116, 24)
        DEV.TabIndex = 39
        DEV.Text = "Preview Only"
        DEV.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(215, 339)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(110, 55)
        Button2.TabIndex = 40
        Button2.Text = "Symmetrical Locks"
        Button2.UseVisualStyleBackColor = True
        Button2.Visible = False
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(194, 113)
        Label22.Name = "Label22"
        Label22.Size = New Size(355, 80)
        Label22.TabIndex = 41
        Label22.Text = "NOTE: It is ok to leave lock locations empty, " & vbCrLf & "if the textbox is empty the application will ignore it. " & vbCrLf & "If a textbox is dsabled (greyed out) the application " & vbCrLf & "will also ignore it."
        ' 
        ' STD
        ' 
        STD.AutoSize = True
        STD.Location = New Point(471, 185)
        STD.Margin = New Padding(3, 4, 3, 4)
        STD.Name = "STD"
        STD.Size = New Size(85, 24)
        STD.TabIndex = 42
        STD.Text = "STD Tee"
        STD.UseVisualStyleBackColor = True
        ' 
        ' PN
        ' 
        PN.AutoSize = True
        PN.Location = New Point(442, 540)
        PN.Name = "PN"
        PN.Size = New Size(61, 20)
        PN.TabIndex = 43
        PN.Text = "Label23"
        PN.Visible = False
        ' 
        ' DEVTEXT
        ' 
        DEVTEXT.Location = New Point(683, 741)
        DEVTEXT.Margin = New Padding(3, 4, 3, 4)
        DEVTEXT.Name = "DEVTEXT"
        DEVTEXT.Size = New Size(89, 44)
        DEVTEXT.TabIndex = 44
        DEVTEXT.Text = "Edit String"
        DEVTEXT.UseCompatibleTextRendering = True
        DEVTEXT.UseVisualStyleBackColor = True
        DEVTEXT.Visible = False
        ' 
        ' Thickness
        ' 
        Thickness.AutoSize = True
        Thickness.Location = New Point(471, 219)
        Thickness.Margin = New Padding(3, 4, 3, 4)
        Thickness.Name = "Thickness"
        Thickness.Size = New Size(111, 24)
        Thickness.TabIndex = 45
        Thickness.Text = "5"" Thickness"
        Thickness.UseVisualStyleBackColor = True
        ' 
        ' FBCheck
        ' 
        FBCheck.AutoSize = True
        FBCheck.Location = New Point(471, 249)
        FBCheck.Margin = New Padding(3, 4, 3, 4)
        FBCheck.Name = "FBCheck"
        FBCheck.Size = New Size(133, 24)
        FBCheck.TabIndex = 46
        FBCheck.Text = "Female Bottom"
        FBCheck.UseVisualStyleBackColor = True
        ' 
        ' TeePanelForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1349, 855)
        Controls.Add(FBCheck)
        Controls.Add(Thickness)
        Controls.Add(DEVTEXT)
        Controls.Add(PN)
        Controls.Add(STD)
        Controls.Add(Label22)
        Controls.Add(Button2)
        Controls.Add(SoftPartCheckBox)
        Controls.Add(DEV)
        Controls.Add(PictureBox1)
        Controls.Add(QRCode)
        Controls.Add(Button1)
        Controls.Add(StringBox)
        Controls.Add(TEELength)
        Controls.Add(Height)
        Controls.Add(FELEG)
        Controls.Add(MALEG)
        Controls.Add(TextBox10)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(GroupBox3)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "TeePanelForm"
        Text = "Tee Panels"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(QRCode, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FETEERB As RadioButton
    Friend WithEvents MATEERB As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents EXT As RadioButton
    Friend WithEvents FEINT As RadioButton
    Friend WithEvents MAINT As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents MALEG As TextBox
    Friend WithEvents FELEG As TextBox
    Friend WithEvents Height As TextBox
    Friend WithEvents TEELength As TextBox
    Friend WithEvents StringBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents QRCode As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SoftPartCheckBox As CheckBox
    Friend WithEvents DEV As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents STD As CheckBox
    Friend WithEvents PN As Label
    Friend WithEvents DEVTEXT As Button
    Friend WithEvents Thickness As CheckBox
    Friend WithEvents FBCheck As CheckBox
End Class
