Imports System.Data.SqlClient
Public Class FmLogin
    Private Sub btndn_Click(sender As Object, e As EventArgs) Handles btndn.Click
        If (txtuser.Text = "") Then
            MessageBox.Show("Bạn hãy nhập vào tên tài khoản")
            txtuser.Focus()
        Else
            If (txtpass.Text = "") Then
                MessageBox.Show("Bạn hãy nhập vào mật khẩu")
                txtpass.Focus()
            Else

                Dim ketn As New Ketnoi
                If ketn.ktketnoi(txtuser.Text, txtpass.Text) Then
                    If (txtuser.Text = "admin" And txtpass.Text = "admin") Then
                        Admin.Show()

                    Else
                        MessageBox.Show("Bạn đã đăng nhập thành công")
                        FmSubject.Show()
                        Me.Hide()
                    End If

                Else

                    '//ngược lại tức là dữ liệu lấy từ ketnoi không có hoặc một trong tài khoản hoặc user đã sai thì thông báo
                    MessageBox.Show("Lỗi đăng nhập!")
                    txtpass.Text = ""
                    txtpass.Focus()
                End If
                End If
            End If


    End Sub

    Private Sub btncan_Click(sender As Object, e As EventArgs) Handles btncan.Click
        Close()
    End Sub
    Private Sub txtuser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtuser.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtpass.Focus()
        End If
    End Sub
    'Sự kiện cho txtpass là keydown nhập xong nhấn enter thì gọi lệnh đăng nhập
    Private Sub txtpass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyValue = Keys.Enter Then
            btndn_Click(sender, e)
        End If
    End Sub
End Class
'KẾT NỐI
Public Class Ketnoi
    Private conn = "Data Source=MAYTINH-JRUTQDS;Initial Catalog=db_question;Integrated Security=True;MultipleActiveResultSets=True"
    Public Function ktketnoi(ByVal user As String, ByVal pass As String) As Boolean  '//tạo ra class kết nối với giá trị trả về là kiểu true, false


        Try
            Dim sql = "select * from t_user where msv='" & user & "'  and password= '" & pass & "' "
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

