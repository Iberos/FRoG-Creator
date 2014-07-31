Public Class frmDataEditor

    Private Sub frmDataEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.Load()
    End Sub

    Private Sub frmDataEditor_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        frmMapEditor.loadBar.Value = 0
    End Sub
End Class