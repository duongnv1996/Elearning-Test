<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdLib = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.AliceBlue
        Me.Button1.Location = New System.Drawing.Point(423, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(320, 108)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Quản lý sinh viên"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdLib
        '
        Me.cmdLib.Location = New System.Drawing.Point(423, 413)
        Me.cmdLib.Name = "cmdLib"
        Me.cmdLib.Size = New System.Drawing.Size(320, 108)
        Me.cmdLib.TabIndex = 1
        Me.cmdLib.Text = "Quản lý ngân hàng câu hỏi"
        Me.cmdLib.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(398, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 51)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Quản lý ứng dụng"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1131, 588)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdLib)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdLib As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
