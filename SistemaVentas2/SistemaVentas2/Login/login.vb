Public Class login
    Dim c As New CLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        c.validar_sesion()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub check_Click(sender As Object, e As EventArgs) Handles check.Click
        txt_contraseña.PasswordChar = ""
        check.Hide()
        uncheck.Show()
    End Sub

    Private Sub uncheck_Click(sender As Object, e As EventArgs) Handles uncheck.Click
        txt_contraseña.PasswordChar = "*"
        uncheck.Hide()
        check.Show()
    End Sub
End Class