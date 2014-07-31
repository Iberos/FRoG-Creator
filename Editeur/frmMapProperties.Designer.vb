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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlSelect = New System.Windows.Forms.Panel()
        Me.lstMaps = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btBorder8 = New System.Windows.Forms.Button()
        Me.btBorder7 = New System.Windows.Forms.Button()
        Me.btBorder4 = New System.Windows.Forms.Button()
        Me.btBorder5 = New System.Windows.Forms.Button()
        Me.btBorder6 = New System.Windows.Forms.Button()
        Me.btBorder3 = New System.Windows.Forms.Button()
        Me.btBorder2 = New System.Windows.Forms.Button()
        Me.btBorder1 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstTypes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.pnlSelect.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pnlSelect)
        Me.GroupBox1.Controls.Add(Me.btBorder8)
        Me.GroupBox1.Controls.Add(Me.btBorder7)
        Me.GroupBox1.Controls.Add(Me.btBorder4)
        Me.GroupBox1.Controls.Add(Me.btBorder5)
        Me.GroupBox1.Controls.Add(Me.btBorder6)
        Me.GroupBox1.Controls.Add(Me.btBorder3)
        Me.GroupBox1.Controls.Add(Me.btBorder2)
        Me.GroupBox1.Controls.Add(Me.btBorder1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 285)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alentours"
        '
        'pnlSelect
        '
        Me.pnlSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSelect.Controls.Add(Me.lstMaps)
        Me.pnlSelect.Controls.Add(Me.Button2)
        Me.pnlSelect.Controls.Add(Me.Button1)
        Me.pnlSelect.Location = New System.Drawing.Point(56, 109)
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(101, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btBorder8
        '
        Me.btBorder8.Location = New System.Drawing.Point(200, 191)
        Me.btBorder8.Name = "btBorder8"
        Me.btBorder8.Size = New System.Drawing.Size(80, 80)
        Me.btBorder8.TabIndex = 7
        Me.btBorder8.UseVisualStyleBackColor = True
        '
        'btBorder7
        '
        Me.btBorder7.Location = New System.Drawing.Point(114, 191)
        Me.btBorder7.Name = "btBorder7"
        Me.btBorder7.Size = New System.Drawing.Size(80, 80)
        Me.btBorder7.TabIndex = 6
        Me.btBorder7.UseVisualStyleBackColor = True
        '
        'btBorder4
        '
        Me.btBorder4.Location = New System.Drawing.Point(28, 105)
        Me.btBorder4.Name = "btBorder4"
        Me.btBorder4.Size = New System.Drawing.Size(80, 80)
        Me.btBorder4.TabIndex = 5
        Me.btBorder4.UseVisualStyleBackColor = True
        '
        'btBorder5
        '
        Me.btBorder5.Location = New System.Drawing.Point(200, 105)
        Me.btBorder5.Name = "btBorder5"
        Me.btBorder5.Size = New System.Drawing.Size(80, 80)
        Me.btBorder5.TabIndex = 4
        Me.btBorder5.UseVisualStyleBackColor = True
        '
        'btBorder6
        '
        Me.btBorder6.Location = New System.Drawing.Point(28, 191)
        Me.btBorder6.Name = "btBorder6"
        Me.btBorder6.Size = New System.Drawing.Size(80, 80)
        Me.btBorder6.TabIndex = 3
        Me.btBorder6.UseVisualStyleBackColor = True
        '
        'btBorder3
        '
        Me.btBorder3.Location = New System.Drawing.Point(200, 19)
        Me.btBorder3.Name = "btBorder3"
        Me.btBorder3.Size = New System.Drawing.Size(80, 80)
        Me.btBorder3.TabIndex = 2
        Me.btBorder3.UseVisualStyleBackColor = True
        '
        'btBorder2
        '
        Me.btBorder2.Location = New System.Drawing.Point(114, 19)
        Me.btBorder2.Name = "btBorder2"
        Me.btBorder2.Size = New System.Drawing.Size(80, 80)
        Me.btBorder2.TabIndex = 1
        Me.btBorder2.UseVisualStyleBackColor = True
        '
        'btBorder1
        '
        Me.btBorder1.Location = New System.Drawing.Point(28, 19)
        Me.btBorder1.Name = "btBorder1"
        Me.btBorder1.Size = New System.Drawing.Size(80, 80)
        Me.btBorder1.TabIndex = 0
        Me.btBorder1.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(244, 390)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 3
        Me.Button9.Text = "Valider"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstTypes)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 81)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Général"
        '
        'lstTypes
        '
        Me.lstTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstTypes.FormattingEnabled = True
        Me.lstTypes.Items.AddRange(New Object() {"Normale", "Sans PVP", "Intérieur"})
        Me.lstTypes.Location = New System.Drawing.Point(105, 52)
        Me.lstTypes.Name = "lstTypes"
        Me.lstTypes.Size = New System.Drawing.Size(196, 21)
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
        Me.txtName.Location = New System.Drawing.Point(105, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(196, 20)
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
        Me.ClientSize = New System.Drawing.Size(335, 419)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMapProperties"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proprieté de la map"
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlSelect.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btBorder8 As System.Windows.Forms.Button
    Friend WithEvents btBorder7 As System.Windows.Forms.Button
    Friend WithEvents btBorder4 As System.Windows.Forms.Button
    Friend WithEvents btBorder5 As System.Windows.Forms.Button
    Friend WithEvents btBorder6 As System.Windows.Forms.Button
    Friend WithEvents btBorder3 As System.Windows.Forms.Button
    Friend WithEvents btBorder2 As System.Windows.Forms.Button
    Friend WithEvents btBorder1 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents pnlSelect As System.Windows.Forms.Panel
    Friend WithEvents lstMaps As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstTypes As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
