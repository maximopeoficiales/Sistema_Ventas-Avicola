<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu1))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelMenuInicio = New System.Windows.Forms.Panel()
        Me.panel_con_botones = New System.Windows.Forms.Panel()
        Me.btn_registrar_venta = New System.Windows.Forms.Button()
        Me.btn_modificar_cliente = New System.Windows.Forms.Button()
        Me.btn_consultar_productos = New System.Windows.Forms.Button()
        Me.panel_contenedor_usuario = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label_usuario = New System.Windows.Forms.Label()
        Me.SlideMenu = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btmenu = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.imglogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Ganancias1 = New System.Windows.Forms.Button()
        Me.btn_Ventas = New System.Windows.Forms.Button()
        Me.btn_Empleados = New System.Windows.Forms.Button()
        Me.btn_Clientes = New System.Windows.Forms.Button()
        Me.btn_Productos = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.btn_proovedores = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelMenuInicio.SuspendLayout()
        Me.panel_con_botones.SuspendLayout()
        Me.panel_contenedor_usuario.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SlideMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.imglogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.White
        Me.PanelContenedor.Controls.Add(Me.PanelMenuInicio)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(309, 0)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1611, 1055)
        Me.PanelContenedor.TabIndex = 3
        '
        'PanelMenuInicio
        '
        Me.PanelMenuInicio.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.stroheim_montasio_ombre_haze_5405502_luxury_decor_fabric_pl_118816_e32
        Me.PanelMenuInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelMenuInicio.Controls.Add(Me.PictureBox2)
        Me.PanelMenuInicio.Controls.Add(Me.panel_con_botones)
        Me.PanelMenuInicio.Controls.Add(Me.panel_contenedor_usuario)
        Me.PanelMenuInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMenuInicio.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelMenuInicio.Name = "PanelMenuInicio"
        Me.PanelMenuInicio.Size = New System.Drawing.Size(1611, 1055)
        Me.PanelMenuInicio.TabIndex = 0
        '
        'panel_con_botones
        '
        Me.panel_con_botones.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panel_con_botones.BackColor = System.Drawing.Color.Transparent
        Me.panel_con_botones.Controls.Add(Me.btn_registrar_venta)
        Me.panel_con_botones.Controls.Add(Me.btn_modificar_cliente)
        Me.panel_con_botones.Controls.Add(Me.btn_consultar_productos)
        Me.panel_con_botones.Location = New System.Drawing.Point(297, 100)
        Me.panel_con_botones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_con_botones.Name = "panel_con_botones"
        Me.panel_con_botones.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_con_botones.Size = New System.Drawing.Size(1016, 193)
        Me.panel_con_botones.TabIndex = 29
        '
        'btn_registrar_venta
        '
        Me.btn_registrar_venta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_registrar_venta.FlatAppearance.BorderSize = 0
        Me.btn_registrar_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar_venta.ForeColor = System.Drawing.Color.White
        Me.btn_registrar_venta.Image = Global.SistemaVentas2.My.Resources.Resources.shopping_cart
        Me.btn_registrar_venta.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_registrar_venta.Location = New System.Drawing.Point(361, 38)
        Me.btn_registrar_venta.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_registrar_venta.Name = "btn_registrar_venta"
        Me.btn_registrar_venta.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_registrar_venta.Size = New System.Drawing.Size(307, 134)
        Me.btn_registrar_venta.TabIndex = 27
        Me.btn_registrar_venta.Text = "REGISTRAR " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VENTA"
        Me.btn_registrar_venta.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_registrar_venta.UseVisualStyleBackColor = False
        '
        'btn_modificar_cliente
        '
        Me.btn_modificar_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btn_modificar_cliente.FlatAppearance.BorderSize = 0
        Me.btn_modificar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modificar_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_cliente.ForeColor = System.Drawing.Color.White
        Me.btn_modificar_cliente.Image = Global.SistemaVentas2.My.Resources.Resources.clientes
        Me.btn_modificar_cliente.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_modificar_cliente.Location = New System.Drawing.Point(741, 38)
        Me.btn_modificar_cliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_modificar_cliente.Name = "btn_modificar_cliente"
        Me.btn_modificar_cliente.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_modificar_cliente.Size = New System.Drawing.Size(256, 134)
        Me.btn_modificar_cliente.TabIndex = 13
        Me.btn_modificar_cliente.Text = "MODIFICAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CLIENTE"
        Me.btn_modificar_cliente.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_modificar_cliente.UseVisualStyleBackColor = False
        '
        'btn_consultar_productos
        '
        Me.btn_consultar_productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_consultar_productos.FlatAppearance.BorderSize = 0
        Me.btn_consultar_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_consultar_productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultar_productos.ForeColor = System.Drawing.Color.White
        Me.btn_consultar_productos.Image = Global.SistemaVentas2.My.Resources.Resources.pollo__1_
        Me.btn_consultar_productos.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_consultar_productos.Location = New System.Drawing.Point(40, 38)
        Me.btn_consultar_productos.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_consultar_productos.Name = "btn_consultar_productos"
        Me.btn_consultar_productos.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_consultar_productos.Size = New System.Drawing.Size(267, 134)
        Me.btn_consultar_productos.TabIndex = 12
        Me.btn_consultar_productos.Text = "CONSULTAR " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PRODUCTOS"
        Me.btn_consultar_productos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_consultar_productos.UseVisualStyleBackColor = False
        '
        'panel_contenedor_usuario
        '
        Me.panel_contenedor_usuario.BackColor = System.Drawing.Color.Transparent
        Me.panel_contenedor_usuario.Controls.Add(Me.PictureBox1)
        Me.panel_contenedor_usuario.Controls.Add(Me.label_usuario)
        Me.panel_contenedor_usuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_contenedor_usuario.Location = New System.Drawing.Point(0, 0)
        Me.panel_contenedor_usuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_contenedor_usuario.Name = "panel_contenedor_usuario"
        Me.panel_contenedor_usuario.Size = New System.Drawing.Size(1611, 100)
        Me.panel_contenedor_usuario.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SistemaVentas2.My.Resources.Resources.estudiante
        Me.PictureBox1.Location = New System.Drawing.Point(13, 17)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'label_usuario
        '
        Me.label_usuario.AutoSize = True
        Me.label_usuario.BackColor = System.Drawing.Color.Transparent
        Me.label_usuario.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_usuario.ForeColor = System.Drawing.Color.Black
        Me.label_usuario.Location = New System.Drawing.Point(109, 26)
        Me.label_usuario.Name = "label_usuario"
        Me.label_usuario.Size = New System.Drawing.Size(158, 51)
        Me.label_usuario.TabIndex = 24
        Me.label_usuario.Text = "Usuario"
        '
        'SlideMenu
        '
        Me.SlideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.SlideMenu.Controls.Add(Me.Panel2)
        Me.SlideMenu.Controls.Add(Me.Panel1)
        Me.SlideMenu.Controls.Add(Me.btn_Ganancias1)
        Me.SlideMenu.Controls.Add(Me.btn_Ventas)
        Me.SlideMenu.Controls.Add(Me.btn_Empleados)
        Me.SlideMenu.Controls.Add(Me.btn_Clientes)
        Me.SlideMenu.Controls.Add(Me.btn_Productos)
        Me.SlideMenu.Controls.Add(Me.btn_Salir)
        Me.SlideMenu.Controls.Add(Me.btn_proovedores)
        Me.SlideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.SlideMenu.Location = New System.Drawing.Point(0, 0)
        Me.SlideMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SlideMenu.Name = "SlideMenu"
        Me.SlideMenu.Size = New System.Drawing.Size(309, 1055)
        Me.SlideMenu.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btmenu)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Panel2.Size = New System.Drawing.Size(309, 78)
        Me.Panel2.TabIndex = 22
        '
        'btmenu
        '
        Me.btmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btmenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btmenu.Image = CType(resources.GetObject("btmenu.Image"), System.Drawing.Image)
        Me.btmenu.Location = New System.Drawing.Point(251, 17)
        Me.btmenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btmenu.Name = "btmenu"
        Me.btmenu.Size = New System.Drawing.Size(43, 39)
        Me.btmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btmenu.TabIndex = 14
        Me.btmenu.TabStop = False
        Me.btmenu.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.imglogo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(3, 82)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 117)
        Me.Panel1.TabIndex = 29
        '
        'imglogo
        '
        Me.imglogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imglogo.Image = Global.SistemaVentas2.My.Resources.Resources.logo
        Me.imglogo.Location = New System.Drawing.Point(-3, 15)
        Me.imglogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.imglogo.Name = "imglogo"
        Me.imglogo.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.imglogo.Size = New System.Drawing.Size(76, 71)
        Me.imglogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imglogo.TabIndex = 21
        Me.imglogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(93, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AVICOLA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(155, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 39)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "CIRILA"
        '
        'btn_Ganancias1
        '
        Me.btn_Ganancias1.FlatAppearance.BorderSize = 0
        Me.btn_Ganancias1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_Ganancias1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_Ganancias1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_Ganancias1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Ganancias1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ganancias1.ForeColor = System.Drawing.Color.White
        Me.btn_Ganancias1.Image = CType(resources.GetObject("btn_Ganancias1.Image"), System.Drawing.Image)
        Me.btn_Ganancias1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Ganancias1.Location = New System.Drawing.Point(0, 597)
        Me.btn_Ganancias1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Ganancias1.Name = "btn_Ganancias1"
        Me.btn_Ganancias1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_Ganancias1.Size = New System.Drawing.Size(309, 62)
        Me.btn_Ganancias1.TabIndex = 27
        Me.btn_Ganancias1.Text = "     Ganancias"
        Me.btn_Ganancias1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Ganancias1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Ganancias1.UseVisualStyleBackColor = True
        '
        'btn_Ventas
        '
        Me.btn_Ventas.FlatAppearance.BorderSize = 0
        Me.btn_Ventas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_Ventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_Ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Ventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ventas.ForeColor = System.Drawing.Color.White
        Me.btn_Ventas.Image = CType(resources.GetObject("btn_Ventas.Image"), System.Drawing.Image)
        Me.btn_Ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Ventas.Location = New System.Drawing.Point(0, 236)
        Me.btn_Ventas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Ventas.Name = "btn_Ventas"
        Me.btn_Ventas.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_Ventas.Size = New System.Drawing.Size(309, 62)
        Me.btn_Ventas.TabIndex = 5
        Me.btn_Ventas.Text = "     Ventas"
        Me.btn_Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Ventas.UseVisualStyleBackColor = True
        '
        'btn_Empleados
        '
        Me.btn_Empleados.FlatAppearance.BorderSize = 0
        Me.btn_Empleados.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_Empleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_Empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Empleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Empleados.ForeColor = System.Drawing.Color.White
        Me.btn_Empleados.Image = CType(resources.GetObject("btn_Empleados.Image"), System.Drawing.Image)
        Me.btn_Empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Empleados.Location = New System.Drawing.Point(0, 453)
        Me.btn_Empleados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Empleados.Name = "btn_Empleados"
        Me.btn_Empleados.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_Empleados.Size = New System.Drawing.Size(309, 62)
        Me.btn_Empleados.TabIndex = 11
        Me.btn_Empleados.Text = "     Empleados"
        Me.btn_Empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Empleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Empleados.UseVisualStyleBackColor = True
        '
        'btn_Clientes
        '
        Me.btn_Clientes.FlatAppearance.BorderSize = 0
        Me.btn_Clientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_Clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clientes.ForeColor = System.Drawing.Color.White
        Me.btn_Clientes.Image = CType(resources.GetObject("btn_Clientes.Image"), System.Drawing.Image)
        Me.btn_Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Clientes.Location = New System.Drawing.Point(0, 377)
        Me.btn_Clientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Clientes.Name = "btn_Clientes"
        Me.btn_Clientes.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_Clientes.Size = New System.Drawing.Size(309, 62)
        Me.btn_Clientes.TabIndex = 7
        Me.btn_Clientes.Text = "     Clientes"
        Me.btn_Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Clientes.UseVisualStyleBackColor = True
        '
        'btn_Productos
        '
        Me.btn_Productos.FlatAppearance.BorderSize = 0
        Me.btn_Productos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_Productos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_Productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Productos.ForeColor = System.Drawing.Color.White
        Me.btn_Productos.Image = CType(resources.GetObject("btn_Productos.Image"), System.Drawing.Image)
        Me.btn_Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Productos.Location = New System.Drawing.Point(0, 306)
        Me.btn_Productos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Productos.Name = "btn_Productos"
        Me.btn_Productos.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_Productos.Size = New System.Drawing.Size(309, 62)
        Me.btn_Productos.TabIndex = 22
        Me.btn_Productos.Text = "     Productos"
        Me.btn_Productos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Productos.UseVisualStyleBackColor = True
        '
        'btn_Salir
        '
        Me.btn_Salir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_Salir.FlatAppearance.BorderSize = 0
        Me.btn_Salir.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.White
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.Location = New System.Drawing.Point(0, 993)
        Me.btn_Salir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_Salir.Size = New System.Drawing.Size(309, 62)
        Me.btn_Salir.TabIndex = 12
        Me.btn_Salir.Text = "     Cerrar Sesion"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Salir.UseVisualStyleBackColor = True
        '
        'btn_proovedores
        '
        Me.btn_proovedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_proovedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_proovedores.FlatAppearance.BorderSize = 0
        Me.btn_proovedores.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_proovedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_proovedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_proovedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proovedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proovedores.ForeColor = System.Drawing.Color.White
        Me.btn_proovedores.Image = Global.SistemaVentas2.My.Resources.Resources.proveedores
        Me.btn_proovedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_proovedores.Location = New System.Drawing.Point(0, 523)
        Me.btn_proovedores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_proovedores.Name = "btn_proovedores"
        Me.btn_proovedores.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_proovedores.Size = New System.Drawing.Size(309, 62)
        Me.btn_proovedores.TabIndex = 28
        Me.btn_proovedores.Text = "     Proveedores"
        Me.btn_proovedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_proovedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_proovedores.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.SistemaVentas2.My.Resources.Resources.avicola
        Me.PictureBox2.Location = New System.Drawing.Point(218, 363)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1289, 658)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'Menu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1055)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.SlideMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(808, 446)
        Me.Name = "Menu1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelMenuInicio.ResumeLayout(False)
        Me.panel_con_botones.ResumeLayout(False)
        Me.panel_contenedor_usuario.ResumeLayout(False)
        Me.panel_contenedor_usuario.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SlideMenu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.btmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.imglogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContenedor As System.Windows.Forms.Panel
    Friend WithEvents SlideMenu As System.Windows.Forms.Panel
    Friend WithEvents btmenu As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Ganancias1 As System.Windows.Forms.Button
    Friend WithEvents btn_Ventas As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents imglogo As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Empleados As System.Windows.Forms.Button
    Friend WithEvents btn_Clientes As System.Windows.Forms.Button
    Friend WithEvents btn_Productos As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_proovedores As System.Windows.Forms.Button
    Friend WithEvents PanelMenuInicio As Panel
    Friend WithEvents panel_con_botones As Panel
    Friend WithEvents btn_registrar_venta As Button
    Friend WithEvents btn_modificar_cliente As Button
    Friend WithEvents btn_consultar_productos As Button
    Friend WithEvents panel_contenedor_usuario As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents label_usuario As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
