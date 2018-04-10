
Public Class CIQ_Import
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Private Sub ForCharlie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        opd.Filter = "EXCEL文件|*.xls;*xlsx"

        opd.ShowDialog()

        TextBox1.Text = opd.FileName
    End Sub

   





    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Try
            Dim pici As String


            pici = Format(Now, "yyyyMMddHHmmss")


            If Len(TextBox1.Text) = 0 Then
                MessageBox.Show("请先选择SAP导出的出库数据表", "提示", MessageBoxButtons.OK)
                GoTo NOFILE

            Else

                '---------------------------------------------------------------
                Dim da As New SqlClient.SqlDataAdapter("Select * from CIQ_Trade", objconnection)
                Dim MyCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
                Dim ds As New DataSet()
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey
                da.Fill(ds, "trade")
                Dim myRow As DataRow



                objdataadapter = New SqlClient.SqlDataAdapter
                objdataadapter.SelectCommand = New SqlClient.SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection





                '------------------------------------------------------------------


                Dim XLS As Object = CreateObject("Excel.Application")
                Dim tFilePath As String = Trim(TextBox1.Text)
                Dim xlsBook As Object = XLS.WorkBooks.Open(tFilePath)
                Dim xlssheet As Object = xlsBook.sheets(1)

                Dim a, b As Integer
                a = Val(kaishi.Text)     '行数
                b = Val(jieshu.Text)

                pb.Minimum = a
                pb.Maximum = b

                Dim c As Integer



                For c = a To b

                    myRow = ds.Tables("trade").NewRow()

                    myRow("原料合同号") = Trim(hetonghao.Text)

                    myRow("报关单号") = Trim(baoguandanhao.Text)

                    myRow("原料领用库位") = Trim(lingyongkuwei.Text)

                    myRow("产品存放库位") = Trim(cunfangkuwei.Text)

                    myRow("销售合同号") = xlssheet.cells(c, 4).value()


                    '  MessageBox.Show(xlssheet.cells(c, 1).value().ToString)
                    myRow("日期") = Format(xlssheet.cells(c, 1).value().ToString, "Short Date")



                    myRow("提单号") = xlssheet.cells(c, 4).value()

                    myRow("客户名称") = xlssheet.cells(c, 7).value()

                    myRow("件数") = xlssheet.cells(c, 5).value()

                    myRow("重量") = xlssheet.cells(c, 6).value()

                    myRow("品名") = xlssheet.cells(c, 2).value()

                    myRow("运输方式") = xlssheet.cells(c, 3).value()

                    myRow("备注") = xlssheet.cells(c, 8).value()

                    myRow("导入批次") = pici








                    '-------------------------------------------------------------------------------------------------------------
                    ds.Tables("trade").Rows.Add(myRow)


                    Application.DoEvents()
                    pb.Value = c
                    Application.DoEvents()
                Next

                da.Update(ds, "trade")
                MyCB = Nothing
                ds = Nothing
                da = Nothing
                '---------------------------------
                xlssheet = Nothing '释放sheet对象

                xlsBook.Close()  '关闭文件
                xlsBook = Nothing

                XLS.Quit() '关闭Excel
                XLS = Nothing

                Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("excel")
                MessageBox.Show("导入完成！", "提示", MessageBoxButtons.OK)



                '-------------------------------------------
                objdataadapter.SelectCommand = New SqlClient.SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 导入批次= '" & pici & "'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "trade")
                objdataview = New DataView(objdataset.Tables("trade"))
                ' dgv.DataSource = objdataview



            End If
NOFILE:


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class