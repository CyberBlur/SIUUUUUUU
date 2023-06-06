<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editar_empleado
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
        Me.btncancel_edit_empleado = New System.Windows.Forms.Button()
        Me.btnguardar_emple_nuevo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtempleadotelef = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdireccionempleado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtempleadoapellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtempleadonombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncancel_edit_empleado
        '
        Me.btncancel_edit_empleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancel_edit_empleado.BackColor = System.Drawing.Color.Red
        Me.btncancel_edit_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel_edit_empleado.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btncancel_edit_empleado.ForeColor = System.Drawing.Color.White
        Me.btncancel_edit_empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel_edit_empleado.Location = New System.Drawing.Point(485, 286)
        Me.btncancel_edit_empleado.Name = "btncancel_edit_empleado"
        Me.btncancel_edit_empleado.Size = New System.Drawing.Size(140, 50)
        Me.btncancel_edit_empleado.TabIndex = 41
        Me.btncancel_edit_empleado.Text = "Cancelar"
        Me.btncancel_edit_empleado.UseVisualStyleBackColor = False
        '
        'btnguardar_emple_nuevo
        '
        Me.btnguardar_emple_nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnguardar_emple_nuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnguardar_emple_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar_emple_nuevo.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnguardar_emple_nuevo.ForeColor = System.Drawing.Color.White
        Me.btnguardar_emple_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguardar_emple_nuevo.Location = New System.Drawing.Point(307, 286)
        Me.btnguardar_emple_nuevo.Name = "btnguardar_emple_nuevo"
        Me.btnguardar_emple_nuevo.Size = New System.Drawing.Size(140, 50)
        Me.btnguardar_emple_nuevo.TabIndex = 40
        Me.btnguardar_emple_nuevo.Text = "Guardar"
        Me.btnguardar_emple_nuevo.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(303, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 21)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Teléfono"
        '
        'txtempleadotelef
        '
        Me.txtempleadotelef.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtempleadotelef.Location = New System.Drawing.Point(307, 220)
        Me.txtempleadotelef.Name = "txtempleadotelef"
        Me.txtempleadotelef.Size = New System.Drawing.Size(318, 27)
        Me.txtempleadotelef.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(303, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 21)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Dirección"
        '
        'txtdireccionempleado
        '
        Me.txtdireccionempleado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccionempleado.Location = New System.Drawing.Point(307, 140)
        Me.txtdireccionempleado.Name = "txtdireccionempleado"
        Me.txtdireccionempleado.Size = New System.Drawing.Size(318, 27)
        Me.txtdireccionempleado.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(303, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 21)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Fecha de nacimiento"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(307, 62)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(318, 27)
        Me.DateTimePicker1.TabIndex = 34
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.ListBox1.Location = New System.Drawing.Point(33, 300)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(200, 25)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 21)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Género"
        '
        'txtdni
        '
        Me.txtdni.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdni.Location = New System.Drawing.Point(33, 220)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(200, 27)
        Me.txtdni.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 21)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "DNI"
        '
        'txtempleadoapellido
        '
        Me.txtempleadoapellido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtempleadoapellido.Location = New System.Drawing.Point(33, 140)
        Me.txtempleadoapellido.Name = "txtempleadoapellido"
        Me.txtempleadoapellido.Size = New System.Drawing.Size(200, 27)
        Me.txtempleadoapellido.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 21)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Apellido"
        '
        'txtempleadonombre
        '
        Me.txtempleadonombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtempleadonombre.Location = New System.Drawing.Point(33, 60)
        Me.txtempleadonombre.Name = "txtempleadonombre"
        Me.txtempleadonombre.Size = New System.Drawing.Size(200, 27)
        Me.txtempleadonombre.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 21)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Nombre"
        '
        'editar_empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 387)
        Me.Controls.Add(Me.btncancel_edit_empleado)
        Me.Controls.Add(Me.btnguardar_emple_nuevo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtempleadotelef)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdireccionempleado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtempleadoapellido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtempleadonombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "editar_empleado"
        Me.Text = "Editar Empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btncancel_edit_empleado As Button
    Private WithEvents btnguardar_emple_nuevo As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtempleadotelef As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdireccionempleado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdni As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtempleadoapellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtempleadonombre As TextBox
    Friend WithEvents Label1 As Label
End Class
