<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Text
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
        TextBox1 = New TextBox()
        Button1 = New Button()
        QRCode = New PictureBox()
        DEV = New CheckBox()
        Label1 = New Label()
        CType(QRCode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 31)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(396, 164)
        TextBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(427, 108)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 48)
        Button1.TabIndex = 1
        Button1.Text = "Generate QR Code"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' QRCode
        ' 
        QRCode.Location = New Point(570, 47)
        QRCode.Name = "QRCode"
        QRCode.Size = New Size(158, 147)
        QRCode.SizeMode = PictureBoxSizeMode.Zoom
        QRCode.TabIndex = 2
        QRCode.TabStop = False
        ' 
        ' DEV
        ' 
        DEV.AutoSize = True
        DEV.Location = New Point(427, 175)
        DEV.Name = "DEV"
        DEV.Size = New Size(70, 19)
        DEV.TabIndex = 3
        DEV.Text = "DEV Test"
        DEV.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 4
        Label1.Text = "Label1"
        ' 
        ' Edit_Text
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 265)
        Controls.Add(Label1)
        Controls.Add(DEV)
        Controls.Add(QRCode)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Name = "Edit_Text"
        Text = "Dev Environment"
        CType(QRCode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents QRCode As PictureBox
    Friend WithEvents DEV As CheckBox
    Friend WithEvents Label1 As Label
End Class
