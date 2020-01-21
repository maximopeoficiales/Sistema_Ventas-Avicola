<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministrarClientes
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
        Me.AdministrarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_agregarcliente = New System.Windows.Forms.Button()
        Me.btn_mostrar_clientes = New System.Windows.Forms.Button()
        Me.btn_eliminarcliente = New System.Windows.Forms.Button()
        Me.btn_actualizarcliente = New System.Windows.Forms.Button()
        Me.tablaclientes = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_buscarclientes = New System.Windows.Forms.PictureBox()
        Me.cb_dni = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.tablaclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_buscarclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarClientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1610, 46)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministrarClientesToolStripMenuItem
        '
        Me.AdministrarClientesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministrarClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AdministrarClientesToolStripMenuItem.Name = "AdministrarClientesToolStripMenuItem"
        Me.AdministrarClientesToolStripMenuItem.Size = New System.Drawing.Size(298, 42)
        Me.AdministrarClientesToolStripMenuItem.Text = "Administrar Clientes"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.stroheim_montasio_ombre_haze_5405502_luxury_decor_fabric_pl_118816_e32
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.tablaclientes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1610, 1034)
        Me.Panel1.TabIndex = 26
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txt_direccion)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txt_telefono)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.txt_dni)
        Me.Panel3.Controls.Add(Me.txt_nombre)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1385, 377)
        Me.Panel3.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(318, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 38)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "DNI"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(318, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 38)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "NOMBRE"
        '
        'txt_direccion
        '
        Me.txt_direccion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_direccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion.Location = New System.Drawing.Point(527, 273)
        Me.txt_direccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(496, 22)
        Me.txt_direccion.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(318, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 38)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "TELEFONO"
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox4.Image = Global.SistemaVentas2.My.Resources.Resources.form2
        Me.PictureBox4.Location = New System.Drawing.Point(512, 262)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(523, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 48
        Me.PictureBox4.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(318, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 38)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "DIRECCION"
        '
        'txt_telefono
        '
        Me.txt_telefono.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_telefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono.Location = New System.Drawing.Point(527, 211)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(496, 22)
        Me.txt_telefono.TabIndex = 49
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox3.Image = Global.SistemaVentas2.My.Resources.Resources.form2
        Me.PictureBox3.Location = New System.Drawing.Point(512, 200)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(523, 47)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 48
        Me.PictureBox3.TabStop = False
        '
        'txt_dni
        '
        Me.txt_dni.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_dni.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dni.Location = New System.Drawing.Point(527, 56)
        Me.txt_dni.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(496, 22)
        Me.txt_dni.TabIndex = 49
        '
        'txt_nombre
        '
        Me.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(527, 132)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(496, 22)
        Me.txt_nombre.TabIndex = 49
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = Global.SistemaVentas2.My.Resources.Resources.form2
        Me.PictureBox2.Location = New System.Drawing.Point(512, 121)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(523, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.SistemaVentas2.My.Resources.Resources.form2
        Me.PictureBox1.Location = New System.Drawing.Point(512, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(523, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btn_agregarcliente)
        Me.Panel2.Controls.Add(Me.btn_mostrar_clientes)
        Me.Panel2.Controls.Add(Me.btn_eliminarcliente)
        Me.Panel2.Controls.Add(Me.btn_actualizarcliente)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1385, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(225, 1034)
        Me.Panel2.TabIndex = 51
        '
        'btn_agregarcliente
        '
        Me.btn_agregarcliente.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_agregarcliente.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.empleado
        Me.btn_agregarcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_agregarcliente.Location = New System.Drawing.Point(41, 184)
        Me.btn_agregarcliente.Name = "btn_agregarcliente"
        Me.btn_agregarcliente.Size = New System.Drawing.Size(150, 150)
        Me.btn_agregarcliente.TabIndex = 29
        Me.btn_agregarcliente.UseVisualStyleBackColor = True
        '
        'btn_mostrar_clientes
        '
        Me.btn_mostrar_clientes.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_mostrar_clientes.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.listar
        Me.btn_mostrar_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_mostrar_clientes.Location = New System.Drawing.Point(41, 703)
        Me.btn_mostrar_clientes.Name = "btn_mostrar_clientes"
        Me.btn_mostrar_clientes.Size = New System.Drawing.Size(150, 150)
        Me.btn_mostrar_clientes.TabIndex = 50
        Me.btn_mostrar_clientes.UseVisualStyleBackColor = True
        '
        'btn_eliminarcliente
        '
        Me.btn_eliminarcliente.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_eliminarcliente.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.eliminar_amigo
        Me.btn_eliminarcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_eliminarcliente.Location = New System.Drawing.Point(41, 350)
        Me.btn_eliminarcliente.Name = "btn_eliminarcliente"
        Me.btn_eliminarcliente.Size = New System.Drawing.Size(150, 150)
        Me.btn_eliminarcliente.TabIndex = 29
        Me.btn_eliminarcliente.UseVisualStyleBackColor = True
        '
        'btn_actualizarcliente
        '
        Me.btn_actualizarcliente.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_actualizarcliente.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.recargar
        Me.btn_actualizarcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_actualizarcliente.Location = New System.Drawing.Point(41, 529)
        Me.btn_actualizarcliente.Name = "btn_actualizarcliente"
        Me.btn_actualizarcliente.Size = New System.Drawing.Size(150, 150)
        Me.btn_actualizarcliente.TabIndex = 29
        Me.btn_actualizarcliente.UseVisualStyleBackColor = True
        '
        'tablaclientes
        '
        Me.tablaclientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tablaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaclientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.tablaclientes.Location = New System.Drawing.Point(325, 392)
        Me.tablaclientes.Name = "tablaclientes"
        Me.tablaclientes.RowHeadersWidth = 51
        Me.tablaclientes.RowTemplate.Height = 24
        Me.tablaclientes.Size = New System.Drawing.Size(710, 614)
        Me.tablaclientes.TabIndex = 30
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.MinimumWidth = 6
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Width = 125
        '
        'btn_buscarclientes
        '
        Me.btn_buscarclientes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_buscarclientes.BackColor = System.Drawing.Color.Transparent
        Me.btn_buscarclientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_buscarclientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscarclientes.Image = Global.SistemaVentas2.My.Resources.Resources.busqueda
        Me.btn_buscarclientes.Location = New System.Drawing.Point(1383, 4)
        Me.btn_buscarclientes.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_buscarclientes.Name = "btn_buscarclientes"
        Me.btn_buscarclientes.Size = New System.Drawing.Size(70, 38)
        Me.btn_buscarclientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_buscarclientes.TabIndex = 40
        Me.btn_buscarclientes.TabStop = False
        '
        'cb_dni
        '
        Me.cb_dni.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cb_dni.FormattingEnabled = True
        Me.cb_dni.Location = New System.Drawing.Point(1107, 12)
        Me.cb_dni.Name = "cb_dni"
        Me.cb_dni.Size = New System.Drawing.Size(255, 24)
        Me.cb_dni.TabIndex = 41
        '
        'AdministrarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1610, 1080)
        Me.Controls.Add(Me.cb_dni)
        Me.Controls.Add(Me.btn_buscarclientes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdministrarClientes"
        Me.Text = "AdministrarClientes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.tablaclientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_buscarclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministrarClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_actualizarcliente As System.Windows.Forms.Button
    Friend WithEvents btn_agregarcliente As System.Windows.Forms.Button
    Friend WithEvents btn_eliminarcliente As System.Windows.Forms.Button
    Friend WithEvents tablaclientes As System.Windows.Forms.DataGridView
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_dni As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_buscarclientes As System.Windows.Forms.PictureBox
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btn_mostrar_clientes As System.Windows.Forms.Button
    Friend WithEvents cb_dni As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
End Class
