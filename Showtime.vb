Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Data.Common


Public Class Showtime

    Dim cmddelt, cmdSve, cmdUpde, cmd As OleDbCommand

    Dim da, daTemp, daT As OleDbDataAdapter
    Dim ds, dsTemp, dsT As New DataSet
    Dim bs, bs1, bsT As BindingSource

    Dim sql, sqlT As String

    Private Sub Showtime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call openConn()
        Try
            sqlT = "select * from ScreenMovie_Schedule"
            daT = New OleDbDataAdapter(sqlT, cn)
            bsT = New BindingSource()
            daT.Fill(dsT)
            bsT.DataSource = dsT.Tables(0)
            'txtMno.DataBindings.Add("Text", bs, "M_No")
            DataGridView1.DataSource = dsT.Tables(0)

        Catch ex As Exception
            MsgBox("Exception:" + ex.Message)

        End Try
        
        cmdRate.Enabled = False
        Button2.Enabled = False


        da = New OleDbDataAdapter("select M_Name from Movie", cn)
        ds = New DataSet
        Try
            da.Fill(ds)

        Catch ex As Exception
            MsgBox(ex)
        End Try


        For i = 0 To ds.Tables(0).Rows.Count - 1
            ListBox1.Items.Add(ds.Tables(0).Rows(i).Item(0))
        Next
        cboScreen.Items.Add("1")


    End Sub
    Sub CreateId()
        Try
            bs = New BindingSource()
            bs.AddNew()
            sql = "Select MAX(ShowId) from ScreenMovie_Schedule"
            daTemp = New OleDbDataAdapter(sql, cn)
            dsTemp.Clear()
            daTemp.Fill(dsTemp)

            If IsDBNull(dsTemp.Tables(0).Rows(0).Item(0)) Then
                ShowId.Text = 1
            Else
                ShowId.Text = dsTemp.Tables(0).Rows(0).Item(0) + 1

            End If
            Call createCommandDefn()
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub
    Sub Clear()
        ShowId.Text = ""
        txtTime.Text = ""


    End Sub
    Private Sub createCommandDefn()
        sql = "INSERT INTO ScreenMovie_Schedule values(@ShowId, @S_No, @M_Time,@M_Name, @Sch_Date)"
        cmdSve = New OleDbCommand(sql, cn)

        cmdSve.Parameters.Add("@ShowId", OleDbType.Numeric)
        cmdSve.Parameters.Add("@S_No", OleDbType.Numeric)
        cmdSve.Parameters.Add("@M_Time", OleDbType.VarChar)
        cmdSve.Parameters.Add("@M_Name", OleDbType.VarChar)
        'cmdSve.Parameters.Add("@M_RelDate", OleDbType.VarChar)
        cmdSve.Parameters.Add("@Sch_Date", OleDbType.VarChar)



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click




        Call Clear()
        Call CreateId()
        cmdRate.Enabled = True
        Button1.Enabled = False



    End Sub



    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Dim result As Integer
        cmdSve.Parameters("@ShowId").Value = CInt(ShowId.Text)
        cmdSve.Parameters("@S_No").Value = CInt(cboScreen.Text)
        cmdSve.Parameters("@M_Time").Value = txtTime.Text
        cmdSve.Parameters("@M_Name").Value = ListBox1.SelectedItem
        cmdSve.Parameters("@Sch_Date").Value = DateTimePicker1.Value



        result = cmdSve.ExecuteNonQuery()
        If result > 0 Then
            MsgBox("Record Saved.....Successfully")
            bs.MovePrevious()
            bs.MoveNext()
            DataGridView1.Refresh()
        Else
            MsgBox("Record Saved......Failed")

        End If
        Me.Close()

    End Sub

    Private Sub cmdRate_Click(sender As System.Object, e As System.EventArgs) Handles cmdRate.Click
        Dim count As Integer
        Try
            sql = "select COUNT(*) from ScreenMovie_Schedule where M_Time like ' " & txtTime.Text & "' And S_No = " & cboScreen.SelectedItem & ""

        Catch ex As Exception
            MsgBox("Exception:" + ex.Message)

        End Try
        cmd = New OleDbCommand(sql, cn)
        count = cmd.ExecuteNonQuery()

        If count > 0 Then
            MsgBox("Cannot add Show time as already Exist Please Choose Another Time Or Screen")
            txtTime.Text = ""
            cboScreen.Text = ""
        Else
            Button2.Enabled = True
            Rates.txtShowId.Text = ShowId.Text
            Rates.Show()
            cmdRate.Enabled = False




        End If
        



    End Sub

    Private Sub cboScreen_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboScreen.SelectedIndexChanged

       

       
    End Sub
End Class