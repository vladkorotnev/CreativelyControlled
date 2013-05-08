Imports Midi
Public Class Form1
    Dim midiInput As Midi.InputDevice
    Dim midiDevs As New Collection
    Dim actions As New Collection
    Dim actionCodes As New ArrayList


    Public Sub ReceiveSysex(ByVal message As Midi.SysExMessage)
        Dim incomingSysExMessage As Byte() = message.Data
        PushEvt(bytesInStr(incomingSysExMessage))

    End Sub
    Function bytesInStr(ByVal bytes As Byte()) As String
        Dim s As String
        s = BitConverter.ToString(bytes).Replace("-", " ")
        Return s
    End Function
 
    Delegate Sub SetTextCallback(ByVal text As String)
    Sub PushEvt(ByVal [text] As String)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.TextBox1.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf PushEvt)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.TextBox1.Text = [text]
            If actionCodes.Contains(Me.TextBox1.Text) Then
                Dim a As CCAction
                Button1.Text = "Edit this"

                signal.BackColor = Color.LightGreen
                a = actions.Item(actionCodes.IndexOf(Me.TextBox1.Text) + 1)
                signal.Text = a.name
                a.Execute()
            Else
                Button1.Text = "Save this"
                signal.Text = "No match"
                signal.BackColor = Color.LightPink

                If Me.Visible And learnMode.Checked Then
                    Button1.PerformClick()
                End If
            End If

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then Return
        If actionCodes.IndexOf(TextBox1.Text) > -1 Then
            Dim a As CCAction
            a = actions.Item(actionCodes.IndexOf(TextBox1.Text) + 1)
            Dim edit As New CCAEditor
            edit.editingItem = a
            edit.ShowDialog()
            freshActionList()
        Else
            Dim a As New CCAction
            a.Type = CCAction.CCAType.CCAExecuteType
            a.code = TextBox1.Text
            a.name = "My Action"
            Dim edit As New CCAEditor
            edit.editingItem = a

            If edit.ShowDialog() = Windows.Forms.DialogResult.OK Then
                actions.Add(a)
                actionCodes.Add(a.code)
                freshActionList()
            End If
        End If
       

    End Sub

    Sub freshActionList()
        codes.Items.Clear()
        actionCodes.Clear()
        Dim actionsStringReps As New System.Collections.Specialized.StringCollection

        For Each a As CCAction In actions
            codes.Items.Add(a.ToString)
            actionCodes.Add(a.code)
            actionsStringReps.Add(a.AsStringRepresentation())
        Next
        My.Settings.actions = actionsStringReps
        My.Settings.Save()

    End Sub

    Private Sub startstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop.Click
        If startstop.Text = "Start" Then
            startstop.Text = "Stop"
            deviceList.Enabled = False
            midiInput = InputDevice.InstalledDevices.Item(deviceList.SelectedIndex)
            midiInput.Open()
            Me.Text = "CreativelyControlled: " + midiInput.Name
            midiInput.StartReceiving(New Midi.Clock(300), True)
            My.Settings.curSelDevIdx = deviceList.SelectedIndex
            curDev.Text = "Using: " + midiInput.Name
            Button1.Enabled = True

            AddHandler midiInput.SysEx, AddressOf ReceiveSysex
        Else
            startstop.Text = "Start"
            deviceList.Enabled = True
            midiInput.StopReceiving()
            midiInput.Close()
            curDev.Text = "Not Active"
            Button1.Enabled = False
            RemoveHandler midiInput.SysEx, AddressOf ReceiveSysex
            Me.Text = "CreativelyControlled"
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Me.Visible And (midiInput.IsReceiving Or midiInput.IsOpen) Then
                If MsgBox("Really stop CreativelyControlled? No further remote events will be working until relaunch.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Quit CreativelyControlled") = MsgBoxResult.Yes Then
                    midiInput.StopReceiving()
                    midiInput.Close()
                Else
                    e.Cancel = True
                End If
            
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.WindowState = FormWindowState.Minimized
                taskbarIcon.Visible = True
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size
        Me.MaximizeBox = False
        Dim midiDevices = Midi.InputDevice.InstalledDevices
        For Each d As Midi.InputDevice In midiDevices
            midiDevs.Add(d)
            deviceList.Items.Add(d.Name)
        Next
        learnMode.Checked = My.Settings.learnMode
        If Not IsNothing(My.Settings.actions) Then
            Dim sReps As System.Collections.Specialized.StringCollection
            sReps = My.Settings.actions
            For Each sRep As String In sReps
                Dim a As New CCAction
                a.ReloadFromStringRepresentation(sRep)
                actions.Add(a)
                actionCodes.Add(a.code)
            Next
            freshActionList()
        End If
        If My.Settings.curSelDevIdx > -1 Then
            deviceList.SelectedIndex = My.Settings.curSelDevIdx
            startstop.PerformClick()
            Me.WindowState = FormWindowState.Minimized
            taskbarIcon.Visible = True
            Me.Hide()
        End If
    End Sub




    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If midiInput.IsReceiving Then midiInput.StopReceiving()
        If midiInput.IsOpen Then midiInput.Close()
        End
    End Sub


    Private Sub editBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editBtn.Click
        If codes.SelectedIndex < 0 Then Return
        Dim a As CCAction
        a = actions.Item(codes.SelectedIndex + 1)
        Dim edit As New CCAEditor
        edit.editingItem = a
        edit.ShowDialog()
        freshActionList()
    End Sub

    Private Sub learnMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles learnMode.CheckedChanged
        My.Settings.learnMode = learnMode.Checked
        My.Settings.Save()
    End Sub

    Private Sub codes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codes.SelectedIndexChanged
        editBtn.Enabled = (codes.SelectedIndex > -1)
        delbtn.Enabled = (codes.SelectedIndex > -1)
    End Sub

    Private Sub taskbarIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles taskbarIcon.MouseDoubleClick
        Try
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            taskbarIcon.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ShowCreativelyControlledToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowCreativelyControlledToolStripMenuItem.Click
        Try
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            taskbarIcon.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub delbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delbtn.Click
        If codes.SelectedIndex < 0 Then Return
        Dim a As CCAction
        a = actions.Item(codes.SelectedIndex + 1)
        If MsgBox("Are you sure you want to remove " + a.ToString + "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Really remove?") = MsgBoxResult.Yes Then
            actions.Remove(codes.SelectedIndex + 1)
            TextBox1.Text = ""
            freshActionList()
        End If

    End Sub

    Private Sub AboutCCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutCCToolStripMenuItem.Click
        MsgBox("CreativelyControlled - a better Creative remote handler." + vbCrLf + "Proudly made in Russia by vladkorotnev in May of 2013" + vbCrLf + "vladkorotnev.github.com", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "About CreativelyControlled")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ExportProfiles.Enabled = Not (actions.Count = 0)
        importExport.Show(Me.Left + Button2.Left, Me.Top + Button2.Top)
    End Sub

  
    Private Sub ImportProfiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportProfiles.Click
        If opener.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            FileOpen(1, opener.FileName, OpenMode.Input)
            Dim buf As String = ""
            While Not EOF(1)
                buf += LineInput(1)
                buf += vbLf
            End While
            FileClose(1)
            Dim savedPresets() As String = Split(buf, "<BUTTON>")

            For Each a As String In savedPresets
                If a <> "" Then
                    Dim act As New CCAction
                    act.ReloadFromStringRepresentation(a)
                    If Not actionCodes.Contains(act.code) Then
                        actions.Add(act)
                        actionCodes.Add(act.code)
                    Else
                        Dim conflict As CCAction
                        Dim citem As Integer = actionCodes.IndexOf(act.code)
                        conflict = actions.Item(citem + 1)
                        Dim res As MsgBoxResult = MsgBox("Conflicting items use the same code!" + vbCrLf + "Your item: " + conflict.ToString + vbCrLf + "Import item: " + act.ToString + vbCrLf + "Replace yours with the imported one?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question, "Import conflict")
                        If res = MsgBoxResult.Cancel Then
                            Exit For
                        ElseIf res = MsgBoxResult.Yes Then
                            actions.Remove(citem + 1)
                            actionCodes.Remove(act.code)
                            actions.Add(act)
                            actionCodes.Add(act.code)
                        End If
                    End If
                End If
            Next

            freshActionList()

        End If
    End Sub

    Private Sub ExportProfiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportProfiles.Click
        If saver.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            FileOpen(1, saver.FileName, OpenMode.Output)
            For Each a As CCAction In actions

                Print(1, "<BUTTON>")
                PrintLine(1, a.AsStringRepresentation)
            Next
            FileClose(1)
        End If
    End Sub
End Class
