Public Class frmConfigNPC

    Private Sub rdbtn_custom_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtn_custom.CheckedChanged
        grp_customMovement.Enabled = rdbtn_custom.Checked
    End Sub

    Private Sub rdbtn_static_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtn_static.CheckedChanged
        cmb_NPCVelocity.Enabled = Not rdbtn_static.Checked
    End Sub

    Private Sub rb_NPCAggressive_CheckedChanged(sender As Object, e As EventArgs) Handles rb_NPCAggressive.CheckedChanged
        grp_NPCAggresiveArea.Enabled = rb_NPCAggressive.Checked
    End Sub
End Class