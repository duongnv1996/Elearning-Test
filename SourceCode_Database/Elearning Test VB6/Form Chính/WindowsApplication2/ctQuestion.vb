Public Class ctQuestion
    Private _item As New Item
    Public Property QuestionItem() As Item

        Get
            Return _item
        End Get
        Set(value As Item)
            _item = value
        End Set
    End Property

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbQuest.Width = Me.Width
        lbQuest.Height = Me.Height

        lbQuest.Text = _item.quest().contentQuest()
        Dim sizeOfAns As Integer = _item.ans.Count()
        Dim isFail As Boolean = true
        Select Case sizeOfAns
            Case 1
                rbA.Text = _item.ans.Item(0).contentAns()
                rbB.Visible = False
                rbC.Visible = False
                rbD.Visible = False
                If (_item.ans.Item(0).isTrue()) Then
                    isFail = False
                End If

            Case 2
                rbA.Text = _item.ans.Item(0).contentAns()
                rbB.Text = _item.ans.Item(1).contentAns()
                rbC.Visible = False
                rbD.Visible = False
                If (_item.ans.Item(0).isTrue()) Then
                    isFail = False
                End If
                If (_item.ans.Item(1).isTrue()) Then
                    isFail = False
                End If
            Case 3
                rbA.Text = _item.ans.Item(0).contentAns()
                rbB.Text = _item.ans.Item(1).contentAns()
                rbC.Text = _item.ans.Item(2).contentAns()
                rbD.Visible = False

                If (_item.ans.Item(0).isTrue()) Then
                    isFail = False
                End If
                If (_item.ans.Item(1).isTrue()) Then
                    isFail = False
                End If
                If (_item.ans.Item(2).isTrue()) Then
                    isFail = False
                End If
              
            Case 4
                rbA.Text = _item.ans.Item(0).contentAns()
                rbB.Text = _item.ans.Item(1).contentAns()
                rbC.Text = _item.ans.Item(2).contentAns()
                rbD.Text = _item.ans.Item(3).contentAns()

                If (_item.ans.Item(0).isTrue()) Then
                    isFail = False
                End If
                If (_item.ans.Item(1).isTrue()) Then
                    isFail = False
                End If
                If (_item.ans.Item(2).isTrue()) Then
                    isFail = False
                End If
                If (_item.ans.Item(3).isTrue()) Then
                    isFail = False
                End If
        End Select
        'rbA.Text = _item.ans.Item(0).contentAns()
        'rbB.Text = _item.ans.Item(1).contentAns()
        'rbC.Text = _item.ans.Item(2).contentAns()
        'rbD.Text = _item.ans.Item(3).contentAns()
        'If (isFail) Then
        '    MsgBox("ID question false is " & _item.quest().idQuest())
        'End If

    End Sub
End Class
