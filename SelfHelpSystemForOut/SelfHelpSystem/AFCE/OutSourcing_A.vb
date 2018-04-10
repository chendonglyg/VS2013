Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Public Class OutSourcing_A
    Dim forreport As New SqlDataAdapter
    Public afterdel As String
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub Maintenance_FL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select id,资产分类 from Maintenance order by id desc"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "fl")

        objdataview = New DataView(objdataset.Tables("fl"))

        objconnection.Close()



        dgv.DataSource = objdataview
        dgv.Columns(0).ReadOnly = True
    End Sub

    Private Sub 保存ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 保存ToolStripMenuItem.Click
        Dim SCB As SqlCommandBuilder = New SqlCommandBuilder(objdataadapter)

        objdataadapter.Update(objdataset.Tables("fl"))




        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "fl")

        dgv.DataSource = objdataset.Tables("fl")
        MessageBox.Show("更新完毕")
    End Sub
End Class