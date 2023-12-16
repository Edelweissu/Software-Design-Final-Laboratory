Public Class UserLog
    Private Sub UserLog_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub UserLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UserList.Items.Clear()
        query = "Select * from UserLog"
        Exec()
        For Each R As DataRow In dt.Rows
            UserList.Items.Add(R("Date"))
            With UserList.Items(UserList.Items.Count - 1).SubItems
                .Add(R("UserL"))
                .Add(R("Task"))
            End With
        Next

        UserList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        UserList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Filter_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Filter.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserList.Items.Clear()
        query = "Select * from UserLog"
        Exec()
        For Each R As DataRow In dt.Rows
            UserList.Items.Add(R("Date"))
            With UserList.Items(UserList.Items.Count - 1).SubItems
                .Add(R("UserL"))
                .Add(R("Task"))
            End With
        Next
    End Sub
End Class