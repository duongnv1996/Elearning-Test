


Public Class SubjectItem

    Private _id_subject As String
    Private _name As String


    Public Property id() As String
        Get
            Return _id_subject
        End Get
        Set(value As String)
            _id_subject = value
        End Set
    End Property

    Public Property name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property




End Class

