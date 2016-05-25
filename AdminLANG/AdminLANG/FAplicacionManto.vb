Public Class FAplicacionManto
    Public Property Aplicacion As String
    Public Property NombreForma As String

    Private _idiomas As List(Of Citi.Synergia.Entidades.Idiomas)
    Private _formas As List(Of Citi.Synergia.Entidades.Formas)


    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & ":  '" & Me.Aplicacion & "'"

        If Me.NombreForma <> "" Then
            Me.BotonAgregar.Visible = False
            Me.ToolStripSeparator2.Visible = Me.BotonAgregar.Visible
        End If

        Me.LeerIdiomas()

        Me.LlenarCombo()
    End Sub

    Private Sub LeerIdiomas()
        Me._idiomas = AdminLANG.Helper.LeerIdioma()

        Dim colForma As New DataGridViewTextBoxColumn
        With colForma
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
            .Width = 75
            .MinimumWidth = 90
            .HeaderText = "Forma"
            .Name = "ColForma"
            .Tag = ""
            .ReadOnly = True
        End With
        grdFormas.Columns.Add(colForma)

        Dim cellStyle As New DataGridViewCellStyle
        cellStyle.DataSourceNullValue = ""
        cellStyle.Format = ""
        cellStyle.NullValue = ""

        For Each idioma As Citi.Synergia.Entidades.Idiomas In Me._idiomas
            Dim colIdioma As New DataGridViewTextBoxColumn
            With colIdioma
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
                .Width = 300
                .MinimumWidth = 250
                .DefaultCellStyle = cellStyle
                .HeaderText = idioma.Descripcion + " (" + idioma.Codigo + ")"
                .Name = idioma.Codigo
                .Tag = idioma.Codigo
                .ReadOnly = False
            End With
            grdFormas.Columns.Add(colIdioma)
        Next

        cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Dim colControles As New DataGridViewLinkColumn
        With colControles
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .MinimumWidth = 70
            .Width = 70
            .ActiveLinkColor = Color.Red
            .LinkColor = Color.Blue
            .VisitedLinkColor = Color.Purple
            .DefaultCellStyle = cellStyle
            .HeaderText = "Controles"
            .Name = "ColControles"
            .Tag = ""
            .ReadOnly = True
        End With
        grdFormas.Columns.Add(colControles)
    End Sub

    Private Sub LlenarCombo()
        Me._formas = AdminLANG.Helper.LeerFormas(Me.Aplicacion, Me.NombreForma)

        If Me._formas.Count > 0 Then
            Dim formas As New List(Of Citi.Synergia.Entidades.Formas)

            Dim item As Citi.Synergia.Entidades.Formas

            If Me.NombreForma.Trim.Length = 0 Then
                If Me._formas.Item(0).Forma = "" Then
                    Exit Sub
                End If
                item = New Citi.Synergia.Entidades.Formas(Me.Aplicacion, "Todas", 0, "", "")
                formas.Add(item)
            End If

            For i As Integer = 0 To Me._formas.Count - 1
                item = New Citi.Synergia.Entidades.Formas(Me._formas.Item(i).Aplicacion, Me._formas.Item(i).Forma, 0, "", "")
                formas.Add(item)
            Next

            With Me.cboForma
                .DataSource = formas
                .DisplayMember = "Forma"
                .ValueMember = "Forma"
            End With
        End If
    End Sub

    Private Sub LeerData()
        grdFormas.Rows.Clear()

        Dim formaSeleccionada As String = ""
        If cboForma.SelectedItem.Forma.ToString <> "Todas" Then
            formaSeleccionada = cboForma.SelectedItem.Forma.ToString
        End If

        '-- Leo las formas según el combo
        Dim formas As List(Of Citi.Synergia.Entidades.Formas) = AdminLANG.Helper.LeerFormasIdiomas(Aplicacion, formaSeleccionada)

        '-- Filtro las formas por idioma
        For Each frm In formas
            Dim existe As Boolean = False

            '-- Creo la fila a insertar en el Grid
            Dim filaNueva As New DataGridViewRow
            filaNueva.CreateCells(Me.grdFormas)

            '-- Lleno la fila con la info vacía
            For i As Integer = 0 To Me.grdFormas.Columns.Count - 1
                filaNueva.Cells(i).Value = ""
            Next

            '-- Nombre de la forma
            filaNueva.Cells(0).Value = frm.Forma

            '-- Idioma que trae la forma
            Dim indice As Integer = 0
            For Each columna As DataGridViewColumn In Me.grdFormas.Columns
                If columna.Tag.ToString = frm.Idioma Then
                    indice = columna.Index
                    filaNueva.Cells(indice).Value = frm.Titulo
                End If
            Next

            '-- Le agrego en la última columna el valor link para los controles
            filaNueva.Cells(Me.grdFormas.Columns.Count - 1).Value = "Sel."

            '-- Valido si la forma a insertar ya existe en el grid
            For Each fila As DataGridViewRow In Me.grdFormas.Rows
                If fila.Cells(0).Value.ToString = frm.Forma Then
                    existe = True
                    '-- Le pongo el valor del idioma
                    fila.Cells(indice).Value = frm.Titulo
                End If
            Next

            '-- Agrego la fila nueva al grid sólo si no existe la forma en el listado
            If existe = False Then
                Me.grdFormas.Rows.Add(filaNueva)
            End If
        Next
    End Sub

    Private Sub CambiosEnGrid(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdFormas.CurrentCellDirtyStateChanged
        If grdFormas.IsCurrentCellDirty Then
            grdFormas.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub CambioSeleccion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboForma.SelectedIndexChanged
        Me.LeerData()
    End Sub

    Private Sub Salir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonSalir.Click
        Me.Close()
    End Sub

    Private Sub Grabar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonGrabar.Click
        '-- Variables donde iré guardando la información
        Dim formas As New List(Of Citi.Synergia.Entidades.Formas)
        Dim nombreForma As String = String.Empty

        '-- Valido que haya información para guardar
        If Me.grdFormas.Rows.Count = 0 Then
            MessageBox.Show("No se encontró información a guardar.", "Aviso.", MessageBoxButtons.OK)
            Exit Sub
        End If

        '-- Recorro todas las filas del grid
        For i As Integer = 0 To Me.grdFormas.Rows.Count - 1
            If Not String.IsNullOrEmpty(Me.grdFormas.Rows(i).Cells(0).Value.ToString) Then
                '-- Guardo el nombre de la forma
                nombreForma = Me.grdFormas.Rows(i).Cells(0).Value.ToString
                '-- Recorro las columnas restantes menos la última para los idiomas
                For columna As Integer = 1 To Me.grdFormas.Columns.Count - 2
                    If Not IsNothing(Me.grdFormas.Rows(i).Cells(columna).Value) Then
                        Dim forma As New Citi.Synergia.Entidades.Formas
                        With forma
                            .Forma = nombreForma
                            .Idioma = Me.grdFormas.Columns(columna).Tag.ToString
                            .Titulo = Me.grdFormas.Rows(i).Cells(columna).Value.ToString
                        End With
                        formas.Add(forma)
                    End If
                Next
            End If
        Next

        If AdminLANG.Helper.FormasEditar(Me.Aplicacion, formas) Then
            MessageBox.Show("Cambios realizados.", "Aviso.", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub Agregar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAgregar.Click
        Dim frmAgregar As New FFormaAgregar
        With frmAgregar
            .Aplicacion = Me.Aplicacion
            .ShowDialog(Me)
            If .HubieronCambios Then
                Me.LlenarCombo()
            End If
            .Dispose()
        End With
    End Sub

    Private Sub Forma_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                Me.Close()
        End Select
    End Sub

    Private Sub ClickEnGrid(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdFormas.CellContentClick
        If e.RowIndex >= 0 Then
            Select Case e.ColumnIndex
                Case Me.grdFormas.Columns.Count - 1 '-- Controles
                    Dim frmControles As New FControlesManto
                    With frmControles
                        .Aplicacion = Me.Aplicacion
                        .Forma = Me.grdFormas.Rows(e.RowIndex).Cells(0).Value.ToString
                        .ShowDialog(Me)
                    End With
            End Select
        End If
    End Sub
End Class