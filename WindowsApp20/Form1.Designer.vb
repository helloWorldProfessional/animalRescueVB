<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxNoviUN = New System.Windows.Forms.TextBox()
        Me.TextBoxNoviPass = New System.Windows.Forms.TextBox()
        Me.TextBoxNoviPass2 = New System.Windows.Forms.TextBox()
        Me.Potvrdi = New System.Windows.Forms.Button()
        Me.Odustani = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Novi username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Novi password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Novi password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stari username"
        '
        'TextBoxNoviUN
        '
        Me.TextBoxNoviUN.Location = New System.Drawing.Point(209, 65)
        Me.TextBoxNoviUN.Name = "TextBoxNoviUN"
        Me.TextBoxNoviUN.Size = New System.Drawing.Size(177, 22)
        Me.TextBoxNoviUN.TabIndex = 6
        '
        'TextBoxNoviPass
        '
        Me.TextBoxNoviPass.Location = New System.Drawing.Point(209, 127)
        Me.TextBoxNoviPass.Name = "TextBoxNoviPass"
        Me.TextBoxNoviPass.Size = New System.Drawing.Size(177, 22)
        Me.TextBoxNoviPass.TabIndex = 7
        Me.TextBoxNoviPass.UseSystemPasswordChar = True
        '
        'TextBoxNoviPass2
        '
        Me.TextBoxNoviPass2.Location = New System.Drawing.Point(209, 167)
        Me.TextBoxNoviPass2.Name = "TextBoxNoviPass2"
        Me.TextBoxNoviPass2.Size = New System.Drawing.Size(177, 22)
        Me.TextBoxNoviPass2.TabIndex = 8
        Me.TextBoxNoviPass2.UseSystemPasswordChar = True
        '
        'Potvrdi
        '
        Me.Potvrdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Potvrdi.Location = New System.Drawing.Point(284, 238)
        Me.Potvrdi.Name = "Potvrdi"
        Me.Potvrdi.Size = New System.Drawing.Size(102, 37)
        Me.Potvrdi.TabIndex = 9
        Me.Potvrdi.Text = "Potvrdi"
        Me.Potvrdi.UseVisualStyleBackColor = True
        '
        'Odustani
        '
        Me.Odustani.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Odustani.Location = New System.Drawing.Point(66, 238)
        Me.Odustani.Name = "Odustani"
        Me.Odustani.Size = New System.Drawing.Size(96, 37)
        Me.Odustani.TabIndex = 10
        Me.Odustani.Text = "Odustani"
        Me.Odustani.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(177, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 20)
        Me.Label6.TabIndex = 11
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.Location = New System.Drawing.Point(212, 30)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(0, 20)
        Me.LabelUsername.TabIndex = 12
        '
        'EditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(433, 291)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Odustani)
        Me.Controls.Add(Me.Potvrdi)
        Me.Controls.Add(Me.TextBoxNoviPass2)
        Me.Controls.Add(Me.TextBoxNoviPass)
        Me.Controls.Add(Me.TextBoxNoviUN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxNoviUN As TextBox
    Friend WithEvents TextBoxNoviPass As TextBox
    Friend WithEvents TextBoxNoviPass2 As TextBox
    Friend WithEvents Potvrdi As Button
    Friend WithEvents Odustani As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelUsername As Label
End Class
