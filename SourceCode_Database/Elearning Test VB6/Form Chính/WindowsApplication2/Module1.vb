Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb


Module Module1
    Public dbs As New SqlConnection
    Public MyConnectString As String = "server=(local);database=db_question;trusted_connection=false;uid=sa;pwd=duong12210119"

    Public Function TruyVan(ByVal MySQLStr As String, ByRef rst_dt As DataTable) As Boolean
        Dim MyResult As Boolean = False
        Dim rst_da As SqlDataAdapter = Nothing
        Try
            rst_da = New SqlDataAdapter(MySQLStr, dbs)
            rst_da.Fill(rst_dt)
            If rst_dt.Rows.Count <> 0 Then
                MyResult = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SELECTQUERY")
        Finally
            rst_da.Dispose()
        End Try
        Return MyResult
    End Function


End Module
