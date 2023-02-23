Imports MySql.Data.MySqlClient

Public Class Afficage
    Dim ident As String
    Dim affich As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBoxSrch.Clear()
        Opencon()
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM client"
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim MyDataSet As New DataSet
        Try
            Label2.Visible = False
            adapter.Fill(MyDataSet, cmd.CommandText)
            DataGridView1.DataSource = MyDataSet.Tables(cmd.CommandText)
        Catch ex As Exception
            MessageBox.Show("!" & ex.Message)
        End Try

        conn.Close()
        TextBoxSrch.Clear()
        affich = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxSrch.Clear()

        Opencon()
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM employe"
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim MyDataSet As New DataSet
        Try
            Label2.Visible = False
            adapter.Fill(MyDataSet, cmd.CommandText)
            DataGridView1.DataSource = MyDataSet.Tables(cmd.CommandText)
        Catch ex As Exception
            MessageBox.Show("!" & ex.Message)
        End Try
        conn.Close()
        affich = 2
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Accueil.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Close()
        Accueil.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSrch.TextChanged
        If affich = 2 Then
            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM employe WHERE nom LIKE'%" + TextBoxSrch.Text + "%'or prenom LIKE '%" + TextBoxSrch.Text + "%'  or adresse LIKE '%" + TextBoxSrch.Text + "%'"
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim MyDataSet As New DataSet
            Try
                Label2.Visible = False
                adapter.Fill(MyDataSet, cmd.CommandText)
                DataGridView1.DataSource = MyDataSet.Tables(cmd.CommandText)
            Catch ex As Exception
                MessageBox.Show("!" & ex.Message)
            End Try



            conn.Close()
        ElseIf affich = 1 Then
            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM client WHERE nom LIKE'%" + TextBoxSrch.Text + "%' or prenom LIKE '%" + TextBoxSrch.Text + "%'  or adresse LIKE '%" + TextBoxSrch.Text + "%'"
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim MyDataSet As New DataSet
            Try
                Label2.Visible = False
                adapter.Fill(MyDataSet, cmd.CommandText)
                DataGridView1.DataSource = MyDataSet.Tables(cmd.CommandText)
            Catch ex As Exception
                MessageBox.Show("!" & ex.Message)
            End Try
        ElseIf affich = 3 Then
            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "SELECT modele.idmod AS ID,modele.libmod AS Modele,marque.libmark AS Marque FROM marque,modele 
              WHERE (modele.libmod LIKE'%" + TextBoxSrch.Text + "%' and modele.idmarque=marque.idmark)
              or (marque.libmark LIKE '%" + TextBoxSrch.Text + "%' and modele.idmarque=marque.idmark)"
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim MyDataSet As New DataSet
            Try
                Label2.Visible = False
                adapter.Fill(MyDataSet, cmd.CommandText)
                DataGridView1.DataSource = MyDataSet.Tables(cmd.CommandText)
            Catch ex As Exception
                MessageBox.Show("!" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub Afficage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Opencon()
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM marque"
        reader = cmd.ExecuteReader()

        ComboBoxMrk1.Items.Clear()

        While reader.Read()
            ComboBoxMrk1.Items.Add(reader("libmark"))
        End While
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBoxSrch.Clear()

        Opencon()
        cmd.Connection = conn
        cmd.CommandText = "SELECT modele.idmod,modele.libmod,marque.libmark FROM marque,modele 
                                WHERE modele.idmarque=marque.idmark;"
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim MyDataSet As New DataSet
        Try
            Label2.Visible = False
            adapter.Fill(MyDataSet, cmd.CommandText)
            DataGridView1.DataSource = MyDataSet.Tables(cmd.CommandText)
        Catch ex As Exception
            MessageBox.Show("!" & ex.Message)
        End Try
        conn.Close()

        affich = 3
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If affich = 2 Then
            PanelEmp.Visible = True
            PanelMod.Visible = False
            Panelclit.Visible = False
        ElseIf affich = 3 Then
            PanelMod.Visible = True
            PanelEmp.Visible = False
            Panelclit.Visible = False

        ElseIf affich = 1 Then
            Panelclit.Visible = True
            PanelEmp.Visible = False
            PanelMod.Visible = False
        ElseIf affich = 4 Then
            Enregistrement.ShowDialog()

        End If
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBoxSrch.Clear()

        Opencon()
        cmd.Connection = conn
        cmd.CommandText = "SELECT vente.id as N°,marque.libmark as 'Marque de la voiture',modele.libmod as 'Modèle',couleur.libcolor,CONCAT(client.Nom,' ',client.Prenom) as 'Client',CONCAT(employe.Nom,' ', employe.Prenom) as 'Employé',vente.Montant
                           FROM vente,voiture,marque,modele,couleur,client,employe 
                           WHERE modele.idmarque=marque.idmark AND vente.voiture=voiture.idvoiture and voiture.model=modele.idmod and voiture.marque=marque.idmark and voiture.couleur=couleur.idcolor and vente.employ=employe.idempl and vente.client=client.IDclient;"
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim MyDataSet As New DataSet
        Try
            Label2.Visible = False
            adapter.Fill(MyDataSet, cmd.CommandText)
            DataGridView1.DataSource = MyDataSet.Tables(cmd.CommandText)
        Catch ex As Exception
            MessageBox.Show("!" & ex.Message)
        End Try
        conn.Close()

        affich = 4
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        PanelMod.Visible = False
        Panel1.Visible = True


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        PanelEmp.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles ButtonAddMod.Click

        Try
            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "SELECT idmark FROM marque WHERE libmark= '" + ComboBoxMrk1.Text + "'"
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

            ComboBoxMrk1.Text = ""
            TextBoxMod.Clear()
        Catch ex As Exception
            MessageBox.Show("Un problème est survenu: " & ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If affich = 1 Then
            TextBoxSrch.Clear()
            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM client"
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim MyDataSet As New DataSet
            Try
                Label2.Visible = False
                adapter.Fill(MyDataSet, cmd.CommandText)
                DataGridView1.DataSource = MyDataSet.Tables(cmd.CommandText)
            Catch ex As Exception
                MessageBox.Show("!" & ex.Message)
            End Try

            conn.Close()
            TextBoxSrch.Clear()
            affich = 1
        ElseIf affich = 2 Then
            TextBoxSrch.Clear()

            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM employe"
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim MyDataSet As New DataSet
            Try
                Label2.Visible = False
                adapter.Fill(MyDataSet, cmd.CommandText)
                DataGridView1.DataSource = MyDataSet.Tables(cmd.CommandText)
            Catch ex As Exception
                MessageBox.Show("!" & ex.Message)
            End Try
            conn.Close()
            affich = 2
        ElseIf affich = 3 Then
            TextBoxSrch.Clear()

            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "SELECT modele.idmod,modele.libmod,marque.libmark FROM marque,modele 
                                WHERE modele.idmarque=marque.idmark;"
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim MyDataSet As New DataSet
            Try
                Label2.Visible = False
                adapter.Fill(MyDataSet, cmd.CommandText)
                DataGridView1.DataSource = MyDataSet.Tables(cmd.CommandText)
            Catch ex As Exception
                MessageBox.Show("!" & ex.Message)
            End Try
            conn.Close()

            affich = 3
        ElseIf affich = 4 Then


        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles ButtonAddEmp.Click
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

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles ButtonAddClt.Click

        Try
            Opencon()
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO client (nom,prenom,Telephone,Adresse) VALUES('" & TextBoxNomCl.Text & "',
            '" & TextBoxPrenCl.Text & "','" & TextBoxTelCl.Text & "','" & TextBoxAdrCl.Text & "')"
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show("Un problème est survenu: Marque dejas enregistrée " & ex.Message)
        End Try
        conn.Close()

        TextBoxAdrCl.Clear()
        TextBoxPrenCl.Clear()
        TextBoxNomCl.Clear()
        TextBoxTelCl.Clear()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Panelclit.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

    End Sub
    Dim modif As String
    Dim libmark As String
    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        If DataGridView1.SelectedRows.Count > 0 Then

            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            Select Case affich
                Case 1
                    Panelclit.Visible = True
                    TextBoxNomCl.Text = row.Cells("nom").Value.ToString
                    TextBoxPrenCl.Text = row.Cells("prenom").Value.ToString
                    TextBoxTelCl.Text = row.Cells("Telephone").Value.ToString
                    TextBoxAdrCl.Text = row.Cells("Adresse").Value.ToString


                Case 2
                    PanelEmp.Visible = True
                    TextBoxNom.Text = row.Cells("nom").Value.ToString
                    TextBoxPren.Text = row.Cells("prenom").Value.ToString
                    TextBoxTel.Text = row.Cells("Téléphone").Value.ToString
                    TextBoxAdr.Text = row.Cells("Adresse").Value.ToString
                Case 3
                    PanelMod.Visible = True
                    ComboBoxMrk1.Text = row.Cells("libmark").Value.ToString
                    libmark = row.Cells("libmark").Value.ToString
                    TextBoxMod.Text = row.Cells("libmod").Value.ToString
                    modif = row.Cells("idmod").Value.ToString
                    ButtonAddMod.Enabled = False
                    ButtonAddMod.BackColor = Color.Gainsboro
                Case 4
                    Enregistrement.Show()
                Case Else


            End Select
        End If
    End Sub

    Private Sub ButtonModifMod_Click(sender As Object, e As EventArgs) Handles ButtonModifMod.Click
        Opencon()
        cmd.Connection = conn
        cmd.CommandText = "select idmark from marque where libmark='" & ComboBoxMrk1.Text & "'"
        reader = cmd.ExecuteReader()
        While reader.Read()
            ident = reader("idmark")
        End While

        conn.Close()
        Opencon()
        cmd.Connection = conn
        cmd.CommandText = "update modele set idmarque='" & ident & "', libmod='" & TextBoxMod.Text & "' where idmod='" & modif & "'"
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
End Class