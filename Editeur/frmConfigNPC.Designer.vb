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
        Me.grpNPCList = New System.Windows.Forms.GroupBox()
        Me.pnlNPCList = New System.Windows.Forms.Panel()
        Me.grpNPCConfig = New System.Windows.Forms.GroupBox()
        Me.tcNPCConfig = New System.Windows.Forms.TabControl()
        Me.tpNPCMovement = New System.Windows.Forms.TabPage()
        Me.cmbNPCVelocity = New System.Windows.Forms.ComboBox()
        Me.lblNPCVelocity = New System.Windows.Forms.Label()
        Me.grpCustomMovement = New System.Windows.Forms.GroupBox()
        Me.pnlListNPCMovement = New System.Windows.Forms.Panel()
        Me.cmbEnableNPCMovements = New System.Windows.Forms.ComboBox()
        Me.btnAddNPCMovement = New System.Windows.Forms.Button()
        Me.cbLoopNPCMovement = New System.Windows.Forms.CheckBox()
        Me.rdbtnPerimeter = New System.Windows.Forms.RadioButton()
        Me.rdbtnCustom = New System.Windows.Forms.RadioButton()
        Me.rdbtnRand = New System.Windows.Forms.RadioButton()
        Me.rdbtnStatic = New System.Windows.Forms.RadioButton()
        Me.tpNPCStatus = New System.Windows.Forms.TabPage()
        Me.grpNPCAggresiveArea = New System.Windows.Forms.GroupBox()
        Me.picNPCCasesArea = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblNPCLnAggArea = New System.Windows.Forms.Label()
        Me.grpNPCStatus = New System.Windows.Forms.GroupBox()
        Me.cbNPCInvicible = New System.Windows.Forms.CheckBox()
        Me.rbNPCPassive = New System.Windows.Forms.RadioButton()
        Me.rbNPCFriendly = New System.Windows.Forms.RadioButton()
        Me.rbNPCAggressive = New System.Windows.Forms.RadioButton()
        Me.btnNPCValid = New System.Windows.Forms.Button()
        Me.grpNPCList.SuspendLayout()
        Me.grpNPCConfig.SuspendLayout()
        Me.tcNPCConfig.SuspendLayout()
        Me.tpNPCMovement.SuspendLayout()
        Me.grpCustomMovement.SuspendLayout()
        Me.tpNPCStatus.SuspendLayout()
        Me.grpNPCAggresiveArea.SuspendLayout()
        CType(Me.picNPCCasesArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNPCStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpNPCList
        '
        Me.grpNPCList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpNPCList.Controls.Add(Me.pnlNPCList)
        Me.grpNPCList.Location = New System.Drawing.Point(12, 12)
        Me.grpNPCList.Name = "grpNPCList"
        Me.grpNPCList.Size = New System.Drawing.Size(235, 472)
        Me.grpNPCList.TabIndex = 2
        Me.grpNPCList.TabStop = False
        Me.grpNPCList.Text = "Liste de PNJs"
        '
        'pnlNPCList
        '
        Me.pnlNPCList.AutoScroll = True
        Me.pnlNPCList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNPCList.Location = New System.Drawing.Point(3, 16)
        Me.pnlNPCList.Name = "pnlNPCList"
        Me.pnlNPCList.Size = New System.Drawing.Size(229, 453)
        Me.pnlNPCList.TabIndex = 0
        '
        'grpNPCConfig
        '
        Me.grpNPCConfig.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpNPCConfig.Controls.Add(Me.tcNPCConfig)
        Me.grpNPCConfig.Location = New System.Drawing.Point(253, 12)
        Me.grpNPCConfig.Name = "grpNPCConfig"
        Me.grpNPCConfig.Size = New System.Drawing.Size(419, 436)
        Me.grpNPCConfig.TabIndex = 3
        Me.grpNPCConfig.TabStop = False
        Me.grpNPCConfig.Text = "Configurations"
        '
        'tcNPCConfig
        '
        Me.tcNPCConfig.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcNPCConfig.Controls.Add(Me.tpNPCMovement)
        Me.tcNPCConfig.Controls.Add(Me.tpNPCStatus)
        Me.tcNPCConfig.Location = New System.Drawing.Point(6, 19)
        Me.tcNPCConfig.Name = "tcNPCConfig"
        Me.tcNPCConfig.SelectedIndex = 0
        Me.tcNPCConfig.Size = New System.Drawing.Size(411, 411)
        Me.tcNPCConfig.TabIndex = 0
        '
        'tpNPCMovement
        '
        Me.tpNPCMovement.Controls.Add(Me.cmbNPCVelocity)
        Me.tpNPCMovement.Controls.Add(Me.lblNPCVelocity)
        Me.tpNPCMovement.Controls.Add(Me.grpCustomMovement)
        Me.tpNPCMovement.Controls.Add(Me.rdbtnPerimeter)
        Me.tpNPCMovement.Controls.Add(Me.rdbtnCustom)
        Me.tpNPCMovement.Controls.Add(Me.rdbtnRand)
        Me.tpNPCMovement.Controls.Add(Me.rdbtnStatic)
        Me.tpNPCMovement.Location = New System.Drawing.Point(4, 22)
        Me.tpNPCMovement.Name = "tpNPCMovement"
        Me.tpNPCMovement.Padding = New System.Windows.Forms.Padding(3)
        Me.tpNPCMovement.Size = New System.Drawing.Size(403, 385)
        Me.tpNPCMovement.TabIndex = 0
        Me.tpNPCMovement.Text = "Déplacements"
        Me.tpNPCMovement.UseVisualStyleBackColor = True
        '
        'cmbNPCVelocity
        '
        Me.cmbNPCVelocity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNPCVelocity.Enabled = False
        Me.cmbNPCVelocity.FormattingEnabled = True
        Me.cmbNPCVelocity.Items.AddRange(New Object() {"Lente", "Moyenne", "Rapide", "Trés rapide"})
        Me.cmbNPCVelocity.Location = New System.Drawing.Point(21, 167)
        Me.cmbNPCVelocity.Name = "cmbNPCVelocity"
        Me.cmbNPCVelocity.Size = New System.Drawing.Size(133, 21)
        Me.cmbNPCVelocity.TabIndex = 10
        '
        'lblNPCVelocity
        '
        Me.lblNPCVelocity.AutoSize = True
        Me.lblNPCVelocity.Location = New System.Drawing.Point(18, 151)
        Me.lblNPCVelocity.Name = "lblNPCVelocity"
        Me.lblNPCVelocity.Size = New System.Drawing.Size(126, 13)
        Me.lblNPCVelocity.TabIndex = 11
        Me.lblNPCVelocity.Text = "Vitesse de déplacement :"
        '
        'grpCustomMovement
        '
        Me.grpCustomMovement.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCustomMovement.Controls.Add(Me.pnlListNPCMovement)
        Me.grpCustomMovement.Controls.Add(Me.cmbEnableNPCMovements)
        Me.grpCustomMovement.Controls.Add(Me.btnAddNPCMovement)
        Me.grpCustomMovement.Controls.Add(Me.cbLoopNPCMovement)
        Me.grpCustomMovement.Enabled = False
        Me.grpCustomMovement.Location = New System.Drawing.Point(174, 15)
        Me.grpCustomMovement.Name = "grpCustomMovement"
        Me.grpCustomMovement.Size = New System.Drawing.Size(226, 355)
        Me.grpCustomMovement.TabIndex = 9
        Me.grpCustomMovement.TabStop = False
        Me.grpCustomMovement.Text = "Déplacements personnalisés"
        '
        'pnlListNPCMovement
        '
        Me.pnlListNPCMovement.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlListNPCMovement.AutoScroll = True
        Me.pnlListNPCMovement.Location = New System.Drawing.Point(6, 19)
        Me.pnlListNPCMovement.Name = "pnlListNPCMovement"
        Me.pnlListNPCMovement.Size = New System.Drawing.Size(214, 264)
        Me.pnlListNPCMovement.TabIndex = 10
        '
        'cmbEnableNPCMovements
        '
        Me.cmbEnableNPCMovements.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbEnableNPCMovements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEnableNPCMovements.FormattingEnabled = True
        Me.cmbEnableNPCMovements.Items.AddRange(New Object() {"Haut", "Bas", "Droite", "Gauche"})
        Me.cmbEnableNPCMovements.Location = New System.Drawing.Point(6, 289)
        Me.cmbEnableNPCMovements.Name = "cmbEnableNPCMovements"
        Me.cmbEnableNPCMovements.Size = New System.Drawing.Size(133, 21)
        Me.cmbEnableNPCMovements.TabIndex = 9
        '
        'btnAddNPCMovement
        '
        Me.btnAddNPCMovement.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddNPCMovement.Location = New System.Drawing.Point(145, 289)
        Me.btnAddNPCMovement.Name = "btnAddNPCMovement"
        Me.btnAddNPCMovement.Size = New System.Drawing.Size(75, 21)
        Me.btnAddNPCMovement.TabIndex = 8
        Me.btnAddNPCMovement.Text = "Ajouter"
        Me.btnAddNPCMovement.UseVisualStyleBackColor = True
        '
        'cbLoopNPCMovement
        '
        Me.cbLoopNPCMovement.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLoopNPCMovement.AutoSize = True
        Me.cbLoopNPCMovement.Location = New System.Drawing.Point(49, 328)
        Me.cbLoopNPCMovement.Name = "cbLoopNPCMovement"
        Me.cbLoopNPCMovement.Size = New System.Drawing.Size(139, 17)
        Me.cbLoopNPCMovement.TabIndex = 7
        Me.cbLoopNPCMovement.Text = "Répéter le déplacement"
        Me.cbLoopNPCMovement.UseVisualStyleBackColor = True
        '
        'rdbtnPerimeter
        '
        Me.rdbtnPerimeter.AutoSize = True
        Me.rdbtnPerimeter.Location = New System.Drawing.Point(21, 75)
        Me.rdbtnPerimeter.Name = "rdbtnPerimeter"
        Me.rdbtnPerimeter.Size = New System.Drawing.Size(69, 17)
        Me.rdbtnPerimeter.TabIndex = 8
        Me.rdbtnPerimeter.Text = "Périmètre"
        Me.rdbtnPerimeter.UseVisualStyleBackColor = True
        '
        'rdbtnCustom
        '
        Me.rdbtnCustom.AutoSize = True
        Me.rdbtnCustom.Location = New System.Drawing.Point(21, 98)
        Me.rdbtnCustom.Name = "rdbtnCustom"
        Me.rdbtnCustom.Size = New System.Drawing.Size(85, 17)
        Me.rdbtnCustom.TabIndex = 7
        Me.rdbtnCustom.Text = "Personnalisé"
        Me.rdbtnCustom.UseVisualStyleBackColor = True
        '
        'rdbtnRand
        '
        Me.rdbtnRand.AutoSize = True
        Me.rdbtnRand.Location = New System.Drawing.Point(21, 52)
        Me.rdbtnRand.Name = "rdbtnRand"
        Me.rdbtnRand.Size = New System.Drawing.Size(66, 17)
        Me.rdbtnRand.TabIndex = 5
        Me.rdbtnRand.Text = "Aléatoire"
        Me.rdbtnRand.UseVisualStyleBackColor = True
        '
        'rdbtnStatic
        '
        Me.rdbtnStatic.AutoSize = True
        Me.rdbtnStatic.Checked = True
        Me.rdbtnStatic.Location = New System.Drawing.Point(21, 29)
        Me.rdbtnStatic.Name = "rdbtnStatic"
        Me.rdbtnStatic.Size = New System.Drawing.Size(66, 17)
        Me.rdbtnStatic.TabIndex = 4
        Me.rdbtnStatic.TabStop = True
        Me.rdbtnStatic.Text = "Immobile"
        Me.rdbtnStatic.UseVisualStyleBackColor = True
        '
        'tpNPCStatus
        '
        Me.tpNPCStatus.Controls.Add(Me.grpNPCAggresiveArea)
        Me.tpNPCStatus.Controls.Add(Me.grpNPCStatus)
        Me.tpNPCStatus.Location = New System.Drawing.Point(4, 22)
        Me.tpNPCStatus.Name = "tpNPCStatus"
        Me.tpNPCStatus.Padding = New System.Windows.Forms.Padding(3)
        Me.tpNPCStatus.Size = New System.Drawing.Size(403, 386)
        Me.tpNPCStatus.TabIndex = 1
        Me.tpNPCStatus.Text = "Statut"
        Me.tpNPCStatus.UseVisualStyleBackColor = True
        '
        'grpNPCAggresiveArea
        '
        Me.grpNPCAggresiveArea.Controls.Add(Me.picNPCCasesArea)
        Me.grpNPCAggresiveArea.Controls.Add(Me.TextBox1)
        Me.grpNPCAggresiveArea.Controls.Add(Me.lblNPCLnAggArea)
        Me.grpNPCAggresiveArea.Enabled = False
        Me.grpNPCAggresiveArea.Location = New System.Drawing.Point(159, 15)
        Me.grpNPCAggresiveArea.Name = "grpNPCAggresiveArea"
        Me.grpNPCAggresiveArea.Size = New System.Drawing.Size(223, 134)
        Me.grpNPCAggresiveArea.TabIndex = 15
        Me.grpNPCAggresiveArea.TabStop = False
        Me.grpNPCAggresiveArea.Text = "Zone d'agression"
        '
        'picNPCCasesArea
        '
        Me.picNPCCasesArea.Image = CType(resources.GetObject("picNPCCasesArea.Image"), System.Drawing.Image)
        Me.picNPCCasesArea.Location = New System.Drawing.Point(12, 55)
        Me.picNPCCasesArea.Name = "picNPCCasesArea"
        Me.picNPCCasesArea.Size = New System.Drawing.Size(123, 66)
        Me.picNPCCasesArea.TabIndex = 2
        Me.picNPCCasesArea.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(59, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(54, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "5"
        '
        'lblNPCLnAggArea
        '
        Me.lblNPCLnAggArea.AutoSize = True
        Me.lblNPCLnAggArea.Location = New System.Drawing.Point(9, 33)
        Me.lblNPCLnAggArea.Name = "lblNPCLnAggArea"
        Me.lblNPCLnAggArea.Size = New System.Drawing.Size(44, 13)
        Me.lblNPCLnAggArea.TabIndex = 0
        Me.lblNPCLnAggArea.Text = "Portée :"
        '
        'grpNPCStatus
        '
        Me.grpNPCStatus.Controls.Add(Me.cbNPCInvicible)
        Me.grpNPCStatus.Controls.Add(Me.rbNPCPassive)
        Me.grpNPCStatus.Controls.Add(Me.rbNPCFriendly)
        Me.grpNPCStatus.Controls.Add(Me.rbNPCAggressive)
        Me.grpNPCStatus.Location = New System.Drawing.Point(18, 15)
        Me.grpNPCStatus.Name = "grpNPCStatus"
        Me.grpNPCStatus.Size = New System.Drawing.Size(120, 134)
        Me.grpNPCStatus.TabIndex = 14
        Me.grpNPCStatus.TabStop = False
        '
        'cbNPCInvicible
        '
        Me.cbNPCInvicible.AutoSize = True
        Me.cbNPCInvicible.Location = New System.Drawing.Point(28, 102)
        Me.cbNPCInvicible.Name = "cbNPCInvicible"
        Me.cbNPCInvicible.Size = New System.Drawing.Size(71, 17)
        Me.cbNPCInvicible.TabIndex = 13
        Me.cbNPCInvicible.Text = "Invincible"
        Me.cbNPCInvicible.UseVisualStyleBackColor = True
        '
        'rbNPCPassive
        '
        Me.rbNPCPassive.AutoSize = True
        Me.rbNPCPassive.Checked = True
        Me.rbNPCPassive.Location = New System.Drawing.Point(28, 19)
        Me.rbNPCPassive.Name = "rbNPCPassive"
        Me.rbNPCPassive.Size = New System.Drawing.Size(53, 17)
        Me.rbNPCPassive.TabIndex = 9
        Me.rbNPCPassive.TabStop = True
        Me.rbNPCPassive.Text = "Passif"
        Me.rbNPCPassive.UseVisualStyleBackColor = True
        '
        'rbNPCFriendly
        '
        Me.rbNPCFriendly.AutoSize = True
        Me.rbNPCFriendly.Location = New System.Drawing.Point(28, 65)
        Me.rbNPCFriendly.Name = "rbNPCFriendly"
        Me.rbNPCFriendly.Size = New System.Drawing.Size(56, 17)
        Me.rbNPCFriendly.TabIndex = 12
        Me.rbNPCFriendly.Text = "Amical"
        Me.rbNPCFriendly.UseVisualStyleBackColor = True
        '
        'rbNPCAggressive
        '
        Me.rbNPCAggressive.AutoSize = True
        Me.rbNPCAggressive.Location = New System.Drawing.Point(28, 42)
        Me.rbNPCAggressive.Name = "rbNPCAggressive"
        Me.rbNPCAggressive.Size = New System.Drawing.Size(62, 17)
        Me.rbNPCAggressive.TabIndex = 10
        Me.rbNPCAggressive.Text = "Agressif"
        Me.rbNPCAggressive.UseVisualStyleBackColor = True
        '
        'btnNPCValid
        '
        Me.btnNPCValid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNPCValid.Location = New System.Drawing.Point(513, 454)
        Me.btnNPCValid.Name = "btnNPCValid"
        Me.btnNPCValid.Size = New System.Drawing.Size(159, 27)
        Me.btnNPCValid.TabIndex = 0
        Me.btnNPCValid.Text = "Valider"
        Me.btnNPCValid.UseVisualStyleBackColor = True
        '
        'frmConfigNPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 496)
        Me.Controls.Add(Me.btnNPCValid)
        Me.Controls.Add(Me.grpNPCConfig)
        Me.Controls.Add(Me.grpNPCList)
        Me.MinimumSize = New System.Drawing.Size(700, 535)
        Me.Name = "frmConfigNPC"
        Me.Text = "Configurateur de PNJs"
        Me.grpNPCList.ResumeLayout(False)
        Me.grpNPCConfig.ResumeLayout(False)
        Me.tcNPCConfig.ResumeLayout(False)
        Me.tpNPCMovement.ResumeLayout(False)
        Me.tpNPCMovement.PerformLayout()
        Me.grpCustomMovement.ResumeLayout(False)
        Me.grpCustomMovement.PerformLayout()
        Me.tpNPCStatus.ResumeLayout(False)
        Me.grpNPCAggresiveArea.ResumeLayout(False)
        Me.grpNPCAggresiveArea.PerformLayout()
        CType(Me.picNPCCasesArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNPCStatus.ResumeLayout(False)
        Me.grpNPCStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpNPCList As System.Windows.Forms.GroupBox
    Friend WithEvents grpNPCConfig As System.Windows.Forms.GroupBox
    Friend WithEvents btnNPCValid As System.Windows.Forms.Button
    Friend WithEvents tcNPCConfig As System.Windows.Forms.TabControl
    Friend WithEvents tpNPCMovement As System.Windows.Forms.TabPage
    Friend WithEvents grpCustomMovement As System.Windows.Forms.GroupBox
    Friend WithEvents cmbEnableNPCMovements As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddNPCMovement As System.Windows.Forms.Button
    Friend WithEvents cbLoopNPCMovement As System.Windows.Forms.CheckBox
    Friend WithEvents rdbtnPerimeter As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnCustom As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnRand As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnStatic As System.Windows.Forms.RadioButton
    Friend WithEvents tpNPCStatus As System.Windows.Forms.TabPage
    Friend WithEvents cmbNPCVelocity As System.Windows.Forms.ComboBox
    Friend WithEvents lblNPCVelocity As System.Windows.Forms.Label
    Friend WithEvents grpNPCAggresiveArea As System.Windows.Forms.GroupBox
    Friend WithEvents grpNPCStatus As System.Windows.Forms.GroupBox
    Friend WithEvents cbNPCInvicible As System.Windows.Forms.CheckBox
    Friend WithEvents rbNPCPassive As System.Windows.Forms.RadioButton
    Friend WithEvents rbNPCFriendly As System.Windows.Forms.RadioButton
    Friend WithEvents rbNPCAggressive As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNPCLnAggArea As System.Windows.Forms.Label
    Friend WithEvents picNPCCasesArea As System.Windows.Forms.PictureBox
    Friend WithEvents pnlNPCList As System.Windows.Forms.Panel
    Friend WithEvents pnlListNPCMovement As System.Windows.Forms.Panel
End Class
