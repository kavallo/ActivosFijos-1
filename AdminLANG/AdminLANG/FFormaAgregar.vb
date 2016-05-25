Public Class FFormaAgregar
    Public Property Aplicacion As String
    Public Property HubieronCambios As Boolean

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & ":  '" & Me.Aplicacion & "'"

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
            .HeaderText = "Forma"
            .Name = "ColForma"
            .Tag = ""
            .ReadOnly = False
        End With
        grdFormas.Columns.Add(columna)

        For Each idioma As Citi.Synergia.Entidades.Idiomas In idiomas
            Dim colIdioma As New DataGridViewTextBoxColumn
            With colIdioma
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
                .MinimumWidth = 250
                .Width = 300
                .DefaultCellStyle = cellStyle
                .HeaderText = idioma.Descripcion + " (" + idioma.Codigo + ")"
                .Name = idioma.Codigo
                .Tag = idioma.Codigo
                .ReadOnly = False
            End With
            grdFormas.Columns.Add(colIdioma)
        Next

        With Me.grdFormas.Columns(Me.grdFormas.Columns.Count - 1)
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .MinimumWidth = 300
            .Width = 300
        End With

        '-- Limpio cualquier fila
        Me.grdFormas.Rows.Clear()

        '-- Creo la fila para ingreso de datos
        Dim fila As New DataGridViewRow
        fila.CreateCells(Me.grdFormas)

        '-- Lleno la fila con la info vacía
        For i As Integer = 0 To Me.grdFormas.Columns.Count - 1
            fila.Cells(i).Value = ""
        Next

        '-- Agrego la fila al grid
        Me.grdFormas.Rows.Add(fila)
    End Sub

    Private Sub CambiosEnGrid(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdFormas.CurrentCellDirtyStateChanged
        If grdFormas.IsCurrentCellDirty Then
            grdFormas.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub Grabar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonGrabar.Click
        '-- Variables donde guardaré la información
        Dim forma As String = String.Empty
        Dim titulos As New List(Of Citi.Synergia.Entidades.Formas)

        '-- Valido si ingresaron nombre de la forma
        If String.IsNullOrEmpty(Me.grdFormas.Rows(0).Cells(0).Value.ToString) Then
            MessageBox.Show("Ingrese nombre de la forma", "Aviso.", MessageBoxButtons.OK)
            Exit Sub
        End If

        '-- Nombre de la forma
        forma = Me.grdFormas.Rows(0).Cells(0).Value.ToString

        '-- Titulos de idiomas
        For i As Integer = 1 To Me.grdFormas.Columns.Count - 1
            'If Not String.IsNullOrEmpty(Me.grdFormas.Rows(0).Cells(i).Value.ToString) Then
            Dim titulo As New Citi.Synergia.Entidades.Formas
            With titulo
                .Aplicacion = Me.Aplicacion
                .Forma = forma
                .Idioma = Me.grdFormas.Columns(i).Tag.ToString
                .Titulo = Me.grdFormas.Rows(0).Cells(i).Value.ToString
            End With

            titulos.Add(titulo)
            'End If
        Next

        If titulos.Count = 0 Then
            MessageBox.Show("Ingrese al menos un título para la forma.", "Aviso.", MessageBoxButtons.OK)
            Exit Sub
        End If

        If AdminLANG.Helper.FormaAgregar(Me.Aplicacion, forma, titulos) Then
            Me.HubieronCambios = True
            MessageBox.Show("Forma guardada.", "Aviso.", MessageBoxButtons.OK)
            Me.Close()
        End If
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
End Class