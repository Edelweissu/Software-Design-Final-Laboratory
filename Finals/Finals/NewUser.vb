Public Class NewUser
    Private Sub LastName_Keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles LastName.KeyPress

        If Not (Asc(e.KeyChar) = 8) And Not (Asc(e.KeyChar) = 32) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FirstName_Keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles FirstName.KeyPress
        If Not (Asc(e.KeyChar) = 8) And Not (Asc(e.KeyChar) = 32) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub MiddleName_Keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MiddleName.KeyPress
        If Not (Asc(e.KeyChar) = 8) And Not (Asc(e.KeyChar) = 32) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Pass.PasswordChar = "*" Then
            Pass.PasswordChar = Nothing
            PictureBox1.Image = Image.FromFile("D:\Opera downloads\ShowPassword.png")
        Else
            Pass.PasswordChar = "*"
            PictureBox1.Image = Image.FromFile("D:\Opera downloads\HidePassword.png")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Name As String = FirstName.Text & " " & MiddleName.Text & " " & LastName.Text
        Dim User As String = Username.Text.ToUpper()


        If FirstName.Text = Nothing Or LastName.Text = Nothing Then
            Me.Hide()
            MessageBox.Show("Please fill up the form" & vbCrLf & "in order to proceed", "Incomplete Form",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)
            Me.Show()
        Else
            query = "Select UserName from tbUsers where UserName = '" & Username.Text & "'"
            Exec()
            If cnt = 0 Then
                If Pass.Text = ConfirmPass.Text Then
                    query = "Insert into tbUsers (UserName,Password,LastN,FirstN,MiddleN) VALUES ('" & User & "', '" & Pass.Text & "', '" & LastName.Text & "', '" & FirstName.Text & "', '" & MiddleName.Text & "')"
                    Exec()
                    MessageBox.Show("Created a new user!" & vbCrLf & "Welcome! " & Name, "User Created!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2)

                    query = "Select * from tbUsers where Username = '" & User & "' and Password = '" & Pass.Text & "'"
                    Exec()
                    Dim UserName As String
                    UserName = dt.Rows(0)(3) & " " & dt.Rows(0)(4) & " " & dt.Rows(0)(2)
                    query = "Insert into UserLog VALUES ('" & Date.Now.ToShortDateString & "', '" & UserName & "', 'New User Created!!')"
                    Exec()

                Else
                    MessageBox.Show("Confirm Password is not" & vbCrLf & "same as Password", "Password Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button2)
                End If
            Else
                If Username.Text.ToUpper = "ADMIN" Then
                    Me.Hide()
                    MessageBox.Show("ADMIN ONLY", "Username taken",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button2)
                    Me.Show()
                Else
                    Me.Hide()
                    MessageBox.Show("Username is taken", "Username taken",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button2)
                    Me.Show()
                End If
            End If

        End If
    End Sub

End Class