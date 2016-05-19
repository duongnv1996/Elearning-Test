Public Class Item
    Private _quest As New ItemQuest
    Private _ans As New List(Of ItemAnswer)
    Public Property quest() As ItemQuest
        Get
            Return _quest
        End Get
        Set(value As ItemQuest)
            _quest = value
        End Set
    End Property
    Public Property ans() As List(Of ItemAnswer)
        Get
            Return _ans
        End Get
        Set(value As List(Of ItemAnswer))
            _ans = value
        End Set
    End Property
End Class
