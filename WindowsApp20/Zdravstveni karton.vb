Imports System.Data.SqlClient
Public Class Zdravstveni_karton
    Dim connection As New SqlConnection("Server= computer_name; Database = Udomljavanje; Integrated Security = true")

    Private Sub IzvrsiUpit(query As String)
        Dim komanda As New SqlCommand(query, connection)
        connection.Open()
        komanda.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub ButtonPretraga_Click(sender As Object, e As EventArgs) Handles ButtonPretraga.Click
        TextBoxVelicina.Text = ""
        TextBoxKilaza.Text = ""
        TextBoxBoja.Text = ""
        ComboBoxSteril.Text = ""
        DateTimePickerSteril.Text = ""
        TextBoxVA.Text = ""
        TextBoxDoktor.Text = ""
        TextBoxID.Text = ""
        TextBoxBoja.Text = ""
        DateTimePickerDU.Text = ""
        TextBoxRU.Text = ""

        If (TextBoxIme.Text = "") Then
            MessageBox.Show("Za pretragu je potrebno popuniti polja ime!")

        Else
            Try
                Dim unos As String = "select [ID Zivotinja] as ID,Ime, Vrsta, Rasa, Starost from Zivotinja where [Ime ]='" & TextBoxIme.Text & "' "
                Dim adapter As New SqlDataAdapter(unos, connection)
                Dim tabela As New DataTable()
                adapter.Fill(tabela)
                DataGridView1.DataSource = tabela
                DataGridView1.ClearSelection()


            Catch ex As Exception
                MessageBox.Show("Nije pronadjen u bazi podataka!")
            End Try


        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Dim indeks As Integer
        indeks = DataGridView1.CurrentRow.Index
        DataGridView1.ClearSelection()
        TextBoxIme.Text = DataGridView1.Item(1, indeks).Value.ToString
        Try
            Dim unos As String = "select*from [Zdravstveni karton] where [ID zivotinjA]='" & DataGridView1.Item(0, indeks).Value.ToString & "'"
            Dim adapter As New SqlDataAdapter(unos, connection)
            Dim tabela As New DataTable()
            adapter.Fill(tabela)
            DataGridView1.ClearSelection()
            TextBoxID.Text = tabela.Rows(0)(1).ToString()

            TextBoxVelicina.Text = tabela.Rows(0)(2).ToString() 'DataGridView1.Item(2, indeks).Value.ToString
            TextBoxKilaza.Text = tabela.Rows(0)(3).ToString() 'DataGridView1.Item(3, indeks).Value.ToString
            TextBoxBoja.Text = tabela.Rows(0)(4).ToString() 'DataGridView1.Item(4, indeks).Value.ToString
            ComboBoxSteril.Text = tabela.Rows(0)(5).ToString() 'DataGridView1.Item(5, indeks).Value.ToString
            DateTimePickerSteril.Text = tabela.Rows(0)(6).ToString() 'DataGridView1.Item(6, indeks).Value.ToString
            TextBoxVA.Text = tabela.Rows(0)(7).ToString() 'DataGridView1.Item(7, indeks).Value.ToString
            TextBoxDoktor.Text = tabela.Rows(0)(8).ToString() 'DataGridView1.Item(8, indeks).Value.ToString
            'TextBoxLijekovi.Text = tabela.Rows(0)(9).ToString() 'DataGridView1.Item(9, indeks).Value.ToString
            'TextBoxDetalji.Text = tabela.Rows(0)(10).ToString() 'DataGridView1.Item(10, indeks).Value.ToString
            DateTimePickerDU.Text = tabela.Rows(0)(11).ToString() 'DataGridView1.Item(11, indeks).Value.ToString
            TextBoxRU.Text = tabela.Rows(0)(12).ToString() 'DataGridView1.Item(12, indeks).Value.ToString
        Catch ex As Exception

        End Try



    End Sub

    Private Sub ButtonListaj_Click(sender As Object, e As EventArgs) Handles ButtonListaj.Click
        Try
            'Dim unos As String = "select Zivotinja.[ID Zivotinja] as ID, Zivotinja.Ime, Terapija.Lijek,Terapija.[Pocetak terapije],Terapija.[Kraj terapije], Zivotinja.Starost, Zivotinja.Pol, [Zdravstveni karton].Doktor,[Zdravstveni karton].[Kilaza (kg)],[Zdravstveni karton].[Sterilizovan/a] from Zivotinja inner join Terapija on  Zivotinja.[ID Zivotinja]=Terapija.[ID zivotinja] inner join [Zdravstveni karton] on Zivotinja.[ID Zivotinja]=[Zdravstveni karton].[ID zivotinja]"
            Dim unos As String = "select Zivotinja.[ID Zivotinja] as ID, Zivotinja.Ime, Terapija.Lijek,Terapija.[Pocetak terapije] as Pocetak,Terapija.[Kraj terapije] as Kraj, Zivotinja.Starost, Zivotinja.Pol, [Zdravstveni karton].Doktor,[Zdravstveni karton].[Kilaza (kg)],[Zdravstveni karton].[Sterilizovan/a],Terapija.RB from Zivotinja inner join Terapija on  Zivotinja.[ID Zivotinja]=Terapija.[ID zivotinja] inner join [Zdravstveni karton] on Zivotinja.[ID Zivotinja]=[Zdravstveni karton].[ID zivotinja] where Zivotinja.[ID Zivotinja]='" & TextBoxID.Text & "'"
            Dim adapter As New SqlDataAdapter(unos, connection)
            Dim tabela As New DataTable()
            adapter.Fill(tabela)
            DataGridView1.DataSource = tabela
            DataGridView1.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Nije pronadjen u bazi podataka!")
        End Try
    End Sub

    Private Sub ButtonAzuriraj_Click(sender As Object, e As EventArgs) Handles ButtonAzuriraj.Click
        Dim velicina As String = "Update [Zdravstveni karton] Set Velicina='" & TextBoxVelicina.Text & "' where [ID zivotinja]='" & TextBoxID.Text & "'"
        Dim kilaza As String = "Update [Zdravstveni karton] Set [Kilaza (kg)]='" & TextBoxKilaza.Text & "' where [ID zivotinja]='" & TextBoxID.Text & "'"
        Dim boja As String = "Update [Zdravstveni karton] Set Boja='" & TextBoxBoja.Text & "' where [ID zivotinja]='" & TextBoxID.Text & "'"
        Dim steril As String = "Update [Zdravstveni karton] Set [Sterilizovan/a]='" & ComboBoxSteril.SelectedItem.ToString & "' where [ID zivotinja]='" & TextBoxID.Text & "'"
        Dim datS As String = "Update [Zdravstveni karton] Set [Datum sterilizacije]='" & DateTimePickerSteril.Value.ToString & "' where [ID zivotinja]='" & TextBoxID.Text & "'"
        Dim vetA As String = "Update [Zdravstveni karton] Set [Veterinarska ambulanta]='" & TextBoxVA.Text & "' where [ID zivotinja]='" & TextBoxID.Text & "'"
        Dim doc As String = "Update [Zdravstveni karton] Set Doktor='" & TextBoxDoktor.Text & "' where [ID zivotinja]='" & TextBoxID.Text & "'"
        'Dim detalji As String = "Update [Zdravstveni karton] Set Detalji='" & TextBoxDetalji.Text & "' where [ID zivotinja]='" & TextBoxID.Text & "'"
        Dim datU As String = "Update [Zdravstveni karton] Set [Datum uginuca]='" & DateTimePickerDU.Value.ToString & "' where [ID zivotinja]='" & TextBoxID.Text & "'"
        Dim razlog As String = "Update [Zdravstveni karton] Set [Razlog uginuca]='" & TextBoxRU.Text & "' where [ID zivotinja]='" & TextBoxID.Text & "'"


        If (Not String.IsNullOrEmpty(TextBoxVelicina.Text)) Then
            IzvrsiUpit(velicina)

        End If
        If (Not String.IsNullOrEmpty(TextBoxKilaza.Text)) Then
            IzvrsiUpit(kilaza)

        End If
        If (Not String.IsNullOrEmpty(TextBoxBoja.Text)) Then
            IzvrsiUpit(boja)

        End If
        If (Not String.IsNullOrEmpty(ComboBoxSteril.SelectedItem.ToString)) Then
            IzvrsiUpit(steril)

        End If
        If (Not String.IsNullOrEmpty(DateTimePickerSteril.Value.ToString)) Then
            IzvrsiUpit(datS)

        End If
        If (Not String.IsNullOrEmpty(TextBoxVA.Text)) Then
            IzvrsiUpit(vetA)

        End If
        If (Not String.IsNullOrEmpty(TextBoxDoktor.Text)) Then
            IzvrsiUpit(doc)

        End If
        'If (Not String.IsNullOrEmpty(TextBoxDetalji.Text)) Then
        '    IzvrsiUpit(detalji)

        'End If
        If (Not String.IsNullOrEmpty(DateTimePickerDU.Value.ToString)) Then
            IzvrsiUpit(datU)

        End If
        If (Not String.IsNullOrEmpty(TextBoxRU.Text)) Then
            IzvrsiUpit(razlog)

        End If
        MessageBox.Show("Uspjesno ste azurirali bazu podataka!")
    End Sub

    Private Sub ButtonUnesi_Click(sender As Object, e As EventArgs) Handles ButtonUnesi.Click
        Try

            Dim provjera As String = "select * from [Zdravstveni karton] where [ID zivotinja]='" & TextBoxID.Text & "'"
            Dim adapter As New SqlDataAdapter(provjera, connection)
            Dim tabela As New DataTable()
            adapter.Fill(tabela)

            If tabela.Rows.Count = 0 Then
                Dim unos As String = "INSERT INTO [Zdravstveni karton] ([ID zivotinja],[Velicina],[Kilaza (kg)],[Boja],[Sterilizovan/a],[Datum sterilizacije],[Veterinarska ambulanta],[Doktor],[Datum uginuca],[Razlog uginuca])
               VALUES
           ('" & TextBoxVelicina.Text & "','" & TextBoxKilaza.Text & "', '" & TextBoxBoja.Text & "','" & ComboBoxSteril.SelectedItem.ToString & "','" & DateTimePickerSteril.Value.ToString & "','" & TextBoxVA.Text & "','" & TextBoxDoktor.Text & "','" & DateTimePickerDU.Value.ToString & "','" & DateTimePickerDU.Value.ToString & "','" & TextBoxRU.Text & "')"

                IzvrsiUpit(unos)
                MessageBox.Show("Unijeli ste uspjesno u bazu!")

            Else
                MessageBox.Show("Unos onemogucen, korisnik je u bazi podataka!")
            End If

        Catch ex As Exception

            MessageBox.Show("Greska prilikom unosa! Provjerite polja.")
        End Try

    End Sub

    Private Sub ButtonIzbrisi_Click(sender As Object, e As EventArgs) Handles ButtonIzbrisi.Click
        If (DataGridView1.SelectedCells.Count > 0) Then
            Dim result As DialogResult = MessageBox.Show("Da li ste sigurni da zelite obrisati selektovano?", "Upozorenje!", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    Dim indeks As Integer
                    indeks = DataGridView1.CurrentRow.Index
                    Dim brisi As String = "DELETE FROM  [Zdravstveni karton] WHERE [ID zivotinja]='" & DataGridView1.Item(0, indeks).Value & "'"
                    IzvrsiUpit(brisi)
                    MessageBox.Show("Uspjesno ste izbrisali podatke sa id-em:" + DataGridView1.Item(0, indeks).Value.ToString)

                Catch ex As Exception

                End Try

            End If
        Else
            MessageBox.Show("Potrebno je selektovati polje prije brisanja!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (DataGridView1.SelectedCells.Count > 0 And DataGridView1.Columns.Count > 5) Then
            Dim result As DialogResult = MessageBox.Show("Da li ste sigurni da zelite obrisati selektovano?", "Upozorenje!", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    Dim indeks As Integer
                    indeks = DataGridView1.CurrentRow.Index
                    Dim brisi As String = "DELETE FROM  Terapija WHERE RB='" & DataGridView1.Item(10, indeks).Value & "'"
                    IzvrsiUpit(brisi)
                    MessageBox.Show("Uspjesno ste izbrisali podatke o terapiji!")

                Catch ex As Exception

                End Try

            End If
        Else
            MessageBox.Show("Potrebno je selektovati terapiju!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (TextBoxID.Text = "") Then
                MessageBox.Show("Potrebno je unijeti ID sticenika!")
            Else
                Dim unos As String = "INSERT INTO Terapija ([ID zivotinja],[Pocetak terapije],[Kraj terapije], Lijek) VALUES ('" & TextBoxID.Text & "','" & DateTimePickerPocetak.Value.ToString & "','" & DateTimePickerKraj.Value.ToString & "','" & TextBoxTerapija.Text & "')"
                IzvrsiUpit(unos)
                MessageBox.Show("Unijeli ste uspjesno u bazu!")
            End If


        Catch ex As Exception

            MessageBox.Show("Greska prilikom unosa! Provjerite polja.")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Index.Show()
        Index.Label3.Text = Me.Label15.Text
        Index.Label4.Text = Me.Label16.Text
        Me.Close()
    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        LogIn.TextBoxUsername.Text = ""
        LogIn.MaskedTextBoxPassword.Text = ""
        LogIn.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Try

            Dim naredba As String = "select*from [Zdravstveni karton]"
            Dim adapter As New SqlDataAdapter(naredba, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            DataGridView1.ClearSelection()
        Catch ex As Exception

            MessageBox.Show("Greska prilikom unosa! Provjerite polja.")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim EditForm As New EditForm
        EditForm.LabelUsername.Text = Me.Label15.Text
        EditForm.Show()
    End Sub
End Class