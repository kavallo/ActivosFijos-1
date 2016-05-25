Public Class Iconos
    Public Enum TipoIcono As Short
        Agregar
        Borrar
        Modificar
        Consultar
        BajarNivel
        Llenar
        Graficar
        Imprimir
        Copiar
        TiposGraficas
        Salir
        ConsultaDerecha
        ConsultaIzquierda
        ConsultaMovimientos
        ConsultaPartida
        Consolidar
        PolizasVencidas
        Mejorar
        InfoGeneral
        Traslado
        AsociarImagen
        ReporteFicha
        ReporteGeneral
        Reporte
        TasasDeCambio
        ListaValores
        Proceso
        Autoriza
        Revaluar
        Movimiento
        Calculo
        Autorizacion
        Coberturas
        Endoso
        Tabla
        CoberturaActivos
        BuscarCarpeta
        ExportarAExcel
        Editar
        TablaVer
    End Enum

    Public Enum Imagenes
        BuscarCarpeta
    End Enum

    Private alto As Integer = 32
    Private ancho As Integer = 32

    Public Function GetIcon(ByVal tipo As TipoIcono) As Drawing.Icon

        Dim oIcono As System.Drawing.Icon

        Select Case tipo
            Case TipoIcono.Agregar
                oIcono = New Drawing.Icon(My.Resources.Recursos.Agregar, ancho, alto)

            Case TipoIcono.Borrar
                oIcono = New Drawing.Icon(My.Resources.Recursos.Borrar, ancho, alto)

            Case TipoIcono.Modificar
                oIcono = New Drawing.Icon(My.Resources.Recursos.Modificar, ancho, alto)

            Case TipoIcono.Consultar
                oIcono = New Drawing.Icon(My.Resources.Recursos.Consultar, ancho, alto)

            Case TipoIcono.BajarNivel
                oIcono = New Drawing.Icon(My.Resources.Recursos.BajarNivel, ancho, alto)

            Case TipoIcono.Llenar
                oIcono = New Drawing.Icon(My.Resources.Recursos.Llenar, ancho, alto)

            Case TipoIcono.Graficar
                oIcono = New Drawing.Icon(My.Resources.Recursos.Graficar, ancho, alto)

            Case TipoIcono.Imprimir
                oIcono = New Drawing.Icon(My.Resources.Recursos.Iprimir, ancho, alto)

            Case TipoIcono.Copiar
                oIcono = New Drawing.Icon(My.Resources.Recursos.Copiar, ancho, alto)

            Case TipoIcono.TiposGraficas
                oIcono = New Drawing.Icon(My.Resources.Recursos.TiposGraficas, ancho, alto)

            Case TipoIcono.Salir
                oIcono = New Drawing.Icon(My.Resources.Recursos.Salir, ancho, alto)

            Case TipoIcono.ConsultaDerecha
                oIcono = New Drawing.Icon(My.Resources.Recursos.ConsultaDerecha, ancho, alto)

            Case TipoIcono.ConsultaIzquierda
                oIcono = New Drawing.Icon(My.Resources.Recursos.ConsultaIzquierda, ancho, alto)

            Case TipoIcono.ConsultaMovimientos
                oIcono = New Drawing.Icon(My.Resources.Recursos.ConsultaMovimientos, ancho, alto)

            Case TipoIcono.ConsultaPartida
                oIcono = New Drawing.Icon(My.Resources.Recursos.ConsultaPartida, ancho, alto)

            Case TipoIcono.Consolidar
                oIcono = New Drawing.Icon(My.Resources.Recursos.Consolidar, ancho, alto)

            Case TipoIcono.PolizasVencidas
                oIcono = New Drawing.Icon(My.Resources.Recursos.PolizasVencidas, ancho, alto)

            Case TipoIcono.Mejorar
                oIcono = New Drawing.Icon(My.Resources.Recursos.Mejorar, ancho, alto)

            Case TipoIcono.InfoGeneral
                oIcono = New Drawing.Icon(My.Resources.Recursos.InfoGeneral, ancho, alto)

            Case TipoIcono.Traslado
                oIcono = New Drawing.Icon(My.Resources.Recursos.Traslado, ancho, alto)

            Case TipoIcono.AsociarImagen
                oIcono = New Drawing.Icon(My.Resources.Recursos.AsociarImagen, ancho, alto)

            Case TipoIcono.ReporteFicha
                oIcono = New Drawing.Icon(My.Resources.Recursos.ReporteFicha, ancho, alto)

            Case TipoIcono.ReporteGeneral
                oIcono = New Drawing.Icon(My.Resources.Recursos.ReporteGeneral, ancho, alto)

            Case TipoIcono.Reporte
                oIcono = New Drawing.Icon(My.Resources.Recursos.Reporte, ancho, alto)

            Case TipoIcono.TasasDeCambio
                oIcono = New Drawing.Icon(My.Resources.Recursos.TasasDeCambio, ancho, alto)

            Case TipoIcono.ListaValores
                oIcono = New Drawing.Icon(My.Resources.Recursos.ListaValores, ancho, alto)

            Case TipoIcono.Proceso
                oIcono = New Drawing.Icon(My.Resources.Recursos.Proceso, ancho, alto)

            Case TipoIcono.Autoriza
                oIcono = New Drawing.Icon(My.Resources.Recursos.Autoriza, ancho, alto)

            Case TipoIcono.Revaluar
                oIcono = New Drawing.Icon(My.Resources.Recursos.Revaluar, ancho, alto)

            Case TipoIcono.Movimiento
                oIcono = New Drawing.Icon(My.Resources.Recursos.Movimiento, ancho, alto)

            Case TipoIcono.Calculo
                oIcono = New Drawing.Icon(My.Resources.Recursos.Calculo, ancho, alto)

            Case TipoIcono.Autorizacion
                oIcono = New Drawing.Icon(My.Resources.Recursos.Autorizacion, ancho, alto)

            Case TipoIcono.Coberturas
                oIcono = New Drawing.Icon(My.Resources.Recursos.Coberturas, ancho, alto)

            Case TipoIcono.Endoso
                oIcono = New Drawing.Icon(My.Resources.Recursos.Endoso, ancho, alto)

            Case TipoIcono.Tabla
                oIcono = New Drawing.Icon(My.Resources.Recursos.Tabla, ancho, alto)

            Case TipoIcono.CoberturaActivos
                oIcono = New Drawing.Icon(My.Resources.Recursos.CoberturaActivos, ancho, alto)

            Case TipoIcono.BuscarCarpeta
                oIcono = New Drawing.Icon(My.Resources.Recursos.BuscarCarpeta, ancho, alto)

            Case TipoIcono.ExportarAExcel
                oIcono = New Drawing.Icon(My.Resources.Recursos.ExportarAExcel, ancho, alto)

            Case TipoIcono.Editar
                oIcono = New Drawing.Icon(My.Resources.Recursos.Editar, ancho, alto)

            Case TipoIcono.TablaVer
                oIcono = New Drawing.Icon(My.Resources.Recursos.TablaVer, ancho, alto)

            Case Else
                oIcono = New Drawing.Icon(My.Resources.Recursos.NoEncontrada, ancho, alto)
        End Select

        Return oIcono
    End Function

    Public Function GetImagen(ByVal tipo As Imagenes, ByVal ancho As Integer, ByVal alto As Integer) As Drawing.Bitmap

        Dim oImagen As System.Drawing.Bitmap
        Select Case tipo
            Case Imagenes.BuscarCarpeta
                oImagen = New Drawing.Bitmap(My.Resources.Recursos.ImgBuscarCarpeta, ancho, alto)

            Case Else
                oImagen = New Drawing.Bitmap(GetIcon(TipoIcono.Borrar).ToBitmap, ancho, alto)
        End Select

        Return oImagen
    End Function
End Class
