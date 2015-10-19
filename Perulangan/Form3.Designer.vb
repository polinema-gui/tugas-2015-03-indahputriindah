<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Matrik1Text = New System.Windows.Forms.TextBox()
        Me.Matrik2Text = New System.Windows.Forms.TextBox()
        Me.hasilText = New System.Windows.Forms.TextBox()
        Me.hitungButton = New System.Windows.Forms.Button()
        Me.ComboOperasi = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matrik 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Matrik 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Operasi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasil"
        '
        'Matrik1Text
        '
        Me.Matrik1Text.Location = New System.Drawing.Point(90, 12)
        Me.Matrik1Text.Multiline = True
        Me.Matrik1Text.Name = "Matrik1Text"
        Me.Matrik1Text.Size = New System.Drawing.Size(324, 93)
        Me.Matrik1Text.TabIndex = 4
        '
        'Matrik2Text
        '
        Me.Matrik2Text.Location = New System.Drawing.Point(90, 138)
        Me.Matrik2Text.Multiline = True
        Me.Matrik2Text.Name = "Matrik2Text"
        Me.Matrik2Text.Size = New System.Drawing.Size(324, 72)
        Me.Matrik2Text.TabIndex = 6
        '
        'hasilText
        '
        Me.hasilText.Location = New System.Drawing.Point(90, 216)
        Me.hasilText.Multiline = True
        Me.hasilText.Name = "hasilText"
        Me.hasilText.Size = New System.Drawing.Size(324, 72)
        Me.hasilText.TabIndex = 7
        '
        'hitungButton
        '
        Me.hitungButton.Location = New System.Drawing.Point(339, 351)
        Me.hitungButton.Name = "hitungButton"
        Me.hitungButton.Size = New System.Drawing.Size(75, 23)
        Me.hitungButton.TabIndex = 8
        Me.hitungButton.Text = "Hitung"
        Me.hitungButton.UseVisualStyleBackColor = True
        '
        'ComboOperasi
        '
        Me.ComboOperasi.FormattingEnabled = True
        Me.ComboOperasi.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.ComboOperasi.Location = New System.Drawing.Point(90, 111)
        Me.ComboOperasi.Name = "ComboOperasi"
        Me.ComboOperasi.Size = New System.Drawing.Size(324, 21)
        Me.ComboOperasi.TabIndex = 9
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.ComboOperasi)
        Me.Controls.Add(Me.hitungButton)
        Me.Controls.Add(Me.hasilText)
        Me.Controls.Add(Me.Matrik2Text)
        Me.Controls.Add(Me.Matrik1Text)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Matrik1Text As System.Windows.Forms.TextBox
    Friend WithEvents Matrik2Text As System.Windows.Forms.TextBox
    Friend WithEvents hasilText As System.Windows.Forms.TextBox
    Friend WithEvents hitungButton As System.Windows.Forms.Button
    Friend WithEvents ComboOperasi As System.Windows.Forms.ComboBox
End Class
