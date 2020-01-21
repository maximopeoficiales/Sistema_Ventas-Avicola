<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaProductos
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
        Me.btn_eliminar_producto = New System.Windows.Forms.Button()
        Me.btn_atras = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabla_productos = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.tabla_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.stroheim_montasio_ombre_haze_5405502_luxury_decor_fabric_pl_118816_e32
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btn_eliminar_producto)
        Me.Panel1.Controls.Add(Me.btn_atras)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tabla_productos)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(914, 521)
        Me.Panel1.TabIndex = 2
        '
        'btn_eliminar_producto
        '
        Me.btn_eliminar_producto.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.borrar_amigo
        Me.btn_eliminar_producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_eliminar_producto.Location = New System.Drawing.Point(805, 12)
        Me.btn_eliminar_producto.Name = "btn_eliminar_producto"
        Me.btn_eliminar_producto.Size = New System.Drawing.Size(59, 51)
        Me.btn_eliminar_producto.TabIndex = 48
        Me.btn_eliminar_producto.UseVisualStyleBackColor = True
        '
        'btn_atras
        '
        Me.btn_atras.BackgroundImage = Global.SistemaVentas2.My.Resources.Resources.atras
        Me.btn_atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_atras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_atras.Location = New System.Drawing.Point(43, 14)
        Me.btn_atras.Name = "btn_atras"
        Me.btn_atras.Size = New System.Drawing.Size(64, 46)
        Me.btn_atras.TabIndex = 25
        Me.btn_atras.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(292, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(350, 51)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Lista de Productos"
        '
        'tabla_productos
        '
        Me.tabla_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.tabla_productos.Location = New System.Drawing.Point(43, 88)
        Me.tabla_productos.Name = "tabla_productos"
        Me.tabla_productos.RowHeadersWidth = 51
        Me.tabla_productos.RowTemplate.Height = 24
        Me.tabla_productos.Size = New System.Drawing.Size(831, 393)
        Me.tabla_productos.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.MinimumWidth = 6
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Width = 125
        '
        'ListaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 512)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ListaProductos"
        Me.Text = "ListaProductos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tabla_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_atras As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tabla_productos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_eliminar_producto As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
