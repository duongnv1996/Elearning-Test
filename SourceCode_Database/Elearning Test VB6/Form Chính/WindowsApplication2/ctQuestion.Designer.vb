<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctQuestion
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
        Me.lbQuest = New System.Windows.Forms.Label()
        Me.rbA = New System.Windows.Forms.RadioButton()
        Me.rbB = New System.Windows.Forms.RadioButton()
        Me.rbC = New System.Windows.Forms.RadioButton()
        Me.rbD = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lbQuest
        '
        Me.lbQuest.AutoSize = True
        Me.lbQuest.Location = New System.Drawing.Point(27, 9)
        Me.lbQuest.Name = "lbQuest"
        Me.lbQuest.Size = New System.Drawing.Size(51, 17)
        Me.lbQuest.TabIndex = 0
        Me.lbQuest.Text = "Label1"
        '
        'rbA
        '
        Me.rbA.AutoSize = True
        Me.rbA.Location = New System.Drawing.Point(46, 68)
        Me.rbA.Name = "rbA"
        Me.rbA.Size = New System.Drawing.Size(115, 21)
        Me.rbA.TabIndex = 1
        Me.rbA.TabStop = True
        Me.rbA.Text = "RadioButton1"
        Me.rbA.UseVisualStyleBackColor = True
        '
        'rbB
        '
        Me.rbB.AutoSize = True
        Me.rbB.Location = New System.Drawing.Point(46, 106)
        Me.rbB.Name = "rbB"
        Me.rbB.Size = New System.Drawing.Size(115, 21)
        Me.rbB.TabIndex = 2
        Me.rbB.TabStop = True
        Me.rbB.Text = "RadioButton2"
        Me.rbB.UseVisualStyleBackColor = True
        '
        'rbC
        '
        Me.rbC.AutoSize = True
        Me.rbC.Location = New System.Drawing.Point(46, 145)
        Me.rbC.Name = "rbC"
        Me.rbC.Size = New System.Drawing.Size(115, 21)
        Me.rbC.TabIndex = 3
        Me.rbC.TabStop = True
        Me.rbC.Text = "RadioButton3"
        Me.rbC.UseVisualStyleBackColor = True
        '
        'rbD
        '
        Me.rbD.AutoSize = True
        Me.rbD.Location = New System.Drawing.Point(46, 181)
        Me.rbD.Name = "rbD"
        Me.rbD.Size = New System.Drawing.Size(115, 21)
        Me.rbD.TabIndex = 4
        Me.rbD.TabStop = True
        Me.rbD.Text = "RadioButton4"
        Me.rbD.UseVisualStyleBackColor = True
        '
        'ctQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rbD)
        Me.Controls.Add(Me.rbC)
        Me.Controls.Add(Me.rbB)
        Me.Controls.Add(Me.rbA)
        Me.Controls.Add(Me.lbQuest)
        Me.Name = "ctQuestion"
        Me.Size = New System.Drawing.Size(1496, 227)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbQuest As System.Windows.Forms.Label
    Friend WithEvents rbA As System.Windows.Forms.RadioButton
    Friend WithEvents rbB As System.Windows.Forms.RadioButton
    Friend WithEvents rbC As System.Windows.Forms.RadioButton
    Friend WithEvents rbD As System.Windows.Forms.RadioButton

End Class
