Imports System
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Idiomas
    Inherits Citi.Synergia.DB.SQL

#Region " [Idiomas & Tablas] "
    Public Function LeerIdiomas(ByVal aplicacion As String, ByVal forma As String, ByVal idioma As String) As List(Of Citi.Synergia.Entidades.Controles)
        Dim retorno As New List(Of Citi.Synergia.Entidades.Controles)
        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comando As New SqlCommand
        With comando
            .CommandText = "Select * From SYN_IDIOMA_CONTROLES_DET Where LINEA In (Select LINEA From SYN_IDIOMA_CONTROLES Where APLICACION = @Aplicacion And FORMA = @Forma And IDIOMA = @Idioma)"
            comando.Parameters.Add("@Aplicacion", SqlDbType.VarChar).Value = aplicacion
            comando.Parameters.Add("@Forma", SqlDbType.VarChar).Value = forma
            comando.Parameters.Add("@Idioma", SqlDbType.VarChar).Value = idioma
        End With

        Try
            If Citi.Synergia.Locals.Cache.TablasDeIdiomaCreadas = False Then
                Me.CrearTablas()
            End If

            ValidarConexion()

            Dim data As DataSet = MyBase.GetDataSet(comando)

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    For Each fila As DataRow In data.Tables(0).Rows
                        Dim c As New Citi.Synergia.Entidades.Controles
                        With c
                            .Nombre = fila.Item("CONTROL").ToString()
                            .Texto = fila.Item("TEXTO").ToString()
                            .ToolTip = fila.Item("TOOLTIPTEXT").ToString()
                        End With
                        retorno.Add(c)
                    Next
                End If
            End If

            Return retorno

        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub GrabarIdiomas(ByVal aplicacion As String, ByVal forma As String, ByVal idioma As String, ByVal titulo As String, ByVal controles As List(Of Citi.Synergia.Entidades.Controles))
        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comando As New SqlCommand
        comando.CommandText = "Delete SYN_IDIOMA_CONTROLES Where APLICACION = @Aplicacion And FORMA = @Forma And IDIOMA = @Idioma"
        comando.Parameters.Add("@Aplicacion", SqlDbType.VarChar).Value = aplicacion
        comando.Parameters.Add("@Forma", SqlDbType.VarChar).Value = forma
        comando.Parameters.Add("@Idioma", SqlDbType.VarChar).Value = idioma
        comando.Parameters.Add("@Titulo", SqlDbType.VarChar).Value = titulo

        Try
            If Citi.Synergia.Locals.Cache.TablasDeIdiomaCreadas = False Then
                Me.CrearTablas()
            End If

            ValidarConexion()

            '-- Delete
            MyBase.EjecutarComando(comando)

            Dim linea As Integer = 0

            comando.CommandText = "Insert SYN_IDIOMA_CONTROLES (APLICACION, FORMA, IDIOMA, TITULO) Values (@Aplicacion, @Forma, @Idioma, @Titulo); Select SCOPE_IDENTITY()"

            linea = Convert.ToInt32(MyBase.EjecutarScalar(comando))

            For Each c As Citi.Synergia.Entidades.Controles In controles
                '-- Si lleva '@' al inicio no se graba.
                If Not String.Equals(c.Texto.Chars(0), "@") Then
                    With comando
                        .Parameters.Clear()
                        .CommandText = "Insert SYN_IDIOMA_CONTROLES_DET (LINEA, CONTROL, TEXTO, TOOLTIPTEXT) Values (@Linea, @Control, @Texto, @ToolTipText)"
                        .Parameters.Add("@Linea", SqlDbType.Int).Value = linea
                        .Parameters.Add("@Control", SqlDbType.VarChar).Value = c.Nombre
                        .Parameters.Add("@Texto", SqlDbType.VarChar).Value = c.Texto
                        .Parameters.Add("@ToolTipText", SqlDbType.VarChar).Value = c.ToolTip
                        MyBase.EjecutarComando(comando)
                    End With
                End If
            Next

            comando.Dispose()
        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CrearTablas()
        Dim contador As Integer
        Dim comando As New SqlCommand

        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        '-- Veo si ya existen las tablas:
        comando.CommandText = "Select COUNT(*) From sys.objects  Where Name = 'SYN_IDIOMA_CONTROLES'"

        Try
            ValidarConexion()

            contador = CType(MyBase.EjecutarScalar(comando), Integer)
            If contador = 0 Then
                comando.CommandText = " CREATE TABLE SYN_IDIOMA_CONTROLES (" & _
                                      "     [LINEA] [int] IDENTITY(1,1) NOT NULL," & _
                                      "     [APLICACION] [varchar](max) NULL," & _
                                      "     [FORMA] [varchar](max) NULL," & _
                                      "     [IDIOMA] [varchar](3) NULL," & _
                                      "     [TITULO] [varchar](max) NULL," & _
                                      "  CONSTRAINT [PK_SYN_IDIOMA_CONTROLES] PRIMARY KEY CLUSTERED (" & _
                                      "     [LINEA] ASC" & _
                                      " )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]" & _
                                      " ) ON [PRIMARY]"
                MyBase.EjecutarComando(comando)
            End If

            '-- Valido si ya existen la tabla de detalles (sólo por si acaso)
            comando.CommandText = "Select COUNT(*) From sys.objects  Where Name = 'SYN_IDIOMA_CONTROLES_DET'"
            contador = CType(MyBase.EjecutarScalar(comando), Integer)
            If contador = 0 Then
                comando.CommandText = " CREATE TABLE [dbo].[SYN_IDIOMA_CONTROLES_DET](" & _
                                      " 	[LINEA_DET] [int] IDENTITY(1,1) NOT NULL," & _
                                      " 	[LINEA] [int] NOT NULL," & _
                                      " 	[CONTROL] [varchar](max) NULL," & _
                                      " 	[TEXTO] [varchar](max) NULL," & _
                                      " 	[TOOLTIPTEXT] [varchar](max) NULL," & _
                                      "  CONSTRAINT [PK_SYN_IDIOMA_CONTROLES_DET] PRIMARY KEY CLUSTERED (" & _
                                      " 	[LINEA_DET] ASC" & _
                                      " )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]" & _
                                      " ) ON [PRIMARY]" & _
                                      " ALTER TABLE [dbo].[SYN_IDIOMA_CONTROLES_DET]  WITH CHECK ADD  CONSTRAINT [FK_SYN_IDIOMA_CONTROLES_DET_SYN_IDIOMA_CONTROLES] FOREIGN KEY([LINEA])" & _
                                      " REFERENCES [dbo].[SYN_IDIOMA_CONTROLES] ([LINEA])" & _
                                      " ON DELETE CASCADE" & _
                                      " ALTER TABLE [dbo].[SYN_IDIOMA_CONTROLES_DET] CHECK CONSTRAINT [FK_SYN_IDIOMA_CONTROLES_DET_SYN_IDIOMA_CONTROLES]"
                MyBase.EjecutarComando(comando)
            End If


            '-- Valido si existe la tabla de mensajes
            comando.CommandText = "Select COUNT(*) From sys.objects  Where Name = 'SYN_MENSAJES'"
            contador = CType(MyBase.EjecutarScalar(comando), Integer)
            If contador = 0 Then
                comando.CommandText = " CREATE TABLE [dbo].[SYN_MENSAJES](" & _
                                      " 	[LINEA] [int] IDENTITY(1,1) NOT NULL," & _
                                      " 	[CODIGO] int NULL," & _
                                      " 	[IDIOMA] [varchar](3) NULL," & _
                                      " 	[TEXTO] [varchar](max) NULL," & _
                                      "  CONSTRAINT [PK_SYN_MENSAJES] PRIMARY KEY CLUSTERED (" & _
                                      " 	[LINEA] ASC" & _
                                      " )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]" & _
                                      " ) ON [PRIMARY]"
                MyBase.EjecutarComando(comando)
            End If

            '-- Valido si existe la tabla donde se registra al usuario que usa la aplicación
            comando.CommandText = "Select COUNT(*) From sys.objects  Where Name = 'SYN_IDIOMA_USUARIO'"
            contador = CType(MyBase.EjecutarScalar(comando), Integer)
            If contador = 0 Then
                comando.CommandText = " CREATE TABLE [dbo].[SYN_IDIOMA_USUARIO](" & _
                                      " 	[USUARIO] [varchar](50) NOT NULL," & _
                                      " 	[WORKSTATION] [varchar](100) NOT NULL," & _
                                      " 	[IDIOMA] [varchar](3) NOT NULL" & _
                                      " ) ON [PRIMARY]"
                MyBase.EjecutarComando(comando)
            End If

            '-- Cambio a true variable global
            Citi.Synergia.Locals.Cache.TablasDeIdiomaCreadas = True

        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LeerIdioma(ByVal codigo As String) As List(Of Citi.Synergia.Entidades.Idiomas)
        Dim retorno As New List(Of Citi.Synergia.Entidades.Idiomas)
        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comando As New SqlCommand
        With comando
            .CommandText = "Select * From SYN_IDIOMAS"

            If codigo.Trim.Length > 0 Then
                .CommandText = .CommandText + " Where CODIGO = @Codigo"
                .Parameters.Add("@Codigo", SqlDbType.VarChar).Value = codigo
            End If
        End With

        Try
            ValidarConexion()

            Dim data As DataSet = MyBase.GetDataSet(comando)

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    For Each fila As DataRow In data.Tables(0).Rows
                        Dim i As New Citi.Synergia.Entidades.Idiomas
                        With i
                            .Codigo = fila.Item("CODIGO").ToString
                            .Descripcion = fila.Item("DESCRIPCION").ToString
                        End With
                        retorno.Add(i)
                    Next
                End If
            End If

            Return retorno

        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region " [Aplicaciones] "
    Public Function LeerAplicaciones() As List(Of Citi.Synergia.Entidades.Aplicaciones)
        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim retorno As New List(Of Citi.Synergia.Entidades.Aplicaciones)

        Dim instruccionSQL As String = "Select Distinct APLICACION From SYN_IDIOMA_CONTROLES Order By APLICACION"

        Dim data As New DataSet

        Try
            If Citi.Synergia.Locals.Cache.TablasDeIdiomaCreadas = False Then
                Me.CrearTablas()
            End If

            ValidarConexion()

            data = MyBase.GetDataSet(instruccionSQL)

            For Each fila As DataRow In data.Tables(0).Rows
                Dim app As New Citi.Synergia.Entidades.Aplicaciones
                app.Aplicacion = fila.Item(0).ToString()

                retorno.Add(app)
            Next

            Return retorno
        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub AplicacionAgregar(ByVal aplicacion As String)
        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comando As New SqlCommand

        Try
            If Citi.Synergia.Locals.Cache.TablasDeIdiomaCreadas = False Then
                Me.CrearTablas()
            End If

            ValidarConexion()

            With comando
                .CommandText = "Insert SYN_IDIOMA_CONTROLES (APLICACION, FORMA, IDIOMA, TITULO) Values (@Aplicacion, @Forma, @Idioma, @Titulo)"
                comando.Parameters.Add("@Aplicacion", SqlDbType.VarChar).Value = aplicacion
                comando.Parameters.Add("@Forma", SqlDbType.VarChar).Value = String.Empty
                comando.Parameters.Add("@Idioma", SqlDbType.VarChar).Value = String.Empty
                comando.Parameters.Add("@Titulo", SqlDbType.VarChar).Value = String.Empty
            End With

            MyBase.EjecutarComando(comando)

            comando.Dispose()
        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region " [Formas & Controles] "
    Public Function LeerFormas(ByVal aplicacion As String, ByVal forma As String) As List(Of Citi.Synergia.Entidades.Formas)
        Dim retorno As New List(Of Citi.Synergia.Entidades.Formas)
        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comando As New SqlCommand
        With comando
            .CommandText = "Select Distinct FORMA From SYN_IDIOMA_CONTROLES Where APLICACION = @Aplicacion"
            .Parameters.Add("@Aplicacion", SqlDbType.VarChar).Value = aplicacion
            If Not String.IsNullOrEmpty(forma) Then
                .CommandText += " And FORMA = @Forma"
                .Parameters.Add("@Forma", SqlDbType.VarChar).Value = forma
            End If
        End With

        Try
            ValidarConexion()

            Dim data As DataSet = MyBase.GetDataSet(comando)

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    For Each fila As DataRow In data.Tables(0).Rows
                        Dim f As New Citi.Synergia.Entidades.Formas
                        With f
                            .Aplicacion = aplicacion
                            .Forma = fila.Item("FORMA").ToString
                        End With
                        retorno.Add(f)
                    Next
                End If
            End If

            Return retorno

        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function LeerFormasIdiomas(ByVal aplicacion As String, ByVal forma As String, ByVal idioma As String) As List(Of Citi.Synergia.Entidades.Formas)
        Dim retorno As New List(Of Citi.Synergia.Entidades.Formas)
        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comandoSQL As String = String.Empty

        Dim comando As New SqlCommand
        With comando
            comandoSQL = "Select * From SYN_IDIOMA_CONTROLES Where APLICACION = @Aplicacion"
            .Parameters.Add("@Aplicacion", SqlDbType.VarChar).Value = aplicacion

            If Not String.IsNullOrEmpty(forma) Then
                comandoSQL += " And FORMA = @Forma"
                .Parameters.Add("@Forma", SqlDbType.VarChar).Value = forma
            End If

            If Not String.IsNullOrEmpty(idioma) Then
                comandoSQL += " And IDIOMA = @Idioma"
                .Parameters.Add("@Idioma", SqlDbType.VarChar).Value = idioma
            End If

            comandoSQL += " Order By FORMA"
            .CommandText = comandoSQL
        End With

        Try
            ValidarConexion()

            Dim data As DataSet = MyBase.GetDataSet(comando)

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    For Each fila As DataRow In data.Tables(0).Rows
                        Dim f As New Citi.Synergia.Entidades.Formas
                        With f
                            .Aplicacion = aplicacion
                            .Forma = fila.Item("FORMA").ToString
                            .Linea = CType(fila.Item("LINEA"), Integer)
                            .Idioma = fila.Item("IDIOMA").ToString
                            .Titulo = fila.Item("TITULO").ToString
                        End With
                        retorno.Add(f)
                    Next
                End If
            End If

            Return retorno

        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub FormaAgregar(ByVal aplicacion As String, ByVal forma As String, ByVal titulos As List(Of Citi.Synergia.Entidades.Formas))
        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comando As New SqlCommand
        With comando
            .CommandText = "Delete SYN_IDIOMA_CONTROLES Where APLICACION = @Aplicacion AND (FORMA = @Forma OR FORMA = '')"
            .Parameters.Add("@Aplicacion", SqlDbType.VarChar).Value = aplicacion
            .Parameters.Add("@Forma", SqlDbType.VarChar).Value = forma
        End With

        Try
            ValidarConexion()

            MyBase.EjecutarComando(comando)

            For Each titulo In titulos
                With comando
                    .Parameters.Clear()
                    .CommandText = "Insert SYN_IDIOMA_CONTROLES (APLICACION, FORMA, IDIOMA, TITULO) Values (@Aplicacion, @Forma, @Idioma, @Titulo)"
                    .Parameters.Add("@Aplicacion", SqlDbType.VarChar).Value = aplicacion
                    .Parameters.Add("@Forma", SqlDbType.VarChar).Value = forma
                    .Parameters.Add("@Idioma", SqlDbType.VarChar).Value = titulo.Idioma
                    .Parameters.Add("@Titulo", SqlDbType.VarChar).Value = titulo.Titulo
                End With
                MyBase.EjecutarComando(comando)
            Next

            comando.Dispose()
        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub FormasEditar(ByVal aplicacion As String, ByVal formas As List(Of Citi.Synergia.Entidades.Formas))
        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comando As New SqlCommand

        Try
            For Each forma In formas
                With comando
                    .Parameters.Clear()
                    .CommandText = "Update SYN_IDIOMA_CONTROLES Set TITULO = @Titulo Where APLICACION = @Aplicacion AND FORMA = @Forma AND IDIOMA = @Idioma"
                    .Parameters.Add("@Aplicacion", SqlDbType.VarChar).Value = aplicacion
                    .Parameters.Add("@Forma", SqlDbType.VarChar).Value = forma.Forma
                    .Parameters.Add("@Idioma", SqlDbType.VarChar).Value = forma.Idioma
                    .Parameters.Add("@Titulo", SqlDbType.VarChar).Value = forma.Titulo
                    MyBase.EjecutarComando(comando)

                    '-- Veo si tengo que agregar
                    Dim contador As Integer = 0
                    .CommandText = "Select IsNull(Count(*), 0) From SYN_IDIOMA_CONTROLES Where APLICACION = @Aplicacion AND FORMA = @Forma AND IDIOMA = @Idioma"
                    contador = CType(MyBase.EjecutarScalar(comando), Integer)

                    If contador = 0 Then
                        '-- Agrego
                        .CommandText = "Insert SYN_IDIOMA_CONTROLES (APLICACION, FORMA, IDIOMA, TITULO) Values (@Aplicacion, @Forma, @Idioma, @Titulo)"
                        MyBase.EjecutarComando(comando)
                    End If
                End With
            Next

            comando.Dispose()

        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LeerControlesIdiomas(ByVal aplicacion As String, ByVal forma As String) As List(Of Citi.Synergia.Entidades.ControlDetalle)
        Dim retorno As New List(Of Citi.Synergia.Entidades.ControlDetalle)
        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comandoSQL As New Text.StringBuilder()
        With comandoSQL
            .Append("Select f.APLICACION AS AplicacionNombre")
            .Append("     , f.FORMA AS FormaNombre")
            .Append("     , f.IDIOMA AS Idioma")
            .Append("     , c.CONTROL AS ControlNombre")
            .Append("     , c.TEXTO AS Texto")
            .Append("     , c.TOOLTIPTEXT AS ToolTipText")
            .Append("  From SYN_IDIOMA_CONTROLES_DET  c")
            .Append("  Join SYN_IDIOMA_CONTROLES      f On (f.LINEA = c.LINEA)")
            .Append(" Where f.APLICACION = @Aplicacion")
            .Append("   And f.FORMA = @Forma")
            .Append("       Order By c.CONTROL")
        End With

        Dim comando As New SqlCommand
        With comando
            .CommandType = CommandType.Text
            .CommandText = comandoSQL.ToString()
            comando.Parameters.Add("@Aplicacion", SqlDbType.VarChar).Value = aplicacion
            comando.Parameters.Add("@Forma", SqlDbType.VarChar).Value = forma
        End With

        Try
            ValidarConexion()

            Dim data As DataSet = MyBase.GetDataSet(comando)

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    For Each fila As DataRow In data.Tables(0).Rows
                        Dim c As New Citi.Synergia.Entidades.ControlDetalle
                        With c
                            .Aplicacion = fila.Item("AplicacionNombre").ToString()
                            .Forma = fila.Item("FormaNombre").ToString()
                            .Idioma = fila.Item("Idioma").ToString()
                            .Nombre = fila.Item("ControlNombre").ToString()
                            .Texto = fila.Item("Texto").ToString()
                            .ToolTipText = fila.Item("ToolTipText").ToString()
                        End With
                        retorno.Add(c)
                    Next
                End If
            End If

            Return retorno

        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ControlEditar(ByVal aplicacion As String, ByVal forma As String, ByVal controles As List(Of Citi.Synergia.Entidades.ControlDetalle))
        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comando As New SqlCommand

        Try
            '-- En controles viene una fila por control por idioma (con Texto y ToolTip cada una)
            For Each control In controles
                With comando
                    .Parameters.Clear()
                    '-- Necesito el número de Linea de SYN_IDIOMA_CONTROLES
                    .CommandText = "Select LINEA From SYN_IDIOMA_CONTROLES Where APLICACION = @Aplicacion AND FORMA = @Forma AND IDIOMA = @Idioma"
                    .Parameters.Add("@Aplicacion", SqlDbType.VarChar).Value = aplicacion
                    .Parameters.Add("@Forma", SqlDbType.VarChar).Value = forma
                    .Parameters.Add("@Idioma", SqlDbType.VarChar).Value = control.Idioma
                    Dim linea As Integer = 0
                    linea = CType(MyBase.EjecutarScalar(comando), Integer)

                    '-- Hago la actualización
                    .CommandText = "Update SYN_IDIOMA_CONTROLES_DET Set TEXTO = @Texto, TOOLTIPTEXT = @ToolTipText Where LINEA = @Linea AND CONTROL = @Control"
                    .Parameters.Add("@Linea", SqlDbType.Int).Value = linea
                    .Parameters.Add("@Control", SqlDbType.VarChar).Value = control.Nombre
                    .Parameters.Add("@Texto", SqlDbType.VarChar).Value = control.Texto
                    .Parameters.Add("@ToolTipText", SqlDbType.VarChar).Value = control.ToolTipText
                    MyBase.EjecutarComando(comando)

                    '-- Veo si tengo que agregar
                    Dim contador As Integer = 0
                    .CommandText = "Select IsNull(Count(*), 0) From SYN_IDIOMA_CONTROLES_DET Where LINEA = @Linea And CONTROL = @Control"
                    contador = CType(MyBase.EjecutarScalar(comando), Integer)

                    If contador = 0 Then
                        '-- Agrego
                        .CommandText = "Insert SYN_IDIOMA_CONTROLES_DET (LINEA, CONTROL, TEXTO, TOOLTIPTEXT) Values (@Linea, @Control, @Texto, @ToolTipText)"
                        MyBase.EjecutarComando(comando)
                    End If
                End With
            Next

            comando.Dispose()

        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ControlAgregar(ByVal aplicacion As String, ByVal forma As String, ByVal controles As List(Of Citi.Synergia.Entidades.ControlDetalle))
        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comando As New SqlCommand

        Try
            ValidarConexion()

            '-- En controles viene una fila por idioma (con Texto y ToolTip cada una)
            For Each control In controles
                With comando
                    .Parameters.Clear()
                    '-- Necesito el número de Linea de SYN_IDIOMA_CONTROLES
                    .CommandText = "Select LINEA From SYN_IDIOMA_CONTROLES Where APLICACION = @Aplicacion AND FORMA = @Forma AND IDIOMA = @Idioma"
                    .Parameters.Add("@Aplicacion", SqlDbType.VarChar).Value = aplicacion
                    .Parameters.Add("@Forma", SqlDbType.VarChar).Value = forma
                    .Parameters.Add("@Idioma", SqlDbType.VarChar).Value = control.Idioma
                    Dim linea As Integer = 0
                    linea = CType(MyBase.EjecutarScalar(comando), Integer)

                    '-- Hago el Insert
                    .CommandText = "Insert SYN_IDIOMA_CONTROLES_DET (LINEA, CONTROL, TEXTO, TOOLTIPTEXT) Values (@Linea, @Control, @Texto, @ToolTipText)"
                    .Parameters.Add("@Linea", SqlDbType.Int).Value = linea
                    .Parameters.Add("@Control", SqlDbType.VarChar).Value = control.Nombre
                    .Parameters.Add("@Texto", SqlDbType.VarChar).Value = control.Texto
                    .Parameters.Add("@ToolTipText", SqlDbType.VarChar).Value = control.ToolTipText
                End With
                MyBase.EjecutarComando(comando)
            Next

            comando.Dispose()
        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region " [Mensajes] "
    Public Shared Function GetMensaje(ByVal codigo As Integer, ByVal defaultCadena As String) As String
        '-- Variable a retornar
        '-- La variable 'retorno' es la que se devuelve si no se encontró el código
        Dim respuesta As String = defaultCadena

        Dim oIdiomas As New Citi.Synergia.Traductor.Idiomas

        '-- Conexión
        oIdiomas.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comando As New SqlCommand

        Try
            If Citi.Synergia.Locals.Cache.TablasDeIdiomaCreadas = False Then
                oIdiomas.CrearTablas()
            End If

            With comando
                .CommandText = "Select TEXTO From SYN_MENSAJES Where CODIGO = @Codigo AND IDIOMA = @Idioma"
                .Parameters.Add("@Codigo", SqlDbType.Int).Value = codigo
                .Parameters.Add("@Idioma", SqlDbType.VarChar).Value = Citi.Synergia.Locals.Cache.IdiomaSeleccionado
            End With

            respuesta = oIdiomas.EjecutarScalar(comando) ' .ToString

            If String.IsNullOrEmpty(respuesta) Then
                respuesta = defaultCadena
            End If

            comando.Dispose()

        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try

        Return respuesta
    End Function

    Public Function LeerMensajeIdiomas(ByVal codigo As Integer, ByVal idioma As String) As List(Of Citi.Synergia.Entidades.Mensajes)
        Dim retorno As New List(Of Citi.Synergia.Entidades.Mensajes)
        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comandoSQL As String = String.Empty

        Dim comando As New SqlCommand
        With comando
            comandoSQL = "Select * From SYN_MENSAJES"
            If codigo <> 0 Then
                comandoSQL += " Where CODIGO = @Codigo"
                .Parameters.Add("@Codigo", SqlDbType.Int).Value = codigo
            End If

            If Not String.IsNullOrEmpty(idioma) Then
                MyBase.AgregarWhere(comandoSQL)
                comandoSQL += " IDIOMA = @Idioma"
                .Parameters.Add("@Idioma", SqlDbType.VarChar).Value = idioma
            End If
            .CommandText = comandoSQL
        End With

        Try
            If Citi.Synergia.Locals.Cache.TablasDeIdiomaCreadas = False Then
                Me.CrearTablas()
            End If

            ValidarConexion()

            Dim data As DataSet = MyBase.GetDataSet(comando)

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    For Each fila As DataRow In data.Tables(0).Rows
                        Dim m As New Citi.Synergia.Entidades.Mensajes
                        With m
                            .Codigo = CType(fila.Item("CODIGO").ToString(), Integer)
                            .Idioma = fila.Item("IDIOMA").ToString()
                            .Texto = fila.Item("TEXTO").ToString()
                        End With
                        retorno.Add(m)
                    Next
                End If
            End If

            Return retorno

        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub MensajesEditar(ByVal mensajes As List(Of Citi.Synergia.Entidades.Mensajes))
        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comando As New SqlCommand

        Try
            For Each mensaje In mensajes
                With comando
                    .Parameters.Clear()
                    '-- Antes de editar veo si ya existe el registro
                    .CommandText = "Select COUNT(*) From SYN_MENSAJES Where CODIGO = @Codigo AND IDIOMA = @Idioma"
                    .Parameters.Add("@Codigo", SqlDbType.Int).Value = mensaje.Codigo
                    .Parameters.Add("@Idioma", SqlDbType.VarChar).Value = mensaje.Idioma
                    .Parameters.Add("@Texto", SqlDbType.VarChar).Value = mensaje.Texto
                    Dim contador As Integer = 0
                    contador = CType(MyBase.EjecutarScalar(comando), Integer)
                    '-- Si no hay registros hago un Insert
                    If contador = 0 Then
                        .CommandText = "Insert Into SYN_MENSAJES (CODIGO, IDIOMA, TEXTO) Values (@Codigo, @Idioma, @Texto)"
                    Else
                        .CommandText = "Update SYN_MENSAJES Set TEXTO = @Texto Where CODIGO = @Codigo AND IDIOMA = @Idioma"
                    End If
                End With

                MyBase.EjecutarComando(comando)
            Next

            comando.Dispose()

        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub MensajeAgregar(ByVal mensajes As List(Of Citi.Synergia.Entidades.Mensajes))
        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comando As New SqlCommand

        Try
            If Citi.Synergia.Locals.Cache.TablasDeIdiomaCreadas = False Then
                Me.CrearTablas()
            End If

            For Each mensaje In mensajes
                With comando
                    .Parameters.Clear()
                    .CommandText = "Insert SYN_MENSAJES (CODIGO, IDIOMA, TEXTO) Values (@Codigo, @Idioma, @Texto)"
                    .Parameters.Add("@Codigo", SqlDbType.Int).Value = mensaje.Codigo
                    .Parameters.Add("@Idioma", SqlDbType.VarChar).Value = mensaje.Idioma
                    .Parameters.Add("@Texto", SqlDbType.VarChar).Value = mensaje.Texto
                End With
                MyBase.EjecutarComando(comando)
            Next

            comando.Dispose()
        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function MensajeCodigoSugerido() As Integer
        Dim retorno As Integer = 0
        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comando As New SqlCommand
        With comando
            .CommandText = "Select COUNT(*) From SYN_MENSAJES"
        End With

        Try
            If Citi.Synergia.Locals.Cache.TablasDeIdiomaCreadas = False Then
                Me.CrearTablas()
            End If

            ValidarConexion()

            Dim contador As Integer = 0
            contador = CType(MyBase.EjecutarScalar(comando), Integer)
            If contador = 0 Then
                retorno = 1
            Else
                comando.CommandText = "Select MAX(CODIGO) + 1 From SYN_MENSAJES"
                retorno = CType(MyBase.EjecutarScalar(comando), Integer)
            End If

            Return retorno

        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function GetMensaje(ByVal codigoCadena As String, ByVal defaultCadena As String) As String
        '-- Variable a retornar
        '-- La variable 'defaultCadena' es la que se devuelve si no se encontró el código
        Dim respuesta As String = defaultCadena

        Dim oIdiomas As New Citi.Synergia.Traductor.Idiomas

        If codigoCadena.Trim.Length > 0 Then
            Dim codigo As Integer = oIdiomas.MensajeRetornaCodigo(codigoCadena)

            '-- Conexión
            oIdiomas.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

            Dim comando As New SqlCommand

            Try
                If Citi.Synergia.Locals.Cache.TablasDeIdiomaCreadas = False Then
                    oIdiomas.CrearTablas()
                End If

                With comando
                    .CommandText = "Select TEXTO From SYN_MENSAJES Where CODIGO = @Codigo AND IDIOMA = @Idioma"
                    .Parameters.Add("@Codigo", SqlDbType.Int).Value = codigo
                    .Parameters.Add("@Idioma", SqlDbType.VarChar).Value = Citi.Synergia.Locals.Cache.IdiomaSeleccionado
                End With

                respuesta = oIdiomas.EjecutarScalar(comando) '.ToString

                If String.IsNullOrEmpty(respuesta) Then
                    respuesta = defaultCadena
                End If

                comando.Dispose()

            Catch errSQL As SqlException
                Throw errSQL
            Catch ex As Exception
                Throw ex
            End Try
        End If

        Return respuesta
    End Function

    Private Function MensajeRetornaCodigo(ByVal texto As String) As Integer
        Dim retorno As Integer = 0

        If String.Equals(texto.Chars(0), "@") Then
            retorno = CType(texto.Substring(1, texto.Length - 1), Integer)
        End If

        Return retorno
    End Function

    Public Function MensajeExiste(ByVal mensaje As String) As String
        Dim retorno As String = String.Empty

        MyBase.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comando As New SqlCommand
        With comando
            .CommandText = "Select COUNT(*) Where UPPER(TEXTO) = UPPER(@Mensaje)"
            .Parameters.Add("@Mensaje", SqlDbType.VarChar).Value = mensaje
        End With

        Try
            ValidarConexion()

            Dim contador As Integer = 0
            contador = MyBase.EjecutarScalar(comando)

            If contador <> 0 Then
                retorno = mensaje
            End If

        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try

        Return retorno
    End Function
#End Region
End Class