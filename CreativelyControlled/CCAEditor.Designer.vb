<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CCAEditor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CCAEditor))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.kindShellExec = New System.Windows.Forms.RadioButton()
        Me.kindKeys = New System.Windows.Forms.RadioButton()
        Me.shellExecField = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.kindMsg = New System.Windows.Forms.RadioButton()
        Me.keyField = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.msgField = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameField = New System.Windows.Forms.TextBox()
        Me.opener = New System.Windows.Forms.OpenFileDialog()
        Me.keypress = New System.Windows.Forms.RadioButton()
        Me.singlekey = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 267)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'kindShellExec
        '
        Me.kindShellExec.AutoSize = True
        Me.kindShellExec.Checked = True
        Me.kindShellExec.Location = New System.Drawing.Point(12, 41)
        Me.kindShellExec.Name = "kindShellExec"
        Me.kindShellExec.Size = New System.Drawing.Size(90, 17)
        Me.kindShellExec.TabIndex = 1
        Me.kindShellExec.TabStop = True
        Me.kindShellExec.Text = "Shell Execute"
        Me.kindShellExec.UseVisualStyleBackColor = True
        '
        'kindKeys
        '
        Me.kindKeys.AutoSize = True
        Me.kindKeys.Location = New System.Drawing.Point(13, 90)
        Me.kindKeys.Name = "kindKeys"
        Me.kindKeys.Size = New System.Drawing.Size(73, 17)
        Me.kindKeys.TabIndex = 2
        Me.kindKeys.Text = "Type Text"
        Me.kindKeys.UseVisualStyleBackColor = True
        '
        'shellExecField
        '
        Me.shellExecField.Location = New System.Drawing.Point(12, 64)
        Me.shellExecField.Name = "shellExecField"
        Me.shellExecField.Size = New System.Drawing.Size(358, 20)
        Me.shellExecField.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(376, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'kindMsg
        '
        Me.kindMsg.AutoSize = True
        Me.kindMsg.Location = New System.Drawing.Point(12, 153)
        Me.kindMsg.Name = "kindMsg"
        Me.kindMsg.Size = New System.Drawing.Size(114, 17)
        Me.kindMsg.TabIndex = 5
        Me.kindMsg.TabStop = True
        Me.kindMsg.Text = "Show messagebox"
        Me.kindMsg.UseVisualStyleBackColor = True
        '
        'keyField
        '
        Me.keyField.Location = New System.Drawing.Point(13, 114)
        Me.keyField.Name = "keyField"
        Me.keyField.Size = New System.Drawing.Size(407, 20)
        Me.keyField.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.keyField, resources.GetString("keyField.ToolTip"))
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 137)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(184, 13)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Supports the SendKeys replacements"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(294, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Shift is +, Ctrl is ^, Alt is %"
        Me.ToolTip1.SetToolTip(Me.Label1, resources.GetString("Label1.ToolTip"))
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 1000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        '
        'msgField
        '
        Me.msgField.Location = New System.Drawing.Point(15, 177)
        Me.msgField.Name = "msgField"
        Me.msgField.Size = New System.Drawing.Size(405, 20)
        Me.msgField.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Name"
        '
        'nameField
        '
        Me.nameField.Location = New System.Drawing.Point(55, 10)
        Me.nameField.Name = "nameField"
        Me.nameField.Size = New System.Drawing.Size(368, 20)
        Me.nameField.TabIndex = 11
        '
        'opener
        '
        Me.opener.FileName = "OpenFileDialog1"
        Me.opener.Title = "Browse for file"
        '
        'keypress
        '
        Me.keypress.AutoSize = True
        Me.keypress.Location = New System.Drawing.Point(12, 209)
        Me.keypress.Name = "keypress"
        Me.keypress.Size = New System.Drawing.Size(77, 17)
        Me.keypress.TabIndex = 12
        Me.keypress.TabStop = True
        Me.keypress.Text = "Single key:"
        Me.keypress.UseVisualStyleBackColor = True
        '
        'singlekey
        '
        Me.singlekey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.singlekey.FormattingEnabled = True
        Me.singlekey.Location = New System.Drawing.Point(95, 208)
        Me.singlekey.Name = "singlekey"
        Me.singlekey.Size = New System.Drawing.Size(325, 21)
        Me.singlekey.TabIndex = 13
        '
        'CCAEditor
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 308)
        Me.Controls.Add(Me.singlekey)
        Me.Controls.Add(Me.keypress)
        Me.Controls.Add(Me.nameField)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.msgField)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.keyField)
        Me.Controls.Add(Me.kindMsg)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.shellExecField)
        Me.Controls.Add(Me.kindKeys)
        Me.Controls.Add(Me.kindShellExec)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CCAEditor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Action"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents kindShellExec As System.Windows.Forms.RadioButton
    Friend WithEvents kindKeys As System.Windows.Forms.RadioButton
    Friend WithEvents shellExecField As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents kindMsg As System.Windows.Forms.RadioButton
    Friend WithEvents keyField As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents msgField As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nameField As System.Windows.Forms.TextBox
    Friend WithEvents opener As System.Windows.Forms.OpenFileDialog
    Friend WithEvents keypress As System.Windows.Forms.RadioButton
    Friend WithEvents singlekey As System.Windows.Forms.ComboBox

End Class
