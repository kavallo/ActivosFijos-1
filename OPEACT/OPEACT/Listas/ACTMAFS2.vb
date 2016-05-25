﻿Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.Iconos

Public Class ACTMAFS2
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuConsultar.Text = Me.cmdConsultar.Texto
        Me.mnuProceso.Text = Me.cmdProceso.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos

            Me.IconosMenus.Images.Clear()
            '-- Consultar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Consultar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Proceso
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Proceso).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.cmdConsultar.Image = Me.IconosMenus.Images(0)
            Me.mnuConsultar.Image = Me.cmdConsultar.Image
            Me.cmdProceso.Image = Me.IconosMenus.Images(1)
            Me.mnuProceso.Image = Me.cmdProceso.Image
            Me.BotonLlenar.Image = Me.IconosMenus.Images(2)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(3)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try

        MyBase.SetearPosiciones()

        Me.LlenarParam()

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarParam()
        NumCols = 5
        NumLlaves = 2
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Codigo Activo", 15, ALINEAR_IZQ, "CODIGO_DE_ACTIVO", 47, 15, 0, 1, 92)
        MeterParam(2, Info, 1, "Mejoras", 10, ALINEAR_DER, "MEJORA_CORRELATIVO", 56, 4, 0, 2, 115)
        MeterParam(3, Info, 1, "Descripcion", 30, ALINEAR_IZQ, "DESCRIP_CORTA_ACTIVO", 39, 40, 0, 0, 12)
        MeterParam(4, Info, 1, "Valor Original", 14, ALINEAR_DER, "Convert(Varchar, VALOR_ORIGINAL_ACTIV, 1)", 60, 13, 2, 0, 121)
        MeterParam(5, Info, 1, "Adquisición", 11, ALINEAR_IZQ, "convert(varchar(10), FECHA_ADQUISICION,103)", 47, 10, 0, 0, 223)

        snCond = " Where ESTATUS = 'U' and VALOR_ACTUAL_ACTIVO = VALOR_ORIGINAL_ACTIV"
        snTabla = "ACTIVOS_FIJOS"
    End Sub

    Private Sub Consultar()
        If LlenarLlaves() Then
            Dim frmConsulta As New ACTMAFC0
            With frmConsulta
                .Pila = Me.Pila
                .ShowDialog()
                If .HubieronCambios Then
                    MyBase.LlenarSelNav()
                End If
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

    Private Sub Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click, mnuConsultar.Click
        Me.Consultar()
    End Sub

    Private Sub Proceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProceso.Click, mnuProceso.Click
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                If GridData.SelectedRows.Count > 0 Then
                    If Citi.Synergia.HelperClient.Utils.CITIMsgBox(Citi.Synergia.Traductor.Idiomas.GetMensaje(317, "Este proceso anula la actualizacion de los activos fijos cambiando el estado del activo como pendiente."), Citi.Synergia.HelperClient.Utils.TipoDeMensaje.TipoConfirmacion) = Citi.Synergia.HelperClient.Utils.TipoDeRespuesta.Aceptar Then
                        For Each filaGrid As DataGridViewRow In GridData.SelectedRows
                            Dim codigoActivo As String = filaGrid.Cells(0).Value.ToString
                            Dim mejora As String = filaGrid.Cells(1).Value.ToString

                            Dim comando As New SqlClient.SqlCommand
                            With comando
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "sp_Desactualiza_Activo_Fijo"
                                .Parameters.Add("@CODIGO_DE_ACTIVO", SqlDbType.Char, 15).Value = codigoActivo
                                .Parameters.Add("@MEJORA_CORRELATIVO", SqlDbType.Int).Value = mejora
                                .Parameters.Add("@Usuario", SqlDbType.Char, 10).Value = Citi.Synergia.Locals.Cache.UsuarioSSO
                                .Parameters(0).Direction = ParameterDirection.Input
                                .Parameters(1).Direction = ParameterDirection.Input
                                .Parameters(2).Direction = ParameterDirection.Input
                            End With

                            Dim parametro As SqlClient.SqlParameter
                            parametro = New SqlClient.SqlParameter
                            With parametro
                                .ParameterName = "@CODIGO_DE_ACTIVO"
                                .Direction = ParameterDirection.Input
                                .SqlDbType = SqlDbType.Char
                                .Size = 15
                                .Value = codigoActivo
                            End With
                            parametro = New SqlClient.SqlParameter
                            With parametro
                                .ParameterName = "MEJORA_CORRELATIVO"
                                .Direction = ParameterDirection.Input
                                .SqlDbType = SqlDbType.Int
                                .Value = mejora
                            End With

                            Try
                                EjecutarComando(comando)

                                MyBase.LlenarSelNav()

                            Catch errSQL As SqlClient.SqlException
                                MessageBox.Show(errSQL.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        Next
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Llenar(False)
    End Sub
End Class