Public Class Filter
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()
        If ComboBox1.Text = "Date" Then
            query = "Select Date from UserLog Group by Date"
            Exec()
            For Each R As DataRow In dt.Rows
                ComboBox2.Items.Add(R("Date"))
            Next
        ElseIf ComboBox1.Text = "User" Then
            query = "Select UserL from UserLog Group by UserL"
            Exec()
            For Each R As DataRow In dt.Rows
                ComboBox2.Items.Add(R("UserL"))
            Next
        ElseIf ComboBox1.Text = "Task" Then
            query = "Select Task from UserLog Group by Task"
            Exec()
            For Each R As DataRow In dt.Rows
                ComboBox2.Items.Add(R("Task"))
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserLog.UserList.Items.Clear()
        If ComboBox1.Text = "User" Then
            query = "Select * from UserLog where UserL = '" & ComboBox2.Text & "'"
            Exec()
            For Each R As DataRow In dt.Rows
                UserLog.UserList.Items.Add(R("Date"))
                With UserLog.UserList.Items(UserLog.UserList.Items.Count - 1).SubItems
                    .Add(R("UserL"))
                    .Add(R("Task"))
                End With
            Next
        Else
            query = "Select * from UserLog where " & ComboBox1.Text & " = '" & ComboBox2.Text & "'"
            Exec()

            For Each R As DataRow In dt.Rows
                UserLog.UserList.Items.Add(R("Date"))
                With UserLog.UserList.Items(UserLog.UserList.Items.Count - 1).SubItems
                    .Add(R("UserL"))
                    .Add(R("Task"))
                End With
            Next

        End If
    End Sub
End Class