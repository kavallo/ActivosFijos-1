Public Class ACTCDAM0
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
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
        If Acción And cp_POP Then txtCATEGORIA_ID.Text = Pop()
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" ACT_CATEGORIAS.CATEGORIA_DESC, ")
                meteSQL(" ACT_CATEGORIAS.timestamp ")
                meteSQL("from ACT_CATEGORIAS")
                meteSQL(" where ACT_CATEGORIAS.CATEGORIA_ID = " & Scm(txtCATEGORIA_ID.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    txtCATEGORIA_DESC.Text = SqlData(Sqlconn, 1).ToString
                    MyBase.ReadTimeStamp()
                Loop
            End If

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                txtCATEGORIA_ID.Enabled = False
                lblTitCATEGORIA_ID.Enabled = txtCATEGORIA_ID.Enabled
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
                txtCATEGORIA_ID.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                txtCATEGORIA_ID.Text = Pop()
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
        End If

        V = V & "  @CATEGORIA_ID = " & Scm(txtCATEGORIA_ID.Text)
        V = V & ", @CATEGORIA_DESC = " & Scm(txtCATEGORIA_DESC.Text)

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("ACT_CATEGORIAS", V) Then
            Grabado = True
            Me.HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class