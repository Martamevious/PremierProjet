Imports System.Data.SqlClient
Public Class Enregistrement
    Dim idmod As String
    Dim idvoit As String
    Dim idclient As String
    Dim idcolor As String
    Dim iden As String
    Dim idempl As String
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Accueil.Show()
    End Sub

    Private Sub Enregistrement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxDate.Text = ""
        Opencon()
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM marque"
        reader = cmd.ExecuteReader()

        ComboBoxMrk.Items.Clear()

        Do While reader.Read()
            ComboBoxMrk.Items.Add(reader("libmark"))
        Loop
        conn.Close()
        Opencon()
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM couleur"
        reader = cmd.ExecuteReader()

        ComboBoxCol.Items.Clear()

        Do While reader.Read()
            ComboBoxCol.Items.Add(reader("libcolor"))
        Loop

        conn.Close()
        Opencon()
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM modele "
        reader = cmd.ExecuteReader()

        ComboBoxMod.Items.Clear()

        Do While reader.Read()
            ComboBoxMod.Items.Add(reader("libmod"))
        Loop

        conn.Close()

        Opencon()
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM client "
        reader = cmd.ExecuteReader()

        ComboBoxClt.Items.Clear()

        Do While reader.Read()
            ComboBoxClt.Items.Add(reader("nom"))
        Loop

        conn.Close()

        Opencon()
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM employe"
        reader = cmd.ExecuteReader()

        ComboBoxEmp.Items.Clear()

        Do While reader.Read()
            ComboBoxEmp.Items.Add(reader("Nom"))
        Loop
        conn.Close()


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    Private Sub ButtonValider_Click(sender As Object, e As EventArgs) Handles ButtonValider.Click
        'Enregistrement des données dans la base
        If (ComboBoxClt.Text <> "" And ComboBoxCol.Text <> "" And ComboBoxEmp.Text <> "" And TextBoxDate.Text <> "" And TextBoxMont.Text <> "" And ComboBoxMod.Text <> "" And ComboBoxMrk.Text <> "") Then


            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "SELECT idmod from modele where libmod='" & ComboBoxMod.Text & "'"
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                idmod = reader("idmod")
            Loop

            conn.Close()

            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "SELECT idclient from client where nom='" & ComboBoxClt.Text & "'"
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                idclient = reader("idclient")
            Loop

            conn.Close()

            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "SELECT idempl from employe where nom='" & ComboBoxEmp.Text & "'"
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                idempl = reader("idempl")
            Loop

            conn.Close()

            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "SELECT idcolor from couleur where libcolor='" & ComboBoxCol.Text & "'"
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                idcolor = reader("idcolor")
            Loop

            conn.Close()

            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO voiture (model,marque,couleur) VALUES('" & idmod & "','" & iden & "','" & idcolor & "')"
            cmd.ExecuteNonQuery()

            conn.Close()

            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "SELECT idvoiture from voiture where model='" & idmod & "' and marque='" & iden & "' and 
            couleur='" & idcolor & "'"
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                idvoit = reader("idvoiture")
            Loop

            conn.Close()

            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO vente  (voiture,employ,client,datevente,Montant) VALUES('" & idvoit & "','" & idempl & "','" & idclient & "',
        '" & TextBoxDate.Text & "','" & TextBoxMont.Text & "')"
            cmd.ExecuteNonQuery()

            conn.Close()
            ComboBoxClt.Text = ""
            ComboBoxCol.Text = ""
            ComboBoxEmp.Text = ""
            ComboBoxMrk.Text = ""
            ComboBoxMod.Text = ""
            TextBoxDate.Clear()
            TextBoxMont.Clear()
        Else
            MessageBox.Show("Veuillez saisir tous les champs", "", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        ComboBoxClt.Text = ""
        ComboBoxCol.Text = ""
        ComboBoxEmp.Text = ""
        ComboBoxMrk.Text = ""
        ComboBoxMod.Text = ""
        TextBoxDate.Clear()
        TextBoxMont.Clear()





    End Sub

    Private Sub ComboBoxMrk_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBoxMrk.SelectedIndexChanged
        PictureBox2.Visible = True
        ComboBoxMod.Text = ""
        Opencon()
        cmd.Connection = conn
        cmd.CommandText = "SELECT idmark FROM marque WHERE libmark='" + ComboBoxMrk.Text + "'"
        reader = cmd.ExecuteReader()


        Do While reader.Read()
            iden = reader("idmark")
        Loop

        conn.Close()

        Opencon()
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM modele where idmarque= '" + iden + "' "
        reader = cmd.ExecuteReader()

        ComboBoxMod.Items.Clear()

        Do While reader.Read()
            ComboBoxMod.Items.Add(reader("libmod"))
        Loop

        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBoxDate.Text = DateTimePicker1.Value
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub
End Class