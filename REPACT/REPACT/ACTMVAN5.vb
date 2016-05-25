Imports Citi.Synergia.HelperClient

Public Class ACTMVAN5
    Private Sub Forma_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()

        Me.LlenarCombos()
    End Sub

    Private Sub LlenarCombos()
        Dim mesesInicial As List(Of Citi.Synergia.Entidades.CodigoDescripcion) = Citi.Synergia.HelperClient.Utils.ListaDeMeses()

        With cboMesInicial
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = mesesInicial
        End With

        Dim mesesFinal As List(Of Citi.Synergia.Entidades.CodigoDescripcion) = Citi.Synergia.HelperClient.Utils.ListaDeMeses()
        With cboMesFinal
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = mesesFinal
        End With
    End Sub

    Private Sub Filtros()
        If Me.txtActivoInicial.Text = "" Then
            Me.txtActivoInicial.Text = DescripcionesDB.CodigoActivoMinimo()
        End If
        If Me.txtActivoFinal.Text = "" Then
            Me.txtActivoFinal.Text = DescripcionesDB.CodigoActivoMaximo()
        End If
        If Me.txtTipoActivoInicial.Text = "" Then
            Me.txtTipoActivoInicial.Text = DescripcionesDB.CodigoTipoDeActivoMinimo()
            Me.Codigos_Leave(txtTipoActivoInicial, Nothing)
        End If
        If Me.txtTipoActivoFinal.Text = "" Then
            Me.txtTipoActivoFinal.Text = DescripcionesDB.CodigoTipoDeActivoMaximo()
            Me.Codigos_Leave(txtTipoActivoFinal, Nothing)
        End If
        If Me.txtDivisionInicial.Text = "" Then
            Me.txtDivisionInicial.Text = DescripcionesDB.CodigoDivisionMinimo()
            Me.Codigos_Leave(txtDivisionInicial, Nothing)
        End If
        If Me.txtDivisionFinal.Text = "" Then
            Me.txtDivisionFinal.Text = DescripcionesDB.CodigoDivisionMaximo()
            Me.Codigos_Leave(txtDivisionFinal, Nothing)
        End If
    End Sub

    Private Sub LabelActivoInicial_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtActivoInicial.DoubleClick, lblActivoFijoInicial.DoubleClick
        With txtActivoInicial
            .NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeActivosFijos_ACTMAFL0
            .GenerarConsulta()
            '-- En este caso la consulta devuelve 2 códigos, uno del tipo de activo
            '-- y el otro del correlativo, este no se utiliza
            '-- Se hace así porque el último que retorna la consulta es el correlativo
            If .CodigosRetorno.Count > 0 Then
                .Text = .CodigosRetorno.Item(0)
            End If
            .NombreDeConsulta = Nothing
        End With
    End Sub

    Private Sub ActivoInicial_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtActivoInicial.KeyUp
        If e.KeyCode = Keys.F4 Then
            Me.LabelActivoInicial_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub LabelActivoFinal_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtActivoFinal.DoubleClick, lblActivoFijoFinal.DoubleClick
        With txtActivoFinal
            .NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeActivosFijos_ACTMAFL0
            .GenerarConsulta()
            '-- En este caso la consulta devuelve 2 códigos, uno del tipo de activo
            '-- y el otro del correlativo, este no se utiliza
            '-- Se hace así porque el último que retorna la consulta es el correlativo
            If .CodigosRetorno.Count > 0 Then
                .Text = .CodigosRetorno.Item(0)
            End If
            .NombreDeConsulta = Nothing
        End With
    End Sub

    Private Sub ActivoFinal_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtActivoFinal.KeyUp
        If e.KeyCode = Keys.F4 Then
            Me.LabelActivoFinal_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub LabelCodigos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTipoActivoInicial.DoubleClick, lblTipoActivoFinal.DoubleClick, lblDivisionInicial.DoubleClick, lblDivisionFinal.Click
        Select Case sender.Name
            Case "lblTipoActivoInicial"
                Me.txtTipoActivoInicial.GenerarConsulta()
            Case "lblTipoActivoFinal"
                Me.txtTipoActivoFinal.GenerarConsulta()
            Case "lblDivisionInicial"
                Me.txtDivisionInicial.GenerarConsulta()
            Case "lblDivisionFinal"
                Me.txtDivisionFinal.GenerarConsulta()
        End Select
    End Sub

    Private Sub Codigos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoActivoInicial.Leave, txtTipoActivoFinal.Leave, txtDivisionInicial.Leave, txtDivisionFinal.Leave, txtActivoInicial.Leave, txtActivoFinal.Leave, txtAnioInicial.Leave
        Dim codigo As String = sender.Text
        Select Case sender.Name
            Case "txtTipoActivoInicial"
                Me.lblNombreTipoInicial.Text = DescripcionesDB.TipoDeActivo(codigo)
            Case "txtTipoActivoFinal"
                Me.lblNombreTipoFinal.Text = DescripcionesDB.TipoDeActivo(codigo)
            Case "txtDivisionInicial"
                Me.lblNombreDivisionInicial.Text = DescripcionesDB.Division(codigo)
            Case "txtDivisionFinal"
                Me.lblNombreDivisionFinal.Text = DescripcionesDB.Division(codigo)
            Case "txtActivoInicial"
                If Me.txtActivoFinal.Text = "" Then
                    Me.txtActivoFinal.Text = Me.txtActivoInicial.Text
                End If
            Case "txtActivoFinal"
                If Me.txtActivoInicial.Text = "" Then
                    Me.txtActivoInicial.Text = Me.txtActivoFinal.Text
                End If
        End Select
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If MyBase.ValidarCampos(grpFecha) = False Then
            Return
        End If

        MyBase.ErrorCampos.SetError(Me.cboMesInicial, Nothing)
        If cboMesInicial.SelectedValue.ToString = "" Then
            MyBase.ErrorCampos.SetError(cboMesInicial, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
            Return
        End If

        MyBase.ErrorCampos.SetError(Me.cboMesFinal, Nothing)
        If cboMesFinal.SelectedValue.ToString = "" Then
            MyBase.ErrorCampos.SetError(cboMesFinal, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
            Return
        End If

        MyBase.ErrorCampos.SetError(Me.txtAnioInicial, Nothing)
        Dim validarAnio As Integer = Me.txtAnioInicial.Text
        If validarAnio <= 1900 Then
            MyBase.ErrorCampos.SetError(txtAnioInicial, Citi.Synergia.Traductor.Idiomas.GetMensaje(245, "Año inválido"))
            Return
        End If

        MyBase.ErrorCampos.SetError(Me.txtAnioFinal, Nothing)
        Dim validarAniofinal As Integer = Me.txtAnioFinal.Text
        If validarAnio <= 1900 Then
            MyBase.ErrorCampos.SetError(txtAnioFinal, Citi.Synergia.Traductor.Idiomas.GetMensaje(245, "Año inválido"))
            Return
        End If

        Try
            Me.Filtros()

            Dim anioInicial As Integer = Me.txtAnioInicial.Text
            Dim anioFinal As Integer = Me.txtAnioFinal.Text

            meteSQL("Exec Proyecta_depreciaciones")
            meteSQL(" @MES_INI         =" & Scm(Me.cboMesInicial.SelectedValue.ToString))
            meteSQL(",@MES_FIN        =" & Scm(Me.cboMesFinal.SelectedValue.ToString))
            meteSQL(",@ANO_INI        =" & Scm(anioInicial))
            meteSQL(",@ANO_FIN        =" & Scm(anioFinal))
            meteSQL(",@CODIGO_ACT_INI =" & Scm(Me.txtActivoInicial.Text))
            meteSQL(",@CODIGO_ACT_FIN =" & Scm(Me.txtActivoFinal.Text))
            meteSQL(",@DIVISION_INI   =" & Scm(Me.txtDivisionInicial.Text))
            meteSQL(",@DIVISION_FIN   =" & Scm(Me.txtDivisionFinal.Text))
            meteSQL(",@TIPO_ACT_INI   =" & Scm(Me.txtTipoActivoInicial.Text))
            meteSQL(",@TIPO_ACT_FIN   =" & Scm(Me.txtTipoActivoFinal.Text))
            meteSQL(",@Usuario        =" & Scm(Citi.Synergia.Locals.Cache.UsuarioSSO))

            EjecutaSQL("")

            Dim filtro As String = String.Empty

            Dim clasificadoPor As String = String.Empty
            Dim codigoActivoInicial As String = String.Empty
            Dim codigoActivoFinal As String = String.Empty
            Dim divisionInicial As String = String.Empty
            Dim divisionFinal As String = String.Empty
            Dim mesInicial As String = String.Empty
            Dim mesFinal As String = String.Empty
            Dim tipoActivoInicial As String = String.Empty
            Dim tipoActivoFinal As String = String.Empty

            clasificadoPor = IIf(Me.radTipoDivision.Checked = True, "T", "D")
            codigoActivoInicial = Scm(Me.txtActivoInicial.Text)
            codigoActivoFinal = Scm(Me.txtActivoFinal.Text)
            divisionInicial = Scm(Me.txtDivisionInicial.Text)
            divisionFinal = Scm(Me.txtDivisionFinal.Text)
            mesInicial = Scm(Me.cboMesInicial.SelectedValue.ToString)
            mesFinal = Scm(Me.cboMesFinal.SelectedValue.ToString)
            tipoActivoInicial = Scm(Me.txtTipoActivoInicial.Text)
            tipoActivoFinal = Scm(Me.txtTipoActivoFinal.Text)


            'Citi.Synergia.Reportes.Crystal.Parametros.Clear()
            'With Citi.Synergia.Reportes.Crystal.Parametros
            '    .Add(New Citi.Synergia.Reportes.Campos("_AÑO_INI", Scm(Me.txtAnioInicial.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_AÑO_FIN", Scm(Me.txtAnioFinal.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_CLASIFICADO_POR", Scm(IIf(Me.radTipoDivision.Checked = True, "T", "D"))))
            '    .Add(New Citi.Synergia.Reportes.Campos("_CODIGO_ACT_INI", Scm(Me.txtActivoInicial.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_CODIGO_ACT_FIN", Scm(Me.txtActivoFinal.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_DIVISION_INI", Scm(Me.txtDivisionInicial.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_DIVISION_FIN", Scm(Me.txtDivisionFinal.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_EMPRESA", Scm(DescripcionesDB.TraeEmpresa())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_MES_INI", Scm(Me.cboMesInicial.SelectedValue.ToString)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_MES_FIN", Scm(Me.cboMesFinal.SelectedValue.ToString)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_TIPO_ACT_INI", Scm(Me.txtTipoActivoInicial.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_TIPO_ACT_FIN", Scm(Me.txtTipoActivoFinal.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_USUARIO", Scm(DescripcionesDB.TraeUsuario())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_IDIOMA", Scm(Citi.Synergia.Locals.Cache.IdiomaSeleccionado)))
            'End With

            'If Citi.Synergia.Reportes.Crystal.ValidaReporte("Proyeccion_depreciaciones", True) = False Then
            '    Return
            'End If

            'filtro = "{ACTIVOS_FIJOS.DEPRECIABLE} = 'S' and "
            'filtro = filtro & "{ACTIVOS_FIJOS.CODIGO_TIPO_ACTIVO} in {@_TIPO_ACT_INI} to {@_TIPO_ACT_FIN} and "
            'filtro = filtro & "{ACTIVOS_FIJOS.ESTATUS} = 'U' and "
            'filtro = filtro & "{ACTIVOS_FIJOS.CODIGO_DE_ACTIVO} in {@_CODIGO_ACT_INI} to {@_CODIGO_ACT_FIN} and "
            'filtro = filtro & "{ACTIVOS_FIJOS.CODIGO_DIVISION} in {@_DIVISION_INI} to {@_DIVISION_FIN}"

            'Citi.Synergia.Reportes.Crystal.EjecutarReporte("Proyeccion_depreciaciones", filtro, Citi.Synergia.Traductor.Idiomas.GetMensaje(271, "Depreciación activos"))


            filtro = String.Empty
            filtro = "a.ESTATUS = 'U'"
            filtro = filtro + " And a.DEPRECIABLE = 'S'"
            filtro = filtro + " And (a.CODIGO_TIPO_ACTIVO Between " + tipoActivoInicial + " And " + tipoActivoFinal + ")"
            filtro = filtro + " And (a.CODIGO_DE_ACTIVO Between " + codigoActivoInicial + " And " + codigoActivoFinal + ")"
            filtro = filtro + " And (a.CODIGO_DIVISION Between " + divisionInicial + " And " + divisionFinal + ")"
            If clasificadoPor = "T" Then
                filtro = filtro + " Order By a.CODIGO_TIPO_ACTIVO, a.CODIGO_DIVISION, a.CODIGO_DE_ACTIVO"
            Else
                filtro = filtro + " Order By a.CODIGO_DIVISION, a.CODIGO_TIPO_ACTIVO, a.CODIGO_DE_ACTIVO"
            End If

            Dim parametros As New List(Of String)
            With parametros
                .Add(anioInicial)
                .Add(anioFinal)
                .Add(clasificadoPor)
                .Add(codigoActivoInicial)
                .Add(codigoActivoFinal)
                .Add(divisionInicial)
                .Add(divisionFinal)
                .Add(mesInicial)
                .Add(mesFinal)
                .Add(tipoActivoInicial)
                .Add(tipoActivoFinal)
            End With

            Citi.Synergia.Reports.Reportes.EjecutarReporte(Citi.Synergia.Reports.Reportes.ListadoReportes.Proyeccion_depreciaciones, parametros, filtro)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class