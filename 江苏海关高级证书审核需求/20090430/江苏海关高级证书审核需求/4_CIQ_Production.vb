Public Class CIQ_Production
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
        'Try

        If Len(hetonghao.Text) > 0 And Len(baoguandanhao.Text) > 0 Then




            Dim objcommand As New SqlClient.SqlCommand



            objcommand.Connection = objconnection
            objcommand.CommandText = "insert into CIQ_Production (Receipt_id,Unload_id,合同号,报关单号,操作人,领用库位,领用数量,日期,日期2,产成品品名,产成品品名2,产成品品名3,产成品数量,产出库位) values (@Receipt_id,@Unload_id,@合同号,@报关单号,@操作人,@领用库位,@领用数量,@日期,@日期2,@产成品品名,@产成品品名2,@产成品品名3,@产成品数量,@产出库位)"

            objcommand.Parameters.AddWithValue("@合同号", Trim(hetonghao.Text))

            objcommand.Parameters.AddWithValue("@报关单号", Trim(baoguandanhao.Text))

            objcommand.Parameters.AddWithValue("@操作人", Trim(caozuoren.Text))

            objcommand.Parameters.AddWithValue("@Receipt_id", Val(Receipt_id.Text))
            objcommand.Parameters.AddWithValue("@Unload_id", Val(Unload_id.Text))

            objcommand.Parameters.AddWithValue("@领用库位", Trim(lingyongkuwei.Text))

            objcommand.Parameters.AddWithValue("@领用数量", Val(lingyongshuliang.Text))


            objcommand.Parameters.AddWithValue("@日期", riqi.Value)
            objcommand.Parameters.AddWithValue("@日期2", riqi2.Value)

            objcommand.Parameters.AddWithValue("@产出库位", Trim(chanchukuwei.Text))


            objcommand.Parameters.AddWithValue("@产成品品名", Trim(ccppm.Text))
            objcommand.Parameters.AddWithValue("@产成品品名2", Trim(ccppm2.Text))
            objcommand.Parameters.AddWithValue("@产成品品名3", Trim(ccppm3.Text))

            objcommand.Parameters.AddWithValue("@产成品数量", Val(ccpsl.Text))

            '-------------------------------------------------------------------------------------------------------------------------------

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objcommand.ExecuteNonQuery()
            objconnection.Close()

            MessageBox.Show("数据已经提交", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            clearbox(Me.Controls)
            showall()



        Else
            MessageBox.Show("合同号和报关单号不能为空!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub showall()

        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from CIQ_Production where ltrim(rtrim(报关单号)) ='" & Trim(BGBG.Text) & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "SQL")
        objdataview = New DataView(objdataset.Tables("SQL"))
        dgv2.DataSource = objdataview
        objconnection.Close()
    End Sub

    Private Sub CIQ_Production_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.AllowUserToAddRows = False
        dgv2.AllowUserToAddRows = False
    End Sub

    Private Sub dgv2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv2.CellFormatting
        dgv2.Columns(0).Width = 0
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
                objdataadapter.SelectCommand.CommandText = "select top 100 * from CIQ_Unload order by 日期 desc "
            Else
                objdataadapter.SelectCommand.CommandText = "select * from CIQ_Unload where ltrim(rtrim(报关单号)) ='" & Trim(FORSQL.Text) & "'"
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
        ' idid.Text = Trim(dgv.Rows(e.RowIndex).Cells(0).Value)
        hetonghao.Text = Trim(dgv.Rows(e.RowIndex).Cells(1).Value)
        baoguandanhao.Text = Trim(dgv.Rows(e.RowIndex).Cells(2).Value)
        lingyongkuwei.Text = Trim(dgv.Rows(e.RowIndex).Cells(8).Value)
        HTHT.Text = Trim(dgv.Rows(e.RowIndex).Cells(1).Value) '这里的HTHT存放的是报关单号
        BGBG.Text = Trim(dgv.Rows(e.RowIndex).Cells(2).Value)
        Receipt_id.Text = Trim(dgv.Rows(e.RowIndex).Cells(10).Value)
        Unload_id.Text = Trim(dgv.Rows(e.RowIndex).Cells(0).Value)



        objdataadapter.SelectCommand.CommandText = "select * from CIQ_Production where ltrim(rtrim(报关单号)) ='" & Trim(baoguandanhao.Text) & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "SQL")
        objdataview = New DataView(objdataset.Tables("SQL"))
        dgv2.DataSource = objdataview
        objconnection.Close()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Try
            If Len(Unload_id.Text) > 0 Then
                objdataadapter = New SqlClient.SqlDataAdapter
                objdataadapter.SelectCommand = New SqlClient.SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection
                objdataadapter.SelectCommand.CommandType = CommandType.StoredProcedure

                objdataadapter.SelectCommand.CommandText = "CIQ_DELProduction"



                objdataadapter.SelectCommand.Parameters.AddWithValue("@Production_id", Val(Production_id.Text))


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
        Production_id.Text = Trim(dgv2.Rows(e.RowIndex).Cells(0).Value)
        BGBG.Text = Trim(dgv2.Rows(e.RowIndex).Cells(2).Value)

    End Sub

    Private Sub FORSQL_TextChanged(sender As Object, e As EventArgs) Handles FORSQL.TextChanged

    End Sub

    Private Sub 更新所选记录ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 更新所选记录ToolStripMenuItem.Click
        Try

      
        Dim SCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(objdataadapter)

        objdataadapter.Update(objdataset.Tables("SQL"))


        Dim objcommand As New SqlClient.SqlCommand
            MessageBox.Show("数据已成功更新并保存！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("数据未能成功更新,失败原因:" & ex.Message, "失败提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class