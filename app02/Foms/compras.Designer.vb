<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class compras
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
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.SuspendLayout()
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(237, 185)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(200, 100)
        Me.GunaGradient2Panel1.TabIndex = 0
        '
        'compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GunaGradient2Panel1)
        Me.Name = "compras"
        Me.Text = "compras"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
End Class
