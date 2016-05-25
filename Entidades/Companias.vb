Public Class Companias

    Public Property Indice As Integer
    Public Property Servidor As String
    Public Property BaseDeDatos As String
    Public Property Descripcion As String
    Public Property LegalEntity As String
    Public Property Country As String
    Public Property BatchCode As String
    Public Property TransactionCodeDebit As String
    Public Property TransactionCodeCredit As String
    Public Property BranchCode As String
    Public Property BranchCodeLength As Integer
    Public Property ADEComplement As String
    Public Property ADEComplementLength As Integer

    Public Sub New()
        Indice = 0
        Servidor = String.Empty
        BaseDeDatos = String.Empty
        Descripcion = String.Empty
        LegalEntity = String.Empty
        Country = String.Empty
        BatchCode = String.Empty
        TransactionCodeDebit = String.Empty
        TransactionCodeCredit = String.Empty
        BranchCode = String.Empty
        BranchCode = 0
        ADEComplement = String.Empty
        ADEComplementLength = 0
    End Sub

    Public Sub New(ByVal indice As Integer, ByVal servidor As String, ByVal baseDeDatos As String, ByVal descripcion As String, ByVal legalEntity As String, ByVal country As String, ByVal batchCode As String, ByVal transactionCodeDebit As String, ByVal transactionCodeCredit As String, ByVal branchCode As String, ByVal branchCodeLength As Integer, ByVal adeComplement As String, ByVal adeComplementLength As Integer)
        Me.Indice = indice
        Me.Servidor = servidor
        Me.BaseDeDatos = baseDeDatos
        Me.Descripcion = descripcion
        Me.LegalEntity = legalEntity
        Me.Country = country
        Me.BatchCode = batchCode
        Me.TransactionCodeDebit = transactionCodeDebit
        Me.TransactionCodeCredit = transactionCodeCredit
        Me.BranchCode = branchCode
        Me.BranchCodeLength = branchCodeLength
        Me.ADEComplement = adeComplement
        Me.ADEComplementLength = adeComplementLength
    End Sub
End Class
