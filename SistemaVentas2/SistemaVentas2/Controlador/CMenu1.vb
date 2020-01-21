Public Class CMenu1
    Public Sub abrirform(ByVal formhijo As Object)
        If Menu1.PanelContenedor.Controls.Count > 0 Then
            Menu1.PanelContenedor.Controls.RemoveAt(0)
            Dim fh As Form = TryCast(formhijo, Form)
            fh.TopLevel = False
            fh.FormBorderStyle = FormBorderStyle.None
            fh.Dock = DockStyle.Fill
            Menu1.PanelContenedor.Controls.Add(fh)
            Menu1.PanelContenedor.Tag = fh
            fh.Show()
        End If
    End Sub
    Public Sub SalirSession()
        Dim button = MessageBox.Show("ESTAS SEGURO DE SALIR?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If button = DialogResult.Yes Then
            Menu1.Close()
            login.Show()
            login.txt_usuario.Text = ""
            login.txt_contraseña.Text = ""
        End If
    End Sub

End Class
