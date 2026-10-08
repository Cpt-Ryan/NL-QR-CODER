<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CeilingPanelForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CeilingPanelForm))
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
        SoftPartCheckBox = New CheckBox()
        DEV = New CheckBox()
        Label3 = New Label()
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
        Label2.Location = New Point(158, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 20)
        Label2.TabIndex = 5
        Label2.Text = "Shear Length"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 20)
        Label1.TabIndex = 4
        Label1.Text = "Shear Width"
        ' 
        ' PanelWidth
        ' 
        PanelWidth.Location = New Point(14, 48)
        PanelWidth.Margin = New Padding(3, 4, 3, 4)
        PanelWidth.Name = "PanelWidth"
        PanelWidth.Size = New Size(114, 27)
        PanelWidth.TabIndex = 6
        ' 
        ' PanelLenght
        ' 
        PanelLenght.Location = New Point(158, 48)
        PanelLenght.Margin = New Padding(3, 4, 3, 4)
        PanelLenght.Name = "PanelLenght"
        PanelLenght.Size = New Size(114, 27)
        PanelLenght.TabIndex = 7
        ' 
        ' PanelType
        ' 
        PanelType.Controls.Add(CNT)
        PanelType.Controls.Add(OSFE)
        PanelType.Controls.Add(OSMA)
        PanelType.Location = New Point(323, 16)
        PanelType.Margin = New Padding(3, 4, 3, 4)
        PanelType.Name = "PanelType"
        PanelType.Padding = New Padding(3, 4, 3, 4)
        PanelType.Size = New Size(229, 133)
        PanelType.TabIndex = 8
        PanelType.TabStop = False
        PanelType.Text = "Panel Type"
        ' 
        ' CNT
        ' 
        CNT.AutoSize = True
        CNT.Location = New Point(9, 92)
        CNT.Margin = New Padding(3, 4, 3, 4)
        CNT.Name = "CNT"
        CNT.Size = New Size(73, 24)
        CNT.TabIndex = 2
        CNT.Text = "Center"
        CNT.UseVisualStyleBackColor = True
        ' 
        ' OSFE
        ' 
        OSFE.AutoSize = True
        OSFE.Location = New Point(9, 59)
        OSFE.Margin = New Padding(3, 4, 3, 4)
        OSFE.Name = "OSFE"
        OSFE.Size = New Size(133, 24)
        OSFE.TabIndex = 1
        OSFE.Text = "Outside Female"
        OSFE.UseVisualStyleBackColor = True
        ' 
        ' OSMA
        ' 
        OSMA.AutoSize = True
        OSMA.Checked = True
        OSMA.Location = New Point(9, 25)
        OSMA.Margin = New Padding(3, 4, 3, 4)
        OSMA.Name = "OSMA"
        OSMA.Size = New Size(118, 24)
        OSMA.TabIndex = 0
        OSMA.TabStop = True
        OSMA.Text = "Outside Male"
        OSMA.UseVisualStyleBackColor = True
        ' 
        ' MetalType
        ' 
        MetalType.Controls.Add(EXT)
        MetalType.Controls.Add(INT)
        MetalType.Location = New Point(570, 16)
        MetalType.Margin = New Padding(3, 4, 3, 4)
        MetalType.Name = "MetalType"
        MetalType.Padding = New Padding(3, 4, 3, 4)
        MetalType.Size = New Size(103, 99)
        MetalType.TabIndex = 9
        MetalType.TabStop = False
        MetalType.Text = "Metal Type"
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
        ' S1
        ' 
        S1.AutoSize = True
        S1.Location = New Point(22, 35)
        S1.Name = "S1"
        S1.Size = New Size(25, 20)
        S1.TabIndex = 10
        S1.Text = "S1"
        ' 
        ' S2
        ' 
        S2.AutoSize = True
        S2.Location = New Point(22, 76)
        S2.Name = "S2"
        S2.Size = New Size(25, 20)
        S2.TabIndex = 11
        S2.Text = "S2"
        ' 
        ' S3
        ' 
        S3.AutoSize = True
        S3.Location = New Point(22, 115)
        S3.Name = "S3"
        S3.Size = New Size(25, 20)
        S3.TabIndex = 12
        S3.Text = "S3"
        ' 
        ' S4
        ' 
        S4.AutoSize = True
        S4.Location = New Point(22, 153)
        S4.Name = "S4"
        S4.Size = New Size(25, 20)
        S4.TabIndex = 13
        S4.Text = "S4"
        ' 
        ' S5
        ' 
        S5.AutoSize = True
        S5.Location = New Point(22, 192)
        S5.Name = "S5"
        S5.Size = New Size(25, 20)
        S5.TabIndex = 14
        S5.Text = "S5"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(50, 31)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(114, 27)
        TextBox1.TabIndex = 15
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(50, 69)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(114, 27)
        TextBox2.TabIndex = 16
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(50, 108)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(114, 27)
        TextBox3.TabIndex = 17
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(50, 147)
        TextBox4.Margin = New Padding(3, 4, 3, 4)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(114, 27)
        TextBox4.TabIndex = 18
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(50, 185)
        TextBox5.Margin = New Padding(3, 4, 3, 4)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(114, 27)
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
        GroupBox1.Location = New Point(14, 177)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(200, 239)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "Side Lock Spacing"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(224, 389)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(145, 61)
        Button1.TabIndex = 21
        Button1.Text = "Generate QR Code"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' StringBox
        ' 
        StringBox.Location = New Point(14, 476)
        StringBox.Margin = New Padding(3, 4, 3, 4)
        StringBox.Multiline = True
        StringBox.Name = "StringBox"
        StringBox.Size = New Size(427, 145)
        StringBox.TabIndex = 22
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(525, 173)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(705, 567)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' QRCode
        ' 
        QRCode.Location = New Point(275, 177)
        QRCode.Margin = New Padding(3, 4, 3, 4)
        QRCode.Name = "QRCode"
        QRCode.Size = New Size(179, 189)
        QRCode.SizeMode = PictureBoxSizeMode.Zoom
        QRCode.TabIndex = 24
        QRCode.TabStop = False
        ' 
        ' SoftPartCheckBox
        ' 
        SoftPartCheckBox.AutoSize = True
        SoftPartCheckBox.Checked = True
        SoftPartCheckBox.CheckState = CheckState.Checked
        SoftPartCheckBox.Location = New Point(394, 389)
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
        DEV.Location = New Point(394, 427)
        DEV.Margin = New Padding(3, 4, 3, 4)
        DEV.Name = "DEV"
        DEV.Size = New Size(116, 24)
        DEV.TabIndex = 25
        DEV.Text = "Preview Only"
        DEV.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(210, 60)
        Label3.TabIndex = 26
        Label3.Text = "S1: flat distance from the edge." & vbCrLf & "S2-S5: spacing from the last lock." & vbCrLf & "Leave a box blank for no lock."
        ' 
        ' Thickness
        ' 
        Thickness.AutoSize = True
        Thickness.Location = New Point(577, 123)
        Thickness.Margin = New Padding(3, 4, 3, 4)
        Thickness.Name = "Thickness"
        Thickness.Size = New Size(111, 24)
        Thickness.TabIndex = 35
        Thickness.Text = "5"" Thickness"
        Thickness.UseVisualStyleBackColor = True
        ' 
        ' DEVTEXT
        ' 
        DEVTEXT.Location = New Point(333, 631)
        DEVTEXT.Margin = New Padding(3, 4, 3, 4)
        DEVTEXT.Name = "DEVTEXT"
        DEVTEXT.Size = New Size(109, 51)
        DEVTEXT.TabIndex = 36
        DEVTEXT.Text = "Edit String"
        DEVTEXT.UseVisualStyleBackColor = True
        DEVTEXT.Visible = False
        ' 
        ' PN
        ' 
        PN.AutoSize = True
        PN.Location = New Point(14, 452)
        PN.Name = "PN"
        PN.Size = New Size(53, 20)
        PN.TabIndex = 38
        PN.Text = "Label8"
        PN.Visible = False
        ' 
        ' CeilingPanelForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1276, 767)
        Controls.Add(PN)
        Controls.Add(DEVTEXT)
        Controls.Add(Thickness)
        Controls.Add(Label3)
        Controls.Add(SoftPartCheckBox)
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
        Margin = New Padding(3, 4, 3, 4)
        Name = "CeilingPanelForm"
        Text = "Ceiling Panels"
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
    Friend WithEvents SoftPartCheckBox As CheckBox
    Friend WithEvents DEV As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Thickness As CheckBox
    Friend WithEvents DEVTEXT As Button
    Friend WithEvents PN As Label
End Class
