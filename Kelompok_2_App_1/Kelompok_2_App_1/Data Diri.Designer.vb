<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.Kelamin = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Matpel = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Kelas = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(313, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(313, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(403, 69)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(313, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 69)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kelas"
        '
        'Nama
        '
        Me.Nama.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(779, 161)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(400, 30)
        Me.Nama.TabIndex = 4
        Me.Nama.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Kelamin
        '
        Me.Kelamin.BackColor = System.Drawing.SystemColors.Menu
        Me.Kelamin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kelamin.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Kelamin.FormattingEnabled = True
        Me.Kelamin.Items.AddRange(New Object() {"Laki - Laki", "Perempuan"})
        Me.Kelamin.Location = New System.Drawing.Point(779, 411)
        Me.Kelamin.Name = "Kelamin"
        Me.Kelamin.Size = New System.Drawing.Size(400, 33)
        Me.Kelamin.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(313, 513)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(432, 69)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Mata Pelajaran"
        '
        'Matpel
        '
        Me.Matpel.BackColor = System.Drawing.SystemColors.Menu
        Me.Matpel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Matpel.FormattingEnabled = True
        Me.Matpel.Items.AddRange(New Object() {"TIK", "Biologi", "Matematika Peminatan", "Matematika Wajib", "Fisika", "Kimia", "Agama", "PKN", "Prakarya", "Sejarah Indo", "Sastra Inggris", "Bahasa Inggris", "Seni Budaya", "Bahasa Korea"})
        Me.Matpel.Location = New System.Drawing.Point(779, 533)
        Me.Matpel.Name = "Matpel"
        Me.Matpel.Size = New System.Drawing.Size(400, 33)
        Me.Matpel.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1016, 644)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 39)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Tampilkan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(1016, 699)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 39)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Kelas
        '
        Me.Kelas.BackColor = System.Drawing.SystemColors.Menu
        Me.Kelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kelas.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Kelas.FormattingEnabled = True
        Me.Kelas.Items.AddRange(New Object() {"XII MIA", "XII IIS"})
        Me.Kelas.Location = New System.Drawing.Point(779, 291)
        Me.Kelas.Name = "Kelas"
        Me.Kelas.Size = New System.Drawing.Size(400, 33)
        Me.Kelas.TabIndex = 11
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(1422, 977)
        Me.Controls.Add(Me.Kelas)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Matpel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Kelamin)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Nama As System.Windows.Forms.TextBox
    Friend WithEvents Kelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Matpel As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Kelas As System.Windows.Forms.ComboBox
End Class
