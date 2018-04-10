Public Class A2
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim sendsomething As New sendmessage.CTEnterprisesSoapClient
   
    Private Sub addcombo()

        ' Application.DoEvents()

        kehumingcheng.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        kehumingcheng.AutoCompleteSource = AutoCompleteSource.ListItems

        ' Application.DoEvents()

        Dim a As Integer


        objdataadapter.SelectCommand = New System.Data.SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 客户名称 from DATA_QUEUE"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "kehu")

        objdataview = New DataView(objdataset.Tables("kehu"))
        ' Application.DoEvents()
        ' MessageBox.Show(objdataview.Count)
        kehumingcheng.Items.Clear()
        ' On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                If Len(objdataview.Item(a).Item("客户名称").ToString) <> 0 Then
                    Application.DoEvents()
                    kehumingcheng.Items.Add(Trim(objdataview.Item(a).Item("客户名称")))
                End If
            Next
        End If
        '  Application.DoEvents()

        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料名称 from DATA_QUEUE"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "wuliao")

        objdataview = New DataView(objdataset.Tables("wuliao"))

        ' MessageBox.Show(objdataview.Count)
        pinming.Items.Clear()


        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                If Len(objdataview.Item(a).Item("物料名称").ToString) <> 0 Then
                    pinming.Items.Add(Trim(objdataview.Item(a).Item("物料名称")))
                End If
            Next
        End If




        objconnection.Close()




    End Sub

    Private Sub A2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next

        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection

        kehumingcheng.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        kehumingcheng.AutoCompleteSource = AutoCompleteSource.ListItems

        DT.Value = Now
        '---------------------------------------------------------------------------

        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 提单创建日期,客户名称,提单号,货物名称,提单数量,车号,电话号码,自派车,备注 FROM TRUCK_QUEUE_INPUT"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

   

   

    Private Sub DGV_KeyDown(sender As Object, e As KeyEventArgs) Handles DGV.KeyDown
        On Error Resume Next


        If (e.KeyCode = Keys.V And e.Control) Then
            Dim i, j As Integer
            Dim pRow, pCol As Integer
            Dim selectedCellCount As Integer
            Dim startRow, startCol, endRow, endCol As Integer
            Dim pasteText, strline, strVal As String
            Dim strlines, vals As String()
            Dim pasteData(,) As String
            Dim flag As Boolean = False
            ' 当前单元格是否选择的判断
            If DGV.CurrentCell Is Nothing Then
                Return
            End If
            Dim insertRowIndex As Integer = DGV.CurrentCell.RowIndex
            ' 获取DataGridView选择区域，并计算要复制的行列开始、结束位置
            startRow = 9999
            startCol = 9999
            endRow = 0
            endCol = 0
            selectedCellCount = DGV.GetCellCount(DataGridViewElementStates.Selected)
            For i = 0 To selectedCellCount - 1
                startRow = Math.Min(DGV.SelectedCells(i).RowIndex, startRow)
                startCol = Math.Min(DGV.SelectedCells(i).ColumnIndex, startCol)
                endRow = Math.Max(DGV.SelectedCells(i).RowIndex, endRow)
                endCol = Math.Max(DGV.SelectedCells(i).ColumnIndex, endCol)
            Next
            ' 获取剪切板的内容，并按行分割
            pasteText = Clipboard.GetText()
            If String.IsNullOrEmpty(pasteText) Then
                Return
            End If
            pasteText = pasteText.Replace(vbCrLf, vbLf)
            ReDim strlines(0)
            strlines = pasteText.Split(vbLf)
            pRow = strlines.Length        '行数
            pCol = 0
            For Each strline In strlines
                ReDim vals(0)
                vals = strline.Split(New Char() {vbTab, vbCr, vbNullChar, vbNullString}, 256, StringSplitOptions.RemoveEmptyEntries) ' 按Tab分割数据
                pCol = Math.Max(vals.Length, pCol) '列数
            Next
            ReDim pasteData(pRow, pCol)
            pasteText = Clipboard.GetText()
            pasteText = pasteText.Replace(vbCrLf, vbLf)
            ReDim strlines(0)
            strlines = pasteText.Split(vbLf)
            i = 1
            For Each strline In strlines
                j = 1
                ReDim vals(0)
                strline.TrimEnd(New Char() {vbLf})
                vals = strline.Split(New Char() {vbTab, vbCr, vbNullChar, vbNullString}, 256, StringSplitOptions.RemoveEmptyEntries)
                For Each strVal In vals
                    pasteData(i, j) = strVal
                    j = j + 1
                Next
                i = i + 1
            Next
            flag = False
            For j = 1 To pCol
                If pasteData(pRow, j) <> "" Then
                    flag = True
                    Exit For
                End If
            Next
            If flag = False Then
                pRow = Math.Max(pRow - 1, 0)
            End If


            For i = 1 To endRow - startRow + 1
                Dim row As DataGridViewRow = DGV.Rows(i + startRow - 1)
                If i <= pRow Then
                    For j = 1 To endCol - startCol + 1
                        If j <= pCol Then
                            row.Cells(j + startCol - 1).Value = Trim(pasteData(i, j))
                        Else
                            Exit For
                        End If
                    Next
                Else
                    Exit For
                End If
            Next

        End If
    End Sub

   

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim i As Integer = 0
        Dim PICI As String
        Do While Not (DGV.Rows(i).Cells(0).Value) Is DBNull.Value
            i = i + 1
        Loop


        ' -----------------------------------------------------------------------------------
        Try



            Dim ii As Integer
            For ii = 0 To i - 1 Step 1
                Dim objcommand As New SqlClient.SqlCommand
                objcommand.Connection = objconnection

                objcommand.CommandText = "insert into TRUCK_QUEUE (提单创建日期,客户名称,提单号,货物名称,提单数量,车号,电话号码,自派车,推送时间,可登记,是否卸车) values (@提单创建日期,@客户名称,@提单号,@货物名称,@提单数量,@车号,@电话号码,@自派车,@推送时间,@可登记,@是否卸车)"

                objcommand.Parameters.AddWithValue("@提单创建日期", Trim(DGV.Rows(ii).Cells(0).Value.ToString))
                objcommand.Parameters.AddWithValue("@客户名称", Trim(DGV.Rows(ii).Cells(1).Value.ToString))

                objcommand.Parameters.AddWithValue("@提单号", Trim(DGV.Rows(ii).Cells(2).Value.ToString))
                objcommand.Parameters.AddWithValue("@货物名称", Trim(DGV.Rows(ii).Cells(3).Value.ToString))
                objcommand.Parameters.AddWithValue("@提单数量", Val(DGV.Rows(ii).Cells(4).Value.ToString))
                objcommand.Parameters.AddWithValue("@车号", Trim(DGV.Rows(ii).Cells(5).Value.ToString))

                objcommand.Parameters.AddWithValue("@电话号码", Trim(DGV.Rows(ii).Cells(6).Value.ToString))
                objcommand.Parameters.AddWithValue("@自派车", Val(DGV.Rows(ii).Cells(7).Value.ToString))
                objcommand.Parameters.AddWithValue("@备注", Trim(DGV.Rows(ii).Cells(8).Value.ToString))
                objcommand.Parameters.AddWithValue("@是否卸车", 1)

                objcommand.Parameters.AddWithValue("@推送时间", Now)

                objcommand.Parameters.AddWithValue("@可登记", 1)

                PICI = Format(Now, "yyyyMMddHHmmss")
                objcommand.Parameters.AddWithValue("@导入批次 ", PICI)

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommand.ExecuteNonQuery()


                sendsomething.sendOneMessage(Trim(DGV.Rows(ii).Cells(6).Value.ToString), Trim(DGV.Rows(ii).Cells(5).Value.ToString) & "可以前往柜台进行车辆登记!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

            Next

            MessageBox.Show(i & "条记录导入完毕", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Try
            If (Len(pinming.Text) > 0) Or Len(kehumingcheng.Text) = 0 Then



                Dim objcommand As New SqlClient.SqlCommand

                objcommand.Connection = objconnection
                objcommand.CommandText = "insert into TRUCK_QUEUE (客户名称,货物名称,提单号,车号,电话号码,备注,推送时间,可登记,提单创建日期,是否卸车,提单数量,自派车) values (@客户名称,@货物名称,@提单号,@车号,@电话号码,@备注,@推送时间,@可登记,@提单创建日期,@是否卸车,@提单数量,@自派车)"

                objcommand.Parameters.AddWithValue("@客户名称", Trim(kehumingcheng.Text))

                objcommand.Parameters.AddWithValue("@货物名称", Trim(pinming.Text))

                objcommand.Parameters.AddWithValue("@提单创建日期", DT.Value)

                objcommand.Parameters.AddWithValue("@提单数量", Val(shuliang.Text))

                objcommand.Parameters.AddWithValue("@提单号", Trim(tidanhao.Text))

                objcommand.Parameters.AddWithValue("@车号", Trim(chehao.Text))

                objcommand.Parameters.AddWithValue("@电话号码", Trim(dianhuahaoma.Text))

                objcommand.Parameters.AddWithValue("@推送时间", Now)

                objcommand.Parameters.AddWithValue("@备注", Trim(beizhu.Text))

                objcommand.Parameters.AddWithValue("@可登记", 1)

                objcommand.Parameters.AddWithValue("@是否卸车", 1)

                If zipaiche.Checked = True Then
                    objcommand.Parameters.AddWithValue("@自派车", 1)
                Else
                    objcommand.Parameters.AddWithValue("@自派车", 0)
                End If


                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objcommand.ExecuteNonQuery()
                objconnection.Close()

                If MessageBox.Show("数据已经保存！是否需要现在发短信给当事人？（Y/N）", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), Trim(chehao.Text) & "可以前往柜台进行车辆登记!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")
                    MessageBox.Show(" 短信已经发送！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                End If

            Else
                MessageBox.Show("关键数据没有录入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        displaymessage.Visible = True
        addcombo()
        displaymessage.Visible = False
    End Sub

    
End Class