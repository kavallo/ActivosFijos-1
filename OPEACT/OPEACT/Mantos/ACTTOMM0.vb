Imports Citi.Synergia.HelperClient

Public Class ACTTOMM0
    Private _registroImportado As String = String.Empty
    Private _cambioDetalle As Boolean = False

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblRegistro.Text = ""
        lblModificada.Text = ""

        Me.InicioForma()
    End Sub

    Private Sub InicioForma()
        Modo = Modo_Local

        MyBase.Limpiar()

        _cambioDetalle = False

        Me.CreaGrid()

        If Modo_Local <> Modo_Alta Then
            NUMERO_TOMA.Text = Pop()
            Me.Leer()
        Else
            If Not String.IsNullOrEmpty(TraeDato("Select IsNull(Max(NUMERO_TOMA),0) + 1 From ACT_TOMAFISICA_ENC")) Then
                NUMERO_TOMA.Text = TraeDato("Select IsNull(Max(NUMERO_TOMA),0) + 1 From ACT_TOMAFISICA_ENC").ToString
            End If

            Dim fecha As String = DescripcionesDB.TraeFechaHoy("101")
            FECHA_TOMA.EscribirFecha(fecha, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
        End If

        MyBase.Habilitar()

        If Modo_Local = Modo_Alta Or Modo_Local = Modo_Cambio Then
            Me.HabilitaGrid(True)
        Else
            Me.HabilitaGrid(False)
        End If

        Me._registroImportado = "N"

        If Modo_Local = Modo_Cambio Then
            Me.cmdImportar.Visible = True
            Me.cmdExportar.Visible = True
            Me.NUMERO_TOMA.Enabled = False
        End If

        If SoloDeConsulta Then
            Me.cmdAceptar.Visible = False
            Me.cmdExportar.Visible = False
            Me.cmdImportar.Visible = False
            Me.cmdCancelar.Text = Me.cmdAceptar.Text

            Me.DeshabilitaCodigos()

            Me.HabilitaGrid(False)
        End If
    End Sub

    Private Sub CreaGrid()
        '-- El grid tendrá 6 columnas, de tipo texto.
        '-- La última columna estará oculta para indicar si se ha modificado
        '-- Sólo la columna de Observaciones se podrá modificar.

        DETALLE.Rows.Clear()
        DETALLE.Columns.Clear()

        Dim columna As DataGridViewTextBoxColumn
        columna = New DataGridViewTextBoxColumn
        With columna
            '.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
            .MinimumWidth = 80
            .Width = 100
            .MaxInputLength = 10
            .ReadOnly = True
            .HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(240, "Ubicación")
        End With
        Me.DETALLE.Columns.Add(columna)

        columna = New DataGridViewTextBoxColumn
        With columna
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
            .MinimumWidth = 80
            .Width = 100
            .MaxInputLength = 5
            .ReadOnly = True
            .HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(32, "Responsable")
        End With
        Me.DETALLE.Columns.Add(columna)

        columna = New DataGridViewTextBoxColumn
        With columna
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
            .MinimumWidth = 80
            .Width = 100
            .MaxInputLength = 15
            .ReadOnly = True
            .HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(92, "Código Activo")
        End With
        Me.DETALLE.Columns.Add(columna)

        columna = New DataGridViewTextBoxColumn
        With columna
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
            .MinimumWidth = 80
            .Width = 100
            .MaxInputLength = 10
            .ReadOnly = True
            .HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(115, "Mejora")
        End With
        Me.DETALLE.Columns.Add(columna)

        columna = New DataGridViewTextBoxColumn
        With columna
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .MinimumWidth = 250
            .Width = 300
            .MaxInputLength = 255
            .ReadOnly = False
            .HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(226, "Observaciones")
        End With
        Me.DETALLE.Columns.Add(columna)

        columna = New DataGridViewTextBoxColumn
        With columna
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .ReadOnly = True
            .Visible = False
            .HeaderText = "Oculta"
        End With
        Me.DETALLE.Columns.Add(columna)
    End Sub

    Private Sub Leer()
        Try
            'ENCABEZADO
            meteSQL("Select Convert(varchar(10),FECHA_TOMA,101)")
            meteSQL("     , RESPONSABLE_TOMA")
            meteSQL("     , OBSERVACIONES")
            meteSQL("     , Case ESTADO_TOMA When 'E' Then 'EN PROCESO' Else 'AUTORIZADO' End")
            meteSQL("     , USUARIO_ING")
            meteSQL("     , Convert(varchar(10),FECHA_ING,103)")
            meteSQL("     , USUARIO_AUT")
            meteSQL("     , Convert(varchar(10),FECHA_AUT,103)")
            meteSQL("     , IMPORTADA")
            meteSQL("     , USUARIO_IMP")
            meteSQL("     , Convert(varchar(10),FECHA_IMP,103)")
            meteSQL("     , IsNull(MODIF_DESP_IMP, 'N')")
            meteSQL("  From ACT_TOMAFISICA_ENC")
            meteSQL(" Where NUMERO_TOMA = " & sen(NUMERO_TOMA.GetValor()))

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                FECHA_TOMA.EscribirFecha(SqlData(Sqlconn, 1).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                RESPONSABLE_TOMA.Text = SqlData(Sqlconn, 2).ToString
                OBSERVACIONES.Text = SqlData(Sqlconn, 3).ToString
                ESTADO_TOMA.Text = "** " & SqlData(Sqlconn, 4).ToString & " **"
                USUARIO_ING.Text = SqlData(Sqlconn, 5).ToString
                FECHA_ING.Text = SqlData(Sqlconn, 6).ToString
                USUARIO_AUT.Text = SqlData(Sqlconn, 7).ToString
                FECHA_AUT.Text = SqlData(Sqlconn, 8).ToString
                IMPORTADA.Checked = CType(SqlData(Sqlconn, 9), Boolean)
                USUARIO_IMP.Text = SqlData(Sqlconn, 10).ToString
                FECHA_IMP.Text = SqlData(Sqlconn, 11).ToString
                If SqlData(Sqlconn, 12).ToString = "S" Then
                    Me.lblModificada.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(257, "La transacción fue modificada después de haber sido importada.")
                Else
                    Me.lblModificada.Text = ""
                End If
            Loop

            '-- Detalle
            Me.LeerDetalle()

            Me.Codigos_Leave(CODIGO_UBICACION, Nothing)
            Me.Codigos_Leave(RESPONSABLE_ID, Nothing)
            Me.Codigos_Leave(CODIGO_DE_ACTIVO, Nothing)
            Me.Codigos_Leave(MEJORA_CORRELATIVO, Nothing)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LeerDetalle()
        'DETALLE
        Try
            Dim comandoSQL As New System.Text.StringBuilder()
            With comandoSQL
                .Append("Select Rtrim(CODIGO_UBICACION) + '-' +")
                .Append("       (Select UBICACION_ACTIVO.DESCRIPCION_UBICACION from UBICACION_ACTIVO Where UBICACION_ACTIVO.CODIGO_UBICACION = ACT_TOMAFISICA_DET.CODIGO_UBICACION)")
                .Append("     , Rtrim(RESPONSABLE_ID) + '-' +")
                .Append("       (Select ACT_RESPONSABLES.NOMBRE_USUAL from ACT_RESPONSABLES Where ACT_RESPONSABLES.RESPONSABLE_ID = ACT_TOMAFISICA_DET.RESPONSABLE_ID)")
                .Append("     , CODIGO_DE_ACTIVO")
                .Append("     , MEJORA_CORRELATIVO")
                .Append("     , OBSERVACIONES")
                .Append("  From ACT_TOMAFISICA_DET")
                .Append(" Where NUMERO_TOMA = " & sen(NUMERO_TOMA.GetValor()))
            End With

            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandText = comandoSQL.ToString
            End With

            Dim dsDetalle As DataSet = GetDataSet(comando)
            If Not dsDetalle Is Nothing Then
                If dsDetalle.Tables.Count > 0 Then
                    For Each filaData As DataRow In dsDetalle.Tables(0).Rows
                        Dim filaGrid As New DataGridViewRow
                        filaGrid.CreateCells(Me.DETALLE)
                        filaGrid.Cells(0).Value = filaData.Item(0).ToString
                        filaGrid.Cells(1).Value = filaData.Item(1).ToString
                        filaGrid.Cells(2).Value = filaData.Item(2).ToString
                        filaGrid.Cells(3).Value = filaData.Item(3).ToString
                        filaGrid.Cells(4).Value = filaData.Item(4).ToString
                        filaGrid.Cells(5).Value = ""

                        Me.DETALLE.Rows.Add(filaGrid)
                    Next
                End If
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HabilitaGrid(ByVal habilita As Boolean)
        'Bloqueamos todo el grid
        DETALLE.ReadOnly = True

        'Si habilitan, habilitamos solo obs
        If habilita Then
            DETALLE.ReadOnly = False
        End If

        'Ocultamos la columna de control
        Me.DETALLE.Columns(5).Visible = False
    End Sub

    Private Sub DeshabilitaCodigos(Optional ByVal esImportada As Boolean = False)
        Me.lblCODIGO_UBICACION.Enabled = False
        Me.CODIGO_UBICACION.Enabled = False
        Me.lblRESPONSABLE_ID.Enabled = False
        Me.RESPONSABLE_ID.Enabled = False
        Me.lblACTIVO.Enabled = False
        Me.CODIGO_DE_ACTIVO.Enabled = False
        Me.MEJORA_CORRELATIVO.Enabled = False

        If esImportada Then
            OBSERVACIONES_DET.Enabled = False
        End If
    End Sub

    Private Sub LimpiaDetalle()
        'Rutina para limpiar los campos para ingreso de 1 reg
        CODIGO_UBICACION.Text = ""
        RESPONSABLE_ID.Text = ""
        CODIGO_DE_ACTIVO.Text = ""
        MEJORA_CORRELATIVO.Text = ""
    End Sub

    Private Function EsImportada() As Boolean
        'Indica que es importada o no y envia error
        Dim retorno As Boolean = False

        If IMPORTADA.CheckState = 1 Then
            Citi.Synergia.HelperClient.Utils.CITIMsgBox(Citi.Synergia.Traductor.Idiomas.GetMensaje(258, "No se puede agregar ningún registro porque ésta transacción ha sido importada."), Utils.TipoDeMensaje.TipoError)
            retorno = True
        End If

        Return retorno
    End Function

    Private Sub Siguiente(Optional ByVal cancelar As Boolean = False)
        If Modo_Local = Modo_Alta Then
            Modo_Local = Modo_Cambio
            Modo = Modo_Cambio
        ElseIf Modo_Local = Modo_Baja Then
            Me.Close()
        End If
    End Sub

    Private Sub GrabaDetalles()
        Dim comandoSQL As System.Text.StringBuilder
        Dim comando As SqlClient.SqlCommand

        For Each filaGrid As DataGridViewRow In DETALLE.Rows
            If filaGrid.Cells(5).Value.ToString = "*" Then
                filaGrid.Cells(5).Value = ""

                comandoSQL = New System.Text.StringBuilder
                comando = New SqlClient.SqlCommand

                'Actualizamos la observacion
                If _registroImportado = "N" Then
                    With comandoSQL
                        .Append("Update ACT_TOMAFISICA_DET")
                        .Append("   Set OBSERVACIONES      = " & Scm(filaGrid.Cells(4).Value.ToString))
                        .Append(" Where NUMERO_TOMA        = " & sen(NUMERO_TOMA.GetValor()))
                        .Append("   And CODIGO_UBICACION   = " & Scm(Mid(filaGrid.Cells(0).Value.ToString, 1, InStr(filaGrid.Cells(0).Value.ToString, "-") - 1)))
                        .Append("   And RESPONSABLE_ID     = " & Scm(Mid(filaGrid.Cells(1).Value.ToString, 1, InStr(filaGrid.Cells(1).Value.ToString, "-") - 1)))
                        .Append("   And CODIGO_DE_ACTIVO   = " & Scm(filaGrid.Cells(2).Value.ToString))
                        .Append("   And MEJORA_CORRELATIVO = " & sen(filaGrid.Cells(3).Value.ToString))
                    End With
                Else
                    With comandoSQL
                        .Append("Insert ACT_TOMAFISICA_DET")
                        .Append("     ( NUMERO_TOMA")
                        .Append("     , CODIGO_UBICACION")
                        .Append("     , RESPONSABLE_ID")
                        .Append("     , CODIGO_DE_ACTIVO")
                        .Append("     , MEJORA_CORRELATIVO")
                        .Append("     , OBSERVACIONES)")
                        .Append("Values( " & sen(NUMERO_TOMA.GetValor()))
                        .Append("     , " & Scm(filaGrid.Cells(0).Value.ToString))
                        .Append("     , " & Scm(filaGrid.Cells(1).Value.ToString))
                        .Append("     , " & Scm(filaGrid.Cells(2).Value.ToString))
                        .Append("     , " & Scm(filaGrid.Cells(3).Value.ToString))
                        .Append("     , " & Scm(filaGrid.Cells(4).Value.ToString) & ")")
                    End With
                End If

                With comando
                    .CommandText = comandoSQL.ToString
                End With
                Try
                    EjecutarComando(comando)

                    Me._cambioDetalle = True

                Catch errSQL As SqlClient.SqlException
                    MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Next

        If Me._cambioDetalle And IMPORTADA.CheckState = True Then
            comandoSQL = New System.Text.StringBuilder
            comando = New SqlClient.SqlCommand

            With comandoSQL
                .Append("Update ACT_TOMAFISICA_ENC")
                .Append("   Set MODIF_DESP_IMP = 'S'")
                .Append(" Where NUMERO_TOMA = " & sen(NUMERO_TOMA.GetValor()))
            End With

            With comando
                .CommandText = comandoSQL.ToString
            End With

            Try
                EjecutarComando(comando)

            Catch errSQL As SqlClient.SqlException
                MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Grabar()
        _cambioDetalle = False

        CODIGO_UBICACION.EsRequerido = False
        RESPONSABLE_ID.EsRequerido = CODIGO_UBICACION.EsRequerido
        CODIGO_DE_ACTIVO.EsRequerido = CODIGO_UBICACION.EsRequerido
        MEJORA_CORRELATIVO.EsRequerido = CODIGO_UBICACION.EsRequerido

        If MyBase.ValidarCampos(frmTOMA) = False Then
            Return
        End If

        'Mantenimiento: ENC
        meteSQL("Exec abc_ACT_TOMAFISICA_ENC")
        meteSQL("     @NUMERO_TOMA      = " & sen(NUMERO_TOMA.GetValor()))
        meteSQL("   , @FECHA_TOMA       = " & Scm(FECHA_TOMA.TextMMDDYYYY()))
        meteSQL("   , @RESPONSABLE_TOMA = " & Scm(RESPONSABLE_TOMA.Text))
        meteSQL("   , @OBSERVACIONES    = " & Scm(OBSERVACIONES.Text))
        meteSQL("   , @REGISTRO_IMP     = " & Scm(Me._registroImportado))
        meteSQL("   , @MODO             = " & sen(CStr(Modo_Local)))
        meteSQL("   , @USUARIO          = " & sen(Citi.Synergia.Locals.Cache.UsuarioSSO))
        EjecutaSQL("")

        HubieronCambios = True

        Dim grabaDetalle As Boolean = False

        'Si todo OK continua con el detalle
        If (CODIGO_DE_ACTIVO.Text <> "" Or RESPONSABLE_ID.Text <> "") Or (CODIGO_DE_ACTIVO.Text <> "" Or MEJORA_CORRELATIVO.Text <> "") Then
            grabaDetalle = True
        End If

        If grabaDetalle Then
            'Si determinamos que debe registrar detalle valida que ingresen los valores
            CODIGO_UBICACION.EsRequerido = True
            RESPONSABLE_ID.EsRequerido = CODIGO_UBICACION.EsRequerido
            CODIGO_DE_ACTIVO.EsRequerido = CODIGO_UBICACION.EsRequerido
            MEJORA_CORRELATIVO.EsRequerido = CODIGO_UBICACION.EsRequerido

            If MyBase.ValidarCampos(frmDET) = False Then
                grabaDetalle = False
            End If

            If Not grabaDetalle Then
                'Si no registra, preguntamos si desea limpiar los valores
                If Citi.Synergia.HelperClient.Utils.CITIMsgBox(Citi.Synergia.Traductor.Idiomas.GetMensaje(259, "Desea limpiar los valores utilizados para agregar un nuevo activo encontrado para la toma?"), Utils.TipoDeMensaje.TipoConfirmacion) = Utils.TipoDeRespuesta.Cancelar Then
                    Me.LimpiaDetalle()
                End If

                Return
            End If

            'Agregamos el detalle
            Dim comandoSQL As New System.Text.StringBuilder
            With comandoSQL
                .Append("Insert ACT_TOMAFISICA_DET")
                .Append("     ( NUMERO_TOMA")
                .Append("     , CODIGO_UBICACION")
                .Append("     , RESPONSABLE_ID")
                .Append("     , CODIGO_DE_ACTIVO")
                .Append("     , MEJORA_CORRELATIVO")
                .Append("     , OBSERVACIONES)")
                .Append("Values( " & sen(NUMERO_TOMA.GetValor()))
                .Append("     , " & Scm(CODIGO_UBICACION.Text))
                .Append("     , " & Scm(RESPONSABLE_ID.Text))
                .Append("     , " & Scm(CODIGO_DE_ACTIVO.Text))
                .Append("     , " & sen(MEJORA_CORRELATIVO.Text))
                .Append("     , " & Scm(OBSERVACIONES_DET.Text) & ")")
            End With
            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandText = comandoSQL.ToString
            End With

            Dim existeError As Boolean = False
            Try
                Dim resultado As Integer = 0
                resultado = EjecutarComando(comando)

                If resultado <> -1 Then
                    'Si todo Ok, limpia los datos del activo y observacion
                    CODIGO_DE_ACTIVO.Text = ""
                    MEJORA_CORRELATIVO.Text = ""
                    OBSERVACIONES_DET.Text = ""
                    CODIGO_DE_ACTIVO.Focus()
                Else
                    existeError = True
                End If

            Catch errSQL As SqlClient.SqlException
                MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                existeError = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                existeError = True
            End Try

            If existeError Then
                Return
            End If

            Me._cambioDetalle = True
        End If

        Me.Siguiente()

        'Graba los detalles modificados
        Me.GrabaDetalles()

        Me._registroImportado = "N"

        Push(NUMERO_TOMA.Text)

        Me.InicioForma()
    End Sub

    Private Function NombreMDB(ByVal numero As Integer) As String
        Dim retorno As String = String.Empty

        'Formateamos el nombre para que sea estandar
        retorno = "TF" & String.Format("{0:0000000000}", numero)

        Return retorno
    End Function

    Private Sub Importada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMPORTADA.CheckedChanged
        If IMPORTADA.Checked Then
            Me.DeshabilitaCodigos(True)
            Me.lblRegistro.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(258, "No se puede agregar ningún registro porque ésta transacción ha sido importada.")
        End If
    End Sub

    Private Sub LabelCodigoUbicacion_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_UBICACION.DoubleClick, lblCODIGO_UBICACION.DoubleClick
        If Me.EsImportada() = False Then
            With CODIGO_UBICACION
                .NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeUbicacionesDeActivosFijos_ACTUBIL0
                .GenerarConsulta()
                .NombreDeConsulta = Nothing
            End With
        End If
    End Sub

    Private Sub CodigoUbicacion_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CODIGO_UBICACION.KeyUp
        If e.KeyCode = Keys.F4 Then
            Me.LabelCodigoUbicacion_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub LabelCodigoResponsable_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RESPONSABLE_ID.DoubleClick, lblRESPONSABLE_ID.DoubleClick
        If Me.EsImportada() = False Then
            With RESPONSABLE_ID
                .NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeResponsablesDeActivosFijos_ACTRAFL0
                .GenerarConsulta()
                .NombreDeConsulta = Nothing
            End With
        End If
    End Sub

    Private Sub CodigoResponsable_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RESPONSABLE_ID.KeyUp
        If e.KeyCode = Keys.F4 Then
            Me.LabelCodigoResponsable_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub LabelCodigoDeActivo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_DE_ACTIVO.DoubleClick, MEJORA_CORRELATIVO.DoubleClick, lblACTIVO.DoubleClick
        If Me.EsImportada() = False Then
            With CODIGO_DE_ACTIVO
                .NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeActivosFijos_ACTMAFL0
                .GenerarConsulta()
                '-- En este caso la consulta devuelve 2 códigos, uno del tipo de activo
                '-- y el otro del correlativo
                If .CodigosRetorno.Count > 0 Then
                    MEJORA_CORRELATIVO.Text = .CodigosRetorno.Item(1)
                    .Text = .CodigosRetorno.Item(0)
                End If
                .NombreDeConsulta = Nothing
            End With
        End If
    End Sub

    Private Sub CodigoActivoMejora_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CODIGO_DE_ACTIVO.KeyUp, MEJORA_CORRELATIVO.KeyUp
        If e.KeyCode = Keys.F4 Then
            Me.LabelCodigoDeActivo_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub Codigos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_UBICACION.Leave, RESPONSABLE_ID.Leave, CODIGO_DE_ACTIVO.Leave, MEJORA_CORRELATIVO.Leave
        Select Case sender.Name
            Case "CODIGO_UBICACION"
                desCODIGO_UBICACION.Text = DescripcionesDB.UbicacionActivo(CODIGO_UBICACION.Text)
            Case "RESPONSABLE_ID"
                desRESPONSABLE_ID.Text = DescripcionesDB.NombreUsualResponsable(RESPONSABLE_ID.Text)
            Case "CODIGO_DE_ACTIVO"
                desCODIGO_DE_ACTIVO.Text = DescripcionesDB.DescripcionCortaActivo(CODIGO_DE_ACTIVO.Text, MEJORA_CORRELATIVO.Text)
            Case "MEJORA_CORRELATIVO"
                desCODIGO_DE_ACTIVO.Text = DescripcionesDB.DescripcionCortaActivo(CODIGO_DE_ACTIVO.Text, MEJORA_CORRELATIVO.Text)
        End Select
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click
        'Creamos archivo de SALIDA para toma fisica
        Dim archivoOrigen As String = String.Empty
        Dim comandoSQL As New System.Text.StringBuilder
        Dim dsData As DataSet
        Dim pathDirectorio As String = String.Empty
        Dim hayError As Boolean = False
        Dim archivoDestino As String = String.Empty

        Try
            pathDirectorio = My.Application.Info.DirectoryPath

            'Manejo de Archivo MDB
            If Not pathDirectorio.Trim.EndsWith("\") Then
                pathDirectorio = pathDirectorio & "\"
            End If

            archivoOrigen = pathDirectorio & NombreMDB(0) & ".mdb"

            If Not Citi.Synergia.HelperClient.Utils.ArchivoExiste(archivoOrigen) Then
                Citi.Synergia.HelperClient.Utils.CITIMsgBox(Citi.Synergia.Traductor.Idiomas.GetMensaje(260, "No existe el archivo") & ": " & archivoOrigen.ToUpper & ". " & Citi.Synergia.Traductor.Idiomas.GetMensaje(261, "El archivo es requerido para la exportación."), Utils.TipoDeMensaje.TipoError)
                Return
            End If

            archivoDestino = pathDirectorio & NombreMDB(Val(NUMERO_TOMA.GetValor())) & ".mdb"

            '-- Copio el archivo base
            FileIO.FileSystem.CopyFile(archivoOrigen, archivoDestino, True)

            'Exportamos datos
            Dim accConexion As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=IQS_CT04;Data Source=" + archivoDestino)
            Dim comando As New OleDb.OleDbCommand
            comando.Connection = accConexion

            accConexion.Open()

            'UBICACIONES
            With comandoSQL
                .Append("Select CODIGO_UBICACION, DESCRIPCION_UBICACION")
                .Append("  From UBICACION_ACTIVO")
            End With
            dsData = GetDataSet(comandoSQL.ToString)

            If Not dsData Is Nothing Then
                If dsData.Tables.Count > 0 Then
                    For Each filaData As DataRow In dsData.Tables(0).Rows
                        With comando
                            .Parameters.Clear()
                            .CommandText = "Insert Into UBICACION Values(@Codigo, @Descripcion)"
                            .Parameters.Add("@Codigo", OleDb.OleDbType.VarChar).Value = filaData.Item(0).ToString
                            .Parameters.Add("@Descripcion", OleDb.OleDbType.VarChar).Value = filaData.Item(1).ToString
                            .ExecuteNonQuery()
                        End With
                    Next
                End If
            End If

            'RESPONSABLES
            comandoSQL.Clear()
            With comandoSQL
                .Append("Select RESPONSABLE_ID, NOMBRE_USUAL")
                .Append("  From ACT_RESPONSABLES")
            End With
            dsData = GetDataSet(comandoSQL.ToString)

            If Not dsData Is Nothing Then
                If dsData.Tables.Count > 0 Then
                    For Each filaData As DataRow In dsData.Tables(0).Rows
                        With comando
                            .Parameters.Clear()
                            .CommandText = "Insert Into RESPONSABLE Values(@Codigo, @Descripcion)"
                            .Parameters.Add("@Codigo", OleDb.OleDbType.VarChar).Value = filaData.Item(0).ToString
                            .Parameters.Add("@Descripcion", OleDb.OleDbType.VarChar).Value = filaData.Item(1).ToString
                            .ExecuteNonQuery()
                        End With
                    Next
                End If
            End If

            'ACTIVOS FIJOS
            comandoSQL.Clear()
            With comandoSQL
                .Append("SELECT A.CODIGO_DE_ACTIVO, A.MEJORA_CORRELATIVO, ISNULL(G.DESCRIP_LARGA_UNO, A.DESCRIP_CORTA_ACTIVO) AS DESCRIPCION, G.MARCA,")
                .Append("       G.NUMERO_SERIE_ACTIVO , a.CODIGO_UBICACION, a.RESPONSABLE_ID")
                .Append("  FROM ACTIVOS_FIJOS AS A LEFT OUTER JOIN")
                .Append("       ACTIVOS_FIJOS_GEN AS G ON A.CODIGO_DE_ACTIVO = G.CODIGO_DE_ACTIVO AND A.MEJORA_CORRELATIVO = G.MEJORA_CORRELATIVO")
                .Append(" WHERE (A.ESTATUS = 'U') AND (ISNULL(A.POSEE_CTRL_TF, '1') = '1')")
            End With
            dsData = GetDataSet(comandoSQL.ToString)

            If Not dsData Is Nothing Then
                If dsData.Tables.Count > 0 Then
                    For Each filaData As DataRow In dsData.Tables(0).Rows
                        With comando
                            .Parameters.Clear()
                            .CommandText = "Insert Into ACTIVO_FIJO Values(@Codigo, @Correlativo, @Descripcion, @Marca, @Serie, @Ubicacion, @Responsable)"
                            .Parameters.Add("@Codigo", OleDb.OleDbType.VarChar).Value = filaData.Item(0).ToString
                            .Parameters.Add("@Correlativo", OleDb.OleDbType.VarChar).Value = filaData.Item(1).ToString
                            .Parameters.Add("@Descripcion", OleDb.OleDbType.VarChar).Value = filaData.Item(2).ToString
                            .Parameters.Add("@Marca", OleDb.OleDbType.VarChar).Value = filaData.Item(3).ToString
                            .Parameters.Add("@Serie", OleDb.OleDbType.VarChar).Value = filaData.Item(4).ToString
                            .Parameters.Add("@Ubicacion", OleDb.OleDbType.VarChar).Value = filaData.Item(5).ToString
                            .Parameters.Add("@Responsable", OleDb.OleDbType.VarChar).Value = filaData.Item(6).ToString
                            .ExecuteNonQuery()
                        End With
                    Next
                End If
            End If

            accConexion.Close()

            'Todo OK
            Citi.Synergia.HelperClient.Utils.CITIMsgBox(Citi.Synergia.Traductor.Idiomas.GetMensaje(262, "Se exportó la información para toma física en el archivo") & ": " & archivoDestino, Utils.TipoDeMensaje.TipoAviso)

            '-- Cualquier error borro el archivo destino
        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Citi.Synergia.HelperClient.Utils.CITIMsgBox(Citi.Synergia.Traductor.Idiomas.GetMensaje(263, "Se detectó problemas con la exportación") & ".", Utils.TipoDeMensaje.TipoError)
            hayError = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Citi.Synergia.HelperClient.Utils.CITIMsgBox(Citi.Synergia.Traductor.Idiomas.GetMensaje(263, "Se detectó problemas con la exportación") & ".", Utils.TipoDeMensaje.TipoError)
            hayError = True
        End Try

        '-- Si hubieron errores borro el archivo destino
        If hayError Then
            Try
                If Citi.Synergia.HelperClient.Utils.ArchivoExiste(archivoDestino) Then
                    FileIO.FileSystem.DeleteFile(archivoDestino)
                End If
            Catch errSQL As SqlClient.SqlException
                MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Importar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportar.Click
        'Importamos información desde ACCESS
        '-----------------------------------
        Dim existeError As Boolean = False

        'Manejo de Archivo MDB
        Dim archivoOrigen As String = String.Empty
        Dim pathDirectorio As String = String.Empty

        pathDirectorio = My.Application.Info.DirectoryPath
        If Not pathDirectorio.Trim.EndsWith("\") Then
            pathDirectorio = pathDirectorio & "\"
        End If

        archivoOrigen = pathDirectorio & NombreMDB(Val(NUMERO_TOMA.GetValor())) & ".mdb"

        If Not Citi.Synergia.HelperClient.Utils.ArchivoExiste(archivoOrigen) Then
            Citi.Synergia.HelperClient.Utils.CITIMsgBox(Citi.Synergia.Traductor.Idiomas.GetMensaje(260, "No existe el archivo") & ": " & archivoOrigen.ToUpper & ". " & Citi.Synergia.Traductor.Idiomas.GetMensaje(264, "El archivo es requerido para la importación."), Utils.TipoDeMensaje.TipoError)
            Return
        End If

        'Confirmamos eliminación si HAY detalles
        If Not String.IsNullOrEmpty(TraeDato("Select IsNull(Count(1), 0) from ACT_TOMAFISICA_DET where NUMERO_TOMA = " & sen(NUMERO_TOMA.GetValor()))) Then
            If Val(TraeDato("Select Count(1) from ACT_TOMAFISICA_DET where NUMERO_TOMA = " & sen(NUMERO_TOMA.GetValor())).ToString) <> 0 Then
                If Citi.Synergia.HelperClient.Utils.CITIMsgBox(Citi.Synergia.Traductor.Idiomas.GetMensaje(265, "Se detectó que YA existen detalles, está seguro de importar? La importación reemplaza la información existente."), Utils.TipoDeMensaje.TipoConfirmacion) = Utils.TipoDeRespuesta.Cancelar Then
                    Return
                End If

                Dim comando As New SqlClient.SqlCommand
                comando.CommandText = "Delete ACT_TOMAFISICA_DET Where NUMERO_TOMA = " & sen(NUMERO_TOMA.GetValor())


                Dim resultado As Integer = 0

                resultado = EjecutarComando(comando)

                If resultado = -1 Then
                    existeError = True
                End If

                If existeError Then
                    Return
                End If
            End If
        End If

        Try
            Dim accConexion As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=IQS_CT04;Data Source=" + archivoOrigen)

            Dim accCommand As New System.Data.OleDb.OleDbCommand
            With accCommand
                .CommandType = CommandType.Text
                .Connection = accConexion
                .CommandText = "Select * from TOMA_REALIZADA"
            End With

            Dim adPuente As New System.Data.OleDb.OleDbDataAdapter
            adPuente.SelectCommand = accCommand

            Dim dsData As New DataSet

            accConexion.Open()

            adPuente.Fill(dsData)

            accCommand.Dispose()

            accConexion.Close()

            Me.LimpiaDetalle()

            '-- Limpiar grid
            DETALLE.Rows.Clear()

            If Not dsData Is Nothing Then
                If dsData.Tables.Count > 0 Then
                    For Each filaData As DataRow In dsData.Tables(0).Rows
                        '-- Fila para agregar al grid
                        Dim filaGrid As New DataGridViewRow
                        filaGrid.CreateCells(Me.DETALLE)

                        '-- El número de columnas de la tabla es una menos que la del grid
                        For i As Integer = 0 To DETALLE.Columns.Count - 2
                            filaGrid.Cells(i).Value = IIf(IsDBNull(filaData.Item(i)), "", filaData.Item(i).ToString)
                        Next

                        '-- Marca la fila como modificada para guardar
                        filaGrid.Cells(5).Value = "*"

                        '-- Agrego al grid la fila
                        Me.DETALLE.Rows.Add(filaGrid)
                    Next
                End If
            End If

            Me._registroImportado = "S"

            Me.Grabar()

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Citi.Synergia.HelperClient.Utils.CITIMsgBox(Citi.Synergia.Traductor.Idiomas.GetMensaje(266, "Se detectó problemas con la importación") & ".", Utils.TipoDeMensaje.TipoError)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Citi.Synergia.HelperClient.Utils.CITIMsgBox(Citi.Synergia.Traductor.Idiomas.GetMensaje(266, "Se detectó problemas con la importación") & ".", Utils.TipoDeMensaje.TipoError)
        End Try
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Grabar()
    End Sub
End Class