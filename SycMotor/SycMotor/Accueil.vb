Public Class Accueil
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub MenuResg_Click(sender As Object, e As EventArgs) Handles MenuResg.Click
        Me.Hide()
        Enregistrement.show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Enregistrement.Show()
    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click
        Me.Hide()
        Aide.Show()
    End Sub

    Private Sub SombreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SombreToolStripMenuItem.Click


    End Sub

    Private Sub AidesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AidesToolStripMenuItem.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            End
        Else

        End If
    End Sub


    Private Sub ClientsEnregistrésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientsEnregistrésToolStripMenuItem.Click
        Me.Hide()
        Afficage.Show()


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If (MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            End
        Else

        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Afficage.Show()

    End Sub
End Class