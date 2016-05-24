Imports System.Data.SqlClient

Public Class FmSubject
    Private _user As New User

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

    Private Sub ten_Click(sender As Object, e As EventArgs) Handles ten.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub lp_Click(sender As Object, e As EventArgs) Handles lp.Click

    End Sub

    Private Sub msv_Click(sender As Object, e As EventArgs) Handles msv.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class

'' sae show n ra ho a, nchung cơ ban la v.
' vay cc. 
' bỏ shift ra
' thôi để đấy a làm cho
' lam báo cáo đi
'ow, á
Public Class Ketnoi1
    Private conn = "Data Source=MAYTINH-JRUTQDS;Initial Catalog=db_question;Integrated Security=True"
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

