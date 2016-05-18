Public Class Item
    Private _quest As ItemQuest
    Private _ans() As ItemAnswer
    Public Property quest() As ItemQuest
        Get
            Return _quest
        End Get
        Set(value As ItemQuest)
        End Set
    End Property
    Public Property ans() As ItemAnswer()

        Get
            Return _ans
        End Get
        Set(value As ItemAnswer())
            _ans = value
        End Set
    End Property
End Class
