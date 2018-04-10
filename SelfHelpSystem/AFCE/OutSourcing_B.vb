Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Public Class Maintenance_bm
    Dim forreport As New SqlDataAdapter
    Public afterdel As String
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet

    Private Sub Maintenance_GS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select id,部门名称 from Maintenance order by id desc"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "bm")

        objdataview = New DataView(objdataset.Tables("bm"))

        objconnection.Close()



        dgv.DataSource = objdataview
        dgv.Columns(0).ReadOnly = True
    End Sub

    Private Sub 保存ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 保存ToolStripMenuItem.Click
        Dim SCB As SqlCommandBuilder = New SqlCommandBuilder(objdataadapter)

        objdataadapter.Update(objdataset.Tables("bm"))




        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "bm")

        dgv.DataSource = objdataset.Tables("bm")
        MessageBox.Show("更新完毕")
    End Sub
End Class