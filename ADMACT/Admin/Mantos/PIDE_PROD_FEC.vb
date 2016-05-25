Public Class PIDE_PROD_FEC
    Public Property Producto As String
    Public Property FechaInicial As String
    Public Property FechaFinal As String

    Public Property Respuesta As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()

        If Me.Producto.Trim.Length > 0 Then
            txtPRODUCT0.Visible = False
            lblProducto.Visible = False
        End If

        '-- Las fechas vienen en formato mm/dd/aaa
        If Me.FechaInicial.Trim.Length > 0 Then
            mskFECHA_INI.EscribirFecha(Me.FechaInicial, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
        End If

        If Me.FechaFinal.Trim.Length > 0 Then
            mskFECHA_FIN.EscribirFecha(Me.FechaFinal, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
        End If
    End Sub

    Private Sub Cerrar()
        If Respuesta = "*" Then
            Me.Producto = txtPRODUCT0.Text
            Me.FechaInicial = mskFECHA_INI.TextMMDDYYYY()
            Me.FechaFinal = mskFECHA_FIN.TextMMDDYYYY()
        Else
            Me.FechaInicial = "99/99/9999"
            Me.FechaFinal = "99/99/9999"
        End If

        Me.Close()
    End Sub

    Private Sub Producto_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblProducto.DoubleClick
        txtPRODUCT0.GenerarConsulta()
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Cerrar()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Respuesta = "*"

        Me.txtPRODUCT0.EsRequerido = Me.txtPRODUCT0.Visible

        If MyBase.ValidarCampos(Me) = False Then
            Me.Respuesta = ""
            Exit Sub
        End If

        Dim inicial As String
        Dim final As String

        inicial = mskFECHA_INI.TextMMDDYYYY()
        final = mskFECHA_FIN.TextMMDDYYYY()

        If Not ValidaFecha(inicial, final) Then
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(202, "Fecha inicial es mayor que fecha final."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mskFECHA_INI.Focus()
            Me.Respuesta = ""
            Exit Sub
        End If

        Dim producto As Integer = 0
        If txtPRODUCT0.Visible = True Then
            producto = CType(TraeDato("select count(*) from MAESTRO_PRODUCTOS where PRODUCT0 = " & Scm(txtPRODUCT0.Text)), Integer)
            If Producto = 0 Then
                MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(211, "Producto a consultar no existe."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtPRODUCT0.Focus()
                Me.Respuesta = ""
                Exit Sub
            End If
        End If

        Me.Cerrar()
    End Sub
End Class