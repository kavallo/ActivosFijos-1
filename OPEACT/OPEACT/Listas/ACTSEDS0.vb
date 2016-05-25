Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.Iconos

Public Class ACTSEDS0
    Public Property NumeroEndoso As String
    Public Property NumeroPoliza As String
    Public Property CodigoCobertura As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuAgregar.Text = Me.cmdAgregar.Texto
        Me.mnuBorrar.Text = Me.cmdBorrar.Texto
        Me.mnuConsultar.Text = Me.cmdConsultar.Texto
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
            '-- Consultar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Consultar).ToBitmap
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
            Me.cmdConsultar.Image = Me.IconosMenus.Images(2)
            Me.mnuConsultar.Image = Me.cmdConsultar.Image
            Me.BotonLlenar.Image = Me.IconosMenus.Images(3)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(4)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        lblNUMERO_POLIZA.Text = NumeroPoliza
        lblNO_ENDOSO.Text = NumeroEndoso + " - "
        If Not String.IsNullOrEmpty(TraeDato("SELECT COMPANIA_SEGUROS FROM SEGUROS_ENC WHERE NUMERO_POLIZA = " + Scm(NumeroPoliza) + "AND NO_ENDOSO = " + Scm(NumeroEndoso))) Then
            lblNO_ENDOSO.Text += TraeDato("SELECT COMPANIA_SEGUROS FROM SEGUROS_ENC WHERE NUMERO_POLIZA = " + Scm(NumeroPoliza) + "AND NO_ENDOSO = " + Scm(NumeroEndoso)).ToString
        End If

        lblCODIGO_COBERTURA.Text = CodigoCobertura + " - "
        If Not String.IsNullOrEmpty(TraeDato("SELECT DESCRIPCION_COBERTUR FROM SEGUROS_COB WHERE NUMERO_POLIZA = " & Scm(NumeroPoliza) & " AND NO_ENDOSO = " & Scm(NumeroEndoso) & " AND CODIGO_COBERTURA = " & sen(CodigoCobertura))) Then
            lblCODIGO_COBERTURA.Text += TraeDato("SELECT DESCRIPCION_COBERTUR FROM SEGUROS_COB WHERE NUMERO_POLIZA = " & Scm(NumeroPoliza) & " AND NO_ENDOSO = " & Scm(NumeroEndoso) & " AND CODIGO_COBERTURA = " & sen(CodigoCobertura)).ToString
        End If

        MyBase.SetearPosiciones()

        Me.LlenarParam()

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarParam()
        NumCols = 3
        NumLlaves = 2
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Codigo Activo", 12, ALINEAR_IZQ, "SEGUROS_DET.CODIGO_DE_ACTIVO", 47, 5, 0, 1, 92)
        MeterParam(2, Info, 1, "Mejora", 8, ALINEAR_DER, "SEGUROS_DET.MEJORA_CORRELATIVO", 56, 4, 0, 2, 115)
        MeterParam(3, Info, 1, "Descripción", 40, ALINEAR_IZQ, "ACTIVOS_FIJOS.DESCRIP_CORTA_ACTIVO", 47, 40, 0, 0, 12)

        snCond = "SEGUROS_DET.NO_ENDOSO = " & Scm(NumeroEndoso) & " and SEGUROS_DET.NUMERO_POLIZA = " & Scm(NumeroPoliza) & " and SEGUROS_DET.CODIGO_COBERTURA = " & sen(CodigoCobertura) & " and ACTIVOS_FIJOS.CODIGO_DE_ACTIVO = SEGUROS_DET.CODIGO_DE_ACTIVO and ACTIVOS_FIJOS.MEJORA_CORRELATIVO = SEGUROS_DET.MEJORA_CORRELATIVO"
        snTabla = "SEGUROS_DET,ACTIVOS_FIJOS"
    End Sub

    Private Sub Consultar()
        If LlenarLlaves() Then
            Dim frmConsulta As New ACTSEDM0
            With frmConsulta
                .NumeroPoliza = NumeroPoliza
                .NumeroEndoso = NumeroEndoso
                .CodigoCobertura = CodigoCobertura
                .Pila = Me.Pila
                .Modo_Local = Modo_Cambio
                .SoloDeConsulta = True
                .ShowDialog()
                .Dispose()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub SeleccionaFila(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Me.Consultar()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Llenar(False)
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click, mnuAgregar.Click
        Dim frmManto As New ACTSEDM0
        With frmManto
            .NumeroPoliza = NumeroPoliza
            .NumeroEndoso = NumeroEndoso
            .CodigoCobertura = CodigoCobertura
            .Modo_Local = Modo_Alta
            .ShowDialog()
            If .HubieronCambios Then
                MyBase.LlenarSelNav()
            End If
            .Dispose()
        End With
    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click, mnuBorrar.Click
        If LlenarLlaves() Then
            Dim frmBorrar As New ACTSEDM0
            With frmBorrar
                .NumeroPoliza = NumeroPoliza
                .NumeroEndoso = NumeroEndoso
                .CodigoCobertura = CodigoCobertura
                .Pila = Me.Pila
                .Modo_Local = Modo_Baja
                .ShowDialog()
                If .HubieronCambios Then
                    MyBase.LlenarSelNav()
                End If
                .Dispose()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click, mnuConsultar.Click
        Me.Consultar()
    End Sub
End Class