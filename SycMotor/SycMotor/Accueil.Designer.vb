<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuResg = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VuesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LePersonnelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientsEnregistrésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PréferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComptesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApparenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AidesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LabelLogo = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Chocolate
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.VuesToolStripMenuItem, Me.PréferencesToolStripMenuItem, Me.AidesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(923, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuResg, Me.ModifierToolStripMenuItem, Me.EnregistrerToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'MenuResg
        '
        Me.MenuResg.Name = "MenuResg"
        Me.MenuResg.Size = New System.Drawing.Size(153, 24)
        Me.MenuResg.Text = "Nouveau"
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.ModifierToolStripMenuItem.Text = "Modifier"
        '
        'EnregistrerToolStripMenuItem
        '
        Me.EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        Me.EnregistrerToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.EnregistrerToolStripMenuItem.Text = "Enregistrer"
        '
        'VuesToolStripMenuItem
        '
        Me.VuesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LePersonnelToolStripMenuItem, Me.ClientsEnregistrésToolStripMenuItem})
        Me.VuesToolStripMenuItem.Name = "VuesToolStripMenuItem"
        Me.VuesToolStripMenuItem.Size = New System.Drawing.Size(54, 24)
        Me.VuesToolStripMenuItem.Text = "Vues"
        '
        'LePersonnelToolStripMenuItem
        '
        Me.LePersonnelToolStripMenuItem.Name = "LePersonnelToolStripMenuItem"
        Me.LePersonnelToolStripMenuItem.Size = New System.Drawing.Size(202, 24)
        Me.LePersonnelToolStripMenuItem.Text = "Le personnel"
        '
        'ClientsEnregistrésToolStripMenuItem
        '
        Me.ClientsEnregistrésToolStripMenuItem.Name = "ClientsEnregistrésToolStripMenuItem"
        Me.ClientsEnregistrésToolStripMenuItem.Size = New System.Drawing.Size(202, 24)
        Me.ClientsEnregistrésToolStripMenuItem.Text = "Clients enregistrés"
        '
        'PréferencesToolStripMenuItem
        '
        Me.PréferencesToolStripMenuItem.BackColor = System.Drawing.Color.Chocolate
        Me.PréferencesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComptesToolStripMenuItem, Me.ApparenceToolStripMenuItem})
        Me.PréferencesToolStripMenuItem.Name = "PréferencesToolStripMenuItem"
        Me.PréferencesToolStripMenuItem.Size = New System.Drawing.Size(101, 24)
        Me.PréferencesToolStripMenuItem.Text = "Préferences"
        '
        'ComptesToolStripMenuItem
        '
        Me.ComptesToolStripMenuItem.Name = "ComptesToolStripMenuItem"
        Me.ComptesToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.ComptesToolStripMenuItem.Text = "Comptes"
        '
        'ApparenceToolStripMenuItem
        '
        Me.ApparenceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SombreToolStripMenuItem})
        Me.ApparenceToolStripMenuItem.Name = "ApparenceToolStripMenuItem"
        Me.ApparenceToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.ApparenceToolStripMenuItem.Text = "Apparence"
        '
        'SombreToolStripMenuItem
        '
        Me.SombreToolStripMenuItem.Name = "SombreToolStripMenuItem"
        Me.SombreToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.SombreToolStripMenuItem.Text = "Sombre"
        '
        'AidesToolStripMenuItem
        '
        Me.AidesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CToolStripMenuItem, Me.AProposToolStripMenuItem})
        Me.AidesToolStripMenuItem.Name = "AidesToolStripMenuItem"
        Me.AidesToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.AidesToolStripMenuItem.Text = "Aides"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.CToolStripMenuItem.Text = "c"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.AProposToolStripMenuItem.Text = "A propos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(350, 194)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(233, 201)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Beige
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Location = New System.Drawing.Point(340, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(253, 69)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Nouvel enregistrement"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(421, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Copyright© 2023"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 488)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(923, 47)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Location = New System.Drawing.Point(42, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(220, 326)
        Me.Panel2.TabIndex = 5
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button6.FlatAppearance.BorderSize = 2
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(42, 96)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(138, 29)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Opérations récentes"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.PictureBox5)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Location = New System.Drawing.Point(661, 144)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(225, 326)
        Me.Panel3.TabIndex = 6
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(30, 205)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 29)
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(30, 129)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 29)
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(30, 61)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 29)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(30, 280)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 31)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button5.FlatAppearance.BorderSize = 2
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(54, 280)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(138, 31)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Quitter l'application"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(54, 205)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 29)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Supprimer"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(54, 129)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 29)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Modifier"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(54, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 29)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Recherche"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.LabelLogo)
        Me.Panel4.Location = New System.Drawing.Point(218, 45)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(501, 76)
        Me.Panel4.TabIndex = 7
        '
        'LabelLogo
        '
        Me.LabelLogo.AutoSize = True
        Me.LabelLogo.BackColor = System.Drawing.Color.White
        Me.LabelLogo.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLogo.Location = New System.Drawing.Point(128, 11)
        Me.LabelLogo.Name = "LabelLogo"
        Me.LabelLogo.Size = New System.Drawing.Size(247, 50)
        Me.LabelLogo.TabIndex = 0
        Me.LabelLogo.Text = "SYCMOTORS"
        '
        'Accueil
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = Global.SycMotor.My.MySettings.Default.tsr
        Me.ClientSize = New System.Drawing.Size(923, 535)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Accueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accueil"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuResg As ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VuesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PréferencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComptesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AidesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LePersonnelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientsEnregistrésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ApparenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents SombreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LabelLogo As Label
End Class
