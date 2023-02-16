Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        Dim x As Contacto
        x = New Contacto()
        x.FechaDenacimiento_ = DateTime.Parse("2003/01/01")
        x.Nombre_ = TextBox1.Text
        x.telefono_ = TextBox2.Text
        Label3.Text = x.ToString
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
