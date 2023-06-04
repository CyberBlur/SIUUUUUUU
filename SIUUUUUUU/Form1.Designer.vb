<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnpacientes = New System.Windows.Forms.Button()
        Me.btncatalogo = New System.Windows.Forms.Button()
        Me.btnfacturacion = New System.Windows.Forms.Button()
        Me.btnempleados = New System.Windows.Forms.Button()
        Me.btnusuarios = New System.Windows.Forms.Button()
        Me.btnreportes = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 41)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(284, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Laboratorios Clinicos de Oriente"
        '
        'btnpacientes
        '
        Me.btnpacientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnpacientes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpacientes.ForeColor = System.Drawing.Color.White
        Me.btnpacientes.Location = New System.Drawing.Point(27, 44)
        Me.btnpacientes.Name = "btnpacientes"
        Me.btnpacientes.Size = New System.Drawing.Size(170, 90)
        Me.btnpacientes.TabIndex = 1
        Me.btnpacientes.Text = "Pacientes"
        Me.btnpacientes.UseVisualStyleBackColor = False
        '
        'btncatalogo
        '
        Me.btncatalogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btncatalogo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btncatalogo.ForeColor = System.Drawing.Color.White
        Me.btncatalogo.Location = New System.Drawing.Point(287, 44)
        Me.btncatalogo.Name = "btncatalogo"
        Me.btncatalogo.Size = New System.Drawing.Size(170, 90)
        Me.btncatalogo.TabIndex = 2
        Me.btncatalogo.Text = "Catalogo de examenes"
        Me.btncatalogo.UseVisualStyleBackColor = False
        '
        'btnfacturacion
        '
        Me.btnfacturacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnfacturacion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfacturacion.ForeColor = System.Drawing.Color.White
        Me.btnfacturacion.Location = New System.Drawing.Point(544, 44)
        Me.btnfacturacion.Name = "btnfacturacion"
        Me.btnfacturacion.Size = New System.Drawing.Size(170, 90)
        Me.btnfacturacion.TabIndex = 3
        Me.btnfacturacion.Text = "Facturación"
        Me.btnfacturacion.UseVisualStyleBackColor = False
        '
        'btnempleados
        '
        Me.btnempleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnempleados.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnempleados.ForeColor = System.Drawing.Color.White
        Me.btnempleados.Location = New System.Drawing.Point(27, 204)
        Me.btnempleados.Name = "btnempleados"
        Me.btnempleados.Size = New System.Drawing.Size(170, 90)
        Me.btnempleados.TabIndex = 4
        Me.btnempleados.Text = "Empleados"
        Me.btnempleados.UseVisualStyleBackColor = False
        '
        'btnusuarios
        '
        Me.btnusuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnusuarios.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnusuarios.ForeColor = System.Drawing.Color.White
        Me.btnusuarios.Location = New System.Drawing.Point(287, 204)
        Me.btnusuarios.Name = "btnusuarios"
        Me.btnusuarios.Size = New System.Drawing.Size(170, 90)
        Me.btnusuarios.TabIndex = 5
        Me.btnusuarios.Text = "Usuarios"
        Me.btnusuarios.UseVisualStyleBackColor = False
        '
        'btnreportes
        '
        Me.btnreportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnreportes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreportes.ForeColor = System.Drawing.Color.White
        Me.btnreportes.Location = New System.Drawing.Point(544, 204)
        Me.btnreportes.Name = "btnreportes"
        Me.btnreportes.Size = New System.Drawing.Size(170, 90)
        Me.btnreportes.TabIndex = 6
        Me.btnreportes.Text = "Reportes"
        Me.btnreportes.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnreportes)
        Me.GroupBox1.Controls.Add(Me.btnusuarios)
        Me.GroupBox1.Controls.Add(Me.btnempleados)
        Me.GroupBox1.Controls.Add(Me.btnfacturacion)
        Me.GroupBox1.Controls.Add(Me.btncatalogo)
        Me.GroupBox1.Controls.Add(Me.btnpacientes)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(738, 330)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(834, 571)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnpacientes As Button
    Friend WithEvents btncatalogo As Button
    Friend WithEvents btnfacturacion As Button
    Friend WithEvents btnempleados As Button
    Friend WithEvents btnusuarios As Button
    Friend WithEvents btnreportes As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
