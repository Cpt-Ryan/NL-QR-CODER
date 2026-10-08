<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FloorPanelForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FloorPanelForm))
        OSFE = New RadioButton()
        L1 = New Label()
        L2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        PanelWidth = New TextBox()
        PanelLenght = New TextBox()
        GroupBox1 = New GroupBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        Label1 = New Label()
        CNT = New RadioButton()
        OSMA = New RadioButton()
        GroupBox3 = New GroupBox()
        EXT = New RadioButton()
        INT = New RadioButton()
        QRCode = New PictureBox()
        Button1 = New Button()
        SoftPartCheckBox = New CheckBox()
        DEV = New CheckBox()
        StringBox = New TextBox()
        PictureBox1 = New PictureBox()
        Label8 = New Label()
        PN = New Label()
        DEVTEXT = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(QRCode, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' OSFE
        ' 
        OSFE.AutoSize = True
        OSFE.Location = New Point(7, 61)
        OSFE.Margin = New Padding(3, 4, 3, 4)
        OSFE.Name = "OSFE"
        OSFE.Size = New Size(177, 24)
        OSFE.TabIndex = 0
        OSFE.Text = "Outside Female Splice"
        OSFE.UseVisualStyleBackColor = True
        ' 
        ' L1
        ' 
        L1.AutoSize = True
        L1.Location = New Point(14, 32)
        L1.Name = "L1"
        L1.Size = New Size(90, 20)
        L1.TabIndex = 1
        L1.Text = "Shear Width"
        ' 
        ' L2
        ' 
        L2.AutoSize = True
        L2.Location = New Point(198, 32)
        L2.Name = "L2"
        L2.Size = New Size(95, 20)
        L2.TabIndex = 2
        L2.Text = "Shear Length"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(25, 20)
        Label3.TabIndex = 3
        Label3.Text = "S1"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 71)
        Label4.Name = "Label4"
        Label4.Size = New Size(25, 20)
        Label4.TabIndex = 4
        Label4.Text = "S2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 109)
        Label5.Name = "Label5"
        Label5.Size = New Size(25, 20)
        Label5.TabIndex = 5
        Label5.Text = "S3"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(22, 149)
        Label6.Name = "Label6"
        Label6.Size = New Size(25, 20)
        Label6.TabIndex = 6
        Label6.Text = "S4"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(22, 192)
        Label7.Name = "Label7"
        Label7.Size = New Size(25, 20)
        Label7.TabIndex = 7
        Label7.Text = "S5"
        ' 
        ' PanelWidth
        ' 
        PanelWidth.Location = New Point(14, 56)
        PanelWidth.Margin = New Padding(3, 4, 3, 4)
        PanelWidth.Name = "PanelWidth"
        PanelWidth.Size = New Size(114, 27)
        PanelWidth.TabIndex = 8
        ' 
        ' PanelLenght
        ' 
        PanelLenght.Location = New Point(198, 56)
        PanelLenght.Margin = New Padding(3, 4, 3, 4)
        PanelLenght.Name = "PanelLenght"
        PanelLenght.Size = New Size(114, 27)
        PanelLenght.TabIndex = 9
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Location = New Point(14, 129)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(193, 232)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Side Lock Spacing"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(50, 184)
        TextBox5.Margin = New Padding(3, 4, 3, 4)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(114, 27)
        TextBox5.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(50, 145)
        TextBox4.Margin = New Padding(3, 4, 3, 4)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(114, 27)
        TextBox4.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(50, 105)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(114, 27)
        TextBox3.TabIndex = 10
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(50, 67)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(114, 27)
        TextBox2.TabIndex = 9
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(50, 28)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(114, 27)
        TextBox1.TabIndex = 8
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(CNT)
        GroupBox2.Controls.Add(OSMA)
        GroupBox2.Controls.Add(OSFE)
        GroupBox2.Location = New Point(330, 16)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(179, 148)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Panel Type"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(37, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 20)
        Label1.TabIndex = 3
        Label1.Text = "(Can be MA or FE)"
        ' 
        ' CNT
        ' 
        CNT.AutoSize = True
        CNT.Location = New Point(7, 95)
        CNT.Margin = New Padding(3, 4, 3, 4)
        CNT.Name = "CNT"
        CNT.Size = New Size(117, 24)
        CNT.TabIndex = 2
        CNT.Text = "Center Splice"
        CNT.UseVisualStyleBackColor = True
        ' 
        ' OSMA
        ' 
        OSMA.AutoSize = True
        OSMA.Checked = True
        OSMA.Location = New Point(7, 28)
        OSMA.Margin = New Padding(3, 4, 3, 4)
        OSMA.Name = "OSMA"
        OSMA.Size = New Size(162, 24)
        OSMA.TabIndex = 1
        OSMA.TabStop = True
        OSMA.Text = "Outside Male Splice"
        OSMA.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(EXT)
        GroupBox3.Controls.Add(INT)
        GroupBox3.Location = New Point(517, 16)
        GroupBox3.Margin = New Padding(3, 4, 3, 4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 4, 3, 4)
        GroupBox3.Size = New Size(113, 105)
        GroupBox3.TabIndex = 12
        GroupBox3.TabStop = False
        GroupBox3.Text = "Metal Type"
        ' 
        ' EXT
        ' 
        EXT.AutoSize = True
        EXT.Location = New Point(7, 59)
        EXT.Margin = New Padding(3, 4, 3, 4)
        EXT.Name = "EXT"
        EXT.Size = New Size(81, 24)
        EXT.TabIndex = 1
        EXT.Text = "Exterior"
        EXT.UseVisualStyleBackColor = True
        ' 
        ' INT
        ' 
        INT.AutoSize = True
        INT.Checked = True
        INT.Location = New Point(7, 25)
        INT.Margin = New Padding(3, 4, 3, 4)
        INT.Name = "INT"
        INT.Size = New Size(78, 24)
        INT.TabIndex = 0
        INT.TabStop = True
        INT.Text = "Interior"
        INT.UseVisualStyleBackColor = True
        ' 
        ' QRCode
        ' 
        QRCode.Location = New Point(305, 172)
        QRCode.Margin = New Padding(3, 4, 3, 4)
        QRCode.Name = "QRCode"
        QRCode.Size = New Size(184, 180)
        QRCode.SizeMode = PictureBoxSizeMode.Zoom
        QRCode.TabIndex = 13
        QRCode.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(240, 372)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(136, 68)
        Button1.TabIndex = 14
        Button1.Text = "Generate QR Code"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' SoftPartCheckBox
        ' 
        SoftPartCheckBox.AutoSize = True
        SoftPartCheckBox.Checked = True
        SoftPartCheckBox.CheckState = CheckState.Checked
        SoftPartCheckBox.Location = New Point(409, 372)
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
        DEV.Location = New Point(409, 415)
        DEV.Margin = New Padding(3, 4, 3, 4)
        DEV.Name = "DEV"
        DEV.Size = New Size(116, 24)
        DEV.TabIndex = 15
        DEV.Text = "Preview Only"
        DEV.UseVisualStyleBackColor = True
        ' 
        ' StringBox
        ' 
        StringBox.Location = New Point(21, 469)
        StringBox.Margin = New Padding(3, 4, 3, 4)
        StringBox.Multiline = True
        StringBox.Name = "StringBox"
        StringBox.Size = New Size(463, 169)
        StringBox.TabIndex = 16
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(531, 111)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(717, 543)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(14, 372)
        Label8.Name = "Label8"
        Label8.Size = New Size(210, 60)
        Label8.TabIndex = 19
        Label8.Text = "S1: flat distance from the edge." & vbCrLf & "S2-S5: spacing from the last lock." & vbCrLf & "Leave a box blank for no lock."
        ' 
        ' PN
        ' 
        PN.AutoSize = True
        PN.Location = New Point(35, 445)
        PN.Name = "PN"
        PN.Size = New Size(53, 20)
        PN.TabIndex = 20
        PN.Text = "Label9"
        PN.Visible = False
        ' 
        ' DEVTEXT
        ' 
        DEVTEXT.Location = New Point(367, 648)
        DEVTEXT.Margin = New Padding(3, 4, 3, 4)
        DEVTEXT.Name = "DEVTEXT"
        DEVTEXT.Size = New Size(102, 47)
        DEVTEXT.TabIndex = 21
        DEVTEXT.Text = "Edit String"
        DEVTEXT.UseVisualStyleBackColor = True
        DEVTEXT.Visible = False
        ' 
        ' FloorPanelForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1271, 740)
        Controls.Add(DEVTEXT)
        Controls.Add(PN)
        Controls.Add(Label8)
        Controls.Add(PictureBox1)
        Controls.Add(StringBox)
        Controls.Add(SoftPartCheckBox)
        Controls.Add(DEV)
        Controls.Add(Button1)
        Controls.Add(QRCode)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(PanelLenght)
        Controls.Add(PanelWidth)
        Controls.Add(L2)
        Controls.Add(L1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FloorPanelForm"
        Text = "Floor Panels"
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

    Friend WithEvents OSFE As RadioButton
    Friend WithEvents L1 As Label
    Friend WithEvents L2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PanelWidth As TextBox
    Friend WithEvents PanelLenght As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CNT As RadioButton
    Friend WithEvents OSMA As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents EXT As RadioButton
    Friend WithEvents INT As RadioButton
    Friend WithEvents QRCode As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SoftPartCheckBox As CheckBox
    Friend WithEvents DEV As CheckBox
    Friend WithEvents StringBox As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PN As Label
    Friend WithEvents DEVTEXT As Button
End Class
