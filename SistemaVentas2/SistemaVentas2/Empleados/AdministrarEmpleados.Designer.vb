<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministrarEmpleados
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministarEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelTexts = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.uncheck1 = New System.Windows.Forms.PictureBox()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.check1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.uncheck = New System.Windows.Forms.PictureBox()
        Me.cb_tipo_empleado = New System.Windows.Forms.ComboBox()
        Me.check = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txt_nueva_contraseña = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.btn_agregar_emp = New System.Windows.Forms.Button()
        Me.btn_actualizar_emp = New System.Windows.Forms.Button()
        Me.btn_listar_emp = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.label_cantidad_emp = New System.Windows.Forms.Label()
        Me.cod_empleado_txt = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelTexts.SuspendLayout()
        CType(Me.uncheck1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.check1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uncheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.check, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBotones.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministarEmpleadosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1610, 46)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministarEmpleadosToolStripMenuItem
        '
        Me.AdministarEmpleadosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministarEmpleadosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AdministarEmpleadosToolStripMenuItem.Name = "AdministarEmpleadosToolStripMenuItem"
        Me.AdministarEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(337, 42)
        Me.AdministarEmpleadosToolStripMenuItem.Text = "Administrar Empleados"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.stroheim_montasio_ombre_haze_5405502_luxury_decor_fabric_pl_118816_e32
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.panelTexts)
        Me.Panel1.Controls.Add(Me.PanelBotones)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1610, 1034)
        Me.Panel1.TabIndex = 27
        '
        'panelTexts
        '
        Me.panelTexts.BackColor = System.Drawing.Color.Transparent
        Me.panelTexts.Controls.Add(Me.cod_empleado_txt)
        Me.panelTexts.Controls.Add(Me.Label3)
        Me.panelTexts.Controls.Add(Me.Label1)
        Me.panelTexts.Controls.Add(Me.uncheck1)
        Me.panelTexts.Controls.Add(Me.txt_contraseña)
        Me.panelTexts.Controls.Add(Me.txt_usuario)
        Me.panelTexts.Controls.Add(Me.PictureBox2)
        Me.panelTexts.Controls.Add(Me.Label2)
        Me.panelTexts.Controls.Add(Me.check1)
        Me.panelTexts.Controls.Add(Me.Label4)
        Me.panelTexts.Controls.Add(Me.txt_nombre)
        Me.panelTexts.Controls.Add(Me.Label5)
        Me.panelTexts.Controls.Add(Me.uncheck)
        Me.panelTexts.Controls.Add(Me.cb_tipo_empleado)
        Me.panelTexts.Controls.Add(Me.check)
        Me.panelTexts.Controls.Add(Me.PictureBox4)
        Me.panelTexts.Controls.Add(Me.txt_nueva_contraseña)
        Me.panelTexts.Controls.Add(Me.PictureBox3)
        Me.panelTexts.Controls.Add(Me.PictureBox1)
        Me.panelTexts.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTexts.Location = New System.Drawing.Point(0, 0)
        Me.panelTexts.Name = "panelTexts"
        Me.panelTexts.Size = New System.Drawing.Size(1410, 346)
        Me.panelTexts.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(317, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 32)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "TIPO"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(319, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 32)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "NOMBRE"
        '
        'uncheck1
        '
        Me.uncheck1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.uncheck1.BackColor = System.Drawing.Color.Transparent
        Me.uncheck1.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.consolar
        Me.uncheck1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.uncheck1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.uncheck1.Location = New System.Drawing.Point(1038, 284)
        Me.uncheck1.Name = "uncheck1"
        Me.uncheck1.Size = New System.Drawing.Size(28, 28)
        Me.uncheck1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.uncheck1.TabIndex = 50
        Me.uncheck1.TabStop = False
        Me.uncheck1.Visible = False
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_contraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contraseña.Location = New System.Drawing.Point(646, 221)
        Me.txt_contraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contraseña.Size = New System.Drawing.Size(367, 22)
        Me.txt_contraseña.TabIndex = 49
        '
        'txt_usuario
        '
        Me.txt_usuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(646, 146)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(367, 22)
        Me.txt_usuario.TabIndex = 49
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = Global.SistemaVentas2.My.Resources.Resources.form2
        Me.PictureBox2.Location = New System.Drawing.Point(630, 136)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(400, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(317, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 32)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "USUARIO"
        '
        'check1
        '
        Me.check1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.check1.BackColor = System.Drawing.Color.Transparent
        Me.check1.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.check
        Me.check1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.check1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.check1.Location = New System.Drawing.Point(1038, 284)
        Me.check1.Name = "check1"
        Me.check1.Size = New System.Drawing.Size(28, 28)
        Me.check1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.check1.TabIndex = 51
        Me.check1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(317, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 32)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "CONTRASEÑA"
        '
        'txt_nombre
        '
        Me.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(647, 87)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(367, 22)
        Me.txt_nombre.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(319, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(264, 32)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "NUEVA CONTRASEÑA"
        '
        'uncheck
        '
        Me.uncheck.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.uncheck.BackColor = System.Drawing.Color.Transparent
        Me.uncheck.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.consolar
        Me.uncheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.uncheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.uncheck.Location = New System.Drawing.Point(1038, 215)
        Me.uncheck.Name = "uncheck"
        Me.uncheck.Size = New System.Drawing.Size(28, 28)
        Me.uncheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.uncheck.TabIndex = 22
        Me.uncheck.TabStop = False
        Me.uncheck.Visible = False
        '
        'cb_tipo_empleado
        '
        Me.cb_tipo_empleado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cb_tipo_empleado.FormattingEnabled = True
        Me.cb_tipo_empleado.Items.AddRange(New Object() {"Vendedor ", "Dueño"})
        Me.cb_tipo_empleado.Location = New System.Drawing.Point(630, 28)
        Me.cb_tipo_empleado.Name = "cb_tipo_empleado"
        Me.cb_tipo_empleado.Size = New System.Drawing.Size(401, 24)
        Me.cb_tipo_empleado.TabIndex = 30
        Me.cb_tipo_empleado.Text = "Seleccione su tipo"
        '
        'check
        '
        Me.check.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.check.BackColor = System.Drawing.Color.Transparent
        Me.check.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.check
        Me.check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.check.Cursor = System.Windows.Forms.Cursors.Hand
        Me.check.Location = New System.Drawing.Point(1037, 215)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(28, 28)
        Me.check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.check.TabIndex = 22
        Me.check.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox4.Image = Global.SistemaVentas2.My.Resources.Resources.form2
        Me.PictureBox4.Location = New System.Drawing.Point(631, 72)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(400, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 48
        Me.PictureBox4.TabStop = False
        '
        'txt_nueva_contraseña
        '
        Me.txt_nueva_contraseña.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_nueva_contraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txt_nueva_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nueva_contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nueva_contraseña.Location = New System.Drawing.Point(647, 286)
        Me.txt_nueva_contraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nueva_contraseña.Name = "txt_nueva_contraseña"
        Me.txt_nueva_contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_nueva_contraseña.Size = New System.Drawing.Size(367, 22)
        Me.txt_nueva_contraseña.TabIndex = 49
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox3.Image = Global.SistemaVentas2.My.Resources.Resources.form2
        Me.PictureBox3.Location = New System.Drawing.Point(630, 209)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(400, 51)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 48
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.SistemaVentas2.My.Resources.Resources.form2
        Me.PictureBox1.Location = New System.Drawing.Point(631, 271)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(401, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'PanelBotones
        '
        Me.PanelBotones.BackColor = System.Drawing.Color.Transparent
        Me.PanelBotones.Controls.Add(Me.btn_agregar_emp)
        Me.PanelBotones.Controls.Add(Me.btn_actualizar_emp)
        Me.PanelBotones.Controls.Add(Me.btn_listar_emp)
        Me.PanelBotones.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelBotones.Location = New System.Drawing.Point(1410, 0)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(200, 1034)
        Me.PanelBotones.TabIndex = 33
        '
        'btn_agregar_emp
        '
        Me.btn_agregar_emp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_agregar_emp.BackColor = System.Drawing.Color.Transparent
        Me.btn_agregar_emp.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.agregar_empleado__1_
        Me.btn_agregar_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_agregar_emp.Location = New System.Drawing.Point(28, 218)
        Me.btn_agregar_emp.Name = "btn_agregar_emp"
        Me.btn_agregar_emp.Size = New System.Drawing.Size(150, 150)
        Me.btn_agregar_emp.TabIndex = 29
        Me.btn_agregar_emp.UseVisualStyleBackColor = False
        '
        'btn_actualizar_emp
        '
        Me.btn_actualizar_emp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_actualizar_emp.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.recargar__1_
        Me.btn_actualizar_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_actualizar_emp.Location = New System.Drawing.Point(28, 442)
        Me.btn_actualizar_emp.Name = "btn_actualizar_emp"
        Me.btn_actualizar_emp.Size = New System.Drawing.Size(150, 150)
        Me.btn_actualizar_emp.TabIndex = 29
        Me.btn_actualizar_emp.UseVisualStyleBackColor = True
        '
        'btn_listar_emp
        '
        Me.btn_listar_emp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_listar_emp.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.listar
        Me.btn_listar_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_listar_emp.Location = New System.Drawing.Point(28, 648)
        Me.btn_listar_emp.Name = "btn_listar_emp"
        Me.btn_listar_emp.Size = New System.Drawing.Size(150, 150)
        Me.btn_listar_emp.TabIndex = 29
        Me.btn_listar_emp.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.barradeceleste1JPG
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.label_cantidad_emp)
        Me.Panel2.Location = New System.Drawing.Point(323, 393)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(591, 255)
        Me.Panel2.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(345, 41)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Empleados Registrados"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.SistemaVentas2.My.Resources.Resources.estudiante
        Me.PictureBox6.Location = New System.Drawing.Point(433, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(123, 100)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 22
        Me.PictureBox6.TabStop = False
        '
        'label_cantidad_emp
        '
        Me.label_cantidad_emp.AutoSize = True
        Me.label_cantidad_emp.BackColor = System.Drawing.Color.Transparent
        Me.label_cantidad_emp.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_cantidad_emp.ForeColor = System.Drawing.Color.White
        Me.label_cantidad_emp.Location = New System.Drawing.Point(3, 12)
        Me.label_cantidad_emp.Name = "label_cantidad_emp"
        Me.label_cantidad_emp.Size = New System.Drawing.Size(84, 65)
        Me.label_cantidad_emp.TabIndex = 23
        Me.label_cantidad_emp.Text = "10"
        '
        'cod_empleado_txt
        '
        Me.cod_empleado_txt.AutoSize = True
        Me.cod_empleado_txt.Location = New System.Drawing.Point(1088, 34)
        Me.cod_empleado_txt.Name = "cod_empleado_txt"
        Me.cod_empleado_txt.Size = New System.Drawing.Size(0, 17)
        Me.cod_empleado_txt.TabIndex = 52
        Me.cod_empleado_txt.Visible = False
        '
        'AdministrarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1610, 1080)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdministrarEmpleados"
        Me.Text = "AdministrarEmpleados"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.panelTexts.ResumeLayout(False)
        Me.panelTexts.PerformLayout()
        CType(Me.uncheck1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.check1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uncheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.check, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBotones.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministarEmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_actualizar_emp As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_emp As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_listar_emp As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents check As System.Windows.Forms.PictureBox
    Friend WithEvents label_cantidad_emp As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_nueva_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Public WithEvents cb_tipo_empleado As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents uncheck As System.Windows.Forms.PictureBox
    Friend WithEvents uncheck1 As System.Windows.Forms.PictureBox
    Friend WithEvents check1 As System.Windows.Forms.PictureBox
    Friend WithEvents panelTexts As Panel
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents cod_empleado_txt As Label
End Class
