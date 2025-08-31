Public Class frmMain

    Private Const VK_PLAY_PAUSE As Integer = &HB3
    Private Const KEYEVENTF_KEYUP As Integer = &H2
    Private Const VK_MEDIA_STOP As Byte = &HB2
    Private Const VK_MEDIA_PREV_TRACK = &HB1
    Private Const VK_MEDIA_NEXT_TRACK = &HB0

    Private idletime As Integer


    Private Declare Sub keybd_event Lib "user32" (
    ByVal bVk As Byte,
    ByVal bScan As Byte,
    ByVal dwFlags As Integer,
    ByVal dwExtraInfo As Integer
)
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        ' Press and release Play/Pause
        sendKey(VK_PLAY_PAUSE)
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        sendKey(VK_MEDIA_STOP)
    End Sub

    Private Sub sendKey(VK_MAP As Integer)
        ' Press and release Play/Pause
        keybd_event(VK_MAP, 0, 0, 0)
        keybd_event(VK_MAP, 0, KEYEVENTF_KEYUP, 0)
    End Sub

    Private Sub btnbck_Click(sender As Object, e As EventArgs) Handles btnbck.Click
        sendKey(VK_MEDIA_PREV_TRACK)
    End Sub

    Private Sub btnffwd_Click(sender As Object, e As EventArgs) Handles btnffwd.Click
        sendKey(VK_MEDIA_NEXT_TRACK)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmridle.Tick
        If idletime < 5 Then
            idletime = idletime + 1
            Debug.Print("Idling in:" & idletime)
        Else
            changeopacity(0.4)
            tmridle.Enabled = False
        End If
    End Sub

    Private Sub changeopacity(value As Double)
        Me.Opacity = value ' 75% visible
    End Sub

    Private Sub frmMain_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        'idletime = 0
        'Timer1_Tick(sender, e)
        Debug.Print("MOuse leave")
        Dim curpoint As Point
        curpoint = Cursor.Position
        Dim formbound As Rectangle
        formbound = Me.Bounds


        If Not formbound.Contains(curpoint) Then
            tmridle.Enabled = True
            'changeopacity(0.4)
        End If
    End Sub


    Private Sub frmMain_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Dim curpoint As Point
        curpoint = Cursor.Position
        Dim formbound As Rectangle
        formbound = Me.Bounds
        idletime = 0

        If formbound.Contains(curpoint) Then
            changeopacity(1)
            Debug.Print("Mouse Enter")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub lblheader_DragOver(sender As Object, e As DragEventArgs) Handles lblheader.DragOver
        Dim curpoint As Point
        curpoint = Cursor.Position
        Debug.Print("Location")
        Me.Location = curpoint

    End Sub
End Class
