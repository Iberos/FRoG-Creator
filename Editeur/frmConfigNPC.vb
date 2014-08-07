Public Class frmConfigNPC

    Private Sub rbNPCAggressive_CheckedChanged(sender As Object, e As EventArgs) Handles rbNPCAggressive.CheckedChanged
        grpNPCAggresiveArea.Enabled = rbNPCAggressive.Checked
    End Sub

    Private Sub rdbtnStatic_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnStatic.CheckedChanged
        cmbNPCVelocity.Enabled = Not rdbtnStatic.Checked
    End Sub

    Private Sub rdbtnCustom_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnCustom.CheckedChanged
        grpCustomMovement.Enabled = rdbtnCustom.Checked
    End Sub

    Private Sub frmConfigNPC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Prototype de création
        Dim currentNpc As String = "Sprite.png" ' Type "GameNPC" et non un String
        'TODO Création de la classe GameNPC
        Dim npc As New ctrlGameNPC(currentNpc)
        pnlNPCList.Controls.Add(npc)

        For i As Integer = 0 To 10
            npc = New ctrlGameNPC(currentNpc)
            npc.Location = New Point(0, (npc.Height + 2) * i)
            pnlNPCList.Controls.Add(npc)
        Next
    End Sub
End Class