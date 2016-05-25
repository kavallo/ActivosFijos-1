Public Class FControlesManto
    Public Property Aplicacion As String
    Public Property Forma As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & ":  '" & Me.Forma & "'"

        Me.LeerIdiomas()

        Me.LeerData()
    End Sub

    Private Sub LeerIdiomas()
        Dim idiomas As List(Of Citi.Synergia.Entidades.Idiomas) = AdminLANG.Helper.LeerIdioma()

        Dim cellStyle As New DataGridViewCellStyle
        With cellStyle
            .DataSourceNullValue = ""
            .Format = ""
            .NullValue = ""
        End With

        Dim columna As New DataGridViewTextBoxColumn
        With columna
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
            .MinimumWidth = 80
            .Width = 100
            .DefaultCellStyle = cellStyle
            .HeaderText = "Control"
            .Name = "ColControl"
            .Tag = ""
            .ReadOnly = True
        End With
        grdControles.Columns.Add(columna)

        For Each idioma As Citi.Synergia.Entidades.Idiomas In idiomas
            Dim colIdioma As New DataGridViewTextBoxColumn
            '-- Columna para 'Texto'
            With colIdioma
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
                .MinimumWidth = 150
                .Width = 200
                .DefaultCellStyle = cellStyle
                .HeaderText = "Texto  (" & idioma.Descripcion + " - " + idioma.Codigo + ")"
                .Name = "Texto_" & idioma.Codigo
                .Tag = "Texto_" & idioma.Codigo
                .ReadOnly = False
            End With
            grdControles.Columns.Add(colIdioma)

            '-- Columna para 'ToolTipText'
            colIdioma = New DataGridViewTextBoxColumn
            With colIdioma
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
                .MinimumWidth = 150
                .Width = 200
                .DefaultCellStyle = cellStyle
                .HeaderText = "ToolTipText  (" & idioma.Descripcion + " - " + idioma.Codigo + ")"
                .Name = "ToolTipText_" & idioma.Codigo
                .Tag = "ToolTipText_" & idioma.Codigo
                .ReadOnly = False
            End With
            grdControles.Columns.Add(colIdioma)
        Next

        With Me.grdControles.Columns(Me.grdControles.Columns.Count - 1)
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .MinimumWidth = 200
            .Width = 200
        End With
    End Sub

    Private Sub LeerData()
        grdControles.Rows.Clear()

        '-- Leo los controles según las propiedades enviadas
        Dim controles As List(Of Citi.Synergia.Entidades.ControlDetalle) = AdminLANG.Helper.LeerControlesIdiomas(Me.Aplicacion, Me.Forma)

        '-- Filtro las formas por idioma
        For Each con In controles
            Dim existe As Boolean = False

            '-- Creo la fila a insertar en el Grid
            Dim filaNueva As New DataGridViewRow
            filaNueva.CreateCells(Me.grdControles)

            '-- Lleno la fila con la info vacía
            For i As Integer = 0 To Me.grdControles.Columns.Count - 1
                filaNueva.Cells(i).Value = ""
            Next

            '-- Nombre del control
            filaNueva.Cells(0).Value = con.Nombre

            '-- Idioma que trae el control
            Dim indiceTexto As Integer = 0
            Dim indiceToolTip As Integer = 0
            For Each columna As DataGridViewColumn In Me.grdControles.Columns
                Select Case columna.Tag.ToString
                    Case "Texto_" & con.Idioma
                        indiceTexto = columna.Index
                        filaNueva.Cells(indiceTexto).Value = con.Texto

                    Case "ToolTipText_" & con.Idioma
                        indiceToolTip = columna.Index
                        filaNueva.Cells(indiceToolTip).Value = con.ToolTipText
                End Select
            Next

            '-- Valido si el control a insertar en el grid ya existe en el grid
            For Each fila As DataGridViewRow In Me.grdControles.Rows
                If fila.Cells(0).Value.ToString = con.Nombre Then
                    existe = True
                    '-- Le pongo el valor del Texto en idioma
                    fila.Cells(indiceTexto).Value = con.Texto
                    '-- Le pongo el valor del ToolTip en idioma
                    fila.Cells(indiceToolTip).Value = con.ToolTipText
                End If
            Next

            '-- Agrego la fila nueva al grid sólo si no existe la forma en el listado
            If existe = False Then
                Me.grdControles.Rows.Add(filaNueva)
            End If
        Next
    End Sub

    Private Sub Salir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonSalir.Click
        Me.Close()
    End Sub

    Private Sub Forma_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                Me.Close()
        End Select
    End Sub

    Private Sub Grabar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonGrabar.Click
        '-- Variables donde iré guardando la información
        Dim controles As New List(Of Citi.Synergia.Entidades.ControlDetalle)
        Dim nombreControl As String = String.Empty

        '-- Valido que haya información para guardar
        If Me.grdControles.Rows.Count = 0 Then
            MessageBox.Show("No se encontró información a guardar.", "Aviso.", MessageBoxButtons.OK)
            Exit Sub
        End If

        '-- Recorro todas las filas del grid
        For i As Integer = 0 To Me.grdControles.Rows.Count - 1
            If Not String.IsNullOrEmpty(Me.grdControles.Rows(i).Cells(0).Value.ToString) Then
                '-- Guardo el nombre del control
                nombreControl = Me.grdControles.Rows(i).Cells(0).Value.ToString
                '-- Recorro las columnas restantes para los idiomas de 2 en 2
                For columna As Integer = 1 To Me.grdControles.Columns.Count - 1 Step 2
                    If Not IsNothing(Me.grdControles.Rows(i).Cells(columna).Value) Then
                        Dim control As New Citi.Synergia.Entidades.ControlDetalle
                        Dim idiomaControl As String = String.Empty
                        idiomaControl = Me.grdControles.Columns(columna).Tag.ToString.Replace("Texto_", "")
                        With control
                            .Aplicacion = Me.Aplicacion
                            .Forma = Me.Forma
                            .Nombre = nombreControl
                            .Idioma = idiomaControl
                            '-- Texto
                            .Texto = Me.grdControles.Rows(i).Cells(columna).Value.ToString
                            '-- ToolTipText
                            .ToolTipText = Me.grdControles.Rows(i).Cells(columna + 1).Value.ToString
                        End With
                        controles.Add(control)
                    End If
                Next
            End If
        Next

        If AdminLANG.Helper.ControlEditar(Me.Aplicacion, Me.Forma, controles) Then
            MessageBox.Show("Cambios realizados.", "Aviso.", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub Agregar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAgregar.Click
        Dim frmAgregar As New FControlAgregar
        With frmAgregar
            .Aplicacion = Me.Aplicacion
            .Forma = Me.Forma
            .ShowDialog(Me)
            If .HubieronCambios Then
                Me.LeerData()
            End If
            .Dispose()
        End With
    End Sub

    Private Sub CambiosEnGrid(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdControles.CurrentCellDirtyStateChanged
        If Me.grdControles.IsCurrentCellDirty Then
            Me.grdControles.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
End Class