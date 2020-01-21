<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarGanancias
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
        Me.AdministrarGananciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_mostrar_ganancias_seleccionable = New System.Windows.Forms.Button()
        Me.fecha_rango2 = New System.Windows.Forms.DateTimePicker()
        Me.r2ganancia = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.r1ganancia = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.fecha_dia = New System.Windows.Forms.DateTimePicker()
        Me.fecha_rango1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.label_ganancias = New System.Windows.Forms.Label()
        Me.btn_calcular_ganancias = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarGananciasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1095, 38)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministrarGananciasToolStripMenuItem
        '
        Me.AdministrarGananciasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministrarGananciasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AdministrarGananciasToolStripMenuItem.Name = "AdministrarGananciasToolStripMenuItem"
        Me.AdministrarGananciasToolStripMenuItem.Size = New System.Drawing.Size(259, 34)
        Me.AdministrarGananciasToolStripMenuItem.Text = "Administrar Ganancias"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.stroheim_montasio_ombre_haze_5405502_luxury_decor_fabric_pl_118816_e32
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btn_calcular_ganancias)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1095, 710)
        Me.Panel1.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btn_mostrar_ganancias_seleccionable)
        Me.Panel3.Controls.Add(Me.fecha_rango2)
        Me.Panel3.Controls.Add(Me.r2ganancia)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.r1ganancia)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.fecha_dia)
        Me.Panel3.Controls.Add(Me.fecha_rango1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1095, 254)
        Me.Panel3.TabIndex = 25
        '
        'btn_mostrar_ganancias_seleccionable
        '
        Me.btn_mostrar_ganancias_seleccionable.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_mostrar_ganancias_seleccionable.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.check_list
        Me.btn_mostrar_ganancias_seleccionable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_mostrar_ganancias_seleccionable.Location = New System.Drawing.Point(933, 62)
        Me.btn_mostrar_ganancias_seleccionable.Name = "btn_mostrar_ganancias_seleccionable"
        Me.btn_mostrar_ganancias_seleccionable.Size = New System.Drawing.Size(112, 122)
        Me.btn_mostrar_ganancias_seleccionable.TabIndex = 23
        Me.btn_mostrar_ganancias_seleccionable.UseVisualStyleBackColor = True
        '
        'fecha_rango2
        '
        Me.fecha_rango2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.fecha_rango2.Location = New System.Drawing.Point(673, 164)
        Me.fecha_rango2.Name = "fecha_rango2"
        Me.fecha_rango2.Size = New System.Drawing.Size(208, 20)
        Me.fecha_rango2.TabIndex = 21
        '
        'r2ganancia
        '
        Me.r2ganancia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.r2ganancia.AutoSize = True
        Me.r2ganancia.BackColor = System.Drawing.Color.Transparent
        Me.r2ganancia.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r2ganancia.Location = New System.Drawing.Point(203, 156)
        Me.r2ganancia.Name = "r2ganancia"
        Me.r2ganancia.Size = New System.Drawing.Size(147, 29)
        Me.r2ganancia.TabIndex = 14
        Me.r2ganancia.TabStop = True
        Me.r2ganancia.Text = "Rango de dia"
        Me.r2ganancia.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.SistemaVentas2.My.Resources.Resources.toma_de_decisiones
        Me.PictureBox2.Location = New System.Drawing.Point(591, 145)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'r1ganancia
        '
        Me.r1ganancia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.r1ganancia.AutoSize = True
        Me.r1ganancia.BackColor = System.Drawing.Color.Transparent
        Me.r1ganancia.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1ganancia.Location = New System.Drawing.Point(206, 64)
        Me.r1ganancia.Name = "r1ganancia"
        Me.r1ganancia.Size = New System.Drawing.Size(73, 29)
        Me.r1ganancia.TabIndex = 13
        Me.r1ganancia.TabStop = True
        Me.r1ganancia.Text = "1 dia"
        Me.r1ganancia.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SistemaVentas2.My.Resources.Resources.calendario
        Me.PictureBox1.Location = New System.Drawing.Point(591, 64)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'fecha_dia
        '
        Me.fecha_dia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.fecha_dia.Location = New System.Drawing.Point(365, 72)
        Me.fecha_dia.Name = "fecha_dia"
        Me.fecha_dia.Size = New System.Drawing.Size(205, 20)
        Me.fecha_dia.TabIndex = 12
        '
        'fecha_rango1
        '
        Me.fecha_rango1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.fecha_rango1.Location = New System.Drawing.Point(365, 164)
        Me.fecha_rango1.Name = "fecha_rango1"
        Me.fecha_rango1.Size = New System.Drawing.Size(208, 20)
        Me.fecha_rango1.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.barradecolorada1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.label_ganancias)
        Me.Panel2.Location = New System.Drawing.Point(523, 285)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(357, 251)
        Me.Panel2.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(2, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 41)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Ganancias totales"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.SistemaVentas2.My.Resources.Resources.dinero
        Me.PictureBox5.Location = New System.Drawing.Point(182, 0)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(176, 107)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'label_ganancias
        '
        Me.label_ganancias.AutoSize = True
        Me.label_ganancias.BackColor = System.Drawing.Color.Transparent
        Me.label_ganancias.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_ganancias.ForeColor = System.Drawing.Color.White
        Me.label_ganancias.Location = New System.Drawing.Point(13, 11)
        Me.label_ganancias.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label_ganancias.Name = "label_ganancias"
        Me.label_ganancias.Size = New System.Drawing.Size(166, 65)
        Me.label_ganancias.TabIndex = 23
        Me.label_ganancias.Text = "$ 45.0"
        '
        'btn_calcular_ganancias
        '
        Me.btn_calcular_ganancias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_calcular_ganancias.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.banco
        Me.btn_calcular_ganancias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_calcular_ganancias.Location = New System.Drawing.Point(206, 327)
        Me.btn_calcular_ganancias.Name = "btn_calcular_ganancias"
        Me.btn_calcular_ganancias.Size = New System.Drawing.Size(211, 152)
        Me.btn_calcular_ganancias.TabIndex = 19
        Me.btn_calcular_ganancias.UseVisualStyleBackColor = True
        '
        'ConsultarGanancias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 748)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ConsultarGanancias"
        Me.Text = "ConsultarGanancias"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents label_ganancias As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents fecha_rango1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecha_rango2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_calcular_ganancias As System.Windows.Forms.Button
    Friend WithEvents fecha_dia As System.Windows.Forms.DateTimePicker
    Friend WithEvents r1ganancia As System.Windows.Forms.RadioButton
    Friend WithEvents r2ganancia As System.Windows.Forms.RadioButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministrarGananciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_mostrar_ganancias_seleccionable As System.Windows.Forms.Button
End Class
