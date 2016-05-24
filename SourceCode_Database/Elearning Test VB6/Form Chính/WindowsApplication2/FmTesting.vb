Imports System.Data.SqlClient

Public Class FmTesting
    Private heightPanel As Integer = 200
    Private subject As String
    Private numberOfQuest As Integer = 20
    Private marginSize As Integer = 5
    Private con As New SqlConnection("Data Source=MAYTINH-JRUTQDS;Initial Catalog=db_question;Integrated Security=True;MultipleActiveResultSets=True")
    Private listQuest As New List(Of ctQuestion)
    Public Property subjectCode() As String
        Get
            Return Subject
        End Get
        Set(value As String)
            subject = value
        End Set
    End Property
    Private Function getData()
        Try
            con.Open()
            ' random 20 question when query 
            Dim queryString As String = "select TOP 20 * from t_question where id_subject= " & "'" & subject & "'" & "ORDER BY NEWID()"
            Dim sqlSelect As New SqlCommand(queryString, con)
            '  sqlSelect.Parameters.AddWithValue("@idSubject", "MMT")
            Dim reader As SqlDataReader = sqlSelect.ExecuteReader()

            ' Read 20 questions from reader
            Dim index As Integer = 1
            Dim listItemQ As New List(Of ItemQuest)
            If (reader.HasRows()) Then
                While (reader.Read())
                    Dim itemQ As New ItemQuest

                    Dim idSubject As String = reader("id_subject").ToString
                    Dim id As Integer = Integer.Parse(reader("id_quest").ToString)
                    Dim quest As String = ""
                    quest = "Cau " & index & " " & reader("content_quest").ToString
                    If (StrComp("", quest, CompareMethod.Text) <> 0 And id <> -1) Then
                        itemQ.contentQuest() = quest
                        itemQ.idQuest() = id
                        itemQ.idSubject() = idSubject




                    End If
                  
                    index = index + 1
                    listItemQ.Add(itemQ)

                End While


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
            Else
                MsgBox("Chua co du lieu cau hoi cho mon hoc nay")
            End If



            con.Close()
        Catch ex As Exception
            MsgBox("Khong the ket noi db . Vi " & ex.Message)
        End Try






    End Function

    
    Private Sub FmTesting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Size = New Size(Width, heightPanel * numberOfQuest + 100)
        getData()
        Dim i As Integer = 0
        For Each Item As ctQuestion In listQuest
            Item.Size = New Size(1000, heightPanel)
            Item.Location = New Point(10, i * heightPanel + marginSize * i)
            Me.Panel2.Controls.Add(Item)
            i = i + 1

        Next

      
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)
        'Me.Panel2.Top = -Me.VScrollBar1.Value()
        'Me.VScrollBar1.Maximum = Me.Panel2.Size.Height - Me.Panel1.Size.Height
    End Sub


    Private Sub btnNopBai_Click(sender As Object, e As EventArgs) Handles btnNopBai.Click
        MsgBox("Mark = " & getMark())
        

    End Sub


    Private Function getMark() As Double
        Dim mark As Double = 0
        For Each itemCtQuest As ctQuestion In listQuest
            If (itemCtQuest.rbA.Checked = True) Then
                If (itemCtQuest.QuestionItem().ans(0).isTrue = True) Then
                    mark = mark + 0.5
                End If
            End If

            If (itemCtQuest.rbB.Checked = True) Then
                If (itemCtQuest.QuestionItem().ans(1).isTrue = True) Then
                    mark = mark + 0.5
                End If
            End If
            If (itemCtQuest.rbC.Checked = True And itemCtQuest.rbC.Visible = True) Then
                If (itemCtQuest.QuestionItem().ans(2).isTrue = True) Then
                    mark = mark + 0.5
                End If
            End If
            If (itemCtQuest.rbD.Checked = True And itemCtQuest.rbD.Visible = True) Then
                If (itemCtQuest.QuestionItem().ans(3).isTrue = True) Then
                    mark = mark + 0.5
                End If
            End If


        Next

        Return mark
    End Function
End Class