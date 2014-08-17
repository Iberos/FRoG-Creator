Public Class frmDataEditor

    Private Sub frmDataEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.Load()
        For i = 0 To lstClasses.Count - 1
            lstBClasses.Items.Add(lstClasses(i).name)
        Next
        lstBClasses.Items.Add("Nouveau...")
        lstBClasses.SelectedIndex = 0
    End Sub

    Private Sub frmDataEditor_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        frmMapEditor.loadBar.Value = 0
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tab.SelectedIndexChanged
        If Tab.SelectedIndex = 0 Then 'Classes
            lstBClasses.Items.Clear()
            For i = 0 To lstClasses.Count - 1
                lstBClasses.Items.Add(lstClasses(i).name)
            Next
            lstBClasses.Items.Add("Nouveau...")
            lstBClasses.SelectedIndex = 0
        ElseIf Tab.SelectedIndex = 1 Then ' Objets
            lstBItems.Items.Clear()
            For i = 0 To lstItems.Count - 1
                lstBItems.Items.Add(lstItems(i).Name)
            Next
            lstBItems.Items.Add("Nouveau...")
            lstBItems.SelectedIndex = 0
        ElseIf Tab.SelectedIndex = 2 Then ' Sorts
            lstBSpells.Items.Clear()
            For i = 0 To lstSpells.Count - 1
                lstBSpells.Items.Add(lstSpells(i).Name)
            Next
            lstBSpells.Items.Add("Nouveau...")
            lstBSpells.SelectedIndex = 0
        ElseIf Tab.SelectedIndex = 3 Then ' PNJs
            lstBNPCs.Items.Clear()
            For i = 0 To lstNPCs.Count - 1
                lstBNPCs.Items.Add(lstNPCs(i).Name)
            Next
            lstBNPCs.Items.Add("Nouveau...")
            lstBNPCs.SelectedIndex = 0
        End If
    End Sub

#Region "Classes"

    Private Sub Class_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub lstBClasses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBClasses.SelectedIndexChanged
        If Not lstBClasses.SelectedIndex = lstBClasses.Items.Count - 1 Then
            With lstClasses(lstBClasses.SelectedIndex)
                txtClassName.Text = .name
                txtClassDesc.Text = .description
                txtClassHP.Text = .HP
                txtClassMP.Text = .MP
                txtClassStrength.Text = .strength
                txtClassMagic.Text = .magic
                txtClassDef.Text = .defense
                txtClassAgility.Text = .agility
                txtClassSpeed.Text = .speed
            End With
        Else
            txtClassName.Text = ""
            txtClassDesc.Text = ""
            txtClassHP.Text = "0"
            txtClassMP.Text = "0"
            txtClassStrength.Text = "0"
            txtClassMagic.Text = "0"
            txtClassDef.Text = "0"
            txtClassAgility.Text = "0"
            txtClassSpeed.Text = "0"
        End If
    End Sub

    Private Sub btClassSave_Click(sender As Object, e As EventArgs)
        Dim tmpIndex As Short = lstBClasses.SelectedIndex

        If Not lstBClasses.SelectedIndex = lstBClasses.Items.Count - 1 Then
            With lstClasses(lstBClasses.SelectedIndex)
                .name = txtClassName.Text
                .description = txtClassDesc.Text
                .HP = txtClassHP.Text
                .MP = txtClassMP.Text
                .strength = txtClassStrength.Text
                .magic = txtClassMagic.Text
                .defense = txtClassDef.Text
                .agility = txtClassAgility.Text
                .speed = txtClassSpeed.Text
            End With
        Else
            Dim tmp As New GameClass
            With tmp
                .name = txtClassName.Text
                .description = txtClassDesc.Text
                .HP = txtClassHP.Text
                .MP = txtClassMP.Text
                .strength = txtClassStrength.Text
                .magic = txtClassMagic.Text
                .defense = txtClassDef.Text
                .agility = txtClassAgility.Text
                .speed = txtClassSpeed.Text
            End With
            lstClasses.Add(tmp)
        End If

        lstClasses(tmpIndex).Save()
        lstBClasses.Items.Clear()

        For i = 0 To lstClasses.Count - 1
            lstBClasses.Items.Add(lstClasses(i).name)
        Next

        lstBClasses.Items.Add("Nouveau...")
        lstBClasses.SelectedIndex = tmpIndex
    End Sub

#End Region

#Region "Items"

    Private Sub Item_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub lstBItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBItems.SelectedIndexChanged
        If Not lstBItems.SelectedIndex = lstBItems.Items.Count - 1 Then
            With lstItems(lstBItems.SelectedIndex)
                txtItemName.Text = .name
                txtItemDesc.Text = .description
                lstItemType.SelectedIndex = .type
                txtItemHP.Text = .HP
                txtItemMP.Text = .HP
            End With
        Else
            txtItemName.Text = ""
            txtItemDesc.Text = ""
            lstItemType.SelectedIndex = 0
            txtItemHP.Text = "0"
            txtItemMP.Text = "0"
        End If
    End Sub

    Private Sub btItemSave_Click(sender As Object, e As EventArgs)
        Dim tmpIndex As Short = lstBItems.SelectedIndex()

        If Not lstBItems.SelectedIndex = lstBItems.Items.Count - 1 Then
            With lstItems(lstBItems.SelectedIndex)
                .name = txtItemName.Text
                .description = txtItemDesc.Text
                .type = lstItemType.SelectedIndex
                .HP = txtItemHP.Text
                .MP = txtItemMP.Text
            End With
        Else
            Dim tmp As New GameItem
            With tmp
                .name = txtItemName.Text
                .description = txtItemDesc.Text
                .type = lstItemType.SelectedIndex
                .HP = txtItemHP.Text
                .MP = txtItemMP.Text
            End With
            lstItems.Add(tmp)
        End If

        lstItems(tmpIndex).Save()
        lstBItems.Items.Clear()

        For i = 0 To lstItems.Count - 1
            lstBItems.Items.Add(lstItems(i).name)
        Next

        lstBItems.Items.Add("Nouveau...")
        lstBItems.SelectedIndex = tmpIndex
    End Sub

#End Region

#Region "Spells"

    Private Sub Spell_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub lstBSpells_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBSpells.SelectedIndexChanged
        If Not lstBSpells.SelectedIndex = lstBSpells.Items.Count - 1 Then
            With lstSpells(lstBSpells.SelectedIndex)
                txtSpellName.Text = .name
                lstSpellType.SelectedIndex = .type
                txtSpellDesc.Text = .description
                txtSpellDamage.Text = .damage
            End With
        Else
            txtSpellName.Text = ""
            lstSpellType.SelectedIndex = 0
            txtSpellDesc.Text = ""
            txtSpellDamage.Text = "0"
        End If
    End Sub


    Private Sub btSpellSave_Click(sender As Object, e As EventArgs)
        Dim tmpIndex As Short = lstBSpells.SelectedIndex

        If Not lstBSpells.SelectedIndex = lstBSpells.Items.Count - 1 Then
            With lstSpells(lstBSpells.SelectedIndex)
                .name = txtSpellName.Text
                .type = lstSpellType.SelectedIndex
                .description = txtSpellDesc.Text
                .damage = txtSpellDamage.Text
            End With
        Else
            Dim tmp As New GameSpell
            With tmp
                .name = txtSpellName.Text
                .type = lstSpellType.SelectedIndex
                .description = txtSpellDesc.Text
                .damage = txtSpellDamage.Text
            End With
            lstSpells.Add(tmp)
        End If

        lstSpells(tmpIndex).Save()
        lstBSpells.Items.Clear()

        For i = 0 To lstSpells.Count - 1
            lstBSpells.Items.Add(lstSpells(i).name)
        Next

        lstBSpells.Items.Add("Nouveau...")
        lstBSpells.SelectedIndex = tmpIndex
    End Sub

    Private Sub lstSpellType_SelectedIndexChanged(sender As Object, e As EventArgs)
        If lstSpellType.SelectedIndex = 0 Then
            lblSpellDamages.Text = "Dégats"
        ElseIf lstSpellType.SelectedIndex = 1 Then
            lblSpellDamages.Text = "Soin"
        ElseIf lstSpellType.SelectedIndex = 2 Then
            lblSpellDamages.Text = "Durée"
        End If
    End Sub

#End Region

#Region "NPCs"

    Private Sub txtNPCStrength_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub lstBNPC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBNPCs.SelectedIndexChanged
        If Not lstBNPCs.SelectedIndex = lstBNPCs.Items.Count - 1 Then
            With lstNPCs(lstBNPCs.SelectedIndex)
                txtNPCName.Text = .name
                lstNPCType.SelectedIndex = .type
                txtNPCDial.Text = .dialog
                txtNPCHP.Text = .HP
                txtNPCMP.Text = .MP
                txtNPCStrength.Text = .strength
                txtNPCMagic.Text = .magic
                txtNPCDefense.Text = .defense
                txtNPCAgility.Text = .agility
                txtNPCSpeed.Text = .speed
            End With
        Else
            txtNPCName.Text = ""
            lstNPCType.SelectedIndex = 0
            txtNPCDial.Text = ""
            txtNPCHP.Text = "0"
            txtNPCMP.Text = "0"
            txtNPCStrength.Text = "0"
            txtNPCMagic.Text = "0"
            txtNPCDefense.Text = "0"
            txtNPCAgility.Text = "0"
            txtNPCSpeed.Text = "0"
        End If
        txtNPCName.Focus()
    End Sub

    Private Sub btNPCName_Click(sender As Object, e As EventArgs)
        Dim tmpIndex As Short = lstBNPCs.SelectedIndex

        If Not lstBNPCs.SelectedIndex = lstBNPCs.Items.Count - 1 Then
            With lstNPCs(lstBNPCs.SelectedIndex)
                .name = txtNPCName.Text
                .type = lstNPCType.SelectedIndex
                .dialog = txtNPCDial.Text
                .HP = txtNPCHP.Text
                .MP = txtNPCMP.Text
                .strength = txtNPCStrength.Text
                .magic = txtNPCMagic.Text
                .defense = txtNPCDefense.Text
                .agility = txtNPCAgility.Text
                .speed = txtNPCSpeed.Text
            End With
        Else
            Dim tmp As New GameNPC
            With tmp
                .name = txtNPCName.Text
                .type = lstNPCType.SelectedIndex
                .dialog = txtNPCDial.Text
                .HP = txtNPCHP.Text
                .MP = txtNPCMP.Text
                .strength = txtNPCStrength.Text
                .magic = txtNPCMagic.Text
                .defense = txtNPCDefense.Text
                .agility = txtNPCAgility.Text
                .speed = txtNPCSpeed.Text
            End With
            lstNPCs.Add(tmp)
        End If
        lstNPCs(tmpIndex).Save()
        lstBNPCs.Items.Clear()
        For i = 0 To lstNPCs.Count - 1
            lstBNPCs.Items.Add(lstNPCs(i).name)
        Next
        lstBNPCs.Items.Add("Nouveau...")
        lstBNPCs.SelectedIndex = tmpIndex
    End Sub

#End Region

End Class

