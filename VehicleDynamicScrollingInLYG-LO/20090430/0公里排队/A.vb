Public Class MAOYI
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim sendsomething As New sendmessage.CTEnterprisesSoapClient


    Dim veh_return, in_date, stre, stre_2, stre_3, phone_no As String
    Dim crytogram, vehicle, externo As String



    Private Sub A_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection


        kedengji.AllowUserToAddRows = False '消除最后一行


        'Dim temp As Integer
        'temp = TRUCK.Auth_User("admin", "qwaszx", "wwqeq")
        'MessageBox.Show(temp)



    End Sub
 
    Private Sub showall()

        objdataadapter.SelectCommand.CommandType = CommandType.Text


        If TreeView1.SelectedNode.Text = "可登记" Then

            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 可登记=1 order by 推送时间 "
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "kedengji")

            objdataview = New DataView(objdataset.Tables("kedengji"))

            kedengji.DataSource = objdataview
            Box2.Text = "可登记数据"
            C1.Items(1).Enabled = True
        End If
        '----------------------------------------------------------
        If TreeView1.SelectedNode.Text = "已登记" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 已登记=1 order by 登记时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "yidengji")

            objdataview = New DataView(objdataset.Tables("yidengji"))

            kedengji.DataSource = objdataview
            Box2.Text = "已登记数据"
            C1.Items(1).Enabled = False
        End If
        '----------------------------------------------------------
        If TreeView1.SelectedNode.Text = "可进厂" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 可进厂=1 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "kejinchang")

            objdataview = New DataView(objdataset.Tables("kejinchang"))

            kedengji.DataSource = objdataview
            Box2.Text = "可进厂数据"
            C1.Items(1).Enabled = False
        End If
        '--------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "已完成" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE_BAK where 已完成=1 order by 完成时间 desc"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "yiwancheng")

            objdataview = New DataView(objdataset.Tables("yiwancheng"))

            kedengji.DataSource = objdataview
            Box2.Text = "已完成数据"
            C1.Items(1).Enabled = False
        End If
        '--------------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "--超时车辆" Then
            objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 可进厂=1 and  datediff(n,进厂时间,getdate())>120 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "chaoshi")

            objdataview = New DataView(objdataset.Tables("chaoshi"))

            kedengji.DataSource = objdataview
            kedengji.ContextMenuStrip = C1
            Box2.Text = "超时车辆"
            C1.Items(1).Enabled = False

        End If
        '------------------------------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "--退回车辆" Then
            objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 已退回=1 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "tuihui")

            objdataview = New DataView(objdataset.Tables("tuihui"))

            kedengji.DataSource = objdataview
            kedengji.ContextMenuStrip = Nothing
            Box2.Text = "退回车辆"
            C1.Items(1).Enabled = False
        End If

        '-------------------------------------------------------------------------------------------
        On Error Resume Next
        kedengji.Columns(0).Width = 1
        objconnection.Close()
    End Sub

    'Private Sub addcombo()
    '    loading.Visible = True

    '    '  Application.DoEvents()

    '    kehumingcheng.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    '    kehumingcheng.AutoCompleteSource = AutoCompleteSource.ListItems



    '    Dim a As Integer


    '    objdataadapter.SelectCommand = New System.Data.SqlClient.SqlCommand
    '    objdataadapter.SelectCommand.Connection = objconnection
    '    objdataadapter.SelectCommand.CommandText = "select 客户名称 from DATA_QUEUE"
    '    If objconnection.State = ConnectionState.Closed Then
    '        objconnection.Open()
    '    End If
    '    objdataset = New DataSet
    '    objdataadapter.Fill(objdataset, "kehu")

    '    objdataview = New DataView(objdataset.Tables("kehu"))

    '    ' MessageBox.Show(objdataview.Count)
    '    kehumingcheng.Items.Clear()
    '    'On Error Resume Next
    '    If objdataview.Count >= 1 Then
    '        For a = 0 To objdataview.Count - 1
    '            If Len(objdataview.Item(a).Item("客户名称").ToString) <> 0 Then
    '                kehumingcheng.Items.Add(Trim(objdataview.Item(a).Item("客户名称")))
    '            End If
    '        Next
    '    End If
    '    Application.DoEvents()

    '    objdataadapter.SelectCommand = New SqlClient.SqlCommand
    '    objdataadapter.SelectCommand.Connection = objconnection
    '    objdataadapter.SelectCommand.CommandText = "select 物料名称 from DATA_QUEUE"
    '    If objconnection.State = ConnectionState.Closed Then
    '        objconnection.Open()
    '    End If
    '    objdataset = New DataSet
    '    objdataadapter.Fill(objdataset, "wuliao")

    '    objdataview = New DataView(objdataset.Tables("wuliao"))

    '    ' MessageBox.Show(objdataview.Count)
    '    pinming.Items.Clear()


    '    If objdataview.Count >= 1 Then
    '        For a = 0 To objdataview.Count - 1
    '            If Len(objdataview.Item(a).Item("物料名称").ToString) <> 0 Then
    '                pinming.Items.Add(Trim(objdataview.Item(a).Item("物料名称")))
    '            End If
    '        Next
    '    End If




    '    objconnection.Close()

    '    loading.Visible = False


    'End Sub
    'Private Sub addtxt()
    '    Dim sr As IO.StreamReader
    '    sr = New System.IO.StreamReader(Application.StartupPath & "\客户名称.txt", True)
    '    kehumingcheng.Items.Clear()
    '    Do While sr.Peek > 0
    '        kehumingcheng.Items.Add(sr.ReadLine)
    '    Loop
    '    ' MessageBox.Show(sr.ReadToEnd)
    '    'MessageBox.Show(OpenFileDialog1.FileName)
    '    sr.Close()
    '    sr = Nothing
    'End Sub
    'Private Sub savetxt()
    '    If kehumingcheng.Text.Length > 0 Then
    '        If kehumingcheng.FindString(kehumingcheng.Text) < 0 Then
    '            Dim xr As New IO.StreamWriter(Application.StartupPath & "\客户名称.txt", True)
    '            xr.WriteLine(kehumingcheng.Text)
    '            xr.Flush()
    '            xr.Close()
    '        End If
    '    End If
    'End Sub






    


    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        objdataadapter.SelectCommand.CommandType = CommandType.Text


        If TreeView1.SelectedNode.Text = "可登记" Then

            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 可登记=1 order by 推送时间 "
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "kedengji")

            objdataview = New DataView(objdataset.Tables("kedengji"))

            kedengji.DataSource = objdataview
            Box2.Text = "可登记数据"
            Button4.Enabled = True
            C1.Items(1).Enabled = True


        End If
        '----------------------------------------------------------
        If TreeView1.SelectedNode.Text = "已登记" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 已登记=1 order by 登记时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "yidengji")

            objdataview = New DataView(objdataset.Tables("yidengji"))

            kedengji.DataSource = objdataview
            Box2.Text = "已登记数据"
            Button4.Enabled = True
            C1.Items(1).Enabled = False
        End If
        '----------------------------------------------------------
        If TreeView1.SelectedNode.Text = "可进厂" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 可进厂=1 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "kejinchang")

            objdataview = New DataView(objdataset.Tables("kejinchang"))

            kedengji.DataSource = objdataview
            Box2.Text = "可进厂数据"
            Button4.Enabled = True
            C1.Items(1).Enabled = False
        End If
        '--------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "已完成" Then
            objdataadapter.SelectCommand.CommandText = "select top 100 * from TRUCK_QUEUE_BAK where 已完成=1 order by 完成时间 desc"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "yiwancheng")

            objdataview = New DataView(objdataset.Tables("yiwancheng"))

            kedengji.DataSource = objdataview
            Box2.Text = "已完成数据"
            Button4.Enabled = False
            C1.Items(1).Enabled = False
        End If
        '--------------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "--超时车辆" Then
            objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 可进厂=1 and  datediff(n,进厂时间,getdate())>120 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "chaoshi")

            objdataview = New DataView(objdataset.Tables("chaoshi"))

            kedengji.DataSource = objdataview
            kedengji.ContextMenuStrip = C1
            Box2.Text = "超时车辆"
            Button4.Enabled = True
            C1.Items(1).Enabled = False
        End If
        '------------------------------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "--退回车辆" Then
            objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 已退回=1 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "tuihui")

            objdataview = New DataView(objdataset.Tables("tuihui"))

            kedengji.DataSource = objdataview
            kedengji.ContextMenuStrip = Nothing
            Box2.Text = "退回车辆"
            Button4.Enabled = True
            C1.Items(1).Enabled = False
        End If

        '-------------------------------------------------------------------------------------------
        On Error Resume Next
        kedengji.Columns(0).Width = 1
        objconnection.Close()

    End Sub



    Private Sub dianhuahaoma_TextChanged(sender As Object, e As EventArgs) Handles dianhuahaoma.TextChanged
        If IsNumeric(Trim(dianhuahaoma.Text)) = False Then
            MessageBox.Show("请录入数据而非字符且不超过11位，谢谢！")
            dianhuahaoma.Text = ""
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'addcombo()
    End Sub

    Private Sub kedengji_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles kedengji.CellContentClick

        On Error Resume Next
        idid.Text = Trim(kedengji.Rows(e.RowIndex).Cells(0).Value)
        kehumingcheng.Text = Trim(kedengji.Rows(e.RowIndex).Cells(1).Value)

        shuliang.Text = Trim(kedengji.Rows(e.RowIndex).Cells(5).Value)


        pinming.Text = Trim(kedengji.Rows(e.RowIndex).Cells(2).Value)
        tidanhao.Text = Trim(kedengji.Rows(e.RowIndex).Cells(3).Value)
        chehao.Text = Trim(kedengji.Rows(e.RowIndex).Cells(6).Value)
        dianhuahaoma.Text = Trim(kedengji.Rows(e.RowIndex).Cells(7).Value)

        zipaiche.Checked = kedengji.Rows(e.RowIndex).Cells(19).Value
        beizhu.Text = Trim(kedengji.Rows(e.RowIndex).Cells(17).Value)

        isReserved.Checked = kedengji.Rows(e.RowIndex).Cells(32).Value
        Reservedtime1.Text = kedengji.Rows(e.RowIndex).Cells(33).Value
        Reservedtime2.Text = kedengji.Rows(e.RowIndex).Cells(34).Value
    End Sub





    Private Sub kedengji_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles kedengji.CellFormatting
        Dim dgv As DataGridView = CType(sender, DataGridView)

        '确认单元格的列




        '根据单元格的值，变更背景色
        If dgv.Rows(e.RowIndex).Cells("车辆信息更改").Value Is DBNull.Value Or dgv.Rows(e.RowIndex).Cells("车辆信息更改时间").Value Is DBNull.Value Then

        Else


            e.CellStyle.BackColor = Color.Yellow

        End If


    End Sub

    Private Sub 退回操作ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles del.Click
        Try

            Dim objcommanddel As New SqlClient.SqlCommand
            objcommanddel.Connection = objconnection
            objcommanddel.CommandText = "delete from TRUCK_QUEUE where id=" & Val(idid.Text)

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommanddel.ExecuteNonQuery()
            objcommanddel.CommandText = "delete from TRUCK_QUEUE_BAK where id=" & Val(idid.Text)
            objcommanddel.ExecuteNonQuery()


            MessageBox.Show("删除成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            showall()
            clearall()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub clearall()
        For Each c As Windows.Forms.Control In Me.jichuxinxi.Controls
            If TypeOf c Is Windows.Forms.ComboBox Then
                c.Text = "请选择"
            ElseIf TypeOf c Is Windows.Forms.TextBox Then
                c.Text = "0"
            End If
        Next


    End Sub

   
   

    Private Sub chaxun_KeyDown(sender As Object, e As KeyEventArgs) Handles chaxun.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then


            If TreeView1.SelectedNode.Text = "可登记" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 可登记=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"


                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "kedengji")

                objdataview = New DataView(objdataset.Tables("kedengji"))

                kedengji.DataSource = objdataview
                Box2.Text = "可登记数据"
                C1.Items(1).Enabled = True
            End If
            '----------------------------------------------------------
            If TreeView1.SelectedNode.Text = "已登记" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 已登记=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yidengji")

                objdataview = New DataView(objdataset.Tables("yidengji"))

                kedengji.DataSource = objdataview
                Box2.Text = "已登记数据"
                C1.Items(1).Enabled = False
            End If
            '----------------------------------------------------------
            If TreeView1.SelectedNode.Text = "可进厂" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 可进厂=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "kejinchang")

                objdataview = New DataView(objdataset.Tables("kejinchang"))

                kedengji.DataSource = objdataview
                Box2.Text = "可进厂数据"
                C1.Items(1).Enabled = False
            End If
            '--------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "已完成" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE_BAK where 已完成=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yiwancheng")

                objdataview = New DataView(objdataset.Tables("yiwancheng"))

                kedengji.DataSource = objdataview
                Box2.Text = "已完成数据"
                C1.Items(1).Enabled = False
            End If
            '-----------------------------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "--超时车辆" Then
                objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 可进厂=1 and  datediff(n,进厂时间,getdate())>120 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "chaoshi")

                objdataview = New DataView(objdataset.Tables("chaoshi"))

                kedengji.DataSource = objdataview

                Box2.Text = "超时车辆"
                C1.Items(1).Enabled = False
            End If
            '------------------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "--退回车辆" Then
                objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 已退回=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "tuihui")

                objdataview = New DataView(objdataset.Tables("tuihui"))

                kedengji.DataSource = objdataview
                kedengji.ContextMenuStrip = Nothing
                Box2.Text = "退回车辆"
                C1.Items(1).Enabled = False
            End If

            '-------------------------------------------------------------------------------------------

            kedengji.Columns(0).Width = 0
            objconnection.Close()

        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub force_Click(sender As Object, e As EventArgs) Handles force.Click
        'VPN没有+无论任何情况都可以登记
        Dim objcommandpassword As New SqlClient.SqlCommand
        objcommandpassword.Connection = objconnection
        objcommandpassword.CommandText = "update TRUCK_QUEUE set 可登记=0,已登记=1,登记时间=@登记时间,备注=@备注" & " where id=" & Val(idid.Text)
        objcommandpassword.Parameters.AddWithValue("@登记时间", sendsomething.getDateTime())
        objcommandpassword.Parameters.AddWithValue("@备注", Trim(beizhu.Text))
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If

        objcommandpassword.ExecuteNonQuery()
        objconnection.Close()
        MessageBox.Show("登记完成！（如没有选择记录，将不会有任何改变)", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '-------------------------------------

        'InsertConsignVehicle()


        ''---------------------------------------------------------------------------------------------------------------------------以上是报备，以下是办理通行证
        'UpdateConsignVehicle()

        showall()
        clearall()
    End Sub
    Private Function InsertConsignVehicle()
        '车辆申报


        Dim insertsomething As New lygport_outside.Service1SoapClient

        vehicle = Trim(chehao.Text)
        phone_no = Trim(dianhuahaoma.Text)

        stre_2 = insertsomething.InsertConsignVehicle("siewn%%iu#$W*insert_yh", vehicle, phone_no)
        If stre_2 = "success" Then
            MessageBox.Show("车号已报备港口集团!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(stre_2, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        '注意:
        '(1)对于传入的参数vehicle，phone_no,均不能为空
        '(2)当strE返回的是success表明申报成功
        '        未申报成功原因请参照strE返回值的内容()
        Return stre_2
    End Function

    Private Function UpdateConsignVehicle()
        '车辆放行
        Dim updatesomething As New lygport_outside.Service1SoapClient
        stre_3 = updatesomething.UpdateConsignVehicle("ygygdn%hjiu**W*update_yh", Trim(chehao.Text))

        If stre_3 = "success" Then
            MessageBox.Show("通行证已开始启用，请到隔壁进行绑定后方可入港！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(stre_3, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return stre_3
    End Function

   

    Private Sub 配卡通行ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 配卡通行ToolStripMenuItem.Click
        港务局测试一卡通专用.Show()
        港务局测试一卡通专用.chehao.Text = Trim(chehao.Text)
        港务局测试一卡通专用.dianhuahaoma.Text = Trim(dianhuahaoma.Text)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If Len(chehao.Text) > 0 Then
                objdataadapter = New SqlClient.SqlDataAdapter
                objdataadapter.SelectCommand = New SqlClient.SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection
                objdataadapter.SelectCommand.CommandType = CommandType.StoredProcedure

                objdataadapter.SelectCommand.CommandText = "updatetruckno"



                objdataadapter.SelectCommand.Parameters.AddWithValue("@id", Trim(idid.Text))
                objdataadapter.SelectCommand.Parameters.AddWithValue("@zipaiche", zipaiche.Checked)
                objdataadapter.SelectCommand.Parameters.AddWithValue("@chehao", Trim(chehao.Text))
                objdataadapter.SelectCommand.Parameters.AddWithValue("@dianhuahaoma", Trim(dianhuahaoma.Text))

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objdataadapter.SelectCommand.ExecuteNonQuery()
                objconnection.Close()

                MessageBox.Show("完成更新操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                showall()
                sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<车辆变更信息>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨,车号已变更为:" & Trim(chehao.Text), "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")


            Else

                MessageBox.Show("请先选中记录再继续!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            End If

            clearall()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        A1.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        A2.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        A3.Show()
    End Sub

  
    
   
   
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class