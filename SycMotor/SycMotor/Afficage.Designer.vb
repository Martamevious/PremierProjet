<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Afficage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Afficage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelEmp = New System.Windows.Forms.Panel()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.PanelMod = New System.Windows.Forms.Panel()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.ButtonModifMod = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxMod = New System.Windows.Forms.TextBox()
        Me.ComboBoxMrk1 = New System.Windows.Forms.ComboBox()
        Me.ButtonAddMod = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonModifEmp = New System.Windows.Forms.Button()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.TextBoxTel = New System.Windows.Forms.TextBox()
        Me.TextBoxAdr = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxPren = New System.Windows.Forms.TextBox()
        Me.ButtonAddEmp = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TextBoxSrch = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Panelclit = New System.Windows.Forms.Panel()
        Me.TextBoxAdrCl = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxTelCl = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxPrenCl = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxNomCl = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.ButtonModifClt = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonAddClt = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.PanelEmp.SuspendLayout()
        Me.PanelMod.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelclit.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.PanelEmp)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 375)
        Me.Panel1.TabIndex = 0
        '
        'PanelEmp
        '
        Me.PanelEmp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelEmp.Controls.Add(Me.Button12)
        Me.PanelEmp.Controls.Add(Me.ButtonModifEmp)
        Me.PanelEmp.Controls.Add(Me.TextBoxNom)
        Me.PanelEmp.Controls.Add(Me.TextBoxTel)
        Me.PanelEmp.Controls.Add(Me.TextBoxAdr)
        Me.PanelEmp.Controls.Add(Me.Label11)
        Me.PanelEmp.Controls.Add(Me.Label12)
        Me.PanelEmp.Controls.Add(Me.Label8)
        Me.PanelEmp.Controls.Add(Me.TextBoxPren)
        Me.PanelEmp.Controls.Add(Me.ButtonAddEmp)
        Me.PanelEmp.Controls.Add(Me.Label9)
        Me.PanelEmp.Controls.Add(Me.Label10)
        Me.PanelEmp.Location = New System.Drawing.Point(0, 0)
        Me.PanelEmp.Name = "PanelEmp"
        Me.PanelEmp.Size = New System.Drawing.Size(256, 375)
        Me.PanelEmp.TabIndex = 17
        Me.PanelEmp.Visible = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Sienna
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button12.FlatAppearance.BorderSize = 2
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.White
        Me.Button12.Location = New System.Drawing.Point(83, 322)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(102, 28)
        Me.Button12.TabIndex = 27
        Me.Button12.Text = "Terminer"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'PanelMod
        '
        Me.PanelMod.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMod.Controls.Add(Me.Button13)
        Me.PanelMod.Controls.Add(Me.ButtonModifMod)
        Me.PanelMod.Controls.Add(Me.Label4)
        Me.PanelMod.Controls.Add(Me.TextBoxMod)
        Me.PanelMod.Controls.Add(Me.ComboBoxMrk1)
        Me.PanelMod.Controls.Add(Me.ButtonAddMod)
        Me.PanelMod.Controls.Add(Me.Label3)
        Me.PanelMod.Controls.Add(Me.Label5)
        Me.PanelMod.ForeColor = System.Drawing.Color.Black
        Me.PanelMod.Location = New System.Drawing.Point(9, 146)
        Me.PanelMod.Name = "PanelMod"
        Me.PanelMod.Size = New System.Drawing.Size(256, 375)
        Me.PanelMod.TabIndex = 16
        Me.PanelMod.Visible = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Sienna
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button13.FlatAppearance.BorderSize = 2
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.White
        Me.Button13.Location = New System.Drawing.Point(73, 318)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(102, 28)
        Me.Button13.TabIndex = 28
        Me.Button13.Text = "Terminer"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'ButtonModifMod
        '
        Me.ButtonModifMod.BackColor = System.Drawing.Color.YellowGreen
        Me.ButtonModifMod.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.ButtonModifMod.FlatAppearance.BorderSize = 2
        Me.ButtonModifMod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonModifMod.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModifMod.ForeColor = System.Drawing.Color.Navy
        Me.ButtonModifMod.Location = New System.Drawing.Point(136, 261)
        Me.ButtonModifMod.Name = "ButtonModifMod"
        Me.ButtonModifMod.Size = New System.Drawing.Size(102, 28)
        Me.ButtonModifMod.TabIndex = 27
        Me.ButtonModifMod.Text = "Modifier"
        Me.ButtonModifMod.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(54, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Gestion des Modèles"
        '
        'TextBoxMod
        '
        Me.TextBoxMod.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxMod.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMod.ForeColor = System.Drawing.Color.Navy
        Me.TextBoxMod.Location = New System.Drawing.Point(82, 159)
        Me.TextBoxMod.Name = "TextBoxMod"
        Me.TextBoxMod.Size = New System.Drawing.Size(134, 25)
        Me.TextBoxMod.TabIndex = 14
        '
        'ComboBoxMrk1
        '
        Me.ComboBoxMrk1.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBoxMrk1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMrk1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxMrk1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxMrk1.ForeColor = System.Drawing.Color.Navy
        Me.ComboBoxMrk1.FormattingEnabled = True
        Me.ComboBoxMrk1.Location = New System.Drawing.Point(82, 112)
        Me.ComboBoxMrk1.Name = "ComboBoxMrk1"
        Me.ComboBoxMrk1.Size = New System.Drawing.Size(133, 25)
        Me.ComboBoxMrk1.TabIndex = 13
        '
        'ButtonAddMod
        '
        Me.ButtonAddMod.BackColor = System.Drawing.Color.YellowGreen
        Me.ButtonAddMod.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.ButtonAddMod.FlatAppearance.BorderSize = 2
        Me.ButtonAddMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAddMod.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddMod.ForeColor = System.Drawing.Color.Black
        Me.ButtonAddMod.Location = New System.Drawing.Point(24, 261)
        Me.ButtonAddMod.Name = "ButtonAddMod"
        Me.ButtonAddMod.Size = New System.Drawing.Size(94, 28)
        Me.ButtonAddMod.TabIndex = 15
        Me.ButtonAddMod.Text = "Ajouter"
        Me.ButtonAddMod.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Modèle : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Marque : "
        '
        'ButtonModifEmp
        '
        Me.ButtonModifEmp.BackColor = System.Drawing.Color.YellowGreen
        Me.ButtonModifEmp.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.ButtonModifEmp.FlatAppearance.BorderSize = 2
        Me.ButtonModifEmp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonModifEmp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModifEmp.ForeColor = System.Drawing.Color.Navy
        Me.ButtonModifEmp.Location = New System.Drawing.Point(136, 280)
        Me.ButtonModifEmp.Name = "ButtonModifEmp"
        Me.ButtonModifEmp.Size = New System.Drawing.Size(102, 28)
        Me.ButtonModifEmp.TabIndex = 26
        Me.ButtonModifEmp.Text = "Modifier"
        Me.ButtonModifEmp.UseVisualStyleBackColor = False
        '
        'TextBoxNom
        '
        Me.TextBoxNom.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxNom.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNom.ForeColor = System.Drawing.Color.Navy
        Me.TextBoxNom.Location = New System.Drawing.Point(91, 100)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(134, 25)
        Me.TextBoxNom.TabIndex = 21
        '
        'TextBoxTel
        '
        Me.TextBoxTel.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxTel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTel.ForeColor = System.Drawing.Color.Navy
        Me.TextBoxTel.Location = New System.Drawing.Point(91, 164)
        Me.TextBoxTel.Name = "TextBoxTel"
        Me.TextBoxTel.Size = New System.Drawing.Size(134, 25)
        Me.TextBoxTel.TabIndex = 23
        '
        'TextBoxAdr
        '
        Me.TextBoxAdr.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxAdr.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAdr.ForeColor = System.Drawing.Color.Navy
        Me.TextBoxAdr.Location = New System.Drawing.Point(91, 195)
        Me.TextBoxAdr.Name = "TextBoxAdr"
        Me.TextBoxAdr.Size = New System.Drawing.Size(134, 25)
        Me.TextBoxAdr.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(13, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 17)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Adresse : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(13, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 17)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Telephone : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(55, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Gestion des employés"
        '
        'TextBoxPren
        '
        Me.TextBoxPren.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxPren.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPren.ForeColor = System.Drawing.Color.Navy
        Me.TextBoxPren.Location = New System.Drawing.Point(91, 131)
        Me.TextBoxPren.Name = "TextBoxPren"
        Me.TextBoxPren.Size = New System.Drawing.Size(134, 25)
        Me.TextBoxPren.TabIndex = 22
        '
        'ButtonAddEmp
        '
        Me.ButtonAddEmp.BackColor = System.Drawing.Color.YellowGreen
        Me.ButtonAddEmp.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.ButtonAddEmp.FlatAppearance.BorderSize = 2
        Me.ButtonAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAddEmp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddEmp.ForeColor = System.Drawing.Color.Black
        Me.ButtonAddEmp.Location = New System.Drawing.Point(16, 280)
        Me.ButtonAddEmp.Name = "ButtonAddEmp"
        Me.ButtonAddEmp.Size = New System.Drawing.Size(102, 28)
        Me.ButtonAddEmp.TabIndex = 25
        Me.ButtonAddEmp.Text = "Ajouter"
        Me.ButtonAddEmp.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(13, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Prenom : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(13, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Nom : "
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(29, 306)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(194, 40)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Les ventes"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(29, 234)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(194, 40)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Modèles disponibles"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(29, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(194, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Liste des employés"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(29, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Liste des Clients enregistrés"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Beige
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(284, 146)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.Size = New System.Drawing.Size(643, 375)
        Me.DataGridView1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 527)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(946, 47)
        Me.Panel2.TabIndex = 5
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Location = New System.Drawing.Point(0, 136)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(925, 4)
        Me.Panel3.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Navy
        Me.Panel4.Location = New System.Drawing.Point(274, 139)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(4, 364)
        Me.Panel4.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Beige
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(420, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(351, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Vos enregistrements devraient s'afficher ici..."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Beige
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(896, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(946, 48)
        Me.Panel5.TabIndex = 11
        '
        'TextBoxSrch
        '
        Me.TextBoxSrch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBoxSrch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.TextBoxSrch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSrch.Location = New System.Drawing.Point(591, 90)
        Me.TextBoxSrch.Multiline = True
        Me.TextBoxSrch.Name = "TextBoxSrch"
        Me.TextBoxSrch.Size = New System.Drawing.Size(197, 27)
        Me.TextBoxSrch.TabIndex = 12
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.ForestGreen
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Beige
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(785, 90)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 27)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Rechercher"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Gainsboro
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Beige
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(49, 90)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(94, 27)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "Ajouter"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Firebrick
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Beige
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(180, 90)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(98, 27)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "Supprimer"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Brown
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(162, 90)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 18
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(23, 90)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(465, 90)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Gainsboro
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.Beige
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button14.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.Black
        Me.Button14.Location = New System.Drawing.Point(491, 90)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(94, 27)
        Me.Button14.TabIndex = 20
        Me.Button14.Text = "Actualiser"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Panelclit
        '
        Me.Panelclit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panelclit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panelclit.Controls.Add(Me.TextBoxAdrCl)
        Me.Panelclit.Controls.Add(Me.Label7)
        Me.Panelclit.Controls.Add(Me.TextBoxTelCl)
        Me.Panelclit.Controls.Add(Me.Label13)
        Me.Panelclit.Controls.Add(Me.TextBoxPrenCl)
        Me.Panelclit.Controls.Add(Me.Label14)
        Me.Panelclit.Controls.Add(Me.TextBoxNomCl)
        Me.Panelclit.Controls.Add(Me.Label15)
        Me.Panelclit.Controls.Add(Me.Button15)
        Me.Panelclit.Controls.Add(Me.ButtonModifClt)
        Me.Panelclit.Controls.Add(Me.Label6)
        Me.Panelclit.Controls.Add(Me.ButtonAddClt)
        Me.Panelclit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panelclit.ForeColor = System.Drawing.Color.Black
        Me.Panelclit.Location = New System.Drawing.Point(12, 146)
        Me.Panelclit.Name = "Panelclit"
        Me.Panelclit.Size = New System.Drawing.Size(256, 375)
        Me.Panelclit.TabIndex = 29
        Me.Panelclit.Visible = False
        '
        'TextBoxAdrCl
        '
        Me.TextBoxAdrCl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAdrCl.Location = New System.Drawing.Point(89, 205)
        Me.TextBoxAdrCl.Name = "TextBoxAdrCl"
        Me.TextBoxAdrCl.Size = New System.Drawing.Size(138, 25)
        Me.TextBoxAdrCl.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Adresse : "
        '
        'TextBoxTelCl
        '
        Me.TextBoxTelCl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTelCl.Location = New System.Drawing.Point(89, 164)
        Me.TextBoxTelCl.Name = "TextBoxTelCl"
        Me.TextBoxTelCl.Size = New System.Drawing.Size(138, 25)
        Me.TextBoxTelCl.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 167)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 17)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Téléphone : "
        '
        'TextBoxPrenCl
        '
        Me.TextBoxPrenCl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrenCl.Location = New System.Drawing.Point(89, 126)
        Me.TextBoxPrenCl.Name = "TextBoxPrenCl"
        Me.TextBoxPrenCl.Size = New System.Drawing.Size(138, 25)
        Me.TextBoxPrenCl.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 17)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Prenom : "
        '
        'TextBoxNomCl
        '
        Me.TextBoxNomCl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNomCl.Location = New System.Drawing.Point(89, 91)
        Me.TextBoxNomCl.Name = "TextBoxNomCl"
        Me.TextBoxNomCl.Size = New System.Drawing.Size(138, 25)
        Me.TextBoxNomCl.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 17)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Nom : "
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Sienna
        Me.Button15.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button15.FlatAppearance.BorderSize = 2
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.White
        Me.Button15.Location = New System.Drawing.Point(73, 318)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(102, 28)
        Me.Button15.TabIndex = 28
        Me.Button15.Text = "Terminer"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'ButtonModifClt
        '
        Me.ButtonModifClt.BackColor = System.Drawing.Color.YellowGreen
        Me.ButtonModifClt.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.ButtonModifClt.FlatAppearance.BorderSize = 2
        Me.ButtonModifClt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonModifClt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModifClt.ForeColor = System.Drawing.Color.Navy
        Me.ButtonModifClt.Location = New System.Drawing.Point(136, 261)
        Me.ButtonModifClt.Name = "ButtonModifClt"
        Me.ButtonModifClt.Size = New System.Drawing.Size(102, 28)
        Me.ButtonModifClt.TabIndex = 27
        Me.ButtonModifClt.Text = "Modifier"
        Me.ButtonModifClt.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(60, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Gestion des clients"
        '
        'ButtonAddClt
        '
        Me.ButtonAddClt.BackColor = System.Drawing.Color.YellowGreen
        Me.ButtonAddClt.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.ButtonAddClt.FlatAppearance.BorderSize = 2
        Me.ButtonAddClt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAddClt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddClt.ForeColor = System.Drawing.Color.Black
        Me.ButtonAddClt.Location = New System.Drawing.Point(24, 261)
        Me.ButtonAddClt.Name = "ButtonAddClt"
        Me.ButtonAddClt.Size = New System.Drawing.Size(94, 28)
        Me.ButtonAddClt.TabIndex = 15
        Me.ButtonAddClt.Text = "Ajouter"
        Me.ButtonAddClt.UseVisualStyleBackColor = False
        '
        'Afficage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(939, 574)
        Me.Controls.Add(Me.PanelMod)
        Me.Controls.Add(Me.Panelclit)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBoxSrch)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Afficage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Afficage"
        Me.Panel1.ResumeLayout(False)
        Me.PanelEmp.ResumeLayout(False)
        Me.PanelEmp.PerformLayout()
        Me.PanelMod.ResumeLayout(False)
        Me.PanelMod.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelclit.ResumeLayout(False)
        Me.Panelclit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextBoxSrch As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents PanelMod As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxMod As TextBox
    Friend WithEvents ComboBoxMrk1 As ComboBox
    Friend WithEvents ButtonAddMod As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonModifMod As Button
    Friend WithEvents PanelEmp As Panel
    Friend WithEvents ButtonModifEmp As Button
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents TextBoxTel As TextBox
    Friend WithEvents TextBoxAdr As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxPren As TextBox
    Friend WithEvents ButtonAddEmp As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button14 As Button
    Friend WithEvents Panelclit As Panel
    Friend WithEvents Button15 As Button
    Friend WithEvents ButtonModifClt As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonAddClt As Button
    Friend WithEvents TextBoxAdrCl As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxTelCl As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxPrenCl As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxNomCl As TextBox
    Friend WithEvents Label15 As Label
End Class
