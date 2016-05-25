Public Class FMensajes

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LeerIdiomas()

        Me.LeerData()
    End Sub

    Private Sub LeerIdiomas()
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
            .ReadOnly = True
        End With
        grdMensajes.Columns.Add(columna)

        With cellStyle
            .DataSourceNullValue = ""
            .Format = ""
            .NullValue = ""
        End With

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
    End Sub

    Private Sub LeerData()
        grdMensajes.Rows.Clear()

        '-- Leo las formas según el combo
        Dim mensajes As List(Of Citi.Synergia.Entidades.Mensajes) = AdminLANG.Helper.LeerMensajeIdiomas()

        '-- Filtro las formas por idioma
        For Each msj In mensajes
            Dim existe As Boolean = False

            '-- Creo la fila a insertar en el Grid
            Dim filaNueva As New DataGridViewRow
            filaNueva.CreateCells(Me.grdMensajes)

            '-- Lleno la fila con la info vacía
            For i As Integer = 0 To Me.grdMensajes.Columns.Count - 1
                filaNueva.Cells(i).Value = ""
            Next

            '-- Nombre de la forma
            filaNueva.Cells(0).Value = msj.Codigo

            '-- Idioma que trae la forma
            Dim indice As Integer = 0
            For Each columna As DataGridViewColumn In Me.grdMensajes.Columns
                If columna.Tag.ToString = msj.Idioma Then
                    indice = columna.Index
                    filaNueva.Cells(indice).Value = msj.Texto
                End If
            Next

            '-- Valido si la forma a insertar ya existe en el grid
            For Each fila As DataGridViewRow In Me.grdMensajes.Rows
                If fila.Cells(0).Value.ToString = msj.Codigo Then
                    existe = True
                    '-- Le pongo el valor del idioma
                    fila.Cells(indice).Value = msj.Texto
                End If
            Next

            '-- Agrego la fila nueva al grid sólo si no existe la forma en el listado
            If existe = False Then
                Me.grdMensajes.Rows.Add(filaNueva)
            End If
        Next
    End Sub

    Private Sub CambiosEnGrid(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMensajes.CurrentCellDirtyStateChanged
        If grdMensajes.IsCurrentCellDirty Then
            grdMensajes.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub Salir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonSalir.Click
        Me.Close()
    End Sub

    Private Sub Grabar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonGrabar.Click
        '-- Variables donde iré guardando la información
        Dim mensajes As New List(Of Citi.Synergia.Entidades.Mensajes)
        Dim codigoMensaje As Integer = 0

        '-- Valido que haya información para guardar
        If Me.grdMensajes.Rows.Count = 0 Then
            MessageBox.Show("No se encontró información a guardar.", "Aviso.", MessageBoxButtons.OK)
            Exit Sub
        End If

        '-- Recorro todas las filas del grid
        For i As Integer = 0 To Me.grdMensajes.Rows.Count - 1
            If Not IsNothing(Me.grdMensajes.Rows(i).Cells(0).Value) Or Me.grdMensajes.Rows(i).Cells(0).Value <> 0 Then
                '-- Guardo el código del mensje
                codigoMensaje = Me.grdMensajes.Rows(i).Cells(0).Value
                '-- Recorro las columnas restantes para los idiomas
                For columna As Integer = 1 To Me.grdMensajes.Columns.Count - 1
                    If Not IsNothing(Me.grdMensajes.Rows(i).Cells(columna).Value) Then
                        Dim mensaje As New Citi.Synergia.Entidades.Mensajes
                        With mensaje
                            .Codigo = codigoMensaje
                            .Idioma = Me.grdMensajes.Columns(columna).Tag.ToString
                            .Texto = Me.grdMensajes.Rows(i).Cells(columna).Value.ToString
                        End With
                        mensajes.Add(mensaje)
                    End If
                Next
            End If
        Next

        If AdminLANG.Helper.MensajesEditar(mensajes) Then
            MessageBox.Show("Cambios realizados.", "Aviso.", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub Agregar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAgregar.Click
        Dim frmAgregar As New FMensajeAgregar
        With frmAgregar
            .ShowDialog(Me)
            If .HubieronCambios Then
                Me.LeerData()
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
End Class