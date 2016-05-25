Public Class ACTMARM0
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
        Dim omision As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With omision
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("O", Citi.Synergia.Traductor.Idiomas.GetMensaje(337, "O - Omisión")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(338, "N - No omisión")))
        End With

        With cboValorOmision
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = omision
        End With
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then txtCODIGO_MARCA.Text = Pop()
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" MARCAS.CODIGO_MARCA, ")
                meteSQL(" MARCAS.DESCRIPCION_MARCA, ")
                meteSQL(" MARCAS.VALOR_OMISION_MARCA, ")
                meteSQL(" MARCAS.timestamp ")
                meteSQL("from MARCAS")
                meteSQL(" where MARCAS.CODIGO_MARCA= " & Scm(txtCODIGO_MARCA.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    txtCODIGO_MARCA.Text = SqlData(Sqlconn, 1).ToString
                    txtDESCRIPCION.Text = SqlData(Sqlconn, 2).ToString
                    cboValorOmision.SelectedValue = SqlData(Sqlconn, 3).ToString

                    MyBase.ReadTimeStamp()
                Loop
            End If

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                txtCODIGO_MARCA.Enabled = False
                lblcodigo_marca.Enabled = txtCODIGO_MARCA.Enabled
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
                txtCODIGO_MARCA.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                txtCODIGO_MARCA.Text = Pop()
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

            MyBase.ErrorCampos.SetError(Me.cboValorOmision, Nothing)
            If cboValorOmision.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboValorOmision, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Return
            End If
        End If

        V = V & "  @CODIGO_MARCA = " & Scm(txtCODIGO_MARCA.Text)
        V = V & ", @DESCRIPCION= " & Scm(txtDESCRIPCION.Text)
        V = V & ", @VALOR_OMISION= " & Scm(cboValorOmision.SelectedValue)

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("MARCAS", V) Then
            Grabado = True
            Me.HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class