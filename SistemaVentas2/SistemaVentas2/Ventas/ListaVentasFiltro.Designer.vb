<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaVentasFiltro
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
        Me.btn_buscar_dni = New System.Windows.Forms.PictureBox()
        Me.txt_dni_compra = New System.Windows.Forms.TextBox()
        Me.btn_atras = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabla_ventas = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_buscar_dni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabla_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.stroheim_montasio_ombre_haze_5405502_luxury_decor_fabric_pl_118816_e32
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_buscar_dni)
        Me.Panel1.Controls.Add(Me.txt_dni_compra)
        Me.Panel1.Controls.Add(Me.btn_atras)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tabla_ventas)
        Me.Panel1.Location = New System.Drawing.Point(-2, -13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1157, 618)
        Me.Panel1.TabIndex = 2
        '
        'btn_buscar_dni
        '
        Me.btn_buscar_dni.BackColor = System.Drawing.Color.Transparent
        Me.btn_buscar_dni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_buscar_dni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscar_dni.Image = Global.SistemaVentas2.My.Resources.Resources.busqueda
        Me.btn_buscar_dni.Location = New System.Drawing.Point(1059, 23)
        Me.btn_buscar_dni.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_buscar_dni.Name = "btn_buscar_dni"
        Me.btn_buscar_dni.Size = New System.Drawing.Size(64, 52)
        Me.btn_buscar_dni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_buscar_dni.TabIndex = 41
        Me.btn_buscar_dni.TabStop = False
        '
        'txt_dni_compra
        '
        Me.txt_dni_compra.Location = New System.Drawing.Point(744, 47)
        Me.txt_dni_compra.Name = "txt_dni_compra"
        Me.txt_dni_compra.Size = New System.Drawing.Size(308, 22)
        Me.txt_dni_compra.TabIndex = 27
        '
        'btn_atras
        '
        Me.btn_atras.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.atras
        Me.btn_atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_atras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_atras.Location = New System.Drawing.Point(33, 23)
        Me.btn_atras.Name = "btn_atras"
        Me.btn_atras.Size = New System.Drawing.Size(64, 52)
        Me.btn_atras.TabIndex = 26
        Me.btn_atras.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(121, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(616, 51)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Lista de Ventas Registradas-Filtro"
        '
        'tabla_ventas
        '
        Me.tabla_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_ventas.Location = New System.Drawing.Point(33, 100)
        Me.tabla_ventas.Name = "tabla_ventas"
        Me.tabla_ventas.RowHeadersWidth = 51
        Me.tabla_ventas.RowTemplate.Height = 24
        Me.tabla_ventas.Size = New System.Drawing.Size(1090, 452)
        Me.tabla_ventas.TabIndex = 0
        '
        'ListaVentasFiltro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 592)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ListaVentasFiltro"
        Me.Text = "ListaVentaFiltro"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_buscar_dni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabla_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_buscar_dni As PictureBox
    Friend WithEvents txt_dni_compra As TextBox
    Friend WithEvents btn_atras As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tabla_ventas As DataGridView
End Class
