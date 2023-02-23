Public Class Connect
    Public username As String
    Public motPass As String
    Public Sub Button1_Click(sender As Object, e As EventArgs)
        If (TextBoxID.Text = "" Or TextBoxPwD.Text = "") Then
            MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Opencon()

            cmd.Connection = conn
            cmd.CommandText = "SELECT userN,motPass FROM admin"
            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                username = reader("userN")
                motPass = reader("motPass")
                If (username = TextBoxID.Text And motPass = TextBoxPwD.Text) Then

                    Dim check As New Check()
                    Me.Hide()
                    Accueil.Show()
                Else
                    Label4.Text = "Utillisateur ou Mot de passe incorrect"
                End If
            Else
                MessageBox.Show("Aucun enregistrement trouvé")
            End If
            conn.Close()

        End If

    End Sub


    Private Sub Connect_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            Me.Capture = True
            Me.Cursor = Cursors.Arrow
            Me.Tag = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If Me.Capture Then
            Dim dx As Integer = e.X - Me.Tag.X
            Dim dy As Integer = e.Y - Me.Tag.Y
            Me.Location = New Point(Me.Location.X + dx, Me.Location.Y + dy)
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
End Class