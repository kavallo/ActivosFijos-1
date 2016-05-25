Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Globalization
Imports Microsoft.Office.Interop
Imports Citi.Synergia.HelperClient

Public Class Reportes
    Public Enum ListadoReportes
        Catalogo_activos_fijos
        General_activos_fijos
        Informacion_general
        Reporte_de_movimientos
        Reporte_depreciaciones
        Toma_fisica_inventario
        Proyeccion_depreciaciones
        totalmente_depreciados
        Informacion_Tipos_de_Activos
        Activos_depreciados
        Informacion_general_Activos_Fijos
        Ficha_responsable
        Resultado_Toma
        Partidas_de_trabajo
        assetinfo
        Divisiones
        Monedas
        Tipos_activos_fijos
        Movimiento_Activos
        Proveedores
        Informacion_general_activo_fijo
    End Enum

#Region " [ GetDataSet ] "
    Private Shared Function GetDataSet(ByVal comando As String) As DataSet
        Dim oData As New Citi.Synergia.DB.SQL
        oData.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim dsRetorno As DataSet = New DataSet()

        Try
            dsRetorno = oData.GetDataSet(comando)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dsRetorno
    End Function

    Private Shared Function GetDataSet(ByVal comando As SqlClient.SqlCommand) As DataSet
        Dim oData As New Citi.Synergia.DB.SQL
        oData.ConexionSQL = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim dsRetorno As DataSet = New DataSet()

        Try
            dsRetorno = oData.GetDataSet(comando)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dsRetorno
    End Function
#End Region

#Region " [ Auxiliares ] "
    Private Shared Function QuitaComilla(ByVal texto As String) As String
        Dim retorno As String = String.Empty

        retorno = texto

        If retorno.StartsWith("'") Then
            retorno = texto.Substring(1, texto.Length - 2)
        End If

        Return retorno.Trim
    End Function

    Private Shared Function DevuelveDescripcionEstado(ByVal estado As String) As String
        Dim retorno As String = String.Empty

        Select Case estado
            Case "T"
                retorno = "ALL STATUS"
            Case "U"
                retorno = "ONLY ACTIVE"
            Case "P"
                retorno = "ONLY PENDING"
            Case "V"
                retorno = "ONLY SOLD"
            Case "D"
                retorno = "ONLY DISPOSED"
            Case "N"
                retorno = "DONATED ONLY"
        End Select

        Return retorno
    End Function

    Private Shared Function DevuelveEstado(ByVal estado As String, ByVal incluirEstado As Boolean) As String
        Dim retorno As String = String.Empty

        Select Case estado
            Case "U"
                If incluirEstado Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(72, "U-ACTIVE").Replace("A - ", "U-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(72, "ACTIVE").Replace("A - ", "").ToUpper
                End If
            Case "P"
                If incluirEstado Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(103, "P-PENDING").Replace("P - ", "P-").ToUpper
                Else
                    retorno = retorno = Synergia.Traductor.Idiomas.GetMensaje(103, "PENDING").Replace("P - ", "").ToUpper
                End If
            Case "V"
                If incluirEstado Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(105, "V-SOLD").Replace("V - ", "V-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(3566, "SOLD").ToUpper
                End If
            Case "D"
                If incluirEstado Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(104, "D-DISPOSED").Replace("D - ", "D-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(3567, "DISPOSED").ToUpper
                End If
            Case "N"
                If incluirEstado Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(106, "N-DONATED").Replace("N - ", "N-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(106, "DONATED").Replace("N - ", "").ToUpper
                End If
            Case "T"
                If incluirEstado Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(107, "T-ALL").Replace("T - ", "T-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(107, "ALL").Replace("T - ", "").ToUpper
                End If
        End Select

        Return retorno
    End Function

    Private Shared Function DevuelveTipoDepreciacion(ByVal tipo As String, ByVal incluirTipo As Boolean) As String
        Dim retorno As String = String.Empty

        Select Case tipo
            Case "L"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(51, "L-STRAIGHT LINE").Replace("L - ", "L-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(51, "STRAIGHT LINE").Replace("L - ", "").ToUpper
                End If
            Case "D"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(50, "D-DOUBLE DECLINING BALANCE").Replace("D - ", "D-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(50, "DOUBLE DECLINING BALANCE").Replace("D - ", "").ToUpper
                End If
            Case "S"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(52, "S-YEAR DIGITS' SUM").Replace("S - ", "S-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(52, "YEAR DIGITS' SUM").Replace("S - ", "").ToUpper
                End If
        End Select

        Return retorno
    End Function

    Private Shared Function DevuelveSiEsDepreciado(ByVal tipo As String, ByVal incluirTipo As Boolean) As String
        Dim retorno As String = String.Empty

        Select Case tipo
            Case "S"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(117, "S-IT IS DEPRECIABLE").Replace("S - ", "S-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(117, "IT IS DEPRECIABLE").Replace("S - ", "").ToUpper
                End If
            Case "N"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(16, "N-NOT DEPRECIABLE").Replace("N - ", "N-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(16, "NOT DEPRECIABLE").Replace("N - ", "").ToUpper
                End If
        End Select

        Return retorno
    End Function

    Private Shared Function DevuelveEstadoServicio(ByVal tipo As String, ByVal incluirTipo As Boolean) As String
        Dim retorno As String = String.Empty

        Select Case tipo
            Case "U"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(118, "U-USE").Replace("U - ", "U-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(118, "USE").Replace("U - ", "").ToUpper
                End If
            Case "M"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(119, "M-MAINTENANCE").Replace("M - ", "M-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(119, "MAINTENANCE").Replace("M - ", "").ToUpper
                End If
        End Select

        Return retorno
    End Function

    Private Shared Function DevuelveExcluye(ByVal excluye As String) As String
        Dim retorno As String = String.Empty

        Select Case excluye
            Case "0"
                retorno = "All the assets"
            Case "1"
                retorno = "Assets with current value"
            Case "2"
                retorno = "Assets without current value"
        End Select

        Return retorno
    End Function

    Private Shared Function DevuelveTipoMovimiento(ByVal tipo As String, ByVal incluirTipo As Boolean) As String
        Dim retorno As String = String.Empty

        Select Case tipo
            Case "0"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(107, "0-ALL").Replace("T - ", "0-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(107, "ALL").Replace("T - ", "").ToUpper
                End If
            Case "1"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(61, "1-ADD").Replace("A - ", "1-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(61, "ADD").Replace("A - ", "").ToUpper
                End If
            Case "A"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(61, "A-ADD").Replace("A - ", "A-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(61, "ADD").Replace("A - ", "").ToUpper
                End If
            Case "2"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(63, "2-DEPRECIATION").Replace("P - ", "2-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(63, "DEPRECIATION").Replace("P - ", "").ToUpper
                End If
            Case "P"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(63, "P-DEPRECIATION").Replace("P - ", "P-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(63, "DEPRECIATION").Replace("P - ", "").ToUpper
                End If
            Case "3"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(64, "3-REVALUATION").Replace("R - ", "3-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(64, "REVALUATION").Replace("R - ", "").ToUpper
                End If
            Case "R"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(64, "R-REVALUATION").Replace("R - ", "R-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(64, "REVALUATION").Replace("R - ", "").ToUpper
                End If
            Case "4"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(68, "4-MASIVE REVALUATION").Replace("G - ", "4-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(68, "MASIVE REVALUATION").Replace("G - ", "").ToUpper
                End If
            Case "G"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(68, "G-MASIVE REVALUATION").Replace("G - ", "G-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(68, "MASIVE REVALUATION").Replace("G - ", "").ToUpper
                End If
            Case "5"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(66, "5-ADJUSTMENT BY INCREASING ASSET VALUE").Replace("I - ", "5-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(66, "ADJUSTMENT BY INCREASING ASSET VALUE").Replace("I - ", "").ToUpper
                End If
            Case "I"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(66, "I-ADJUSTMENT BY INCREASING ASSET VALUE").Replace("I - ", "I-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(66, "ADJUSTMENT BY INCREASING ASSET VALUE").Replace("I - ", "").ToUpper
                End If
            Case "6"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(67, "6-ADJUSTMENT BY DECREASING ASSET VALUE").Replace("M - ", "6-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(67, "ADJUSTMENT BY DECREASING ASSET VALUE").Replace("M - ", "").ToUpper
                End If
            Case "M"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(67, "M-ADJUSTMENT BY DECREASING ASSET VALUE").Replace("M - ", "M-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(67, "ADJUSTMENT BY DECREASING ASSET VALUE").Replace("M - ", "").ToUpper
                End If
            Case "7"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(62, "7-DISPOSAL").Replace("D - ", "7-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(62, "DISPOSAL").Replace("D - ", "").ToUpper
                End If
            Case "D"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(62, "D-DISPOSAL").Replace("D - ", "D-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(62, "DISPOSAL").Replace("D - ", "").ToUpper
                End If
            Case "8"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(69, "8-DONATION").Replace("N - ", "8-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(69, "DONATION").Replace("N - ", "").ToUpper
                End If
            Case "N"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(69, "N-DONATION").Replace("N - ", "N-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(69, "DONATION").Replace("N - ", "").ToUpper
                End If
            Case "9"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(65, "9-SALE").Replace("V - ", "9-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(65, "SALE").Replace("V - ", "").ToUpper
                End If
            Case "V"
                If incluirTipo Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(65, "V-SALE").Replace("V - ", "V-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(65, "SALE").Replace("V - ", "").ToUpper
                End If
        End Select

        Return retorno
    End Function

    Private Shared Function DevuelveEstadoMovimiento(ByVal tipo As String, ByVal incluirEstado As Boolean) As String
        Dim retorno As String = String.Empty

        Select Case tipo
            Case "P"
                If incluirEstado Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(103, "P-PENDING").Replace("P - ", "P-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(103, "PENDING").Replace("P - ", "").ToUpper
                End If
            Case "T"
                If incluirEstado Then
                    retorno = "T-TRANSACTION"
                Else
                    retorno = "TRANSACTION"
                End If
        End Select

        Return retorno
    End Function

    Private Shared Function DevuelveEstadoPartida(ByVal tipo As String, ByVal incluirEstado As Boolean) As String
        Dim retorno As String = String.Empty

        Select Case tipo
            Case "A"
                If incluirEstado Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(179, "P-AUTHORIZED").Replace("A - ", "A-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(179, "AUTHORIZED").Replace("A - ", "").ToUpper
                End If
            Case "N"
                If incluirEstado Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(181, "N-ACCOUNTING NOT COMPLETED").Replace("N - ", "N-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(181, "ACCOUNTING NOT COMPLETED").Replace("N - ", "").ToUpper
                End If
            Case "S"
                If incluirEstado Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(182, "S-POSTED").Replace("S - ", "S-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(182, "POSTED").Replace("S - ", "").ToUpper
                End If
        End Select

        Return retorno
    End Function

    Private Shared Function DevuelveClaseContabilidad(ByVal tipo As String, ByVal incluirEstado As Boolean) As String
        Dim retorno As String = String.Empty

        Select Case tipo
            Case "A"
                If incluirEstado Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(53, "A-TAKE CENTER ASSET TYPE").Replace("A - ", "A-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(53, "TAKE CENTER ASSET TYPE").Replace("A - ", "").ToUpper
                End If
            Case "D"
                If incluirEstado Then
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(54, "D-TAKE CENTER DEPARTMENT").Replace("D - ", "D-").ToUpper
                Else
                    retorno = Synergia.Traductor.Idiomas.GetMensaje(54, "TAKE CENTER DEPARTMENT").Replace("D - ", "").ToUpper
                End If
        End Select

        Return retorno
    End Function
#End Region

#Region " [ Reportes ] "
    Public Shared Sub EjecutarReporte(ByVal reporte As ListadoReportes, ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Select Case reporte
            Case ListadoReportes.Catalogo_activos_fijos
                CatalogoActivosFijos(parametros, filtro)
            Case ListadoReportes.General_activos_fijos
                GeneralActivosFijos(parametros, filtro)
            Case ListadoReportes.Informacion_general
                InformacionGeneral(parametros, filtro)
            Case ListadoReportes.Reporte_de_movimientos
                ReporteDeMovimientos(parametros, filtro)
            Case ListadoReportes.Reporte_depreciaciones
                ReporteDepreciaciones(parametros, filtro)
            Case ListadoReportes.Toma_fisica_inventario
                TomaFisicaInventario(parametros, filtro)
            Case ListadoReportes.Proyeccion_depreciaciones
                ProyeccionDepreciaciones(parametros, filtro)
            Case ListadoReportes.totalmente_depreciados
                TotalmenteDepreciados(parametros, filtro)
            Case ListadoReportes.Informacion_Tipos_de_Activos
                InformacionTiposDeActivos(parametros, filtro)
            Case ListadoReportes.Activos_depreciados
                ActivosDepreciados(parametros, filtro)
            Case ListadoReportes.Informacion_general_Activos_Fijos
                InformacionGeneralActivosFijos(parametros, filtro)
            Case ListadoReportes.Ficha_responsable
                FichaResponsable(parametros, filtro)
            Case ListadoReportes.Resultado_Toma
                ResultadoToma(parametros, filtro)
            Case ListadoReportes.Partidas_de_trabajo
                PartidasDeTrabajo(parametros, filtro)
            Case ListadoReportes.assetinfo
                AssetInfo(parametros, filtro)
            Case ListadoReportes.Divisiones
                Divisiones(parametros, filtro)
            Case ListadoReportes.Monedas
                Monedas(parametros, filtro)
            Case ListadoReportes.Tipos_activos_fijos
                TiposActivosFijos(parametros, filtro)
            Case ListadoReportes.Movimiento_Activos
                MovimientoActivos(parametros, filtro)
            Case ListadoReportes.Proveedores
                Proveedores(parametros, filtro)
            Case ListadoReportes.Informacion_general_activo_fijo
                InformacionGeneralActivoFijo(parametros, filtro)
        End Select
    End Sub

    Private Shared Sub CatalogoActivosFijos(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT a.CODIGO_DE_ACTIVO")
            .Append("     , a.MEJORA_CORRELATIVO")
            .Append("     , a.DESCRIP_CORTA_ACTIVO")
            .Append("     , a.CODIGO_TIPO_ACTIVO")
            .Append("     , t.DESCRIP_TIPO_ACTIVO")
            .Append("     , a.CODIGO_DIVISION")
            .Append("     , d.DESCRIPCION_DIVISION")
            .Append("     , a.CODIGO_DE_MONEDA")
            .Append("     , m.DESCRIPCION_MONEDA")
            .Append("     , Convert(Varchar(10), a.FECHA_ADQUISICION, 103) As FECHA_ADQUISICION")
            .Append("     , IsNull(Convert(Varchar(10), a.FECHA_BAJA_ACTIVO, 103), '') As FECHA_BAJA_ACTIVO")   '--10
            .Append("     , a.ESTATUS")
            .Append("     , a.VALOR_NO_DEDUCIBLE")
            .Append("     , a.VALOR_ORIGINAL_ACTIV")
            .Append("     , a.VALOR_ACTUAL_ACTIVO")
            .Append("     , a.VALOR_RESCATE_ACTIVO")
            .Append("     , a.VALOR_ORIG_ACT_USADO")
            .Append("     , a.TIPO_DEPRECIACION")
            .Append("     , a.DEPRECIABLE")
            .Append("     , a.VALOR_DEP_ACUM_ACT")
            .Append("     , a.PORCENTAJE_ANUAL_DEP")        '--20 
            .Append("     , a.TASA_DEDUCIBLE_ISR")
            .Append("     , IsNull(Convert(Varchar(10), a.FECHA_ULTIMA_DEPREC, 103), '') As FECHA_ULTIMA_DEPREC")
            .Append("     , a.MONTO_ULTIMA_REVAL")
            .Append("     , IsNull(Convert(Varchar(10), a.FECHA_ULTIMA_REVAL, 103), '') As FECHA_ULTIMA_REVAL")
            .Append("     , a.MONTO_ULTIMA_DEPREC")
            .Append("     , a.TIEMPO_DEPRECIACION")
            .Append("     , a.TASA_CAMBIO_COMPRA")
            .Append("     , a.TASA_CAMBIO_ULT_REV")
            .Append("     , IsNull(Convert(Varchar(10), a.FECHA_ULT_INVENTARIO, 103), '') As FECHA_ULT_INVENTARIO")
            .Append("     , a.NO_ORDEN")                    '--30 
            .Append("     , IsNull(Convert(Varchar(10), a.FECHA_ULT_MANTMTO, 103), '') As FECHA_ULT_MANTMTO")
            .Append("     , a.COSTO_ACUM_MNTMTO")
            .Append("     , a.FRECUENCIA_MNTMTO")
            .Append("     , a.ESTADO_SERVICIO")
            .Append("     , g.DESCRIP_LARGA_UNO")
            .Append("     , g.DESCRIP_LARGA_DOS")
            .Append("     , g.DESCRIP_LARGA_TRES")
            .Append("     , s.DESCRIPCION_MARCA As MARCA")
            .Append("     , g.NUMERO_SERIE_ACTIVO")
            .Append("     , g.CHASIS_ACTIVO")               '--40 
            .Append("     , g.DESC_GARANTIA_1")
            .Append("     , g.DESC_GARANTIA_2")
            .Append("     , g.DESC_GARANTIA_3")
            .Append("     , g.DESC_GARANTIA_4")
            .Append("     , u.DESCRIPCION_UBICACION As UBICACION_ACTIVO")
            .Append("     , r.NOMBRE_USUAL + ' - ' + r.NOMBRE_RESPONSABLE + ' ' + r.APELLIDO_PATERNO As RESPONSABLE_ACTIVO")
            .Append("     , a.DESAPARECIDO")
            .Append("     , Convert(Varchar(10), getdate(), 103) As FechaActual")
            .Append("     , Convert(Varchar(10), getdate(), 108) As HoraActual")
            .Append("     , '" & Citi.Synergia.Locals.Cache.UsuarioSSO & "' As UsrEjecutor")                 '--50
            .Append("     , a.CODIGO_PROVEEDOR")
            .Append("     , p.nombre_proveedor")
            .Append("  FROM            ACTIVOS_FIJOS     a")
            .Append("  LEFT OUTER JOIN MONEDAS           m ON (a.CODIGO_DE_MONEDA = m.CODIGO_DE_MONEDA)")
            .Append("  LEFT OUTER JOIN TIPOS_DE_ACTIVOS  t ON (a.CODIGO_TIPO_ACTIVO = t.CODIGO_TIPO_ACTIVO)")
            .Append("  LEFT OUTER JOIN ACTIVOS_FIJOS_GEN g ON (a.CODIGO_DE_ACTIVO = g.CODIGO_DE_ACTIVO AND a.MEJORA_CORRELATIVO = g.MEJORA_CORRELATIVO)")
            .Append("  LEFT OUTER JOIN DIVISIONES        d ON (a.CODIGO_DIVISION = d.CODIGO_DIVISION)")
            .Append("  LEFT OUTER JOIN PROVEEDORES       p ON (a.CODIGO_PROVEEDOR = p.CODIGO_PROVEEDOR)")
            .Append("  LEFT OUTER JOIN UBICACION_ACTIVO  u ON (a.CODIGO_UBICACION = u.CODIGO_UBICACION)")
            .Append("  LEFT OUTER JOIN ACT_RESPONSABLES  r ON (a.RESPONSABLE_ID = r.RESPONSABLE_ID)")
            .Append("  LEFT OUTER JOIN MARCAS            s ON (a.CODIGO_MARCA = s.CODIGO_MARCA)")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If
            .Append(" ORDER BY a.CODIGO_DE_ACTIVO")
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CreaReporteCatalogoActivosFijos(data, parametros)
    End Sub

    Private Shared Sub CreaReporteCatalogoActivosFijos(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 15
                    oExcel.Cells(linea, 1).ColumnWidth = 25
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 3

                    Dim columnaCuadro As Excel.Range
                    Dim totalColumnas As Integer = 6

                    oExcel.Cells(linea, 1) = Synergia.Traductor.Idiomas.GetMensaje(268, "FIXED ASSETS' CATALOG").ToUpper
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 16
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea += 2
                    Dim lineaAux As Integer = linea
                    oExcel.Cells(lineaAux, 2).Font.Bold = True
                    oExcel.Cells(lineaAux, 2).font.Size = 12
                    oExcel.Cells(lineaAux, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(lineaAux, 2) = "FROM ASSET:"
                    oExcel.Cells(lineaAux, 4).Font.Bold = True
                    oExcel.Cells(lineaAux, 4).font.Size = 12
                    oExcel.Cells(lineaAux, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(lineaAux, 4) = "TO ASSET:"
                    lineaAux = lineaAux + 1
                    oExcel.Cells(lineaAux, 2).Font.Bold = True
                    oExcel.Cells(lineaAux, 2).font.Size = 12
                    oExcel.Cells(lineaAux, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(lineaAux, 2) = "FROM DEPARTMENT:"
                    oExcel.Cells(lineaAux, 4).Font.Bold = True
                    oExcel.Cells(lineaAux, 4).font.Size = 12
                    oExcel.Cells(lineaAux, 4).ColumnWidth = 18
                    oExcel.Cells(lineaAux, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(lineaAux, 4) = "TO DEPARTMENT:"
                    lineaAux = lineaAux + 1
                    oExcel.Cells(lineaAux, 2).Font.Bold = True
                    oExcel.Cells(lineaAux, 2).font.Size = 12
                    oExcel.Cells(lineaAux, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(lineaAux, 2) = "FROM ASSET TYPE:"
                    oExcel.Cells(lineaAux, 4).Font.Bold = True
                    oExcel.Cells(lineaAux, 4).font.Size = 12
                    oExcel.Cells(lineaAux, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(lineaAux, 4) = "TO ASSET TYPE:"
                    If Citi.Synergia.Locals.Cache.ProveedoresInvisibles = False Then
                        lineaAux = lineaAux + 1
                        oExcel.Cells(lineaAux, 2).Font.Bold = True
                        oExcel.Cells(lineaAux, 2).font.Size = 12
                        oExcel.Cells(lineaAux, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(lineaAux, 2) = "FROM VENDOR:"
                        oExcel.Cells(lineaAux, 4).Font.Bold = True
                        oExcel.Cells(lineaAux, 4).font.Size = 12
                        oExcel.Cells(lineaAux, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(lineaAux, 4) = "TO VENDOR:"
                    End If
                    lineaAux = lineaAux + 2
                    oExcel.Cells(lineaAux, 3).Font.Bold = True
                    oExcel.Cells(lineaAux, 3).font.Size = 12
                    oExcel.Cells(lineaAux, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(lineaAux, 3) = "STATUS INCLUDED:"
                    lineaAux = lineaAux + 1
                    oExcel.Cells(lineaAux, 3).Font.Bold = True
                    oExcel.Cells(lineaAux, 3).font.Size = 12
                    oExcel.Cells(lineaAux, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(lineaAux, 3) = "ONLY MISSING:"

                    '-- Los parámetros vienen en orden código activo, division, tipo activo, proveedor, estado y sólo desaparecido
                    For i As Integer = 0 To parametros.Count - 1
                        Select Case i
                            Case 0, 2, 4 '-- Iniciales de: Código activo, division, tipo activo
                                oExcel.Cells(linea, 3).font.Size = 11
                                oExcel.Cells(linea, 3).ColumnWidth = 19
                                oExcel.Cells(linea, 3).NumberFormat = "@"
                                oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                                oExcel.Cells(linea, 3) = QuitaComilla(parametros.Item(i))
                            Case 1, 3, 5 '-- Finales de: Código activo, division, tipo activo
                                oExcel.Cells(linea, 5).font.Size = 11
                                oExcel.Cells(linea, 5).NumberFormat = "@"
                                oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                                oExcel.Cells(linea, 5) = QuitaComilla(parametros.Item(i))
                                linea = linea + 1
                            Case 6   '-- Proveedor inicial
                                If Citi.Synergia.Locals.Cache.ProveedoresInvisibles = False Then
                                    oExcel.Cells(linea, 3).font.Size = 11
                                    oExcel.Cells(linea, 3).NumberFormat = "@"
                                    oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                                    oExcel.Cells(linea, 3) = QuitaComilla(parametros.Item(i))
                                End If
                            Case 7   '-- Proveedor final
                                If Citi.Synergia.Locals.Cache.ProveedoresInvisibles = False Then
                                    oExcel.Cells(linea, 5).font.Size = 11
                                    oExcel.Cells(linea, 5).NumberFormat = "@"
                                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                                    oExcel.Cells(linea, 5) = QuitaComilla(parametros.Item(i))
                                    linea = linea + 1
                                End If
                            Case 8  '-- estado
                                linea = linea + 1
                                oExcel.Cells(linea, 4).font.Size = 11
                                oExcel.Cells(linea, 4).NumberFormat = "@"
                                oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                                oExcel.Cells(linea, 4) = DevuelveDescripcionEstado(QuitaComilla(parametros.Item(i)))
                            Case 9
                                linea = linea + 1
                                oExcel.Cells(linea, 4).font.Size = 11
                                oExcel.Cells(linea, 4).NumberFormat = "@"
                                oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                                oExcel.Cells(linea, 4) = QuitaComilla(parametros.Item(i))
                        End Select
                    Next

                    linea = linea + 2

                    '-- Títulos de las columnas 
                    For Each filaData As DataRow In data.Tables(0).Rows
                        Dim lineaInicial As Integer = linea

                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = Synergia.Traductor.Idiomas.GetMensaje(92, "ASSET ID").ToUpper
                        oExcel.Cells(linea, 2) = filaData.Item("CODIGO_DE_ACTIVO").ToString
                        If Not filaData.IsNull("DESAPARECIDO") Then
                            If filaData.Item("DESAPARECIDO").ToString = "S" Then
                                oExcel.Cells(linea, 3) = "** (MISSING)"
                            End If
                        End If
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = Synergia.Traductor.Idiomas.GetMensaje(115, "UPGRADE").ToUpper
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("MEJORA_CORRELATIVO").ToString
                        oExcel.Cells(linea, 3) = filaData.Item("DESCRIP_CORTA_ACTIVO").ToString

                        '-- Dibujo un cuadro
                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                        linea = linea + 1
                        lineaInicial = linea

                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "ASSET TYPE:"
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("CODIGO_TIPO_ACTIVO").ToString
                        oExcel.Cells(linea, 3) = filaData.Item("DESCRIP_TIPO_ACTIVO").ToString
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = Synergia.Traductor.Idiomas.GetMensaje(39, "DEPARTMENT").ToUpper + ":"
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("CODIGO_DIVISION").ToString
                        oExcel.Cells(linea, 3) = filaData.Item("DESCRIPCION_DIVISION").ToString
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = Synergia.Traductor.Idiomas.GetMensaje(40, "CURRENCY").ToUpper + ":"
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("CODIGO_DE_MONEDA").ToString
                        oExcel.Cells(linea, 3) = filaData.Item("DESCRIPCION_MONEDA").ToString
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "ACQUISITION DATE:"
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("FECHA_ADQUISICION").ToString
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5) = Synergia.Traductor.Idiomas.GetMensaje(37, "STATUS").ToUpper + ":"
                        oExcel.Cells(linea, 5).NumberFormat = "@"
                        oExcel.Cells(linea, 6) = DevuelveEstado(filaData.Item("ESTATUS").ToString, True)
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "DELETE DATE:"
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("FECHA_BAJA_ACTIVO").ToString
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5) = "NOT DEDUCTABLE VALUE:"
                        oExcel.Cells(linea, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 6) = filaData.Item("VALOR_NO_DEDUCIBLE").ToString
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = Synergia.Traductor.Idiomas.GetMensaje(121, "ORIGINAL VALUE").ToUpper + ":"
                        oExcel.Cells(linea, 2).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 2) = filaData.Item("VALOR_ORIGINAL_ACTIV").ToString
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5) = "CURRENT VALUE:"
                        oExcel.Cells(linea, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 6) = filaData.Item("VALOR_ACTUAL_ACTIVO").ToString
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "RESIDUAL VALUE:"
                        oExcel.Cells(linea, 2).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 2) = filaData.Item("VALOR_RESCATE_ACTIVO").ToString
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5) = "ORIGINAL PURCHASE VALUE:"
                        oExcel.Cells(linea, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 6) = filaData.Item("VALOR_ORIG_ACT_USADO").ToString
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = Synergia.Traductor.Idiomas.GetMensaje(114, "DEPRECIATION TYPE").ToUpper + ":"
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = DevuelveTipoDepreciacion(filaData.Item("TIPO_DEPRECIACION").ToString, True)
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5) = "DEPRECIABLE:"
                        oExcel.Cells(linea, 6).ColumnWidth = 25
                        oExcel.Cells(linea, 6).NumberFormat = "@"
                        oExcel.Cells(linea, 6) = DevuelveSiEsDepreciado(filaData.Item("DEPRECIABLE").ToString, True)
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "DEPRECIATION VALUE:"
                        oExcel.Cells(linea, 2).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 2) = filaData.Item("VALOR_DEP_ACUM_ACT").ToString
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5) = "ANNUAL DEPRECIATION %:"
                        oExcel.Cells(linea, 6).NumberFormat = "###,###,##0.00000;[Red](###,###,##0.00000)"
                        oExcel.Cells(linea, 6) = filaData.Item("PORCENTAJE_ANUAL_DEP").ToString
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "DEPRECIATION MONTHS:"
                        oExcel.Cells(linea, 2).NumberFormat = "###,###,##0;[Red](###,###,##0)"
                        oExcel.Cells(linea, 2) = filaData.Item("TIEMPO_DEPRECIACION").ToString
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5) = "INCOME TAX DECT. RATE %:"
                        oExcel.Cells(linea, 6).NumberFormat = "###,###,##0.00000;[Red](###,###,##0.00000)"
                        oExcel.Cells(linea, 6) = filaData.Item("TASA_DEDUCIBLE_ISR").ToString
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "LAST DEPRECIATION DATE:"
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("FECHA_ULTIMA_DEPREC").ToString
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5).ColumnWidth = 24
                        oExcel.Cells(linea, 5) = "LAST DEPRECIATION AMOUNT:"
                        oExcel.Cells(linea, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 6) = filaData.Item("MONTO_ULTIMA_DEPREC").ToString
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "LAST REVALUATION DATE:"
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("FECHA_ULTIMA_REVAL").ToString
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5) = "LAST REVALUATION AMOUNT:"
                        oExcel.Cells(linea, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 6) = filaData.Item("MONTO_ULTIMA_REVAL").ToString
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "PURCHASE RATE:"
                        oExcel.Cells(linea, 2).NumberFormat = "###,###,##0.000000;[Red](###,###,##0.000000)"
                        oExcel.Cells(linea, 2) = filaData.Item("TASA_CAMBIO_COMPRA").ToString
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5) = "LAST REVALUATION RATE:"
                        oExcel.Cells(linea, 6).NumberFormat = "###,###,##0.000000;[Red](###,###,##0.000000)"
                        oExcel.Cells(linea, 6) = filaData.Item("TASA_CAMBIO_ULT_REV").ToString
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "LAST INVENTORY DATE:"
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("FECHA_ULT_INVENTARIO").ToString
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5) = "PURCHASE ORDER:"
                        oExcel.Cells(linea, 6).NumberFormat = "###,###,##0;[Red](###,###,##0)"
                        oExcel.Cells(linea, 6) = filaData.Item("NO_ORDEN").ToString
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "LAST MAINTENANCE DATE:"
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("FECHA_ULT_MANTMTO").ToString
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5) = "MAINTENANCE COST:"
                        oExcel.Cells(linea, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 6) = filaData.Item("COSTO_ACUM_MNTMTO").ToString
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True

                        oExcel.Cells(linea, 1) = "MNTNMT. FREQUENCY (DAYS):"
                        oExcel.Cells(linea, 2).NumberFormat = "###,###,##0;[Red](###,###,##0)"
                        oExcel.Cells(linea, 2) = filaData.Item("FRECUENCIA_MNTMTO").ToString
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5) = "SERVICE STATUS:"
                        oExcel.Cells(linea, 6).NumberFormat = "@"
                        oExcel.Cells(linea, 6) = DevuelveEstadoServicio(filaData.Item("ESTADO_SERVICIO").ToString, True)
                        linea = linea + 2
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "***  GENERAL INFORMATION  ***"
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = Synergia.Traductor.Idiomas.GetMensaje(3299, "DESCRIPTION:").ToUpper
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("DESCRIP_LARGA_UNO").ToString + filaData.Item("DESCRIP_LARGA_DOS").ToString + filaData.Item("DESCRIP_LARGA_TRES").ToString
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "BRAND:"
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("MARCA").ToString
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "SERIES NUMBER:"
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("NUMERO_SERIE_ACTIVO").ToString
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5) = "CHASSIS NUMBER:"
                        oExcel.Cells(linea, 6).NumberFormat = "@"
                        oExcel.Cells(linea, 6) = filaData.Item("CHASIS_ACTIVO").ToString
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "WARRANTY:"
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("DESC_GARANTIA_1").ToString + filaData.Item("DESC_GARANTIA_2").ToString + filaData.Item("DESC_GARANTIA_3").ToString + filaData.Item("DESC_GARANTIA_4").ToString
                        linea = linea + 1
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "LOCATION:"
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("UBICACION_ACTIVO").ToString
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5) = "RESPONSIBLE:"
                        oExcel.Cells(linea, 6).NumberFormat = "@"
                        oExcel.Cells(linea, 6) = filaData.Item("RESPONSABLE_ACTIVO").ToString

                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                        Dim rangoColumnas As Excel.Range = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea, totalColumnas))
                        rangoColumnas.Font.Size = 10

                        '-- Cambio de activo
                        linea = linea + 3

                        oExcel.Cells(1, totalColumnas).font.Size = 9
                        oExcel.Cells(1, totalColumnas).NumberFormat = "@"
                        oExcel.Cells(1, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(1, totalColumnas) = filaData.Item("FechaActual").ToString
                        oExcel.Cells(2, totalColumnas).font.Size = 9
                        oExcel.Cells(2, totalColumnas).NumberFormat = "@"
                        oExcel.Cells(2, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(2, totalColumnas) = filaData.Item("HoraActual").ToString
                        oExcel.Cells(2, 1).font.Size = 9
                        oExcel.Cells(2, 1).NumberFormat = "@"
                        oExcel.Cells(2, 1) = filaData.Item("UsrEjecutor").ToString
                    Next

                    oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 6) = "*** QUANTITY OF ASSETS: " + data.Tables(0).Rows.Count.ToString + " ***"
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub GeneralActivosFijos(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT a.CODIGO_DE_ACTIVO")
            .Append("     , a.MEJORA_CORRELATIVO")
            .Append("     , a.DESCRIP_CORTA_ACTIVO")
            .Append("     , Convert(Varchar(10), a.FECHA_ADQUISICION, 103) As FECHA_ADQUISICION")
            .Append("     , a.NO_ORDEN")
            .Append("     , a.PORCENTAJE_ANUAL_DEP")
            .Append("     , t.DESCRIP_TIPO_ACTIVO")
            .Append("     , a.ESTATUS")
            .Append("     , a.CODIGO_TIPO_ACTIVO")
            .Append("     , a.CODIGO_DIVISION")
            .Append("     , r.VALOR_ORIGINAL_ACTIV")
            .Append("     , r.VALOR_DEP_ACUM_ACT")
            .Append("     , r.VALOR_ACTUAL_ACTIVO")
            .Append("     , d.DESCRIPCION_DIVISION")
            .Append("     , r.USUARIO")
            .Append("     , r.EXCLUYE")
            .Append("     , Convert(Varchar(10), getdate(), 103) As FechaActual")
            .Append("     , Convert(Varchar(10), getdate(), 108) As HoraActual")
            .Append("     , '" & Citi.Synergia.Locals.Cache.UsuarioSSO & "' As UsrEjecutor")
            .Append("     , a.CODIGO_PROVEEDOR")
            .Append("     , p.nombre_proveedor")
            .Append("  FROM            ACTIVOS_FIJOS           a")
            .Append("  LEFT OUTER JOIN PROVEEDORES             p ON (a.CODIGO_PROVEEDOR = p.CODIGO_PROVEEDOR)")
            .Append("  INNER JOIN      TIPOS_DE_ACTIVOS        t ON (a.CODIGO_TIPO_ACTIVO = t.CODIGO_TIPO_ACTIVO)")
            .Append("  LEFT OUTER JOIN RPT_ACTIVO_DEPRECIACION r ON (a.CODIGO_DE_ACTIVO = r.CODIGO_DE_ACTIVO  AND a.MEJORA_CORRELATIVO = r.MEJORA_CORRELATIVO)")
            .Append("  INNER JOIN      DIVISIONES              d ON (a.CODIGO_DIVISION = d.CODIGO_DIVISION)")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CreaReporteGeneralActivosFijos(data, parametros)
    End Sub

    Private Shared Sub CreaReporteGeneralActivosFijos(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 3

                    Dim columnaCuadro As Excel.Range
                    Dim totalColumnas As Integer = 11

                    oExcel.Cells(linea, 1) = "ASSET TYPES' GENERAL REPORT"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 16
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea += 2

                    '-- Los parámetros vienen en orden: título clasificación, tipo activo inicial, tipo activo final, division inicial, division final, estado, excluye, clasificado por
                    oExcel.Cells(linea, 1) = parametros.Item(0)
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 12
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea += 2

                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 12
                    oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 4) = "FROM ASSET TYPE:"
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5).NumberFormat = "@"
                    oExcel.Cells(linea, 5) = QuitaComilla(parametros.Item(1))
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 12
                    oExcel.Cells(linea, 6) = "TO ASSET TYPE:"
                    oExcel.Cells(linea, 7).font.Size = 11
                    oExcel.Cells(linea, 7).NumberFormat = "@"
                    oExcel.Cells(linea, 7) = QuitaComilla(parametros.Item(2))

                    linea = linea + 1

                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 12
                    oExcel.Cells(linea, 4).ColumnWidth = 21
                    oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 4) = "FROM DEPARTMENT:"
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5).NumberFormat = "@"
                    oExcel.Cells(linea, 5) = QuitaComilla(parametros.Item(3))
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 12
                    oExcel.Cells(linea, 6).ColumnWidth = 18
                    oExcel.Cells(linea, 6) = "TO DEPARTMENT:"
                    oExcel.Cells(linea, 7).font.Size = 11
                    oExcel.Cells(linea, 7).NumberFormat = "@"
                    oExcel.Cells(linea, 7) = QuitaComilla(parametros.Item(4))

                    linea = linea + 1

                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 12
                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 5) = "Assets' Status:"
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).NumberFormat = "@"
                    oExcel.Cells(linea, 6) = DevuelveEstado(QuitaComilla(parametros.Item(5)), False)

                    Dim ordenamiento As String = String.Empty
                    If parametros.Item(7) = "T" Then
                        ordenamiento = "Asset type "
                    Else
                        ordenamiento = "Department "
                    End If

                    linea = linea + 1

                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 12
                    oExcel.Cells(linea, 5).ColumnWidth = 16
                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 5) = "Assets included:"
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).NumberFormat = "@"
                    oExcel.Cells(linea, 6) = DevuelveExcluye(QuitaComilla(parametros.Item(6)))

                    linea = linea + 2

                    '-- Títulos de las columnas
                    oExcel.Cells(linea, 8).NumberFormat = "@"
                    oExcel.Cells(linea, 8) = "+--------------------- TO DATE: " + parametros.Item(8) + " ---------------------+"

                    linea = linea + 1

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).ColumnWidth = 14
                    oExcel.Cells(linea, 1) = Synergia.Traductor.Idiomas.GetMensaje(3086, "ASSET").ToUpper
                    oExcel.Cells(linea, 3).Font.Bold = True
                    oExcel.Cells(linea, 3).ColumnWidth = 30
                    oExcel.Cells(linea, 3) = Synergia.Traductor.Idiomas.GetMensaje(12, "DESCRIPTION").ToUpper
                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).ColumnWidth = 30
                    If parametros.Item(7) = "T" Then
                        oExcel.Cells(linea, 4) = Synergia.Traductor.Idiomas.GetMensaje(3071, "DEPARTMENT").ToUpper
                    Else
                        oExcel.Cells(linea, 4) = "ASSET TYPE"
                    End If
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5) = "ACQUISITION DATE"
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).ColumnWidth = 17
                    oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 6) = Synergia.Traductor.Idiomas.GetMensaje(3316, "PURCHASE ORDER").Replace(":", "").ToUpper
                    oExcel.Cells(linea, 7).Font.Bold = True
                    oExcel.Cells(linea, 7).ColumnWidth = 9
                    oExcel.Cells(linea, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 7) = "DEPRE. %"
                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).ColumnWidth = 16
                    oExcel.Cells(linea, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 8) = "ORIGINAL VALUE"
                    oExcel.Cells(linea, 9).Font.Bold = True
                    oExcel.Cells(linea, 9).ColumnWidth = 19
                    oExcel.Cells(linea, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 9) = "DEPRECIATED VALUE"
                    oExcel.Cells(linea, 10).Font.Bold = True
                    oExcel.Cells(linea, 10).ColumnWidth = 16
                    oExcel.Cells(linea, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 10) = "CURRENT VALUE"
                    oExcel.Cells(linea, 11).Font.Bold = True
                    oExcel.Cells(linea, 11).ColumnWidth = 14
                    oExcel.Cells(linea, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 11) = "ASSET STATUS"

                    linea = linea + 1

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1) = Synergia.Traductor.Idiomas.GetMensaje(92, "ASSET ID").ToUpper

                    '-- Dibujo un cuadro
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea - 2, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    Dim lineaInicial As Integer = linea

                    Dim llaveAnterior As String = String.Empty
                    Dim llaveActual As String = String.Empty
                    Dim primerVez As Boolean = True
                    Dim escribirTipo As Boolean = True
                    Dim entro As Boolean = False

                    Dim leyendaCantidad As String = String.Empty

                    Dim totalOrginalGeneral As Decimal = 0
                    Dim totalOriginalActivo As Decimal = 0
                    Dim totalDepreciadoGeneral As Decimal = 0
                    Dim totalDepreciadoActivo As Decimal = 0
                    Dim totalActualGeneral As Decimal = 0
                    Dim totalActualActivo As Decimal = 0

                    Dim contador As Integer = 0

                    For Each filaData As DataRow In data.Tables(0).Rows
                        contador = contador + 1

                        If parametros.Item(7) = "T" Then
                            llaveActual = filaData.Item("CODIGO_TIPO_ACTIVO").ToString
                        Else
                            llaveActual = filaData.Item("CODIGO_DIVISION").ToString
                        End If

                        If llaveActual <> llaveAnterior Then
                            llaveAnterior = llaveActual
                            If primerVez = False Then
                                '-- Cambio de activo
                                linea = linea + 3
                            End If
                            primerVez = False

                            If escribirTipo = False Then
                                oExcel.Cells(linea - 2, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                                oExcel.Cells(linea - 2, 7).Font.Bold = True
                                oExcel.Cells(linea - 2, 7) = leyendaCantidad.Trim + ": " + contador.ToString

                                If totalOriginalActivo <> 0 Then
                                    oExcel.Cells(linea - 2, 8).Font.Bold = True
                                    oExcel.Cells(linea - 2, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - 2, 8) = totalOriginalActivo
                                End If

                                If totalDepreciadoActivo <> 0 Then
                                    oExcel.Cells(linea - 2, 9).Font.Bold = True
                                    oExcel.Cells(linea - 2, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - 2, 9) = totalDepreciadoActivo
                                End If

                                If totalActualActivo <> 0 Then
                                    oExcel.Cells(linea - 2, 10).Font.Bold = True
                                    oExcel.Cells(linea - 2, 10).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - 2, 10) = totalActualActivo
                                End If

                                totalOriginalActivo = 0
                                totalDepreciadoActivo = 0
                                totalActualActivo = 0
                            End If

                            entro = True

                            escribirTipo = True
                        End If

                        If escribirTipo Then
                            oExcel.Cells(linea, 1).Font.Bold = True
                            If parametros.Item(7) = "T" Then
                                oExcel.Cells(linea, 1) = "Asset type: " + filaData.Item("CODIGO_TIPO_ACTIVO").ToString + " - " + filaData.Item("DESCRIP_TIPO_ACTIVO").ToString
                                leyendaCantidad = "Quantity of assets by " + ordenamiento + filaData.Item("CODIGO_TIPO_ACTIVO").ToString + " - " + filaData.Item("DESCRIP_TIPO_ACTIVO").ToString
                            Else
                                oExcel.Cells(linea, 1) = "Department: " + filaData.Item("CODIGO_DIVISION").ToString + " - " + filaData.Item("DESCRIPCION_DIVISION").ToString
                                leyendaCantidad = "Quantity of assets by " + ordenamiento + filaData.Item("CODIGO_DIVISION").ToString + " - " + filaData.Item("DESCRIPCION_DIVISION").ToString
                            End If

                            contador = 0

                            escribirTipo = False
                        End If

                        linea = linea + 1
                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = filaData.Item("CODIGO_DE_ACTIVO").ToString
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 2) = filaData.Item("MEJORA_CORRELATIVO").ToString
                        oExcel.Cells(linea, 3) = filaData.Item("DESCRIP_CORTA_ACTIVO").ToString
                        oExcel.Cells(linea, 4).NumberFormat = "@"
                        If parametros.Item(7) = "T" Then
                            oExcel.Cells(linea, 4) = filaData.Item("CODIGO_DIVISION").ToString + " - " + filaData.Item("DESCRIPCION_DIVISION").ToString
                        Else
                            oExcel.Cells(linea, 4) = filaData.Item("CODIGO_TIPO_ACTIVO").ToString + " - " + filaData.Item("DESCRIP_TIPO_ACTIVO").ToString
                        End If
                        oExcel.Cells(linea, 5).NumberFormat = "@"
                        oExcel.Cells(linea, 5) = filaData.Item("FECHA_ADQUISICION").ToString
                        oExcel.Cells(linea, 6).NumberFormat = "###,###,##0;[Red](###,###,##0)"
                        oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 6) = filaData.Item("NO_ORDEN").ToString
                        oExcel.Cells(linea, 7).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 7) = filaData.Item("PORCENTAJE_ANUAL_DEP").ToString
                        oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 8) = filaData.Item("VALOR_ORIGINAL_ACTIV").ToString
                        If filaData.IsNull("VALOR_ORIGINAL_ACTIV") = False Then
                            totalOriginalActivo = totalOriginalActivo + filaData.Item("VALOR_ORIGINAL_ACTIV")
                            totalOrginalGeneral = totalOrginalGeneral + filaData.Item("VALOR_ORIGINAL_ACTIV")
                        End If
                        oExcel.Cells(linea, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 9) = filaData.Item("VALOR_DEP_ACUM_ACT").ToString
                        If filaData.IsNull("VALOR_DEP_ACUM_ACT") = False Then
                            totalDepreciadoActivo = totalDepreciadoActivo + filaData.Item("VALOR_DEP_ACUM_ACT")
                            totalDepreciadoGeneral = totalDepreciadoGeneral + filaData.Item("VALOR_DEP_ACUM_ACT")
                        End If
                        oExcel.Cells(linea, 10).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 10) = filaData.Item("VALOR_ACTUAL_ACTIVO").ToString
                        If filaData.IsNull("VALOR_ACTUAL_ACTIVO") = False Then
                            totalActualActivo = totalActualActivo + filaData.Item("VALOR_ACTUAL_ACTIVO")
                            totalActualGeneral = totalActualGeneral + filaData.Item("VALOR_ACTUAL_ACTIVO")
                        End If
                        oExcel.Cells(linea, 11).NumberFormat = "@"
                        oExcel.Cells(linea, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 11) = DevuelveEstado(filaData.Item("ESTATUS").ToString, True)

                        oExcel.Cells(1, 11).font.Size = 9
                        oExcel.Cells(1, 11).NumberFormat = "@"
                        oExcel.Cells(1, 11) = filaData.Item("FechaActual").ToString
                        oExcel.Cells(2, 11).font.Size = 9
                        oExcel.Cells(2, 11).NumberFormat = "@"
                        oExcel.Cells(2, 11) = filaData.Item("HoraActual").ToString
                        oExcel.Cells(2, 1).font.Size = 9
                        oExcel.Cells(2, 1).NumberFormat = "@"
                        oExcel.Cells(2, 1) = filaData.Item("UsrEjecutor").ToString
                    Next

                    linea = linea + 1

                    If entro Then
                        contador = contador + 1

                        oExcel.Cells(linea, 7).font.Size = 10
                        oExcel.Cells(linea, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 7).Font.Bold = True
                        oExcel.Cells(linea, 7) = leyendaCantidad.Trim + ": " + contador.ToString

                        If totalOriginalActivo <> 0 Then
                            oExcel.Cells(linea, 8).Font.Bold = True
                            oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                            oExcel.Cells(linea, 8) = totalOriginalActivo
                        End If

                        If totalDepreciadoActivo <> 0 Then
                            oExcel.Cells(linea, 9).Font.Bold = True
                            oExcel.Cells(linea, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                            oExcel.Cells(linea, 9) = totalDepreciadoActivo
                        End If

                        If totalActualActivo <> 0 Then
                            oExcel.Cells(linea, 10).Font.Bold = True
                            oExcel.Cells(linea, 10).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                            oExcel.Cells(linea, 10) = totalActualActivo
                        End If
                    End If

                    Dim rangoColumnas As Excel.Range = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea, totalColumnas))
                    rangoColumnas.Font.Size = 10

                    linea = linea + 3

                    oExcel.Cells(linea, 7).font.Size = 10
                    oExcel.Cells(linea, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 7).Font.Bold = True
                    oExcel.Cells(linea, 7) = "Overall total:"
                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 8) = totalOrginalGeneral
                    oExcel.Cells(linea, 9).Font.Bold = True
                    oExcel.Cells(linea, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 9) = totalDepreciadoGeneral
                    oExcel.Cells(linea, 10).Font.Bold = True
                    oExcel.Cells(linea, 10).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 10) = totalActualGeneral
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub InformacionGeneral(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT a.MEJORA_CORRELATIVO")
            .Append("     , a.DESCRIP_CORTA_ACTIVO")
            .Append("     , Convert(Varchar(10), a.FECHA_ADQUISICION, 103) As FECHA_ADQUISICION")
            .Append("     , a.TIPO_DEPRECIACION")
            .Append("     , a.ESTATUS")
            .Append("     , m.DESCRIPCION_MARCA As MARCA")
            .Append("     , g.NUMERO_SERIE_ACTIVO")
            .Append("     , g.MODELO_DEL_ACTIVO")
            .Append("     , g.CHASIS_ACTIVO")
            .Append("     , u.DESCRIPCION_UBICACION As UBICACION_ACTIVO")
            .Append("     , r.NOMBRE_USUAL + ' - ' + r.NOMBRE_RESPONSABLE + ' ' + r.APELLIDO_PATERNO As RESPONSABLE_ACTIVO")
            .Append("     , d.DESCRIPCION_DIVISION")
            .Append("     , a.CODIGO_DIVISION")
            .Append("     , a.CODIGO_DE_ACTIVO")
            .Append("     , a.CODIGO_TIPO_ACTIVO")
            .Append("     , Convert(Varchar(10), getdate(), 103) As FechaActual")
            .Append("     , Convert(Varchar(10), getdate(), 108) As HoraActual")
            .Append("     , '" & Citi.Synergia.Locals.Cache.UsuarioSSO & "' As UsrEjecutor")
            .Append("     , a.CODIGO_PROVEEDOR")
            .Append("  FROM            ACTIVOS_FIJOS     a")
            .Append("  LEFT OUTER JOIN ACTIVOS_FIJOS_GEN g ON (a.CODIGO_DE_ACTIVO = g.CODIGO_DE_ACTIVO AND a.MEJORA_CORRELATIVO = g.MEJORA_CORRELATIVO)")
            .Append("  LEFT OUTER JOIN DIVISIONES        d ON (a.CODIGO_DIVISION = d.CODIGO_DIVISION)")
            .Append("  LEFT OUTER JOIN MARCAS            m ON (a.CODIGO_MARCA = m.CODIGO_MARCA)")
            .Append("  LEFT OUTER JOIN UBICACION_ACTIVO  u ON (a.CODIGO_UBICACION = u.CODIGO_UBICACION)")
            .Append("  LEFT OUTER JOIN ACT_RESPONSABLES  r ON (a.RESPONSABLE_ID = r.RESPONSABLE_ID)")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If

            .Append(" ORDER BY a.CODIGO_DIVISION, a.CODIGO_DE_ACTIVO")
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CrearInformacionGeneral(data, parametros)
    End Sub

    Private Shared Sub CrearInformacionGeneral(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 3

                    Dim totalColumnas As Integer = 9
                    Dim columnaCuadro As Excel.Range

                    oExcel.Cells(linea, 1) = "FIXED ASSTES' GENERAL INFORMATION"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 16
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea += 2

                    '-- Los parámetros vienen en orden: codigo activo inicial, codigo activo final, tipo activo inicial, tipo activo final, division inicial, division final, proveedor inicial, proveedor final
                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 12
                    oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 4) = "FROM ASSET:"
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5).ColumnWidth = 15
                    oExcel.Cells(linea, 5).NumberFormat = "@"
                    oExcel.Cells(linea, 5) = QuitaComilla(parametros.Item(0))
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 12
                    oExcel.Cells(linea, 6) = "TO ASSET:"
                    oExcel.Cells(linea, 7).ColumnWidth = 15
                    oExcel.Cells(linea, 7).font.Size = 11
                    oExcel.Cells(linea, 7).NumberFormat = "@"
                    oExcel.Cells(linea, 7) = QuitaComilla(parametros.Item(1))

                    linea = linea + 1

                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 12
                    oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 4) = "FROM ASSET TYPE:"
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5).NumberFormat = "@"
                    oExcel.Cells(linea, 5) = QuitaComilla(parametros.Item(2))
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 12
                    oExcel.Cells(linea, 6) = "TO ASSET TYPE:"
                    oExcel.Cells(linea, 7).font.Size = 11
                    oExcel.Cells(linea, 7).NumberFormat = "@"
                    oExcel.Cells(linea, 7) = QuitaComilla(parametros.Item(3))

                    linea = linea + 1

                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 12
                    oExcel.Cells(linea, 4).ColumnWidth = 21
                    oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 4) = "FROM DEPARTMENT:"
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5).NumberFormat = "@"
                    oExcel.Cells(linea, 5) = QuitaComilla(parametros.Item(4))
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 12
                    oExcel.Cells(linea, 6).ColumnWidth = 18
                    oExcel.Cells(linea, 6) = "TO DEPARTMENT:"
                    oExcel.Cells(linea, 7).font.Size = 11
                    oExcel.Cells(linea, 7).NumberFormat = "@"
                    oExcel.Cells(linea, 7) = QuitaComilla(parametros.Item(5))

                    If Citi.Synergia.Locals.Cache.ProveedoresInvisibles = False Then
                        linea = linea + 1
                        oExcel.Cells(linea, 4).Font.Bold = True
                        oExcel.Cells(linea, 4).font.Size = 12
                        oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 4) = "FROM VENDOR:"
                        oExcel.Cells(linea, 5).font.Size = 11
                        oExcel.Cells(linea, 5).NumberFormat = "@"
                        oExcel.Cells(linea, 5) = QuitaComilla(parametros.Item(6))
                        oExcel.Cells(linea, 6).Font.Bold = True
                        oExcel.Cells(linea, 6).font.Size = 12
                        oExcel.Cells(linea, 6) = "TO VENDOR:"
                        oExcel.Cells(linea, 7).font.Size = 11
                        oExcel.Cells(linea, 7).NumberFormat = "@"
                        oExcel.Cells(linea, 7) = QuitaComilla(parametros.Item(7))
                    End If

                    linea = linea + 2

                    Dim lineaInicial As Integer = linea

                    '-- Primer filtro: departamento
                    Dim llaveAnterior As String = String.Empty
                    Dim llaveActual As String = String.Empty
                    Dim primerVez As Boolean = True
                    Dim escribirTipo As Boolean = True
                    Dim entro As Boolean = False

                    '-- Segundo filtro: código de activo
                    Dim tranAnterior As String = String.Empty
                    Dim tranActual As String = String.Empty
                    Dim primerTran As Boolean = True
                    Dim escribirTran As Boolean = True
                    Dim cambioActivo As Boolean = False

                    Dim leyendaInterna As String = String.Empty
                    Dim leyendaExterna As String = String.Empty

                    Dim contadorInterno As Integer = 0
                    Dim contadorExterno As Integer = 0
                    Dim contadorGeneral As Integer = 0

                    Dim lineaAux As Integer = linea
                    Dim lineaDepartamento As Integer = 0

                    For Each filaData As DataRow In data.Tables(0).Rows
                        cambioActivo = False

                        llaveActual = filaData.Item("CODIGO_DIVISION").ToString
                        tranActual = filaData.Item("CODIGO_DE_ACTIVO").ToString

                        If llaveActual <> llaveAnterior Then
                            llaveAnterior = llaveActual
                            If primerVez = False Then
                                '-- Cambio de activo
                                linea = linea + 5
                            End If
                            primerVez = False

                            If escribirTipo = False Then
                                linea = linea - 1
                                oExcel.Cells(linea - 3, 1).Font.Size = 11
                                oExcel.Cells(linea - 3, 1).Font.Bold = True
                                oExcel.Cells(linea - 3, 1) = leyendaExterna.Trim + ": " + contadorExterno.ToString

                                '-- Dibujo un cuadro
                                columnaCuadro = oExcel.Range(oExcel.Cells(lineaDepartamento, 1), oExcel.Cells(linea - 4, totalColumnas))
                                columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                                contadorGeneral = contadorGeneral + contadorExterno

                                contadorExterno = 0
                            End If

                            entro = True

                            cambioActivo = True

                            escribirTipo = True

                            tranAnterior = String.Empty
                        End If

                        If escribirTipo Then
                            oExcel.Cells(linea, 1).font.Size = 11
                            oExcel.Cells(linea, 1).Font.Bold = True
                            oExcel.Cells(linea, 1).ColumnWidth = 13
                            oExcel.Cells(linea, 1) = Synergia.Traductor.Idiomas.GetMensaje(3071, "DEPARTMENT").ToUpper
                            oExcel.Cells(linea, 2).font.Size = 11
                            oExcel.Cells(linea, 2).Font.Bold = True
                            oExcel.Cells(linea, 2) = filaData.Item("CODIGO_DIVISION").ToString + " - " + filaData.Item("DESCRIPCION_DIVISION").ToString

                            '-- Dibujo un cuadro
                            columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                            columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                            lineaDepartamento = linea + 1

                            escribirTipo = False
                        End If

                        If tranActual <> tranAnterior Then
                            tranAnterior = tranActual
                            If primerTran = False And cambioActivo = False Then
                                '-- Cambia de transacción
                                linea = linea + 3
                            End If

                            primerTran = False

                            If escribirTran = False Then
                                linea = linea - 1
                                If cambioActivo = False Then
                                    oExcel.Cells(linea - 2, 2).Font.Bold = True
                                    oExcel.Cells(linea - 2, 2).font.Size = 9
                                    oExcel.Cells(linea - 2, 2) = leyendaInterna + ": " + contadorInterno.ToString

                                    '-- Dibujo un cuadro
                                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 1), oExcel.Cells(linea - 3, totalColumnas))
                                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                                Else
                                    linea = linea + 1
                                    oExcel.Cells(linea - 4, 2).Font.Bold = True
                                    oExcel.Cells(linea - 4, 2).font.Size = 9
                                    oExcel.Cells(linea - 4, 2) = leyendaInterna + ": " + contadorInterno.ToString

                                    '-- Dibujo un cuadro
                                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 1), oExcel.Cells(linea - 5, totalColumnas))
                                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                                End If

                                contadorInterno = 0
                            End If

                            escribirTran = True
                        End If

                        If escribirTran Then
                            linea = linea + 1

                            oExcel.Cells(linea, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            oExcel.Cells(linea, 1) = "UPGRADE"
                            oExcel.Cells(linea, 2).ColumnWidth = 30
                            oExcel.Cells(linea, 2) = Synergia.Traductor.Idiomas.GetMensaje(12, "DESCRIPTION").ToUpper()
                            oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            oExcel.Cells(linea, 3) = "ACQUISITION"
                            oExcel.Cells(linea, 4).ColumnWidth = 16
                            oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            oExcel.Cells(linea, 4) = "DEPRECIATION TYPE"
                            oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            oExcel.Cells(linea, 5) = "STATUS"
                            oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            oExcel.Cells(linea, 6) = "BRAND"
                            oExcel.Cells(linea, 7).ColumnWidth = 23
                            oExcel.Cells(linea, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            oExcel.Cells(linea, 7) = "SERIAL NUMBER / CHASSIS"
                            oExcel.Cells(linea, 8).ColumnWidth = 13
                            oExcel.Cells(linea, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            oExcel.Cells(linea, 8) = "MODEL"
                            oExcel.Cells(linea, 9).ColumnWidth = 50
                            oExcel.Cells(linea, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            oExcel.Cells(linea, 9) = "LOCATION / RESPONSIBLE"

                            '-- Dibujo un cuadro
                            columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                            columnaCuadro.Font.Size = 10
                            columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                            escribirTran = False

                            lineaAux = linea + 1
                        End If

                        leyendaInterna = "Quantity of assets by asset type " + filaData.Item("CODIGO_DE_ACTIVO").ToString
                        leyendaExterna = "Quantity of assets by department " + filaData.Item("CODIGO_DIVISION").ToString

                        linea = linea + 1

                        'lineaAux = linea

                        oExcel.Cells(linea, 1).NumberFormat = "###,###,##0;[Red](###,###,##0)"
                        oExcel.Cells(linea, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 1) = filaData.Item("MEJORA_CORRELATIVO").ToString
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("DESCRIP_CORTA_ACTIVO").ToString
                        oExcel.Cells(linea, 3).NumberFormat = "@"
                        oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 3) = filaData.Item("FECHA_ADQUISICION").ToString
                        oExcel.Cells(linea, 4).NumberFormat = "@"
                        oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 4) = DevuelveTipoDepreciacion(filaData.Item("TIPO_DEPRECIACION").ToString, True)
                        oExcel.Cells(linea, 5).NumberFormat = "@"
                        oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 5) = DevuelveEstado(filaData.Item("ESTATUS").ToString, True)
                        oExcel.Cells(linea, 6).NumberFormat = "@"
                        oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 6) = filaData.Item("MARCA").ToString
                        oExcel.Cells(linea, 7).NumberFormat = "@"
                        oExcel.Cells(linea, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 7) = filaData.Item("NUMERO_SERIE_ACTIVO").ToString + " / " + filaData.Item("CHASIS_ACTIVO").ToString
                        oExcel.Cells(linea, 8).NumberFormat = "@"
                        oExcel.Cells(linea, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 8) = filaData.Item("MODELO_DEL_ACTIVO").ToString
                        oExcel.Cells(linea, 9).NumberFormat = "@"
                        oExcel.Cells(linea, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 9) = filaData.Item("UBICACION_ACTIVO").ToString + " / " + filaData.Item("RESPONSABLE_ACTIVO").ToString

                        linea = linea + 1
                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = "ASSET ID: " + filaData.Item("CODIGO_DE_ACTIVO").ToString + " - " + filaData.Item("DESCRIP_CORTA_ACTIVO").ToString

                        contadorInterno = contadorInterno + 1
                        contadorExterno = contadorExterno + 1

                        linea = linea + 1

                        Dim rangoColumnas As Excel.Range = oExcel.Range(oExcel.Cells(lineaAux, 1), oExcel.Cells(linea, totalColumnas))
                        rangoColumnas.Font.Size = 9

                        oExcel.Cells(1, 9).font.Size = 9
                        oExcel.Cells(1, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(1, 9).NumberFormat = "@"
                        oExcel.Cells(1, 9) = filaData.Item("FechaActual").ToString
                        oExcel.Cells(2, 9).font.Size = 9
                        oExcel.Cells(2, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(2, 9).NumberFormat = "@"
                        oExcel.Cells(2, 9) = filaData.Item("HoraActual").ToString
                        oExcel.Cells(2, 1).font.Size = 9
                        oExcel.Cells(2, 1).NumberFormat = "@"
                        oExcel.Cells(2, 1) = filaData.Item("UsrEjecutor").ToString
                    Next

                    If entro Then
                        oExcel.Cells(linea, 2).Font.Bold = True
                        oExcel.Cells(linea, 2).font.Size = 9
                        oExcel.Cells(linea, 2) = leyendaInterna + ": " + contadorInterno.ToString

                        '-- Dibujo un cuadro
                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 1), oExcel.Cells(linea - 1, totalColumnas))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                        linea = linea + 1

                        oExcel.Cells(linea, 1).Font.Size = 11
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = leyendaExterna.Trim + ": " + contadorExterno.ToString

                        '-- Dibujo un cuadro
                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaDepartamento, 1), oExcel.Cells(linea - 1, totalColumnas))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    End If
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub ReporteDeMovimientos(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT a.CODIGO_DE_ACTIVO")
            .Append("     , a.MEJORA_CORRELATIVO")
            .Append("     , a.DESCRIP_CORTA_ACTIVO")
            .Append("     , t.TIPO_MOVIMIENTO")
            .Append("     , t.DESCRIPCION_TIP_MOV")
            .Append("     , m.CORRELATIVO_MOVIM")
            .Append("     , Convert(Varchar(10), m.FECHA_MOVIMIENTO, 103) As FECHA_MOVIMIENTO")
            .Append("     , m.OBSERVACIONES1")
            .Append("     , m.MONTO_DE_MOVIMIENTO")
            .Append("     , m.TASA_CAMBIO_MOV")
            .Append("     , m.VALOR_NO_DEDUCIBLE")
            .Append("     , m.PORCENTAJE_DEPREC")
            .Append("     , m.PERIODOS_DEPRECIADOS")
            .Append("     , m.ESTADO_MOVIMIENTO")
            .Append("     , m.OBSERVACIONES2")
            .Append("     , m.CODIGO_DE_ACTIVO")
            .Append("     , m.MEJORA_CORRELATIVO")
            .Append("     , m.TIPO_MOVIMIENTO")
            .Append("     , Convert(Varchar(10), getdate(), 103) As FechaActual")
            .Append("     , Convert(Varchar(10), getdate(), 108) As HoraActual")
            .Append("     , '" & Citi.Synergia.Locals.Cache.UsuarioSSO & "' As UsrEjecutor")
            .Append("  FROM       MOVIM_ACTIVOS    m")
            .Append("  INNER JOIN ACTIVOS_FIJOS    a ON (m.CODIGO_DE_ACTIVO = a.CODIGO_DE_ACTIVO AND m.MEJORA_CORRELATIVO = a.MEJORA_CORRELATIVO)")
            .Append("  INNER JOIN TIPO_MOV_ACTIVOS t ON (m.TIPO_MOVIMIENTO = t.TIPO_MOVIMIENTO)")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If

            .Append(" ORDER BY a.CODIGO_DE_ACTIVO, a.MEJORA_CORRELATIVO, t.TIPO_MOVIMIENTO, m.CODIGO_DE_ACTIVO, m.MEJORA_CORRELATIVO, m.TIPO_MOVIMIENTO, m.CORRELATIVO_MOVIM, m.FECHA_MOVIMIENTO")
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CrearReporteDeMovimientos(data, parametros)
    End Sub

    Private Shared Sub CrearReporteDeMovimientos(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 3

                    Dim totalColumnas As Integer = 10
                    Dim columnaCuadro As Excel.Range

                    oExcel.Cells(linea, 1) = "TRANSACTIONS' REPORT"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 16
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea += 2

                    oExcel.Cells(linea, 1) = "REPORT EXPRESSED IN LOCAL CURRENCY"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 12
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea += 2

                    '-- Los parámetros vienen en orden: codigo activo inicial, codigo activo final, fecha inicio, fecha fin, tipo movimiento, titulo movimiento
                    oExcel.Cells(linea, 3).Font.Bold = True
                    oExcel.Cells(linea, 3).Font.Size = 12
                    oExcel.Cells(linea, 3).ColumnWidth = 13
                    oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 3) = "FROM ASSET:"
                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4).NumberFormat = "@"
                    oExcel.Cells(linea, 4).ColumnWidth = 15
                    oExcel.Cells(linea, 4) = QuitaComilla(parametros.Item(0))
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 12
                    oExcel.Cells(linea, 5).ColumnWidth = 10
                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 5) = "TO ASSET:"
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).NumberFormat = "@"
                    oExcel.Cells(linea, 6) = QuitaComilla(parametros.Item(1))

                    linea = linea + 1

                    oExcel.Cells(linea, 3).Font.Bold = True
                    oExcel.Cells(linea, 3).font.Size = 12
                    oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 3) = "FROM:"
                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4).NumberFormat = "@"
                    oExcel.Cells(linea, 4) = QuitaComilla(parametros.Item(2))
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 12
                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 5) = "TO:"
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).NumberFormat = "@"
                    oExcel.Cells(linea, 6) = QuitaComilla(parametros.Item(3))

                    linea = linea + 1

                    oExcel.Cells(linea, 1) = "Transaction type: " + DevuelveTipoMovimiento(QuitaComilla(parametros.Item(4)), False)
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 12
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea = linea + 2

                    '-- Títulos de las columnas
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).ColumnWidth = 17
                    oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 6) = "NOT DEDUCTABLE"
                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).ColumnWidth = 16
                    oExcel.Cells(linea, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 8) = "DEPRECIATION"
                    oExcel.Cells(linea, 9).Font.Bold = True
                    oExcel.Cells(linea, 9).ColumnWidth = 16
                    oExcel.Cells(linea, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 9) = "DEPRECIATED"

                    linea = linea + 1

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1) = "NUMBER"
                    oExcel.Cells(linea, 2).Font.Bold = True
                    oExcel.Cells(linea, 2) = "DATE"
                    oExcel.Cells(linea, 3).Font.Bold = True
                    oExcel.Cells(linea, 3).ColumnWidth = 50
                    oExcel.Cells(linea, 3) = "OBSERVATIONS"
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).ColumnWidth = 15
                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 5) = "AMOUNT"
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 6) = "VALUE"
                    oExcel.Cells(linea, 7).Font.Bold = True
                    oExcel.Cells(linea, 7).ColumnWidth = 16
                    oExcel.Cells(linea, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 7) = "EXCHANGE RATE"
                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 8) = "PERCENTAGE"
                    oExcel.Cells(linea, 9).Font.Bold = True
                    oExcel.Cells(linea, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 9) = "PERIODS"
                    oExcel.Cells(linea, 10).Font.Bold = True
                    oExcel.Cells(linea, 10).ColumnWidth = 16
                    oExcel.Cells(linea, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 10) = "STATUS"

                    '-- Dibujo un cuadro
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea - 1, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    Dim lineaInicial As Integer = linea

                    Dim llaveAnterior As String = String.Empty
                    Dim llaveActual As String = String.Empty
                    Dim primerVez As Boolean = True
                    Dim escribirTipo As Boolean = True
                    Dim entro As Boolean = False

                    Dim tranAnterior As String = String.Empty
                    Dim tranActual As String = String.Empty
                    Dim primerTran As Boolean = True
                    Dim escribirTran As Boolean = True
                    Dim cambioActivo As Boolean = False

                    Dim totalMontoTransaccion As Decimal = 0
                    Dim totalMontoMejora As Decimal = 0
                    Dim totalMonto As Decimal = 0
                    Dim totalNoDeducibleTransaccion As Decimal = 0
                    Dim totalNoDeducibleMejora As Decimal = 0
                    Dim totalNoDeducible As Decimal = 0

                    Dim lineaAux As Integer = 1

                    For Each filaData As DataRow In data.Tables(0).Rows
                        cambioActivo = False

                        llaveActual = filaData.Item("CODIGO_DE_ACTIVO").ToString + "-" + filaData.Item("MEJORA_CORRELATIVO").ToString

                        If llaveActual <> llaveAnterior Then
                            llaveAnterior = llaveActual
                            If primerVez = False Then
                                '-- Cambio de activo
                                linea = linea + 7
                            End If
                            primerVez = False

                            If escribirTipo = False Then
                                oExcel.Cells(linea - 3, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                                oExcel.Cells(linea - 3, 4).Font.Bold = True
                                oExcel.Cells(linea - 3, 4) = "TOTAL BY UPGRADE:"

                                oExcel.Cells(linea - 3, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 5) = totalMontoMejora
                                oExcel.Cells(linea - 3, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 6) = totalNoDeducibleMejora

                                columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 1), oExcel.Cells(linea - 3, totalColumnas))
                                columnaCuadro.Font.Size = 9
                                columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                                totalMonto = totalMonto + totalMontoMejora
                                totalNoDeducible = totalNoDeducible + totalNoDeducibleMejora

                                totalMontoMejora = 0
                                totalNoDeducibleMejora = 0
                            End If

                            entro = True

                            cambioActivo = True

                            escribirTipo = True
                        End If

                        If escribirTipo Then
                            oExcel.Cells(linea, 1).Font.Bold = True
                            oExcel.Cells(linea, 1) = "FIXED ASSET:"
                            oExcel.Cells(linea, 2).Font.Bold = True
                            oExcel.Cells(linea, 2).ColumnWidth = 15
                            oExcel.Cells(linea, 2) = filaData.Item("CODIGO_DE_ACTIVO").ToString
                            linea = linea + 1
                            oExcel.Cells(linea, 1).Font.Bold = True
                            oExcel.Cells(linea, 1) = "UPGRADE:"
                            oExcel.Cells(linea, 2).Font.Bold = True
                            oExcel.Cells(linea, 2) = filaData.Item("MEJORA_CORRELATIVO").ToString
                            oExcel.Cells(linea, 3) = filaData.Item("DESCRIP_CORTA_ACTIVO").ToString

                            columnaCuadro = oExcel.Range(oExcel.Cells(linea - 1, 1), oExcel.Cells(linea, totalColumnas))
                            columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                            escribirTipo = False
                        End If

                        tranActual = filaData.Item("CODIGO_DE_ACTIVO").ToString + "-" + filaData.Item("TIPO_MOVIMIENTO").ToString

                        If tranActual <> tranAnterior Then
                            tranAnterior = tranActual
                            If primerTran = False And cambioActivo = False Then
                                '-- Cambia de transacción
                                linea = linea + 3

                                columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 1), oExcel.Cells(linea, totalColumnas))
                                columnaCuadro.Font.Size = 9
                                columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                            End If

                            primerTran = False

                            If escribirTran = False Then
                                If cambioActivo = False Then
                                    oExcel.Cells(linea - 1, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                                    oExcel.Cells(linea - 1, 4).Font.Bold = True
                                    oExcel.Cells(linea - 1, 4) = "TOTAL BY TRANSACTION:"
                                    oExcel.Cells(linea - 1, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - 1, 5) = totalMontoTransaccion
                                    oExcel.Cells(linea - 1, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - 1, 6) = totalNoDeducibleTransaccion
                                Else
                                    oExcel.Cells(linea - 6, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                                    oExcel.Cells(linea - 6, 4).Font.Bold = True
                                    oExcel.Cells(linea - 6, 4) = "TOTAL BY TRANSACTION:"
                                    oExcel.Cells(linea - 6, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - 6, 5) = totalMontoTransaccion
                                    oExcel.Cells(linea - 6, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - 6, 6) = totalNoDeducibleTransaccion
                                End If

                                totalMontoTransaccion = 0
                                totalNoDeducibleTransaccion = 0
                            End If

                            escribirTran = True
                        End If

                        If escribirTran Then
                            linea = linea + 1

                            lineaAux = linea

                            oExcel.Cells(linea, 1).ColumnWidth = 14
                            oExcel.Cells(linea, 1) = "TRANSACTION: "
                            oExcel.Cells(linea, 2).NumberFormat = "@"
                            oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            oExcel.Cells(linea, 2) = filaData.Item("TIPO_MOVIMIENTO").ToString
                            oExcel.Cells(linea, 3).NumberFormat = "@"
                            oExcel.Cells(linea, 3) = filaData.Item("DESCRIPCION_TIP_MOV").ToString

                            escribirTran = False
                        End If

                        linea = linea + 1

                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 1) = filaData.Item("CORRELATIVO_MOVIM").ToString
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("FECHA_MOVIMIENTO").ToString
                        oExcel.Cells(linea, 3).NumberFormat = "@"
                        oExcel.Cells(linea, 3) = filaData.Item("OBSERVACIONES1").ToString

                        Dim montoMovimiento As Decimal = 0
                        Dim tasaCambioMovimiento As Decimal = 0

                        If filaData.IsNull("MONTO_DE_MOVIMIENTO") = False Then
                            montoMovimiento = filaData.Item("MONTO_DE_MOVIMIENTO")
                        End If
                        If filaData.IsNull("TASA_CAMBIO_MOV") = False Then
                            tasaCambioMovimiento = filaData.Item("TASA_CAMBIO_MOV")
                        End If
                        oExcel.Cells(linea, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 5) = montoMovimiento * tasaCambioMovimiento

                        totalMontoMejora = totalMontoMejora + (montoMovimiento * tasaCambioMovimiento)
                        totalMontoTransaccion = totalMontoTransaccion + (montoMovimiento * tasaCambioMovimiento)

                        oExcel.Cells(linea, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 6) = filaData.Item("VALOR_NO_DEDUCIBLE").ToString

                        If filaData.IsNull("VALOR_NO_DEDUCIBLE") = False Then
                            totalNoDeducibleMejora = totalNoDeducibleMejora + filaData.Item("VALOR_NO_DEDUCIBLE")
                            totalNoDeducibleTransaccion = totalNoDeducibleTransaccion + filaData.Item("VALOR_NO_DEDUCIBLE")
                        End If

                        oExcel.Cells(linea, 7).NumberFormat = "###,###,##0.000000;[Red](###,###,##0.000000)"
                        oExcel.Cells(linea, 7) = tasaCambioMovimiento
                        oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.000000;[Red](###,###,##0.000000)"
                        oExcel.Cells(linea, 8) = filaData.Item("PORCENTAJE_DEPREC").ToString
                        oExcel.Cells(linea, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 9).NumberFormat = "###,###,##0;[Red](###,###,##0)"
                        oExcel.Cells(linea, 9) = filaData.Item("PERIODOS_DEPRECIADOS").ToString
                        oExcel.Cells(linea, 10).NumberFormat = "@"
                        oExcel.Cells(linea, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 10) = DevuelveEstadoMovimiento(filaData.Item("ESTADO_MOVIMIENTO").ToString, True)


                        oExcel.Cells(1, totalColumnas).font.Size = 9
                        oExcel.Cells(1, totalColumnas).NumberFormat = "@"
                        oExcel.Cells(1, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(1, totalColumnas) = filaData.Item("FechaActual").ToString
                        oExcel.Cells(2, totalColumnas).font.Size = 9
                        oExcel.Cells(2, totalColumnas).NumberFormat = "@"
                        oExcel.Cells(2, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(2, totalColumnas) = filaData.Item("HoraActual").ToString
                        oExcel.Cells(2, 1).font.Size = 9
                        oExcel.Cells(2, 1).NumberFormat = "@"
                        oExcel.Cells(2, 1) = filaData.Item("UsrEjecutor").ToString
                    Next

                    linea = linea + 4

                    If entro Then
                        oExcel.Cells(linea - 2, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea - 2, 4).Font.Bold = True
                        oExcel.Cells(linea - 2, 4) = "TOTAL BY TRANSACTION:"
                        oExcel.Cells(linea - 2, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea - 2, 5) = totalMontoTransaccion
                        oExcel.Cells(linea - 2, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea - 2, 6) = totalNoDeducibleTransaccion

                        oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 4).Font.Bold = True
                        oExcel.Cells(linea, 4) = "TOTAL BY UPGRADE:"
                        oExcel.Cells(linea, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 5) = totalMontoMejora
                        oExcel.Cells(linea, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 6) = totalNoDeducibleMejora

                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 1), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.Font.Size = 9
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                        totalMonto = totalMonto + totalMontoMejora
                        totalNoDeducible = totalNoDeducible + totalNoDeducibleMejora
                    End If

                    linea = linea + 2

                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4) = "Overall total:"
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 5) = totalMonto
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 6) = totalNoDeducible
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub ReporteDepreciaciones(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT t.CODIGO_TIPO_ACTIVO")
            .Append("     , t.DESCRIP_TIPO_ACTIVO")
            .Append("     , d.CODIGO_DIVISION")
            .Append("     , d.DESCRIPCION_DIVISION")
            .Append("     , t.CTA_ACTIVO")
            .Append("     , t.CTA_DEPREC_ACUM")
            .Append("     , t.CTA_GASTO_DEPREC")
            .Append("     , c.DESCRIPCION")
            .Append("     , c2.DESCRIPCION As DESCRIPCION_DEPREC_ACUM")
            .Append("     , c3.DESCRIPCION As DESCRIPCION_GASTO_DEPREC")
            .Append("     , a.CODIGO_DE_ACTIVO")
            .Append("     , a.MEJORA_CORRELATIVO")
            .Append("     , a.DESCRIP_CORTA_ACTIVO")
            .Append("     , Convert(Varchar(10), a.FECHA_ADQUISICION, 103) As FECHA_ADQUISICION")
            .Append("     , r.VALOR_ORIGINAL_ACTIV")
            .Append("     , r.MONTO_REVALUAC_ACT")
            .Append("     , a.VALOR_NO_DEDUCIBLE")
            .Append("     , a.VALOR_RESCATE_ACTIVO")
            .Append("     , r.MOVIMIENTO_PORC")
            .Append("     , r.MOVIMIENTO_PER_DEP")
            .Append("     , a.TIPO_DEPRECIACION")
            .Append("     , a.ESTATUS")
            .Append("     , r.VALOR_DEP_ACUM_ACT")
            .Append("     , r.MOVIMIENTO_VAL_NO_DED")
            .Append("     , r.MOVIMIENTO_ANUAL_DEP")
            .Append("     , r.MOVIMIENTO_VALOR")
            .Append("     , r.USUARIO")
            .Append("     , Convert(Varchar(10), getdate(), 103) As FechaActual")
            .Append("     , Convert(Varchar(10), getdate(), 108) As HoraActual")
            .Append("     , '" & Citi.Synergia.Locals.Cache.UsuarioSSO & "' As UsrEjecutor")
            .Append("  FROM       ACTIVOS_FIJOS           a")
            .Append("  INNER JOIN TIPOS_DE_ACTIVOS        t  ON (a.CODIGO_TIPO_ACTIVO = t.CODIGO_TIPO_ACTIVO)")
            .Append("  INNER JOIN RPT_ACTIVO_DEPRECIACION r  ON (a.CODIGO_DE_ACTIVO = r.CODIGO_DE_ACTIVO AND a.MEJORA_CORRELATIVO = r.MEJORA_CORRELATIVO)")
            .Append("  INNER JOIN DIVISIONES              d  ON (a.CODIGO_DIVISION = d.CODIGO_DIVISION)")
            .Append("  INNER JOIN CATALOGO_CONT_DET       c  ON (t.TIPO_CATALOGO = c.TIPO_CATALOGO  AND t.CTA_ACTIVO = c.CUENTA_CONTABLE)")
            .Append("  INNER JOIN CATALOGO_CONT_DET       c2 ON (t.TIPO_CATALOGO = c2.TIPO_CATALOGO AND t.CTA_DEPREC_ACUM = c2.CUENTA_CONTABLE)")
            .Append("  INNER JOIN CATALOGO_CONT_DET       c3 ON (t.TIPO_CATALOGO = c3.TIPO_CATALOGO AND t.CTA_GASTO_DEPREC = c3.CUENTA_CONTABLE)")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CrearReporteDepreciaciones(data, parametros)
    End Sub

    Private Shared Sub CrearReporteDepreciaciones(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 3

                    Dim totalColumnas As Integer = 19
                    Dim columnaCuadro As Excel.Range

                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).Font.Size = 16
                    oExcel.Cells(linea, 4) = "DEPRECIATIONS' REPORT"

                    linea += 2

                    '-- Los parámetros vienen en orden: tipo activo inicial, tipo activo final, division inicial, division final, fecha reconstruir, texto preliminar, clasificado por
                    oExcel.Cells(linea, 3).Font.Bold = True
                    oExcel.Cells(linea, 3).font.Size = 12
                    oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 3) = "FROM ASSET TYPE:"
                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4).ColumnWidth = 11
                    oExcel.Cells(linea, 4).NumberFormat = "@"
                    oExcel.Cells(linea, 4) = QuitaComilla(parametros.Item(0))
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 12
                    oExcel.Cells(linea, 5) = "TO ASSET TYPE:"
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).NumberFormat = "@"
                    oExcel.Cells(linea, 6) = QuitaComilla(parametros.Item(1))

                    linea = linea + 1

                    oExcel.Cells(linea, 3).Font.Bold = True
                    oExcel.Cells(linea, 3).font.Size = 12
                    oExcel.Cells(linea, 3).ColumnWidth = 21
                    oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 3) = "FROM DEPARTMENT:"
                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4).NumberFormat = "@"
                    oExcel.Cells(linea, 4) = QuitaComilla(parametros.Item(2))
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 12
                    oExcel.Cells(linea, 5).ColumnWidth = 18
                    oExcel.Cells(linea, 5) = "TO DEPARTMENT:"
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).NumberFormat = "@"
                    oExcel.Cells(linea, 6) = QuitaComilla(parametros.Item(3))

                    linea = linea + 1

                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 12
                    oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 4) = IIf(parametros.Item(7) = "S", "FROM: 1900 TO:", "TO DATE:")
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5).NumberFormat = "@"
                    oExcel.Cells(linea, 5) = parametros.Item(4)

                    Dim clasificadoPor As String = parametros.Item(6)

                    Dim ordenamiento As String = String.Empty
                    If clasificadoPor = "T" Then
                        ordenamiento = "By Asset Type - Department"
                    Else
                        ordenamiento = "By Department - Asset Type"
                    End If

                    linea = linea + 2

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 11
                    oExcel.Cells(linea, 1) = parametros.Item(5)
                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4) = ordenamiento

                    linea = linea + 2

                    '-- Títulos de las columnas
                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 11
                    oExcel.Cells(linea, 1) = "Asset ID"
                    oExcel.Cells(linea, 2).Font.Bold = True
                    oExcel.Cells(linea, 2).font.Size = 11
                    oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 2) = "Upgrade"
                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 4) = "Acquisition"
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 5) = "Original"
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).ColumnWidth = 13
                    oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 6) = "Revaluation"
                    oExcel.Cells(linea, 7).Font.Bold = True
                    oExcel.Cells(linea, 7).font.Size = 11
                    oExcel.Cells(linea, 7).ColumnWidth = 15
                    oExcel.Cells(linea, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 7) = "Asset Total"
                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).font.Size = 11
                    oExcel.Cells(linea, 8).ColumnWidth = 15
                    oExcel.Cells(linea, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 8) = "Not Deductible"
                    oExcel.Cells(linea, 9).Font.Bold = True
                    oExcel.Cells(linea, 9).font.Size = 11
                    oExcel.Cells(linea, 9).ColumnWidth = 11
                    oExcel.Cells(linea, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 9) = "Residual"
                    oExcel.Cells(linea, 10).Font.Bold = True
                    oExcel.Cells(linea, 10).font.Size = 11
                    oExcel.Cells(linea, 10).ColumnWidth = 15
                    oExcel.Cells(linea, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 10) = "Value to"
                    oExcel.Cells(linea, 11).Font.Bold = True
                    oExcel.Cells(linea, 11).font.Size = 11
                    oExcel.Cells(linea, 11).ColumnWidth = 15
                    oExcel.Cells(linea, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 11) = "Accum. Depre."
                    oExcel.Cells(linea, 12).Font.Bold = True
                    oExcel.Cells(linea, 12).font.Size = 11
                    oExcel.Cells(linea, 12).ColumnWidth = 15
                    oExcel.Cells(linea, 12).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 12) = "Depreciation"
                    oExcel.Cells(linea, 13).Font.Bold = True
                    oExcel.Cells(linea, 13).font.Size = 11
                    oExcel.Cells(linea, 13).ColumnWidth = 15
                    oExcel.Cells(linea, 13).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 13) = "Accumulated"
                    oExcel.Cells(linea, 14).Font.Bold = True
                    oExcel.Cells(linea, 14).font.Size = 11
                    oExcel.Cells(linea, 14).ColumnWidth = 15
                    oExcel.Cells(linea, 14).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 14) = "Not Deductible"
                    oExcel.Cells(linea, 15).Font.Bold = True
                    oExcel.Cells(linea, 15).font.Size = 11
                    oExcel.Cells(linea, 15).ColumnWidth = 15
                    oExcel.Cells(linea, 15).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 15) = "Pending Balance"
                    oExcel.Cells(linea, 16).Font.Bold = True
                    oExcel.Cells(linea, 16).font.Size = 11
                    oExcel.Cells(linea, 16).ColumnWidth = 13
                    oExcel.Cells(linea, 16).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 16) = "Depreciaton"
                    oExcel.Cells(linea, 17).Font.Bold = True
                    oExcel.Cells(linea, 17).font.Size = 11
                    oExcel.Cells(linea, 17).ColumnWidth = 13
                    oExcel.Cells(linea, 17).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 17) = "Department"
                    oExcel.Cells(linea, 18).Font.Bold = True
                    oExcel.Cells(linea, 18).font.Size = 11
                    oExcel.Cells(linea, 18).ColumnWidth = 15
                    oExcel.Cells(linea, 18).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 18) = "Depreciation"
                    oExcel.Cells(linea, 19).Font.Bold = True
                    oExcel.Cells(linea, 19).font.Size = 11
                    oExcel.Cells(linea, 19).ColumnWidth = 15
                    oExcel.Cells(linea, 19).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 19) = "Asset Status"

                    linea = linea + 1

                    oExcel.Cells(linea, 2).Font.Bold = True
                    oExcel.Cells(linea, 2).font.Size = 11
                    oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 2) = "Correlative"
                    oExcel.Cells(linea, 3).Font.Bold = True
                    oExcel.Cells(linea, 3).font.Size = 11
                    oExcel.Cells(linea, 3).ColumnWidth = 35
                    oExcel.Cells(linea, 3) = "Asset's Description"
                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 4) = "Date"
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 5) = "Value"
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 6) = "Amount"
                    oExcel.Cells(linea, 7).Font.Bold = True
                    oExcel.Cells(linea, 7).font.Size = 11
                    oExcel.Cells(linea, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 7) = "Amount"
                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).font.Size = 11
                    oExcel.Cells(linea, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 8) = "Value"
                    oExcel.Cells(linea, 9).Font.Bold = True
                    oExcel.Cells(linea, 9).font.Size = 11
                    oExcel.Cells(linea, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 9) = "Value"
                    oExcel.Cells(linea, 10).Font.Bold = True
                    oExcel.Cells(linea, 10).font.Size = 11
                    oExcel.Cells(linea, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 10) = "Depreciate"
                    oExcel.Cells(linea, 11).Font.Bold = True
                    oExcel.Cells(linea, 11).font.Size = 11
                    oExcel.Cells(linea, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 11) = "Fiscal Year"
                    oExcel.Cells(linea, 12).Font.Bold = True
                    oExcel.Cells(linea, 12).font.Size = 11
                    oExcel.Cells(linea, 12).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 12) = "Amount"
                    oExcel.Cells(linea, 13).Font.Bold = True
                    oExcel.Cells(linea, 13).font.Size = 11
                    oExcel.Cells(linea, 13).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 13) = "Depreciation"
                    oExcel.Cells(linea, 14).Font.Bold = True
                    oExcel.Cells(linea, 14).font.Size = 11
                    oExcel.Cells(linea, 14).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 14) = "Value"
                    oExcel.Cells(linea, 15).Font.Bold = True
                    oExcel.Cells(linea, 15).font.Size = 11
                    oExcel.Cells(linea, 15).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 15) = "to Depreciate"
                    oExcel.Cells(linea, 16).Font.Bold = True
                    oExcel.Cells(linea, 16).font.Size = 11
                    oExcel.Cells(linea, 16).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 16) = "Percentage"
                    oExcel.Cells(linea, 17).Font.Bold = True
                    oExcel.Cells(linea, 17).font.Size = 11
                    oExcel.Cells(linea, 17).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 17) = "Loss"
                    oExcel.Cells(linea, 18).Font.Bold = True
                    oExcel.Cells(linea, 18).font.Size = 11
                    oExcel.Cells(linea, 18).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 18) = "Method"

                    '-- Dibujo un cuadro
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea - 1, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    Dim lineaInicial As Integer = linea

                    '-- Primer filtro
                    Dim llaveAnterior As String = String.Empty
                    Dim llaveActual As String = String.Empty
                    Dim primerVez As Boolean = True
                    Dim escribirTipo As Boolean = True
                    Dim entro As Boolean = False

                    '-- Segundo filtro
                    Dim tranAnterior As String = String.Empty
                    Dim tranActual As String = String.Empty
                    Dim primerTran As Boolean = True
                    Dim escribirTran As Boolean = True
                    Dim cambioActivo As Boolean = False

                    Dim totalOriginalInterno As Decimal = 0
                    Dim totalOriginalExterno As Decimal = 0
                    Dim totalOriginal As Decimal = 0
                    Dim totalRevaluacionInterno As Decimal = 0
                    Dim totalRevaluacionExterno As Decimal = 0
                    Dim totalRevaluacion As Decimal = 0
                    Dim totalMontoInterno As Decimal = 0
                    Dim totalMontoExterno As Decimal = 0
                    Dim totalMonto As Decimal = 0
                    Dim totalNoDeducibleInterno As Decimal = 0
                    Dim totalNoDeducibleExterno As Decimal = 0
                    Dim totalNoDeducible As Decimal = 0
                    Dim totalResidualInterno As Decimal = 0
                    Dim totalResidualExterno As Decimal = 0
                    Dim totalResidual As Decimal = 0
                    Dim totalDepreciarInterno As Decimal = 0
                    Dim totalDepreciarExterno As Decimal = 0
                    Dim totalDepreciar As Decimal = 0
                    Dim totalFiscalInterno As Decimal = 0
                    Dim totalFiscalExterno As Decimal = 0
                    Dim totalFiscal As Decimal = 0
                    Dim totalDeprecInterno As Decimal = 0
                    Dim totalDeprecExterno As Decimal = 0
                    Dim totalDeprec As Decimal = 0
                    Dim totalAccumInterno As Decimal = 0
                    Dim totalAccumExterno As Decimal = 0
                    Dim totalAccum As Decimal = 0
                    Dim totalValorNoInterno As Decimal = 0
                    Dim totalValorNoExterno As Decimal = 0
                    Dim totalValorNo As Decimal = 0
                    Dim totalPendienteInterno As Decimal = 0
                    Dim totalPendienteExterno As Decimal = 0
                    Dim totalPendiente As Decimal = 0

                    Dim leyendaExterna As String = String.Empty
                    Dim leyendaInterna As String = String.Empty

                    For Each filaData As DataRow In data.Tables(0).Rows
                        cambioActivo = False

                        If clasificadoPor = "T" Then
                            llaveActual = filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim
                            tranActual = filaData.Item("CODIGO_DIVISION").ToString.Trim
                        Else
                            llaveActual = filaData.Item("CODIGO_DIVISION").ToString.Trim
                            tranActual = filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim
                        End If

                        If llaveActual <> llaveAnterior Then
                            llaveAnterior = llaveActual
                            If primerVez = False Then
                                '-- Cambio de activo
                                linea = linea + 7
                            End If
                            primerVez = False

                            If escribirTipo = False Then
                                oExcel.Cells(linea - 3, 1).Font.Size = 10
                                oExcel.Cells(linea - 3, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                                oExcel.Cells(linea - 3, 1).Font.Bold = True
                                oExcel.Cells(linea - 3, 1) = leyendaExterna
                                oExcel.Cells(linea - 3, 5).Font.Size = 10
                                oExcel.Cells(linea - 3, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 5) = totalOriginalExterno
                                oExcel.Cells(linea - 3, 6).Font.Size = 10
                                oExcel.Cells(linea - 3, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 6) = totalRevaluacionExterno
                                oExcel.Cells(linea - 3, 7).Font.Size = 10
                                oExcel.Cells(linea - 3, 7).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 7) = totalMontoExterno
                                oExcel.Cells(linea - 3, 8).Font.Size = 10
                                oExcel.Cells(linea - 3, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 8) = totalNoDeducibleExterno
                                oExcel.Cells(linea - 3, 9).Font.Size = 10
                                oExcel.Cells(linea - 3, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 9) = totalResidualExterno
                                oExcel.Cells(linea - 3, 10).Font.Size = 10
                                oExcel.Cells(linea - 3, 10).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 10) = totalDepreciarExterno
                                oExcel.Cells(linea - 3, 11).Font.Size = 10
                                oExcel.Cells(linea - 3, 11).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 11) = totalFiscalExterno
                                oExcel.Cells(linea - 3, 12).Font.Size = 10
                                oExcel.Cells(linea - 3, 12).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 12) = totalDeprecExterno
                                oExcel.Cells(linea - 3, 13).Font.Size = 10
                                oExcel.Cells(linea - 3, 13).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 13) = totalAccumExterno
                                oExcel.Cells(linea - 3, 14).Font.Size = 10
                                oExcel.Cells(linea - 3, 14).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 14) = totalValorNoExterno
                                oExcel.Cells(linea - 3, 15).Font.Size = 10
                                oExcel.Cells(linea - 3, 15).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 15) = totalPendienteExterno

                                totalOriginal = totalOriginal + totalOriginalExterno
                                totalRevaluacion = totalRevaluacion + totalRevaluacionExterno
                                totalMonto = totalMonto + totalMontoExterno
                                totalNoDeducible = totalNoDeducible + totalNoDeducibleExterno
                                totalResidual = totalResidual + totalResidualExterno
                                totalDepreciar = totalDepreciar + totalDepreciarExterno
                                totalFiscal = totalFiscal + totalFiscalExterno
                                totalDeprec = totalDeprec + totalDeprecExterno
                                totalAccum = totalAccum + totalAccumExterno
                                totalValorNo = totalValorNo + totalValorNoExterno
                                totalPendiente = totalPendiente + totalPendienteExterno

                                totalOriginalExterno = 0
                                totalRevaluacionExterno = 0
                                totalMontoExterno = 0
                                totalNoDeducibleExterno = 0
                                totalResidualExterno = 0
                                totalDepreciarExterno = 0
                                totalFiscalExterno = 0
                                totalDeprecExterno = 0
                                totalAccumExterno = 0
                                totalValorNoExterno = 0
                                totalPendienteExterno = 0
                            End If

                            entro = True

                            cambioActivo = True

                            escribirTipo = True

                            tranAnterior = String.Empty
                        End If

                        If escribirTipo Then
                            oExcel.Cells(linea, 1).Font.Bold = True
                            oExcel.Cells(linea, 1).Font.Size = 10

                            If clasificadoPor = "T" Then
                                oExcel.Cells(linea, 1) = "Asset type " + filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim + " - " + filaData.Item("DESCRIP_TIPO_ACTIVO").ToString.Trim
                                linea = linea + 1
                                oExcel.Cells(linea, 1).Font.Size = 10
                                oExcel.Cells(linea, 1).ColumnWidth = 32
                                oExcel.Cells(linea, 1) = "Asset account:"
                                oExcel.Cells(linea, 2).Font.Size = 10
                                oExcel.Cells(linea, 2).ColumnWidth = 20
                                oExcel.Cells(linea, 2).NumberFormat = "@"
                                oExcel.Cells(linea, 2) = filaData.Item("CTA_ACTIVO").ToString.Trim
                                oExcel.Cells(linea, 3).Font.Size = 10
                                oExcel.Cells(linea, 3).NumberFormat = "@"
                                oExcel.Cells(linea, 3) = filaData.Item("DESCRIPCION").ToString.Trim
                                linea = linea + 1
                                oExcel.Cells(linea, 1).Font.Size = 10
                                oExcel.Cells(linea, 1) = "Accumulated depreciation account:"
                                oExcel.Cells(linea, 2).Font.Size = 10
                                oExcel.Cells(linea, 2).NumberFormat = "@"
                                oExcel.Cells(linea, 2) = filaData.Item("CTA_DEPREC_ACUM").ToString.Trim
                                oExcel.Cells(linea, 3).Font.Size = 10
                                oExcel.Cells(linea, 3).NumberFormat = "@"
                                oExcel.Cells(linea, 3) = filaData.Item("DESCRIPCION_DEPREC_ACUM").ToString.Trim
                                linea = linea + 1
                                oExcel.Cells(linea, 1).Font.Size = 10
                                oExcel.Cells(linea, 1) = "Depreciation expense account:"
                                oExcel.Cells(linea, 2).Font.Size = 10
                                oExcel.Cells(linea, 2).NumberFormat = "@"
                                oExcel.Cells(linea, 2) = filaData.Item("CTA_GASTO_DEPREC").ToString.Trim
                                oExcel.Cells(linea, 3).Font.Size = 10
                                oExcel.Cells(linea, 3).NumberFormat = "@"
                                oExcel.Cells(linea, 3) = filaData.Item("DESCRIPCION_GASTO_DEPREC").ToString.Trim
                            Else
                                oExcel.Cells(linea, 1) = "Department " + filaData.Item("CODIGO_DIVISION").ToString.Trim + " - " + filaData.Item("DESCRIPCION_DIVISION").ToString.Trim
                            End If

                            escribirTipo = False
                        End If

                        If tranActual <> tranAnterior Then
                            tranAnterior = tranActual
                            If primerTran = False And cambioActivo = False Then
                                '-- Cambia de transacción
                                linea = linea + 3
                            End If

                            primerTran = False

                            If escribirTran = False Then
                                Dim resta As Integer = 0

                                If cambioActivo = False Then
                                    resta = 1
                                    oExcel.Cells(linea - resta, 2).font.Size = 9
                                    oExcel.Cells(linea - resta, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                                    oExcel.Cells(linea - resta, 2).Font.Bold = True
                                    oExcel.Cells(linea - resta, 2) = leyendaInterna
                                    oExcel.Cells(linea - resta, 5).font.Size = 9
                                    oExcel.Cells(linea - resta, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 5) = totalOriginalInterno
                                    oExcel.Cells(linea - resta, 6).font.Size = 9
                                    oExcel.Cells(linea - resta, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 6) = totalRevaluacionInterno
                                    oExcel.Cells(linea - resta, 7).font.Size = 9
                                    oExcel.Cells(linea - resta, 7).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 7) = totalMontoInterno
                                    oExcel.Cells(linea - resta, 8).font.Size = 9
                                    oExcel.Cells(linea - resta, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 8) = totalNoDeducibleInterno
                                    oExcel.Cells(linea - resta, 9).font.Size = 9
                                    oExcel.Cells(linea - resta, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 9) = totalResidualInterno
                                    oExcel.Cells(linea - resta, 10).font.Size = 9
                                    oExcel.Cells(linea - resta, 10).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 10) = totalDepreciarInterno
                                    oExcel.Cells(linea - resta, 11).font.Size = 9
                                    oExcel.Cells(linea - resta, 11).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 11) = totalFiscalInterno
                                    oExcel.Cells(linea - resta, 12).font.Size = 9
                                    oExcel.Cells(linea - resta, 12).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 12) = totalDeprecInterno
                                    oExcel.Cells(linea - resta, 13).font.Size = 9
                                    oExcel.Cells(linea - resta, 13).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 13) = totalAccumInterno
                                    oExcel.Cells(linea - resta, 14).font.Size = 9
                                    oExcel.Cells(linea - resta, 14).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 14) = totalValorNoInterno
                                    oExcel.Cells(linea - resta, 15).font.Size = 9
                                    oExcel.Cells(linea - resta, 15).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 15) = totalPendienteInterno
                                Else
                                    If clasificadoPor = "T" Then
                                        resta = 8
                                    Else
                                        resta = 5
                                    End If
                                    oExcel.Cells(linea - resta, 2).font.Size = 9
                                    oExcel.Cells(linea - resta, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                                    oExcel.Cells(linea - resta, 2).Font.Bold = True
                                    oExcel.Cells(linea - resta, 2) = leyendaInterna
                                    oExcel.Cells(linea - resta, 5).font.Size = 9
                                    oExcel.Cells(linea - resta, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 5) = totalOriginalInterno
                                    oExcel.Cells(linea - resta, 6).font.Size = 9
                                    oExcel.Cells(linea - resta, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 6) = totalRevaluacionInterno
                                    oExcel.Cells(linea - resta, 7).font.Size = 9
                                    oExcel.Cells(linea - resta, 7).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 7) = totalMontoInterno
                                    oExcel.Cells(linea - resta, 8).font.Size = 9
                                    oExcel.Cells(linea - resta, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 8) = totalNoDeducibleInterno
                                    oExcel.Cells(linea - resta, 9).font.Size = 9
                                    oExcel.Cells(linea - resta, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 9) = totalResidualInterno
                                    oExcel.Cells(linea - resta, 10).font.Size = 9
                                    oExcel.Cells(linea - resta, 10).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 10) = totalDepreciarInterno
                                    oExcel.Cells(linea - resta, 11).font.Size = 9
                                    oExcel.Cells(linea - resta, 11).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 11) = totalFiscalInterno
                                    oExcel.Cells(linea - resta, 12).font.Size = 9
                                    oExcel.Cells(linea - resta, 12).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 12) = totalDeprecInterno
                                    oExcel.Cells(linea - resta, 13).font.Size = 9
                                    oExcel.Cells(linea - resta, 13).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 13) = totalAccumInterno
                                    oExcel.Cells(linea - resta, 14).font.Size = 9
                                    oExcel.Cells(linea - resta, 14).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 14) = totalValorNoInterno
                                    oExcel.Cells(linea - resta, 15).font.Size = 9
                                    oExcel.Cells(linea - resta, 15).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - resta, 15) = totalPendienteInterno
                                End If

                                totalOriginalInterno = 0
                                totalRevaluacionInterno = 0
                                totalMontoInterno = 0
                                totalNoDeducibleInterno = 0
                                totalResidualInterno = 0
                                totalDepreciarInterno = 0
                                totalFiscalInterno = 0
                                totalDeprecInterno = 0
                                totalAccumInterno = 0
                                totalValorNoInterno = 0
                                totalPendienteInterno = 0
                            End If

                            escribirTran = True
                        End If

                        If escribirTran Then
                            linea = linea + 1

                            If clasificadoPor = "T" Then
                                linea = linea + 1
                                oExcel.Cells(linea, 2).Font.Size = 9
                                oExcel.Cells(linea, 2) = "Department " + filaData.Item("CODIGO_DIVISION").ToString.Trim + " - " + filaData.Item("DESCRIPCION_DIVISION").ToString.Trim
                            Else
                                linea = linea + 1
                                oExcel.Cells(linea, 1).ColumnWidth = 15
                                oExcel.Cells(linea, 2).Font.Size = 9
                                oExcel.Cells(linea, 2) = "Asset type " + filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim + " - " + filaData.Item("DESCRIP_TIPO_ACTIVO").ToString.Trim
                                linea = linea + 1
                                oExcel.Cells(linea, 2).Font.Size = 9
                                oExcel.Cells(linea, 2).ColumnWidth = 32
                                oExcel.Cells(linea, 2) = "Asset account:"
                                oExcel.Cells(linea, 3).Font.Size = 9
                                oExcel.Cells(linea, 3).NumberFormat = "@"
                                oExcel.Cells(linea, 3) = filaData.Item("CTA_ACTIVO").ToString.Trim
                                oExcel.Cells(linea, 4).Font.Size = 9
                                oExcel.Cells(linea, 4).NumberFormat = "@"
                                oExcel.Cells(linea, 4) = filaData.Item("DESCRIPCION").ToString.Trim
                                linea = linea + 1
                                oExcel.Cells(linea, 2).Font.Size = 9
                                oExcel.Cells(linea, 2) = "Accumulated depreciation account:"
                                oExcel.Cells(linea, 3).Font.Size = 9
                                oExcel.Cells(linea, 3).NumberFormat = "@"
                                oExcel.Cells(linea, 3) = filaData.Item("CTA_DEPREC_ACUM").ToString.Trim
                                oExcel.Cells(linea, 4).Font.Size = 9
                                oExcel.Cells(linea, 4).NumberFormat = "@"
                                oExcel.Cells(linea, 4) = filaData.Item("DESCRIPCION_DEPREC_ACUM").ToString.Trim
                                linea = linea + 1
                                oExcel.Cells(linea, 2).Font.Size = 9
                                oExcel.Cells(linea, 2) = "Depreciation expense account:"
                                oExcel.Cells(linea, 3).Font.Size = 9
                                oExcel.Cells(linea, 3).NumberFormat = "@"
                                oExcel.Cells(linea, 3) = filaData.Item("CTA_GASTO_DEPREC").ToString.Trim
                                oExcel.Cells(linea, 4).Font.Size = 9
                                oExcel.Cells(linea, 4).NumberFormat = "@"
                                oExcel.Cells(linea, 4) = filaData.Item("DESCRIPCION_GASTO_DEPREC").ToString.Trim
                            End If

                            escribirTran = False
                        End If

                        If clasificadoPor = "T" Then
                            leyendaInterna = "Total department: " + filaData.Item("CODIGO_DIVISION").ToString.Trim + " - " + filaData.Item("DESCRIPCION_DIVISION").ToString.Trim
                            leyendaExterna = "Total Asset Type: " + filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim + " - " + filaData.Item("DESCRIP_TIPO_ACTIVO").ToString.Trim
                        Else
                            leyendaInterna = "Total Asset Type: " + filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim + " - " + filaData.Item("DESCRIP_TIPO_ACTIVO").ToString.Trim
                            leyendaExterna = "Total Department: " + filaData.Item("CODIGO_DIVISION").ToString.Trim + " - " + filaData.Item("DESCRIPCION_DIVISION").ToString.Trim
                        End If

                        linea = linea + 1

                        oExcel.Cells(linea, 1).Font.Size = 8
                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = filaData.Item("CODIGO_DE_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 2).Font.Size = 8
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 2) = filaData.Item("MEJORA_CORRELATIVO").ToString.Trim
                        oExcel.Cells(linea, 3).Font.Size = 8
                        oExcel.Cells(linea, 3).NumberFormat = "@"
                        oExcel.Cells(linea, 3) = filaData.Item("DESCRIP_CORTA_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 4).Font.Size = 8
                        oExcel.Cells(linea, 4).NumberFormat = "@"
                        oExcel.Cells(linea, 4) = filaData.Item("FECHA_ADQUISICION").ToString.Trim
                        oExcel.Cells(linea, 5).Font.Size = 8
                        oExcel.Cells(linea, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 5) = filaData.Item("VALOR_ORIGINAL_ACTIV").ToString.Trim
                        Dim valorOriginalActivo As Decimal = 0
                        Dim montoRevaluacionActivo As Decimal = 0
                        If filaData.IsNull("VALOR_ORIGINAL_ACTIV") = False Then
                            totalOriginalInterno = totalOriginalInterno + filaData.Item("VALOR_ORIGINAL_ACTIV")
                            totalOriginalExterno = totalOriginalExterno + filaData.Item("VALOR_ORIGINAL_ACTIV")
                            valorOriginalActivo = filaData.Item("VALOR_ORIGINAL_ACTIV")
                        End If

                        oExcel.Cells(linea, 6).Font.Size = 8
                        oExcel.Cells(linea, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 6) = filaData.Item("MONTO_REVALUAC_ACT").ToString
                        If filaData.IsNull("MONTO_REVALUAC_ACT") = False Then
                            totalRevaluacionInterno = totalRevaluacionInterno + filaData.Item("MONTO_REVALUAC_ACT")
                            totalRevaluacionExterno = totalRevaluacionExterno + filaData.Item("MONTO_REVALUAC_ACT")
                            montoRevaluacionActivo = filaData.Item("MONTO_REVALUAC_ACT")
                        End If

                        oExcel.Cells(linea, 7).Font.Size = 8
                        oExcel.Cells(linea, 7).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 7) = valorOriginalActivo + montoRevaluacionActivo
                        totalMontoInterno = totalMontoInterno + (valorOriginalActivo + montoRevaluacionActivo)
                        totalMontoExterno = totalMontoExterno + (valorOriginalActivo + montoRevaluacionActivo)

                        oExcel.Cells(linea, 8).Font.Size = 8
                        oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 8) = filaData.Item("VALOR_NO_DEDUCIBLE").ToString
                        If filaData.IsNull("VALOR_NO_DEDUCIBLE") = False Then
                            totalNoDeducibleInterno = totalNoDeducibleInterno + filaData.Item("VALOR_NO_DEDUCIBLE")
                            totalNoDeducibleExterno = totalNoDeducibleExterno + filaData.Item("VALOR_NO_DEDUCIBLE")
                        End If

                        oExcel.Cells(linea, 9).Font.Size = 8
                        oExcel.Cells(linea, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 9) = filaData.Item("VALOR_RESCATE_ACTIVO").ToString
                        Dim valorRescateActivo As Decimal = 0
                        If filaData.IsNull("VALOR_RESCATE_ACTIVO") = False Then
                            totalResidualInterno = totalResidualInterno + filaData.Item("VALOR_RESCATE_ACTIVO")
                            totalResidualExterno = totalResidualExterno + filaData.Item("VALOR_RESCATE_ACTIVO")
                            valorRescateActivo = filaData.Item("VALOR_RESCATE_ACTIVO")
                        End If

                        oExcel.Cells(linea, 10).Font.Size = 8
                        oExcel.Cells(linea, 10).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 10) = (valorOriginalActivo + montoRevaluacionActivo) - valorRescateActivo

                        totalDepreciarInterno = totalDepreciarInterno + (valorOriginalActivo + montoRevaluacionActivo) - valorRescateActivo
                        totalDepreciarExterno = totalDepreciarExterno + (valorOriginalActivo + montoRevaluacionActivo) - valorRescateActivo

                        oExcel.Cells(linea, 11).Font.Size = 8
                        oExcel.Cells(linea, 11).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 11) = filaData.Item("MOVIMIENTO_ANUAL_DEP").ToString
                        If filaData.IsNull("MOVIMIENTO_ANUAL_DEP") = False Then
                            totalFiscalInterno = totalFiscalInterno + filaData.Item("MOVIMIENTO_ANUAL_DEP")
                            totalFiscalExterno = totalFiscalExterno + filaData.Item("MOVIMIENTO_ANUAL_DEP")
                        End If

                        oExcel.Cells(linea, 12).Font.Size = 8
                        oExcel.Cells(linea, 12).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 12) = filaData.Item("MOVIMIENTO_VALOR").ToString
                        If filaData.IsNull("MOVIMIENTO_VALOR") = False Then
                            totalDeprecInterno = totalDeprecInterno + filaData.Item("MOVIMIENTO_VALOR")
                            totalDeprecExterno = totalDeprecExterno + filaData.Item("MOVIMIENTO_VALOR")
                        End If

                        oExcel.Cells(linea, 13).Font.Size = 8
                        oExcel.Cells(linea, 13).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 13) = filaData.Item("VALOR_DEP_ACUM_ACT").ToString
                        Dim valorDepAcumAct As Decimal = 0
                        If filaData.IsNull("VALOR_DEP_ACUM_ACT") = False Then
                            totalAccumInterno = totalAccumInterno + filaData.Item("VALOR_DEP_ACUM_ACT")
                            totalAccumExterno = totalAccumExterno + filaData.Item("VALOR_DEP_ACUM_ACT")
                            valorDepAcumAct = filaData.Item("VALOR_DEP_ACUM_ACT")
                        End If

                        oExcel.Cells(linea, 14).Font.Size = 8
                        oExcel.Cells(linea, 14).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 14) = filaData.Item("MOVIMIENTO_VAL_NO_DED").ToString
                        If filaData.IsNull("MOVIMIENTO_VAL_NO_DED") = False Then
                            totalValorNoInterno = totalValorNoInterno + filaData.Item("MOVIMIENTO_VAL_NO_DED")
                            totalValorNoExterno = totalValorNoExterno + filaData.Item("MOVIMIENTO_VAL_NO_DED")
                        End If

                        oExcel.Cells(linea, 15).Font.Size = 8
                        oExcel.Cells(linea, 15).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 15) = ((valorOriginalActivo + montoRevaluacionActivo) - valorRescateActivo) - valorDepAcumAct

                        totalPendienteInterno = totalPendienteInterno + ((valorOriginalActivo + montoRevaluacionActivo) - valorRescateActivo) - valorDepAcumAct
                        totalPendienteExterno = totalPendienteExterno + ((valorOriginalActivo + montoRevaluacionActivo) - valorRescateActivo) - valorDepAcumAct

                        oExcel.Cells(linea, 16).Font.Size = 8
                        oExcel.Cells(linea, 16).NumberFormat = "###,###,##0.000000;[Red](###,###,##0.000000)"
                        oExcel.Cells(linea, 16) = filaData.Item("MOVIMIENTO_PORC").ToString
                        oExcel.Cells(linea, 17).Font.Size = 8
                        oExcel.Cells(linea, 17).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 17).NumberFormat = "@"
                        oExcel.Cells(linea, 17) = filaData.Item("MOVIMIENTO_PER_DEP").ToString
                        oExcel.Cells(linea, 18).Font.Size = 8
                        oExcel.Cells(linea, 18).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 18).NumberFormat = "@"
                        oExcel.Cells(linea, 18) = filaData.Item("TIPO_DEPRECIACION").ToString
                        oExcel.Cells(linea, 19).Font.Size = 8
                        oExcel.Cells(linea, 19).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 19).NumberFormat = "@"
                        oExcel.Cells(linea, 19) = DevuelveEstado(filaData.Item("ESTATUS").ToString, True)

                        oExcel.Cells(1, totalColumnas).font.Size = 9
                        oExcel.Cells(1, totalColumnas).NumberFormat = "@"
                        oExcel.Cells(1, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(1, totalColumnas) = filaData.Item("FechaActual").ToString
                        oExcel.Cells(2, totalColumnas).font.Size = 9
                        oExcel.Cells(2, totalColumnas).NumberFormat = "@"
                        oExcel.Cells(2, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(2, totalColumnas) = filaData.Item("HoraActual").ToString
                        oExcel.Cells(2, 1).font.Size = 9
                        oExcel.Cells(2, 1).NumberFormat = "@"
                        oExcel.Cells(2, 1) = filaData.Item("UsrEjecutor").ToString
                    Next

                    linea = linea + 4

                    If entro Then
                        oExcel.Cells(linea - 2, 2).font.Size = 9
                        oExcel.Cells(linea - 2, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        oExcel.Cells(linea - 2, 2).Font.Bold = True
                        oExcel.Cells(linea - 2, 2) = leyendaInterna
                        oExcel.Cells(linea - 2, 5).font.Size = 9
                        oExcel.Cells(linea - 2, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea - 2, 5) = totalOriginalInterno
                        oExcel.Cells(linea - 2, 6).font.Size = 9
                        oExcel.Cells(linea - 2, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea - 2, 6) = totalRevaluacionInterno
                        oExcel.Cells(linea - 2, 7).font.Size = 9
                        oExcel.Cells(linea - 2, 7).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea - 2, 7) = totalMontoInterno
                        oExcel.Cells(linea - 2, 8).font.Size = 9
                        oExcel.Cells(linea - 2, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea - 2, 8) = totalNoDeducibleInterno
                        oExcel.Cells(linea - 2, 9).font.Size = 9
                        oExcel.Cells(linea - 2, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea - 2, 9) = totalResidualInterno
                        oExcel.Cells(linea - 2, 10).font.Size = 9
                        oExcel.Cells(linea - 2, 10).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea - 2, 10) = totalDepreciarInterno
                        oExcel.Cells(linea - 2, 11).font.Size = 9
                        oExcel.Cells(linea - 2, 11).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea - 2, 11) = totalFiscalInterno
                        oExcel.Cells(linea - 2, 12).font.Size = 9
                        oExcel.Cells(linea - 2, 12).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea - 2, 12) = totalDeprecInterno
                        oExcel.Cells(linea - 2, 13).font.Size = 9
                        oExcel.Cells(linea - 2, 13).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea - 2, 13) = totalAccumInterno
                        oExcel.Cells(linea - 2, 14).font.Size = 9
                        oExcel.Cells(linea - 2, 14).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea - 2, 14) = totalValorNoInterno
                        oExcel.Cells(linea - 2, 15).font.Size = 9
                        oExcel.Cells(linea - 2, 15).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea - 2, 15) = totalPendienteInterno

                        oExcel.Cells(linea, 1).font.Size = 10
                        oExcel.Cells(linea, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = leyendaExterna
                        oExcel.Cells(linea, 5).font.Size = 10
                        oExcel.Cells(linea, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 5) = totalOriginalExterno
                        oExcel.Cells(linea, 6).font.Size = 10
                        oExcel.Cells(linea, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 6) = totalRevaluacionExterno
                        oExcel.Cells(linea, 7).font.Size = 10
                        oExcel.Cells(linea, 7).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 7) = totalMontoExterno
                        oExcel.Cells(linea, 8).font.Size = 10
                        oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 8) = totalNoDeducibleExterno
                        oExcel.Cells(linea, 9).font.Size = 10
                        oExcel.Cells(linea, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 9) = totalResidualExterno
                        oExcel.Cells(linea, 10).font.Size = 10
                        oExcel.Cells(linea, 10).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 10) = totalDepreciarExterno
                        oExcel.Cells(linea, 11).font.Size = 10
                        oExcel.Cells(linea, 11).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 11) = totalFiscalExterno
                        oExcel.Cells(linea, 12).font.Size = 10
                        oExcel.Cells(linea, 12).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 12) = totalDeprecExterno
                        oExcel.Cells(linea, 13).font.Size = 10
                        oExcel.Cells(linea, 13).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 13) = totalAccumExterno
                        oExcel.Cells(linea, 14).font.Size = 10
                        oExcel.Cells(linea, 14).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 14) = totalValorNoExterno
                        oExcel.Cells(linea, 15).font.Size = 10
                        oExcel.Cells(linea, 15).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 15) = totalPendienteExterno

                        totalOriginal = totalOriginal + totalOriginalExterno
                        totalRevaluacion = totalRevaluacion + totalRevaluacionExterno
                        totalMonto = totalMonto + totalMontoExterno
                        totalNoDeducible = totalNoDeducible + totalNoDeducibleExterno
                        totalResidual = totalResidual + totalResidualExterno
                        totalDepreciar = totalDepreciar + totalDepreciarExterno
                        totalFiscal = totalFiscal + totalFiscalExterno
                        totalDeprec = totalDeprec + totalDeprecExterno
                        totalAccum = totalAccum + totalAccumExterno
                        totalValorNo = totalValorNo + totalValorNoExterno
                        totalPendiente = totalPendiente + totalPendienteExterno
                    End If

                    linea = linea + 2

                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4) = "Overall total:"
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 5) = totalOriginal
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 6) = totalRevaluacion
                    oExcel.Cells(linea, 7).font.Size = 11
                    oExcel.Cells(linea, 7).Font.Bold = True
                    oExcel.Cells(linea, 7).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 7) = totalMonto
                    oExcel.Cells(linea, 8).font.Size = 11
                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 8) = totalNoDeducible
                    oExcel.Cells(linea, 9).font.Size = 11
                    oExcel.Cells(linea, 9).Font.Bold = True
                    oExcel.Cells(linea, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 9) = totalResidual
                    oExcel.Cells(linea, 10).font.Size = 11
                    oExcel.Cells(linea, 10).Font.Bold = True
                    oExcel.Cells(linea, 10).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 10) = totalDepreciar
                    oExcel.Cells(linea, 11).font.Size = 11
                    oExcel.Cells(linea, 11).Font.Bold = True
                    oExcel.Cells(linea, 11).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 11) = totalFiscal
                    oExcel.Cells(linea, 12).font.Size = 11
                    oExcel.Cells(linea, 12).Font.Bold = True
                    oExcel.Cells(linea, 12).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 12) = totalDeprec
                    oExcel.Cells(linea, 13).font.Size = 11
                    oExcel.Cells(linea, 13).Font.Bold = True
                    oExcel.Cells(linea, 13).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 13) = totalAccum
                    oExcel.Cells(linea, 14).font.Size = 11
                    oExcel.Cells(linea, 14).Font.Bold = True
                    oExcel.Cells(linea, 14).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 14) = totalValorNo
                    oExcel.Cells(linea, 15).font.Size = 11
                    oExcel.Cells(linea, 15).Font.Bold = True
                    oExcel.Cells(linea, 15).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 15) = totalPendiente
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub TomaFisicaInventario(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT a.CODIGO_TIPO_ACTIVO")
            .Append("     , a.CODIGO_DIVISION")
            .Append("     , d.DESCRIPCION_DIVISION")
            .Append("     , a.CODIGO_DE_ACTIVO")
            .Append("     , a.MEJORA_CORRELATIVO")
            .Append("     , a.DESCRIP_CORTA_ACTIVO")
            .Append("     , a.ESTATUS")
            .Append("     , Convert(Varchar(10), a.FECHA_ADQUISICION, 103) As FECHA_ADQUISICION")
            .Append("     , s.DESCRIPCION_MARCA As MARCA")
            .Append("     , u.DESCRIPCION_UBICACION As UBICACION_ACTIVO")
            .Append("     , g.MODELO_DEL_ACTIVO")
            .Append("     , r.NOMBRE_USUAL + ' - ' + r.NOMBRE_RESPONSABLE + ' ' + r.APELLIDO_PATERNO As RESPONSABLE_ACTIVO")
            .Append("     , g.ESTILO_DEL_ACTIVO")
            .Append("     , Convert(Varchar(10), a.FECHA_ULT_INVENTARIO, 103) As FECHA_ULT_INVENTARIO")
            .Append("     , g.CHASIS_ACTIVO")
            .Append("     , g.NUMERO_SERIE_ACTIVO")
            .Append("     , t.DESCRIP_TIPO_ACTIVO")
            .Append("     , t.CODIGO_TIPO_ACTIVO")
            .Append("     , d.CODIGO_DIVISION")
            .Append("     , Convert(Varchar(10), getdate(), 103) As FechaActual")
            .Append("     , Convert(Varchar(10), getdate(), 108) As HoraActual")
            .Append("     , '" & Citi.Synergia.Locals.Cache.UsuarioSSO & "' As UsrEjecutor")
            .Append("  FROM            ACTIVOS_FIJOS     a")
            .Append("  LEFT OUTER JOIN DIVISIONES        d ON (a.CODIGO_DIVISION = d.CODIGO_DIVISION)")
            .Append("  LEFT OUTER JOIN ACTIVOS_FIJOS_GEN g ON (a.CODIGO_DE_ACTIVO = g.CODIGO_DE_ACTIVO AND a.MEJORA_CORRELATIVO = g.MEJORA_CORRELATIVO)")
            .Append("  INNER JOIN      TIPOS_DE_ACTIVOS  t ON (a.CODIGO_TIPO_ACTIVO = t.CODIGO_TIPO_ACTIVO)")
            .Append("  LEFT OUTER JOIN MARCAS            s ON (a.CODIGO_MARCA = s.CODIGO_MARCA)")
            .Append("  LEFT OUTER JOIN UBICACION_ACTIVO  u On (a.CODIGO_UBICACION = u.CODIGO_UBICACION)")
            .Append("  LEFT OUTER JOIN ACT_RESPONSABLES  r On (a.RESPONSABLE_ID = r.RESPONSABLE_ID)")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CrearReporteTomaFisicaInventario(data, parametros)
    End Sub

    Private Shared Sub CrearReporteTomaFisicaInventario(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 3

                    Dim totalColumnas As Integer = 9
                    Dim columnaCuadro As Excel.Range

                    oExcel.Cells(linea, 1) = "PHYSICAL RECONCILIATION"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 16
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea += 2

                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 14
                    oExcel.Cells(linea, 5).ColumnWidth = 43
                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 5) = "PHYSICAL RECONCILIATION TO DATE:"
                    oExcel.Cells(linea, 6).font.Size = 13
                    oExcel.Cells(linea, 6).ColumnWidth = 14
                    oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    Dim spGT As New CultureInfo("es-GT")
                    oExcel.Cells(linea, 6) = Now.Date.ToString("d", spGT)

                    Dim clasificadoPor As String = parametros.Item(0)

                    linea += 2

                    If clasificadoPor = "T" Then
                        oExcel.Cells(linea, 1) = "CLASSIFIED BY ASSET TYPE - DEPARTMENT"
                    Else
                        oExcel.Cells(linea, 1) = "CLASSIFIED BY DEPARTMENT - ASSET TYPE"
                    End If
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 12
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea += 2

                    '-- Los parámetros vienen en orden: clasificado por, division inicial, division final, estado activo, tipo activo inicial, tipo activo final
                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 12
                    oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 4) = "FROM ASSET TYPE:"
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5).NumberFormat = "@"
                    oExcel.Cells(linea, 5) = QuitaComilla(parametros.Item(4))
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 12
                    oExcel.Cells(linea, 6) = "TO ASSET TYPE:"
                    oExcel.Cells(linea, 7).font.Size = 11
                    oExcel.Cells(linea, 7).NumberFormat = "@"
                    oExcel.Cells(linea, 7) = QuitaComilla(parametros.Item(5))

                    linea = linea + 1

                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 12
                    oExcel.Cells(linea, 4).ColumnWidth = 21
                    oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 4) = "FROM DEPARTMENT:"
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5).NumberFormat = "@"
                    oExcel.Cells(linea, 5) = QuitaComilla(parametros.Item(1))
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 12
                    oExcel.Cells(linea, 6).ColumnWidth = 18
                    oExcel.Cells(linea, 6) = "TO DEPARTMENT:"
                    oExcel.Cells(linea, 7).font.Size = 11
                    oExcel.Cells(linea, 7).NumberFormat = "@"
                    oExcel.Cells(linea, 7) = QuitaComilla(parametros.Item(2))

                    linea = linea + 1

                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 12
                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 5) = "ASSET STATUS:"
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).NumberFormat = "@"
                    oExcel.Cells(linea, 6) = DevuelveEstado(parametros.Item(3), False)

                    linea = linea + 2

                    '-- Títulos de las columnas
                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 11
                    oExcel.Cells(linea, 1).ColumnWidth = 11
                    oExcel.Cells(linea, 1) = "ASSET ID"
                    oExcel.Cells(linea, 3).Font.Bold = True
                    oExcel.Cells(linea, 3).font.Size = 11
                    oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 3) = "UPGRADE"
                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4).ColumnWidth = 35
                    oExcel.Cells(linea, 4) = "DESCRIPTION"
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5) = "ENTRY DATE"
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).ColumnWidth = 25
                    oExcel.Cells(linea, 6) = "LOCATION"
                    oExcel.Cells(linea, 7).Font.Bold = True
                    oExcel.Cells(linea, 7).font.Size = 11
                    oExcel.Cells(linea, 7).ColumnWidth = 25
                    oExcel.Cells(linea, 7) = "RESPONSIBLE"
                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).font.Size = 11
                    oExcel.Cells(linea, 8).ColumnWidth = 15
                    oExcel.Cells(linea, 8).ColumnWidth = 21
                    oExcel.Cells(linea, 8) = "LAST INVENTORY DATE"

                    linea = linea + 1

                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4) = "ASSET STATUS"
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5) = "BRAND"
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6) = "MODEL"
                    oExcel.Cells(linea, 7).Font.Bold = True
                    oExcel.Cells(linea, 7).font.Size = 11
                    oExcel.Cells(linea, 7) = "STYLE"
                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).font.Size = 11
                    oExcel.Cells(linea, 8) = "CHASSIS"
                    oExcel.Cells(linea, 9).Font.Bold = True
                    oExcel.Cells(linea, 9).font.Size = 11
                    oExcel.Cells(linea, 9).ColumnWidth = 35
                    oExcel.Cells(linea, 9) = "OBSERVATIONS"

                    '-- Dibujo un cuadro
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea - 1, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    Dim lineaInicial As Integer = linea

                    '-- Primer filtro
                    Dim llaveAnterior As String = String.Empty
                    Dim llaveActual As String = String.Empty
                    Dim primerVez As Boolean = True
                    Dim escribirTipo As Boolean = True
                    Dim entro As Boolean = False

                    '-- Segundo filtro
                    Dim tranAnterior As String = String.Empty
                    Dim tranActual As String = String.Empty
                    Dim primerTran As Boolean = True
                    Dim escribirTran As Boolean = True
                    Dim cambioActivo As Boolean = False

                    Dim contadorInterno As Integer = 0
                    Dim contadorExterno As Integer = 0

                    Dim leyendaExterna As String = String.Empty
                    Dim leyendaInterna As String = String.Empty

                    Dim lineaAux As Integer = 0

                    For Each filaData As DataRow In data.Tables(0).Rows
                        cambioActivo = False

                        If clasificadoPor = "T" Then
                            llaveActual = filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim
                            tranActual = filaData.Item("CODIGO_DIVISION").ToString.Trim
                        Else
                            llaveActual = filaData.Item("CODIGO_DIVISION").ToString.Trim
                            tranActual = filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim
                        End If

                        If llaveActual <> llaveAnterior Then
                            llaveAnterior = llaveActual
                            If primerVez = False Then
                                '-- Cambio de activo
                                linea = linea + 6
                            End If
                            primerVez = False

                            If escribirTipo = False Then
                                oExcel.Cells(linea - 3, 1).Font.Size = 10
                                oExcel.Cells(linea - 3, 1).Font.Bold = True
                                oExcel.Cells(linea - 3, 1) = leyendaExterna + ": " + contadorExterno.ToString

                                '-- Dibujo un cuadro
                                columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 1), oExcel.Cells(linea - 3, totalColumnas))
                                columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                                contadorExterno = 0
                            End If

                            entro = True

                            cambioActivo = True

                            escribirTipo = True

                            tranAnterior = String.Empty
                        End If

                        If escribirTipo Then
                            lineaAux = linea

                            oExcel.Cells(linea, 1).Font.Bold = True
                            oExcel.Cells(linea, 1).Font.Size = 10

                            If clasificadoPor = "T" Then
                                oExcel.Cells(linea, 1) = "ASSET TYPE: " + filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim + " - " + filaData.Item("DESCRIP_TIPO_ACTIVO").ToString.Trim
                            Else
                                oExcel.Cells(linea, 1) = "DEPARTMENT: " + filaData.Item("CODIGO_DIVISION").ToString.Trim + " - " + filaData.Item("DESCRIPCION_DIVISION").ToString.Trim
                            End If

                            escribirTipo = False
                        End If

                        contadorExterno = contadorExterno + 1

                        If tranActual <> tranAnterior Then
                            tranAnterior = tranActual
                            If primerTran = False And cambioActivo = False Then
                                '-- Cambia de transacción
                                linea = linea + 2
                            End If

                            primerTran = False

                            If escribirTran = False Then
                                If cambioActivo = False Then
                                    oExcel.Cells(linea - 1, 2).font.Size = 9
                                    oExcel.Cells(linea - 1, 2) = leyendaInterna + ": " + contadorInterno.ToString
                                Else
                                    oExcel.Cells(linea - 5, 2).font.Size = 9
                                    oExcel.Cells(linea - 5, 2) = leyendaInterna + ": " + contadorInterno.ToString
                                End If

                                contadorInterno = 0
                            End If

                            escribirTran = True
                        End If

                        If escribirTran Then
                            If clasificadoPor = "T" Then
                                linea = linea + 1
                                oExcel.Cells(linea, 2).Font.Size = 9
                                oExcel.Cells(linea, 2) = "DEPARTMENT: " + filaData.Item("CODIGO_DIVISION").ToString.Trim + " - " + filaData.Item("DESCRIPCION_DIVISION").ToString.Trim
                            Else
                                linea = linea + 1
                                oExcel.Cells(linea, 2).Font.Size = 9
                                oExcel.Cells(linea, 2) = "ASSET TYPE: " + filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim + " - " + filaData.Item("DESCRIP_TIPO_ACTIVO").ToString.Trim
                            End If

                            escribirTran = False
                        End If

                        contadorInterno = contadorInterno + 1

                        If clasificadoPor = "T" Then
                            leyendaInterna = "ASSETS BY DEPARTMENT: " + filaData.Item("CODIGO_DIVISION").ToString.Trim + " - " + filaData.Item("DESCRIPCION_DIVISION").ToString.Trim
                            leyendaExterna = "ASSETS BY ASSET TYPE: " + filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim + " - " + filaData.Item("DESCRIP_TIPO_ACTIVO").ToString.Trim
                        Else
                            leyendaInterna = "ASSETS BY ASSET TYPE: " + filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim + " - " + filaData.Item("DESCRIP_TIPO_ACTIVO").ToString.Trim
                            leyendaExterna = "ASSETS BY DEPARTMENT: " + filaData.Item("CODIGO_DIVISION").ToString.Trim + " - " + filaData.Item("DESCRIPCION_DIVISION").ToString.Trim
                        End If

                        linea = linea + 1

                        oExcel.Cells(linea, 1).Font.Size = 8
                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = filaData.Item("CODIGO_DE_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 3).Font.Size = 8
                        oExcel.Cells(linea, 3).NumberFormat = "@"
                        oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 3) = filaData.Item("MEJORA_CORRELATIVO").ToString.Trim
                        oExcel.Cells(linea, 4).Font.Size = 8
                        oExcel.Cells(linea, 4).NumberFormat = "@"
                        oExcel.Cells(linea, 4) = filaData.Item("DESCRIP_CORTA_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 5).Font.Size = 8
                        oExcel.Cells(linea, 5).NumberFormat = "@"
                        oExcel.Cells(linea, 5) = filaData.Item("FECHA_ADQUISICION").ToString.Trim
                        oExcel.Cells(linea, 6).Font.Size = 8
                        oExcel.Cells(linea, 6).NumberFormat = "@"
                        oExcel.Cells(linea, 6) = filaData.Item("UBICACION_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 7).Font.Size = 8
                        oExcel.Cells(linea, 7).NumberFormat = "@"
                        oExcel.Cells(linea, 7) = filaData.Item("RESPONSABLE_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 8).Font.Size = 8
                        oExcel.Cells(linea, 8).NumberFormat = "@"
                        oExcel.Cells(linea, 8) = filaData.Item("FECHA_ULT_INVENTARIO").ToString.Trim
                        oExcel.Cells(linea, 9).Font.Size = 8
                        oExcel.Cells(linea, 9).NumberFormat = "@"
                        oExcel.Cells(linea, 9) = filaData.Item("NUMERO_SERIE_ACTIVO").ToString.Trim

                        linea = linea + 1
                        oExcel.Cells(linea, 4).Font.Size = 8
                        oExcel.Cells(linea, 4).NumberFormat = "@"
                        oExcel.Cells(linea, 4) = DevuelveEstado(filaData.Item("ESTATUS").ToString.Trim, True)
                        oExcel.Cells(linea, 5).Font.Size = 8
                        oExcel.Cells(linea, 5).NumberFormat = "@"
                        oExcel.Cells(linea, 5) = filaData.Item("MARCA").ToString.Trim
                        oExcel.Cells(linea, 6).Font.Size = 8
                        oExcel.Cells(linea, 6).NumberFormat = "@"
                        oExcel.Cells(linea, 6) = filaData.Item("MODELO_DEL_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 7).Font.Size = 8
                        oExcel.Cells(linea, 7).NumberFormat = "@"
                        oExcel.Cells(linea, 7) = filaData.Item("ESTILO_DEL_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 8).Font.Size = 8
                        oExcel.Cells(linea, 8).NumberFormat = "@"
                        oExcel.Cells(linea, 8) = filaData.Item("CHASIS_ACTIVO").ToString.Trim

                        oExcel.Cells(1, totalColumnas).font.Size = 9
                        oExcel.Cells(1, totalColumnas).NumberFormat = "@"
                        oExcel.Cells(1, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(1, totalColumnas) = filaData.Item("FechaActual").ToString
                        oExcel.Cells(2, totalColumnas).font.Size = 9
                        oExcel.Cells(2, totalColumnas).NumberFormat = "@"
                        oExcel.Cells(2, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(2, totalColumnas) = filaData.Item("HoraActual").ToString
                        oExcel.Cells(2, 1).font.Size = 9
                        oExcel.Cells(2, 1).NumberFormat = "@"
                        oExcel.Cells(2, 1) = filaData.Item("UsrEjecutor").ToString
                    Next

                    linea = linea + 3

                    If entro Then
                        oExcel.Cells(linea - 2, 2).font.Size = 9
                        oExcel.Cells(linea - 2, 2) = leyendaInterna + ": " + contadorInterno.ToString

                        oExcel.Cells(linea, 1).font.Size = 10
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = leyendaExterna + ": " + contadorExterno.ToString

                        '-- Dibujo un cuadro
                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 1), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                        '-- Dibujo el cuadro externo
                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    End If
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub ProyeccionDepreciaciones(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT a.TIPO_DEPRECIACION")
            .Append("     , a.CODIGO_DIVISION")
            .Append("     , a.CODIGO_DE_ACTIVO")
            .Append("     , Convert(Varchar(10), a.FECHA_ADQUISICION, 103) As FECHA_ADQUISICION")
            .Append("     , a.VALOR_RESCATE_ACTIVO")
            .Append("     , a.PORCENTAJE_ANUAL_DEP")
            .Append("     , a.DESCRIP_CORTA_ACTIVO")
            .Append("     , t.CODIGO_TIPO_ACTIVO")
            .Append("     , t.DESCRIP_TIPO_ACTIVO")
            .Append("     , d.DESCRIPCION_DIVISION")
            .Append("     , a.VALOR_ORIGINAL_ACTIV")
            .Append("     , r.PERIODO_DEPRECIACION")
            .Append("     , r.VALOR_ACTUAL_ACTIVO")
            .Append("     , r.MONTO_ULTIMA_DEPREC")
            .Append("     , r.VALOR_DEP_ACUM_ACT")
            .Append("     , d.CODIGO_DIVISION")
            .Append("     , r.MES_CALCULO")
            .Append("     , a.CODIGO_TIPO_ACTIVO")
            .Append("     , a.DEPRECIABLE")
            .Append("     , a.ESTATUS")
            .Append("     , Convert(Varchar(10), getdate(), 103) As FechaActual")
            .Append("     , Convert(Varchar(10), getdate(), 108) As HoraActual")
            .Append("     , '" & Citi.Synergia.Locals.Cache.UsuarioSSO & "' As UsrEjecutor")
            .Append("  FROM       ACTIVOS_FIJOS            a")
            .Append("  INNER JOIN TIPOS_DE_ACTIVOS         t ON (a.CODIGO_TIPO_ACTIVO = t.CODIGO_TIPO_ACTIVO)")
            .Append("  INNER JOIN DIVISIONES               d ON (a.CODIGO_DIVISION = d.CODIGO_DIVISION)")
            .Append("  INNER JOIN RPT_DEPRECIACION_DETALLE r ON (a.CODIGO_DE_ACTIVO = r.CODIGO_DE_ACTIVO  AND a.MEJORA_CORRELATIVO = r.MEJORA_CORRELATIVO)")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CreaReporteProyeccionDepreciaciones(data, parametros)
    End Sub

    Private Shared Sub CreaReporteProyeccionDepreciaciones(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 2
                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 16
                    oExcel.Cells(linea, 4) = "Depreciations' proyection of fixed assets"

                    linea += 2

                    '-- Los parámetros vienen en orden: año inicial, año final, clasificado por, codigo activo inicial, codigo activo final, division inicial, division final, mes inicial, mes final, tipo activo inicial, tipo activo final
                    Dim clasificadoPor As String = parametros.Item(2)

                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 14
                    oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 4) = "CLASSIFIED BY:"
                    oExcel.Cells(linea, 5).font.Size = 13
                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    If clasificadoPor = "T" Then
                        oExcel.Cells(linea, 5) = "Asset Types"
                    Else
                        oExcel.Cells(linea, 5) = "Department"
                    End If

                    linea += 2

                    oExcel.Cells(linea, 3).Font.Bold = True
                    oExcel.Cells(linea, 3).font.Size = 12
                    oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 3) = "FROM ASSET:"
                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4).ColumnWidth = 14
                    oExcel.Cells(linea, 4).NumberFormat = "@"
                    oExcel.Cells(linea, 4) = QuitaComilla(parametros.Item(3))
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 12
                    oExcel.Cells(linea, 5) = "TO ASSET:"
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).ColumnWidth = 14
                    oExcel.Cells(linea, 6).NumberFormat = "@"
                    oExcel.Cells(linea, 6) = QuitaComilla(parametros.Item(4))
                    linea += 1
                    oExcel.Cells(linea, 3).Font.Bold = True
                    oExcel.Cells(linea, 3).font.Size = 12
                    oExcel.Cells(linea, 3).ColumnWidth = 21
                    oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 3) = "FROM DEPARTMENT:"
                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4).NumberFormat = "@"
                    oExcel.Cells(linea, 4) = QuitaComilla(parametros.Item(5))
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 12
                    oExcel.Cells(linea, 5).ColumnWidth = 18
                    oExcel.Cells(linea, 5) = "TO DEPARTMENT:"
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).NumberFormat = "@"
                    oExcel.Cells(linea, 6) = QuitaComilla(parametros.Item(6))
                    linea += 1
                    oExcel.Cells(linea, 3).Font.Bold = True
                    oExcel.Cells(linea, 3).font.Size = 12
                    oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 3) = "FROM ASSET TYPE:"
                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4).NumberFormat = "@"
                    oExcel.Cells(linea, 4) = QuitaComilla(parametros.Item(9))
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 12
                    oExcel.Cells(linea, 5) = "TO ASSET TYPE:"
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).NumberFormat = "@"
                    oExcel.Cells(linea, 6) = QuitaComilla(parametros.Item(10))
                    linea = linea + 1
                    oExcel.Cells(linea, 3).Font.Bold = True
                    oExcel.Cells(linea, 3).font.Size = 12
                    oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 3) = "START DATE:"
                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4).NumberFormat = "@"
                    Dim spGT As New CultureInfo("es-GT")
                    Dim fecha As Date
                    fecha = New Date(QuitaComilla(parametros(0)), QuitaComilla(parametros(7)), 1)
                    oExcel.Cells(linea, 4) = fecha.ToString("d", spGT)
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 12
                    oExcel.Cells(linea, 5) = "END DATE:"
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).NumberFormat = "@"
                    fecha = New Date(QuitaComilla(parametros(1)), QuitaComilla(parametros(8)), 1)
                    oExcel.Cells(linea, 6) = fecha.ToString("d", spGT)

                    linea = linea + 2

                    '-- Títulos de las columnas
                    oExcel.Cells(linea, 2).Font.Bold = True
                    oExcel.Cells(linea, 2).font.Size = 11
                    oExcel.Cells(linea, 2).ColumnWidth = 16
                    oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 2) = "DEPRECIATION"
                    oExcel.Cells(linea, 3).Font.Bold = True
                    oExcel.Cells(linea, 3).font.Size = 11
                    oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 3) = "ACQUISITION DATE"
                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4).ColumnWidth = 35
                    oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 4) = "ORIGINAL VALUE"
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 5) = "RESIDUAL VALUE"
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6) = "YEAR/MONTH"
                    oExcel.Cells(linea, 7).Font.Bold = True
                    oExcel.Cells(linea, 7).font.Size = 11
                    oExcel.Cells(linea, 7).ColumnWidth = 21
                    oExcel.Cells(linea, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 7) = "CURRENT REAL VALUE"
                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).font.Size = 11
                    oExcel.Cells(linea, 8).ColumnWidth = 16
                    oExcel.Cells(linea, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 8) = "PROJECTED"
                    oExcel.Cells(linea, 9).Font.Bold = True
                    oExcel.Cells(linea, 9).font.Size = 11
                    oExcel.Cells(linea, 9).ColumnWidth = 21
                    oExcel.Cells(linea, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 9) = "REAL ACCUM. DEPREC."
                    oExcel.Cells(linea, 10).Font.Bold = True
                    oExcel.Cells(linea, 10).font.Size = 11
                    oExcel.Cells(linea, 10).ColumnWidth = 15
                    oExcel.Cells(linea, 10) = "DEPRECIATION"

                    linea = linea + 1

                    oExcel.Cells(linea, 2).Font.Bold = True
                    oExcel.Cells(linea, 2).font.Size = 11
                    oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 2) = "METHOD"
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6) = "DEPRECIATION"
                    oExcel.Cells(linea, 7).Font.Bold = True
                    oExcel.Cells(linea, 7).font.Size = 11
                    oExcel.Cells(linea, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 7) = "+ PROJECTED"
                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).font.Size = 11
                    oExcel.Cells(linea, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 8) = "DEPRECIATION"
                    oExcel.Cells(linea, 9).Font.Bold = True
                    oExcel.Cells(linea, 9).font.Size = 11
                    oExcel.Cells(linea, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 9) = "+ PROJECTED"
                    oExcel.Cells(linea, 10).Font.Bold = True
                    oExcel.Cells(linea, 10).font.Size = 11
                    oExcel.Cells(linea, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 10) = "PERCENTAGE"

                    '-- Dibujo un cuadro
                    Dim totalColumnas As Integer = 1
                    totalColumnas = 10

                    Dim columnaCuadro As Excel.Range = oExcel.Range(oExcel.Cells(linea - 1, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    Dim lineaInicial As Integer = linea

                    '-- Primer filtro
                    Dim llaveAnterior As String = String.Empty
                    Dim llaveActual As String = String.Empty
                    Dim primerVez As Boolean = True
                    Dim escribirTipo As Boolean = True
                    Dim entro As Boolean = False

                    '-- Segundo filtro
                    Dim tranAnterior As String = String.Empty
                    Dim tranActual As String = String.Empty
                    Dim primerTran As Boolean = True
                    Dim escribirTran As Boolean = True
                    Dim cambioActivo As Boolean = False

                    '-- Tercer filtro
                    Dim activoAnterior As String = String.Empty
                    Dim activoActual As String = String.Empty
                    Dim primerActivo As Boolean = True
                    Dim escribirActivo As Boolean = True
                    Dim cambioTipo As Boolean = False

                    Dim leyendaExterna As String = String.Empty
                    Dim leyendaInterna As String = String.Empty
                    Dim leyendaActivo As String = String.Empty

                    Dim lineaAux As Integer = 0

                    Dim totalOriginalExterno As Decimal = 0
                    Dim totalOriginalInterno As Decimal = 0
                    Dim totalOriginalActivo As Decimal = 0
                    Dim totalOriginalGeneral As Decimal = 0
                    Dim totalRescateExterno As Decimal = 0
                    Dim totalRescateInterno As Decimal = 0
                    Dim totalRescateActivo As Decimal = 0
                    Dim totalRescateGeneral As Decimal = 0
                    Dim totalProyectadoExterno As Decimal = 0
                    Dim totalProyectadoInterno As Decimal = 0
                    Dim totalProyectadoActivo As Decimal = 0
                    Dim totalProyectadoGeneral As Decimal = 0

                    For Each filaData As DataRow In data.Tables(0).Rows
                        cambioActivo = False
                        cambioTipo = False

                        If clasificadoPor = "T" Then
                            llaveActual = filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim
                            tranActual = filaData.Item("CODIGO_DIVISION").ToString.Trim
                            activoActual = filaData.Item("CODIGO_DE_ACTIVO").ToString.Trim
                        Else
                            llaveActual = filaData.Item("CODIGO_DIVISION").ToString.Trim
                            tranActual = filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim
                            activoActual = filaData.Item("CODIGO_DE_ACTIVO").ToString.Trim
                        End If

                        If llaveActual <> llaveAnterior Then
                            llaveAnterior = llaveActual
                            If primerVez = False Then
                                '-- Cambio de activo
                                linea = linea + 8
                            End If
                            primerVez = False

                            If escribirTipo = False Then
                                oExcel.Cells(linea - 3, 1).Font.Size = 10
                                oExcel.Cells(linea - 3, 1).Font.Bold = True
                                oExcel.Cells(linea - 3, 1) = leyendaExterna

                                oExcel.Cells(linea - 3, 4).Font.Size = 10
                                oExcel.Cells(linea - 3, 4).Font.Bold = True
                                oExcel.Cells(linea - 3, 4).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 4) = totalOriginalExterno
                                oExcel.Cells(linea - 3, 5).Font.Size = 10
                                oExcel.Cells(linea - 3, 5).Font.Bold = True
                                oExcel.Cells(linea - 3, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 5) = totalRescateExterno
                                oExcel.Cells(linea - 3, 8).Font.Size = 10
                                oExcel.Cells(linea - 3, 8).Font.Bold = True
                                oExcel.Cells(linea - 3, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 8) = totalProyectadoExterno

                                totalOriginalGeneral = totalOriginalGeneral + totalOriginalExterno
                                totalRescateGeneral = totalRescateGeneral + totalRescateExterno
                                totalProyectadoGeneral = totalProyectadoGeneral + totalProyectadoExterno

                                totalOriginalExterno = 0
                                totalRescateExterno = 0
                                totalProyectadoExterno = 0

                                '-- Dibujo un cuadro
                                columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 1), oExcel.Cells(linea - 3, totalColumnas))
                                columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                            End If

                            entro = True

                            cambioActivo = True

                            escribirTipo = True

                            tranAnterior = String.Empty
                        End If

                        If escribirTipo Then
                            lineaAux = linea

                            oExcel.Cells(linea, 1).Font.Bold = True
                            oExcel.Cells(linea, 1).Font.Size = 10


                            If clasificadoPor = "T" Then
                                oExcel.Cells(linea, 1) = "Asset Type " + filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim + " - " + filaData.Item("DESCRIP_TIPO_ACTIVO").ToString.Trim
                            Else
                                oExcel.Cells(linea, 1) = "Department " + filaData.Item("CODIGO_DIVISION").ToString.Trim + " - " + filaData.Item("DESCRIPCION_DIVISION").ToString.Trim
                            End If

                            escribirTipo = False
                        End If

                        If tranActual <> tranAnterior Then
                            tranAnterior = tranActual
                            If primerTran = False And cambioActivo = False Then
                                '-- Cambia de transacción
                                linea = linea + 4
                            End If

                            primerTran = False

                            If escribirTran = False Then
                                If cambioActivo = False Then
                                    oExcel.Cells(linea - 1, 2).Font.Bold = True
                                    oExcel.Cells(linea - 1, 2).font.Size = 9
                                    oExcel.Cells(linea - 1, 2) = leyendaInterna

                                    oExcel.Cells(linea - 1, 4).Font.Size = 9
                                    oExcel.Cells(linea - 1, 4).Font.Bold = True
                                    oExcel.Cells(linea - 1, 4).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - 1, 4) = totalOriginalInterno
                                    oExcel.Cells(linea - 1, 5).Font.Size = 9
                                    oExcel.Cells(linea - 1, 5).Font.Bold = True
                                    oExcel.Cells(linea - 1, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - 1, 5) = totalRescateInterno
                                    oExcel.Cells(linea - 1, 8).Font.Size = 9
                                    oExcel.Cells(linea - 1, 8).Font.Bold = True
                                    oExcel.Cells(linea - 1, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - 1, 8) = totalProyectadoInterno
                                Else
                                    oExcel.Cells(linea - 5, 2).Font.Bold = True
                                    oExcel.Cells(linea - 5, 2).font.Size = 9
                                    oExcel.Cells(linea - 5, 2) = leyendaInterna

                                    oExcel.Cells(linea - 5, 4).Font.Size = 9
                                    oExcel.Cells(linea - 5, 4).Font.Bold = True
                                    oExcel.Cells(linea - 5, 4).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - 5, 4) = totalOriginalInterno
                                    oExcel.Cells(linea - 5, 5).Font.Size = 9
                                    oExcel.Cells(linea - 5, 5).Font.Bold = True
                                    oExcel.Cells(linea - 5, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - 5, 5) = totalRescateInterno
                                    oExcel.Cells(linea - 5, 8).Font.Size = 9
                                    oExcel.Cells(linea - 5, 8).Font.Bold = True
                                    oExcel.Cells(linea - 5, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - 5, 8) = totalProyectadoInterno
                                End If
                            End If

                            totalOriginalInterno = 0
                            totalRescateInterno = 0
                            totalProyectadoInterno = 0

                            cambioTipo = True

                            escribirTran = True

                            activoAnterior = String.Empty
                        End If

                        If escribirTran Then
                            linea = linea + 1
                            If clasificadoPor = "T" Then
                                oExcel.Cells(linea, 2).Font.Size = 9
                                oExcel.Cells(linea, 2) = "Department " + filaData.Item("CODIGO_DIVISION").ToString.Trim + " - " + filaData.Item("DESCRIPCION_DIVISION").ToString.Trim
                            Else
                                oExcel.Cells(linea, 2).Font.Size = 9
                                oExcel.Cells(linea, 2) = "Asset Type " + filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim + " - " + filaData.Item("DESCRIP_TIPO_ACTIVO").ToString.Trim
                            End If

                            escribirTran = False
                        End If

                        If activoActual <> activoAnterior Then
                            activoAnterior = activoActual
                            If primerActivo = False And cambioTipo = False Then
                                '-- Cambia de activo
                                linea = linea + 3
                            End If

                            primerActivo = False

                            If escribirActivo = False Then
                                If cambioActivo = False Then
                                    If cambioTipo = False Then
                                        oExcel.Cells(linea - 2, 3).Font.Bold = True
                                        oExcel.Cells(linea - 2, 3).font.Size = 8
                                        oExcel.Cells(linea - 2, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                                        oExcel.Cells(linea - 2, 3) = leyendaActivo

                                        oExcel.Cells(linea - 2, 4).Font.Size = 8
                                        oExcel.Cells(linea - 2, 4).Font.Bold = True
                                        oExcel.Cells(linea - 2, 4).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                        oExcel.Cells(linea - 2, 4) = totalOriginalActivo
                                        oExcel.Cells(linea - 2, 5).Font.Size = 8
                                        oExcel.Cells(linea - 2, 5).Font.Bold = True
                                        oExcel.Cells(linea - 2, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                        oExcel.Cells(linea - 2, 5) = totalRescateActivo
                                        oExcel.Cells(linea - 2, 8).Font.Size = 8
                                        oExcel.Cells(linea - 2, 8).Font.Bold = True
                                        oExcel.Cells(linea - 2, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                        oExcel.Cells(linea - 2, 8) = totalProyectadoActivo
                                    Else
                                        oExcel.Cells(linea - 4, 3).Font.Bold = True
                                        oExcel.Cells(linea - 4, 3).font.Size = 8
                                        oExcel.Cells(linea - 4, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                                        oExcel.Cells(linea - 4, 3) = leyendaActivo

                                        oExcel.Cells(linea - 4, 4).Font.Size = 8
                                        oExcel.Cells(linea - 4, 4).Font.Bold = True
                                        oExcel.Cells(linea - 4, 4).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                        oExcel.Cells(linea - 4, 4) = totalOriginalActivo
                                        oExcel.Cells(linea - 4, 5).Font.Size = 8
                                        oExcel.Cells(linea - 4, 5).Font.Bold = True
                                        oExcel.Cells(linea - 4, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                        oExcel.Cells(linea - 4, 5) = totalRescateActivo
                                        oExcel.Cells(linea - 4, 8).Font.Size = 8
                                        oExcel.Cells(linea - 4, 8).Font.Bold = True
                                        oExcel.Cells(linea - 4, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                        oExcel.Cells(linea - 4, 8) = totalProyectadoActivo
                                    End If
                                Else
                                    oExcel.Cells(linea - 8, 3).Font.Bold = True
                                    oExcel.Cells(linea - 8, 3).font.Size = 8
                                    oExcel.Cells(linea - 8, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                                    oExcel.Cells(linea - 8, 3) = leyendaActivo

                                    oExcel.Cells(linea - 8, 4).Font.Size = 8
                                    oExcel.Cells(linea - 8, 4).Font.Bold = True
                                    oExcel.Cells(linea - 8, 4).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - 8, 4) = totalOriginalActivo
                                    oExcel.Cells(linea - 8, 5).Font.Size = 8
                                    oExcel.Cells(linea - 8, 5).Font.Bold = True
                                    oExcel.Cells(linea - 8, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - 8, 5) = totalRescateActivo
                                    oExcel.Cells(linea - 8, 8).Font.Size = 8
                                    oExcel.Cells(linea - 8, 8).Font.Bold = True
                                    oExcel.Cells(linea - 8, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    oExcel.Cells(linea - 8, 8) = totalProyectadoActivo
                                End If
                            End If

                            totalOriginalActivo = 0
                            totalRescateActivo = 0
                            totalProyectadoActivo = 0

                            escribirActivo = True
                        End If

                        If escribirActivo Then
                            linea = linea + 1

                            oExcel.Cells(linea, 3).Font.Size = 8
                            oExcel.Cells(linea, 3).NumberFormat = "@"
                            oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                            oExcel.Cells(linea, 3) = filaData.Item("CODIGO_DE_ACTIVO").ToString.Trim
                            oExcel.Cells(linea, 4).Font.Size = 8
                            oExcel.Cells(linea, 4).NumberFormat = "@"
                            oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                            oExcel.Cells(linea, 4) = filaData.Item("DESCRIP_CORTA_ACTIVO").ToString.Trim

                            linea = linea + 1

                            oExcel.Cells(linea, 2).Font.Size = 8
                            oExcel.Cells(linea, 2).NumberFormat = "@"
                            oExcel.Cells(linea, 2) = DevuelveTipoDepreciacion(filaData.Item("TIPO_DEPRECIACION").ToString.Trim, True)
                            oExcel.Cells(linea, 3).Font.Size = 8
                            oExcel.Cells(linea, 3).NumberFormat = "@"
                            oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                            oExcel.Cells(linea, 3) = filaData.Item("FECHA_ADQUISICION").ToString.Trim
                            oExcel.Cells(linea, 4).Font.Size = 8
                            oExcel.Cells(linea, 4).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                            oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                            oExcel.Cells(linea, 4) = filaData.Item("VALOR_ORIGINAL_ACTIV").ToString.Trim
                            If filaData.IsNull("VALOR_ORIGINAL_ACTIV") = False Then
                                totalOriginalExterno = totalOriginalExterno + filaData.Item("VALOR_ORIGINAL_ACTIV")
                                totalOriginalInterno = totalOriginalInterno + filaData.Item("VALOR_ORIGINAL_ACTIV")
                                totalOriginalActivo = totalOriginalActivo + filaData.Item("VALOR_ORIGINAL_ACTIV")
                            End If
                            oExcel.Cells(linea, 5).Font.Size = 8
                            oExcel.Cells(linea, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                            oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                            oExcel.Cells(linea, 5) = filaData.Item("VALOR_RESCATE_ACTIVO").ToString.Trim
                            If filaData.IsNull("VALOR_RESCATE_ACTIVO") = False Then
                                totalRescateActivo = totalRescateActivo + filaData.Item("VALOR_RESCATE_ACTIVO")
                                totalRescateExterno = totalRescateExterno + filaData.Item("VALOR_RESCATE_ACTIVO")
                                totalRescateInterno = totalRescateInterno + filaData.Item("VALOR_RESCATE_ACTIVO")
                            End If
                            oExcel.Cells(linea, 10).Font.Size = 8
                            oExcel.Cells(linea, 10).NumberFormat = "###,###,##0.000000;[Red](###,###,##0.000000)"
                            oExcel.Cells(linea, 10) = filaData.Item("PORCENTAJE_ANUAL_DEP").ToString.Trim

                            escribirActivo = False
                        End If

                        If clasificadoPor = "T" Then
                            leyendaInterna = "Total by Department: " + filaData.Item("CODIGO_DIVISION").ToString.Trim + " - " + filaData.Item("DESCRIPCION_DIVISION").ToString.Trim
                            leyendaExterna = "Total by Asset Type: " + filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim + " - " + filaData.Item("DESCRIP_TIPO_ACTIVO").ToString.Trim
                            leyendaActivo = "TOTAL ASSET: "
                        Else
                            leyendaInterna = "Total by Asset Type: " + filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim + " - " + filaData.Item("DESCRIP_TIPO_ACTIVO").ToString.Trim
                            leyendaExterna = "Total by Department: " + filaData.Item("CODIGO_DIVISION").ToString.Trim + " - " + filaData.Item("DESCRIPCION_DIVISION").ToString.Trim
                            leyendaActivo = "TOTAL ASSET: "
                        End If

                        linea = linea + 1

                        oExcel.Cells(linea, 6).Font.Size = 8
                        oExcel.Cells(linea, 6).NumberFormat = "@"
                        oExcel.Cells(linea, 6) = filaData.Item("PERIODO_DEPRECIACION").ToString.Trim
                        oExcel.Cells(linea, 7).Font.Size = 8
                        oExcel.Cells(linea, 7).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 7) = filaData.Item("VALOR_ACTUAL_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 8).Font.Size = 8
                        oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 8) = filaData.Item("MONTO_ULTIMA_DEPREC").ToString.Trim
                        If filaData.IsNull("MONTO_ULTIMA_DEPREC") = False Then
                            totalProyectadoExterno = totalProyectadoExterno + filaData.Item("MONTO_ULTIMA_DEPREC")
                            totalProyectadoActivo = totalProyectadoActivo + filaData.Item("MONTO_ULTIMA_DEPREC")
                            totalProyectadoInterno = totalProyectadoInterno + filaData.Item("MONTO_ULTIMA_DEPREC")
                        End If
                        oExcel.Cells(linea, 9).Font.Size = 8
                        oExcel.Cells(linea, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 9) = filaData.Item("VALOR_DEP_ACUM_ACT").ToString.Trim

                        oExcel.Cells(1, totalColumnas).font.Size = 9
                        oExcel.Cells(1, totalColumnas).NumberFormat = "@"
                        oExcel.Cells(1, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(1, totalColumnas) = filaData.Item("FechaActual").ToString
                        oExcel.Cells(2, totalColumnas).font.Size = 9
                        oExcel.Cells(2, totalColumnas).NumberFormat = "@"
                        oExcel.Cells(2, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(2, totalColumnas) = filaData.Item("HoraActual").ToString
                        oExcel.Cells(2, 1).font.Size = 9
                        oExcel.Cells(2, 1).NumberFormat = "@"
                        oExcel.Cells(2, 1) = filaData.Item("UsrEjecutor").ToString
                    Next

                    If entro Then
                        linea = linea + 1
                        oExcel.Cells(linea, 3).font.Size = 8
                        oExcel.Cells(linea, 3).Font.Bold = True
                        oExcel.Cells(linea, 3) = leyendaActivo
                        oExcel.Cells(linea, 4).Font.Size = 8
                        oExcel.Cells(linea, 4).Font.Bold = True
                        oExcel.Cells(linea, 4).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 4) = totalOriginalActivo
                        oExcel.Cells(linea, 5).Font.Size = 8
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 5) = totalRescateActivo
                        oExcel.Cells(linea, 8).Font.Size = 8
                        oExcel.Cells(linea, 8).Font.Bold = True
                        oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 8) = totalProyectadoActivo


                        linea = linea + 2
                        oExcel.Cells(linea, 2).font.Size = 9
                        oExcel.Cells(linea, 2).Font.Bold = True
                        oExcel.Cells(linea, 2) = leyendaInterna
                        oExcel.Cells(linea, 4).Font.Size = 9
                        oExcel.Cells(linea, 4).Font.Bold = True
                        oExcel.Cells(linea, 4).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 4) = totalOriginalInterno
                        oExcel.Cells(linea, 5).Font.Size = 9
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 5) = totalRescateInterno
                        oExcel.Cells(linea, 8).Font.Size = 9
                        oExcel.Cells(linea, 8).Font.Bold = True
                        oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 8) = totalProyectadoInterno

                        linea = linea + 2
                        oExcel.Cells(linea, 1).font.Size = 10
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = leyendaExterna
                        oExcel.Cells(linea, 4).Font.Size = 10
                        oExcel.Cells(linea, 4).Font.Bold = True
                        oExcel.Cells(linea, 4).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 4) = totalOriginalExterno
                        oExcel.Cells(linea, 5).Font.Size = 10
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 5) = totalRescateExterno
                        oExcel.Cells(linea, 8).Font.Size = 10
                        oExcel.Cells(linea, 8).Font.Bold = True
                        oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 8) = totalProyectadoExterno

                        totalOriginalGeneral = totalOriginalGeneral + totalOriginalExterno
                        totalRescateGeneral = totalRescateGeneral + totalRescateExterno
                        totalProyectadoGeneral = totalProyectadoGeneral + totalProyectadoExterno

                        '-- Dibujo un cuadro
                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 1), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                        '-- Dibujo el cuadro externo
                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    End If

                    linea = linea + 2

                    oExcel.Cells(linea, 3).font.Size = 11
                    oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 3).Font.Bold = True
                    oExcel.Cells(linea, 3) = "Overall total:"

                    oExcel.Cells(linea, 4).Font.Size = 11
                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 4) = totalOriginalGeneral
                    oExcel.Cells(linea, 5).Font.Size = 11
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 5) = totalRescateGeneral
                    oExcel.Cells(linea, 8).Font.Size = 11
                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 8) = totalProyectadoGeneral
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub TotalmenteDepreciados(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("sp_activos_tot_depreciados")
        End With

        With comando
            .Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Citi.Synergia.Locals.Cache.UsuarioSSO
            .CommandType = CommandType.StoredProcedure
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CrearReporteTotalmenteDepreciados(data, parametros)
    End Sub

    Private Shared Sub CrearReporteTotalmenteDepreciados(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 2
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 16
                    oExcel.Cells(linea, 6) = "FULLY DEPRECIATED ASSETS"

                    linea += 2

                    '-- Los parámetros vienen en orden: fecha inicial, fecha final
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 12
                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 5) = "Start Date:"
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).NumberFormat = "@"
                    oExcel.Cells(linea, 6) = parametros.Item(0)
                    oExcel.Cells(linea, 7).Font.Bold = True
                    oExcel.Cells(linea, 7).font.Size = 12
                    oExcel.Cells(linea, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 7) = "End Date:"
                    oExcel.Cells(linea, 8).font.Size = 11
                    oExcel.Cells(linea, 8).NumberFormat = "@"
                    oExcel.Cells(linea, 8) = parametros.Item(1)

                    linea += 2

                    oExcel.Cells(linea, 6).Font.Size = 10
                    oExcel.Cells(linea, 6) = "Amounts in local currency"

                    linea = linea + 2

                    Dim columnaCuadro As Excel.Range

                    '-- Títulos de las columnas
                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 11
                    oExcel.Cells(linea, 1).ColumnWidth = 18
                    oExcel.Cells(linea, 1) = "Asset ID"
                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4).ColumnWidth = 18
                    oExcel.Cells(linea, 4) = "Depreciation"
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5).ColumnWidth = 15
                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 5) = "Asset original"
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).ColumnWidth = 18
                    oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 6) = "Asset accumulated"
                    oExcel.Cells(linea, 7).Font.Bold = True
                    oExcel.Cells(linea, 7).font.Size = 11
                    oExcel.Cells(linea, 7).ColumnWidth = 15
                    oExcel.Cells(linea, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 7) = "Asset period"
                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).font.Size = 11
                    oExcel.Cells(linea, 8).ColumnWidth = 18
                    oExcel.Cells(linea, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 8) = "Asset depreciation"
                    oExcel.Cells(linea, 9).Font.Bold = True
                    oExcel.Cells(linea, 9).font.Size = 11
                    oExcel.Cells(linea, 9).ColumnWidth = 15
                    oExcel.Cells(linea, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 9) = "Current Value"
                    oExcel.Cells(linea, 10).Font.Bold = True
                    oExcel.Cells(linea, 10).font.Size = 11
                    oExcel.Cells(linea, 10).ColumnWidth = 15
                    oExcel.Cells(linea, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 10) = "Accumulated"
                    oExcel.Cells(linea, 11).Font.Bold = True
                    oExcel.Cells(linea, 11).font.Size = 11
                    oExcel.Cells(linea, 11).ColumnWidth = 13
                    oExcel.Cells(linea, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 11) = "Months x"
                    oExcel.Cells(linea, 13).Font.Bold = True
                    oExcel.Cells(linea, 13).font.Size = 11
                    oExcel.Cells(linea, 13).ColumnWidth = 12
                    oExcel.Cells(linea, 13).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 13) = "Annual %"
                    oExcel.Cells(linea, 14).Font.Bold = True
                    oExcel.Cells(linea, 14).font.Size = 11
                    oExcel.Cells(linea, 14).ColumnWidth = 17
                    oExcel.Cells(linea, 14).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 14) = "Last depreciation"
                    oExcel.Cells(linea, 15).Font.Bold = True
                    oExcel.Cells(linea, 15).font.Size = 11
                    oExcel.Cells(linea, 15).ColumnWidth = 17
                    oExcel.Cells(linea, 15).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 15) = "Acquisition date"
                    oExcel.Cells(linea, 16).Font.Bold = True
                    oExcel.Cells(linea, 16).font.Size = 11
                    oExcel.Cells(linea, 16).ColumnWidth = 17
                    oExcel.Cells(linea, 16).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 16) = "Last depreciation"
                    oExcel.Cells(linea, 17).Font.Bold = True
                    oExcel.Cells(linea, 17).font.Size = 11
                    oExcel.Cells(linea, 17).ColumnWidth = 12
                    oExcel.Cells(linea, 17).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 17) = "Discharge"

                    linea = linea + 1

                    oExcel.Cells(linea, 2).Font.Bold = True
                    oExcel.Cells(linea, 2).font.Size = 11
                    oExcel.Cells(linea, 2).ColumnWidth = 9
                    oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 2) = "Upgrade"
                    oExcel.Cells(linea, 3).Font.Bold = True
                    oExcel.Cells(linea, 3).font.Size = 11
                    oExcel.Cells(linea, 3).ColumnWidth = 35
                    oExcel.Cells(linea, 3) = "Short description"
                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4) = "time"
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 5) = "value"

                    columnaCuadro = oExcel.Range(oExcel.Cells(linea - 1, 1), oExcel.Cells(linea, 5))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 6) = "depreciation"
                    oExcel.Cells(linea, 7).Font.Bold = True
                    oExcel.Cells(linea, 7).font.Size = 11
                    oExcel.Cells(linea, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 7) = "value"
                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).font.Size = 11
                    oExcel.Cells(linea, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 8) = "months"

                    columnaCuadro = oExcel.Range(oExcel.Cells(linea - 1, 6), oExcel.Cells(linea, 8))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    oExcel.Cells(linea, 10).Font.Bold = True
                    oExcel.Cells(linea, 10).font.Size = 11
                    oExcel.Cells(linea, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 10) = "depreciation"
                    oExcel.Cells(linea, 11).Font.Bold = True
                    oExcel.Cells(linea, 11).font.Size = 11
                    oExcel.Cells(linea, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 11) = "depreciation"

                    columnaCuadro = oExcel.Range(oExcel.Cells(linea - 1, 9), oExcel.Cells(linea, 11))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    oExcel.Cells(linea, 12).Font.Bold = True
                    oExcel.Cells(linea, 12).font.Size = 11
                    oExcel.Cells(linea, 12).ColumnWidth = 15
                    oExcel.Cells(linea, 12).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 12) = "Status"
                    oExcel.Cells(linea, 13).Font.Bold = True
                    oExcel.Cells(linea, 13).font.Size = 11
                    oExcel.Cells(linea, 13).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 13) = "depreciated"
                    oExcel.Cells(linea, 14).Font.Bold = True
                    oExcel.Cells(linea, 14).font.Size = 11
                    oExcel.Cells(linea, 14).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 14) = "amount"
                    oExcel.Cells(linea, 16).Font.Bold = True
                    oExcel.Cells(linea, 16).font.Size = 11
                    oExcel.Cells(linea, 16).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 16) = "date"
                    oExcel.Cells(linea, 17).Font.Bold = True
                    oExcel.Cells(linea, 17).font.Size = 11
                    oExcel.Cells(linea, 17).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 17) = "Date"

                    '-- Dibujo un cuadro
                    Dim totalColumnas As Integer = 1
                    totalColumnas = 17

                    columnaCuadro = oExcel.Range(oExcel.Cells(linea - 1, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    Dim lineaInicial As Integer = linea

                    '-- Primer filtro
                    Dim llaveAnterior As String = String.Empty
                    Dim llaveActual As String = String.Empty
                    Dim primerVez As Boolean = True
                    Dim escribirTipo As Boolean = True
                    Dim entro As Boolean = False

                    Dim lineaAux As Integer = 0

                    Dim totalOriginalExterno As Decimal = 0
                    Dim totalOriginalGeneral As Decimal = 0

                    Dim contadorGeneral As Integer = 0
                    Dim contadorExterno As Integer = 0

                    For Each filaData As DataRow In data.Tables(0).Rows
                        llaveActual = filaData.Item("TIPO").ToString.Trim

                        If llaveActual <> llaveAnterior Then
                            llaveAnterior = llaveActual
                            If primerVez = False Then
                                '-- Cambio de activo
                                linea = linea + 5
                            End If

                            primerVez = False

                            If escribirTipo = False Then
                                oExcel.Cells(linea - 3, 1).Font.Size = 10
                                oExcel.Cells(linea - 3, 1).Font.Bold = True
                                oExcel.Cells(linea - 3, 1) = "Total assets:"
                                oExcel.Cells(linea - 3, 2).Font.Size = 10
                                oExcel.Cells(linea - 3, 2).Font.Bold = True
                                oExcel.Cells(linea - 3, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                                oExcel.Cells(linea - 3, 2).NumberFormat = "###,###,##0;[Red](###,###,##0)"
                                oExcel.Cells(linea - 3, 2) = contadorExterno.ToString
                                oExcel.Cells(linea - 3, 4).Font.Size = 10
                                oExcel.Cells(linea - 3, 4).Font.Bold = True
                                oExcel.Cells(linea - 3, 4) = "Assets Sum:"
                                oExcel.Cells(linea - 3, 5).Font.Size = 10
                                oExcel.Cells(linea - 3, 5).Font.Bold = True
                                oExcel.Cells(linea - 3, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 5) = totalOriginalExterno

                                totalOriginalGeneral = totalOriginalGeneral + totalOriginalExterno

                                contadorGeneral = contadorGeneral + contadorExterno

                                totalOriginalExterno = 0
                                contadorExterno = 0

                                '-- Dibujo los cuadros internos
                                columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 1), oExcel.Cells(linea - 3, 5))
                                columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                                columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 6), oExcel.Cells(linea - 3, 8))
                                columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                                columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 9), oExcel.Cells(linea - 3, 11))
                                columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                                '-- Dibujo un cuadro externo
                                columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 1), oExcel.Cells(linea - 3, totalColumnas))
                                columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                            End If

                            entro = True

                            escribirTipo = True
                        End If

                        If escribirTipo Then
                            lineaAux = linea

                            oExcel.Cells(linea, 1).Font.Bold = True
                            oExcel.Cells(linea, 1).Font.Size = 10
                            oExcel.Cells(linea, 1) = "Asset Type:"
                            oExcel.Cells(linea, 2).Font.Bold = True
                            oExcel.Cells(linea, 2).Font.Size = 10
                            oExcel.Cells(linea, 2) = filaData.Item("TIPO").ToString.Trim
                            oExcel.Cells(linea, 3).Font.Size = 10
                            oExcel.Cells(linea, 3) = filaData.Item("DESC_TIPO").ToString.Trim

                            escribirTipo = False

                            linea = linea + 1
                        End If

                        linea = linea + 1

                        oExcel.Cells(linea, 1).Font.Size = 9
                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = filaData.Item("CODIGO_DE_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 2).Font.Size = 9
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 2) = filaData.Item("MEJORA_CORRELATIVO").ToString.Trim
                        oExcel.Cells(linea, 3).Font.Size = 9
                        oExcel.Cells(linea, 3).NumberFormat = "@"
                        oExcel.Cells(linea, 3) = filaData.Item("DESCRIP_CORTA_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 4).Font.Size = 9
                        oExcel.Cells(linea, 4).NumberFormat = "@"
                        oExcel.Cells(linea, 4) = filaData.Item("TIEMPO_DEPRECIACION").ToString.Trim
                        oExcel.Cells(linea, 5).Font.Size = 9
                        oExcel.Cells(linea, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 5) = filaData.Item("VALOR_ORIGINAL_ACTIV").ToString.Trim
                        If filaData.IsNull("VALOR_ORIGINAL_ACTIV") = False Then
                            totalOriginalExterno = totalOriginalExterno + filaData.Item("VALOR_ORIGINAL_ACTIV")
                        End If

                        contadorExterno = contadorExterno + 1

                        oExcel.Cells(linea, 6).Font.Size = 9
                        oExcel.Cells(linea, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 6) = filaData.Item("DEP_ACUM_PERIODO").ToString.Trim
                        oExcel.Cells(linea, 7).Font.Size = 9
                        oExcel.Cells(linea, 7).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 7) = filaData.Item("VALOR_ACTUAL_PERIODO").ToString.Trim
                        oExcel.Cells(linea, 8).Font.Size = 9
                        oExcel.Cells(linea, 8).NumberFormat = "###,###,##0;[Red](###,###,##0)"
                        oExcel.Cells(linea, 8) = filaData.Item("MESES_DEP_PERIODO").ToString.Trim
                        oExcel.Cells(linea, 9).Font.Size = 9
                        oExcel.Cells(linea, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 9) = filaData.Item("VALOR_ACTUAL").ToString.Trim
                        oExcel.Cells(linea, 10).Font.Size = 9
                        oExcel.Cells(linea, 10).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 10) = filaData.Item("DEP_ACUM").ToString.Trim
                        oExcel.Cells(linea, 11).Font.Size = 9
                        oExcel.Cells(linea, 11).NumberFormat = "###,###,##0;[Red](###,###,##0)"
                        oExcel.Cells(linea, 11) = filaData.Item("MESES x DEP").ToString.Trim
                        oExcel.Cells(linea, 12).Font.Size = 9
                        oExcel.Cells(linea, 12).NumberFormat = "@"
                        oExcel.Cells(linea, 12).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 12) = DevuelveEstado(filaData.Item("ESTATUS").ToString.Trim, False)
                        oExcel.Cells(linea, 13).Font.Size = 9
                        oExcel.Cells(linea, 13).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        If filaData.IsNull("PORCENTAJE_ANUAL_DEP") = False Then
                            oExcel.Cells(linea, 13) = (filaData.Item("PORCENTAJE_ANUAL_DEP") * 100).ToString.Trim
                        End If
                        oExcel.Cells(linea, 14).Font.Size = 9
                        oExcel.Cells(linea, 14).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 14) = filaData.Item("MONTO_ULTIMA_DEPREC").ToString.Trim
                        oExcel.Cells(linea, 15).Font.Size = 9
                        oExcel.Cells(linea, 15).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 15).NumberFormat = "@"
                        Dim fecha As String()
                        fecha = filaData.Item("FECHA_ADQUISICION").ToString.Split("/")
                        oExcel.Cells(linea, 15) = fecha(0) + "/" + fecha(1) + "/" + fecha(2).Substring(0, 4)

                        oExcel.Cells(linea, 16).Font.Size = 9
                        oExcel.Cells(linea, 16).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 16).NumberFormat = "@"
                        If filaData.IsNull("FECHA_ULTIMA_DEPREC") = False Then
                            Dim fechaDeprec As String()
                            fechaDeprec = filaData.Item("FECHA_ULTIMA_DEPREC").ToString.Split("/")
                            oExcel.Cells(linea, 16) = fechaDeprec(0) + "/" + fechaDeprec(1) + "/" + fechaDeprec(2).Substring(0, 4)
                        End If

                        oExcel.Cells(linea, 17).Font.Size = 9
                        oExcel.Cells(linea, 17).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 17).NumberFormat = "@"
                        If filaData.IsNull("FECHA_BAJA_ACTIVO") = False Then
                            Dim fechaDeprec As String()
                            fechaDeprec = filaData.Item("FECHA_BAJA_ACTIVO").ToString.Split("/")
                            oExcel.Cells(linea, 17) = fechaDeprec(0) + "/" + fechaDeprec(1) + "/" + fechaDeprec(2).Substring(0, 4)
                        End If
                    Next

                    Dim spGT As New CultureInfo("es-GT")

                    oExcel.Cells(2, 1).font.Size = 9
                    oExcel.Cells(2, 1).NumberFormat = "@"
                    oExcel.Cells(2, 1) = parametros(2)
                    oExcel.Cells(1, totalColumnas).font.Size = 9
                    oExcel.Cells(1, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(1, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(1, totalColumnas) = Now.Date.ToString("d", spGT)
                    oExcel.Cells(2, totalColumnas).font.Size = 9
                    oExcel.Cells(2, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(2, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(2, totalColumnas) = DateTime.Now.ToString("T", spGT)

                    If entro Then
                        linea = linea + 2
                        oExcel.Cells(linea, 1).Font.Size = 10
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "Total assets:"
                        oExcel.Cells(linea, 2).Font.Size = 10
                        oExcel.Cells(linea, 2).Font.Bold = True
                        oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 2).NumberFormat = "###,###,##0;[Red](###,###,##0)"
                        oExcel.Cells(linea, 2) = contadorExterno.ToString
                        oExcel.Cells(linea, 4).Font.Size = 10
                        oExcel.Cells(linea, 4).Font.Bold = True
                        oExcel.Cells(linea, 4) = "Assets Sum:"
                        oExcel.Cells(linea, 5).Font.Size = 10
                        oExcel.Cells(linea, 5).Font.Bold = True
                        oExcel.Cells(linea, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 5) = totalOriginalExterno

                        contadorGeneral = contadorGeneral + contadorExterno
                        totalOriginalGeneral = totalOriginalGeneral + totalOriginalExterno

                        '-- Dibujo los cuadros internos
                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 1), oExcel.Cells(linea, 5))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 6), oExcel.Cells(linea, 8))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 9), oExcel.Cells(linea, 11))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                        '-- Dibujo un cuadro
                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 1), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                        '-- Dibujo el cuadro externo
                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    End If

                    linea = linea + 2

                    oExcel.Cells(linea, 1).font.Size = 11
                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1) = "Overall total assets:"
                    oExcel.Cells(linea, 2).Font.Size = 11
                    oExcel.Cells(linea, 2).Font.Bold = True
                    oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 2).NumberFormat = "###,###,##0;[Red](###,###,##0)"
                    oExcel.Cells(linea, 2) = contadorGeneral.ToString

                    oExcel.Cells(linea, 4).Font.Size = 11
                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4) = "Overall sum assets:"
                    oExcel.Cells(linea, 5).Font.Size = 11
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 5) = totalOriginalGeneral
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub InformacionTiposDeActivos(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT r.CODIGO_ACT")
            .Append("     , r.MEJORA")
            .Append("     , r.DESCRIP_CORTA_ACTIVO")
            .Append("     , r.REFERENCIA_ACTIVO")
            .Append("     , r.DESCRIPCION_MARCA")
            .Append("     , r.CAMPO_TITULO1")
            .Append("     , r.CAMPO_TITULO2")
            .Append("     , r.VALOR2")
            .Append("     , r.CAMPO_TITULO3")
            .Append("     , r.VALOR3")
            .Append("     , r.CAMPO_TITULO4")
            .Append("     , r.VALOR4")
            .Append("     , r.CAMPO_TITULO5")
            .Append("     , r.VALOR5")
            .Append("     , r.CAMPO_TITULO6")
            .Append("     , r.VALOR6")
            .Append("     , r.CAMPO_TITULO7")
            .Append("     , r.VALOR7")
            .Append("     , r.CAMPO_TITULO8")
            .Append("     , r.VALOR8")
            .Append("     , r.CAMPO_TITULO9")
            .Append("     , r.VALOR9")
            .Append("     , r.CAMPO_TITULO10")
            .Append("     , r.VALOR10")
            .Append("     , r.CAMPO_TITULO11")
            .Append("     , r.VALOR11")
            .Append("     , r.DECRIP_TIPO_ACTIVO")
            .Append("     , r.VALOR1")
            .Append("     , Convert(Varchar(10), getdate(), 103) As FechaActual")
            .Append("     , Convert(Varchar(10), getdate(), 108) As HoraActual")
            .Append("     , '" & Citi.Synergia.Locals.Cache.UsuarioSSO & "' As UsrEjecutor")
            .Append("  FROM RTP_TIPOS_DE_ACTIVOS r")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CrearReporteInformacionTiposDeActivos(data, parametros)
    End Sub

    Private Shared Sub CrearReporteInformacionTiposDeActivos(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 2
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 16
                    oExcel.Cells(linea, 5) = parametros(0)

                    linea += 2

                    Dim columnaCuadro As Excel.Range

                    Dim primervez As Boolean = True

                    '-- Dibujo un cuadro
                    Dim totalColumnas As Integer = 1
                    totalColumnas = 16

                    For Each filaData As DataRow In data.Tables(0).Rows
                        If primervez Then
                            oExcel.Cells(linea, 5).Font.Bold = True
                            oExcel.Cells(linea, 5).font.Size = 13
                            oExcel.Cells(linea, 5) = filaData.Item("DECRIP_TIPO_ACTIVO").ToString.Trim

                            linea += 2

                            '-- Títulos de las columnas
                            oExcel.Cells(linea, 1).Font.Bold = True
                            oExcel.Cells(linea, 1).font.Size = 11
                            oExcel.Cells(linea, 1).ColumnWidth = 18
                            oExcel.Cells(linea, 1) = "ID"
                            oExcel.Cells(linea, 2).Font.Bold = True
                            oExcel.Cells(linea, 2).font.Size = 11
                            oExcel.Cells(linea, 2).ColumnWidth = 11
                            oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            oExcel.Cells(linea, 2) = "UPGRADE"
                            oExcel.Cells(linea, 3).Font.Bold = True
                            oExcel.Cells(linea, 3).font.Size = 11
                            oExcel.Cells(linea, 3).ColumnWidth = 35
                            oExcel.Cells(linea, 3) = "DESCRIPTION"
                            oExcel.Cells(linea, 4).Font.Bold = True
                            oExcel.Cells(linea, 4).font.Size = 11
                            oExcel.Cells(linea, 4).ColumnWidth = 18
                            oExcel.Cells(linea, 4) = "INVENTORY ID"
                            oExcel.Cells(linea, 5).Font.Bold = True
                            oExcel.Cells(linea, 5).font.Size = 11
                            oExcel.Cells(linea, 5).ColumnWidth = 26
                            oExcel.Cells(linea, 5) = "BRAND DESCRIPTION"
                            oExcel.Cells(linea, 6).Font.Bold = True
                            oExcel.Cells(linea, 6).font.Size = 11
                            oExcel.Cells(linea, 6).ColumnWidth = 11
                            oExcel.Cells(linea, 6) = filaData.Item("CAMPO_TITULO1").ToString.Trim
                            oExcel.Cells(linea, 7).Font.Bold = True
                            oExcel.Cells(linea, 7).font.Size = 11
                            oExcel.Cells(linea, 7).ColumnWidth = 11
                            oExcel.Cells(linea, 7) = filaData.Item("CAMPO_TITULO2").ToString.Trim
                            oExcel.Cells(linea, 8).Font.Bold = True
                            oExcel.Cells(linea, 8).font.Size = 11
                            oExcel.Cells(linea, 8).ColumnWidth = 11
                            oExcel.Cells(linea, 8) = filaData.Item("CAMPO_TITULO3").ToString.Trim
                            oExcel.Cells(linea, 9).Font.Bold = True
                            oExcel.Cells(linea, 9).font.Size = 11
                            oExcel.Cells(linea, 9).ColumnWidth = 11
                            oExcel.Cells(linea, 9) = filaData.Item("CAMPO_TITULO4").ToString.Trim
                            oExcel.Cells(linea, 10).Font.Bold = True
                            oExcel.Cells(linea, 10).font.Size = 11
                            oExcel.Cells(linea, 10).ColumnWidth = 11
                            oExcel.Cells(linea, 10) = filaData.Item("CAMPO_TITULO5").ToString.Trim
                            oExcel.Cells(linea, 11).Font.Bold = True
                            oExcel.Cells(linea, 11).font.Size = 11
                            oExcel.Cells(linea, 11).ColumnWidth = 11
                            oExcel.Cells(linea, 11) = filaData.Item("CAMPO_TITULO6").ToString.Trim
                            oExcel.Cells(linea, 12).Font.Bold = True
                            oExcel.Cells(linea, 12).font.Size = 11
                            oExcel.Cells(linea, 12).ColumnWidth = 11
                            oExcel.Cells(linea, 12) = filaData.Item("CAMPO_TITULO7").ToString.Trim
                            oExcel.Cells(linea, 13).Font.Bold = True
                            oExcel.Cells(linea, 13).font.Size = 11
                            oExcel.Cells(linea, 13).ColumnWidth = 11
                            oExcel.Cells(linea, 13) = filaData.Item("CAMPO_TITULO8").ToString.Trim
                            oExcel.Cells(linea, 14).Font.Bold = True
                            oExcel.Cells(linea, 14).font.Size = 11
                            oExcel.Cells(linea, 14).ColumnWidth = 11
                            oExcel.Cells(linea, 14) = filaData.Item("CAMPO_TITULO9").ToString.Trim
                            oExcel.Cells(linea, 15).Font.Bold = True
                            oExcel.Cells(linea, 15).font.Size = 11
                            oExcel.Cells(linea, 15).ColumnWidth = 11
                            oExcel.Cells(linea, 15) = filaData.Item("CAMPO_TITULO10").ToString.Trim
                            oExcel.Cells(linea, 16).Font.Bold = True
                            oExcel.Cells(linea, 16).font.Size = 11
                            oExcel.Cells(linea, 16).ColumnWidth = 11
                            oExcel.Cells(linea, 16) = filaData.Item("CAMPO_TITULO11").ToString.Trim

                            columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                            columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                            primervez = False
                        End If

                        linea = linea + 1

                        oExcel.Cells(linea, 1).Font.Size = 10
                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = filaData.Item("CODIGO_ACT").ToString.Trim
                        oExcel.Cells(linea, 2).Font.Size = 10
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 2) = filaData.Item("MEJORA").ToString.Trim
                        oExcel.Cells(linea, 3).Font.Size = 10
                        oExcel.Cells(linea, 3).NumberFormat = "@"
                        oExcel.Cells(linea, 3) = filaData.Item("DESCRIP_CORTA_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 4).Font.Size = 10
                        oExcel.Cells(linea, 4).NumberFormat = "@"
                        oExcel.Cells(linea, 4) = filaData.Item("REFERENCIA_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 5).Font.Size = 10
                        oExcel.Cells(linea, 5).NumberFormat = "@"
                        oExcel.Cells(linea, 5) = filaData.Item("DESCRIPCION_MARCA").ToString.Trim
                        oExcel.Cells(linea, 6).Font.Size = 10
                        oExcel.Cells(linea, 6).NumberFormat = "@"
                        oExcel.Cells(linea, 6) = filaData.Item("VALOR1").ToString.Trim
                        oExcel.Cells(linea, 7).Font.Size = 10
                        oExcel.Cells(linea, 7).NumberFormat = "@"
                        oExcel.Cells(linea, 7) = filaData.Item("VALOR2").ToString.Trim
                        oExcel.Cells(linea, 8).Font.Size = 10
                        oExcel.Cells(linea, 8).NumberFormat = "@"
                        oExcel.Cells(linea, 8) = filaData.Item("VALOR3").ToString.Trim
                        oExcel.Cells(linea, 9).Font.Size = 10
                        oExcel.Cells(linea, 9).NumberFormat = "@"
                        oExcel.Cells(linea, 9) = filaData.Item("VALOR4").ToString.Trim
                        oExcel.Cells(linea, 10).Font.Size = 10
                        oExcel.Cells(linea, 10).NumberFormat = "@"
                        oExcel.Cells(linea, 10) = filaData.Item("VALOR5").ToString.Trim
                        oExcel.Cells(linea, 11).Font.Size = 10
                        oExcel.Cells(linea, 11).NumberFormat = "@"
                        oExcel.Cells(linea, 11) = filaData.Item("VALOR6").ToString.Trim
                        oExcel.Cells(linea, 12).Font.Size = 10
                        oExcel.Cells(linea, 12).NumberFormat = "@"
                        oExcel.Cells(linea, 12) = filaData.Item("VALOR7").ToString.Trim
                        oExcel.Cells(linea, 13).Font.Size = 10
                        oExcel.Cells(linea, 13).NumberFormat = "@"
                        oExcel.Cells(linea, 13) = filaData.Item("VALOR8").ToString.Trim
                        oExcel.Cells(linea, 14).Font.Size = 10
                        oExcel.Cells(linea, 14).NumberFormat = "@"
                        oExcel.Cells(linea, 14) = filaData.Item("VALOR9").ToString.Trim
                        oExcel.Cells(linea, 15).Font.Size = 10
                        oExcel.Cells(linea, 15).NumberFormat = "@"
                        oExcel.Cells(linea, 15) = filaData.Item("VALOR10").ToString.Trim
                        oExcel.Cells(linea, 16).Font.Size = 10
                        oExcel.Cells(linea, 16).NumberFormat = "@"
                        oExcel.Cells(linea, 16) = filaData.Item("VALOR11").ToString.Trim
                    Next

                    Dim spGT As New CultureInfo("es-GT")

                    oExcel.Cells(2, 1).font.Size = 9
                    oExcel.Cells(2, 1).NumberFormat = "@"
                    oExcel.Cells(2, 1) = parametros(1)
                    oExcel.Cells(1, totalColumnas).font.Size = 9
                    oExcel.Cells(1, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(1, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(1, totalColumnas) = Now.Date.ToString("d", spGT)
                    oExcel.Cells(2, totalColumnas).font.Size = 9
                    oExcel.Cells(2, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(2, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(2, totalColumnas) = DateTime.Now.ToString("T", spGT)
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub ActivosDepreciados(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SP_ACTIVOS_DEPRECIADOS")
        End With

        With comando
            .Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Citi.Synergia.Locals.Cache.UsuarioSSO
            .CommandType = CommandType.StoredProcedure
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CrearReporteActivosDepreciados(data, parametros)
    End Sub

    Private Shared Sub CrearReporteActivosDepreciados(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 2

                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 16
                    oExcel.Cells(linea, 6) = "DEPRECIATED ASSETS"

                    linea += 2

                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 14
                    oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 6) = "TO DATE:"
                    oExcel.Cells(linea, 7).Font.Bold = True
                    oExcel.Cells(linea, 7).font.Size = 14
                    oExcel.Cells(linea, 7).NumberFormat = "@"
                    oExcel.Cells(linea, 7) = parametros(1)

                    linea += 2

                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 12
                    oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 6) = "Status:"
                    oExcel.Cells(linea, 7).Font.Bold = True
                    oExcel.Cells(linea, 7).font.Size = 12
                    oExcel.Cells(linea, 7).NumberFormat = "@"
                    oExcel.Cells(linea, 7) = DevuelveEstado(parametros(0), False)

                    linea += 2

                    '-- Títulos de las columnas
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 6) = "PENDING MONTHS"
                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).font.Size = 11
                    oExcel.Cells(linea, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 8) = "ACCUMULATED"
                    oExcel.Cells(linea, 9).Font.Bold = True
                    oExcel.Cells(linea, 9).font.Size = 11
                    oExcel.Cells(linea, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 9) = "CURRENT"
                    oExcel.Cells(linea, 10).Font.Bold = True
                    oExcel.Cells(linea, 10).font.Size = 11
                    oExcel.Cells(linea, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 10) = "TRANSACTION"
                    oExcel.Cells(linea, 14).Font.Bold = True
                    oExcel.Cells(linea, 14).font.Size = 11
                    oExcel.Cells(linea, 14).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 14) = "CURRENT VALUE"
                    oExcel.Cells(linea, 15).Font.Bold = True
                    oExcel.Cells(linea, 15).font.Size = 11
                    oExcel.Cells(linea, 15).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 15) = "LAST DEPRECIATION"

                    linea = linea + 1

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 11
                    oExcel.Cells(linea, 1).ColumnWidth = 20
                    oExcel.Cells(linea, 1) = "ASSET ID"
                    oExcel.Cells(linea, 2).Font.Bold = True
                    oExcel.Cells(linea, 2).font.Size = 11
                    oExcel.Cells(linea, 2).ColumnWidth = 11
                    oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 2) = "UPGRADE"
                    oExcel.Cells(linea, 3).Font.Bold = True
                    oExcel.Cells(linea, 3).font.Size = 11
                    oExcel.Cells(linea, 3).ColumnWidth = 35
                    oExcel.Cells(linea, 3) = "SHORT DESCRIPTION"
                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 11
                    oExcel.Cells(linea, 4).ColumnWidth = 15
                    oExcel.Cells(linea, 4) = "DEPARTMENT ID"
                    oExcel.Cells(linea, 5).Font.Bold = True
                    oExcel.Cells(linea, 5).font.Size = 11
                    oExcel.Cells(linea, 5).ColumnWidth = 30
                    oExcel.Cells(linea, 5) = "DEPARTMENT DESCRIPTION"
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 11
                    oExcel.Cells(linea, 6).ColumnWidth = 19
                    oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 6) = "TO DEPRECIATE"
                    oExcel.Cells(linea, 7).Font.Bold = True
                    oExcel.Cells(linea, 7).font.Size = 11
                    oExcel.Cells(linea, 7).ColumnWidth = 19
                    oExcel.Cells(linea, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 7) = "ORIGINAL VALUE"
                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).font.Size = 11
                    oExcel.Cells(linea, 8).ColumnWidth = 22
                    oExcel.Cells(linea, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 8) = "DEPRECIATION PERIOD"
                    oExcel.Cells(linea, 9).Font.Bold = True
                    oExcel.Cells(linea, 9).font.Size = 11
                    oExcel.Cells(linea, 9).ColumnWidth = 15
                    oExcel.Cells(linea, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 9) = "VALUE"
                    oExcel.Cells(linea, 10).Font.Bold = True
                    oExcel.Cells(linea, 10).font.Size = 11
                    oExcel.Cells(linea, 10).ColumnWidth = 19
                    oExcel.Cells(linea, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 10) = "DEPRECIATION"
                    oExcel.Cells(linea, 11).Font.Bold = True
                    oExcel.Cells(linea, 11).font.Size = 11
                    oExcel.Cells(linea, 11).ColumnWidth = 16
                    oExcel.Cells(linea, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 11) = "DEPRECIATION %"
                    oExcel.Cells(linea, 12).Font.Bold = True
                    oExcel.Cells(linea, 12).font.Size = 11
                    oExcel.Cells(linea, 12).ColumnWidth = 18
                    oExcel.Cells(linea, 12).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 12) = "STATUS"
                    oExcel.Cells(linea, 13).Font.Bold = True
                    oExcel.Cells(linea, 13).font.Size = 11
                    oExcel.Cells(linea, 13).ColumnWidth = 19
                    oExcel.Cells(linea, 13).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 13) = "ACQUISITION DATE"
                    oExcel.Cells(linea, 14).Font.Bold = True
                    oExcel.Cells(linea, 14).font.Size = 11
                    oExcel.Cells(linea, 14).ColumnWidth = 18
                    oExcel.Cells(linea, 14).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 14) = "CALCULATED"
                    oExcel.Cells(linea, 15).Font.Bold = True
                    oExcel.Cells(linea, 15).font.Size = 11
                    oExcel.Cells(linea, 15).ColumnWidth = 20
                    oExcel.Cells(linea, 15).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 15) = "DATE"

                    '-- Dibujo un cuadro
                    Dim totalColumnas As Integer = 1
                    totalColumnas = 15

                    Dim columnaCuadro As Excel.Range
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea - 1, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    Dim lineaInicial As Integer = linea

                    '-- Primer filtro
                    Dim llaveAnterior As String = String.Empty
                    Dim llaveActual As String = String.Empty
                    Dim primerVez As Boolean = True
                    Dim escribirTipo As Boolean = True
                    Dim entro As Boolean = False

                    Dim lineaAux As Integer = 0

                    Dim totalOriginalExterno As Decimal = 0
                    Dim totalOriginalGeneral As Decimal = 0
                    Dim totalAcumuladoExterno As Decimal = 0
                    Dim totalAcumuladoGeneral As Decimal = 0
                    Dim totalActualExterno As Decimal = 0
                    Dim totalActualGeneral As Decimal = 0

                    Dim contadorGeneral As Integer = 0
                    Dim contadorExterno As Integer = 0

                    Dim estadoSeleccionado As String = parametros(0)

                    For Each filaData As DataRow In data.Tables(0).Rows
                        If filaData.Item("ESTATUS").ToString <> estadoSeleccionado Then
                            Continue For
                        End If

                        llaveActual = filaData.Item("TIPO_ACTIVO").ToString.Trim

                        If llaveActual <> llaveAnterior Then
                            llaveAnterior = llaveActual
                            If primerVez = False Then
                                '-- Cambio de activo
                                linea = linea + 5
                            End If

                            primerVez = False

                            If escribirTipo = False Then
                                oExcel.Cells(linea - 3, 1).Font.Size = 10
                                oExcel.Cells(linea - 3, 1).Font.Bold = True
                                oExcel.Cells(linea - 3, 1) = "Total assets:"
                                oExcel.Cells(linea - 3, 2).Font.Size = 10
                                oExcel.Cells(linea - 3, 2).Font.Bold = True
                                oExcel.Cells(linea - 3, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                                oExcel.Cells(linea - 3, 2).NumberFormat = "###,###,##0;[Red](###,###,##0)"
                                oExcel.Cells(linea - 3, 2) = contadorExterno.ToString
                                oExcel.Cells(linea - 3, 6).Font.Size = 10
                                oExcel.Cells(linea - 3, 6).Font.Bold = True
                                oExcel.Cells(linea - 3, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                                oExcel.Cells(linea - 3, 6) = "Assets Sum:"
                                oExcel.Cells(linea - 3, 7).Font.Size = 10
                                oExcel.Cells(linea - 3, 7).Font.Bold = True
                                oExcel.Cells(linea - 3, 7).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 7) = totalOriginalExterno
                                oExcel.Cells(linea - 3, 8).Font.Size = 10
                                oExcel.Cells(linea - 3, 8).Font.Bold = True
                                oExcel.Cells(linea - 3, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 8) = totalAcumuladoExterno
                                oExcel.Cells(linea - 3, 9).Font.Size = 10
                                oExcel.Cells(linea - 3, 9).Font.Bold = True
                                oExcel.Cells(linea - 3, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea - 3, 9) = totalActualExterno

                                totalOriginalGeneral = totalOriginalGeneral + totalOriginalExterno
                                totalAcumuladoGeneral = totalAcumuladoGeneral + totalAcumuladoExterno
                                totalActualGeneral = totalActualGeneral + totalActualExterno
                                contadorGeneral = contadorGeneral + contadorExterno

                                totalOriginalExterno = 0
                                totalAcumuladoExterno = 0
                                totalActualExterno = 0
                                contadorExterno = 0

                                '-- Dibujo un cuadro externo
                                columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 1), oExcel.Cells(linea - 3, totalColumnas))
                                columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                            End If

                            entro = True

                            escribirTipo = True
                        End If

                        If escribirTipo Then
                            lineaAux = linea

                            oExcel.Cells(linea, 1).Font.Bold = True
                            oExcel.Cells(linea, 1).Font.Size = 10
                            oExcel.Cells(linea, 1) = "Asset Type:"
                            oExcel.Cells(linea, 3).Font.Bold = True
                            oExcel.Cells(linea, 3).Font.Size = 10
                            oExcel.Cells(linea, 3) = filaData.Item("TIPO_ACTIVO").ToString.Trim
                            oExcel.Cells(linea, 4).Font.Bold = True
                            oExcel.Cells(linea, 4).Font.Size = 10
                            oExcel.Cells(linea, 4) = filaData.Item("DESCRIP_TIPO_ACTIVO").ToString.Trim

                            escribirTipo = False
                        End If

                        linea = linea + 1

                        oExcel.Cells(linea, 1).Font.Size = 9
                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        'oExcel.Cells(linea, 1) = filaData.Item("TIPO_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 1) = filaData.Item("CODIGO").ToString.Trim
                        oExcel.Cells(linea, 2).Font.Size = 9
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 2) = filaData.Item("CORREL").ToString.Trim
                        oExcel.Cells(linea, 3).Font.Size = 9
                        oExcel.Cells(linea, 3).NumberFormat = "@"
                        oExcel.Cells(linea, 3) = filaData.Item("DESCRIPCION").ToString.Trim
                        oExcel.Cells(linea, 4).Font.Size = 9
                        oExcel.Cells(linea, 4).NumberFormat = "@"
                        oExcel.Cells(linea, 4) = filaData.Item("DIVISION").ToString.Trim
                        oExcel.Cells(linea, 5).Font.Size = 9
                        oExcel.Cells(linea, 5).NumberFormat = "@"
                        oExcel.Cells(linea, 5) = filaData.Item("DESCRIPCION_DIVISION").ToString.Trim
                        oExcel.Cells(linea, 6).Font.Size = 9
                        oExcel.Cells(linea, 6).NumberFormat = "@"
                        oExcel.Cells(linea, 6) = filaData.Item("MESES_PDTES_DEPREC").ToString.Trim
                        oExcel.Cells(linea, 7).Font.Size = 9
                        oExcel.Cells(linea, 7).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 7) = filaData.Item("VALOR_ORIGINAL").ToString.Trim
                        If filaData.IsNull("VALOR_ORIGINAL") = False Then
                            totalOriginalExterno = totalOriginalExterno + filaData.Item("VALOR_ORIGINAL")
                        End If
                        oExcel.Cells(linea, 8).Font.Size = 9
                        oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 8) = filaData.Item("VALOR_DEPRECIADO").ToString.Trim
                        If filaData.IsNull("VALOR_DEPRECIADO") = False Then
                            totalAcumuladoExterno = totalAcumuladoExterno + filaData.Item("VALOR_DEPRECIADO")
                        End If
                        oExcel.Cells(linea, 9).Font.Size = 9
                        oExcel.Cells(linea, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 9) = filaData.Item("VALOR_ACTUAL").ToString.Trim
                        If filaData.IsNull("VALOR_ACTUAL") = False Then
                            totalActualExterno = totalActualExterno + filaData.Item("VALOR_ACTUAL")
                        End If

                        contadorExterno = contadorExterno + 1

                        oExcel.Cells(linea, 10).Font.Size = 9
                        oExcel.Cells(linea, 10).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 10) = filaData.Item("DEP_MOVIMS").ToString.Trim
                        oExcel.Cells(linea, 11).Font.Size = 9
                        oExcel.Cells(linea, 11).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        If filaData.IsNull("PORC_DEPREC") = False Then
                            oExcel.Cells(linea, 11) = filaData.Item("PORC_DEPREC") * 100
                        End If
                        oExcel.Cells(linea, 12).Font.Size = 9
                        oExcel.Cells(linea, 12).NumberFormat = "@"
                        oExcel.Cells(linea, 12).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 12) = DevuelveEstado(filaData.Item("ESTATUS").ToString.Trim, False)
                        oExcel.Cells(linea, 13).Font.Size = 9
                        oExcel.Cells(linea, 13).NumberFormat = "@"
                        oExcel.Cells(linea, 13).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 13) = filaData.Item("FECHA_ADQUISICION").ToString.Trim
                        oExcel.Cells(linea, 14).Font.Size = 9
                        oExcel.Cells(linea, 14).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 14) = filaData.Item("V_ACTUAL_CALC").ToString.Trim
                        oExcel.Cells(linea, 15).Font.Size = 9
                        oExcel.Cells(linea, 15).NumberFormat = "@"
                        oExcel.Cells(linea, 15).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 15) = filaData.Item("fecha_ultima_deprec").ToString.Trim
                    Next

                    Dim spGT As New CultureInfo("es-GT")

                    oExcel.Cells(2, 1).font.Size = 9
                    oExcel.Cells(2, 1).NumberFormat = "@"
                    oExcel.Cells(2, 1) = parametros(2)
                    oExcel.Cells(1, totalColumnas).font.Size = 9
                    oExcel.Cells(1, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(1, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(1, totalColumnas) = Now.Date.ToString("d", spGT)
                    oExcel.Cells(2, totalColumnas).font.Size = 9
                    oExcel.Cells(2, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(2, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(2, totalColumnas) = DateTime.Now.ToString("T", spGT)

                    If entro Then
                        linea = linea + 2
                        oExcel.Cells(linea, 1).Font.Size = 10
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "Total assets:"
                        oExcel.Cells(linea, 2).Font.Size = 10
                        oExcel.Cells(linea, 2).Font.Bold = True
                        oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 2).NumberFormat = "###,###,##0;[Red](###,###,##0)"
                        oExcel.Cells(linea, 2) = contadorExterno.ToString
                        oExcel.Cells(linea, 6).Font.Size = 10
                        oExcel.Cells(linea, 6).Font.Bold = True
                        oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 6) = "Assets Sum:"
                        oExcel.Cells(linea, 7).Font.Size = 10
                        oExcel.Cells(linea, 7).Font.Bold = True
                        oExcel.Cells(linea, 7).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 7) = totalOriginalExterno
                        oExcel.Cells(linea, 8).Font.Size = 10
                        oExcel.Cells(linea, 8).Font.Bold = True
                        oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 8) = totalAcumuladoExterno
                        oExcel.Cells(linea, 9).Font.Size = 10
                        oExcel.Cells(linea, 9).Font.Bold = True
                        oExcel.Cells(linea, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 9) = totalActualExterno

                        contadorGeneral = contadorGeneral + contadorExterno
                        totalOriginalGeneral = totalOriginalGeneral + totalOriginalExterno
                        totalAcumuladoGeneral = totalAcumuladoGeneral + totalAcumuladoExterno
                        totalActualGeneral = totalActualGeneral + totalActualExterno

                        '-- Dibujo un cuadro
                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 1), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                        '-- Dibujo el cuadro externo
                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    End If

                    linea = linea + 2

                    oExcel.Cells(linea, 1).font.Size = 11
                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1) = "QUANTITY OF ASSETS:"
                    oExcel.Cells(linea, 2).Font.Size = 11
                    oExcel.Cells(linea, 2).Font.Bold = True
                    oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 2).NumberFormat = "###,###,##0;[Red](###,###,##0)"
                    oExcel.Cells(linea, 2) = contadorGeneral.ToString
                    oExcel.Cells(linea, 6).Font.Size = 11
                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 6) = "ASSETS SUM:"
                    oExcel.Cells(linea, 7).Font.Size = 11
                    oExcel.Cells(linea, 7).Font.Bold = True
                    oExcel.Cells(linea, 7).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 7) = totalOriginalGeneral
                    oExcel.Cells(linea, 8).Font.Size = 11
                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 8) = totalAcumuladoGeneral
                    oExcel.Cells(linea, 9).Font.Size = 11
                    oExcel.Cells(linea, 9).Font.Bold = True
                    oExcel.Cells(linea, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 9) = totalActualGeneral
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub InformacionGeneralActivosFijos(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT a.CODIGO_DE_ACTIVO")
            .Append("     , a.MEJORA_CORRELATIVO")
            .Append("     , a.DESCRIP_CORTA_ACTIVO")
            .Append("     , a.VALOR_ORIGINAL_ACTIV")
            .Append("     , a.VALOR_RESCATE_ACTIVO")
            .Append("     , a.TIPO_DEPRECIACION")
            .Append("     , a.TIEMPO_DEPRECIACION")
            .Append("     , a.PORCENTAJE_ANUAL_DEP")
            .Append("     , Convert(Varchar(10), a.FECHA_ADQUISICION, 103) As FECHA_ADQUISICION")
            .Append("     , Convert(Varchar(10), a.FECHA_ULT_INVENTARIO, 103) As FECHA_ULT_INVENTARIO")
            .Append("     , m.DESCRIPCION_MONEDA")
            .Append("     , a.TASA_CAMBIO_COMPRA")
            .Append("     , a.REFERENCIA")
            .Append("     , a.VALOR_MONEDA_LOCAL")
            .Append("     , a.CODIGO_DE_BARRAS")
            .Append("     , Convert(Varchar(10), a.FECHA_INICIO_DEPREC, 103) As FECHA_INICIO_DEPREC")
            .Append("     , r.DESCRIPCION_MARCA")
            .Append("     , u.DESCRIPCION_UBICACION")
            .Append("     , t.DESCRIP_TIPO_ACTIVO")
            .Append("     , p.nombre_proveedor")
            .Append("  FROM            ACTIVOS_FIJOS    a")
            .Append("  LEFT OUTER JOIN PROVEEDORES      p ON (a.CODIGO_PROVEEDOR = p.CODIGO_PROVEEDOR)")
            .Append("  LEFT OUTER JOIN MONEDAS          m ON (a.CODIGO_DE_MONEDA = m.CODIGO_DE_MONEDA)")
            .Append("  LEFT OUTER JOIN MARCAS           r ON (a.CODIGO_MARCA = r.CODIGO_MARCA)")
            .Append("  LEFT OUTER JOIN UBICACION_ACTIVO u ON (a.CODIGO_UBICACION = u.CODIGO_UBICACION)")
            .Append("  LEFT OUTER JOIN TIPOS_DE_ACTIVOS t ON (a.CODIGO_TIPO_ACTIVO = t.CODIGO_TIPO_ACTIVO)")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If

            .Append("       ORDER BY a.CODIGO_DE_ACTIVO, a.MEJORA_CORRELATIVO")
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CrearReporteInformacionGeneralActivosFijos(data, parametros)
    End Sub

    Private Shared Sub CrearReporteInformacionGeneralActivosFijos(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 2

                    oExcel.Cells(linea, 6).Font.Bold = True
                    oExcel.Cells(linea, 6).font.Size = 16
                    oExcel.Cells(linea, 6) = "Fixed Assets' general Information"

                    linea += 2

                    '-- Títulos de las columnas
                    oExcel.Cells(linea, 1).ColumnWidth = 14
                    oExcel.Cells(linea, 1) = "ID"
                    oExcel.Cells(linea, 2).ColumnWidth = 23
                    oExcel.Cells(linea, 2) = "ASSET TYPE DESCRIPTION"
                    oExcel.Cells(linea, 3).ColumnWidth = 11
                    oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 3) = "UPGRADE"
                    oExcel.Cells(linea, 4).ColumnWidth = 35
                    oExcel.Cells(linea, 4) = "DESCRIPTION"
                    oExcel.Cells(linea, 5).ColumnWidth = 18
                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 5) = "ORIGINAL VALUE"
                    oExcel.Cells(linea, 6).ColumnWidth = 18
                    oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 6) = "CURRENT VALUE"
                    oExcel.Cells(linea, 7).ColumnWidth = 18
                    oExcel.Cells(linea, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 7) = "RESIDUAL VALUE"
                    oExcel.Cells(linea, 8).ColumnWidth = 11
                    oExcel.Cells(linea, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 8) = "TIME"
                    oExcel.Cells(linea, 9).ColumnWidth = 12
                    oExcel.Cells(linea, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 9) = "ANNUAL %"
                    oExcel.Cells(linea, 10).ColumnWidth = 19
                    oExcel.Cells(linea, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 10) = "ACQUISITION DATE"
                    oExcel.Cells(linea, 11).ColumnWidth = 22
                    oExcel.Cells(linea, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 11) = "LAST INVENTORY DATE"
                    oExcel.Cells(linea, 12).ColumnWidth = 12
                    oExcel.Cells(linea, 12).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 12) = "CURRENCY"
                    oExcel.Cells(linea, 13).ColumnWidth = 22
                    oExcel.Cells(linea, 13).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 13) = "DEPRECIATION TYPE"
                    oExcel.Cells(linea, 14).ColumnWidth = 16
                    oExcel.Cells(linea, 14).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 14) = "PURCHASE RATE"
                    oExcel.Cells(linea, 15).ColumnWidth = 12
                    oExcel.Cells(linea, 15).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 15) = "INVENTORY"
                    oExcel.Cells(linea, 16).ColumnWidth = 11
                    oExcel.Cells(linea, 16).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 16) = "BAR CODE"
                    oExcel.Cells(linea, 17).ColumnWidth = 21
                    oExcel.Cells(linea, 17).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 17) = "DEPREC. START DATE"
                    oExcel.Cells(linea, 18).ColumnWidth = 20
                    oExcel.Cells(linea, 18).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 18) = "BRAND"
                    oExcel.Cells(linea, 19).ColumnWidth = 25
                    oExcel.Cells(linea, 19).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 19) = "LOCATION"

                    '-- Dibujo un cuadro
                    Dim totalColumnas As Integer = 1
                    totalColumnas = 19

                    Dim columnaCuadro As Excel.Range
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Font.Size = 11
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    Dim lineaInicial As Integer = linea

                    '-- Primer filtro
                    Dim llaveAnterior As String = String.Empty
                    Dim llaveActual As String = String.Empty
                    Dim primerVez As Boolean = True
                    Dim escribirTipo As Boolean = True
                    Dim entro As Boolean = False

                    Dim lineaAux As Integer = 0

                    Dim contadorExterno As Integer = 0

                    For Each filaData As DataRow In data.Tables(0).Rows
                        llaveActual = filaData.Item("CODIGO_DE_ACTIVO").ToString.Trim

                        If llaveActual <> llaveAnterior Then
                            llaveAnterior = llaveActual
                            If primerVez = False Then
                                '-- Cambio de activo
                                linea = linea + 2
                            End If

                            primerVez = False

                            entro = True

                            escribirTipo = True
                        End If

                        If escribirTipo Then
                            lineaAux = linea

                            oExcel.Cells(linea, 1).Font.Bold = True
                            oExcel.Cells(linea, 1).Font.Size = 10
                            oExcel.Cells(linea, 1) = filaData.Item("CODIGO_DE_ACTIVO").ToString.Trim

                            escribirTipo = False
                        End If

                        linea = linea + 1

                        oExcel.Cells(linea, 2).Font.Size = 9
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("DESCRIP_TIPO_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 3).Font.Size = 9
                        oExcel.Cells(linea, 3).NumberFormat = "@"
                        oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 3) = filaData.Item("MEJORA_CORRELATIVO").ToString.Trim
                        oExcel.Cells(linea, 4).Font.Size = 9
                        oExcel.Cells(linea, 4).NumberFormat = "@"
                        oExcel.Cells(linea, 4) = filaData.Item("DESCRIP_CORTA_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 5).Font.Size = 9
                        oExcel.Cells(linea, 5).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 5) = filaData.Item("VALOR_ORIGINAL_ACTIV").ToString.Trim
                        oExcel.Cells(linea, 6).Font.Size = 9
                        oExcel.Cells(linea, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 6) = filaData.Item("VALOR_MONEDA_LOCAL").ToString.Trim
                        oExcel.Cells(linea, 7).Font.Size = 9
                        oExcel.Cells(linea, 7).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 7) = filaData.Item("VALOR_RESCATE_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 8).Font.Size = 9
                        oExcel.Cells(linea, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 8).NumberFormat = "###,###,##0;[Red](###,###,##0)"
                        oExcel.Cells(linea, 8) = filaData.Item("TIEMPO_DEPRECIACION").ToString.Trim
                        oExcel.Cells(linea, 9).Font.Size = 9
                        oExcel.Cells(linea, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        If filaData.IsNull("PORCENTAJE_ANUAL_DEP") = False Then
                            oExcel.Cells(linea, 9) = filaData.Item("PORCENTAJE_ANUAL_DEP") * 100
                        End If
                        oExcel.Cells(linea, 10).Font.Size = 9
                        oExcel.Cells(linea, 10).NumberFormat = "@"
                        oExcel.Cells(linea, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 10) = filaData.Item("FECHA_ADQUISICION").ToString.Trim
                        oExcel.Cells(linea, 11).Font.Size = 9
                        oExcel.Cells(linea, 11).NumberFormat = "@"
                        oExcel.Cells(linea, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 11) = filaData.Item("FECHA_ULT_INVENTARIO").ToString.Trim
                        oExcel.Cells(linea, 12).Font.Size = 9
                        oExcel.Cells(linea, 12).NumberFormat = "@"
                        oExcel.Cells(linea, 12).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 12) = filaData.Item("DESCRIPCION_MONEDA").ToString.Trim
                        oExcel.Cells(linea, 13).Font.Size = 9
                        oExcel.Cells(linea, 13).NumberFormat = "@"
                        oExcel.Cells(linea, 13).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 13) = DevuelveTipoDepreciacion(filaData.Item("TIPO_DEPRECIACION").ToString.Trim, False)
                        oExcel.Cells(linea, 14).Font.Size = 9
                        oExcel.Cells(linea, 14).NumberFormat = "###,###,##0.000000;[Red](###,###,##0.000000)"
                        oExcel.Cells(linea, 14) = filaData.Item("TASA_CAMBIO_COMPRA").ToString.Trim
                        oExcel.Cells(linea, 15).Font.Size = 9
                        oExcel.Cells(linea, 15).NumberFormat = "@"
                        oExcel.Cells(linea, 15) = filaData.Item("REFERENCIA").ToString.Trim
                        oExcel.Cells(linea, 16).Font.Size = 9
                        oExcel.Cells(linea, 16).NumberFormat = "@"
                        oExcel.Cells(linea, 16) = filaData.Item("CODIGO_DE_BARRAS").ToString.Trim
                        oExcel.Cells(linea, 17).Font.Size = 9
                        oExcel.Cells(linea, 17).NumberFormat = "@"
                        oExcel.Cells(linea, 17).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 17) = filaData.Item("FECHA_INICIO_DEPREC").ToString.Trim
                        oExcel.Cells(linea, 18).Font.Size = 9
                        oExcel.Cells(linea, 18).NumberFormat = "@"
                        oExcel.Cells(linea, 18) = filaData.Item("DESCRIPCION_MARCA").ToString.Trim
                        oExcel.Cells(linea, 19).Font.Size = 9
                        oExcel.Cells(linea, 19).NumberFormat = "@"
                        oExcel.Cells(linea, 19) = filaData.Item("DESCRIPCION_UBICACION").ToString.Trim

                        contadorExterno = contadorExterno + 1
                    Next

                    Dim spGT As New CultureInfo("es-GT")

                    oExcel.Cells(2, 1).font.Size = 9
                    oExcel.Cells(2, 1).NumberFormat = "@"
                    oExcel.Cells(2, 1) = parametros(0)
                    oExcel.Cells(1, totalColumnas).font.Size = 9
                    oExcel.Cells(1, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(1, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(1, totalColumnas) = Now.Date.ToString("d", spGT)
                    oExcel.Cells(2, totalColumnas).font.Size = 9
                    oExcel.Cells(2, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(2, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(2, totalColumnas) = DateTime.Now.ToString("T", spGT)

                    If entro Then
                        '-- Dibujo el cuadro externo
                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                        linea = linea + 1

                        oExcel.Cells(linea, 1).Font.Size = 10
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1) = "Total assets:"
                        oExcel.Cells(linea, 2).Font.Size = 10
                        oExcel.Cells(linea, 2).Font.Bold = True
                        oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        oExcel.Cells(linea, 2).NumberFormat = "###,###,##0;[Red](###,###,##0)"
                        oExcel.Cells(linea, 2) = contadorExterno.ToString
                    End If
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub InformacionGeneralActivoFijo(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT")
            .Append("   a.CODIGO_DE_ACTIVO")
            .Append("   , a.MEJORA_CORRELATIVO")
            .Append("   , ta.DESCRIP_TIPO_ACTIVO")
            .Append("   , d.DESCRIPCION_DIVISION")
            .Append("   , a.DESCRIP_CORTA_ACTIVO")
            .Append("   , a.VALOR_ORIGINAL_ACTIV")
            .Append("   , a.VALOR_RESCATE_ACTIVO")
            .Append("   , a.DEPRECIABLE")
            .Append("   , a.TIEMPO_DEPRECIACION")
            .Append("   , Convert(Varchar(10), a.FECHA_ADQUISICION, 103) As FECHA_ADQUISICION")
            .Append("   , Convert(Varchar(10), a.FECHA_ULT_INVENTARIO, 103) As FECHA_ULT_INVENTARIO")
            .Append("   , m.DESCRIPCION_MONEDA")
            .Append("   , a.FRECUENCIA_MNTMTO")
            .Append("   , a.TIPO_DEPRECIACION")
            .Append("   , a.TASA_CAMBIO_COMPRA")
            .Append("   , a.REFERENCIA")
            .Append("   , a.CODIGO_DE_BARRAS")
            .Append("   , a.VALOR_MONEDA_LOCAL")
            .Append("   , Convert(Varchar(10), a.FECHA_INICIO_DEPREC, 103) As FECHA_INICIO_DEPREC")
            .Append("   , ma.DESCRIPCION_MARCA")
            .Append("   , u.DESCRIPCION_UBICACION")
            .Append("   , a.POSEE_CTRL_TF")
            .Append("   , r.NOMBRE_USUAL")
            .Append("   , c.CATEGORIA_DESC")
            .Append(" FROM")
            .Append("   ACTIVOS_FIJOS a")
            .Append("   LEFT JOIN TIPOS_DE_ACTIVOS ta ON ta.CODIGO_TIPO_ACTIVO = a.CODIGO_TIPO_ACTIVO")
            .Append("   LEFT JOIN DIVISIONES d ON d.CODIGO_DIVISION = a.CODIGO_DIVISION")
            .Append("   LEFT JOIN MONEDAS m ON m.CODIGO_DE_MONEDA = a.CODIGO_DE_MONEDA")
            .Append("   LEFT JOIN MARCAS ma ON ma.CODIGO_MARCA = a.CODIGO_MARCA")
            .Append("   LEFT JOIN UBICACION_ACTIVO u ON u.CODIGO_UBICACION = a.CODIGO_UBICACION")
            .Append("   LEFT JOIN ACT_RESPONSABLES r ON r.RESPONSABLE_ID = a.RESPONSABLE_ID")
            .Append("   LEFT JOIN ACT_CATEGORIAS c ON c.CATEGORIA_ID = a.CATEGORIA_ID")
            .Append(" WHERE " + filtro)
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        '##### generanado comando para obtener los campos especiales
        comandoSQL.Clear()
        With comandoSQL
            .Append("SELECT")
            .Append("   C.CAMPO_TITULO")
            .Append("   , S.VALOR_CAMPO")
            .Append(" FROM")
            .Append("   (")
            .Append("   SELECT")
            .Append("       a.CAMPO_ID")
            .Append("       , (")
            .Append("           CASE WHEN L.CAMPO_ID = a.CAMPO_ID THEN RTRIM(LTRIM(a.VALOR_CAMPO)) + '-' + RTRIM(LTRIM(L.CAMPO_DESCRIPCION)) ELSE a.VALOR_CAMPO END")
            .Append("       ) VALOR_CAMPO")
            .Append("   FROM")
            .Append("       ACT_CAMPOS_VAL a")
            .Append("       LEFT JOIN ACT_CAMPOS_LV L ON L.CAMPO_ID = a.CAMPO_ID AND L.CAMPO_VALOR = a.VALOR_CAMPO")
            .Append("   WHERE " + filtro)
            .Append("   ) AS S")
            .Append("   RIGHT JOIN ACT_CAMPO C ON C.CAMPO_ID = S.CAMPO_ID")
            .Append(" ORDER BY")
            .Append("   C.CAMPO_LISTA_VALORES, C.CAMPO_TITULO")
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim dataFields As New DataSet
        dataFields = GetDataSet(comando)

        CrearReporteInformacionGeneralActivoFijo(data, dataFields, parametros)
    End Sub

    Private Shared Sub CrearReporteInformacionGeneralActivoFijo(ByVal data As DataSet, ByVal dataFields As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim primeraFila As Integer = 1
            Dim ultimaFila As Integer = 22
            Dim ultimaColumna As Integer = 6

            oExcel = New Excel.Application
            oExcel.Workbooks.Add()

            '##### ENCABEZADO DE REPORTE ######

            'mostrando empresa
            oExcel.Cells(1, 1).Font.Bold = True
            oExcel.Cells(1, 1).font.Size = 14
            oExcel.Cells(1, 1) = Citi.Synergia.Locals.Cache.Empresa

            'colocando fecha y hora que se genero reporte
            Dim spGT As New CultureInfo("es-GT")

            oExcel.Cells(2, 1).font.Size = 9
            oExcel.Cells(2, 1).NumberFormat = "@"
            oExcel.Cells(2, 1) = parametros(0)
            oExcel.Cells(1, ultimaColumna).font.Size = 9
            oExcel.Cells(1, ultimaColumna).NumberFormat = "@"
            oExcel.Cells(1, ultimaColumna).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            oExcel.Cells(1, ultimaColumna) = Now.Date.ToString("d", spGT)
            oExcel.Cells(2, ultimaColumna).font.Size = 9
            oExcel.Cells(2, ultimaColumna).NumberFormat = "@"
            oExcel.Cells(2, ultimaColumna).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            oExcel.Cells(2, ultimaColumna) = DateTime.Now.ToString("T", spGT)

            '###### PRIMERA PARTE DE REPORTE #######

            'titulo de reporte
            oExcel.Cells(3, 2).Font.Bold = True
            oExcel.Cells(3, 2).font.Size = 16
            oExcel.Cells(3, 2) = "Fixed Asset Detailed Information"

            'pintando tabla
            Dim columnaCuadro As Excel.Range
            columnaCuadro = oExcel.Range(oExcel.Cells(6, 1), oExcel.Cells(ultimaFila, ultimaColumna))
            'columnaCuadro.Font.Size = 11
            'columnaCuadro.Font.Bold = True
            columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

            'definiendo ancho de columnas
            oExcel.Cells(1, 1).ColumnWidth = 28
            oExcel.Cells(1, 2).ColumnWidth = 20
            oExcel.Cells(1, 3).ColumnWidth = 10
            oExcel.Cells(1, 4).ColumnWidth = 10
            oExcel.Cells(1, 5).ColumnWidth = 26
            oExcel.Cells(1, 6).ColumnWidth = 15

            'columna(A) de titulos
            oExcel.Cells(6, 1) = "FIXED ASSET ID:"
            oExcel.Cells(7, 1) = "FIXED TYPE:"
            oExcel.Cells(8, 1) = "DEPARTMENT:"
            oExcel.Cells(9, 1) = "DESCRIPTION ASSET:"
            oExcel.Cells(10, 1) = "ORIGINAL VALUE:"
            oExcel.Cells(11, 1) = "DEPRECIABLE:"
            oExcel.Cells(12, 1) = "DATE OF ACQUISITION:"
            oExcel.Cells(13, 1) = "CURRENCY PURCHASE:"
            oExcel.Cells(14, 1) = "MAINTENANCE FREQUENCY (DAYS):"
            oExcel.Cells(15, 1) = "DEPRECIATION TYPE:"
            oExcel.Cells(16, 1) = "PURCHASE EXCHANGE RATE:"
            oExcel.Cells(17, 1) = "REFERENCE ASSET:"
            oExcel.Cells(18, 1) = "PURCHASE CURRENCY VALUE:"
            oExcel.Cells(19, 1) = "CODE BRAND:"
            oExcel.Cells(20, 1) = "LOCATION:"
            oExcel.Cells(21, 1) = "REPONSIBLE ASSET:"
            oExcel.Cells(22, 1) = "ASSET CATEGORY:"

            'columna(E) de titulos

            oExcel.Cells(6, 5) = "IMPROV:"
            oExcel.Cells(6, 5).Font.Bold = True
            oExcel.Cells(6, 5).Font.Size = 10

            oExcel.Cells(10, 5) = "RESIDUAL VALUE:"
            oExcel.Cells(10, 5).Font.Bold = True
            oExcel.Cells(10, 5).Font.Size = 10

            oExcel.Cells(11, 5) = "MONTHS TO RUN DEPRECIATION:"
            oExcel.Cells(11, 5).Font.Bold = True
            oExcel.Cells(11, 5).Font.Size = 10

            oExcel.Cells(12, 5) = "LAST DATE INVENTORY:"
            oExcel.Cells(12, 5).Font.Bold = True
            oExcel.Cells(12, 5).Font.Size = 10

            oExcel.Cells(17, 5) = "BARCODE"
            oExcel.Cells(17, 5).Font.Bold = True
            oExcel.Cells(17, 5).Font.Size = 10

            oExcel.Cells(18, 5) = "DEPRECIATION START DATE"
            oExcel.Cells(18, 5).Font.Bold = True
            oExcel.Cells(18, 5).Font.Size = 10

            oExcel.Cells(20, 5) = "INVENTORY CONTROL"
            oExcel.Cells(20, 5).Font.Bold = True
            oExcel.Cells(20, 5).Font.Size = 10


            For fila As Integer = 6 To 22
                oExcel.Cells(fila, 1).Font.Bold = True
                oExcel.Cells(fila, 1).Font.Size = 10

                oExcel.Cells(fila, 2).Font.Size = 10
                oExcel.Cells(fila, 6).Font.Size = 10
            Next

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then

                    For Each filaData As DataRow In data.Tables(0).Rows

                        'Mostrando datos para columna(B)
                        oExcel.Cells(6, 2).Font.Size = 10
                        oExcel.Cells(6, 2) = filaData.Item("CODIGO_DE_ACTIVO").ToString.Trim

                        oExcel.Cells(7, 2).Font.Size = 10
                        oExcel.Cells(7, 2) = filaData.Item("DESCRIP_TIPO_ACTIVO").ToString.Trim

                        oExcel.Cells(8, 2) = filaData.Item("DESCRIPCION_DIVISION").ToString.Trim

                        oExcel.Cells(9, 2) = filaData.Item("DESCRIP_CORTA_ACTIVO").ToString.Trim

                        oExcel.Cells(10, 2).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(10, 2) = filaData.Item("VALOR_ORIGINAL_ACTIV").ToString.Trim

                        oExcel.Cells(11, 2) = DevuelveSiEsDepreciado(filaData.Item("DEPRECIABLE").ToString.Trim, False)

                        oExcel.Cells(12, 2).NumberFormat = "@"
                        oExcel.Cells(12, 2) = filaData.Item("FECHA_ADQUISICION").ToString.Trim

                        oExcel.Cells(13, 2) = filaData.Item("DESCRIPCION_MONEDA").ToString.Trim

                        oExcel.Cells(14, 2) = filaData.Item("FRECUENCIA_MNTMTO").ToString.Trim

                        oExcel.Cells(15, 2) = DevuelveTipoDepreciacion(filaData.Item("TIPO_DEPRECIACION").ToString.Trim, False)

                        oExcel.Cells(16, 2).NumberFormat = "###,###,##0.000000;[Red](###,###,##0.000000)"
                        oExcel.Cells(16, 2) = filaData.Item("TASA_CAMBIO_COMPRA").ToString.Trim

                        If filaData.IsNull("REFERENCIA") = False Then
                            oExcel.Cells(17, 2) = filaData.Item("REFERENCIA").ToString.Trim
                        End If

                        oExcel.Cells(18, 2).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(18, 2) = filaData.Item("VALOR_MONEDA_LOCAL").ToString.Trim

                        If filaData.IsNull("DESCRIPCION_MARCA") = False Then
                            oExcel.Cells(19, 2) = filaData.Item("DESCRIPCION_MARCA").ToString.Trim
                        End If

                        oExcel.Cells(20, 2) = filaData.Item("DESCRIPCION_UBICACION").ToString.Trim

                        oExcel.Cells(21, 2) = filaData.Item("NOMBRE_USUAL").ToString.Trim

                        If filaData.IsNull("CATEGORIA_DESC") = False Then
                            oExcel.Cells(22, 2) = filaData.Item("CATEGORIA_DESC").ToString.Trim
                        End If

                        'Mostrando datos para columna(F)
                        oExcel.Cells(6, 6) = filaData.Item("MEJORA_CORRELATIVO").ToString.Trim

                        oExcel.Cells(10, 6).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(10, 6) = filaData.Item("VALOR_RESCATE_ACTIVO").ToString.Trim

                        oExcel.Cells(11, 6) = filaData.Item("TIEMPO_DEPRECIACION").ToString.Trim

                        If filaData.IsNull("FECHA_ULT_INVENTARIO") = False Then
                            oExcel.Cells(12, 6).NumberFormat = "@"
                            oExcel.Cells(12, 6) = filaData.Item("FECHA_ULT_INVENTARIO").ToString.Trim
                        End If

                        If filaData.IsNull("CODIGO_DE_BARRAS") = False Then
                            oExcel.Cells(17, 6) = filaData.Item("CODIGO_DE_BARRAS").ToString.Trim
                        End If

                        oExcel.Cells(18, 6).NumberFormat = "@"
                        oExcel.Cells(18, 6) = filaData.Item("FECHA_INICIO_DEPREC").ToString.Trim

                        If filaData.Item("POSEE_CTRL_TF").ToString.Trim = "1" Then
                            oExcel.Cells(20, 6) = "YES"
                        Else
                            oExcel.Cells(20, 6) = "NO"
                        End If

                    Next
                End If
            End If

            '###### SEGUNDA PARTE DE REPORTE #######

            ultimaFila += 3

            'titulo de reporte
            oExcel.Cells(ultimaFila, 2).Font.Bold = True
            oExcel.Cells(ultimaFila, 2).font.Size = 16
            oExcel.Cells(ultimaFila, 2) = "Special Fields"

            primeraFila = ultimaFila + 2

            'titulos de tabla
            'oExcel.Cells(primeraFila, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            oExcel.Cells(primeraFila, 1) = "TITLE"
            'oExcel.Range(oExcel.Cells(primeraFila, 2), oExcel.Cells(primeraFila, 4)).MergeCells()
            'oExcel.Cells(primeraFila, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            oExcel.Cells(primeraFila, 2) = "VALUE"

            'creando marco 
            columnaCuadro = oExcel.Range(oExcel.Cells(primeraFila, 1), oExcel.Cells(primeraFila, 4))
            columnaCuadro.Font.Size = 11
            columnaCuadro.Font.Bold = True
            columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

            ultimaFila = primeraFila + 1

            If Not dataFields Is Nothing Then
                If dataFields.Tables.Count > 0 Then

                    For Each filaData As DataRow In dataFields.Tables(0).Rows

                        oExcel.Cells(ultimaFila, 1).Font.Size = 10
                        oExcel.Cells(ultimaFila, 1).Font.Bold = True
                        oExcel.Cells(ultimaFila, 1) = filaData.Item("CAMPO_TITULO").ToString.Trim

                        oExcel.Cells(ultimaFila, 2).Font.Size = 10
                        oExcel.Cells(ultimaFila, 2).NumberFormat = "@"
                        oExcel.Cells(ultimaFila, 2) = filaData.Item("VALOR_CAMPO").ToString.Trim

                        ultimaFila += 1
                    Next

                End If
            End If

            ultimaFila -= 1

            'creando marco
            columnaCuadro = oExcel.Range(oExcel.Cells(primeraFila, 1), oExcel.Cells(ultimaFila, 4))
            columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try


    End Sub

    Private Shared Sub FichaResponsable(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT r.RESPONSABLE_ID")
            .Append("     , r.NOMBRE_USUAL")
            .Append("     , d.DESCRIPCION_DIVISION")
            .Append("     , a.CODIGO_DE_ACTIVO")
            .Append("     , a.MEJORA_CORRELATIVO")
            .Append("     , a.DESCRIP_CORTA_ACTIVO")
            .Append("     , db_name()")
            .Append("  FROM             ACT_RESPONSABLES r")
            .Append("  RIGHT OUTER JOIN ACTIVOS_FIJOS    a ON (r.RESPONSABLE_ID = a.RESPONSABLE_ID)")
            .Append("  INNER JOIN       DIVISIONES       d ON (r.CODIGO_DIVISION = d.CODIGO_DIVISION)")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If

            .Append("       ORDER BY r.RESPONSABLE_ID")
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CrearReporteFichaResponsable(data, parametros)
    End Sub

    Private Shared Sub CrearReporteFichaResponsable(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 3

                    Dim totalColumnas As Integer = 4
                    Dim columnaCuadro As Excel.Range
                    Dim spGT As New CultureInfo("es-GT")

                    oExcel.Cells(linea, 1) = "Fixed assets by Responsible"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 16
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea += 2

                    Dim lineaInicial As Integer = linea

                    '-- Primer filtro
                    Dim llaveAnterior As String = String.Empty
                    Dim llaveActual As String = String.Empty
                    Dim primerVez As Boolean = True
                    Dim escribirTipo As Boolean = True
                    Dim entro As Boolean = False

                    Dim lineaAux As Integer = 0

                    Dim contadorExterno As Integer = 0

                    Dim leyendaAnterior As String = String.Empty

                    '-- Dibujo un cuadro

                    For Each filaData As DataRow In data.Tables(0).Rows
                        llaveActual = filaData.Item("RESPONSABLE_ID").ToString.Trim

                        If llaveActual <> llaveAnterior Then
                            llaveAnterior = llaveActual
                            If primerVez = False Then
                                '-- Cambio de activo
                                linea = linea + 8
                            End If

                            primerVez = False

                            entro = True

                            If escribirTipo = False Then
                                oExcel.Cells(linea - 5, 1).Font.Bold = True
                                oExcel.Cells(linea - 5, 1).Font.Size = 14
                                oExcel.Cells(linea - 5, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                                oExcel.Cells(linea - 5, 1) = "F. "
                                oExcel.Cells(linea - 4, 2) = "Accepted. " + leyendaAnterior

                                columnaCuadro = oExcel.Range(oExcel.Cells(linea - 4, 2), oExcel.Cells(linea - 4, totalColumnas))
                                columnaCuadro.Merge()
                                columnaCuadro.Font.Bold = True
                                columnaCuadro.Font.Size = 14
                                columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                                columnaCuadro = oExcel.Range(oExcel.Cells(linea - 7, 2), oExcel.Cells(linea - 5, totalColumnas))
                                columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                                '-- Dibujo un cuadro externo
                                columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 2), oExcel.Cells(linea - 8, totalColumnas))
                                columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                                oExcel.Cells(linea - 3, totalColumnas).font.Size = 9
                                oExcel.Cells(linea - 3, totalColumnas).NumberFormat = "@"
                                oExcel.Cells(linea - 3, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                                oExcel.Cells(linea - 3, totalColumnas) = DateTime.Now.ToString("dd-MMM-yyyy HH:mm tt", spGT)
                            End If

                            escribirTipo = True
                        End If

                        If escribirTipo Then
                            lineaAux = linea

                            oExcel.Cells(linea, 2).Font.Bold = True
                            oExcel.Cells(linea, 2).Font.Size = 14
                            oExcel.Cells(linea, 2).ColumnWidth = 15
                            oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                            oExcel.Cells(linea, 2) = "Responsible:"
                            oExcel.Cells(linea, 3).Font.Bold = True
                            oExcel.Cells(linea, 3).Font.Size = 14
                            oExcel.Cells(linea, 3).ColumnWidth = 15
                            oExcel.Cells(linea, 3).NumberFormat = "@"
                            If filaData.IsNull("RESPONSABLE_ID") Then
                                oExcel.Cells(linea, 3) = "**** WITHOUT RESPONSIBLE ****"
                            Else
                                oExcel.Cells(linea, 3) = filaData.Item("RESPONSABLE_ID").ToString.Trim + " - " + filaData.Item("NOMBRE_USUAL").ToString.Trim
                            End If

                            linea = linea + 1

                            oExcel.Cells(linea, 2).Font.Bold = True
                            oExcel.Cells(linea, 2).Font.Size = 14
                            oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                            oExcel.Cells(linea, 2) = "Department:"
                            oExcel.Cells(linea, 3).Font.Bold = True
                            oExcel.Cells(linea, 3).Font.Size = 14
                            oExcel.Cells(linea, 3).NumberFormat = "@"
                            oExcel.Cells(linea, 3) = filaData.Item("DESCRIPCION_DIVISION").ToString.Trim
                            linea = linea + 2
                            oExcel.Cells(linea, 3).Font.Bold = True
                            oExcel.Cells(linea, 3).Font.Size = 11
                            oExcel.Cells(linea, 3).ColumnWidth = 12
                            oExcel.Cells(linea, 3) = "FIXED ASSETS ASIGNED"
                            columnaCuadro = oExcel.Range(oExcel.Cells(linea, 2), oExcel.Cells(linea, totalColumnas))
                            columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                            linea = linea + 1
                            oExcel.Cells(linea, 2).Font.Bold = True
                            oExcel.Cells(linea, 2).Font.Size = 11
                            oExcel.Cells(linea, 2) = "ID"
                            oExcel.Cells(linea, 3).Font.Bold = True
                            oExcel.Cells(linea, 3).Font.Size = 11
                            oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            oExcel.Cells(linea, 3) = "UPGRADE"
                            oExcel.Cells(linea, 4).Font.Bold = True
                            oExcel.Cells(linea, 4).Font.Size = 11
                            oExcel.Cells(linea, 4).ColumnWidth = 45
                            oExcel.Cells(linea, 4) = "DESCRIPTION"
                            columnaCuadro = oExcel.Range(oExcel.Cells(linea, 2), oExcel.Cells(linea, totalColumnas))
                            columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                            escribirTipo = False
                        End If

                        leyendaAnterior = filaData.Item("NOMBRE_USUAL").ToString.Trim

                        linea = linea + 1

                        oExcel.Cells(linea, 2).Font.Size = 10
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("CODIGO_DE_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 3).Font.Size = 10
                        oExcel.Cells(linea, 3).NumberFormat = "@"
                        oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 3) = filaData.Item("MEJORA_CORRELATIVO").ToString.Trim
                        oExcel.Cells(linea, 4).Font.Size = 10
                        oExcel.Cells(linea, 4).NumberFormat = "@"
                        oExcel.Cells(linea, 4) = filaData.Item("DESCRIP_CORTA_ACTIVO").ToString.Trim
                    Next

                    If entro Then
                        '-- Dibujo un cuadro externo
                        columnaCuadro = oExcel.Range(oExcel.Cells(lineaAux, 2), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                        linea = linea + 3
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1).Font.Size = 14
                        oExcel.Cells(linea, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 1) = "F. "

                        columnaCuadro = oExcel.Range(oExcel.Cells(linea - 2, 2), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                        linea = linea + 1

                        oExcel.Cells(linea, 2) = "Accepted. " + leyendaAnterior
                        columnaCuadro = oExcel.Range(oExcel.Cells(linea, 2), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.Merge()
                        columnaCuadro.Font.Bold = True
                        columnaCuadro.Font.Size = 14
                        columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                        linea = linea + 1

                        oExcel.Cells(linea, totalColumnas).font.Size = 9
                        oExcel.Cells(linea, totalColumnas).NumberFormat = "@"
                        oExcel.Cells(linea, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, totalColumnas) = DateTime.Now.ToString("dd-MMM-yyyy HH:mm tt", spGT)
                    End If
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub ResultadoToma(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT a.CODIGO_DE_ACTIVO")
            .Append("     , a.MEJORA_CORRELATIVO")
            .Append("     , a.DESCRIP_CORTA_ACTIVO")
            .Append("     , t.EXISTE")
            .Append("     , e.NUMERO_TOMA")
            .Append("     , e.RESPONSABLE_TOMA")
            .Append("     , e.OBSERVACIONES")
            .Append("     , e.ESTADO_TOMA")
            .Append("     , t.CODIGO_UBICACION")
            .Append("     , t.RESPONSABLE_ID")
            .Append("     , t.UBICA_SIS")
            .Append("     , t.RESP_SIS")
            .Append("     , Convert(Varchar(10), e.FECHA_TOMA, 103) As FECHA_TOMA")
            .Append("  FROM       ACT_TOMAFISICA_RESULTADO t")
            .Append("  INNER JOIN ACTIVOS_FIJOS            a ON (t.CODIGO_DE_ACTIVO = a.CODIGO_DE_ACTIVO AND t.MEJORA_CORRELATIVO = a.MEJORA_CORRELATIVO)")
            .Append("  INNER JOIN ACT_TOMAFISICA_ENC       e ON (t.NUMERO_TOMA = e.NUMERO_TOMA)")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If

            .Append("       ORDER BY a.CODIGO_DE_ACTIVO, a.MEJORA_CORRELATIVO")
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CrearReporteResultadoToma(data, parametros)
    End Sub

    Private Shared Sub CrearReporteResultadoToma(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 2

                    oExcel.Cells(linea, 4).Font.Bold = True
                    oExcel.Cells(linea, 4).font.Size = 16
                    oExcel.Cells(linea, 4) = "PHYSICAL RECONCILIATION RESULT No. " + parametros(0)

                    linea += 2

                    oExcel.Cells(linea, 5).font.Size = 14
                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 5) = "Responsible:"

                    Dim lineaResponsable As Integer = linea

                    linea += 1

                    oExcel.Cells(linea, 5).font.Size = 14
                    oExcel.Cells(linea, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, 5) = "Date:"

                    linea += 2

                    oExcel.Cells(linea, 1).font.Size = 12
                    oExcel.Cells(linea, 1) = "Observations:"

                    linea += 2

                    Dim columnaCuadro As Excel.Range

                    '-- Títulos de las columnas
                    oExcel.Cells(linea, 6) = "LOCATION"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 6), oExcel.Cells(linea, 7))
                    columnaCuadro.Merge()
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    oExcel.Cells(linea, 8) = "RESPONSIBLE"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 8), oExcel.Cells(linea, 9))
                    columnaCuadro.Merge()
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    oExcel.Cells(linea, 1).ColumnWidth = 14
                    oExcel.Cells(linea, 1) = "ASSET"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea - 1, 1), oExcel.Cells(linea, 1))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    columnaCuadro.Merge()
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    columnaCuadro.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    oExcel.Cells(linea, 2).ColumnWidth = 11
                    oExcel.Cells(linea, 2) = "UPGRADE"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea - 1, 2), oExcel.Cells(linea, 2))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    columnaCuadro.Merge()
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    columnaCuadro.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    oExcel.Cells(linea, 3).ColumnWidth = 35
                    oExcel.Cells(linea, 3) = "DESCRIPTION"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea - 1, 3), oExcel.Cells(linea, 3))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    columnaCuadro.Merge()
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    columnaCuadro.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    oExcel.Cells(linea, 4).ColumnWidth = 8
                    oExcel.Cells(linea, 4) = "Missing"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea - 1, 4), oExcel.Cells(linea, 4))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    columnaCuadro.Merge()
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    columnaCuadro.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


                    oExcel.Cells(linea, 5).ColumnWidth = 5
                    oExcel.Cells(linea, 5) = "Dif."
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea - 1, 5), oExcel.Cells(linea, 5))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    columnaCuadro.Merge()
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    columnaCuadro.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    oExcel.Cells(linea, 6).ColumnWidth = 23
                    oExcel.Cells(linea, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 6) = "PHYSICAL"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 6), oExcel.Cells(linea, 6))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    oExcel.Cells(linea, 7).ColumnWidth = 23
                    oExcel.Cells(linea, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 7) = "SYSTEM"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 7), oExcel.Cells(linea, 7))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    oExcel.Cells(linea, 8).ColumnWidth = 23
                    oExcel.Cells(linea, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 8) = "PHYSICAL"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 8), oExcel.Cells(linea, 8))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    oExcel.Cells(linea, 9).ColumnWidth = 23
                    oExcel.Cells(linea, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 9) = "SYSTEM"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 9), oExcel.Cells(linea, 9))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    '-- Dibujo un cuadro
                    Dim totalColumnas As Integer = 1
                    totalColumnas = 9

                    columnaCuadro = oExcel.Range(oExcel.Cells(linea - 1, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Font.Size = 11
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    Dim primerVez As Boolean = True

                    Dim lineaInicial As Integer = linea

                    Dim lineaAux As Integer = 0

                    For Each filaData As DataRow In data.Tables(0).Rows
                        If primerVez Then
                            linea = linea + 1

                            oExcel.Cells(lineaResponsable, 6).font.Size = 14
                            oExcel.Cells(lineaResponsable, 6) = filaData.Item("RESPONSABLE_TOMA").ToString.Trim
                            lineaResponsable = lineaResponsable + 1
                            oExcel.Cells(lineaResponsable, 6).font.Size = 14
                            oExcel.Cells(lineaResponsable, 6).NumberFormat = "@"
                            oExcel.Cells(lineaResponsable, 6) = filaData.Item("FECHA_TOMA").ToString.Trim
                            lineaResponsable = lineaResponsable + 2
                            oExcel.Cells(lineaResponsable, 2).font.Size = 12
                            oExcel.Cells(lineaResponsable, 2) = filaData.Item("OBSERVACIONES").ToString.Trim
                            oExcel.Cells(lineaResponsable, totalColumnas).font.Size = 13
                            oExcel.Cells(lineaResponsable, totalColumnas).Font.Bold = True
                            oExcel.Cells(lineaResponsable, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                            If filaData.Item("ESTADO_TOMA").ToString.Trim = "E" Then
                                oExcel.Cells(lineaResponsable, totalColumnas) = "*** IN PROCESS ***"
                            Else
                                oExcel.Cells(lineaResponsable, totalColumnas) = "*** AUTHORIZED ***"
                            End If

                            primerVez = False
                        End If

                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = filaData.Item("CODIGO_DE_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 2) = filaData.Item("MEJORA_CORRELATIVO").ToString.Trim
                        oExcel.Cells(linea, 3).NumberFormat = "@"
                        oExcel.Cells(linea, 3) = filaData.Item("DESCRIP_CORTA_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 4).NumberFormat = "@"
                        If filaData.Item("EXISTE").ToString.Trim <> "1" Then
                            oExcel.Cells(linea, 4) = "X"
                        End If

                        Dim ubicacionFisica As String = String.Empty
                        If filaData.IsNull("CODIGO_UBICACION") = False Then
                            ubicacionFisica = filaData.Item("CODIGO_UBICACION").ToString.Trim
                        End If

                        Dim ubicacionSistema As String = String.Empty
                        If filaData.IsNull("UBICA_SIS") = False Then
                            ubicacionSistema = filaData.Item("UBICA_SIS").ToString.Trim
                        End If

                        Dim responsableFisico As String = String.Empty
                        If filaData.IsNull("RESPONSABLE_ID") = False Then
                            responsableFisico = filaData.Item("RESPONSABLE_ID").ToString.Trim
                        End If

                        Dim responsableSistema As String = String.Empty
                        If filaData.IsNull("RESP_SIS") = False Then
                            responsableSistema = filaData.Item("RESP_SIS").ToString.Trim
                        End If

                        oExcel.Cells(linea, 5).NumberFormat = "@"
                        If ubicacionSistema <> ubicacionFisica Or responsableSistema <> responsableFisico Then
                            oExcel.Cells(linea, 5) = "X"
                        End If

                        oExcel.Cells(linea, 6).NumberFormat = "@"
                        oExcel.Cells(linea, 7).NumberFormat = "@"
                        If ubicacionFisica <> ubicacionSistema Then
                            oExcel.Cells(linea, 6) = ubicacionFisica
                            oExcel.Cells(linea, 7) = ubicacionSistema
                        End If

                        oExcel.Cells(linea, 8).NumberFormat = "@"
                        oExcel.Cells(linea, 9).NumberFormat = "@"
                        If responsableFisico <> responsableSistema Then
                            oExcel.Cells(linea, 8) = responsableFisico
                            oExcel.Cells(linea, 9) = responsableSistema
                        End If

                        columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.Font.Size = 10
                        columnaCuadro.BorderAround(Excel.XlLineStyle.xlDot, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                        linea = linea + 1
                    Next

                    linea = linea - 1

                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea, 1))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 2), oExcel.Cells(linea, 2))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 3), oExcel.Cells(linea, 3))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 4), oExcel.Cells(linea, 4))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 5), oExcel.Cells(linea, 5))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 6), oExcel.Cells(linea, 6))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 7), oExcel.Cells(linea, 7))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 8), oExcel.Cells(linea, 8))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)
                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 9), oExcel.Cells(linea, 9))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    '-- Dibujo el cuadro externo
                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 2

                    Dim spGT As New CultureInfo("es-GT")

                    oExcel.Cells(linea, totalColumnas).font.Size = 9
                    oExcel.Cells(linea, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(linea, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, totalColumnas) = DateTime.Now.ToString("dd-MMM-yyyy HH:mm tt", spGT)
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub PartidasDeTrabajo(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT Convert(Varchar(10), e.FECHA_PARTIDA, 103) As FECHA_PARTIDA")
            .Append("     , t.TIPO_PARTIDA")
            .Append("     , e.ESTADO_PARTIDA")
            .Append("     , e.USUARIO_INGRESO")
            .Append("     , e.TASA_CAMBIO")
            .Append("     , e.ANO_PERIODO")
            .Append("     , d.CORRELATIVO")
            .Append("     , d.TIPO_CATALOGO")
            .Append("     , d.CODIGO_CENTRO")
            .Append("     , d.CUENTA_CONTABLE")
            .Append("     , d.MONTO")
            .Append("     , c.DESCRIPCION")
            .Append("     , d.DEBITO_CREDITO")
            .Append("     , e.NO_PERIODO")
            .Append("     , e.NUMERO_PARTIDA")
            .Append("     , e.DOCUMENTO_ORIGEN")
            .Append("     , t.NOMBRE_TIPO")
            .Append("     , Convert(Varchar(10), e.FECHA_INGRESO, 103) As FECHA_INGRESO")
            .Append("     , e.TIPO_PARTIDA")
            .Append("     , e.DESCRIPCION_1")
            .Append("     , e.DESCRIPCION_2")
            .Append("     , e.DESCRIPCION_3")
            .Append("     , e.DESCRIPCION_4")
            .Append("     , o.DESCRIPCION_ORIGEN3_NOT_PA")
            .Append("     , o.DESCRIPCION_ORIGEN1_PA")
            .Append("     , o.DESCRIPCION_ORIGEN1_ELSE")
            .Append("     , e.ORIGEN1")
            .Append("     , e.ORIGEN2")
            .Append("     , e.ORIGEN3")
            .Append("  FROM       PARTIDAS_TRABAJO_ENC    e")
            .Append("  INNER JOIN PARTIDAS_TRABAJO_DET    d ON (e.ANO_PERIODO = d.ANO_PERIODO AND e.NO_PERIODO = d.NO_PERIODO AND e.NUMERO_PARTIDA = d.NUMERO_PARTIDA)")
            .Append("  INNER JOIN TIPOS_PARTIDAS          t ON (e.TIPO_PARTIDA = t.TIPO_PARTIDA)")
            .Append("  INNER JOIN PARTIDAS_TRABAJO_ORIGEN o ON (e.ANO_PERIODO = o.ANO_PERIODO AND e.NO_PERIODO = o.NO_PERIODO AND e.NUMERO_PARTIDA = o.NUMERO_PARTIDA)")
            .Append("  INNER JOIN CATALOGO_CONT_DET       c ON (d.TIPO_CATALOGO = c.TIPO_CATALOGO AND d.CUENTA_CONTABLE = c.CUENTA_CONTABLE)")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CrearReportePartidasDeTrabajo(data, parametros)
    End Sub

    Private Shared Sub CrearReportePartidasDeTrabajo(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 3

                    Dim totalColumnas As Integer = 9
                    Dim columnaCuadro As Excel.Range

                    oExcel.Cells(linea, 1) = "WORK REGISTRIES' REPORT"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 16
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea += 2

                    Dim ordenamiento As String = parametros(3)
                    Dim textoOrdenamiento As String = String.Empty
                    Select Case ordenamiento
                        Case "I"
                            textoOrdenamiento = "Input sequence"
                        Case "C"
                            textoOrdenamiento = "Accounting acccount"
                        Case "D"
                            textoOrdenamiento = "Debits / Credits"
                    End Select

                    oExcel.Cells(linea, 1) = "Sorted by: " + textoOrdenamiento
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 12
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea = linea + 3

                    oExcel.Cells(linea, 1).Font.Size = 13
                    oExcel.Cells(linea, 1) = "REGISTRY ACCOUNT:"
                    oExcel.Cells(linea, 3).Font.Size = 12
                    oExcel.Cells(linea, 3).NumberFormat = "@"
                    oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    oExcel.Cells(linea, 3) = parametros(1)

                    linea = linea + 1

                    oExcel.Cells(linea, 1).Font.Size = 13
                    oExcel.Cells(linea, 1) = "PERIOD:"
                    oExcel.Cells(linea, 3).Font.Size = 12
                    oExcel.Cells(linea, 3).NumberFormat = "@"
                    oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    oExcel.Cells(linea, 3) = parametros(0) + " - " + parametros(2)

                    linea = linea + 1

                    oExcel.Cells(linea, 1).Font.Size = 13
                    oExcel.Cells(linea, 1) = "ACCOUNT REGISTRY TYPE:"

                    '-- Títulos de tabla
                    Dim lineaTransaction As Integer = linea
                    Dim documentoOrigen As String = ""

                    linea = linea + 1

                    oExcel.Cells(linea, 1).Font.Size = 13
                    oExcel.Cells(linea, 1) = "DATE:"

                    linea = linea + 1

                    oExcel.Cells(linea, 1).Font.Size = 13
                    oExcel.Cells(linea, 1) = "DESCRIPTION:"

                    linea = linea + 4

                    oExcel.Cells(linea, 1).Font.Size = 13
                    oExcel.Cells(linea, 1) = "EXCHANGE RATE:"
                    oExcel.Cells(linea, 4).Font.Size = 13
                    oExcel.Cells(linea, 4) = "MODULE THAT GENERATES:"

                    linea = linea + 1

                    oExcel.Cells(linea, 1).Font.Size = 13
                    oExcel.Cells(linea, 1) = "USER:"
                    oExcel.Cells(linea, 4).Font.Size = 13
                    oExcel.Cells(linea, 4) = "OPERATION DATE:"

                    linea = linea + 1

                    oExcel.Cells(linea, 1).Font.Size = 13
                    oExcel.Cells(linea, 1) = "STATUS:"

                    linea = linea + 2

                    '-- Títulos de las columnas
                    oExcel.Cells(linea, 1).ColumnWidth = 14
                    oExcel.Cells(linea, 1) = "LINE"
                    oExcel.Cells(linea, 2).ColumnWidth = 12
                    oExcel.Cells(linea, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 2) = "TYPE"
                    oExcel.Cells(linea, 3).ColumnWidth = 18
                    oExcel.Cells(linea, 3) = "CENTER"
                    oExcel.Cells(linea, 4).ColumnWidth = 28
                    oExcel.Cells(linea, 4) = "ACCOUNTING ACCOUNT"
                    oExcel.Cells(linea, 5).ColumnWidth = 30
                    oExcel.Cells(linea, 5) = "ACCOUNT DESCRIPTION"

                    '-- Dibujo un cuadro
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Font.Size = 11
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    oExcel.Cells(linea, 8).Font.Size = 10
                    oExcel.Cells(linea, 8).ColumnWidth = 12
                    oExcel.Cells(linea, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 8) = "DEBIT"
                    oExcel.Cells(linea, 9).Font.Size = 10
                    oExcel.Cells(linea, 9).ColumnWidth = 12
                    oExcel.Cells(linea, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    oExcel.Cells(linea, 9) = "CREDIT"

                    linea = linea + 1

                    Dim primerVez As Boolean = True

                    Dim lineaInicial As Integer = linea - 1

                    Dim totalDebitos As Decimal = 0
                    Dim totalCreditos As Decimal = 0

                    For Each filaData As DataRow In data.Tables(0).Rows
                        If primerVez Then
                            'linea = linea + 1
                            documentoOrigen = filaData.Item("DOCUMENTO_ORIGEN").ToString.Trim

                            oExcel.Cells(lineaTransaction, 3).Font.Size = 12
                            oExcel.Cells(lineaTransaction, 3).NumberFormat = "@"
                            oExcel.Cells(lineaTransaction, 3) = filaData.Item("TIPO_PARTIDA").ToString.Trim + " - " + filaData.Item("NOMBRE_TIPO").ToString.Trim
                            oExcel.Cells(lineaTransaction, 6).Font.Size = 13
                            oExcel.Cells(lineaTransaction, 6).ColumnWidth = 13
                            oExcel.Cells(lineaTransaction, 6).NumberFormat = "@"
                            If documentoOrigen = "PA" Then
                                oExcel.Cells(lineaTransaction, 6) = "Transaction"
                            Else
                                oExcel.Cells(lineaTransaction, 6) = "Asset"
                            End If
                            oExcel.Cells(lineaTransaction, 7).Font.Size = 12
                            oExcel.Cells(lineaTransaction, 7).ColumnWidth = 20
                            oExcel.Cells(lineaTransaction, 7).NumberFormat = "@"
                            If documentoOrigen = "PA" Then
                                oExcel.Cells(lineaTransaction, 7) = filaData.Item("ORIGEN1").ToString.Trim + " - " + filaData.Item("DESCRIPCION_ORIGEN1_PA").ToString.Trim
                            Else
                                oExcel.Cells(lineaTransaction, 7) = filaData.Item("ORIGEN1").ToString.Trim + " - " + filaData.Item("DESCRIPCION_ORIGEN1_ELSE").ToString.Trim
                            End If

                            lineaTransaction = lineaTransaction + 1

                            oExcel.Cells(lineaTransaction, 3).Font.Size = 12
                            oExcel.Cells(lineaTransaction, 3).NumberFormat = "@"
                            oExcel.Cells(lineaTransaction, 3) = filaData.Item("FECHA_PARTIDA").ToString.Trim
                            oExcel.Cells(lineaTransaction, 6).Font.Size = 13
                            oExcel.Cells(lineaTransaction, 6).NumberFormat = "@"
                            If documentoOrigen = "PA" Then
                                oExcel.Cells(lineaTransaction, 6) = "Year"
                            Else
                                oExcel.Cells(lineaTransaction, 6) = "Upgrade"
                            End If
                            oExcel.Cells(lineaTransaction, 7).Font.Size = 12
                            oExcel.Cells(lineaTransaction, 7).NumberFormat = "@"
                            oExcel.Cells(lineaTransaction, 7) = filaData.Item("ORIGEN2").ToString.Trim

                            lineaTransaction = lineaTransaction + 1

                            oExcel.Cells(lineaTransaction, 3).Font.Size = 12
                            oExcel.Cells(lineaTransaction, 3).NumberFormat = "@"
                            oExcel.Cells(lineaTransaction, 3) = filaData.Item("DESCRIPCION_1").ToString.Trim
                            oExcel.Cells(lineaTransaction, 6).Font.Size = 13
                            oExcel.Cells(lineaTransaction, 6).NumberFormat = "@"
                            If documentoOrigen = "PA" Then
                                oExcel.Cells(lineaTransaction, 6) = "Period"
                            Else
                                oExcel.Cells(lineaTransaction, 6) = "Transaction"
                            End If
                            oExcel.Cells(lineaTransaction, 7).Font.Size = 12
                            oExcel.Cells(lineaTransaction, 7).NumberFormat = "@"
                            If filaData.IsNull("DESCRIPCION_ORIGEN3_NOT_PA") = False Then
                                If filaData.Item("DESCRIPCION_ORIGEN3_NOT_PA").ToString.Trim <> "" Then
                                    oExcel.Cells(lineaTransaction, 7) = filaData.Item("ORIGEN3").ToString.Trim + " - " + filaData.Item("DESCRIPCION_ORIGEN3_NOT_PA").ToString.Trim
                                Else
                                    oExcel.Cells(lineaTransaction, 7) = filaData.Item("ORIGEN3").ToString.Trim
                                End If
                            Else
                                oExcel.Cells(lineaTransaction, 7) = filaData.Item("ORIGEN3").ToString.Trim
                            End If

                            lineaTransaction = lineaTransaction + 1

                            oExcel.Cells(lineaTransaction, 3).Font.Size = 12
                            oExcel.Cells(lineaTransaction, 3).NumberFormat = "@"
                            oExcel.Cells(lineaTransaction, 3) = filaData.Item("DESCRIPCION_2").ToString.Trim

                            lineaTransaction = lineaTransaction + 1

                            oExcel.Cells(lineaTransaction, 3).Font.Size = 12
                            oExcel.Cells(lineaTransaction, 3).NumberFormat = "@"
                            oExcel.Cells(lineaTransaction, 3) = filaData.Item("DESCRIPCION_3").ToString.Trim

                            lineaTransaction = lineaTransaction + 1

                            oExcel.Cells(lineaTransaction, 3).Font.Size = 12
                            oExcel.Cells(lineaTransaction, 3).NumberFormat = "@"
                            oExcel.Cells(lineaTransaction, 3) = filaData.Item("DESCRIPCION_4").ToString.Trim

                            lineaTransaction = lineaTransaction + 1

                            oExcel.Cells(lineaTransaction, 3).Font.Size = 12
                            oExcel.Cells(lineaTransaction, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                            oExcel.Cells(lineaTransaction, 3).NumberFormat = "###,###,##0.000000;[Red](###,###,##0.000000)"
                            oExcel.Cells(lineaTransaction, 3) = filaData.Item("TASA_CAMBIO").ToString.Trim
                            oExcel.Cells(lineaTransaction, 5).Font.Size = 12
                            oExcel.Cells(lineaTransaction, 5).NumberFormat = "@"
                            oExcel.Cells(lineaTransaction, 5) = filaData.Item("TIPO_PARTIDA").ToString.Trim

                            lineaTransaction = lineaTransaction + 1

                            oExcel.Cells(lineaTransaction, 3).Font.Size = 12
                            oExcel.Cells(lineaTransaction, 3).NumberFormat = "@"
                            oExcel.Cells(lineaTransaction, 3) = filaData.Item("USUARIO_INGRESO").ToString.Trim
                            oExcel.Cells(lineaTransaction, 5).Font.Size = 12
                            oExcel.Cells(lineaTransaction, 5).NumberFormat = "@"
                            oExcel.Cells(lineaTransaction, 5) = filaData.Item("FECHA_INGRESO").ToString.Trim

                            lineaTransaction = lineaTransaction + 1

                            oExcel.Cells(lineaTransaction, 3).Font.Size = 12
                            oExcel.Cells(lineaTransaction, 3).NumberFormat = "@"
                            oExcel.Cells(lineaTransaction, 3) = DevuelveEstadoPartida(filaData.Item("ESTADO_PARTIDA").ToString.Trim, False)

                            linea = linea + 1

                            primerVez = False
                        End If

                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = filaData.Item("CORRELATIVO").ToString.Trim
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("TIPO_CATALOGO").ToString.Trim
                        oExcel.Cells(linea, 3).NumberFormat = "@"
                        oExcel.Cells(linea, 3) = filaData.Item("CODIGO_CENTRO").ToString.Trim
                        oExcel.Cells(linea, 4).NumberFormat = "@"
                        oExcel.Cells(linea, 4) = filaData.Item("CUENTA_CONTABLE").ToString.Trim
                        oExcel.Cells(linea, 5).NumberFormat = "@"
                        oExcel.Cells(linea, 5) = filaData.Item("DESCRIPCION").ToString.Trim


                        oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"

                        If filaData.IsNull("DEBITO_CREDITO") = False And filaData.IsNull("MONTO") = False Then
                            If filaData.Item("DEBITO_CREDITO").ToString.Trim = "D" Then
                                oExcel.Cells(linea, 8) = filaData.Item("MONTO")
                                totalDebitos = totalDebitos + filaData.Item("MONTO")
                            Else
                                oExcel.Cells(linea, 9) = filaData.Item("MONTO")
                                totalCreditos = totalCreditos + filaData.Item("MONTO")
                            End If
                        End If

                        linea = linea + 1
                    Next

                    '-- Dibujo el cuadro externo
                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea - 1, totalColumnas))
                    columnaCuadro.Font.Size = 10
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    oExcel.Cells(linea, 8).Font.Bold = True
                    oExcel.Cells(linea, 8).Font.Size = 11
                    oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 8) = totalDebitos
                    oExcel.Cells(linea, 9).Font.Bold = True
                    oExcel.Cells(linea, 9).Font.Size = 11
                    oExcel.Cells(linea, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                    oExcel.Cells(linea, 9) = totalCreditos

                    Dim spGT As New CultureInfo("es-GT")

                    oExcel.Cells(2, 1).font.Size = 9
                    oExcel.Cells(2, 1).NumberFormat = "@"
                    oExcel.Cells(2, 1) = parametros(4)
                    oExcel.Cells(1, totalColumnas).font.Size = 9
                    oExcel.Cells(1, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(1, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(1, totalColumnas) = Now.Date.ToString("d", spGT)
                    oExcel.Cells(2, totalColumnas).font.Size = 9
                    oExcel.Cells(2, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(2, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(2, totalColumnas) = DateTime.Now.ToString("T", spGT)
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub AssetInfo(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT a.CODIGO_DE_ACTIVO")
            .Append("     , a.MEJORA_CORRELATIVO")
            .Append("     , a.DESCRIP_CORTA_ACTIVO")
            .Append("     , a.VALOR_ORIGINAL_ACTIV")
            .Append("     , a.VALOR_ACTUAL_ACTIVO")
            .Append("     , a.DESAPARECIDO")
            .Append("     , u.DESCRIPCION_UBICACION")
            .Append("     , r.NOMBRE_USUAL + ' - ' + r.NOMBRE_RESPONSABLE + ' ' + r.APELLIDO_PATERNO As Responsable")
            .Append("     , f.FOTO")
            .Append("     , p.nombre_proveedor")
            .Append("  FROM            ACTIVOS_FIJOS       a")
            .Append("  LEFT OUTER JOIN ACTIVOS_FIJOS_FOTOS f ON (a.CODIGO_DE_ACTIVO = f.CODIGO_DE_ACTIVO AND a.MEJORA_CORRELATIVO = f.MEJORA_CORRELATIVO)")
            .Append("  LEFT OUTER JOIN PROVEEDORES         p ON (a.CODIGO_PROVEEDOR = p.CODIGO_PROVEEDOR)")
            .Append("  LEFT OUTER JOIN ACT_RESPONSABLES    r ON (a.RESPONSABLE_ID = r.RESPONSABLE_ID)")
            .Append("  LEFT OUTER JOIN UBICACION_ACTIVO    u ON (a.CODIGO_UBICACION = u.CODIGO_UBICACION)")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If

            .Append(" ORDER BY a.CODIGO_DE_ACTIVO, a.MEJORA_CORRELATIVO")
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CrearReporteAssetInfo(data, parametros)
    End Sub

    Private Shared Sub CrearReporteAssetInfo(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 3

                    Dim totalColumnas As Integer = 4
                    Dim columnaCuadro As Excel.Range

                    oExcel.Cells(linea, 1) = "Fixed Asset' File"
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 16
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea += 2

                    Dim lineaInicial As Integer = linea

                    Dim lineaAux As Integer = 0

                    For Each filaData As DataRow In data.Tables(0).Rows
                        oExcel.Cells(linea, 1).Font.Size = 14
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1).ColumnWidth = 25
                        oExcel.Cells(linea, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 1) = "ID"
                        oExcel.Cells(linea, 2).Font.Size = 12
                        oExcel.Cells(linea, 2).ColumnWidth = 30
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("CODIGO_DE_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 3).Font.Size = 12
                        oExcel.Cells(linea, 3).ColumnWidth = 10
                        oExcel.Cells(linea, 3).NumberFormat = "@"
                        oExcel.Cells(linea, 3) = filaData.Item("MEJORA_CORRELATIVO").ToString.Trim
                        oExcel.Cells(linea, 4).Font.Size = 14
                        oExcel.Cells(linea, 4).Font.Bold = True
                        oExcel.Cells(linea, 4).ColumnWidth = 18
                        oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        If filaData.IsNull("DESAPARECIDO") = False Then
                            If filaData.Item("DESAPARECIDO") = "S" Then
                                oExcel.Cells(linea, 4) = "*** MISSING ***"
                            End If
                        End If

                        linea = linea + 1

                        oExcel.Cells(linea, 1).Font.Size = 14
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = "Description"
                        oExcel.Cells(linea, 2).Font.Size = 12
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("DESCRIP_CORTA_ACTIVO").ToString.Trim

                        linea = linea + 1

                        oExcel.Cells(linea, 1).Font.Size = 14
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = "Original Value"
                        oExcel.Cells(linea, 2).Font.Size = 12
                        oExcel.Cells(linea, 2).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 2) = filaData.Item("VALOR_ORIGINAL_ACTIV").ToString.Trim

                        linea = linea + 1

                        oExcel.Cells(linea, 1).Font.Size = 14
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = "Current Value"
                        oExcel.Cells(linea, 2).Font.Size = 12
                        oExcel.Cells(linea, 2).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 2) = filaData.Item("VALOR_ACTUAL_ACTIVO").ToString.Trim

                        linea = linea + 1

                        oExcel.Cells(linea, 1).Font.Size = 14
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = "Location"
                        oExcel.Cells(linea, 2).Font.Size = 12
                        oExcel.Cells(linea, 2).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 2) = filaData.Item("DESCRIPCION_UBICACION").ToString.Trim

                        linea = linea + 1

                        oExcel.Cells(linea, 1).Font.Size = 14
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = "Responsible"
                        oExcel.Cells(linea, 2).Font.Size = 12
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("Responsable").ToString.Trim

                        linea = linea + 1

                        oExcel.Cells(linea, 1).Font.Size = 14
                        oExcel.Cells(linea, 1).Font.Bold = True
                        oExcel.Cells(linea, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = "Picture"

                        If Not filaData.IsNull("FOTO") Then
                            'Dim imagen() As Byte = filaData.Item("FOTO")
                            'Dim myStream As IO.MemoryStream = New IO.MemoryStream(imagen, True)

                            'myStream.Write(imagen, 0, imagen.Length)

                            'Dim imagenFinal As New System.Drawing.Bitmap(myStream)

                            'Clipboard.SetDataObject(imagenFinal)

                            'columnaCuadro = oExcel.Range(oExcel.Cells(linea, 2), oExcel.Cells(linea, 2))
                            'columnaCuadro.Select()
                            'columnaCuadro.PasteSpecial()
                        End If

                        linea = linea + 3
                    Next

                    linea = linea - 3

                    '-- Dibujo el cuadro externo
                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 2

                    Dim spGT As New CultureInfo("es-GT")

                    oExcel.Cells(linea, totalColumnas).font.Size = 9
                    oExcel.Cells(linea, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(linea, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, totalColumnas) = DateTime.Now.ToString("dd-MMM-yyyy HH:mm tt", spGT)
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub Divisiones(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT d.CODIGO_DIVISION")
            .Append("     , d.DESCRIPCION_DIVISION")
            .Append("     , d.DIRECCION_DIVISION")
            .Append("     , d.TIPO_CATALOGO")
            .Append("     , d.CODIGO_CENTRO")
            .Append("     , d.RESPONSABLE_DIVISION")
            .Append("     , d.CUENTA_CONTABLE_SXP")
            .Append("     , d.TELEFONO_DIVISION")
            .Append("  FROM DIVISIONES d")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If

            .Append(" ORDER BY d.CODIGO_DIVISION")
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CrearReporteDivisiones(data, parametros)
    End Sub

    Private Shared Sub CrearReporteDivisiones(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 3

                    Dim totalColumnas As Integer = 8
                    Dim columnaCuadro As Excel.Range

                    oExcel.Cells(linea, 1) = Citi.Synergia.Traductor.Idiomas.GetMensaje(276, "Reporte de Divisiones")
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 16
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea += 2

                    '-- Títulos de las columnas
                    oExcel.Cells(linea, 1).ColumnWidth = 14
                    oExcel.Cells(linea, 1) = "ID"
                    oExcel.Cells(linea, 2).ColumnWidth = 28
                    oExcel.Cells(linea, 2) = "DESCRIPTION"
                    oExcel.Cells(linea, 3).ColumnWidth = 20
                    oExcel.Cells(linea, 3) = "ADDRESS"
                    oExcel.Cells(linea, 4).ColumnWidth = 9
                    oExcel.Cells(linea, 4) = "CATALOG"
                    oExcel.Cells(linea, 5).ColumnWidth = 15
                    oExcel.Cells(linea, 5) = "CENTER"
                    oExcel.Cells(linea, 6).ColumnWidth = 18
                    oExcel.Cells(linea, 6) = "RESPONSIBLE"
                    oExcel.Cells(linea, 7).ColumnWidth = 30
                    oExcel.Cells(linea, 7) = "EXPENSE STATIONARY ACCOUNT"
                    oExcel.Cells(linea, 8).ColumnWidth = 18
                    oExcel.Cells(linea, 8) = "PHONE"

                    '-- Dibujo un cuadro
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Font.Size = 11
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    Dim contador As Integer = 0

                    Dim lineaInicial As Integer = linea - 1

                    For Each filaData As DataRow In data.Tables(0).Rows
                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = filaData.Item("CODIGO_DIVISION").ToString.Trim
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("DESCRIPCION_DIVISION").ToString.Trim
                        oExcel.Cells(linea, 3).NumberFormat = "@"
                        oExcel.Cells(linea, 3) = filaData.Item("DIRECCION_DIVISION").ToString.Trim
                        oExcel.Cells(linea, 4).NumberFormat = "@"
                        oExcel.Cells(linea, 4) = filaData.Item("TIPO_CATALOGO").ToString.Trim
                        oExcel.Cells(linea, 5).NumberFormat = "@"
                        oExcel.Cells(linea, 5) = filaData.Item("CODIGO_CENTRO").ToString.Trim
                        oExcel.Cells(linea, 6).NumberFormat = "@"
                        oExcel.Cells(linea, 6) = filaData.Item("RESPONSABLE_DIVISION").ToString.Trim
                        oExcel.Cells(linea, 7).NumberFormat = "@"
                        oExcel.Cells(linea, 7) = filaData.Item("CUENTA_CONTABLE_SXP").ToString.Trim
                        oExcel.Cells(linea, 8).NumberFormat = "@"
                        oExcel.Cells(linea, 8) = filaData.Item("TELEFONO_DIVISION").ToString.Trim

                        columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.Font.Size = 9
                        columnaCuadro.BorderAround(Excel.XlLineStyle.xlDot, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                        contador = contador + 1

                        linea = linea + 1
                    Next

                    '-- Dibujo el cuadro externo
                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea - 1, totalColumnas))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    oExcel.Cells(linea, totalColumnas).Font.Bold = True
                    oExcel.Cells(linea, totalColumnas).Font.Size = 11
                    oExcel.Cells(linea, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(linea, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, totalColumnas) = "*** Quantity of departments: " + contador.ToString + " ***"

                    Dim spGT As New CultureInfo("es-GT")

                    oExcel.Cells(2, 1).font.Size = 9
                    oExcel.Cells(2, 1).NumberFormat = "@"
                    oExcel.Cells(2, 1) = parametros(0)
                    oExcel.Cells(1, totalColumnas).font.Size = 9
                    oExcel.Cells(1, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(1, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(1, totalColumnas) = Now.Date.ToString("d", spGT)
                    oExcel.Cells(2, totalColumnas).font.Size = 9
                    oExcel.Cells(2, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(2, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(2, totalColumnas) = DateTime.Now.ToString("T", spGT)
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub Monedas(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT m.CODIGO_DE_MONEDA")
            .Append("     , m.DESCRIPCION_MONEDA")
            .Append("     , m.SIGNO_DE_MONEDA")
            .Append("  FROM MONEDAS m")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If

            .Append(" ORDER BY m.CODIGO_DE_MONEDA")
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CrearReporteMonedas(data, parametros)
    End Sub

    Private Shared Sub CrearReporteMonedas(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 3

                    Dim totalColumnas As Integer = 3
                    Dim columnaCuadro As Excel.Range

                    oExcel.Cells(linea, 1) = Citi.Synergia.Traductor.Idiomas.GetMensaje(277, "Reporte de Monedas")
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 16
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea += 2

                    '-- Títulos de las columnas
                    oExcel.Cells(linea, 1).ColumnWidth = 18
                    oExcel.Cells(linea, 1) = "ID"
                    oExcel.Cells(linea, 2).ColumnWidth = 35
                    oExcel.Cells(linea, 2) = "DESCRIPTION"
                    oExcel.Cells(linea, 3).ColumnWidth = 20
                    oExcel.Cells(linea, 3) = "SIGN"

                    '-- Dibujo un cuadro
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Font.Size = 11
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    Dim contador As Integer = 0

                    Dim lineaInicial As Integer = linea - 1

                    For Each filaData As DataRow In data.Tables(0).Rows
                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = filaData.Item("CODIGO_DE_MONEDA").ToString.Trim
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("DESCRIPCION_MONEDA").ToString.Trim
                        oExcel.Cells(linea, 3).NumberFormat = "@"
                        oExcel.Cells(linea, 3) = filaData.Item("SIGNO_DE_MONEDA").ToString.Trim

                        columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.Font.Size = 9
                        columnaCuadro.BorderAround(Excel.XlLineStyle.xlDot, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                        contador = contador + 1

                        linea = linea + 1
                    Next

                    '-- Dibujo el cuadro externo
                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea - 1, totalColumnas))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    oExcel.Cells(linea, totalColumnas).Font.Bold = True
                    oExcel.Cells(linea, totalColumnas).Font.Size = 11
                    oExcel.Cells(linea, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(linea, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, totalColumnas) = "*** Quantity of currencies: " + contador.ToString + " ***"

                    Dim spGT As New CultureInfo("es-GT")

                    oExcel.Cells(2, 1).font.Size = 9
                    oExcel.Cells(2, 1).NumberFormat = "@"
                    oExcel.Cells(2, 1) = parametros(0)
                    oExcel.Cells(1, totalColumnas).font.Size = 9
                    oExcel.Cells(1, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(1, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(1, totalColumnas) = Now.Date.ToString("d", spGT)
                    oExcel.Cells(2, totalColumnas).font.Size = 9
                    oExcel.Cells(2, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(2, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(2, totalColumnas) = DateTime.Now.ToString("T", spGT)
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub TiposActivosFijos(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT t.CODIGO_TIPO_ACTIVO")
            .Append("     , t.DESCRIP_TIPO_ACTIVO")
            .Append("     , t.TIPO_DEPRECIACION")
            .Append("     , t.TIPO_CATALOGO")
            .Append("     , t.CODIGO_CENTRO_ACTIVO")
            .Append("     , t.CTA_ACTIVO")
            .Append("     , c.NOMBRE_CATALOGO")
            .Append("     , t.FORZAR_FECHA_ACTIVO")
            .Append("     , t.MONTO_MINIMO_ACTIVO")
            .Append("     , t.CLA_CONTABILIZACION")
            .Append("     , t.CTA_DEPREC_ACUM")
            .Append("  FROM            TIPOS_DE_ACTIVOS  t")
            .Append("  LEFT OUTER JOIN CATALOGO_CONT_ENC c ON (t.TIPO_CATALOGO = c.TIPO_CATALOGO)")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If

            .Append(" ORDER BY t.CODIGO_TIPO_ACTIVO")
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CrearReporteTiposActivosFijos(data, parametros)
    End Sub

    Private Shared Sub CrearReporteTiposActivosFijos(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 3

                    Dim totalColumnas As Integer = 10
                    Dim columnaCuadro As Excel.Range

                    oExcel.Cells(linea, 1) = Citi.Synergia.Traductor.Idiomas.GetMensaje(33, "Tipo de Activos")
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 16
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea += 2

                    '-- Títulos de las columnas
                    oExcel.Cells(linea, 1).ColumnWidth = 9
                    oExcel.Cells(linea, 1) = "ID"
                    oExcel.Cells(linea, 2).ColumnWidth = 22
                    oExcel.Cells(linea, 2) = "DESCRIPTION"
                    oExcel.Cells(linea, 3).ColumnWidth = 24
                    oExcel.Cells(linea, 3) = "CATALOG DESCRIPTION"
                    oExcel.Cells(linea, 4).ColumnWidth = 20
                    oExcel.Cells(linea, 4) = "DEPRECIATION TYPE"
                    oExcel.Cells(linea, 5).ColumnWidth = 15
                    oExcel.Cells(linea, 5) = "ASSET CENTER"
                    oExcel.Cells(linea, 6).ColumnWidth = 20
                    oExcel.Cells(linea, 6) = "ASSET ACCOUNT"
                    oExcel.Cells(linea, 7).ColumnWidth = 20
                    oExcel.Cells(linea, 7) = "DEPRECIATION DAYS"
                    oExcel.Cells(linea, 8).ColumnWidth = 20
                    oExcel.Cells(linea, 8) = "MINIMUM AMOUNT"
                    oExcel.Cells(linea, 9).ColumnWidth = 25
                    oExcel.Cells(linea, 9) = "DEPRECIATION ACCOUNT"
                    oExcel.Cells(linea, 10).ColumnWidth = 25
                    oExcel.Cells(linea, 10) = "ACCOUNTING CLASS"

                    '-- Dibujo un cuadro
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Font.Size = 11
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    Dim contador As Integer = 0

                    Dim lineaInicial As Integer = linea - 1

                    For Each filaData As DataRow In data.Tables(0).Rows
                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = filaData.Item("CODIGO_TIPO_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("DESCRIP_TIPO_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 3).NumberFormat = "@"
                        oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 3) = filaData.Item("TIPO_CATALOGO").ToString.Trim + " - " + filaData.Item("NOMBRE_CATALOGO").ToString.Trim
                        oExcel.Cells(linea, 4).NumberFormat = "@"
                        oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 4) = DevuelveTipoDepreciacion(filaData.Item("TIPO_DEPRECIACION").ToString.Trim, True)
                        oExcel.Cells(linea, 5).NumberFormat = "@"
                        oExcel.Cells(linea, 5) = filaData.Item("CODIGO_CENTRO_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 6).NumberFormat = "@"
                        oExcel.Cells(linea, 6) = filaData.Item("CTA_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 7).NumberFormat = "###,###,##0;[Red](###,###,##0)"
                        oExcel.Cells(linea, 7) = filaData.Item("FORZAR_FECHA_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                        oExcel.Cells(linea, 8) = filaData.Item("MONTO_MINIMO_ACTIVO").ToString.Trim
                        oExcel.Cells(linea, 9).NumberFormat = "@"
                        oExcel.Cells(linea, 9) = filaData.Item("CTA_DEPREC_ACUM").ToString.Trim
                        oExcel.Cells(linea, 10).NumberFormat = "@"
                        oExcel.Cells(linea, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 10) = DevuelveClaseContabilidad(filaData.Item("CLA_CONTABILIZACION").ToString.Trim, True)

                        columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.Font.Size = 9
                        columnaCuadro.BorderAround(Excel.XlLineStyle.xlDot, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                        contador = contador + 1

                        linea = linea + 1
                    Next

                    '-- Dibujo el cuadro externo
                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea - 1, totalColumnas))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    oExcel.Cells(linea, totalColumnas).Font.Bold = True
                    oExcel.Cells(linea, totalColumnas).Font.Size = 11
                    oExcel.Cells(linea, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(linea, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, totalColumnas) = "*** Quantity of assets type: " + contador.ToString + " ***"

                    Dim spGT As New CultureInfo("es-GT")

                    oExcel.Cells(2, 1).font.Size = 9
                    oExcel.Cells(2, 1).NumberFormat = "@"
                    oExcel.Cells(2, 1) = parametros(0)
                    oExcel.Cells(1, totalColumnas).font.Size = 9
                    oExcel.Cells(1, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(1, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(1, totalColumnas) = Now.Date.ToString("d", spGT)
                    oExcel.Cells(2, totalColumnas).font.Size = 9
                    oExcel.Cells(2, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(2, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(2, totalColumnas) = DateTime.Now.ToString("T", spGT)
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub MovimientoActivos(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT t.DESCRIPCION_TIP_MOV")
            .Append("     , t.CLASE_MOVIMIENTO")
            .Append("     , t.TIPO_MOVIMIENTO")
            .Append("     , p.TIPO_PARTIDA")
            .Append("     , p.NOMBRE_TIPO")
            .Append("  FROM       TIPO_MOV_ACTIVOS t")
            .Append("  INNER JOIN TIPOS_PARTIDAS   p ON (t.TIPO_PARTIDA = p.TIPO_PARTIDA)")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If

            .Append(" ORDER BY t.TIPO_MOVIMIENTO")
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CrearReporteMovimientoActivos(data, parametros)
    End Sub

    Private Shared Sub CrearReporteMovimientoActivos(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 3

                    Dim totalColumnas As Integer = 4
                    Dim columnaCuadro As Excel.Range

                    oExcel.Cells(linea, 1) = Citi.Synergia.Traductor.Idiomas.GetMensaje(272, "Movimiento de activos")
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 16
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea += 2

                    '-- Títulos de las columnas
                    oExcel.Cells(linea, 1).ColumnWidth = 9
                    oExcel.Cells(linea, 1) = "TYPE"
                    oExcel.Cells(linea, 2).ColumnWidth = 22
                    oExcel.Cells(linea, 2) = "DESCRIPTION"
                    oExcel.Cells(linea, 3).ColumnWidth = 24
                    oExcel.Cells(linea, 3) = "TRANSACTION TYPE"
                    oExcel.Cells(linea, 4).ColumnWidth = 27
                    oExcel.Cells(linea, 4) = "REGISTRY - ACCOUNT TYPE"

                    '-- Dibujo un cuadro
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Font.Size = 11
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    Dim contador As Integer = 0

                    Dim lineaInicial As Integer = linea - 1

                    For Each filaData As DataRow In data.Tables(0).Rows
                        oExcel.Cells(linea, 1).NumberFormat = "@"
                        oExcel.Cells(linea, 1) = filaData.Item("TIPO_MOVIMIENTO").ToString.Trim
                        oExcel.Cells(linea, 2).NumberFormat = "@"
                        oExcel.Cells(linea, 2) = filaData.Item("DESCRIPCION_TIP_MOV").ToString.Trim
                        oExcel.Cells(linea, 3).NumberFormat = "@"
                        oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 3) = DevuelveTipoMovimiento(filaData.Item("CLASE_MOVIMIENTO").ToString.Trim, True)
                        oExcel.Cells(linea, 4).NumberFormat = "@"
                        oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        oExcel.Cells(linea, 4) = filaData.Item("TIPO_PARTIDA").ToString.Trim + " - " + filaData.Item("NOMBRE_TIPO").ToString.Trim

                        columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                        columnaCuadro.Font.Size = 9
                        columnaCuadro.BorderAround(Excel.XlLineStyle.xlDot, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                        contador = contador + 1

                        linea = linea + 1
                    Next

                    '-- Dibujo el cuadro externo
                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea - 1, totalColumnas))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    oExcel.Cells(linea, totalColumnas).Font.Bold = True
                    oExcel.Cells(linea, totalColumnas).Font.Size = 11
                    oExcel.Cells(linea, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(linea, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, totalColumnas) = "*** Quantity of transactions type: " + contador.ToString + " ***"

                    Dim spGT As New CultureInfo("es-GT")

                    oExcel.Cells(2, 1).font.Size = 9
                    oExcel.Cells(2, 1).NumberFormat = "@"
                    oExcel.Cells(2, 1) = parametros(0)
                    oExcel.Cells(1, totalColumnas).font.Size = 9
                    oExcel.Cells(1, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(1, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(1, totalColumnas) = Now.Date.ToString("d", spGT)
                    oExcel.Cells(2, totalColumnas).font.Size = 9
                    oExcel.Cells(2, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(2, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(2, totalColumnas) = DateTime.Now.ToString("T", spGT)
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub

    Private Shared Sub Proveedores(ByVal parametros As List(Of String), Optional ByVal filtro As String = "")
        Dim comando As New SqlClient.SqlCommand

        Dim comandoSQL As New Text.StringBuilder
        With comandoSQL
            .Append("SELECT p.CODIGO_PROVEEDOR")
            .Append("     , p.TIPO_PROVEEDOR")
            .Append("     , p.nombre_proveedor")
            .Append("     , p.direccion_proveedor")
            .Append("     , p.telefonos_proveedor")
            .Append("     , p.fax_proveedor")
            .Append("     , p.nit_proveedor")
            .Append("     , p.Cedula_proveedor")
            .Append("     , p.porcentaje_descuento")
            .Append("     , p.Cod_postal_proveedor")
            .Append("     , p.paga_iva_proveedor")
            .Append("     , p.ORIGEN_PROVEEDOR")
            .Append("     , p.TOMA_DESCUENTOS")
            .Append("     , p.PROVEEDOR_UNICA_VEZ")
            .Append("     , p.ESTATUS_PROVEEDOR")
            .Append("     , p.congelado")
            .Append("     , p.PARTICIPA_RETENCION")
            .Append("     , c.DESCRIPCION_CLASE")
            .Append("     , b.NOMBRE_BANCO")
            .Append("     , m.DESCRIPCION_MONEDA")
            .Append("     , n.DESCRIPCI_CONDICION")
            .Append("     , t.DESC_TIPO_PAGO")
            .Append("     , s.NOMBRE_DEL_PAIS")
            .Append("     , i.DESCRIPCION_IMPUESTO")
            .Append("  FROM            PROVEEDORES         p")
            .Append("  INNER JOIN      CLASE_PROVEEDOR     c ON (p.CODIGO_CLASE_PROVEED = c.CODIGO_CLASE_PROVEED)")
            .Append("  LEFT OUTER JOIN BANCOS              b ON (p.CODIGO_BANCO = b.CODIGO_BANCO)")
            .Append("  INNER JOIN      MONEDAS             m ON (p.CODIGO_DE_MONEDA = m.CODIGO_DE_MONEDA)")
            .Append("  INNER JOIN      CONDICIONES_DE_PAGO n ON (p.CODIGO_DE_CONDICION = n.CODIGO_DE_CONDICION)")
            .Append("  INNER JOIN      TIPOS_DE_PAGO       t ON (p.CODIGO_TIPO_PAGO = t.CODIGO_TIPO_PAGO)")
            .Append("  INNER JOIN      MAESTRO_PAISES      s ON (p.CODIGO_DE_PAIS = s.CODIGO_DE_PAIS)")
            .Append("  INNER JOIN      IMPUESTOS           i ON (p.CODIGO_IMPUESTO = i.CODIGO_IMPUESTO)")

            If filtro.Trim.Length > 0 Then
                .Append(" Where " + filtro)
            End If
        End With

        With comando
            .CommandText = comandoSQL.ToString
        End With

        Dim data As New DataSet
        data = GetDataSet(comando)

        CrearReporteProveedores(data, parametros)
    End Sub

    Private Shared Sub CrearReporteProveedores(ByVal data As DataSet, ByVal parametros As List(Of String))
        '-- Excel
        Dim oExcel As Excel.Application = Nothing

        Try
            Dim linea As Integer = 1

            If Not data Is Nothing Then
                If data.Tables.Count > 0 Then
                    oExcel = New Excel.Application
                    oExcel.Workbooks.Add()

                    oExcel.Cells(linea, 1).Font.Bold = True
                    oExcel.Cells(linea, 1).font.Size = 14
                    oExcel.Cells(linea, 1) = Citi.Synergia.Locals.Cache.Empresa

                    linea += 3

                    Dim totalColumnas As Integer = 24
                    Dim columnaCuadro As Excel.Range

                    oExcel.Cells(linea, 1) = Citi.Synergia.Traductor.Idiomas.GetMensaje(278, "Información General de Proveedores")
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Merge()
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.Font.Size = 16
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    linea += 2

                    ''-- Títulos de las columnas
                    'oExcel.Cells(linea, 1).ColumnWidth = 9
                    'oExcel.Cells(linea, 1) = "TYPE"
                    'oExcel.Cells(linea, 2).ColumnWidth = 22
                    'oExcel.Cells(linea, 2) = "DESCRIPTION"
                    'oExcel.Cells(linea, 3).ColumnWidth = 24
                    'oExcel.Cells(linea, 3) = "TRANSACTION TYPE"
                    'oExcel.Cells(linea, 4).ColumnWidth = 27
                    'oExcel.Cells(linea, 4) = "REGISTRY - ACCOUNT TYPE"

                    '-- Dibujo un cuadro
                    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    columnaCuadro.Font.Size = 11
                    columnaCuadro.Font.Bold = True
                    columnaCuadro.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    Dim contador As Integer = 0

                    Dim lineaInicial As Integer = linea - 1

                    'For Each filaData As DataRow In data.Tables(0).Rows
                    '    oExcel.Cells(linea, 1).NumberFormat = "@"
                    '    oExcel.Cells(linea, 1) = filaData.Item("TIPO_MOVIMIENTO").ToString.Trim
                    '    oExcel.Cells(linea, 2).NumberFormat = "@"
                    '    oExcel.Cells(linea, 2) = filaData.Item("DESCRIPCION_TIP_MOV").ToString.Trim
                    '    oExcel.Cells(linea, 3).NumberFormat = "@"
                    '    oExcel.Cells(linea, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    '    oExcel.Cells(linea, 3) = DevuelveTipoMovimiento(filaData.Item("CLASE_MOVIMIENTO").ToString.Trim, True)
                    '    oExcel.Cells(linea, 4).NumberFormat = "@"
                    '    oExcel.Cells(linea, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    '    oExcel.Cells(linea, 4) = filaData.Item("TIPO_PARTIDA").ToString.Trim + " - " + filaData.Item("NOMBRE_TIPO").ToString.Trim

                    '    columnaCuadro = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                    '    columnaCuadro.Font.Size = 9
                    '    columnaCuadro.BorderAround(Excel.XlLineStyle.xlDot, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    '    contador = contador + 1

                    '    linea = linea + 1
                    'Next

                    '-- Dibujo el cuadro externo
                    columnaCuadro = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea - 1, totalColumnas))
                    columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                    linea = linea + 1

                    oExcel.Cells(linea, totalColumnas).Font.Bold = True
                    oExcel.Cells(linea, totalColumnas).Font.Size = 11
                    oExcel.Cells(linea, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(linea, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(linea, totalColumnas) = "*** Quantity of Vendors: " + contador.ToString + " ***"

                    Dim spGT As New CultureInfo("es-GT")

                    oExcel.Cells(2, 1).font.Size = 9
                    oExcel.Cells(2, 1).NumberFormat = "@"
                    oExcel.Cells(2, 1) = parametros(0)
                    oExcel.Cells(1, totalColumnas).font.Size = 9
                    oExcel.Cells(1, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(1, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(1, totalColumnas) = Now.Date.ToString("d", spGT)
                    oExcel.Cells(2, totalColumnas).font.Size = 9
                    oExcel.Cells(2, totalColumnas).NumberFormat = "@"
                    oExcel.Cells(2, totalColumnas).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    oExcel.Cells(2, totalColumnas) = DateTime.Now.ToString("T", spGT)
                End If
            End If

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel = Nothing
            End If
            Throw ex
        End Try
    End Sub
#End Region
End Class
