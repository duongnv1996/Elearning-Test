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
        Me.Db_question = New WindowsApplication2.db_question()
        Me.T_userBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_userTableAdapter = New WindowsApplication2.db_questionTableAdapters.t_userTableAdapter()
        Me.TableAdapterManager = New WindowsApplication2.db_questionTableAdapters.TableAdapterManager()
        Me.T_userBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.T_userBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.T_userDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.T_markBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_markTableAdapter = New WindowsApplication2.db_questionTableAdapters.t_markTableAdapter()
        Me.T_markDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Db_question, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_userBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_userBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.T_userBindingNavigator.SuspendLayout()
        CType(Me.T_userDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_markBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_markDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Db_question
        '
        Me.Db_question.DataSetName = "db_question"
        Me.Db_question.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'T_userBindingNavigator
        '
        Me.T_userBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.T_userBindingNavigator.BindingSource = Me.T_userBindingSource
        Me.T_userBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.T_userBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.T_userBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.T_userBindingNavigatorSaveItem, Me.ToolStripProgressBar1})
        Me.T_userBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.T_userBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.T_userBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.T_userBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.T_userBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.T_userBindingNavigator.Name = "T_userBindingNavigator"
        Me.T_userBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.T_userBindingNavigator.Size = New System.Drawing.Size(1342, 27)
        Me.T_userBindingNavigator.TabIndex = 0
        Me.T_userBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 20)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'T_userBindingNavigatorSaveItem
        '
        Me.T_userBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.T_userBindingNavigatorSaveItem.Image = CType(resources.GetObject("T_userBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.T_userBindingNavigatorSaveItem.Name = "T_userBindingNavigatorSaveItem"
        Me.T_userBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.T_userBindingNavigatorSaveItem.Text = "Save Data"
        '
        'T_userDataGridView
        '
        Me.T_userDataGridView.AutoGenerateColumns = False
        Me.T_userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T_userDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.T_userDataGridView.DataSource = Me.T_userBindingSource
        Me.T_userDataGridView.Location = New System.Drawing.Point(59, 125)
        Me.T_userDataGridView.Name = "T_userDataGridView"
        Me.T_userDataGridView.RowTemplate.Height = 24
        Me.T_userDataGridView.Size = New System.Drawing.Size(575, 388)
        Me.T_userDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "msv"
        Me.DataGridViewTextBoxColumn1.HeaderText = "msv"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn2.HeaderText = "password"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "class"
        Me.DataGridViewTextBoxColumn4.HeaderText = "class"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 24)
        '
        'T_markBindingSource
        '
        Me.T_markBindingSource.DataMember = "t_mark"
        Me.T_markBindingSource.DataSource = Me.Db_question
        '
        'T_markTableAdapter
        '
        Me.T_markTableAdapter.ClearBeforeFill = True
        '
        'T_markDataGridView
        '
        Me.T_markDataGridView.AutoGenerateColumns = False
        Me.T_markDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T_markDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.T_markDataGridView.DataSource = Me.T_markBindingSource
        Me.T_markDataGridView.Location = New System.Drawing.Point(702, 125)
        Me.T_markDataGridView.Name = "T_markDataGridView"
        Me.T_markDataGridView.RowTemplate.Height = 24
        Me.T_markDataGridView.Size = New System.Drawing.Size(591, 388)
        Me.T_markDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "msv"
        Me.DataGridViewTextBoxColumn5.HeaderText = "msv"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id_subject"
        Me.DataGridViewTextBoxColumn6.HeaderText = "id_subject"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "mark"
        Me.DataGridViewTextBoxColumn7.HeaderText = "mark"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'fmstudentManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 596)
        Me.Controls.Add(Me.T_markDataGridView)
        Me.Controls.Add(Me.T_userDataGridView)
        Me.Controls.Add(Me.T_userBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmstudentManager"
        Me.Text = "studentManager"
        CType(Me.Db_question, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_userBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_userBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.T_userBindingNavigator.ResumeLayout(False)
        Me.T_userBindingNavigator.PerformLayout()
        CType(Me.T_userDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_markBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_markDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db_question As WindowsApplication2.db_question
    Friend WithEvents T_userBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_userTableAdapter As WindowsApplication2.db_questionTableAdapters.t_userTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication2.db_questionTableAdapters.TableAdapterManager
    Friend WithEvents T_userBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents T_userBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents T_userDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents T_markTableAdapter As WindowsApplication2.db_questionTableAdapters.t_markTableAdapter
    Friend WithEvents T_markBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_markDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
