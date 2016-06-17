Imports System.IO

Public Class ctQuestion
    Private _list As List(Of Button)

    Public Property List() As List(Of Button)

        Get
            Return _list
        End Get
        Set(value As List(Of Button))
            _list = value
        End Set
    End Property
    Private _btn As Button
    Public Property btn() As Button
        Get
            Return _btn
        End Get
        Set(value As Button)
            _btn = value
        End Set
    End Property
    Private _radTrue As RadioButton
    Public Property radTrue() As RadioButton
        Get
            Return _radTrue
        End Get
        Set(value As RadioButton)
            _radTrue = value
        End Set
    End Property
    Private _item As New Item
    Public Property QuestionItem() As Item

        Get
            Return _item
        End Get
        Set(value As Item)
            _item = value
        End Set
    End Property
    Private _index As Integer
    Public Property indexQuestion() As Integer

        Get
            Return _index
        End Get
        Set(value As Integer)
            _index = value
        End Set
    End Property
    Private _iCheckBox As ICheckBox
    Public Property iCheckbox() As ICheckBox

        Get
            Return _iCheckBox
        End Get
        Set(value As ICheckBox)
            _iCheckBox = value
        End Set
    End Property
    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbQuest.Width = Me.Width
        lbQuest.Height = Me.Height
        'Dim contentQ As String = _item.quest().contentQuest()
        'For i = 0 To contentQ.Length
        '    If (i Mod 200 = 0) Then
        '        contentQ = contentQ.Substring(0, i) + Environment.NewLine + contentQ.Substring(i)

        '    End If


        'Next
        lbQuest.Text = _item.quest().contentQuest()
        Dim sizeOfAns As Integer = _item.ans.Count()
        ' Dim isFail As Boolean = True
        Select Case sizeOfAns
            Case 1
                rbA.Text = _item.ans.Item(0).contentAns()
                rbB.Visible = False
                rbC.Visible = False
                rbD.Visible = False
                'If (_item.ans.Item(0).isTrue()) Then
                '    isFail = False
                'End If

            Case 2
                rbA.Text = _item.ans.Item(0).contentAns()
                rbB.Text = _item.ans.Item(1).contentAns()
                rbC.Visible = False
                rbD.Visible = False
                'If (_item.ans.Item(0).isTrue()) Then
                '    isFail = False
                'End If
                'If (_item.ans.Item(1).isTrue()) Then
                '    isFail = False
                'End If
            Case 3
                rbA.Text = _item.ans.Item(0).contentAns()
                rbB.Text = _item.ans.Item(1).contentAns()
                rbC.Text = _item.ans.Item(2).contentAns()
                rbD.Visible = False

                'If (_item.ans.Item(0).isTrue()) Then
                '    isFail = False
                'End If
                'If (_item.ans.Item(1).isTrue()) Then
                '    isFail = False
                'End If
                'If (_item.ans.Item(2).isTrue()) Then
                '    isFail = False
                'End If

            Case 4
                rbA.Text = _item.ans.Item(0).contentAns()
                rbB.Text = _item.ans.Item(1).contentAns()
                rbC.Text = _item.ans.Item(2).contentAns()
                rbD.Text = _item.ans.Item(3).contentAns()

                'If (_item.ans.Item(0).isTrue()) Then
                '    isFail = False
                'End If
                'If (_item.ans.Item(1).isTrue()) Then
                '    isFail = False
                'End If
                'If (_item.ans.Item(2).isTrue()) Then
                '    isFail = False
                'End If
                'If (_item.ans.Item(3).isTrue()) Then
                '    isFail = False
                'End If
        End Select
        rbA.Checked = False

        'rbA.Text = _item.ans.Item(0).contentAns()
        'rbB.Text = _item.ans.Item(1).contentAns()
        'rbC.Text = _item.ans.Item(2).contentAns()
        'rbD.Text = _item.ans.Item(3).contentAns()
        'If (isFail) Then
        '    ' MsgBox("ID question false is " & _item.quest().idQuest().ToString)
        '    writeToFile("log.txt", _item.quest().idSubject().ToString & " ID question false is " & _item.quest().idQuest().ToString & "-" & _item.quest().contentQuest().ToString)
        'End If

    End Sub


    Private Function writeToFile(ByVal name As String, ByVal msg As String) As Boolean
        Dim writeStream As StreamWriter = New StreamWriter(name, True)
        Try
            writeStream.WriteLine(msg)

        Catch ex As Exception
            Return False
        Finally
            writeStream.Close()
        End Try


        Return True


    End Function

    Private Sub lbQuest_Click(sender As Object, e As EventArgs) Handles lbQuest.Click

    End Sub

    Private Sub rbA_CheckedChanged(sender As Object, e As EventArgs) Handles rbA.CheckedChanged
        _iCheckBox.check(_btn)

    End Sub

    Private Sub rbB_CheckedChanged(sender As Object, e As EventArgs) Handles rbB.CheckedChanged
        _iCheckBox.check(_btn)
    End Sub

    Private Sub rbC_CheckedChanged(sender As Object, e As EventArgs) Handles rbC.CheckedChanged
        _iCheckBox.check(_btn)
    End Sub

    Private Sub rbD_CheckedChanged(sender As Object, e As EventArgs) Handles rbD.CheckedChanged
        _iCheckBox.check(_btn)
    End Sub
End Class
