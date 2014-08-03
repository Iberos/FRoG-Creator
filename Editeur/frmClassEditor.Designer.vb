<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassEditor
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
        Me.Label_Class_Creation = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label_Class_Name = New System.Windows.Forms.Label()
        Me.Label_Class_Description = New System.Windows.Forms.Label()
        Me.Label_Class_HP = New System.Windows.Forms.Label()
        Me.Label_Class_MP = New System.Windows.Forms.Label()
        Me.Label_Class_Strength = New System.Windows.Forms.Label()
        Me.Label_Class_Magic = New System.Windows.Forms.Label()
        Me.Label_Class_Defense = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label_Class_Speed = New System.Windows.Forms.Label()
        Me.Textbox_Class_Name = New System.Windows.Forms.TextBox()
        Me.Textbox_Class_HP = New System.Windows.Forms.TextBox()
        Me.Textbox_Class_MP = New System.Windows.Forms.TextBox()
        Me.Textbox_Class_Speed = New System.Windows.Forms.TextBox()
        Me.Textbox_Class_Agility = New System.Windows.Forms.TextBox()
        Me.Textbox_Class_Defense = New System.Windows.Forms.TextBox()
        Me.Textbox_Class_Magic = New System.Windows.Forms.TextBox()
        Me.Textbox_Class_Strength = New System.Windows.Forms.TextBox()
        Me.RichTextBox_Class_Description = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label_Class_Creation
        '
        Me.Label_Class_Creation.AutoSize = True
        Me.Label_Class_Creation.ForeColor = System.Drawing.Color.Red
        Me.Label_Class_Creation.Location = New System.Drawing.Point(84, 9)
        Me.Label_Class_Creation.Name = "Label_Class_Creation"
        Me.Label_Class_Creation.Size = New System.Drawing.Size(108, 13)
        Me.Label_Class_Creation.TabIndex = 0
        Me.Label_Class_Creation.Text = "Création d'une classe"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Créer la classe"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label_Class_Name
        '
        Me.Label_Class_Name.AutoSize = True
        Me.Label_Class_Name.Location = New System.Drawing.Point(9, 36)
        Me.Label_Class_Name.Name = "Label_Class_Name"
        Me.Label_Class_Name.Size = New System.Drawing.Size(29, 13)
        Me.Label_Class_Name.TabIndex = 2
        Me.Label_Class_Name.Text = "Nom"
        '
        'Label_Class_Description
        '
        Me.Label_Class_Description.AutoSize = True
        Me.Label_Class_Description.Location = New System.Drawing.Point(4, 62)
        Me.Label_Class_Description.Name = "Label_Class_Description"
        Me.Label_Class_Description.Size = New System.Drawing.Size(60, 13)
        Me.Label_Class_Description.TabIndex = 3
        Me.Label_Class_Description.Text = "Description"
        '
        'Label_Class_HP
        '
        Me.Label_Class_HP.AutoSize = True
        Me.Label_Class_HP.Location = New System.Drawing.Point(9, 105)
        Me.Label_Class_HP.Name = "Label_Class_HP"
        Me.Label_Class_HP.Size = New System.Drawing.Size(22, 13)
        Me.Label_Class_HP.TabIndex = 4
        Me.Label_Class_HP.Text = "HP"
        '
        'Label_Class_MP
        '
        Me.Label_Class_MP.AutoSize = True
        Me.Label_Class_MP.Location = New System.Drawing.Point(9, 131)
        Me.Label_Class_MP.Name = "Label_Class_MP"
        Me.Label_Class_MP.Size = New System.Drawing.Size(23, 13)
        Me.Label_Class_MP.TabIndex = 5
        Me.Label_Class_MP.Text = "MP"
        '
        'Label_Class_Strength
        '
        Me.Label_Class_Strength.AutoSize = True
        Me.Label_Class_Strength.Location = New System.Drawing.Point(9, 157)
        Me.Label_Class_Strength.Name = "Label_Class_Strength"
        Me.Label_Class_Strength.Size = New System.Drawing.Size(34, 13)
        Me.Label_Class_Strength.TabIndex = 6
        Me.Label_Class_Strength.Text = "Force"
        '
        'Label_Class_Magic
        '
        Me.Label_Class_Magic.AutoSize = True
        Me.Label_Class_Magic.Location = New System.Drawing.Point(9, 186)
        Me.Label_Class_Magic.Name = "Label_Class_Magic"
        Me.Label_Class_Magic.Size = New System.Drawing.Size(36, 13)
        Me.Label_Class_Magic.TabIndex = 7
        Me.Label_Class_Magic.Text = "Magie"
        '
        'Label_Class_Defense
        '
        Me.Label_Class_Defense.AutoSize = True
        Me.Label_Class_Defense.Location = New System.Drawing.Point(9, 212)
        Me.Label_Class_Defense.Name = "Label_Class_Defense"
        Me.Label_Class_Defense.Size = New System.Drawing.Size(47, 13)
        Me.Label_Class_Defense.TabIndex = 8
        Me.Label_Class_Defense.Text = "Défense"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Agilité"
        '
        'Label_Class_Speed
        '
        Me.Label_Class_Speed.AutoSize = True
        Me.Label_Class_Speed.Location = New System.Drawing.Point(9, 267)
        Me.Label_Class_Speed.Name = "Label_Class_Speed"
        Me.Label_Class_Speed.Size = New System.Drawing.Size(41, 13)
        Me.Label_Class_Speed.TabIndex = 10
        Me.Label_Class_Speed.Text = "Vitesse"
        '
        'Textbox_Class_Name
        '
        Me.Textbox_Class_Name.Location = New System.Drawing.Point(70, 33)
        Me.Textbox_Class_Name.Name = "Textbox_Class_Name"
        Me.Textbox_Class_Name.Size = New System.Drawing.Size(199, 20)
        Me.Textbox_Class_Name.TabIndex = 11
        '
        'Textbox_Class_HP
        '
        Me.Textbox_Class_HP.Location = New System.Drawing.Point(70, 102)
        Me.Textbox_Class_HP.Name = "Textbox_Class_HP"
        Me.Textbox_Class_HP.Size = New System.Drawing.Size(70, 20)
        Me.Textbox_Class_HP.TabIndex = 12
        '
        'Textbox_Class_MP
        '
        Me.Textbox_Class_MP.Location = New System.Drawing.Point(70, 128)
        Me.Textbox_Class_MP.Name = "Textbox_Class_MP"
        Me.Textbox_Class_MP.Size = New System.Drawing.Size(70, 20)
        Me.Textbox_Class_MP.TabIndex = 13
        '
        'Textbox_Class_Speed
        '
        Me.Textbox_Class_Speed.Location = New System.Drawing.Point(70, 264)
        Me.Textbox_Class_Speed.Name = "Textbox_Class_Speed"
        Me.Textbox_Class_Speed.Size = New System.Drawing.Size(34, 20)
        Me.Textbox_Class_Speed.TabIndex = 14
        '
        'Textbox_Class_Agility
        '
        Me.Textbox_Class_Agility.Location = New System.Drawing.Point(70, 235)
        Me.Textbox_Class_Agility.Name = "Textbox_Class_Agility"
        Me.Textbox_Class_Agility.Size = New System.Drawing.Size(34, 20)
        Me.Textbox_Class_Agility.TabIndex = 15
        '
        'Textbox_Class_Defense
        '
        Me.Textbox_Class_Defense.Location = New System.Drawing.Point(70, 209)
        Me.Textbox_Class_Defense.Name = "Textbox_Class_Defense"
        Me.Textbox_Class_Defense.Size = New System.Drawing.Size(34, 20)
        Me.Textbox_Class_Defense.TabIndex = 16
        '
        'Textbox_Class_Magic
        '
        Me.Textbox_Class_Magic.Location = New System.Drawing.Point(70, 183)
        Me.Textbox_Class_Magic.Name = "Textbox_Class_Magic"
        Me.Textbox_Class_Magic.Size = New System.Drawing.Size(34, 20)
        Me.Textbox_Class_Magic.TabIndex = 17
        '
        'Textbox_Class_Strength
        '
        Me.Textbox_Class_Strength.Location = New System.Drawing.Point(70, 154)
        Me.Textbox_Class_Strength.Name = "Textbox_Class_Strength"
        Me.Textbox_Class_Strength.Size = New System.Drawing.Size(34, 20)
        Me.Textbox_Class_Strength.TabIndex = 18
        '
        'RichTextBox_Class_Description
        '
        Me.RichTextBox_Class_Description.Location = New System.Drawing.Point(70, 59)
        Me.RichTextBox_Class_Description.Name = "RichTextBox_Class_Description"
        Me.RichTextBox_Class_Description.Size = New System.Drawing.Size(199, 37)
        Me.RichTextBox_Class_Description.TabIndex = 19
        Me.RichTextBox_Class_Description.Text = ""
        '
        'frmClassEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 334)
        Me.Controls.Add(Me.RichTextBox_Class_Description)
        Me.Controls.Add(Me.Textbox_Class_Strength)
        Me.Controls.Add(Me.Textbox_Class_Magic)
        Me.Controls.Add(Me.Textbox_Class_Defense)
        Me.Controls.Add(Me.Textbox_Class_Agility)
        Me.Controls.Add(Me.Textbox_Class_Speed)
        Me.Controls.Add(Me.Textbox_Class_MP)
        Me.Controls.Add(Me.Textbox_Class_HP)
        Me.Controls.Add(Me.Textbox_Class_Name)
        Me.Controls.Add(Me.Label_Class_Speed)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label_Class_Defense)
        Me.Controls.Add(Me.Label_Class_Magic)
        Me.Controls.Add(Me.Label_Class_Strength)
        Me.Controls.Add(Me.Label_Class_MP)
        Me.Controls.Add(Me.Label_Class_HP)
        Me.Controls.Add(Me.Label_Class_Description)
        Me.Controls.Add(Me.Label_Class_Name)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label_Class_Creation)
        Me.Name = "frmClassEditor"
        Me.Text = "frmClassesEditor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Class_Creation As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label_Class_Name As System.Windows.Forms.Label
    Friend WithEvents Label_Class_Description As System.Windows.Forms.Label
    Friend WithEvents Label_Class_HP As System.Windows.Forms.Label
    Friend WithEvents Label_Class_MP As System.Windows.Forms.Label
    Friend WithEvents Label_Class_Strength As System.Windows.Forms.Label
    Friend WithEvents Label_Class_Magic As System.Windows.Forms.Label
    Friend WithEvents Label_Class_Defense As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label_Class_Speed As System.Windows.Forms.Label
    Friend WithEvents Textbox_Class_Name As System.Windows.Forms.TextBox
    Friend WithEvents Textbox_Class_HP As System.Windows.Forms.TextBox
    Friend WithEvents Textbox_Class_MP As System.Windows.Forms.TextBox
    Friend WithEvents Textbox_Class_Speed As System.Windows.Forms.TextBox
    Friend WithEvents Textbox_Class_Agility As System.Windows.Forms.TextBox
    Friend WithEvents Textbox_Class_Defense As System.Windows.Forms.TextBox
    Friend WithEvents Textbox_Class_Magic As System.Windows.Forms.TextBox
    Friend WithEvents Textbox_Class_Strength As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox_Class_Description As System.Windows.Forms.RichTextBox
End Class
