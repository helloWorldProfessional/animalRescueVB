<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usvajac
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usvajac))
        Me.btnUnos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIme = New System.Windows.Forms.Label()
        Me.lblPrezime = New System.Windows.Forms.Label()
        Me.lblAdresa = New System.Windows.Forms.Label()
        Me.lblIDZivotinje = New System.Windows.Forms.Label()
        Me.lblDU = New System.Windows.Forms.Label()
        Me.TextBoxIDusvajaca = New System.Windows.Forms.TextBox()
        Me.TextBoxIme = New System.Windows.Forms.TextBox()
        Me.TextBoxPrezime = New System.Windows.Forms.TextBox()
        Me.TextBoxAdresa = New System.Windows.Forms.TextBox()
        Me.TextBoxIDzivotinje = New System.Windows.Forms.TextBox()
        Me.btnAzuriranje = New System.Windows.Forms.Button()
        Me.btnPretraga = New System.Windows.Forms.Button()
        Me.btnIzbrisi = New System.Windows.Forms.Button()
        Me.btnPrikaz = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBoxTelefon = New System.Windows.Forms.TextBox()
        Me.lblTelefon = New System.Windows.Forms.Label()
        Me.DateTimePickerDU = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxDostupnost = New System.Windows.Forms.TextBox()
        Me.Dostupnost = New System.Windows.Forms.Label()
        Me.LogOut = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUnos
        '
        Me.btnUnos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnUnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnUnos.Location = New System.Drawing.Point(606, 105)
        Me.btnUnos.Name = "btnUnos"
        Me.btnUnos.Size = New System.Drawing.Size(141, 42)
        Me.btnUnos.TabIndex = 0
        Me.btnUnos.Text = "Unesi"
        Me.btnUnos.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(494, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID usvajaca"
        '
        'lblIme
        '
        Me.lblIme.AutoSize = True
        Me.lblIme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIme.Location = New System.Drawing.Point(17, 23)
        Me.lblIme.Name = "lblIme"
        Me.lblIme.Size = New System.Drawing.Size(36, 20)
        Me.lblIme.TabIndex = 3
        Me.lblIme.Text = "Ime"
        '
        'lblPrezime
        '
        Me.lblPrezime.AutoSize = True
        Me.lblPrezime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrezime.Location = New System.Drawing.Point(14, 63)
        Me.lblPrezime.Name = "lblPrezime"
        Me.lblPrezime.Size = New System.Drawing.Size(71, 20)
        Me.lblPrezime.TabIndex = 4
        Me.lblPrezime.Text = "Prezime"
        '
        'lblAdresa
        '
        Me.lblAdresa.AutoSize = True
        Me.lblAdresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdresa.Location = New System.Drawing.Point(15, 111)
        Me.lblAdresa.Name = "lblAdresa"
        Me.lblAdresa.Size = New System.Drawing.Size(67, 20)
        Me.lblAdresa.TabIndex = 6
        Me.lblAdresa.Text = "Adresa "
        '
        'lblIDZivotinje
        '
        Me.lblIDZivotinje.AutoSize = True
        Me.lblIDZivotinje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDZivotinje.Location = New System.Drawing.Point(344, 158)
        Me.lblIDZivotinje.Name = "lblIDZivotinje"
        Me.lblIDZivotinje.Size = New System.Drawing.Size(97, 20)
        Me.lblIDZivotinje.TabIndex = 7
        Me.lblIDZivotinje.Text = "ID sticenika"
        '
        'lblDU
        '
        Me.lblDU.AutoSize = True
        Me.lblDU.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDU.Location = New System.Drawing.Point(16, 202)
        Me.lblDU.Name = "lblDU"
        Me.lblDU.Size = New System.Drawing.Size(134, 20)
        Me.lblDU.TabIndex = 8
        Me.lblDU.Text = "Datum usvajanja"
        '
        'TextBoxIDusvajaca
        '
        Me.TextBoxIDusvajaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIDusvajaca.Location = New System.Drawing.Point(607, 60)
        Me.TextBoxIDusvajaca.Name = "TextBoxIDusvajaca"
        Me.TextBoxIDusvajaca.Size = New System.Drawing.Size(142, 27)
        Me.TextBoxIDusvajaca.TabIndex = 9
        '
        'TextBoxIme
        '
        Me.TextBoxIme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIme.Location = New System.Drawing.Point(104, 21)
        Me.TextBoxIme.Name = "TextBoxIme"
        Me.TextBoxIme.Size = New System.Drawing.Size(205, 27)
        Me.TextBoxIme.TabIndex = 10
        '
        'TextBoxPrezime
        '
        Me.TextBoxPrezime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrezime.Location = New System.Drawing.Point(104, 61)
        Me.TextBoxPrezime.Name = "TextBoxPrezime"
        Me.TextBoxPrezime.Size = New System.Drawing.Size(205, 27)
        Me.TextBoxPrezime.TabIndex = 11
        '
        'TextBoxAdresa
        '
        Me.TextBoxAdresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAdresa.Location = New System.Drawing.Point(104, 110)
        Me.TextBoxAdresa.Name = "TextBoxAdresa"
        Me.TextBoxAdresa.Size = New System.Drawing.Size(464, 27)
        Me.TextBoxAdresa.TabIndex = 13
        '
        'TextBoxIDzivotinje
        '
        Me.TextBoxIDzivotinje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIDzivotinje.Location = New System.Drawing.Point(458, 155)
        Me.TextBoxIDzivotinje.Name = "TextBoxIDzivotinje"
        Me.TextBoxIDzivotinje.Size = New System.Drawing.Size(110, 27)
        Me.TextBoxIDzivotinje.TabIndex = 14
        '
        'btnAzuriranje
        '
        Me.btnAzuriranje.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAzuriranje.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnAzuriranje.Location = New System.Drawing.Point(606, 152)
        Me.btnAzuriranje.Name = "btnAzuriranje"
        Me.btnAzuriranje.Size = New System.Drawing.Size(141, 42)
        Me.btnAzuriranje.TabIndex = 16
        Me.btnAzuriranje.Text = "Azuriraj"
        Me.btnAzuriranje.UseVisualStyleBackColor = False
        '
        'btnPretraga
        '
        Me.btnPretraga.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPretraga.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnPretraga.Location = New System.Drawing.Point(328, 31)
        Me.btnPretraga.Name = "btnPretraga"
        Me.btnPretraga.Size = New System.Drawing.Size(141, 49)
        Me.btnPretraga.TabIndex = 17
        Me.btnPretraga.Text = "Pretrazi"
        Me.btnPretraga.UseVisualStyleBackColor = False
        '
        'btnIzbrisi
        '
        Me.btnIzbrisi.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnIzbrisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnIzbrisi.Location = New System.Drawing.Point(863, 549)
        Me.btnIzbrisi.Name = "btnIzbrisi"
        Me.btnIzbrisi.Size = New System.Drawing.Size(141, 42)
        Me.btnIzbrisi.TabIndex = 18
        Me.btnIzbrisi.Text = "Izbrisi"
        Me.btnIzbrisi.UseVisualStyleBackColor = False
        '
        'btnPrikaz
        '
        Me.btnPrikaz.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPrikaz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnPrikaz.Location = New System.Drawing.Point(47, 550)
        Me.btnPrikaz.Name = "btnPrikaz"
        Me.btnPrikaz.Size = New System.Drawing.Size(141, 41)
        Me.btnPrikaz.TabIndex = 19
        Me.btnPrikaz.Text = "Prikazi"
        Me.btnPrikaz.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 253)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(996, 288)
        Me.DataGridView1.TabIndex = 20
        '
        'TextBoxTelefon
        '
        Me.TextBoxTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTelefon.Location = New System.Drawing.Point(138, 152)
        Me.TextBoxTelefon.Name = "TextBoxTelefon"
        Me.TextBoxTelefon.Size = New System.Drawing.Size(185, 27)
        Me.TextBoxTelefon.TabIndex = 22
        '
        'lblTelefon
        '
        Me.lblTelefon.AutoSize = True
        Me.lblTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefon.Location = New System.Drawing.Point(15, 155)
        Me.lblTelefon.Name = "lblTelefon"
        Me.lblTelefon.Size = New System.Drawing.Size(101, 20)
        Me.lblTelefon.TabIndex = 21
        Me.lblTelefon.Text = "BR. telefona"
        '
        'DateTimePickerDU
        '
        Me.DateTimePickerDU.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDU.Location = New System.Drawing.Point(165, 197)
        Me.DateTimePickerDU.Name = "DateTimePickerDU"
        Me.DateTimePickerDU.Size = New System.Drawing.Size(403, 27)
        Me.DateTimePickerDU.TabIndex = 23
        '
        'TextBoxDostupnost
        '
        Me.TextBoxDostupnost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDostupnost.Location = New System.Drawing.Point(608, 21)
        Me.TextBoxDostupnost.Name = "TextBoxDostupnost"
        Me.TextBoxDostupnost.Size = New System.Drawing.Size(141, 27)
        Me.TextBoxDostupnost.TabIndex = 25
        '
        'Dostupnost
        '
        Me.Dostupnost.AutoSize = True
        Me.Dostupnost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dostupnost.Location = New System.Drawing.Point(494, 28)
        Me.Dostupnost.Name = "Dostupnost"
        Me.Dostupnost.Size = New System.Drawing.Size(95, 20)
        Me.Dostupnost.TabIndex = 24
        Me.Dostupnost.Text = "Dostupnost"
        '
        'LogOut
        '
        Me.LogOut.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut.Location = New System.Drawing.Point(902, 207)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(111, 35)
        Me.LogOut.TabIndex = 32
        Me.LogOut.Text = "Log Out"
        Me.LogOut.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(772, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 142)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profil"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(143, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 29)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Edit "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button1.Location = New System.Drawing.Point(606, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 42)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Ocisti unos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(905, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 35)
        Me.Button3.TabIndex = 39
        Me.Button3.Text = "Nazad"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(109, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 18)
        Me.Label8.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(110, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 18)
        Me.Label9.TabIndex = 42
        '
        'Usvajac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1037, 612)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LogOut)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxDostupnost)
        Me.Controls.Add(Me.Dostupnost)
        Me.Controls.Add(Me.DateTimePickerDU)
        Me.Controls.Add(Me.TextBoxTelefon)
        Me.Controls.Add(Me.lblTelefon)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnPrikaz)
        Me.Controls.Add(Me.btnIzbrisi)
        Me.Controls.Add(Me.btnPretraga)
        Me.Controls.Add(Me.btnAzuriranje)
        Me.Controls.Add(Me.TextBoxIDzivotinje)
        Me.Controls.Add(Me.TextBoxAdresa)
        Me.Controls.Add(Me.TextBoxPrezime)
        Me.Controls.Add(Me.TextBoxIme)
        Me.Controls.Add(Me.TextBoxIDusvajaca)
        Me.Controls.Add(Me.lblDU)
        Me.Controls.Add(Me.lblIDZivotinje)
        Me.Controls.Add(Me.lblAdresa)
        Me.Controls.Add(Me.lblPrezime)
        Me.Controls.Add(Me.lblIme)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUnos)
        Me.Name = "Usvajac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usvajac"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblIme As Label
    Friend WithEvents lblPrezime As Label
    Friend WithEvents lblAdresa As Label
    Friend WithEvents lblIDZivotinje As Label
    Friend WithEvents lblDU As Label
    Friend WithEvents TextBoxIDusvajaca As TextBox
    Friend WithEvents TextBoxIme As TextBox
    Friend WithEvents TextBoxPrezime As TextBox
    Friend WithEvents TextBoxAdresa As TextBox
    Friend WithEvents TextBoxIDzivotinje As TextBox
    Friend WithEvents btnAzuriranje As Button
    Friend WithEvents btnPretraga As Button
    Friend WithEvents btnIzbrisi As Button
    Friend WithEvents btnPrikaz As Button
    Friend WithEvents btnUnos As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBoxTelefon As TextBox
    Friend WithEvents lblTelefon As Label
    Friend WithEvents DateTimePickerDU As DateTimePicker
    Friend WithEvents TextBoxDostupnost As TextBox
    Friend WithEvents Dostupnost As Label
    Friend WithEvents LogOut As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
