Imports System.Data
Imports System.Data.OleDb

Public Class TicketBooking

    Public da, da1 As OleDbDataAdapter
    Public ds, ds1 As DataSet
    Public bs As BindingSource
    Dim sql As String


    Private Sub TicketBooking_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call openConn()

        da = New OleDbDataAdapter("select M_Name from Movie", cn)
        ds = New DataSet
        Try
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex)
        End Try


        For i = 0 To ds.Tables(0).Rows.Count - 1
            cboMovie.Items.Add(ds.Tables(0).Rows(i).Item(0))
        Next






        
    End Sub

    Private Sub cmdSeat_Click(sender As System.Object, e As System.EventArgs) Handles cmdSeat.Click
        FormSeat.txtMname.Text = cboMovie.SelectedItem
        FormSeat.TextTime.Text = cboTime.SelectedItem
        FormSeat.txtShowId.Text = cmdShowId.Text
        SelectSeatType.txtShowId.Text = cmdShowId.Text
        SelectSeatType.Show()
        Me.Close()

    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub cboMovie_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboMovie.SelectedIndexChanged
        da1 = New OleDbDataAdapter("select M_Time from ScreenMovie_Schedule where M_Name like'" & cboMovie.SelectedItem & "' AND Sch_Date like '" & DateTimePicker1.Value.Date & "'", cn)
        ds1 = New DataSet
        Try
            da1.Fill(ds1)
        Catch ex As Exception
            MsgBox(ex)
        End Try


        For i = 0 To ds1.Tables(0).Rows.Count - 1
            cboTime.Items.Add(ds1.Tables(0).Rows(i).Item(0))
        Next
    End Sub



    Private Sub cboTime_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTime.SelectedIndexChanged


        Try
            sql = "select * From ScreenMovie_Schedule where M_Time like '" & cboTime.SelectedItem & "' And M_Name like '" & cboMovie.SelectedItem & "'"
            da = New OleDbDataAdapter(sql, cn)
            ds = New DataSet
            da.Fill(ds)

            cmdShowId.Text = ds.Tables(0).Rows(0).Item(0)

        Catch ex As Exception
            MsgBox("Exception:" + ex.Message)

        End Try
        'Try

        'sql = "Select * from Seat_TypeRate  Where ShowId =  '" & ShowId.Text & " '"
        'da = New OleDbDataAdapter(sql, cn)
        'bs = New BindingSource()
        'da.Fill(ds)
        'bs.DataSource = ds.Tables(0)
        'TextBox1.DataBindings.Add("Text", bs, "PlatiniumRate")
        'TextBox2.DataBindings.Add("Text", bs, "GoldRate")
        'TextBox3.DataBindings.Add("Text", bs, "SilverRate")
        'dgMemberMst.DataSource = ds.Tables(0)


        'Catch ex As Exception
        'MsgBox("Exception:" + ex.Message)

        '        End Try

    End Sub

    Private Sub getId_Click(sender As System.Object, e As System.EventArgs)
        Try
            sql = "select * From ScreenMovie_Schedule where M_Time like '" & cboTime.SelectedItem & "' And M_Name like '" & cboMovie.SelectedItem & "'"
            da = New OleDbDataAdapter(sql, cn)
            ds = New DataSet
            da.Fill(ds)

            cmdShowId.Text = ds.Tables(0).Rows(0).Item(0)

        Catch ex As Exception
            MsgBox("Exception:" + ex.Message)

        End Try

    End Sub

   
End Class
