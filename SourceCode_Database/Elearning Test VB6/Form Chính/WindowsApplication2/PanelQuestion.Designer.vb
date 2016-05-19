Partial Class PanelQuestion
    Inherits System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    '<System.Diagnostics.DebuggerNonUserCode()> _
    'Public Sub New()
    '    MyBase.New()

    '    'This call is required by the Component Designer.
    '    InitializeComponent()

    'End Sub

    'Component overrides dispose to clean up the component list.
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

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbQuest = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbQuest
        '
        Me.lbQuest.AutoSize = True
        Me.lbQuest.Location = New System.Drawing.Point(1, 0)
        Me.lbQuest.Name = "lbQuest"
        Me.lbQuest.Size = New System.Drawing.Size(100, 23)
        Me.lbQuest.TabIndex = 0
        Me.lbQuest.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PanelQuestion
        '
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbQuest As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
