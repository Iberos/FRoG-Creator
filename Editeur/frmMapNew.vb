Imports System.IO

Public Class frmMapNew
    Dim tmp As Integer

    Private Sub frmMapNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.GetFiles("Maps").Count = 0 Then tmp = Int(Split(Split(Directory.GetFiles("Maps")(Directory.GetFiles("Maps").Count - 1), "p")(2), ".")(0)) + 1 Else tmp = 0
        txtIndex.Text = tmp
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(txtIndex.Text) Then
            curMap = Int(txtIndex.Text)
            map = New GameMap
            game.DrawMap()
            frmMapEditor.pnlStart.Visible = False
            Me.Close()
        Else
            txtIndex.Text = tmp
        End If
    End Sub
End Class