Public Class Settings


    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        With NewUser
            .TopLevel = False
            .AutoSize = True
            Panel1.Controls.Add(NewUser)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Settings_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        With ChangePassword
            .TopLevel = False
            .AutoSize = True
            Panel1.Controls.Add(ChangePassword)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class