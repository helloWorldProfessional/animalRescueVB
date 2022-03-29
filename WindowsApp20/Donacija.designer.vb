<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Donacija
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
        Dim lblIme As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Donacija))
        Me.btnUnos = New System.Windows.Forms.Button()
        Me.DataGridViewPrikaz = New System.Windows.Forms.DataGridView()
        Me.btnBrisanje = New System.Windows.Forms.Button()
        Me.lblPrezime = New System.Windows.Forms.Label()
        Me.lblVrijednost = New System.Windows.Forms.Label()
        Me.TextBoxIme = New System.Windows.Forms.TextBox()
        Me.TextBoxPrezime = New System.Windows.Forms.TextBox()
        Me.TextBoxVrijednost = New System.Windows.Forms.TextBox()
        Me.btnPretraga = New System.Windows.Forms.Button()
        Me.btnPrikaz = New System.Windows.Forms.Button()
        Me.LogOut = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        lblIme = New System.Windows.Forms.Label()
        CType(Me.DataGridViewPrikaz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIme
        '
        lblIme.AutoSize = True
        lblIme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblIme.Location = New System.Drawing.Point(29, 59)
        lblIme.Name = "lblIme"
        lblIme.Size = New System.Drawing.Size(36, 20)
        lblIme.TabIndex = 6
        lblIme.Text = "Ime"
        '
        'btnUnos
        '
        Me.btnUnos.BackColor = System.Drawing.Color.Gainsboro
        Me.btnUnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnos.Location = New System.Drawing.Point(374, 139)
        Me.btnUnos.Name = "btnUnos"
        Me.btnUnos.Size = New System.Drawing.Size(141, 44)
        Me.btnUnos.TabIndex = 0
        Me.btnUnos.Text = "Unesi"
        Me.btnUnos.UseVisualStyleBackColor = False
        '
        'DataGridViewPrikaz
        '
        Me.DataGridViewPrikaz.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPrikaz.Location = New System.Drawing.Point(55, 274)
        Me.DataGridViewPrikaz.Name = "DataGridViewPrikaz"
        Me.DataGridViewPrikaz.RowTemplate.Height = 24
        Me.DataGridViewPrikaz.Size = New System.Drawing.Size(737, 303)
        Me.DataGridViewPrikaz.TabIndex = 1
        '
        'btnBrisanje
        '
        Me.btnBrisanje.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBrisanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrisanje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrisanje.Location = New System.Drawing.Point(622, 584)
        Me.btnBrisanje.Name = "btnBrisanje"
        Me.btnBrisanje.Size = New System.Drawing.Size(134, 44)
        Me.btnBrisanje.TabIndex = 4
        Me.btnBrisanje.Text = "Izbrisi"
        Me.btnBrisanje.UseVisualStyleBackColor = False
        '
        'lblPrezime
        '
        Me.lblPrezime.AutoSize = True
        Me.lblPrezime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrezime.Location = New System.Drawing.Point(29, 107)
        Me.lblPrezime.Name = "lblPrezime"
        Me.lblPrezime.Size = New System.Drawing.Size(71, 20)
        Me.lblPrezime.TabIndex = 7
        Me.lblPrezime.Text = "Prezime"
        '
        'lblVrijednost
        '
        Me.lblVrijednost.AutoSize = True
        Me.lblVrijednost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVrijednost.Location = New System.Drawing.Point(26, 151)
        Me.lblVrijednost.Name = "lblVrijednost"
        Me.lblVrijednost.Size = New System.Drawing.Size(84, 20)
        Me.lblVrijednost.TabIndex = 8
        Me.lblVrijednost.Text = "Vrijednost"
        '
        'TextBoxIme
        '
        Me.TextBoxIme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIme.Location = New System.Drawing.Point(131, 56)
        Me.TextBoxIme.Name = "TextBoxIme"
        Me.TextBoxIme.Size = New System.Drawing.Size(227, 27)
        Me.TextBoxIme.TabIndex = 10
        '
        'TextBoxPrezime
        '
        Me.TextBoxPrezime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrezime.Location = New System.Drawing.Point(131, 104)
        Me.TextBoxPrezime.Name = "TextBoxPrezime"
        Me.TextBoxPrezime.Size = New System.Drawing.Size(227, 27)
        Me.TextBoxPrezime.TabIndex = 11
        '
        'TextBoxVrijednost
        '
        Me.TextBoxVrijednost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVrijednost.Location = New System.Drawing.Point(128, 149)
        Me.TextBoxVrijednost.Name = "TextBoxVrijednost"
        Me.TextBoxVrijednost.Size = New System.Drawing.Size(137, 27)
        Me.TextBoxVrijednost.TabIndex = 12
        '
        'btnPretraga
        '
        Me.btnPretraga.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPretraga.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPretraga.Location = New System.Drawing.Point(374, 72)
        Me.btnPretraga.Name = "btnPretraga"
        Me.btnPretraga.Size = New System.Drawing.Size(141, 44)
        Me.btnPretraga.TabIndex = 13
        Me.btnPretraga.Text = "Pretrazi"
        Me.btnPretraga.UseVisualStyleBackColor = False
        '
        'btnPrikaz
        '
        Me.btnPrikaz.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPrikaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrikaz.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrikaz.Location = New System.Drawing.Point(94, 583)
        Me.btnPrikaz.Name = "btnPrikaz"
        Me.btnPrikaz.Size = New System.Drawing.Size(142, 45)
        Me.btnPrikaz.TabIndex = 15
        Me.btnPrikaz.Text = "Prikazi"
        Me.btnPrikaz.UseVisualStyleBackColor = False
        '
        'LogOut
        '
        Me.LogOut.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut.Location = New System.Drawing.Point(720, 211)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(111, 35)
        Me.LogOut.TabIndex = 26
        Me.LogOut.Text = "Log Out"
        Me.LogOut.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(550, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 142)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profil"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(179, 100)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 29)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Edit "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(19, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 67)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(101, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 18)
        Me.Label8.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(102, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 18)
        Me.Label9.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(720, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 35)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Nazad"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Donacija
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 647)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LogOut)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPrikaz)
        Me.Controls.Add(Me.btnPretraga)
        Me.Controls.Add(Me.TextBoxVrijednost)
        Me.Controls.Add(Me.TextBoxPrezime)
        Me.Controls.Add(Me.TextBoxIme)
        Me.Controls.Add(Me.lblVrijednost)
        Me.Controls.Add(Me.lblPrezime)
        Me.Controls.Add(lblIme)
        Me.Controls.Add(Me.btnBrisanje)
        Me.Controls.Add(Me.DataGridViewPrikaz)
        Me.Controls.Add(Me.btnUnos)
        Me.Name = "Donacija"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donacija"
        CType(Me.DataGridViewPrikaz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUnos As Button
    Friend WithEvents DataGridViewPrikaz As DataGridView
    Friend WithEvents btnBrisanje As Button
    Friend WithEvents lblPrezime As Label
    Friend WithEvents lblVrijednost As Label
    Friend WithEvents TextBoxIme As TextBox
    Friend WithEvents TextBoxPrezime As TextBox
    Friend WithEvents TextBoxVrijednost As TextBox
    Friend WithEvents btnPretraga As Button
    Friend WithEvents btnPrikaz As Button
    Friend WithEvents LogOut As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
End Class
