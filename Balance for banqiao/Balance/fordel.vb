Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32





Public Class fordel
    Inherits System.Windows.Forms.Form
    Dim afterdel As String
    Dim objdataadapter As New SqlDataAdapter
    Dim datatable As DataTable
    Dim BindingSourceSalaryItemSet As BindingSource

    Dim objdataview As New DataView
    Dim objdataset As New DataSet




    Private Sub baojianhaoweihu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.MdiParent = MDIParent1
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select top 100 * from deltrade order by 动作时间 desc"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "aa")

        dgv.DataSource = objdataset.Tables("aa")





    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim SCB As SqlCommandBuilder = New SqlCommandBuilder(objdataadapter)

        objdataadapter.Update(objdataset.Tables("aa"))






        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "aa")

        dgv.DataSource = objdataset.Tables("aa")
        MessageBox.Show("更新完毕")

        objdataadapter = New SqlDataAdapter
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select top 100 * from deltrade"


        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "aa")
        objdataview = New DataView(objdataset.Tables("aa"))
        dgv.DataSource = objdataview

        objconnection.Close()

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click

        Dim objcommanddel As New SqlCommand
        objcommanddel.Connection = objconnection
        objcommanddel.CommandText = "delete from deltrade where id=" & afterdel

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If

        objcommanddel.ExecuteNonQuery()



        objdataadapter = New SqlDataAdapter
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select top 100 * from deltrade"


        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "aa")
        objdataview = New DataView(objdataset.Tables("aa"))
        dgv.DataSource = objdataview

        objconnection.Close()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'Me.MdiParent = MDIParent1
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from deltrade where balanceno ='" & Trim(bangdanhao.Text) & "'"




        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "aa")






        'BindingSourceSalaryItemSet = New BindingSource(objdataset, "update")
        'dgv.DataSource = BindingSourceSalaryItemSet




        dgv.DataSource = objdataset.Tables("aa")

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()

    End Sub

    Private Sub dgv_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        On Error Resume Next
        afterdel = Trim(dgv.Rows(e.RowIndex).Cells(0).Value)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class