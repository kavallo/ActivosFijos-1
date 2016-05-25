Imports Citi.Synergia.HelperClient

Public Class ACTMVAN3
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()

        Me.LlenarCombos()

        'Opeact, envia año y mes para reporte,
        'Repact, no envia y el usario define los valores
        If Pop() Then
            Me.txtAnio.Text = Pop()
            Me.cboMeses.SelectedValue = Pop()
            Me.txtAnio.Enabled = False
        Else
            Me.txtAnio.Enabled = True
        End If
        Me.cboMeses.Enabled = Me.txtAnio.Enabled
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

        Dim meses As List(Of Citi.Synergia.Entidades.CodigoDescripcion) = Citi.Synergia.HelperClient.Utils.ListaDeMeses()
        With cboMeses
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = meses
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
        Dim fecha As String
        Dim fechaRecons As Date

        If MyBase.ValidarCampos(Me) = False Then
            Return
        End If

        MyBase.ErrorCampos.SetError(Me.txtAnio, Nothing)
        Dim validarAnio As Integer = Me.txtAnio.Text
        If validarAnio <= 1900 Then
            MyBase.ErrorCampos.SetError(txtAnio, Citi.Synergia.Traductor.Idiomas.GetMensaje(245, "Año inválido"))
            Return
        End If

        MyBase.ErrorCampos.SetError(Me.cboMeses, Nothing)
        If cboMeses.SelectedValue.ToString = "" Then
            MyBase.ErrorCampos.SetError(cboMeses, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
            Return
        End If

        MyBase.ErrorCampos.SetError(Me.cboTotalizado, Nothing)
        If cboTotalizado.SelectedValue.ToString = "" Then
            MyBase.ErrorCampos.SetError(cboTotalizado, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
            Return
        End If

        Me.Filtros()

        Try
            Dim dia As String = String.Empty
            Dim mes As String = String.Empty
            Dim anio As String = String.Empty

            dia = "01"
            mes = Me.cboMeses.SelectedValue.ToString
            If mes.Length = 1 Then
                mes = "0" & mes
            End If
            anio = Me.txtAnio.Text

            fechaRecons = New DateTime(anio, mes, dia).ToString("d")

            '-- fechaRecons se desea que sea el último día del mes ingresado
            fechaRecons = New DateTime(anio, mes, Date.DaysInMonth(anio, mes)).ToString("d")

            dia = fechaRecons.Day.ToString
            mes = fechaRecons.Month.ToString
            anio = fechaRecons.Year.ToString

            If dia.Length = 1 Then
                dia = "0" & dia
            End If
            If mes.Length = 1 Then
                mes = "0" & mes
            End If
            fecha = mes & "/" & dia & "/" & anio

            'obtencion de datos para impresion
            meteSQL("Exec Reconstruccion_depreciacion_activos")
            meteSQL("     @FECHA_RECONSTRUCCION  =" & Scm(fecha))
            If TodosLosAños.Checked Then
                meteSQL("   , @FECHA_INICIAL        = '01/01/1900'")
            End If
            meteSQL("   , @TIPO_ACT_INI         =" & Scm(Me.txtTipoActivoInicial.Text))
            meteSQL("   , @TIPO_ACT_FIN         =" & Scm(Me.txtTipoActivoFinal.Text))
            meteSQL("   , @DIVISION_INI         =" & Scm(Me.txtDivisionInicial.Text))
            meteSQL("   , @DIVISION_FIN         =" & Scm(Me.txtDivisionFinal.Text))
            meteSQL("   , @Usuario              =" & Scm(Citi.Synergia.Locals.Cache.UsuarioSSO))

            EjecutaSQL("")

            '-- Antes reviso si hay pendientes
            Dim tipoMovimiento As Integer = TraeDato("Select TIPO_MOVIMIENTO From TIPO_MOV_ACTIVOS Where CLASE_MOVIMIENTO = 'P'")

            If tipoMovimiento = 0 Then
                Exit Sub
            End If

            Dim contador As Integer = 0
            contador = TraeDato("Select IsNull(Count(*), 0) From MOVIM_ACTIVOS Where TIPO_MOVIMIENTO = " & tipoMovimiento & "And ESTADO_MOVIMIENTO = 'P' and FECHA_MOVIMIENTO  <= " & Scm(fecha))

            Dim textoPreliminar As String = String.Empty
            If contador > 0 Then
                textoPreliminar = "PRELIMINARY INFORMATION"
            End If

            Dim filtro As String = String.Empty

            Dim clasificadoPor As String = String.Empty
            Dim divisionInicial As String = String.Empty
            Dim divisionFinal As String = String.Empty
            Dim fechaReconstruir As String = String.Empty
            Dim tipoActivoInicial As String = String.Empty
            Dim tipoActivoFinal As String = String.Empty

            clasificadoPor = IIf(Me.cboTotalizado.SelectedValue.ToString = "1", "T", "D")
            divisionInicial = Scm(Me.txtDivisionInicial.Text)
            divisionFinal = Scm(Me.txtDivisionFinal.Text)
            fechaReconstruir = dia + "/" + mes + "/" + anio
            tipoActivoInicial = Scm(Me.txtTipoActivoInicial.Text)
            tipoActivoFinal = Scm(Me.txtTipoActivoFinal.Text)

            'Citi.Synergia.Reportes.Crystal.Parametros.Clear()
            'With Citi.Synergia.Reportes.Crystal.Parametros
            '    .Add(New Citi.Synergia.Reportes.Campos("_CLASIFICADO_POR", Scm(IIf(Me.cboTotalizado.SelectedValue.ToString = "1", "T", "D"))))
            '    .Add(New Citi.Synergia.Reportes.Campos("_DIVISION_INI", Scm(Me.txtDivisionInicial.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_DIVISION_FIN", Scm(Me.txtDivisionFinal.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_EMPRESA", Scm(DescripcionesDB.TraeEmpresa())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_FECHA_RECONSTRUIR", "date (" & anio & "," & mes & "," & dia & ")"))
            '    .Add(New Citi.Synergia.Reportes.Campos("_TIPO_ACT_INI", Scm(Me.txtTipoActivoInicial.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_TIPO_ACT_FIN", Scm(Me.txtTipoActivoFinal.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_USUARIO", Scm(DescripcionesDB.TraeUsuario())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_IDIOMA", Scm(Citi.Synergia.Locals.Cache.IdiomaSeleccionado)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_PRELIMINAR", Scm(textoPreliminar)))
            'End With

            'If Citi.Synergia.Reportes.Crystal.ValidaReporte("Reporte_depreciaciones", True) = False Then
            '    Return
            'End If

            'filtro = "{RPT_ACTIVO_DEPRECIACION.MOVIMIENTO_ANUAL_DEP} <> $0.00 and "
            'filtro = filtro & "{DIVISIONES.CODIGO_DIVISION} in {@_DIVISION_INI} to {@_DIVISION_FIN} and "
            'filtro = filtro & "{TIPOS_DE_ACTIVOS.CODIGO_TIPO_ACTIVO} in {@_TIPO_ACT_INI} to {@_TIPO_ACT_FIN} and "
            'filtro = filtro & "{RPT_ACTIVO_DEPRECIACION.USUARIO} = {@_USUARIO} and "
            'filtro = filtro & "{ACTIVOS_FIJOS.ESTATUS} = {@FILTRO_ESTADO_DEPRE}"

            'Citi.Synergia.Reportes.Crystal.EjecutarReporte("Reporte_depreciaciones", filtro, Citi.Synergia.Traductor.Idiomas.GetMensaje(271, "Depreciación de activos"))


            filtro = String.Empty
            filtro = "r.MOVIMIENTO_ANUAL_DEP <> 0"
            filtro = filtro + " And (d.CODIGO_DIVISION Between " + divisionInicial + " AND " + divisionFinal + ")"
            filtro = filtro + " And (t.CODIGO_TIPO_ACTIVO Between " + tipoActivoInicial + " AND " + tipoActivoFinal + ")"
            filtro = filtro + " And r.USUARIO = " + Scm(Citi.Synergia.Locals.Cache.UsuarioSSO) 'DescripcionesDB.TraeUsuario())
            If clasificadoPor = "T" Then
                filtro = filtro + " Order By t.CODIGO_TIPO_ACTIVO, d.CODIGO_DIVISION"
            Else
                filtro = filtro + " Order By d.CODIGO_DIVISION, t.CODIGO_TIPO_ACTIVO"
            End If

            Dim parametros As New List(Of String)
            With parametros
                .Add(tipoActivoInicial)
                .Add(tipoActivoFinal)
                .Add(divisionInicial)
                .Add(divisionFinal)
                .Add(fechaReconstruir)
                .Add(textoPreliminar)
                .Add(clasificadoPor)
                .Add(IIf(TodosLosAños.Checked, "S", "N"))
            End With

            Citi.Synergia.Reports.Reportes.EjecutarReporte(Citi.Synergia.Reports.Reportes.ListadoReportes.Reporte_depreciaciones, parametros, filtro)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class