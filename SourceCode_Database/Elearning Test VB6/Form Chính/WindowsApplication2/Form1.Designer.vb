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
        Me.components = New System.ComponentModel.Container()
        Me.UserControl11 = New WindowsApplication2.ctQuestion()
        Me.PanelQuestion1 = New WindowsApplication2.PanelQuestion(Me.components)
        Me.SuspendLayout()
        '
        'UserControl11
        '
        Me.UserControl11.Location = New System.Drawing.Point(12, 12)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(601, 357)
        Me.UserControl11.TabIndex = 0
        '
        'PanelQuestion1
        '
        Me.PanelQuestion1.BorderColor = System.Drawing.Color.Empty
        Me.PanelQuestion1.BorderWidth = 0
        Me.PanelQuestion1.Location = New System.Drawing.Point(573, 128)
        Me.PanelQuestion1.Name = "PanelQuestion1"
        Me.PanelQuestion1.Size = New System.Drawing.Size(521, 408)
        Me.PanelQuestion1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 574)
        Me.Controls.Add(Me.PanelQuestion1)
        Me.Controls.Add(Me.UserControl11)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UserControl11 As WindowsApplication2.ctQuestion
    Friend WithEvents PanelQuestion1 As WindowsApplication2.PanelQuestion
End Class
