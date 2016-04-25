Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Data.Common
Public Class Rates
    Dim cmddelt, cmdSve, cmdUpde As OleDbCommand

    Dim da, daTemp As OleDbDataAdapter
    Dim ds, dsTemp As New DataSet
    Dim bs As BindingSource

    Dim sql As String

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        Dim result As Integer

        cmdSve.Parameters("@ShowId").Value = CInt(txtShowId.Text)
        cmdSve.Parameters("@PlatiniumRate").Value = Platinum.Text
        cmdSve.Parameters("@GoldRate").Value = Gold.Text
        cmdSve.Parameters("@SilverRate").Value = Silver.Text


        result = cmdSve.ExecuteNonQuery()
        If result > 0 Then
            MsgBox("Record Saved.....Successfully")


        Else
            MsgBox("Record Saved......Failed")
        End If
        Showtime.Show()
        Me.Close()

    End Sub

    Private Sub Rates_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call openConn()
        Call createCommandDefn()


    End Sub
    Private Sub createCommandDefn()
        sql = "INSERT INTO Seat_TypeRate values(@ShowId, @PlatiniumRate, @GoldRate, @SilverRate)"
        cmdSve = New OleDbCommand(sql, cn)

        cmdSve.Parameters.Add("@ShowId", OleDbType.Numeric)
        cmdSve.Parameters.Add("@PlatiniumRate", OleDbType.VarChar)
        cmdSve.Parameters.Add("@GoldRate", OleDbType.VarChar)
        cmdSve.Parameters.Add("@SilverRate", OleDbType.VarChar)
        

    End Sub
End Class