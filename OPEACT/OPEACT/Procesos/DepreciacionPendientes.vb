Imports Citi.Synergia.Iconos

Public Class DepreciacionPendientes
    Public Property Servidor As String
    Public Property Empresa As String
    Public Property DescripcionEmpresa As String

    Private Sub Forma_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos

            Me.IconosMenus.Images.Clear()
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.cmdSalir.Image = Me.IconosMenus.Images(0)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.lblEmpresa.Text = Me.DescripcionEmpresa
        Me.lblBaseDeDatos.Text = Me.Empresa

        '-- Le cambio los headers al grid de acuerdo al idioma
        Me.grdPendientes.Columns(0).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(21, "Código")
        Me.grdPendientes.Columns(1).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(12, "Descripción")
        Me.grdPendientes.Columns(2).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(234, "Ubicación")

        Me.LlenarGrid()
    End Sub

    Private Sub LlenarGrid()
        Dim conexion As New SqlClient.SqlConnection

        Try
            conexion.ConnectionString = "Data Source=" + Me.Servidor + "; Initial Catalog=" + Me.Empresa + "; uid=" + Citi.Synergia.Locals.Cache.UsuarioSQL + "; pwd=" + Citi.Synergia.Locals.Cache.Password

            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "Select CODIGO, DESCRIPCION, FUENTE From BITACORA_PENDIENTES order by FUENTE, CODIGO"
                .Connection = conexion
            End With

            Dim dsData As New DataSet

            Dim adPuente As New SqlClient.SqlDataAdapter

            adPuente.SelectCommand = comando

            conexion.Open()

            adPuente.Fill(dsData)

            conexion.Close()

            If Not dsData Is Nothing Then
                If dsData.Tables.Count > 0 Then
                    For Each filaData As DataRow In dsData.Tables(0).Rows
                        Dim filaGrid As New DataGridViewRow
                        filaGrid.CreateCells(Me.grdPendientes)

                        filaGrid.Cells(0).Value = filaData.Item("CODIGO").ToString
                        filaGrid.Cells(1).Value = filaData.Item("DESCRIPCION").ToString
                        filaGrid.Cells(2).Value = filaData.Item("FUENTE").ToString

                        Me.grdPendientes.Rows.Add(filaGrid)
                    Next
                End If
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    Private Sub Salir_Click(sender As System.Object, e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub
End Class