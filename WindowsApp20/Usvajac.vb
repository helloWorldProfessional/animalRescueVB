Imports System.Data.SqlClient
Public Class Usvajac
    Dim connection As New SqlConnection("Server= computer_name; Database = Udomljavanje; Integrated Security = true")
    Private Sub IzvrsiUpit(query As String)
        Dim komanda As New SqlCommand(query, connection)
        connection.Open()
        komanda.ExecuteNonQuery()
        connection.Close()
    End Sub
    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

    End Sub
    Private Sub FindDostunpnost(q As String)
        TextBoxDostupnost.Text = ""
        Try
            Dim constr As String = "Server=computer_name;Database=Udomljavanje;Integrated Security=True"
            Using con As SqlConnection = New SqlConnection(constr)
                Using cmd As SqlCommand = New SqlCommand(q)
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    con.Open()
                    Using sdr As SqlDataReader = cmd.ExecuteReader()
                        sdr.Read()
                        TextBoxDostupnost.Text = sdr("Dostupnost pri usvajanju").ToString()
                    End Using
                    con.Close()
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUnos_Click(sender As Object, e As EventArgs) Handles btnUnos.Click
        Try

            Dim provjera As String = "select* from Usvajac where [ID zivotinje]='" & TextBoxIDzivotinje.Text & "'"
            Dim adapter As New SqlDataAdapter(provjera, connection)
            Dim tabela As New DataTable()
            adapter.Fill(tabela)

            If tabela.Rows.Count = 0 Then
                Dim insertQuery As String = "INSERT INTO Usvajac([Ime usvajaca],[Prezime usvajaca],[Adresa stanovanja usvajaca],[Kontakt telefon usvajaca],[ID zivotinje],[Datum usvajanja]) VALUES('" & TextBoxIme.Text & "','" & TextBoxPrezime.Text & "','" & TextBoxAdresa.Text & "','" & TextBoxTelefon.Text & "','" & TextBoxIDzivotinje.Text & "','" & DateTimePickerDU.Value.ToString & "')"
                ExecuteQuery(insertQuery)
                Dim DPU As String = "Update Zivotinja Set [Dostupnost pri usvajanju]='Udomljen/a' where [ID Zivotinja]='" & TextBoxIDzivotinje.Text & "'"
                IzvrsiUpit(DPU)
                MessageBox.Show("Uspjesno ste unijeli podatke u bazu!")

            Else
                MessageBox.Show("Unos onemogucen, sticenik je udomljen!")
            End If

        Catch ex As Exception
            MessageBox.Show("Greska prilikom unosa! Provjerite polja.")
        End Try

    End Sub

    Private Sub btnAzuriranje_Click(sender As Object, e As EventArgs) Handles btnAzuriranje.Click
        Try
            If (TextBoxIme.Text.Trim.Length > 0 Or TextBoxAdresa.Text.Trim.Length > 0 Or TextBoxPrezime.Text.Trim.Length > 0 Or TextBoxTelefon.Text.Trim.Length > 0 Or TextBoxIDzivotinje.Text.Trim.Length > 0) Then

                Dim ime As String = "Update Usvajac Set [Ime usvajaca]='" & TextBoxIme.Text & "' where [ID Usvajac]='" & TextBoxIDusvajaca.Text & "'"
                Dim prezime As String = "Update Usvajac Set [Prezime usvajaca]='" & TextBoxPrezime.Text & "' where [ID Usvajac]='" & TextBoxIDusvajaca.Text & "'"
                Dim adresa As String = "Update Usvajac Set [Adresa stanovanja usvajaca]='" & TextBoxAdresa.Text & "' where [ID Usvajac]='" & TextBoxIDusvajaca.Text & "'"
                Dim telefon As String = "Update Usvajac Set [Kontakt telefon usvajaca]='" & TextBoxTelefon.Text & "' where [ID Usvajac]='" & TextBoxIDusvajaca.Text & "'"
                Dim IDZ As String = "Update Usvajac Set [ID zivotinje]='" & TextBoxIDzivotinje.Text & "' where [ID Usvajac]='" & TextBoxIDusvajaca.Text & "'"
                Dim DU As String = "Update Usvajac Set [Datum usvajanja]='" & DateTimePickerDU.Value.ToString & "' where [ID Usvajac]='" & TextBoxIDusvajaca.Text & "'"


                If (Not String.IsNullOrEmpty(TextBoxIme.Text)) Then
                    ExecuteQuery(ime)

                End If
                If (Not String.IsNullOrEmpty(TextBoxPrezime.Text)) Then
                    ExecuteQuery(prezime)

                End If
                If (Not String.IsNullOrEmpty(TextBoxAdresa.Text)) Then
                    ExecuteQuery(adresa)

                End If
                If (Not String.IsNullOrEmpty(TextBoxTelefon.Text)) Then
                    ExecuteQuery(telefon)

                End If
                'If (Not String.IsNullOrEmpty(TextBoxIDzivotinje.Text)) Then
                '    ExecuteQuery(IDZ)

                'End If
                If (Not String.IsNullOrEmpty(DateTimePickerDU.Value.ToString)) Then
                    ExecuteQuery(DU)

                End If
                MessageBox.Show("Uspjesno ste azurirali bazu podataka!")
            Else
                MessageBox.Show("Popunite polja prije azuriranja!")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPretraga_Click(sender As Object, e As EventArgs) Handles btnPretraga.Click
        TextBoxIDusvajaca.Text = ""
        TextBoxAdresa.Text = ""
        TextBoxTelefon.Text = ""
        TextBoxIDzivotinje.Text = ""
        DateTimePickerDU.Text = ""
        TextBoxDostupnost.Text = ""
        If (TextBoxIme.Text = "" Or TextBoxPrezime.Text = "") Then
            MessageBox.Show("Za pretragu je potrebno popuniti polja ime i prezime!")

        Else
            Try
                Dim unos As String = "select*from Usvajac where [Ime usvajaca]='" & TextBoxIme.Text & "' and [Prezime usvajaca]='" & TextBoxPrezime.Text & "' "
                Dim adapter As New SqlDataAdapter(unos, connection)
                Dim tabela As New DataTable()
                adapter.Fill(tabela)
                DataGridView1.DataSource = tabela
                DataGridView1.ClearSelection()
            Catch ex As Exception

            End Try


        End If

    End Sub

    Private Sub btnIzbrisi_Click(sender As Object, e As EventArgs) Handles btnIzbrisi.Click
        If (DataGridView1.SelectedCells.Count > 0) Then
            Dim result As DialogResult = MessageBox.Show("Da li ste sigurni da zelite obrisati selektovano?", "Upozorenje!", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    Dim indeks As Integer
                    indeks = DataGridView1.CurrentRow.Index
                    Dim brisi As String = "DELETE FROM Usvajac WHERE [ID Usvajac]='" & DataGridView1.Item(0, indeks).Value & "'"
                    ExecuteQuery(brisi)
                    MessageBox.Show("Uspjesno ste izbrisali podatke sa id-em:" + DataGridView1.Item(0, indeks).Value.ToString)
                    Dim DPU As String = "Update Zivotinja Set [Dostupnost pri usvajanju]='Dostupan' where [ID Zivotinja]='" & TextBoxIDzivotinje.Text & "'"
                    IzvrsiUpit(DPU)

                Catch ex As Exception

                End Try

            End If
        Else
            MessageBox.Show("Potrebno je selektovati polje prije brisanja!")
        End If

    End Sub

    Private Sub btnPrikaz_Click(sender As Object, e As EventArgs) Handles btnPrikaz.Click
        Dim naredba As String = "select*from Usvajac"
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
        TextBoxIDusvajaca.Text = DataGridView1.Item(0, indeks).Value.ToString
        TextBoxIme.Text = DataGridView1.Item(1, indeks).Value.ToString
        TextBoxPrezime.Text = DataGridView1.Item(2, indeks).Value.ToString
        TextBoxAdresa.Text = DataGridView1.Item(3, indeks).Value.ToString
        TextBoxTelefon.Text = DataGridView1.Item(4, indeks).Value.ToString
        TextBoxIDzivotinje.Text = DataGridView1.Item(5, indeks).Value.ToString
        DateTimePickerDU.Text = DataGridView1.Item(6, indeks).Value.ToString
        Dim dostupnost As String = "select [Dostupnost pri usvajanju] from Zivotinja where [ID Zivotinja]='" & TextBoxIDzivotinje.Text & "'"
        FindDostunpnost(dostupnost)
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
        TextBoxIDusvajaca.Text = ""
        TextBoxIme.Text = ""
        TextBoxPrezime.Text = ""
        TextBoxAdresa.Text = ""
        TextBoxTelefon.Text = ""
        TextBoxIDzivotinje.Text = ""
        TextBoxDostupnost.Text = ""
        DateTimePickerDU.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Index.Show()
        Index.Label3.Text = Me.Label8.Text
        Index.Label4.Text = Me.Label9.Text
        Me.Close()
    End Sub
End Class
