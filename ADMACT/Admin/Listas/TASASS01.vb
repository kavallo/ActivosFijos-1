Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.HelperClient

Public Class TASASS01
    Public Property CodigoMoneda As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuAgregar.Text = Me.cmdAgregar.Texto
        Me.mnuBorrar.Text = Me.cmdBorrar.Texto
        Me.mnuModificar.Text = Me.cmdModificar.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
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
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Llenar).ToBitmap
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
            Me.BotonLlenar.Image = Me.IconosMenus.Images(3)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(4)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MyBase.SetearPosiciones()

        lblCODIGO_DE_MONEDA.Text = CodigoMoneda

        Order_By = " Order by ltrim(str(TASAS_DE_CAMBIO.TASA_CONVERSION,13,5)) "

        Me.LlenarEncab()

        Me.LlenarParam()

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarEncab()
        Try
            meteSQL("select")
            meteSQL("       DESCRIPCION_MONEDA")
            meteSQL("  from MONEDAS")
            meteSQL(" where CODIGO_DE_MONEDA = " & Scm(CodigoMoneda))

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                lblDESCRIPCION_MONEDA.Text = SqlData(Sqlconn, 1).ToString
            Loop

            ' recuperamos tipo de Cambio de parametros generales
            lblTIPO_CAMBIO.Text = DescripcionesDB.ParametrosGeneralesTipoDeCambio("PA")

            Select Case lblTIPO_CAMBIO.Text
                Case "D"
                    lblDECRIP_TIPO.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(194, "Diario")
                Case "H"
                    lblDECRIP_TIPO.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(195, "Histórico")
                Case "P"
                    lblDECRIP_TIPO.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(196, "Promedio")
            End Select

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LlenarParam()
        NumCols = 4
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Tasa Venta", 12, InfoLista.TipoAlineacion.ALINEAR_DER, "ltrim(str(TASA_CONVERSION,13,6))", 56, 13, 2, 0, 42)
        MeterParam(2, Info, 1, "Tasa Compra", 12, InfoLista.TipoAlineacion.ALINEAR_DER, "ltrim(str(TASA_COMPRA,13,6))", 56, 13, 2, 0, 43)
        MeterParam(3, Info, 1, "Tasa Promedio", 12, InfoLista.TipoAlineacion.ALINEAR_DER, "ltrim(str((TASA_CONVERSION + TASA_COMPRA)/2,13,6))", 56, 13, 2, 0, 44)
        MeterParam(4, Info, 1, "Fecha", 12, InfoLista.TipoAlineacion.ALINEAR_IZQ, "convert(varchar, FECHA_DE_LA_TASA, 103)", 61, 12, 0, 1, 135)

        snCond = " CODIGO_DE_MONEDA = '" & CodigoMoneda & "' and TIP_CAMBIO_TASAS_CAM = " & Scm(lblTIPO_CAMBIO.Text)
        snTabla = "TASAS_DE_CAMBIO"
        'snCampos = "' ' + ltrim(str(TASAS_DE_CAMBIO.TASA_CONVERSION,13,6)),  ' ' + ltrim(str(TASAS_DE_CAMBIO.TASA_COMPRA,13,6)),  ' ' + ltrim(str((TASA_CONVERSION + TASA_COMPRA)/2,13,6)), ' ' + convert(varchar,TASAS_DE_CAMBIO.FECHA_DE_LA_TASA, 103)"
    End Sub

    Private Sub Modificar()
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim fecha As String = GridData.SelectedRows(0).Cells(3).Value.ToString()
                Dim frmModificar As New TASASM01
                With frmModificar
                    .Modo_Local = Modo_Cambio
                    .CodigoMoneda = Me.CodigoMoneda
                    .TipoCambio = lblTIPO_CAMBIO.Text
                    .Fecha = fecha '-- Formato dd/mm/aaaa
                    .ShowDialog()
                    If .HubieronCambios Then
                        MyBase.LlenarSelNav()
                    End If
                    .Dispose()
                End With
            End If
        End If
    End Sub

    Private Sub SeleccionaFila(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Me.Modificar()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Llenar(False)
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click, mnuAgregar.Click
        Dim frmAgregar As New TASASM01
        With frmAgregar
            .Modo_Local = Modo_Alta
            .CodigoMoneda = Me.CodigoMoneda
            .TipoCambio = ""
            .Fecha = ""
            .ShowDialog()
            If .HubieronCambios Then
                MyBase.LlenarSelNav()
            End If
            .Dispose()
        End With
    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click, mnuBorrar.Click
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim fecha As String = GridData.SelectedRows(0).Cells(3).Value.ToString()
                Dim frmBorrar As New TASASM01
                With frmBorrar
                    .Modo_Local = Modo_Baja
                    .CodigoMoneda = Me.CodigoMoneda
                    .TipoCambio = lblTIPO_CAMBIO.Text
                    .Fecha = fecha '-- Formato dd/mm/aaaa
                    .ShowDialog()
                    If .HubieronCambios Then
                        MyBase.LlenarSelNav()
                    End If
                    .Dispose()
                End With
            End If
        End If
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click, mnuModificar.Click
        Me.Modificar()
    End Sub
End Class