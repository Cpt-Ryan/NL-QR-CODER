<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        GroupBox1 = New GroupBox()
        DEVSTR = New RadioButton()
        TeesRB = New RadioButton()
        CornerRB = New RadioButton()
        FloorsRB = New RadioButton()
        CeilingRB = New RadioButton()
        WallsRB = New RadioButton()
        Button1 = New Button()
        QRCode = New PictureBox()
        FoundPartLabel = New Label()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        FindPN = New TextBox()
        Label1 = New Label()
        Button2 = New Button()
        GroupBox1.SuspendLayout()
        CType(QRCode, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DEVSTR)
        GroupBox1.Controls.Add(TeesRB)
        GroupBox1.Controls.Add(CornerRB)
        GroupBox1.Controls.Add(FloorsRB)
        GroupBox1.Controls.Add(CeilingRB)
        GroupBox1.Controls.Add(WallsRB)
        GroupBox1.Location = New Point(32, 27)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(279, 239)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Panel Type"
        ' 
        ' DEVSTR
        ' 
        DEVSTR.AutoSize = True
        DEVSTR.Location = New Point(16, 197)
        DEVSTR.Margin = New Padding(3, 4, 3, 4)
        DEVSTR.Name = "DEVSTR"
        DEVSTR.Size = New Size(116, 24)
        DEVSTR.TabIndex = 5
        DEVSTR.TabStop = True
        DEVSTR.Text = "StringBuilder"
        DEVSTR.UseVisualStyleBackColor = True
        ' 
        ' TeesRB
        ' 
        TeesRB.AutoSize = True
        TeesRB.Location = New Point(16, 164)
        TeesRB.Margin = New Padding(3, 4, 3, 4)
        TeesRB.Name = "TeesRB"
        TeesRB.Size = New Size(59, 24)
        TeesRB.TabIndex = 4
        TeesRB.TabStop = True
        TeesRB.Text = "Tees"
        TeesRB.UseVisualStyleBackColor = True
        ' 
        ' CornerRB
        ' 
        CornerRB.AutoSize = True
        CornerRB.Location = New Point(16, 131)
        CornerRB.Margin = New Padding(3, 4, 3, 4)
        CornerRB.Name = "CornerRB"
        CornerRB.Size = New Size(80, 24)
        CornerRB.TabIndex = 3
        CornerRB.TabStop = True
        CornerRB.Text = "Corners"
        CornerRB.UseVisualStyleBackColor = True
        ' 
        ' FloorsRB
        ' 
        FloorsRB.AutoSize = True
        FloorsRB.Location = New Point(17, 100)
        FloorsRB.Margin = New Padding(3, 4, 3, 4)
        FloorsRB.Name = "FloorsRB"
        FloorsRB.Size = New Size(70, 24)
        FloorsRB.TabIndex = 2
        FloorsRB.TabStop = True
        FloorsRB.Text = "Floors"
        FloorsRB.UseVisualStyleBackColor = True
        ' 
        ' CeilingRB
        ' 
        CeilingRB.AutoSize = True
        CeilingRB.Location = New Point(17, 67)
        CeilingRB.Margin = New Padding(3, 4, 3, 4)
        CeilingRB.Name = "CeilingRB"
        CeilingRB.Size = New Size(76, 24)
        CeilingRB.TabIndex = 1
        CeilingRB.TabStop = True
        CeilingRB.Text = "Ceiling"
        CeilingRB.UseVisualStyleBackColor = True
        ' 
        ' WallsRB
        ' 
        WallsRB.AutoSize = True
        WallsRB.Location = New Point(17, 33)
        WallsRB.Margin = New Padding(3, 4, 3, 4)
        WallsRB.Name = "WallsRB"
        WallsRB.Size = New Size(65, 24)
        WallsRB.TabIndex = 0
        WallsRB.TabStop = True
        WallsRB.Text = "Walls"
        WallsRB.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(338, 107)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 64)
        Button1.TabIndex = 2
        Button1.Text = "Enter Size"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' QRCode
        ' 
        FoundPartLabel.Location = New Point(521, 305)
        FoundPartLabel.Name = "FoundPartLabel"
        FoundPartLabel.Size = New Size(277, 24)
        FoundPartLabel.TextAlign = ContentAlignment.MiddleLeft
        FoundPartLabel.AutoEllipsis = True
        FoundPartLabel.UseMnemonic = False
        FoundPartLabel.Visible = False
        QRCode.Location = New Point(521, 335)
        QRCode.Name = "QRCode"
        QRCode.Size = New Size(277, 215)
        QRCode.TabIndex = 3
        QRCode.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(GroupBox1)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Location = New Point(12, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(531, 287)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Generate QR Code"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Button2)
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Controls.Add(FindPN)
        GroupBox3.Location = New Point(12, 319)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(477, 166)
        GroupBox3.TabIndex = 6
        GroupBox3.TabStop = False
        GroupBox3.Text = "Find QR Code"
        ' 
        ' FindPN
        ' 
        FindPN.Location = New Point(44, 85)
        FindPN.Name = "FindPN"
        FindPN.Size = New Size(157, 27)
        FindPN.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 20)
        Label1.TabIndex = 1
        Label1.Text = "Part Number"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(267, 50)
        Button2.Name = "Button2"
        Button2.Size = New Size(121, 62)
        Button2.TabIndex = 2
        Button2.Text = "Find QR Code"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1004, 562)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(FoundPartLabel)
        Controls.Add(QRCode)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "QR Code Application"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(QRCode, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FloorsRB As RadioButton
    Friend WithEvents CeilingRB As RadioButton
    Friend WithEvents WallsRB As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents CornerRB As RadioButton
    Friend WithEvents TeesRB As RadioButton
    Friend WithEvents DEVSTR As RadioButton
    Friend WithEvents QRCode As PictureBox
    Friend WithEvents FoundPartLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FindPN As TextBox
    Friend WithEvents Button2 As Button
End Class
