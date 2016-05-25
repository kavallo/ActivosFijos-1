Public Class ACTTSAM0
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        Me.LlenarCombos()

        If Modo_Local = Modo_Alta Then
            Me.kPila(cp_POP)
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

        Grabado = False
    End Sub

    Private Sub LlenarCombos()
        Dim claseDeServicio As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With claseDeServicio
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("C", Citi.Synergia.Traductor.Idiomas.GetMensaje(70, "C - Correctivo")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("P", Citi.Synergia.Traductor.Idiomas.GetMensaje(71, "P - Preventivo")))
        End With
        With cboCLASE_DE_SERVICIO
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = claseDeServicio
        End With
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then txtTIPO_SERVICIO.Text = Pop()
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" TIPOS_DE_SERVICIOS.DESCRIPCION_SERVICIO, ")
                meteSQL(" TIPOS_DE_SERVICIOS.CLASE_DE_SERVICIO, ")
                meteSQL(" TIPOS_DE_SERVICIOS.timestamp ")
                meteSQL("from TIPOS_DE_SERVICIOS")
                meteSQL(" where TIPOS_DE_SERVICIOS.TIPO_SERVICIO = " & Scm(txtTIPO_SERVICIO.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    txtDESCRIPCION_SERVICIO.Text = SqlData(Sqlconn, 1).ToString
                    cboCLASE_DE_SERVICIO.SelectedValue = SqlData(Sqlconn, 2).ToString

                    MyBase.ReadTimeStamp()

                    TimeStamp_Local = SysTimeStamp
                Loop
            End If

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                txtTIPO_SERVICIO.Enabled = False
                lblTitTIPO_SERVICIO.Enabled = txtTIPO_SERVICIO.Enabled
            End If

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
                txtTIPO_SERVICIO.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                txtTIPO_SERVICIO.Text = Pop()
                Me.Leer()
            Else
                Me.Close()
            End If
        End If
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

            MyBase.ErrorCampos.SetError(Me.cboCLASE_DE_SERVICIO, Nothing)
            If cboCLASE_DE_SERVICIO.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboCLASE_DE_SERVICIO, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Return
            End If
        End If

        V = V & "  @TIPO_SERVICIO = " & Scm(txtTIPO_SERVICIO.Text)
        V = V & ", @DESCRIPCION_SERVICIO = " & Scm(txtDESCRIPCION_SERVICIO.Text)
        V = V & ", @CLASE_DE_SERVICIO = " & Scm(cboCLASE_DE_SERVICIO.SelectedValue.ToString)

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("TIPOS_DE_SERVICIOS", V) Then
            Grabado = True
            Me.HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class