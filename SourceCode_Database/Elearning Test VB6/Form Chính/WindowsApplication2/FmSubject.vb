﻿Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class FmSubject
    Implements IClickSubject
    
    Const DEFAULT_NUMBER_QUEST As Integer = 20
    Const DEFAULT_TIME As Integer = 20
    Dim w As Integer = 100      ' location panel subject
    Dim h As Integer = 15
    Dim sizeW As Integer = 400   'size panel subject
    Dim sizeH As Integer = 125

    Private conn As New SqlConnection("Data Source=MAYTINH-JRUTQDS;Initial Catalog=db_question;Integrated Security=True;MultipleActiveResultSets=True")
    Private _user As New User

    Public Property user() As User
        Get
            Return _user
        End Get
        Set(value As User)
            _user = value
        End Set
    End Property
    Private _subjectClicked As SubjectItem
    Private _subject As New SubjectItem

    Public Property Subject() As SubjectItem
        Get
            Return _subject
        End Get
        Set(value As SubjectItem)
            _subject = value
        End Set
    End Property
    Private listSubject As New List(Of SubjectItem)
    Private listPanelSubject As New List(Of PanelSubject)

    Private Sub FmSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsNothing(user) <> True Then
            ten.Text = _user.name
            lp.Text = _user.grade
            msv.Text = _user.msv
        End If
        Dim intHeight As Integer = Height - panelRoot.Location.Y
        Dim intWidth As Integer = Width
        btnTest.Enabled = False
        'set size scroll panel
        panelRoot.MaximumSize = New Size(intWidth, intHeight)

        panelRoot.AutoScroll = True
        getData()

    End Sub





    Private Sub getData()
        Try
            conn.Open()
            Dim sql As New SqlCommand("Select * from t_subject", conn)
            Dim reader As SqlDataReader = sql.ExecuteReader()
            If (reader.HasRows()) Then
                Dim i As Integer = 1
                While (reader.Read)
                    Dim id As String
                    Dim content As String
                    Dim dayTest As String
                    Dim numberQuest As Integer
                    Dim time As Integer
                    Dim str As String
                    id = reader("id_subject").ToString
                    content = reader("content_subject").ToString
                    str = reader("date_test").ToString
                    If str.Equals("") = False Then
                        Dim date1 As DateTime = reader("date_test").ToString
                        dayTest = date1.ToString("dd-MM-yyyy hh:mm")
                    End If
                    
                    str = reader("number_quest").ToString
                    If (str.Equals("") = False) Then
                        numberQuest = Integer.Parse(str)
                    Else
                        numberQuest = DEFAULT_NUMBER_QUEST
                    End If
                    str = reader("timer").ToString
                    If (str.Equals("") = False) Then
                        time = Integer.Parse(str)
                    Else
                        time = DEFAULT_TIME
                    End If

                    Dim subject As New PanelSubject
                    subject.Subject.id = id
                    subject.Subject.name = content
                    subject.Subject.dayTest = dayTest
                    subject.Subject.time = time
                    subject.Subject.numberQuest = numberQuest
                    subject.Location = New System.Drawing.Point(w, h)
                    subject.Margin = New System.Windows.Forms.Padding(4)
                    subject.Name = i
                    subject.Size = New System.Drawing.Size(sizeW, sizeH)
                    w = w + sizeW + 4
                    If i Mod 2 = 0 Then
                        h = h + sizeH + 4
                        w = 100
                    End If
                    subject.IClick = Me
                    Me.panelRoot.Controls.Add(subject)
                    i = i + 1

                End While

            End If


            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Public Sub clickSubject(ByVal subject As SubjectItem) Implements IClickSubject.ClickSubject
        lbDate.Text = "Ngày kiểm tra : " & subject.dayTest.Substring(0, 10)
        lbTime.Text = "Thời gian : " & subject.time & " phút "
        lbNumberQuest.Text = "Số lượng câu hỏi : " & subject.numberQuest & " câu "
        gbSubject.Text = subject.name
        _subjectClicked = subject
        btnTest.Enabled = True
    End Sub

    Private Sub panelRoot_Paint(sender As Object, e As PaintEventArgs) Handles panelRoot.Paint

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Try
            conn.Open()
            Dim sql As New SqlCommand("Select * from t_question where id_subject = '" & _subjectClicked.id & " '", conn)
            Dim reader As SqlDataReader = sql.ExecuteReader()

           
            If reader.HasRows AndAlso DateDiff(DateInterval.Day, Date.Now, Date.Parse(_subjectClicked.dayTest)) = 0 Then
                reader.Close()

                Dim sqlExist As New SqlCommand("Select msv from t_mark where id_subject = '" & _subjectClicked.id & " ' and msv =' " & _user.msv & " '", conn)
                Dim readerExist As SqlDataReader = sqlExist.ExecuteReader()
                If readerExist.HasRows = True Then
                    MessageBox.Show("Bạn đã tham gia thi môn học này. Vui lòng chọn môn học khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    Dim test As New FmTesting
                    test.subjectItem = _subjectClicked
                    test.user = _user
                    test.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Môn học này hiện tại chưa tổ chức thi. Vui lòng chọn môn học khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

                conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

   
End Class

'' sae show n ra ho a, nchung cơ ban la v.
' vay cc. 
' bỏ shift ra
' thôi để đấy a làm cho
' lam báo cáo đi
'ow, á
'Public Class Ketnoi1
'    Private conn = "Data Source=MAYTINH-JRUTQDS;Initial Catalog=db_question;Integrated Security=True"
'    Public Function ktketnoi(ByVal ten As String, ByVal lop As String) As Boolean  '//t?o ra class k?t n?i v?i giá tr? tr? v? là ki?u true, false
'        Try
'            Dim sql = "select * from us where name='" & ten & "'  and class= '" & lop & "' "
'            Dim sqlcon As New SqlConnection(conn)
'            Dim adapter As New SqlDataAdapter(sql, sqlcon)
'            Dim dt As New DataTable '//T?o bi?t dt d?ng d? li?u là m?t table
'            adapter.Fill(dt) '//Đua giá tr? t? k?t n?i vào bi?n dt
'            If dt.Rows.Count > 0 Then '//>0 có nghia là có giá tr? trong dt
'                Return True
'            Else
'                Return False
'            End If
'        Catch ex As Exception
'            Return False
'        End Try
'    End Function
'End Class

