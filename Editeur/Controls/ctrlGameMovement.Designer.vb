<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlGameMovement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlGameMovement))
        Me.lblMovement = New System.Windows.Forms.Label()
        Me.picMovement = New System.Windows.Forms.PictureBox()
        Me.picRemove = New System.Windows.Forms.PictureBox()
        CType(Me.picMovement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMovement
        '
        Me.lblMovement.AutoSize = True
        Me.lblMovement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovement.Location = New System.Drawing.Point(42, 6)
        Me.lblMovement.Name = "lblMovement"
        Me.lblMovement.Size = New System.Drawing.Size(12, 16)
        Me.lblMovement.TabIndex = 1
        Me.lblMovement.Text = "."
        '
        'picMovement
        '
        Me.picMovement.Location = New System.Drawing.Point(161, 2)
        Me.picMovement.Name = "picMovement"
        Me.picMovement.Size = New System.Drawing.Size(24, 24)
        Me.picMovement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMovement.TabIndex = 2
        Me.picMovement.TabStop = False
        '
        'picRemove
        '
        Me.picRemove.Image = CType(resources.GetObject("picRemove.Image"), System.Drawing.Image)
        Me.picRemove.Location = New System.Drawing.Point(3, 2)
        Me.picRemove.Name = "picRemove"
        Me.picRemove.Size = New System.Drawing.Size(24, 24)
        Me.picRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRemove.TabIndex = 0
        Me.picRemove.TabStop = False
        '
        'ctrlGameMovement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.picMovement)
        Me.Controls.Add(Me.lblMovement)
        Me.Controls.Add(Me.picRemove)
        Me.Name = "ctrlGameMovement"
        Me.Size = New System.Drawing.Size(188, 27)
        CType(Me.picMovement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRemove, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picRemove As System.Windows.Forms.PictureBox
    Friend WithEvents lblMovement As System.Windows.Forms.Label
    Friend WithEvents picMovement As System.Windows.Forms.PictureBox

End Class
