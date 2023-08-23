Public Class APIInvoice
    Private PartitionKey_ As String
    Public Property PartitionKey() As String
        Get
            Return PartitionKey_
        End Get
        Set(ByVal value As String)
            PartitionKey_ = value
        End Set
    End Property

    Private RowKey_ As String
    Public Property RowKey() As String
        Get
            Return RowKey_
        End Get
        Set(ByVal value As String)
            RowKey_ = value
        End Set
    End Property

    Private Data_ As New Dictionary(Of String, String)
    Public Property Data() As Dictionary(Of String, String)
        Get
            Return Data_
        End Get
        Set(ByVal value As Dictionary(Of String, String))
            Data_ = value
        End Set
    End Property
End Class
