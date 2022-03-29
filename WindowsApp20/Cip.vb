Imports System.Data.SqlClient
Public Class Cip
    Dim konekcija As New SqlConnection("Server=computer_name;Database=Udomljavanje;Integrated Security=True")
    Private Sub IzvrsiUpit(query As String)
        Dim komanda As New SqlCommand(query, konekcija)
        konekcija.Open()
        komanda.ExecuteNonQuery()
        konekcija.Close()
    End Sub
    Private Sub FindName(q As String)
        TextBoxImeSticenika.Text = ""
        Try
            Dim constr As String = "Server=computer_name;Database=Udomljavanje;Integrated Security=True"
            Using con As SqlConnection = New SqlConnection(constr)
                Using cmd As SqlCommand = New SqlCommand(q)
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    con.Open()
                    Using sdr As SqlDataReader = cmd.ExecuteReader()
                        sdr.Read()
                        TextBoxImeSticenika.Text = sdr("Ime").ToString()
                    End Using
                    con.Close()
                End Using
            End Using
        Catch ex As Exception

        End Try

    End Sub
    Private Sub FindVlasnik(q As String)
        TextBoxIme.Text = ""
        TextBoxPrezime.Text = ""
        Try
            Dim constr As String = "Server=computer_name;Database=Udomljavanje;Integrated Security=True"
            Using con As SqlConnection = New SqlConnection(constr)
                Using cmd As SqlCommand = New SqlCommand(q)
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    con.Open()
                    Using sdr As SqlDataReader = cmd.ExecuteReader()
                        sdr.Read()
                        TextBoxIme.Text = sdr("Ime usvajaca").ToString()
                        TextBoxPrezime.Text = sdr("Prezime usvajaca").ToString()
                    End Using
                    con.Close()
                End Using
            End Using
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnUnos_Click(sender As Object, e As EventArgs) Handles btnUnos.Click

        Try

            Dim provjera As String = "select [ID cip] from Cip where [ID zivotinje]='" & TextBoxIDzivotinje.Text & "'"
            Dim adapter As New SqlDataAdapter(provjera, konekcija)
            Dim tabela As New DataTable()
            adapter.Fill(tabela)

            If tabela.Rows.Count = 0 Then
                If (TextBoxKod.Text.Trim.Length > 0 Or TextBoxIDzivotinje.Text.Trim.Length > 0 Or TextBoxIDvlasnika.Text.Trim.Length > 0 Or TextBoxIDZK.Text.Trim.Length > 0) Then

                    Dim unos As String = "INSERT INTO Cip (Kod,[ID zivotinje],[ID Vlasnika],[ID zdravstvenog kartona],[Datum kreiranja],[Datum azuriranja], [ID zaposleni]) VALUES ('" & TextBoxKod.Text & "','" & TextBoxIDzivotinje.Text & "','" & TextBoxIDvlasnika.Text & "','" & TextBoxIDZK.Text & "','" & DateTimePickerKreiranja.Value.ToString & "','" & DateTimePickerAzuriranja.Value.ToString & "','" & Label9.Text & "')"
                    IzvrsiUpit(unos)
                    MessageBox.Show("Unijeli ste uspjesno u bazu!")
                Else
                    MessageBox.Show("Popunite sva polja prije unosa!")
                End If

            Else
                MessageBox.Show("Unos onemogucen, korisnik je u bazi podataka!")

            End If

        Catch ex As Exception

            MessageBox.Show("Greska prilikom unosa! Provjerite polja.")
        End Try



    End Sub

    Private Sub btnAzuriraj_Click(sender As Object, e As EventArgs) Handles btnAzuriraj.Click
        If TextBoxIDZK.Text = "" Then
            MessageBox.Show("Popunite polje ID sticenika")
        End If

        Dim DatumA As String = "Update Cip Set [Datum azuriranja]='" & DateTimePickerAzuriranja.Value.ToString & "' where [ID zivotinje]='" & TextBoxIDzivotinje.Text & "'"
        Dim DatumK As String = "Update Cip Set [Datum kreiranja]='" & DateTimePickerKreiranja.Value.ToString & "' where [ID zivotinje]='" & TextBoxIDzivotinje.Text & "'"
        Dim Kod As String = "Update Cip Set Kod='" & TextBoxKod.Text & "' where [ID zivotinje]='" & TextBoxIDzivotinje.Text & "'"

        If (Not String.IsNullOrEmpty(DateTimePickerAzuriranja.Value.ToString)) Then
            IzvrsiUpit(DatumA)

        End If
        If (Not String.IsNullOrEmpty(DateTimePickerKreiranja.Value.ToString)) Then
            IzvrsiUpit(datumk)

        End If
        If (Not String.IsNullOrEmpty(TextBoxKod.Text)) Then
            IzvrsiUpit(Kod)
        End If
    End Sub

    Private Sub btnPretraga_Click(sender As Object, e As EventArgs) Handles btnPretraga.Click
        TextBoxIDCipa.Text = ""
        TextBoxKod.Text = ""
        TextBoxImeSticenika.Text = ""
        TextBoxIDvlasnika.Text = ""
        TextBoxIDzivotinje.Text = ""
        TextBoxIDZK.Text = ""
        If (TextBoxIme.Text = "" Or TextBoxPrezime.Text = "") Then
            MessageBox.Show("Za pretragu je potrebno popuniti polja ime i prezime!")

        Else
            Dim unos As String = "select*from Usvajac where [Ime usvajaca]='" & TextBoxIme.Text & "' and [Prezime usvajaca]='" & TextBoxPrezime.Text & "' "
            Dim adapter As New SqlDataAdapter(unos, konekcija)
            Dim tabela As New DataTable()
            adapter.Fill(tabela)
            DataGridView1.DataSource = tabela
            DataGridView1.ClearSelection()

        End If
        '    TextBoxIDCipa.Text = ""
        '    TextBoxKod.Text = ""
        '    TextBoxImeSticenika.Text = ""
        '    TextBoxIDvlasnika.Text = ""
        '    TextBoxIDzivotinje.Text = ""
        '    TextBoxIDZK.Text = ""

        '    If (TextBoxIme.Text = "" Or TextBoxPrezime.Text = "") Then
        '        MessageBox.Show("Za pretragu je potrebno popuniti polja ime i prezime vlasnika!")

        '    Else
        '        Try
        '            Dim unos As String = "select [ID Usvajac],[ID zivotinje] from Usvajac where [Ime usvajaca]='" & TextBoxIme.Text & "' and [Prezime usvajaca]='" & TextBoxPrezime.Text & "'"
        '            Dim adapter As New SqlDataAdapter(unos, konekcija)
        '            Dim tabela As New DataTable()
        '            adapter.Fill(tabela)
        '            TextBoxIDvlasnika.Text = tabela.Rows(0)(0).ToString
        '            TextBoxIDzivotinje.Text = tabela.Rows(0)(1).ToString
        '            tabela.Clear()

        '            Dim unos2 As String = "select Ime from Zivotinja where [ID Zivotinja]='" & TextBoxIDzivotinje.Text & "'"
        '            Dim adapter2 As New SqlDataAdapter(unos2, konekcija)
        '            Dim tabela2 As New DataTable()
        '            adapter2.Fill(tabela2)
        '            TextBoxImeSticenika.Text = tabela2.Rows(0)(0)

        '            Dim unos3 As String = "select [ID kartona] from [Zdravstveni karton] where [ID Zivotinja]='" & TextBoxIDzivotinje.Text & "'"
        '            Dim adapter3 As New SqlDataAdapter(unos3, konekcija)
        '            Dim tabela3 As New DataTable()
        '            adapter3.Fill(tabela3)
        '            TextBoxIDZK.Text = tabela3.Rows(0)(0)

        '            Dim unos4 As String = "select [ID cip], Kod from Cip where [ID zivotinje]='" & TextBoxIDzivotinje.Text & "'"
        '            Dim adapter4 As New SqlDataAdapter(unos4, konekcija)
        '            Dim tabela4 As New DataTable()
        '            adapter4.Fill(tabela4)
        '            TextBoxIDCipa.Text = tabela4.Rows(0)(0).ToString
        '            TextBoxKod.Text = tabela4.Rows(0)(1).ToString
        '        Catch ex As Exception
        '            MessageBox.Show("Uneseni vlasnik se ne nalazi u bazi podataka ili sticenik nije cipovan!")

        '        End Try

        '    End If

    End Sub

    Private Sub btnIzbrisi_Click(sender As Object, e As EventArgs) Handles btnIzbrisi.Click
        If (DataGridView1.SelectedCells.Count > 0) Then
            Dim result As DialogResult = MessageBox.Show("Da li ste sigurni da zelite obrisati selektovano?", "Upozorenje!", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    Dim indeks As Integer
                    indeks = DataGridView1.CurrentRow.Index
                    Dim brisi As String = "DELETE FROM cIP where [ID cip]='" & DataGridView1.Item(0, indeks).Value & "' "
                    IzvrsiUpit(brisi)
                    MessageBox.Show("Uspjesno ste izbrisali podatke za cip sa id-em:" + DataGridView1.Item(0, indeks).Value.ToString)
                Catch ex As Exception

                End Try

            End If

        Else
            MessageBox.Show("Potrebno je selektovati polje prije brisanja!")
        End If

    End Sub

    Private Sub btnPrikaz_Click(sender As Object, e As EventArgs) Handles btnPrikaz.Click
        Dim naredba As String = "Select [ID cip],[Kod],[ID zivotinje],[ID Vlasnika],[ID zdravstvenog kartona] as [ID ZK],[Datum kreiranja],[Datum azuriranja],[ID zaposleni] as [ID kreatora] from Cip"
        Dim adapter As New SqlDataAdapter(naredba, konekcija)
        Dim tabela As New DataTable()
        adapter.Fill(tabela)
        DataGridView1.DataSource = tabela
        DataGridView1.ClearSelection()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        TextBoxIDCipa.Text = ""
        TextBoxKod.Text = ""
        TextBoxImeSticenika.Text = ""
        TextBoxIDvlasnika.Text = ""
        TextBoxIDzivotinje.Text = ""
        TextBoxIDZK.Text = ""
        Try

            'DataGridView1.ClearSelection()
            Dim indeks As Integer
            indeks = DataGridView1.CurrentRow.Index
            DataGridView1.ClearSelection()
            'TextBoxIDzivotinje.Text = DataGridView1.Item(5, indeks).Value.ToString
            If (DataGridView1.Item(0, indeks).Value.ToString < 4000) Then
                Dim ime As String = "select* from Usvajac where [ID Usvajac] ='" & DataGridView1.Item(3, indeks).Value.ToString & "' "
                Dim unos As String = "select* from Cip where [ID Vlasnika] ='" & DataGridView1.Item(3, indeks).Value.ToString & "' "
                Dim imeS As String = "select Ime from Zivotinja where [ID Zivotinja] ='" & DataGridView1.Item(2, indeks).Value.ToString & "' "
                FindName(imeS)
                FindVlasnik(ime)
                Dim adapter As New SqlDataAdapter(unos, konekcija)
                Dim tabela As New DataTable()
                adapter.Fill(tabela)
                TextBoxIDCipa.Text = tabela.Rows(0)(0).ToString() 'DataGridView1.Item(0, indeks).Value.ToString
                TextBoxKod.Text = tabela.Rows(0)(1).ToString() 'DataGridView1.Item(1, indeks).Value.ToString
                TextBoxIDvlasnika.Text = tabela.Rows(0)(3).ToString() 'DataGridView1.Item(3, indeks).Value.ToString
                TextBoxIDzivotinje.Text = tabela.Rows(0)(2).ToString()
                TextBoxIDZK.Text = tabela.Rows(0)(4).ToString() 'DataGridView1.Item(4, indeks).Value.ToString
                DateTimePickerKreiranja.Text = tabela.Rows(0)(5).ToString() 'DataGridView1.Item(5, indeks).Value
                DateTimePickerAzuriranja.Text = tabela.Rows(0)(6).ToString() 'DataGridView1.Item(6, indeks).Value.ToString
            Else
                Dim unos As String = "select* from Cip where [ID zivotinje] ='" & DataGridView1.Item(5, indeks).Value.ToString & "' "
                Dim ime As String = "select Ime from Zivotinja where [ID Zivotinja] ='" & DataGridView1.Item(5, indeks).Value.ToString & "' "
                FindName(ime)
                Dim adapter As New SqlDataAdapter(unos, konekcija)
                Dim tabela As New DataTable()
                adapter.Fill(tabela)
                TextBoxIDCipa.Text = tabela.Rows(0)(0).ToString() 'DataGridView1.Item(0, indeks).Value.ToString
                TextBoxKod.Text = tabela.Rows(0)(1).ToString() 'DataGridView1.Item(1, indeks).Value.ToString
                TextBoxIDvlasnika.Text = tabela.Rows(0)(3).ToString() 'DataGridView1.Item(3, indeks).Value.ToString
                TextBoxIDzivotinje.Text = DataGridView1.Item(5, indeks).Value.ToString
                TextBoxIDZK.Text = tabela.Rows(0)(4).ToString() 'DataGridView1.Item(4, indeks).Value.ToString
                DateTimePickerKreiranja.Text = tabela.Rows(0)(5).ToString() 'DataGridView1.Item(5, indeks).Value
                DateTimePickerAzuriranja.Text = tabela.Rows(0)(6).ToString() 'DataGridView1.Item(6, indeks).Value.ToString

            End If

        Catch ex As Exception
            MessageBox.Show("Sticenik nije cipovan! Potrebno je kreirati nalog.")
        End Try
        DataGridView1.ClearSelection()
        'Try
        '        Dim unos As String = "select [ID Usvajac],[ID zivotinje] from Usvajac where [Ime usvajaca]='" & TextBoxIme.Text & "' and [Prezime usvajaca]='" & TextBoxPrezime.Text & "'"
        '        Dim adapter As New SqlDataAdapter(unos, konekcija)
        '        Dim tabela As New DataTable()
        '        adapter.Fill(tabela)
        '        TextBoxIDvlasnika.Text = tabela.Rows(0)(0).ToString
        '        TextBoxIDzivotinje.Text = tabela.Rows(0)(1).ToString
        '        tabela.Clear()

        '        Dim unos2 As String = "select Ime from Zivotinja where [ID Zivotinja]='" & TextBoxIDzivotinje.Text & "'"
        '        Dim adapter2 As New SqlDataAdapter(unos2, konekcija)
        '        Dim tabela2 As New DataTable()
        '        adapter2.Fill(tabela2)
        '        TextBoxImeSticenika.Text = tabela2.Rows(0)(0)

        '        Dim unos3 As String = "select [ID kartona] from [Zdravstveni karton] where [ID Zivotinja]='" & TextBoxIDzivotinje.Text & "'"
        '        Dim adapter3 As New SqlDataAdapter(unos3, konekcija)
        '        Dim tabela3 As New DataTable()
        '        adapter3.Fill(tabela3)
        '        TextBoxIDZK.Text = tabela3.Rows(0)(0)

        '        Dim unos4 As String = "select [ID cip], Kod from Cip where [ID zivotinje]='" & TextBoxIDzivotinje.Text & "'"
        '        Dim adapter4 As New SqlDataAdapter(unos4, konekcija)
        '        Dim tabela4 As New DataTable()
        '        adapter4.Fill(tabela4)
        '        TextBoxIDCipa.Text = tabela4.Rows(0)(0).ToString
        '        TextBoxKod.Text = tabela4.Rows(0)(1).ToString
        '    Catch ex As Exception

        '    DataGridView1.ClearSelection()
        'End Try



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
        TextBoxIme.Text = ""
        TextBoxPrezime.Text = ""
        TextBoxIDCipa.Text = ""
        TextBoxKod.Text = ""
        TextBoxImeSticenika.Text = ""
        TextBoxIDvlasnika.Text = ""
        TextBoxIDzivotinje.Text = ""
        TextBoxIDZK.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Index.Show()
        Index.Label3.Text = Me.Label8.Text
        Index.Label4.Text = Me.Label9.Text
        Me.Close()
    End Sub
End Class



