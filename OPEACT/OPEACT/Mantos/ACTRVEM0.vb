Imports Citi.Synergia.HelperClient

Public Class ACTRVEM0
    Private varESTADO_REVALUACION As String
    Private varFECHA_AUTORIZACION As String
    Private varUSUARIO_AUTORIZACION As String

    Private _primerLlenado As Boolean = False

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        Me.LlenarCombos()

        If Modo = Modo_Alta Then
            Me.kPila(cp_POP)
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

        Grabado = False
    End Sub

    Private Sub LlenarCombos()
        Dim tipoRevaluacion As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With tipoRevaluacion
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(231, "D - División")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("T", Citi.Synergia.Traductor.Idiomas.GetMensaje(230, "T - Tipo de Activo")))
        End With
        With cboTIPO_DE_REVALUACION
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = tipoRevaluacion
        End With
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then txtCODIGO_REVALUACION.Text = Pop()
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL(" SELECT REVALUACION_ENC.ESTADO_REVALUACION, convert(varchar(10), REVALUACION_ENC.FECHA_AUTORIZACION, 101), REVALUACION_ENC.USUARIO_AUTORIZACION,")
                meteSQL("        REVALUACION_ENC.DESC_REVALUACION, CONVERT(varchar(10), REVALUACION_ENC.FECHA_DE_REVALUACION, 101) AS Expr1,")
                meteSQL("        REVALUACION_ENC.TIPO_DE_REVALUACION, TIPOS_DE_ACTIVOS.CODIGO_TIPO_ACTIVO, TIPOS_DE_ACTIVOS.DESCRIP_TIPO_ACTIVO,")
                meteSQL("        DIVISIONES.CODIGO_DIVISION, DIVISIONES.DESCRIPCION_DIVISION, REVALUACION_ENC.PORCENTAJE_REVAL,")
                meteSQL("        REVALUACION_ENC.TimeStamp")
                meteSQL(" FROM   DIVISIONES RIGHT OUTER JOIN")
                meteSQL("        REVALUACION_ENC ON DIVISIONES.CODIGO_DIVISION = REVALUACION_ENC.CODIGO_DIVISION LEFT OUTER JOIN")
                meteSQL("        TIPOS_DE_ACTIVOS ON REVALUACION_ENC.CODIGO_TIPO_ACTIVO = TIPOS_DE_ACTIVOS.CODIGO_TIPO_ACTIVO")
                meteSQL(" Where REVALUACION_ENC.CODIGO_REVALUACION = " & sen(txtCODIGO_REVALUACION.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    varESTADO_REVALUACION = SqlData(Sqlconn, 1).ToString
                    varFECHA_AUTORIZACION = SqlData(Sqlconn, 2).ToString
                    varUSUARIO_AUTORIZACION = SqlData(Sqlconn, 3).ToString
                    txtDESC_REVALUACION.Text = SqlData(Sqlconn, 4).ToString
                    mskFECHA_DE_REVALUACION.EscribirFecha(SqlData(Sqlconn, 5).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    cboTIPO_DE_REVALUACION.SelectedValue = SqlData(Sqlconn, 6).ToString
                    txtCODIGO_TIPO_ACTIVO.Text = SqlData(Sqlconn, 7).ToString
                    lblDESCRIP_TIPO_ACTIVO.Text = SqlData(Sqlconn, 8).ToString
                    txtCODIGO_DIVISION.Text = SqlData(Sqlconn, 9).ToString
                    lblDESCRIPCION_DIVISION.Text = SqlData(Sqlconn, 10).ToString
                    txtporcentaje.Text = SqlData(Sqlconn, 11).ToString

                    MyBase.ReadTimeStamp()

                    TimeStamp_Local = SysTimeStamp
                Loop
            End If

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                txtCODIGO_REVALUACION.Enabled = False
                lblTitCODIGO_REVALUACION.Enabled = txtCODIGO_REVALUACION.Enabled
                txtporcentaje.Enabled = False
                lblporcentaje.Enabled = False
                cboTIPO_DE_REVALUACION.Enabled = False
                lblTitTIPO_DE_REVALUACION.Enabled = False
            End If

            Me.Codigos_Leave(txtCODIGO_TIPO_ACTIVO, Nothing)
            Me.Codigos_Leave(txtCODIGO_DIVISION, Nothing)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Siguiente(Optional ByVal cancelar As Boolean = False)
        If Modo_Local = Modo_Alta Then
            If cancelar Then
                Me.Close()
            Else
                MyBase.Limpiar()
                lblDESCRIP_TIPO_ACTIVO.Text = String.Empty
                lblDESCRIPCION_DIVISION.Text = String.Empty
                txtCODIGO_REVALUACION.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                txtCODIGO_REVALUACION.Text = Pop()
                Me.Leer()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub TipoRevaluacion_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTIPO_DE_REVALUACION.SelectedValueChanged
        If _primerLlenado Then
            Dim topLabelTipoActivo As Integer = 124
            Dim topCodigoTipoActivo As Integer = 118
            Dim topDescripTipoActivo As Integer = 120
            Dim topLabelDivision As Integer = 150
            Dim topCodigoDivision As Integer = 144
            Dim topLabelPorcentaje As Integer = 172
            Dim topPorcentaje As Integer = 170

            txtCODIGO_TIPO_ACTIVO.Text = ""
            txtCODIGO_DIVISION.Text = ""

            lblTitCODIGO_TIPO_ACTIVO.Visible = False
            txtCODIGO_TIPO_ACTIVO.Visible = lblTitCODIGO_TIPO_ACTIVO.Visible
            lblTitCODIGO_DIVISION.Visible = lblTitCODIGO_TIPO_ACTIVO.Visible
            txtCODIGO_DIVISION.Visible = lblTitCODIGO_TIPO_ACTIVO.Visible
            lblporcentaje.Visible = lblTitCODIGO_TIPO_ACTIVO.Visible
            txtporcentaje.Visible = lblTitCODIGO_TIPO_ACTIVO.Visible
            lblDESCRIP_TIPO_ACTIVO.Visible = lblTitCODIGO_TIPO_ACTIVO.Visible
            lblDESCRIPCION_DIVISION.Visible = lblTitCODIGO_TIPO_ACTIVO.Visible

            Dim aux As String = String.Empty
            aux = cboTIPO_DE_REVALUACION.SelectedValue.ToString
            Select Case aux
                Case "T"
                    lblTitCODIGO_TIPO_ACTIVO.Visible = True
                    txtCODIGO_TIPO_ACTIVO.Visible = lblTitCODIGO_TIPO_ACTIVO.Visible
                    lblporcentaje.Visible = lblTitCODIGO_TIPO_ACTIVO.Visible
                    txtporcentaje.Visible = lblTitCODIGO_TIPO_ACTIVO.Visible
                    lblDESCRIP_TIPO_ACTIVO.Visible = lblTitCODIGO_TIPO_ACTIVO.Visible
                    lblTitCODIGO_TIPO_ACTIVO.Top = topLabelTipoActivo
                    txtCODIGO_TIPO_ACTIVO.Top = topCodigoTipoActivo
                    lblDESCRIP_TIPO_ACTIVO.Top = topDescripTipoActivo
                    lblporcentaje.Top = topLabelDivision
                    txtporcentaje.Top = topCodigoDivision

                Case "D"
                    lblTitCODIGO_DIVISION.Visible = True
                    txtCODIGO_DIVISION.Visible = lblTitCODIGO_DIVISION.Visible
                    lblporcentaje.Visible = lblTitCODIGO_DIVISION.Visible
                    txtporcentaje.Visible = lblTitCODIGO_DIVISION.Visible
                    lblDESCRIPCION_DIVISION.Visible = lblTitCODIGO_DIVISION.Visible
                    lblTitCODIGO_DIVISION.Top = topLabelTipoActivo
                    txtCODIGO_DIVISION.Top = topCodigoTipoActivo
                    lblDESCRIPCION_DIVISION.Top = topDescripTipoActivo
                    lblporcentaje.Top = topLabelDivision
                    txtporcentaje.Top = topCodigoDivision
            End Select
        End If
        Me._primerLlenado = True
    End Sub

    Private Sub LabelCodigoDivision_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitCODIGO_DIVISION.DoubleClick, lblTitCODIGO_TIPO_ACTIVO.DoubleClick
        Select Case sender.Name
            Case "txtCODIGO_DIVISION"
                txtCODIGO_DIVISION.GenerarConsulta()
            Case "lblTitCODIGO_TIPO_ACTIVO"
                txtCODIGO_TIPO_ACTIVO.GenerarConsulta()
        End Select
    End Sub

    Private Sub Codigos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_TIPO_ACTIVO.Leave, txtCODIGO_DIVISION.Leave
        Select Case sender.Name
            Case "txtCODIGO_TIPO_ACTIVO"
                lblDESCRIP_TIPO_ACTIVO.Text = DescripcionesDB.TipoDeActivo(txtCODIGO_TIPO_ACTIVO.Text)
            Case "txtCODIGO_DIVISION"
                lblDESCRIPCION_DIVISION.Text = DescripcionesDB.Division(txtCODIGO_DIVISION.Text)
        End Select
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Siguiente(True)
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim v As String = String.Empty

        If Modo_Local <> Modo_Baja Then
            txtCODIGO_DIVISION.EsRequerido = False
            txtCODIGO_TIPO_ACTIVO.EsRequerido = False

            If cboTIPO_DE_REVALUACION.SelectedValue.ToString = "T" Then
                txtCODIGO_TIPO_ACTIVO.EsRequerido = True
            Else
                txtCODIGO_DIVISION.EsRequerido = True
            End If

            If MyBase.ValidarCampos(Me) = False Then
                Return
            End If

            MyBase.ErrorCampos.SetError(Me.cboTIPO_DE_REVALUACION, Nothing)
            If cboTIPO_DE_REVALUACION.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboTIPO_DE_REVALUACION, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Return
            End If
        End If

        v = v & "  @CODIGO_REVALUACION = " & sen(txtCODIGO_REVALUACION.Text)
        v = v & ", @DESC_REVALUACION = " & Scm(txtDESC_REVALUACION.Text)
        v = v & ", @FECHA_AUTORIZACION = " & Scm(varFECHA_AUTORIZACION)
        v = v & ", @USUARIO_AUTORIZACION = " & Scm(varUSUARIO_AUTORIZACION)
        v = v & ", @FECHA_DE_REVALUACION = " & Scm(mskFECHA_DE_REVALUACION.TextMMDDYYYY())
        v = v & ", @ESTADO_REVALUACION = " & Scm(varESTADO_REVALUACION)
        v = v & ", @TIPO_DE_REVALUACION = " & Scm(cboTIPO_DE_REVALUACION.SelectedValue.ToString)
        v = v & ", @CODIGO_TIPO_ACTIVO = " & Scm(txtCODIGO_TIPO_ACTIVO.Text)
        v = v & ", @CODIGO_DIVISION = " & Scm(txtCODIGO_DIVISION.Text)
        v = v & ", @PORCENTAJE_REVAL= " & sen(txtporcentaje.GetValor())

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("REVALUACION_ENC", v) Then
            Grabado = True
            HubieronCambios = True

            Me.Siguiente()
        End If
    End Sub
End Class