Public Class FrmCirculo
    Private Sub BtnArea_Click(sender As Object, e As EventArgs) Handles BtnArea.Click
        Dim pi As Double = 3.1416
        Dim X As Double

        X = pi * (TextBox1.Text) * (TextBox1.Text)
        LblResultadoA.Text = X

    End Sub

    Private Sub BtnPerimetro_Click(sender As Object, e As EventArgs) Handles BtnPerimetro.Click
        Dim pi As Double = 3.1416
        Dim Y As Double

        Y = (2 * pi) * (TextBox1.Text)
        LblResultadoP.Text = Y
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        FrmMenu.Show()
    End Sub
End Class