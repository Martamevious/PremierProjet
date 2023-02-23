
Imports System.Data.SqlClient

Public Class Update

    Dim ident As String
    Private Sub Liste_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Opencon()
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM marque"
        reader = cmd.ExecuteReader()

        ComboBox1.Items.Clear()

        While reader.Read()
            ComboBox1.Items.Add(reader("libmark"))
        End While
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO marque (libmark) VALUES('" & TextBox1.Text & "')"
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show("Un problème est survenu: Marque dejas enregistrée " & ex.Message)
        End Try
        TextBox1.Clear()
        conn.Close()

        Opencon()
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM marque"
        reader = cmd.ExecuteReader()

        ComboBox1.Items.Clear()

        While reader.Read()
            ComboBox1.Items.Add(reader("libmark"))
        End While
        conn.Close()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "SELECT idmark FROM marque WHERE libmark= '" + ComboBox1.Text + "'"
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                ident = reader("idmark")
            Loop

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
        Try
            Opencon()

            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO modele (libmod,idmarque) VALUES('" & TextBoxMod.Text & "','" & ident & "')"
            cmd.ExecuteNonQuery()

            ComboBox1.Text = ""
            TextBoxMod.Clear()
        Catch ex As Exception
            MessageBox.Show("Un problème est survenu: " & ex.Message)
        End Try
        conn.Close()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO employe (nom,prenom,téléphone,adresse) VALUES('" & TextBoxNom.Text & "','" & TextBoxPren.Text & "','" & TextBoxTel.Text & "','" & TextBoxAdr.Text & "')"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Un problème est survenu: " & ex.Message)
        End Try
        conn.Close()
        TextBoxNom.Clear()
        TextBoxPren.Clear()
        TextBoxTel.Clear()
        TextBoxAdr.Clear()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
        Accueil.Show()
    End Sub
End Class