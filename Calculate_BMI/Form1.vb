Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim hitung As Double

        hitung = Me.BB.Text / (Me.TB.Text * Me.TB.Text)
        Me.Hasil.Text = hitung
    End Sub
End Class
