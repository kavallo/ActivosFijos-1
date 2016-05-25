Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports Citi.Synergia.HelperClient

Public Class ACTMAFN3
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()

        Me.LlenarCombos()

        If Citi.Synergia.Locals.Cache.ProveedoresInvisibles Then
            Me.grpProveedor.Visible = False
            Me.chkSoloDeaparecidos.Top = 271
            Me.cmdAceptar.Top = 302
            Me.cmdCancelar.Top = Me.cmdAceptar.Top
            Me.Height = 363
        Else
            Me.grpProveedor.Visible = True
            Me.chkSoloDeaparecidos.Top = 348
            Me.cmdAceptar.Top = 379
            Me.cmdCancelar.Top = Me.cmdAceptar.Top
            Me.Height = 441
        End If
    End Sub

    Private Sub LlenarCombos()
        Dim estatus As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With estatus
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(104, "D - Desechado")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("P", Citi.Synergia.Traductor.Idiomas.GetMensaje(103, "P - Pendiente")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("U", Citi.Synergia.Traductor.Idiomas.GetMensaje(102, "U - Actualizado")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("V", Citi.Synergia.Traductor.Idiomas.GetMensaje(105, "V - Vendidos")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(106, "N - Donado")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("T", Citi.Synergia.Traductor.Idiomas.GetMensaje(107, "T - Todos")))
        End With
        With cboEstatus
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = estatus
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

        If Citi.Synergia.Locals.Cache.ProveedoresInvisibles = False Then
            If Me.txtProveedorInicial.Text = "" Then
                Me.txtProveedorInicial.Text = DescripcionesDB.CodigoProveedorMinimo()
                Me.Codigos_Leave(txtProveedorInicial, Nothing)
            End If
            If Me.txtProveedorFinal.Text = "" Then
                Me.txtProveedorFinal.Text = DescripcionesDB.CodigoProveedorMaximo()
                Me.Codigos_Leave(txtProveedorFinal, Nothing)
            End If
        Else
            Me.txtProveedorInicial.Text = "0"
            Me.txtProveedorFinal.Text = "0"
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

    Private Sub Codigos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoActivoInicial.Leave, txtTipoActivoFinal.Leave, txtDivisionInicial.Leave, txtDivisionFinal.Leave, txtProveedorInicial.Leave, txtProveedorFinal.Leave
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
            Case "txtProveedorInicial"
                Me.lblNombreProveedorInicial.Text = DescripcionesDB.Proveedor(codigo)
            Case "txtProveedorFinal"
                lblNombreProveedorFinal.Text = DescripcionesDB.Proveedor(codigo)
        End Select
    End Sub

    Private Sub ListaProveedorInicial_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProveedorInicial.DoubleClick, lblProveedorInicial.DoubleClick
        Dim codigoProveedor As String = String.Empty
        Dim frmLista As New PROVEC01
        With frmLista
            .ShowDialog()
            codigoProveedor = .CodigoProveedor
            .Dispose()
        End With
        If codigoProveedor <> "" Then
            Me.txtProveedorInicial.Text = codigoProveedor
        End If
    End Sub

    Private Sub ProveedorInicial_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtProveedorInicial.KeyUp
        If e.KeyCode = Keys.F4 Then
            Me.ListaProveedorInicial_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub ListaProveedorFinal_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProveedorFinal.DoubleClick, lblProveedorFinal.DoubleClick
        Dim codigoProveedor As String = String.Empty
        Dim frmLista As New PROVEC01
        With frmLista
            .ShowDialog()
            codigoProveedor = .CodigoProveedor
            .Dispose()
        End With
        If codigoProveedor <> "" Then
            Me.txtProveedorFinal.Text = codigoProveedor
        End If
    End Sub

    Private Sub ProveedorFinal_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtProveedorFinal.KeyUp
        If e.KeyCode = Keys.F4 Then
            Me.ListaProveedorFinal_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            MyBase.ErrorCampos.SetError(Me.cboEstatus, Nothing)
            If cboEstatus.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboEstatus, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Return
            End If

            '-- Filtros
            Me.Filtros()

            Dim filtro As String = String.Empty

            Dim codigoActivoInicial As String = String.Empty
            Dim codigoActivoFinal As String = String.Empty
            Dim desaparecido As String = String.Empty
            Dim divisionInicial As String = String.Empty
            Dim divisionFinal As String = String.Empty
            Dim estado As String = String.Empty
            Dim proveedorInicial As String = String.Empty
            Dim proveedorFinal As String = String.Empty
            Dim tipoActivoInicial As String = String.Empty
            Dim tipoActivoFinal As String = String.Empty

            codigoActivoInicial = Scm(Me.txtActivoInicial.Text)
            codigoActivoFinal = Scm(Me.txtActivoFinal.Text)
            desaparecido = Scm(IIf(Me.chkSoloDeaparecidos.Checked, "1", "0"))
            divisionInicial = Scm(Me.txtDivisionInicial.Text)
            divisionFinal = Scm(Me.txtDivisionFinal.Text)
            estado = Scm(Me.cboEstatus.SelectedValue.ToString)
            proveedorInicial = sen(Me.txtProveedorInicial.GetValor())
            proveedorFinal = sen(Me.txtProveedorFinal.GetValor())
            tipoActivoInicial = Scm(Me.txtTipoActivoInicial.Text)
            tipoActivoFinal = Scm(Me.txtTipoActivoFinal.Text)

            'Citi.Synergia.Reportes.Crystal.Parametros.Clear()
            'With Citi.Synergia.Reportes.Crystal.Parametros
            '    .Add(New Citi.Synergia.Reportes.Campos("_CODIGO_ACT_INI", Scm(Me.txtActivoInicial.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_CODIGO_ACT_FIN", Scm(Me.txtActivoFinal.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_DESAPARECIDO", Scm(IIf(Me.chkSoloDeaparecidos.Checked, "1", "0"))))
            '    .Add(New Citi.Synergia.Reportes.Campos("_DIVISION_INI", Scm(Me.txtDivisionInicial.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_DIVISION_FIN", Scm(Me.txtDivisionFinal.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_EMPRESA", Scm(DescripcionesDB.TraeEmpresa())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_ESTADO", Scm(Me.cboEstatus.SelectedValue.ToString)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_PROVEEDOR_INI", sen(Me.txtProveedorInicial.GetValor())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_PROVEEDOR_FIN", sen(Me.txtProveedorFinal.GetValor())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_TIPO_ACT_INI", Scm(Me.txtTipoActivoInicial.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_TIPO_ACT_FIN", Scm(Me.txtTipoActivoFinal.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_USUARIO", Scm(DescripcionesDB.TraeUsuario())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_IDIOMA", Scm(Citi.Synergia.Locals.Cache.IdiomaSeleccionado)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_OCULTA_PROVEEDORES", sen(IIf(Citi.Synergia.Locals.Cache.ProveedoresInvisibles, "1", "0"))))
            'End With

            'If Citi.Synergia.Reportes.Crystal.ValidaReporte("Catalogo_activos_fijos", True) = False Then
            '    Return
            'End If

            'filtro = "{ACTIVOS_FIJOS.CODIGO_DIVISION} in {@_DIVISION_INI} to {@_DIVISION_FIN} and "
            'If Not Citi.Synergia.Locals.Cache.ProveedoresInvisibles Then
            '    filtro = filtro & "({ACTIVOS_FIJOS.CODIGO_PROVEEDOR} in {@_PROVEEDOR_INI} to {@_PROVEEDOR_FIN} or isNull ({ACTIVOS_FIJOS.CODIGO_PROVEEDOR})) and "
            'End If
            'filtro = filtro & "{ACTIVOS_FIJOS.CODIGO_TIPO_ACTIVO} in {@_TIPO_ACT_INI} to {@_TIPO_ACT_FIN} and "
            'filtro = filtro & "{ACTIVOS_FIJOS.CODIGO_DE_ACTIVO} in {@_CODIGO_ACT_INI} to {@_CODIGO_ACT_FIN} and "
            'If Me.cboEstatus.SelectedValue.ToString = "T" Then
            '    filtro = filtro & "{ACTIVOS_FIJOS.ESTATUS} = {ACTIVOS_FIJOS.ESTATUS} and "
            'Else
            '    filtro = filtro & "{ACTIVOS_FIJOS.ESTATUS} = {@_ESTADO} and "
            'End If
            'filtro = filtro & "{@FILTRO_DESAPARECIDO_TABLA} = {@FILTRO_DESAPARECIDO}"

            'Citi.Synergia.Reportes.Crystal.EjecutarReporte("Catalogo_activos_fijos", filtro, Citi.Synergia.Traductor.Idiomas.GetMensaje(268, "Catálogo de activos"))

            filtro = String.Empty
            If Not Citi.Synergia.Locals.Cache.ProveedoresInvisibles Then
                filtro = filtro & "(a.CODIGO_PROVEEDOR Between " + proveedorInicial + " And " + proveedorFinal + " or a.CODIGO_PROVEEDOR is null) and "
            End If
            filtro = filtro + "(a.CODIGO_TIPO_ACTIVO Between " + tipoActivoInicial + " And " + tipoActivoFinal + ") and "
            filtro = filtro + "(a.CODIGO_DE_ACTIVO Between " + codigoActivoInicial + " And " + codigoActivoFinal + ") and "
            filtro = filtro + "(a.CODIGO_DIVISION Between " + divisionInicial + " And " + divisionFinal + ") and "
            If estado = "'T'" Then
                filtro = filtro + "a.ESTATUS = a.ESTATUS and "
            Else
                filtro = filtro + "a.ESTATUS = " + estado + " and "
            End If
            If desaparecido = "1" Then
                filtro = filtro + "IsNull(a.DESAPARECIDO, '-jp') = 'S'"
            Else
                filtro = filtro + "IsNull(a.DESAPARECIDO, '-jp') = IsNull(a.DESAPARECIDO, '-jp')"
            End If

            If desaparecido = "'1'" Then
                desaparecido = Citi.Synergia.Traductor.Idiomas.GetMensaje(85, "YES").Replace("1 - ", "").ToUpper
            Else
                desaparecido = Citi.Synergia.Traductor.Idiomas.GetMensaje(86, "NO").Replace("0 - ", "").ToUpper
            End If

            Dim parametros As New List(Of String)
            With parametros
                .Add(codigoActivoInicial)
                .Add(codigoActivoFinal)
                .Add(divisionInicial)
                .Add(divisionFinal)
                .Add(tipoActivoInicial)
                .Add(tipoActivoFinal)
                .Add(proveedorInicial)
                .Add(proveedorFinal)
                .Add(estado)
                .Add(desaparecido)
            End With

            Citi.Synergia.Reports.Reportes.EjecutarReporte(Citi.Synergia.Reports.Reportes.ListadoReportes.Catalogo_activos_fijos, parametros, filtro)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class