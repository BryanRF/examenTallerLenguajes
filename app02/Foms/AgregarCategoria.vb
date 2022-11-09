Imports CapaNegocio
Imports CapaEntidad
Public Class AgregarCategoria

    Dim cate As New cat
    Dim objNegocio As New cls_CapaNegocio

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Agregarcate_Click(sender As Object, e As EventArgs) Handles Agregarcate.Click
        cate.nombre = txtNombre.Text
        objNegocio.CN_InsertarCategoria(cate)
        MessageBox.Show("Se registró correctamente el categoria")
        Close()
    End Sub
End Class