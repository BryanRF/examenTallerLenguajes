
Imports CapaNegocio
Imports CapaEntidad
Public Class AgregarCliente
    Private objNegocio As New cls_CapaNegocio
    Dim Persona As New PersonaRegistro
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        loadingCombo()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        conoboGenero()
    End Sub


    Public Sub loadingCombo()
        Dim table As DataTable = objNegocio.CN_ListarPais
        comboPais.DataSource = table
        comboPais.DisplayMember = "pais"
        comboPais.ValueMember = "idPais"
    End Sub




    Public Sub conoboGenero()
        Dim table As DataTable = objNegocio.CN_listargenro
        Genero.DataSource = table
        Genero.DisplayMember = "nombre"
        Genero.ValueMember = "id_genero"
    End Sub



    Private Sub comboPais_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboPais.SelectedValueChanged
        Dim cod As Integer = Val(comboPais.SelectedValue.ToString)
        Dim table As DataTable = objNegocio.CD_BuscarPais(cod)
        ConboDepartamento.DataSource = table
        ConboDepartamento.DisplayMember = "departamento"
        ConboDepartamento.ValueMember = "idDepartamento"
    End Sub


    Private Sub ConboDepartamento_SelectedValueChanged(sender As Object, e As EventArgs) Handles ConboDepartamento.SelectedValueChanged
        Dim cod2 As Integer = Val(ConboDepartamento.SelectedValue.ToString)
        Dim table As DataTable = objNegocio.CN_BuscarProvincia(cod2)
        ComboBoxProvincia.DataSource = table
        ComboBoxProvincia.DisplayMember = "provincia"
        ComboBoxProvincia.ValueMember = "idProvincia"
    End Sub

    Private Sub ComboBoxProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProvincia.SelectedValueChanged

        Dim cod2 As Integer = Val(ComboBoxProvincia.SelectedValue.ToString)
        Dim table As DataTable = objNegocio.CN_ListarDistrito(cod2)
        conboDistrito.DataSource = table
        conboDistrito.DisplayMember = "distrito"
        conboDistrito.ValueMember = "idDistrito"

    End Sub

    Private Sub AgregarPersonas_Click(sender As Object, e As EventArgs) Handles AgregarPersonas.Click
        Persona.apellidos = txtApellido.Text
        Persona.nombres = txtNombre.Text
        Persona.fecha_nacimiento = Format(fechaNacimiento.Value, "yyyy-MM-dd")
        Persona.nombreDireccion = DIreccion.Text
        Persona.id_distrito = Val(conboDistrito.SelectedValue.ToString)
        Persona.dni = Dni.Text
        objNegocio.CN_InsertarClientes(Persona)
        MessageBox.Show("Se registró correctamente el cliente")
        Close()

    End Sub


End Class