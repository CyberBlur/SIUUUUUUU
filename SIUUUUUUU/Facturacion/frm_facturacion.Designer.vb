<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_facturacion
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
        Me.pnl_frm_facturacion1 = New System.Windows.Forms.Panel()
        Me.lbl_frm_facturacion1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_frm_facturacion1 = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_frm_facturacion1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_frm_facturacion1
        '
        Me.pnl_frm_facturacion1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnl_frm_facturacion1.Controls.Add(Me.lbl_frm_facturacion1)
        Me.pnl_frm_facturacion1.Location = New System.Drawing.Point(0, 0)
        Me.pnl_frm_facturacion1.Name = "pnl_frm_facturacion1"
        Me.pnl_frm_facturacion1.Size = New System.Drawing.Size(800, 41)
        Me.pnl_frm_facturacion1.TabIndex = 0
        '
        'lbl_frm_facturacion1
        '
        Me.lbl_frm_facturacion1.AutoSize = True
        Me.lbl_frm_facturacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_frm_facturacion1.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_frm_facturacion1.Location = New System.Drawing.Point(12, 9)
        Me.lbl_frm_facturacion1.Name = "lbl_frm_facturacion1"
        Me.lbl_frm_facturacion1.Size = New System.Drawing.Size(125, 25)
        Me.lbl_frm_facturacion1.TabIndex = 0
        Me.lbl_frm_facturacion1.Text = "Facturación"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 335)
        Me.DataGridView1.TabIndex = 1
        '
        'btn_frm_facturacion1
        '
        Me.btn_frm_facturacion1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_frm_facturacion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_frm_facturacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_frm_facturacion1.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_frm_facturacion1.Location = New System.Drawing.Point(12, 388)
        Me.btn_frm_facturacion1.Name = "btn_frm_facturacion1"
        Me.btn_frm_facturacion1.Size = New System.Drawing.Size(196, 50)
        Me.btn_frm_facturacion1.TabIndex = 2
        Me.btn_frm_facturacion1.Text = "Nueva Factura"
        Me.btn_frm_facturacion1.UseVisualStyleBackColor = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Fecha de Facturación"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Paciente"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Empleado"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Subtotal"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "ISV"
        Me.Column6.Name = "Column6"
        '
        'frm_facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_frm_facturacion1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pnl_frm_facturacion1)
        Me.Name = "frm_facturacion"
        Me.Text = "frm_facturacion"
        Me.pnl_frm_facturacion1.ResumeLayout(False)
        Me.pnl_frm_facturacion1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_frm_facturacion1 As Panel
    Friend WithEvents lbl_frm_facturacion1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_frm_facturacion1 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
