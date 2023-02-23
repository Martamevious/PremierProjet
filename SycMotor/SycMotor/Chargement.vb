Public Class Chargement
    Dim i As Integer
    Dim connect As New Connect()
    Private Sub Chargement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        LabelPercent.Text = " (" & i & "%)"
        ProgressBar1.Value = ProgressBar1.Value + 2
        i += 2

        If i = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            connect.Show()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class