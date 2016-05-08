Public Class fmstudentManager

    Private Sub studentManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_question.t_mark' table. You can move, or remove it, as needed.
        Me.T_markTableAdapter.Fill(Me.Db_question.t_mark)
        'TODO: This line of code loads data into the 'Db_question.t_user' table. You can move, or remove it, as needed.
        Me.T_userTableAdapter.Fill(Me.Db_question.t_user)

    End Sub

    Private Sub T_userBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles T_userBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.T_userBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_question)

    End Sub
End Class