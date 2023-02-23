Public Class Check
    Private Sub Check_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try
            Opencon()
            Label2.Text = "Connected"

        Catch ex As Exception

            Label2.Text = "Disconnected"
            MsgBox(ex.ToString)
        End Try
        conn.Close()
        Opencon()
        cmd.Connection = conn
        cmd.CommandText = "SELECT libmark FROM marque"

        reader = cmd.ExecuteReader()
        RichTextBox1.Text = ""
        Do While reader.Read()
            If Not reader.IsDBNull(reader.GetOrdinal("libmark")) Then

                RichTextBox1.Text = RichTextBox1.Text + reader("libmark").ToString() + vbCr
            End If
        Loop

        conn.Close()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Opencon()

        Try
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO marque (libmark) VALUES('" & TextBox1.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Enregistrement éffectué avec succès")
            conn.Close()

        Catch ex As Exception
            MsgBox("")
        End Try


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class