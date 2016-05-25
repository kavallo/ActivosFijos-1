Public Class ConsultaPartida
    Public Property Opcion As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LlenarCombos()
    End Sub

    Private Sub LlenarCombos()
        Dim opciones As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With opciones
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("1", Citi.Synergia.Traductor.Idiomas.GetMensaje(173, "Consulta a partida")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("2", Citi.Synergia.Traductor.Idiomas.GetMensaje(239, "Generación ADE")))
        End With
        With cboOpciones
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = opciones
        End With
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Opcion = cboOpciones.SelectedValue.ToString

        Me.Close()
    End Sub
End Class