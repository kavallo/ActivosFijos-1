Public Class ACTCUTCB
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        If Modo_Local = Modo_Alta Then
            kPila(cp_POP)
        Else
            kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

        Grabado = False
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then txtCUENTA_CONTABLE.Text = Pop()
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" CATALOGO_CONT_DET.DESCRIPCION,")
                meteSQL(" CATALOGO_CONT_DET.timestamp ")
                meteSQL("from CATALOGO_CONT_DET")
                meteSQL(" where CATALOGO_CONT_DET.CUENTA_CONTABLE = " & Scm(txtCUENTA_CONTABLE.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    txtDESCRIPCION.Text = SqlData(Sqlconn, 1).ToString
                    MyBase.ReadTimeStamp()
                Loop
            End If

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                txtCUENTA_CONTABLE.Enabled = False
                lblTitCUENTA_CONTABLE.Enabled = txtCUENTA_CONTABLE.Enabled
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
                txtCUENTA_CONTABLE.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                txtCUENTA_CONTABLE.Text = Pop()
                Me.Leer()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Siguiente(True)
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim V As String = String.Empty

        System.Windows.Forms.Application.DoEvents()

        If Modo_Local <> Modo_Baja Then
            If MyBase.ValidarCampos(Frame1) = False Then
                Return
            End If
        End If

        V = V & "  @CUENTA_CONTABLE  = " & Scm(txtCUENTA_CONTABLE.Text)
        V = V & ", @DESCRIPCION   = " & Scm(txtDESCRIPCION.Text)

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("CATALOGO_CONT_DET", V) Then
            meteSQL("Exec sp_Genera_MG")
            EjecutaSQL("")
            Grabado = True
            Me.HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class