


Public Class SubjectItem

    Private _id_subject As String
    Private _name As String
    Private _number_quest As Integer
    Private _time As Integer
    Private _date_test As String

    Public Property number_quest() As Integer
        Get
            Return _number_quest
        End Get
        Set(value As Integer)
            _number_quest = value
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
    Public Property date_test() As String
        Get
            Return _date_test
        End Get
        Set(value As String)
            _date_test = value
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

