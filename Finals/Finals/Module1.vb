Imports System.Data.OleDb
Module Module1
    Public connectionString As String = "Provider=SQLOLEDB.1;Persist Security Info=true;User ID=sa;Password=password01;Initial Catalog=Finals;Data Source=ZWEI\SQLEXPRESS"
    Public conn As New OleDbConnection(connectionString)
    Public cmd As New OleDbCommand
    Public da As New OleDbDataAdapter

    Public bsData As New BindingSource
    Public ds As New DataSet
    Public dt As DataTable
    Public cnt As Long
    Public query As String

    Public Sub Exec()
        If conn.State = ConnectionState.Open Then conn.Close()
        Try
            conn.Open()
            cmd = New OleDbCommand(query, conn)
            da = New OleDbDataAdapter(cmd)
            dt = New DataTable
            cnt = da.Fill(dt)


        Catch ex As Exception
        End Try
    End Sub
End Module
