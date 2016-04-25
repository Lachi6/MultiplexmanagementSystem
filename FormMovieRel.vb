Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Data.Common

Public Class FormMovieRel

    Dim cmddelt, cmdSve, cmdUpde As OleDbCommand

    Dim da, daTemp As OleDbDataAdapter
    Dim ds, dsTemp As New DataSet
    Dim bs As BindingSource

    Dim sql As String
    Private Sub FormMovieRel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CboCertificate.Items.Add("A")
        CboCertificate.Items.Add("U/A")
        CboCertificate.Items.Add("U")

        CboGenre.Items.Add("Action")
        CboGenre.Items.Add("Comedy")
        CboGenre.Items.Add("Romentic")
        CboGenre.Items.Add("Drama")


        Call openConn()
        Try
            sql = "select * from Movie"
            da = New OleDbDataAdapter(sql, cn)
            bs = New BindingSource()
            da.Fill(ds)
            bs.DataSource = ds.Tables(0)
            txtMno.DataBindings.Add("Text", bs, "M_No")
            'dgMemberMst.DataSource = ds.Tables(0)

            Call createCommandDefn()
        Catch ex As Exception
            MsgBox("Exception:" + ex.Message)

        End Try
    End Sub

    Private Sub createCommandDefn()
        sql = "INSERT INTO Movie values(@M_no, @M_Name, @M_Cencor, @M_Genre,@M_Lang,@M_Rel)"
        cmdSve = New OleDbCommand(sql, cn)

        cmdSve.Parameters.Add("@M_No", OleDbType.Numeric)
        cmdSve.Parameters.Add("@M_Name", OleDbType.VarChar)


        cmdSve.Parameters.Add("@M_Cencor", OleDbType.VarChar)
        cmdSve.Parameters.Add("@M_Genre", OleDbType.VarChar)
        cmdSve.Parameters.Add("@M_Lang", OleDbType.VarChar)
        cmdSve.Parameters.Add("@M_Rel", OleDbType.VarChar)

    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        Dim result As Integer

        cmdSve.Parameters("@M_No").Value = CInt(txtMno.Text)
        cmdSve.Parameters("@M_Name").Value = txtMname.Text
        cmdSve.Parameters("@M_Cencor").Value = CboCertificate.Text
        cmdSve.Parameters("@M_Genre").Value = CboGenre.Text
        If RBEng.Checked = True Then
            cmdSve.Parameters("@M_Lang").Value = "English"
        ElseIf RBHindi.Checked = True Then
            cmdSve.Parameters("@M_Lang").Value = "Hindi"
        ElseIf RBMarathi.Checked = True Then
            cmdSve.Parameters("@M_Lang").Value = "Marathi"
        ElseIf RBOther.Checked = True Then
            cmdSve.Parameters("@M_Lang").Value = "Other"

        End If
        'cmdSve.Parameters("@M_Lang").Value = GroupBox1.Text

        cmdSve.Parameters("@M_Rel").Value = DateTimePicker1.Value

        result = cmdSve.ExecuteNonQuery()
        If result > 0 Then
            MsgBox("Record Saved.....Successfully")
            bs.MovePrevious()
            bs.MoveNext()
            'dgsupp.Refresh()

        Else
            MsgBox("Record Saved......Failed")
        End If
    End Sub


    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        bs = New BindingSource()
        bs.AddNew()
        sql = "Select MAX(M_No) from Movie"
        daTemp = New OleDbDataAdapter(sql, cn)
        dsTemp.Clear()
        daTemp.Fill(dsTemp)

        If IsDBNull(dsTemp.Tables(0).Rows(0).Item(0)) Then
            txtMno.Text = 1
        Else
            txtMno.Text = dsTemp.Tables(0).Rows(0).Item(0) + 1

        End If
        BtnNew.Enabled = False


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormForgetPassword.Show()

    End Sub

  

    Private Sub txtMno_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMno.TextChanged

    End Sub

    Private Sub CboGenre_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CboGenre.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
