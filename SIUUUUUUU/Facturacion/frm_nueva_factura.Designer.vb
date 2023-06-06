<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_nueva_factura
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
        Me.lbl_frm_nueva_factura = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_descuento = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.btn_agregar_lista = New System.Windows.Forms.Button()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.btn_facturar = New System.Windows.Forms.Button()
        Me.txt_paciente = New System.Windows.Forms.TextBox()
        Me.txt_examen_medico = New System.Windows.Forms.TextBox()
        Me.btn_cancelar_factura = New System.Windows.Forms.Button()
        Me.lbl_descuento = New System.Windows.Forms.Label()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.lbl_paciente = New System.Windows.Forms.Label()
        Me.lbl_examen_medico = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_frm_nueva_factura)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 44)
        Me.Panel1.TabIndex = 0
        '
        'lbl_frm_nueva_factura
        '
        Me.lbl_frm_nueva_factura.AutoSize = True
        Me.lbl_frm_nueva_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_frm_nueva_factura.ForeColor = System.Drawing.Color.White
        Me.lbl_frm_nueva_factura.Location = New System.Drawing.Point(13, 10)
        Me.lbl_frm_nueva_factura.Name = "lbl_frm_nueva_factura"
        Me.lbl_frm_nueva_factura.Size = New System.Drawing.Size(153, 25)
        Me.lbl_frm_nueva_factura.TabIndex = 0
        Me.lbl_frm_nueva_factura.Text = "Nueva Factura"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txt_descuento)
        Me.Panel2.Controls.Add(Me.txt_precio)
        Me.Panel2.Controls.Add(Me.btn_agregar_lista)
        Me.Panel2.Controls.Add(Me.txt_cantidad)
        Me.Panel2.Controls.Add(Me.btn_facturar)
        Me.Panel2.Controls.Add(Me.txt_paciente)
        Me.Panel2.Controls.Add(Me.txt_examen_medico)
        Me.Panel2.Controls.Add(Me.btn_cancelar_factura)
        Me.Panel2.Controls.Add(Me.lbl_descuento)
        Me.Panel2.Controls.Add(Me.lbl_precio)
        Me.Panel2.Controls.Add(Me.lbl_cantidad)
        Me.Panel2.Controls.Add(Me.lbl_paciente)
        Me.Panel2.Controls.Add(Me.lbl_examen_medico)
        Me.Panel2.Location = New System.Drawing.Point(0, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(291, 411)
        Me.Panel2.TabIndex = 1
        '
        'txt_descuento
        '
        Me.txt_descuento.Location = New System.Drawing.Point(16, 247)
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.Size = New System.Drawing.Size(259, 20)
        Me.txt_descuento.TabIndex = 13
        Me.txt_descuento.Text = "0"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(16, 192)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(259, 20)
        Me.txt_precio.TabIndex = 12
        Me.txt_precio.Text = "0"
        '
        'btn_agregar_lista
        '
        Me.btn_agregar_lista.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_agregar_lista.FlatAppearance.BorderSize = 0
        Me.btn_agregar_lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar_lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_lista.ForeColor = System.Drawing.Color.White
        Me.btn_agregar_lista.Location = New System.Drawing.Point(54, 282)
        Me.btn_agregar_lista.Name = "btn_agregar_lista"
        Me.btn_agregar_lista.Size = New System.Drawing.Size(181, 34)
        Me.btn_agregar_lista.TabIndex = 6
        Me.btn_agregar_lista.Text = "Agregar a la lista"
        Me.btn_agregar_lista.UseVisualStyleBackColor = False
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(16, 137)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(259, 20)
        Me.txt_cantidad.TabIndex = 11
        Me.txt_cantidad.Text = "0"
        '
        'btn_facturar
        '
        Me.btn_facturar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_facturar.FlatAppearance.BorderSize = 0
        Me.btn_facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_facturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_facturar.ForeColor = System.Drawing.Color.White
        Me.btn_facturar.Location = New System.Drawing.Point(54, 322)
        Me.btn_facturar.Name = "btn_facturar"
        Me.btn_facturar.Size = New System.Drawing.Size(181, 34)
        Me.btn_facturar.TabIndex = 7
        Me.btn_facturar.Text = "Facturar"
        Me.btn_facturar.UseVisualStyleBackColor = False
        '
        'txt_paciente
        '
        Me.txt_paciente.Location = New System.Drawing.Point(17, 82)
        Me.txt_paciente.Name = "txt_paciente"
        Me.txt_paciente.Size = New System.Drawing.Size(258, 20)
        Me.txt_paciente.TabIndex = 10
        '
        'txt_examen_medico
        '
        Me.txt_examen_medico.Location = New System.Drawing.Point(17, 27)
        Me.txt_examen_medico.Name = "txt_examen_medico"
        Me.txt_examen_medico.Size = New System.Drawing.Size(258, 20)
        Me.txt_examen_medico.TabIndex = 9
        '
        'btn_cancelar_factura
        '
        Me.btn_cancelar_factura.BackColor = System.Drawing.Color.Red
        Me.btn_cancelar_factura.FlatAppearance.BorderSize = 0
        Me.btn_cancelar_factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar_factura.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar_factura.Location = New System.Drawing.Point(54, 362)
        Me.btn_cancelar_factura.Name = "btn_cancelar_factura"
        Me.btn_cancelar_factura.Size = New System.Drawing.Size(181, 34)
        Me.btn_cancelar_factura.TabIndex = 8
        Me.btn_cancelar_factura.Text = "Cancelar Factura"
        Me.btn_cancelar_factura.UseVisualStyleBackColor = False
        '
        'lbl_descuento
        '
        Me.lbl_descuento.AutoSize = True
        Me.lbl_descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descuento.ForeColor = System.Drawing.Color.White
        Me.lbl_descuento.Location = New System.Drawing.Point(13, 224)
        Me.lbl_descuento.Name = "lbl_descuento"
        Me.lbl_descuento.Size = New System.Drawing.Size(87, 20)
        Me.lbl_descuento.TabIndex = 5
        Me.lbl_descuento.Text = "Descuento"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio.ForeColor = System.Drawing.Color.White
        Me.lbl_precio.Location = New System.Drawing.Point(13, 169)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(53, 20)
        Me.lbl_precio.TabIndex = 4
        Me.lbl_precio.Text = "Precio"
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cantidad.ForeColor = System.Drawing.Color.White
        Me.lbl_cantidad.Location = New System.Drawing.Point(13, 114)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(73, 20)
        Me.lbl_cantidad.TabIndex = 3
        Me.lbl_cantidad.Text = "Cantidad"
        '
        'lbl_paciente
        '
        Me.lbl_paciente.AutoSize = True
        Me.lbl_paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_paciente.ForeColor = System.Drawing.Color.White
        Me.lbl_paciente.Location = New System.Drawing.Point(13, 59)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(71, 20)
        Me.lbl_paciente.TabIndex = 2
        Me.lbl_paciente.Text = "Paciente"
        '
        'lbl_examen_medico
        '
        Me.lbl_examen_medico.AutoSize = True
        Me.lbl_examen_medico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_examen_medico.ForeColor = System.Drawing.Color.White
        Me.lbl_examen_medico.Location = New System.Drawing.Point(13, 4)
        Me.lbl_examen_medico.Name = "lbl_examen_medico"
        Me.lbl_examen_medico.Size = New System.Drawing.Size(122, 20)
        Me.lbl_examen_medico.TabIndex = 1
        Me.lbl_examen_medico.Text = "Examen Médico"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(298, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(490, 388)
        Me.DataGridView1.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre del Examen"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Precio"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Descuento"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Eliminar"
        Me.Column5.Name = "Column5"
        '
        'frm_nueva_factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_nueva_factura"
        Me.Text = "frm_nueva_factura"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_frm_nueva_factura As Label
    Friend WithEvents txt_descuento As TextBox
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents btn_agregar_lista As Button
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents btn_facturar As Button
    Friend WithEvents txt_paciente As TextBox
    Friend WithEvents txt_examen_medico As TextBox
    Friend WithEvents btn_cancelar_factura As Button
    Friend WithEvents lbl_descuento As Label
    Friend WithEvents lbl_precio As Label
    Friend WithEvents lbl_cantidad As Label
    Friend WithEvents lbl_paciente As Label
    Friend WithEvents lbl_examen_medico As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
