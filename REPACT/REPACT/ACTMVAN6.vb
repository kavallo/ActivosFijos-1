Imports Citi.Synergia.HelperClient

Public Class ACTMVAN6
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()

        Me.ProponerFechaReporte()
    End Sub

    Private Sub ProponerFechaReporte()
        Dim fechaActual As Date

        Dim dia As String = String.Empty
        Dim mes As String = String.Empty
        Dim anio As String = String.Empty

        fechaActual = Date.Today

        mes = fechaActual.AddMonths(-1).Month.ToString
        If mes.Length = 1 Then
            mes = "0" & mes
        End If

        anio = fechaActual.Year
        If mes = "12" Then
            anio = fechaActual.AddYears(-1).Year.ToString
        End If

        Me.txtFechaInicio.EscribirFecha("01/" & mes & "/" & anio)

        dia = Date.DaysInMonth(CType(anio, Integer), CType(mes, Integer)).ToString
        If dia.Length = 1 Then
            dia = "0" & dia
        End If

        Me.txtFechaFin.EscribirFecha(dia & "/" & mes & "/" & anio)
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim fechaInicio, fechaFin As String

        If MyBase.ValidarCampos(Me) = False Then
            Return
        End If

        fechaInicio = Me.txtFechaInicio.TextMMDDYYYY()
        fechaFin = Me.txtFechaFin.TextMMDDYYYY()

        Try
            If Not MyBase.ValidaFecha(fechaInicio, fechaFin) Then
                MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(202, "Fecha inicial es mayor que fecha final."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtFechaInicio.Focus()
                Return
            End If

            'Borramos data anterior
            meteSQL("Delete PARAMETROS_REPORTE")
            meteSQL(" Where usuario = " & Scm(Citi.Synergia.Locals.Cache.UsuarioSSO))  '-- DescripcionesDB.TraeUsuario()))
            EjecutaSQL("")

            'Ingresamos los Datos a la tabla parametros_reporte
            meteSQL("Insert into PARAMETROS_REPORTE (USUARIO, PARAMETRO1, PARAMETRO2)")
            'meteSQL(" Select suser_sname(), '" & fechaInicio & " 12:00AM " & "', " & "'" & fechaFin & " 11:59PM " & Chr(39))
            meteSQL(" Select " & Scm(Citi.Synergia.Locals.Cache.UsuarioSSO) & ", '" & fechaInicio & " 12:00AM ', '" & fechaFin & " 11:59PM " & Chr(39))
            EjecutaSQL("")

            ''Ejecutamos el SP para actualizar la data del reporte
            'meteSQL("Exec sp_activos_tot_depreciados")
            'EjecutaSQL("")

            'Citi.Synergia.Reportes.Crystal.Parametros.Clear()
            'With Citi.Synergia.Reportes.Crystal.Parametros
            '    .Add(New Citi.Synergia.Reportes.Campos("_USUARIO", Scm(DescripcionesDB.TraeUsuario())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_EMPRESA", Scm(DescripcionesDB.TraeEmpresa())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_IDIOMA", Scm(Citi.Synergia.Locals.Cache.IdiomaSeleccionado)))
            'End With

            'If Citi.Synergia.Reportes.Crystal.ValidaReporte("totalmente_depreciados", True) = False Then
            '    Return
            'End If

            'Citi.Synergia.Reportes.Crystal.EjecutarReporte("totalmente_depreciados", , Citi.Synergia.Traductor.Idiomas.GetMensaje(273, "Activos totalmente depreciados"))


            Dim parametros As New List(Of String)
            With parametros
                .Add(fechaInicio)
                .Add(fechaFin)
                '.Add(DescripcionesDB.TraeUsuario())
                .Add(Citi.Synergia.Locals.Cache.UsuarioSSO)
            End With

            Citi.Synergia.Reports.Reportes.EjecutarReporte(Citi.Synergia.Reports.Reportes.ListadoReportes.totalmente_depreciados, parametros)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class