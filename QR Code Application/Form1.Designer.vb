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
        GroupBox1.SuspendLayout()
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
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(244, 179)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Panel Type"
        ' 
        ' DEVSTR
        ' 
        DEVSTR.AutoSize = True
        DEVSTR.Location = New Point(14, 148)
        DEVSTR.Name = "DEVSTR"
        DEVSTR.Size = New Size(93, 19)
        DEVSTR.TabIndex = 5
        DEVSTR.TabStop = True
        DEVSTR.Text = "StringBuilder"
        DEVSTR.UseVisualStyleBackColor = True
        ' 
        ' TeesRB
        ' 
        TeesRB.AutoSize = True
        TeesRB.Location = New Point(14, 123)
        TeesRB.Name = "TeesRB"
        TeesRB.Size = New Size(47, 19)
        TeesRB.TabIndex = 4
        TeesRB.TabStop = True
        TeesRB.Text = "Tees"
        TeesRB.UseVisualStyleBackColor = True
        ' 
        ' CornerRB
        ' 
        CornerRB.AutoSize = True
        CornerRB.Location = New Point(14, 98)
        CornerRB.Name = "CornerRB"
        CornerRB.Size = New Size(66, 19)
        CornerRB.TabIndex = 3
        CornerRB.TabStop = True
        CornerRB.Text = "Corners"
        CornerRB.UseVisualStyleBackColor = True
        ' 
        ' FloorsRB
        ' 
        FloorsRB.AutoSize = True
        FloorsRB.Location = New Point(15, 75)
        FloorsRB.Name = "FloorsRB"
        FloorsRB.Size = New Size(57, 19)
        FloorsRB.TabIndex = 2
        FloorsRB.TabStop = True
        FloorsRB.Text = "Floors"
        FloorsRB.UseVisualStyleBackColor = True
        ' 
        ' CeilingRB
        ' 
        CeilingRB.AutoSize = True
        CeilingRB.Location = New Point(15, 50)
        CeilingRB.Name = "CeilingRB"
        CeilingRB.Size = New Size(62, 19)
        CeilingRB.TabIndex = 1
        CeilingRB.TabStop = True
        CeilingRB.Text = "Ceiling"
        CeilingRB.UseVisualStyleBackColor = True
        ' 
        ' WallsRB
        ' 
        WallsRB.AutoSize = True
        WallsRB.Location = New Point(15, 25)
        WallsRB.Name = "WallsRB"
        WallsRB.Size = New Size(53, 19)
        WallsRB.TabIndex = 0
        WallsRB.TabStop = True
        WallsRB.Text = "Walls"
        WallsRB.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(262, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 48)
        Button1.TabIndex = 2
        Button1.Text = "Enter Size"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(453, 203)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "QR Code Application"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
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
End Class
