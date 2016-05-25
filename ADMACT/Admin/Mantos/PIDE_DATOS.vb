Public Class PIDE_DATOS
    Public Property CodigoMoneda As String
    Public Property FechaInicial As String
    Public Property FechaFinal As String
    Public Property TasaTipo As String
    Public Property Respuesta As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()

        Me.Respuesta = ""

        txtCODIGO_DE_MONEDA.Text = Me.CodigoMoneda

        '-- Las fechas vienen en formado mm/dd/aaaa
        If Me.FechaInicial.Trim.Length > 0 Then
            mskFECHA_INI.EscribirFecha(Me.FechaInicial, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
        End If
        If Me.FechaFinal.Trim.Length > 0 Then
            mskFECHA_FIN.EscribirFecha(Me.FechaFinal, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
        End If
        
        Me.LlenarCombos()

        Me.ValoresDefault()
    End Sub

    Private Sub LlenarCombos()
        Dim cambioTasas As New List(Of Citi.Synergia.Entidades.EstadoActivoInactivo)
        With cambioTasas
            .Add(New Citi.Synergia.Entidades.EstadoActivoInactivo("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(197, "D - Diario")))
            .Add(New Citi.Synergia.Entidades.EstadoActivoInactivo("H", Citi.Synergia.Traductor.Idiomas.GetMensaje(198, "H - Histórico")))
            .Add(New Citi.Synergia.Entidades.EstadoActivoInactivo("H", Citi.Synergia.Traductor.Idiomas.GetMensaje(199, "P - Promedio")))
        End With

        With cboTIP_CAMBIO_TASAS_CAM
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = cambioTasas
        End With
    End Sub

    Private Sub ValoresDefault()
        Dim cantidad As Integer = 0
        If Not String.IsNullOrEmpty(TraeDato("select IsNull(COUNT(1), 0) from MONEDAS")) Then
            cantidad = CType(TraeDato("select IsNull(COUNT(1), 0) from MONEDAS"), Integer)
            If cantidad = 1 Then
                Me.txtCODIGO_DE_MONEDA.Text = TraeDato("Select CODIGO_DE_MONEDA From MONEDAS").ToString
                Me.txtCODIGO_DE_MONEDA.Enabled = False
                Me.lblCodigoMoneda.Enabled = False
            End If
        End If
    End Sub

    Private Sub Cerrar()
        Dim tasa As String = Me.cboTIP_CAMBIO_TASAS_CAM.SelectedValue.ToString

        Me.CodigoMoneda = Me.txtCODIGO_DE_MONEDA.Text
        Me.TasaTipo = tasa

        If Respuesta = "*" Then
            Me.FechaInicial = mskFECHA_INI.TextMMDDYYYY()
            Me.FechaFinal = mskFECHA_FIN.TextMMDDYYYY()
        Else
            Me.FechaInicial = "99/99/9999"
            Me.FechaFinal = "99/99/9999"
        End If

        Me.Close()
    End Sub

    Private Sub CodigoMoneda_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCodigoMoneda.DoubleClick
        txtCODIGO_DE_MONEDA.GenerarConsulta()
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Cerrar()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim moneda As Integer
        Me.Respuesta = "*"

        If MyBase.ValidarCampos(Me) = False Then
            Me.Respuesta = ""
            Return
        End If

        Dim inicial As String = String.Empty
        Dim final As String = String.Empty

        inicial = mskFECHA_INI.TextMMDDYYYY()
        final = mskFECHA_FIN.TextMMDDYYYY()

        If Not MyBase.ValidaFecha(inicial, final) Then
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(202, "Fecha inicial es mayor que fecha final."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mskFECHA_INI.Focus()
            Me.Respuesta = ""
            Return
        End If

        If Not String.IsNullOrEmpty(TraeDato("select count(*) from MONEDAS where CODIGO_DE_MONEDA = '" & txtCODIGO_DE_MONEDA.Text & "'")) Then
            moneda = CType(TraeDato("select count(*) from MONEDAS where CODIGO_DE_MONEDA = '" & txtCODIGO_DE_MONEDA.Text & "'"), Integer)
        End If

        If moneda < 1 Then
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(203, "Moneda no es válida."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCODIGO_DE_MONEDA.Focus()
            Me.Respuesta = ""
            Return
        End If

        Me.Cerrar()
    End Sub
End Class