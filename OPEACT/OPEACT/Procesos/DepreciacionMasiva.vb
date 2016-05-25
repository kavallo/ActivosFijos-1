Imports Citi.Synergia.Iconos

Public Class DepreciacionMasiva
    Public Property EsCalculo As Boolean
    Public Property MesDepreciacion As Integer
    Public Property AnioDepreciacion As Integer
    Public Property NumeroPeriodo As Integer
    Public Property AnioPeriodo As Integer

    Private _empresasConAcceso As New List(Of Citi.Synergia.Entidades.Companias)
    Private _empresasSinAcceso As New List(Of Citi.Synergia.Entidades.Companias)

    Private Sub Forma_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.mnuEjecutaProceso.Text = Me.BotonEjecutaProceso.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos

            Me.IconosMenus.Images.Clear()
            '-- Proceso
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Proceso).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.BotonEjecutaProceso.Image = Me.IconosMenus.Images(0)
            Me.mnuEjecutaProceso.Image = Me.BotonEjecutaProceso.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(1)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If Me.EsCalculo Then
            Me.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(308, "Cálculo de depreciación") & " - DepreciacionMasiva"
        Else
            Me.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(309, "Autorización de depreciación") & " - DepreciacionMasiva"
        End If

        '-- El grid de empresas con acceso sólo tiene 4 columnas
        Me.grdEmpresas.Columns(0).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(307, "Seleccionar")
        Me.grdEmpresas.Columns(1).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(342, "Base de Datos")
        Me.grdEmpresas.Columns(2).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(306, "Empresas")
        Me.grdEmpresas.Columns(3).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(310, "Warnings")
        Me.grdEmpresas.Columns(4).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(313, "Ver pendientes")

        '-- El grid de empresas sin acceso sólo tiene 2 columnas
        Me.grdSinAcceso.Columns(0).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(342, "Base de Datos")
        Me.grdSinAcceso.Columns(1).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(306, "Empresas")

        lblMes.Text = Citi.Synergia.HelperClient.Utils.MesEnLetras(Me.MesDepreciacion)
        lblAnio.Text = Me.AnioDepreciacion.ToString

        '-- Valido si el usuario tiene acceso a todas las empresas
        Me.ValidaAcceso()

        '-- Lleno el grid
        Me.LlenoGrid()

        '-- Verifico si hay pendientes sólo si se va a calcular y no a autorizar
        If EsCalculo Then
            Me.VerificarPendientes()
        Else
            Me.lblTitNumeroPeriodo.Visible = True
            Me.lblTitAnioPeriodo.Visible = Me.lblTitNumeroPeriodo.Visible
            Me.lblNumeroPeriodo.Visible = Me.lblTitNumeroPeriodo.Visible
            Me.lblAnioPeriodo.Visible = Me.lblTitNumeroPeriodo.Visible

            Me.lblNumeroPeriodo.Text = Me.NumeroPeriodo.ToString
            Me.lblAnioPeriodo.Text = Me.AnioPeriodo.ToString
        End If
    End Sub

    Private Sub ValidaAcceso()
        '-- Por cada empresa veo si el usuario tiene acceso a la DB abriendo una conexion
        For Each empresa As Citi.Synergia.Entidades.Companias In _companias
            Dim tieneAcceso As Boolean = False

            Try
                Dim conexion As New SqlClient.SqlConnection
                conexion.ConnectionString = "Data Source=" + empresa.Servidor + "; Initial Catalog=" + empresa.BaseDeDatos + "; uid=" + Citi.Synergia.Locals.Cache.UsuarioSQL + "; pwd=" + Citi.Synergia.Locals.Cache.Password

                conexion.Open()

                conexion.Close()

                tieneAcceso = True

            Catch ex As Exception
                '-- Si tira error es porque no tiene acceso
                tieneAcceso = False
            End Try

            If tieneAcceso Then
                Me._empresasConAcceso.Add(empresa)
            Else
                Me._empresasSinAcceso.Add(empresa)
            End If
        Next
    End Sub

    Private Sub LlenoGrid()
        If Me._empresasConAcceso.Count > 0 Then
            For Each empresa As Citi.Synergia.Entidades.Companias In Me._empresasConAcceso
                Dim filaGrid As New DataGridViewRow
                filaGrid.CreateCells(grdEmpresas)

                filaGrid.Cells(0).Value = True
                filaGrid.Cells(1).Value = empresa.BaseDeDatos
                filaGrid.Cells(1).Tag = empresa.Servidor
                filaGrid.Cells(2).Value = empresa.Descripcion
                filaGrid.Cells(3).Value = String.Empty
                filaGrid.Cells(4).Value = String.Empty

                grdEmpresas.Rows.Add(filaGrid)
            Next
        Else
            Me.BotonEjecutaProceso.Enabled = False
            Me.mnuEjecutaProceso.Enabled = False
        End If

        If Me._empresasSinAcceso.Count > 0 Then
            For Each empresa As Citi.Synergia.Entidades.Companias In Me._empresasSinAcceso
                Dim filaGrid As New DataGridViewRow
                filaGrid.CreateCells(grdSinAcceso)

                filaGrid.Cells(0).Value = empresa.BaseDeDatos
                filaGrid.Cells(1).Value = empresa.Descripcion

                grdSinAcceso.Rows.Add(filaGrid)
            Next
        Else
            Me.grdSinAcceso.Visible = False
            Me.lblSinMostrar.Visible = True
            Me.panSinAcceso.Visible = False
            Me.Height = 322
        End If

        If EsCalculo = False Then
            '-- Es autorización, no hay Warnings
            grdEmpresas.Columns(3).Visible = False
            grdEmpresas.Columns(4).Visible = False
            grdEmpresas.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If
    End Sub

    Private Sub VerificarPendientes()
        'SE VERIFICARA LO SIGUIENTE
        'a. Traslado de divisiones pendientes de autorizar
        'b. Traslado de responsables pendientes de autorizar
        'c. Nuevos activos pendientes de ser autorizados
        'Si existe informacion en la tabla bitacora mostrara datos

        For Each empresa As Citi.Synergia.Entidades.Companias In Me._empresasConAcceso
            Dim conexion As New SqlClient.SqlConnection

            Try
                conexion.ConnectionString = "Data Source=" + empresa.Servidor + "; Initial Catalog=" + empresa.BaseDeDatos + "; uid=" + Citi.Synergia.Locals.Cache.UsuarioSQL + "; pwd=" + Citi.Synergia.Locals.Cache.Password

                'Ejecutar el sp que verifica si hay informacion pendiente
                Dim comando As New SqlClient.SqlCommand
                With comando
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "sp_VERIFICA_PENDIENTES"
                    .Connection = conexion
                End With

                conexion.Open()

                comando.ExecuteNonQuery()

                'Verificar si existe mas de 1 registro pendiente
                Dim resultado As Integer = 0

                With comando
                    .CommandType = CommandType.Text
                    .CommandText = "SELECT IsNull(COUNT(*), 0) FROM BITACORA_PENDIENTES"
                    resultado = CType(.ExecuteScalar(), Integer)
                End With

                If resultado <> 0 Then
                    '-- La empresa tiene información pendiente
                    For Each filaGrid As DataGridViewRow In Me.grdEmpresas.Rows
                        If filaGrid.Cells(1).Value.ToString = empresa.BaseDeDatos AndAlso filaGrid.Cells(1).Tag.ToString = empresa.Servidor Then
                            filaGrid.Cells(3).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(311, "Hay información pendiente de ser autorizada")
                            filaGrid.Cells(4).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(313, "Ver")
                            Exit For
                        End If
                    Next
                End If

                comando.Dispose()

                conexion.Close()

            Catch errSQL As SqlClient.SqlException
                Dim entro As Boolean = False
                For Each errorMalo As System.Data.SqlClient.SqlError In errSQL.Errors
                    If errorMalo.Number = 40000 Then
                        entro = True
                        MessageBox.Show(errorMalo.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Next

                If Not entro Then
                    MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
            End Try
        Next
    End Sub

    Private Sub VerEmpresas_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdEmpresas.CellContentClick
        If grdEmpresas.Rows.Count > 0 Then
            Select Case e.ColumnIndex
                Case 4 '-- Ver pendientes
                    If grdEmpresas.Rows(e.RowIndex).Cells(4).Value.ToString <> "" Then
                        Dim servidor As String = grdEmpresas.Rows(e.RowIndex).Cells(1).Tag.ToString
                        Dim empresa As String = grdEmpresas.Rows(e.RowIndex).Cells(1).Value.ToString
                        Dim descripcion As String = grdEmpresas.Rows(e.RowIndex).Cells(2).Value.ToString

                        Dim frmPendientes As New DepreciacionPendientes
                        With frmPendientes
                            .Servidor = servidor
                            .Empresa = empresa
                            .DescripcionEmpresa = descripcion
                            .ShowDialog()
                            .Dispose()
                        End With
                    End If
            End Select
        End If
    End Sub

    Private Sub Salir_Click(sender As System.Object, e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub EjecutaProceso_Click(sender As System.Object, e As System.EventArgs) Handles BotonEjecutaProceso.Click, mnuEjecutaProceso.Click
        If Me.grdEmpresas.Rows.Count > 0 Then
            Dim exito As Boolean = False
            Dim entro As Boolean = False
            Dim empresasError As New List(Of String)

            If Me.EsCalculo Then
                '-- Se realiza el cálculo de la depreciacion
                For Each filaGrid As DataGridViewRow In Me.grdEmpresas.Rows
                    If filaGrid.Cells(0).Value = True Then
                        entro = True
                        exito = False

                        Dim conexion As New SqlClient.SqlConnection

                        Dim servidor As String = filaGrid.Cells(1).Tag.ToString
                        Dim empresa As String = filaGrid.Cells(1).Value.ToString
                        Dim descripcion As String = filaGrid.Cells(2).Value.ToString

                        Try
                            conexion.ConnectionString = "Data Source=" + servidor + "; Initial Catalog=" + empresa + "; uid=" + Citi.Synergia.Locals.Cache.UsuarioSQL + "; pwd=" + Citi.Synergia.Locals.Cache.Password

                            Dim comando As New SqlClient.SqlCommand
                            With comando
                                .Connection = conexion
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "Calcula_Depreciacion"
                                .Parameters.Add("@MES_DEPRECIA", SqlDbType.Int).Value = Me.MesDepreciacion
                                .Parameters.Add("@ANO_DEPRECIA", SqlDbType.Int).Value = Me.AnioDepreciacion
                                .Parameters.Add("@USUARIO", SqlDbType.Char, 10).Value = Citi.Synergia.Locals.Cache.UsuarioSSO
                            End With

                            conexion.Open()

                            comando.ExecuteNonQuery()

                            Me.HubieronCambios = True

                            exito = True

                            conexion.Close()

                        Catch errSQL As SqlClient.SqlException
                            Dim entroError As Boolean = False
                            For Each errorMalo As System.Data.SqlClient.SqlError In errSQL.Errors
                                If errorMalo.Number = 40000 Then
                                    entroError = True
                                    MessageBox.Show(errorMalo.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Next

                            If Not entroError Then
                                MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If

                            empresasError.Add(descripcion)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                            empresasError.Add(descripcion)
                        Finally
                            If conexion.State = ConnectionState.Open Then
                                conexion.Close()
                            End If
                        End Try
                    End If
                Next

                If entro Then
                    MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(334, "Finalizó proceso."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If empresasError.Count > 0 Then
                        Dim msgEmpresas As String = String.Empty
                        For Each empresaError As String In empresasError
                            msgEmpresas += " " & empresaError
                        Next

                        MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(335, "Se detectaron problemas en las siguientes empresas:") & msgEmpresas & ".", Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Me.Close()
                    End If
                Else
                    MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(314, "No se seleccionaron empresas."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                '-- Se realiza la autorización de la depreciación
                For Each filaGrid As DataGridViewRow In Me.grdEmpresas.Rows
                    If filaGrid.Cells(0).Value = True Then
                        entro = True
                        exito = False

                        Dim conexion As New SqlClient.SqlConnection

                        Dim servidor As String = filaGrid.Cells(1).Tag.ToString
                        Dim empresa As String = filaGrid.Cells(1).Value.ToString
                        Dim descripcion As String = filaGrid.Cells(2).Value.ToString

                        Try
                            conexion.ConnectionString = "Data Source=" + servidor + "; Initial Catalog=" + empresa + "; uid=" + Citi.Synergia.Locals.Cache.UsuarioSQL + "; pwd=" + Citi.Synergia.Locals.Cache.Password

                            Dim comando As New SqlClient.SqlCommand
                            With comando
                                .Connection = conexion
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "Autoriza_Depreciacion"
                                .Parameters.Add("@NO_PERIODO", SqlDbType.Int).Value = Me.NumeroPeriodo
                                .Parameters.Add("@ANO_PERIODO", SqlDbType.Int).Value = Me.AnioPeriodo
                                .Parameters.Add("@MES_DEPRE", SqlDbType.Int).Value = Me.MesDepreciacion
                                .Parameters.Add("@ANO_DEPRE", SqlDbType.Int).Value = Me.AnioDepreciacion
                                .Parameters.Add("@USUARIO", SqlDbType.Char, 10).Value = Citi.Synergia.Locals.Cache.UsuarioSSO
                            End With

                            conexion.Open()

                            comando.ExecuteNonQuery()

                            exito = True

                            conexion.Close()

                        Catch errSQL As SqlClient.SqlException
                            Dim entroError As Boolean = False
                            For Each errorMalo As System.Data.SqlClient.SqlError In errSQL.Errors
                                If errorMalo.Number = 40000 Then
                                    entroError = True
                                    MessageBox.Show(errorMalo.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Next

                            If Not entroError Then
                                MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If

                            empresasError.Add(descripcion)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                            empresasError.Add(descripcion)
                        Finally
                            If conexion.State = ConnectionState.Open Then
                                conexion.Close()
                            End If
                        End Try
                    End If
                Next

                If entro Then
                    MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(243, "La autorización de activos fue exitosa."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If empresasError.Count > 0 Then
                        Dim msgEmpresas As String = String.Empty
                        For Each empresaError As String In empresasError
                            msgEmpresas += " " & empresaError
                        Next

                        MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(244, "Se detectó problemas en la autorización de activos en:") & msgEmpresas & ".", Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Me.Close()
                    End If
                Else
                    MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(314, "No se seleccionaron empresas."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
End Class