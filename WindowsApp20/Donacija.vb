Imports System.Data.SqlClient
Public Class Donacija
    Dim konekcija As New SqlConnection("Server=computer_name;Database=Udomljavanje;Integrated Security=True")

    Private Sub IzvrsiUpit(query As String)
        Dim komanda As New SqlCommand(query, konekcija)
        konekcija.Open()
        komanda.ExecuteNonQuery()
        konekcija.Close()
    End Sub

    Private Sub btnUnos_Click(sender As Object, e As EventArgs) Handles btnUnos.Click
        If (TextBoxIme.Text = "" Or TextBoxPrezime.Text = "" Or TextBoxVrijednost.Text = "") Then
            MessageBox.Show("Potrabno je popuniti polja ime, prezime i vrijednost!")
        Else

            Dim unos As String = "INSERT INTO Donacija ([Ime donatora],[Prezime donatora],[Vrijednost donacije],[ID zaposlenog]) VALUES('" & TextBoxIme.Text & "','" & TextBoxPrezime.Text & "','" & TextBoxVrijednost.Text & "','" & TextBoxIme.Text & "')"
            IzvrsiUpit(unos)
            MessageBox.Show("Uspjesno ste unijeli donaciju!")
        End If



    End Sub

    Private Sub btnBrisanje_Click(sender As Object, e As EventArgs) Handles btnBrisanje.Click
        If (DataGridViewPrikaz.SelectedCells.Count > 0) Then
            Dim result As DialogResult = MessageBox.Show("Da li ste sigurni da zelite obrisati selektovano?", "Upozorenje!", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim indeks As Integer
                indeks = DataGridViewPrikaz.CurrentRow.Index
                Dim brisi As String = "DELETE FROM Donacija where [ID]='" & DataGridViewPrikaz.Item(0, indeks).Value & "' "
                IzvrsiUpit(brisi)
                MessageBox.Show("Uspjesno ste izbrisali podatke sa id-em:" + DataGridViewPrikaz.Item(0, indeks).Value.ToString)
            End If

        Else
            MessageBox.Show("Potrebno je selektovati polje prije brisanja!")
        End If

    End Sub

    Private Sub btnPretraga_Click(sender As Object, e As EventArgs) Handles btnPretraga.Click
        Try
            Dim unos As String = "select*from Donacija where [Ime donatora]='" & TextBoxIme.Text & "' and [Prezime donatora]='" & TextBoxPrezime.Text & "' "
            Dim adapter As New SqlDataAdapter(unos, konekcija)
            Dim tabela As New DataTable()
            adapter.Fill(tabela)
            'TextBoxID.Text = tabela.Rows(0)(0).ToString
            TextBoxVrijednost.Text = tabela.Rows(0)(3).ToString
        Catch ex As Exception
            MessageBox.Show("Nije pronađen donator u bazi podataka!")

        End Try

    End Sub

    Private Sub btnPrikaz_Click(sender As Object, e As EventArgs) Handles btnPrikaz.Click
        Dim naredba As String = "select*from Donacija"
        Dim adapter As New SqlDataAdapter(naredba, konekcija)
        Dim tabela As New DataTable()
        adapter.Fill(tabela)
        DataGridViewPrikaz.DataSource = tabela
        DataGridViewPrikaz.ClearSelection()

    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        LogIn.TextBoxUsername.Text = ""
        LogIn.MaskedTextBoxPassword.Text = ""
        LogIn.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim EditForm As New EditForm
        EditForm.LabelUsername.Text = Me.Label8.Text
        EditForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Index.Show()
        Index.Label3.Text = Me.Label8.Text
        Index.Label4.Text = Me.Label9.Text
        Me.Close()
    End Sub
End Class


