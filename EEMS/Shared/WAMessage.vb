Public Class WAMessage

    Private Id_ As String
    Public Property Id() As String
        Get
            Return Id_
        End Get
        Set(ByVal value As String)
            Id_ = value
        End Set
    End Property

    Private Username_ As String
    Public Property Username() As String
        Get
            Return Username_
        End Get
        Set(ByVal value As String)
            Username_ = value
        End Set
    End Property

    Private Mobile_ As String
    Public Property Mobile() As String
        Get
            Return Mobile_
        End Get
        Set(ByVal value As String)
            Mobile_ = value
        End Set
    End Property

    Private Message_ As String
    Public Property Message() As String
        Get
            Return Message_
        End Get
        Set(ByVal value As String)
            Message_ = value
        End Set
    End Property

    Sub New(Id As String, Username As String, Mobile As String, Message As String)
        Id_ = Id
        Username_ = Username
        Mobile_ = Mobile
        Message_ = Message
    End Sub
End Class
