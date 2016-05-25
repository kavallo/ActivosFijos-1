Imports Citi.Synergia.HelperClient

Public Class ACTRESN0
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Responsable_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RESP_INI.Leave, RESP_FIN.Leave
        Select Case sender.Name
            Case "RESP_INI"
                desRESP_INI.Text = DescripcionesDB.NombreUsualResponsable(RESP_INI.Text)
            Case "RESP_FIN"
                desRESP_FIN.Text = DescripcionesDB.NombreUsualResponsable(RESP_FIN.Text)
        End Select
    End Sub

    Private Sub ResponsableLabel_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRESP_INI.DoubleClick
        Select Case sender.Name
            Case "lblRESP_INI"
                RESP_INI.GenerarConsulta()
            Case "lblRESP_FIN"
                RESP_FIN.GenerarConsulta()
        End Select
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'Validamos que ingresen rango completo o ninguno
        If MyBase.ValidarCampos(Me) = False Then
            Return
        End If

        Dim filtro As String = String.Empty

        Dim responsableInicial As String = String.Empty
        Dim responsableFinal As String = String.Empty

        responsableInicial = RESP_INI.Text
        responsableFinal = RESP_FIN.Text

        'If RESP_INI.Text <> "" Then
        '    'Condicionamos rango si lo han definido
        '    filtro = "( Not IsNull({ACTIVOS_FIJOS.RESPONSABLE_ID}) And {ACTIVOS_FIJOS.RESPONSABLE_ID} in " & Scm(RESP_INI.Text) & " to " & Scm(RESP_FIN.Text) & ")"
        'Else
        '    'Condicionamos todo el rango
        '    filtro = "( Not IsNull({ACTIVOS_FIJOS.RESPONSABLE_ID}) And {ACTIVOS_FIJOS.RESPONSABLE_ID} in '0' to 'z')"
        'End If

        'If SIN_RESP.CheckState = CheckState.Checked Then
        '    'Condicionamos que incluya los que no tienen responsable
        '    filtro = filtro & " Or IsNull({ACTIVOS_FIJOS.RESPONSABLE_ID})"
        'End If

        Try
            'Citi.Synergia.Reportes.Crystal.Parametros.Clear()
            'With Citi.Synergia.Reportes.Crystal.Parametros
            '    .Add(New Citi.Synergia.Reportes.Campos("_EMPRESA", Scm(DescripcionesDB.TraeEmpresa())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_USUARIO", Scm(DescripcionesDB.TraeUsuario())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_IDIOMA", Scm(Citi.Synergia.Locals.Cache.IdiomaSeleccionado)))
            'End With

            'If Citi.Synergia.Reportes.Crystal.ValidaReporte("Ficha_responsable", True) = False Then
            '    Return
            'End If

            'Citi.Synergia.Reportes.Crystal.EjecutarReporte("Ficha_responsable", filtro, Citi.Synergia.Traductor.Idiomas.GetMensaje(32, "Responsable"))


            filtro = String.Empty
            filtro = "(a.RESPONSABLE_ID is not null"
            If responsableInicial <> "" Then
                filtro = filtro + " And (a.RESPONSABLE_ID Between '" + responsableInicial + "' And '" + responsableFinal + "')"
            End If
            filtro = filtro + ")"
            If SIN_RESP.CheckState = CheckState.Checked Then
                filtro = filtro + " Or a.RESPONSABLE_ID is null"
            End If

            Dim parametros As New List(Of String)
            With parametros
                .Add(responsableInicial)
                .Add(responsableFinal)
                '.Add(DescripcionesDB.TraeUsuario())
                .Add(Citi.Synergia.Locals.Cache.UsuarioSSO)
            End With

            Citi.Synergia.Reports.Reportes.EjecutarReporte(Citi.Synergia.Reports.Reportes.ListadoReportes.Ficha_responsable, parametros, filtro)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class