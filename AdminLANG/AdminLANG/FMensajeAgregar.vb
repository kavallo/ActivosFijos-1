Public Class FMensajeAgregar
    Public Property HubieronCambios As Boolean

    Private Sub FMensajeAgregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormatearGrid()
    End Sub

    Private Sub FormatearGrid()
        Dim idiomas As List(Of Citi.Synergia.Entidades.Idiomas) = AdminLANG.Helper.LeerIdioma()

        Dim cellStyle As New DataGridViewCellStyle
        With cellStyle
            .DataSourceNullValue = 0
            .Format = "N0"
            .NullValue = 0
        End With

        Dim columna As New DataGridViewTextBoxColumn
        With columna
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
            .MinimumWidth = 80
            .Width = 100
            .DefaultCellStyle = cellStyle
            .HeaderText = "Código"
            .Name = "ColCodigo"
            .Tag = ""
            .ReadOnly = False
        End With
        grdMensajes.Columns.Add(columna)

        cellStyle.DataSourceNullValue = ""
        cellStyle.Format = ""
        cellStyle.NullValue = ""

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
            grdMensajes.Columns.Add(colIdioma)
        Next

        With Me.grdMensajes.Columns(Me.grdMensajes.Columns.Count - 1)
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .MinimumWidth = 300
            .Width = 300
        End With

        '-- Limpio cualquier fila
        Me.grdMensajes.Rows.Clear()

        '-- Creo la fila para ingreso de datos
        Dim fila As New DataGridViewRow
        fila.CreateCells(Me.grdMensajes)

        '-- Le coloco el código sugerido
        fila.Cells(0).Value = AdminLANG.Helper.MensajeCodigoSugerido()

        '-- Lleno el resto de la fila con la info vacía
        For i As Integer = 1 To Me.grdMensajes.Columns.Count - 1
            fila.Cells(i).Value = ""
        Next

        '-- Agrego la fila al grid
        Me.grdMensajes.Rows.Add(fila)
    End Sub

    Private Sub CambiosEnGrid(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMensajes.CurrentCellDirtyStateChanged
        If grdMensajes.IsCurrentCellDirty Then
            grdMensajes.CommitEdit(DataGridViewDataErrorContexts.Commit)
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

    Private Sub Grabar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonGrabar.Click
        '-- Variables donde guardaré la información
        Dim codigoMensaje As Integer = 0
        Dim textos As New List(Of Citi.Synergia.Entidades.Mensajes)

        '-- Valido si ingresaron el código del mensaje
        If IsNothing(Me.grdMensajes.Rows(0).Cells(0).Value) Or Me.grdMensajes.Rows(0).Cells(0).Value = 0 Then
            MessageBox.Show("Ingrese un código de mensaje diferente a CERO (0).", "Aviso.", MessageBoxButtons.OK)
            Exit Sub
        End If

        '-- Nombre de la forma
        codigoMensaje = Me.grdMensajes.Rows(0).Cells(0).Value

        '-- Textos en idiomas
        For i As Integer = 1 To Me.grdMensajes.Columns.Count - 1
            If Not String.IsNullOrEmpty(Me.grdMensajes.Rows(0).Cells(i).Value.ToString) Then
                Dim texto As New Citi.Synergia.Entidades.Mensajes
                With texto
                    .Codigo = codigoMensaje
                    .Idioma = Me.grdMensajes.Columns(i).Tag.ToString
                    .Texto = Me.grdMensajes.Rows(0).Cells(i).Value.ToString
                End With
                textos.Add(texto)
            End If
        Next

        If textos.Count = 0 Then
            MessageBox.Show("Ingrese al menos un texto para el código de mensaje.", "Aviso.", MessageBoxButtons.OK)
            Exit Sub
        End If

        If AdminLANG.Helper.MensajeAgregar(textos) Then
            Me.HubieronCambios = True
            MessageBox.Show("Mensaje guardado.", "Aviso.", MessageBoxButtons.OK)
            Me.Close()
        End If
    End Sub
End Class