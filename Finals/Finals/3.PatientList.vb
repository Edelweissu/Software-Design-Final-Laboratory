Public Class PatientList
    Dim sortColumn As Integer = -1
    ' The column currently used for sorting.
    Private m_SortingColumn As ColumnHeader
    Private Sub Form3_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub PatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fill()
        Print()
        Listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        Listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub Fill()

        query = "Select * from tbRegistered"
        Exec()
        For Each R As DataRow In dt.Rows
            Listview1.Items.Add(R("PatientID"))
            With Listview1.Items(Listview1.Items.Count - 1).SubItems
                .Add(R("FirstName"))
                .Add(R("LastName"))
                .Add(R("MiddleName"))
                .Add(R("Sex"))
                .Add(R("Age"))
                .Add(R("CityOrTown"))
                .Add(R("ZipCode"))
                .Add(R("VaccSite"))
                .Add(R("Vaccine"))
                .Add(R("HealthcareProf"))
                .Add(R("Date"))
            End With
        Next

    End Sub
    Private Sub Print()
        query = "select * from tbRegistered"
        Exec()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PatientForm.Vaccines.Enabled = False
        PatientForm.VaccSite.Enabled = False
        PatientForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SearchBar.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Listview1.Items.Clear()
        query = "Select * from tbRegistered where Date = '" & DateTimePicker1.Text & "'"
        Exec()
        If cnt > 0 Then
            For Each R As DataRow In dt.Rows
                Listview1.Items.Add(R("PatientID"))
                With Listview1.Items(Listview1.Items.Count - 1).SubItems
                    .Add(R("FirstName"))
                    .Add(R("LastName"))
                    .Add(R("MiddleName"))
                    .Add(R("Sex"))
                    .Add(R("Age"))
                    .Add(R("CityOrTown"))
                    .Add(R("ZipCode"))
                    .Add(R("VaccSite"))
                    .Add(R("Vaccine"))
                    .Add(R("HealthcareProf"))
                    .Add(R("Date"))
                End With
            Next
        End If
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If Listview1.SelectedItems.Count = 0 Then Exit Sub

        query = "Select * from tbRegistered where PatientID = '" & Listview1.SelectedItems(0).Text & "'"
        Exec()

        PatientForm.Vaccines.Enabled = True
        PatientForm.VaccSite.Enabled = True

        PatientForm.Show()

        PatientForm.PatientID.Text = Listview1.SelectedItems(0).Text
        Dim txt As TextBox() = {PatientForm.LastName, PatientForm.FirstName, PatientForm.MiddleName}
        For x = 0 To UBound(txt)
            txt(x).Text = Listview1.SelectedItems(0).SubItems(x + 1).Text
        Next
        PatientForm.SexList.Text = Listview1.SelectedItems(0).SubItems(4).Text
        PatientForm.TextBox1.Text = Listview1.SelectedItems(0).SubItems(5).Text
        PatientForm.Municipality.Text = Listview1.SelectedItems(0).SubItems(6).Text
        PatientForm.ZipCode.Text = Listview1.SelectedItems(0).SubItems(7).Text
        PatientForm.VaccSite.Text = Listview1.SelectedItems(0).SubItems(8).Text
        PatientForm.Vaccines.Text = Listview1.SelectedItems(0).SubItems(9).Text
        PatientForm.DoctorName.Text = Listview1.SelectedItems(0).SubItems(10).Text
        Listview1.SelectedItems(0).SubItems(11).Text = Date.Now.ToShortDateString
        PatientForm.ContactInfo.Text = dt.Rows(0)(12)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If Listview1.SelectedItems.Count = 0 Then Exit Sub

        query = "delete from tbRegistered where PatientID = '" & Listview1.SelectedItems(0).Text & "'"
        Exec()

        Listview1.SelectedItems(0).Remove()
    End Sub
End Class
