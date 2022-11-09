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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panelmenu = New System.Windows.Forms.Panel()
        Me.usuarios = New FontAwesome.Sharp.IconButton()
        Me.categorias = New FontAwesome.Sharp.IconButton()
        Me.empleados = New FontAwesome.Sharp.IconButton()
        Me.proveedores = New FontAwesome.Sharp.IconButton()
        Me.clientes = New FontAwesome.Sharp.IconButton()
        Me.compras = New FontAwesome.Sharp.IconButton()
        Me.ventas = New FontAwesome.Sharp.IconButton()
        Me.bnt_productos = New FontAwesome.Sharp.IconButton()
        Me.bnt_dashboard = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblFormActual = New System.Windows.Forms.Label()
        Me.IconFormActual = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelEscritorio = New System.Windows.Forms.Panel()
        Me.Panelmenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.IconFormActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panelmenu
        '
        Me.Panelmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panelmenu.Controls.Add(Me.usuarios)
        Me.Panelmenu.Controls.Add(Me.categorias)
        Me.Panelmenu.Controls.Add(Me.empleados)
        Me.Panelmenu.Controls.Add(Me.proveedores)
        Me.Panelmenu.Controls.Add(Me.clientes)
        Me.Panelmenu.Controls.Add(Me.compras)
        Me.Panelmenu.Controls.Add(Me.ventas)
        Me.Panelmenu.Controls.Add(Me.bnt_productos)
        Me.Panelmenu.Controls.Add(Me.bnt_dashboard)
        Me.Panelmenu.Controls.Add(Me.Panel2)
        Me.Panelmenu.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelmenu.Location = New System.Drawing.Point(0, 0)
        Me.Panelmenu.Name = "Panelmenu"
        Me.Panelmenu.Size = New System.Drawing.Size(259, 688)
        Me.Panelmenu.TabIndex = 0
        '
        'usuarios
        '
        Me.usuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.usuarios.FlatAppearance.BorderSize = 0
        Me.usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuarios.ForeColor = System.Drawing.Color.White
        Me.usuarios.IconChar = FontAwesome.Sharp.IconChar.UserDoctor
        Me.usuarios.IconColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.usuarios.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.usuarios.Location = New System.Drawing.Point(0, 544)
        Me.usuarios.Name = "usuarios"
        Me.usuarios.Size = New System.Drawing.Size(259, 49)
        Me.usuarios.TabIndex = 9
        Me.usuarios.Text = "Usuarios"
        Me.usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.usuarios.UseVisualStyleBackColor = True
        '
        'categorias
        '
        Me.categorias.Dock = System.Windows.Forms.DockStyle.Top
        Me.categorias.FlatAppearance.BorderSize = 0
        Me.categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.categorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categorias.ForeColor = System.Drawing.Color.White
        Me.categorias.IconChar = FontAwesome.Sharp.IconChar.Tag
        Me.categorias.IconColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.categorias.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.categorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.categorias.Location = New System.Drawing.Point(0, 490)
        Me.categorias.Name = "categorias"
        Me.categorias.Size = New System.Drawing.Size(259, 54)
        Me.categorias.TabIndex = 8
        Me.categorias.Text = "Categorias"
        Me.categorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.categorias.UseVisualStyleBackColor = True
        '
        'empleados
        '
        Me.empleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.empleados.FlatAppearance.BorderSize = 0
        Me.empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.empleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empleados.ForeColor = System.Drawing.Color.White
        Me.empleados.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.empleados.IconColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.empleados.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.empleados.Location = New System.Drawing.Point(0, 436)
        Me.empleados.Name = "empleados"
        Me.empleados.Size = New System.Drawing.Size(259, 54)
        Me.empleados.TabIndex = 7
        Me.empleados.Text = "Empleados"
        Me.empleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.empleados.UseVisualStyleBackColor = True
        '
        'proveedores
        '
        Me.proveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.proveedores.FlatAppearance.BorderSize = 0
        Me.proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.proveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proveedores.ForeColor = System.Drawing.Color.White
        Me.proveedores.IconChar = FontAwesome.Sharp.IconChar.UsersViewfinder
        Me.proveedores.IconColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.proveedores.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.proveedores.Location = New System.Drawing.Point(0, 382)
        Me.proveedores.Name = "proveedores"
        Me.proveedores.Size = New System.Drawing.Size(259, 54)
        Me.proveedores.TabIndex = 6
        Me.proveedores.Text = "Proveedores"
        Me.proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.proveedores.UseVisualStyleBackColor = True
        '
        'clientes
        '
        Me.clientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.clientes.FlatAppearance.BorderSize = 0
        Me.clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientes.ForeColor = System.Drawing.Color.White
        Me.clientes.IconChar = FontAwesome.Sharp.IconChar.UsersLine
        Me.clientes.IconColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.clientes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clientes.Location = New System.Drawing.Point(0, 328)
        Me.clientes.Name = "clientes"
        Me.clientes.Size = New System.Drawing.Size(259, 54)
        Me.clientes.TabIndex = 5
        Me.clientes.Text = "Clientes"
        Me.clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.clientes.UseVisualStyleBackColor = True
        '
        'compras
        '
        Me.compras.Dock = System.Windows.Forms.DockStyle.Top
        Me.compras.FlatAppearance.BorderSize = 0
        Me.compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.compras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compras.ForeColor = System.Drawing.Color.White
        Me.compras.IconChar = FontAwesome.Sharp.IconChar.BasketShopping
        Me.compras.IconColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.compras.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.compras.Location = New System.Drawing.Point(0, 279)
        Me.compras.Name = "compras"
        Me.compras.Size = New System.Drawing.Size(259, 49)
        Me.compras.TabIndex = 4
        Me.compras.Text = "compras"
        Me.compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.compras.UseVisualStyleBackColor = True
        '
        'ventas
        '
        Me.ventas.Dock = System.Windows.Forms.DockStyle.Top
        Me.ventas.FlatAppearance.BorderSize = 0
        Me.ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ventas.ForeColor = System.Drawing.Color.White
        Me.ventas.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.ventas.IconColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.ventas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ventas.Location = New System.Drawing.Point(0, 234)
        Me.ventas.Name = "ventas"
        Me.ventas.Size = New System.Drawing.Size(259, 45)
        Me.ventas.TabIndex = 3
        Me.ventas.Text = "Ventas"
        Me.ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ventas.UseVisualStyleBackColor = True
        '
        'bnt_productos
        '
        Me.bnt_productos.Dock = System.Windows.Forms.DockStyle.Top
        Me.bnt_productos.FlatAppearance.BorderSize = 0
        Me.bnt_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnt_productos.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_productos.ForeColor = System.Drawing.Color.White
        Me.bnt_productos.IconChar = FontAwesome.Sharp.IconChar.Store
        Me.bnt_productos.IconColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.bnt_productos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.bnt_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bnt_productos.Location = New System.Drawing.Point(0, 180)
        Me.bnt_productos.Name = "bnt_productos"
        Me.bnt_productos.Size = New System.Drawing.Size(259, 54)
        Me.bnt_productos.TabIndex = 2
        Me.bnt_productos.Text = "Productos"
        Me.bnt_productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bnt_productos.UseVisualStyleBackColor = True
        '
        'bnt_dashboard
        '
        Me.bnt_dashboard.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.bnt_dashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.bnt_dashboard.FlatAppearance.BorderSize = 0
        Me.bnt_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnt_dashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_dashboard.ForeColor = System.Drawing.Color.White
        Me.bnt_dashboard.IconChar = FontAwesome.Sharp.IconChar.LineChart
        Me.bnt_dashboard.IconColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.bnt_dashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.bnt_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bnt_dashboard.Location = New System.Drawing.Point(0, 100)
        Me.bnt_dashboard.Name = "bnt_dashboard"
        Me.bnt_dashboard.Size = New System.Drawing.Size(259, 80)
        Me.bnt_dashboard.TabIndex = 1
        Me.bnt_dashboard.Text = "DASHBOARD"
        Me.bnt_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bnt_dashboard.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(259, 100)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(236, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LblFormActual)
        Me.Panel3.Controls.Add(Me.IconFormActual)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(259, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(828, 100)
        Me.Panel3.TabIndex = 1
        '
        'LblFormActual
        '
        Me.LblFormActual.AutoSize = True
        Me.LblFormActual.ForeColor = System.Drawing.Color.White
        Me.LblFormActual.Location = New System.Drawing.Point(114, 48)
        Me.LblFormActual.Name = "LblFormActual"
        Me.LblFormActual.Size = New System.Drawing.Size(47, 16)
        Me.LblFormActual.TabIndex = 1
        Me.LblFormActual.Text = "HOME"
        Me.LblFormActual.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'IconFormActual
        '
        Me.IconFormActual.BackColor = System.Drawing.Color.Transparent
        Me.IconFormActual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.IconFormActual.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconFormActual.IconColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.IconFormActual.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconFormActual.IconSize = 60
        Me.IconFormActual.Location = New System.Drawing.Point(29, 29)
        Me.IconFormActual.Name = "IconFormActual"
        Me.IconFormActual.Size = New System.Drawing.Size(67, 60)
        Me.IconFormActual.TabIndex = 0
        Me.IconFormActual.TabStop = False
        '
        'PanelEscritorio
        '
        Me.PanelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEscritorio.Location = New System.Drawing.Point(259, 100)
        Me.PanelEscritorio.Name = "PanelEscritorio"
        Me.PanelEscritorio.Size = New System.Drawing.Size(828, 588)
        Me.PanelEscritorio.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1087, 688)
        Me.Controls.Add(Me.PanelEscritorio)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panelmenu)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panelmenu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.IconFormActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panelmenu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents compras As FontAwesome.Sharp.IconButton
    Friend WithEvents ventas As FontAwesome.Sharp.IconButton
    Friend WithEvents bnt_productos As FontAwesome.Sharp.IconButton
    Friend WithEvents categorias As FontAwesome.Sharp.IconButton
    Friend WithEvents empleados As FontAwesome.Sharp.IconButton
    Friend WithEvents proveedores As FontAwesome.Sharp.IconButton
    Friend WithEvents clientes As FontAwesome.Sharp.IconButton
    Friend WithEvents usuarios As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents IconFormActual As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents LblFormActual As Label
    Friend WithEvents bnt_dashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelEscritorio As Panel
End Class
