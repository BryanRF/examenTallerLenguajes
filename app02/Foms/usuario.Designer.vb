<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usuario
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usuario))
        Me.tabla_usuarios = New Guna.UI.WinForms.GunaDataGridView()
        Me.txtBuscar = New Bunifu.Framework.UI.BunifuTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BuscarCliente = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuTextbox1 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.agregarMedicamentos = New Guna.UI.WinForms.GunaGradientTileButton()
        CType(Me.tabla_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabla_usuarios
        '
        Me.tabla_usuarios.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.tabla_usuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.tabla_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabla_usuarios.BackgroundColor = System.Drawing.Color.White
        Me.tabla_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabla_usuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.tabla_usuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabla_usuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.tabla_usuarios.ColumnHeadersHeight = 27
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabla_usuarios.DefaultCellStyle = DataGridViewCellStyle6
        Me.tabla_usuarios.EnableHeadersVisualStyles = False
        Me.tabla_usuarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabla_usuarios.Location = New System.Drawing.Point(39, 144)
        Me.tabla_usuarios.Name = "tabla_usuarios"
        Me.tabla_usuarios.RowHeadersVisible = False
        Me.tabla_usuarios.RowHeadersWidth = 51
        Me.tabla_usuarios.RowTemplate.Height = 24
        Me.tabla_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla_usuarios.Size = New System.Drawing.Size(714, 269)
        Me.tabla_usuarios.TabIndex = 1
        Me.tabla_usuarios.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.tabla_usuarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.tabla_usuarios.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.tabla_usuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.tabla_usuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.tabla_usuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.tabla_usuarios.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.tabla_usuarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabla_usuarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabla_usuarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.tabla_usuarios.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.tabla_usuarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.tabla_usuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.tabla_usuarios.ThemeStyle.HeaderStyle.Height = 27
        Me.tabla_usuarios.ThemeStyle.ReadOnly = False
        Me.tabla_usuarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.tabla_usuarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.tabla_usuarios.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.tabla_usuarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tabla_usuarios.ThemeStyle.RowsStyle.Height = 24
        Me.tabla_usuarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabla_usuarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.Silver
        Me.txtBuscar.BackgroundImage = CType(resources.GetObject("txtBuscar.BackgroundImage"), System.Drawing.Image)
        Me.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscar.Icon = CType(resources.GetObject("txtBuscar.Icon"), System.Drawing.Image)
        Me.txtBuscar.Location = New System.Drawing.Point(55, 30)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(240, 52)
        Me.txtBuscar.TabIndex = 15
        Me.txtBuscar.text = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuImageButton2)
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.BuscarCliente)
        Me.Panel1.Controls.Add(Me.BunifuTextbox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 115)
        Me.Panel1.TabIndex = 16
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(426, 30)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(68, 52)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 17
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Red
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(352, 30)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(68, 52)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 16
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BuscarCliente
        '
        Me.BuscarCliente.BackColor = System.Drawing.Color.SeaGreen
        Me.BuscarCliente.Image = CType(resources.GetObject("BuscarCliente.Image"), System.Drawing.Image)
        Me.BuscarCliente.ImageActive = Nothing
        Me.BuscarCliente.Location = New System.Drawing.Point(278, 30)
        Me.BuscarCliente.Name = "BuscarCliente"
        Me.BuscarCliente.Size = New System.Drawing.Size(68, 52)
        Me.BuscarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BuscarCliente.TabIndex = 15
        Me.BuscarCliente.TabStop = False
        Me.BuscarCliente.Zoom = 10
        '
        'BunifuTextbox1
        '
        Me.BunifuTextbox1.BackColor = System.Drawing.Color.Silver
        Me.BunifuTextbox1.BackgroundImage = CType(resources.GetObject("BunifuTextbox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuTextbox1.Icon = CType(resources.GetObject("BunifuTextbox1.Icon"), System.Drawing.Image)
        Me.BunifuTextbox1.Location = New System.Drawing.Point(31, 30)
        Me.BunifuTextbox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuTextbox1.Name = "BunifuTextbox1"
        Me.BunifuTextbox1.Size = New System.Drawing.Size(240, 52)
        Me.BunifuTextbox1.TabIndex = 14
        Me.BunifuTextbox1.text = ""
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.agregarMedicamentos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(554, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(246, 115)
        Me.Panel2.TabIndex = 13
        '
        'agregarMedicamentos
        '
        Me.agregarMedicamentos.AnimationHoverSpeed = 0.07!
        Me.agregarMedicamentos.AnimationSpeed = 0.03!
        Me.agregarMedicamentos.BackColor = System.Drawing.Color.Transparent
        Me.agregarMedicamentos.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.agregarMedicamentos.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.agregarMedicamentos.BorderColor = System.Drawing.Color.Black
        Me.agregarMedicamentos.BorderSize = 1
        Me.agregarMedicamentos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.agregarMedicamentos.FocusedColor = System.Drawing.Color.Empty
        Me.agregarMedicamentos.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.agregarMedicamentos.ForeColor = System.Drawing.Color.White
        Me.agregarMedicamentos.Image = CType(resources.GetObject("agregarMedicamentos.Image"), System.Drawing.Image)
        Me.agregarMedicamentos.ImageSize = New System.Drawing.Size(40, 40)
        Me.agregarMedicamentos.Location = New System.Drawing.Point(17, 21)
        Me.agregarMedicamentos.Name = "agregarMedicamentos"
        Me.agregarMedicamentos.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.agregarMedicamentos.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.agregarMedicamentos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.agregarMedicamentos.OnHoverForeColor = System.Drawing.Color.White
        Me.agregarMedicamentos.OnHoverImage = Nothing
        Me.agregarMedicamentos.OnPressedColor = System.Drawing.Color.Black
        Me.agregarMedicamentos.Radius = 20
        Me.agregarMedicamentos.Size = New System.Drawing.Size(196, 79)
        Me.agregarMedicamentos.TabIndex = 12
        Me.agregarMedicamentos.Text = "Nuevo Usuario"
        '
        'usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.tabla_usuarios)
        Me.Name = "usuario"
        Me.Text = "usuario"
        CType(Me.tabla_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabla_usuarios As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents txtBuscar As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BuscarCliente As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuTextbox1 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents agregarMedicamentos As Guna.UI.WinForms.GunaGradientTileButton
End Class
