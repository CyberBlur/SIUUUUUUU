<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pacientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.iconButton3 = New System.Windows.Forms.Button()
        Me.iconButton2 = New System.Windows.Forms.Button()
        Me.dg_pacientes = New System.Windows.Forms.DataGridView()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.dg_pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlTitulo.TabIndex = 2
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
        Me.Label1.Size = New System.Drawing.Size(233, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Listadoo de Pacientes"
        '
        'iconButton3
        '
        Me.iconButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconButton3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.iconButton3.ForeColor = System.Drawing.Color.White
        Me.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconButton3.Location = New System.Drawing.Point(625, 60)
        Me.iconButton3.Name = "iconButton3"
        Me.iconButton3.Size = New System.Drawing.Size(197, 47)
        Me.iconButton3.TabIndex = 22
        Me.iconButton3.Text = "Nuevo Paciente"
        Me.iconButton3.UseVisualStyleBackColor = False
        '
        'iconButton2
        '
        Me.iconButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconButton2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.iconButton2.ForeColor = System.Drawing.Color.White
        Me.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconButton2.Location = New System.Drawing.Point(625, 123)
        Me.iconButton2.Name = "iconButton2"
        Me.iconButton2.Size = New System.Drawing.Size(197, 47)
        Me.iconButton2.TabIndex = 23
        Me.iconButton2.Text = "Editar Paciente"
        Me.iconButton2.UseVisualStyleBackColor = False
        '
        'dg_pacientes
        '
        Me.dg_pacientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_pacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_pacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_pacientes.BackgroundColor = System.Drawing.Color.White
        Me.dg_pacientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_pacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dg_pacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_pacientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_pacientes.EnableHeadersVisualStyles = False
        Me.dg_pacientes.GridColor = System.Drawing.Color.SteelBlue
        Me.dg_pacientes.Location = New System.Drawing.Point(12, 60)
        Me.dg_pacientes.Name = "dg_pacientes"
        Me.dg_pacientes.ReadOnly = True
        Me.dg_pacientes.RowHeadersVisible = False
        Me.dg_pacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_pacientes.Size = New System.Drawing.Size(607, 454)
        Me.dg_pacientes.TabIndex = 24
        '
        'Pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(834, 571)
        Me.Controls.Add(Me.dg_pacientes)
        Me.Controls.Add(Me.iconButton2)
        Me.Controls.Add(Me.iconButton3)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Name = "Pacientes"
        Me.Text = "Pacientes"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        CType(Me.dg_pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents Button1 As Button
    Private WithEvents Label1 As Label
    Private WithEvents iconButton3 As Button
    Private WithEvents iconButton2 As Button
    Private WithEvents dg_pacientes As DataGridView
End Class
