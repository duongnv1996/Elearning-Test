Public Class ItemAnswer

    Private _idAns As Integer
    Private _contentAns As String
    Private _idQuest As Integer
    Private _isTrue As Boolean
    Public Property idAns() As Integer

        Get
            Return _idAns
        End Get
        Set(value As Integer)
            _idAns = value
        End Set
    End Property
    Public Property contentAns() As String

        Get
            Return _contentAns
        End Get
        Set(value As String)
            _contentAns = value
        End Set
    End Property
    Public Property idQuest() As Integer

        Get
            Return _idQuest
        End Get
        Set(value As Integer)
            _idQuest = value
        End Set
    End Property
    Public Property isTrue() As Boolean

        Get
            Return _isTrue
        End Get
        Set(value As Boolean)
            _isTrue = value
        End Set
    End Property

    Public Function ItemAnswer(i As Integer, c As String, q As String, t As Boolean)
        _idAns = i
        _contentAns = c
        _idQuest = q
        _isTrue = t
    End Function


End Class
