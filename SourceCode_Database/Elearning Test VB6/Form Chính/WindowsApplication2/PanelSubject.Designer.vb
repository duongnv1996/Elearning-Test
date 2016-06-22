<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelSubject
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnSubject = New System.Windows.Forms.Button()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.lbDay = New System.Windows.Forms.Label()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubject
        '
        Me.btnSubject.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSubject.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnSubject.Location = New System.Drawing.Point(51, 31)
        Me.btnSubject.Name = "btnSubject"
        Me.btnSubject.Size = New System.Drawing.Size(399, 100)
        Me.btnSubject.TabIndex = 0
        Me.btnSubject.UseVisualStyleBackColor = False
        '
        'pic
        '
        Me.pic.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pic.Image = Global.WindowsApplication2.My.Resources.Resources.bell_ring
        Me.pic.ImageLocation = ""
        Me.pic.Location = New System.Drawing.Point(401, 37)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(28, 28)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic.TabIndex = 2
        Me.pic.TabStop = False
        Me.pic.Visible = False
        '
        'lbDay
        '
        Me.lbDay.AutoSize = True
        Me.lbDay.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbDay.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbDay.ForeColor = System.Drawing.Color.White
        Me.lbDay.Image = Global.WindowsApplication2.My.Resources.Resources.backgroung
        Me.lbDay.Location = New System.Drawing.Point(395, 37)
        Me.lbDay.Name = "lbDay"
        Me.lbDay.Padding = New System.Windows.Forms.Padding(8)
        Me.lbDay.Size = New System.Drawing.Size(16, 39)
        Me.lbDay.TabIndex = 1
        '
        'PanelSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.lbDay)
        Me.Controls.Add(Me.btnSubject)
        Me.Name = "PanelSubject"
        Me.Size = New System.Drawing.Size(489, 149)
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubject As System.Windows.Forms.Button
    Friend WithEvents lbDay As System.Windows.Forms.Label
    Friend WithEvents pic As System.Windows.Forms.PictureBox

End Class
