﻿Public Class frmExport
    Private Sub btnNavDashboard_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click
        Me.Close()
        frmDashboard.Show()
    End Sub

    Private Sub btnNavItems_Click(sender As Object, e As EventArgs) Handles btnNavItems.Click
        Me.Close()
        frmItems.Show()
    End Sub

    Private Sub btnNavCategories_Click(sender As Object, e As EventArgs) Handles btnNavCategories.Click
        Me.Close()
        frmCategories.Show()
    End Sub

    Private Sub btnNavLocations_Click(sender As Object, e As EventArgs) Handles btnNavLocations.Click
        Me.Close()
        frmLocations.Show()
    End Sub

    Private Sub btnNavExport_Click(sender As Object, e As EventArgs) Handles btnNavExport.Click
        'Already on this page
    End Sub
End Class