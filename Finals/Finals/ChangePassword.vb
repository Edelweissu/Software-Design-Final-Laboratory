Public Class ChangePassword
    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        query = "Select * from tbUsers where UserName = '" & Username.Text.ToUpper() & "' and Password = '" & Pass.Text & "'"
        Exec()
        If cnt = 1 Then
            If Pass.Text = ChangePass.Text Then
                Settings.Hide()
                MessageBox.Show("Cannot change to same password", "Invalid Change",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button2)
                Settings.Show()
            Else
                If ChangePass.Text = CCPass.Text Then
                    query = "Update tbUsers set Password = '" & CCPass.Text & "' where UserName = '" & Username.Text.ToUpper() & "'"
                    Exec()
                    MessageBox.Show("Password Changed", "Password Change Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2)

                    query = "Select * from tbUsers where Username = '" & LoginForm.TextBox1.Text & "' and Password = '" & ChangePass.Text & "'"
                    Exec()
                    Dim Name As String
                    Name = dt.Rows(0)(3) & " " & dt.Rows(0)(4) & " " & dt.Rows(0)(2)
                    query = "Insert into UserLog VALUES ('" & Date.Now.ToShortDateString & "', '" & Name & "', 'Change Password')"
                    Exec()

                    MessageBox.Show("You shall be logged out now")
                    Settings.Hide()
                    LoginForm.Show()
                Else
                    MessageBox.Show("Confirm Password is not" & vbCrLf & "same as Password", "Password Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button2)
                End If
            End If
        Else
            Settings.Hide()
            MessageBox.Show("Invalid Username", "Invalid Change",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)
            Settings.Show()
        End If
    End Sub
End Class