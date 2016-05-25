Imports Citi.Synergia.HelperClient

Public Class PATRER00
    Private _encuentra As Boolean

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Parametros()

        Me.BuscaPartida()

        If Not _encuentra Then
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(246, "No se encuentra la partida de trabajo relacionada."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    Sub Parametros()
        'El objetivo de esta forma es recibir los
        'Origenes de una partida e imprimirla,
        'el orden de envio (PUSH):
        '   - DOCUMENTO ORIGEN
        '   - ORIGEN 6
        '   - ORIGEN 5
        '   - ORIGEN 4
        '   - ORIGEN 3
        '   - ORIGEN 2
        '   - ORIGEN 1
        '-------------------------------------------
        varDORIGEN.Text = Pop()
        var6ORIGEN.Text = Pop()
        var5ORIGEN.Text = Pop()
        var4ORIGEN.Text = Pop()
        var3ORIGEN.Text = Pop()
        var2ORIGEN.Text = Pop()
        var1ORIGEN.Text = Pop()
    End Sub

    Sub BuscaPartida()
        _encuentra = False

        Try
            meteSQL(" Select PARTIDAS_TRABAJO_ENC.ANO_PERIODO")
            meteSQL("      , PARTIDAS_TRABAJO_ENC.NO_PERIODO")
            meteSQL("      , PARTIDAS_TRABAJO_ENC.NUMERO_PARTIDA")
            meteSQL("   From PARTIDAS_TRABAJO_ENC")
            meteSQL("  where PARTIDAS_TRABAJO_ENC.ORIGEN1 = " & Scm(var1ORIGEN.Text))
            If var2ORIGEN.Text <> "" Then
                meteSQL("    And PARTIDAS_TRABAJO_ENC.ORIGEN2 = " & Scm(var2ORIGEN.Text))
            End If
            If var3ORIGEN.Text <> "" Then
                meteSQL("    And PARTIDAS_TRABAJO_ENC.ORIGEN3 = " & Scm(var3ORIGEN.Text))
            End If
            If var4ORIGEN.Text <> "" Then
                meteSQL("    And PARTIDAS_TRABAJO_ENC.ORIGEN4 = " & Scm(var4ORIGEN.Text))
            End If
            If var5ORIGEN.Text <> "" Then
                meteSQL("    And PARTIDAS_TRABAJO_ENC.ORIGEN5 = " & Scm(var5ORIGEN.Text))
            End If
            If var6ORIGEN.Text <> "" Then
                meteSQL("    And PARTIDAS_TRABAJO_ENC.ORIGEN6 = " & Scm(var6ORIGEN.Text))
            End If
            If varDORIGEN.Text <> "" Then
                meteSQL("    And PARTIDAS_TRABAJO_ENC.DOCUMENTO_ORIGEN = " & Scm(varDORIGEN.Text))
            End If

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                txtANO_PERIODO.Text = SqlData(Sqlconn, 1).ToString
                txtNO_PERIODO.Text = SqlData(Sqlconn, 2).ToString
                txtNUMERO_PARTIDA.Text = SqlData(Sqlconn, 3).ToString
                _encuentra = True
            Loop

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Dim ORDEN As String = String.Empty

        If OP1.Checked Then
            ORDEN = "D"
        ElseIf OP2.Checked Then
            ORDEN = "I"
        Else
            ORDEN = "C"
        End If

        Try
            Dim filtro As String = String.Empty

            Dim anioPeriodo As String = String.Empty
            Dim numeroPartida As String = String.Empty
            Dim periodo As String = String.Empty
            Dim ordenamiento As String = String.Empty

            anioPeriodo = sen(txtANO_PERIODO.Text)
            numeroPartida = sen(txtNUMERO_PARTIDA.Text)
            periodo = sen(txtNO_PERIODO.Text)
            ordenamiento = IIf(OP1.Checked = True, "D", IIf(OP2.Checked = True, "I", "C"))


            'Citi.Synergia.Reportes.Crystal.Parametros.Clear()
            'With Citi.Synergia.Reportes.Crystal.Parametros
            '    .Add(New Citi.Synergia.Reportes.Campos("_ANIO", sen(txtANO_PERIODO.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_EMPRESA", Scm(DescripcionesDB.TraeEmpresa())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_NUMERO_PARTIDA", sen(txtNUMERO_PARTIDA.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_PERIODO", sen(txtNO_PERIODO.Text)))
            '    .Add(New Citi.Synergia.Reportes.Campos("_USUARIO", Scm(DescripcionesDB.TraeUsuario())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_ORDEN", Scm(IIf(OP1.Checked = True, "D", IIf(OP2.Checked = True, "I", "C")))))
            '    .Add(New Citi.Synergia.Reportes.Campos("_IDIOMA", Scm(Citi.Synergia.Locals.Cache.IdiomaSeleccionado)))
            'End With

            'If Citi.Synergia.Reportes.Crystal.ValidaReporte("Partidas_de_trabajo", True) = False Then
            '    Return
            'End If

            'filtro = "{PARTIDAS_TRABAJO_ENC.NUMERO_PARTIDA} = {@_NUMERO_PARTIDA} and "
            'filtro = filtro & "{PARTIDAS_TRABAJO_ENC.ANO_PERIODO} = {@_ANIO} and "
            'filtro = filtro & "{PARTIDAS_TRABAJO_ENC.NO_PERIODO} = {@_PERIODO}"

            'Citi.Synergia.Reportes.Crystal.EjecutarReporte("Partidas_de_trabajo", filtro, Citi.Synergia.Traductor.Idiomas.GetMensaje(323, "Reporte partidas de trabajo"))


            filtro = String.Empty
            filtro = "e.ANO_PERIODO    = " + anioPeriodo
            filtro = filtro + " And e.NO_PERIODO     = " + periodo
            filtro = filtro + " And e.NUMERO_PARTIDA = " + numeroPartida

            Select Case ordenamiento
                Case "I"
                    filtro = filtro + " ORDER BY e.ANO_PERIODO, e.NO_PERIODO, e.NUMERO_PARTIDA, d.CORRELATIVO"
                Case "C"
                    filtro = filtro + " ORDER BY e.ANO_PERIODO, e.NO_PERIODO, e.NUMERO_PARTIDA, d.CUENTA_CONTABLE"
                Case "D"
                    filtro = filtro + " ORDER BY e.ANO_PERIODO, e.NO_PERIODO, e.NUMERO_PARTIDA, d.DEBITO_CREDITO DESC, d.MONTO DESC"
            End Select

            Dim parametros As New List(Of String)
            With parametros
                .Add(anioPeriodo)
                .Add(numeroPartida)
                .Add(periodo)
                .Add(ordenamiento)
                '.Add(DescripcionesDB.TraeUsuario())
                .Add(Citi.Synergia.Locals.Cache.UsuarioSSO)
            End With

            Citi.Synergia.Reports.Reportes.EjecutarReporte(Citi.Synergia.Reports.Reportes.ListadoReportes.Partidas_de_trabajo, parametros, filtro)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class