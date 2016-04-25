
Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Common



Public Class User
    Dim cmdRegister, cmdCancel, cmdNew As OleDbCommand
    Dim da, daTemp As OleDbDataAdapter
    Dim ds, dsTemp As New DataSet
    Dim bs As BindingSource
    Dim dgUserManagement As DataGridView


    Dim sql As String



    Private Sub User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            sql = "select * from Employee_Mst"
            da = New OleDbDataAdapter(sql, cn)

            bs = New BindingSource()
            'bsTemp = New BindingSource()
            da.Fill(ds)
            bs.DataSource = ds.Tables(0)

            txtUserID.DataBindings.Add("text", bs, "UID")
            txtName.DataBindings.Add("text", bs, "U_Name")
            txtAdd.DataBindings.Add("text", bs, "U_Address")
            txtAnswer.DataBindings.Add("text", bs, "U_ContactNo")
            txtContact.DataBindings.Add("text", bs, "U_DOB")

            'dgUserManagement.DataSource = ds.Tables(0)

            Call createCommandDefn()


        Catch ex As Exception

            MsgBox("Exception : " + ex.Message)

        End Try
    End Sub

    Private Sub createCommandDefn()

        sql = "Insert into UserManagement values(@UID, @U_Name, @U_Address,@U_SecurityQuestion,@U_Answer,@U_ContactNo)"
        cmdRegister = New OleDbCommand(sql, cn)
        cmdRegister.Parameters.Add("@UserNo", OleDbType.Numeric)
        cmdRegister.Parameters.Add("@UserName", OleDbType.LongVarChar)
        cmdRegister.Parameters.Add("@UserAdd", OleDbType.LongVarChar)
        cmdRegister.Parameters.Add("@UserContact", OleDbType.Numeric)
        cmdRegister.Parameters.Add("@UserQstn", OleDbType.LongVarChar)
        cmdRegister.Parameters.Add("@UserAns", OleDbType.LongVarChar)



    End Sub

   

    Private Sub cmdReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReg.Click
        Dim Result As Integer

        cmdRegister.Parameters("@UserNo").Value = CInt(txtUserID.Text)
        cmdRegister.Parameters("@UserName").Value = txtName.Text
        cmdRegister.Parameters("@UserAdd").Value = txtAdd.Text
        cmdRegister.Parameters("@UserAns").Value = txtAnswer.Text
        cmdRegister.Parameters("@UserQstn").Value = cboSecurity.Text
        cmdRegister.Parameters("@UserContact").Value = CInt(txtContact.Text)

        Result = cmdRegister.ExecuteNonQuery()

        If Result > 0 Then
            MsgBox("Record Saved..........Successfully")
            'dgUserManagement.Refresh()
        Else
            MsgBox("Record Inserting Failed....!")

        End If
    End Sub

    Private Sub cmdNw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNw.Click
        bs.AddNew()

        sql = "Select max(UserNo) from UserManagement "

        daTemp = New OleDbDataAdapter(sql, cn)
        dsTemp.Clear()
        daTemp.Fill(dsTemp)

        If IsDBNull(dsTemp.Tables(0).Rows(0).Item(0)) Then
            txtUserID.Text = 1
        Else
            txtUserID.Text = dsTemp.Tables(0).Rows(0).Item(0) + 1

        End If

    End Sub

    Private Sub cmdCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCan.Click
        Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class