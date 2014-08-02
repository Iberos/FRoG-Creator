Public Class frmDataEditor

    Private Sub frmDataEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.Load()
        For i = 0 To lstClasses.Count - 1
            lstBClasses.Items.Add(lstClasses(i).Name)
        Next
        lstBClasses.Items.Add("Nouveau...")
        lstBClasses.SelectedIndex = 0
    End Sub

    Private Sub frmDataEditor_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        frmMapEditor.loadBar.Value = 0
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then 'Classes
            For i = 0 To lstClasses.Count - 1
                lstBClasses.Items.Add(lstClasses(i).Name)
            Next
            lstBClasses.Items.Add("Nouveau...")
            lstBClasses.SelectedIndex = 0
        ElseIf TabControl1.SelectedIndex = 1 Then ' Objets
            For i = 0 To lstItems.Count - 1
                lstBItems.Items.Add(lstItems(i).Name)
            Next
            lstBItems.Items.Add("Nouveau...")
            lstBItems.SelectedIndex = 0
        ElseIf TabControl1.SelectedIndex = 2 Then ' Sorts
            For i = 0 To lstSpells.Count - 1
                lstBSpells.Items.Add(lstSpells(i).Name)
            Next
            lstBSpells.Items.Add("Nouveau...")
            lstBSpells.SelectedIndex = 0
        ElseIf TabControl1.SelectedIndex = 3 Then ' PNJs
            For i = 0 To lstNPCs.Count - 1
                lstBNPCs.Items.Add(lstNPCs(i).Name)
            Next
            lstBNPCs.Items.Add("Nouveau...")
            lstBNPCs.SelectedIndex = 0
        End If
    End Sub
End Class