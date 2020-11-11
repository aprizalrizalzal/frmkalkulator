Public Class frmkalkulator

    Private Sub BtnKali_Click(sender As Object, e As EventArgs) Handles BtnKali.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(TBAngkaPertama.Text)
        Angka2 = Val(TBAngkaKedua.Text)
        Hasil = Angka1 * Angka2
        TBHasil.Text = Hasil
    End Sub

    Private Sub BtnBagi_Click(sender As Object, e As EventArgs) Handles BtnBagi.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(TBAngkaPertama.Text)
        Angka2 = Val(TBAngkaKedua.Text)
        Hasil = Angka1 / Angka2
        TBHasil.Text = Hasil
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(TBAngkaPertama.Text)
        Angka2 = Val(TBAngkaKedua.Text)
        Hasil = Angka1 + Angka2
        TBHasil.Text = Hasil
    End Sub

    Private Sub BtnKurang_Click(sender As Object, e As EventArgs) Handles BtnKurang.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(TBAngkaPertama.Text)
        Angka2 = Val(TBAngkaKedua.Text)
        Hasil = Angka1 - Angka2
        TBHasil.Text = Hasil
    End Sub

End Class
