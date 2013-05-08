Public Class Keyboard
    Declare Sub keybd_event Lib "user32.dll" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Int32, ByVal dwExtraInfo As Int32)

    Public Shared Sub SendKey(ByVal key As Keys)
        keybd_event(CByte(key), 0, 0, 0)
    End Sub
End Class

Public Class CCAction
    Public Enum CCAType As Integer
        CCAExecuteType = 0
        CCAKeyEmulationType = 1
        CCAKeyPressType = 2
        CCADebugMessageType = 3
    End Enum
    Public Property Type As CCAType
    Public Property code As String
    Public Property name As String
    Public Property Parameter As String
    Private Function remappedKeyFromName(ByVal name As String) As Keys
        Return System.Enum.Parse(GetType(Keys), name)
    End Function
    Public Sub Execute()
        Try
            Select Case Me.Type
                Case CCAType.CCAExecuteType
                    Shell(Parameter)

                Case CCAType.CCAKeyEmulationType
                    SendKeys.Send(Parameter)

                Case CCAType.CCAKeyPressType
                    Keyboard.SendKey(remappedKeyFromName(Parameter))

                Case CCAType.CCADebugMessageType
                    MsgBox(Parameter)
            End Select
        Catch ex As Exception
            MsgBox("Error executing " + Me.ToString + "! " + ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Oops!")
        End Try
    End Sub
    Public Function AsStringRepresentation() As String
        Dim res As String
        res = Me.name
        res += Chr(13)
        res += Me.code
        res += Chr(13)
        res += CInt(Me.Type).ToString
        res += Chr(13)
        res += Me.Parameter

        Return res
    End Function
    Public Function ReloadFromStringRepresentation(ByVal Representation As String)
        Dim decoded As String() = Split(Representation, vbLf)
        Me.name = decoded(0)
        Me.code = decoded(1)
        Me.Type = CInt(decoded(2))
        Me.Parameter = decoded(3)
        Return Me
    End Function
    Public Function ToString() As String
        Dim res As String
        res = Me.name + ", "
        Select Case Me.Type
            Case CCAType.CCAKeyPressType
                res += "KeyPress: " + Parameter
            Case CCAType.CCADebugMessageType
                res += "Messagebox: " + Parameter
            Case CCAType.CCAKeyEmulationType
                res += "Type text: " + Parameter
            Case CCAType.CCAExecuteType
                res += "Execute: " + Parameter
        End Select
        Return res
    End Function
End Class
