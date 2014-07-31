Imports System.IO

Public Class frmMapProperties
    Dim curBorder As Byte

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        With map
            .name = txtName.Text
            .type = lstTypes.SelectedIndex
        End With
        Me.Close()
    End Sub

    Private Sub frmMapProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With map
            txtName.Text = .name
            lstTypes.SelectedIndex = .type
        End With

        lstMaps.Items.Add("Aucune")
        For i = 0 To Directory.GetFiles("Maps").Count - 1
            lstMaps.Items.Add(Directory.GetFiles("Maps")(i))
        Next

        btBorder1.Text = map.borderMap(0)
        btBorder2.Text = map.borderMap(1)
        btBorder3.Text = map.borderMap(2)
        btBorder4.Text = map.borderMap(3)
        btBorder5.Text = map.borderMap(4)
        btBorder6.Text = map.borderMap(5)
        btBorder7.Text = map.borderMap(6)
        btBorder8.Text = map.borderMap(7)
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
        map.borderMap(curBorder) = lstMaps.SelectedIndex

        btBorder1.Text = map.borderMap(0)
        btBorder2.Text = map.borderMap(1)
        btBorder3.Text = map.borderMap(2)
        btBorder4.Text = map.borderMap(3)
        btBorder5.Text = map.borderMap(4)
        btBorder6.Text = map.borderMap(5)
        btBorder7.Text = map.borderMap(6)
        btBorder8.Text = map.borderMap(7)

        pnlSelect.Visible = False
    End Sub

    Private Sub pnlSelect_VisibleChanged(sender As Object, e As EventArgs) Handles pnlSelect.VisibleChanged
        If pnlSelect.Visible Then
            lstMaps.SelectedIndex = map.borderMap(curBorder)
        End If
    End Sub
End Class