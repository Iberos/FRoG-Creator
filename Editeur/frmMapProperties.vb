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

        btBorder1.Text = map.MapsBorder(0).ToString()
        btBorder2.Text = map.MapsBorder(1).ToString()
        btBorder3.Text = map.MapsBorder(2).ToString()
        btBorder4.Text = map.MapsBorder(3).ToString()
        btBorder5.Text = map.MapsBorder(4).ToString()
        btBorder6.Text = map.MapsBorder(5).ToString()
        btBorder7.Text = map.MapsBorder(6).ToString()
        btBorder8.Text = map.MapsBorder(7).ToString()
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
        map.MapsBorder(curBorder) = lstMaps.SelectedIndex

        btBorder1.Text = map.MapsBorder(0).ToString()
        btBorder2.Text = map.MapsBorder(1).ToString()
        btBorder3.Text = map.MapsBorder(2).ToString()
        btBorder4.Text = map.MapsBorder(3).ToString()
        btBorder5.Text = map.MapsBorder(4).ToString()
        btBorder6.Text = map.MapsBorder(5).ToString()
        btBorder7.Text = map.MapsBorder(6).ToString()
        btBorder8.Text = map.MapsBorder(7).ToString()

        pnlSelect.Visible = False
    End Sub

    Private Sub pnlSelect_VisibleChanged(sender As Object, e As EventArgs) Handles pnlSelect.VisibleChanged
        If pnlSelect.Visible Then
            lstMaps.SelectedIndex = map.MapsBorder(curBorder)
        End If
    End Sub
End Class