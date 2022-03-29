<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cip))
        Me.lblIDCip = New System.Windows.Forms.Label()
        Me.lblKod = New System.Windows.Forms.Label()
        Me.lblIDzivotinja = New System.Windows.Forms.Label()
        Me.lblIDZK = New System.Windows.Forms.Label()
        Me.lblDatumKreiranja = New System.Windows.Forms.Label()
        Me.lblDatumAzuriranja = New System.Windows.Forms.Label()
        Me.TextBoxIDCipa = New System.Windows.Forms.TextBox()
        Me.TextBoxKod = New System.Windows.Forms.TextBox()
        Me.TextBoxIDzivotinje = New System.Windows.Forms.TextBox()
        Me.TextBoxIDZK = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnUnos = New System.Windows.Forms.Button()
        Me.btnAzuriraj = New System.Windows.Forms.Button()
        Me.btnPretraga = New System.Windows.Forms.Button()
        Me.btnIzbrisi = New System.Windows.Forms.Button()
        Me.lblIDvlasnika = New System.Windows.Forms.Label()
        Me.TextBoxIDvlasnika = New System.Windows.Forms.TextBox()
        Me.btnPrikaz = New System.Windows.Forms.Button()
        Me.TextBoxPrezime = New System.Windows.Forms.TextBox()
        Me.TextBoxIme = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ime = New System.Windows.Forms.Label()
        Me.TextBoxImeSticenika = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerKreiranja = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerAzuriranja = New System.Windows.Forms.DateTimePicker()
        Me.LogOut = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIDCip
        '
        Me.lblIDCip.AutoSize = True
        Me.lblIDCip.Location = New System.Drawing.Point(41, 119)
        Me.lblIDCip.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDCip.Name = "lblIDCip"
        Me.lblIDCip.Size = New System.Drawing.Size(62, 20)
        Me.lblIDCip.TabIndex = 0
        Me.lblIDCip.Text = "ID cipa"
        '
        'lblKod
        '
        Me.lblKod.AutoSize = True
        Me.lblKod.Location = New System.Drawing.Point(282, 119)
        Me.lblKod.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKod.Name = "lblKod"
        Me.lblKod.Size = New System.Drawing.Size(38, 20)
        Me.lblKod.TabIndex = 1
        Me.lblKod.Text = "Kod"
        '
        'lblIDzivotinja
        '
        Me.lblIDzivotinja.AutoSize = True
        Me.lblIDzivotinja.Location = New System.Drawing.Point(40, 159)
        Me.lblIDzivotinja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDzivotinja.Name = "lblIDzivotinja"
        Me.lblIDzivotinja.Size = New System.Drawing.Size(97, 20)
        Me.lblIDzivotinja.TabIndex = 2
        Me.lblIDzivotinja.Text = "ID sticenika"
        '
        'lblIDZK
        '
        Me.lblIDZK.AutoSize = True
        Me.lblIDZK.Location = New System.Drawing.Point(302, 201)
        Me.lblIDZK.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDZK.Name = "lblIDZK"
        Me.lblIDZK.Size = New System.Drawing.Size(51, 20)
        Me.lblIDZK.TabIndex = 4
        Me.lblIDZK.Text = "ID ZK"
        '
        'lblDatumKreiranja
        '
        Me.lblDatumKreiranja.AutoSize = True
        Me.lblDatumKreiranja.Location = New System.Drawing.Point(40, 242)
        Me.lblDatumKreiranja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatumKreiranja.Name = "lblDatumKreiranja"
        Me.lblDatumKreiranja.Size = New System.Drawing.Size(128, 20)
        Me.lblDatumKreiranja.TabIndex = 5
        Me.lblDatumKreiranja.Text = "Datum kreiranja"
        '
        'lblDatumAzuriranja
        '
        Me.lblDatumAzuriranja.AutoSize = True
        Me.lblDatumAzuriranja.Location = New System.Drawing.Point(40, 289)
        Me.lblDatumAzuriranja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatumAzuriranja.Name = "lblDatumAzuriranja"
        Me.lblDatumAzuriranja.Size = New System.Drawing.Size(138, 20)
        Me.lblDatumAzuriranja.TabIndex = 6
        Me.lblDatumAzuriranja.Text = "Datum azuriranja"
        '
        'TextBoxIDCipa
        '
        Me.TextBoxIDCipa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIDCipa.Location = New System.Drawing.Point(133, 112)
        Me.TextBoxIDCipa.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxIDCipa.Name = "TextBoxIDCipa"
        Me.TextBoxIDCipa.Size = New System.Drawing.Size(110, 27)
        Me.TextBoxIDCipa.TabIndex = 7
        '
        'TextBoxKod
        '
        Me.TextBoxKod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxKod.Location = New System.Drawing.Point(339, 112)
        Me.TextBoxKod.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxKod.Name = "TextBoxKod"
        Me.TextBoxKod.Size = New System.Drawing.Size(229, 27)
        Me.TextBoxKod.TabIndex = 8
        '
        'TextBoxIDzivotinje
        '
        Me.TextBoxIDzivotinje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIDzivotinje.Location = New System.Drawing.Point(161, 152)
        Me.TextBoxIDzivotinje.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxIDzivotinje.Name = "TextBoxIDzivotinje"
        Me.TextBoxIDzivotinje.Size = New System.Drawing.Size(123, 27)
        Me.TextBoxIDzivotinje.TabIndex = 9
        '
        'TextBoxIDZK
        '
        Me.TextBoxIDZK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIDZK.Location = New System.Drawing.Point(361, 194)
        Me.TextBoxIDZK.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxIDZK.Name = "TextBoxIDZK"
        Me.TextBoxIDZK.Size = New System.Drawing.Size(123, 27)
        Me.TextBoxIDZK.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 372)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(794, 281)
        Me.DataGridView1.TabIndex = 14
        '
        'btnUnos
        '
        Me.btnUnos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnUnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnos.Location = New System.Drawing.Point(431, 319)
        Me.btnUnos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUnos.Name = "btnUnos"
        Me.btnUnos.Size = New System.Drawing.Size(123, 47)
        Me.btnUnos.TabIndex = 15
        Me.btnUnos.Text = "Unos"
        Me.btnUnos.UseVisualStyleBackColor = False
        '
        'btnAzuriraj
        '
        Me.btnAzuriraj.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAzuriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAzuriraj.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAzuriraj.Location = New System.Drawing.Point(196, 319)
        Me.btnAzuriraj.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAzuriraj.Name = "btnAzuriraj"
        Me.btnAzuriraj.Size = New System.Drawing.Size(124, 47)
        Me.btnAzuriraj.TabIndex = 16
        Me.btnAzuriraj.Text = "Azuriranje"
        Me.btnAzuriraj.UseVisualStyleBackColor = False
        '
        'btnPretraga
        '
        Me.btnPretraga.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPretraga.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPretraga.Location = New System.Drawing.Point(431, 42)
        Me.btnPretraga.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPretraga.Name = "btnPretraga"
        Me.btnPretraga.Size = New System.Drawing.Size(137, 43)
        Me.btnPretraga.TabIndex = 17
        Me.btnPretraga.Text = "Pretraga"
        Me.btnPretraga.UseVisualStyleBackColor = False
        '
        'btnIzbrisi
        '
        Me.btnIzbrisi.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIzbrisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIzbrisi.Location = New System.Drawing.Point(635, 661)
        Me.btnIzbrisi.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIzbrisi.Name = "btnIzbrisi"
        Me.btnIzbrisi.Size = New System.Drawing.Size(171, 48)
        Me.btnIzbrisi.TabIndex = 18
        Me.btnIzbrisi.Text = "Izbrisi"
        Me.btnIzbrisi.UseVisualStyleBackColor = False
        '
        'lblIDvlasnika
        '
        Me.lblIDvlasnika.AutoSize = True
        Me.lblIDvlasnika.Location = New System.Drawing.Point(40, 194)
        Me.lblIDvlasnika.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDvlasnika.Name = "lblIDvlasnika"
        Me.lblIDvlasnika.Size = New System.Drawing.Size(91, 20)
        Me.lblIDvlasnika.TabIndex = 19
        Me.lblIDvlasnika.Text = "ID vlasnika"
        '
        'TextBoxIDvlasnika
        '
        Me.TextBoxIDvlasnika.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIDvlasnika.Location = New System.Drawing.Point(161, 194)
        Me.TextBoxIDvlasnika.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxIDvlasnika.Name = "TextBoxIDvlasnika"
        Me.TextBoxIDvlasnika.Size = New System.Drawing.Size(123, 27)
        Me.TextBoxIDvlasnika.TabIndex = 20
        '
        'btnPrikaz
        '
        Me.btnPrikaz.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPrikaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrikaz.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrikaz.Location = New System.Drawing.Point(92, 661)
        Me.btnPrikaz.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrikaz.Name = "btnPrikaz"
        Me.btnPrikaz.Size = New System.Drawing.Size(151, 48)
        Me.btnPrikaz.TabIndex = 21
        Me.btnPrikaz.Text = "Prikazi"
        Me.btnPrikaz.UseVisualStyleBackColor = False
        '
        'TextBoxPrezime
        '
        Me.TextBoxPrezime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrezime.Location = New System.Drawing.Point(196, 71)
        Me.TextBoxPrezime.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPrezime.Name = "TextBoxPrezime"
        Me.TextBoxPrezime.Size = New System.Drawing.Size(213, 27)
        Me.TextBoxPrezime.TabIndex = 25
        '
        'TextBoxIme
        '
        Me.TextBoxIme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIme.Location = New System.Drawing.Point(196, 30)
        Me.TextBoxIme.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxIme.Name = "TextBoxIme"
        Me.TextBoxIme.Size = New System.Drawing.Size(213, 27)
        Me.TextBoxIme.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Prezime vlasnika"
        '
        'Ime
        '
        Me.Ime.AutoSize = True
        Me.Ime.Location = New System.Drawing.Point(40, 33)
        Me.Ime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Ime.Name = "Ime"
        Me.Ime.Size = New System.Drawing.Size(101, 20)
        Me.Ime.TabIndex = 22
        Me.Ime.Text = "Ime vlasnika"
        '
        'TextBoxImeSticenika
        '
        Me.TextBoxImeSticenika.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxImeSticenika.Location = New System.Drawing.Point(417, 150)
        Me.TextBoxImeSticenika.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxImeSticenika.Name = "TextBoxImeSticenika"
        Me.TextBoxImeSticenika.Size = New System.Drawing.Size(151, 27)
        Me.TextBoxImeSticenika.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(302, 155)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Ime sticenika"
        '
        'DateTimePickerKreiranja
        '
        Me.DateTimePickerKreiranja.Location = New System.Drawing.Point(196, 237)
        Me.DateTimePickerKreiranja.Name = "DateTimePickerKreiranja"
        Me.DateTimePickerKreiranja.Size = New System.Drawing.Size(372, 27)
        Me.DateTimePickerKreiranja.TabIndex = 28
        '
        'DateTimePickerAzuriranja
        '
        Me.DateTimePickerAzuriranja.Location = New System.Drawing.Point(196, 284)
        Me.DateTimePickerAzuriranja.Name = "DateTimePickerAzuriranja"
        Me.DateTimePickerAzuriranja.Size = New System.Drawing.Size(372, 27)
        Me.DateTimePickerAzuriranja.TabIndex = 29
        '
        'LogOut
        '
        Me.LogOut.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut.Location = New System.Drawing.Point(728, 211)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(111, 35)
        Me.LogOut.TabIndex = 30
        Me.LogOut.Text = "Log Out"
        Me.LogOut.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(611, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 142)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profil"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(110, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 24)
        Me.Label8.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(111, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 24)
        Me.Label9.TabIndex = 35
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(126, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 29)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Edit "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(575, 254)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 48)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Ocisti unos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(728, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 35)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Nazad"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Cip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(870, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LogOut)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePickerAzuriranja)
        Me.Controls.Add(Me.DateTimePickerKreiranja)
        Me.Controls.Add(Me.TextBoxImeSticenika)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxPrezime)
        Me.Controls.Add(Me.TextBoxIme)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Ime)
        Me.Controls.Add(Me.btnPrikaz)
        Me.Controls.Add(Me.TextBoxIDvlasnika)
        Me.Controls.Add(Me.lblIDvlasnika)
        Me.Controls.Add(Me.btnIzbrisi)
        Me.Controls.Add(Me.btnPretraga)
        Me.Controls.Add(Me.btnAzuriraj)
        Me.Controls.Add(Me.btnUnos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBoxIDZK)
        Me.Controls.Add(Me.TextBoxIDzivotinje)
        Me.Controls.Add(Me.TextBoxKod)
        Me.Controls.Add(Me.TextBoxIDCipa)
        Me.Controls.Add(Me.lblDatumAzuriranja)
        Me.Controls.Add(Me.lblDatumKreiranja)
        Me.Controls.Add(Me.lblIDZK)
        Me.Controls.Add(Me.lblIDzivotinja)
        Me.Controls.Add(Me.lblKod)
        Me.Controls.Add(Me.lblIDCip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Cip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cip"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIDCip As Label
    Friend WithEvents lblKod As Label
    Friend WithEvents lblIDzivotinja As Label
    Friend WithEvents lblIDZK As Label
    Friend WithEvents lblDatumAzuriranja As Label
    Friend WithEvents TextBoxIDCipa As TextBox
    Friend WithEvents TextBoxKod As TextBox
    Friend WithEvents TextBoxIDzivotinje As TextBox
    Friend WithEvents TextBoxIDZK As TextBox
    Friend WithEvents lblDatumKreiranja As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnUnos As Button
    Friend WithEvents btnAzuriraj As Button
    Friend WithEvents btnPretraga As Button
    Friend WithEvents btnIzbrisi As Button
    Friend WithEvents lblIDvlasnika As Label
    Friend WithEvents TextBoxIDvlasnika As TextBox
    Friend WithEvents btnPrikaz As Button
    Friend WithEvents TextBoxPrezime As TextBox
    Friend WithEvents TextBoxIme As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Ime As Label
    Friend WithEvents TextBoxImeSticenika As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerKreiranja As DateTimePicker
    Friend WithEvents DateTimePickerAzuriranja As DateTimePicker
    Friend WithEvents LogOut As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
