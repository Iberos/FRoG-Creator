Public Class ctrlGameMovement

    Public Sub New(movement As String)
        InitializeComponent()

        lblMovement.Text = movement

        Select Case movement
            Case "Haut"
                picMovement.Image = My.Resources.Arrow_up
            Case "Bas"
                picMovement.Image = My.Resources.Arrow_down
            Case "Gauche"
                picMovement.Image = My.Resources.Arrow_left
            Case "Droite"
                picMovement.Image = My.Resources.Arrow_right
            Case Else
                Exit Select
        End Select
    End Sub

    Private Sub picRemove_Click(sender As Object, e As EventArgs) Handles picRemove.Click
        Me.Parent.Controls.Remove(Me)
        RefreshPanel()
        'TODO Supprimer de la liste des déplacements
    End Sub

    Private Sub RefreshPanel()
        Dim i = 0
        For Each ctrlMovement As ctrlGameMovement In npcConfigurator.pnlListNPCMovement.Controls
            ctrlMovement.Location = New Point(0, (ctrlMovement.Height + 2) * i - npcConfigurator.pnlListNPCMovement.VerticalScroll.Value)
            i += 1
        Next
    End Sub
End Class
