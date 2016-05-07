Imports System.Data.SqlClient
Public Class Form1
    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        If (txtuser.Text = "") Then
            MessageBox.Show("Bạn hãy nhập vào tên tài khoản")
            txtuser.Focus()
        Else
            If (txtpas.Text = "") Then
                MessageBox.Show("Bạn hãy nhập vào mật khẩu")
                txtpas.Focus()
            Else
                Dim ketn As New Ketnoi
                If ketn.ktketnoi(txtuser.Text, txtpas.Text) Then
                    '  MessageBox.Show("Bạn đã đăng nhập thành công")
                    Form2.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Lỗi đăng nhập!")
                    txtpas.Text = ""
                    txtpas.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub btncan_Click(sender As Object, e As EventArgs) Handles btncan.Click
        Close()
    End Sub
    Private Sub txtuser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtuser.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtpas.Focus()
        End If
    End Sub
    'Sự kiện cho txtpass là keydown nhập xong nhấn enter thì gọi lệnh đăng nhập
    Private Sub txtpas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnlog_Click(sender, e)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtuser.Text = ""
        txtpas.Text = ""
        txtuser.Focus()
    End Sub
End Class
'KẾT NỐI
Public Class Ketnoi
    Private conn = "Data Source=DESKTOP-T17IS19\SQLEXPRESS;Initial Catalog=user_login;Integrated Security=True"
    Public Function ktketnoi(ByVal user As String, ByVal pas As String) As Boolean  '//tạo ra class kết nối với giá trị trả về là kiểu true, false


        Try
            Dim sql = "select * from login where uid='" & user & "'  and pwd= '" & pas & "' "
            Dim sqlcon As New SqlConnection(conn)
            Dim adapter As New SqlDataAdapter(sql, sqlcon)
            Dim dt As New DataTable '//Tạo biết dt dạng dữ liệu là một table
            adapter.Fill(dt) '//Đưa giá trị từ kết nối vào biến dt
            If dt.Rows.Count > 0 Then '//>0 có nghĩa là có giá trị trong dt
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class

