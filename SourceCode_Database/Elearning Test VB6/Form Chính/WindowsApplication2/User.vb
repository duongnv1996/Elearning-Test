Public Class User
    Private _msv As String
    Private _name As String
    Private _class As String
    Private _mark As Double

    Public Property msv() As String
        Get
            Return _msv
        End Get
        Set(value As String)
            _msv = value
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


    Public Property grade() As String
        Get
            Return _class
        End Get
        Set(value As String)
            _class = value
        End Set
    End Property

    Public Property mark() As String
        Get
            Return _mark
        End Get
        Set(value As String)
            _mark = value
        End Set
    End Property


End Class