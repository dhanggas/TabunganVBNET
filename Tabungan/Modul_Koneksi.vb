Imports System.Data.Odbc
Imports System.Data
Imports System.Data.OleDb
Module Modul_Koneksi
    Public Conn As OleDbConnection
    Public RD As OleDbDataReader
    Public DA As OleDbDataAdapter
    Public CMD As OleDbCommand
    Public DS As DataSet
    Public DB As OleDbCommandBuilder
    Public DT As DataTable
    Public Sub Koneksi()
        Dim SQLConn As String
        SQLConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbtabungan.mdb;"
        Conn = New OleDbConnection(SQLConn)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
