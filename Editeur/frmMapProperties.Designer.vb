<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMapProperties
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
        Me.grpWorldMap = New System.Windows.Forms.GroupBox()
        Me.pnlWorldMap = New System.Windows.Forms.Panel()
        Me.pnlSelect = New System.Windows.Forms.Panel()
        Me.lstMaps = New System.Windows.Forms.ComboBox()
        Me.btnCancelPanelSelect = New System.Windows.Forms.Button()
        Me.btnValidPanelSelect = New System.Windows.Forms.Button()
        Me.btnValid = New System.Windows.Forms.Button()
        Me.grpMapProperties = New System.Windows.Forms.GroupBox()
        Me.lstTypes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpWorldMap.SuspendLayout()
        Me.pnlWorldMap.SuspendLayout()
        Me.pnlSelect.SuspendLayout()
        Me.grpMapProperties.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpWorldMap
        '
        Me.grpWorldMap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpWorldMap.Controls.Add(Me.pnlWorldMap)
        Me.grpWorldMap.Location = New System.Drawing.Point(12, 99)
        Me.grpWorldMap.Name = "grpWorldMap"
        Me.grpWorldMap.Size = New System.Drawing.Size(556, 312)
        Me.grpWorldMap.TabIndex = 2
        Me.grpWorldMap.TabStop = False
        Me.grpWorldMap.Text = "World Map"
        '
        'pnlWorldMap
        '
        Me.pnlWorldMap.AutoScroll = True
        Me.pnlWorldMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlWorldMap.Controls.Add(Me.pnlSelect)
        Me.pnlWorldMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWorldMap.Location = New System.Drawing.Point(3, 16)
        Me.pnlWorldMap.Name = "pnlWorldMap"
        Me.pnlWorldMap.Size = New System.Drawing.Size(550, 293)
        Me.pnlWorldMap.TabIndex = 9
        '
        'pnlSelect
        '
        Me.pnlSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSelect.Controls.Add(Me.lstMaps)
        Me.pnlSelect.Controls.Add(Me.btnCancelPanelSelect)
        Me.pnlSelect.Controls.Add(Me.btnValidPanelSelect)
        Me.pnlSelect.Location = New System.Drawing.Point(164, 100)
        Me.pnlSelect.Name = "pnlSelect"
        Me.pnlSelect.Size = New System.Drawing.Size(200, 73)
        Me.pnlSelect.TabIndex = 8
        Me.pnlSelect.Visible = False
        '
        'lstMaps
        '
        Me.lstMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstMaps.FormattingEnabled = True
        Me.lstMaps.Location = New System.Drawing.Point(3, 8)
        Me.lstMaps.Name = "lstMaps"
        Me.lstMaps.Size = New System.Drawing.Size(191, 21)
        Me.lstMaps.TabIndex = 2
        '
        'btnCancelPanelSelect
        '
        Me.btnCancelPanelSelect.Location = New System.Drawing.Point(3, 39)
        Me.btnCancelPanelSelect.Name = "btnCancelPanelSelect"
        Me.btnCancelPanelSelect.Size = New System.Drawing.Size(93, 23)
        Me.btnCancelPanelSelect.TabIndex = 1
        Me.btnCancelPanelSelect.Text = "Annuler"
        Me.btnCancelPanelSelect.UseVisualStyleBackColor = True
        '
        'btnValidPanelSelect
        '
        Me.btnValidPanelSelect.Location = New System.Drawing.Point(101, 39)
        Me.btnValidPanelSelect.Name = "btnValidPanelSelect"
        Me.btnValidPanelSelect.Size = New System.Drawing.Size(93, 23)
        Me.btnValidPanelSelect.TabIndex = 0
        Me.btnValidPanelSelect.Text = "Valider"
        Me.btnValidPanelSelect.UseVisualStyleBackColor = True
        '
        'btnValid
        '
        Me.btnValid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnValid.Location = New System.Drawing.Point(468, 417)
        Me.btnValid.Name = "btnValid"
        Me.btnValid.Size = New System.Drawing.Size(100, 23)
        Me.btnValid.TabIndex = 3
        Me.btnValid.Text = "Valider"
        Me.btnValid.UseVisualStyleBackColor = True
        '
        'grpMapProperties
        '
        Me.grpMapProperties.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMapProperties.Controls.Add(Me.lstTypes)
        Me.grpMapProperties.Controls.Add(Me.Label2)
        Me.grpMapProperties.Controls.Add(Me.txtName)
        Me.grpMapProperties.Controls.Add(Me.Label1)
        Me.grpMapProperties.Location = New System.Drawing.Point(12, 12)
        Me.grpMapProperties.Name = "grpMapProperties"
        Me.grpMapProperties.Size = New System.Drawing.Size(556, 81)
        Me.grpMapProperties.TabIndex = 4
        Me.grpMapProperties.TabStop = False
        Me.grpMapProperties.Text = "Général"
        '
        'lstTypes
        '
        Me.lstTypes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstTypes.FormattingEnabled = True
        Me.lstTypes.Items.AddRange(New Object() {"Normale", "Sans PVP", "Intérieur"})
        Me.lstTypes.Location = New System.Drawing.Point(105, 52)
        Me.lstTypes.Name = "lstTypes"
        Me.lstTypes.Size = New System.Drawing.Size(445, 21)
        Me.lstTypes.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Type de map :"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(105, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(445, 20)
        Me.txtName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom de la map :"
        '
        'frmMapProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 446)
        Me.Controls.Add(Me.grpWorldMap)
        Me.Controls.Add(Me.grpMapProperties)
        Me.Controls.Add(Me.btnValid)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(523, 485)
        Me.Name = "frmMapProperties"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proprietés de map"
        Me.grpWorldMap.ResumeLayout(False)
        Me.pnlWorldMap.ResumeLayout(False)
        Me.pnlSelect.ResumeLayout(False)
        Me.grpMapProperties.ResumeLayout(False)
        Me.grpMapProperties.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpWorldMap As System.Windows.Forms.GroupBox
    Friend WithEvents btnValid As System.Windows.Forms.Button
    Friend WithEvents pnlSelect As System.Windows.Forms.Panel
    Friend WithEvents lstMaps As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelPanelSelect As System.Windows.Forms.Button
    Friend WithEvents btnValidPanelSelect As System.Windows.Forms.Button
    Friend WithEvents grpMapProperties As System.Windows.Forms.GroupBox
    Friend WithEvents lstTypes As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlWorldMap As System.Windows.Forms.Panel
End Class
