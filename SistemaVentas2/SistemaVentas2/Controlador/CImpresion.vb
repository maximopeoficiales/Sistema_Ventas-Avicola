Public Class CImpresion
    Public Sub mostrar_datos(list As ListView, numeroBoletaFactura As String, direccion As String, documentoCliente As String, fecha As String, igv As String, nombreCliente As String, subtotal As String, telefono As String, total As String)

        'algoritmo para traer los datos de la otra tabla(listview)'
        For Index = 0 To RegistrarVentas.list.Items.Count - 1
            With list.Items.Add(RegistrarVentas.list.Items(Index).SubItems(0).Text)
                .SubItems.Add(RegistrarVentas.list.Items(Index).SubItems(1).Text)
                .SubItems.Add(RegistrarVentas.list.Items(Index).SubItems(2).Text)
                .SubItems.Add(RegistrarVentas.list.Items(Index).SubItems(3).Text)
                .SubItems.Add(RegistrarVentas.list.Items(Index).SubItems(4).Text)
            End With
        Next
        Dim rg = RegistrarVentas
        'datos de txt'
        numeroBoletaFactura = rg.label_n_factura.Text
        direccion = rg.txt_direccion.Text
        documentoCliente = rg.txt_dni.Text
        fecha = rg.txt_fecha.Text
        igv = rg.txt_igv.Text
        nombreCliente = rg.cb_clientes.Text
        subtotal = rg.txt_subtotal.Text
        telefono = rg.txt_telefono.Text
        total = rg.label_total.Text

    End Sub

    Public Sub imprimir(btcerrar As PictureBox, btimprimir As PictureBox, printForm As PowerPacks.Printing.PrintForm)
        btcerrar.Visible = False
        btimprimir.Visible = False
        'defino los margenes'
        printForm.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        'seleccione el tipo de papel'

        'PrintForm1.PrintAction = Printing.PaperKind.A4

        printForm.Print()

        btcerrar.Visible = True
        btimprimir.Visible = True
    End Sub
End Class
