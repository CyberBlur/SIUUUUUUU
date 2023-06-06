<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnempleadonuevo = New System.Windows.Forms.Button()
        Me.btnempleadoeditar = New System.Windows.Forms.Button()
        Me.dg_empleados = New System.Windows.Forms.DataGridView()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.dg_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.Button1)
        Me.pnlTitulo.Controls.Add(Me.Label1)
        Me.pnlTitulo.Location = New System.Drawing.Point(1, 1)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(833, 42)
        Me.pnlTitulo.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(3, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Listado de Empleados"
        '
        'btnempleadonuevo
        '
        Me.btnempleadonuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnempleadonuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnempleadonuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnempleadonuevo.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnempleadonuevo.ForeColor = System.Drawing.Color.White
        Me.btnempleadonuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnempleadonuevo.Location = New System.Drawing.Point(625, 61)
        Me.btnempleadonuevo.Name = "btnempleadonuevo"
        Me.btnempleadonuevo.Size = New System.Drawing.Size(197, 47)
        Me.btnempleadonuevo.TabIndex = 23
        Me.btnempleadonuevo.Text = "Nuevo Empleado"
        Me.btnempleadonuevo.UseVisualStyleBackColor = False
        '
        'btnempleadoeditar
        '
        Me.btnempleadoeditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnempleadoeditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnempleadoeditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnempleadoeditar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnempleadoeditar.ForeColor = System.Drawing.Color.White
        Me.btnempleadoeditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnempleadoeditar.Location = New System.Drawing.Point(625, 124)
        Me.btnempleadoeditar.Name = "btnempleadoeditar"
        Me.btnempleadoeditar.Size = New System.Drawing.Size(197, 47)
        Me.btnempleadoeditar.TabIndex = 24
        Me.btnempleadoeditar.Text = "Editar Empleado"
        Me.btnempleadoeditar.UseVisualStyleBackColor = False
        '
        'dg_empleados
        '
        Me.dg_empleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_empleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_empleados.BackgroundColor = System.Drawing.Color.White
        Me.dg_empleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_empleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dg_empleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_empleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_empleados.EnableHeadersVisualStyles = False
        Me.dg_empleados.GridColor = System.Drawing.Color.SteelBlue
        Me.dg_empleados.Location = New System.Drawing.Point(12, 61)
        Me.dg_empleados.Name = "dg_empleados"
        Me.dg_empleados.ReadOnly = True
        Me.dg_empleados.RowHeadersVisible = False
        Me.dg_empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_empleados.Size = New System.Drawing.Size(607, 454)
        Me.dg_empleados.TabIndex = 25
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(834, 571)
        Me.Controls.Add(Me.dg_empleados)
        Me.Controls.Add(Me.btnempleadoeditar)
        Me.Controls.Add(Me.btnempleadonuevo)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        CType(Me.dg_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents Button1 As Button
    Private WithEvents Label1 As Label
    Private WithEvents btnempleadonuevo As Button
    Private WithEvents btnempleadoeditar As Button
    Private WithEvents dg_empleados As DataGridView
End Class
