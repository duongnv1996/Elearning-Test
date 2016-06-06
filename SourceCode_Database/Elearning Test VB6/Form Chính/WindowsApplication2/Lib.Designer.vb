<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmAdd))
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
        Me.T_questionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_questionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_question = New WindowsApplication2.db_question()
        Me.T_answerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_answerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_subjectDataGridView = New System.Windows.Forms.DataGridView()
        Me.T_subjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddDB = New System.Windows.Forms.Button()
        Me.cmdFile = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIDSub = New System.Windows.Forms.TextBox()
        Me.cmdUpdateDB = New System.Windows.Forms.Button()
        Me.DbquestionDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_questionTableAdapter = New WindowsApplication2.db_questionTableAdapters.t_questionTableAdapter()
        Me.TableAdapterManager = New WindowsApplication2.db_questionTableAdapters.TableAdapterManager()
        Me.T_answerTableAdapter = New WindowsApplication2.db_questionTableAdapters.t_answerTableAdapter()
        Me.T_subjectTableAdapter = New WindowsApplication2.db_questionTableAdapters.t_subjectTableAdapter()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.DirectorySearcher2 = New System.DirectoryServices.DirectorySearcher()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cbbType = New System.Windows.Forms.ComboBox()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.number_quest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_test = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.T_questionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_questionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_question, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_answerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_answerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_subjectDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_subjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbquestionDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdRead
        '
        Me.cmdRead.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRead.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdRead.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdRead.Location = New System.Drawing.Point(1124, 15)
        Me.cmdRead.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.txtFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(433, 22)
        Me.txtFile.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(539, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Đường dẫn File"
        '
        'lblTitle1
        '
        Me.lblTitle1.AutoSize = True
        Me.lblTitle1.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTitle1.Location = New System.Drawing.Point(253, 177)
        Me.lblTitle1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(64, 16)
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
        Me.lstQuestion.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lstQuestion.FormattingEnabled = True
        Me.lstQuestion.HorizontalExtent = 100
        Me.lstQuestion.HorizontalScrollbar = True
        Me.lstQuestion.Location = New System.Drawing.Point(21, 197)
        Me.lstQuestion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstQuestion.Name = "lstQuestion"
        Me.lstQuestion.ScrollAlwaysVisible = True
        Me.lstQuestion.Size = New System.Drawing.Size(480, 498)
        Me.lstQuestion.TabIndex = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ký tự phân biệt câu hỏi :"
        '
        'txtCQuest
        '
        Me.txtCQuest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCQuest.Location = New System.Drawing.Point(257, 76)
        Me.txtCQuest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCQuest.Name = "txtCQuest"
        Me.txtCQuest.Size = New System.Drawing.Size(151, 22)
        Me.txtCQuest.TabIndex = 6
        Me.txtCQuest.Text = "?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 113)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Ký tự phân biệt câu trả lời đúng :"
        '
        'txtTrueAns
        '
        Me.txtTrueAns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTrueAns.Location = New System.Drawing.Point(257, 108)
        Me.txtTrueAns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTrueAns.Name = "txtTrueAns"
        Me.txtTrueAns.Size = New System.Drawing.Size(151, 22)
        Me.txtTrueAns.TabIndex = 10
        Me.txtTrueAns.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tên môn học:"
        '
        'txtMonHoc
        '
        Me.txtMonHoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonHoc.Location = New System.Drawing.Point(257, 12)
        Me.txtMonHoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMonHoc.Name = "txtMonHoc"
        Me.txtMonHoc.Size = New System.Drawing.Size(151, 22)
        Me.txtMonHoc.TabIndex = 12
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
        Me.T_questionDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.T_questionDataGridView.Name = "T_questionDataGridView"
        Me.T_questionDataGridView.Size = New System.Drawing.Size(720, 176)
        Me.T_questionDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_quest"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MÃ CÂU HỎI"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "content_quest"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NỘI DUNG CÂU HỎI"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id_subject"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MÃ MÔN HỌC"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'T_questionBindingSource
        '
        Me.T_questionBindingSource.DataMember = "t_question"
        Me.T_questionBindingSource.DataSource = Me.db_question
        '
        'db_question
        '
        Me.db_question.DataSetName = "db_question"
        Me.db_question.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.T_answerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.T_answerDataGridView.DataSource = Me.T_answerBindingSource
        Me.T_answerDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.T_answerDataGridView.Location = New System.Drawing.Point(643, 517)
        Me.T_answerDataGridView.Margin = New System.Windows.Forms.Padding(1)
        Me.T_answerDataGridView.MaximumSize = New System.Drawing.Size(1600, 1477)
        Me.T_answerDataGridView.Name = "T_answerDataGridView"
        Me.T_answerDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.T_answerDataGridView.Size = New System.Drawing.Size(720, 209)
        Me.T_answerDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "id_ans"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MÃ CÂU TRẢ LỜI"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "content_ans"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NỘI DUNG"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "id_quest"
        Me.DataGridViewTextBoxColumn7.HeaderText = "MÃ CÂU HỎI"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "true_ans"
        Me.DataGridViewTextBoxColumn8.HeaderText = "LÀ ĐÁP ÁN ĐÚNG(0/1)"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ToolTipText = "a"
        '
        'T_answerBindingSource
        '
        Me.T_answerBindingSource.DataMember = "t_answer"
        Me.T_answerBindingSource.DataSource = Me.db_question
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
        Me.T_subjectDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.number_quest, Me.timer, Me.date_test})
        Me.T_subjectDataGridView.DataSource = Me.T_subjectBindingSource
        Me.T_subjectDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.T_subjectDataGridView.Location = New System.Drawing.Point(644, 197)
        Me.T_subjectDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.T_subjectDataGridView.Name = "T_subjectDataGridView"
        Me.T_subjectDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.T_subjectDataGridView.Size = New System.Drawing.Size(719, 92)
        Me.T_subjectDataGridView.TabIndex = 13
        '
        'T_subjectBindingSource
        '
        Me.T_subjectBindingSource.DataMember = "t_subject"
        Me.T_subjectBindingSource.DataSource = Me.db_question
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(920, 300)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Bảng Câu hỏi"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.Location = New System.Drawing.Point(920, 177)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Bảng môn học"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label7.Location = New System.Drawing.Point(920, 500)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Bảng câu trả lời"
        '
        'btnAddDB
        '
        Me.btnAddDB.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnAddDB.Location = New System.Drawing.Point(512, 342)
        Me.btnAddDB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.cmdFile.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdFile.Location = New System.Drawing.Point(1263, 15)
        Me.cmdFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.Size = New System.Drawing.Size(100, 28)
        Me.cmdFile.TabIndex = 18
        Me.cmdFile.Text = "Tìm File"
        Me.cmdFile.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 53)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "ID môn học:"
        '
        'txtIDSub
        '
        Me.txtIDSub.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIDSub.Location = New System.Drawing.Point(257, 44)
        Me.txtIDSub.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIDSub.Name = "txtIDSub"
        Me.txtIDSub.Size = New System.Drawing.Size(151, 22)
        Me.txtIDSub.TabIndex = 19
        '
        'cmdUpdateDB
        '
        Me.cmdUpdateDB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdUpdateDB.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdUpdateDB.Location = New System.Drawing.Point(512, 423)
        Me.cmdUpdateDB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdUpdateDB.Name = "cmdUpdateDB"
        Me.cmdUpdateDB.Size = New System.Drawing.Size(123, 73)
        Me.cmdUpdateDB.TabIndex = 21
        Me.cmdUpdateDB.Text = "Lưu CSDL"
        Me.cmdUpdateDB.UseVisualStyleBackColor = True
        Me.cmdUpdateDB.Visible = False
        '
        'DbquestionDataSetBindingSource
        '
        Me.DbquestionDataSetBindingSource.DataSource = Me.db_question
        Me.DbquestionDataSetBindingSource.Position = 0
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
        Me.TableAdapterManager.UpdateOrder = WindowsApplication2.db_questionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'T_answerTableAdapter
        '
        Me.T_answerTableAdapter.ClearBeforeFill = True
        '
        'T_subjectTableAdapter
        '
        Me.T_subjectTableAdapter.ClearBeforeFill = True
        '
        'cmdBack
        '
        Me.cmdBack.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(512, 505)
        Me.cmdBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(123, 73)
        Me.cmdBack.TabIndex = 22
        Me.cmdBack.Text = "Trở lại"
        Me.cmdBack.UseVisualStyleBackColor = True
        Me.cmdBack.Visible = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(19, 711)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "A : Câu hỏi"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(395, 711)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "A: Đáp án đúng"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(209, 711)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 17)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "A: Đáp án"
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'DirectorySearcher2
        '
        Me.DirectorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(671, 53)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(433, 22)
        Me.txtSearch.TabIndex = 26
        Me.txtSearch.Visible = False
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label12.Location = New System.Drawing.Point(540, 53)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 16)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Tìm kiếm dữ liệu"
        '
        'cmdFind
        '
        Me.cmdFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdFind.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdFind.Location = New System.Drawing.Point(1263, 50)
        Me.cmdFind.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(100, 28)
        Me.cmdFind.TabIndex = 29
        Me.cmdFind.Text = "Lọc"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'cbbType
        '
        Me.cbbType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbType.FormattingEnabled = True
        Me.cbbType.Items.AddRange(New Object() {"Môn học", "Câu hỏi", "Câu trả lời"})
        Me.cbbType.Location = New System.Drawing.Point(1124, 50)
        Me.cbbType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbbType.Name = "cbbType"
        Me.cbbType.Size = New System.Drawing.Size(100, 24)
        Me.cbbType.TabIndex = 31
        Me.cbbType.Text = "Môn học"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "id_subject"
        Me.DataGridViewTextBoxColumn9.HeaderText = "MÃ MÔN HỌC"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "content_subject"
        Me.DataGridViewTextBoxColumn10.HeaderText = "TÊN MÔN HỌC"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'number_quest
        '
        Me.number_quest.DataPropertyName = "number_quest"
        Me.number_quest.HeaderText = "number_quest"
        Me.number_quest.Name = "number_quest"
        '
        'timer
        '
        Me.timer.DataPropertyName = "timer"
        Me.timer.HeaderText = "timer"
        Me.timer.Name = "timer"
        '
        'date_test
        '
        Me.date_test.DataPropertyName = "date_test"
        Me.date_test.HeaderText = "date_test"
        Me.date_test.Name = "date_test"
        '
        'fmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1379, 738)
        Me.Controls.Add(Me.cbbType)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdUpdateDB)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "fmAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Dữ Liệu"
        CType(Me.T_questionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_questionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_question, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_answerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_answerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_subjectDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_subjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbquestionDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents db_question As WindowsApplication2.db_question
    Friend WithEvents T_questionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_questionTableAdapter As WindowsApplication2.db_questionTableAdapters.t_questionTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication2.db_questionTableAdapters.TableAdapterManager
    Friend WithEvents T_questionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents T_answerTableAdapter As WindowsApplication2.db_questionTableAdapters.t_answerTableAdapter
    Friend WithEvents T_answerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_answerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents T_subjectTableAdapter As WindowsApplication2.db_questionTableAdapters.t_subjectTableAdapter
    Friend WithEvents T_subjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_subjectDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAddDB As System.Windows.Forms.Button
    Friend WithEvents cmdFile As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIDSub As System.Windows.Forms.TextBox
    Friend WithEvents cmdUpdateDB As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DirectorySearcher1 As System.DirectoryServices.DirectorySearcher
    Friend WithEvents DirectorySearcher2 As System.DirectoryServices.DirectorySearcher
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cbbType As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents number_quest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents timer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_test As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
