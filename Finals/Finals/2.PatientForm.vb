Imports System.Data.SqlClient
Public Class PatientForm
    Private Sub PatientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Doctors()

    End Sub
    Private Sub PatientForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    '//Passive Code//'
    Private Sub Municipality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Municipality.SelectedIndexChanged
        Municipal()
    End Sub
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
    Private Sub ContactInfo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ContactInfo.KeyPress
        If Asc(e.KeyChar) <> 8 Or Asc(e.KeyChar) = 45 Then      'Enables Backspace but Disables '-' sign'
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then  'Enables Numbers only'
                e.Handled = True
            End If
        End If
    End Sub
    'Age'
    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Or Asc(e.KeyChar) = 45 Then      'Enables Backspace but Disables '-' sign'
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then  'Enables Numbers only'
                e.Handled = True
                e.Handled = Not Char.IsDigit(e.KeyChar)
            End If
        End If
    End Sub
    '//Active Code//'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        PatientList.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If FirstName.Text = Nothing Or LastName.Text = Nothing Or TextBox1.Text = Nothing _
                            Or ContactInfo.Text = Nothing Or SexList.Text = Nothing Or Municipality.Text = Nothing _
                            Or VaccSite.Text = Nothing Or DoctorName.Text = Nothing Then
            Me.Hide()
            MessageBox.Show("Please fill up the form" & vbCrLf & "in order to proceed", "Incomplete Form",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)
            Me.Show()
        Else
            DataInsert()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FirstName.Text = Nothing
        LastName.Text = Nothing
        MiddleName.Text = Nothing
        TextBox1.Text = Nothing
        ContactInfo.Text = Nothing
        SexList.Text = Nothing
        ZipCode.Text = ""
        Municipality.Text = Nothing
        VaccSite.Text = Nothing
    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles TextBox1.MouseLeave
        If TextBox1.TextLength > 1 Then
            VaccineAgeGroup()
        Else
            MessageBox.Show("Not Eligible for Vaccine", "Young Age",
        MessageBoxButtons.OK,
        MessageBoxIcon.Error,
        MessageBoxDefaultButton.Button2)
        End If
    End Sub
End Class

