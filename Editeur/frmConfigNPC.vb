Public Class frmConfigNPC

    Private Sub rdbtn_custom_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtn_custom.CheckedChanged
            grp_customMovement.Enabled = rdbtn_custom.Checked
    End Sub
End Class