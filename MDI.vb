Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Data.Common

Public Class MDI


    Private Sub MDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call openConn()
    End Sub

   

    Private Sub MovieChangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovieChangeToolStripMenuItem.Click
        FormMovieRel.Show()

    End Sub

    Private Sub ShowTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowTimeToolStripMenuItem.Click
        Showtime.Show()

    End Sub

    Private Sub BookTicketToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BookTicketToolStripMenuItem.Click
        TicketBooking.Show()

    End Sub

    Private Sub UserReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UserReportToolStripMenuItem.Click
        ColReport.Show()

    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        FormSupplier.Show()

    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddUserToolStripMenuItem.Click
        User.Show()

    End Sub

    Private Sub ShowAllUsersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowAllUsersToolStripMenuItem.Click
        formUserReport.Show()

    End Sub

    Private Sub MonthlyCollectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MonthlyCollectionToolStripMenuItem.Click

    End Sub
End Class