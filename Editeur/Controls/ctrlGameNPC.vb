Public Class ctrlGameNPC

    Dim Selected As Boolean = False

    Public Sub New(ByVal npc As String)
        InitializeComponent()

        Dim npcBitmap = New Bitmap(npc) 'npc.image (équivalent)
        npcPicture.Size = New Point(npcBitmap.PhysicalDimension.Width / 4, npcBitmap.PhysicalDimension.Height / 4)
        npcPicture.Image = npcBitmap
        npcName.Text = "Exemple"
    End Sub

    Private Sub ctrlGameNPC_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        RefreshSelect()
    End Sub

    Private Sub npcName_Click(sender As Object, e As EventArgs) Handles npcName.Click
        RefreshSelect()
    End Sub

    Private Sub npcPicture_Click(sender As Object, e As EventArgs) Handles npcPicture.Click
        RefreshSelect()
    End Sub

    Private Sub RefreshSelect()
        Me.Selected = Not Me.Selected

        If Me.Selected Then
            Me.BackColor = Color.PaleGreen
        Else
            Me.BackColor = Color.White
        End If
    End Sub
End Class
