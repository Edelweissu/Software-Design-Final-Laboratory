Public Class SearchBar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        query = "Select * from tbRegistered where " & ComboBox1.Text & " LIKE '%" & Search.Text & "%'"
        Exec()

        If cnt = 0 Then
            MessageBox.Show(Search.Text & " Could not be found in the database", "Logged In",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)
        Else
            If RadioButton1.Checked = True Then
                PatientList.Listview1.Items.Clear()
                query = "Select * from tbRegistered where " & ComboBox1.Text & " LIKE '%" & Search.Text & "%' and Sex = 'Male' "
                Exec()
                For Each R As DataRow In dt.Rows
                    PatientList.Listview1.Items.Add(R("PatientID"))
                    With PatientList.Listview1.Items(PatientList.Listview1.Items.Count - 1).SubItems
                        .Add(R("LastName"))
                        .Add(R("FirstName"))
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
                MessageBox.Show(PatientList.Listview1.Items.Count & " Items have been found in the database", "Logged In",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button2)
                RadioButton1.Checked = False
            ElseIf RadioButton2.Checked = True Then
                PatientList.Listview1.Items.Clear()
                query = "Select * from tbRegistered where " & ComboBox1.Text & " LIKE '%" & Search.Text & "%' and Sex = 'Female' "
                Exec()
                For Each R As DataRow In dt.Rows
                    PatientList.Listview1.Items.Add(R("PatientID"))
                    With PatientList.Listview1.Items(PatientList.Listview1.Items.Count - 1).SubItems
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
                MessageBox.Show(PatientList.Listview1.Items.Count & " Items have been found in the database", "Logged In",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button2)
                RadioButton2.Checked = False
            ElseIf (RadioButton1.Checked And RadioButton2.Checked) = False Then
                RadioButton3.Checked = True
                PatientList.Listview1.Items.Clear()
                query = "Select * from tbRegistered where " & ComboBox1.Text & " LIKE '%" & Search.Text & "%'"
                Exec()
                For Each R As DataRow In dt.Rows
                    PatientList.Listview1.Items.Add(R("PatientID"))
                    With PatientList.Listview1.Items(PatientList.Listview1.Items.Count - 1).SubItems
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
                MessageBox.Show(PatientList.Listview1.Items.Count & " Items have been found in the database", "Logged In",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button2)
                RadioButton3.Checked = False
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
    Private Sub Search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Search.KeyPress
        If ComboBox1.Text = "PatientID" Then
            Search.MaxLength = 12
            KeyfilterNumber(e)
        Else
            KeyFilterAlpha(e)
        End If
    End Sub

End Class