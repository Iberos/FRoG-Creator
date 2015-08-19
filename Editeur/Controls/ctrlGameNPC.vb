Public Class ctrlGameNPC

    Dim Selected As Boolean = False

    Public Sub New(ByVal npc As GameNPC)
        InitializeComponent()
        npcPicture.Image = npc.GetView(True)
        npcName.Text = npc.name
    End Sub

    Private Sub ctrlGameNPC_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.Selected = Not Me.Selected
        RefreshSelect()
    End Sub

    Private Sub npcName_Click(sender As Object, e As EventArgs) Handles npcName.Click
        Me.Selected = Not Me.Selected
        RefreshSelect()
    End Sub

    Private Sub npcPicture_Click(sender As Object, e As EventArgs) Handles npcPicture.Click
        Me.Selected = Not Me.Selected
        RefreshSelect()
    End Sub

    Private Sub RefreshSelect()
        If Me.Selected Then
            Me.BackColor = Color.PaleGreen

            ' Deselection des autres controls
            For Each ctrlNPC As ctrlGameNPC In Me.Parent.Controls
                If Not ctrlNPC.Equals(Me) Then
                    ctrlNPC.Deselect()
                End If
            Next
        Else
            Me.BackColor = Color.White
        End If
    End Sub

    Private Sub Deselect()
        Me.Selected = False
        RefreshSelect()
    End Sub
End Class
