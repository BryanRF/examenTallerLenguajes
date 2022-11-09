
Imports CapaNegocio

Public Class usuario
    Private objNegocio As New cls_CapaNegocio
    Private Sub usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarUsuario()
    End Sub


    Sub MostrarUsuario()
        Dim dt As DataTable = objNegocio.CN_ListarUsuarios
        Me.tabla_usuarios.DataSource = dt
    End Sub

End Class