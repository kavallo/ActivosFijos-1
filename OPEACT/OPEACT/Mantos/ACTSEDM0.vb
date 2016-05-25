Imports Citi.Synergia.HelperClient

Public Class ACTSEDM0
    Public Property NumeroPoliza As String
    Public Property NumeroEndoso As String
    Public Property CodigoCobertura As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        txtNUMERO_POLIZA.Text = Me.NumeroPoliza
        txtNO_ENDOSO.Text = Me.NumeroEndoso
        txtCODIGO_COBERTURA.Text = Me.CodigoCobertura

        If Modo_Local = Modo_Alta Then
            Me.kPila(cp_POP)
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

        Grabado = False

        txtNUMERO_POLIZA.Enabled = False
        txtNO_ENDOSO.Enabled = False
        txtCODIGO_COBERTURA.Enabled = False

        If SoloDeConsulta Then
            Me.cmdCancelar.Text = Me.cmdAceptar.Text
            Me.cmdAceptar.Visible = False
            Me.cmdAceptar.Enabled = Me.cmdAceptar.Visible
            Me.txtCODIGO_DE_ACTIVO.Enabled = False
            Me.lblTitCODIGO_DE_ACTIVO.Enabled = Me.txtCODIGO_DE_ACTIVO.Enabled
            Me.lblTitMEJORA_CORRELATIVO.Enabled = Me.txtCODIGO_DE_ACTIVO.Enabled
            Me.txtMEJORA_CORRELATIVO.Enabled = Me.txtCODIGO_DE_ACTIVO.Enabled
            Me.lblTitNUMERO_POLIZA.Enabled = Me.txtCODIGO_DE_ACTIVO.Enabled
            Me.lblTitNO_ENDOSO.Enabled = Me.txtCODIGO_DE_ACTIVO.Enabled
            Me.lblTitCODIGO_COBERTURA.Enabled = Me.txtCODIGO_DE_ACTIVO.Enabled
        End If
    End Sub

    Private Sub kPila(ByVal Acción As Short)
        If Acción And cp_POP Then txtMEJORA_CORRELATIVO.Text = Pop()
        If Acción And cp_POP Then txtCODIGO_DE_ACTIVO.Text = Pop()
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL("       SEGUROS_DET.timestamp ")
                meteSQL("  from SEGUROS_DET")
                meteSQL(" where SEGUROS_DET.NO_ENDOSO = " & Scm(Me.NumeroEndoso) & " and SEGUROS_DET.NUMERO_POLIZA = " & Scm(Me.NumeroPoliza) & " and SEGUROS_DET.CODIGO_COBERTURA = " & sen(Me.CodigoCobertura) & " and SEGUROS_DET.CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text) & " and SEGUROS_DET.MEJORA_CORRELATIVO = " & sen(txtMEJORA_CORRELATIVO.Text))
                meteSQL("")

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    MyBase.ReadTimeStamp()

                    TimeStamp_Local = SysTimeStamp
                Loop
            End If

            MyBase.Habilitar()

            Me.CodigoActivo_Leave(Nothing, Nothing)

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
                Me.CodigoActivo_Leave(Nothing, Nothing)
                txtNUMERO_POLIZA.Text = NumeroPoliza
                txtNO_ENDOSO.Text = NumeroEndoso
            End If
        Else
            If Me.Pila.Count > 0 Then
                txtMEJORA_CORRELATIVO.Text = Pop()
                txtCODIGO_DE_ACTIVO.Text = Pop()
                Me.Leer()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub CodigoActivo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_DE_ACTIVO.Leave, txtMEJORA_CORRELATIVO.Leave
        lblnombreactivo.Text = DescripcionesDB.DescripcionCortaActivo(txtCODIGO_DE_ACTIVO.Text, txtMEJORA_CORRELATIVO.Text)
    End Sub

    Private Sub CodigoActivoMejora_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitCODIGO_DE_ACTIVO.DoubleClick, lblTitMEJORA_CORRELATIVO.DoubleClick, txtCODIGO_DE_ACTIVO.DoubleClick, txtMEJORA_CORRELATIVO.DoubleClick
        With txtCODIGO_DE_ACTIVO
            .NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeActivosFijos_ACTMAFL0
            .GenerarConsulta()
            '-- En este caso la consulta devuelve 2 códigos, uno del tipo de activo
            '-- y el otro del correlativo
            If .CodigosRetorno.Count > 0 Then
                txtMEJORA_CORRELATIVO.Text = .CodigosRetorno.Item(1)
                .Text = .CodigosRetorno.Item(0)
            End If
            .NombreDeConsulta = Nothing
        End With
    End Sub

    Private Sub CodigoActivoMejora_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCODIGO_DE_ACTIVO.KeyUp, txtMEJORA_CORRELATIVO.KeyUp
        If e.KeyCode = Keys.F4 Then
            Me.CodigoActivoMejora_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Siguiente(True)
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim V As String = String.Empty

        If Modo_Local <> Modo_Baja Then
            If MyBase.ValidarCampos(GroupBox1) = False Then
                Return
            End If
        End If

        V = V & "  @NUMERO_POLIZA = " & Scm(txtNUMERO_POLIZA.Text)
        V = V & ", @NO_ENDOSO = " & Scm(txtNO_ENDOSO.Text)
        V = V & ", @CODIGO_COBERTURA = " & sen(txtCODIGO_COBERTURA.Text)
        V = V & ", @CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text)
        V = V & ", @MEJORA_CORRELATIVO = " & sen(txtMEJORA_CORRELATIVO.Text)

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("SEGUROS_DET", V) Then
            Grabado = True
            HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class