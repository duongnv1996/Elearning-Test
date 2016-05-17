Public Class ItemQuest
    Private _idQuest As Integer
    Private _contentQuest As String
    Private _idSubject As String
    Public Property contentQuest() As String
        Get

            Return _contentQuest
        End Get
        Set(ByVal Value As String)
            _contentQuest = Value

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
    Public Property idSubject() As String
        Get
            Return _idSubject
        End Get
        Set(value As String)
            _idSubject = value
        End Set
    End Property


    Public Function ItemQuest(i As Integer, c As String, s As String)
        _idQuest = i
        _contentQuest = c
        _idSubject = s

    End Function
End Class
