Imports Citi.Synergia.Iconos
Imports Citi.Synergia.Entidades

Public Class NOMEMPS8
    Private Sub Forma_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.mnuConsultar.Text = Me.BotonConsultar.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos

            Me.IconosMenus.Images.Clear()
            '--Consulta
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Consultar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.BotonConsultar.Image = Me.IconosMenus.Images(0)
            Me.mnuConsultar.Image = Me.BotonConsultar.Image
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

        lblCODIGO_DIVISION.Text = Pop()

        Me.LlenarEncab()

        Me.LlenarParam()

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarEncab()
        Try
            meteSQL("select")
            meteSQL("       DESCRIPCION_DIVISION")
            meteSQL("  from DIVISIONES")
            meteSQL(" where CODIGO_DIVISION = " & Scm(lblCODIGO_DIVISION.Text))

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                lblDESCRIPCION_DIVISION.Text = SqlData(Sqlconn, 1).ToString
            Loop

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LlenarParam()
        NumCols = 2
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Empleado", 10, InfoLista.TipoAlineacion.ALINEAR_IZQ, "EMPLEADO.EMPLEADO_ID", 39, 10, 0, 1, 19)
        MeterParam(2, Info, 1, "Nombre", 40, InfoLista.TipoAlineacion.ALINEAR_IZQ, "EMPLEADO.NOMBRE_USUAL", 39, 40, 0, 0, 7)

        'snCampos = CrearParam(Info, Me)

        snCond = " CODIGO_DIVISION = " & Scm(lblCODIGO_DIVISION.Text)
        snTabla = "EMPLEADO"
    End Sub

    Private Function TieneAccesoNomina(ByVal codigoTipoNomina As String) As Boolean
        Dim retorno As Boolean = False

        Dim tieneAcceso As String

        tieneAcceso = "N"

        If Not String.IsNullOrEmpty(TraeDato("select count(1) from NOMINA_TIPO_USUARIOS where CODIGO_TIPO = " & Scm(codigoTipoNomina))) Then
            Dim contador As Integer = CType(TraeDato("select count(1) from NOMINA_TIPO_USUARIOS where CODIGO_TIPO = " & Scm(codigoTipoNomina)), Integer)
            If contador > 0 Then
                If is_sa() Then
                    tieneAcceso = "S"
                Else
                    If Not String.IsNullOrEmpty(TraeDato("select 'S' from NOMINA_TIPO_USUARIOS where CODIGO_TIPO = " & Scm(codigoTipoNomina) & " and NOMBRE_CORTO_ID = " & Scm(Citi.Synergia.Locals.Cache.UsuarioSSO))) Then
                        tieneAcceso = TraeDato("select 'S' from NOMINA_TIPO_USUARIOS where CODIGO_TIPO = " & Scm(codigoTipoNomina) & " and NOMBRE_CORTO_ID = " & Scm(Citi.Synergia.Locals.Cache.UsuarioSSO)).ToString
                    End If
                End If
            Else
                tieneAcceso = "S"
            End If
        End If

        If tieneAcceso <> "S" Then
            If Citi.Synergia.HelperClient.Utils.CITIMsgBox(Citi.Synergia.Traductor.Idiomas.GetMensaje(280, "El usuario no tiene acceso a la nómina: ") & codigoTipoNomina, Citi.Synergia.HelperClient.Utils.TipoDeMensaje.TipoError) = Citi.Synergia.HelperClient.Utils.TipoDeRespuesta.Continuar Then
                retorno = True
            Else
                retorno = False
            End If
        End If

        Return retorno
    End Function

    Private Function is_sa() As Boolean
        '--------------------------------------------------------
        'Author     : Fernando Fuentes
        'Fecha      : 20/6/1997
        'Descripcion:
        '
        'FUNCION VERIFICA SI EL USUARIO CONECTADO ACTUALMENTE
        'TIENE ROLE DE sa EN LA BASE DE DATOS Y SERVIDOR ACTUAL
        'USAR  ESTA FUNCION EN SEGURIDAD
        '--------------------------------------------------------
        'VALORES A RETORNAR:
        '                       true  si es sa
        '                       false si no es sa
        '--------------------------------------------------------
        Dim retorno As Boolean = False

        Try
            Dim resultado As String

            Dim contador As Integer
            If Not String.IsNullOrEmpty(TraeDato("Select count(1) from sysobjects where name = 'CITIROLE' and type = 'P'")) Then
                contador = CType(TraeDato("Select count(1) from sysobjects where name = 'CITIROLE' and type = 'P'"), Integer)
            End If

            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@role", SqlDbType.Int).Value = 0
                If contador <> 0 Then
                    .CommandText = "CITIROLE"
                Else
                    .CommandText = "SPCROLE"
                End If
                .Parameters(0).Direction = ParameterDirection.Output
            End With

            Dim parametro As New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@role"
                .Direction = ParameterDirection.Output
                .SqlDbType = SqlDbType.Int
                .Value = 0
            End With

            EjecutarComando(comando)

            resultado = comando.Parameters(0).Value.ToString

            If resultado = "1" Then
                retorno = True
            Else
                retorno = False
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return retorno
    End Function

    Private Sub Consultar()
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim idEmpleado As String = GridData.SelectedRows(0).Cells(0).Value.ToString()

                Dim codigoTipo As String = String.Empty
                If Not String.IsNullOrEmpty(TraeDato("select CODIGO_TIPO from EMPLEADO where EMPLEADO_ID = " & Scm(idEmpleado))) Then
                    codigoTipo = TraeDato("select CODIGO_TIPO from EMPLEADO where EMPLEADO_ID = " & Scm(idEmpleado)).ToString
                End If

                If Me.TieneAccesoNomina(codigoTipo) Then
                    Push(idEmpleado)

                    Dim frmConsulta As New NOMEMPC0
                    With frmConsulta
                        .SoloDeConsulta = True
                        .Pila = Me.Pila
                        .ShowDialog()
                        .Dispose()
                    End With
                    Me.LimpiarPila()
                End If
            End If
        End If
    End Sub

    Private Sub SeleccionaFila(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Me.Consultar()
    End Sub

    Private Sub Salir_Click(sender As System.Object, e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Llenar_Click(sender As System.Object, e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Llenar(False)
    End Sub

    Private Sub Consultar_Click(sender As System.Object, e As System.EventArgs) Handles BotonConsultar.Click, mnuConsultar.Click
        Me.Consultar()
    End Sub
End Class