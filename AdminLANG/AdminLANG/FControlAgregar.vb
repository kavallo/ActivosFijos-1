Public Class FControlAgregar
    Public Property Aplicacion As String
    Public Property Forma As String
    Public Property HubieronCambios As Boolean

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & ":  '" & Me.Forma & "'"

        Me.FormatearGrid()
    End Sub

    Private Sub FormatearGrid()
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
            .ReadOnly = False
        End With
        grdControl.Columns.Add(columna)

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
            grdControl.Columns.Add(colIdioma)

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
            grdControl.Columns.Add(colIdioma)
        Next

        With Me.grdControl.Columns(Me.grdControl.Columns.Count - 1)
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .MinimumWidth = 200
            .Width = 200
        End With

        '-- Limpio cualquier fila
        Me.grdControl.Rows.Clear()

        '-- Creo la fila para el ingreso de datos
        Dim fila As New DataGridViewRow
        fila.CreateCells(Me.grdControl)

        '-- Lleno la fila con info vacía
        For i As Integer = 0 To Me.grdControl.Columns.Count - 1
            fila.Cells(i).Value = ""
        Next

        '-- Agrego la fila al grid
        Me.grdControl.Rows.Add(fila)
    End Sub

    Private Sub CambiosEnGrid(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdControl.CurrentCellDirtyStateChanged
        If grdControl.IsCurrentCellDirty Then
            grdControl.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub Forma_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                Me.Close()
        End Select
    End Sub

    Private Sub Salir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonSalir.Click
        Me.Close()
    End Sub

    Private Sub Grabar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonGrabar.Click
        '-- Variables donde iré guardando la información
        Dim controles As New List(Of Citi.Synergia.Entidades.ControlDetalle)
        Dim nombreControl As String = String.Empty

        '-- Valido si ingresaron nombre del control
        If String.IsNullOrEmpty(Me.grdControl.Rows(0).Cells(0).Value.ToString) Then
            MessageBox.Show("Ingrese nombre del control.", "Aviso.", MessageBoxButtons.OK)
            Exit Sub
        End If

        '-- Nombre del control
        nombreControl = Me.grdControl.Rows(0).Cells(0).Value.ToString

        '-- Recorro las columnas restantes para los idiomas de 2 en 2
        For columna As Integer = 1 To Me.grdControl.Columns.Count - 1 Step 2
            'If Not String.IsNullOrEmpty(Me.grdControl.Rows(0).Cells(columna).Value.ToString) Then
            Dim control As New Citi.Synergia.Entidades.ControlDetalle
            Dim idiomaControl As String = String.Empty
            idiomaControl = Me.grdControl.Columns(columna).Tag.ToString.Replace("Texto_", "")
            With control
                .Aplicacion = Me.Aplicacion
                .Forma = Me.Forma
                .Nombre = nombreControl
                .Idioma = idiomaControl
                '-- Texto
                .Texto = Me.grdControl.Rows(0).Cells(columna).Value.ToString
                '-- ToolTipText
                .ToolTipText = Me.grdControl.Rows(0).Cells(columna + 1).Value.ToString
            End With
            controles.Add(control)
            'End If
        Next

        If controles.Count = 0 Then
            MessageBox.Show("Ingrese al menos un texto para el control.", "Aviso.", MessageBoxButtons.OK)
            Exit Sub
        End If

        If AdminLANG.Helper.ControlAgregar(Me.Aplicacion, Me.Forma, controles) Then
            Me.HubieronCambios = True
            MessageBox.Show("Control guardado.", "Aviso.", MessageBoxButtons.OK)
            Me.Close()
        End If
    End Sub
End Class