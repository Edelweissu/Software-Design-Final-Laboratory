Public Class Form4
    Private Sub Form4_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        PatientList.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        query = "Select * from tbUsers where Username = '" & LoginForm.TextBox1.Text & "' and Password = '" & LoginForm.TextBox2.Text & "'"
        Exec()
        Dim Name As String
        Name = dt.Rows(0)(3) & " " & dt.Rows(0)(4) & " " & dt.Rows(0)(2)
        Dim result As DialogResult
        Me.Hide()
        result = MessageBox.Show("Confirm to log out of the system?", "Log Out confirmation",
                 MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            MessageBox.Show(Name & " has logged out of the system" & vbCrLf & "Thank you for your cooperation", "Log Out",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)

            query = "Insert into UserLog VALUES ('" & Date.Now.ToShortDateString & "', '" & Name & "', 'Time Out')"
            Exec()

            LoginForm.Show()
            Me.Hide()
        ElseIf result = DialogResult.No Then
            Me.Show()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Settings.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        UserLog.UserList.Items.Clear()
        query = "Select * from UserLog"
        Exec()

        For Each R As DataRow In dt.Rows
            UserLog.UserList.Items.Add(R("Date"))
            With UserLog.UserList.Items(UserLog.UserList.Items.Count - 1).SubItems
                .Add(R("UserL"))
                .Add(R("Task"))
            End With
        Next

        UserLog.Show()
        Me.Hide()
    End Sub
End Class
