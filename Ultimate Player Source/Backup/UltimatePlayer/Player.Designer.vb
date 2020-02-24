<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Player
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Player))
        Me.PlayerControl = New AxWMPLib.AxWindowsMediaPlayer
        Me.PlayBtn = New System.Windows.Forms.Button
        Me.StopBtn = New System.Windows.Forms.Button
        Me.OpenBtn = New System.Windows.Forms.Button
        Me.VolumeBar = New System.Windows.Forms.TrackBar
        Me.BalanceBar = New System.Windows.Forms.TrackBar
        Me.PlayBar = New System.Windows.Forms.HScrollBar
        Me.PlayerMenu = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenMenuBtn = New System.Windows.Forms.ToolStripMenuItem
        Me.ContinuePlay = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitBtn = New System.Windows.Forms.ToolStripMenuItem
        Me.DurationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Duration = New System.Windows.Forms.Label
        Me.PauseBtn = New System.Windows.Forms.Button
        CType(Me.PlayerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlayerMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlayerControl
        '
        Me.PlayerControl.Enabled = True
        Me.PlayerControl.Location = New System.Drawing.Point(-1, 25)
        Me.PlayerControl.Name = "PlayerControl"
        Me.PlayerControl.OcxState = CType(resources.GetObject("PlayerControl.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PlayerControl.Size = New System.Drawing.Size(420, 270)
        Me.PlayerControl.TabIndex = 0
        '
        'PlayBtn
        '
        Me.PlayBtn.Location = New System.Drawing.Point(3, 323)
        Me.PlayBtn.Name = "PlayBtn"
        Me.PlayBtn.Size = New System.Drawing.Size(44, 23)
        Me.PlayBtn.TabIndex = 1
        Me.PlayBtn.Text = "Play"
        Me.PlayBtn.UseVisualStyleBackColor = True
        '
        'StopBtn
        '
        Me.StopBtn.Location = New System.Drawing.Point(99, 323)
        Me.StopBtn.Name = "StopBtn"
        Me.StopBtn.Size = New System.Drawing.Size(44, 23)
        Me.StopBtn.TabIndex = 2
        Me.StopBtn.Text = "Stop"
        Me.StopBtn.UseVisualStyleBackColor = True
        '
        'OpenBtn
        '
        Me.OpenBtn.Location = New System.Drawing.Point(147, 323)
        Me.OpenBtn.Name = "OpenBtn"
        Me.OpenBtn.Size = New System.Drawing.Size(44, 23)
        Me.OpenBtn.TabIndex = 3
        Me.OpenBtn.Text = "Open"
        Me.OpenBtn.UseVisualStyleBackColor = True
        '
        'VolumeBar
        '
        Me.VolumeBar.Location = New System.Drawing.Point(191, 322)
        Me.VolumeBar.Maximum = 100
        Me.VolumeBar.Name = "VolumeBar"
        Me.VolumeBar.Size = New System.Drawing.Size(104, 45)
        Me.VolumeBar.TabIndex = 4
        Me.VolumeBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.VolumeBar.Value = 100
        '
        'BalanceBar
        '
        Me.BalanceBar.Location = New System.Drawing.Point(298, 322)
        Me.BalanceBar.Maximum = 50
        Me.BalanceBar.Name = "BalanceBar"
        Me.BalanceBar.Size = New System.Drawing.Size(55, 45)
        Me.BalanceBar.TabIndex = 5
        Me.BalanceBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.BalanceBar.Value = 25
        '
        'PlayBar
        '
        Me.PlayBar.Location = New System.Drawing.Point(3, 298)
        Me.PlayBar.Name = "PlayBar"
        Me.PlayBar.Size = New System.Drawing.Size(416, 17)
        Me.PlayBar.TabIndex = 6
        '
        'PlayerMenu
        '
        Me.PlayerMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.PlayerMenu.Location = New System.Drawing.Point(0, 0)
        Me.PlayerMenu.Name = "PlayerMenu"
        Me.PlayerMenu.Size = New System.Drawing.Size(419, 24)
        Me.PlayerMenu.TabIndex = 8
        Me.PlayerMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenMenuBtn, Me.ContinuePlay, Me.ToolStripSeparator1, Me.ExitBtn})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenMenuBtn
        '
        Me.OpenMenuBtn.Name = "OpenMenuBtn"
        Me.OpenMenuBtn.Size = New System.Drawing.Size(184, 22)
        Me.OpenMenuBtn.Text = "Open"
        '
        'ContinuePlay
        '
        Me.ContinuePlay.Checked = Global.UltimatePlayer.My.MySettings.Default.PlayAgain
        Me.ContinuePlay.CheckOnClick = True
        Me.ContinuePlay.Name = "ContinuePlay"
        Me.ContinuePlay.Size = New System.Drawing.Size(184, 22)
        Me.ContinuePlay.Text = "Continuous Playback"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(181, 6)
        '
        'ExitBtn
        '
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(184, 22)
        Me.ExitBtn.Text = "Exit"
        '
        'DurationTimer
        '
        '
        'OpenFile
        '
        Me.OpenFile.Title = "Choose A File"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Duration)
        Me.Panel1.Location = New System.Drawing.Point(353, 323)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(61, 24)
        Me.Panel1.TabIndex = 9
        '
        'Duration
        '
        Me.Duration.AutoSize = True
        Me.Duration.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Duration.Location = New System.Drawing.Point(3, 0)
        Me.Duration.Name = "Duration"
        Me.Duration.Size = New System.Drawing.Size(51, 19)
        Me.Duration.TabIndex = 0
        Me.Duration.Text = "00:00"
        '
        'PauseBtn
        '
        Me.PauseBtn.Location = New System.Drawing.Point(51, 323)
        Me.PauseBtn.Name = "PauseBtn"
        Me.PauseBtn.Size = New System.Drawing.Size(44, 23)
        Me.PauseBtn.TabIndex = 10
        Me.PauseBtn.Text = "Pause"
        Me.PauseBtn.UseVisualStyleBackColor = True
        '
        'Player
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 348)
        Me.Controls.Add(Me.PauseBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PlayBar)
        Me.Controls.Add(Me.BalanceBar)
        Me.Controls.Add(Me.VolumeBar)
        Me.Controls.Add(Me.OpenBtn)
        Me.Controls.Add(Me.StopBtn)
        Me.Controls.Add(Me.PlayBtn)
        Me.Controls.Add(Me.PlayerControl)
        Me.Controls.Add(Me.PlayerMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.PlayerMenu
        Me.MaximizeBox = False
        Me.Name = "Player"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ultimate Player"
        CType(Me.PlayerControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlayerMenu.ResumeLayout(False)
        Me.PlayerMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlayerControl As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PlayBtn As System.Windows.Forms.Button
    Friend WithEvents StopBtn As System.Windows.Forms.Button
    Friend WithEvents OpenBtn As System.Windows.Forms.Button
    Friend WithEvents VolumeBar As System.Windows.Forms.TrackBar
    Friend WithEvents BalanceBar As System.Windows.Forms.TrackBar
    Friend WithEvents PlayBar As System.Windows.Forms.HScrollBar
    Friend WithEvents PlayerMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenMenuBtn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContinuePlay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitBtn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DurationTimer As System.Windows.Forms.Timer
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Duration As System.Windows.Forms.Label
    Friend WithEvents PauseBtn As System.Windows.Forms.Button

End Class
