Imports Citi.Synergia.HelperClient

Public Class ACTMVAN4
    Private Sub Forma_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()
    End Sub

    Private Sub Filtros()
        If Me.txtActivoInicial.Text = "" Then
            Me.txtActivoInicial.Text = DescripcionesDB.CodigoActivoMinimo()
        End If
        If Me.txtActivoFinal.Text = "" Then
            Me.txtActivoFinal.Text = DescripcionesDB.CodigoActivoMaximo()
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

    Private Sub TipoMovimiento_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTipoMovimiento.DoubleClick
        Me.txtTipoMovimiento.GenerarConsulta()
    End Sub

    Private Sub TipoMovimiento_Leave(sender As System.Object, e As System.EventArgs) Handles txtTipoMovimiento.Leave
        Dim claseMovimiento As String = DescripcionesDB.TipoMovimientoClase(Me.txtTipoMovimiento.Text)

        Select Case claseMovimiento
            Case "A"
                Me.lblNombreTipoMovimiento.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(61, "A - Alta").Replace("A - ", "").ToUpper
            Case "D"
                Me.lblNombreTipoMovimiento.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(62, "D - Desecho").Replace("D - ", "").ToUpper
            Case "P"
                Me.lblNombreTipoMovimiento.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(63, "P - Depreciación").Replace("P - ", "").ToUpper
            Case "R"
                Me.lblNombreTipoMovimiento.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(64, "R - Revaluación").Replace("R - ", "").ToUpper
            Case "I"
                Me.lblNombreTipoMovimiento.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(66, "I - Ajuste por Incremento al valor del activo").Replace("I - ", "").ToUpper
            Case "M"
                Me.lblNombreTipoMovimiento.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(67, "M - Ajuste por Disminución al valor del activo").Replace("M - ", "").ToUpper
            Case "V"
                Me.lblNombreTipoMovimiento.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(65, "V - Venta").Replace("V - ", "").ToUpper
            Case "G"
                Me.lblNombreTipoMovimiento.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(68, "G - Revaluación Masiva").Replace("G - ", "").ToUpper
            Case "N"
                Me.lblNombreTipoMovimiento.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(69, "N - Donación").Replace("N - ", "").ToUpper
        End Select
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim fechaInicial, fechaFinal As String

        System.Windows.Forms.Application.DoEvents()

        If MyBase.ValidarCampos(Me) = False Then
            Return
        End If

        fechaInicial = Me.txtFechaInicio.TextMMDDYYYY()
        fechaFinal = Me.txtFechaFin.TextMMDDYYYY()

        Try
            If Not MyBase.ValidaFecha(fechaInicial, fechaFinal) Then
                MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(202, "Fecha inicial es mayor que fecha final."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtFechaInicio.Focus()
                Return
            End If

            Me.Filtros()

            Dim filtro As String = String.Empty

            Dim codigoActivoInicial As String = String.Empty
            Dim codigoActivoFinal As String = String.Empty
            Dim fechaInicio As String = String.Empty
            Dim fechaFin As String = String.Empty
            Dim tipoMovimiento As String = String.Empty
            Dim tituloMomiviento As String = String.Empty

            codigoActivoInicial = Scm(Me.txtActivoInicial.Text)
            codigoActivoFinal = Scm(Me.txtActivoFinal.Text)
            fechaInicio = Me.txtFechaInicio.TextDDMMYYYY()
            fechaFin = Me.txtFechaFin.TextDDMMYYYY()
            tipoMovimiento = IIf(Trim(Me.txtTipoMovimiento.Text) = "", "0", Me.txtTipoMovimiento.Text)
            tituloMomiviento = IIf(Trim(Me.txtTipoMovimiento.Text) = "", Citi.Synergia.Traductor.Idiomas.GetMensaje(107, "T - Todos").Replace("T - ", "").ToUpper, Me.lblNombreTipoMovimiento.Text)

            'Citi.Synergia.Reportes.Crystal.Parametros.Clear()
            'With Citi.Synergia.Reportes.Crystal.Parametros
            '    .Add(New Citi.Synergia.Reportes.Campos("_ACTIVO_INI", Scm(Me.txtActivoInicial.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_ACTIVO_FIN", Scm(Me.txtActivoFinal.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_EMPRESA", Scm(DescripcionesDB.TraeEmpresa())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_FECHA_INI", "Date(" & fechaInicial.Substring(6, 4) & "," & fechaInicial.Substring(0, 2) & "," & fechaInicial.Substring(3, 2) & ")"))
            '    .Add(New Citi.Synergia.Reportes.Campos("_FECHA_FIN", "Date(" & fechaFinal.Substring(6, 4) & "," & fechaFinal.Substring(0, 2) & "," & fechaFinal.Substring(3, 2) & ")"))
            '    .Add(New Citi.Synergia.Reportes.Campos("_TIPO_MOV", sen(IIf(Trim(Me.txtTipoMovimiento.Text) = "", 0, Me.txtTipoMovimiento.Text))))
            '    .Add(New Citi.Synergia.Reportes.Campos("TITULO_MOVIMIENTO", Scm(IIf(Trim(Me.txtTipoMovimiento.Text) = "", Citi.Synergia.Traductor.Idiomas.GetMensaje(107, "T - Todos").Replace("T - ", "").ToUpper, Me.lblNombreTipoMovimiento.Text))))
            '    .Add(New Citi.Synergia.Reportes.Campos("_USUARIO", Scm(DescripcionesDB.TraeUsuario())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_IDIOMA", Scm(Citi.Synergia.Locals.Cache.IdiomaSeleccionado)))
            'End With

            'If Citi.Synergia.Reportes.Crystal.ValidaReporte("Reporte_de_movimientos", True) = False Then
            '    Return
            'End If

            'filtro = filtro & "{MOVIM_ACTIVOS.FECHA_MOVIMIENTO} in {@_FECHA_INI} to {@_FECHA_FIN} and "
            'filtro = filtro & "{MOVIM_ACTIVOS.CODIGO_DE_ACTIVO} in {@_ACTIVO_INI} to {@_ACTIVO_FIN} and "
            'If Me.txtTipoMovimiento.Text.Trim = "" Then
            '    filtro = filtro & "{MOVIM_ACTIVOS.TIPO_MOVIMIENTO} = {MOVIM_ACTIVOS.TIPO_MOVIMIENTO}"
            'Else
            '    filtro = filtro & "{MOVIM_ACTIVOS.TIPO_MOVIMIENTO} in {@_TIPO_MOV} to {@_TIPO_MOV}"
            'End If

            'Citi.Synergia.Reportes.Crystal.EjecutarReporte("Reporte_de_movimientos", filtro, Citi.Synergia.Traductor.Idiomas.GetMensaje(272, "Movimiento de activos"))


            filtro = String.Empty
            filtro = "(m.FECHA_MOVIMIENTO Between Convert(Datetime, '" + fechaInicio + "', 103) And Convert(Datetime, '" + fechaFin + "', 103))"
            filtro = filtro + " And (m.CODIGO_DE_ACTIVO Between " + codigoActivoInicial + " And " + codigoActivoFinal + ")"
            If Me.txtTipoMovimiento.Text.Trim = "" Then
                filtro = filtro & " And m.TIPO_MOVIMIENTO = m.TIPO_MOVIMIENTO"
            Else
                filtro = filtro & " And (m.TIPO_MOVIMIENTO Between " + tipoMovimiento + " And " + tipoMovimiento + ")"
            End If

            Dim parametros As New List(Of String)
            With parametros
                .Add(codigoActivoInicial)
                .Add(codigoActivoFinal)
                .Add(fechaInicio)
                .Add(fechaFin)
                .Add(tipoMovimiento)
                .Add(tituloMomiviento)
            End With

            Citi.Synergia.Reports.Reportes.EjecutarReporte(Citi.Synergia.Reports.Reportes.ListadoReportes.Reporte_de_movimientos, parametros, filtro)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class