Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion

Public Class ACTSEDS1
    Public Property NumeroPoliza As String
    Public Property NumeroEndoso As String
    Public Property CodigoCobertura As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuConsultar.Text = Me.BotonConsulta.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos.Iconos

            Me.IconosMenus.Images.Clear()
            '-- Consultar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Consultar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.BotonConsulta.Image = Me.IconosMenus.Images(0)
            Me.mnuConsultar.Image = Me.BotonConsulta.Image
            Me.BotonLlenar.Image = Me.IconosMenus.Images(1)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(2)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MyBase.SetearPosiciones()

        lblCodigoCobertura.Text = Me.CodigoCobertura
        lblNumeroEndoso.Text = Me.NumeroEndoso
        lblNumeroPoliza.Text = Me.NumeroPoliza

        Me.LlenarParam()

        If Not String.IsNullOrEmpty(TraeDato("SELECT COMPANIA_SEGUROS FROM SEGUROS_ENC WHERE NUMERO_POLIZA = " & Scm(Me.NumeroPoliza) & " AND NO_ENDOSO = " & Scm(Me.NumeroEndoso))) Then
            lblNombrePoliza.Text = TraeDato("SELECT COMPANIA_SEGUROS FROM SEGUROS_ENC WHERE NUMERO_POLIZA = " & Scm(Me.NumeroPoliza) & " AND NO_ENDOSO = " & Scm(Me.NumeroEndoso)).ToString
        End If
        If Not String.IsNullOrEmpty(TraeDato("SELECT DESCRIPCION_COBERTUR FROM SEGUROS_COB WHERE NUMERO_POLIZA = " & Scm(Me.NumeroPoliza) & " AND NO_ENDOSO = " & Scm(Me.NumeroEndoso) & " AND CODIGO_COBERTURA = " & sen(Me.CodigoCobertura))) Then
            lblNombreCobertura.Text = TraeDato("SELECT DESCRIPCION_COBERTUR FROM SEGUROS_COB WHERE NUMERO_POLIZA = " & Scm(Me.NumeroPoliza) & " AND NO_ENDOSO = " & Scm(Me.NumeroEndoso) & " AND CODIGO_COBERTURA = " & sen(Me.CodigoCobertura)).ToString
        End If

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarParam()
        NumCols = 3
        NumLlaves = 2
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Codigo Activo", 10, ALINEAR_IZQ, "SEGUROS_DET.CODIGO_DE_ACTIVO", 47, 15, 0, 1, 92)
        MeterParam(2, Info, 1, "Mejora", 8, ALINEAR_DER, "SEGUROS_DET.MEJORA_CORRELATIVO", 56, 10, 0, 2, 115)
        MeterParam(3, Info, 1, "Descripción", 40, ALINEAR_IZQ, "ACTIVOS_FIJOS.DESCRIP_CORTA_ACTIVO", 47, 40, 0, 0, 12)

        'snCampos = CrearParam(Info, Me)
        snCond = " SEGUROS_DET.NO_ENDOSO = " & Scm(Me.NumeroEndoso) & " and SEGUROS_DET.NUMERO_POLIZA = " & Scm(Me.NumeroPoliza) & " and SEGUROS_DET.CODIGO_COBERTURA = " & sen(Me.CodigoCobertura) & " and ACTIVOS_FIJOS.CODIGO_DE_ACTIVO = SEGUROS_DET.CODIGO_DE_ACTIVO and ACTIVOS_FIJOS.MEJORA_CORRELATIVO = SEGUROS_DET.MEJORA_CORRELATIVO "
        snTabla = "SEGUROS_DET,ACTIVOS_FIJOS"
    End Sub

    Private Sub Consultar()
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim codigoActivo As String = GridData.SelectedRows(0).Cells(0).Value.ToString()
                Dim codigoMejora As String = GridData.SelectedRows(0).Cells(1).Value.ToString()

                Dim frmConsulta As New ACTSEDM1
                With frmConsulta
                    .NumeroPoliza = Me.NumeroPoliza
                    .NumeroEndoso = Me.NumeroEndoso
                    .CodigoCobertura = Me.CodigoCobertura
                    .CodigoActivo = codigoActivo
                    .CodigoMejora = codigoMejora
                    .Modo_Local = Modo_Consulta
                    .SoloDeConsulta = True
                    .ShowDialog()
                    .Dispose()
                End With
            End If
        End If
    End Sub

    Private Sub SeleccionaFila(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Me.Consultar()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonConsulta.Click, mnuConsultar.Click
        Me.Consultar()
    End Sub

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Me.Llenar(False)
    End Sub
End Class