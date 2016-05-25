Public Class ACTMVAN2
    Public Property Mes As Integer = 0
    Public Property Anio As Integer = 0

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarCombos()

        If Mes = 0 AndAlso Anio = 0 Then
            Me.txtAno.Text = Date.Now.Year.ToString()
            Me.txtAno.Enabled = True
        Else
            Me.txtAno.Text = Me.Anio.ToString
            Me.cboMeses.SelectedValue = Me.Mes.ToString
            Me.txtAno.Enabled = False
        End If

        Me.cboMeses.Enabled = Me.txtAno.Enabled
        Me.lblMes.Enabled = Me.txtAno.Enabled
        Me.lblAnio.Enabled = Me.txtAno.Enabled
    End Sub

    Private Sub LlenarCombos()
        Dim meses As List(Of Citi.Synergia.Entidades.CodigoDescripcion) = Citi.Synergia.HelperClient.Utils.ListaDeMeses()
        With cboMeses
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = meses
        End With
    End Sub

    Private Sub LabelAnio_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnio.DoubleClick, lblMes.DoubleClick, txtAno.DoubleClick
        With txtAno
            .NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDePeriodosContables_PECONC02
            .GenerarConsulta()
            '-- En este caso la consulta devuelve 2 códigos
            If .CodigosRetorno.Count > 0 Then
                .Text = .CodigosRetorno.Item(0)
                Me.cboMeses.SelectedValue = .CodigosRetorno.Item(1)
            End If
            .NombreDeConsulta = Nothing
        End With
    End Sub

    Private Sub Ano_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtAno.KeyUp
        If e.KeyCode = Keys.F4 Then
            Me.LabelAnio_DoubleClick(Nothing, Nothing)
        End If
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