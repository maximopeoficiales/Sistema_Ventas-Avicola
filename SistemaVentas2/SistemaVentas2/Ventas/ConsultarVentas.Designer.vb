<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultarVentas
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConsultarVentrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel_accesorios = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.label_ventas_totales = New System.Windows.Forms.Label()
        Me.btn_listar_todo = New System.Windows.Forms.Button()
        Me.PanelContenedorFechas = New System.Windows.Forms.Panel()
        Me.btn_mostrar_ventas_seleccionable = New System.Windows.Forms.Button()
        Me.fecha_rango2 = New System.Windows.Forms.DateTimePicker()
        Me.rb_rango_de_dia = New System.Windows.Forms.RadioButton()
        Me.rb_un_dia = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.fecha_1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.fecha_rango1 = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel_accesorios.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedorFechas.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarVentrasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1095, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConsultarVentrasToolStripMenuItem
        '
        Me.ConsultarVentrasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsultarVentrasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ConsultarVentrasToolStripMenuItem.Name = "ConsultarVentrasToolStripMenuItem"
        Me.ConsultarVentrasToolStripMenuItem.Size = New System.Drawing.Size(174, 29)
        Me.ConsultarVentrasToolStripMenuItem.Text = "Consultar Ventas"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.stroheim_montasio_ombre_haze_5405502_luxury_decor_fabric_pl_118816_e32
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel_accesorios)
        Me.Panel1.Controls.Add(Me.PanelContenedorFechas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1095, 715)
        Me.Panel1.TabIndex = 23
        '
        'Panel_accesorios
        '
        Me.Panel_accesorios.BackColor = System.Drawing.Color.Transparent
        Me.Panel_accesorios.Controls.Add(Me.Panel2)
        Me.Panel_accesorios.Controls.Add(Me.btn_listar_todo)
        Me.Panel_accesorios.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_accesorios.Location = New System.Drawing.Point(0, 249)
        Me.Panel_accesorios.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_accesorios.Name = "Panel_accesorios"
        Me.Panel_accesorios.Size = New System.Drawing.Size(1095, 322)
        Me.Panel_accesorios.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.barraverde1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.label_ventas_totales)
        Me.Panel2.Location = New System.Drawing.Point(203, 37)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(375, 253)
        Me.Panel2.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 41)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Ventas Totales"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.SistemaVentas2.My.Resources.Resources.compras
        Me.PictureBox5.Location = New System.Drawing.Point(200, 2)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(176, 107)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'label_ventas_totales
        '
        Me.label_ventas_totales.AutoSize = True
        Me.label_ventas_totales.BackColor = System.Drawing.Color.Transparent
        Me.label_ventas_totales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label_ventas_totales.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_ventas_totales.ForeColor = System.Drawing.Color.White
        Me.label_ventas_totales.Location = New System.Drawing.Point(2, 11)
        Me.label_ventas_totales.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label_ventas_totales.Name = "label_ventas_totales"
        Me.label_ventas_totales.Size = New System.Drawing.Size(112, 65)
        Me.label_ventas_totales.TabIndex = 23
        Me.label_ventas_totales.Text = "120"
        '
        'btn_listar_todo
        '
        Me.btn_listar_todo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_listar_todo.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.listar2
        Me.btn_listar_todo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_listar_todo.Location = New System.Drawing.Point(789, 173)
        Me.btn_listar_todo.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_listar_todo.Name = "btn_listar_todo"
        Me.btn_listar_todo.Size = New System.Drawing.Size(112, 122)
        Me.btn_listar_todo.TabIndex = 25
        Me.btn_listar_todo.UseVisualStyleBackColor = True
        '
        'PanelContenedorFechas
        '
        Me.PanelContenedorFechas.BackColor = System.Drawing.Color.Transparent
        Me.PanelContenedorFechas.Controls.Add(Me.btn_mostrar_ventas_seleccionable)
        Me.PanelContenedorFechas.Controls.Add(Me.fecha_rango2)
        Me.PanelContenedorFechas.Controls.Add(Me.rb_rango_de_dia)
        Me.PanelContenedorFechas.Controls.Add(Me.rb_un_dia)
        Me.PanelContenedorFechas.Controls.Add(Me.PictureBox2)
        Me.PanelContenedorFechas.Controls.Add(Me.fecha_1)
        Me.PanelContenedorFechas.Controls.Add(Me.PictureBox1)
        Me.PanelContenedorFechas.Controls.Add(Me.fecha_rango1)
        Me.PanelContenedorFechas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelContenedorFechas.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedorFechas.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelContenedorFechas.Name = "PanelContenedorFechas"
        Me.PanelContenedorFechas.Size = New System.Drawing.Size(1095, 249)
        Me.PanelContenedorFechas.TabIndex = 26
        '
        'btn_mostrar_ventas_seleccionable
        '
        Me.btn_mostrar_ventas_seleccionable.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_mostrar_ventas_seleccionable.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.check_list
        Me.btn_mostrar_ventas_seleccionable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_mostrar_ventas_seleccionable.Location = New System.Drawing.Point(775, 12)
        Me.btn_mostrar_ventas_seleccionable.Name = "btn_mostrar_ventas_seleccionable"
        Me.btn_mostrar_ventas_seleccionable.Size = New System.Drawing.Size(112, 122)
        Me.btn_mostrar_ventas_seleccionable.TabIndex = 19
        Me.btn_mostrar_ventas_seleccionable.UseVisualStyleBackColor = True
        '
        'fecha_rango2
        '
        Me.fecha_rango2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.fecha_rango2.Location = New System.Drawing.Point(695, 162)
        Me.fecha_rango2.Name = "fecha_rango2"
        Me.fecha_rango2.Size = New System.Drawing.Size(208, 20)
        Me.fecha_rango2.TabIndex = 21
        '
        'rb_rango_de_dia
        '
        Me.rb_rango_de_dia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rb_rango_de_dia.AutoSize = True
        Me.rb_rango_de_dia.BackColor = System.Drawing.Color.Transparent
        Me.rb_rango_de_dia.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_rango_de_dia.Location = New System.Drawing.Point(203, 149)
        Me.rb_rango_de_dia.Name = "rb_rango_de_dia"
        Me.rb_rango_de_dia.Size = New System.Drawing.Size(184, 36)
        Me.rb_rango_de_dia.TabIndex = 14
        Me.rb_rango_de_dia.TabStop = True
        Me.rb_rango_de_dia.Text = "Rango de dia"
        Me.rb_rango_de_dia.UseVisualStyleBackColor = False
        '
        'rb_un_dia
        '
        Me.rb_un_dia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rb_un_dia.AutoSize = True
        Me.rb_un_dia.BackColor = System.Drawing.Color.Transparent
        Me.rb_un_dia.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_un_dia.Location = New System.Drawing.Point(203, 49)
        Me.rb_un_dia.Name = "rb_un_dia"
        Me.rb_un_dia.Size = New System.Drawing.Size(89, 36)
        Me.rb_un_dia.TabIndex = 13
        Me.rb_un_dia.TabStop = True
        Me.rb_un_dia.Text = "1 dia"
        Me.rb_un_dia.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.SistemaVentas2.My.Resources.Resources.toma_de_decisiones
        Me.PictureBox2.Location = New System.Drawing.Point(599, 131)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(82, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'fecha_1
        '
        Me.fecha_1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.fecha_1.Location = New System.Drawing.Point(373, 49)
        Me.fecha_1.Name = "fecha_1"
        Me.fecha_1.Size = New System.Drawing.Size(205, 20)
        Me.fecha_1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SistemaVentas2.My.Resources.Resources.calendario
        Me.PictureBox1.Location = New System.Drawing.Point(606, 24)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'fecha_rango1
        '
        Me.fecha_rango1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.fecha_rango1.Location = New System.Drawing.Point(386, 162)
        Me.fecha_rango1.Name = "fecha_rango1"
        Me.fecha_rango1.Size = New System.Drawing.Size(208, 20)
        Me.fecha_rango1.TabIndex = 21
        '
        'ConsultarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 748)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ConsultarVentas"
        Me.Text = "ConsultarVentas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel_accesorios.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedorFechas.ResumeLayout(False)
        Me.PanelContenedorFechas.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConsultarVentrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents label_ventas_totales As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents fecha_rango1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecha_rango2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_mostrar_ventas_seleccionable As System.Windows.Forms.Button
    Friend WithEvents fecha_1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents rb_un_dia As System.Windows.Forms.RadioButton
    Friend WithEvents rb_rango_de_dia As System.Windows.Forms.RadioButton
    Friend WithEvents btn_listar_todo As Button
    Friend WithEvents Panel_accesorios As Panel
    Friend WithEvents PanelContenedorFechas As Panel
End Class
