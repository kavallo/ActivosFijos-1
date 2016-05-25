Imports Citi.Synergia.HelperClient

Public Class CXPCPIM0
    Public Property CodigoProveedor As String
    Public Property CodigoImpuesto As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        If Modo_Local = Modo_Alta Then
            txtCODIGO_IMPUESTO.Text = Me.CodigoImpuesto
            lblCODIGO_PROVEEDOR.Text = Me.CodigoProveedor
        Else
            txtCODIGO_IMPUESTO.Text = Me.CodigoImpuesto
            lblCODIGO_PROVEEDOR.Text = Me.CodigoProveedor
            Me.Leer()
        End If

        Grabado = False

        If Not String.IsNullOrEmpty(TraeDato("Select SUBSTRING(nombre_proveedor,1,40) from PROVEEDORES where CODIGO_PROVEEDOR = " & sen(Me.CodigoProveedor))) Then
            lblnombre_proveedor.Text = TraeDato("Select SUBSTRING(nombre_proveedor,1,40) from PROVEEDORES where CODIGO_PROVEEDOR = " & sen(Me.CodigoProveedor)).ToString
        End If

        Me.ValoresDefault()
    End Sub

    Private Sub kPila(ByVal Acción As Short)
        If Acción And cp_POP Then txtCODIGO_IMPUESTO.Text = Pop()
        If Acción And cp_POP Then lblCODIGO_PROVEEDOR.Text = Pop()
    End Sub

    Private Sub ValoresDefault()
        Dim cantidad As Integer = 0

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(COUNT(1), 0) from IMPUESTOS")) Then
            cantidad = CType(TraeDato("select IsNull(COUNT(1), 0) from IMPUESTOS"), Integer)
            If cantidad = 1 Then
                Me.txtCODIGO_IMPUESTO.Text = TraeDato("Select CODIGO_IMPUESTO From IMPUESTOS").ToString
                Me.CodigoImpuesto_Leave(Nothing, Nothing)
                Me.txtCODIGO_IMPUESTO.Enabled = False
                Me.lblTitCODIGO_IMPUESTO.Enabled = False
            End If
        End If
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" IMPUESTOS.DESCRIPCION_IMPUESTO, ")
                meteSQL("CXP_PROVEEDOR_IMPTO.timestamp ")
                meteSQL("from CXP_PROVEEDOR_IMPTO, IMPUESTOS")
                meteSQL(" where CXP_PROVEEDOR_IMPTO.CODIGO_IMPUESTO = " & Scm(txtCODIGO_IMPUESTO.Text) & " and CXP_PROVEEDOR_IMPTO.CODIGO_PROVEEDOR = " & sen(Me.CodigoProveedor))
                meteSQL(" and CXP_PROVEEDOR_IMPTO.CODIGO_IMPUESTO  =  IMPUESTOS.CODIGO_IMPUESTO")

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    lblDESCRIPCION_IMPUESTO.Text = SqlData(Sqlconn, 1).ToString

                    MyBase.ReadTimeStamp()

                    TimeStamp_Local = SysTimeStamp
                Loop
            End If

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                txtCODIGO_IMPUESTO.Enabled = False
                lblTitCODIGO_IMPUESTO.Enabled = False
            End If

            Me.CodigoImpuesto_Leave(Nothing, Nothing)

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
                Me.CodigoImpuesto_Leave(Nothing, Nothing)
                Me.ValoresDefault()
                Me.txtCODIGO_IMPUESTO.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                Me.txtCODIGO_IMPUESTO.Text = Pop()
                Me.Leer()
                Me.ValoresDefault()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub CodigoImpuesto_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitCODIGO_IMPUESTO.DoubleClick
        txtCODIGO_IMPUESTO.GenerarConsulta()
    End Sub

    Private Sub CodigoImpuesto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_IMPUESTO.Leave
        'lblDESCRIPCION_IMPUESTO.Text = ""
        'If txtCODIGO_IMPUESTO.Text.Trim.Length > 0 Then
        lblDESCRIPCION_IMPUESTO.Text = DescripcionesDB.Impuesto(txtCODIGO_IMPUESTO.Text)
        'End If
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

        V = V & " @CODIGO_PROVEEDOR = " & sen(Me.CodigoProveedor)
        V = V & ", @CODIGO_IMPUESTO = " & Scm(txtCODIGO_IMPUESTO.Text)

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("CXP_PROVEEDOR_IMPTO", V) Then
            Grabado = True
            Me.HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class