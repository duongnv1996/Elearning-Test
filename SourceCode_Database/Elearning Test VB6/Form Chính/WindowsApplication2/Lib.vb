Imports Microsoft.Office.Interop
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient

Namespace Form_Add_Data

End Namespace

Public Class fmAdd
    Private gvSubject As Integer = 1
    Private gvQuestion As Integer = 2
    Private gvAnswer As Integer = 3
    Private focusIn As Integer
    Private cQuest As String
    Private cAns As String
    Private cTrueAns As String
    Private idSubjectFocus As String
    Private idQuestFocus As String
    Private idAnsFocus As String
    Private mSubject As String
    Private con As New SqlConnection("Data Source=MAYTINH-JRUTQDS;Initial Catalog=db_question;Integrated Security=True")

    Dim ds As New DataSet
    Dim sqlQuest As String = "SELECT * FROM t_question"
    Dim sqlSub As String = "SELECT * FROM t_subject"
    Dim sqlAns As String = "SELECT * FROM t_answer"
    Dim adapterQuest As New SqlDataAdapter(sqlQuest, con)
    Dim adapterAns As New SqlDataAdapter(sqlAns, con)
    Dim adapterSub As New SqlDataAdapter(sqlSub, con)
    Private Sub loadToDGV()
        T_questionDataGridView.DataSource = db_question.t_question
        T_answerDataGridView.DataSource = db_question.t_answer
        T_subjectDataGridView.DataSource = db_question.t_subject
    End Sub
    Private Sub fmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        txtMonHoc.Focus()
        con.Open()
        adapterQuest.Fill(ds, "t_question")
        adapterAns.Fill(ds, "t_answer")
        adapterSub.Fill(ds, "t_subject")
        con.Close()
        '  loadToDGV()

        'Try
        '    con.Open()
        '    Dim deleteSub As New SqlCommand("Delete  FROM  t_subject", con)
        '    Dim deleteAns As New SqlCommand("Delete  FROM  t_answer", con)
        '    Dim deleteQuest As New SqlCommand("Delete FROM t_quest", con)
        '    deleteSub.ExecuteNonQuery()
        '    deleteQuest.ExecuteNonQuery()
        '    deleteAns.ExecuteNonQuery()
        '    'MsgBox("Mo thanh cong DB")

        '    con.Close()
        'Catch ex As Exception
        '    MsgBox("Loi roi " & ex.Message.ToString)

        'End Try

        'TODO: This line of code loads data into the 'db_question.t_subject' table. You can move, or remove it, as needed.
        Me.T_subjectTableAdapter.Fill(Me.db_question.t_subject)
        'TODO: This line of code loads data into the 'db_question.t_answer' table. You can move, or remove it, as needed.
        Me.T_answerTableAdapter.Fill(Me.db_question.t_answer)
        'TODO: This line of code loads data into the 'db_question.t_question' table. You can move, or remove it, as needed.
        Me.T_questionTableAdapter.Fill(Me.db_question.t_question)

        lstQuestion.HorizontalScrollbar = True
        Me.AutoSize = True

    End Sub

    ' Read from the Excel workbook.
    Private Sub cmdRead_Click(filename)
        Dim excel_app As Excel.Application
        Dim workbook As Excel.Workbook
        Dim sheet As Excel.Worksheet

        ' Get the Excel application object.
        excel_app = New Excel.Application

        ' Make Excel visible (optional).
        excel_app.Visible = True

        ' Open the workbook read-only.
        workbook = excel_app.Workbooks.Open( _
            Filename:=filename, ReadOnly:=True)

        ' Get the first worksheet.
        sheet = workbook.Sheets(1)

        ' Get the titles and values.
        If (txtCQuest.Text.ToString.Length > 0 And txtTrueAns.Text.ToString.Length > 0) Then
            SetTitleAndListValues(sheet, 1, 1, lblTitle1, lstQuestion, txtCQuest.Text.ToString, txtTrueAns.Text.ToString)
        Else
            MsgBox("Vui lòng điền đầy đủ thông tin", vbOK, "Thông báo")
            txtCQuest.Focus()
        End If

        ' SetTitleAndListValues(sheet, 1, 2, lblTitle2, lstItems2)

        ' Save the changes and close the workbook.
        workbook.Close(SaveChanges:=False)

        ' Close the Excel server.
        excel_app.Quit()
    End Sub

    ' Set a title Label and the values in a ListBox. Get the
    ' title from cell (row, col).
    ' Get the values from cell (row + 1, col) to the end of the
    ' column.
    Private Sub SetTitleAndListValues(ByVal sheet As  _
        Excel.Worksheet, _
        ByVal row As Integer, ByVal col As Integer, ByVal lbl As  _
            Label, ByVal lst As ListBox, ByVal cQuest As Char, ByVal cTrueAns As Char)
        Dim range As Excel.Range
        Dim last_cell As Excel.Range
        Dim first_cell As Excel.Range
        Dim value_range As Excel.Range
        Dim range_values(,) As Object
        Dim num_items As Integer
        Dim i As Integer

        ' Set the title.
        range = sheet.Cells(row, col)
        lbl.Text = txtMonHoc.Text
        'lbl.ForeColor = range.Font.Color
        'lbl.BackColor = range.Interior.Color

        ' Get the values.
        ' Find the last cell in the column.
        range = sheet.Columns(col)
        last_cell = range.End(Excel.XlDirection.xlDown)
        ' Get a Range holding the values.
        first_cell = sheet.Cells(row, col)
        value_range = sheet.Range(first_cell, last_cell)
        ' Get the values.
        range_values = value_range.Value2()
        ' Convert this into a 1-dimensional array.
        ' Note that the Range's array has lower bounds 1.
        num_items = UBound(range_values, 1)
        lst.Items.Clear()
        Dim k = 0
        For i = 1 To num_items
            Dim content As String
            content = range_values.GetValue(i, 1)
            If (content.Equals("") <> True) Then
                lst.Items.Add(content)
            End If

        Next i
    End Sub




    Private Sub cmdRead_Click(sender As Object, e As EventArgs) Handles cmdRead.Click
        'cmdRead_Click()
        'FolderBrowserDialog1.ShowDialog()
        If (txtFile.Text.Equals("")) Then
            MsgBox("Vui lòng điền đầy đủ thông tin", vbOK, "Thông báo")

        Else
            cmdRead_Click(txtFile.Text)




        End If

    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        ' lstQuestion.Items.Clear()
        Dim fileName = sender.FileName()
        txtFile.Text = fileName.ToString
        cmdRead_Click(fileName)


    End Sub

    Private Sub lstQuestion_DrawItem(ByVal sender As Object, _
 ByVal e As System.Windows.Forms.DrawItemEventArgs) _
 Handles lstQuestion.DrawItem

        cQuest = txtCQuest.Text.ToString.Trim
        cTrueAns = txtTrueAns.Text.ToString.Trim
        ' Draw the background of the ListBox control for each item.
        e.DrawBackground()

        ' Define the default color of the brush as black.
        Dim myBrush As Brush = Brushes.Black

        ' Determine the color of the brush to draw each item based on   
        ' the index of the item to draw.
        myBrush = Brushes.Red
        'Select Case e.Index
        '    Case 0
        '        myBrush = Brushes.Red
        '    Case 1
        '        myBrush = Brushes.Orange
        '    Case 2
        '        myBrush = Brushes.Purple
        'End Select

        ' Draw the current item text based on the current 
        ' Font and the custom brush settings.

        If (lstQuestion.Items(e.Index).ToString().Contains(cTrueAns)) Then
            e.Graphics.DrawString(lstQuestion.Items(e.Index).ToString(), _
           e.Font, Brushes.Red, e.Bounds, StringFormat.GenericDefault)
        ElseIf (lstQuestion.Items(e.Index).ToString().Contains(cQuest)) Then
            e.Graphics.DrawString(lstQuestion.Items(e.Index).ToString(), _
          e.Font, Brushes.Blue, e.Bounds, StringFormat.GenericDefault)
        Else
            e.Graphics.DrawString(lstQuestion.Items(e.Index).ToString(), _
           e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault)
        End If
        'e.Graphics.DrawString(lstQuestion.Items(e.Index).ToString(), _
        '   e.Font, myBrush, e.Bounds, StringFormat.GenericDefault)

        ' If the ListBox has focus, draw a focus rectangle around  _ 
        ' the selected item.
        e.DrawFocusRectangle()

    End Sub

    Private Sub cmdFile_Click(sender As Object, e As EventArgs) Handles cmdFile.Click
        OpenFileDialog1.Filter = "Excel Worksheets|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub btnAddDB_Click(sender As Object, e As EventArgs) Handles btnAddDB.Click
        Dim isAdd As Boolean
        isAdd = False


        If (txtMonHoc.Text.Trim.ToString.Length > 0 And txtIDSub.Text.Trim.ToString.Length > 0 And txtCQuest.Text.Trim.ToString.Length > 0 And txtTrueAns.Text.Trim.ToString.Length > 0) Then
            mSubject = txtMonHoc.Text.Trim.ToString
            cQuest = txtCQuest.Text.ToString.Trim
            cTrueAns = txtTrueAns.Text.ToString.Trim
            Dim idSubject = txtIDSub.Text

            Try
                con.Open()
                'Them vao bang t_subject
                Dim queryString As String = "select * from t_subject where id_subject=@idSubject"
                Dim sqlSelect As New SqlCommand(queryString, con)
                sqlSelect.Parameters.AddWithValue("@idSubject", idSubject)

                Dim isExist As Boolean = False
                Using reader As SqlDataReader = sqlSelect.ExecuteReader()
                    If (reader.HasRows) Then
                        isExist = True
                    End If
                End Using

                If isExist <> True Then

                    Dim sql As New SqlCommand("insert into t_subject (id_subject,content_subject) values (N'" & idSubject & "',N'" & mSubject & "')", con)

                    sql.ExecuteNonQuery()
                    'Them vao bang question
                    If (lstQuestion.Items.Count > 0) Then
                        Dim idQ As Integer = -1
                        For Each item In lstQuestion.Items
                            If (item.ToString.Equals("") <> True) Then
                                If (item.ToString.Contains(cQuest)) Then
                                    Dim sqlInsertQ As New SqlCommand("insert into t_question (content_quest,id_subject) values (N'" & item.ToString & "',N'" & idSubject & "')SELECT SCOPE_IDENTITY();", con)
                                    idQ = CInt(sqlInsertQ.ExecuteScalar())
                                ElseIf (item.ToString.Contains(cTrueAns)) Then
                                    Dim sT As String
                                    sT = "Insert into t_answer(content_ans,id_quest,true_ans) values (N'" & item.ToString.Trim & "'" & "," & idQ & "," & 1 & ")"
                                    Dim sqlInsertT As New SqlCommand(sT, con)
                                    sqlInsertT.ExecuteNonQuery()
                                Else
                                    Dim s As String
                                    s = "Insert into t_answer(content_ans,id_quest,true_ans) values (N'" & item.ToString.Trim & "'" & "," & idQ & "," & 0 & ")"
                                    Dim sqlInsertA As New SqlCommand(s, con)
                                    sqlInsertA.ExecuteNonQuery()
                                End If
                            End If
                        Next
                    End If
                    Me.T_subjectTableAdapter.Fill(Me.db_question.t_subject)
                    Me.T_answerTableAdapter.Fill(Me.db_question.t_answer)
                    Me.T_questionTableAdapter.Fill(Me.db_question.t_question)
                    MsgBox("Thêm thành công " & mSubject, vbOKOnly, "Thông báo")


                Else
                    MsgBox("ID môn học : " & idSubject & " đã tồn tại. Vui lòng chọn mã ID khác", vbOKOnly, "Lỗi ID")

                End If


                con.Close()
            Catch ex As Exception
                MsgBox("Không thể thêm " & " do " & ex.Message, vbOKOnly, "Thông báo")
                con.Close()
            End Try


        Else
            MsgBox("Vui lòng điền đầy đủ thông tin", vbOK, "Thông báo")
        End If
    End Sub
    Private Function getGreatString(str As String) As String
        Dim s$
        s = ""
        str = Trim(str)
        Dim id As String
        id = ""
        Dim i%
        For i = 2 To Len(str)
            If Mid(str, i, 1) <> " " Then
                If Mid(str, i - 1, 1) = " " Then
                    s = s & " " & UCase(Mid(str, i, 1))
                    id = id & UCase(Mid(str, i, 1))
                Else
                    s = s & LCase(Mid(str, i, 1))
                End If
            End If
        Next
        s = UCase(Mid(str, 1, 1)) & s
        id = UCase(Mid(str, 1, 1)) & id
        getGreatString = id
    End Function
    Private Sub txtMonHoc_LostFocus() Handles txtMonHoc.LostFocus
        If (txtMonHoc.Text.Length > 0) Then
            txtIDSub.Text = getGreatString(txtMonHoc.Text.ToString)
        End If


    End Sub


    Private Function insertInto(table As String, ByVal colums As ArrayList, ByVal values As ArrayList) As Integer
        Dim c As String
        c = ""
        Dim v As String
        v = ""
        For Each columI As String In colums
            c = c + columI
        Next
        For Each valueI As String In values
            v = v + valueI
        Next
        Dim sql As New SqlCommand("insert into t_subject (" + c + ") values (N'" + v + "')", con)
        insertInto = sql.ExecuteNonQuery()
    End Function



    Private Sub cmdUpdateDB_Click(sender As Object, e As EventArgs) Handles cmdUpdateDB.Click

        Try
            Me.TableAdapterManager.UpdateAll(db_question)

            MsgBox("Lưu vào CSDL thành công")
            cmdUpdateDB.Visible = False
        Catch ex As Exception
            MsgBox("Không thể lưu vào CSDL")
        End Try


    End Sub
    
    Private Sub cmdUndo_Click(sender As Object, e As EventArgs) Handles cmdBack.Click

        loadToDGV()


    End Sub

    Private Sub T_questionDataGridView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles T_questionDataGridView.CellBeginEdit


    End Sub

 


    Private Sub T_questionDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles T_questionDataGridView.CellValueChanged
        cmdUpdateDB.Visible = True

    End Sub

    Private Sub T_subjectDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles T_subjectDataGridView.CellValueChanged
        cmdUpdateDB.Visible = True
    End Sub

    

    Private Sub T_answerDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles T_answerDataGridView.CellValueChanged
        cmdUpdateDB.Visible = True
    End Sub

    Private Sub T_answerDataGridView_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles T_answerDataGridView.UserDeletedRow
        cmdUpdateDB.Visible = True
    End Sub
    Dim dv As DataView
    Private Sub T_subjectDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles T_subjectDataGridView.RowHeaderMouseClick
        Dim count As Long = T_subjectDataGridView.RowCount


        If (e.RowIndex < count - 1) Then
            idSubjectFocus = T_subjectDataGridView.Rows(e.RowIndex).Cells(0).Value


            dv = New DataView(db_question.t_question, "id_subject = '" & idSubjectFocus & "'", "id_quest Desc", DataViewRowState.CurrentRows)
            T_questionDataGridView.DataSource = dv
            'filter Ans
            'idQuestFocus = T_questionDataGridView.Rows(0).Cells(0).Value

            'Dim dvAns As DataView
            'dvAns = New DataView(db_question.t_answer, "id_quest = '" & idQuestFocus & "'", "id_ans Desc", DataViewRowState.CurrentRows)
            'T_answerDataGridView.DataSource = dvAns

            ' filter Subject
            Dim dvSub As New DataView(db_question.t_subject, "id_subject = '" & idSubjectFocus & "'", "id_subject Desc", DataViewRowState.CurrentRows)
            T_subjectDataGridView.DataSource = dvSub
            cmdBack.Visible = True
        End If

    End Sub

    Private Sub T_subjectDataGridView_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles T_subjectDataGridView.UserDeletingRow
        cmdUpdateDB.Visible = True
        For Each Item As DataRowView In dv
            Dim id As String = Item(0).ToString()
            Dim dvAnss = New DataView(db_question.t_answer, "id_quest = '" & id & "'", "id_ans Desc", DataViewRowState.CurrentRows)
            deleteAns(dvAnss)
            Item.Delete()

        Next
        loadToDGV()
    End Sub

 

    Private Sub T_questionDataGridView_ContextMenuStripChanged(sender As Object, e As EventArgs) Handles T_questionDataGridView.ContextMenuStripChanged

    End Sub

    Private Sub T_questionDataGridView_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles T_questionDataGridView.RowEnter
      

    End Sub
    Private listSelect As List(Of Long)
    Dim dvAns As DataView

    Private Sub T_questionDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles T_questionDataGridView.RowHeaderMouseClick
        Dim count As Long = T_questionDataGridView.RowCount


        If (e.RowIndex < count - 1) Then
            idQuestFocus = T_questionDataGridView.Rows(e.RowIndex).Cells(0).Value
            Dim subject As String = T_questionDataGridView.Rows(e.RowIndex).Cells(2).Value.ToString()
            Dim dvQuest As DataView
            dvQuest = New DataView(db_question.t_question, "id_quest = '" & idQuestFocus & "'", "id_quest Desc", DataViewRowState.CurrentRows)
            T_questionDataGridView.DataSource = dvQuest
            'filter Ans

            dvAns = New DataView(db_question.t_answer, "id_quest = '" & idQuestFocus & "'", "id_ans Desc", DataViewRowState.CurrentRows)

            T_answerDataGridView.DataSource = dvAns

            ' filter Subject
            Dim dvSub As New DataView(db_question.t_subject, "id_subject = '" & subject & "'", "id_subject Desc", DataViewRowState.CurrentRows)
            T_subjectDataGridView.DataSource = dvSub


            cmdBack.Visible = True
        End If
     
    End Sub

    Private Sub T_questionDataGridView_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles T_questionDataGridView.RowLeave
       
    End Sub

    Private Sub T_questionDataGridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles T_questionDataGridView.RowValidating
        '  MsgBox("ID vua xoa la : " & T_questionDataGridView.RowCount)
    End Sub



    


    Private Sub T_questionDataGridView_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles T_questionDataGridView.UserDeletedRow
        'MsgBox("ID vua xoa la : " & idQuestFocus)
        deleteAns(dvAns)
        loadToDGV()
        cmdUpdateDB.Visible = True
    End Sub
    
    Private isFirst As Boolean
    Private Sub deleteAns(ByVal dvAns As DataView)
        For Each Item As DataRowView In dvAns
            Item.Delete()
        Next
    End Sub

End Class
