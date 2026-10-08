Imports System.Drawing
Imports System.Windows.Forms

Public Class FoamDateDialog
    Inherits Form

    Private ReadOnly datePicker As New DateTimePicker()
    Private ReadOnly okButton As New Button()

    Public ReadOnly Property SelectedDate As Date
        Get
            Return datePicker.Value.Date
        End Get
    End Property

    Public Sub New()
        Text = "Select Foam Date"
        ClientSize = New Size(390, 175)
        FormBorderStyle = FormBorderStyle.FixedDialog
        StartPosition = FormStartPosition.CenterParent
        MaximizeBox = False
        MinimizeBox = False
        ShowInTaskbar = False
        AutoScaleMode = AutoScaleMode.Font

        Dim instructions As New Label With {
            .Text = "Select Foam Date",
            .AutoSize = False,
            .Location = New Point(18, 18),
            .Size = New Size(354, 36)
        }
        datePicker.Location = New Point(18, 62)
        datePicker.Size = New Size(220, 27)
        datePicker.Format = DateTimePickerFormat.Custom
        datePicker.CustomFormat = "MM/dd/yyyy"
        datePicker.ShowCheckBox = True
        datePicker.Value = Date.Today
        datePicker.Checked = False
        datePicker.TabIndex = 0

        okButton.Text = "OK"
        okButton.Location = New Point(196, 120)
        okButton.Size = New Size(80, 30)
        okButton.Enabled = False
        okButton.TabIndex = 1

        Dim cancelButton As New Button With {
            .Text = "Cancel",
            .Location = New Point(286, 120),
            .Size = New Size(85, 30),
            .DialogResult = DialogResult.Cancel,
            .TabIndex = 2
        }
        AddHandler datePicker.ValueChanged, AddressOf DateSelectionChanged
        AddHandler okButton.Click, AddressOf ConfirmDate
        Controls.AddRange(New Control() {instructions, datePicker, okButton, cancelButton})
        AcceptButton = okButton
        Me.CancelButton = cancelButton
    End Sub

    Private Sub DateSelectionChanged(sender As Object, e As EventArgs)
        okButton.Enabled = datePicker.Checked
    End Sub

    Private Sub ConfirmDate(sender As Object, e As EventArgs)
        If Not datePicker.Checked Then Return
        DialogResult = DialogResult.OK
    End Sub
End Class