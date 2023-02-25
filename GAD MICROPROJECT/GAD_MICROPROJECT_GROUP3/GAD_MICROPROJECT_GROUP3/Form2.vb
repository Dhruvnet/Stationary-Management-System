Public Class Formloginpg
    Private Sub Formloginpg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Buttonlogin.Enabled = False
        Textusername.Focus()
    End Sub
    Private Sub TextusernameextChanged(sender As Object, e As EventArgs) Handles Textusername.TextChanged
        Buttonlogin.Enabled = True
    End Sub
    Private Sub TextBusername_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Textusername.KeyDown
        If e.KeyCode = Keys.Enter Then
            Textpassword.Focus()
        End If
    End Sub
    Private Sub textpassword_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Buttonlogin_Click(Me, EventArgs.Empty)
        End If
    End Sub
    Private Sub Buttonlogin_Click(sender As Object, e As EventArgs) Handles Buttonlogin.Click
        If (Textusername.Text = "" Or Textpassword.Text = "") Then
            Buttonlogin.Enabled = False
        ElseIf Textusername.Text = "" Then
            MessageBox.Show(" Please enter username ", "Username Error")
        ElseIf Textpassword.Text = "" Then
            MessageBox.Show("Please enter password", "Password Error")
        ElseIf Textusername.Text = "admin" And Textpassword.Text = "pass123" Then
            Textusername.Clear()
            Textpassword.Clear()
            Textusername.Focus()
            Formhomepg.Show()
            Me.Hide()
        ElseIf Textusername.Text = "admin" And Textpassword.Text <> "pass123" Then
            MessageBox.Show("Wrong Password", "Error")
            Textpassword.Text = ""
            Textpassword.Focus()
        ElseIf Textusername.Text <> "admin" And Textpassword.Text = "pass123" Then
            MessageBox.Show("Wrong Username", "Error")
            Textusername.Text = ""
            Textusername.Focus()
        ElseIf Textusername.Text <> "admin" And Textpassword.Text <> "pass123" Then
            MessageBox.Show("Please Enter Correct Username and Password ", "Error")
            Textusername.Text = ""
            Textpassword.Text = ""
            Textusername.Focus()
        End If
    End Sub
    Private Sub Buttonclear_Click(sender As Object, e As EventArgs) Handles Buttonclear.Click
        Buttonlogin.Enabled = False
        Textusername.Clear()
        Textpassword.Clear()
    End Sub
    Private Sub Checkpassword_CheckedChanged(sender As Object, e As EventArgs) Handles Checkpassword.CheckedChanged
        If Checkpassword.Checked Then
            Textpassword.UseSystemPasswordChar = True
        Else
            Textpassword.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub Buttonexit_Click(sender As Object, e As EventArgs) Handles Buttonexit.Click
        Dim d As DialogResult
        d = MessageBox.Show(" Are you sure you want to EXIT Application ?? ", "EXIT ", MessageBoxButtons.YesNo)
        If d = DialogResult.Yes Then
            MessageBox.Show("Srushti Shete" & Space(10) & "- 09" & Environment.NewLine &
                            "Mohit Gangwani" & Space(3) & "- 10" & Environment.NewLine &
                            "Srushti Joil" & Space(14) & "- 11" & Environment.NewLine &
                            "Dhruv Sheth" & Space(11) & "- 12", "GROUP DETAILS")
            End
        End If
    End Sub
End Class