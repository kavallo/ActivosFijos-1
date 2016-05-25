Imports Citi.Synergia.HelperClient

Public Class ACTSEEM1
    Dim varENDOSO_ANTERIOR As String = String.Empty
    Dim varESTADO_POLIZA As String = String.Empty
    Dim endoso_ant As String = String.Empty

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        If Modo_Local = Modo_Alta Then
            Me.kPila(cp_POP)
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()

            txtNUMERO_POLIZA.Enabled = False
            lblTitNUMERO_POLIZA.Enabled = txtNUMERO_POLIZA.Enabled
        End If

        endoso_ant = txtNO_ENDOSO.Text

        Me.ValoresDefault()

        Grabado = False
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then txtNO_ENDOSO.Text = Pop()
        If Acción And cp_POP Then txtNUMERO_POLIZA.Text = Pop()
    End Sub

    Private Sub ValoresDefault()
        If Not String.IsNullOrEmpty(TraeDato("select IsNull(COUNT(1), 0) from MONEDAS")) Then
            Dim cantidad As Integer = CType(TraeDato("select IsNull(COUNT(1), 0) from MONEDAS"), Integer)
            If cantidad = 1 Then
                Me.txtCODIGO_DE_MONEDA.Text = TraeDato("Select CODIGO_DE_MONEDA From MONEDAS").ToString
                lblnombremoneda.Text = DescripcionesDB.Monedas(txtCODIGO_DE_MONEDA.Text)
                Me.lblTitCODIGO_DE_MONEDA.Enabled = False
                Me.txtCODIGO_DE_MONEDA.Enabled = False
            End If
        End If
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" SEGUROS_ENC.ENDOSO_ANTERIOR, ")
                meteSQL(" SEGUROS_ENC.ESTADO_POLIZA, ")
                meteSQL(" convert(varchar(10),SEGUROS_ENC.FECHA_I_VIGENCIA,101), ")
                meteSQL(" convert(varchar(10),SEGUROS_ENC.FECHA_F_VIGENCIA,101), ")
                meteSQL(" SEGUROS_ENC.COMPANIA_SEGUROS, ")
                meteSQL(" SEGUROS_ENC.CONTACTO_COMPANIA, ")
                meteSQL(" SEGUROS_ENC.TELEFONO_COMPANIA, ")
                meteSQL(" SEGUROS_ENC.FAX_COMPANIA, ")
                meteSQL(" SEGUROS_ENC.NOMBRE_CORREDOR, ")
                meteSQL(" SEGUROS_ENC.CONTACTO_CORREDOR, ")
                meteSQL(" SEGUROS_ENC.TELEFONO_CORREDOR, ")
                meteSQL(" SEGUROS_ENC.FAX_CORREDOR, ")
                meteSQL(" ltrim(str(SEGUROS_ENC.MONTO_PRIMA,14,2)), ")
                meteSQL(" ltrim(str(SEGUROS_ENC.TOTAL_SEGURO,14,2)), ")
                meteSQL(" SEGUROS_ENC.CODIGO_DE_MONEDA, ")
                meteSQL(" SEGUROS_ENC.timestamp ")
                meteSQL("from SEGUROS_ENC")
                meteSQL(" where SEGUROS_ENC.NO_ENDOSO = " + Scm(txtNO_ENDOSO.Text) + " and SEGUROS_ENC.NUMERO_POLIZA = " + Scm(txtNUMERO_POLIZA.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    varENDOSO_ANTERIOR = SqlData(Sqlconn, 1).ToString
                    varESTADO_POLIZA = SqlData(Sqlconn, 2).ToString
                    mskFechaI.EscribirFecha(SqlData(Sqlconn, 3).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    mskFechaF.EscribirFecha(SqlData(Sqlconn, 4).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    txtCOMPANIA_SEGUROS.Text = SqlData(Sqlconn, 5).ToString
                    txtCONTACTO_COMPANIA.Text = SqlData(Sqlconn, 6).ToString
                    txtTELEFONO_COMPANIA.Text = SqlData(Sqlconn, 7).ToString
                    txtFAX_COMPANIA.Text = SqlData(Sqlconn, 8).ToString
                    txtNOMBRE_CORREDOR.Text = SqlData(Sqlconn, 9).ToString
                    txtCONTACTO_CORREDOR.Text = SqlData(Sqlconn, 10).ToString
                    txtTELEFONO_CORREDOR.Text = SqlData(Sqlconn, 11).ToString
                    txtFAX_CORREDOR.Text = SqlData(Sqlconn, 12).ToString
                    txtMONTO_PRIMA.Text = SqlData(Sqlconn, 13).ToString
                    txtTOTAL_SEGURO.Text = SqlData(Sqlconn, 14).ToString
                    txtCODIGO_DE_MONEDA.Text = SqlData(Sqlconn, 15).ToString

                    MyBase.ReadTimeStamp()
                Loop
            End If

            MyBase.Habilitar()

            Me.CodigoMoneda_Leave(Nothing, Nothing)

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
                Me.CodigoMoneda_Leave(Nothing, Nothing)
                Me.ValoresDefault()
                txtNUMERO_POLIZA.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                txtNO_ENDOSO.Text = Pop()
                txtNUMERO_POLIZA.Text = Pop()
                Me.Leer()
                Me.ValoresDefault()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub LabelCodigoMoneda_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitCODIGO_DE_MONEDA.DoubleClick
        txtCODIGO_DE_MONEDA.GenerarConsulta()
    End Sub

    Private Sub CodigoMoneda_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_DE_MONEDA.Leave
        lblnombremoneda.Text = DescripcionesDB.Monedas(txtCODIGO_DE_MONEDA.Text)
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Siguiente(True)
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim V As String = String.Empty
        If Modo_Local <> Modo_Baja Then
            If MyBase.ValidarCampos(Folder.TabPages(0)) = False Then
                Folder.SelectedIndex = 0
                Return
            End If
        End If

        V = V & "  @NUMERO_POLIZA = " & Scm(txtNUMERO_POLIZA.Text)
        V = V & ", @NO_ENDOSO = " & Scm(txtNO_ENDOSO.Text)
        V = V & ", @FECHA_I_VIGENCIA = " & Scm(mskFechaI.TextMMDDYYYY)
        V = V & ", @FECHA_F_VIGENCIA = " & Scm(mskFechaF.TextMMDDYYYY)
        V = V & ", @COMPANIA_SEGUROS = " & Scm(txtCOMPANIA_SEGUROS.Text)
        V = V & ", @CONTACTO_COMPANIA = " & Scm(txtCONTACTO_COMPANIA.Text)
        V = V & ", @TELEFONO_COMPANIA = " & Scm(txtTELEFONO_COMPANIA.Text)
        V = V & ", @FAX_COMPANIA = " & Scm(txtFAX_COMPANIA.Text)
        V = V & ", @NOMBRE_CORREDOR = " & Scm(txtNOMBRE_CORREDOR.Text)
        V = V & ", @CONTACTO_CORREDOR = " & Scm(txtCONTACTO_CORREDOR.Text)
        V = V & ", @TELEFONO_CORREDOR = " & Scm(txtTELEFONO_CORREDOR.Text)
        V = V & ", @FAX_CORREDOR = " & Scm(txtFAX_CORREDOR.Text)
        V = V & ", @MONTO_PRIMA = " & sen(txtMONTO_PRIMA.GetValor())
        V = V & ", @TOTAL_SEGURO = " & sen(txtTOTAL_SEGURO.GetValor())
        V = V & ", @CODIGO_DE_MONEDA = " & Scm(txtCODIGO_DE_MONEDA.Text)
        V = V & ", @ESTADO_POLIZA = 'A'"
        V = V & ", @ENDOSO_ANTERIOR = " & Scm(endoso_ant)

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local
        Modo = Modo_Alta

        If sp("SEGUROS_ENC", V) Then
            Grabado = True
            HubieronCambios = True

            Dim comando As New SqlClient.SqlCommand
            With comando
                .Parameters.Add("@NUMERO_POLIZA", SqlDbType.Char, 20).Value = txtNUMERO_POLIZA.Text
                .Parameters.Add("@ENDOSO_ANT", SqlDbType.Char, 15).Value = endoso_ant
                .Parameters.Add("@ENDOSO_ACT", SqlDbType.Char, 15).Value = txtNO_ENDOSO.Text
                .CommandText = "sp_Actualizaciones_Por_Endoso"
                .CommandType = CommandType.StoredProcedure
            End With

            EjecutarComando(comando)

            Me.Siguiente()
        End If
    End Sub
End Class