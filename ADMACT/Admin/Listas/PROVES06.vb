Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.HelperClient

Public Class PROVES06
    Private _primerLlenado As Boolean = False

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuAgregar.Text = Me.cmdAgregar.Texto
        Me.mnuBorrar.Text = Me.cmdBorrar.Texto
        Me.mnuModificar.Text = Me.cmdModificar.Texto
        Me.mnuConsultar.Text = Me.BotonConsultar.Texto
        Me.mnuBajarNivel.Text = Me.BotonBajarNivel.Texto
        Me.mnuReporte.Text = Me.BotonReporte.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos.Iconos

            Me.IconosMenus.Images.Clear()
            '-- Agregar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Agregar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Borrar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Borrar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Modificar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Modificar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consultar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Consultar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Bajar nivel
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.BajarNivel).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Reporte
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Reporte).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.cmdAgregar.Image = Me.IconosMenus.Images(0)
            Me.mnuAgregar.Image = Me.cmdAgregar.Image
            Me.cmdBorrar.Image = Me.IconosMenus.Images(1)
            Me.mnuBorrar.Image = Me.cmdBorrar.Image
            Me.cmdModificar.Image = Me.IconosMenus.Images(2)
            Me.mnuModificar.Image = Me.cmdModificar.Image
            Me.BotonConsultar.Image = Me.IconosMenus.Images(3)
            Me.mnuConsultar.Image = Me.BotonConsultar.Image
            Me.BotonBajarNivel.Image = Me.IconosMenus.Images(4)
            Me.mnuBajarNivel.Image = Me.BotonBajarNivel.Image
            Me.BotonReporte.Image = Me.IconosMenus.Images(5)
            Me.mnuReporte.Image = Me.BotonReporte.Image
            Me.BotonLlenar.Image = Me.IconosMenus.Images(6)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(7)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MyBase.SetearPosiciones()

        Me._primerLlenado = False

        Me.LlenarParam()

        Me.LlenarEncabezado()

        '-- No se utilizan porque se llena el grid cuando se llena el combo.
        'LlenarParam()

        'MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarParam()
        NumCols = 2
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Proveedor", 10, ALINEAR_DER, "CODIGO_PROVEEDOR", 56, 10, 0, 1, 45)
        MeterParam(2, Info, 1, "Nombre", 40, ALINEAR_IZQ, "nombre_proveedor", 47, 40, 0, 0, 7)

        Dim clase As String = String.Empty 'cboCODIGO_CLASE_PROVEED.SelectedValue
        If Not String.IsNullOrEmpty(cboCODIGO_CLASE_PROVEED.SelectedValue) Then
            clase = cboCODIGO_CLASE_PROVEED.SelectedValue.ToString
        End If
        If clase.Trim().Length > 0 Then
            snCond = " Where CODIGO_CLASE_PROVEED = " + Scm(clase)
        End If
        snTabla = "PROVEEDORES"
    End Sub

    Private Sub LlenarEncabezado()
        Try
            Dim clases As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)

            clases.Add(New Citi.Synergia.Entidades.CodigoDescripcion("", "** TODOS **"))

            meteSQL("Select CODIGO_CLASE_PROVEED ")
            meteSQL("     , DESCRIPCION_CLASE")
            meteSQL("  from CLASE_PROVEEDOR")

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                clases.Add(New Citi.Synergia.Entidades.CodigoDescripcion(SqlData(Sqlconn, 1), SqlData(Sqlconn, 2)))
            Loop

            With cboCODIGO_CLASE_PROVEED
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
                .DataSource = clases
            End With

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Modificar()
        If LlenarLlaves() Then
            Dim frmModificar As New PROVEM03
            With frmModificar
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

    Private Sub CodigoProveedor_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCODIGO_CLASE_PROVEED.SelectedValueChanged
        Dim clase As String = String.Empty 'cboCODIGO_CLASE_PROVEED.SelectedValue
        If Not String.IsNullOrEmpty(cboCODIGO_CLASE_PROVEED.SelectedValue) Then
            clase = cboCODIGO_CLASE_PROVEED.SelectedValue.ToString
        End If
        If clase.Trim().Length > 0 Then
            snCond = " Where CODIGO_CLASE_PROVEED = " + Scm(clase)
        Else
            snCond = ""
        End If

        If Me._primerLlenado Then
            MyBase.LlenarSelNav()
        End If

        Me._primerLlenado = True
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click, mnuAgregar.Click
        Dim frmAgregar As New PROVEM03
        With frmAgregar
            .Modo_Local = Modo_Alta
            .Push("")
            .ShowDialog()
            If .HubieronCambios Then
                MyBase.LlenarSelNav()
            End If
            .Dispose()
        End With
    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click, mnuBorrar.Click
        If LlenarLlaves() Then
            Dim frmBorrar As New PROVEM03
            With frmBorrar
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

    Private Sub Salir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Me.Llenar(False)
    End Sub

    Private Sub Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonConsultar.Click, mnuConsultar.Click
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim codigoProveedor As String = GridData.SelectedRows(0).Cells(0).Value.ToString()

                Dim frmConsulta As New PROVEM10
                With frmConsulta
                    .Modo_Local = Modo_Consulta
                    .SoloDeConsulta = True
                    .CodigoProveedor = codigoProveedor
                    .Show()
                End With
            End If
        End If
    End Sub

    Private Sub BajarNivel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBajarNivel.Click, mnuBajarNivel.Click
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim codigoProveedor As String = GridData.SelectedRows(0).Cells(0).Value.ToString()

                Dim frmBajarNivel As New CXPCPIS0
                With frmBajarNivel
                    .CodigoProveedor = codigoProveedor
                    .Show()
                End With
            End If
        End If
    End Sub

    Private Sub Reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonReporte.Click, mnuReporte.Click
        Try
            'Citi.Synergia.Reportes.Crystal.Parametros.Clear()
            'With Citi.Synergia.Reportes.Crystal.Parametros
            '    .Add(New Citi.Synergia.Reportes.Campos("_USUARIO", Scm(DescripcionesDB.TraeUsuario())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_EMPRESA", Scm(DescripcionesDB.TraeEmpresa())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_IDIOMA", Scm(Citi.Synergia.Locals.Cache.IdiomaSeleccionado)))
            'End With

            'If Citi.Synergia.Reportes.Crystal.ValidaReporte("Proveedores", True) = False Then
            '    Return
            'End If

            'Citi.Synergia.Reportes.Crystal.EjecutarReporte("Proveedores", , Citi.Synergia.Traductor.Idiomas.GetMensaje(278, "Información General de Proveedores"))


            Dim parametros As New List(Of String)
            With parametros
                '.Add(DescripcionesDB.TraeUsuario())
                .Add(Citi.Synergia.Locals.Cache.UsuarioSSO)
            End With

            Citi.Synergia.Reports.Reportes.EjecutarReporte(Reports.Reportes.ListadoReportes.Proveedores, parametros)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class