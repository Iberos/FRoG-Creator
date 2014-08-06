Public Class frmDataEditor

    'Protected Overrides ReadOnly Property CreateParams As CreateParams
    '    Get
    '        Dim cp As CreateParams = MyBase.CreateParams
    '        cp.ExStyle = &H20
    '        Return cp
    '    End Get
    'End Property

    Private Sub frmDataEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DoubleBuffered = True
        'SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        DB.Load()
        For i = 0 To lstClasses.Count - 1
            lstBClasses.Items.Add(lstClasses(i).name)
        Next
        lstBClasses.Items.Add("Nouveau...")
        lstBClasses.SelectedIndex = 0
    End Sub

    Private Sub frmDataEditor_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        pnlClass.Top = (SplitContainer1.Panel2.Height - pnlClass.Height) / 2
        pnlClass.Left = (SplitContainer1.Panel2.Width - pnlClass.Width) / 2
    End Sub

    Private Sub frmDataEditor_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        frmMapEditor.loadBar.Value = 0
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then 'Classes
            lstBClasses.Items.Clear()
            For i = 0 To lstClasses.Count - 1
                lstBClasses.Items.Add(lstClasses(i).name)
            Next
            lstBClasses.Items.Add("Nouveau...")
            lstBClasses.SelectedIndex = 0
        ElseIf TabControl1.SelectedIndex = 1 Then ' Objets
            lstBItems.Items.Clear()
            For i = 0 To lstItems.Count - 1
                lstBItems.Items.Add(lstItems(i).Name)
            Next
            lstBItems.Items.Add("Nouveau...")
            lstBItems.SelectedIndex = 0
        ElseIf TabControl1.SelectedIndex = 2 Then ' Sorts
            lstBSpells.Items.Clear()
            For i = 0 To lstSpells.Count - 1
                lstBSpells.Items.Add(lstSpells(i).Name)
            Next
            lstBSpells.Items.Add("Nouveau...")
            lstBSpells.SelectedIndex = 0
        ElseIf TabControl1.SelectedIndex = 3 Then ' PNJs
            lstBNPCs.Items.Clear()
            For i = 0 To lstNPCs.Count - 1
                lstBNPCs.Items.Add(lstNPCs(i).Name)
            Next
            lstBNPCs.Items.Add("Nouveau...")
            lstBNPCs.SelectedIndex = 0
        End If
    End Sub

#Region "Classes"
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
            txtClassHP.Text = ""
            txtClassMP.Text = ""
            txtClassStrength.Text = ""
            txtClassMagic.Text = ""
            txtClassDef.Text = ""
            txtClassAgility.Text = ""
            txtClassSpeed.Text = ""
        End If
    End Sub

    Private Sub btClassSave_Click(sender As Object, e As EventArgs) Handles btClassSave.Click
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
    Private Sub lstBItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBItems.SelectedIndexChanged
        If Not lstBItems.SelectedIndex = lstBItems.Items.Count - 1 Then
            With lstItems(lstBItems.SelectedIndex)
                txtItemName.Text = .Name
                txtItemDesc.Text = .Description
                txtItemType.Text = .Type
                txtItemHP.Text = .HP
                txtItemMP.Text = .HP
            End With
        Else
            txtItemName.Text = ""
            txtItemDesc.Text = ""
            txtItemType.Text = ""
            txtItemHP.Text = ""
            txtItemMP.Text = ""
        End If
    End Sub

    Private Sub btItemSave_Click(sender As Object, e As EventArgs) Handles btItemSave.Click
        Dim tmpIndex As Short = lstBItems.SelectedIndex()

        If Not lstBItems.SelectedIndex = lstBItems.Items.Count - 1 Then
            With lstItems(lstBItems.SelectedIndex)
                .Name = txtItemName.Text
                .Description = txtItemDesc.Text
                .Type = txtItemType.Text
                .HP = txtItemHP.Text
                .MP = txtItemMP.Text
            End With
        Else
            Dim tmp As New GameItem
            With tmp
                .Name = txtItemName.Text
                .Description = txtItemDesc.Text
                .Type = txtItemType.Text
                .HP = txtItemHP.Text
                .MP = txtItemMP.Text
            End With
            lstItems.Add(tmp)
        End If
        lstItems(tmpIndex).Save()
        lstBItems.Items.Clear()
        For i = 0 To lstItems.Count - 1
            lstBClasses.Items.Add(lstItems(i).Name)
        Next
        lstBItems.Items.Add("Nouveau...")
        lstBItems.SelectedIndex = tmpIndex
    End Sub
#End Region

#Region "Spell"
    Private Sub lstBSpells_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBSpells.SelectedIndexChanged
        If Not lstBSpells.SelectedIndex = lstBSpells.Items.Count - 1 Then
            With lstSpells(lstBSpells.SelectedIndex)
                txtSpellName.Text = .Name
                txtSpellDesc.Text = .Description
                txtSpellDamage.Text = .Damage
            End With
        Else
            txtSpellName.Text = ""
            txtSpellDesc.Text = ""
            txtSpellDamage.Text = ""
        End If
    End Sub


    Private Sub btSpellSave_Click(sender As Object, e As EventArgs) Handles btSpellSave.Click
        Dim tmpIndex As Short = lstBSpells.SelectedIndex

        If Not lstBSpells.SelectedIndex = lstBSpells.Items.Count - 1 Then
            With lstSpells(lstBSpells.SelectedIndex)
                .Name = txtSpellName.Text
                .Description = txtSpellDesc.Text
                .Damage = txtSpellDamage.Text
            End With
        Else
            Dim tmp As New GameSpell
            With tmp
                .Name = txtSpellName.Text
                .Description = txtSpellDesc.Text
                .Damage = txtSpellDamage.Text
            End With
            lstSpells.Add(tmp)
        End If
        lstSpells(tmpIndex).Save()
        lstBSpells.Items.Clear()
        For i = 0 To lstSpells.Count - 1
            lstBSpells.Items.Add(lstSpells(i).Name)
        Next
        lstBSpells.Items.Add("Nouveau...")
        lstBSpells.SelectedIndex = tmpIndex
    End Sub

#End Region

#Region "NPC"

#End Region
    Private Sub lstBNPC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBNPCs.SelectedIndexChanged
        If Not lstBNPCs.SelectedIndex = lstBNPCs.Items.Count - 1 Then
            With lstNPCs(lstBItems.SelectedIndex)
                txtNPCName.Text = .Name
                txtNPCDial.Text = .Dialog
            End With
        Else
            txtNPCName.Text = ""
            txtNPCDial.Text = ""
        End If
    End Sub


    Private Sub btNPCName_Click(sender As Object, e As EventArgs) Handles btNPCName.Click
        Dim tmpIndex As Short = lstBNPCs.SelectedIndex

        If Not lstBNPCs.SelectedIndex = lstBNPCs.Items.Count - 1 Then
            With lstNPCs(lstBNPCs.SelectedIndex)
                .Name = txtNPCName.Text
                .Dialog = txtNPCDial.Text
            End With
        Else
            Dim tmp As New GameNPC
            With tmp
                .Name = txtNPCName.Text
                .Dialog = txtNPCDial.Text
            End With
            lstNPCs.Add(tmp)
        End If
        lstNPCs(tmpIndex).Save()
        lstBNPCs.Items.Clear()
        For i = 0 To lstClasses.Count - 1
            lstBClasses.Items.Add(lstClasses(i).name)
        Next
        lstBNPCs.Items.Add("Nouveau...")
        lstBNPCs.SelectedIndex = tmpIndex
    End Sub
End Class

