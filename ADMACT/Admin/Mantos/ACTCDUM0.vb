Imports Citi.Synergia.HelperClient

Public Class ACTCDUM0
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        Me.LlenarCombos()

        If Modo_Local = Modo_Alta Then
            kPila(cp_POP)
        Else
            kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

        Grabado = False
    End Sub

    Private Sub LlenarCombos()
        Dim campoOpcional As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With campoOpcional
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(46, "N - No es opcional")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("S", Citi.Synergia.Traductor.Idiomas.GetMensaje(47, "S - Si es opcional")))
        End With
        With cboCAMPO_OPCIONAL
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = campoOpcional
        End With

        Dim campoListaValores As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With campoListaValores
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(48, "N - No tiene lista de valores")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("S", Citi.Synergia.Traductor.Idiomas.GetMensaje(49, "S - Si tiene lista de valores")))
        End With
        With cboCAMPO_LISTA_VALORES
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = campoListaValores
        End With
    End Sub

    Private Sub kPila(ByVal Acción As Short)
        If Acción And cp_POP Then txtCAMPO_ID.Text = Pop()
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" ACT_CAMPO.CAMPO_NOMBRE, ")
                meteSQL(" ACT_CAMPO.CAMPO_TITULO, ")
                meteSQL(" ACT_CAMPO.CAMPO_OPCIONAL, ")
                meteSQL(" ACT_CAMPO.CAMPO_LISTA_VALORES, ")
                meteSQL(" ACT_CAMPO.CODIGO_TIPO_ACTIVO, ")
                meteSQL(" ACT_CAMPO.timestamp ")
                meteSQL(" from ACT_CAMPO")
                meteSQL(" where ACT_CAMPO.CAMPO_ID = " & Scm(txtCAMPO_ID.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    txtCAMPO_NOMBRE.Text = SqlData(Sqlconn, 1).ToString
                    txtCAMPO_TITULO.Text = SqlData(Sqlconn, 2).ToString
                    cboCAMPO_OPCIONAL.SelectedValue = SqlData(Sqlconn, 3).ToString
                    cboCAMPO_LISTA_VALORES.SelectedValue = SqlData(Sqlconn, 4).ToString
                    txtCODIGO_TIPOACTIVO.Text = SqlData(Sqlconn, 5).ToString

                    MyBase.ReadTimeStamp()

                    TimeStamp_Local = SysTimeStamp
                Loop
            End If

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                txtCAMPO_ID.Enabled = False
                lblTitCAMPO_ID.Enabled = txtCAMPO_ID.Enabled
            End If

            Me.TipoActivo_Leave(Nothing, Nothing)

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
                lblDESCRIPCION_TIPOACTIVO.Text = ""
                txtCAMPO_ID.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                txtCAMPO_ID.Text = Pop()
                Me.Leer()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub TipoActivo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_TIPOACTIVO.Leave
        lblDESCRIPCION_TIPOACTIVO.Text = DescripcionesDB.TipoDeActivo(txtCODIGO_TIPOACTIVO.Text)
    End Sub

    Private Sub TipoActivoLabel_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTIPOACTIVO.DoubleClick
        txtCODIGO_TIPOACTIVO.GenerarConsulta()
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

            MyBase.ErrorCampos.SetError(Me.cboCAMPO_OPCIONAL, Nothing)
            If cboCAMPO_OPCIONAL.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboCAMPO_OPCIONAL, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Return
            End If

            MyBase.ErrorCampos.SetError(Me.cboCAMPO_LISTA_VALORES, Nothing)
            If cboCAMPO_LISTA_VALORES.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboCAMPO_LISTA_VALORES, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Return
            End If

            MyBase.ErrorCampos.SetError(Me.txtCODIGO_TIPOACTIVO, Nothing)
            If lblDESCRIPCION_TIPOACTIVO.Text = "" And txtCODIGO_TIPOACTIVO.Text <> "" Then
                MyBase.ErrorCampos.SetError(txtCODIGO_TIPOACTIVO, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Return
            End If
        End If

        V = V & "  @CAMPO_ID            = " & Scm(txtCAMPO_ID.Text)
        V = V & ", @CAMPO_NOMBRE        = " & Scm(txtCAMPO_NOMBRE.Text)
        V = V & ", @CAMPO_TITULO        = " & Scm(txtCAMPO_TITULO.Text)
        V = V & ", @CAMPO_OPCIONAL      = " & Scm(cboCAMPO_OPCIONAL.SelectedValue.ToString)
        V = V & ", @CAMPO_LISTA_VALORES = " & Scm(cboCAMPO_LISTA_VALORES.SelectedValue.ToString)
        V = V & ", @CODIGO_TIPO_ACTIVO  = " & Scm(txtCODIGO_TIPOACTIVO.Text)

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("ACT_CAMPO", V) Then
            Grabado = True
            Me.HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class