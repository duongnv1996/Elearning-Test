﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmdRead = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitle1 = New System.Windows.Forms.Label()
        Me.lstQuestion = New System.Windows.Forms.ListBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCQuest = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTrueAns = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMonHoc = New System.Windows.Forms.TextBox()
        Me.db_questionDataSet1 = New WindowsApplication2.db_questionDataSet1()
        Me.DbquestionDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_questionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_questionTableAdapter = New WindowsApplication2.db_questionDataSet1TableAdapters.t_questionTableAdapter()
        Me.TableAdapterManager = New WindowsApplication2.db_questionDataSet1TableAdapters.TableAdapterManager()
        Me.T_answerTableAdapter = New WindowsApplication2.db_questionDataSet1TableAdapters.t_answerTableAdapter()
        Me.T_subjectTableAdapter = New WindowsApplication2.db_questionDataSet1TableAdapters.t_subjectTableAdapter()
        Me.T_questionDataGridView = New System.Windows.Forms.DataGridView()
        Me.T_answerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_answerDataGridView = New System.Windows.Forms.DataGridView()
        Me.T_subjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_subjectDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddDB = New System.Windows.Forms.Button()
        Me.cmdFile = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIDSub = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.db_questionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbquestionDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_questionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_questionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_answerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_answerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_subjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_subjectDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdRead
        '
        Me.cmdRead.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRead.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdRead.Location = New System.Drawing.Point(1124, 15)
        Me.cmdRead.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdRead.Name = "cmdRead"
        Me.cmdRead.Size = New System.Drawing.Size(100, 28)
        Me.cmdRead.TabIndex = 0
        Me.cmdRead.Text = "Open"
        Me.cmdRead.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFile.Location = New System.Drawing.Point(671, 17)
        Me.txtFile.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(433, 22)
        Me.txtFile.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(539, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Đường dẫn File"
        '
        'lblTitle1
        '
        Me.lblTitle1.AutoSize = True
        Me.lblTitle1.Location = New System.Drawing.Point(253, 177)
        Me.lblTitle1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(64, 17)
        Me.lblTitle1.TabIndex = 3
        Me.lblTitle1.Text = "CÂU HỎI"
        '
        'lstQuestion
        '
        Me.lstQuestion.AllowDrop = True
        Me.lstQuestion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstQuestion.ColumnWidth = 600
        Me.lstQuestion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lstQuestion.FormattingEnabled = True
        Me.lstQuestion.HorizontalExtent = 100
        Me.lstQuestion.HorizontalScrollbar = True
        Me.lstQuestion.Location = New System.Drawing.Point(21, 197)
        Me.lstQuestion.Margin = New System.Windows.Forms.Padding(4)
        Me.lstQuestion.Name = "lstQuestion"
        Me.lstQuestion.ScrollAlwaysVisible = True
        Me.lstQuestion.Size = New System.Drawing.Size(480, 511)
        Me.lstQuestion.TabIndex = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ký tự phân biệt câu hỏi :"
        '
        'txtCQuest
        '
        Me.txtCQuest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCQuest.Location = New System.Drawing.Point(257, 76)
        Me.txtCQuest.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCQuest.Name = "txtCQuest"
        Me.txtCQuest.Size = New System.Drawing.Size(151, 22)
        Me.txtCQuest.TabIndex = 6
        Me.txtCQuest.Text = "?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 113)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Ký tự phân biệt câu trả lời đúng :"
        '
        'txtTrueAns
        '
        Me.txtTrueAns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTrueAns.Location = New System.Drawing.Point(257, 108)
        Me.txtTrueAns.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTrueAns.Name = "txtTrueAns"
        Me.txtTrueAns.Size = New System.Drawing.Size(151, 22)
        Me.txtTrueAns.TabIndex = 10
        Me.txtTrueAns.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tên môn học:"
        '
        'txtMonHoc
        '
        Me.txtMonHoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonHoc.Location = New System.Drawing.Point(257, 12)
        Me.txtMonHoc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMonHoc.Name = "txtMonHoc"
        Me.txtMonHoc.Size = New System.Drawing.Size(151, 22)
        Me.txtMonHoc.TabIndex = 12
        '
        'db_questionDataSet1
        '
        Me.db_questionDataSet1.DataSetName = "db_questionDataSet1"
        Me.db_questionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DbquestionDataSetBindingSource
        '
        Me.DbquestionDataSetBindingSource.DataSource = Me.db_questionDataSet1
        Me.DbquestionDataSetBindingSource.Position = 0
        '
        'T_questionBindingSource
        '
        Me.T_questionBindingSource.DataMember = "t_question"
        Me.T_questionBindingSource.DataSource = Me.db_questionDataSet1
        '
        'T_questionTableAdapter
        '
        Me.T_questionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.t_answerTableAdapter = Me.T_answerTableAdapter
        Me.TableAdapterManager.t_markTableAdapter = Nothing
        Me.TableAdapterManager.t_questionTableAdapter = Me.T_questionTableAdapter
        Me.TableAdapterManager.t_subjectTableAdapter = Me.T_subjectTableAdapter
        Me.TableAdapterManager.t_userTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication2.db_questionDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'T_answerTableAdapter
        '
        Me.T_answerTableAdapter.ClearBeforeFill = True
        '
        'T_subjectTableAdapter
        '
        Me.T_subjectTableAdapter.ClearBeforeFill = True
        '
        'T_questionDataGridView
        '
        Me.T_questionDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T_questionDataGridView.AutoGenerateColumns = False
        Me.T_questionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.T_questionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.T_questionDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.T_questionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.T_questionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.T_questionDataGridView.DataSource = Me.T_questionBindingSource
        Me.T_questionDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.T_questionDataGridView.Location = New System.Drawing.Point(643, 320)
        Me.T_questionDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.T_questionDataGridView.Name = "T_questionDataGridView"
        Me.T_questionDataGridView.RowHeadersVisible = False
        Me.T_questionDataGridView.Size = New System.Drawing.Size(720, 176)
        Me.T_questionDataGridView.TabIndex = 13
        '
        'T_answerBindingSource
        '
        Me.T_answerBindingSource.DataMember = "t_answer"
        Me.T_answerBindingSource.DataSource = Me.db_questionDataSet1
        '
        'T_answerDataGridView
        '
        Me.T_answerDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T_answerDataGridView.AutoGenerateColumns = False
        Me.T_answerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.T_answerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.T_answerDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.T_answerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.T_answerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.T_answerDataGridView.DataSource = Me.T_answerBindingSource
        Me.T_answerDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.T_answerDataGridView.Location = New System.Drawing.Point(643, 517)
        Me.T_answerDataGridView.Margin = New System.Windows.Forms.Padding(1)
        Me.T_answerDataGridView.MaximumSize = New System.Drawing.Size(1600, 1477)
        Me.T_answerDataGridView.Name = "T_answerDataGridView"
        Me.T_answerDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.T_answerDataGridView.RowHeadersVisible = False
        Me.T_answerDataGridView.Size = New System.Drawing.Size(720, 209)
        Me.T_answerDataGridView.TabIndex = 13
        '
        'T_subjectBindingSource
        '
        Me.T_subjectBindingSource.DataMember = "t_subject"
        Me.T_subjectBindingSource.DataSource = Me.db_questionDataSet1
        '
        'T_subjectDataGridView
        '
        Me.T_subjectDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T_subjectDataGridView.AutoGenerateColumns = False
        Me.T_subjectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.T_subjectDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.T_subjectDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.T_subjectDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.T_subjectDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.T_subjectDataGridView.DataSource = Me.T_subjectBindingSource
        Me.T_subjectDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.T_subjectDataGridView.Location = New System.Drawing.Point(644, 197)
        Me.T_subjectDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.T_subjectDataGridView.Name = "T_subjectDataGridView"
        Me.T_subjectDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.T_subjectDataGridView.RowHeadersVisible = False
        Me.T_subjectDataGridView.Size = New System.Drawing.Size(719, 92)
        Me.T_subjectDataGridView.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(920, 300)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Bảng Câu hỏi"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(920, 177)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Bảng môn học"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(920, 500)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Bảng câu trả lời"
        '
        'btnAddDB
        '
        Me.btnAddDB.Location = New System.Drawing.Point(511, 377)
        Me.btnAddDB.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddDB.Name = "btnAddDB"
        Me.btnAddDB.Size = New System.Drawing.Size(123, 73)
        Me.btnAddDB.TabIndex = 17
        Me.btnAddDB.Text = "Thêm vào CSDL"
        Me.btnAddDB.UseVisualStyleBackColor = True
        '
        'cmdFile
        '
        Me.cmdFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFile.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdFile.Location = New System.Drawing.Point(1263, 15)
        Me.cmdFile.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.Size = New System.Drawing.Size(100, 28)
        Me.cmdFile.TabIndex = 18
        Me.cmdFile.Text = "Tìm File"
        Me.cmdFile.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 53)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "ID môn học:"
        '
        'txtIDSub
        '
        Me.txtIDSub.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIDSub.Location = New System.Drawing.Point(257, 44)
        Me.txtIDSub.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIDSub.Name = "txtIDSub"
        Me.txtIDSub.Size = New System.Drawing.Size(151, 22)
        Me.txtIDSub.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(1263, 161)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Tìm File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "id_ans"
        Me.DataGridViewTextBoxColumn4.HeaderText = "id_ans"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "content_ans"
        Me.DataGridViewTextBoxColumn5.HeaderText = "content_ans"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id_subject"
        Me.DataGridViewTextBoxColumn6.HeaderText = "id_subject"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "id_quest"
        Me.DataGridViewTextBoxColumn7.HeaderText = "id_quest"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "true_ans"
        Me.DataGridViewTextBoxColumn8.HeaderText = "true_ans"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_quest"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_quest"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "content_quest"
        Me.DataGridViewTextBoxColumn2.HeaderText = "content_quest"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id_subject"
        Me.DataGridViewTextBoxColumn3.HeaderText = "id_subject"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "id_subject"
        Me.DataGridViewTextBoxColumn9.HeaderText = "id_subject"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "content_subject"
        Me.DataGridViewTextBoxColumn10.HeaderText = "content_subject"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'fmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1379, 738)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtIDSub)
        Me.Controls.Add(Me.cmdFile)
        Me.Controls.Add(Me.btnAddDB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.T_subjectDataGridView)
        Me.Controls.Add(Me.T_answerDataGridView)
        Me.Controls.Add(Me.T_questionDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMonHoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTrueAns)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCQuest)
        Me.Controls.Add(Me.lstQuestion)
        Me.Controls.Add(Me.lblTitle1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.cmdRead)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "fmAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Dữ Liệu"
        CType(Me.db_questionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbquestionDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_questionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_questionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_answerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_answerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_subjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_subjectDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdRead As System.Windows.Forms.Button
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTitle1 As System.Windows.Forms.Label
    Friend WithEvents lstQuestion As System.Windows.Forms.ListBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCQuest As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTrueAns As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMonHoc As System.Windows.Forms.TextBox
    Friend WithEvents DbquestionDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents db_questionDataSet1 As WindowsApplication2.db_questionDataSet1
    Friend WithEvents T_questionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_questionTableAdapter As WindowsApplication2.db_questionDataSet1TableAdapters.t_questionTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication2.db_questionDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents T_questionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents T_answerTableAdapter As WindowsApplication2.db_questionDataSet1TableAdapters.t_answerTableAdapter
    Friend WithEvents T_answerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_answerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents T_subjectTableAdapter As WindowsApplication2.db_questionDataSet1TableAdapters.t_subjectTableAdapter
    Friend WithEvents T_subjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_subjectDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAddDB As System.Windows.Forms.Button
    Friend WithEvents cmdFile As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIDSub As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class