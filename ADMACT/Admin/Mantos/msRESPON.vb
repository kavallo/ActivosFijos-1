Imports Citi.Synergia.HelperClient

Public Class msRESPON
    Public Property CodigoDivision As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        Me.LlenarEncabezado()

        Me.LlenarCombos()

        If Modo_Local = Modo_Alta Then
            Me.kPila(cp_POP)
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

        Grabado = False
    End Sub

    Private Sub LlenarEncabezado()
        lblCODIGO_DIVISION.Text = CodigoDivision.Trim + " - " + DescripcionesDB.Division(CodigoDivision)
    End Sub

    Private Sub LlenarCombos()
        Dim estados As New List(Of Citi.Synergia.Entidades.EstadoActivoInactivo)
        estados.Add(New Citi.Synergia.Entidades.EstadoActivoInactivo("A", Citi.Synergia.Traductor.Idiomas.GetMensaje(72, "A - Activo")))
        estados.Add(New Citi.Synergia.Entidades.EstadoActivoInactivo("I", Citi.Synergia.Traductor.Idiomas.GetMensaje(74, "I - Inactivo")))

        With cboESTADO_RESPONSABLE
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = estados
        End With
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then txtCODIGO_RESPONSABLE.Text = Pop()
    End Sub

    Private Sub Leer()
        If Modo_Local <> Modo_Alta Then
            meteSQL("select")
            meteSQL(" RESPONSABLEXDIVISION.NOMBRE_RESPONSABLE, ")
            meteSQL(" RESPONSABLEXDIVISION.ESTADO_RESPONSABLE, ")
            meteSQL(" RESPONSABLEXDIVISION.timestamp ")
            meteSQL("from DIVISIONES, RESPONSABLEXDIVISION")
            meteSQL(" where RESPONSABLEXDIVISION.CODIGO_DIVISION = " & Scm(CodigoDivision) & " and RESPONSABLEXDIVISION.CODIGO_RESPONSABLE = " & Scm(txtCODIGO_RESPONSABLE.Text))
            meteSQL(" and RESPONSABLEXDIVISION.CODIGO_DIVISION  =  DIVISIONES.CODIGO_DIVISION")

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                txtNOMBRE_RESPONSABLE.Text = SqlData(Sqlconn, 1).ToString
                cboESTADO_RESPONSABLE.SelectedValue = SqlData(Sqlconn, 2).ToString

                MyBase.ReadTimeStamp()
            Loop
        End If

        MyBase.Habilitar()

        If Modo_Local <> Modo_Alta Then
            Me.txtCODIGO_RESPONSABLE.Enabled = False
        End If
        Me.lblTitCODIGO_RESPONSABLE.Enabled = Me.txtCODIGO_RESPONSABLE.Enabled
    End Sub

    Private Sub Siguiente(Optional ByVal cancelar As Boolean = False)
        If Modo_Local = Modo_Alta Then
            If cancelar Then
                Me.Close()
            Else
                MyBase.Limpiar()
                txtCODIGO_RESPONSABLE.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                txtCODIGO_RESPONSABLE.Text = Pop()
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

            MyBase.ErrorCampos.SetError(Me.cboESTADO_RESPONSABLE, Nothing)
            If cboESTADO_RESPONSABLE.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboESTADO_RESPONSABLE, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Return
            End If
        End If

        V = V & "  @CODIGO_DIVISION = " & Scm(CodigoDivision)
        V = V & ", @CODIGO_RESPONSABLE = " & Scm(txtCODIGO_RESPONSABLE.Text)
        V = V & ", @NOMBRE_RESPONSABLE = " & Scm(txtNOMBRE_RESPONSABLE.Text)
        V = V & ", @ESTADO_RESPONSABLE = " & Scm(cboESTADO_RESPONSABLE.SelectedValue.ToString)

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("RESPONSABLEXDIVISION", V) Then
            Grabado = True
            Me.HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class