<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtname = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btncan = New System.Windows.Forms.Button()
        Me.btnlog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtname
        '
        Me.txtname.AutoSize = True
        Me.txtname.BackColor = System.Drawing.Color.Fuchsia
        Me.txtname.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtname.Location = New System.Drawing.Point(23, 72)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(57, 13)
        Me.txtname.TabIndex = 0
        Me.txtname.Text = "UserName"
        '
        'txtpass
        '
        Me.txtpass.AutoSize = True
        Me.txtpass.BackColor = System.Drawing.Color.Fuchsia
        Me.txtpass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtpass.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtpass.Location = New System.Drawing.Point(23, 155)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(56, 13)
        Me.txtpass.TabIndex = 0
        Me.txtpass.Text = "PassWord"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Lime
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Image = Global.WindowsApplication2.My.Resources.Resources.huyen
        Me.Label3.Location = New System.Drawing.Point(126, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "LOGIN"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(135, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(100, 148)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(135, 20)
        Me.TextBox2.TabIndex = 1
        '
        'btncan
        '
        Me.btncan.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btncan.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btncan.Location = New System.Drawing.Point(179, 211)
        Me.btncan.Name = "btncan"
        Me.btncan.Size = New System.Drawing.Size(75, 23)
        Me.btncan.TabIndex = 2
        Me.btncan.Text = "Cancel"
        Me.btncan.UseVisualStyleBackColor = False
        '
        'btnlog
        '
        Me.btnlog.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnlog.ForeColor = System.Drawing.Color.Brown
        Me.btnlog.Location = New System.Drawing.Point(54, 211)
        Me.btnlog.Name = "btnlog"
        Me.btnlog.Size = New System.Drawing.Size(75, 23)
        Me.btnlog.TabIndex = 2
        Me.btnlog.Text = "Login"
        Me.btnlog.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.huyen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnlog)
        Me.Controls.Add(Me.btncan)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtname)
        Me.Name = "Form1"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtname As System.Windows.Forms.Label
    Friend WithEvents txtpass As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btncan As System.Windows.Forms.Button
    Friend WithEvents btnlog As System.Windows.Forms.Button

End Class
