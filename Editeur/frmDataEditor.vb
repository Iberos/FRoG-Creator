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
                lstBItems.Items.Add(lstItems(i).ItemName)
            Next
            lstBItems.Items.Add("Nouveau...")
            lstBItems.SelectedIndex = 0
        ElseIf TabControl1.SelectedIndex = 2 Then ' Sorts
            lstBSpells.Items.Clear()
            For i = 0 To lstSpells.Count - 1
                lstBSpells.Items.Add(lstSpells(i).SpellName)
            Next
            lstBSpells.Items.Add("Nouveau...")
            lstBSpells.SelectedIndex = 0
        ElseIf TabControl1.SelectedIndex = 3 Then ' PNJs
            lstBNPCs.Items.Clear()
            For i = 0 To lstNPCs.Count - 1
                lstBNPCs.Items.Add(lstNPCs(i).NPCName)
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

    Private Sub pnlClass_Paint(sender As Object, e As PaintEventArgs) Handles pnlClass.Paint

    End Sub

    Private Sub btItemSave_Click(sender As Object, e As EventArgs) Handles btItemSave.Click
        Dim tmpIndex As Short = lstBItems.SelectedIndex()

        If Not lstBItems.SelectedIndex = lstBItems.Items.Count - 1 Then
            With lstBItems(lstBItems.SelectedIndex)
                .name = txtItemName.Text
                .description = txtItemDesc.Text
                .Type = txtItemType.Text
                .HP = txtItemHP.Text
                .MP = txtItemMP.Text
            End With
        Else
            Dim tmp As New GameItems
            With tmp
                .name = txtItemName.Text
                .description = txtItemDesc.Text
                .Type = txtItemType.Text
                .HP = txtItemHP.Text
                .MP = txtItemMP.Text
            End With
            lstClasses.Add(tmp)
        End If
        lstItems(tmpIndex).Save()
        lstBItems.Items.Clear()
        For i = 0 To lstItems.Count - 1
            lstBClasses.Items.Add(lstItems(i).name)
        Next
        lstBItems.Items.Add("Nouveau...")
        lstBItems.SelectedIndex = tmpIndex
    End Sub

    Private Sub btSpellSave_Click(sender As Object, e As EventArgs) Handles btSpellSave.Click
        Dim tmpIndex As Short = lstBSpell.SelectedIndex

        If Not lstBSpell.SelectedIndex = lstSpell.Items.Count - 1 Then
            With lstBSpell(lstSpell.SelectedIndex)
                .name = txtSpellName.Text
                .description = txtSpellDesc.Text
                .Damage = txtSpellDamage.Text
            End With
        Else
            Dim tmp As New GameSpell
            With tmp
                .name = txtSpellName.Text
                .description = txtSpellDesc.Text
                .Damage = txtSpellDamage.Text
            End With
            lstSpell.Add(tmp)
        End If
        lstSpell(tmpIndex).Save()
        lstBSpell.Items.Clear()
        For i = 0 To lstSpell.Count - 1
            lstBSpell.Items.Add(lstBSpell(i).name)
        Next
        lstBSpell.Items.Add("Nouveau...")
        lstBSpell.SelectedIndex = tmpIndex
    End Sub

    Private Sub btNPCName_Click(sender As Object, e As EventArgs) Handles btNPCName.Click
        Dim tmpIndex As Short = lstBBNPC.SelectedIndex

        If Not lstBNPC.SelectedIndex = lstBNPC.Items.Count - 1 Then
            With lstBNPC(lstBNPC.SelectedIndex)
                .name = txtNPCName.Text
                .dialogue = txtNPCDial.Text
            End With
        Else
            Dim tmp As New GameNPC
            With tmp
                .name = txtNPCName.Text
                .dialogue = txtNPCDial.Text
            End With
            lstClasses.Add(tmp)
        End If
        lstNPC(tmpIndex).Save()
        lstBNPC.Items.Clear()
        For i = 0 To lstClasses.Count - 1
            lstBClasses.Items.Add(lstClasses(i).name)
        Next
        lstBNPC.Items.Add("Nouveau...")
        lstBNPC.SelectedIndex = tmpIndex
    End Sub
End Class