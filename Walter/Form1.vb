Public Class Form1

    Private Sub Label1_DoubleClick(sender As Object, e As System.EventArgs) Handles Label1.DoubleClick
        MessageBox.Show("PopularMMOs Pat And Jen Minecraft Pat And Jen SEX CHALLENGE GAMES Lucky Blog Mod Modded Mini Game")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer1.Stop()
        My.Settings.Interval = NumericUpDown1.Value * 60000
        Timer1.Interval = My.Settings.Interval
        MessageBox.Show("PopularMMOs Pat And Jen Minecraft Pat And Jen SEX CHALLENGE GAMES Lucky Blog Mod Modded Mini Game")
        Me.Hide()
        Timer1.Start()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NumericUpDown1.Value = My.Settings.Interval / 60000
        Timer1.Interval = My.Settings.Interval
        Timer1.Start()
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = MouseButtons.Left Then
            Me.Show()
        End If
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        DRINKALERT.ShowDialog()
        Timer1.Start()
    End Sub

    Private Sub StartupFolderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StartupFolderToolStripMenuItem.Click
        Process.Start("explorer.exe", "shell:startup")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TimerWaltuh.Enabled = True
            My.Computer.Audio.Play(My.Resources.waltuh, AudioPlayMode.Background)
        Else
            TimerWaltuh.Enabled = False
        End If
    End Sub

    Private Sub TimerWaltuh_Tick(sender As System.Object, e As System.EventArgs) Handles TimerWaltuh.Tick
        My.Computer.Audio.Play(My.Resources.waltuh, AudioPlayMode.Background)
    End Sub
End Class
