<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.deviceList = New System.Windows.Forms.ComboBox()
        Me.startstop = New System.Windows.Forms.Button()
        Me.taskbarIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.curDev = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowCreativelyControlledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutCCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.learnMode = New System.Windows.Forms.CheckBox()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.codes = New System.Windows.Forms.ListBox()
        Me.delbtn = New System.Windows.Forms.Button()
        Me.signal = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.importExport = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ImportProfiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportProfiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.opener = New System.Windows.Forms.OpenFileDialog()
        Me.saver = New System.Windows.Forms.SaveFileDialog()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.importExport.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(74, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(233, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(314, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Save this"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'deviceList
        '
        Me.deviceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.deviceList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.deviceList.FormattingEnabled = True
        Me.deviceList.Location = New System.Drawing.Point(74, 12)
        Me.deviceList.Name = "deviceList"
        Me.deviceList.Size = New System.Drawing.Size(233, 21)
        Me.deviceList.TabIndex = 4
        '
        'startstop
        '
        Me.startstop.Location = New System.Drawing.Point(314, 9)
        Me.startstop.Name = "startstop"
        Me.startstop.Size = New System.Drawing.Size(75, 23)
        Me.startstop.TabIndex = 5
        Me.startstop.Text = "Start"
        Me.startstop.UseVisualStyleBackColor = True
        '
        'taskbarIcon
        '
        Me.taskbarIcon.ContextMenuStrip = Me.ContextMenuStrip1
        Me.taskbarIcon.Icon = CType(resources.GetObject("taskbarIcon.Icon"), System.Drawing.Icon)
        Me.taskbarIcon.Text = "CreativelyControlled"
        Me.taskbarIcon.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.curDev, Me.ToolStripMenuItem1, Me.ShowCreativelyControlledToolStripMenuItem, Me.AboutCCToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(215, 98)
        '
        'curDev
        '
        Me.curDev.Enabled = False
        Me.curDev.Name = "curDev"
        Me.curDev.Size = New System.Drawing.Size(214, 22)
        Me.curDev.Text = "Not active"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(211, 6)
        '
        'ShowCreativelyControlledToolStripMenuItem
        '
        Me.ShowCreativelyControlledToolStripMenuItem.Name = "ShowCreativelyControlledToolStripMenuItem"
        Me.ShowCreativelyControlledToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ShowCreativelyControlledToolStripMenuItem.Text = "Show CreativelyControlled"
        '
        'AboutCCToolStripMenuItem
        '
        Me.AboutCCToolStripMenuItem.Name = "AboutCCToolStripMenuItem"
        Me.AboutCCToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.AboutCCToolStripMenuItem.Text = "About CC..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'learnMode
        '
        Me.learnMode.AutoSize = True
        Me.learnMode.Location = New System.Drawing.Point(12, 424)
        Me.learnMode.Name = "learnMode"
        Me.learnMode.Size = New System.Drawing.Size(295, 17)
        Me.learnMode.TabIndex = 6
        Me.learnMode.Text = "Learn mode (unknown code autosaves, only when open)"
        Me.learnMode.UseVisualStyleBackColor = True
        '
        'editBtn
        '
        Me.editBtn.Enabled = False
        Me.editBtn.Location = New System.Drawing.Point(13, 388)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(75, 23)
        Me.editBtn.TabIndex = 7
        Me.editBtn.Text = "Edit"
        Me.editBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Received:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Device:"
        '
        'codes
        '
        Me.codes.FormattingEnabled = True
        Me.codes.Location = New System.Drawing.Point(12, 91)
        Me.codes.Name = "codes"
        Me.codes.Size = New System.Drawing.Size(377, 290)
        Me.codes.TabIndex = 11
        '
        'delbtn
        '
        Me.delbtn.Enabled = False
        Me.delbtn.Location = New System.Drawing.Point(94, 388)
        Me.delbtn.Name = "delbtn"
        Me.delbtn.Size = New System.Drawing.Size(75, 23)
        Me.delbtn.TabIndex = 12
        Me.delbtn.Text = "Delete"
        Me.delbtn.UseVisualStyleBackColor = True
        '
        'signal
        '
        Me.signal.Location = New System.Drawing.Point(12, 63)
        Me.signal.Name = "signal"
        Me.signal.Size = New System.Drawing.Size(377, 25)
        Me.signal.TabIndex = 13
        Me.signal.Text = "No Signal"
        Me.signal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(314, 388)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "From/To file"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'importExport
        '
        Me.importExport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportProfiles, Me.ExportProfiles})
        Me.importExport.Name = "importExport"
        Me.importExport.Size = New System.Drawing.Size(120, 48)
        '
        'ImportProfiles
        '
        Me.ImportProfiles.Name = "ImportProfiles"
        Me.ImportProfiles.Size = New System.Drawing.Size(119, 22)
        Me.ImportProfiles.Text = "Import..."
        '
        'ExportProfiles
        '
        Me.ExportProfiles.Name = "ExportProfiles"
        Me.ExportProfiles.Size = New System.Drawing.Size(152, 22)
        Me.ExportProfiles.Text = "Export..."
        '
        'opener
        '
        Me.opener.Filter = "CC Profiles|*.creacon"
        '
        'saver
        '
        Me.saver.Filter = "CC Profiles|*.creacon"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 451)
        Me.Controls.Add(Me.signal)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.delbtn)
        Me.Controls.Add(Me.codes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.editBtn)
        Me.Controls.Add(Me.learnMode)
        Me.Controls.Add(Me.startstop)
        Me.Controls.Add(Me.deviceList)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "CreativelyControlled"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.importExport.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents deviceList As System.Windows.Forms.ComboBox
    Friend WithEvents startstop As System.Windows.Forms.Button
    Friend WithEvents taskbarIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents curDev As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents learnMode As System.Windows.Forms.CheckBox
    Friend WithEvents editBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents codes As System.Windows.Forms.ListBox
    Friend WithEvents ShowCreativelyControlledToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents delbtn As System.Windows.Forms.Button
    Friend WithEvents signal As System.Windows.Forms.Label
    Friend WithEvents AboutCCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents importExport As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ImportProfiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportProfiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opener As System.Windows.Forms.OpenFileDialog
    Friend WithEvents saver As System.Windows.Forms.SaveFileDialog

End Class
