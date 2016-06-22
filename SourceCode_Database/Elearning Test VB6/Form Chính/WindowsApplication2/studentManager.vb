Imports System.Data.SqlClient
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop

Public Class fmstudentManager
    Private con As New SqlConnection("Data Source=MAYTINH-JRUTQDS;Initial Catalog=db_question;Integrated Security=True;MultipleActiveResultSets=True")
    Dim txtSearch As New TextBox
    Dim source As New AutoCompleteStringCollection
    Dim id As String


    Dim sqlMark As String = "SELECT * FROM t_mark"
    Dim sqlUser As String = "SELECT * FROM t_user"
    Dim adapterMark As New SqlDataAdapter(sqlMark, con)
    Dim adapterUser As New SqlDataAdapter(sqlUser, con)
    Dim ds As New db_question

    Dim tableMark As DataTable
    Dim tableUser As DataTable
    Private Sub loadDGV()

        loadFromAdapter(adapterMark, "t_mark", tableMark)
        loadFromAdapter(adapterUser, "t_user", tableUser)
        T_userDataGridView.DataSource = tableUser
        T_markDataGridView.DataSource = tableMark

    End Sub
    Private Sub loadFromAdapter(ByVal adapter As SqlDataAdapter, ByVal name As String, ByRef table As DataTable)

        adapter.Fill(ds, name)
        table = ds.Tables(name)
    End Sub
    Private Sub studentManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  con.Open()
        loadDGV()
        ' con.Close()

        For Each row As DataRow In tableUser.Rows
            source.Add(row(0).ToString())
            source.Add(row(2).ToString())
            source.Add(row(3).ToString())
        Next
        For Each row As DataRow In tableMark.Rows
            source.Add(row(1).ToString())
            source.Add(row(2).ToString())

        Next
        txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest
        txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtSearch.AutoCompleteCustomSource = source
        txtSearch.Size = New Size(200, 10)
        txtSearch.Location = New Point(150, 7)
        Me.Controls.Add(txtSearch)
        txtSearch.Parent = Me

        ' Me.Controls.Add(cmdSearch)

    End Sub

    Private Sub filterData(ByVal data As String)
        Try
            Dim isSuccessfull As Boolean = False


            'filter question
            Dim dv As New DataView(tableUser, "msv = '" & data & "'" & " or name = '" & data & "'", "", DataViewRowState.CurrentRows)
            If (dv.Count > 0) Then
                T_userDataGridView.DataSource = dv
                isSuccessfull = True

            End If

            Dim dv2 As New DataView(tableMark, "msv = '" & data & "'" & " or id_subject = '" & data & "'", "", DataViewRowState.CurrentRows)
            If (dv2.Count > 0) Then
                T_markDataGridView.DataSource = dv2
                isSuccessfull = True
            End If
            If (isSuccessfull <> True) Then

                MessageBox.Show("Không tìm thấy thông tin vừa nhập", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Không tìm thấy thông tin vừa nhập", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Error)

            loadToDGV()

        End Try
    End Sub

    Private Sub T_userBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.T_userBindingSource.EndEdit()
        'adapterMark.Update(tableMark)
        'adapterUser.Update(tableUser)

    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        filterData(txtSearch.Text)

    End Sub

    Private Sub T_userDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles T_userDataGridView.RowHeaderMouseClick
        Dim count As Long = T_userDataGridView.RowCount


        If (e.RowIndex < count - 1) Then
            id = T_userDataGridView.Rows(e.RowIndex).Cells(0).Value
            Dim dv As DataView
            dv = New DataView(tableUser, "msv = '" & id & "'", "", DataViewRowState.CurrentRows)
            T_userDataGridView.DataSource = dv
            'filter Ans
            Dim dvAns As DataView
            dvAns = New DataView(tableMark, "msv = '" & id & "'", "", DataViewRowState.CurrentRows)
            T_markDataGridView.DataSource = dvAns
            cmdBack.Visible = True
        End If
    End Sub
    Private Sub loadToDGV()
        T_userDataGridView.DataSource = tableUser
        T_markDataGridView.DataSource = tableMark

    End Sub
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        loadToDGV()
    End Sub
    Dim dataHeader As DataRowCollection
    Private Sub cmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click
        Dim cnn As SqlConnection
        Dim connectionString As String
        Dim sql As String
        Dim i, j As Integer

        Dim xlApp As New Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As New Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        connectionString = "Data Source=MAYTINH-JRUTQDS;Initial Catalog=db_question;Integrated Security=True"
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        sql = "SELECT t_mark.msv,t_user.name , t_user.class , t_subject.content_subject ,t_mark.mark FROM t_mark, t_user , t_subject WHERE t_mark.msv = t_user.msv and t_mark.id_subject = t_subject.id_subject "
        Dim dscmd As New SqlDataAdapter(sql, cnn)
        Dim ds As New DataSet
        dscmd.Fill(ds)
        xlWorkSheet.Cells(1, 1).Value = "MÃ SINH VIÊN"
        xlWorkSheet.Cells(1, 2).Value = " HỌ TÊN"
        xlWorkSheet.Cells(1, 3).Value = "LỚP"
        xlWorkSheet.Cells(1, 4).Value = "MÔN HỌC"
        xlWorkSheet.Cells(1, 5).Value = "ĐIỂM"
        Dim k As Integer = 2
        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                xlWorkSheet.Cells(k, j + 1) = _
               ds.Tables(0).Rows(i).Item(j)
            Next
            k = k + 1
        Next
        xlWorkSheet.SaveAs("D:\mark.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        cnn.Close()

        MessageBox.Show("Xuất file Excel thành công. Xem file tại địa chỉ D:\mark.xlsx", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            con.Open()
            Me.TableAdapterManager.UpdateAll(ds)
            MessageBox.Show("Lưu vào CSDL thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Không thể lưu vào CSDL " & ex.ToString, "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub
End Class