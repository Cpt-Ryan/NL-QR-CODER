<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelTypeGroupBox = New GroupBox()
        DEVSTR = New RadioButton()
        TeesRB = New RadioButton()
        CornerRB = New RadioButton()
        FloorsRB = New RadioButton()
        CeilingRB = New RadioButton()
        WallsRB = New RadioButton()
        OpenPanelButton = New Button()
        QrCodePictureBox = New PictureBox()
        FoundPartLabel = New Label()
        GenerateQrCodeGroupBox = New GroupBox()
        FindQrCodeGroupBox = New GroupBox()
        FindQrCodeButton = New Button()
        PartNumberLabel = New Label()
        PartNumberTextBox = New TextBox()
        PanelTypeGroupBox.SuspendLayout()
        CType(QrCodePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        GenerateQrCodeGroupBox.SuspendLayout()
        FindQrCodeGroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelTypeGroupBox
        ' 
        PanelTypeGroupBox.Controls.Add(DEVSTR)
        PanelTypeGroupBox.Controls.Add(TeesRB)
        PanelTypeGroupBox.Controls.Add(CornerRB)
        PanelTypeGroupBox.Controls.Add(FloorsRB)
        PanelTypeGroupBox.Controls.Add(CeilingRB)
        PanelTypeGroupBox.Controls.Add(WallsRB)
        PanelTypeGroupBox.Location = New Point(32, 27)
        PanelTypeGroupBox.Margin = New Padding(3, 4, 3, 4)
        PanelTypeGroupBox.Name = "PanelTypeGroupBox"
        PanelTypeGroupBox.Padding = New Padding(3, 4, 3, 4)
        PanelTypeGroupBox.Size = New Size(279, 239)
        PanelTypeGroupBox.TabIndex = 0
        PanelTypeGroupBox.TabStop = False
        PanelTypeGroupBox.Text = "Panel Type"
        ' 
        ' DEVSTR
        ' 
        DEVSTR.AutoSize = True
        DEVSTR.Location = New Point(16, 197)
        DEVSTR.Margin = New Padding(3, 4, 3, 4)
        DEVSTR.Name = "DEVSTR"
        DEVSTR.Size = New Size(113, 24)
        DEVSTR.TabIndex = 5
        DEVSTR.TabStop = True
        DEVSTR.Text = "String Editor"
        DEVSTR.UseVisualStyleBackColor = True
        ' 
        ' TeesRB
        ' 
        TeesRB.AutoSize = True
        TeesRB.Location = New Point(16, 164)
        TeesRB.Margin = New Padding(3, 4, 3, 4)
        TeesRB.Name = "TeesRB"
        TeesRB.Size = New Size(98, 24)
        TeesRB.TabIndex = 4
        TeesRB.TabStop = True
        TeesRB.Text = "Tee Panels"
        TeesRB.UseVisualStyleBackColor = True
        ' 
        ' CornerRB
        ' 
        CornerRB.AutoSize = True
        CornerRB.Location = New Point(16, 131)
        CornerRB.Margin = New Padding(3, 4, 3, 4)
        CornerRB.Name = "CornerRB"
        CornerRB.Size = New Size(119, 24)
        CornerRB.TabIndex = 3
        CornerRB.TabStop = True
        CornerRB.Text = "Corner Panels"
        CornerRB.UseVisualStyleBackColor = True
        ' 
        ' FloorsRB
        ' 
        FloorsRB.AutoSize = True
        FloorsRB.Location = New Point(17, 100)
        FloorsRB.Margin = New Padding(3, 4, 3, 4)
        FloorsRB.Name = "FloorsRB"
        FloorsRB.Size = New Size(109, 24)
        FloorsRB.TabIndex = 2
        FloorsRB.TabStop = True
        FloorsRB.Text = "Floor Panels"
        FloorsRB.UseVisualStyleBackColor = True
        ' 
        ' CeilingRB
        ' 
        CeilingRB.AutoSize = True
        CeilingRB.Location = New Point(17, 67)
        CeilingRB.Margin = New Padding(3, 4, 3, 4)
        CeilingRB.Name = "CeilingRB"
        CeilingRB.Size = New Size(121, 24)
        CeilingRB.TabIndex = 1
        CeilingRB.TabStop = True
        CeilingRB.Text = "Ceiling Panels"
        CeilingRB.UseVisualStyleBackColor = True
        ' 
        ' WallsRB
        ' 
        WallsRB.AutoSize = True
        WallsRB.Location = New Point(17, 33)
        WallsRB.Margin = New Padding(3, 4, 3, 4)
        WallsRB.Name = "WallsRB"
        WallsRB.Size = New Size(104, 24)
        WallsRB.TabIndex = 0
        WallsRB.TabStop = True
        WallsRB.Text = "Wall Panels"
        WallsRB.UseVisualStyleBackColor = True
        ' 
        ' OpenPanelButton
        ' 
        OpenPanelButton.Location = New Point(338, 107)
        OpenPanelButton.Margin = New Padding(3, 4, 3, 4)
        OpenPanelButton.Name = "OpenPanelButton"
        OpenPanelButton.Size = New Size(150, 64)
        OpenPanelButton.TabIndex = 2
        OpenPanelButton.Text = "Configure Sheet Metal"
        OpenPanelButton.UseVisualStyleBackColor = True
        ' 
        ' QrCodePictureBox
        ' 
        QrCodePictureBox.Location = New Point(620, 270)
        QrCodePictureBox.Name = "QrCodePictureBox"
        QrCodePictureBox.Size = New Size(277, 215)
        QrCodePictureBox.TabIndex = 3
        QrCodePictureBox.TabStop = False
        ' 
        ' FoundPartLabel
        ' 
        FoundPartLabel.AutoEllipsis = True
        FoundPartLabel.Location = New Point(648, 236)
        FoundPartLabel.Name = "FoundPartLabel"
        FoundPartLabel.Size = New Size(277, 24)
        FoundPartLabel.TabIndex = 7
        FoundPartLabel.TextAlign = ContentAlignment.MiddleLeft
        FoundPartLabel.UseMnemonic = False
        FoundPartLabel.Visible = False
        ' 
        ' GenerateQrCodeGroupBox
        ' 
        GenerateQrCodeGroupBox.Controls.Add(PanelTypeGroupBox)
        GenerateQrCodeGroupBox.Controls.Add(OpenPanelButton)
        GenerateQrCodeGroupBox.Location = New Point(12, 12)
        GenerateQrCodeGroupBox.Name = "GenerateQrCodeGroupBox"
        GenerateQrCodeGroupBox.Size = New Size(531, 287)
        GenerateQrCodeGroupBox.TabIndex = 5
        GenerateQrCodeGroupBox.TabStop = False
        GenerateQrCodeGroupBox.Text = "Generate QR Code"
        ' 
        ' FindQrCodeGroupBox
        ' 
        FindQrCodeGroupBox.Controls.Add(FindQrCodeButton)
        FindQrCodeGroupBox.Controls.Add(PartNumberLabel)
        FindQrCodeGroupBox.Controls.Add(PartNumberTextBox)
        FindQrCodeGroupBox.Location = New Point(12, 319)
        FindQrCodeGroupBox.Name = "FindQrCodeGroupBox"
        FindQrCodeGroupBox.Size = New Size(477, 166)
        FindQrCodeGroupBox.TabIndex = 6
        FindQrCodeGroupBox.TabStop = False
        FindQrCodeGroupBox.Text = "Find QR Code"
        ' 
        ' FindQrCodeButton
        ' 
        FindQrCodeButton.Location = New Point(267, 50)
        FindQrCodeButton.Name = "FindQrCodeButton"
        FindQrCodeButton.Size = New Size(121, 62)
        FindQrCodeButton.TabIndex = 2
        FindQrCodeButton.Text = "Find QR Code"
        FindQrCodeButton.UseVisualStyleBackColor = True
        ' 
        ' PartNumberLabel
        ' 
        PartNumberLabel.AutoSize = True
        PartNumberLabel.Location = New Point(44, 50)
        PartNumberLabel.Name = "PartNumberLabel"
        PartNumberLabel.Size = New Size(92, 20)
        PartNumberLabel.TabIndex = 1
        PartNumberLabel.Text = "Part Number"
        ' 
        ' PartNumberTextBox
        ' 
        PartNumberTextBox.Location = New Point(44, 85)
        PartNumberTextBox.Name = "PartNumberTextBox"
        PartNumberTextBox.Size = New Size(157, 27)
        PartNumberTextBox.TabIndex = 0
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1004, 562)
        Controls.Add(FindQrCodeGroupBox)
        Controls.Add(GenerateQrCodeGroupBox)
        Controls.Add(FoundPartLabel)
        Controls.Add(QrCodePictureBox)
        Margin = New Padding(3, 4, 3, 4)
        Name = "MainForm"
        Text = "QR Code Manager"
        PanelTypeGroupBox.ResumeLayout(False)
        PanelTypeGroupBox.PerformLayout()
        CType(QrCodePictureBox, ComponentModel.ISupportInitialize).EndInit()
        GenerateQrCodeGroupBox.ResumeLayout(False)
        FindQrCodeGroupBox.ResumeLayout(False)
        FindQrCodeGroupBox.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelTypeGroupBox As GroupBox
    Friend WithEvents FloorsRB As RadioButton
    Friend WithEvents CeilingRB As RadioButton
    Friend WithEvents WallsRB As RadioButton
    Friend WithEvents OpenPanelButton As Button
    Friend WithEvents CornerRB As RadioButton
    Friend WithEvents TeesRB As RadioButton
    Friend WithEvents DEVSTR As RadioButton
    Friend WithEvents QrCodePictureBox As PictureBox
    Friend WithEvents FoundPartLabel As Label
    Friend WithEvents GenerateQrCodeGroupBox As GroupBox
    Friend WithEvents FindQrCodeGroupBox As GroupBox
    Friend WithEvents PartNumberLabel As Label
    Friend WithEvents PartNumberTextBox As TextBox
    Friend WithEvents FindQrCodeButton As Button
End Class
