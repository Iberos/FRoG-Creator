Imports System.Windows.Forms

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

    Public Sub Initialize()
        ' Chargement et ajout des PNJs
        Dim i = 0
        For Each currentNpc As GameNPC In lstNPCs
            Dim ctrlNpc As New ctrlGameNPC(currentNpc)
            ctrlNpc.Location = New Point(0, (ctrlNpc.Height + 2) * i)
            pnlNPCList.Controls.Add(ctrlNpc)
            i += 1
        Next

        ' Initialisation des items de déplacements
        'TODO CHarger déplacements du pnj courant
    End Sub

    Private Sub btnAddNPCMovement_Click(sender As Object, e As EventArgs) Handles btnAddNPCMovement.Click
        Dim ctrlMovement As New ctrlGameMovement(cmbEnableNPCMovements.Text)
        ctrlMovement.Location = New Point(0, (ctrlMovement.Height + 2) * pnlListNPCMovement.Controls.Count)
        pnlListNPCMovement.Controls.Add(ctrlMovement)
        'TODO Ajouter à la liste des déplacements
    End Sub
End Class