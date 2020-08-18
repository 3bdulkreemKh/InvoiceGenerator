Imports System.Data.OleDb
Public Class data
    Dim path As String = Environment.CurrentDirectory + "\HoD.accdb"
    Dim con As OleDbConnection

    Sub New()
        Dim strcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        con = New OleDbConnection(strcon)
    End Sub

    Function getdata(ByVal query As String) As DataTable
        con.Open()
        Dim t As New DataTable
        Dim ds As New DataSet
        Try
            Dim ad As New OleDbDataAdapter(query, con)
            ad.Fill(ds)
            t = ds.Tables(0)
        Catch ex As Exception
        End Try
        con.Close()
        Return t
    End Function
    Function checkdata(ByVal query As String) As Boolean
        con.Open()
        Dim t As New DataTable
        Dim ds As New DataSet
        Try
            Dim ad As New OleDbDataAdapter(query, con)
            ad.Fill(ds)
            t = ds.Tables(0)
        Catch ex As Exception
        End Try
        con.Close()
        If t.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Function RunQuery(ByVal query As String) As Integer
        Dim rows As Integer = 0
        con.Open()
        Try
            Dim cmd As New OleDbCommand(query, con)
            rows = cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        con.Close()
        Return rows
    End Function

End Class