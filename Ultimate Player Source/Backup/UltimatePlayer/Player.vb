Public Class Player
    Private PlayAgain As Boolean

    Private Sub Library_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim CloseMessage As DialogResult
        CloseMessage = MsgBox("Are you sure you want to close?", MsgBoxStyle.YesNo)
        If CloseMessage = Windows.Forms.DialogResult.Yes Then
            PlayerControl.Ctlcontrols.stop()
        End If
        If CloseMessage = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Library_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PlayerControl.settings.autoStart = True
        PlayerControl.settings.volume = VolumeBar.Value
        PlayerControl.settings.balance = BalanceBar.Value
        PlayerControl.settings.enableErrorDialogs = False
        PlayerControl.enableContextMenu = False

        If My.Settings.PlayAgain = False Then
            ContinuePlay.Checked = False
            PlayAgain = False
        Else
            ContinuePlay.Checked = True
            PlayAgain = True
        End If


    End Sub
    Private Sub GetFile()
        If OpenFile.ShowDialog = Windows.Forms.DialogResult.OK And OpenFile.FileName <> "" Then
            PlayerControl.URL = OpenFile.FileName
            DurationTimer.Enabled = True
        End If
    End Sub
    Private Sub PlaySong()
        If PlayerControl.URL <> "" Then
            PlayerControl.Ctlcontrols.play()
            DurationTimer.Enabled = True
        Else
            DurationTimer.Enabled = False
        End If
    End Sub
    Private Sub PauseSong()
        PlayerControl.Ctlcontrols.pause()
    End Sub
    
    Private Sub StopSong()
        PlayerControl.Ctlcontrols.stop()
        Duration.Text = "00:00"
        DurationTimer.Enabled = False
        PlayBar.Value = 0
    End Sub

    Private Sub OpenBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenBtn.Click
        GetFile()
    End Sub
    Private Sub PlayBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayBtn.Click
        PlaySong()
    End Sub
    Private Sub StopBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopBtn.Click
        StopSong()
    End Sub
    Private Sub PlayBar_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles PlayBar.Scroll
        Try
            If (PlayerControl.currentMedia.duration <> 0) Then
                Dim NewPerc As Double = Convert.ToDouble(PlayBar.Value) / 100
                Dim DurationVar As Integer = Convert.ToInt32(PlayerControl.currentMedia.duration * 1000) ' milliseconds
                Dim NewPos As Integer = (DurationVar * NewPerc) / 1000


                PlayerControl.Ctlcontrols.currentPosition = NewPos
            Else
                PlayBar.Value = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DurationTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DurationTimer.Tick
        ' Update the trackbar.
        Dim CurPos As Integer = Convert.ToInt32(PlayerControl.Ctlcontrols.currentPosition * 1000) ' milliseconds
        Dim DurationVar As Integer = Convert.ToInt32(PlayerControl.currentMedia.duration * 1000) ' milliseconds
        If DurationVar > 0 Then
            PlayBar.Value = Convert.ToInt32((CurPos * 100) / DurationVar) ' % complete
        End If

        ' Update the time label
        Duration.Text = PlayerControl.Ctlcontrols.currentPositionString

        If PlayerControl.playState = WMPLib.WMPPlayState.wmppsStopped Then
            Duration.Text = "00:00"
            DurationTimer.Enabled = False
            PlayBar.Value = 0
        End If
        If PlayAgain = False Then
        Else
            If PlayerControl.playState = WMPLib.WMPPlayState.wmppsStopped Then
                PlaySong()
            Else
            End If
        End If
    End Sub

    Private Sub VolumeBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolumeBar.Scroll
        PlayerControl.settings.volume = VolumeBar.Value
    End Sub

    Private Sub BalanceBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BalanceBar.Scroll
        PlayerControl.settings.balance = BalanceBar.Value & "%"
    End Sub

    Private Sub OpenMenuBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenMenuBtn.Click
        GetFile()
    End Sub

    Private Sub ContinuePlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContinuePlay.Click
        If ContinuePlay.Checked = True Then
            My.Settings.PlayAgain = False
            ContinuePlay.Checked = False
        Else
            My.Settings.PlayAgain = True
            ContinuePlay.Checked = True
        End If
    End Sub

    Private Sub PauseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauseBtn.Click
        PauseSong()
    End Sub
End Class
