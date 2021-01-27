Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim W, X, Z As Single
        Const pi As Single = 3.1415
        X = Val(Radio.Text) / 2
        Z = Val(Altura.Text)
        W = pi * (X * X) * Z
        resultado.Text = " EL VOLUMEN DEL CILINDRO ES DE " & W & " METROS CUBICOS "
    End Sub
End Class
