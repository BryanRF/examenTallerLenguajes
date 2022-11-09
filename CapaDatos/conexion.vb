Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad


Public Class conexion
    Private conn As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ConnectionString)

    Public Function CD_ListarClientes() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("[dbo].[listaPersona]", conn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function


End Class
