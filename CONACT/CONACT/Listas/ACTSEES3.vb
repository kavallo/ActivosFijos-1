Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion

Public Class ACTSEES3
    Public Property NumeroPoliza As String

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

        lblNumeroPoliza.Text = Me.NumeroPoliza

        Me.LlenarParam()

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarParam()
        NumCols = 3
        NumLlaves = 2
        ReDim Llaves(NumLlaves)
        snBusc = ""

        'MeterParam 1, Info(), 1, "Numero Poliza", 20, ALINEAR_IZQ, "SEGUROS_ENC.NUMERO_POLIZA", 39, 20, 0, Llaves(), 2
        MeterParam(1, Info, 1, "Numero Endoso", 10, ALINEAR_IZQ, "NO_ENDOSO", 39, 15, 0, 1, 139)
        'MeterParam 3, Info(), 1, "Inicio Vigencia", 15, ALINEAR_IZQ, "convert(varchar(10),SEGUROS_ENC.FECHA_I_VIGENCIA,103)", 47, 10, 0, Llaves(), 0
        MeterParam(2, Info, 1, "Fin Vigencia", 10, ALINEAR_IZQ, "convert(varchar(10), FECHA_F_VIGENCIA,103)", 47, 10, 0, 0, 140)
        MeterParam(3, Info, 1, "Compañia Seguros", 20, ALINEAR_IZQ, "COMPANIA_SEGUROS", 39, 30, 0, 0, 141)

        'snCampos = CrearParam(Info, Me)
        snCond = " Where ESTADO_POLIZA = 'V' and NUMERO_POLIZA = " & Scm(Me.NumeroPoliza)
        snTabla = "SEGUROS_ENC"
    End Sub

    Private Sub Consultar()
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim numeroEndoso As String = GridData.SelectedRows(0).Cells(0).Value.ToString()

                Dim frmConsulta As New ACTSEEM2
                With frmConsulta
                    .Modo_Local = Modo_Consulta
                    .SoloDeConsulta = True
                    .NumeroPoliza = Me.NumeroPoliza
                    .NumeroEndoso = numeroEndoso
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
                Dim numeroEndoso As String = GridData.SelectedRows(0).Cells(0).Value.ToString()

                Dim frmBajarNivel As New ACTCPPS3
                With frmBajarNivel
                    .NumeroPoliza = Me.NumeroPoliza
                    .NumeroEndoso = numeroEndoso
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