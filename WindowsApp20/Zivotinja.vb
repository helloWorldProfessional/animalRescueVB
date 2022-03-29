Imports System.Data.SqlClient

Public Class Sticenici

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

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            Dim insertQuery As String = "INSERT INTO Zivotinja (Ime,Vrsta,Pol,Rasa,Starost,[Dostupnost pri usvajanju],Komentar,[ID zaposleni],[Datum pristupanja bazi]) VALUES('" & TextBoxImeZivotinje.Text & "','" & TextBoxVrsta.Text & "','" & ComboBox1.SelectedItem.ToString & "','" & TextBoxRasa.Text & "','" & TextBoxStarost.Text & "','" & TextBoxDPU.Text & "','" & TextBoxKomentar.Text & "','" & Label4.Text & "','" & DateTimePicker1.Value.ToString & "')"
            ExecuteQuery(insertQuery)
            MessageBox.Show("Uspjesno ste unijeli podatke u bazu!")
        Catch ex As Exception
            MessageBox.Show("Greska prilikom unosa! Provjerite id polja!")
        End Try


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim ime As String = "Update Zivotinja Set Ime='" & TextBoxImeZivotinje.Text & "',[Datum azuriranja]='" & DateTimePicker2.Value.ToString & "' where [ID Zivotinja]='" & TextBoxIDzivotinje.Text & "'"
        Dim vrsta As String = "Update Zivotinja Set Vrsta='" & TextBoxVrsta.Text & "',[Datum azuriranja]='" & DateTimePicker2.Value.ToString & "' where [ID Zivotinja]='" & TextBoxIDzivotinje.Text & "'"
        Dim pol As String = "Update Zivotinja Set pol='" & ComboBox1.SelectedItem.ToString & "',[Datum azuriranja]='" & DateTimePicker2.Value.ToString & "' where [ID Zivotinja]='" & TextBoxIDzivotinje.Text & "'"
        Dim rasa As String = "Update Zivotinja Set Rasa='" & TextBoxRasa.Text & "',[Datum azuriranja]='" & DateTimePicker2.Value.ToString & "' where [ID Zivotinja]='" & TextBoxIDzivotinje.Text & "'"
        Dim starost As String = "Update Zivotinja Set Starost='" & TextBoxStarost.Text & "',[Datum azuriranja]='" & DateTimePicker2.Value.ToString & "' where [ID Zivotinja]='" & TextBoxIDzivotinje.Text & "'"
        Dim DPU As String = "Update Zivotinja Set [Dostupnost pri usvajanju]='" & TextBoxDPU.Text & "',[Datum azuriranja]='" & DateTimePicker2.Value.ToString & "' where [ID Zivotinja]='" & TextBoxIDzivotinje.Text & "'"
        Dim komentar As String = "Update Zivotinja Set Komentar='" & TextBoxKomentar.Text & "',[Datum azuriranja]='" & DateTimePicker2.Value.ToString & "' where [ID Zivotinja]='" & TextBoxIDzivotinje.Text & "'"
        'Dim IDzaposleni As String = "Update Zivotinja Set [ID zaposleni]='" & TextBoxIDzaposlenog.Text & "',[Datum azuriranja]='" & DateTimePicker2.Value.ToString & "' where [ID Zivotinja]='" & TextBoxIDzivotinje.Text & "'"
        Dim DPB As String = "Update Zivotinja Set [Datum pristupanja bazi]='" & DateTimePicker1.Value.ToString & "' where [ID Zivotinja]='" & TextBoxIDzivotinje.Text & "'"

        Dim result As DialogResult = MessageBox.Show("Da li ste sigurni da zelite azurirati sva popunjena polja?", "Upozorenje!", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                If (Not String.IsNullOrEmpty(TextBoxImeZivotinje.Text)) Then
                    ExecuteQuery(ime)

                End If
                If (Not String.IsNullOrEmpty(TextBoxVrsta.Text)) Then
                    ExecuteQuery(vrsta)
                End If
                If (Not String.IsNullOrEmpty(ComboBox1.SelectedItem.ToString)) Then
                    ExecuteQuery(pol)

                End If
                If (Not String.IsNullOrEmpty(TextBoxRasa.Text)) Then
                    ExecuteQuery(rasa)

                End If
                If (Not String.IsNullOrEmpty(TextBoxStarost.Text)) Then
                    ExecuteQuery(starost)

                End If
                If (Not String.IsNullOrEmpty(TextBoxDPU.Text)) Then
                    ExecuteQuery(DPU)

                End If
                If (Not String.IsNullOrEmpty(TextBoxKomentar.Text)) Then
                    ExecuteQuery(komentar)

                End If
                'If (Not String.IsNullOrEmpty(TextBoxIDzaposlenog.Text)) Then
                '    ExecuteQuery(IDzaposleni)

                'End If
                If (Not String.IsNullOrEmpty(DateTimePicker1.Value.ToString)) Then
                    ExecuteQuery(DPB)

                End If
                MessageBox.Show("Uspijesno ste azurirali nalog!")
            Catch ex As Exception
                MessageBox.Show("Greska prilikom unosa! Provjerite polja.")
            End Try

        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (DataGridViewPrikaz.SelectedCells.Count > 0) Then
            Dim result As DialogResult = MessageBox.Show("Da li ste sigurni da zelite obrisati selektovano?", "Upozorenje!", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    Dim indeks As Integer
                    indeks = DataGridViewPrikaz.CurrentRow.Index
                    Dim brisi As String = "DELETE FROM Zivotinja WHERE [ID Zivotinja]='" & DataGridViewPrikaz.Item(0, indeks).Value & "' "
                    ExecuteQuery(brisi)
                    MessageBox.Show("Uspjesno ste izbrisali podatke za sticenika sa id-em:" + DataGridViewPrikaz.Item(0, indeks).Value.ToString)
                    'Dim upd As String = "DELETE FROM Usvajac WHERE [ID zivotinje]='" & DataGridViewPrikaz.Item(0, indeks).Value & "' "
                    'IzvrsiUpit(upd)
                    'ExecuteQuery(upd)

                Catch ex As Exception

                End Try


            End If
        Else
            MessageBox.Show("Potrebno je selektovati polje prije brisanja!")
        End If

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        TextBoxIDzivotinje.Text = ""
        TextBoxVrsta.Text = ""
        ComboBox1.Text = ""
        TextBoxRasa.Text = ""
        TextBoxStarost.Text = ""
        DateTimePicker1.Text = ""
        TextBoxKomentar.Text = ""
        ' TextBoxIDzaposlenog.Text = ""
        TextBoxDPU.Text = ""
        If (TextBoxImeZivotinje.Text = "") Then
            MessageBox.Show("Za pretragu je potrebno popuniti polje IME!")

        Else
            Try
                Dim unos As String = "select*from Zivotinja where [Ime]='" & TextBoxImeZivotinje.Text & "' "
                Dim adapter As New SqlDataAdapter(unos, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridViewPrikaz.DataSource = table
                DataGridViewPrikaz.ClearSelection()
            Catch ex As Exception

            End Try
        End If


        'TextBoxIDzivotinje.Text = table.Rows(0)(0).ToString()
        'TextBoxImeZivotinje.Text = table.Rows(0)(1).ToString()
        'TextBoxVrsta.Text = table.Rows(0)(2).ToString()
        'ComboBox1.Text = table.Rows(0)(3).ToString()
        'TextBoxRasa.Text = table.Rows(0)(4).ToString()
        'TextBoxStarost.Text = table.Rows(0)(5).ToString()
        'DateTimePicker1.Text = table.Rows(0)(9)
        'TextBoxKomentar.Text = table.Rows(0)(7).ToString()
        'TextBoxIDzaposlenog.Text = table.Rows(0)(8).ToString()
        'TextBoxDPU.Text = table.Rows(0)(6).ToString()


    End Sub
    Private Sub DataGridViewPrikaz_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPrikaz.CellDoubleClick

        Dim indeks As Integer
        indeks = DataGridViewPrikaz.CurrentRow.Index
        DataGridViewPrikaz.ClearSelection()
        TextBoxIDzivotinje.Text = DataGridViewPrikaz.Item(0, indeks).Value.ToString
        TextBoxImeZivotinje.Text = DataGridViewPrikaz.Item(1, indeks).Value.ToString
        TextBoxVrsta.Text = DataGridViewPrikaz.Item(2, indeks).Value.ToString
        ComboBox1.Text = DataGridViewPrikaz.Item(3, indeks).Value.ToString
        TextBoxRasa.Text = DataGridViewPrikaz.Item(4, indeks).Value.ToString
        TextBoxStarost.Text = DataGridViewPrikaz.Item(5, indeks).Value.ToString
        TextBoxDPU.Text = DataGridViewPrikaz.Item(6, indeks).Value.ToString
        TextBoxKomentar.Text = DataGridViewPrikaz.Item(7, indeks).Value.ToString
        'TextBoxIDzaposlenog.Text = DataGridViewPrikaz.Item(8, indeks).Value.ToString
        DateTimePicker1.Text = DataGridViewPrikaz.Item(9, indeks).Value.ToString


    End Sub

    Private Sub btnPrikaz_Click(sender As Object, e As EventArgs) Handles btnPrikaz.Click

        Dim naredba As String = "SELECT*FROM ZIVOTINJA"
        Dim adapter As New SqlDataAdapter(naredba, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridViewPrikaz.DataSource = table
        DataGridViewPrikaz.ClearSelection()
    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        LogIn.TextBoxUsername.Text = ""
        LogIn.MaskedTextBoxPassword.Text = ""
        LogIn.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBoxDPU.Text = ""
        TextBoxIDzivotinje.Text = ""
        TextBoxImeZivotinje.Text = ""
        TextBoxKomentar.Text = ""
        TextBoxRasa.Text = ""
        TextBoxStarost.Text = ""
        TextBoxVrsta.Text = ""
        ComboBox1.SelectedIndex = -1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim EditForm As New EditForm
        EditForm.LabelUsername.Text = Me.Label3.Text
        EditForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Index.Show()
        Index.Label3.Text = Me.Label3.Text
        Index.Label4.Text = Me.Label4.Text
        Me.Close()
    End Sub
End Class

