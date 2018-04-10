Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Public Class Para
    Inherits System.Windows.Forms.Form
    Dim afterdel As String
    Dim objdataadapter As New SqlDataAdapter
    Dim objdataadapter_kc As New SqlDataAdapter
    Dim objdataadapter_kcwl As New SqlDataAdapter
    Dim objdataadapter_midu As New SqlDataAdapter

    Dim datatable As DataTable
    Dim BindingSourceSalaryItemSet As BindingSource

    Dim objdataview As New DataView
    Dim objdatasetdd, objdatasetkc, objdatasetkcwl, objdatasetmidu As New DataSet

    Private Sub Para_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        MDIMain.GP.Visible = True
    End Sub

    Private Sub DDTCPD_EDIT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select  * from ddtcpd_1"
        Me.MdiParent = MDIMain
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdatasetdd = New DataSet
        objdataadapter.Fill(objdatasetdd, "dd")
        MDIMain.GP.Visible = False
        dgv.DataSource = objdatasetdd.Tables("dd")
        dgv.Columns(0).Width = 50
        dgv.Columns(1).Width = 50
        dgv.Columns(2).Width = 50
        dgv.Columns(3).Width = 50
        dgv.Columns(4).Width = 50
        ''--------------------------------------------------------------------------


        objdataadapter_kc.SelectCommand = New SqlCommand
        objdataadapter_kc.SelectCommand.Connection = objconnection
        objdataadapter_kc.SelectCommand.CommandText = "select id,规格,量,单位 from KCPD_1"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdatasetkc = New DataSet
        objdataadapter_kc.Fill(objdatasetkc, "kc")

        dgv_kc.DataSource = objdatasetkc.Tables("kc")
        dgv_kc.Columns(0).Width = 50
        dgv_kc.Columns(1).Width = 50
        dgv_kc.Columns(2).Width = 50
        dgv_kc.Columns(3).Width = 50
        '-------------------------------------------------

        objdataadapter_kcwl.SelectCommand = New SqlCommand
        objdataadapter_kcwl.SelectCommand.Connection = objconnection
        objdataadapter_kcwl.SelectCommand.CommandText = "select id,物料号,物料描述,库场默认显示,豆粕默认显示 from wlbm"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdatasetkcwl = New DataSet
        objdataadapter_kcwl.Fill(objdatasetkcwl, "kcwl")

        dgv_kcwl.DataSource = objdatasetkcwl.Tables("kcwl")
        dgv_kcwl.Columns(0).Width = 50
        dgv_kcwl.Columns(1).Width = 50
        dgv_kcwl.Columns(3).Width = 50
        dgv_kcwl.Columns(4).Width = 50
        ''----------------------------------------------------------------------
   
      


    End Sub


    Private Sub 保存大豆筒仓修改ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 保存大豆筒仓修改ToolStripMenuItem.Click
        Dim SCB1 As SqlCommandBuilder = New SqlCommandBuilder(objdataadapter)

        objdataadapter.Update(objdatasetdd.Tables("dd"))

        MessageBox.Show("更新完毕")
        dgv.DataSource = objdatasetdd.Tables("dd")
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Dim SCB2 As SqlCommandBuilder = New SqlCommandBuilder(objdataadapter_kc)

            objdataadapter_kc.Update(objdatasetkc.Tables("kc"))

            MessageBox.Show("更新完毕")
            dgv_kc.DataSource = objdatasetkc.Tables("kc")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Dim SCB As SqlCommandBuilder = New SqlCommandBuilder(objdataadapter_kcwl)

        objdataadapter_kcwl.Update(objdatasetkcwl.Tables("kcwl"))
       
        MessageBox.Show("更新完毕")
       
        dgv_kcwl.DataSource = objdatasetkcwl.Tables("kcwl")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select id,物料号,物料描述,库场默认显示,豆粕默认显示 from wlbm where ltrim(rtrim(物料描述)) like '%" & Trim(TextBox1.Text) & "%'"



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdatasetkcwl = New DataSet
        objdataadapter.Fill(objdatasetkcwl, "kcwl")

      dgv_kcwl.DataSource = objdatasetkcwl.Tables("kcwl")
  
    End Sub

   

  
End Class