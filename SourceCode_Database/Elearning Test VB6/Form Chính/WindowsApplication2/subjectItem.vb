


Public Class SubjectItem

    Private _id_subject As String
    Private _name As String

    Private _dayTest As String
    Private _numberQuest As Integer
    Private _time As Integer
    Public Property numberQuest() As Integer
        Get
            Return _numberQuest
        End Get
        Set(value As Integer)
            _numberQuest = value
        End Set
    End Property
    Public Property time() As Integer
        Get
            Return _time
        End Get
        Set(value As Integer)
            _time = value
        End Set
    End Property

    Public Property dayTest() As String
        Get
            Return _dayTest
        End Get
        Set(value As String)
            _dayTest = value
        End Set
    End Property
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

