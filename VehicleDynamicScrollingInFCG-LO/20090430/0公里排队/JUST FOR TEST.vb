Public Class JUST_FOR_TEST

    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim sendsomething As New sendmessage.CTEnterprisesSoapClient
    Private Sub JUST_FOR_TEST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)

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

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Function DataGridViewColumn() As Object
        Throw New NotImplementedException
    End Function

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
                objcommand.Parameters.AddWithValue("@可登记", 1)

                PICI = Format(Now, "yyyyMMddHHmmss")
                objcommand.Parameters.AddWithValue("@导入批次 ", PICI)

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommand.ExecuteNonQuery()


                sendsomething.sendOneMessage(Trim(DGV.Rows(ii).Cells(8).Value.ToString), Trim(DGV.Rows(ii).Cells(6).Value.ToString) & "可以前往柜台进行车辆登记!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

            Next

            MessageBox.Show(i & "条记录导入完毕", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            CLEAR_GRIDVIEW()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class