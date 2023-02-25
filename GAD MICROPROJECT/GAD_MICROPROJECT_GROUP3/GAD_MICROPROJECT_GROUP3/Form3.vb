Public Class Formhomepg
    Private Sub Buttonstock_Click(sender As Object, e As EventArgs) Handles Buttonstock.Click
        Me.Hide()
        Stocksform.Show()
    End Sub

    Private Sub Buttonuser_Click(sender As Object, e As EventArgs) Handles Buttonuser.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Buttonbill_Click(sender As Object, e As EventArgs) Handles Buttonbill.Click
        Me.Hide()
        form6.show
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub Buttonreturnhomepage_Click(sender As Object, e As EventArgs) Handles Buttonreturnhomepage.Click
        Me.Show()
    End Sub

    Private Sub Buttonlogout_Click(sender As Object, e As EventArgs) Handles Buttonlogout.Click
        Dim d As DialogResult
        d = MessageBox.Show(" Are you sure you want to Logout ?? ", "LOGOUT", MessageBoxButtons.YesNo)
        If d = DialogResult.Yes Then
            Formloginpg.Show()
            Me.Hide()
        End If
    End Sub
End Class