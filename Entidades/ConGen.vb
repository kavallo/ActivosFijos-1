Public Class ConGenControlesLlave
    Public Property Titulo As String
    Public Property Control As Object

    Public Sub New()
        Titulo = String.Empty
        Control = Nothing
    End Sub
    Public Sub New(ByVal titulo As String, ByVal control As Object)
        Me.Titulo = titulo
        Me.Control = control
    End Sub
End Class

Public Class ConGenCampos
    Public Property Nombre As String
    Public Property Titulo As String
    Public Property EsLlave As Boolean
    Public Property Retorna As Boolean
    Public Property IdLenguaje As Integer
    Public Property ValorRetorno As String

    Public Sub New()
        Nombre = String.Empty
        Titulo = String.Empty
        EsLlave = False
        Retorna = False
        IdLenguaje = 0
    End Sub

    Public Sub New(ByVal nombre As String, ByVal titulo As String, ByVal esLlave As Boolean, ByVal retorna As Boolean, ByVal idLenguaje As Integer)
        Me.Nombre = nombre
        Me.Titulo = titulo
        Me.EsLlave = esLlave
        Me.Retorna = retorna
        Me.IdLenguaje = idLenguaje
    End Sub
End Class
Public Class ConGen
    Public Enum NombreConsulta
        ListaDeCatalogosContables_CACOEC01
        ListaDeCentrosDeResponsabilidad_CERESC01
        ListaDeMayorGeneral_MAYGEC01
        ListaDeTiposDePartidas_TIPARC01
        EmpleadosPorDivisiones_NOMEMPS8
        ListaDeBancos_BANCOC01
        ListaDeImpuestos_IMPUEC01
        ListaDeTiposDeActivos_TIPOACT
        ListaDeEmpleados_NOMEMPL0
        ListaDeDivisiones_DIVISC01
        ListaDeMonedas_MONEDC01
        ListaDeActivosFijos_ACTMAFL0
        ListaDeMarcas_MARCAC01
        ListaDeUbicacionesDeActivosFijos_ACTUBIL0
        ListaDeResponsablesDeActivosFijos_ACTRAFL0
        ListaDeCategoriasDeActivos_ACTCDAL0
        ListaDeTiposDeMovimientosDeActivos_ACTTMAL0
        ListaDeCatalogoContablePorTipoDeCatalogo_CACODC03
        ListaDeClasesDeProveedor_CLPROC01
        ListaDeCuentasPorBanco_CUENTC01
        ListaDeCondicionesDePago_CONDIC01
        ListaDeTiposDePago_TIPPAC01
        ListaDePaises_PAISEC01
        ListaDeFormatosDeOrdenDeCompra_GYSFORL6
        ListaDeProductos_MPRODC01
        ListaDeTiposDeServicio_ACTTSAL0
        ListaDePeriodosContables_PECONC02
    End Enum

    Public Property Consulta As NombreConsulta
    Public Property FromSQL As String
    Public Property WhereSQL As String
    Public Property OrderBySQL As String

    Public Property Campos As New List(Of ConGenCampos)
    Public Property Llaves As New List(Of ConGenControlesLlave)

    Public TituloForma As String

    Public Sub New()
        TituloForma = String.Empty
    End Sub

End Class
