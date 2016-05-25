Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion

Public Class CONEPCS0
    Public Property Consolidacion As String
    Public Property PeriodoAnio As String
    Public Property PeriodoNumero As String

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

        lblNO_PERIODO.Text = Me.PeriodoNumero
        lblANO_PERIODO.Text = Me.PeriodoAnio
        lblCONSOLIDACION_ID.Text = Me.Consolidacion

        Me.LlenarParam()

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarParam()
        NumCols = 4
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Partida", 7, ALINEAR_DER, "NUMERO_PARTIDA", 56, 7, 0, 1, 134)
        MeterParam(2, Info, 1, "Descripcion", 25, ALINEAR_IZQ, "DESCRIPCION_1", 39, 25, 0, 0, 12)
        MeterParam(3, Info, 1, "Fecha", 10, ALINEAR_IZQ, "convert(varchar,FECHA_PARTIDA,103)", 58, 10, 0, 0, 135)
        MeterParam(4, Info, 1, "Modulo", 6, ALINEAR_IZQ, "CODIGO_MODULO", 47, 3, 0, 0, 136)

        snCond = " NO_PERIODO = " & sen(Me.PeriodoNumero) & " and ANO_PERIODO = " & sen(Me.PeriodoAnio) & " and CONSOLIDACION_ID = " & sen(Me.Consolidacion)
        snTabla = "PARTIDAS_CONSOL_ENC"
    End Sub

    Private Sub Consultar()
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim partida As String = GridData.SelectedRows(0).Cells(0).Value.ToString()

                Dim frmConsulta As New CONEPCC0
                With frmConsulta
                    .PeriodoAnio = Me.PeriodoAnio
                    .PeriodoNumero = Me.PeriodoNumero
                    .Partida = partida
                    .Show()
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