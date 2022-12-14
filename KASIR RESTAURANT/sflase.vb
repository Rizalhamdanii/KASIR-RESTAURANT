Public Class sflase
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Value += 1
        Label2.Text = "Loading..." & Convert.ToString(ProgressBar1.Value) & "%"
        If ProgressBar1.Value = 10 Then
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            MenuUtama.ShowDialog()
        End If
    End Sub
End Class