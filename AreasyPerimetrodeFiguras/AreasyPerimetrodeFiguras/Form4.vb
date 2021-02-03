Public Class FrmRectangulo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim X As Double
        X = TextBox1.Text * TextBox2.Text
        LblResultadoA.Text = X
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Y As Double
        Y = (Val(TextBox1.Text) + Val(TextBox2.Text)) * 2
        LblResultadoP.Text = Y
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        FrmMenu.Show()
    End Sub
End Class