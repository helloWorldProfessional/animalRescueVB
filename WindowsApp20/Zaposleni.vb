Imports System.Data.SqlClient
Public Class Zaposleni
    Dim connection As New SqlConnection("Server= computer_name; Database = Udomljavanje; Integrated Security = true")
    Private Sub IzvrsiUpit(query As String)
        Dim komanda As New SqlCommand(query, connection)
        connection.Open()
        komanda.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub ButtonPrikaz_Click(sender As Object, e As EventArgs) Handles ButtonPrikaz.Click
        'Dim naredba As String = "select*from Zaposleni"
        Dim naredba As String = "select [ID zaposleni] as ID,[Ime zaposlenog] as Ime ,[Prezime zaposlenog] as Prezime,[Adresa stanovanja zaposlenog] as Adresa,[Kontakt telefon zaposlenog] as Telefon,[Email zaposlenog] as Email,[Status zaposlenog] as Status from Zaposleni"
        Dim adapter As New SqlDataAdapter(naredba, connection)
        Dim tabela As New DataTable()
        adapter.Fill(tabela)
        DataGridView1.DataSource = tabela
        DataGridView1.ClearSelection()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Dim indeks As Integer
        indeks = DataGridView1.CurrentRow.Index
        DataGridView1.ClearSelection()
        TextBoxID.Text = DataGridView1.Item(0, indeks).Value.ToString
        TextBoxIme.Text = DataGridView1.Item(1, indeks).Value.ToString
        TextBoxPrezime.Text = DataGridView1.Item(2, indeks).Value.ToString
        TextBoxAdresa.Text = DataGridView1.Item(3, indeks).Value.ToString
        TextBoxTelefon.Text = DataGridView1.Item(4, indeks).Value.ToString
        TextBoxEmail.Text = DataGridView1.Item(5, indeks).Value.ToString
        ComboBoxStatus.Text = DataGridView1.Item(6, indeks).Value.ToString

    End Sub

    Private Sub ButtonPretraga_Click(sender As Object, e As EventArgs) Handles ButtonPretraga.Click

        TextBoxID.Text = ""
        TextBoxAdresa.Text = ""
        TextBoxTelefon.Text = ""
        TextBoxEmail.Text = ""
        ComboBoxStatus.Text = ""

        If (TextBoxIme.Text = "" Or TextBoxPrezime.Text = "") Then
            MessageBox.Show("Za pretragu je potrebno popuniti polja ime i prezime!")

        Else
            Try
                Dim unos As String = "select [ID zaposleni] as ID,[Ime zaposlenog] as Ime ,[Prezime zaposlenog] as Prezime,[Adresa stanovanja zaposlenog] as Adresa,[Kontakt telefon zaposlenog] as Telefon,[Email zaposlenog] as Email,[Status zaposlenog] as Status from Zaposleni where [Ime zaposlenog]='" & TextBoxIme.Text & "' and [Prezime zaposlenog]='" & TextBoxPrezime.Text & "' "
                Dim adapter As New SqlDataAdapter(unos, connection)
                Dim tabela As New DataTable()
                adapter.Fill(tabela)
                DataGridView1.DataSource = tabela
                DataGridView1.ClearSelection()

            Catch ex As Exception
                MessageBox.Show("Nalog nije pronađen u bazi!")
            End Try

        End If

    End Sub

    Private Sub ButtonUnos_Click(sender As Object, e As EventArgs) Handles ButtonUnos.Click


        Dim provjera As String = "select* from Zaposleni where [Ime zaposlenog]='" & TextBoxIme.Text & "' and [Prezime zaposlenog]='" & TextBoxPrezime.Text & "'"
        Dim adapter As New SqlDataAdapter(provjera, connection)
        Dim tabela As New DataTable()
        adapter.Fill(tabela)
        If tabela.Rows.Count = 0 Then
            If TextBoxIme.Text = "" Or TextBoxPrezime.Text = "" Or TextBoxTelefon.Text = "" Or String.IsNullOrEmpty(ComboBoxStatus.SelectedItem) Or TextBoxUserN.Text = "" Then
                MessageBox.Show("Potrebno je popuniti polja Ime, Prezime, Username, Telefon i Status za kreiranje novog naloga!")
            Else
                Try
                    Dim insertQuery As String = "INSERT INTO Zaposleni([Ime zaposlenog],[Prezime zaposlenog],[Adresa stanovanja zaposlenog],[Kontakt telefon zaposlenog],[Email zaposlenog],[Status zaposlenog],username) VALUES('" & TextBoxIme.Text & "','" & TextBoxPrezime.Text & "','" & TextBoxAdresa.Text & "','" & TextBoxTelefon.Text & "','" & TextBoxEmail.Text & "','" & ComboBoxStatus.SelectedItem.ToString & "','" & TextBoxUserN.Text & "')"
                    IzvrsiUpit(insertQuery)
                    MessageBox.Show("Uspjesno ste kreirali novi nalog!")
                Catch ex As Exception

                End Try

            End If

        Else

            Dim result As DialogResult = MessageBox.Show("Nalog sa navedenim imenom i prezimenom vec postoji! Da li zelite nastaviti sa izradom novog naloga?", "Upozorenje!", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    Dim insertQuery As String = "INSERT INTO Zaposleni([Ime zaposlenog],[Prezime zaposlenog],[Adresa stanovanja zaposlenog],[Kontakt telefon zaposlenog],[Email zaposlenog],[Status zaposlenog]) VALUES('" & TextBoxIme.Text & "','" & TextBoxPrezime.Text & "','" & TextBoxAdresa.Text & "','" & TextBoxTelefon.Text & "','" & TextBoxEmail.Text & "','" & ComboBoxStatus.SelectedItem.ToString & "')"
                    IzvrsiUpit(insertQuery)
                    MessageBox.Show("Uspjesno ste kreirali novi nalog!")

                Catch ex As Exception

                End Try

            End If
        End If



    End Sub

    Private Sub ButtonAzuriraj_Click(sender As Object, e As EventArgs) Handles ButtonAzuriraj.Click
        Try

            If (Not String.IsNullOrEmpty(TextBoxID.Text)) Then
                Dim ime As String = "Update Zaposleni Set [Ime zaposlenog]='" & TextBoxIme.Text & "' where [ID zaposleni]='" & TextBoxID.Text & "'"
                Dim prezime As String = "Update Zaposleni Set [Prezime zaposlenog]='" & TextBoxPrezime.Text & "' where [ID zaposleni]='" & TextBoxID.Text & "'"
                Dim adresa As String = "Update Zaposleni Set [Adresa stanovanja zaposlenog]='" & TextBoxAdresa.Text & "' where [ID zaposleni]='" & TextBoxID.Text & "'"
                Dim telefon As String = "Update Zaposleni Set [Kontakt telefon zaposlenog]='" & TextBoxTelefon.Text & "' where [ID zaposleni]='" & TextBoxID.Text & "'"
                Dim email As String = "Update Zaposleni Set [Email zaposlenog]='" & TextBoxEmail.Text & "' where [ID zaposleni]='" & TextBoxID.Text & "'"
                Dim status As String = "Update Zaposleni Set [Status zaposlenog]='" & ComboBoxStatus.SelectedItem.ToString & "' where [ID zaposleni]='" & TextBoxID.Text & "'"


                If (Not String.IsNullOrEmpty(TextBoxIme.Text)) Then
                    IzvrsiUpit(ime)

                End If
                If (Not String.IsNullOrEmpty(TextBoxPrezime.Text)) Then
                    IzvrsiUpit(prezime)

                End If
                If (Not String.IsNullOrEmpty(TextBoxAdresa.Text)) Then
                    IzvrsiUpit(adresa)

                End If
                If (Not String.IsNullOrEmpty(TextBoxTelefon.Text)) Then
                    IzvrsiUpit(telefon)

                End If
                If (Not String.IsNullOrEmpty(TextBoxEmail.Text)) Then
                    IzvrsiUpit(email)

                End If
                If (Not String.IsNullOrEmpty(ComboBoxStatus.SelectedItem.ToString)) Then
                    IzvrsiUpit(status)

                End If
                MessageBox.Show("Uspjesno ste azurirali bazu podataka!")
            Else
                MessageBox.Show("Unesite ID! Azuriranje se vrsi na onsnovu ID-a zaposlenog! ")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonIzbrisi_Click(sender As Object, e As EventArgs) Handles ButtonIzbrisi.Click
        If (DataGridView1.SelectedCells.Count > 0) Then
            Dim result As DialogResult = MessageBox.Show("Da li ste sigurni da zelite obrisati selektovano?", "Upozorenje!", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    Dim indeks As Integer
                    indeks = DataGridView1.CurrentRow.Index
                    Dim brisi As String = "DELETE FROM Zaposleni WHERE [ID zaposleni]='" & DataGridView1.Item(0, indeks).Value & "'"
                    IzvrsiUpit(brisi)
                    MessageBox.Show("Uspjesno ste izbrisali podatke sa id-em:" + DataGridView1.Item(0, indeks).Value.ToString)

                Catch ex As Exception

                End Try

            End If
        Else
            MessageBox.Show("Potrebno je selektovati polje iz tabele!")
        End If
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
        TextBoxID.Text = ""
        TextBoxIme.Text = ""
        TextBoxPrezime.Text = ""
        TextBoxAdresa.Text = ""
        TextBoxTelefon.Text = ""
        TextBoxEmail.Text = ""
        ComboBoxStatus.Text = ""
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Index.Show()
        Index.Label3.Text = Me.Label8.Text
        Index.Label4.Text = Me.Label9.Text
        Me.Close()
    End Sub
End Class