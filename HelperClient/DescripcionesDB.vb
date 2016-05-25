Imports System.Windows.Forms

Public Class DescripcionesDB
    Private Shared Function TraeDato(ByVal cadena As String) As Object
        Dim oData As New Citi.Synergia.DB.SQL
        oData.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim retorno As New Object

        Try
            retorno = oData.EjecutarScalar(cadena)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return retorno
    End Function

    Private Shared Function scm(ByVal cadena As String) As String
        ' scm = Super Comilla Mágica
        Dim retorno As String = String.Empty

        If cadena Is Nothing Then
            cadena = String.Empty
        End If

        If cadena.Length > 0 Then
            retorno = "'" + cadena.Replace("'", "''") + "'"
        Else
            retorno = "null"
        End If

        Return retorno
    End Function

    Private Shared Function sen(ByVal valor As String) As String
        ' sen = Super Evaluador Numérico
        Dim retorno As String = String.Empty
        Dim pto As Integer

        If valor Is Nothing Then
            valor = String.Empty
        End If

        If valor.Trim.Length > 0 Then
            pto = InStr(valor, ",")
            If pto > 0 Then
                Mid(valor, pto, 1) = "."
            End If
            sen = valor
        Else
            sen = "null"
        End If
    End Function

    Public Shared Function TipoDeActivo(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(DESCRIP_TIPO_ACTIVO, '') from TIPOS_DE_ACTIVOS where CODIGO_TIPO_ACTIVO = " & scm(codigo))) Then
            retorno = TraeDato("select IsNull(DESCRIP_TIPO_ACTIVO, '') from TIPOS_DE_ACTIVOS where CODIGO_TIPO_ACTIVO = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function Division(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(DESCRIPCION_DIVISION, '') from DIVISIONES where CODIGO_DIVISION = " & scm(codigo))) Then
            retorno = TraeDato("select IsNull(DESCRIPCION_DIVISION, '') from DIVISIONES where CODIGO_DIVISION = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function Proveedor(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(nombre_proveedor, '') from PROVEEDORES where CODIGO_PROVEEDOR = " & scm(codigo))) Then
            retorno = TraeDato("select IsNull(nombre_proveedor, '') from PROVEEDORES where CODIGO_PROVEEDOR = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function Categoria(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(CATEGORIA_DESC, '') from ACT_CATEGORIAS where CATEGORIA_ID = " & scm(codigo))) Then
            retorno = TraeDato("select IsNull(CATEGORIA_DESC, '') from ACT_CATEGORIAS where CATEGORIA_ID = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function Centros(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(DESCRIPCION, '') from CENTROS where CODIGO_CENTRO = " & scm(codigo))) Then
            retorno = TraeDato("select IsNull(DESCRIPCION, '') from CENTROS where CODIGO_CENTRO = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function CentroPorCatalogo(ByVal tipoCatalogo As String, ByVal codigoCentro As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(DESCRIPCION, '') from CENTROS where TIPO_CATALOGO = " & scm(tipoCatalogo) & " and CODIGO_CENTRO = " & scm(codigoCentro))) Then
            retorno = TraeDato("select IsNull(DESCRIPCION, '') from CENTROS where TIPO_CATALOGO = " & scm(tipoCatalogo) & " and CODIGO_CENTRO = " & scm(codigoCentro)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function Cuentas(ByVal tipoCatalogo As String, ByVal cuentaContable As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(DESCRIPCION, '') from CATALOGO_CONT_DET where TIPO_CATALOGO = " & scm(tipoCatalogo) & " and CUENTA_CONTABLE = " & scm(cuentaContable))) Then
            retorno = TraeDato("select IsNull(DESCRIPCION, '') from CATALOGO_CONT_DET where TIPO_CATALOGO = " & scm(tipoCatalogo) & " and CUENTA_CONTABLE = " & scm(cuentaContable)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function NombreCatalogoContable(ByVal tipoCatalogo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(NOMBRE_CATALOGO, '') from CATALOGO_CONT_ENC where TIPO_CATALOGO = " & scm(tipoCatalogo))) Then
            retorno = TraeDato("select IsNull(NOMBRE_CATALOGO, '') from CATALOGO_CONT_ENC where TIPO_CATALOGO = " & scm(tipoCatalogo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function Monedas(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(DESCRIPCION_MONEDA, '') from MONEDAS where CODIGO_DE_MONEDA = " & scm(codigo))) Then
            retorno = TraeDato("select IsNull(DESCRIPCION_MONEDA, '') from MONEDAS where CODIGO_DE_MONEDA = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function Marcas(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("Select IsNull(DESCRIPCION_MARCA, '') From MARCAS Where CODIGO_MARCA = " & scm(codigo))) Then
            retorno = TraeDato("Select IsNull(DESCRIPCION_MARCA, '') From MARCAS Where CODIGO_MARCA = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function UbicacionActivo(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("Select IsNull(DESCRIPCION_UBICACION, '') From UBICACION_ACTIVO Where CODIGO_UBICACION = " & scm(codigo))) Then
            retorno = TraeDato("Select IsNull(DESCRIPCION_UBICACION, '') From UBICACION_ACTIVO Where CODIGO_UBICACION = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function NombreUsualResponsable(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("Select IsNull(NOMBRE_USUAL, '') From ACT_RESPONSABLES Where RESPONSABLE_ID = " & scm(codigo))) Then
            retorno = TraeDato("Select IsNull(NOMBRE_USUAL, '') From ACT_RESPONSABLES Where RESPONSABLE_ID = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function DescripcionCortaActivo(ByVal codigoActivo As String, ByVal mejoraCorrelativo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(DESCRIP_CORTA_ACTIVO, '') from ACTIVOS_FIJOS where CODIGO_DE_ACTIVO = " & scm(codigoActivo) & " and MEJORA_CORRELATIVO = " & sen(mejoraCorrelativo))) Then
            retorno = TraeDato("select IsNull(DESCRIP_CORTA_ACTIVO, '') from ACTIVOS_FIJOS where CODIGO_DE_ACTIVO = " & scm(codigoActivo) & " and MEJORA_CORRELATIVO = " & sen(mejoraCorrelativo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function TipoDeActivoCodigoMoneda(ByVal codigo As String, ByVal mejoraCorrelativo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(CODIGO_DE_MONEDA, '') from ACTIVOS_FIJOS where CODIGO_DE_ACTIVO = " & scm(codigo) & " and MEJORA_CORRELATIVO = " & sen(mejoraCorrelativo))) Then
            retorno = TraeDato("select IsNull(CODIGO_DE_MONEDA, '') from ACTIVOS_FIJOS where CODIGO_DE_ACTIVO = " & scm(codigo) & " and MEJORA_CORRELATIVO = " & sen(mejoraCorrelativo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function TipoDeActivoTasaCambioCompra(ByVal codigo As String, ByVal mejoraCorrelativo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(TASA_CAMBIO_COMPRA, 0) from ACTIVOS_FIJOS where CODIGO_DE_ACTIVO = " & scm(codigo) & " and MEJORA_CORRELATIVO = " & sen(mejoraCorrelativo))) Then
            retorno = String.Format("{0:0.00000}", TraeDato("select IsNull(TASA_CAMBIO_COMPRA, 0) from ACTIVOS_FIJOS where CODIGO_DE_ACTIVO = " & scm(codigo) & " and MEJORA_CORRELATIVO = " & sen(mejoraCorrelativo)))
        End If

        Return retorno
    End Function

    Public Shared Function ParametrosGeneralesTipoDeCambio(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(TIPO_DE_CAMBIO, '') from PARAMETRO_GENERALES where COMPANIA = " & scm(codigo))) Then
            retorno = TraeDato("select IsNull(TIPO_DE_CAMBIO, '') from PARAMETRO_GENERALES where COMPANIA = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function ParametrosGeneralesCodigoMoneda(ByVal codigoCompania As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("Select IsNull(CODIGO_DE_MONEDA, '') From PARAMETRO_GENERALES Where compania = " & scm(codigoCompania))) Then
            retorno = TraeDato("Select IsNull(CODIGO_DE_MONEDA, '') From PARAMETRO_GENERALES Where compania = " & scm(codigoCompania)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function Impuesto(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("Select IsNull(DESCRIPCION_IMPUESTO, '') From IMPUESTOS Where CODIGO_IMPUESTO = " & scm(codigo))) Then
            retorno = TraeDato("Select IsNull(DESCRIPCION_IMPUESTO, '') From IMPUESTOS Where CODIGO_IMPUESTO = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function TipoPartida(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("Select IsNull(NOMBRE_TIPO, '') From TIPOS_PARTIDAS Where TIPO_PARTIDA = " & scm(codigo))) Then
            retorno = TraeDato("Select IsNull(NOMBRE_TIPO, '') From TIPOS_PARTIDAS Where TIPO_PARTIDA = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function RazonContable(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(Descripcion_razon, '') from RAZONCONT where Codigo_razon = " & scm(codigo))) Then
            retorno = TraeDato("select IsNull(Descripcion_razon, '') from RAZONCONT where Codigo_razon = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function TipoDeServicioDescripcion(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(DESCRIPCION_SERVICIO, '') from TIPOS_DE_SERVICIOS where TIPO_SERVICIO = " & scm(codigo))) Then
            retorno = TraeDato("select IsNull(DESCRIPCION_SERVICIO, '') from TIPOS_DE_SERVICIOS where TIPO_SERVICIO = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function TipoDeServicioClase(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(CLASE_DE_SERVICIO, '') from TIPOS_DE_SERVICIOS where TIPO_SERVICIO = " & scm(codigo))) Then
            retorno = TraeDato("select IsNull(CLASE_DE_SERVICIO, '') from TIPOS_DE_SERVICIOS where TIPO_SERVICIO = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function Puestos(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(DESCRIPCION_PUESTO, '') from PUESTOS where CODIGO_PUESTO = " & scm(codigo))) Then
            retorno = TraeDato("select IsNull(DESCRIPCION_PUESTO, '') from PUESTOS where CODIGO_PUESTO = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function EmpleadoTipo(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(DESCRIPCION_TIPO, '') from EMPLEADO_TIPO where TIPO_EMPLEADO = " & scm(codigo))) Then
            retorno = TraeDato("select IsNull(DESCRIPCION_TIPO, '') from EMPLEADO_TIPO where TIPO_EMPLEADO = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function NominaTipo(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(DESCRIPCION, '') from NOMINA_TIPO where CODIGO_TIPO = " & scm(codigo))) Then
            retorno = TraeDato("select IsNull(DESCRIPCION, '') from NOMINA_TIPO where CODIGO_TIPO = " & scm(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function UsuariosNombre(ByVal codigoNombrecorto As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(NOMBRE, '') from USUARIOS where NOMBRE_CORTO_ID = " & scm(codigoNombrecorto))) Then
            retorno = TraeDato("select IsNull(NOMBRE, '') from USUARIOS where NOMBRE_CORTO_ID = " & scm(codigoNombrecorto)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function TipoMovimientoClase(ByVal codigo As String) As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(CLASE_MOVIMIENTO, '') from TIPO_MOV_ACTIVOS where TIPO_MOVIMIENTO = " & sen(codigo))) Then
            retorno = TraeDato("select IsNull(CLASE_MOVIMIENTO, '') from TIPO_MOV_ACTIVOS where TIPO_MOVIMIENTO = " & sen(codigo)).ToString
        End If

        Return retorno
    End Function

    Public Shared Function CodigoActivoMinimo() As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(min(CODIGO_DE_ACTIVO), '') from ACTIVOS_FIJOS")) Then
            retorno = TraeDato("select IsNull(min(CODIGO_DE_ACTIVO), '') from ACTIVOS_FIJOS").ToString
        End If

        Return retorno
    End Function

    Public Shared Function CodigoActivoMaximo() As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(max(CODIGO_DE_ACTIVO), '') from ACTIVOS_FIJOS")) Then
            retorno = TraeDato("select IsNull(max(CODIGO_DE_ACTIVO), '') from ACTIVOS_FIJOS").ToString
        End If

        Return retorno
    End Function

    Public Shared Function CodigoTipoDeActivoMinimo() As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(min(CODIGO_TIPO_ACTIVO), '') from TIPOS_DE_ACTIVOS")) Then
            retorno = TraeDato("select IsNull(min(CODIGO_TIPO_ACTIVO), '') from TIPOS_DE_ACTIVOS").ToString
        End If

        Return retorno
    End Function

    Public Shared Function CodigoTipoDeActivoMaximo() As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(max(CODIGO_TIPO_ACTIVO), '') from TIPOS_DE_ACTIVOS")) Then
            retorno = TraeDato("select IsNull(max(CODIGO_TIPO_ACTIVO), '') from TIPOS_DE_ACTIVOS").ToString
        End If

        Return retorno
    End Function

    Public Shared Function CodigoDivisionMinimo() As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(min(CODIGO_DIVISION), '') from DIVISIONES")) Then
            retorno = TraeDato("select IsNull(min(CODIGO_DIVISION), '') from DIVISIONES").ToString
        End If

        Return retorno
    End Function

    Public Shared Function CodigoDivisionMaximo() As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(max(CODIGO_DIVISION), '') from DIVISIONES")) Then
            retorno = TraeDato("select IsNull(max(CODIGO_DIVISION), '') from DIVISIONES").ToString
        End If

        Return retorno
    End Function

    Public Shared Function CodigoProveedorMinimo() As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(min(CODIGO_PROVEEDOR), '') from PROVEEDORES")) Then
            retorno = TraeDato("select IsNull(min(CODIGO_PROVEEDOR), '') from PROVEEDORES").ToString
        End If

        Return retorno
    End Function

    Public Shared Function CodigoProveedorMaximo() As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(max(CODIGO_PROVEEDOR), '') from PROVEEDORES")) Then
            retorno = TraeDato("select IsNull(max(CODIGO_PROVEEDOR), '') from PROVEEDORES").ToString
        End If

        Return retorno
    End Function

    Public Shared Function CodigoCategoriaMinimo() As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(min(CATEGORIA_ID), '') from ACT_CATEGORIAS")) Then
            retorno = TraeDato("select IsNull(min(CATEGORIA_ID), '') from ACT_CATEGORIAS").ToString
        End If

        Return retorno
    End Function

    Public Shared Function CodigoCategoriaMaximo() As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(max(CATEGORIA_ID), '') from ACT_CATEGORIAS")) Then
            retorno = TraeDato("select IsNull(max(CATEGORIA_ID), '') from ACT_CATEGORIAS").ToString
        End If

        Return retorno
    End Function

    Public Shared Function TraeEmpresa() As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("Select db_name()")) Then
            retorno = TraeDato("Select db_name()").ToString
        End If

        Return retorno
    End Function

    ''' <summary>
    ''' No usar ya que devolvería el usuario con nuevo formato de SG.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Obsolete("No usar este método ya que devolvería el usuario con nuevo formato de SG.")>
    Public Shared Function TraeUsuario() As String
        Dim retorno As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("select suser_sname()")) Then
            retorno = TraeDato("select suser_sname()").ToString
        End If

        Return retorno
    End Function

    Public Shared Function TraeFechaHoy(ByVal format As String) As String
        Dim retorno As String = String.Empty

        If format.Trim.Length > 0 Then
            Select Case format
                Case "101"
                    If Not String.IsNullOrEmpty(TraeDato("select convert(varchar(10),getdate(),101)")) Then
                        retorno = TraeDato("select convert(varchar(10),getdate(),101)").ToString
                    End If

                Case "103"
                    If Not String.IsNullOrEmpty(TraeDato("select convert(varchar(10),getdate(),103)")) Then
                        retorno = TraeDato("select convert(varchar(10),getdate(),103)").ToString
                    End If

                Case "8"
                    If Not String.IsNullOrEmpty(TraeDato("select convert(varchar(8), getdate(), 8)")) Then
                        retorno = TraeDato("select convert(varchar(8), getdate(), 8)").ToString
                    End If
            End Select
        End If

        Return retorno
    End Function
End Class
