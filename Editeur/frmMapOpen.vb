Imports System.IO
Public Class frmMapOpen

    Private Sub frmMapOpen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To Directory.GetFiles("Maps").Count - 1
            lstMaps.Items.Add(Directory.GetFiles("Maps")(i))
        Next
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        lstMaps.Items.Clear()
        If txtName.Text = "" Then
            For i = 0 To Directory.GetFiles("Maps").Count - 1
                lstMaps.Items.Add(Directory.GetFiles("Maps")(i))
            Next
        Else
            For i = 0 To Directory.GetFiles("Maps").Count - 1
                If Directory.GetFiles("Maps")(i).ToLower.Contains(txtName.Text.ToLower) Then
                    lstMaps.Items.Add(Directory.GetFiles("Maps")(i))
                End If
            Next
        End If
    End Sub

    Private Sub lstMaps_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstMaps.MouseDoubleClick
        ' TODO : Erreur retrouvée => Chaine trop longue (?) À voir ! [Après double clic]
        curMap = Int(lstMaps.Text.Substring(8).Split(".")(0))
        map.LoadIntoEditor(curMap)
        game.DrawMap()
        frmMapEditor.pnlStart.Visible = False
    End Sub
End Class