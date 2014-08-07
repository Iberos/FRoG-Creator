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
End Class