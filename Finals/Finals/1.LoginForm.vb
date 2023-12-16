Public Class LoginForm
    '//PASSIVE CODE//'
    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer1.Enabled = True Then
            Label4.Text = Date.Now.ToShortDateString
        End If
    End Sub
    Private Sub TextBox1_Keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
            e.Handled = True
            e.SuppressKeyPress = True 'Supresses Ding sound'
        End If
    End Sub
    Private Sub TextBox2_Keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    '//ACTIVE CODE//'
    'Exit Button'
    Private Sub Ex_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim confirmation As DialogResult = MessageBox.Show("Do you want to exit?", "Exit Form",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1)
        If confirmation = DialogResult.Yes Then
            Application.Exit() 'Exit Application'
        ElseIf confirmation = DialogResult.No Then
            Me.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As String
        user = TextBox1.Text.ToUpper()
        query = "Select * from tbUsers where Username = '" & TextBox1.Text & "' and Password = '" & TextBox2.Text & "'"
        Exec()
        If cnt = 0 Then
            MessageBox.Show("User ID or Password is incorrect", "Wrong Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)
        Else
            If user = "ADMIN" And TextBox2.Text = TextBox2.Text Then
                MessageBox.Show("Welcome Administrator!!", "Logged In",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2)

                Dim Name As String
                Name = dt.Rows(0)(3) & " " & dt.Rows(0)(4) & " " & dt.Rows(0)(2)
                query = "Insert into UserLog VALUES ('" & Date.Now.ToShortDateString & "', '" & Name & "', 'Time In')"
                Exec()

                Form4.PictureBox2.Enabled = True
                Settings.PictureBox4.Enabled = True
                Form4.PictureBox2.BackColor = Color.FromArgb(255, 255, 255)
                Settings.PictureBox4.BackColor = Color.FromArgb(255, 255, 255)

                Form4.Show()
                Me.Hide()
            Else

                Dim Name As String
                Name = dt.Rows(0)(3) & " " & dt.Rows(0)(4) & " " & dt.Rows(0)(2)
                MessageBox.Show("Welcome Regular User: " & Name, "Logged In",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2)

                Form4.PictureBox2.Enabled = False
                Form4.PictureBox2.BackColor = Color.FromArgb(105, 105, 105)
                Settings.PictureBox4.BackColor = Color.FromArgb(105, 105, 105)
                Settings.PictureBox4.Enabled = False

                query = "Insert into UserLog VALUES ('" & Date.Now.ToShortDateString & "', '" & Name & "', 'Time In')"
                Exec()

                Form4.Show()
                Me.Hide()
            End If
        End If

    End Sub
End Class
