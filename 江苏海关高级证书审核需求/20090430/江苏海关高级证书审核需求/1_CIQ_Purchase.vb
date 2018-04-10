
Public Class CIQ_Purchase

    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim objdataview As New DataView
    Dim objdataset As New DataSet


    

    

   
    Private Sub 保存记录ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存记录ToolStripMenuItem.Click

        Try
            If Len(hetonghao.Text) <> 0 Then



                Dim objcommand As New SqlClient.SqlCommand

                objcommand.Connection = objconnection
                objcommand.CommandText = "insert into CIQ_Purchase (合同号,合同数量,溢短装,合同单价_美,合同单价_中,合同日期,国别,货品,物料号,操作人,船名,单位,运输方式,支付方式,供应商) values (@合同号,@合同数量,@溢短装,@合同单价_美,@合同单价_中,@合同日期,@国别,@货品,@物料号,@操作人,@船名,@单位,@运输方式,@支付方式,@供应商)"

                objcommand.Parameters.AddWithValue("@合同号", Trim(hetonghao.Text))

                objcommand.Parameters.AddWithValue("@合同数量", Trim(hetongshuliang.Text))

                objcommand.Parameters.AddWithValue("@溢短装", Val(yiduanzhuang.Text))


                objcommand.Parameters.AddWithValue("@合同单价_美", Val(hetongdanjiameiyuan.Text))

                objcommand.Parameters.AddWithValue("@合同单价_中", Val(hetongdanjiarmb.Text))


                objcommand.Parameters.AddWithValue("@合同日期", hetongriqi.Value)


                objcommand.Parameters.AddWithValue("@国别", Trim(guobie.Text))

                objcommand.Parameters.AddWithValue("@货品", Trim(huopin.Text))

                objcommand.Parameters.AddWithValue("@物料号", Trim(wuliaohao.Text))

                objcommand.Parameters.AddWithValue("@操作人", Trim(caozuoren.Text))

                objcommand.Parameters.AddWithValue("@船名", Trim(chuanming.Text))

                objcommand.Parameters.AddWithValue("@单位", Trim(danwei.Text))


                objcommand.Parameters.AddWithValue("@运输方式", Val(yunshufangshi.Text))
                objcommand.Parameters.AddWithValue("@支付方式", Val(zhifufangshi.Text))
                objcommand.Parameters.AddWithValue("@供应商", Trim(gongyingshang.Text))





                '-------------------------------------------------------------------------------------------------------------------------------

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objcommand.ExecuteNonQuery()
                objconnection.Close()

                MessageBox.Show("数据已经提交", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                showall()
                clearbox(Me.Controls)
            Else
                MessageBox.Show("合同号关键字不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If Len(hetonghao.Text) = 0 Then
            objdataadapter.SelectCommand.CommandText = "select top 100 * from CIQ_Purchase order by 合同日期 desc"
        Else
            objdataadapter.SelectCommand.CommandText = "select * from CIQ_Purchase where ltrim(rtrim(合同号)) ='" & Trim(hetonghao.Text) & "'"
        End If
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "hetonghao")
        objdataview = New DataView(objdataset.Tables("hetonghao"))
        dgv.DataSource = objdataview
        objconnection.Close()
    End Sub


  
    Private Sub hetonghao_KeyDown(sender As Object, e As KeyEventArgs) Handles hetonghao.KeyDown
        'On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandType = CommandType.Text
            If Len(hetonghao.Text) = 0 Then
                objdataadapter.SelectCommand.CommandText = "select top 100 * from CIQ_Purchase order by 合同日期 desc"
            Else
                objdataadapter.SelectCommand.CommandText = "select * from CIQ_Purchase where ltrim(rtrim(合同号)) ='" & Trim(hetonghao.Text) & "'"
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
                MessageBox.Show("没有该合同号，请创建!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If



            objconnection.Close()

        End If

    End Sub

  
  
  
    Private Sub CIQ_Purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.AllowUserToAddRows = False
    End Sub

    Private Sub 重置界面ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重置界面ToolStripMenuItem.Click
        clearbox(Me.Controls)
    End Sub

    Private Sub 退出界面ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出界面ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub 删除合同ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除合同ToolStripMenuItem.Click
        Try
            If Len(idid.Text) > 0 Then
                objdataadapter = New SqlClient.SqlDataAdapter
                objdataadapter.SelectCommand = New SqlClient.SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection
                objdataadapter.SelectCommand.CommandType = CommandType.StoredProcedure

                objdataadapter.SelectCommand.CommandText = "CIQ_DELHETONGHAO"



                objdataadapter.SelectCommand.Parameters.AddWithValue("@hetonghao", Trim(htht.Text))
         

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objdataadapter.SelectCommand.ExecuteNonQuery()
                objconnection.Close()

                MessageBox.Show("该合同已被删除!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                showall()
           
            Else

                MessageBox.Show("请先选中记录才可以进行删除操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        On Error Resume Next
        idid.Text = Trim(dgv.Rows(e.RowIndex).Cells(0).Value)
        htht.Text = Trim(dgv.Rows(e.RowIndex).Cells(1).Value)
   
    End Sub
End Class