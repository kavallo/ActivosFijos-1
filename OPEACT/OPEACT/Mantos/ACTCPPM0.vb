Public Class ACTCPPM0
    Public Property NumeroPoliza As String
    Public Property NumeroEndoso As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        txtNUMERO_POLIZA.Text = NumeroPoliza
        txtNO_ENDOSO.Text = NumeroEndoso

        If Modo_Local = Modo_Alta Then
            Me.kPila(cp_POP)
            txtCODIGO_COBERTURA.Focus()
        Else
            kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
            txtNUMERO_POLIZA.Enabled = False
            lblTitNUMERO_POLIZA.Enabled = txtNUMERO_POLIZA.Enabled
            txtNO_ENDOSO.Enabled = txtNUMERO_POLIZA.Enabled
            lblTitNO_ENDOSO.Enabled = txtNUMERO_POLIZA.Enabled
            txtCODIGO_COBERTURA.Enabled = txtNUMERO_POLIZA.Enabled
            lblTitCODIGO_COBERTURA.Enabled = txtNUMERO_POLIZA.Enabled
            txtDESCRIPCION_COBERTUR.Focus()
        End If

        Grabado = False

        If SoloDeConsulta Then
            Me.cmdCancelar.Text = Me.cmdAceptar.Text
            cmdAceptar.Visible = False
            cmdAceptar.Enabled = cmdAceptar.Visible
        End If
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then txtCODIGO_COBERTURA.Text = Pop()
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" SEGUROS_COB.DESCRIPCION_COBERTUR, ")
                meteSQL(" ltrim(str(SEGUROS_COB.MONTO_ASEGURADO,14,2)), ")
                meteSQL(" SEGUROS_COB.OBSERVACIONES1, ")
                meteSQL(" SEGUROS_COB.OBSERVACIONES2, ")
                meteSQL(" SEGUROS_COB.OBSERVACIONES3, ")
                meteSQL(" SEGUROS_COB.timestamp ")
                meteSQL("from SEGUROS_COB")
                meteSQL(" where SEGUROS_COB.NO_ENDOSO = " & Scm(NumeroEndoso) & " and SEGUROS_COB.NUMERO_POLIZA = " & Scm(NumeroPoliza) & " and SEGUROS_COB.CODIGO_COBERTURA = " & sen(txtCODIGO_COBERTURA.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    txtDESCRIPCION_COBERTUR.Text = SqlData(Sqlconn, 1).ToString
                    txtMONTO_ASEGURADO.Text = SqlData(Sqlconn, 2).ToString
                    txtOBSERVACIONES1.Text = SqlData(Sqlconn, 3).ToString
                    txtOBSERVACIONES2.Text = SqlData(Sqlconn, 4).ToString
                    txtOBSERVACIONES3.Text = SqlData(Sqlconn, 5).ToString

                    MyBase.ReadTimeStamp()
                Loop
            End If

            MyBase.Habilitar()

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
                Me.Limpiar()
                txtNUMERO_POLIZA.Text = NumeroPoliza
                txtNO_ENDOSO.Text = NumeroEndoso
                txtCODIGO_COBERTURA.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                txtCODIGO_COBERTURA = Pop()
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

        If Modo_Local <> Modo_Baja Then
            If MyBase.ValidarCampos(TabDatos.TabPages(0)) = False Then
                TabDatos.SelectedIndex = 0
                Return
            End If
        End If

        V = V & "@NUMERO_POLIZA = " & Scm(NumeroPoliza)
        V = V & ", @NO_ENDOSO = " & Scm(NumeroEndoso)
        V = V & ", @CODIGO_COBERTURA = " & sen(txtCODIGO_COBERTURA.Text)
        V = V & ", @DESCRIPCION_COBERTUR = " & Scm(txtDESCRIPCION_COBERTUR.Text)
        V = V & ", @MONTO_ASEGURADO = " & sen(txtMONTO_ASEGURADO.GetValor())
        V = V & ", @OBSERVACIONES1 = " & Scm(txtOBSERVACIONES1.Text)
        V = V & ", @OBSERVACIONES2 = " & Scm(txtOBSERVACIONES2.Text)
        V = V & ", @OBSERVACIONES3 = " & Scm(txtOBSERVACIONES3.Text)

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("SEGUROS_COB", V) Then
            Grabado = True
            HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class