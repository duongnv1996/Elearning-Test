Partial Class db_question
    Partial Class t_answerDataTable

        Private Sub t_answerDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.id_ansColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
