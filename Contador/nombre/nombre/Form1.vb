Public Class Form1

    Public nombre As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombre = TxtNombre.Text

        lblSaludo.Text = ("Hola ") & nombre & (", lindo nombre")
    End Sub
End Class
