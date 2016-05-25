Imports Citi.Synergia.HelperClient

Public Class ACTMAFN6
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()

        Me.LlenarCombos()
    End Sub

    Private Sub LlenarCombos()
        Dim totalizado As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With totalizado
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("1", Citi.Synergia.Traductor.Idiomas.GetMensaje(100, "1 - Tipo De Activo,Division")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("2", Citi.Synergia.Traductor.Idiomas.GetMensaje(101, "2 - Division      ,Tipo De Activo")))
        End With
        With cboTotalizado
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = totalizado
        End With

        Dim estatus As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With estatus
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("U", Citi.Synergia.Traductor.Idiomas.GetMensaje(102, "U - Actualizados")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("P", Citi.Synergia.Traductor.Idiomas.GetMensaje(103, "P - Pendientes")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(104, "D - Desechados")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("V", Citi.Synergia.Traductor.Idiomas.GetMensaje(105, "V - Vendidos")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(106, "N - Donados")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("T", Citi.Synergia.Traductor.Idiomas.GetMensaje(107, "T - Todos")))
        End With
        With cboEstatus
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = estatus
        End With
    End Sub

    Private Sub Filtros()
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

    Private Sub Codigos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoActivoInicial.Leave, txtTipoActivoFinal.Leave, txtDivisionInicial.Leave, txtDivisionFinal.Leave
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
        End Select
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        MyBase.ErrorCampos.SetError(Me.cboTotalizado, Nothing)
        If cboTotalizado.SelectedValue.ToString = "" Then
            MyBase.ErrorCampos.SetError(cboTotalizado, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
            Return
        End If

        MyBase.ErrorCampos.SetError(Me.cboEstatus, Nothing)
        If cboEstatus.SelectedValue.ToString = "" Then
            MyBase.ErrorCampos.SetError(cboEstatus, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
            Return
        End If

        If MyBase.ValidarCampos(grpClasificacion) = False Then
            Return
        End If

        Me.Filtros()

        Dim filtro As String = String.Empty

        Dim excluye As String = String.Empty
        If Me.radTodos.Checked Then
            excluye = "0"
        End If
        If Me.radConValor.Checked Then
            excluye = "1"
        End If
        If Me.radSinValor.Checked Then
            excluye = "2"
        End If

        Try
            'Obtenemos los datos para impresion
            meteSQL("Exec Reconstruccion_depreciacion_activos")
            meteSQL("     @FECHA_RECONSTRUCCION = " & Scm(Me.txtFecha.TextMMDDYYYY()))
            meteSQL("   , @TIPO_ACT_INI         = " & Scm(Me.txtTipoActivoInicial.Text))
            meteSQL("   , @TIPO_ACT_FIN         = " & Scm(Me.txtTipoActivoFinal.Text))
            meteSQL("   , @DIVISION_INI         = " & Scm(Me.txtDivisionInicial.Text))
            meteSQL("   , @DIVISION_FIN         = " & Scm(Me.txtDivisionFinal.Text))
            meteSQL("   , @EXCLUYE              = " & Scm(excluye))
            meteSQL("   , @Usuario              = " & Scm(Citi.Synergia.Locals.Cache.UsuarioSSO))

            EjecutaSQL("")

            Dim fecha As String = Me.txtFecha.TextMMDDYYYY()

            Dim clasificadoPor As String = String.Empty
            Dim divisionInicial As String = String.Empty
            Dim divisionFinal As String = String.Empty
            Dim tipoActivoInicial As String = String.Empty
            Dim tipoActivoFinal As String = String.Empty
            Dim estado As String = String.Empty

            clasificadoPor = IIf(Me.cboTotalizado.SelectedValue.ToString = "1", "T", "D")
            divisionInicial = Scm(Me.txtDivisionInicial.Text)
            divisionFinal = Scm(Me.txtDivisionFinal.Text)
            tipoActivoInicial = Scm(Me.txtTipoActivoInicial.Text)
            tipoActivoFinal = Scm(Me.txtTipoActivoFinal.Text)
            estado = Scm(Me.cboEstatus.SelectedValue.ToString)

            'Citi.Synergia.Reportes.Crystal.Parametros.Clear()
            'With Citi.Synergia.Reportes.Crystal.Parametros
            '    .Add(New Citi.Synergia.Reportes.Campos("_A_FECHA", "Date(" & fecha.Substring(6, 4) & "," & fecha.Substring(0, 2) & "," & fecha.Substring(3, 2) & ")"))
            '    .Add(New Citi.Synergia.Reportes.Campos("_CLASIFICADO_POR", Scm(IIf(Me.cboTotalizado.SelectedValue.ToString = "1", "T", "D"))))
            '    .Add(New Citi.Synergia.Reportes.Campos("_DIVISION_INICIAL", Scm(Me.txtDivisionInicial.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_DIVISION_FINAL", Scm(Me.txtDivisionFinal.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_EMPRESA", Scm(DescripcionesDB.TraeEmpresa())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_TIPO_INI", Scm(Me.txtTipoActivoInicial.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_TIPO_FIN", Scm(Me.txtTipoActivoFinal.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_USUARIO", Scm(DescripcionesDB.TraeUsuario())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_ESTADO", Scm(Me.cboEstatus.SelectedValue.ToString)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_IDIOMA", Scm(Citi.Synergia.Locals.Cache.IdiomaSeleccionado)))
            'End With

            'If Citi.Synergia.Reportes.Crystal.ValidaReporte("General_activos_fijos", True) = False Then
            '    Return
            'End If

            'filtro = "{ACTIVOS_FIJOS.CODIGO_TIPO_ACTIVO} in {@_TIPO_INI} to {@_TIPO_FIN} and "
            'filtro = filtro & "{ACTIVOS_FIJOS.FECHA_ADQUISICION} <= {@_A_FECHA} and "
            'filtro = filtro & "{ACTIVOS_FIJOS.CODIGO_DIVISION} in {@_DIVISION_INICIAL} to {@_DIVISION_FINAL} and "
            'filtro = filtro & "{RPT_ACTIVO_DEPRECIACION.USUARIO} = {@_USUARIO} and "
            'If Me.cboEstatus.SelectedValue.ToString = "T" Then
            '    filtro = filtro & "{ACTIVOS_FIJOS.ESTATUS} = {ACTIVOS_FIJOS.ESTATUS}"
            'Else
            '    filtro = filtro & "{ACTIVOS_FIJOS.ESTATUS} = {@_ESTADO}"
            'End If

            'Citi.Synergia.Reportes.Crystal.EjecutarReporte("General_activos_fijos", filtro, Citi.Synergia.Traductor.Idiomas.GetMensaje(270, "General activos"))

            fecha = Me.txtFecha.TextDDMMYYYY()

            filtro = String.Empty
            filtro = "(a.CODIGO_TIPO_ACTIVO Between " + tipoActivoInicial + " And " + tipoActivoFinal + ")"
            filtro = filtro + " And a.FECHA_ADQUISICION <= Convert(Datetime, '" + fecha + "',103)"
            filtro = filtro + " And (a.CODIGO_DIVISION Between " + divisionInicial + " And " + divisionFinal + ")"
            filtro = filtro + " And r.USUARIO = " + Scm(Citi.Synergia.Locals.Cache.UsuarioSSO) '-- DescripcionesDB.TraeUsuario())
            If Me.cboEstatus.SelectedValue.ToString = "T" Then
                filtro = filtro & " And a.ESTATUS = a.ESTATUS"
            Else
                filtro = filtro & " And a.ESTATUS = " + estado
            End If

            Dim tituloClasificacion As String = String.Empty
            If clasificadoPor = "T" Then
                filtro = filtro + " Order By a.CODIGO_TIPO_ACTIVO, a.CODIGO_DE_ACTIVO"
                tituloClasificacion = "CLASSIFIED BY ASSET TYPE - DEPARTMENT"
            Else
                filtro = filtro + " Order By a.CODIGO_DIVISION, a.CODIGO_DE_ACTIVO"
                tituloClasificacion = "CLASSIFIED BY DEPARTMENT - ASSET TYPE"
            End If

            Dim parametros As New List(Of String)
            With parametros
                .Add(tituloClasificacion)
                .Add(tipoActivoInicial)
                .Add(tipoActivoFinal)
                .Add(divisionInicial)
                .Add(divisionFinal)
                .Add(estado)
                .Add(excluye)
                .Add(clasificadoPor)
                .Add(fecha)
            End With

            Citi.Synergia.Reports.Reportes.EjecutarReporte(Citi.Synergia.Reports.Reportes.ListadoReportes.General_activos_fijos, parametros, filtro)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class