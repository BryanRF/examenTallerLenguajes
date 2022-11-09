<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarCategoria))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New Guna.UI.WinForms.GunaTextBox()
        Me.Agregarcate = New Guna.UI.WinForms.GunaGradientButton()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Sitka Subheading", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(76, 31)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(351, 48)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Registro de Categoira"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(53, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
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
        Me.txtNombre.Location = New System.Drawing.Point(168, 134)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.Size = New System.Drawing.Size(259, 41)
        Me.txtNombre.TabIndex = 3
        Me.txtNombre.Text = "Nombre"
        '
        'Agregarcate
        '
        Me.Agregarcate.AnimationHoverSpeed = 0.07!
        Me.Agregarcate.AnimationSpeed = 0.03!
        Me.Agregarcate.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.Agregarcate.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.Agregarcate.BorderColor = System.Drawing.Color.Black
        Me.Agregarcate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Agregarcate.FocusedColor = System.Drawing.Color.Empty
        Me.Agregarcate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Agregarcate.ForeColor = System.Drawing.Color.White
        Me.Agregarcate.Image = CType(resources.GetObject("Agregarcate.Image"), System.Drawing.Image)
        Me.Agregarcate.ImageSize = New System.Drawing.Size(20, 20)
        Me.Agregarcate.Location = New System.Drawing.Point(255, 274)
        Me.Agregarcate.Name = "Agregarcate"
        Me.Agregarcate.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Agregarcate.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Agregarcate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Agregarcate.OnHoverForeColor = System.Drawing.Color.White
        Me.Agregarcate.OnHoverImage = Nothing
        Me.Agregarcate.OnPressedColor = System.Drawing.Color.Black
        Me.Agregarcate.Size = New System.Drawing.Size(181, 61)
        Me.Agregarcate.TabIndex = 4
        Me.Agregarcate.Text = "Agregar"
        '
        'AgregarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(501, 365)
        Me.Controls.Add(Me.Agregarcate)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Name = "AgregarCategoria"
        Me.Text = "AgregarCategoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Agregarcate As Guna.UI.WinForms.GunaGradientButton
End Class
