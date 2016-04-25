Imports System.Data
Imports System.Data.OleDb
Public Class SelectSeatType
    Public da, da1 As OleDbDataAdapter
    Public ds, ds1 As DataSet
    Public bs As BindingSource
    Dim sql As String


    Private Sub Platinium_Click(sender As System.Object, e As System.EventArgs) Handles Platinium.Click




        For Each ctrl As Control In FormSeat.Controls()
            If TypeOf ctrl Is Button Then
                If ctrl.Text.Contains("C") Then

                    ctrl.Enabled = False
                End If
            End If

        Next
        For Each ctrl As Control In FormSeat.Controls()
            If TypeOf ctrl Is Button Then
                If ctrl.Text.Contains("D") Then

                    ctrl.Enabled = False
                End If
            End If

        Next
        FormSeat.txtPrice.Text = txtPlatinium.Text
        FormSeat.Show()
        Me.Close()



    End Sub

    Private Sub Gold_Click(sender As System.Object, e As System.EventArgs) Handles Gold.Click
        For Each ctrl As Control In FormSeat.Controls()
            If TypeOf ctrl Is Button Then
                If ctrl.Text.Contains("A") Then

                    ctrl.Enabled = False
                End If
            End If

        Next
        For Each ctrl As Control In FormSeat.Controls()
            If TypeOf ctrl Is Button Then
                If ctrl.Text.Contains("B") Then

                    ctrl.Enabled = False
                End If
            End If

        Next

        For Each ctrl As Control In FormSeat.Controls()
            If TypeOf ctrl Is Button Then
                If ctrl.Text.Contains("D") Then

                    ctrl.Enabled = False
                End If
            End If

        Next
        FormSeat.txtPrice.Text = txtGold.Text
        FormSeat.Show()
        Me.Close()
    End Sub

    Private Sub Silver_Click(sender As System.Object, e As System.EventArgs) Handles Silver.Click
        For Each ctrl As Control In FormSeat.Controls()
            If TypeOf ctrl Is Button Then
                If ctrl.Text.Contains("A") Then

                    ctrl.Enabled = False
                End If
            End If

        Next
        For Each ctrl As Control In FormSeat.Controls()
            If TypeOf ctrl Is Button Then
                If ctrl.Text.Contains("B") Then

                    ctrl.Enabled = False
                End If
            End If

        Next

        For Each ctrl As Control In FormSeat.Controls()
            If TypeOf ctrl Is Button Then
                If ctrl.Text.Contains("C") Then

                    ctrl.Enabled = False
                End If
            End If

        Next
        FormSeat.txtPrice.Text = txtSilver.Text
        FormSeat.Show()
        Me.Close()
    End Sub

    Private Sub SelectSeatType_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            sql = "select PlatinumRate From Seat_TypeRate where ShowId = " & txtShowId.Text & "  "
            da = New OleDbDataAdapter(sql, cn)
            ds = New DataSet
            da.Fill(ds)

            txtPlatinium.Text = ds.Tables(0).Rows(0).Item(0)

        Catch ex As Exception
            MsgBox("Exception:" + ex.Message)

        End Try
        Try
            sql = "select SilverRate From Seat_TypeRate where ShowId = " & txtShowId.Text & "  "
            da = New OleDbDataAdapter(sql, cn)
            ds = New DataSet
            da.Fill(ds)

            txtSilver.Text = ds.Tables(0).Rows(0).Item(0)

        Catch ex As Exception
            MsgBox("Exception:" + ex.Message)

        End Try
        Try
            sql = "select GoldRate From Seat_TypeRate where ShowId = " & txtShowId.Text & "  "
            da = New OleDbDataAdapter(sql, cn)
            ds = New DataSet
            da.Fill(ds)

            txtGold.Text = ds.Tables(0).Rows(0).Item(0)

        Catch ex As Exception
            MsgBox("Exception:" + ex.Message)

        End Try
      
    End Sub
End Class