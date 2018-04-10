Public Class CIQ_Trade
    Inherits System.Windows.Forms.Form
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim datatable As DataTable
    Dim objdataview As New DataView
    Dim objdataset As New DataSet
    Public Sub clearbox(ByVal cc As Control.ControlCollection)

        For Each ctl As Control In cc

            If TypeOf ctl Is TextBox Then

                ctl.Text = ""


            ElseIf ctl.Controls.Count > 0 Then

                clearbox(ctl.Controls) '递归调用

            End If

        Next

        For Each ctl As Control In cc

            If TypeOf ctl Is ComboBox Then

                ctl.Text = ""


            ElseIf ctl.Controls.Count > 0 Then

                clearbox(ctl.Controls) '递归调用

            End If

        Next




    End Sub

    Private Sub 保存记录ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存记录ToolStripMenuItem.Click
        Try


            Dim objcommand As New SqlClient.SqlCommand



            objcommand.Connection = objconnection
            objcommand.CommandText = "insert into CIQ_Trade (Receipt_id,Unload_id,Production_id,原料合同号,报关单号,原料领用库位,产品存放库位,销售合同号,日期,提单号,客户名称,件数,重量,品名,运输方式) values (@Receipt_id,@Unload_id,@Production_id,@原料合同号,@报关单号,@原料领用库位,@产品存放库位,@销售合同号,@日期,@提单号,@客户名称,@件数,@重量,@品名,@运输方式)"

            objcommand.Parameters.AddWithValue("@原料合同号", Trim(hetonghao.Text))

            objcommand.Parameters.AddWithValue("@报关单号", Trim(baoguandanhao.Text))

            objcommand.Parameters.AddWithValue("@原料领用库位", Trim(lingyongkuwei.Text))

            objcommand.Parameters.AddWithValue("@产品存放库位", Trim(cunfangkuwei.Text))

            objcommand.Parameters.AddWithValue("@Receipt_id", Val(Receipt_id.Text))
            objcommand.Parameters.AddWithValue("@Unload_id", Val(Unload_id.Text))
            objcommand.Parameters.AddWithValue("@Production_id", Val(Production_id.Text))

            objcommand.Parameters.AddWithValue("@销售合同号", Trim(xshth.Text))


            objcommand.Parameters.AddWithValue("@日期", riqi.Value)

            objcommand.Parameters.AddWithValue("@提单号", Trim(xstdh.Text))

            objcommand.Parameters.AddWithValue("@客户名称", Trim(kehumingcheng.Text))

            objcommand.Parameters.AddWithValue("@件数", Val(jianshu.Text))

            objcommand.Parameters.AddWithValue("@重量", Val(zhongliang.Text))

            objcommand.Parameters.AddWithValue("@品名", Trim(pinming.Text))

            objcommand.Parameters.AddWithValue("@运输方式", Trim(chechuanhao.Text))
            '-------------------------------------------------------------------------------------------------------------------------------

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objcommand.ExecuteNonQuery()
            objconnection.Close()

            MessageBox.Show("数据已经提交", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            showall()
            clearbox(Me.Controls)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub showall()

        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from CIQ_Trade where 报关单号='" & Trim(bgbg.Text) & "' order by 日期 desc"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "baoguandanhao")
        objdataview = New DataView(objdataset.Tables("baoguandanhao"))
        dgv2.DataSource = objdataview
        objconnection.Close()
    End Sub

 
    Private Sub CIQ_Trade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.AllowUserToAddRows = False
        dgv2.AllowUserToAddRows = False
    End Sub



    Private Sub dgv_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv.CellFormatting
        dgv.Columns(0).Width = 0
    End Sub

    Private Sub 退出界面ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出界面ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FORSQL_KeyDown(sender As Object, e As KeyEventArgs) Handles FORSQL.KeyDown
        If e.KeyCode = Keys.Enter Then
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandType = CommandType.Text
            If Len(FORSQL.Text) = 0 Then
                objdataadapter.SelectCommand.CommandText = "select top 200 * from CIQ_Production order by 日期 desc "
            Else
                objdataadapter.SelectCommand.CommandText = "select * from CIQ_Production where ltrim(rtrim(报关单号)) ='" & Trim(FORSQL.Text) & "'"
            End If


            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "SQL")

            objdataview = New DataView(objdataset.Tables("SQL"))
            If objdataview.Count >= 1 Then
                dgv.DataSource = objdataview

            Else
                MessageBox.Show("没有该报关单号，请联系相关人员吧创建!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If



            objconnection.Close()

        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        On Error Resume Next

        hetonghao.Text = Trim(dgv.Rows(e.RowIndex).Cells(1).Value)
        baoguandanhao.Text = Trim(dgv.Rows(e.RowIndex).Cells(2).Value)
        pinming.Text = Trim(dgv.Rows(e.RowIndex).Cells(7).Value)
        lingyongkuwei.Text = Trim(dgv.Rows(e.RowIndex).Cells(3).Value)
        cunfangkuwei.Text = Trim(dgv.Rows(e.RowIndex).Cells(11).Value)

        Receipt_id.Text = Trim(dgv.Rows(e.RowIndex).Cells(13).Value)
        Unload_id.Text = Trim(dgv.Rows(e.RowIndex).Cells(14).Value)

        Production_id.Text = Trim(dgv.Rows(e.RowIndex).Cells(0).Value)


        bgbg.Text = Trim(dgv.Rows(e.RowIndex).Cells(2).Value) '这里的HTHT存放的是报关单号
        ' bgbg.Text = Trim(dgv.Rows(e.RowIndex).Cells(7).Value) '这里的LYLY存放的是产成品品名


        'objdataadapter.SelectCommand = New SqlClient.SqlCommand
        'objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from CIQ_Trade where ltrim(rtrim(报关单号)) ='" & Trim(bgbg.Text) & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "SQL")
        objdataview = New DataView(objdataset.Tables("SQL"))
        dgv2.DataSource = objdataview
        objconnection.Close()
    End Sub

    Private Sub dgv2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv2.CellFormatting
        dgv2.Columns(0).Width = 0
    End Sub

    Private Sub 批量导入ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 批量导入ToolStripMenuItem.Click
        If Len(baoguandanhao.Text) > 0 Then
            CIQ_Import.Show()
            CIQ_Import.hetonghao.Text = hetonghao.Text
            CIQ_Import.baoguandanhao.Text = baoguandanhao.Text
            CIQ_Import.lingyongkuwei.Text = lingyongkuwei.Text
            CIQ_Import.cunfangkuwei.Text = cunfangkuwei.Text
        Else
            MessageBox.Show("在导入贸易出库前报关单号不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Try
            If Len(Receipt_id.Text) > 0 Then
                objdataadapter = New SqlClient.SqlDataAdapter
                objdataadapter.SelectCommand = New SqlClient.SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection
                objdataadapter.SelectCommand.CommandType = CommandType.StoredProcedure

                objdataadapter.SelectCommand.CommandText = "CIQ_DELTrade"



                objdataadapter.SelectCommand.Parameters.AddWithValue("@idid", Val(Trade_id.Text))


                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objdataadapter.SelectCommand.ExecuteNonQuery()
                objconnection.Close()

                MessageBox.Show("您所选的记录已被删除!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                showall()

            Else

                MessageBox.Show("请先选中记录才可以进行删除操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgv2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv2.CellClick
        On Error Resume Next
        Trade_id.Text = Val(dgv2.Rows(e.RowIndex).Cells(0).Value)
    End Sub
End Class