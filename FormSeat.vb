Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Data.Common
Public Class FormSeat

    Dim cmddelt, cmdSve, cmdUpde As OleDbCommand

    Dim da, daTemp As OleDbDataAdapter
    Dim ds, dsTemp As New DataSet
    Dim bs As BindingSource

    Dim sql As String

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Call openConn()
        
    End Sub
    Private Sub createCommandDefn()
        sql = "INSERT INTO SeatBooking values(@M_Tno, @SeatNo)"
        cmdSve = New OleDbCommand(Sql, cn)

        'cmdSve.Parameters.Add("@ShowId", OleDbType.Numeric)
        cmdSve.Parameters.Add("@M_Tno", OleDbType.VarChar)
        cmdSve.Parameters.Add("@SeatNo", OleDbType.VarChar)


    End Sub

    Private Sub A1_Click(sender As System.Object, e As System.EventArgs) Handles A1.Click
        
        If A1.BackColor = SystemColors.Control Then
            A1.BackColor = Color.Green
            Dim result As Integer


            'cmdSve.Parameters("@ShowId").Value = CInt(txtShowId.Text)
            cmdSve.Parameters("@M_Tno").Value = TextTime.Text
            cmdSve.Parameters("@SeatNo").Value = A1.Text

            result = cmdSve.ExecuteNonQuery()

            If result > 0 Then
                MsgBox("Record Saved.....Successfully")

                'dgsupp.Refresh()

            Else
                MsgBox("Record Saved......Failed")
            End If

        ElseIf A1.BackColor = Color.Green Then
            A1.BackColor = SystemColors.Control
            sql = "Delete FROM SeatBooking WHERE SeatNo like 'A1' "
            cmddelt = New OleDbCommand(sql, cn)
            cmddelt.ExecuteNonQuery()
            MsgBox("Del")

        End If


    End Sub

    Private Sub A2_Click(sender As System.Object, e As System.EventArgs) Handles A2.Click
        If A2.BackColor = SystemColors.Control Then
            A2.BackColor = Color.Green
            Dim result As Integer


            cmdSve.Parameters("@ShowId").Value = CInt(txtShowId.Text)
            cmdSve.Parameters("@M_Tno").Value = TextTime.Text
            cmdSve.Parameters("@SeatNo").Value = A2.Text

            result = cmdSve.ExecuteNonQuery()

            If result > 0 Then
                MsgBox("Record Saved.....Successfully")

                'dgsupp.Refresh()

            Else
                MsgBox("Record Saved......Failed")
            End If

        ElseIf A2.BackColor = Color.Green Then
            A2.BackColor = SystemColors.Control
            sql = "Delete FROM SeatBooking WHERE SeatNo like 'A2' "
            cmddelt = New OleDbCommand(sql, cn)
            cmddelt.ExecuteNonQuery()
            MsgBox("Del")

        End If


    End Sub

    Private Sub Proceed_Click(sender As System.Object, e As System.EventArgs) Handles Proceed.Click

    End Sub
End Class