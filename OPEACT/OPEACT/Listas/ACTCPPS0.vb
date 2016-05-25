Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.Iconos

Public Class ACTCPPS0
    Public Property NumeroEndoso As String
    Public Property NumeroPoliza As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuAgregar.Text = Me.cmdAgregar.Texto
        Me.mnuBorrar.Text = Me.cmdBorrar.Texto
        Me.mnuModificar.Text = Me.cmdModificar.Texto
        Me.mnuCoberturas.Text = Me.cmdCoberturas.Texto
        Me.mnuCoberturaActivos.Text = Me.cmdCoberturaActivos.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos

            Me.IconosMenus.Images.Clear()
            '-- Agregar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Agregar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Borrar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Borrar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Modificar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Modificar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Coberturas
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Coberturas).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Cobertura activos
            imagen = oIcono.GetIcon(Iconos.TipoIcono.CoberturaActivos).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.cmdAgregar.Image = Me.IconosMenus.Images(0)
            Me.mnuAgregar.Image = Me.cmdAgregar.Image
            Me.cmdBorrar.Image = Me.IconosMenus.Images(1)
            Me.mnuBorrar.Image = Me.cmdBorrar.Image
            Me.cmdModificar.Image = Me.IconosMenus.Images(2)
            Me.mnuModificar.Image = Me.cmdModificar.Image
            Me.cmdCoberturas.Image = IconosMenus.Images(3)
            Me.mnuCoberturas.Image = Me.cmdCoberturas.Image
            Me.cmdCoberturaActivos.Image = IconosMenus.Images(4)
            Me.mnuCoberturaActivos.Image = Me.cmdCoberturaActivos.Image
            Me.BotonLlenar.Image = Me.IconosMenus.Images(5)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(6)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        lblNUMERO_POLIZA.Text = NumeroPoliza
        lblNO_ENDOSO.Text = NumeroEndoso & " "
        If Not String.IsNullOrEmpty(TraeDato("SELECT COMPANIA_SEGUROS FROM SEGUROS_ENC WHERE NUMERO_POLIZA = " + Scm(NumeroPoliza) + "AND NO_ENDOSO = " + Scm(NumeroEndoso))) Then
            lblNO_ENDOSO.Text += TraeDato("SELECT COMPANIA_SEGUROS FROM SEGUROS_ENC WHERE NUMERO_POLIZA = " + Scm(NumeroPoliza) + "AND NO_ENDOSO = " + Scm(NumeroEndoso)).ToString
        End If

        MyBase.SetearPosiciones()

        Me.LlenarParam()

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarParam()
        NumCols = 2
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Cobertura", 10, ALINEAR_DER, "CODIGO_COBERTURA", 56, 10, 0, 1, 142)
        MeterParam(2, Info, 1, "Descripcion", 60, ALINEAR_IZQ, "DESCRIPCION_COBERTUR", 39, 60, 0, 0, 12)

        snCond = "NO_ENDOSO = " & Scm(NumeroEndoso) & " and NUMERO_POLIZA = " & Scm(NumeroPoliza)
        snTabla = "SEGUROS_COB"
    End Sub

    Private Sub Modificar()
        If LlenarLlaves() Then
            Dim frmModificar As New ACTCPPM0
            With frmModificar
                .Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(326, "Mantenimiento a coberturas por póliza - ACTCPPM0")
                .NumeroPoliza = NumeroPoliza
                .NumeroEndoso = NumeroEndoso
                .Modo_Local = Modo_Cambio
                .Pila = Me.Pila
                .ShowDialog()
                If .HubieronCambios Then
                    MyBase.LlenarSelNav()
                End If
                .Dispose()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub SeleccionaFila(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Me.Modificar()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click, mnuAgregar.Click
        Dim frmAgregar As New ACTCPPM0
        With frmAgregar
            .Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(326, "Mantenimiento a coberturas por póliza - ACTCPPM0")
            .NumeroPoliza = NumeroPoliza
            .NumeroEndoso = NumeroEndoso
            .Modo_Local = Modo_Alta
            .Push("")
            .ShowDialog()
            If .HubieronCambios Then
                MyBase.LlenarSelNav()
            End If
            .Dispose()
        End With
        Me.LimpiarPila()
    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click, mnuBorrar.Click
        If LlenarLlaves() Then
            Dim frmBorrar As New ACTCPPM0
            With frmBorrar
                .Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(326, "Mantenimiento a coberturas por póliza - ACTCPPM0")
                .NumeroPoliza = NumeroPoliza
                .NumeroEndoso = NumeroEndoso
                .Modo_Local = Modo_Baja
                .Pila = Me.Pila
                .ShowDialog()
                If .HubieronCambios Then
                    MyBase.LlenarSelNav()
                End If
                .Dispose()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click, mnuModificar.Click
        Me.Modificar()
    End Sub

    Private Sub Coberturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCoberturas.Click, mnuCoberturas.Click
        If LlenarLlaves() Then
            Dim frmCobertura As New ACTCPPM0
            With frmCobertura
                .Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(327, "Consulta a coberturas por póliza - ACTCPPM1")
                .NumeroPoliza = NumeroPoliza
                .NumeroEndoso = NumeroEndoso
                .SoloDeConsulta = True
                .Modo_Local = Modo_Cambio
                .Pila = Me.Pila
                .ShowDialog()
                .Dispose()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub BotonLlenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Me.Llenar(False)
    End Sub

    Private Sub cmdCoberturaActivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCoberturaActivos.Click, mnuCoberturaActivos.Click
        If LlenarLlaves() Then
            Dim frmCobertura As New ACTSEDS0
            With frmCobertura
                .NumeroPoliza = NumeroPoliza
                .NumeroEndoso = NumeroEndoso
                .CodigoCobertura = Me.Pop()
                .ShowDialog(Me)
                .Dispose()
            End With
            Me.LimpiarPila()
        End If
    End Sub
End Class