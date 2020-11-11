<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkalkulator
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
        Me.BtnKali = New System.Windows.Forms.Button()
        Me.BtnBagi = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnKurang = New System.Windows.Forms.Button()
        Me.TBHasil = New System.Windows.Forms.TextBox()
        Me.TBAngkaKedua = New System.Windows.Forms.TextBox()
        Me.TBAngkaPertama = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Angka Pertama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Angka Kedua"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasil"
        '
        'BtnKali
        '
        Me.BtnKali.Location = New System.Drawing.Point(118, 113)
        Me.BtnKali.Name = "BtnKali"
        Me.BtnKali.Size = New System.Drawing.Size(38, 23)
        Me.BtnKali.TabIndex = 3
        Me.BtnKali.Text = "x"
        Me.BtnKali.UseVisualStyleBackColor = True
        '
        'BtnBagi
        '
        Me.BtnBagi.Location = New System.Drawing.Point(162, 113)
        Me.BtnBagi.Name = "BtnBagi"
        Me.BtnBagi.Size = New System.Drawing.Size(38, 23)
        Me.BtnBagi.TabIndex = 4
        Me.BtnBagi.Text = "/"
        Me.BtnBagi.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(206, 113)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(38, 23)
        Me.BtnTambah.TabIndex = 5
        Me.BtnTambah.Text = "+"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnKurang
        '
        Me.BtnKurang.Location = New System.Drawing.Point(250, 113)
        Me.BtnKurang.Name = "BtnKurang"
        Me.BtnKurang.Size = New System.Drawing.Size(38, 23)
        Me.BtnKurang.TabIndex = 6
        Me.BtnKurang.Text = "-"
        Me.BtnKurang.UseVisualStyleBackColor = True
        '
        'TBHasil
        '
        Me.TBHasil.Location = New System.Drawing.Point(118, 149)
        Me.TBHasil.Name = "TBHasil"
        Me.TBHasil.Size = New System.Drawing.Size(100, 20)
        Me.TBHasil.TabIndex = 7
        '
        'TBAngkaKedua
        '
        Me.TBAngkaKedua.Location = New System.Drawing.Point(118, 70)
        Me.TBAngkaKedua.Name = "TBAngkaKedua"
        Me.TBAngkaKedua.Size = New System.Drawing.Size(100, 20)
        Me.TBAngkaKedua.TabIndex = 8
        '
        'TBAngkaPertama
        '
        Me.TBAngkaPertama.Location = New System.Drawing.Point(118, 33)
        Me.TBAngkaPertama.Name = "TBAngkaPertama"
        Me.TBAngkaPertama.Size = New System.Drawing.Size(100, 20)
        Me.TBAngkaPertama.TabIndex = 9
        '
        'frmkalkulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 265)
        Me.Controls.Add(Me.TBAngkaPertama)
        Me.Controls.Add(Me.TBAngkaKedua)
        Me.Controls.Add(Me.TBHasil)
        Me.Controls.Add(Me.BtnKurang)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnBagi)
        Me.Controls.Add(Me.BtnKali)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmkalkulator"
        Me.Text = "frmkalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnKali As Button
    Friend WithEvents BtnBagi As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnKurang As Button
    Friend WithEvents TBHasil As TextBox
    Friend WithEvents TBAngkaKedua As TextBox
    Friend WithEvents TBAngkaPertama As TextBox
End Class
