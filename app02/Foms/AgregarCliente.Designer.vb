<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarCliente
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarCliente))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.AgregarPersonas = New Guna.UI.WinForms.GunaGradientButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Dni = New Guna.UI.WinForms.GunaTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.ComboBoxProvincia = New System.Windows.Forms.ComboBox()
        Me.conboDistrito = New System.Windows.Forms.ComboBox()
        Me.Genero = New System.Windows.Forms.ComboBox()
        Me.ConboDepartamento = New System.Windows.Forms.ComboBox()
        Me.comboPais = New System.Windows.Forms.ComboBox()
        Me.DIreccion = New Guna.UI.WinForms.GunaTextBox()
        Me.fechaNacimiento = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.txtApellido = New Guna.UI.WinForms.GunaTextBox()
        Me.txtNombre = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fechaNac = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'AgregarPersonas
        '
        Me.AgregarPersonas.AnimationHoverSpeed = 0.07!
        Me.AgregarPersonas.AnimationSpeed = 0.03!
        Me.AgregarPersonas.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.AgregarPersonas.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.AgregarPersonas.BorderColor = System.Drawing.Color.Black
        Me.AgregarPersonas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.AgregarPersonas.FocusedColor = System.Drawing.Color.Empty
        Me.AgregarPersonas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AgregarPersonas.ForeColor = System.Drawing.Color.White
        Me.AgregarPersonas.Image = CType(resources.GetObject("AgregarPersonas.Image"), System.Drawing.Image)
        Me.AgregarPersonas.ImageSize = New System.Drawing.Size(20, 20)
        Me.AgregarPersonas.Location = New System.Drawing.Point(66, 19)
        Me.AgregarPersonas.Name = "AgregarPersonas"
        Me.AgregarPersonas.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.AgregarPersonas.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AgregarPersonas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.AgregarPersonas.OnHoverForeColor = System.Drawing.Color.White
        Me.AgregarPersonas.OnHoverImage = Nothing
        Me.AgregarPersonas.OnPressedColor = System.Drawing.Color.Black
        Me.AgregarPersonas.Size = New System.Drawing.Size(154, 42)
        Me.AgregarPersonas.TabIndex = 0
        Me.AgregarPersonas.Text = "Agregar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(970, 100)
        Me.Panel1.TabIndex = 1
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Sitka Subheading", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(182, 21)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(329, 48)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Registro de Clientes"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 589)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(970, 82)
        Me.Panel3.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.AgregarPersonas)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(705, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(265, 82)
        Me.Panel6.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(916, 100)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(54, 489)
        Me.Panel4.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(43, 489)
        Me.Panel2.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Dni)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(43, 100)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(873, 489)
        Me.Panel5.TabIndex = 6
        '
        'Dni
        '
        Me.Dni.BaseColor = System.Drawing.Color.White
        Me.Dni.BorderColor = System.Drawing.Color.Silver
        Me.Dni.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Dni.FocusedBaseColor = System.Drawing.Color.White
        Me.Dni.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dni.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Dni.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Dni.Location = New System.Drawing.Point(585, 52)
        Me.Dni.Name = "Dni"
        Me.Dni.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Dni.Size = New System.Drawing.Size(238, 30)
        Me.Dni.TabIndex = 13
        Me.Dni.Text = "Dni"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(500, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 25)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Dni"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.ComboBoxProvincia)
        Me.Panel8.Controls.Add(Me.conboDistrito)
        Me.Panel8.Controls.Add(Me.Genero)
        Me.Panel8.Controls.Add(Me.ConboDepartamento)
        Me.Panel8.Controls.Add(Me.comboPais)
        Me.Panel8.Controls.Add(Me.DIreccion)
        Me.Panel8.Controls.Add(Me.fechaNacimiento)
        Me.Panel8.Controls.Add(Me.txtApellido)
        Me.Panel8.Controls.Add(Me.txtNombre)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(170, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(298, 489)
        Me.Panel8.TabIndex = 1
        '
        'ComboBoxProvincia
        '
        Me.ComboBoxProvincia.FormattingEnabled = True
        Me.ComboBoxProvincia.Location = New System.Drawing.Point(18, 368)
        Me.ComboBoxProvincia.Name = "ComboBoxProvincia"
        Me.ComboBoxProvincia.Size = New System.Drawing.Size(243, 24)
        Me.ComboBoxProvincia.TabIndex = 10
        '
        'conboDistrito
        '
        Me.conboDistrito.FormattingEnabled = True
        Me.conboDistrito.Location = New System.Drawing.Point(14, 419)
        Me.conboDistrito.Name = "conboDistrito"
        Me.conboDistrito.Size = New System.Drawing.Size(243, 24)
        Me.conboDistrito.TabIndex = 9
        '
        'Genero
        '
        Me.Genero.FormattingEnabled = True
        Me.Genero.Location = New System.Drawing.Point(19, 179)
        Me.Genero.Name = "Genero"
        Me.Genero.Size = New System.Drawing.Size(243, 24)
        Me.Genero.TabIndex = 11
        '
        'ConboDepartamento
        '
        Me.ConboDepartamento.FormattingEnabled = True
        Me.ConboDepartamento.Location = New System.Drawing.Point(19, 323)
        Me.ConboDepartamento.Name = "ConboDepartamento"
        Me.ConboDepartamento.Size = New System.Drawing.Size(243, 24)
        Me.ConboDepartamento.TabIndex = 7
        '
        'comboPais
        '
        Me.comboPais.FormattingEnabled = True
        Me.comboPais.Location = New System.Drawing.Point(19, 278)
        Me.comboPais.Name = "comboPais"
        Me.comboPais.Size = New System.Drawing.Size(243, 24)
        Me.comboPais.TabIndex = 6
        '
        'DIreccion
        '
        Me.DIreccion.BaseColor = System.Drawing.Color.White
        Me.DIreccion.BorderColor = System.Drawing.Color.Silver
        Me.DIreccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DIreccion.FocusedBaseColor = System.Drawing.Color.White
        Me.DIreccion.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DIreccion.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.DIreccion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DIreccion.Location = New System.Drawing.Point(23, 229)
        Me.DIreccion.Name = "DIreccion"
        Me.DIreccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DIreccion.Size = New System.Drawing.Size(238, 30)
        Me.DIreccion.TabIndex = 5
        Me.DIreccion.Text = "Direccion"
        '
        'fechaNacimiento
        '
        Me.fechaNacimiento.BackColor = System.Drawing.Color.SeaGreen
        Me.fechaNacimiento.BorderRadius = 0
        Me.fechaNacimiento.ForeColor = System.Drawing.Color.White
        Me.fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.fechaNacimiento.FormatCustom = Nothing
        Me.fechaNacimiento.Location = New System.Drawing.Point(19, 120)
        Me.fechaNacimiento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fechaNacimiento.Name = "fechaNacimiento"
        Me.fechaNacimiento.Size = New System.Drawing.Size(238, 39)
        Me.fechaNacimiento.TabIndex = 3
        Me.fechaNacimiento.Value = New Date(2022, 10, 17, 22, 4, 49, 215)
        '
        'txtApellido
        '
        Me.txtApellido.BaseColor = System.Drawing.Color.White
        Me.txtApellido.BorderColor = System.Drawing.Color.Silver
        Me.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApellido.FocusedBaseColor = System.Drawing.Color.White
        Me.txtApellido.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApellido.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtApellido.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtApellido.Location = New System.Drawing.Point(19, 70)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellido.Size = New System.Drawing.Size(238, 30)
        Me.txtApellido.TabIndex = 1
        Me.txtApellido.Text = "Apelido"
        '
        'txtNombre
        '
        Me.txtNombre.BaseColor = System.Drawing.Color.White
        Me.txtNombre.BorderColor = System.Drawing.Color.Silver
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNombre.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombre.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNombre.Location = New System.Drawing.Point(19, 16)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.Size = New System.Drawing.Size(238, 30)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.Text = "Nombre"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.fechaNac)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(170, 489)
        Me.Panel7.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(26, 415)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 25)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Distrito"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(18, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Provincia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(22, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Departamento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(22, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Pais"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(18, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Direccion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(20, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Apellido"
        '
        'fechaNac
        '
        Me.fechaNac.AutoSize = True
        Me.fechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaNac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.fechaNac.Location = New System.Drawing.Point(20, 120)
        Me.fechaNac.Name = "fechaNac"
        Me.fechaNac.Size = New System.Drawing.Size(144, 25)
        Me.fechaNac.TabIndex = 3
        Me.fechaNac.Text = "F. Nacimiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(22, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Genero"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'AgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(970, 671)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AgregarCliente"
        Me.Text = "AgregarCliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents AgregarPersonas As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents fechaNac As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents txtApellido As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtNombre As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents fechaNacimiento As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents ConboDepartamento As ComboBox
    Friend WithEvents comboPais As ComboBox
    Friend WithEvents DIreccion As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents conboDistrito As ComboBox
    Friend WithEvents ComboBoxProvincia As ComboBox
    Friend WithEvents Genero As ComboBox
    Friend WithEvents Dni As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label10 As Label
End Class
