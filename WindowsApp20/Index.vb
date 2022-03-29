Public Class Index
    Public idTerapija As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Donacija.Click
        Dim Donacija As New Donacija
        Donacija.Label8.Text = Me.Label3.Text
        Donacija.Label9.Text = Me.Label4.Text
        Donacija.Show()
        Me.Close()
    End Sub

    Private Sub btnSticenici_Click(sender As Object, e As EventArgs) Handles btnSticenici.Click
        Dim Sticenici As New Sticenici
        Sticenici.Label3.Text = Me.Label3.Text
        Sticenici.Label4.Text = Me.Label4.Text
        Sticenici.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Cip As New Cip
        Cip.Label8.Text = Me.Label3.Text
        Cip.Label9.Text = Me.Label4.Text
        Cip.Show()
        Me.Close()
    End Sub

    Private Sub btnUsvajac_Click(sender As Object, e As EventArgs) Handles btnUsvajac.Click
        Dim Usvajac As New Usvajac
        Usvajac.Label8.Text = Me.Label3.Text
        Usvajac.Label9.Text = Me.Label4.Text
        Usvajac.Show()
        Me.Close()
    End Sub

    Private Sub btnZaposleni_Click(sender As Object, e As EventArgs) Handles btnZaposleni.Click
        Dim Zaposleni As New Zaposleni
        Zaposleni.Label8.Text = Me.Label3.Text
        Zaposleni.Label9.Text = Me.Label4.Text
        Zaposleni.Show()
        Me.Close()
    End Sub

    Private Sub btnZK_Click(sender As Object, e As EventArgs) Handles btnZK.Click
        Dim Zdravstveni_karton As New Zdravstveni_karton
        Zdravstveni_karton.Label15.Text = Me.Label3.Text
        Zdravstveni_karton.Label16.Text = Me.Label4.Text
        Zdravstveni_karton.Show()
        Me.Close()
    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        LogIn.TextBoxUsername.Text = ""
        LogIn.MaskedTextBoxPassword.Text = ""
        LogIn.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim EditForm As New EditForm
        EditForm.LabelUsername.Text = Me.Label3.Text
        EditForm.Show()

    End Sub
End Class
