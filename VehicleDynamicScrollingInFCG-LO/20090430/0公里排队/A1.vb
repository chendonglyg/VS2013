Public Class A1
    Dim pici As String

    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim sendsomething As New sendmessage.CTEnterprisesSoapClient
    

    

    Private Sub CLEAR_GRIDVIEW()
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE_INPUT"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "TEST")

        objdataview = New DataView(objdataset.Tables("TEST"))
        DGV.DataSource = objdataview

        Dim jishi As Integer

        For jishi = 1 To 30 Step 1
            objdataset.Tables("TEST").Rows.Add()
        Next

        DGV.Columns(1).Width = 215
        DGV.Columns(4).Width = 170

        For jishi = 0 To 9
            DGV.Columns(jishi).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


    End Sub
    Private Sub Import_Trade_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE_INPUT"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "TEST")

        objdataview = New DataView(objdataset.Tables("TEST"))
        DGV.DataSource = objdataview

        Dim jishi As Integer

        For jishi = 1 To 30 Step 1
            objdataset.Tables("TEST").Rows.Add()
        Next

        DGV.Columns(1).Width = 215
        DGV.Columns(4).Width = 170

        For jishi = 0 To 9
            DGV.Columns(jishi).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.AllowUserToAddRows = False '消除最后一行
    End Sub



    'Private Sub DGV_KeyDown(sender As Object, e As KeyEventArgs) Handles DGV.KeyDown
    '    On Error Resume Next


    '    If (e.KeyCode = Keys.V And e.Control) Then
    '        Dim i, j As Integer
    '        Dim pRow, pCol As Integer
    '        Dim selectedCellCount As Integer
    '        Dim startRow, startCol, endRow, endCol As Integer
    '        Dim pasteText, strline, strVal As String
    '        Dim strlines, vals As String()
    '        Dim pasteData(,) As String
    '        Dim flag As Boolean = False
    '        ' 当前单元格是否选择的判断
    '        If DGV.CurrentCell Is Nothing Then
    '            Return
    '        End If
    '        Dim insertRowIndex As Integer = DGV.CurrentCell.RowIndex
    '        ' 获取DataGridView选择区域，并计算要复制的行列开始、结束位置
    '        startRow = 9999
    '        startCol = 9999
    '        endRow = 0
    '        endCol = 0
    '        selectedCellCount = DGV.GetCellCount(DataGridViewElementStates.Selected)
    '        For i = 0 To selectedCellCount - 1
    '            startRow = Math.Min(DGV.SelectedCells(i).RowIndex, startRow)
    '            startCol = Math.Min(DGV.SelectedCells(i).ColumnIndex, startCol)
    '            endRow = Math.Max(DGV.SelectedCells(i).RowIndex, endRow)
    '            endCol = Math.Max(DGV.SelectedCells(i).ColumnIndex, endCol)
    '        Next
    '        ' 获取剪切板的内容，并按行分割
    '        pasteText = Clipboard.GetText()
    '        If String.IsNullOrEmpty(pasteText) Then
    '            Return
    '        End If
    '        pasteText = pasteText.Replace(vbCrLf, vbLf)
    '        ReDim strlines(0)
    '        strlines = pasteText.Split(vbLf)
    '        pRow = strlines.Length        '行数
    '        pCol = 0
    '        For Each strline In strlines
    '            ReDim vals(0)
    '            vals = strline.Split(New Char() {vbTab, vbCr, vbNullChar, vbNullString}, 256, StringSplitOptions.RemoveEmptyEntries) ' 按Tab分割数据
    '            pCol = Math.Max(vals.Length, pCol) '列数
    '        Next
    '        ReDim pasteData(pRow, pCol)
    '        pasteText = Clipboard.GetText()
    '        pasteText = pasteText.Replace(vbCrLf, vbLf)
    '        ReDim strlines(0)
    '        strlines = pasteText.Split(vbLf)
    '        i = 1
    '        For Each strline In strlines
    '            j = 1
    '            ReDim vals(0)
    '            strline.TrimEnd(New Char() {vbLf})
    '            vals = strline.Split(New Char() {vbTab, vbCr, vbNullChar, vbNullString}, 256, StringSplitOptions.RemoveEmptyEntries)
    '            For Each strVal In vals
    '                pasteData(i, j) = strVal
    '                j = j + 1
    '            Next
    '            i = i + 1
    '        Next
    '        flag = False
    '        For j = 1 To pCol
    '            If pasteData(pRow, j) <> "" Then
    '                flag = True
    '                Exit For
    '            End If
    '        Next
    '        If flag = False Then
    '            pRow = Math.Max(pRow - 1, 0)
    '        End If


    '        For i = 1 To endRow - startRow + 1
    '            Dim row As DataGridViewRow = DGV.Rows(i + startRow - 1)
    '            If i <= pRow Then
    '                For j = 1 To endCol - startCol + 1
    '                    If j <= pCol Then
    '                        row.Cells(j + startCol - 1).Value = Trim(pasteData(i, j))
    '                    Else
    '                        Exit For
    '                    End If
    '                Next
    '            Else
    '                Exit For
    '            End If
    '        Next

    '    End If
    'End Sub

    Private Sub 提交记录多ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 提交记录多ToolStripMenuItem.Click
        Try


            Dim i As Integer = 0
            Dim PICI As String
            Do While Not (DGV.Rows(i).Cells(0).Value) Is DBNull.Value
                i = i + 1
            Loop


            ' -----------------------------------------------------------------------------------


            Dim ii As Integer
            For ii = 0 To i - 1 Step 1
                Dim objcommand As New SqlClient.SqlCommand
                objcommand.Connection = objconnection

                objcommand.CommandText = "insert into TRUCK_QUEUE (提单创建日期,客户名称,对应订单号,提单号,货物名称,提单数量,车号,到站,电话号码,自派车,推送时间,可登记) values (@提单创建日期,@客户名称,@对应订单号,@提单号,@货物名称,@提单数量,@车号,@到站,@电话号码,@自派车,@推送时间,@可登记)"

                objcommand.Parameters.AddWithValue("@提单创建日期", Trim(DGV.Rows(ii).Cells(0).Value.ToString))
                objcommand.Parameters.AddWithValue("@客户名称", Trim(DGV.Rows(ii).Cells(1).Value.ToString))
                objcommand.Parameters.AddWithValue("@对应订单号", Trim(DGV.Rows(ii).Cells(2).Value.ToString))
                objcommand.Parameters.AddWithValue("@提单号", Trim(DGV.Rows(ii).Cells(3).Value.ToString))
                objcommand.Parameters.AddWithValue("@货物名称", Trim(DGV.Rows(ii).Cells(4).Value.ToString))
                objcommand.Parameters.AddWithValue("@提单数量", Trim(DGV.Rows(ii).Cells(5).Value.ToString))
                objcommand.Parameters.AddWithValue("@车号", Trim(DGV.Rows(ii).Cells(6).Value.ToString))
                objcommand.Parameters.AddWithValue("@到站", Trim(DGV.Rows(ii).Cells(7).Value.ToString))
                objcommand.Parameters.AddWithValue("@电话号码", Trim(DGV.Rows(ii).Cells(8).Value.ToString))
                objcommand.Parameters.AddWithValue("@自派车", Val(DGV.Rows(ii).Cells(9).Value.ToString))
                objcommand.Parameters.AddWithValue("@推送时间", Now)
                objcommand.Parameters.AddWithValue("@粕类", 1)
                objcommand.Parameters.AddWithValue("@可登记", 1)

                PICI = Format(Now, "yyyyMMddHHmmss")
                objcommand.Parameters.AddWithValue("@导入批次 ", PICI)

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommand.ExecuteNonQuery()


                SENDSOMETHING.sendOneMessage(Trim(DGV.Rows(ii).Cells(8).Value.ToString), Trim(DGV.Rows(ii).Cells(6).Value.ToString) & "可以前往柜台进行车辆登记!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

            Next

            MessageBox.Show(i & "条记录导入完毕", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            CLEAR_GRIDVIEW()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

   
   
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        opd.Filter = "EXCEL文件|*.xls;*xlsx"

        opd.ShowDialog()

        textbox1.Text = opd.FileName
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        On Error Resume Next



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

            Dim c As Integer '只用于循环
            Dim viewtotal As Integer '用于最后结果显示输出
            viewtotal = b - a + 1 '计划导入笔数


            For c = a To b
                myRow = ds.Tables("trade").NewRow()
                myRow("提单创建日期") = xlssheet.cells(c, 1).value()
                myRow("客户名称") = Trim(xlssheet.cells(c, 2).value())
                myRow("对应订单号") = Trim(xlssheet.cells(c, 3).value())
                myRow("提单号") = Trim(xlssheet.cells(c, 4).value())
                myRow("货物名称") = Trim(xlssheet.cells(c, 5).value())

                myRow("提单数量") = Val(xlssheet.cells(c, 6).value())
                myRow("推送时间") = sendsomething.getDateTime()
                myRow("车号") = Trim(xlssheet.cells(c, 7).value())

                myRow("到站") = xlssheet.cells(c, 8).value()

                myRow("电话号码") = Trim(xlssheet.cells(c, 9).value())
                myRow("自派车") = Val(xlssheet.cells(c, 10).value())
                myRow("客户物料号") = Trim(xlssheet.cells(c, 11).value())

                If Val(xlssheet.cells(c, 12).value()) = 1 Then
                    myRow("isReserved") = Val(xlssheet.cells(c, 12).value())
                    myRow("Reserveredtime1") = Trim(xlssheet.cells(c, 13).value())


                    Dim Reserveredtime2Value As Date

                    Reserveredtime2Value = Trim(xlssheet.cells(c, 13).value())

                    Reserveredtime2Value = Reserveredtime2Value.AddHours(2)

                    myRow("Reserveredtime2") = Reserveredtime2Value
                End If




                myRow("导入批次") = pici

                myRow("可登记") = 1
                myRow("粕类") = 1
                ''xlssheet.cells(c, 2).Interior.ColorIndex = 3
                ds.Tables("trade").Rows.Add(myRow)
                If Val(xlssheet.cells(c, 12).value()) = 1 Then
                    sendsomething.sendOneMessage(myRow("电话号码"), "<<车辆登记提醒>>" & myRow("客户名称") & "," & myRow("货物名称") & ",提单量:" & myRow("提单数量") & "吨," & myRow("车号") & "," & "可按照您预约的时间(" & myRow("Reserveredtime1") & "-" & myRow("Reserveredtime2") & ") 进行登记!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                Else
                    sendsomething.sendOneMessage(myRow("电话号码"), "<<车辆登记提醒>>" & myRow("客户名称") & "," & myRow("货物名称") & ",提单量:" & myRow("提单数量") & "吨," & myRow("车号") & "," & "可登记!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                End If

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
            MessageBox.Show("导入完成！计划导入数量:" & viewtotal & "实际导入数量:" & objdataview.Count, "提示", MessageBoxButtons.OK)


        End If
NOFILE:


        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

   
 
End Class