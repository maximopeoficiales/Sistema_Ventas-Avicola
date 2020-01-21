<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrarVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_limpiar_compras = New System.Windows.Forms.Button()
        Me.list = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cb_clientes = New System.Windows.Forms.ComboBox()
        Me.btn_eliminar_compras = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.label_total = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_igv = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.imagen_producto = New System.Windows.Forms.PictureBox()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.cb_productos = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.label_n_factura = New System.Windows.Forms.Label()
        Me.cb_tipo_documento = New System.Windows.Forms.ComboBox()
        Me.label_tdocumento = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.imagen_producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.stroheim_montasio_ombre_haze_5405502_luxury_decor_fabric_pl_118816_e32
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btn_limpiar_compras)
        Me.Panel1.Controls.Add(Me.list)
        Me.Panel1.Controls.Add(Me.cb_clientes)
        Me.Panel1.Controls.Add(Me.btn_eliminar_compras)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txt_igv)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.txt_subtotal)
        Me.Panel1.Controls.Add(Me.label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btn_registrar)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.btn_imprimir)
        Me.Panel1.Controls.Add(Me.btn_agregar)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.txt_direccion)
        Me.Panel1.Controls.Add(Me.txt_telefono)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_dni)
        Me.Panel1.Controls.Add(Me.txt_fecha)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1610, 1080)
        Me.Panel1.TabIndex = 0
        '
        'btn_limpiar_compras
        '
        Me.btn_limpiar_compras.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_limpiar_compras.BackColor = System.Drawing.Color.Purple
        Me.btn_limpiar_compras.FlatAppearance.BorderSize = 0
        Me.btn_limpiar_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpiar_compras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar_compras.ForeColor = System.Drawing.Color.White
        Me.btn_limpiar_compras.Image = Global.SistemaVentas2.My.Resources.Resources.refrescar
        Me.btn_limpiar_compras.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_limpiar_compras.Location = New System.Drawing.Point(335, 311)
        Me.btn_limpiar_compras.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_limpiar_compras.Name = "btn_limpiar_compras"
        Me.btn_limpiar_compras.Size = New System.Drawing.Size(113, 39)
        Me.btn_limpiar_compras.TabIndex = 47
        Me.btn_limpiar_compras.Text = "Limpiar"
        Me.btn_limpiar_compras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_compras.UseVisualStyleBackColor = False
        '
        'list
        '
        Me.list.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.list.FullRowSelect = True
        Me.list.GridLines = True
        Me.list.HideSelection = False
        Me.list.Location = New System.Drawing.Point(335, 367)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(496, 265)
        Me.list.TabIndex = 46
        Me.list.UseCompatibleStateImageBehavior = False
        Me.list.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cod_Producto"
        Me.ColumnHeader1.Width = 70
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Producto"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 70
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cantidad"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Precio por Kg"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Precio_Venta"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 80
        '
        'cb_clientes
        '
        Me.cb_clientes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cb_clientes.FormattingEnabled = True
        Me.cb_clientes.Items.AddRange(New Object() {"FACTURA", "BOLETA"})
        Me.cb_clientes.Location = New System.Drawing.Point(339, 153)
        Me.cb_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_clientes.Name = "cb_clientes"
        Me.cb_clientes.Size = New System.Drawing.Size(492, 24)
        Me.cb_clientes.TabIndex = 3
        '
        'btn_eliminar_compras
        '
        Me.btn_eliminar_compras.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_eliminar_compras.BackColor = System.Drawing.Color.Purple
        Me.btn_eliminar_compras.FlatAppearance.BorderSize = 0
        Me.btn_eliminar_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar_compras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_compras.ForeColor = System.Drawing.Color.White
        Me.btn_eliminar_compras.Image = Global.SistemaVentas2.My.Resources.Resources.remove16
        Me.btn_eliminar_compras.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_eliminar_compras.Location = New System.Drawing.Point(339, 656)
        Me.btn_eliminar_compras.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_eliminar_compras.Name = "btn_eliminar_compras"
        Me.btn_eliminar_compras.Size = New System.Drawing.Size(113, 39)
        Me.btn_eliminar_compras.TabIndex = 45
        Me.btn_eliminar_compras.Text = "Quitar"
        Me.btn_eliminar_compras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar_compras.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.label_total)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(920, 592)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(312, 75)
        Me.Panel2.TabIndex = 43
        '
        'label_total
        '
        Me.label_total.AutoSize = True
        Me.label_total.Font = New System.Drawing.Font("Microsoft PhagsPa", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_total.ForeColor = System.Drawing.Color.Black
        Me.label_total.Location = New System.Drawing.Point(179, 16)
        Me.label_total.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_total.Name = "label_total"
        Me.label_total.Size = New System.Drawing.Size(44, 50)
        Me.label_total.TabIndex = 0
        Me.label_total.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft PhagsPa", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(4, 21)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 43)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "TOTAL $"
        '
        'txt_igv
        '
        Me.txt_igv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_igv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_igv.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_igv.ForeColor = System.Drawing.Color.Black
        Me.txt_igv.Location = New System.Drawing.Point(1060, 483)
        Me.txt_igv.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_igv.Name = "txt_igv"
        Me.txt_igv.Size = New System.Drawing.Size(133, 15)
        Me.txt_igv.TabIndex = 42
        Me.txt_igv.Text = "18"
        Me.txt_igv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox2.BackColor = System.Drawing.Color.LightGray
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(888, 460)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(359, 15)
        Me.TextBox2.TabIndex = 41
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.BackColor = System.Drawing.Color.LightGray
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(888, 521)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(359, 15)
        Me.TextBox1.TabIndex = 41
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_subtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal.ForeColor = System.Drawing.Color.Black
        Me.txt_subtotal.Location = New System.Drawing.Point(1060, 544)
        Me.txt_subtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(133, 15)
        Me.txt_subtotal.TabIndex = 41
        Me.txt_subtotal.Text = "0.0"
        Me.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label5
        '
        Me.label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Black
        Me.label5.Location = New System.Drawing.Point(1002, 483)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(34, 17)
        Me.label5.TabIndex = 40
        Me.label5.Text = "IGV"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(941, 544)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 17)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "SUBTOTAL:"
        '
        'btn_registrar
        '
        Me.btn_registrar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_registrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btn_registrar.FlatAppearance.BorderSize = 0
        Me.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar.ForeColor = System.Drawing.Color.White
        Me.btn_registrar.Image = Global.SistemaVentas2.My.Resources.Resources.ahorrar_dinero
        Me.btn_registrar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_registrar.Location = New System.Drawing.Point(718, 311)
        Me.btn_registrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(113, 39)
        Me.btn_registrar.TabIndex = 36
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_registrar.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel5.Controls.Add(Me.imagen_producto)
        Me.Panel5.Controls.Add(Me.txt_cantidad)
        Me.Panel5.Controls.Add(Me.txt_codigo)
        Me.Panel5.Controls.Add(Me.txt_precio)
        Me.Panel5.Controls.Add(Me.cb_productos)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Location = New System.Drawing.Point(870, 179)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(395, 250)
        Me.Panel5.TabIndex = 35
        '
        'imagen_producto
        '
        Me.imagen_producto.BackColor = System.Drawing.Color.Transparent
        Me.imagen_producto.Image = Global.SistemaVentas2.My.Resources.Resources.pollo
        Me.imagen_producto.Location = New System.Drawing.Point(282, 93)
        Me.imagen_producto.Name = "imagen_producto"
        Me.imagen_producto.Size = New System.Drawing.Size(95, 106)
        Me.imagen_producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagen_producto.TabIndex = 45
        Me.imagen_producto.TabStop = False
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(135, 182)
        Me.txt_cantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(129, 22)
        Me.txt_cantidad.TabIndex = 2
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(135, 110)
        Me.txt_codigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(129, 22)
        Me.txt_codigo.TabIndex = 2
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(135, 140)
        Me.txt_precio.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(129, 22)
        Me.txt_precio.TabIndex = 2
        '
        'cb_productos
        '
        Me.cb_productos.FormattingEnabled = True
        Me.cb_productos.Items.AddRange(New Object() {"FACTURA", "BOLETA"})
        Me.cb_productos.Location = New System.Drawing.Point(135, 74)
        Me.cb_productos.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_productos.Name = "cb_productos"
        Me.cb_productos.Size = New System.Drawing.Size(129, 24)
        Me.cb_productos.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(27, 182)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 17)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Cantidad"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(27, 110)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 17)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Codigo"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(395, 38)
        Me.Panel6.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Producto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(27, 145)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 17)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Precio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(27, 76)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 17)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Nombre"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_imprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_imprimir.FlatAppearance.BorderSize = 0
        Me.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimir.ForeColor = System.Drawing.Color.White
        Me.btn_imprimir.Image = Global.SistemaVentas2.My.Resources.Resources.print
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_imprimir.Location = New System.Drawing.Point(709, 656)
        Me.btn_imprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(122, 39)
        Me.btn_imprimir.TabIndex = 29
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_agregar.FlatAppearance.BorderSize = 0
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.White
        Me.btn_agregar.Image = Global.SistemaVentas2.My.Resources.Resources.carro_de_la_compra
        Me.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_agregar.Location = New System.Drawing.Point(456, 311)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(254, 39)
        Me.btn_agregar.TabIndex = 29
        Me.btn_agregar.Text = "Agregar y Calcular"
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel4.Controls.Add(Me.label_n_factura)
        Me.Panel4.Controls.Add(Me.cb_tipo_documento)
        Me.Panel4.Controls.Add(Me.label_tdocumento)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Location = New System.Drawing.Point(870, 13)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(395, 158)
        Me.Panel4.TabIndex = 35
        '
        'label_n_factura
        '
        Me.label_n_factura.AutoSize = True
        Me.label_n_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_n_factura.Location = New System.Drawing.Point(183, 109)
        Me.label_n_factura.Name = "label_n_factura"
        Me.label_n_factura.Size = New System.Drawing.Size(72, 25)
        Me.label_n_factura.TabIndex = 26
        Me.label_n_factura.Text = "00008"
        '
        'cb_tipo_documento
        '
        Me.cb_tipo_documento.FormattingEnabled = True
        Me.cb_tipo_documento.Items.AddRange(New Object() {"FACTURA", "BOLETA"})
        Me.cb_tipo_documento.Location = New System.Drawing.Point(20, 59)
        Me.cb_tipo_documento.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_tipo_documento.Name = "cb_tipo_documento"
        Me.cb_tipo_documento.Size = New System.Drawing.Size(357, 24)
        Me.cb_tipo_documento.TabIndex = 0
        Me.cb_tipo_documento.Text = "Seleccione el tipo de documento"
        '
        'label_tdocumento
        '
        Me.label_tdocumento.AutoSize = True
        Me.label_tdocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tdocumento.Location = New System.Drawing.Point(112, 109)
        Me.label_tdocumento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_tdocumento.Name = "label_tdocumento"
        Me.label_tdocumento.Size = New System.Drawing.Size(64, 25)
        Me.label_tdocumento.TabIndex = 25
        Me.label_tdocumento.Text = "FAC-"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(395, 38)
        Me.Panel3.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(13, 7)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 26)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tipo Documento"
        '
        'txt_direccion
        '
        Me.txt_direccion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_direccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_direccion.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion.Location = New System.Drawing.Point(456, 255)
        Me.txt_direccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_direccion.Size = New System.Drawing.Size(375, 22)
        Me.txt_direccion.TabIndex = 34
        Me.txt_direccion.Text = "Direccion"
        '
        'txt_telefono
        '
        Me.txt_telefono.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_telefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_telefono.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono.Location = New System.Drawing.Point(698, 205)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(133, 22)
        Me.txt_telefono.TabIndex = 33
        Me.txt_telefono.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(334, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Cliente:"
        '
        'txt_dni
        '
        Me.txt_dni.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_dni.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_dni.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dni.Location = New System.Drawing.Point(456, 202)
        Me.txt_dni.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(133, 22)
        Me.txt_dni.TabIndex = 31
        Me.txt_dni.Text = "DNI"
        '
        'txt_fecha
        '
        Me.txt_fecha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_fecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txt_fecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha.Location = New System.Drawing.Point(337, 74)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(494, 22)
        Me.txt_fecha.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(613, 202)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 25)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Cel:"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(339, 252)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 25)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Dirección:"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(339, 199)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 25)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "DNI:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(334, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Fecha:"
        '
        'RegistrarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrarVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrarVentas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.imagen_producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_igv As System.Windows.Forms.TextBox
    Friend WithEvents txt_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_registrar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cb_tipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_dni As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_clientes As System.Windows.Forms.ComboBox
    Friend WithEvents label_total As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents cb_productos As System.Windows.Forms.ComboBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents imagen_producto As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents label_tdocumento As System.Windows.Forms.Label
    Friend WithEvents btn_imprimir As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_eliminar_compras As Button
    Friend WithEvents btn_limpiar_compras As Button
    Friend WithEvents label_n_factura As Label
    Public WithEvents list As ListView
End Class
