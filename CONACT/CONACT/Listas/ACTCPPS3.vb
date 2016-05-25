Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion

Public Class ACTCPPS3
    Public Property NumeroPoliza As String
    Public Property NumeroEndoso As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuConsultar.Text = Me.BotonConsulta.Texto
        Me.mnuBajarNivel.Text = Me.BotonBajarNivel.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos.Iconos

            Me.IconosMenus.Images.Clear()
            '-- Consultar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Consultar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Bajar nivel
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.BajarNivel).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.BotonConsulta.Image = Me.IconosMenus.Images(0)
            Me.mnuConsultar.Image = Me.BotonConsulta.Image
            Me.BotonBajarNivel.Image = Me.IconosMenus.Images(1)
            Me.mnuBajarNivel.Image = Me.BotonBajarNivel.Image
            Me.BotonLlenar.Image = Me.IconosMenus.Images(2)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(3)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MyBase.SetearPosiciones()

        lblNumeroEndoso.Text = Me.NumeroEndoso
        lblNumeroPoliza.Text = Me.NumeroPoliza

        Me.LlenarParam()

        If Not String.IsNullOrEmpty(TraeDato("SELECT COMPANIA_SEGUROS FROM SEGUROS_ENC WHERE NUMERO_POLIZA = " & Scm(Me.NumeroPoliza) & " AND NO_ENDOSO = " & Scm(Me.NumeroEndoso))) Then
            lblNombrePoliza.Text = TraeDato("SELECT COMPANIA_SEGUROS FROM SEGUROS_ENC WHERE NUMERO_POLIZA = " & Scm(Me.NumeroPoliza) & " AND NO_ENDOSO = " & Scm(Me.NumeroEndoso)).ToString
        End If

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarParam()
        NumCols = 2
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Cobertura", 9, ALINEAR_DER, "CODIGO_COBERTURA", 56, 6, 0, 1, 142)
        MeterParam(2, Info, 1, "Descripcion", 60, ALINEAR_IZQ, "DESCRIPCION_COBERTUR", 39, 60, 0, 0, 12)

        If String.IsNullOrEmpty(Me.NumeroEndoso) Then
            Me.NumeroEndoso = "               "
        End If
        snCond = " NO_ENDOSO = " & Scm(Me.NumeroEndoso) & " and NUMERO_POLIZA = " & Scm(Me.NumeroPoliza)
        snTabla = "SEGUROS_COB"
    End Sub

    Private Sub Consultar()
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim codigoCobertura As String = GridData.SelectedRows(0).Cells(0).Value.ToString()

                Dim frmConsulta As New ACTCPPM1
                With frmConsulta
                    .Modo_Local = Modo_Consulta
                    .SoloDeConsulta = True
                    .NumeroPoliza = Me.NumeroPoliza
                    .NumeroEndoso = Me.NumeroEndoso
                    .CodigoCobertura = codigoCobertura
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

    Private Sub BajarNivel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBajarNivel.Click, mnuBajarNivel.Click
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim codigoCobertura As String = GridData.SelectedRows(0).Cells(0).Value.ToString()

                Dim frmConsulta As New ACTSEDS1
                With frmConsulta
                    .NumeroPoliza = Me.NumeroPoliza
                    .NumeroEndoso = Me.NumeroEndoso
                    .CodigoCobertura = codigoCobertura
                    .ShowDialog()
                    .Dispose()
                End With
            End If
        End If
    End Sub

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Me.Llenar(False)
    End Sub
End Class