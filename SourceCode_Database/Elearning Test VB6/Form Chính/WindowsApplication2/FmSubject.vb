Imports System.Data.SqlClient

Public Class FmSubject
    Public Property user As String
    Private Sub FmSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = user
        Dim kn As New Ketnoi1
    End Sub
End Class
Public Class Ketnoi1
    Private conn = "Data Source=DESKTOP-T17IS19\SQLEXPRESS;Initial Catalog=login;Integrated Security=True"
    Public Function ktketnoi(ByVal ten As String, ByVal lop As String) As Boolean  '//t?o ra class k?t n?i v?i giá tr? tr? v? là ki?u true, false
        Try
            Dim sql = "select * from us where msv='" & ten & "'  and password= '" & lop & "' "
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

