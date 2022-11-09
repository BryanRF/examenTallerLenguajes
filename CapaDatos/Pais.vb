Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad



Public Class Pais
    Private conn As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ConnectionString)

    Public Function CD_ListarPais() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("[dbo].[listaPais]", conn)

        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function


    Public Function CD_BuscarPais(texto As String) As DataTable
        Dim cmd As New SqlCommand("[dbo].[Get_Departamento]", conn)
        conn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", texto)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function




    Public Function CD_BuscarProvincia(texto As String) As DataTable
        Dim cmd As New SqlCommand("[dbo].[Get_provincia]", conn)
        conn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", texto)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function



    Public Function CD_ListarDistrito(texto As String) As DataTable
        Dim cmd As New SqlCommand("[dbo].[Get_Distrito]", conn)
        conn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", texto)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
End Class
