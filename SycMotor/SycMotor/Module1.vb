Imports MySql.Data.MySqlClient
Module Module1
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public reader As MySqlDataReader

    Sub Opencon()
        conn.ConnectionString = "server=localhost;username=root;password=;database=sycmotors"
        conn.Open()

    End Sub
    Sub Moov()

    End Sub



End Module
