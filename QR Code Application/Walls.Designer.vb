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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Walls))
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
        CheckBox1 = New CheckBox()
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
        DEV = New CheckBox()
        Button2 = New Button()
        Label10 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(QRCode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' WallWidth
        ' 
        WallWidth.Location = New Point(26, 47)
        WallWidth.Name = "WallWidth"
        WallWidth.Size = New Size(100, 23)
        WallWidth.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 1
        Label1.Text = "Panel Width "
        ' 
        ' WallHeight
        ' 
        WallHeight.Location = New Point(155, 47)
        WallHeight.Name = "WallHeight"
        WallHeight.Size = New Size(100, 23)
        WallHeight.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(155, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 3
        Label2.Text = "Panel Height"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 4
        Label3.Text = "Top Locks"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(19, 15)
        Label4.TabIndex = 5
        Label4.Text = "T1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(29, 137)
        Label5.Name = "Label5"
        Label5.Size = New Size(19, 15)
        Label5.TabIndex = 6
        Label5.Text = "T2"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(55, 107)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(55, 134)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(30, 182)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 15)
        Label6.TabIndex = 9
        Label6.Text = "Bottom Locks"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(30, 206)
        Label7.Name = "Label7"
        Label7.Size = New Size(20, 15)
        Label7.TabIndex = 10
        Label7.Text = "B1"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(30, 235)
        Label8.Name = "Label8"
        Label8.Size = New Size(20, 15)
        Label8.TabIndex = 11
        Label8.Text = "B2"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(55, 203)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(55, 232)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 13
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(324, 89)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(107, 19)
        CheckBox1.TabIndex = 14
        CheckBox1.Text = "Female Bottom"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Exterior)
        GroupBox1.Controls.Add(Interior)
        GroupBox1.Location = New Point(309, 14)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 69)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Metal Type"
        ' 
        ' Exterior
        ' 
        Exterior.AutoSize = True
        Exterior.Location = New Point(15, 44)
        Exterior.Name = "Exterior"
        Exterior.Size = New Size(65, 19)
        Exterior.TabIndex = 1
        Exterior.Text = "Exterior"
        Exterior.UseVisualStyleBackColor = True
        ' 
        ' Interior
        ' 
        Interior.AutoSize = True
        Interior.Checked = True
        Interior.Location = New Point(15, 19)
        Interior.Name = "Interior"
        Interior.Size = New Size(63, 19)
        Interior.TabIndex = 0
        Interior.TabStop = True
        Interior.Text = "Interior"
        Interior.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(30, 283)
        Label9.Name = "Label9"
        Label9.Size = New Size(65, 15)
        Label9.TabIndex = 16
        Label9.Text = "Side Locks "
        ' 
        ' S1
        ' 
        S1.AutoSize = True
        S1.Location = New Point(30, 312)
        S1.Name = "S1"
        S1.Size = New Size(19, 15)
        S1.TabIndex = 17
        S1.Text = "S1"
        ' 
        ' S2
        ' 
        S2.AutoSize = True
        S2.Location = New Point(29, 341)
        S2.Name = "S2"
        S2.Size = New Size(19, 15)
        S2.TabIndex = 18
        S2.Text = "S2"
        ' 
        ' S3
        ' 
        S3.AutoSize = True
        S3.Location = New Point(29, 370)
        S3.Name = "S3"
        S3.Size = New Size(19, 15)
        S3.TabIndex = 19
        S3.Text = "S3"
        ' 
        ' S4
        ' 
        S4.AutoSize = True
        S4.Location = New Point(29, 399)
        S4.Name = "S4"
        S4.Size = New Size(19, 15)
        S4.TabIndex = 20
        S4.Text = "S4"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(55, 309)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 21
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(54, 338)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 22
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(54, 367)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 23
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(54, 396)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(100, 23)
        TextBox8.TabIndex = 24
        ' 
        ' DoubleMaleBox
        ' 
        DoubleMaleBox.AutoSize = True
        DoubleMaleBox.Location = New Point(324, 111)
        DoubleMaleBox.Name = "DoubleMaleBox"
        DoubleMaleBox.Size = New Size(93, 19)
        DoubleMaleBox.TabIndex = 25
        DoubleMaleBox.Text = "Double Male"
        DoubleMaleBox.UseVisualStyleBackColor = True
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(51, 29)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(100, 23)
        TextBox9.TabIndex = 28
        ' 
        ' DMS1
        ' 
        DMS1.AutoSize = True
        DMS1.Location = New Point(7, 32)
        DMS1.Name = "DMS1"
        DMS1.Size = New Size(38, 15)
        DMS1.TabIndex = 29
        DMS1.Text = "DMS1"
        ' 
        ' DMS2
        ' 
        DMS2.AutoSize = True
        DMS2.Location = New Point(7, 61)
        DMS2.Name = "DMS2"
        DMS2.Size = New Size(38, 15)
        DMS2.TabIndex = 30
        DMS2.Text = "DMS2"
        ' 
        ' DMS3
        ' 
        DMS3.AutoSize = True
        DMS3.Location = New Point(7, 90)
        DMS3.Name = "DMS3"
        DMS3.Size = New Size(38, 15)
        DMS3.TabIndex = 31
        DMS3.Text = "DMS3"
        ' 
        ' DMS4
        ' 
        DMS4.AutoSize = True
        DMS4.Location = New Point(7, 119)
        DMS4.Name = "DMS4"
        DMS4.Size = New Size(38, 15)
        DMS4.TabIndex = 32
        DMS4.Text = "DMS4"
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(51, 58)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(100, 23)
        TextBox10.TabIndex = 33
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(51, 87)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(100, 23)
        TextBox11.TabIndex = 34
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(51, 116)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(100, 23)
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
        GroupBox2.Location = New Point(161, 283)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(170, 155)
        GroupBox2.TabIndex = 36
        GroupBox2.TabStop = False
        GroupBox2.Text = "Double Male Side Locks"
        GroupBox2.Visible = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(344, 235)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 47)
        Button1.TabIndex = 37
        Button1.Text = "Generate String"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' QRStringlabel
        ' 
        QRStringlabel.AutoSize = True
        QRStringlabel.Location = New Point(344, 320)
        QRStringlabel.Name = "QRStringlabel"
        QRStringlabel.Size = New Size(0, 15)
        QRStringlabel.TabIndex = 38
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(337, 300)
        TextBox13.Multiline = True
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(282, 138)
        TextBox13.TabIndex = 39
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(631, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(459, 509)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 40
        PictureBox1.TabStop = False
        ' 
        ' QRCode
        ' 
        QRCode.Location = New Point(462, 100)
        QRCode.Name = "QRCode"
        QRCode.Size = New Size(157, 129)
        QRCode.SizeMode = PictureBoxSizeMode.Zoom
        QRCode.TabIndex = 41
        QRCode.TabStop = False
        ' 
        ' DEV
        ' 
        DEV.AutoSize = True
        DEV.Location = New Point(501, 263)
        DEV.Name = "DEV"
        DEV.Size = New Size(69, 19)
        DEV.TabIndex = 42
        DEV.Text = "Dev Test"
        DEV.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(168, 235)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 42)
        Button2.TabIndex = 43
        Button2.Text = "Symetrical Locks"
        Button2.UseVisualStyleBackColor = True
        Button2.Visible = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(178, 167)
        Label10.Name = "Label10"
        Label10.Size = New Size(265, 30)
        Label10.TabIndex = 44
        Label10.Text = "It is ok to leave lock locations empty, " & vbCrLf & "if the textbox is empty the program will ignore it "
        ' 
        ' Walls
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1089, 524)
        Controls.Add(Label10)
        Controls.Add(Button2)
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
        Controls.Add(CheckBox1)
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
    Friend WithEvents CheckBox1 As CheckBox
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
    Friend WithEvents DEV As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label10 As Label
End Class
