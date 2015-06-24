Imports System.IO

Public Class frmMapProperties
    Dim curBorder As Byte

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        With map
            .MapName = txtName.Text
            .MapType = lstTypes.SelectedIndex
        End With
        Me.Close()
    End Sub

    Private Sub frmMapProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With map
            txtName.Text = .MapName
            lstTypes.SelectedIndex = .MapType
        End With

        lstMaps.Items.Add("Aucune")
        For i = 0 To Directory.GetFiles("Maps").Count - 1
            lstMaps.Items.Add(Directory.GetFiles("Maps")(i))
        Next

        LoadBorderMaps()
    End Sub

    Private Sub LoadBorderMaps()
        Dim buttons As New List(Of Button)
        buttons.AddRange(New List(Of [Button]) From
        {
            btBorder1, btBorder2, btBorder3, btBorder4,
            btBorder5, btBorder6, btBorder7, btBorder8
        })

        For i As Integer = 0 To buttons.Count
            If (i > 7) Then
                Exit For
            End If
            If (Not map.NeighborIndex(i) < 0) Then
                buttons.ElementAt(i).Text = map.NeighborIndex(i).ToString()
            End If
        Next
    End Sub

    Private Sub btBorder1_Click(sender As Object, e As EventArgs) Handles btBorder1.Click
        curBorder = 0
        pnlSelect.Visible = True
    End Sub

    Private Sub btBorder2_Click(sender As Object, e As EventArgs) Handles btBorder2.Click
        curBorder = 1
        pnlSelect.Visible = True
    End Sub

    Private Sub btBorder3_Click(sender As Object, e As EventArgs) Handles btBorder3.Click
        curBorder = 2
        pnlSelect.Visible = True
    End Sub

    Private Sub btBorder4_Click(sender As Object, e As EventArgs) Handles btBorder4.Click
        curBorder = 3
        pnlSelect.Visible = True
    End Sub

    Private Sub btBorder5_Click(sender As Object, e As EventArgs) Handles btBorder5.Click
        curBorder = 4
        pnlSelect.Visible = True
    End Sub

    Private Sub btBorder6_Click(sender As Object, e As EventArgs) Handles btBorder6.Click
        curBorder = 5
        pnlSelect.Visible = True
    End Sub

    Private Sub btBorder7_Click(sender As Object, e As EventArgs) Handles btBorder7.Click
        curBorder = 6
        pnlSelect.Visible = True
    End Sub

    Private Sub btBorder8_Click(sender As Object, e As EventArgs) Handles btBorder8.Click
        curBorder = 7
        pnlSelect.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pnlSelect.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' TODO : Charger la map plutôt que l'index seulement
        'map.MapsBorder(curBorder).Index = lstMaps.SelectedIndex
        ' exemple : map.MapsBorder(curBorder) = LoadedMaps(lstMaps.SelectedIndex)
        '           map.MapsBorder(curBorder).Index = UnIndexDeRefUnique
        If (lstMaps.SelectedIndex > 0) Then
            Dim neighborMap = GameMap.Load(lstMaps.SelectedIndex - 1)
            If (Not IsNothing(neighborMap)) Then
                map.NeighborIndex(curBorder) = neighborMap.Index
            End If

            LoadBorderMaps()
        End If

        pnlSelect.Visible = False
    End Sub

    Private Sub pnlSelect_VisibleChanged(sender As Object, e As EventArgs) Handles pnlSelect.VisibleChanged
        If pnlSelect.Visible And Not IsNothing(map.NeighborIndex(curBorder)) Then
            lstMaps.SelectedIndex = map.NeighborIndex(curBorder) + 1
        End If
    End Sub
End Class