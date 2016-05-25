Public Class Opgraf
    Private currGT As Short
    Private currGS As Short
    Private GS As String
    Dim cbovis As Short
    Private loaded As Integer

    Private G_PIE2D As Short = 1
    Private G_PIE3D As Short = 2
    Private G_BAR2D As Short = 3
    Private G_BAR3D As Short = 4
    Private G_GANTT As Short = 5
    Private G_LINE As Short = 6
    Private G_LOGLIN As Short = 7
    Private G_AREA As Short = 8
    Private G_SCATTER As Short = 9
    Private G_POLAR As Short = 10
    Private G_HLC As Short = 11

    'Draw Mode
    Private G_NO_ACTION As Short = 0
    Private G_CLEAR As Short = 1
    Private G_DRAW As Short = 2
    Private G_BLIT As Short = 3
    Private G_COPY As Short = 4
    Private G_PRINT As Short = 5
    Private G_WRITE As Short = 6

    Private G_DEFAULT As Short = 0
    Private G_HORIZONTAL As Short = 1
    Private G_STACKED As Short = 2
    Private G_PERCENTAGE As Short = 4
    Private G_Z_CLUSTERED As Short = 6
    Private G_ABSOLUTE As Short = 1
    Private G_NO_CLOSE As Short = 1
    Private G_NO_HIGH_LOW As Short = 2

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'currGT = LeerParamInt("GraphType")
        If currGT = 0 Then currGT = 3
        'GS = LeerParamStr("GraphStyles")
        If GS = "" Then GS = "0"
        GS.Replace(" ", "0")
        Me.LlenarCombos()
        PintarEtiq()
        'chkDrawStyle.CheckState = LeerParamInt("DrawStyle")
        loaded = 1
        RefrescarGráfico()

    End Sub

    Private Sub LlenarCombos()
        Dim combo As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With combo
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion(G_PIE2D.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(147, "Pastel 2D")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion(G_PIE3D.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(148, "Pastel 3D")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion(G_BAR2D.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(149, "Barras 2D")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion(G_BAR3D.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(150, "Barras 3D")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion(G_LINE.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(133, "Líneas")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion(G_AREA.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(151, "Áreas")))
        End With
        With cboGT
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = combo
        End With
        Me.cboGT.SelectedValue = Me.currGT
    End Sub

    Private Sub PintarEtiq()
        lblGraphType.Text = currGT.ToString
        lblGraphStyle.Text = currGS.ToString
    End Sub

    Private Sub RefrescarGráfico()
        Ctl2CurrGS()
        'Tipo de gráfica a mostrar
        'graDemo.GraphType = CurrGT
        'Estilo de gráfica a mostrar
        'graDemo.GraphStyle = CurrGS
        'Forma de dibujar la gráfica
        'graDemo.DrawStyle = chkDrawStyle.CheckState
        If loaded = 1 Then
            Me.graDemo.Refresh()
            'Forma de dibujar
            'graDemo.DrawMode = G_DRAW
        End If
    End Sub

    Private Sub Ctl2CurrGS()
        'Pone los controles en CurrGS, y éste en GS
        If Not Me.Visible Then Exit Sub
        If cbovis Then
            currGS = CType(Me.cboGS.SelectedValue, Short)
            'Else
            '    CurrGS = CShort(-chkGS(0).CheckState) * CShort(chkGS(0).Visible)
            '    CurrGS = CurrGS - CShort(chkGS(1).CheckState) * CShort(chkGS(1).Visible) * 2
            '    CurrGS = CurrGS - CShort(chkGS(2).CheckState) * CShort(chkGS(2).Visible) * 4
        End If
        Mid(GS, currGT * 2 + 1, 2) = String.Format("{0:0}", currGS)
        PintarEtiq()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub chkGS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _chkGS_0.CheckedChanged, _chkGS_1.CheckedChanged, _chkGS_2.CheckedChanged
        Me.RefrescarGráfico()
    End Sub

    Private Sub chkDrawStyle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDrawStyle.CheckedChanged
        Me.RefrescarGráfico()
    End Sub

    Private Sub cboGT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGT.SelectedIndexChanged
        loaded = loaded + 1
        LlenaropcGS()
        loaded = loaded - 1
        RefrescarGráfico()
    End Sub

    Private Sub LlenaropcGS()
        _chkGS_0.Visible = False
        _chkGS_1.Visible = False
        _chkGS_2.Visible = False
        cbovis = False
        cboGS.Items.Clear()
        currGT = CType(cboGT.SelectedValue, Short)
        Select Case CurrGT
            Case G_PIE2D, G_PIE3D
                _chkGS_0.Text = "&Sin líneas"
                _chkGS_1.Text = "&Colorear etiquetas"
                _chkGS_2.Text = "&Porcentaje"
                _chkGS_0.Visible = True
                _chkGS_1.Visible = True
                _chkGS_2.Visible = True
            Case G_BAR2D, G_BAR3D
                Dim combo As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
                With combo
                    .Add(New Citi.Synergia.Entidades.CodigoDescripcion(G_DEFAULT.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(152, "Default")))
                    .Add(New Citi.Synergia.Entidades.CodigoDescripcion(G_HORIZONTAL.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(153, "Horizontal")))
                    .Add(New Citi.Synergia.Entidades.CodigoDescripcion(G_STACKED.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(154, "Apilado")))
                    .Add(New Citi.Synergia.Entidades.CodigoDescripcion((G_STACKED + G_HORIZONTAL).ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(155, "Apilado horizontal")))
                    .Add(New Citi.Synergia.Entidades.CodigoDescripcion(G_PERCENTAGE.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(156, "Apilado %")))
                    .Add(New Citi.Synergia.Entidades.CodigoDescripcion((G_PERCENTAGE + G_HORIZONTAL).ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(157, "Apilado horizontal %")))
                    If currGT = G_BAR3D Then
                        .Add(New Citi.Synergia.Entidades.CodigoDescripcion(G_Z_CLUSTERED, Citi.Synergia.Traductor.Idiomas.GetMensaje(158, "Agrupado en Z")))
                        .Add(New Citi.Synergia.Entidades.CodigoDescripcion((G_Z_CLUSTERED + G_HORIZONTAL).ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(159, "Agrupado en Z horizontal")))
                    End If
                End With
                With cboGS
                    .ValueMember = "Codigo"
                    .DisplayMember = "Descripcion"
                    .DataSource = combo
                End With
                cbovis = True

            Case G_GANTT
                _chkGS_0.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(160, "Barras espaciadas")
                _chkGS_0.Visible = True

            Case G_LINE, G_LOGLIN, G_POLAR
                _chkGS_0.Text = "&" & Citi.Synergia.Traductor.Idiomas.GetMensaje(161, "Símbolos")
                _chkGS_1.Text = "&" & Citi.Synergia.Traductor.Idiomas.GetMensaje(162, "Palos")
                _chkGS_2.Text = "&" & Citi.Synergia.Traductor.Idiomas.GetMensaje(133, "Líneas")
                _chkGS_0.Visible = True
                _chkGS_1.Visible = True
                _chkGS_2.Visible = True

            Case G_AREA
                Dim combo As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
                With combo
                    .Add(New Citi.Synergia.Entidades.CodigoDescripcion(G_DEFAULT.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(152, "Default")))
                    .Add(New Citi.Synergia.Entidades.CodigoDescripcion(G_ABSOLUTE.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(163, "Absoluto")))
                    .Add(New Citi.Synergia.Entidades.CodigoDescripcion(G_PERCENTAGE.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(164, "Porcentaje")))
                End With
                With cboGS
                    .ValueMember = "Codigo"
                    .DisplayMember = "Descripcion"
                    .DataSource = combo
                End With
                cbovis = True

            Case G_HLC
                Dim combo As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
                With combo
                    .Add(New Citi.Synergia.Entidades.CodigoDescripcion(G_DEFAULT.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(152, "Default")))
                    .Add(New Citi.Synergia.Entidades.CodigoDescripcion(G_NO_CLOSE.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(165, "Sin promedio")))
                    .Add(New Citi.Synergia.Entidades.CodigoDescripcion(G_NO_HIGH_LOW.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(166, "Sim máximo/mínimo")))
                    .Add(New Citi.Synergia.Entidades.CodigoDescripcion((G_NO_CLOSE + G_NO_HIGH_LOW).ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(167, "Sin líneas")))
                End With
                With cboGS
                    .ValueMember = "Codigo"
                    .DisplayMember = "Descripcion"
                    .DataSource = combo
                End With
                cbovis = True
        End Select
        cboGS.Visible = cbovis
        CurrGS2Ctl()
    End Sub

    Private Sub CurrGS2Ctl()
        'Pone el GraphStyle de GS en CurrGS
        currGS = Val(Mid(GS, currGT * 2 + 1, 2))
        If cbovis Then
            Me.cboGS.SelectedValue = currGS
        Else
            _chkGS_0.CheckState = -CShort((currGS And 1) <> 0)
            _chkGS_1.CheckState = -CShort((currGS And 2) <> 0)
            _chkGS_2.CheckState = -CShort((currGS And 4) <> 0)
        End If
        PintarEtiq()
    End Sub

    Private Sub Forma_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Ctl2CurrGS()
        'AjustarParam("GraphType", VB6.Format(currGT))
        'AjustarParam("GraphStyles", GS.Value)
        'AjustarParam("DrawStyle", CStr(chkDrawStyle.CheckState))
    End Sub
End Class