<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sticenici
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sticenici))
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblIme = New System.Windows.Forms.Label()
        Me.lblVrsta = New System.Windows.Forms.Label()
        Me.lblPol = New System.Windows.Forms.Label()
        Me.lblRasa = New System.Windows.Forms.Label()
        Me.lblStarost = New System.Windows.Forms.Label()
        Me.lblDPU = New System.Windows.Forms.Label()
        Me.lblKomentar = New System.Windows.Forms.Label()
        Me.lblDPB = New System.Windows.Forms.Label()
        Me.TextBoxIDzivotinje = New System.Windows.Forms.TextBox()
        Me.TextBoxImeZivotinje = New System.Windows.Forms.TextBox()
        Me.TextBoxVrsta = New System.Windows.Forms.TextBox()
        Me.TextBoxRasa = New System.Windows.Forms.TextBox()
        Me.TextBoxStarost = New System.Windows.Forms.TextBox()
        Me.TextBoxDPU = New System.Windows.Forms.TextBox()
        Me.TextBoxKomentar = New System.Windows.Forms.TextBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnPrikaz = New System.Windows.Forms.Button()
        Me.DataGridViewPrikaz = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LogOut = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridViewPrikaz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(542, 167)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(128, 45)
        Me.btnInsert.TabIndex = 0
        Me.btnInsert.Text = "Unesi"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(542, 220)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(128, 47)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Azuriraj"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(933, 711)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(157, 49)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Izbrisi"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(662, 91)
        Me.lblID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(31, 23)
        Me.lblID.TabIndex = 3
        Me.lblID.Text = "ID "
        '
        'lblIme
        '
        Me.lblIme.AutoSize = True
        Me.lblIme.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIme.Location = New System.Drawing.Point(55, 36)
        Me.lblIme.Name = "lblIme"
        Me.lblIme.Size = New System.Drawing.Size(44, 23)
        Me.lblIme.TabIndex = 4
        Me.lblIme.Text = "Ime "
        '
        'lblVrsta
        '
        Me.lblVrsta.AutoSize = True
        Me.lblVrsta.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVrsta.Location = New System.Drawing.Point(55, 82)
        Me.lblVrsta.Name = "lblVrsta"
        Me.lblVrsta.Size = New System.Drawing.Size(51, 23)
        Me.lblVrsta.TabIndex = 5
        Me.lblVrsta.Text = "Vrsta"
        '
        'lblPol
        '
        Me.lblPol.AutoSize = True
        Me.lblPol.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPol.Location = New System.Drawing.Point(306, 87)
        Me.lblPol.Name = "lblPol"
        Me.lblPol.Size = New System.Drawing.Size(35, 23)
        Me.lblPol.TabIndex = 6
        Me.lblPol.Text = "Pol"
        '
        'lblRasa
        '
        Me.lblRasa.AutoSize = True
        Me.lblRasa.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRasa.Location = New System.Drawing.Point(56, 130)
        Me.lblRasa.Name = "lblRasa"
        Me.lblRasa.Size = New System.Drawing.Size(47, 23)
        Me.lblRasa.TabIndex = 7
        Me.lblRasa.Text = "Rasa"
        '
        'lblStarost
        '
        Me.lblStarost.AutoSize = True
        Me.lblStarost.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStarost.Location = New System.Drawing.Point(460, 86)
        Me.lblStarost.Name = "lblStarost"
        Me.lblStarost.Size = New System.Drawing.Size(67, 23)
        Me.lblStarost.TabIndex = 8
        Me.lblStarost.Text = "Starost"
        '
        'lblDPU
        '
        Me.lblDPU.AutoSize = True
        Me.lblDPU.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPU.Location = New System.Drawing.Point(451, 39)
        Me.lblDPU.Name = "lblDPU"
        Me.lblDPU.Size = New System.Drawing.Size(207, 23)
        Me.lblDPU.TabIndex = 9
        Me.lblDPU.Text = "Dostupnost pri usvajanju"
        '
        'lblKomentar
        '
        Me.lblKomentar.AutoSize = True
        Me.lblKomentar.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKomentar.Location = New System.Drawing.Point(338, 130)
        Me.lblKomentar.Name = "lblKomentar"
        Me.lblKomentar.Size = New System.Drawing.Size(88, 23)
        Me.lblKomentar.TabIndex = 10
        Me.lblKomentar.Text = "Komentar"
        '
        'lblDPB
        '
        Me.lblDPB.AutoSize = True
        Me.lblDPB.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPB.Location = New System.Drawing.Point(56, 180)
        Me.lblDPB.Name = "lblDPB"
        Me.lblDPB.Size = New System.Drawing.Size(161, 23)
        Me.lblDPB.TabIndex = 12
        Me.lblDPB.Text = "Datum pristupanja "
        '
        'TextBoxIDzivotinje
        '
        Me.TextBoxIDzivotinje.Location = New System.Drawing.Point(714, 86)
        Me.TextBoxIDzivotinje.Name = "TextBoxIDzivotinje"
        Me.TextBoxIDzivotinje.Size = New System.Drawing.Size(100, 28)
        Me.TextBoxIDzivotinje.TabIndex = 13
        '
        'TextBoxImeZivotinje
        '
        Me.TextBoxImeZivotinje.Location = New System.Drawing.Point(121, 34)
        Me.TextBoxImeZivotinje.Name = "TextBoxImeZivotinje"
        Me.TextBoxImeZivotinje.Size = New System.Drawing.Size(168, 28)
        Me.TextBoxImeZivotinje.TabIndex = 14
        '
        'TextBoxVrsta
        '
        Me.TextBoxVrsta.Location = New System.Drawing.Point(121, 82)
        Me.TextBoxVrsta.Name = "TextBoxVrsta"
        Me.TextBoxVrsta.Size = New System.Drawing.Size(168, 28)
        Me.TextBoxVrsta.TabIndex = 15
        '
        'TextBoxRasa
        '
        Me.TextBoxRasa.Location = New System.Drawing.Point(121, 130)
        Me.TextBoxRasa.Name = "TextBoxRasa"
        Me.TextBoxRasa.Size = New System.Drawing.Size(193, 28)
        Me.TextBoxRasa.TabIndex = 17
        '
        'TextBoxStarost
        '
        Me.TextBoxStarost.Location = New System.Drawing.Point(533, 85)
        Me.TextBoxStarost.Name = "TextBoxStarost"
        Me.TextBoxStarost.Size = New System.Drawing.Size(92, 28)
        Me.TextBoxStarost.TabIndex = 18
        '
        'TextBoxDPU
        '
        Me.TextBoxDPU.Location = New System.Drawing.Point(668, 36)
        Me.TextBoxDPU.Name = "TextBoxDPU"
        Me.TextBoxDPU.Size = New System.Drawing.Size(146, 28)
        Me.TextBoxDPU.TabIndex = 19
        '
        'TextBoxKomentar
        '
        Me.TextBoxKomentar.Location = New System.Drawing.Point(464, 128)
        Me.TextBoxKomentar.Name = "TextBoxKomentar"
        Me.TextBoxKomentar.Size = New System.Drawing.Size(350, 28)
        Me.TextBoxKomentar.TabIndex = 20
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSelect.Location = New System.Drawing.Point(304, 25)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(127, 46)
        Me.btnSelect.TabIndex = 23
        Me.btnSelect.Text = "Pretraga "
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'btnPrikaz
        '
        Me.btnPrikaz.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPrikaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrikaz.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrikaz.Location = New System.Drawing.Point(73, 711)
        Me.btnPrikaz.Name = "btnPrikaz"
        Me.btnPrikaz.Size = New System.Drawing.Size(164, 49)
        Me.btnPrikaz.TabIndex = 24
        Me.btnPrikaz.Text = "Prikazi "
        Me.btnPrikaz.UseVisualStyleBackColor = False
        '
        'DataGridViewPrikaz
        '
        Me.DataGridViewPrikaz.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPrikaz.Location = New System.Drawing.Point(45, 285)
        Me.DataGridViewPrikaz.Name = "DataGridViewPrikaz"
        Me.DataGridViewPrikaz.RowTemplate.Height = 24
        Me.DataGridViewPrikaz.Size = New System.Drawing.Size(1065, 420)
        Me.DataGridViewPrikaz.TabIndex = 27
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"M", "Z"})
        Me.ComboBox1.Location = New System.Drawing.Point(360, 83)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(71, 29)
        Me.ComboBox1.TabIndex = 29
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(231, 175)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(272, 28)
        Me.DateTimePicker1.TabIndex = 30
        '
        'LogOut
        '
        Me.LogOut.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut.Location = New System.Drawing.Point(1008, 213)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(102, 38)
        Me.LogOut.TabIndex = 31
        Me.LogOut.Text = "Log Out"
        Me.LogOut.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(855, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 142)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(102, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 24)
        Me.Label3.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(103, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 24)
        Me.Label4.TabIndex = 36
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(147, 102)
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
        Me.Button1.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(684, 193)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 51)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Ocisti unos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(231, 226)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(272, 28)
        Me.DateTimePicker2.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(56, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 23)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Datum azuriranja "
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
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1008, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 38)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "Nazad"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Sticenici
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1140, 777)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LogOut)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridViewPrikaz)
        Me.Controls.Add(Me.btnPrikaz)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.TextBoxKomentar)
        Me.Controls.Add(Me.TextBoxDPU)
        Me.Controls.Add(Me.TextBoxStarost)
        Me.Controls.Add(Me.TextBoxRasa)
        Me.Controls.Add(Me.TextBoxVrsta)
        Me.Controls.Add(Me.TextBoxImeZivotinje)
        Me.Controls.Add(Me.TextBoxIDzivotinje)
        Me.Controls.Add(Me.lblDPB)
        Me.Controls.Add(Me.lblKomentar)
        Me.Controls.Add(Me.lblDPU)
        Me.Controls.Add(Me.lblStarost)
        Me.Controls.Add(Me.lblRasa)
        Me.Controls.Add(Me.lblPol)
        Me.Controls.Add(Me.lblVrsta)
        Me.Controls.Add(Me.lblIme)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Sticenici"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sticenici"
        CType(Me.DataGridViewPrikaz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInsert As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblID As Label
    Friend WithEvents lblIme As Label
    Friend WithEvents lblVrsta As Label
    Friend WithEvents lblPol As Label
    Friend WithEvents lblRasa As Label
    Friend WithEvents lblStarost As Label
    Friend WithEvents lblDPU As Label
    Friend WithEvents lblKomentar As Label
    Friend WithEvents lblDPB As Label
    Friend WithEvents TextBoxIDzivotinje As TextBox
    Friend WithEvents TextBoxImeZivotinje As TextBox
    Friend WithEvents TextBoxVrsta As TextBox
    Friend WithEvents TextBoxRasa As TextBox
    Friend WithEvents TextBoxStarost As TextBox
    Friend WithEvents TextBoxDPU As TextBox
    Friend WithEvents TextBoxKomentar As TextBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnPrikaz As Button
    Friend WithEvents DataGridViewPrikaz As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LogOut As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
End Class
