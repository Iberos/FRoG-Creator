Imports System.IO

Public Class frmMapProperties

    Private WorldMap As GameWorldMap
    Private CurrentWorldMapButton As ExtendedButton

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnValid.Click
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

        ' Création de la world map
        WorldMap = New GameWorldMap(Me.pnlWorldMap)
        ' Link de click bouton en panel WorldMap
        AddHandler WorldMap.EntityClick, AddressOf WorldMapEntity_Click
    End Sub

    Private Sub btnCancelPanelSelect_Click(sender As Object, e As EventArgs) Handles btnCancelPanelSelect.Click
        pnlSelect.Visible = False
    End Sub

    Private Sub btnValidPanelSelect_Click(sender As Object, e As EventArgs) Handles btnValidPanelSelect.Click

        If (Not IsNothing(Me.CurrentWorldMapButton) And lstMaps.SelectedIndex > 0) Then
            Me.CurrentWorldMapButton.Text = lstMaps.SelectedIndex.ToString()
        End If

        Me.CurrentWorldMapButton = Nothing
        pnlSelect.Visible = False
    End Sub

    ' Lors d'un click sur un bouton du panel WorldMap
    Private Sub WorldMapEntity_Click(sender As Object, e As EventArgs)
        pnlSelect.Visible = True
        Me.CurrentWorldMapButton = DirectCast(sender, ExtendedButton)
    End Sub

End Class