
Imports CapaNegocio

Public Class clientes
    Private objNegocio As New cls_CapaNegocio
    Private Sub FormPregrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmaciaDataSet.telefono' Puede moverla o quitarla según sea necesario.
        MostrarClientes()
    End Sub
    Sub MostrarClientes()
        Dim dt As DataTable = objNegocio.CN_ListarClientes
        Me.GunaDataGridView1.DataSource = dt
    End Sub



    Private Sub agregarMedicamentos_Click(sender As Object, e As EventArgs) Handles agregarMedicamentos.Click
        Dim FormAgrCliente As New AgregarCliente
        FormAgrCliente.ShowDialog()
        MostrarClientes()

    End Sub

    Private Sub BuscarCliente_Click(sender As Object, e As EventArgs) Handles BuscarCliente.Click
        Dim busca = txtBuscar.text
        GunaDataGridView1.DataSource = objNegocio.CN_BuscarCliente(busca)
    End Sub


End Class