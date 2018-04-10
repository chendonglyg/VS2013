
Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO

Public Class Calculate_A

    Dim objobjconnection As New SqlClient.SqlConnection
    Dim objdataadapter, objdataadapter2 As New SqlClient.SqlDataAdapter
    '--------------------------------------------------------- 
    Dim objdataset, objdataset2 As New DataSet
    '-------------------------------------------------------------
    Dim objdatatable, objdatatable2 As New DataTable
    '---------------------------------------------------------
    Dim objdataview, objdataview2 As New DataView



    


    Private Function desc() As Object
        Throw New NotImplementedException
    End Function


  

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn1.Click

        opd.Filter = "EXCEL文件|*.xls;*xlsx"

        opd.ShowDialog()

        TextBox1.Text = opd.FileName
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Try
            If Len(TextBox1.Text) = 0 Then
                MessageBox.Show("请先选择 Work.xls 导出模板", "提示", MessageBoxButtons.OK)

            Else



                objdataadapter.SelectCommand = New SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection

                objdataadapter.SelectCommand.CommandText = "delete TZ_InventoryWork "

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataadapter.SelectCommand.ExecuteNonQuery()

                '---------------------------------------------------------------
                Dim da As New SqlDataAdapter("Select * from TZ_InventoryWork", objconnection)
                Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)
                Dim ds As New DataSet()
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey
                da.Fill(ds, "TZ_InventoryWork")
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
                    myRow = ds.Tables("TZ_InventoryWork").NewRow()
                    myRow("罐号名称") = Trim(xlssheet.cells(c, 1).value())
                    myRow("油品名称") = Trim(xlssheet.cells(c, 2).value())
                    myRow("物料编码") = Trim(xlssheet.cells(c, 4).value())
                    myRow("标准密度") = Val(xlssheet.cells(c, 3).value())
                    myRow("标准温度") = Val(xlssheet.cells(c, 5).value())

                    myRow("更新时间") = Now
                    myRow("更新标志") = 0
                    myRow("所属罐区") = "泰州粮油罐区"


                    ds.Tables("TZ_InventoryWork").Rows.Add(myRow)


                    Application.DoEvents()
                    pb.Value = c
                    Application.DoEvents()
                Next

                da.Update(ds, "TZ_InventoryWork")
                MyCB = Nothing
                ds = Nothing
                da = Nothing

                xlssheet = Nothing '释放sheet对象

                xlsBook.Close()  '关闭文件
                xlsBook = Nothing

                XLS.Quit() '关闭Excel
                XLS = Nothing
                Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("excel")




                '-------------------------------------------
                objdataadapter.SelectCommand = New SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection

                objdataadapter.SelectCommand.CommandText = "select * from TZ_InventoryWork "
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "TZ_InventoryWork")




                objdataview = New DataView(objdataset.Tables("TZ_InventoryWork"))
                dgv.DataSource = objdataview
                MessageBox.Show("传输完成！共计:" & objdataview.Count & "笔记录", "提示", MessageBoxButtons.OK)
                pb.Value = a

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub 保存数据ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存数据ToolStripMenuItem.Click
        On Error Resume Next
        Dim SCB1 As SqlCommandBuilder = New SqlCommandBuilder(objdataadapter)

        objdataadapter.Update(objdataset.Tables("TZ_InventoryWork"))
        Dim objcommand As New SqlCommand

    End Sub

    Private Sub UpdateDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateDataToolStripMenuItem.Click
        On Error Resume Next
        Dim SCB2 As SqlCommandBuilder = New SqlCommandBuilder(objdataadapter2)

        objdataadapter2.Update(objdataset2.Tables("TZ_InventoryDensity"))

        Dim objcommand As New SqlCommand







    End Sub

   
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        opd.Filter = "EXCEL文件|*.xls;*xlsx"

        opd.ShowDialog()

        TextBox2.Text = opd.FileName
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Try
            If Len(TextBox2.Text) = 0 Then
                MessageBox.Show("请先选择 Density.xls 导出模板", "提示", MessageBoxButtons.OK)

            Else


                objdataadapter2.SelectCommand = New SqlCommand
                objdataadapter2.SelectCommand.Connection = objconnection




                objdataadapter2.SelectCommand.CommandText = "delete TZ_InventoryDensity "

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataadapter2.SelectCommand.ExecuteNonQuery()
                'MessageBox.Show("删除完毕！")



                '------------------------------------------------------------------------------------------------

                Dim da As New SqlDataAdapter("Select * from TZ_InventoryDensity", objconnection)
                Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)
                Dim ds As New DataSet()
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey
                da.Fill(ds, "TZ_InventoryDensity")
                Dim myRow As DataRow





                '------------------------------------------------------------------


                Dim XLS As Object = CreateObject("Excel.Application")
                Dim tFilePath As String = Trim(TextBox2.Text)
                Dim xlsBook As Object = XLS.WorkBooks.Open(tFilePath)
                Dim xlssheet As Object = xlsBook.sheets(Val(sheetno.Text))

                Dim a, b As Integer
                a = Val(kaishi2.Text)     '行数
                b = Val(jieshu2.Text)

                pb2.Minimum = a
                pb2.Maximum = b

                Dim c As Integer

                For c = a To b
                    myRow = ds.Tables("TZ_InventoryDensity").NewRow()

                    myRow("油品名称") = Trim(xlssheet.cells(c, 1).value())
                    myRow("物料编码") = Trim(xlssheet.cells(c, 2).value())
                    myRow("标准密度") = Val(xlssheet.cells(c, 3).value())



                    ds.Tables("TZ_InventoryDensity").Rows.Add(myRow)


                    Application.DoEvents()
                    pb2.Value = c
                    Application.DoEvents()
                Next

                da.Update(ds, "TZ_InventoryDensity")
                MyCB = Nothing
                ds = Nothing
                da = Nothing

                xlssheet = Nothing '释放sheet对象

                xlsBook.Close()  '关闭文件
                xlsBook = Nothing

                XLS.Quit() '关闭Excel
                XLS = Nothing

                Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("excel")




                '-------------------------------------------
                objdataadapter2.SelectCommand = New SqlCommand
                objdataadapter2.SelectCommand.Connection = objconnection
                objdataadapter2.SelectCommand.CommandText = "select * from TZ_InventoryDensity"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset2 = New DataSet
                objdataadapter2.Fill(objdataset2, "TZ_InventoryDensity")
                objdataview2 = New DataView(objdataset2.Tables("TZ_InventoryDensity"))
                dgv2.DataSource = objdataview2
                MessageBox.Show("传输完成！共计:" & objdataview2.Count & "笔记录", "提示", MessageBoxButtons.OK)

                objconnection.Close()

                pb2.Value = a


            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ShowDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowDataToolStripMenuItem.Click
   
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from TZ_InventoryWork "
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If

       
        objdataset = New DataSet

        objdataadapter.Fill(objdataset, "TZ_InventoryWork")



        objdataview = New DataView(objdataset.Tables("TZ_InventoryWork"))


        dgv.DataSource = objdataview
        CountNum.Text = "数据读取完成!共计:" & objdataview.Count & "笔记录"
        objconnection.Close()
    End Sub

    Private Sub ShowDataToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ShowDataToolStripMenuItem1.Click
        objdataadapter2.SelectCommand = New SqlCommand
        objdataadapter2.SelectCommand.Connection = objconnection
     
        objdataadapter2.SelectCommand.CommandText = "select * from TZ_InventoryDensity"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset2 = New DataSet


        objdataadapter2.Fill(objdataset2, "TZ_InventoryDensity")
        objdataview2 = New DataView(objdataset2.Tables("TZ_InventoryDensity"))
        dgv2.DataSource = objdataview2
        CountNum.Text = "数据读取完成！共计:" & objdataview2.Count & "笔记录"

        objconnection.Close()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        dgv2.ClearSelection()
    End Sub

 
  
   
  
    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        dgv2.ClearSelection()

    End Sub

    Private Sub dgv2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv2.CellClick
        dgv.ClearSelection()
    End Sub

   
    Private Sub dgv2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv2.CellContentClick
        dgv.ClearSelection()
    End Sub

    Private Sub Calculate_A_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain
    End Sub
End Class