Public Class Form1

    Public contador As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        contador = contador + 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Label1.Text = contador

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        contador = 0

        Label1.Text = 0
    End Sub
End Class
