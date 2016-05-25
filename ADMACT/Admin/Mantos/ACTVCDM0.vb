Public Class ACTVCDM0
    Public Property CampoID As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        Me.LlenarEncabezado()

        If Modo_Local = Modo_Alta Then
            Me.kPila(cp_POP)
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

        Grabado = False
    End Sub

    Private Sub LlenarEncabezado()
        lblCAMPO_ID.Text = CampoID + " - "
        If Not String.IsNullOrEmpty(TraeDato("Select CAMPO_NOMBRE From ACT_CAMPO Where CAMPO_ID = " + Scm(CampoID))) Then
            lblCAMPO_ID.Text = CampoID + " - " + TraeDato("Select CAMPO_NOMBRE From ACT_CAMPO Where CAMPO_ID = " + Scm(CampoID)).ToString().Trim()
        End If
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then txtCAMPO_VALOR.Text = Pop()
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" ACT_CAMPOS_LV.CAMPO_DESCRIPCION, ")
                meteSQL(" ACT_CAMPOS_LV.timestamp ")
                meteSQL("from ACT_CAMPOS_LV")
                meteSQL(" where ACT_CAMPOS_LV.CAMPO_ID = " + Scm(CampoID) + " and ACT_CAMPOS_LV.CAMPO_VALOR = " + Scm(txtCAMPO_VALOR.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    txtCAMPO_DESCRIPCION.Text = SqlData(Sqlconn, 1).ToString

                    MyBase.ReadTimeStamp()
                Loop
            End If

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                txtCAMPO_VALOR.Enabled = False
                lblTitCAMPO_VALOR.Enabled = False
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
                txtCAMPO_VALOR.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                txtCAMPO_VALOR.Text = Pop()
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
            If MyBase.ValidarCampos(Me) = False Then
                Return
            End If
        End If

        V = V & "  @CAMPO_ID = " & Scm(lblCAMPO_ID.Text)
        V = V & ", @CAMPO_VALOR = " & Scm(txtCAMPO_VALOR.Text)
        V = V & ", @CAMPO_DESCRIPCION = " & Scm(txtCAMPO_DESCRIPCION.Text)

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("ACT_CAMPOS_LV", V) Then
            Grabado = True
            Me.HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class