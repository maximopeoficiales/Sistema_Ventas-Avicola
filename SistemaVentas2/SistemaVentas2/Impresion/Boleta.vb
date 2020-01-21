Public Class Boleta
    Dim c As CImpresion
    Private Sub mostrar_datos()

        'algoritmo para traer los datos de la otra tabla(listview)'
        For Index = 0 To RegistrarVentas.list.Items.Count - 1
            With lista_boleta.Items.Add(RegistrarVentas.list.Items(Index).SubItems(0).Text)
                .SubItems.Add(RegistrarVentas.list.Items(Index).SubItems(1).Text)
                .SubItems.Add(RegistrarVentas.list.Items(Index).SubItems(2).Text)
                .SubItems.Add(RegistrarVentas.list.Items(Index).SubItems(3).Text)
                .SubItems.Add(RegistrarVentas.list.Items(Index).SubItems(4).Text)
            End With
        Next
        Dim rg = RegistrarVentas
        'datos de txt'
        label_numero_boleta.Text = rg.label_n_factura.Text
        txt_direccion.Text = rg.txt_direccion.Text
        txt_dni.Text = rg.txt_dni.Text
        txt_fecha.Text = rg.txt_fecha.Text
        txt_igv.Text = rg.txt_igv.Text
        txt_señor.Text = rg.cb_clientes.Text
        txt_subtotal.Text = rg.txt_subtotal.Text
        txt_telefono.Text = rg.txt_telefono.Text
        label_total.Text = rg.label_total.Text
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Hide()
    End Sub

    Private Sub Boleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_datos()
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        btn_cerrar.Visible = False
        btn_imprimir.Visible = False
        'defino los margenes'
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        'seleccione el tipo de papel'

        'PrintForm1.PrintAction = Printing.PaperKind.A4

        PrintForm1.Print()

        btn_cerrar.Visible = True
        btn_imprimir.Visible = True



    End Sub
End Class