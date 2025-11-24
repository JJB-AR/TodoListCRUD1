Imports System.Data.Odbc
Module TestModule
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter

    ''Database
    Public Sub dbConnect()
        Try
            conn = New OdbcConnection("DSN=JonasDB")
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Database Connection Error: " & ex.Message, vbCritical, "Connection Error")
        Finally
            GC.Collect()
        End Try
    End Sub
End Module