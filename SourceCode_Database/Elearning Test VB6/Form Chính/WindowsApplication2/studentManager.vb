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


    Private Sub studentManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_question.t_mark' table. You can move, or remove it, as needed.
        Me.T_markTableAdapter.Fill(Me.Db_question.t_mark)
        'TODO: This line of code loads data into the 'Db_question.t_user' table. You can move, or remove it, as needed.
        Me.T_userTableAdapter.Fill(Me.Db_question.t_user)
        For Each row As DataRow In Db_question.t_user.Rows
            source.Add(row(0).ToString())
            source.Add(row(2).ToString())
            source.Add(row(3).ToString())
        Next
        For Each row As DataRow In Db_question.t_mark.Rows
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
            Dim dv As New DataView(Db_question.t_user, "msv = '" & data & "'" & " or name = '" & data & "'", "", DataViewRowState.CurrentRows)
            If (dv.Count > 0) Then
                T_userDataGridView.DataSource = dv
                isSuccessfull = True

            End If

            Dim dv2 As New DataView(Db_question.t_mark, "msv = '" & data & "'" & " or id_subject = '" & data & "'", "", DataViewRowState.CurrentRows)
            If (dv2.Count > 0) Then
                T_markDataGridView.DataSource = dv2
                isSuccessfull = True
            Else
                isSuccessfull = False
            End If
            If (isSuccessfull <> True) Then
                MsgBox("Không tìm thấy thông tin vừa nhập")
            End If
        Catch ex As Exception
            MsgBox("Không tìm thấy thông tin vừa nhập")
            loadToDGV()

        End Try
    End Sub

    Private Sub T_userBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles T_userBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.T_userBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_question)
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        filterData(txtSearch.Text)

    End Sub

    Private Sub T_userDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles T_userDataGridView.RowHeaderMouseClick
        Dim count As Long = T_userDataGridView.RowCount


        If (e.RowIndex < count - 1) Then
            id = T_userDataGridView.Rows(e.RowIndex).Cells(0).Value
            Dim dv As DataView
            dv = New DataView(Db_question.t_user, "msv = '" & id & "'", "", DataViewRowState.CurrentRows)
            T_userDataGridView.DataSource = dv
            'filter Ans
            Dim dvAns As DataView
            dvAns = New DataView(Db_question.t_mark, "msv = '" & id & "'", "", DataViewRowState.CurrentRows)
            T_markDataGridView.DataSource = dvAns
            cmdBack.Visible = True
        End If
    End Sub
    Private Sub loadToDGV()
        T_userDataGridView.DataSource = Db_question.t_user
        T_markDataGridView.DataSource = Db_question.t_mark

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
        MsgBox("Xuất file Excel thành công. Xem file tại địa chỉ C:\mark.xlsx")
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
End Class