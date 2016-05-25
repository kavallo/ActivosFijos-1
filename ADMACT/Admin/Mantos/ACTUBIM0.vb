Public Class ACTUBIM0
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
        Dim codigos As New List(Of Citi.Synergia.Entidades.EstadoActivoInactivo)
        With codigos
            .Add(New Citi.Synergia.Entidades.EstadoActivoInactivo("A", Citi.Synergia.Traductor.Idiomas.GetMensaje(72, "A - Activo")))
            .Add(New Citi.Synergia.Entidades.EstadoActivoInactivo("X", Citi.Synergia.Traductor.Idiomas.GetMensaje(73, "X - Inactivo")))
        End With
        With cboESTADO_UBICACION
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = codigos
        End With
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then CODIGO_UBICACION.Text = Pop()
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("Select DESCRIPCION_UBICACION")
                meteSQL("     , ESTADO_UBICACION")
                meteSQL("  From UBICACION_ACTIVO")
                meteSQL(" Where CODIGO_UBICACION = " & Scm(CODIGO_UBICACION.Text))
                meteSQL("")

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    DESCRIPCION_UBICACION.Text = SqlData(Sqlconn, 1).ToString
                    cboESTADO_UBICACION.SelectedValue = SqlData(Sqlconn, 2).ToString
                Loop
            End If

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                CODIGO_UBICACION.Enabled = False
                lblCODIGO_UBICACION.Enabled = CODIGO_UBICACION.Enabled
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
                Me.CODIGO_UBICACION.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                Me.CODIGO_UBICACION.Text = Pop()
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

            MyBase.ErrorCampos.SetError(Me.cboESTADO_UBICACION, Nothing)
            If cboESTADO_UBICACION.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboESTADO_UBICACION, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Return
            End If
        End If

        V = V & "  @CODIGO_UBICACION      = " & Scm(CODIGO_UBICACION.Text)
        V = V & ", @DESCRIPCION_UBICACION = " & Scm(DESCRIPCION_UBICACION.Text)
        V = V & ", @ESTADO_UBICACION      = " & Scm(cboESTADO_UBICACION.SelectedValue.ToString)

        Modo = Modo_Local

        If sp("UBICACION_ACTIVO", V) Then
            Grabado = True
            Me.HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class