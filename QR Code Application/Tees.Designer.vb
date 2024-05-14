<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tees
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Tees))
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
        DEV = New CheckBox()
        Button2 = New Button()
        Label22 = New Label()
        STD = New CheckBox()
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
        Label1.Location = New Point(18, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 15)
        Label1.TabIndex = 0
        Label1.Text = "Male Leg Length"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(147, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 15)
        Label2.TabIndex = 1
        Label2.Text = "Female Leg Length"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(279, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 15)
        Label3.TabIndex = 2
        Label3.Text = "Panel Height"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(402, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 15)
        Label4.TabIndex = 3
        Label4.Text = "Tee Leg Length"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(FETEERB)
        GroupBox1.Controls.Add(MATEERB)
        GroupBox1.Location = New Point(509, 25)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(133, 85)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Panel Type"
        ' 
        ' FETEERB
        ' 
        FETEERB.AutoSize = True
        FETEERB.BackgroundImageLayout = ImageLayout.None
        FETEERB.Location = New Point(6, 47)
        FETEERB.Name = "FETEERB"
        FETEERB.Size = New Size(83, 19)
        FETEERB.TabIndex = 1
        FETEERB.Text = "Female Tee"
        FETEERB.UseVisualStyleBackColor = True
        ' 
        ' MATEERB
        ' 
        MATEERB.AutoSize = True
        MATEERB.Checked = True
        MATEERB.Location = New Point(6, 22)
        MATEERB.Name = "MATEERB"
        MATEERB.Size = New Size(71, 19)
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
        GroupBox2.Location = New Point(509, 116)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(133, 100)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Metal Type"
        ' 
        ' EXT
        ' 
        EXT.AutoSize = True
        EXT.Location = New Point(6, 72)
        EXT.Name = "EXT"
        EXT.Size = New Size(65, 19)
        EXT.TabIndex = 2
        EXT.Text = "Exterior"
        EXT.UseVisualStyleBackColor = True
        ' 
        ' FEINT
        ' 
        FEINT.AutoSize = True
        FEINT.Location = New Point(6, 47)
        FEINT.Name = "FEINT"
        FEINT.Size = New Size(104, 19)
        FEINT.TabIndex = 1
        FEINT.Text = "Female Interior"
        FEINT.UseVisualStyleBackColor = True
        ' 
        ' MAINT
        ' 
        MAINT.AutoSize = True
        MAINT.Checked = True
        MAINT.Location = New Point(6, 22)
        MAINT.Name = "MAINT"
        MAINT.Size = New Size(92, 19)
        MAINT.TabIndex = 0
        MAINT.TabStop = True
        MAINT.Text = "Male Interior"
        MAINT.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 76)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 15)
        Label5.TabIndex = 6
        Label5.Text = "Top Locks"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(18, 95)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 15)
        Label6.TabIndex = 7
        Label6.Text = "TM1"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(18, 124)
        Label7.Name = "Label7"
        Label7.Size = New Size(25, 15)
        Label7.TabIndex = 8
        Label7.Text = "TF1"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(18, 153)
        Label8.Name = "Label8"
        Label8.Size = New Size(25, 15)
        Label8.TabIndex = 9
        Label8.Text = "TT1"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(15, 187)
        Label9.Name = "Label9"
        Label9.Size = New Size(80, 15)
        Label9.TabIndex = 10
        Label9.Text = "Bottom Locks"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(18, 213)
        Label10.Name = "Label10"
        Label10.Size = New Size(31, 15)
        Label10.TabIndex = 11
        Label10.Text = "BM1"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(18, 242)
        Label11.Name = "Label11"
        Label11.Size = New Size(26, 15)
        Label11.TabIndex = 12
        Label11.Text = "BF1"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(18, 271)
        Label12.Name = "Label12"
        Label12.Size = New Size(25, 15)
        Label12.TabIndex = 13
        Label12.Text = "BT1"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(12, 301)
        Label13.Name = "Label13"
        Label13.Size = New Size(91, 15)
        Label13.TabIndex = 14
        Label13.Text = "Male Side Locks"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(24, 323)
        Label14.Name = "Label14"
        Label14.Size = New Size(19, 15)
        Label14.TabIndex = 15
        Label14.Text = "S1"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(25, 353)
        Label15.Name = "Label15"
        Label15.Size = New Size(19, 15)
        Label15.TabIndex = 16
        Label15.Text = "S2"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(25, 381)
        Label16.Name = "Label16"
        Label16.Size = New Size(19, 15)
        Label16.TabIndex = 17
        Label16.Text = "S3"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(24, 408)
        Label17.Name = "Label17"
        Label17.Size = New Size(19, 15)
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
        GroupBox3.Location = New Point(188, 301)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(166, 144)
        GroupBox3.TabIndex = 19
        GroupBox3.TabStop = False
        GroupBox3.Text = "Tee Locks"
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(45, 78)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(100, 23)
        TextBox13.TabIndex = 6
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(45, 49)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(100, 23)
        TextBox12.TabIndex = 5
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(45, 20)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(100, 23)
        TextBox11.TabIndex = 4
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(14, 110)
        Label21.Name = "Label21"
        Label21.Size = New Size(25, 15)
        Label21.TabIndex = 3
        Label21.Text = "TS4"
        ' 
        ' TextBox14
        ' 
        TextBox14.Location = New Point(45, 107)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(100, 23)
        TextBox14.TabIndex = 30
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(14, 80)
        Label20.Name = "Label20"
        Label20.Size = New Size(25, 15)
        Label20.TabIndex = 2
        Label20.Text = "TS3"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(14, 52)
        Label19.Name = "Label19"
        Label19.Size = New Size(25, 15)
        Label19.TabIndex = 1
        Label19.Text = "TS2"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(14, 23)
        Label18.Name = "Label18"
        Label18.Size = New Size(25, 15)
        Label18.TabIndex = 0
        Label18.Text = "TS1"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(54, 92)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 20
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(54, 121)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 21
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(54, 150)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 22
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(54, 210)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 23
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(55, 239)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 24
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(55, 268)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 25
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(54, 320)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 26
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(55, 349)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(100, 23)
        TextBox8.TabIndex = 27
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(54, 378)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(100, 23)
        TextBox9.TabIndex = 28
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(55, 405)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(100, 23)
        TextBox10.TabIndex = 29
        ' 
        ' MALEG
        ' 
        MALEG.Location = New Point(18, 43)
        MALEG.Name = "MALEG"
        MALEG.Size = New Size(100, 23)
        MALEG.TabIndex = 31
        ' 
        ' FELEG
        ' 
        FELEG.Location = New Point(154, 43)
        FELEG.Name = "FELEG"
        FELEG.Size = New Size(100, 23)
        FELEG.TabIndex = 32
        ' 
        ' Height
        ' 
        Height.Location = New Point(279, 43)
        Height.Name = "Height"
        Height.Size = New Size(100, 23)
        Height.TabIndex = 33
        ' 
        ' TEELength
        ' 
        TEELength.Location = New Point(402, 43)
        TEELength.Name = "TEELength"
        TEELength.Size = New Size(100, 23)
        TEELength.TabIndex = 34
        ' 
        ' StringBox
        ' 
        StringBox.Location = New Point(378, 420)
        StringBox.Multiline = True
        StringBox.Name = "StringBox"
        StringBox.Size = New Size(317, 130)
        StringBox.TabIndex = 35
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(585, 349)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 47)
        Button1.TabIndex = 36
        Button1.Text = "Generate String"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' QRCode
        ' 
        QRCode.Location = New Point(402, 258)
        QRCode.Name = "QRCode"
        QRCode.Size = New Size(142, 138)
        QRCode.SizeMode = PictureBoxSizeMode.Zoom
        QRCode.TabIndex = 37
        QRCode.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(729, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(378, 591)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 38
        PictureBox1.TabStop = False
        ' 
        ' DEV
        ' 
        DEV.AutoSize = True
        DEV.Location = New Point(626, 400)
        DEV.Name = "DEV"
        DEV.Size = New Size(70, 19)
        DEV.TabIndex = 39
        DEV.Text = "DEV Test"
        DEV.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(188, 254)
        Button2.Name = "Button2"
        Button2.Size = New Size(96, 41)
        Button2.TabIndex = 40
        Button2.Text = "Symetrical Locks"
        Button2.UseVisualStyleBackColor = True
        Button2.Visible = False
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(170, 85)
        Label22.Name = "Label22"
        Label22.Size = New Size(281, 60)
        Label22.TabIndex = 41
        Label22.Text = "NOTE: It is ok to leave lock locations empty, " & vbCrLf & "if the textbox is empty the application will ignore it. " & vbCrLf & "If a textbox is dsabled (greyed out) the application " & vbCrLf & "will also ignore it."
        ' 
        ' STD
        ' 
        STD.AutoSize = True
        STD.Location = New Point(422, 76)
        STD.Name = "STD"
        STD.Size = New Size(66, 19)
        STD.TabIndex = 42
        STD.Text = "STD Tee"
        STD.UseVisualStyleBackColor = True
        ' 
        ' Tees
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1180, 641)
        Controls.Add(STD)
        Controls.Add(Label22)
        Controls.Add(Button2)
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
        Name = "Tees"
        Text = "Tees"
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
    Friend WithEvents DEV As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents STD As CheckBox
End Class
