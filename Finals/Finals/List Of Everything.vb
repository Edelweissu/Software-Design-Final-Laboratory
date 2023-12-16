Imports System.Data.SqlClient
Module MunicipalityList
    Public Sub Municipal()
        If PatientForm.Municipality.Text = "Agno" Then
            PatientForm.ZipCode.Text = "2408"
        ElseIf PatientForm.Municipality.Text = "Aguilar" Then
            PatientForm.ZipCode.Text = "2415"
        ElseIf PatientForm.Municipality.Text = "Alaminos City" Then
            PatientForm.ZipCode.Text = "2404"
        ElseIf PatientForm.Municipality.Text = "Alcala" Then
            PatientForm.ZipCode.Text = "2425"
        ElseIf PatientForm.Municipality.Text = "Anda" Then
            PatientForm.ZipCode.Text = "2405"
        ElseIf PatientForm.Municipality.Text = "Asingan" Then
            PatientForm.ZipCode.Text = "2439"
        ElseIf PatientForm.Municipality.Text = "Balungao" Then
            PatientForm.ZipCode.Text = "2442"
        ElseIf PatientForm.Municipality.Text = "Bani" Then
            PatientForm.ZipCode.Text = "2407"
        ElseIf PatientForm.Municipality.Text = "Basista" Then
            PatientForm.ZipCode.Text = "2422"
        ElseIf PatientForm.Municipality.Text = "Bautista" Then
            PatientForm.ZipCode.Text = "2424"
        ElseIf PatientForm.Municipality.Text = "Bayambang" Then
            PatientForm.ZipCode.Text = "2423"
        ElseIf PatientForm.Municipality.Text = "Binalonan" Then
            PatientForm.ZipCode.Text = "2436"
        ElseIf PatientForm.Municipality.Text = "Binmaley" Then
            PatientForm.ZipCode.Text = "2417"
        ElseIf PatientForm.Municipality.Text = "Bolinao" Then
            PatientForm.ZipCode.Text = "2406"
        ElseIf PatientForm.Municipality.Text = "Bugallon" Then
            PatientForm.ZipCode.Text = "2416"
        ElseIf PatientForm.Municipality.Text = "Burgos" Then
            PatientForm.ZipCode.Text = "2410"
        ElseIf PatientForm.Municipality.Text = "Calasiao" Then
            PatientForm.ZipCode.Text = "2418"
        ElseIf PatientForm.Municipality.Text = "Dagupan City" Then
            PatientForm.ZipCode.Text = "2400"
        ElseIf PatientForm.Municipality.Text = "Dasol" Then
            PatientForm.ZipCode.Text = "2411"
        ElseIf PatientForm.Municipality.Text = "Infanta" Then
            PatientForm.ZipCode.Text = "2412"
        ElseIf PatientForm.Municipality.Text = "Labrador" Then
            PatientForm.ZipCode.Text = "2402"
        ElseIf PatientForm.Municipality.Text = "Laoac" Then
            PatientForm.ZipCode.Text = "2437"
        ElseIf PatientForm.Municipality.Text = "Lingayen" Then
            PatientForm.ZipCode.Text = "2401"
        ElseIf PatientForm.Municipality.Text = "Mabini" Then
            PatientForm.ZipCode.Text = "2409"
        ElseIf PatientForm.Municipality.Text = "Malasiqui" Then
            PatientForm.ZipCode.Text = "2421"
        ElseIf PatientForm.Municipality.Text = "Manaoag" Then
            PatientForm.ZipCode.Text = "2430"
        ElseIf PatientForm.Municipality.Text = "Mangaldan" Then
            PatientForm.ZipCode.Text = "2432"
        ElseIf PatientForm.Municipality.Text = "Mangatarem" Then
            PatientForm.ZipCode.Text = "2413"
        ElseIf PatientForm.Municipality.Text = "Mapandan" Then
            PatientForm.ZipCode.Text = "2429"
        ElseIf PatientForm.Municipality.Text = "Natividad" Then
            PatientForm.ZipCode.Text = "2446"
        ElseIf PatientForm.Municipality.Text = "Pozorrubio" Then
            PatientForm.ZipCode.Text = "2435"
        ElseIf PatientForm.Municipality.Text = "Rosales" Then
            PatientForm.ZipCode.Text = "2441"
        ElseIf PatientForm.Municipality.Text = "San Carlos City" Then
            PatientForm.ZipCode.Text = "2420"
        ElseIf PatientForm.Municipality.Text = "San Fabian" Then
            PatientForm.ZipCode.Text = "2433"
        ElseIf PatientForm.Municipality.Text = "San Jacinto" Then
            PatientForm.ZipCode.Text = "2431"
        ElseIf PatientForm.Municipality.Text = "San Manuel" Then
            PatientForm.ZipCode.Text = "2438"
        ElseIf PatientForm.Municipality.Text = "San Nicolas" Then
            PatientForm.ZipCode.Text = "2447"
        ElseIf PatientForm.Municipality.Text = "San Quintin" Then
            PatientForm.ZipCode.Text = "2444"
        ElseIf PatientForm.Municipality.Text = "Santa Maria" Then
            PatientForm.ZipCode.Text = "2440"
        ElseIf PatientForm.Municipality.Text = "Santa Barbara" Then
            PatientForm.ZipCode.Text = "2419"
        ElseIf PatientForm.Municipality.Text = "Santo Tomas" Then
            PatientForm.ZipCode.Text = "2426"
        ElseIf PatientForm.Municipality.Text = "Sison" Then
            PatientForm.ZipCode.Text = "2434"
        ElseIf PatientForm.Municipality.Text = "Sual" Then
            PatientForm.ZipCode.Text = "2403"
        ElseIf PatientForm.Municipality.Text = "Tayug" Then
            PatientForm.ZipCode.Text = "2445"
        ElseIf PatientForm.Municipality.Text = "Umingan" Then
            PatientForm.ZipCode.Text = "2443"
        ElseIf PatientForm.Municipality.Text = "Urbiztondo" Then
            PatientForm.ZipCode.Text = "2414"
        ElseIf PatientForm.Municipality.Text = "Urdaneta City" Then
            PatientForm.ZipCode.Text = "2428"
        ElseIf PatientForm.Municipality.Text = "Villasis" Then
            PatientForm.ZipCode.Text = "2427"
        End If
    End Sub
    Public Sub VaccineEfficacy()

    End Sub
    Public Sub VaccineAgeGroup()
        Dim vaccAge As Integer
        vaccAge = Convert.ToInt32(PatientForm.TextBox1.Text)

        If vaccAge < 12 Then
            PatientForm.Vaccines.Items.Clear()
            Dim confirmation As DialogResult = MessageBox.Show("Not Eligible for Vaccine", "Error Due to young age",
             MessageBoxButtons.OK,
             MessageBoxIcon.Error,
             MessageBoxDefaultButton.Button2)
            PatientForm.Vaccines.Enabled = False
            PatientForm.VaccSite.Enabled = False

        ElseIf vaccAge > 11 And vaccAge < 18 Then
            PatientForm.Vaccines.Items.Clear()
            PatientForm.Vaccines.Items.Add("Pfizer Vaccine")
            PatientForm.VaccSite.Enabled = True
            PatientForm.Vaccines.Enabled = True
        ElseIf vaccAge > 18 Then
            If vaccAge < 60 Then
                PatientForm.Vaccines.Items.Clear()
                PatientForm.Vaccines.Items.Add("AstraZeneca Vaccine")
                PatientForm.Vaccines.Items.Add("Janssen Vaccine")
                PatientForm.Vaccines.Items.Add("Moderna Vaccine")
                PatientForm.Vaccines.Items.Add("Pfizer Vaccine")
                PatientForm.Vaccines.Items.Add("Sinovac Vaccine")
                PatientForm.VaccSite.Enabled = True
                PatientForm.Vaccines.Enabled = True
            Else
                PatientForm.Vaccines.Items.Clear()
                PatientForm.Vaccines.Items.Add("Janssen Vaccine")
                PatientForm.Vaccines.Items.Add("Moderna Vaccine")
                PatientForm.Vaccines.Items.Add("Pfizer Vaccine")
                PatientForm.VaccSite.Enabled = True
                PatientForm.Vaccines.Enabled = True
            End If

        End If
    End Sub
    Public Sub DataInsert()

        PatientList.Listview1.View = View.Details

        PatientIDFinder()

        query = "Insert Into TbRegistered (PatientID,LastName,FirstName,MiddleName,Sex,Age,CityOrTown,ZipCode,VaccSite,Vaccine,HealthcareProf,Date,Contactno) VALUES ('" & PatientForm.PatientID.Text & "','" & PatientForm.LastName.Text & "','" & PatientForm.FirstName.Text & "','" & PatientForm.MiddleName.Text & "','" & PatientForm.SexList.Text & "','" & PatientForm.TextBox1.Text & "','" & PatientForm.Municipality.Text & "','" & PatientForm.ZipCode.Text & "','" & PatientForm.VaccSite.Text & "','" & PatientForm.Vaccines.Text & "','" & PatientForm.DoctorName.Text & "','" & Date.Now.ToShortDateString & "', '" & PatientForm.ContactInfo.Text & "')"
        Exec()

        Dim List As New ListViewItem(PatientForm.PatientID.Text$)
        List.SubItems.Add(PatientForm.LastName.Text$)
        List.SubItems.Add(PatientForm.FirstName.Text$)
        List.SubItems.Add(PatientForm.MiddleName.Text$)
        List.SubItems.Add(PatientForm.SexList.Text$)
        List.SubItems.Add(PatientForm.TextBox1.Text$)
        List.SubItems.Add(PatientForm.Municipality.Text$)
        List.SubItems.Add(PatientForm.ZipCode.Text$)
        List.SubItems.Add(PatientForm.VaccSite.Text$)
        List.SubItems.Add(PatientForm.Vaccines.Text$)
        List.SubItems.Add(PatientForm.DoctorName.Text$)
        List.SubItems.Add(Date.Now.ToShortDateString)

        PatientList.Listview1.Items.Add(List)

        PatientList.Listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        PatientList.Listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        query = "Select * from tbUsers where Username = '" & LoginForm.TextBox1.Text & "' and Password = '" & LoginForm.TextBox2.Text & "'"
        Exec()
        Dim UserName As String
        UserName = dt.Rows(0)(3) & " " & dt.Rows(0)(4) & " " & dt.Rows(0)(2)
        query = "Insert into UserLog VALUES ('" & Date.Now.ToShortDateString & "', '" & UserName & "', 'Registered Client to Database')"
        Exec()

    End Sub
    Public Sub PatientIDFinder()
        'Make an ID for Patients (Year + Number)'

        query = "Select * from tblRegistered"
        Exec()

        Dim count As Int16 = PatientList.Listview1.Items.Count
        Dim idnumber As String
        Dim yrVal As String = DateTime.Now.Year
        Dim IDPatient As String

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
        count = count + 1
        idnumber = String.Format("{0:00000000}", count)
        IDPatient = yrVal + idnumber
        PatientForm.PatientID.Text = IDPatient

    End Sub
    Public Sub Doctors()
        PatientForm.DoctorName.AutoCompleteMode = AutoCompleteMode.Suggest
        PatientForm.DoctorName.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollection As New AutoCompleteStringCollection()
        AddItems(DataCollection)
        PatientForm.DoctorName.AutoCompleteCustomSource = DataCollection

    End Sub
    Public Sub AddItems(ByVal col As AutoCompleteStringCollection)
        col.Add("Lorenz Jericho C. Pagaduan")
        col.Add("Adrian Harvey V. Javier")
    End Sub

    Public Sub KeyfilterNumber(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Or Asc(e.KeyChar) = 45 Then      'Enables Backspace but Disables '-' sign'
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then  'Enables Numbers only'
                e.Handled = True
                e.Handled = Not Char.IsDigit(e.KeyChar)
            End If
        End If
    End Sub
    Public Sub KeyFilterAlpha(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) And Not (Asc(e.KeyChar) = 32) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Public Sub UserPerson()
        query = "Select * from tbUsers where Username = '" & LoginForm.TextBox1.Text & "' and Password = '" & LoginForm.TextBox2.Text & "'"
        Exec()
        Dim Name As String
        Name = dt.Rows(0)(3) & " " & dt.Rows(0)(4) & " " & dt.Rows(0)(2)
    End Sub
End Module
