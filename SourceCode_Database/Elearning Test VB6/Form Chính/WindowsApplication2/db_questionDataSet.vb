Partial Class db_question
    Partial Class t_questionDataTable

        Private Sub t_questionDataTable_t_questionRowChanging(sender As Object, e As t_questionRowChangeEvent) Handles Me.t_questionRowChanging

        End Sub

    End Class

    Partial Class t_subjectDataTable

        Private Sub t_subjectDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.id_subjectColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class t_answerDataTable

        Private Sub t_answerDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.id_ansColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub t_answerDataTable_t_answerRowChanging(sender As Object, e As t_answerRowChangeEvent) Handles Me.t_answerRowChanging

        End Sub

    End Class

End Class

Namespace db_questionTableAdapters
    
    Partial Public Class t_subjectTableAdapter
    End Class
End Namespace
