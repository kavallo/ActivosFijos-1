Imports Citi.Synergia.HelperClient

Public Class ACTMVAN8
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()

        Me.LlenarCombo()
    End Sub

    Private Sub LlenarCombo()
        Dim estatus As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With estatus
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("U", Citi.Synergia.Traductor.Idiomas.GetMensaje(102, "U - Actualizado")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("P", Citi.Synergia.Traductor.Idiomas.GetMensaje(103, "P - Pendiente")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(104, "D - Desechado")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("V", Citi.Synergia.Traductor.Idiomas.GetMensaje(105, "V - Vendidos")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(106, "N - Donado")))
        End With
        With cboEstatus
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = estatus
        End With
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim fechaDepreciacion As String

        If MyBase.ValidarCampos(Me) = False Then
            Return
        End If

        fechaDepreciacion = Me.txtFecha.TextMMDDYYYY()

        Try
            'Borramos data anterior
            meteSQL("Delete PARAMETROS_REPORTE")
            meteSQL(" Where usuario = " & Scm(Citi.Synergia.Locals.Cache.UsuarioSSO))  '-- DescripcionesDB.TraeUsuario()))
            EjecutaSQL("")

            meteSQL("Insert into PARAMETROS_REPORTE (USUARIO, PARAMETRO3)")
            'meteSQL(" Select " & Scm(DescripcionesDB.TraeUsuario()) & ", '" & fechaDepreciacion & " 11:59PM '")
            meteSQL(" Select " & Scm(Citi.Synergia.Locals.Cache.UsuarioSSO) & ", '" & fechaDepreciacion & " 11:59PM '")
            EjecutaSQL("")

            'Ejecutamos el SP para actualizar la data del reporte
            meteSQL("Exec SP_ACTIVOS_DEPRECIADOS")
            meteSQL(" @Usuario = " & Scm(Citi.Synergia.Locals.Cache.UsuarioSSO))
            EjecutaSQL("")

            'Citi.Synergia.Reportes.Crystal.Parametros.Clear()
            'With Citi.Synergia.Reportes.Crystal.Parametros
            '    .Add(New Citi.Synergia.Reportes.Campos("_USUARIO", Scm(DescripcionesDB.TraeUsuario())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_EMPRESA", Scm(DescripcionesDB.TraeEmpresa())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_FECHA_DEPRE", Scm(fechaDepreciacion)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_ESTADO", Scm(Me.cboEstatus.SelectedValue.ToString())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_IDIOMA", Scm(Citi.Synergia.Locals.Cache.IdiomaSeleccionado)))
            'End With

            'If Citi.Synergia.Reportes.Crystal.ValidaReporte("Activos_depreciados", True) = False Then
            '    Return
            'End If

            ''Dim filtro As String = String.Empty
            ''filtro = "{SP_ACTIVOS_DEPRECIADOS;1.ESTATUS} = {@_ESTADO}"

            'Citi.Synergia.Reportes.Crystal.EjecutarReporte("Activos_depreciados", "", Citi.Synergia.Traductor.Idiomas.GetMensaje(275, "Activos depreciados"))

            Dim parametros As New List(Of String)
            With parametros
                .Add(Me.cboEstatus.SelectedValue.ToString)
                .Add(fechaDepreciacion)
                '.Add(DescripcionesDB.TraeUsuario())
                .Add(Citi.Synergia.Locals.Cache.UsuarioSSO)
            End With

            Citi.Synergia.Reports.Reportes.EjecutarReporte(Citi.Synergia.Reports.Reportes.ListadoReportes.Activos_depreciados, parametros)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class