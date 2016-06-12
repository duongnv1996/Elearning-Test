Imports System.Data.SqlClient
Imports System.Timers.Timer
Public Class FmSubject
    Private _user As New User
    Private _data As New FmSubject
    Public Property user() As User
        Get
            Return _user
        End Get
        Set(value As User)
            _user = value
        End Set
    End Property

    Private Sub FmSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsNothing(user) <> True Then
            ten.Text = _user.name
            lp.Text = _user.grade
            msv.Text = _user.msv
        End If
        Dim phut As Byte
        Dim giay As Byte
        phut = 20 : giay = 0
        'Timer.Enabled = True
        Dim fmtest As New FmTesting
        fmtest.Timer_Tick() = _data
        FmTesting.Show()
        Me.Hide()

    End Sub


    Private Sub cmdKTHDC_Click(sender As Object, e As EventArgs) Handles cmdKTHDC.Click
        Dim test As New FmTesting
        test.subjectCode = "KTHĐC"
        test.Show()
        Me.Hide()

    End Sub

    Private Sub cmdMMT_Click(sender As Object, e As EventArgs) Handles cmdMMT.Click
        Dim test As New FmTesting
        test.subjectCode = "MMT"
        test.Show()
        Me.Hide()
    End Sub


    Private Sub cmdKTMT_Click(sender As Object, e As EventArgs) Handles cmdKTMT.Click
        Dim test As New FmTesting
        test.subjectCode = "KTMT"
        test.Show()
        Me.Hide()
    End Sub

    Private Sub cmdQTDN_Click(sender As Object, e As EventArgs) Handles cmdQTDN.Click
        Dim test As New FmTesting
        test.subjectCode = "QTDN"
        test.Show()
        Me.Hide()
    End Sub

    Private Sub lp_Click(sender As Object, e As EventArgs) Handles lp.Click
        lp.Text = _user.grade
    End Sub

    Private Sub msv_Click(sender As Object, e As EventArgs) Handles msv.Click
        msv.Text = _user.msv
    End Sub

    Private Sub ten_Click(sender As Object, e As EventArgs) Handles ten.Click
        ten.Text = user.name
    End Sub

    Private Function giay() As Integer
        Throw New NotImplementedException
    End Function

    Private Function phut() As Integer
        Throw New NotImplementedException
    End Function

    Private Function t() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Timer_Tick()
        Throw New NotImplementedException
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim phut As Byte
        Dim giay As Byte
        If giay > 0 Then
            giay = giay - 1
        Else 'nếu thành phần giây = 0
            giay = 59
        End If

        If phut > 0 Then
            phut = phut - 1
        End If
    End Sub
End Class

'' sae show n ra ho a, nchung cơ ban la v.
' vay cc. 
' bỏ shift ra
' thôi để đấy a làm cho
' lam báo cáo đi
'ow, á
Public Class Ketnoi1
    Private conn = "Data Source=;Initial Catalog=db_question;Integrated Security=True"
    Public Function ktketnoi(ByVal ten As String, ByVal lop As String) As Boolean  '//t?o ra class k?t n?i v?i giá tr? tr? v? là ki?u true, false
        Try
            Dim sql = "select * from us where name='" & ten & "'  and class= '" & lop & "' "
            Dim sqlcon As New SqlConnection(conn)
            Dim adapter As New SqlDataAdapter(sql, sqlcon)
            Dim dt As New DataTable '//T?o bi?t dt d?ng d? li?u là m?t table
            adapter.Fill(dt) '//Đua giá tr? t? k?t n?i vào bi?n dt
            If dt.Rows.Count > 0 Then '//>0 có nghia là có giá tr? trong dt
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class

