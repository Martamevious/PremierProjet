<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class connection
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(connection))
        Me.Labelid = New System.Windows.Forms.Label()
        Me.Labelpsd = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxPwD = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Titre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Labelid
        '
        Me.Labelid.AutoSize = True
        Me.Labelid.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelid.ForeColor = System.Drawing.Color.Navy
        Me.Labelid.Location = New System.Drawing.Point(72, 215)
        Me.Labelid.Name = "Labelid"
        Me.Labelid.Size = New System.Drawing.Size(95, 20)
        Me.Labelid.TabIndex = 1
        Me.Labelid.Text = "Identifiant : "
        '
        'Labelpsd
        '
        Me.Labelpsd.AutoSize = True
        Me.Labelpsd.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelpsd.ForeColor = System.Drawing.Color.Navy
        Me.Labelpsd.Location = New System.Drawing.Point(72, 279)
        Me.Labelpsd.Name = "Labelpsd"
        Me.Labelpsd.Size = New System.Drawing.Size(114, 20)
        Me.Labelpsd.TabIndex = 2
        Me.Labelpsd.Text = "Mot de passe : "
        '
        'TextBoxID
        '
        Me.TextBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBoxID.Location = New System.Drawing.Point(76, 238)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxID.Size = New System.Drawing.Size(192, 18)
        Me.TextBoxID.TabIndex = 3
        '
        'TextBoxPwD
        '
        Me.TextBoxPwD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxPwD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBoxPwD.Location = New System.Drawing.Point(76, 302)
        Me.TextBoxPwD.MinimumSize = New System.Drawing.Size(0, 10)
        Me.TextBoxPwD.Name = "TextBoxPwD"
        Me.TextBoxPwD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(46)
        Me.TextBoxPwD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxPwD.Size = New System.Drawing.Size(192, 18)
        Me.TextBoxPwD.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(42, 333)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "                                  "
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.ForeColor = System.Drawing.Color.Navy
        Me.Titre.Location = New System.Drawing.Point(103, 21)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(141, 30)
        Me.Titre.TabIndex = 6
        Me.Titre.Text = "CONNEXION"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(117, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Menu
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(117, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 34)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Se connecter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'connection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(344, 416)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxPwD)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.Labelpsd)
        Me.Controls.Add(Me.Labelid)
        Me.Name = "connection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "connection"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Labelid As Label
    Friend WithEvents Labelpsd As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxPwD As TextBox

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxID.TextChanged

    End Sub

    Friend WithEvents Label4 As Label

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub connection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents Titre As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBoxID.Text = "" Or TextBoxPwD.Text = "") Then
            MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            opencon()

            cmd.Connection = conn
            cmd.CommandText = "SELECT userN,motPass FROM admin"
            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                Dim username As String = reader("userN")
                Dim motPass As String = reader("motPass")
                If (username = TextBoxID.Text And motPass = TextBoxPwD.Text) Then

                    Dim check As New check()
                    Me.Hide()
                    check.Show()
                Else
                    Label4.Text = "Utillisateur ou Mot de passe incorrect"
                End If
            Else
                MessageBox.Show("Aucun enregistrement trouvé")
            End If
            conn.Close()

        End If

    End Sub
End Class
