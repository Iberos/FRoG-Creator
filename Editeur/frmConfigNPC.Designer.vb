<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigNPC
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigNPC))
        Me.lst_NPCs = New System.Windows.Forms.ListBox()
        Me.grp_NPCList = New System.Windows.Forms.GroupBox()
        Me.grp_NPCConfig = New System.Windows.Forms.GroupBox()
        Me.tc_NPCConfig = New System.Windows.Forms.TabControl()
        Me.tp_NPCMovement = New System.Windows.Forms.TabPage()
        Me.cmb_NPCVelocity = New System.Windows.Forms.ComboBox()
        Me.lbl_NPCVelocity = New System.Windows.Forms.Label()
        Me.grp_customMovement = New System.Windows.Forms.GroupBox()
        Me.cmb_EnableNPCMovements = New System.Windows.Forms.ComboBox()
        Me.btn_addNPCMovement = New System.Windows.Forms.Button()
        Me.cb_loopNPCMovement = New System.Windows.Forms.CheckBox()
        Me.list_customNPCMovement = New System.Windows.Forms.ListBox()
        Me.rdbtn_perimeter = New System.Windows.Forms.RadioButton()
        Me.rdbtn_custom = New System.Windows.Forms.RadioButton()
        Me.rdbtn_rand = New System.Windows.Forms.RadioButton()
        Me.rdbtn_static = New System.Windows.Forms.RadioButton()
        Me.tp_NPCStatus = New System.Windows.Forms.TabPage()
        Me.btn_NPCSelect = New System.Windows.Forms.Button()
        Me.rb_NPCFriendly = New System.Windows.Forms.RadioButton()
        Me.rb_NPCAggressive = New System.Windows.Forms.RadioButton()
        Me.rb_NPCPassive = New System.Windows.Forms.RadioButton()
        Me.cb_NPCInvicible = New System.Windows.Forms.CheckBox()
        Me.grp_NPCStatus = New System.Windows.Forms.GroupBox()
        Me.grp_NPCAggresiveArea = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pic_NPCCasesArea = New System.Windows.Forms.PictureBox()
        Me.grp_NPCList.SuspendLayout()
        Me.grp_NPCConfig.SuspendLayout()
        Me.tc_NPCConfig.SuspendLayout()
        Me.tp_NPCMovement.SuspendLayout()
        Me.grp_customMovement.SuspendLayout()
        Me.tp_NPCStatus.SuspendLayout()
        Me.grp_NPCStatus.SuspendLayout()
        Me.grp_NPCAggresiveArea.SuspendLayout()
        CType(Me.pic_NPCCasesArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst_NPCs
        '
        Me.lst_NPCs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_NPCs.FormattingEnabled = True
        Me.lst_NPCs.Location = New System.Drawing.Point(3, 16)
        Me.lst_NPCs.Name = "lst_NPCs"
        Me.lst_NPCs.Size = New System.Drawing.Size(229, 453)
        Me.lst_NPCs.TabIndex = 1
        '
        'grp_NPCList
        '
        Me.grp_NPCList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grp_NPCList.Controls.Add(Me.lst_NPCs)
        Me.grp_NPCList.Location = New System.Drawing.Point(12, 12)
        Me.grp_NPCList.Name = "grp_NPCList"
        Me.grp_NPCList.Size = New System.Drawing.Size(235, 472)
        Me.grp_NPCList.TabIndex = 2
        Me.grp_NPCList.TabStop = False
        Me.grp_NPCList.Text = "Liste de PNJs"
        '
        'grp_NPCConfig
        '
        Me.grp_NPCConfig.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_NPCConfig.Controls.Add(Me.tc_NPCConfig)
        Me.grp_NPCConfig.Location = New System.Drawing.Point(253, 12)
        Me.grp_NPCConfig.Name = "grp_NPCConfig"
        Me.grp_NPCConfig.Size = New System.Drawing.Size(418, 436)
        Me.grp_NPCConfig.TabIndex = 3
        Me.grp_NPCConfig.TabStop = False
        Me.grp_NPCConfig.Text = "Configurations"
        '
        'tc_NPCConfig
        '
        Me.tc_NPCConfig.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_NPCConfig.Controls.Add(Me.tp_NPCMovement)
        Me.tc_NPCConfig.Controls.Add(Me.tp_NPCStatus)
        Me.tc_NPCConfig.Location = New System.Drawing.Point(6, 19)
        Me.tc_NPCConfig.Name = "tc_NPCConfig"
        Me.tc_NPCConfig.SelectedIndex = 0
        Me.tc_NPCConfig.Size = New System.Drawing.Size(410, 411)
        Me.tc_NPCConfig.TabIndex = 0
        '
        'tp_NPCMovement
        '
        Me.tp_NPCMovement.Controls.Add(Me.cmb_NPCVelocity)
        Me.tp_NPCMovement.Controls.Add(Me.lbl_NPCVelocity)
        Me.tp_NPCMovement.Controls.Add(Me.grp_customMovement)
        Me.tp_NPCMovement.Controls.Add(Me.rdbtn_perimeter)
        Me.tp_NPCMovement.Controls.Add(Me.rdbtn_custom)
        Me.tp_NPCMovement.Controls.Add(Me.rdbtn_rand)
        Me.tp_NPCMovement.Controls.Add(Me.rdbtn_static)
        Me.tp_NPCMovement.Location = New System.Drawing.Point(4, 22)
        Me.tp_NPCMovement.Name = "tp_NPCMovement"
        Me.tp_NPCMovement.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_NPCMovement.Size = New System.Drawing.Size(402, 385)
        Me.tp_NPCMovement.TabIndex = 0
        Me.tp_NPCMovement.Text = "Déplacements"
        Me.tp_NPCMovement.UseVisualStyleBackColor = True
        '
        'cmb_NPCVelocity
        '
        Me.cmb_NPCVelocity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmb_NPCVelocity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_NPCVelocity.Enabled = False
        Me.cmb_NPCVelocity.FormattingEnabled = True
        Me.cmb_NPCVelocity.Items.AddRange(New Object() {"Lente", "Moyenne", "Rapide", "Trés rapide"})
        Me.cmb_NPCVelocity.Location = New System.Drawing.Point(21, 167)
        Me.cmb_NPCVelocity.Name = "cmb_NPCVelocity"
        Me.cmb_NPCVelocity.Size = New System.Drawing.Size(133, 21)
        Me.cmb_NPCVelocity.TabIndex = 10
        '
        'lbl_NPCVelocity
        '
        Me.lbl_NPCVelocity.AutoSize = True
        Me.lbl_NPCVelocity.Location = New System.Drawing.Point(18, 151)
        Me.lbl_NPCVelocity.Name = "lbl_NPCVelocity"
        Me.lbl_NPCVelocity.Size = New System.Drawing.Size(126, 13)
        Me.lbl_NPCVelocity.TabIndex = 11
        Me.lbl_NPCVelocity.Text = "Vitesse de déplacement :"
        '
        'grp_customMovement
        '
        Me.grp_customMovement.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_customMovement.Controls.Add(Me.cmb_EnableNPCMovements)
        Me.grp_customMovement.Controls.Add(Me.btn_addNPCMovement)
        Me.grp_customMovement.Controls.Add(Me.cb_loopNPCMovement)
        Me.grp_customMovement.Controls.Add(Me.list_customNPCMovement)
        Me.grp_customMovement.Enabled = False
        Me.grp_customMovement.Location = New System.Drawing.Point(173, 15)
        Me.grp_customMovement.Name = "grp_customMovement"
        Me.grp_customMovement.Size = New System.Drawing.Size(226, 355)
        Me.grp_customMovement.TabIndex = 9
        Me.grp_customMovement.TabStop = False
        Me.grp_customMovement.Text = "Déplacements personnalisés"
        '
        'cmb_EnableNPCMovements
        '
        Me.cmb_EnableNPCMovements.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmb_EnableNPCMovements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EnableNPCMovements.FormattingEnabled = True
        Me.cmb_EnableNPCMovements.Items.AddRange(New Object() {"Haut", "Bas", "Droite", "Gauche"})
        Me.cmb_EnableNPCMovements.Location = New System.Drawing.Point(6, 289)
        Me.cmb_EnableNPCMovements.Name = "cmb_EnableNPCMovements"
        Me.cmb_EnableNPCMovements.Size = New System.Drawing.Size(133, 21)
        Me.cmb_EnableNPCMovements.TabIndex = 9
        '
        'btn_addNPCMovement
        '
        Me.btn_addNPCMovement.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_addNPCMovement.Location = New System.Drawing.Point(145, 289)
        Me.btn_addNPCMovement.Name = "btn_addNPCMovement"
        Me.btn_addNPCMovement.Size = New System.Drawing.Size(75, 21)
        Me.btn_addNPCMovement.TabIndex = 8
        Me.btn_addNPCMovement.Text = "Ajouter"
        Me.btn_addNPCMovement.UseVisualStyleBackColor = True
        '
        'cb_loopNPCMovement
        '
        Me.cb_loopNPCMovement.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_loopNPCMovement.AutoSize = True
        Me.cb_loopNPCMovement.Location = New System.Drawing.Point(45, 328)
        Me.cb_loopNPCMovement.Name = "cb_loopNPCMovement"
        Me.cb_loopNPCMovement.Size = New System.Drawing.Size(139, 17)
        Me.cb_loopNPCMovement.TabIndex = 7
        Me.cb_loopNPCMovement.Text = "Répéter le déplacement"
        Me.cb_loopNPCMovement.UseVisualStyleBackColor = True
        '
        'list_customNPCMovement
        '
        Me.list_customNPCMovement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.list_customNPCMovement.FormattingEnabled = True
        Me.list_customNPCMovement.Location = New System.Drawing.Point(6, 22)
        Me.list_customNPCMovement.Name = "list_customNPCMovement"
        Me.list_customNPCMovement.Size = New System.Drawing.Size(214, 251)
        Me.list_customNPCMovement.TabIndex = 6
        '
        'rdbtn_perimeter
        '
        Me.rdbtn_perimeter.AutoSize = True
        Me.rdbtn_perimeter.Location = New System.Drawing.Point(21, 75)
        Me.rdbtn_perimeter.Name = "rdbtn_perimeter"
        Me.rdbtn_perimeter.Size = New System.Drawing.Size(69, 17)
        Me.rdbtn_perimeter.TabIndex = 8
        Me.rdbtn_perimeter.Text = "Périmètre"
        Me.rdbtn_perimeter.UseVisualStyleBackColor = True
        '
        'rdbtn_custom
        '
        Me.rdbtn_custom.AutoSize = True
        Me.rdbtn_custom.Location = New System.Drawing.Point(21, 98)
        Me.rdbtn_custom.Name = "rdbtn_custom"
        Me.rdbtn_custom.Size = New System.Drawing.Size(85, 17)
        Me.rdbtn_custom.TabIndex = 7
        Me.rdbtn_custom.Text = "Personnalisé"
        Me.rdbtn_custom.UseVisualStyleBackColor = True
        '
        'rdbtn_rand
        '
        Me.rdbtn_rand.AutoSize = True
        Me.rdbtn_rand.Location = New System.Drawing.Point(21, 52)
        Me.rdbtn_rand.Name = "rdbtn_rand"
        Me.rdbtn_rand.Size = New System.Drawing.Size(66, 17)
        Me.rdbtn_rand.TabIndex = 5
        Me.rdbtn_rand.Text = "Aléatoire"
        Me.rdbtn_rand.UseVisualStyleBackColor = True
        '
        'rdbtn_static
        '
        Me.rdbtn_static.AutoSize = True
        Me.rdbtn_static.Checked = True
        Me.rdbtn_static.Location = New System.Drawing.Point(21, 29)
        Me.rdbtn_static.Name = "rdbtn_static"
        Me.rdbtn_static.Size = New System.Drawing.Size(66, 17)
        Me.rdbtn_static.TabIndex = 4
        Me.rdbtn_static.TabStop = True
        Me.rdbtn_static.Text = "Immobile"
        Me.rdbtn_static.UseVisualStyleBackColor = True
        '
        'tp_NPCStatus
        '
        Me.tp_NPCStatus.Controls.Add(Me.grp_NPCAggresiveArea)
        Me.tp_NPCStatus.Controls.Add(Me.grp_NPCStatus)
        Me.tp_NPCStatus.Location = New System.Drawing.Point(4, 22)
        Me.tp_NPCStatus.Name = "tp_NPCStatus"
        Me.tp_NPCStatus.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_NPCStatus.Size = New System.Drawing.Size(402, 385)
        Me.tp_NPCStatus.TabIndex = 1
        Me.tp_NPCStatus.Text = "Statut"
        Me.tp_NPCStatus.UseVisualStyleBackColor = True
        '
        'btn_NPCSelect
        '
        Me.btn_NPCSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_NPCSelect.Location = New System.Drawing.Point(512, 454)
        Me.btn_NPCSelect.Name = "btn_NPCSelect"
        Me.btn_NPCSelect.Size = New System.Drawing.Size(159, 27)
        Me.btn_NPCSelect.TabIndex = 0
        Me.btn_NPCSelect.Text = "Selectionner"
        Me.btn_NPCSelect.UseVisualStyleBackColor = True
        '
        'rb_NPCFriendly
        '
        Me.rb_NPCFriendly.AutoSize = True
        Me.rb_NPCFriendly.Location = New System.Drawing.Point(28, 65)
        Me.rb_NPCFriendly.Name = "rb_NPCFriendly"
        Me.rb_NPCFriendly.Size = New System.Drawing.Size(56, 17)
        Me.rb_NPCFriendly.TabIndex = 12
        Me.rb_NPCFriendly.Text = "Amical"
        Me.rb_NPCFriendly.UseVisualStyleBackColor = True
        '
        'rb_NPCAggressive
        '
        Me.rb_NPCAggressive.AutoSize = True
        Me.rb_NPCAggressive.Location = New System.Drawing.Point(28, 42)
        Me.rb_NPCAggressive.Name = "rb_NPCAggressive"
        Me.rb_NPCAggressive.Size = New System.Drawing.Size(62, 17)
        Me.rb_NPCAggressive.TabIndex = 10
        Me.rb_NPCAggressive.Text = "Agressif"
        Me.rb_NPCAggressive.UseVisualStyleBackColor = True
        '
        'rb_NPCPassive
        '
        Me.rb_NPCPassive.AutoSize = True
        Me.rb_NPCPassive.Checked = True
        Me.rb_NPCPassive.Location = New System.Drawing.Point(28, 19)
        Me.rb_NPCPassive.Name = "rb_NPCPassive"
        Me.rb_NPCPassive.Size = New System.Drawing.Size(53, 17)
        Me.rb_NPCPassive.TabIndex = 9
        Me.rb_NPCPassive.TabStop = True
        Me.rb_NPCPassive.Text = "Passif"
        Me.rb_NPCPassive.UseVisualStyleBackColor = True
        '
        'cb_NPCInvicible
        '
        Me.cb_NPCInvicible.AutoSize = True
        Me.cb_NPCInvicible.Location = New System.Drawing.Point(28, 102)
        Me.cb_NPCInvicible.Name = "cb_NPCInvicible"
        Me.cb_NPCInvicible.Size = New System.Drawing.Size(71, 17)
        Me.cb_NPCInvicible.TabIndex = 13
        Me.cb_NPCInvicible.Text = "Invincible"
        Me.cb_NPCInvicible.UseVisualStyleBackColor = True
        '
        'grp_NPCStatus
        '
        Me.grp_NPCStatus.Controls.Add(Me.cb_NPCInvicible)
        Me.grp_NPCStatus.Controls.Add(Me.rb_NPCPassive)
        Me.grp_NPCStatus.Controls.Add(Me.rb_NPCFriendly)
        Me.grp_NPCStatus.Controls.Add(Me.rb_NPCAggressive)
        Me.grp_NPCStatus.Location = New System.Drawing.Point(18, 15)
        Me.grp_NPCStatus.Name = "grp_NPCStatus"
        Me.grp_NPCStatus.Size = New System.Drawing.Size(120, 134)
        Me.grp_NPCStatus.TabIndex = 14
        Me.grp_NPCStatus.TabStop = False
        '
        'grp_NPCAggresiveArea
        '
        Me.grp_NPCAggresiveArea.Controls.Add(Me.pic_NPCCasesArea)
        Me.grp_NPCAggresiveArea.Controls.Add(Me.TextBox1)
        Me.grp_NPCAggresiveArea.Controls.Add(Me.Label1)
        Me.grp_NPCAggresiveArea.Enabled = False
        Me.grp_NPCAggresiveArea.Location = New System.Drawing.Point(159, 15)
        Me.grp_NPCAggresiveArea.Name = "grp_NPCAggresiveArea"
        Me.grp_NPCAggresiveArea.Size = New System.Drawing.Size(223, 134)
        Me.grp_NPCAggresiveArea.TabIndex = 15
        Me.grp_NPCAggresiveArea.TabStop = False
        Me.grp_NPCAggresiveArea.Text = "Zone d'agression"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Distance en cases :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(116, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(54, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "5"
        '
        'pic_NPCCasesArea
        '
        Me.pic_NPCCasesArea.Image = CType(resources.GetObject("pic_NPCCasesArea.Image"), System.Drawing.Image)
        Me.pic_NPCCasesArea.Location = New System.Drawing.Point(12, 55)
        Me.pic_NPCCasesArea.Name = "pic_NPCCasesArea"
        Me.pic_NPCCasesArea.Size = New System.Drawing.Size(123, 66)
        Me.pic_NPCCasesArea.TabIndex = 2
        Me.pic_NPCCasesArea.TabStop = False
        '
        'frmConfigNPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 496)
        Me.Controls.Add(Me.btn_NPCSelect)
        Me.Controls.Add(Me.grp_NPCConfig)
        Me.Controls.Add(Me.grp_NPCList)
        Me.MinimumSize = New System.Drawing.Size(600, 450)
        Me.Name = "frmConfigNPC"
        Me.Text = "Configurateur de PNJs"
        Me.grp_NPCList.ResumeLayout(False)
        Me.grp_NPCConfig.ResumeLayout(False)
        Me.tc_NPCConfig.ResumeLayout(False)
        Me.tp_NPCMovement.ResumeLayout(False)
        Me.tp_NPCMovement.PerformLayout()
        Me.grp_customMovement.ResumeLayout(False)
        Me.grp_customMovement.PerformLayout()
        Me.tp_NPCStatus.ResumeLayout(False)
        Me.grp_NPCStatus.ResumeLayout(False)
        Me.grp_NPCStatus.PerformLayout()
        Me.grp_NPCAggresiveArea.ResumeLayout(False)
        Me.grp_NPCAggresiveArea.PerformLayout()
        CType(Me.pic_NPCCasesArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lst_NPCs As System.Windows.Forms.ListBox
    Friend WithEvents grp_NPCList As System.Windows.Forms.GroupBox
    Friend WithEvents grp_NPCConfig As System.Windows.Forms.GroupBox
    Friend WithEvents btn_NPCSelect As System.Windows.Forms.Button
    Friend WithEvents tc_NPCConfig As System.Windows.Forms.TabControl
    Friend WithEvents tp_NPCMovement As System.Windows.Forms.TabPage
    Friend WithEvents grp_customMovement As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_EnableNPCMovements As System.Windows.Forms.ComboBox
    Friend WithEvents btn_addNPCMovement As System.Windows.Forms.Button
    Friend WithEvents cb_loopNPCMovement As System.Windows.Forms.CheckBox
    Friend WithEvents list_customNPCMovement As System.Windows.Forms.ListBox
    Friend WithEvents rdbtn_perimeter As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtn_custom As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtn_rand As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtn_static As System.Windows.Forms.RadioButton
    Friend WithEvents tp_NPCStatus As System.Windows.Forms.TabPage
    Friend WithEvents cmb_NPCVelocity As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_NPCVelocity As System.Windows.Forms.Label
    Friend WithEvents grp_NPCAggresiveArea As System.Windows.Forms.GroupBox
    Friend WithEvents grp_NPCStatus As System.Windows.Forms.GroupBox
    Friend WithEvents cb_NPCInvicible As System.Windows.Forms.CheckBox
    Friend WithEvents rb_NPCPassive As System.Windows.Forms.RadioButton
    Friend WithEvents rb_NPCFriendly As System.Windows.Forms.RadioButton
    Friend WithEvents rb_NPCAggressive As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pic_NPCCasesArea As System.Windows.Forms.PictureBox
End Class
