<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmTesting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmTesting))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbSubject = New System.Windows.Forms.GroupBox()
        Me.btnNopBai = New System.Windows.Forms.Button()
        Me.T_answerTableAdapter1 = New WindowsApplication2.db_questionTableAdapters.t_answerTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VScrollBar2 = New System.Windows.Forms.VScrollBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblHoTen = New System.Windows.Forms.Label()
        Me.lbHoten = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbMsv = New System.Windows.Forms.Label()
        Me.lbClass = New System.Windows.Forms.Label()
        Me.lbTimeStart = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbTimeEnd = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbSubject.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1098, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Đại Học Điện Lực"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(364, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(645, 49)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kiểm Tra Trắc Nghiệm Elearning"
        '
        'gbSubject
        '
        Me.gbSubject.BackColor = System.Drawing.Color.Transparent
        Me.gbSubject.Controls.Add(Me.btnNopBai)
        Me.gbSubject.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSubject.Location = New System.Drawing.Point(22, 252)
        Me.gbSubject.Margin = New System.Windows.Forms.Padding(4)
        Me.gbSubject.Name = "gbSubject"
        Me.gbSubject.Padding = New System.Windows.Forms.Padding(4)
        Me.gbSubject.Size = New System.Drawing.Size(313, 266)
        Me.gbSubject.TabIndex = 5
        Me.gbSubject.TabStop = False
        Me.gbSubject.Text = "Câu hỏi"
        '
        'btnNopBai
        '
        Me.btnNopBai.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnNopBai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNopBai.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNopBai.ForeColor = System.Drawing.Color.Red
        Me.btnNopBai.Location = New System.Drawing.Point(89, 208)
        Me.btnNopBai.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNopBai.Name = "btnNopBai"
        Me.btnNopBai.Size = New System.Drawing.Size(144, 46)
        Me.btnNopBai.TabIndex = 1
        Me.btnNopBai.Text = "Nộp Bài"
        Me.btnNopBai.UseVisualStyleBackColor = True
        '
        'T_answerTableAdapter1
        '
        Me.T_answerTableAdapter1.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.VScrollBar2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1450, 740)
        Me.Panel1.TabIndex = 6
        Me.Panel1.Visible = False
        '
        'VScrollBar2
        '
        Me.VScrollBar2.Location = New System.Drawing.Point(1368, 0)
        Me.VScrollBar2.Name = "VScrollBar2"
        Me.VScrollBar2.Size = New System.Drawing.Size(21, 3168)
        Me.VScrollBar2.TabIndex = 0
        Me.VScrollBar2.Visible = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(373, 235)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1450, 3200)
        Me.Panel2.TabIndex = 0
        '
        'lblHoTen
        '
        Me.lblHoTen.AutoSize = True
        Me.lblHoTen.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblHoTen.Location = New System.Drawing.Point(18, 119)
        Me.lblHoTen.Name = "lblHoTen"
        Me.lblHoTen.Size = New System.Drawing.Size(97, 22)
        Me.lblHoTen.TabIndex = 6
        Me.lblHoTen.Text = "Họ và tên :"
        '
        'lbHoten
        '
        Me.lbHoten.AutoSize = True
        Me.lbHoten.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lbHoten.Location = New System.Drawing.Point(121, 119)
        Me.lbHoten.Name = "lbHoten"
        Me.lbHoten.Size = New System.Drawing.Size(0, 22)
        Me.lbHoten.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(18, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Mã Sv :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(18, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Lớp :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(855, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Thời gian bắt đầu:"
        '
        'lbMsv
        '
        Me.lbMsv.AutoSize = True
        Me.lbMsv.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lbMsv.Location = New System.Drawing.Point(121, 191)
        Me.lbMsv.Name = "lbMsv"
        Me.lbMsv.Size = New System.Drawing.Size(0, 22)
        Me.lbMsv.TabIndex = 11
        '
        'lbClass
        '
        Me.lbClass.AutoSize = True
        Me.lbClass.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lbClass.Location = New System.Drawing.Point(121, 155)
        Me.lbClass.Name = "lbClass"
        Me.lbClass.Size = New System.Drawing.Size(0, 22)
        Me.lbClass.TabIndex = 12
        '
        'lbTimeStart
        '
        Me.lbTimeStart.AutoSize = True
        Me.lbTimeStart.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lbTimeStart.Location = New System.Drawing.Point(1009, 191)
        Me.lbTimeStart.Name = "lbTimeStart"
        Me.lbTimeStart.Size = New System.Drawing.Size(0, 22)
        Me.lbTimeStart.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(1157, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 22)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Thời gian kết thúc :"
        '
        'lbTimeEnd
        '
        Me.lbTimeEnd.AutoSize = True
        Me.lbTimeEnd.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lbTimeEnd.Location = New System.Drawing.Point(1326, 191)
        Me.lbTimeEnd.Name = "lbTimeEnd"
        Me.lbTimeEnd.Size = New System.Drawing.Size(0, 22)
        Me.lbTimeEnd.TabIndex = 15
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1390, 763)
        Me.ShapeContainer1.TabIndex = 16
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 370
        Me.LineShape2.X2 = 370
        Me.LineShape2.Y1 = 220
        Me.LineShape2.Y2 = 32000
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 2
        Me.LineShape1.X2 = 1385
        Me.LineShape1.Y1 = 220
        Me.LineShape1.Y2 = 220
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 93)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'FmTesting
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1390, 763)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbTimeEnd)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbTimeStart)
        Me.Controls.Add(Me.lbClass)
        Me.Controls.Add(Me.lbMsv)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbHoten)
        Me.Controls.Add(Me.lblHoTen)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.gbSubject)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FmTesting"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Kiểm Tra"
        Me.gbSubject.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbSubject As System.Windows.Forms.GroupBox
    Friend WithEvents btnNopBai As System.Windows.Forms.Button
    Friend WithEvents T_answerTableAdapter1 As WindowsApplication2.db_questionTableAdapters.t_answerTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblHoTen As System.Windows.Forms.Label
    Friend WithEvents lbHoten As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbMsv As System.Windows.Forms.Label
    Friend WithEvents lbClass As System.Windows.Forms.Label
    Friend WithEvents lbTimeStart As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbTimeEnd As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents VScrollBar2 As System.Windows.Forms.VScrollBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
