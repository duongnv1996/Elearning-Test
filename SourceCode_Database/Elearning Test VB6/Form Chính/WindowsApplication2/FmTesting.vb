Imports System.Data.SqlClient

Public Class FmTesting
    Implements ICheckBox
    'GroupBox
    Dim w As Integer = 24       'location button 1

    Dim h As Integer = 37
    Dim sizeW As Integer = 47   'size button 1  
    Dim sizeH As Integer = 32

    Dim intWidth As Integer     ' Max Size scroll panel 2
    Dim intHeight As Integer

    Dim listBtnQuestion As New List(Of Button)

    Private heightPanel As Integer = 200
    Private subject As String = "KTHĐC"
    Private numberOfQuest As Integer = 20
    Private marginSize As Integer = 5
    Private con As New SqlConnection("Data Source=MAYTINH-JRUTQDS;Initial Catalog=db_question;Integrated Security=True;MultipleActiveResultSets=True")
    Private listQuest As New List(Of ctQuestion)
    Private _user As New User
    Private _subjectItem As New SubjectItem
    Private timer As Long
    Private isFrirstClick As Boolean = True
    Private mark As Double
    Public Property subjectItem() As SubjectItem
        Get
            Return _subjectItem
        End Get
        Set(value As SubjectItem)
            _subjectItem = value
        End Set
    End Property
    Public Property listBtn() As List(Of Button)
        Get
            Return listBtnQuestion
        End Get
        Set(value As List(Of Button))
            listBtnQuestion = value
        End Set
    End Property
    Public Property user() As User
        Get
            Return _user
        End Get
        Set(value As User)
            _user = value
        End Set
    End Property
    Public Property subjectCode() As String
        Get
            Return subject
        End Get
        Set(value As String)
            subject = value
        End Set
    End Property
    Private Function getData()
        Try
            con.Open()
            ' random 20 question when query 
            Dim queryString As String = "select TOP " & _subjectItem.numberQuest & "  * from t_question where id_subject= " & "'" & _subjectItem.id & "'" & "ORDER BY NEWID()"
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
                    quest = "Câu " & index & ": " & reader("content_quest").ToString
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

                    'Random answer by ORDER BY NEWID()
                    Dim queryAns As String = "select  * from t_answer where id_quest=@idquest"
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
        '_subjectItem.id = "KTHĐC"
        '_subjectItem.name = "Kinh tế học đại cương"
        '_subjectItem.time = 180
        '_subjectItem.numberQuest = 30
        '_subjectItem.dayTest = "20-2-2012"
        '_user.msv = "1481310014"
        '_user.name = "Nguyen van duong"
        '_user.grade = "D9CNPM"

        getData()
        Dim i As Integer = 0
        For Each Item As ctQuestion In listQuest
            Item.Size = New Size(2000, heightPanel)
            Item.Location = New Point(10, i * heightPanel + marginSize)

            Item.iCheckbox = New FmTesting
            i = i + 1
            Item.indexQuestion = i
            Dim btn As New Button
           
            btn.Location = New System.Drawing.Point(w, h)
            btn.Margin = New System.Windows.Forms.Padding(4)
            btn.Name = i
            btn.Size = New System.Drawing.Size(sizeW, sizeH)
            btn.TabIndex = 0
            btn.Text = i
            btn.UseVisualStyleBackColor = True
            AddHandler btn.Click, AddressOf All_Buttons_Click
            listBtnQuestion.Add(btn)
            Me.gbSubject.Controls.Add(btn)
            w = w + sizeW + 4
            If i Mod 5 = 0 Then
                h = h + sizeH + 4
                w = 24

            End If
            Item.btn = btn
            Me.Panel2.Controls.Add(Item)

        Next
        Me.btnNopBai.Location = New Point(89, h + 20)
        Me.gbSubject.Size = New Size(313, h + 20 + btnNopBai.Size.Height + 20)
        If IsNothing(user) <> True Then
            lbHoten.Text = _user.name
            lbClass.Text = _user.grade
            lbMsv.Text = _user.msv
        End If
        Dim timeStart As String = DateTime.Now.ToLongTimeString
        lbTimeStart.Text = timeStart

        If IsNothing(subjectItem) <> True Then
            gbSubject.Text = _subjectItem.name
        Else
            gbSubject.Text = "Câu hỏi"
        End If

        Timer1.Start()
        timer = _subjectItem.time * 60

        If (_subjectItem.time <= 60 AndAlso _subjectItem.time > 0) Then
            lbTimeEnd.Text = DateTime.Now.AddMinutes(_subjectItem.time).ToLocalTime.ToShortTimeString
        Else
            Dim hour As Integer = _subjectItem.time / 60
            Dim min As Double = _subjectItem.time Mod 60
            lbTimeEnd.Text = DateTime.Now.AddHours(hour).AddMinutes(min).ToLocalTime.ToShortTimeString
        End If


       

        For i = 1 To 19
          
        Next
       

        intHeight = Height - Panel2.Location.Y
        intWidth = Width

        'set size scroll panel
        Panel2.MaximumSize = New Size(intWidth, intHeight)

        Panel2.AutoScroll = True

        For Each btn As Button In listBtnQuestion

        Next

    End Sub
    Private Sub All_Buttons_Click(sender As Object, e As EventArgs)
        '  MsgBox(sender.Text.ToString)
        Dim pos As Integer = Integer.Parse(sender.Text.ToString)
        ' scroll to question location
        Panel2.AutoScrollPosition = New Point(0, pos * heightPanel - heightPanel)
    End Sub
    Private Sub finishTest()

        If (isFrirstClick) Then
            isFrirstClick = False
            mark = getMark()
            Try
                con.Open()
                Dim sql As New SqlCommand("insert into t_mark (msv,id_subject,mark) values ('" & _user.msv & "','" & _subjectItem.id & "', @mark )", con)
                sql.Parameters.AddWithValue("@mark", mark)
                sql.ExecuteNonQuery()
                con.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try
        End If
        Timer1.Stop()
        If MessageBox.Show("Bạn được " & mark & " điểm. Thoát chương trình?", "Báo điểm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

            For Each btn As Button In listBtnQuestion
                RemoveHandler btn.Click, AddressOf All_Buttons_Click
            Next
            Me.Close()
        End If


    End Sub



    Private Sub btnNopBai_Click(sender As Object, e As EventArgs) Handles btnNopBai.Click
        finishTest()

    End Sub


    Private Function getMark() As Double
        Dim mark As Double = 0
        For Each itemCtQuest As ctQuestion In listQuest
            Dim isTrueSelected As Boolean = False
          
            'A
            If (itemCtQuest.rbA.Visible = True AndAlso itemCtQuest.rbA.Checked = True) Then
                If (itemCtQuest.QuestionItem().ans(0).isTrue = True) Then
                    mark = mark + 0.5
                    isTrueSelected = True

                End If
            Else
                If (itemCtQuest.rbA.Visible = True AndAlso itemCtQuest.QuestionItem().ans(0).isTrue = True) Then
                    itemCtQuest.rbA.ForeColor = Color.Red
                End If

            End If
            'B
            If (itemCtQuest.rbB.Checked = True) Then
                If (itemCtQuest.rbB.Visible = True AndAlso itemCtQuest.QuestionItem().ans(1).isTrue = True) Then
                    mark = mark + 0.5
                    isTrueSelected = True
                
                End If
            Else
                If (itemCtQuest.rbB.Visible = True AndAlso itemCtQuest.QuestionItem().ans(1).isTrue = True) Then
                    itemCtQuest.rbB.ForeColor = Color.Red
                End If
            End If
            'C
            If (itemCtQuest.rbC.Visible = True AndAlso itemCtQuest.rbC.Checked = True) Then
                If (itemCtQuest.QuestionItem().ans(2).isTrue = True) Then
                    mark = mark + 0.5
                    isTrueSelected = True
               
                End If
            Else
                If (itemCtQuest.rbC.Visible = True AndAlso itemCtQuest.QuestionItem().ans(2).isTrue = True) Then
                    itemCtQuest.rbC.ForeColor = Color.Red
                End If
            End If
            'D
            If (itemCtQuest.rbD.Visible = True AndAlso itemCtQuest.rbD.Checked = True) Then
                If (itemCtQuest.QuestionItem().ans(3).isTrue = True) Then
                    mark = mark + 0.5
                    isTrueSelected = True
               
                End If
            Else
                If (itemCtQuest.rbD.Visible = True AndAlso itemCtQuest.QuestionItem().ans(3).isTrue = True) Then
                    itemCtQuest.rbD.ForeColor = Color.Red
                End If
            End If

            If isTrueSelected <> True Then
                setBackgroundButton(itemCtQuest.btn, Color.Red)
            End If
            itemCtQuest.rbA.AutoCheck = False
            itemCtQuest.rbB.AutoCheck = False
            itemCtQuest.rbC.AutoCheck = False
            itemCtQuest.rbD.AutoCheck = False
        Next

        Return mark
    End Function

    'Private Sub VScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar2.Scroll
    '    Me.Panel2.Top = -Me.VScrollBar2.Value()
    '    Me.VScrollBar2.Maximum = Me.Panel2.Size.Height - Me.Panel1.Size.Height
    '    Me.gbSubject.Location = New System.Drawing.Point(22, 0)
    'End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (timer > 0) Then
            timer = timer - 1

            '  lbTimeEnd.Text = timer & "sec"
        Else

            finishTest()

            ' MsgBox("Time up")

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Public Sub check(ByVal btn As Button) Implements ICheckBox.check




        setBackgroundButton(btn, Color.AliceBlue)
    End Sub

    Private Sub setBackgroundButton(ByVal btn As Button, ByVal color As Color)

        btn.BackColor = color
        btn.FlatAppearance.BorderColor = System.Drawing.Color.Blue

        btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    End Sub

   
End Class