<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cod_producto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.cb_codigo_proovedor = New System.Windows.Forms.ComboBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_agregar_productos = New System.Windows.Forms.Button()
        Me.btn_actualizar_producto = New System.Windows.Forms.Button()
        Me.btn_mostrar_lista = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label_producto = New System.Windows.Forms.Label()
        Me.imagen_producto_restante = New System.Windows.Forms.PictureBox()
        Me.label_producto_restante = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_buscar_productos = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_productos = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.imagen_producto_restante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_buscar_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.stroheim_montasio_ombre_haze_5405502_luxury_decor_fabric_pl_118816_e32
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1610, 1080)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.txt_stock)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.txt_precio)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.txt_cod_producto)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.txt_nombre)
        Me.Panel5.Controls.Add(Me.cb_codigo_proovedor)
        Me.Panel5.Controls.Add(Me.PictureBox5)
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.PictureBox4)
        Me.Panel5.Location = New System.Drawing.Point(297, 46)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(799, 313)
        Me.Panel5.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(52, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 32)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Cod_Proovedor"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(52, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 32)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Nombre"
        '
        'txt_stock
        '
        Me.txt_stock.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txt_stock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_stock.Location = New System.Drawing.Point(290, 255)
        Me.txt_stock.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(445, 22)
        Me.txt_stock.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(54, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 32)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Cod_Producto"
        '
        'txt_precio
        '
        Me.txt_precio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_precio.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio.Location = New System.Drawing.Point(290, 192)
        Me.txt_precio.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(445, 22)
        Me.txt_precio.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(52, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 32)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Precio"
        '
        'txt_cod_producto
        '
        Me.txt_cod_producto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_cod_producto.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txt_cod_producto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cod_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod_producto.Location = New System.Drawing.Point(290, 67)
        Me.txt_cod_producto.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cod_producto.Name = "txt_cod_producto"
        Me.txt_cod_producto.Size = New System.Drawing.Size(445, 22)
        Me.txt_cod_producto.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(52, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 32)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Stock"
        '
        'txt_nombre
        '
        Me.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(288, 127)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(445, 22)
        Me.txt_nombre.TabIndex = 50
        '
        'cb_codigo_proovedor
        '
        Me.cb_codigo_proovedor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cb_codigo_proovedor.FormattingEnabled = True
        Me.cb_codigo_proovedor.Location = New System.Drawing.Point(275, 19)
        Me.cb_codigo_proovedor.Name = "cb_codigo_proovedor"
        Me.cb_codigo_proovedor.Size = New System.Drawing.Size(472, 24)
        Me.cb_codigo_proovedor.TabIndex = 48
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox5.Image = Global.SistemaVentas2.My.Resources.Resources.form2
        Me.PictureBox5.Location = New System.Drawing.Point(275, 244)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(472, 47)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 49
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox3.Image = Global.SistemaVentas2.My.Resources.Resources.form2
        Me.PictureBox3.Location = New System.Drawing.Point(273, 116)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(472, 47)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 49
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.SistemaVentas2.My.Resources.Resources.form2
        Me.PictureBox1.Location = New System.Drawing.Point(275, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(472, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox4.Image = Global.SistemaVentas2.My.Resources.Resources.form2
        Me.PictureBox4.Location = New System.Drawing.Point(275, 181)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(472, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 49
        Me.PictureBox4.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.btn_agregar_productos)
        Me.Panel4.Controls.Add(Me.btn_actualizar_producto)
        Me.Panel4.Controls.Add(Me.btn_mostrar_lista)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1393, 46)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(217, 1034)
        Me.Panel4.TabIndex = 51
        '
        'btn_agregar_productos
        '
        Me.btn_agregar_productos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar_productos.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.agregar_empleado__1_
        Me.btn_agregar_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_agregar_productos.Location = New System.Drawing.Point(35, 37)
        Me.btn_agregar_productos.Name = "btn_agregar_productos"
        Me.btn_agregar_productos.Size = New System.Drawing.Size(150, 150)
        Me.btn_agregar_productos.TabIndex = 46
        Me.btn_agregar_productos.UseVisualStyleBackColor = True
        '
        'btn_actualizar_producto
        '
        Me.btn_actualizar_producto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_actualizar_producto.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.recargar__1_
        Me.btn_actualizar_producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_actualizar_producto.Location = New System.Drawing.Point(35, 245)
        Me.btn_actualizar_producto.Name = "btn_actualizar_producto"
        Me.btn_actualizar_producto.Size = New System.Drawing.Size(150, 150)
        Me.btn_actualizar_producto.TabIndex = 45
        Me.btn_actualizar_producto.UseVisualStyleBackColor = True
        '
        'btn_mostrar_lista
        '
        Me.btn_mostrar_lista.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_mostrar_lista.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.listar
        Me.btn_mostrar_lista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_mostrar_lista.Location = New System.Drawing.Point(35, 459)
        Me.btn_mostrar_lista.Name = "btn_mostrar_lista"
        Me.btn_mostrar_lista.Size = New System.Drawing.Size(150, 150)
        Me.btn_mostrar_lista.TabIndex = 44
        Me.btn_mostrar_lista.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.barraverde1
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.label_producto)
        Me.Panel3.Controls.Add(Me.imagen_producto_restante)
        Me.Panel3.Controls.Add(Me.label_producto_restante)
        Me.Panel3.Location = New System.Drawing.Point(357, 395)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(517, 299)
        Me.Panel3.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(150, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 41)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Kgs"
        '
        'label_producto
        '
        Me.label_producto.AutoSize = True
        Me.label_producto.BackColor = System.Drawing.Color.Transparent
        Me.label_producto.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_producto.ForeColor = System.Drawing.Color.White
        Me.label_producto.Location = New System.Drawing.Point(1, 87)
        Me.label_producto.Name = "label_producto"
        Me.label_producto.Size = New System.Drawing.Size(133, 41)
        Me.label_producto.TabIndex = 23
        Me.label_producto.Text = "restante"
        '
        'imagen_producto_restante
        '
        Me.imagen_producto_restante.BackColor = System.Drawing.Color.Transparent
        Me.imagen_producto_restante.Image = Global.SistemaVentas2.My.Resources.Resources.huevo
        Me.imagen_producto_restante.Location = New System.Drawing.Point(302, 0)
        Me.imagen_producto_restante.Name = "imagen_producto_restante"
        Me.imagen_producto_restante.Size = New System.Drawing.Size(215, 146)
        Me.imagen_producto_restante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagen_producto_restante.TabIndex = 22
        Me.imagen_producto_restante.TabStop = False
        '
        'label_producto_restante
        '
        Me.label_producto_restante.AutoSize = True
        Me.label_producto_restante.BackColor = System.Drawing.Color.Transparent
        Me.label_producto_restante.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_producto_restante.ForeColor = System.Drawing.Color.White
        Me.label_producto_restante.Location = New System.Drawing.Point(3, 18)
        Me.label_producto_restante.Name = "label_producto_restante"
        Me.label_producto_restante.Size = New System.Drawing.Size(75, 59)
        Me.label_producto_restante.TabIndex = 23
        Me.label_producto_restante.Text = "10"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Controls.Add(Me.btn_buscar_productos)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cb_productos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1610, 46)
        Me.Panel2.TabIndex = 0
        '
        'btn_buscar_productos
        '
        Me.btn_buscar_productos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_buscar_productos.BackColor = System.Drawing.Color.Transparent
        Me.btn_buscar_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_buscar_productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscar_productos.Image = Global.SistemaVentas2.My.Resources.Resources.searh
        Me.btn_buscar_productos.Location = New System.Drawing.Point(1518, 4)
        Me.btn_buscar_productos.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_buscar_productos.Name = "btn_buscar_productos"
        Me.btn_buscar_productos.Size = New System.Drawing.Size(70, 38)
        Me.btn_buscar_productos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_buscar_productos.TabIndex = 38
        Me.btn_buscar_productos.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(336, 45)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Modificar Productos"
        '
        'cb_productos
        '
        Me.cb_productos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_productos.FormattingEnabled = True
        Me.cb_productos.Location = New System.Drawing.Point(1149, 13)
        Me.cb_productos.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_productos.Name = "cb_productos"
        Me.cb_productos.Size = New System.Drawing.Size(344, 24)
        Me.cb_productos.TabIndex = 37
        Me.cb_productos.Text = "Seleccione Producto"
        '
        'ModificarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1610, 1080)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarProductos"
        Me.Text = "ModificarProductos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.imagen_producto_restante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btn_buscar_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_buscar_productos As System.Windows.Forms.PictureBox
    Friend WithEvents cb_productos As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents label_producto As System.Windows.Forms.Label
    Friend WithEvents imagen_producto_restante As System.Windows.Forms.PictureBox
    Friend WithEvents label_producto_restante As System.Windows.Forms.Label
    Friend WithEvents btn_actualizar_producto As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_productos As System.Windows.Forms.Button
    Friend WithEvents cb_codigo_proovedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_stock As System.Windows.Forms.TextBox
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_mostrar_lista As System.Windows.Forms.Button
    Friend WithEvents txt_cod_producto As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
End Class
