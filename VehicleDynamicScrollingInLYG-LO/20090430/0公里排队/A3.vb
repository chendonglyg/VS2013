Public Class A3
    Dim pici As String

    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim sendsomething As New sendmessage.CTEnterprisesSoapClient
   


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        opd.Filter = "EXCEL文件|*.xls;*xlsx"

        opd.ShowDialog()

        textbox1.Text = opd.FileName
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try


            pici = Format(Now, "yyyyMMddHHmmss")


            If Len(textbox1.Text) = 0 Then
                MessageBox.Show("请先选择SAP导出的计划表", "提示", MessageBoxButtons.OK)
                GoTo NOFILE

            Else

                '---------------------------------------------------------------
                Dim da As New SqlClient.SqlDataAdapter("Select * from TRUCK_QUEUE", objconnection)
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
                Dim tFilePath As String = Trim(textbox1.Text)
                Dim xlsBook As Object = XLS.WorkBooks.Open(tFilePath)
                Dim xlssheet As Object = xlsBook.sheets(1)

                Dim a, b As Integer
                a = Val(kaishi.Text)     '行数
                b = Val(jieshu.Text)

                PB.Minimum = a
                PB.Maximum = b

                Dim c As Integer



                For c = a To b
                    myRow = ds.Tables("trade").NewRow()
                    myRow("提单创建日期") = xlssheet.cells(c, 1).value()
                    myRow("客户名称") = Trim(xlssheet.cells(c, 2).value())
                    myRow("对应订单号") = Trim(xlssheet.cells(c, 3).value())
                    myRow("提单号") = Trim(xlssheet.cells(c, 4).value())
                    myRow("货物名称") = Trim(xlssheet.cells(c, 5).value())
                    myRow("备注") = Val(xlssheet.cells(c, 6).value())
                    myRow("提单数量") = Val(xlssheet.cells(c, 7).value())
                    myRow("推送时间") = Now
                    myRow("车号") = Trim(xlssheet.cells(c, 8).value())

                    myRow("到站") = xlssheet.cells(c, 9).value()

                    myRow("电话号码") = Trim(xlssheet.cells(c, 10).value())
                    myRow("自派车") = Val(xlssheet.cells(c, 11).value())
                    myRow("导入批次") = pici

                    myRow("可登记") = 1
                    myRow("粕类") = 0
                    myRow("油脂") = 1
                    ''xlssheet.cells(c, 2).Interior.ColorIndex = 3
                    ds.Tables("trade").Rows.Add(myRow)

                    sendsomething.sendOneMessage(myRow("电话号码"), "<<车辆登记提醒>>" & myRow("客户名称") & "," & myRow("货物名称") & ",提单量:" & myRow("提单数量") & "吨," & myRow("车号") & "," & "可登记!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                    Application.DoEvents()
                    PB.Value = c
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
                DGV.DataSource = objdataview



            End If
NOFILE:


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class