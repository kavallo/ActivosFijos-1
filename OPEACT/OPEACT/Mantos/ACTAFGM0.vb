Imports Citi.Synergia.HelperClient

Public Class ACTAFGM0
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        cmdBorrar.Visible = False

        Me.kPila(cp_POP)

        Me.Leer()

        lblDESCRIP_CORTA_ACTIVO.Text = DescripcionesDB.DescripcionCortaActivo(lblCODIGO_DE_ACTIVO.Text, lblMEJORA_CORRELATIVO.Text)

        Grabado = False
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then lblMEJORA_CORRELATIVO.Text = Pop()
        If Acción And cp_POP Then lblCODIGO_DE_ACTIVO.Text = Pop()
    End Sub

    Private Sub Leer()
        Try
            meteSQL("select")
            meteSQL(" ACTIVOS_FIJOS_GEN.DESCRIP_LARGA_UNO, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.DESCRIP_LARGA_DOS, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.DESCRIP_LARGA_TRES, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.MARCA, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.NUMERO_SERIE_ACTIVO, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.MODELO_DEL_ACTIVO, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.ESTILO_DEL_ACTIVO, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.CHASIS_ACTIVO, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.DESC_GARANTIA_1, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.DESC_GARANTIA_2, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.DESC_GARANTIA_3, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.DESC_GARANTIA_4, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.timestamp ")
            meteSQL("from ACTIVOS_FIJOS, ACTIVOS_FIJOS_GEN")
            meteSQL(" where ACTIVOS_FIJOS_GEN.CODIGO_DE_ACTIVO = " & Scm(lblCODIGO_DE_ACTIVO.Text) & " and ACTIVOS_FIJOS_GEN.MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text))
            meteSQL(" and ACTIVOS_FIJOS_GEN.CODIGO_DE_ACTIVO  =  ACTIVOS_FIJOS.CODIGO_DE_ACTIVO and ACTIVOS_FIJOS_GEN.MEJORA_CORRELATIVO  =  ACTIVOS_FIJOS.MEJORA_CORRELATIVO")

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                txtDESCRIP_LARGA_UNO.Text = SqlData(Sqlconn, 1).ToString
                txtDESCRIP_LARGA_DOS.Text = SqlData(Sqlconn, 2).ToString
                txtDESCRIP_LARGA_TRES.Text = SqlData(Sqlconn, 3).ToString
                txtMARCA.Text = SqlData(Sqlconn, 4).ToString
                txtNUMERO_SERIE_ACTIVO.Text = SqlData(Sqlconn, 5).ToString
                txtMODELO_DEL_ACTIVO.Text = SqlData(Sqlconn, 6).ToString
                txtESTILO_DEL_ACTIVO.Text = SqlData(Sqlconn, 7).ToString
                txtCHASIS_ACTIVO.Text = SqlData(Sqlconn, 8).ToString
                'No se recuperan de la tabla general sino
                'de la referencia del catalogo de activos
                '----------------------------------------
                'txtUBICACION_ACTIVO = SqlData(sqlconn, 9)
                'txtRESPONSABLE_ACTIVO = SqlData(sqlconn, 10)
                DES_GARANTIA_1.Text = SqlData(Sqlconn, 9).ToString
                DES_GARANTIA_2.Text = SqlData(Sqlconn, 10).ToString
                DES_GARANTIA_3.Text = SqlData(Sqlconn, 11).ToString
                DES_GARANTIA_4.Text = SqlData(Sqlconn, 12).ToString

                MyBase.ReadTimeStamp()

                TimeStamp_Local = SysTimeStamp
                Modo_Local = Modo_Cambio
                cmdBorrar.Visible = True
            Loop

            'Recuperamos Ubicacion y Responsable
            meteSQL("Select (Select DESCRIPCION_UBICACION from UBICACION_ACTIVO U")
            meteSQL("         Where U.CODIGO_UBICACION = A.CODIGO_UBICACION)")
            meteSQL("     , (Select NOMBRE_USUAL From ACT_RESPONSABLES R")
            meteSQL("         Where R.RESPONSABLE_ID = A.RESPONSABLE_ID)")
            meteSQL("  From ACTIVOS_FIJOS A")
            meteSQL(" Where A.CODIGO_DE_ACTIVO   = " & Scm(lblCODIGO_DE_ACTIVO.Text))
            meteSQL("   And A.MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text))

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                txtUBICACION_ACTIVO.Text = SqlData(Sqlconn, 1).ToString
                txtRESPONSABLE_ACTIVO.Text = SqlData(Sqlconn, 2).ToString
            Loop

            MyBase.Habilitar()

            txtUBICACION_ACTIVO.Enabled = False
            txtRESPONSABLE_ACTIVO.Enabled = txtUBICACION_ACTIVO.Enabled

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Grabar()
        Dim V As String = String.Empty

        If Modo_Local <> Modo_Baja Then
            If MyBase.ValidarCampos(Me) = False Then
                Return
            End If
        End If

        V = V & "  @CODIGO_DE_ACTIVO = " & Scm(lblCODIGO_DE_ACTIVO.Text)
        V = V & ", @MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text)
        V = V & ", @DESCRIP_LARGA_UNO = " & Scm(txtDESCRIP_LARGA_UNO.Text)
        V = V & ", @DESCRIP_LARGA_DOS = " & Scm(txtDESCRIP_LARGA_DOS.Text)
        V = V & ", @DESCRIP_LARGA_TRES = " & Scm(txtDESCRIP_LARGA_TRES.Text)
        V = V & ", @MARCA = " & Scm(txtMARCA.Text)
        V = V & ", @NUMERO_SERIE_ACTIVO = " & Scm(txtNUMERO_SERIE_ACTIVO.Text)
        V = V & ", @MODELO_DEL_ACTIVO = " & Scm(txtMODELO_DEL_ACTIVO.Text)
        V = V & ", @ESTILO_DEL_ACTIVO = " & Scm(txtESTILO_DEL_ACTIVO.Text)
        V = V & ", @CHASIS_ACTIVO = " & Scm(txtCHASIS_ACTIVO.Text)
        V = V & ", @UBICACION_ACTIVO = " & Scm(txtUBICACION_ACTIVO.Text)
        V = V & ", @RESPONSABLE_ACTIVO = " & Scm(txtRESPONSABLE_ACTIVO.Text)
        V = V & ", @DESC_GARANTIA_1 = " & Scm(DES_GARANTIA_1.Text)
        V = V & ", @DESC_GARANTIA_2 = " & Scm(DES_GARANTIA_2.Text)
        V = V & ", @DESC_GARANTIA_3 = " & Scm(DES_GARANTIA_3.Text)
        V = V & ", @DESC_GARANTIA_4 = " & Scm(DES_GARANTIA_4.Text)
        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("ACTIVOS_FIJOS_GEN", V) Then
            Grabado = True
            HubieronCambios = True

            Me.Siguiente()
        End If
    End Sub

    Private Sub Siguiente(Optional ByVal cancelar As Boolean = False)
        If Modo_Local = Modo_Alta Then
            If cancelar Then
                Me.Close()
            Else
                MyBase.Limpiar()
                txtUBICACION_ACTIVO.Enabled = False
                txtRESPONSABLE_ACTIVO.Enabled = txtUBICACION_ACTIVO.Enabled
                txtDESCRIP_LARGA_UNO.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                lblMEJORA_CORRELATIVO.Text = Pop()
                lblCODIGO_DE_ACTIVO.Text = Pop()
                lblMEJORA_CORRELATIVO.Text = Pop()
                Leer()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Siguiente(True)
    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Modo_Local = Modo_Baja
        Me.Grabar()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Grabar()
    End Sub
End Class