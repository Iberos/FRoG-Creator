﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataEditor
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lstBClasses = New System.Windows.Forms.ListBox()
        Me.pnlClass = New System.Windows.Forms.Panel()
        Me.txtClassDesc = New System.Windows.Forms.TextBox()
        Me.txtClassStrength = New System.Windows.Forms.TextBox()
        Me.txtClassMagic = New System.Windows.Forms.TextBox()
        Me.txtClassDef = New System.Windows.Forms.TextBox()
        Me.txtClassAgility = New System.Windows.Forms.TextBox()
        Me.txtClassSpeed = New System.Windows.Forms.TextBox()
        Me.txtClassMP = New System.Windows.Forms.TextBox()
        Me.txtClassHP = New System.Windows.Forms.TextBox()
        Me.txtClassName = New System.Windows.Forms.TextBox()
        Me.Label_Class_Speed = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label_Class_Defense = New System.Windows.Forms.Label()
        Me.Label_Class_Magic = New System.Windows.Forms.Label()
        Me.Label_Class_Strength = New System.Windows.Forms.Label()
        Me.Label_Class_MP = New System.Windows.Forms.Label()
        Me.Label_Class_HP = New System.Windows.Forms.Label()
        Me.Label_Class_Description = New System.Windows.Forms.Label()
        Me.Label_Class_Name = New System.Windows.Forms.Label()
        Me.btClassSave = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lstBItems = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.lstBSpells = New System.Windows.Forms.ListBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.lstBNPCs = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnlClass.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(809, 492)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(801, 466)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Classes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lstBClasses)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlClass)
        Me.SplitContainer1.Size = New System.Drawing.Size(795, 460)
        Me.SplitContainer1.SplitterDistance = 187
        Me.SplitContainer1.TabIndex = 0
        '
        'lstBClasses
        '
        Me.lstBClasses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstBClasses.FormattingEnabled = True
        Me.lstBClasses.Location = New System.Drawing.Point(0, 0)
        Me.lstBClasses.Name = "lstBClasses"
        Me.lstBClasses.Size = New System.Drawing.Size(187, 460)
        Me.lstBClasses.TabIndex = 0
        '
        'pnlClass
        '
        Me.pnlClass.Controls.Add(Me.txtClassDesc)
        Me.pnlClass.Controls.Add(Me.txtClassStrength)
        Me.pnlClass.Controls.Add(Me.txtClassMagic)
        Me.pnlClass.Controls.Add(Me.txtClassDef)
        Me.pnlClass.Controls.Add(Me.txtClassAgility)
        Me.pnlClass.Controls.Add(Me.txtClassSpeed)
        Me.pnlClass.Controls.Add(Me.txtClassMP)
        Me.pnlClass.Controls.Add(Me.txtClassHP)
        Me.pnlClass.Controls.Add(Me.txtClassName)
        Me.pnlClass.Controls.Add(Me.Label_Class_Speed)
        Me.pnlClass.Controls.Add(Me.Label8)
        Me.pnlClass.Controls.Add(Me.Label_Class_Defense)
        Me.pnlClass.Controls.Add(Me.Label_Class_Magic)
        Me.pnlClass.Controls.Add(Me.Label_Class_Strength)
        Me.pnlClass.Controls.Add(Me.Label_Class_MP)
        Me.pnlClass.Controls.Add(Me.Label_Class_HP)
        Me.pnlClass.Controls.Add(Me.Label_Class_Description)
        Me.pnlClass.Controls.Add(Me.Label_Class_Name)
        Me.pnlClass.Controls.Add(Me.btClassSave)
        Me.pnlClass.Location = New System.Drawing.Point(131, 27)
        Me.pnlClass.Name = "pnlClass"
        Me.pnlClass.Size = New System.Drawing.Size(354, 394)
        Me.pnlClass.TabIndex = 0
        '
        'txtClassDesc
        '
        Me.txtClassDesc.Location = New System.Drawing.Point(111, 83)
        Me.txtClassDesc.Multiline = True
        Me.txtClassDesc.Name = "txtClassDesc"
        Me.txtClassDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtClassDesc.Size = New System.Drawing.Size(199, 37)
        Me.txtClassDesc.TabIndex = 57
        '
        'txtClassStrength
        '
        Me.txtClassStrength.Location = New System.Drawing.Point(111, 178)
        Me.txtClassStrength.Name = "txtClassStrength"
        Me.txtClassStrength.Size = New System.Drawing.Size(34, 20)
        Me.txtClassStrength.TabIndex = 56
        '
        'txtClassMagic
        '
        Me.txtClassMagic.Location = New System.Drawing.Point(111, 207)
        Me.txtClassMagic.Name = "txtClassMagic"
        Me.txtClassMagic.Size = New System.Drawing.Size(34, 20)
        Me.txtClassMagic.TabIndex = 55
        '
        'txtClassDef
        '
        Me.txtClassDef.Location = New System.Drawing.Point(111, 233)
        Me.txtClassDef.Name = "txtClassDef"
        Me.txtClassDef.Size = New System.Drawing.Size(34, 20)
        Me.txtClassDef.TabIndex = 54
        '
        'txtClassAgility
        '
        Me.txtClassAgility.Location = New System.Drawing.Point(111, 259)
        Me.txtClassAgility.Name = "txtClassAgility"
        Me.txtClassAgility.Size = New System.Drawing.Size(34, 20)
        Me.txtClassAgility.TabIndex = 53
        '
        'txtClassSpeed
        '
        Me.txtClassSpeed.Location = New System.Drawing.Point(111, 288)
        Me.txtClassSpeed.Name = "txtClassSpeed"
        Me.txtClassSpeed.Size = New System.Drawing.Size(34, 20)
        Me.txtClassSpeed.TabIndex = 52
        '
        'txtClassMP
        '
        Me.txtClassMP.Location = New System.Drawing.Point(111, 152)
        Me.txtClassMP.Name = "txtClassMP"
        Me.txtClassMP.Size = New System.Drawing.Size(70, 20)
        Me.txtClassMP.TabIndex = 51
        '
        'txtClassHP
        '
        Me.txtClassHP.Location = New System.Drawing.Point(111, 126)
        Me.txtClassHP.Name = "txtClassHP"
        Me.txtClassHP.Size = New System.Drawing.Size(70, 20)
        Me.txtClassHP.TabIndex = 50
        '
        'txtClassName
        '
        Me.txtClassName.Location = New System.Drawing.Point(111, 57)
        Me.txtClassName.Name = "txtClassName"
        Me.txtClassName.Size = New System.Drawing.Size(199, 20)
        Me.txtClassName.TabIndex = 49
        '
        'Label_Class_Speed
        '
        Me.Label_Class_Speed.AutoSize = True
        Me.Label_Class_Speed.Location = New System.Drawing.Point(50, 291)
        Me.Label_Class_Speed.Name = "Label_Class_Speed"
        Me.Label_Class_Speed.Size = New System.Drawing.Size(41, 13)
        Me.Label_Class_Speed.TabIndex = 48
        Me.Label_Class_Speed.Text = "Vitesse"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Agilité"
        '
        'Label_Class_Defense
        '
        Me.Label_Class_Defense.AutoSize = True
        Me.Label_Class_Defense.Location = New System.Drawing.Point(50, 236)
        Me.Label_Class_Defense.Name = "Label_Class_Defense"
        Me.Label_Class_Defense.Size = New System.Drawing.Size(47, 13)
        Me.Label_Class_Defense.TabIndex = 46
        Me.Label_Class_Defense.Text = "Défense"
        '
        'Label_Class_Magic
        '
        Me.Label_Class_Magic.AutoSize = True
        Me.Label_Class_Magic.Location = New System.Drawing.Point(50, 210)
        Me.Label_Class_Magic.Name = "Label_Class_Magic"
        Me.Label_Class_Magic.Size = New System.Drawing.Size(36, 13)
        Me.Label_Class_Magic.TabIndex = 45
        Me.Label_Class_Magic.Text = "Magie"
        '
        'Label_Class_Strength
        '
        Me.Label_Class_Strength.AutoSize = True
        Me.Label_Class_Strength.Location = New System.Drawing.Point(50, 181)
        Me.Label_Class_Strength.Name = "Label_Class_Strength"
        Me.Label_Class_Strength.Size = New System.Drawing.Size(34, 13)
        Me.Label_Class_Strength.TabIndex = 44
        Me.Label_Class_Strength.Text = "Force"
        '
        'Label_Class_MP
        '
        Me.Label_Class_MP.AutoSize = True
        Me.Label_Class_MP.Location = New System.Drawing.Point(50, 155)
        Me.Label_Class_MP.Name = "Label_Class_MP"
        Me.Label_Class_MP.Size = New System.Drawing.Size(23, 13)
        Me.Label_Class_MP.TabIndex = 43
        Me.Label_Class_MP.Text = "MP"
        '
        'Label_Class_HP
        '
        Me.Label_Class_HP.AutoSize = True
        Me.Label_Class_HP.Location = New System.Drawing.Point(50, 129)
        Me.Label_Class_HP.Name = "Label_Class_HP"
        Me.Label_Class_HP.Size = New System.Drawing.Size(22, 13)
        Me.Label_Class_HP.TabIndex = 42
        Me.Label_Class_HP.Text = "HP"
        '
        'Label_Class_Description
        '
        Me.Label_Class_Description.AutoSize = True
        Me.Label_Class_Description.Location = New System.Drawing.Point(45, 86)
        Me.Label_Class_Description.Name = "Label_Class_Description"
        Me.Label_Class_Description.Size = New System.Drawing.Size(60, 13)
        Me.Label_Class_Description.TabIndex = 41
        Me.Label_Class_Description.Text = "Description"
        '
        'Label_Class_Name
        '
        Me.Label_Class_Name.AutoSize = True
        Me.Label_Class_Name.Location = New System.Drawing.Point(50, 60)
        Me.Label_Class_Name.Name = "Label_Class_Name"
        Me.Label_Class_Name.Size = New System.Drawing.Size(29, 13)
        Me.Label_Class_Name.TabIndex = 40
        Me.Label_Class_Name.Text = "Nom"
        '
        'btClassSave
        '
        Me.btClassSave.Location = New System.Drawing.Point(230, 314)
        Me.btClassSave.Name = "btClassSave"
        Me.btClassSave.Size = New System.Drawing.Size(80, 23)
        Me.btClassSave.TabIndex = 39
        Me.btClassSave.Text = "Sauvegarder"
        Me.btClassSave.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(801, 466)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Objets"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lstBItems)
        Me.SplitContainer2.Size = New System.Drawing.Size(795, 460)
        Me.SplitContainer2.SplitterDistance = 187
        Me.SplitContainer2.TabIndex = 0
        '
        'lstBItems
        '
        Me.lstBItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstBItems.FormattingEnabled = True
        Me.lstBItems.Location = New System.Drawing.Point(0, 0)
        Me.lstBItems.Name = "lstBItems"
        Me.lstBItems.Size = New System.Drawing.Size(187, 460)
        Me.lstBItems.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.SplitContainer3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(801, 466)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sorts"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.lstBSpells)
        Me.SplitContainer3.Size = New System.Drawing.Size(801, 466)
        Me.SplitContainer3.SplitterDistance = 189
        Me.SplitContainer3.TabIndex = 0
        '
        'lstBSpells
        '
        Me.lstBSpells.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstBSpells.FormattingEnabled = True
        Me.lstBSpells.Location = New System.Drawing.Point(0, 0)
        Me.lstBSpells.Name = "lstBSpells"
        Me.lstBSpells.Size = New System.Drawing.Size(189, 466)
        Me.lstBSpells.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.SplitContainer4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(801, 466)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "PNJs"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.lstBNPCs)
        Me.SplitContainer4.Size = New System.Drawing.Size(801, 466)
        Me.SplitContainer4.SplitterDistance = 190
        Me.SplitContainer4.TabIndex = 0
        '
        'lstBNPCs
        '
        Me.lstBNPCs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstBNPCs.FormattingEnabled = True
        Me.lstBNPCs.Location = New System.Drawing.Point(0, 0)
        Me.lstBNPCs.Name = "lstBNPCs"
        Me.lstBNPCs.Size = New System.Drawing.Size(190, 466)
        Me.lstBNPCs.TabIndex = 0
        '
        'frmDataEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 492)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmDataEditor"
        Me.Text = "Editeur de ressources"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnlClass.ResumeLayout(False)
        Me.pnlClass.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lstBClasses As System.Windows.Forms.ListBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lstBItems As System.Windows.Forms.ListBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents lstBSpells As System.Windows.Forms.ListBox
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents lstBNPCs As System.Windows.Forms.ListBox
    Friend WithEvents pnlClass As System.Windows.Forms.Panel
    Friend WithEvents txtClassDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtClassStrength As System.Windows.Forms.TextBox
    Friend WithEvents txtClassMagic As System.Windows.Forms.TextBox
    Friend WithEvents txtClassDef As System.Windows.Forms.TextBox
    Friend WithEvents txtClassAgility As System.Windows.Forms.TextBox
    Friend WithEvents txtClassSpeed As System.Windows.Forms.TextBox
    Friend WithEvents txtClassMP As System.Windows.Forms.TextBox
    Friend WithEvents txtClassHP As System.Windows.Forms.TextBox
    Friend WithEvents txtClassName As System.Windows.Forms.TextBox
    Friend WithEvents Label_Class_Speed As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label_Class_Defense As System.Windows.Forms.Label
    Friend WithEvents Label_Class_Magic As System.Windows.Forms.Label
    Friend WithEvents Label_Class_Strength As System.Windows.Forms.Label
    Friend WithEvents Label_Class_MP As System.Windows.Forms.Label
    Friend WithEvents Label_Class_HP As System.Windows.Forms.Label
    Friend WithEvents Label_Class_Description As System.Windows.Forms.Label
    Friend WithEvents Label_Class_Name As System.Windows.Forms.Label
    Friend WithEvents btClassSave As System.Windows.Forms.Button
End Class
