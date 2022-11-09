
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Public Class Categoria
    Private conn As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ConnectionString)

    Public Function CD_Lista_categoria() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("[dbo].[get_lista_categoria]", conn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function





    Public Sub CD_InsertarCategoria(CEDatos As cat)
        Dim cmd As New SqlCommand("[dbo].[Set_Insertar_categeria]", conn)
        conn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("nombre", CEDatos.nombre)

        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        conn.Close()
    End Sub
End Class
