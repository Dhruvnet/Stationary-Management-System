Imports System.Data.OleDb
Public Class Stocksform
    Dim con = New OleDbConnection
    Private Sub Buttonlogout_Click(sender As Object, e As EventArgs) Handles Buttonlogout.Click
        Dim d As DialogResult
        d = MessageBox.Show(" Are you sure you want to Logout ?? ", "LOGOUT", MessageBoxButtons.YesNo)
        If d = DialogResult.Yes Then
            Formloginpg.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Buttonreturnhomepage_Click(sender As Object, e As EventArgs) Handles Buttonreturnhomepage.Click
        Formhomepg.Show()
        Me.Hide()
    End Sub
End Class