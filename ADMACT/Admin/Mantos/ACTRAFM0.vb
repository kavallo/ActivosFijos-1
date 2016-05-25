Imports Citi.Synergia.HelperClient

Public Class ACTRAFM0
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
        If Acción And cp_POP Then txtRESPONSABLE_ID.Text = Pop()
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" ACT_RESPONSABLES.EMPLEADO_ID, ")
                meteSQL(" ACT_RESPONSABLES.NOMBRE_RESPONSABLE, ")
                meteSQL(" ACT_RESPONSABLES.APELLIDO_PATERNO, ")
                meteSQL(" ACT_RESPONSABLES.APELLIDO_MATERNO, ")
                meteSQL(" ACT_RESPONSABLES.APELLIDO_DE_CASADA, ")
                meteSQL(" ACT_RESPONSABLES.NOMBRE_USUAL, ")
                meteSQL(" ACT_RESPONSABLES.CODIGO_DIVISION, ")
                meteSQL("ACT_RESPONSABLES.timestamp ")
                meteSQL("from ACT_RESPONSABLES")
                meteSQL(" where ACT_RESPONSABLES.RESPONSABLE_ID = " & Scm(txtRESPONSABLE_ID.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    txtEMPLEADO_ID.Text = SqlData(Sqlconn, 1).ToString
                    txtNOMBRE_RESPONSABLE.Text = SqlData(Sqlconn, 2).ToString
                    txtAPELLIDO_PATERNO.Text = SqlData(Sqlconn, 3).ToString
                    txtAPELLIDO_MATERNO.Text = SqlData(Sqlconn, 4).ToString
                    txtAPELLIDO_DE_CASADA.Text = SqlData(Sqlconn, 5).ToString
                    txtNOMBRE_USUAL.Text = SqlData(Sqlconn, 6).ToString
                    txtCODIGO_DIVISION.Text = SqlData(Sqlconn, 7).ToString

                    MyBase.ReadTimeStamp()
                Loop
            End If

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                txtRESPONSABLE_ID.Enabled = False
                lblTitRESPONSABLE_ID.Enabled = txtRESPONSABLE_ID.Enabled
            End If

            Me.CodigoDivision_Leave(Nothing, Nothing)
            Me.IDEmpleado_Leave(Nothing, Nothing)

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
                Me.CodigoDivision_Leave(Nothing, Nothing)
                txtRESPONSABLE_ID.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                txtRESPONSABLE_ID.Text = Pop()
                Me.Leer()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub CodigoDivision_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_DIVISION.Leave
        lblDESCRIPCION_DIVISION.Text = DescripcionesDB.Division(txtCODIGO_DIVISION.Text)
    End Sub

    Private Sub CodigoLabel_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitEMPLEADO_ID.DoubleClick, lblTitCODIGO_DIVISION.DoubleClick
        Select Case sender.Name
            Case "lblTitEMPLEADO_ID"
                txtEMPLEADO_ID.GenerarConsulta()
            Case "lblTitCODIGO_DIVISION"
                txtCODIGO_DIVISION.GenerarConsulta()
        End Select
    End Sub

    Private Sub IDEmpleado_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEMPLEADO_ID.Leave
        If txtEMPLEADO_ID.Text <> "" Then
            If Not String.IsNullOrEmpty(TraeDato("Select NOMBRES From EMPLEADO Where EMPLEADO_ID = " & Scm(txtEMPLEADO_ID.Text))) Then
                txtNOMBRE_RESPONSABLE.Text = TraeDato("Select NOMBRES From EMPLEADO Where EMPLEADO_ID = " & Scm(txtEMPLEADO_ID.Text))
            End If
            If Not String.IsNullOrEmpty(TraeDato("Select APELLIDO_PATERNO From EMPLEADO Where EMPLEADO_ID = " & Scm(txtEMPLEADO_ID.Text))) Then
                txtAPELLIDO_PATERNO.Text = TraeDato("Select APELLIDO_PATERNO From EMPLEADO Where EMPLEADO_ID = " & Scm(txtEMPLEADO_ID.Text)).ToString
            End If
            If Not String.IsNullOrEmpty(TraeDato("Select APELLIDO_MATERNO From EMPLEADO Where EMPLEADO_ID = " & Scm(txtEMPLEADO_ID.Text))) Then
                txtAPELLIDO_MATERNO.Text = TraeDato("Select APELLIDO_MATERNO From EMPLEADO Where EMPLEADO_ID = " & Scm(txtEMPLEADO_ID.Text)).ToString
            End If
            If Not String.IsNullOrEmpty(TraeDato("Select APELLIDO_CASADA From EMPLEADO Where EMPLEADO_ID = " & Scm(txtEMPLEADO_ID.Text))) Then
                txtAPELLIDO_DE_CASADA.Text = TraeDato("Select APELLIDO_CASADA From EMPLEADO Where EMPLEADO_ID = " & Scm(txtEMPLEADO_ID.Text)).ToString
            End If
            If Not String.IsNullOrEmpty(TraeDato("Select NOMBRE_USUAL From EMPLEADO Where EMPLEADO_ID = " & Scm(txtEMPLEADO_ID.Text))) Then
                txtNOMBRE_USUAL.Text = TraeDato("Select NOMBRE_USUAL From EMPLEADO Where EMPLEADO_ID = " & Scm(txtEMPLEADO_ID.Text)).ToString
            End If
            If Not String.IsNullOrEmpty(TraeDato("Select CODIGO_DIVISION From EMPLEADO Where EMPLEADO_ID = " & Scm(txtEMPLEADO_ID.Text))) Then
                txtCODIGO_DIVISION.Text = TraeDato("Select CODIGO_DIVISION From EMPLEADO Where EMPLEADO_ID = " & Scm(txtEMPLEADO_ID.Text)).ToString
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

        V = V & "  @RESPONSABLE_ID = " & Scm(txtRESPONSABLE_ID.Text)
        V = V & ", @EMPLEADO_ID = " & Scm(txtEMPLEADO_ID.Text)
        V = V & ", @NOMBRE_RESPONSABLE = " & Scm(txtNOMBRE_RESPONSABLE.Text)
        V = V & ", @APELLIDO_PATERNO = " & Scm(txtAPELLIDO_PATERNO.Text)
        V = V & ", @APELLIDO_MATERNO = " & Scm(txtAPELLIDO_MATERNO.Text)
        V = V & ", @APELLIDO_DE_CASADA = " & Scm(txtAPELLIDO_DE_CASADA.Text)
        V = V & ", @NOMBRE_USUAL = " & Scm(txtNOMBRE_USUAL.Text)
        V = V & ", @CODIGO_DIVISION = " & Scm(txtCODIGO_DIVISION.Text)

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("ACT_RESPONSABLES", V) Then
            Grabado = True
            Me.HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class