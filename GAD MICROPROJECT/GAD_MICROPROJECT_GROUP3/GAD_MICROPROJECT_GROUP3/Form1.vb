Public Class Formloadpg
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Dim per As String
        per = Convert.ToString(ProgressBar1.Value)
        Percentagelb.Text = per + "%"
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Formloginpg.Show()
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub Formloadpg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
