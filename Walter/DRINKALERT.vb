Imports System.Windows.Forms

Public Class DRINKALERT

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        My.Computer.Audio.Stop()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        My.Computer.Audio.Play(My.Resources.DrinkAlert2, AudioPlayMode.Background)
        MessageBox.Show("It's Time to Drink, Walter.")
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DRINKALERT_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.DrinkAlert, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Label1.BackColor = Color.White Then
            Label1.BackColor = Color.Red
            Label1.ForeColor = Color.White
        Else
            Label1.BackColor = Color.White
            Label1.ForeColor = Color.Black
        End If
    End Sub
End Class
