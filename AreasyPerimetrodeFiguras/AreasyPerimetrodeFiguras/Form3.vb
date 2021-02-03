Public Class FrmTriangulo
    Private Sub BtnArea_Click(sender As Object, e As EventArgs) Handles BtnArea.Click
        Dim X As Double
        X = (TextBox2.Text * TextBox1.Text) / 2
        LblResultadoA.Text = X
    End Sub

    Private Sub BtnPerimetro_Click(sender As Object, e As EventArgs) Handles BtnPerimetro.Click
        Dim Y As Double
        Y = Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text)
        LblResultadoP.Text = Y
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Hide()
        FrmMenu.Show()
    End Sub
End Class