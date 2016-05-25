Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.Iconos

Public Class ACTTOMS0
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuAgregar.Text = Me.cmdAgregar.Texto
        Me.mnuBorrar.Text = Me.cmdBorrar.Texto
        Me.mnuModificar.Text = Me.cmdModificar.Texto
        Me.mnuConsultar.Text = Me.cmdConsultar.Texto
        Me.mnuAutorizar.Text = Me.cmdAutorizar.Texto
        Me.mnuReporte.Text = Me.cmdReporte.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos

            Me.IconosMenus.Images.Clear()
            '-- Agregar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Agregar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Borrar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Borrar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Modificar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Modificar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consultar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Consultar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Autorizar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Autoriza).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Reporte
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Reporte).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.cmdAgregar.Image = Me.IconosMenus.Images(0)
            Me.mnuAgregar.Image = Me.cmdAgregar.Image
            Me.cmdBorrar.Image = Me.IconosMenus.Images(1)
            Me.mnuBorrar.Image = Me.cmdBorrar.Image
            Me.cmdModificar.Image = Me.IconosMenus.Images(2)
            Me.mnuModificar.Image = Me.cmdModificar.Image
            Me.cmdConsultar.Image = Me.IconosMenus.Images(3)
            Me.mnuConsultar.Image = Me.cmdConsultar.Image
            Me.cmdAutorizar.Image = Me.IconosMenus.Images(4)
            Me.mnuAutorizar.Image = Me.cmdAutorizar.Image
            Me.cmdReporte.Image = Me.IconosMenus.Images(5)
            Me.mnuReporte.Image = Me.cmdReporte.Image
            Me.BotonLlenar.Image = Me.IconosMenus.Images(6)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(7)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MyBase.SetearPosiciones()

        Me.LlenarParam()

        Me.ActualizaCondicion()

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarParam()
        Dim fecha As String = String.Empty
        'Llena las fechas con el mes en proceso
        If Not String.IsNullOrEmpty(TraeDato("Select Ltrim(Rtrim(str(DatePart(mm,GetDate()),2))) + '/01/' + Ltrim(Rtrim(str(DatePart(yy,GetDate()),4)))")) Then
            fecha = TraeDato("Select Ltrim(Rtrim(str(DatePart(mm,GetDate()),2))) + '/01/' + Ltrim(Rtrim(str(DatePart(yy,GetDate()),4)))").ToString
            mskFECHAI.EscribirFecha(fecha, UIGenerico.SynTextoFecha.FormatoFecha.MDY)
        End If
        If Not String.IsNullOrEmpty(TraeDato("Select Convert(VarChar, Dateadd(dd,-1,Dateadd(mm,1,Ltrim(Rtrim(str(DatePart(mm,GetDate()),2))) + '/01/' + Ltrim(Rtrim(str(DatePart(yy,GetDate()),4))))), 101)")) Then
            fecha = TraeDato("Select Convert(VarChar, Dateadd(dd,-1,Dateadd(mm,1,Ltrim(Rtrim(str(DatePart(mm,GetDate()),2))) + '/01/' + Ltrim(Rtrim(str(DatePart(yy,GetDate()),4))))), 101)").ToString
            mskFECHAF.EscribirFecha(fecha, UIGenerico.SynTextoFecha.FormatoFecha.MDY)
        End If

        NumCols = 4
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Número", 10, ALINEAR_DER, "NUMERO_TOMA", 56, 10, 0, 1, 188)
        MeterParam(2, Info, 1, "Fecha", 10, ALINEAR_IZQ, "Convert(varchar(10),FECHA_TOMA,103)", 47, 10, 0, 0, 135)
        MeterParam(3, Info, 1, "Estado", 14, ALINEAR_IZQ, "ESTADO_TOMA", 47, 1, 0, 0, 37)
        MeterParam(4, Info, 1, "Responsable", 40, ALINEAR_IZQ, "RESPONSABLE_TOMA", 47, 1, 0, 0, 32)

        snCond = " "
        snTabla = "ACT_TOMAFISICA_ENC"
    End Sub

    Private Sub ActualizaCondicion()
        snCond = " FECHA_TOMA Between " & Scm(mskFECHAI.TextMMDDYYYY()) & " And " & Scm(mskFECHAF.TextMMDDYYYY())
        If Not ALL.Checked Then
            snCond = snCond & " And ESTADO_TOMA = " & Scm(IIf(PEND.Checked, "E", "A"))
        End If
    End Sub

    Private Sub ResultadoToma(ByVal numeroToma As String, Optional ByVal paso As Short = 3)
        Try
            'Calculamos e imprimimos resultados
            If paso = 1 Or paso = 3 Then
                meteSQL("Exec sp_Resultado_toma")
                meteSQL("     @NUMERO_TOMA = " & sen(numeroToma))
                EjecutaSQL("")
            End If

            If paso = 2 Or paso = 3 Then
                Dim filtro As String = String.Empty

                'Citi.Synergia.Reportes.Crystal.Parametros.Clear()
                'With Citi.Synergia.Reportes.Crystal.Parametros
                '    .Add(New Citi.Synergia.Reportes.Campos("_IDIOMA", Scm(Citi.Synergia.Locals.Cache.IdiomaSeleccionado)))
                'End With

                'If Citi.Synergia.Reportes.Crystal.ValidaReporte("Resultado_Toma", True) = False Then
                '    Return
                'End If

                'filtro = "{ACT_TOMAFISICA_RESULTADO.NUMERO_TOMA} = " & sen(numeroToma)

                'Citi.Synergia.Reportes.Crystal.EjecutarReporte("Resultado_Toma", filtro)

                filtro = String.Empty
                filtro = "t.NUMERO_TOMA = " + numeroToma

                Dim parametros As New List(Of String)
                With parametros
                    .Add(numeroToma)
                End With

                Citi.Synergia.Reports.Reportes.EjecutarReporte(Reports.Reportes.ListadoReportes.Resultado_Toma, parametros, filtro)
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CambioLista()
        Dim valor As String
        For Each filaGrid As DataGridViewRow In Me.GridData.Rows
            valor = filaGrid.Cells(2).Value.ToString
            Select Case valor
                Case "E"
                    filaGrid.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(328, "En proceso")
                Case Else
                    filaGrid.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(179, "Autorizada").Replace("A - ", "")
            End Select
        Next
    End Sub

    Private Sub Modificar()
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.cmdModificar.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            If LlenarLlaves() Then
                Dim frmBorrar As New ACTTOMM0
                With frmBorrar
                    .Modo_Local = Modo_Cambio
                    .Pila = Me.Pila
                    .ShowDialog()
                    If .HubieronCambios Then
                        MyBase.LlenarSelNav()
                    End If
                    .Dispose()
                End With
                Me.LimpiarPila()
            End If
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub CambiarDescripciones(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.CambiarDescripcionesEnGrid
        Me.CambioLista()
    End Sub

    Private Sub SeleccionaFila(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Me.Modificar()
    End Sub

    Private Sub Opciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALL.CheckedChanged, AUT.CheckedChanged, PEND.CheckedChanged
        If sender.Name <> "" Then
            If sender.Checked Then
                Me.ActualizaCondicion()
                MyBase.LlenarSelNav()
            End If
        End If
    End Sub

    Private Sub Fechas_Validated(sender As System.Object, e As System.EventArgs) Handles mskFECHAI.Validated, mskFECHAF.Validated
        If sender.Text = "" Or sender.Text = "__/__/____" Then
            sender.Focus()
            Beep()
            Return
        End If

        Me.ActualizaCondicion()
        MyBase.LlenarSelNav()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Llenar(False)
        Me.CambioLista()
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click, mnuAgregar.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.cmdAgregar.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            Dim frmAgregar As New ACTTOMM0
            With frmAgregar
                .Modo_Local = Modo_Alta
                .ShowDialog()
                If .HubieronCambios Then
                    MyBase.LlenarSelNav()
                End If
                .Dispose()
            End With
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click, mnuBorrar.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.cmdBorrar.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            If LlenarLlaves() Then
                Dim frmBorrar As New ACTTOMM0
                With frmBorrar
                    .Modo_Local = Modo_Baja
                    .Pila = Me.Pila
                    .ShowDialog()
                    If .HubieronCambios Then
                        MyBase.LlenarSelNav()
                    End If
                    .Dispose()
                End With
                Me.LimpiarPila()
            End If
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click, mnuModificar.Click
        Me.Modificar()
    End Sub

    Private Sub Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click, mnuConsultar.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.cmdConsultar.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            If LlenarLlaves() Then
                Dim frmBorrar As New ACTTOMM0
                With frmBorrar
                    .Modo_Local = Modo_Cambio
                    .SoloDeConsulta = True
                    .Pila = Me.Pila
                    .ShowDialog()
                    .Dispose()
                End With
                Me.LimpiarPila()
            End If
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Autorizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAutorizar.Click, mnuAutorizar.Click
        If Me.GridData.Rows.Count > 0 Then
            If Me.GridData.SelectedRows.Count > 0 Then
                Dim tieneAcceso As Boolean = False
                Try
                    If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.cmdAutorizar.Tag.ToString) Then
                        tieneAcceso = True
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

                If tieneAcceso Then
                    Dim numeroToma As String = Me.GridData.SelectedRows(0).Cells(0).Value.ToString
                    'Validamos que no este autorizada
                    If Not String.IsNullOrEmpty(TraeDato("Select ESTADO_TOMA From ACT_TOMAFISICA_ENC Where NUMERO_TOMA = " & sen(numeroToma))) Then
                        If "A" = TraeDato("Select ESTADO_TOMA From ACT_TOMAFISICA_ENC Where NUMERO_TOMA = " & sen(numeroToma)).ToString Then
                            Citi.Synergia.HelperClient.Utils.CITIMsgBox("La toma física no. " & numeroToma & " YA SE ENCUENTRA AUTORIZADA, imposible procesarla", HelperClient.Utils.TipoDeMensaje.TipoAviso)
                        Else
                            If Citi.Synergia.HelperClient.Utils.CITIMsgBox("Esta seguro de autorizar la(s) toma(s) seleccionadas? ESTE PROCESO NO TIENE REVERSION.", HelperClient.Utils.TipoDeMensaje.TipoConfirmacion) = Citi.Synergia.HelperClient.Utils.TipoDeRespuesta.Cancelar Then
                                Return
                            End If

                            Try
                                'Calculamos por ultima vez el resultado 
                                ResultadoToma(numeroToma, 1)

                                'Actualizamos estado de toma, el trigger completa accion 
                                meteSQL("Update ACT_TOMAFISICA_ENC")
                                meteSQL("   Set ESTADO_TOMA = 'A'")
                                meteSQL(" Where NUMERO_TOMA = " & sen(numeroToma))

                                EjecutaSQL("")

                                'Imprimimos el reporte 
                                Me.ResultadoToma(numeroToma, 2)

                            Catch errSQL As SqlClient.SqlException
                                MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End If
                    End If
                Else
                    MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub Reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReporte.Click, mnuReporte.Click
        If Me.GridData.Rows.Count > 0 Then
            If Me.GridData.SelectedRows.Count > 0 Then
                Dim tieneAcceso As Boolean = False
                Try
                    If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.cmdReporte.Tag.ToString) Then
                        tieneAcceso = True
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

                If tieneAcceso Then
                    Dim numeroToma As String = Me.GridData.SelectedRows(0).Cells(0).Value.ToString

                    Me.ResultadoToma(numeroToma)
                Else
                    MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub
End Class