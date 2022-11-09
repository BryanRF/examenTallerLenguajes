<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class categoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(categoria))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BuscarCliente = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuTextbox1 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.agregarcategoria = New Guna.UI.WinForms.GunaGradientTileButton()
        Me.tabla_categoria = New Guna.UI.WinForms.GunaDataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.tabla_categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.TabIndex = 17
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
        Me.Panel2.Controls.Add(Me.agregarcategoria)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(554, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(246, 115)
        Me.Panel2.TabIndex = 13
        '
        'agregarcategoria
        '
        Me.agregarcategoria.AnimationHoverSpeed = 0.07!
        Me.agregarcategoria.AnimationSpeed = 0.03!
        Me.agregarcategoria.BackColor = System.Drawing.Color.Transparent
        Me.agregarcategoria.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.agregarcategoria.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.agregarcategoria.BorderColor = System.Drawing.Color.Black
        Me.agregarcategoria.BorderSize = 1
        Me.agregarcategoria.DialogResult = System.Windows.Forms.DialogResult.None
        Me.agregarcategoria.FocusedColor = System.Drawing.Color.Empty
        Me.agregarcategoria.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.agregarcategoria.ForeColor = System.Drawing.Color.White
        Me.agregarcategoria.Image = CType(resources.GetObject("agregarcategoria.Image"), System.Drawing.Image)
        Me.agregarcategoria.ImageSize = New System.Drawing.Size(40, 40)
        Me.agregarcategoria.Location = New System.Drawing.Point(18, 12)
        Me.agregarcategoria.Name = "agregarcategoria"
        Me.agregarcategoria.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.agregarcategoria.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.agregarcategoria.OnHoverBorderColor = System.Drawing.Color.Black
        Me.agregarcategoria.OnHoverForeColor = System.Drawing.Color.White
        Me.agregarcategoria.OnHoverImage = Nothing
        Me.agregarcategoria.OnPressedColor = System.Drawing.Color.Black
        Me.agregarcategoria.Radius = 20
        Me.agregarcategoria.Size = New System.Drawing.Size(196, 84)
        Me.agregarcategoria.TabIndex = 12
        Me.agregarcategoria.Text = "Nuevo Categoria"
        '
        'tabla_categoria
        '
        Me.tabla_categoria.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.tabla_categoria.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.tabla_categoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabla_categoria.BackgroundColor = System.Drawing.Color.White
        Me.tabla_categoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabla_categoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.tabla_categoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabla_categoria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.tabla_categoria.ColumnHeadersHeight = 27
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabla_categoria.DefaultCellStyle = DataGridViewCellStyle6
        Me.tabla_categoria.EnableHeadersVisualStyles = False
        Me.tabla_categoria.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabla_categoria.Location = New System.Drawing.Point(12, 132)
        Me.tabla_categoria.Name = "tabla_categoria"
        Me.tabla_categoria.RowHeadersVisible = False
        Me.tabla_categoria.RowHeadersWidth = 51
        Me.tabla_categoria.RowTemplate.Height = 24
        Me.tabla_categoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla_categoria.Size = New System.Drawing.Size(756, 306)
        Me.tabla_categoria.TabIndex = 18
        Me.tabla_categoria.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.tabla_categoria.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.tabla_categoria.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.tabla_categoria.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.tabla_categoria.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.tabla_categoria.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.tabla_categoria.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.tabla_categoria.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabla_categoria.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabla_categoria.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.tabla_categoria.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.tabla_categoria.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.tabla_categoria.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.tabla_categoria.ThemeStyle.HeaderStyle.Height = 27
        Me.tabla_categoria.ThemeStyle.ReadOnly = False
        Me.tabla_categoria.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.tabla_categoria.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.tabla_categoria.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.tabla_categoria.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tabla_categoria.ThemeStyle.RowsStyle.Height = 24
        Me.tabla_categoria.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabla_categoria.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tabla_categoria)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "categoria"
        Me.Text = "categoria"
        Me.Panel1.ResumeLayout(False)
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.tabla_categoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BuscarCliente As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuTextbox1 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents agregarcategoria As Guna.UI.WinForms.GunaGradientTileButton
    Friend WithEvents tabla_categoria As Guna.UI.WinForms.GunaDataGridView
End Class
