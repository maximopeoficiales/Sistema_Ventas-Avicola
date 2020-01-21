<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class panelprincipal2
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
        Me.PanelMenuInicio = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panel_con_botones = New System.Windows.Forms.Panel()
        Me.btn_registrar_venta = New System.Windows.Forms.Button()
        Me.btn_modificar_cliente = New System.Windows.Forms.Button()
        Me.btn_consultar_productos = New System.Windows.Forms.Button()
        Me.panel_contenedor_usuario = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label_usuario = New System.Windows.Forms.Label()
        Me.PanelMenuInicio.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_con_botones.SuspendLayout()
        Me.panel_contenedor_usuario.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PanelMenuInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMenuInicio.Name = "PanelMenuInicio"
        Me.PanelMenuInicio.Size = New System.Drawing.Size(1610, 1055)
        Me.PanelMenuInicio.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.SistemaVentas2.My.Resources.Resources.avicola
        Me.PictureBox2.Location = New System.Drawing.Point(211, 347)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1245, 603)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'panel_con_botones
        '
        Me.panel_con_botones.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panel_con_botones.BackColor = System.Drawing.Color.Transparent
        Me.panel_con_botones.Controls.Add(Me.btn_registrar_venta)
        Me.panel_con_botones.Controls.Add(Me.btn_modificar_cliente)
        Me.panel_con_botones.Controls.Add(Me.btn_consultar_productos)
        Me.panel_con_botones.Location = New System.Drawing.Point(297, 100)
        Me.panel_con_botones.Name = "panel_con_botones"
        Me.panel_con_botones.Padding = New System.Windows.Forms.Padding(2)
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
        Me.btn_registrar_venta.Padding = New System.Windows.Forms.Padding(2)
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
        Me.btn_modificar_cliente.Padding = New System.Windows.Forms.Padding(2)
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
        Me.btn_consultar_productos.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_consultar_productos.Size = New System.Drawing.Size(266, 134)
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
        Me.panel_contenedor_usuario.Name = "panel_contenedor_usuario"
        Me.panel_contenedor_usuario.Size = New System.Drawing.Size(1610, 100)
        Me.panel_contenedor_usuario.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SistemaVentas2.My.Resources.Resources.estudiante
        Me.PictureBox1.Location = New System.Drawing.Point(14, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 74)
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
        Me.label_usuario.Location = New System.Drawing.Point(110, 26)
        Me.label_usuario.Name = "label_usuario"
        Me.label_usuario.Size = New System.Drawing.Size(158, 51)
        Me.label_usuario.TabIndex = 24
        Me.label_usuario.Text = "Usuario"
        '
        'panelprincipal2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1610, 1080)
        Me.Controls.Add(Me.PanelMenuInicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "panelprincipal2"
        Me.Text = "panelprincipal2"
        Me.PanelMenuInicio.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_con_botones.ResumeLayout(False)
        Me.panel_contenedor_usuario.ResumeLayout(False)
        Me.panel_contenedor_usuario.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenuInicio As Panel
    Friend WithEvents panel_con_botones As Panel
    Friend WithEvents btn_registrar_venta As Button
    Friend WithEvents btn_modificar_cliente As Button
    Friend WithEvents btn_consultar_productos As Button
    Friend WithEvents panel_contenedor_usuario As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents label_usuario As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
