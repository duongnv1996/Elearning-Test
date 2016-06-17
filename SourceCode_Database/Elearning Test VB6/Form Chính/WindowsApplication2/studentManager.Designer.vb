<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmstudentManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmstudentManager))
        Me.T_userDataGridView = New System.Windows.Forms.DataGridView()
        Me.T_markDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_markBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_question = New WindowsApplication2.db_question()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_userBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_userTableAdapter = New WindowsApplication2.db_questionTableAdapters.t_userTableAdapter()
        Me.TableAdapterManager = New WindowsApplication2.db_questionTableAdapters.TableAdapterManager()
        Me.T_markTableAdapter = New WindowsApplication2.db_questionTableAdapters.t_markTableAdapter()
        CType(Me.T_userDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_markDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_markBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_question, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_userBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'T_userDataGridView
        '
        Me.T_userDataGridView.AutoGenerateColumns = False
        Me.T_userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.T_userDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.T_userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T_userDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.T_userDataGridView.DataSource = Me.T_userBindingSource
        Me.T_userDataGridView.Location = New System.Drawing.Point(34, 147)
        Me.T_userDataGridView.Name = "T_userDataGridView"
        Me.T_userDataGridView.RowTemplate.Height = 24
        Me.T_userDataGridView.Size = New System.Drawing.Size(503, 364)
        Me.T_userDataGridView.TabIndex = 1
        '
        'T_markDataGridView
        '
        Me.T_markDataGridView.AutoGenerateColumns = False
        Me.T_markDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.T_markDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.T_markDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T_markDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.T_markDataGridView.DataSource = Me.T_markBindingSource
        Me.T_markDataGridView.Location = New System.Drawing.Point(624, 147)
        Me.T_markDataGridView.Name = "T_markDataGridView"
        Me.T_markDataGridView.RowTemplate.Height = 24
        Me.T_markDataGridView.Size = New System.Drawing.Size(517, 364)
        Me.T_markDataGridView.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tìm kiếm  :"
        '
        'cmdSearch
        '
        Me.cmdSearch.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdSearch.Location = New System.Drawing.Point(461, 8)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(66, 25)
        Me.cmdSearch.TabIndex = 4
        Me.cmdSearch.Text = "Tìm kiếm"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(541, 8)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(66, 25)
        Me.cmdBack.TabIndex = 5
        Me.cmdBack.Text = "Trở lại"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'cmdExport
        '
        Me.cmdExport.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdExport.Location = New System.Drawing.Point(1040, 116)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(102, 25)
        Me.cmdExport.TabIndex = 6
        Me.cmdExport.Text = "Xuất Excel"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnSave.Location = New System.Drawing.Point(528, 522)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 25)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Lưu lại"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "msv"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MÃ SINH VIÊN"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id_subject"
        Me.DataGridViewTextBoxColumn6.HeaderText = "MÃ MÔN HỌC"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "mark"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ĐIỂM"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'T_markBindingSource
        '
        Me.T_markBindingSource.DataMember = "t_mark"
        Me.T_markBindingSource.DataSource = Me.Db_question
        '
        'Db_question
        '
        Me.Db_question.DataSetName = "db_question"
        Me.Db_question.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "msv"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MÃ SINH VIÊN"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MẬT KHẨU"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "HỌ TÊN"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "class"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LỚP"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'T_userBindingSource
        '
        Me.T_userBindingSource.DataMember = "t_user"
        Me.T_userBindingSource.DataSource = Me.Db_question
        '
        'T_userTableAdapter
        '
        Me.T_userTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.t_answerTableAdapter = Nothing
        Me.TableAdapterManager.t_markTableAdapter = Me.T_markTableAdapter
        Me.TableAdapterManager.t_questionTableAdapter = Nothing
        Me.TableAdapterManager.t_subjectTableAdapter = Nothing
        Me.TableAdapterManager.t_userTableAdapter = Me.T_userTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication2.db_questionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'T_markTableAdapter
        '
        Me.T_markTableAdapter.ClearBeforeFill = True
        '
        'fmstudentManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 559)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.T_markDataGridView)
        Me.Controls.Add(Me.T_userDataGridView)
        Me.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "fmstudentManager"
        Me.Text = "Student Manager"
        CType(Me.T_userDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_markDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_markBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_question, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_userBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db_question As WindowsApplication2.db_question
    Friend WithEvents T_userBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_userTableAdapter As WindowsApplication2.db_questionTableAdapters.t_userTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication2.db_questionTableAdapters.TableAdapterManager
    Friend WithEvents T_userDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents T_markTableAdapter As WindowsApplication2.db_questionTableAdapters.t_markTableAdapter
    Friend WithEvents T_markBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_markDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
