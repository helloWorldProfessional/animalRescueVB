<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Zdravstveni_karton
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Zdravstveni_karton))
        Me.TextBoxIme = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxVelicina = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxKilaza = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxBoja = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxVA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxDoktor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxRU = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePickerSteril = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerDU = New System.Windows.Forms.DateTimePicker()
        Me.ButtonPretraga = New System.Windows.Forms.Button()
        Me.ComboBoxSteril = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonAzuriraj = New System.Windows.Forms.Button()
        Me.ButtonUnesi = New System.Windows.Forms.Button()
        Me.ButtonIzbrisi = New System.Windows.Forms.Button()
        Me.ButtonListaj = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxTerapija = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateTimePickerKraj = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerPocetak = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LogOut = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxIme
        '
        Me.TextBoxIme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxIme.Location = New System.Drawing.Point(117, 32)
        Me.TextBoxIme.Name = "TextBoxIme"
        Me.TextBoxIme.Size = New System.Drawing.Size(161, 26)
        Me.TextBoxIme.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(53, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ime"
        '
        'TextBoxVelicina
        '
        Me.TextBoxVelicina.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxVelicina.Location = New System.Drawing.Point(133, 69)
        Me.TextBoxVelicina.Name = "TextBoxVelicina"
        Me.TextBoxVelicina.Size = New System.Drawing.Size(145, 26)
        Me.TextBoxVelicina.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(53, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Velicina"
        '
        'TextBoxKilaza
        '
        Me.TextBoxKilaza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxKilaza.Location = New System.Drawing.Point(410, 72)
        Me.TextBoxKilaza.Name = "TextBoxKilaza"
        Me.TextBoxKilaza.Size = New System.Drawing.Size(75, 26)
        Me.TextBoxKilaza.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(305, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Kilaza (kg)"
        '
        'TextBoxBoja
        '
        Me.TextBoxBoja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxBoja.Location = New System.Drawing.Point(350, 103)
        Me.TextBoxBoja.Name = "TextBoxBoja"
        Me.TextBoxBoja.Size = New System.Drawing.Size(163, 26)
        Me.TextBoxBoja.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(300, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Boja"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(51, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sterilizovan/a"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(51, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Datum sterilizacije"
        '
        'TextBoxVA
        '
        Me.TextBoxVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxVA.Location = New System.Drawing.Point(190, 242)
        Me.TextBoxVA.Name = "TextBoxVA"
        Me.TextBoxVA.Size = New System.Drawing.Size(292, 26)
        Me.TextBoxVA.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(54, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Vet.Ambulanta"
        '
        'TextBoxDoktor
        '
        Me.TextBoxDoktor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxDoktor.Location = New System.Drawing.Point(123, 276)
        Me.TextBoxDoktor.Name = "TextBoxDoktor"
        Me.TextBoxDoktor.Size = New System.Drawing.Size(243, 26)
        Me.TextBoxDoktor.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(55, 279)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Doktor"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(51, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Datum uginuca"
        '
        'TextBoxRU
        '
        Me.TextBoxRU.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxRU.Location = New System.Drawing.Point(198, 207)
        Me.TextBoxRU.Name = "TextBoxRU"
        Me.TextBoxRU.Size = New System.Drawing.Size(315, 26)
        Me.TextBoxRU.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(52, 208)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 20)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Razlog uginuca"
        '
        'DateTimePickerSteril
        '
        Me.DateTimePickerSteril.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DateTimePickerSteril.Location = New System.Drawing.Point(220, 136)
        Me.DateTimePickerSteril.Name = "DateTimePickerSteril"
        Me.DateTimePickerSteril.Size = New System.Drawing.Size(305, 26)
        Me.DateTimePickerSteril.TabIndex = 26
        Me.DateTimePickerSteril.Value = New Date(2021, 1, 27, 0, 0, 0, 0)
        '
        'DateTimePickerDU
        '
        Me.DateTimePickerDU.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DateTimePickerDU.Location = New System.Drawing.Point(198, 170)
        Me.DateTimePickerDU.Name = "DateTimePickerDU"
        Me.DateTimePickerDU.Size = New System.Drawing.Size(315, 26)
        Me.DateTimePickerDU.TabIndex = 27
        '
        'ButtonPretraga
        '
        Me.ButtonPretraga.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPretraga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonPretraga.Location = New System.Drawing.Point(304, 23)
        Me.ButtonPretraga.Name = "ButtonPretraga"
        Me.ButtonPretraga.Size = New System.Drawing.Size(137, 40)
        Me.ButtonPretraga.TabIndex = 28
        Me.ButtonPretraga.Text = "Pretraga"
        Me.ButtonPretraga.UseVisualStyleBackColor = False
        '
        'ComboBoxSteril
        '
        Me.ComboBoxSteril.FormattingEnabled = True
        Me.ComboBoxSteril.Items.AddRange(New Object() {"Da", "Ne"})
        Me.ComboBoxSteril.Location = New System.Drawing.Point(180, 103)
        Me.ComboBoxSteril.Name = "ComboBoxSteril"
        Me.ComboBoxSteril.Size = New System.Drawing.Size(86, 24)
        Me.ComboBoxSteril.TabIndex = 29
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(60, 372)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1220, 307)
        Me.DataGridView1.TabIndex = 31
        '
        'ButtonAzuriraj
        '
        Me.ButtonAzuriraj.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonAzuriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAzuriraj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonAzuriraj.Location = New System.Drawing.Point(281, 309)
        Me.ButtonAzuriraj.Name = "ButtonAzuriraj"
        Me.ButtonAzuriraj.Size = New System.Drawing.Size(147, 47)
        Me.ButtonAzuriraj.TabIndex = 32
        Me.ButtonAzuriraj.Text = "Azuriraj"
        Me.ButtonAzuriraj.UseVisualStyleBackColor = False
        '
        'ButtonUnesi
        '
        Me.ButtonUnesi.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonUnesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUnesi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonUnesi.Location = New System.Drawing.Point(117, 309)
        Me.ButtonUnesi.Name = "ButtonUnesi"
        Me.ButtonUnesi.Size = New System.Drawing.Size(147, 47)
        Me.ButtonUnesi.TabIndex = 33
        Me.ButtonUnesi.Text = "Unesi"
        Me.ButtonUnesi.UseVisualStyleBackColor = False
        '
        'ButtonIzbrisi
        '
        Me.ButtonIzbrisi.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonIzbrisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonIzbrisi.Location = New System.Drawing.Point(1123, 685)
        Me.ButtonIzbrisi.Name = "ButtonIzbrisi"
        Me.ButtonIzbrisi.Size = New System.Drawing.Size(137, 40)
        Me.ButtonIzbrisi.TabIndex = 34
        Me.ButtonIzbrisi.Text = "Izbrisi nalog"
        Me.ButtonIzbrisi.UseVisualStyleBackColor = False
        '
        'ButtonListaj
        '
        Me.ButtonListaj.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonListaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonListaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonListaj.Location = New System.Drawing.Point(616, 23)
        Me.ButtonListaj.Name = "ButtonListaj"
        Me.ButtonListaj.Size = New System.Drawing.Size(174, 40)
        Me.ButtonListaj.TabIndex = 35
        Me.ButtonListaj.Text = "Prikazi terapiju"
        Me.ButtonListaj.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(460, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 18)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "ID"
        '
        'TextBoxID
        '
        Me.TextBoxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TextBoxID.Location = New System.Drawing.Point(488, 31)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(100, 24)
        Me.TextBoxID.TabIndex = 37
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(798, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 40)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Unesi terapiju"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBoxTerapija
        '
        Me.TextBoxTerapija.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTerapija.Location = New System.Drawing.Point(664, 97)
        Me.TextBoxTerapija.Name = "TextBoxTerapija"
        Me.TextBoxTerapija.Size = New System.Drawing.Size(219, 27)
        Me.TextBoxTerapija.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(584, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 20)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Kraj"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(584, 140)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 20)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Pocetak"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(585, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 20)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Terapija"
        '
        'DateTimePickerKraj
        '
        Me.DateTimePickerKraj.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerKraj.Location = New System.Drawing.Point(664, 179)
        Me.DateTimePickerKraj.Name = "DateTimePickerKraj"
        Me.DateTimePickerKraj.Size = New System.Drawing.Size(319, 27)
        Me.DateTimePickerKraj.TabIndex = 40
        '
        'DateTimePickerPocetak
        '
        Me.DateTimePickerPocetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerPocetak.Location = New System.Drawing.Point(664, 137)
        Me.DateTimePickerPocetak.Name = "DateTimePickerPocetak"
        Me.DateTimePickerPocetak.Size = New System.Drawing.Size(319, 27)
        Me.DateTimePickerPocetak.TabIndex = 39
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(798, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(174, 42)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Izbrisi terapiju"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1178, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 38)
        Me.Button3.TabIndex = 48
        Me.Button3.Text = "Nazad"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'LogOut
        '
        Me.LogOut.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut.Location = New System.Drawing.Point(1179, 208)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(102, 38)
        Me.LogOut.TabIndex = 46
        Me.LogOut.Text = "Log Out"
        Me.LogOut.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1025, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 142)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profil"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(19, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(102, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 24)
        Me.Label15.TabIndex = 37
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(103, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 24)
        Me.Label16.TabIndex = 36
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(147, 102)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 29)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Edit "
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.Location = New System.Drawing.Point(498, 245)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(147, 47)
        Me.Button6.TabIndex = 50
        Me.Button6.Text = "Ocisti unos"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Zdravstveni_karton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1311, 741)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LogOut)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBoxTerapija)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DateTimePickerKraj)
        Me.Controls.Add(Me.DateTimePickerPocetak)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonListaj)
        Me.Controls.Add(Me.ButtonIzbrisi)
        Me.Controls.Add(Me.ButtonUnesi)
        Me.Controls.Add(Me.ButtonAzuriraj)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBoxSteril)
        Me.Controls.Add(Me.ButtonPretraga)
        Me.Controls.Add(Me.DateTimePickerDU)
        Me.Controls.Add(Me.DateTimePickerSteril)
        Me.Controls.Add(Me.TextBoxRU)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBoxDoktor)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxVA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxBoja)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxKilaza)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxVelicina)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxIme)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Zdravstveni_karton"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zdravstveni karton"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxIme As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxVelicina As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxKilaza As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxBoja As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxVA As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxDoktor As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxRU As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DateTimePickerSteril As DateTimePicker
    Friend WithEvents DateTimePickerDU As DateTimePicker
    Friend WithEvents ButtonPretraga As Button
    Friend WithEvents ComboBoxSteril As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonAzuriraj As Button
    Friend WithEvents ButtonUnesi As Button
    Friend WithEvents ButtonIzbrisi As Button
    Friend WithEvents ButtonListaj As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxTerapija As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DateTimePickerKraj As DateTimePicker
    Friend WithEvents DateTimePickerPocetak As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents LogOut As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
End Class
