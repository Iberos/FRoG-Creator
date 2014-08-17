Imports System.Windows.Forms

Public Class frmConfigNPC

    Public curAttrNum As Integer
    Private attrLoaded As Boolean = False
    Private X, Y As Integer

    Private Sub rbNPCAggressive_CheckedChanged(sender As Object, e As EventArgs) Handles rbNPCAggressive.CheckedChanged
        grpNPCAggresiveArea.Enabled = rbNPCAggressive.Checked
    End Sub

    Private Sub rdbtnStatic_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnStatic.CheckedChanged
        cmbNPCVelocity.Enabled = Not rdbtnStatic.Checked
    End Sub

    Private Sub rdbtnCustom_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnCustom.CheckedChanged
        grpCustomMovement.Enabled = rdbtnCustom.Checked
    End Sub

    Public Sub Initialize()
        ' Chargement et ajout des PNJs
        Dim i = 0
        For Each currentNpc As GameNPC In lstNPCs
            Dim ctrlNpc As New ctrlGameNPC(currentNpc)
            ctrlNpc.Location = New Point(0, (ctrlNpc.Height + 2) * i)
            pnlNPCList.Controls.Add(ctrlNpc)
            i += 1
        Next

        ' Initialisation des items de déplacements
        'TODO CHarger déplacements du pnj courant
    End Sub

    Private Sub btnAddNPCMovement_Click(sender As Object, e As EventArgs) Handles btnAddNPCMovement.Click
        Dim ctrlMovement As New ctrlGameMovement(cmbEnableNPCMovements.Text)
        ctrlMovement.Location = New Point(0, (ctrlMovement.Height + 2) * pnlListNPCMovement.Controls.Count)
        pnlListNPCMovement.Controls.Add(ctrlMovement)
        'TODO Ajouter à la liste des déplacements
    End Sub

    Private Sub btnNPCValid_Click(sender As Object, e As EventArgs) Handles btnNPCValid.Click
        SaveNPC()
        Me.Close()
    End Sub

    Public Sub Open(attr As Attribute, X As Integer, Y As Integer)
        ResetForm()
        Me.X = X
        Me.Y = Y
        If attr.Type = 4 Then
            If attr.sender Is Nothing Then
                Me.curAttrNum = Nothing
            Else
                Me.curAttrNum = attr.sender(0)
                LoadNPC(Me.curAttrNum)
            End If
        End If

        Me.ShowDialog()
    End Sub

    Public Sub ResetForm()
        Me.attrLoaded = False
        Me.curAttrNum = Nothing
        Me.rdbtnStatic.Checked = True
        Me.rdbtnRand.Checked = False
        Me.rdbtnPerimeter.Checked = False
        Me.rdbtnCustom.Checked = False
        Me.pnlListNPCMovement.Controls.Clear()
    End Sub

    Private Sub LoadNPC(index As Integer)
        If index < map.mapNPCs.Count Then
            With map.mapNPCs(index)
                Me.rdbtnStatic.Checked = .standing
                Me.rdbtnRand.Checked = .random
                Me.rdbtnPerimeter.Checked = .perimeter
                Me.rdbtnCustom.Checked = .custom
            End With
            '...
            attrLoaded = True
        End If
    End Sub

    Private Sub SaveNPC()
        Dim npc = New MapNPC(Nothing, X, Y)
        With npc
            .standing = Me.rdbtnStatic.Checked
            .random = Me.rdbtnRand.Checked
            .perimeter = Me.rdbtnPerimeter.Checked
            .custom = Me.rdbtnCustom.Checked
        End With

        If attrLoaded Then
            map.mapNPCs(Me.curAttrNum) = npc
        Else
            map.mapNPCs.Add(npc)
            Me.curAttrNum = map.mapNPCs.Count - 1
            With map.attribute(X, Y)
                .Type = 4
                ReDim .sender(0)
                .sender(0) = Me.curAttrNum
            End With
        End If
    End Sub

End Class