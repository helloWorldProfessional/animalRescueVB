Imports System.Data.SqlClient
Public Class LogIn
    Dim konekcija As New SqlConnection("Server=computer_name;Database=Udomljavanje;Integrated Security=True")

    Private Sub IzvrsiUpit(query As String)
        Dim komanda As New SqlCommand(query, konekcija)
        konekcija.Open()
        komanda.ExecuteNonQuery()
        konekcija.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = ""

        Try
            Dim unos As String = "select*from Zaposleni where username='" & TextBoxUsername.Text & "' and passwoord='" & MaskedTextBoxPassword.Text & "' "
            Dim adapter As New SqlDataAdapter(unos, konekcija)
            Dim tabela As New DataTable()
            adapter.Fill(tabela)
            If tabela.Rows.Count < 1 Then
                Label3.Text = "*Pogresni kredencijali!"
                TextBoxUsername.Text = ""
                MaskedTextBoxPassword.Text = ""
            Else
                Dim Index As New Index
                Index.Show()
                Index.Label3.Text = TextBoxUsername.Text
                Index.Label4.Text = tabela.Rows(0)(0).ToString
                Me.Hide()
            End If

        Catch ex As Exception

            MessageBox.Show("Greška na serveru.")

        End Try
    End Sub


End Class