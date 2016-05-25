Imports Citi.Synergia.HelperClient

Public Class ACTMVAN7
    Private Sub Forma_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()
    End Sub

    Private Sub TipoActivo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTipoActivo.DoubleClick
        Me.txtTipoActivo.GenerarConsulta()
    End Sub

    Private Sub TipoActivo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoActivo.Leave
        Me.lblNombreTipo.Text = DescripcionesDB.TipoDeActivo(sender.Text)
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If MyBase.ValidarCampos(grpSeleccion) = False Then
            Return
        End If

        MyBase.ErrorCampos.SetError(Me.txtTipoActivo, Nothing)
        If lblNombreTipo.Text = "" Then
            MyBase.ErrorCampos.SetError(txtTipoActivo, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
            Return
        End If

        Try
            'Eliminamos informacion anterior del usuario
            meteSQL("Delete RTP_TIPOS_DE_ACTIVOS")
            meteSQL(" Where USUARIO = " & Scm(Citi.Synergia.Locals.Cache.UsuarioSSO)) '-- DescripcionesDB.TraeUsuario()))
            EjecutaSQL("")

            'Ejecutamos el SP
            meteSQL("Exec SP_TIPOS_DE_ACTIVOS")
            meteSQL(" @CODIGO_TIPO_ACTIVO = " & Scm(Me.txtTipoActivo.Text))
            meteSQL(",@MEJORA             = " & Scm(IIf(Me.chkIncluyeMejoras.Checked, "0", "1")))
            meteSQL(",@USER               = " & Scm(Citi.Synergia.Locals.Cache.UsuarioSSO))
            EjecutaSQL("")

            ''Enviamos los parametros a Crystal
            'Citi.Synergia.Reportes.Crystal.Parametros.Clear()
            'With Citi.Synergia.Reportes.Crystal.Parametros
            '    .Add(New Citi.Synergia.Reportes.Campos("_USUARIO", Scm(DescripcionesDB.TraeUsuario())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_EMPRESA", Scm(DescripcionesDB.TraeEmpresa())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_TITULO", IIf(Me.txtTituloReporte.Text.Trim.Length > 0, Scm(Me.txtTituloReporte.Text), Nothing)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_IDIOMA", Scm(Citi.Synergia.Locals.Cache.IdiomaSeleccionado)))
            'End With

            'If Citi.Synergia.Reportes.Crystal.ValidaReporte("Informacion_Tipos_de_Activos", True) = False Then
            '    Return
            'End If

            'Citi.Synergia.Reportes.Crystal.EjecutarReporte("Informacion_Tipos_de_Activos", , Citi.Synergia.Traductor.Idiomas.GetMensaje(274, "Información de Tipos de Activos"))

            Dim parametros As New List(Of String)
            With parametros
                .Add(Me.txtTituloReporte.Text.Trim)
                '.Add(DescripcionesDB.TraeUsuario())
                .Add(Citi.Synergia.Locals.Cache.UsuarioSSO)
            End With

            Citi.Synergia.Reports.Reportes.EjecutarReporte(Citi.Synergia.Reports.Reportes.ListadoReportes.Informacion_Tipos_de_Activos, parametros)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class