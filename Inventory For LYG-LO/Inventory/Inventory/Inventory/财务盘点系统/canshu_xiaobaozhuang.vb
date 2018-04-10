Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Imports Microsoft.Win32
Imports System.Net
Imports System.Net.Sockets
Public Class canshu_xiaobaozhuang
    Inherits System.Windows.Forms.Form
    Dim ssgq As String
    Dim objdataadapter As New SqlDataAdapter
    Dim datatable As DataTable
    Dim BindingSourceSalaryItemSet As BindingSource

    Dim objdataview As New DataView
    Dim objdataset As New DataSet


    Private Sub canshu_xiaobaozhuang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MDIMain.GP.Visible = False
        Me.MdiParent = MDIMain
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        opd.Filter = "EXCEL文件|*.xls;*xlsx"

        opd.ShowDialog()

        TextBox1.Text = opd.FileName
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If s1.Checked = True Then



                If Len(TextBox1.Text) = 0 Then
                    MessageBox.Show("请先选择物料导出模板", "提示", MessageBoxButtons.OK)
                Else

                    '---------------------------------------------------------------
                    Dim da As New SqlDataAdapter("Select * from canshu_xiaobaozhuang", objconnection)
                    Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)
                    Dim ds As New DataSet()
                    da.MissingSchemaAction = MissingSchemaAction.AddWithKey
                    da.Fill(ds, "xiao")
                    Dim myRow As DataRow



                    objdataadapter = New SqlDataAdapter
                    objdataadapter.SelectCommand = New SqlCommand
                    objdataadapter.SelectCommand.Connection = objconnection



                    objdataadapter.SelectCommand.CommandText = "delete canshu_xiaobaozhuang "

                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataadapter.SelectCommand.ExecuteNonQuery()
                    'MessageBox.Show("删除完毕！")

                    '------------------------------------------------------------------


                    Dim XLS As Object = CreateObject("Excel.Application")
                    Dim tFilePath As String = Trim(TextBox1.Text)
                    Dim xlsBook As Object = XLS.WorkBooks.Open(tFilePath)
                    Dim xlssheet As Object = xlsBook.sheets(Val(sheetno.Text))

                    Dim a, b As Integer
                    a = Val(kaishi.Text)     '行数
                    b = Val(jieshu.Text)

                    pb.Minimum = a
                    pb.Maximum = b

                    Dim c As Integer

                    For c = a To b
                        myRow = ds.Tables("xiao").NewRow()
                        myRow("物料编码") = Trim(xlssheet.cells(c, 1).value())
                        myRow("物料描述") = Trim(xlssheet.cells(c, 2).value())
                      
                        ds.Tables("xiao").Rows.Add(myRow)


                        Application.DoEvents()
                        pb.Value = c
                        Application.DoEvents()
                    Next

                    da.Update(ds, "xiao")
                    MyCB = Nothing
                    ds = Nothing
                    da = Nothing


                    Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("excel")




                    '-------------------------------------------
                    objdataadapter.SelectCommand = New SqlCommand
                    objdataadapter.SelectCommand.Connection = objconnection
                    objdataadapter.SelectCommand.CommandText = "select * from canshu_xiaobaozhuang "
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataset = New DataSet
                    objdataadapter.Fill(objdataset, "xiao")
                    objdataview = New DataView(objdataset.Tables("xiao"))
                    dgv.DataSource = objdataview
                    MessageBox.Show("传输完成！共计:" & objdataview.Count & "笔记录", "提示", MessageBoxButtons.OK)

                End If
            End If




            If s2.Checked = True Then
                If Len(TextBox1.Text) = 0 Then
                    MessageBox.Show("请先选择物料导出模板", "提示", MessageBoxButtons.OK)
                Else

                    '---------------------------------------------------------------
                    Dim da As New SqlDataAdapter("Select * from canshu_xiaobaozhuang", objconnection)
                    Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)
                    Dim ds As New DataSet()
                    da.MissingSchemaAction = MissingSchemaAction.AddWithKey
                    da.Fill(ds, "xiao")
                    Dim myRow As DataRow





                    '------------------------------------------------------------------


                    Dim XLS As Object = CreateObject("Excel.Application")
                    Dim tFilePath As String = Trim(TextBox1.Text)
                    Dim xlsBook As Object = XLS.WorkBooks.Open(tFilePath)
                    Dim xlssheet As Object = xlsBook.sheets(Val(sheetno.Text))

                    Dim a, b As Integer
                    a = Val(kaishi.Text)     '行数
                    b = Val(jieshu.Text)

                    pb.Minimum = a
                    pb.Maximum = b

                    Dim c As Integer

                    For c = a To b
                        myRow = ds.Tables("xiao").NewRow()
                        myRow("品牌") = Trim(xlssheet.cells(c, 1).value())
                        myRow("油脂名称") = Trim(xlssheet.cells(c, 2).value())
                        myRow("规格") = Trim(xlssheet.cells(c, 3).value())
                        myRow("单位") = Trim(xlssheet.cells(c, 4).value())



                        ds.Tables("xiao").Rows.Add(myRow)


                        Application.DoEvents()
                        pb.Value = c
                        Application.DoEvents()
                    Next

                    da.Update(ds, "xiao")
                    MyCB = Nothing
                    ds = Nothing
                    da = Nothing


                    Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("excel")




                    '-------------------------------------------
                    objdataadapter.SelectCommand = New SqlCommand
                    objdataadapter.SelectCommand.Connection = objconnection
                    objdataadapter.SelectCommand.CommandText = "select * from canshu_xiaobaozhuang "
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataset = New DataSet
                    objdataadapter.Fill(objdataset, "xiao")
                    objdataview = New DataView(objdataset.Tables("xiao"))
                    dgv.DataSource = objdataview
                    MessageBox.Show("传输完成！共计:" & objdataview.Count & "笔记录", "提示", MessageBoxButtons.OK)

                End If



            End If




















        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料描述,物料编码 from canshu_xiaobaozhuang "
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "xiao")
        objdataview = New DataView(objdataset.Tables("xiao"))
        dgv.DataSource = objdataview
        dgv.Columns(1).Width = 400
        dgv.Columns(0).Width = 400


    End Sub

    Private Sub 保存更新ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 保存更新ToolStripMenuItem.Click
        Dim SCB As SqlCommandBuilder = New SqlCommandBuilder(objdataadapter)

        objdataadapter.Update(objdataset.Tables("xiao"))


        Dim objcommand As New SqlCommand
        MessageBox.Show("提醒完毕")
    End Sub
End Class