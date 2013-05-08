Imports System.Windows.Forms

Public Class CCAEditor
    Public Property editingItem As CCAction
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If nameField.Text = "<BUTTON>" Then
            MsgBox("Disallowed name", MsgBoxStyle.Exclamation, "Oops")
            Return
        End If
        editingItem.name = nameField.Text
        If kindKeys.Checked Then
            editingItem.Type = CCAction.CCAType.CCAKeyEmulationType
            editingItem.Parameter = keyField.Text
        End If
        If kindMsg.Checked Then
            editingItem.Type = CCAction.CCAType.CCADebugMessageType
            editingItem.Parameter = msgField.Text
        End If
        If kindShellExec.Checked Then
            editingItem.Type = CCAction.CCAType.CCAExecuteType
            editingItem.Parameter = shellExecField.Text
        End If
        If keypress.Checked Then
            editingItem.Type = CCAction.CCAType.CCAKeyPressType
            editingItem.Parameter = singlekey.SelectedItem
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CCAEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("To specify that any combination of SHIFT, CTRL, and ALT should be held down while several other keys are pressed, enclose the code for those keys in parentheses. For example, to specify to hold down SHIFT while E and C are pressed, use +(EC). To specify to hold down SHIFT while E is pressed, followed by C without SHIFT, use +EC. The plus sign (+), caret (^), percent sign (%), tilde (~), and parentheses () have special meanings to SendKeys. To specify one of these characters, enclose it within braces ({}). For example, to specify the plus sign, use {+}. To specify brace characters, use {{} and {}}. Brackets ([ ]) have no special meaning to SendKeys, but you must enclose them in braces. ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Help")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If opener.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            shellExecField.Text = opener.FileName
        End If

    End Sub

    Private Sub CCAEditor_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        nameField.Text = editingItem.name

        For Each a As String In System.Enum.GetNames(GetType(Keys))
            If a <> "Modifiers" Then singlekey.Items.Add(a)
        Next
        Select Case editingItem.Type
            Case CCAction.CCAType.CCADebugMessageType
                kindMsg.Checked = True
                kindKeys.Checked = False
                kindShellExec.Checked = False
                keypress.Checked = False
                msgField.Text = editingItem.Parameter

            Case CCAction.CCAType.CCAExecuteType
                kindMsg.Checked = False
                kindKeys.Checked = False
                kindShellExec.Checked = True
                keypress.Checked = False
                shellExecField.Text = editingItem.Parameter

            Case CCAction.CCAType.CCAKeyEmulationType
                kindMsg.Checked = False
                kindKeys.Checked = True
                kindShellExec.Checked = False
                keypress.Checked = False
                keyField.Text = editingItem.Parameter

            Case CCAction.CCAType.CCAKeyPressType
                kindMsg.Checked = False
                kindKeys.Checked = False
                kindShellExec.Checked = False
                keypress.Checked = True
                singlekey.SelectedItem = editingItem.Parameter

        End Select
    End Sub

    Private Sub shellExecField_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shellExecField.TextChanged
        kindMsg.Checked = False
        kindKeys.Checked = False
        kindShellExec.Checked = True
        keypress.Checked = False
        If nameField.Text = "My Action" Then nameField.Text = "Execute file"
    End Sub

    Private Sub keyField_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keyField.TextChanged
        kindMsg.Checked = False
        kindKeys.Checked = True
        kindShellExec.Checked = False
        keypress.Checked = False
        If nameField.Text = "My Action" Then nameField.Text = keyField.Text
    End Sub

    Private Sub singlekey_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles singlekey.SelectedIndexChanged
        kindMsg.Checked = False
        kindKeys.Checked = False
        kindShellExec.Checked = False
        keypress.Checked = True
        If nameField.Text = "My Action" Then nameField.Text = singlekey.SelectedItem
    End Sub

    Private Sub msgField_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msgField.TextChanged
        kindMsg.Checked = True
        kindKeys.Checked = False
        kindShellExec.Checked = False
        keypress.Checked = False
        If nameField.Text = "My Action" Then nameField.Text = msgField.Text
    End Sub
End Class
