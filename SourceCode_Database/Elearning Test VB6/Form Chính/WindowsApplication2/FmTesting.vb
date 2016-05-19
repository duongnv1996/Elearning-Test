Imports System.Data.SqlClient

Public Class FmTesting
    Private heightPanel As Integer = 200
    Private subject As String = "MMT"
    Private numberOfQuest As Integer = 20
    Private marginSize As Integer = 5
    Private con As New SqlConnection("Data Source=MAYTINH-JRUTQDS;Initial Catalog=db_question;Integrated Security=True;MultipleActiveResultSets=True")
    Private listQuest As New List(Of ctQuestion)

    Private Function getData()
        Try
            con.Open()
            ' random 20 question when query 
            Dim queryString As String = "select TOP 20 * from t_question where id_subject='MMT'  ORDER BY NEWID()"
            Dim sqlSelect As New SqlCommand(queryString, con)
            '  sqlSelect.Parameters.AddWithValue("@idSubject", "MMT")
            Dim reader As SqlDataReader = sqlSelect.ExecuteReader()

            ' Read 20 questions from reader
            Dim index As Integer = 1
            Dim listItemQ As New List(Of ItemQuest)
            If (reader.HasRows()) Then
                While (reader.Read())
                    Dim itemQ As New ItemQuest


                    Dim id As Integer = Integer.Parse(reader("id_quest").ToString)
                    Dim quest As String = ""
                    quest = "Cau " & index & " " & reader("content_quest").ToString
                    If (StrComp("", quest, CompareMethod.Text) <> 0 And id <> -1) Then
                        itemQ.contentQuest() = quest
                        itemQ.idQuest() = id
                        itemQ.idSubject() = subject




                    End If
                  
                    index = index + 1
                    listItemQ.Add(itemQ)

                End While
            Else
                MsgBox("Chua co du lieu cau hoi cho mon hoc nay", "Thong bao")


            End If


            For Each q As ItemQuest In listItemQ
                Dim ctQuestItem As New ctQuestion
                ctQuestItem.QuestionItem().quest = q

                'Not random yet
                Dim queryAns As String = "select  * from t_answer where id_quest=@idquest  "
                Dim sqlAns As New SqlCommand(queryAns, con)
                sqlAns.Parameters.AddWithValue("@idquest", q.idQuest)
                Dim readerAns As SqlDataReader = sqlAns.ExecuteReader()

                If (readerAns.HasRows()) Then
                    While (readerAns.Read())
                        Dim itemA As New ItemAnswer
                        Dim idAns As Integer
                        Dim contentAns As String
                        Dim isTrue As Boolean
                        Dim idQuest As Integer
                        '  Dim s As String = readerAns("true_ans").ToString
                        idAns = Integer.Parse(readerAns("id_ans").ToString())
                        contentAns = readerAns("content_ans").ToString
                        contentAns = Replace(contentAns, "*", "")

                        If (StrComp(readerAns("true_ans").ToString, "1", CompareMethod.Text) = 0) Then
                            isTrue = True
                        Else
                            isTrue = False

                        End If


                        idQuest = Integer.Parse(readerAns("id_quest").ToString)

                        itemA.contentAns() = contentAns
                        itemA.idQuest() = idQuest
                        itemA.isTrue() = isTrue
                        itemA.idAns() = idAns
                        ctQuestItem.QuestionItem().ans().Add(itemA)

                    End While
                    listQuest.Add(ctQuestItem)

                End If
            Next

            con.Close()
        Catch ex As Exception
            MsgBox("Khong the ket noi db . Vi " & ex.Message)
        End Try






    End Function

    Private Function getItem(quest As Item) As ctQuestion
        Dim panelItem As New Panel
        'Dim content_quest As New Label
        'content_quest.Size = New Size(1000, 20)
        panelItem.Size = New Size(1000, heightPanel)
        'content_quest.Location = New Point(10, 10)
        'content_quest.Text = quest.contentQuest & "000"
        'panelItem.Controls.Add(content_quest)

        'Dim rbA As New RadioButton
        'rbA.Size = New Size(1000, 20)
        'rbA.Location = New Point(20, 40 + marginSize)
        'rbA.Text = quest.contentQuest & "111"
        'panelItem.Controls.Add(rbA)
        ''content_quest1.Location = New Point(100, 60 + marginSize)
        ''panelItem.Controls.Add(content_quest1)
        ''content_quest1.Location = New Point(100, 80 + marginSize)
        ''panelItem.Controls.Add(content_quest1)


        'Dim rbB As New RadioButton
        'rbB.Size = New Size(1000, 20)
        'rbB.Location = New Point(20, 60 + marginSize)
        'rbB.Text = quest.contentQuest & "222"
        'panelItem.Controls.Add(rbB)

        'Dim rbC As New RadioButton
        'rbC.Size = New Size(1000, 20)
        'rbC.Location = New Point(20, 80 + marginSize)
        'rbC.Text = quest.contentQuest & "333"
        'panelItem.Controls.Add(rbC)

        'Dim rbD As New RadioButton
        'rbD.Size = New Size(1000, 20)
        'rbD.Location = New Point(20, 100 + marginSize)
        'rbD.Text = quest.contentQuest & "444"
        'panelItem.Controls.Add(rbD)


        Dim panel As New ctQuestion
        panel.QuestionItem() = quest

        panel.Size = New Size(1000, heightPanel)
        Return panel



    End Function
    Private Sub FmTesting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Size = New Size(Width, heightPanel * numberOfQuest)
        getData()
        Dim i As Integer = 0
        For Each Item As ctQuestion In listQuest
            Item.Size = New Size(1000, heightPanel)
            Item.Location = New Point(10, i * heightPanel + marginSize * i)
            Me.Panel2.Controls.Add(Item)
            i = i + 1

        Next

        'For i As Integer = 0 To numberOfQuest
        '    Dim item As New Item
        '    item.quest().contentQuest() = "aaa"
        '    Dim ans0 As New ItemAnswer
        '    ans0.idAns = 1
        '    ans0.contentAns() = "1"
        '    ans0.isTrue = True
        '    ans0.idQuest = 1
        '    Dim ans1 As New ItemAnswer
        '    ans1.idAns = 1
        '    ans1.contentAns() = "1"
        '    ans1.isTrue = True
        '    ans1.idQuest = 1
        '    Dim ans2 As New ItemAnswer
        '    ans2.idAns = 1
        '    ans2.contentAns() = "1"
        '    ans2.isTrue = True
        '    ans2.idQuest = 1
        '    Dim ans3 As New ItemAnswer
        '    ans3.idAns = 1
        '    ans3.contentAns() = "1"
        '    ans3.isTrue = True
        '    ans3.idQuest = 1
        '    item.ans().Add(ans0)
        '    item.ans().Add(ans1)
        '    item.ans().Add(ans2)
        '    item.ans().Add(ans3)
        '    'Dim ans As New ItemAnswer
        '    'ans.idAns = 1
        '    'ans.contentAns() = "1"
        '    'ans.isTrue = True
        '    'ans.idQuest = "a"

        '    ' Dim quest As New ItemQuest
        '    ' quest.contentQuest = i & "  amsoid asdsad asd asd as sad as  sadsada samsoid asdsad asd asd as sad as  sadsada samsoid asdsad asd asd as sad as  sadsada samsoid asdsad asd asd as sad as  sadsada s"
        '    '  Dim panelItem = getItem(item)
        '    Dim itemQuest As New ctQuestion
        '    itemQuest.QuestionItem() = item
        '    itemQuest.Size = New Size(1000, heightPanel)
        '    listQuest.Add(itemQuest)
        '    itemQuest.Location = New Point(10, i * heightPanel + marginSize * i)
        '    Me.Panel2.Controls.Add(itemQuest)
        'Next i
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)
        'Me.Panel2.Top = -Me.VScrollBar1.Value()
        'Me.VScrollBar1.Maximum = Me.Panel2.Size.Height - Me.Panel1.Size.Height
    End Sub


    Private Sub btnNopBai_Click(sender As Object, e As EventArgs) Handles btnNopBai.Click
        '  MsgBox(Panel2.Controls.Item(1).Text)


    End Sub
End Class