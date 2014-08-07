<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlGameNPC
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.npcPicture = New System.Windows.Forms.PictureBox()
        Me.npcName = New System.Windows.Forms.Label()
        CType(Me.npcPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'npcPicture
        '
        Me.npcPicture.Location = New System.Drawing.Point(3, 3)
        Me.npcPicture.Name = "npcPicture"
        Me.npcPicture.Size = New System.Drawing.Size(32, 48)
        Me.npcPicture.TabIndex = 0
        Me.npcPicture.TabStop = False
        '
        'npcName
        '
        Me.npcName.AutoSize = True
        Me.npcName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.npcName.Location = New System.Drawing.Point(57, 19)
        Me.npcName.Name = "npcName"
        Me.npcName.Size = New System.Drawing.Size(40, 16)
        Me.npcName.TabIndex = 1
        Me.npcName.Text = "Nom"
        '
        'ctrlGameNPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.npcName)
        Me.Controls.Add(Me.npcPicture)
        Me.Name = "ctrlGameNPC"
        Me.Size = New System.Drawing.Size(200, 56)
        CType(Me.npcPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents npcPicture As System.Windows.Forms.PictureBox
    Friend WithEvents npcName As System.Windows.Forms.Label

End Class
