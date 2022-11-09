Imports FontAwesome.Sharp
Public Class Form1
    'declaramos para alamacenar de forma privada botones y paneles  '

    Private bntActual As IconButton
    Private leftborderBtn As Panel
    Private CurrentChildForm As Form
    'crear contructor'
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftborderBtn = New Panel()
        leftborderBtn.Size = New Size(8, 40)
        Panelmenu.Controls.Add(leftborderBtn)
    End Sub
    'metodos'
    'color activo y metodos personalisado '

    Private Sub ActivateButton(SenderBtn As Object, customColor As Color)
        If SenderBtn IsNot Nothing Then
            DisableButton()
            'convertimos el tipo del objeto al tipo de  icono '
            bntActual = CType(SenderBtn, IconButton)
            bntActual.BackColor = Color.FromArgb(39, 146, 239)
            bntActual.ForeColor = customColor
            bntActual.IconColor = customColor
            bntActual.TextAlign = ContentAlignment.MiddleCenter
            bntActual.ImageAlign = ContentAlignment.MiddleRight
            bntActual.TextImageRelation = TextImageRelation.TextBeforeImage

            'border'

            leftborderBtn.BackColor = customColor
            leftborderBtn.Location = New Point(0, bntActual.Location.Y)
            leftborderBtn.Visible = True
            leftborderBtn.BringToFront()
            IconFormActual.IconChar = bntActual.IconChar
            IconFormActual.IconColor = customColor


        End If
    End Sub

    Private Sub DisableButton()
        If bntActual IsNot Nothing Then
            bntActual.BackColor = Color.FromArgb(36, 40, 46)
            bntActual.ForeColor = Color.White
            bntActual.IconColor = Color.FromArgb(50, 144, 148)
            bntActual.TextAlign = ContentAlignment.MiddleCenter
            bntActual.ImageAlign = ContentAlignment.MiddleLeft
            bntActual.TextImageRelation = TextImageRelation.ImageBeforeText


        End If
    End Sub



    Private Sub OpenChildForm(childForm As Form)
        If CurrentChildForm IsNot Nothing Then
            CurrentChildForm.Close()

        End If
        CurrentChildForm = childForm
        childForm.TopLevel = False
        childForm.Dock = DockStyle.Fill
        childForm.FormBorderStyle = FormBorderStyle.None
        'controles '
        PanelEscritorio.Controls.Add(childForm)
        PanelEscritorio.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        LblFormActual.Text = childForm.Text
    End Sub



    Private Sub bnt_dashboard_Click(sender As Object, e As EventArgs) Handles bnt_dashboard.Click
        ActivateButton(sender, RGBColor.RGBCLORS.colo9)
        OpenChildForm(New Dashboard)
    End Sub

    Private Sub bnt_productos_Click(sender As Object, e As EventArgs) Handles bnt_productos.Click
        ActivateButton(sender, RGBColor.RGBCLORS.colo9)
        OpenChildForm(New productos)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles ventas.Click
        ActivateButton(sender, RGBColor.RGBCLORS.colo9)
        OpenChildForm(New ventas)
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles compras.Click
        ActivateButton(sender, RGBColor.RGBCLORS.colo9)
        OpenChildForm(New compras)
    End Sub



    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles proveedores.Click
        ActivateButton(sender, RGBColor.RGBCLORS.colo9)
        OpenChildForm(New proveedores)
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles empleados.Click
        ActivateButton(sender, RGBColor.RGBCLORS.colo9)
        OpenChildForm(New empleado)
    End Sub

    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles categorias.Click
        ActivateButton(sender, RGBColor.RGBCLORS.colo9)
        OpenChildForm(New categoria)
    End Sub

    Private Sub IconButton9_Click(sender As Object, e As EventArgs) Handles usuarios.Click
        ActivateButton(sender, RGBColor.RGBCLORS.colo9)
        OpenChildForm(New usuario)
    End Sub

    Private Sub clientes_Click(sender As Object, e As EventArgs) Handles clientes.Click
        ActivateButton(sender, RGBColor.RGBCLORS.colo9)
        OpenChildForm(New clientes)
    End Sub
End Class
