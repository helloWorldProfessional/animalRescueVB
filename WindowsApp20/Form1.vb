Imports System.Data.SqlClient
Public Class EditForm

    Private Sub Odustani_Click(sender As Object, e As EventArgs) Handles Odustani.Click
        Me.Close()
    End Sub
    Dim konekcija As New SqlConnection("Server=computer_name;Database=Udomljavanje;Integrated Security=True")
    Private Sub IzvrsiUpit(query As String)
        Dim komanda As New SqlCommand(query, konekcija)
        konekcija.Open()
        komanda.ExecuteNonQuery()
        konekcija.Close()
    End Sub

    Private Sub Potvrdi_Click(sender As Object, e As EventArgs) Handles Potvrdi.Click
        Try
            If (TextBoxNoviUN.Text.Trim.Length > 0 And TextBoxNoviPass.Text.Trim.Length > 0) Then
                If (String.Equals(TextBoxNoviPass.Text, TextBoxNoviPass2.Text)) Then
                    Dim usr As String = "Update Zaposleni set username='" & TextBoxNoviUN.Text & "',passwoord='" & TextBoxNoviPass.Text & "' where username='" & LabelUsername.Text & "'"
                    IzvrsiUpit(usr)
                    MessageBox.Show("Uspjesno ste promijenili kredencijale.")
                Else
                    Label6.Text = "*Passwordi se ne podudaraju."
                End If

                'Index.Label3.Text = Me.TextBoxNoviUN.Text
                'Sticenici.Label4.Text = Me.TextBoxNoviUN.Text
                'Zdravstveni_karton.Label15.Text = Me.TextBoxNoviUN.Text
                'Zaposleni.Label8.Text = Me.TextBoxNoviUN.Text
                'Usvajac.Label8.Text = Me.TextBoxNoviUN.Text
                'Cip.Label8.Text = Me.TextBoxNoviUN.Text
                'Donacija.Label8.Text = Me.TextBoxNoviUN.Text

            ElseIf (TextBoxNoviPass.Text.Trim.Length > 0) Then
                Dim pas As String = "Update Zaposleni set passwoord='" & TextBoxNoviPass.Text & "' where username='" & LabelUsername.Text & "'"

                If (String.Equals(TextBoxNoviPass.Text, TextBoxNoviPass2.Text)) Then
                    IzvrsiUpit(pas)
                    MessageBox.Show("Uspjesno ste promijenili password.")
                Else
                    Label6.Text = "*Passwordi se ne podudaraju."
                    TextBoxNoviPass.Text = ""
                    TextBoxNoviPass2.Text = ""
                End If

            ElseIf (TextBoxNoviUN.Text.Trim.Length > 0) Then
                Dim usr As String = "Update Zaposleni set username='" & TextBoxNoviUN.Text & "' where username='" & LabelUsername.Text & "'"
                IzvrsiUpit(usr)
                MessageBox.Show("Uspjesno ste promijenili korisnicko ime.")

            End If

            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class