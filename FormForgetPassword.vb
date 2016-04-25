Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Data.Common
Public Class FormForgetPassword
    Dim Ans As String
    Dim cmdNext As OleDbCommand

    Dim da, daTemp As OleDbDataAdapter
    Dim ds, dsTemp As New DataSet
    Dim bs As BindingSource

    Dim sql As String

    Private Sub FormForgetPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            sql = "select * From Employee "
            'da = New OleDbDataAdapter(sql, cn)
            'ds = New DataSet
            'da.Fill(ds)

            ' cmdShowId.Text = ds.Tables(0).Rows(0).Item(0)

        Catch ex As Exception
            MsgBox("Exception:" + ex.Message)

        End Try
    End Sub


   

    Private Sub txtUserName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserName.LostFocus
        'bs = New BindingSource()
        'bs.AddNew()
        sql = "select U_SecurityQuestion from Employee_Mst where U_Name like '" & txtUserName.Text & "'"""
       da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        If dsTemp.Tables(0).Rows.Count > 0 Then
            Label4.Text = ds.Tables(0).Rows(0).Item(0)
        Else
            MessageBox.Show("Invalid Username")
            txtUserName.Text = ""
        End If

        

    End Sub

    
    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        If txtAnswer.Text = Ans Then
            Me.Close()
            FormMovieRel.Show()
        Else
            MessageBox.Show("Invalid Password")

        End If
    End Sub

   
    Private Sub BtnCancle_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancle.Click
        sql = "select U_SecurityQuestion from Employee_Mst where U_Name like '" & txtUserName.Text & "'"
        da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        If dsTemp.Tables(0).Rows.Count > 0 Then
            Label4.Text = ds.Tables(0).Rows(0).Item(0)
        Else
            MessageBox.Show("Invalid Username")
            txtUserName.Text = ""
        End If
    End Sub
End Class