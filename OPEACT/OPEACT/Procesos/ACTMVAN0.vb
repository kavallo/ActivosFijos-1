Public Class ACTMVAN0
    Public Property Mes As Integer
    Public Property Anio As Integer

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarCombos()
        Me.txtAno.Text = Date.Now.Year.ToString()
    End Sub

    Private Sub LlenarCombos()
        Dim meses As List(Of Citi.Synergia.Entidades.CodigoDescripcion) = Citi.Synergia.HelperClient.Utils.ListaDeMeses()
        With cboMeses
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = meses
        End With
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        ValidaCampos.SetError(txtAno, Nothing)
        Anio = txtAno.Text
        If Anio <= 1900 Then
            ValidaCampos.SetError(txtAno, Citi.Synergia.Traductor.Idiomas.GetMensaje(245, "Año inválido"))
            Return
        End If

        Mes = cboMeses.SelectedValue

        Me.Close()
    End Sub
End Class