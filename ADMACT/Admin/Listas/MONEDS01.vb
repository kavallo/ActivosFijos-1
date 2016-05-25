Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.HelperClient

Public Class MONEDS01
    Private varTIPO_DE_CAMBIO As String = String.Empty
    Private CODMON As String = String.Empty
    Private DESMON As String = String.Empty
    Private TASCAM As String = String.Empty
    Private StrQuery As String = String.Empty

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuAgregar.Text = Me.cmdAgregar.Texto
        Me.mnuBorrar.Text = Me.cmdBorrar.Texto
        Me.mnuModificar.Text = Me.cmdModificar.Texto
        Me.mnuTasasDeCambio.Text = Me.BotonTasasDeCambio.Texto
        Me.mnuGrafica.Text = Me.BotonGrafica.Texto
        Me.mnuReporte.Text = Me.BotonReporte.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos.Iconos

            Me.IconosMenus.Images.Clear()
            '-- Agregar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Agregar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Borrar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Borrar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Modificar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Modificar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Tasas de Cambio
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.TasasDeCambio).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Gráfica de tasas de cambio
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Graficar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Reporte
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Reporte).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.cmdAgregar.Image = Me.IconosMenus.Images(0)
            Me.mnuAgregar.Image = Me.cmdAgregar.Image
            Me.cmdBorrar.Image = Me.IconosMenus.Images(1)
            Me.mnuBorrar.Image = Me.cmdBorrar.Image
            Me.cmdModificar.Image = Me.IconosMenus.Images(2)
            Me.mnuModificar.Image = Me.cmdModificar.Image
            Me.BotonTasasDeCambio.Image = Me.IconosMenus.Images(3)
            Me.mnuTasasDeCambio.Image = Me.BotonTasasDeCambio.Image
            Me.BotonGrafica.Image = Me.IconosMenus.Images(4)
            Me.mnuGrafica.Image = Me.BotonGrafica.Image
            Me.BotonReporte.Image = Me.IconosMenus.Images(5)
            Me.mnuReporte.Image = Me.BotonReporte.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(6)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MyBase.SetearPosiciones()

        Me.LlenarEncabezado()

        Me.LlenarParam()

        MyBase.LlenarSelNav()
        'MyBase.LlenarSelNavConSP()
    End Sub

    Private Sub LlenarEncabezado()
        Try
            meteSQL("select P.CODIGO_DE_MONEDA, M.DESCRIPCION_MONEDA, P.TIPO_DE_CAMBIO, P.FORMA_CALCULO_CAMBIO")
            meteSQL(" from PARAMETRO_GENERALES P, MONEDAS M")
            meteSQL(" where P.CODIGO_DE_MONEDA = M.CODIGO_DE_MONEDA")

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                lblCODIGO_DE_MONEDA.Text = SqlData(Sqlconn, 1).ToString
                lblDESCRIPCION_MONEDA.Text = SqlData(Sqlconn, 2).ToString
                varTIPO_DE_CAMBIO = SqlData(Sqlconn, 3).ToString
                varFORMA_CALCULO_CAMBIO.Text = SqlData(Sqlconn, 4).ToString
            Loop

            Select Case varFORMA_CALCULO_CAMBIO.Text
                Case "V"
                    nameFORMA_CALCULO_CAMBIO.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(42, "Tasa de Venta")
                Case "C"
                    nameFORMA_CALCULO_CAMBIO.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(43, "Tasa de Compra")
                Case "P"
                    nameFORMA_CALCULO_CAMBIO.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(44, "Tasa Promedio")
            End Select

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LlenarParam()
        NumCols = 3
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        '### 27/11/2015 ###
        StrQuery = "Isnull( (Select Top 1 Case P.TIPO_DE_CAMBIO When 'D' Then TC.TASA_COMPRA When 'V' then TC.TASA_CONVERSION 
When 'C' then TC.TASA_COMPRA When 'P' Then (TC.TASA_CONVERSION + TC.TASA_COMPRA)/2 End 
from TASAS_DE_CAMBIO TC Join PARAMETRO_GENERALES P On (TC.TIP_CAMBIO_TASAS_CAM = P.TIPO_DE_CAMBIO) 
Where TC.CODIGO_DE_MONEDA = M.CODIGO_DE_MONEDA Order by TC.FECHA_DE_LA_TASA desc), 0)"

        MeterParam(1, Info, 1, "Moneda", 10, InfoLista.TipoAlineacion.ALINEAR_IZQ, "CODIGO_DE_MONEDA", 47, 6, 0, 1, 40)
        MeterParam(2, Info, 1, "Descripción", 30, InfoLista.TipoAlineacion.ALINEAR_IZQ, "DESCRIPCION_MONEDA", 47, 30, 0, 0, 12)
        MeterParam(3, Info, 1, "Tasa Conversión", 10, ALINEAR_DER, StrQuery, 56, 10, 2, 0, 41)
        'MeterParam(3, Info, 1, "Tasa Conversión", 15, ALINEAR_DER, "TASA_DE_CAMBIO", 56, 10, 2, 0, 41)
        'snCampos = CrearParam(Info, Me)

        snCond = ""
        'snProcedimiento = "execute sp_Llena_SELNAV_MONEDAS " & Scm(varFORMA_CALCULO_CAMBIO.Text) & ", " & Scm(varTIPO_DE_CAMBIO) & ", " & Scm(CODMON) & ", " & Scm(DESMON) & ", " & sen(TASCAM)
        snTabla = "MONEDAS M"
    End Sub

    Private Sub Modificar()
        If LlenarLlaves() Then
            Dim frmModificar As New MONEDM02
            With frmModificar
                .Modo_Local = Modo_Cambio
                .Pila = Me.Pila
                .ShowDialog()
                If .HubieronCambios Then
                    Me.LlenarEncabezado()
                    MyBase.LlenarSelNavConSP()
                End If
                .Dispose()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub SeleccionaFila(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Me.Modificar()
    End Sub

    Private Sub Agregar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click, mnuAgregar.Click
        Dim frmAgregar As New MONEDM02
        With frmAgregar
            .Modo_Local = Modo_Alta
            .Push("")
            .ShowDialog()
            If .HubieronCambios Then
                Me.LlenarEncabezado()
                MyBase.LlenarSelNavConSP()
            End If
            .Dispose()
        End With
    End Sub

    Private Sub Borrar(sender As System.Object, e As System.EventArgs) Handles cmdBorrar.Click, mnuBorrar.Click
        If LlenarLlaves() Then
            Dim frmBorrar As New MONEDM02
            With frmBorrar
                .Modo_Local = Modo_Baja
                .Pila = Me.Pila
                .ShowDialog()
                If .HubieronCambios Then
                    Me.LlenarEncabezado()
                    MyBase.LlenarSelNavConSP()
                End If
                .Dispose()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub Modificar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click, mnuModificar.Click
        Me.Modificar()
    End Sub

    Private Sub Salir(sender As System.Object, e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub TasasDeCambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTasasDeCambio.Click, mnuTasasDeCambio.Click
        Dim varTIPO_CAMBIO As String = DescripcionesDB.ParametrosGeneralesTipoDeCambio("PA")
        If varTIPO_CAMBIO = "" Then
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(200, "El tipo de cambio por omisión no esta definido en parametros generales."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Me.GridData.Rows.Count > 0 Then
                If GridData.Rows.Count > 0 Then
                    Dim codigoMoneda As String = GridData.SelectedRows(0).Cells(0).Value.ToString()
                    Dim frmConsulta As New TASASS01
                    With frmConsulta
                        .CodigoMoneda = codigoMoneda
                        .ShowDialog()
                        .Dispose()
                    End With
                End If
            End If
        End If
    End Sub

    Private Sub Grafica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonGrafica.Click, mnuGrafica.Click
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim codigoMoneda As String = GridData.SelectedRows(0).Cells(0).Value.ToString()
                Dim fechaInicial As String = String.Empty
                Dim fechaFinal As String = String.Empty
                Dim tasaTipo As String = String.Empty
                Dim frmDatos As New PIDE_DATOS
                With frmDatos
                    .CodigoMoneda = codigoMoneda
                    .FechaInicial = fechaInicial
                    .FechaFinal = fechaFinal
                    .ShowDialog()
                    fechaInicial = .FechaInicial
                    fechaFinal = .FechaFinal
                    codigoMoneda = .CodigoMoneda
                    tasaTipo = .TasaTipo
                    .Dispose()
                End With
                If fechaFinal <> "99/99/9999" And fechaInicial <> "99/99/9999" Then
                    Dim frmTasas As New TASASG01
                    With frmTasas
                        .FechaInicial = fechaInicial
                        .FechaFinal = fechaFinal
                        .CodigoMoneda = codigoMoneda
                        .TasaTipo = tasaTipo
                        .ShowDialog()
                        .Dispose()
                    End With
                End If
            End If
        End If
    End Sub

    Private Sub Reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonReporte.Click, mnuReporte.Click
        Try
            'Citi.Synergia.Reportes.Crystal.Parametros.Clear()
            'With Citi.Synergia.Reportes.Crystal.Parametros
            '    .Add(New Citi.Synergia.Reportes.Campos("_USUARIO", Scm(DescripcionesDB.TraeUsuario())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_EMPRESA", Scm(DescripcionesDB.TraeEmpresa())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_IDIOMA", Scm(Citi.Synergia.Locals.Cache.IdiomaSeleccionado)))
            'End With

            'If Citi.Synergia.Reportes.Crystal.ValidaReporte("Monedas", True) = False Then
            '    Return
            'End If

            'Citi.Synergia.Reportes.Crystal.EjecutarReporte("Monedas", , Citi.Synergia.Traductor.Idiomas.GetMensaje(277, "Reporte de Monedas"))

            Dim parametros As New List(Of String)
            With parametros
                '.Add(DescripcionesDB.TraeUsuario())
                .Add(Citi.Synergia.Locals.Cache.UsuarioSSO)
            End With

            Citi.Synergia.Reports.Reportes.EjecutarReporte(Reports.Reportes.ListadoReportes.Monedas, parametros)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class