
Public Class CIQ_Receipt
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Dim a As Integer
 

 
    Private Sub 保存记录ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存记录ToolStripMenuItem.Click
        Try
            If Len(hetonghao.Text) > 0 And Len(baoguandanhao.Text) > 0 Then

                Dim objcommand As New SqlClient.SqlCommand



                objcommand.Connection = objconnection
                objcommand.CommandText = "insert into CIQ_Receipt (合同号,报关单号,操作人,提单数量,库位) values (@合同号,@报关单号,@操作人,@提单数量,@库位)"

                objcommand.Parameters.AddWithValue("@合同号", Trim(hetonghao.Text))

                objcommand.Parameters.AddWithValue("@报关单号", Trim(baoguandanhao.Text))

                objcommand.Parameters.AddWithValue("@操作人", Trim(caozuoren.Text))




                objcommand.Parameters.AddWithValue("@提单数量", Val(tidanshuliang.Text))

                objcommand.Parameters.AddWithValue("@库位", Trim(kuwei.Text))







                '-------------------------------------------------------------------------------------------------------------------------------

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objcommand.ExecuteNonQuery()


                MessageBox.Show("数据已经提交", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                '---------------------------------------------

                objdataadapter.SelectCommand = New SqlClient.SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection
                objdataadapter.SelectCommand.CommandText = "select * from CIQ_Receipt where ltrim(rtrim(合同号)) ='" & Trim(HTHT.Text) & "'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "SQL")
                objdataview = New DataView(objdataset.Tables("SQL"))
                dgv2.DataSource = objdataview
                objconnection.Close()

                '------------------------------
                clearbox(Me.Controls)
            Else
                MessageBox.Show("合同号和报关单号不能为空!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
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

    Private Sub showall()

        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandType = CommandType.Text

        objdataadapter.SelectCommand.CommandText = "select * from CIQ_Receipt where ltrim(rtrim(合同号)) ='" & Trim(HTHT.Text) & "'"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "CIQ_Receipt")
        objdataview = New DataView(objdataset.Tables("CIQ_Receipt"))
        dgv2.DataSource = objdataview
        objconnection.Close()
    End Sub
  

    Private Sub CIQ_Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.AllowUserToAddRows = False
        dgv2.AllowUserToAddRows = False
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles FORSQL.KeyDown
        If e.KeyCode = Keys.Enter Then
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandType = CommandType.Text
            If Len(FORSQL.Text) = 0 Then
                objdataadapter.SelectCommand.CommandText = "select top 100 * from CIQ_Purchase order by 合同日期 desc"
            Else
                objdataadapter.SelectCommand.CommandText = "select * from CIQ_Purchase where ltrim(rtrim(合同号)) ='" & Trim(FORSQL.Text) & "'"
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
                MessageBox.Show("没有该合同号，请联系相关人员吧创建!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If



            objconnection.Close()

        End If
    End Sub

    Private Sub dgv_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv.CellFormatting
        dgv.Columns(0).Width = 0
    End Sub

  
    Private Sub dgv2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv2.CellFormatting
        dgv2.Columns(0).Width = 0
    End Sub

    

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        On Error Resume Next
        idid.Text = Trim(dgv.Rows(e.RowIndex).Cells(0).Value)
        hetonghao.Text = Trim(dgv.Rows(e.RowIndex).Cells(1).Value)
        HTHT.Text = Trim(dgv.Rows(e.RowIndex).Cells(1).Value)



        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from CIQ_Receipt where ltrim(rtrim(合同号)) ='" & Trim(HTHT.Text) & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "SQL")
        objdataview = New DataView(objdataset.Tables("SQL"))
        dgv2.DataSource = objdataview
        objconnection.Close()
    End Sub

 
    Private Sub 退出界面ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出界面ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub dgv2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv2.CellClick
        On Error Resume Next
        idid.Text = Trim(dgv2.Rows(e.RowIndex).Cells(0).Value)
        hetonghao.Text = Trim(dgv2.Rows(e.RowIndex).Cells(1).Value)
        BGBG.Text = Trim(dgv2.Rows(e.RowIndex).Cells(2).Value)

    End Sub

  
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Try
            If Len(idid.Text) > 0 Then
                objdataadapter = New SqlClient.SqlDataAdapter
                objdataadapter.SelectCommand = New SqlClient.SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection
                objdataadapter.SelectCommand.CommandType = CommandType.StoredProcedure

                objdataadapter.SelectCommand.CommandText = "CIQ_DELBAOGUANDANHAO"



                objdataadapter.SelectCommand.Parameters.AddWithValue("@baoguandanhao", Trim(BGBG.Text))


                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objdataadapter.SelectCommand.ExecuteNonQuery()
                objconnection.Close()

                MessageBox.Show("所有相关联的报关单号已被全部删除!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                showall()

            Else

                MessageBox.Show("请先选中记录才可以进行删除操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class