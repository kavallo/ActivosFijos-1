Imports Citi.Synergia.HelperClient

Public Class ACTTMAM0
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        lblnombretipopartida.Text = ""

        Me.LlenarCombos()

        If Modo_Local = Modo_Alta Then
            Me.kPila(cp_POP)
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

        Me.ValoresDefault()

        Grabado = False
    End Sub

    Private Sub LlenarCombos()
        Dim tipos As New List(Of Citi.Synergia.Entidades.TiposDePartidas)
        With tipos
            .Add(New Citi.Synergia.Entidades.TiposDePartidas("A", Citi.Synergia.Traductor.Idiomas.GetMensaje(61, "A - Alta")))
            .Add(New Citi.Synergia.Entidades.TiposDePartidas("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(62, "D - Desecho")))
            .Add(New Citi.Synergia.Entidades.TiposDePartidas("P", Citi.Synergia.Traductor.Idiomas.GetMensaje(63, "P - Depreciación")))
            .Add(New Citi.Synergia.Entidades.TiposDePartidas("R", Citi.Synergia.Traductor.Idiomas.GetMensaje(64, "R - Revaluación")))
            .Add(New Citi.Synergia.Entidades.TiposDePartidas("V", Citi.Synergia.Traductor.Idiomas.GetMensaje(65, "V - Venta")))
            .Add(New Citi.Synergia.Entidades.TiposDePartidas("I", Citi.Synergia.Traductor.Idiomas.GetMensaje(66, "I - Ajuste Por Incremento Al Valor Del Activo")))
            .Add(New Citi.Synergia.Entidades.TiposDePartidas("M", Citi.Synergia.Traductor.Idiomas.GetMensaje(67, "M - Ajuste Por Disminución Al Valor Del Activo")))
            .Add(New Citi.Synergia.Entidades.TiposDePartidas("G", Citi.Synergia.Traductor.Idiomas.GetMensaje(68, "G - Revaluación Masiva")))
            .Add(New Citi.Synergia.Entidades.TiposDePartidas("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(69, "N - Donación")))
        End With
        With cboCLASE_MOVIMIENTO
            .ValueMember = "TipoPartida"
            .DisplayMember = "Nombre"
            .DataSource = tipos
        End With
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then txtTIPO_MOVIMIENTO.Text = Pop()
    End Sub

    Private Sub ValoresDefault()
        Dim cantidad As Integer = 0

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(COUNT(1), 0) from TIPOS_PARTIDAS")) Then
            cantidad = CType(TraeDato("select IsNull(COUNT(1), 0) from TIPOS_PARTIDAS"), Integer)
            If cantidad = 1 Then
                Me.txtTIPO_PARTIDA.Text = TraeDato("Select TIPO_PARTIDA From TIPOS_PARTIDAS").ToString
                Me.CodigoTipoPartida_Leave(Nothing, Nothing)
                Me.txtTIPO_PARTIDA.Enabled = False
                Me.lblTitTIPO_PARTIDA.Enabled = False
            End If
        End If
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" TIPO_MOV_ACTIVOS.DESCRIPCION_TIP_MOV, ")
                meteSQL(" TIPO_MOV_ACTIVOS.CLASE_MOVIMIENTO, ")
                meteSQL(" TIPO_MOV_ACTIVOS.TIPO_PARTIDA, ")
                meteSQL(" TIPO_MOV_ACTIVOS.timestamp ")
                meteSQL("from TIPO_MOV_ACTIVOS")
                meteSQL(" where TIPO_MOV_ACTIVOS.TIPO_MOVIMIENTO = " & sen(txtTIPO_MOVIMIENTO.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    txtDESCRIPCION_TIP_MOV.Text = SqlData(Sqlconn, 1).ToString
                    cboCLASE_MOVIMIENTO.SelectedValue = SqlData(Sqlconn, 2).ToString
                    txtTIPO_PARTIDA.Text = SqlData(Sqlconn, 3).ToString

                    MyBase.ReadTimeStamp()
                Loop
            End If

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                lblTitTIPO_MOVIMIENTO.Enabled = False
                txtTIPO_MOVIMIENTO.Enabled = lblTitTIPO_MOVIMIENTO.Enabled
            End If

            lblTitTIPO_PARTIDA.Visible = ExisteConta()
            txtTIPO_PARTIDA.Visible = lblTitTIPO_PARTIDA.Visible
            lblnombretipopartida.Visible = lblTitTIPO_PARTIDA.Visible


            Me.CodigoTipoPartida_Leave(Nothing, Nothing)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function ExisteConta() As Boolean
        Dim retorno As Boolean = False

        Try
            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Existe_conta"
                .Parameters.Add("@existe_conta", SqlDbType.Char, 1).Value = "S"
                .Parameters(0).Direction = ParameterDirection.InputOutput
            End With
            Dim parametro As New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@existe_conta"
                .Direction = ParameterDirection.InputOutput
                .SqlDbType = SqlDbType.Char
                .Value = "S"
            End With

            EjecutarComando(comando)

            If comando.Parameters(0).Value = "S" Then
                retorno = True
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return retorno
    End Function

    Private Sub Siguiente(Optional ByVal cancelar As Boolean = False)
        If Modo_Local = Modo_Alta Then
            If cancelar Then
                Me.Close()
            Else
                MyBase.Limpiar()
                Me.CodigoTipoPartida_Leave(Nothing, Nothing)
                Me.ValoresDefault()
                txtTIPO_MOVIMIENTO.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                txtTIPO_MOVIMIENTO.Text = Pop()
                Me.Leer()
                Me.ValoresDefault()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub CodigoTipoPartida_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTIPO_PARTIDA.Leave
        lblnombretipopartida.Text = DescripcionesDB.TipoPartida(txtTIPO_PARTIDA.Text)
    End Sub

    Private Sub LabelTipoPartida_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitTIPO_PARTIDA.DoubleClick
        txtTIPO_PARTIDA.GenerarConsulta()
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Siguiente(True)
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim V As String = String.Empty

        System.Windows.Forms.Application.DoEvents()

        If Modo_Local <> Modo_Baja Then
            If MyBase.ValidarCampos(Frame1) = False Then
                Return
            End If

            MyBase.ErrorCampos.SetError(Me.cboCLASE_MOVIMIENTO, Nothing)
            If cboCLASE_MOVIMIENTO.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboCLASE_MOVIMIENTO, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Return
            End If
        End If

        V = V & "  @TIPO_MOVIMIENTO = " & sen(txtTIPO_MOVIMIENTO.GetValor())
        V = V & ", @DESCRIPCION_TIP_MOV = " & Scm(txtDESCRIPCION_TIP_MOV.Text)
        V = V & ", @CLASE_MOVIMIENTO = " & Scm(cboCLASE_MOVIMIENTO.SelectedValue.ToString)
        V = V & ", @TIPO_PARTIDA = " & Scm(txtTIPO_PARTIDA.Text)

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("TIPO_MOV_ACTIVOS", V) Then
            Grabado = True
            Me.HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class