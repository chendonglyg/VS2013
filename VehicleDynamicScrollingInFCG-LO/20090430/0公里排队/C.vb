Public Class CONTROL
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim OK43, Tree_No As Integer
    Dim sendsomething As New sendmessage.CTEnterprisesSoapClient
    Dim VehicleinPark As New lygport_outside.Service1SoapClient

    Dim veh_return, in_date, stre, stre_2, stre_3, phone_no As String
    Dim crytogram, vehicle, externo As String


    'Private Function InsertConsignVehicle()
    '    '车辆申报


    '    Dim insertsomething As New lygport_outside.Service1SoapClient

    '    vehicle = Trim(chehao.Text)
    '    phone_no = Trim(dianhuahaoma.Text)

    '    stre_2 = insertsomething.InsertConsignVehicle("siewn%%iu#$W*insert_yh", vehicle, phone_no)
    '    If stre_2 = "success" Then
    '        MessageBox.Show("车号已报备港口集团!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Else
    '        MessageBox.Show(stre_2, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If

    '    '注意:
    '    '(1)对于传入的参数vehicle，phone_no,均不能为空
    '    '(2)当strE返回的是success表明申报成功
    '    '        未申报成功原因请参照strE返回值的内容()
    '    Return stre_2
    'End Function

    'Private Function UpdateConsignVehicle()
    '    '车辆放行
    '    Dim updatesomething As New lygport_outside.Service1SoapClient
    '    stre_3 = updatesomething.UpdateConsignVehicle("ygygdn%hjiu**W*update_yh", Trim(chehao.Text))

    '    If stre_3 = "success" Then
    '        MessageBox.Show("通行证已开始启用，请到隔壁进行绑定后方可入港！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Else
    '        MessageBox.Show(stre_3, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    '    Return stre_3
    'End Function

    '-----------------以上两个配卡放行的过程最终决定依然不放在调度环节，还是放在停车场比较合适，因为停车场可以清楚知道车牌颜色.

    Private Sub C_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        yidengji.AllowUserToAddRows = False '消除最后一行
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        If private_data = "C" Then
            TreeView1.Enabled = True
            TreeView2.Enabled = False
        End If
        If private_data = "C1" Then
            TreeView1.Enabled = False
            TreeView2.Enabled = True
        End If
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
    Private Sub showall()
        On Error Resume Next
        If Tree_No = 2 Then

            If TreeView2.SelectedNode.Text = "已登记车辆" Then
                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  油脂=1  and 已登记=1 order by 登记时间"

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "kedengji")

                objdataview = New DataView(objdataset.Tables("kedengji"))
                yidengji.ContextMenuStrip = Oil
                yidengji.DataSource = objdataview
                box2.Text = "已登记油脂类车辆"
            End If


            '----------------------------------------------------------------------------------


            '-------------------------------------------------------------------
            If TreeView2.SelectedNode.Text = "可进厂车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 可进厂=1 and 油脂=1 order by 进厂时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "kejinchang")

                objdataview = New DataView(objdataset.Tables("kejinchang"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C3
                box2.Text = "可进厂车辆"
            End If
            '-----------------------------------------------------------------------------------------
            If TreeView2.SelectedNode.Text = "已完成车辆" Then
                objdataadapter.SelectCommand.CommandText = "select top 100 * from TRUCK_QUEUE_BAK where 已完成=1 and 油脂=1 order by 完成时间 desc"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yiwancheng")

                objdataview = New DataView(objdataset.Tables("yiwancheng"))
                yidengji.ContextMenuStrip = Nothing
                yidengji.DataSource = objdataview
                box2.Text = "已完成车辆"

            End If
            '---------------------------------------------------------------------------------------
            If TreeView2.SelectedNode.Text = "--超时车辆" Then
                objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 可进厂=1 and  datediff(n,进厂时间,getdate())>120 and 油脂=1 order by 进厂时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "chaoshi")

                objdataview = New DataView(objdataset.Tables("chaoshi"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C3
                box2.Text = "超时车辆"

            End If

            '------------------------------------------------------------------------------------------
            If TreeView2.SelectedNode.Text = "--退回车辆" Then
                objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 已退回=1 and 油脂=1 order by 进厂时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "tuihui")

                objdataview = New DataView(objdataset.Tables("tuihui"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = Nothing
                box2.Text = "退回车辆"

            End If
            '------------------------------===========================================

        End If

        If Tree_No = 1 Then



            If TreeView1.SelectedNode.Text = "已登记卸货车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  粕类=1 and 是否卸车=1 and 已登记=1 order by 登记时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "xiehuo")

                objdataview = New DataView(objdataset.Tables("xiehuo"))
                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C1
                box2.Text = "已登记卸货车辆"
            End If


            If TreeView1.SelectedNode.Text = "已登记43%粕车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where   粕类=1 and 自派车 <>1 and 已登记=1 and ltrim(rtrim(货物名称))='丰苑豆粕 43(50 KG)' order by 登记时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yidengji")

                objdataview = New DataView(objdataset.Tables("yidengji"))

                If objdataview.Count > 0 Then
                    OK43 = objdataview.Item(0).Item(0)
                End If
                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C1
            End If

            If TreeView1.SelectedNode.Text = "散货车辆42%" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where (客户物料号='豆粕-饲料类42（散粕)' or 客户物料号='豆粕-饲料类42（吨袋)' or 客户物料号='丰苑豆粕 42(50 KG)' or 客户物料号='丰苑定制豆粕2（50KG)')  and 已登记=1  order by 登记时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "sanhuo")

                objdataview = New DataView(objdataset.Tables("sanhuo"))

                If objdataview.Count > 0 Then
                    OK43 = objdataview.Item(0).Item(0) '第一条记录一定是给OK43
                End If


                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C1
                box2.Text = "散货车辆42%"
            End If
            '--------------------------------------------------------------------------

            If TreeView1.SelectedNode.Text = "散货车辆43%" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where (客户物料号='豆粕-饲料类43（散粕)' or 客户物料号='豆粕-饲料类43（吨袋)' ) and 已登记=1  order by 登记时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "sanhuo")

                objdataview = New DataView(objdataset.Tables("sanhuo"))

                If objdataview.Count > 0 Then
                    OK43 = objdataview.Item(0).Item(0) '第一条记录一定是给OK43
                End If


                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C1
                box2.Text = "散货车辆43%"
            End If
            '--------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "散货车辆46%" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where (客户物料号='豆粕-饲料类46（散粕)' or 客户物料号='豆粕-饲料类46（吨袋)' ) and 已登记=1  order by 登记时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "sanhuo")

                objdataview = New DataView(objdataset.Tables("sanhuo"))

                If objdataview.Count > 0 Then
                    OK43 = objdataview.Item(0).Item(0) '第一条记录一定是给OK43
                End If


                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C1
                box2.Text = "散货车辆46%"
            End If
            '-------------------------------------丰苑低纤维豆粕47（散粕）
            If TreeView1.SelectedNode.Text = "散货车辆47%" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where (客户物料号='丰苑低纤维豆粕47（散粕)' or 客户物料号='丰苑低纤维豆粕47（吨袋)' ) and 已登记=1  order by 登记时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "sanhuo")

                objdataview = New DataView(objdataset.Tables("sanhuo"))

                If objdataview.Count > 0 Then
                    OK43 = objdataview.Item(0).Item(0) '第一条记录一定是给OK43
                End If


                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C1
                box2.Text = "散货车辆47%"
            End If

            '---------------------------------------------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "已登记其他车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  (粕类=1 and 自派车 <>1 and 已登记=1 and ltrim(rtrim(货物名称))<>'丰苑豆粕 43(50 KG)'  and 客户物料号 is null) order by 登记时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yidengji")

                objdataview = New DataView(objdataset.Tables("yidengji"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C2
            End If
            '-------------------------------------------------------------------

            '-------------------------------------
            If TreeView1.SelectedNode.Text = "自派的车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 粕类=1 and 自派车=1 and 已登记=1  order by 登记时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yidengji")

                objdataview = New DataView(objdataset.Tables("yidengji"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C4
            End If
            '-------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "可进厂车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 粕类=1 and 可进厂=1 order by 进厂时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "kejinchang")

                objdataview = New DataView(objdataset.Tables("kejinchang"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C3
            End If
            '--------------------------------------
            If TreeView1.SelectedNode.Text = "已完成车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE_BAK where 粕类=1 and 已完成=1 order by 完成时间 desc"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yiwancheng")

                objdataview = New DataView(objdataset.Tables("yiwancheng"))

                yidengji.DataSource = objdataview

            End If
            '---------------------------------------------------------------------------------------
        End If
        objconnection.Close()




    End Sub

    Private Sub yidengji_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles yidengji.CellContentClick
        On Error Resume Next
        kehumingcheng.Text = Trim(yidengji.Rows(e.RowIndex).Cells(1).Value)
        IDID.Text = Trim(yidengji.Rows(e.RowIndex).Cells(0).Value)
        shuliang.Text = Trim(yidengji.Rows(e.RowIndex).Cells(5).Value)
        pinming.Text = Trim(yidengji.Rows(e.RowIndex).Cells(2).Value)
        tidanhao.Text = Trim(yidengji.Rows(e.RowIndex).Cells(3).Value)
        chehao.Text = Trim(yidengji.Rows(e.RowIndex).Cells(6).Value)
        dianhuahaoma.Text = Trim(yidengji.Rows(e.RowIndex).Cells(7).Value)
        beizhu.Text = Trim(yidengji.Rows(e.RowIndex).Cells(17).Value)
    End Sub







    Private Sub 粕可进厂ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 粕可进厂ToolStripMenuItem.Click

        Dim flag_park As String

        Try
            If Val(IDID.Text) = OK43 And (Len(IDID.Text) > 0) Then


                flag_park = VehicleinPark.VehicleInPark("VehicleInPark_yhwebs", Trim(chehao.Text))

                If flag_park = 1 Then  '车辆在停车场，将按照正常程序放行进厂

                    'If (Len(IDID.Text) > 0) Then '启用它即可任何车辆放行，无需排队

                    Dim objcommandpassword As New SqlClient.SqlCommand
                    objcommandpassword.Connection = objconnection
                    objcommandpassword.CommandText = "update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=1,进厂时间=@进厂时间" & " where id=" & Val(IDID.Text)
                    objcommandpassword.Parameters.AddWithValue("@进厂时间", sendsomething.getDateTime())

                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If

                    objcommandpassword.ExecuteNonQuery()
                    objconnection.Close()
                    MessageBox.Show("已放行受排队管制的车辆!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<进厂装货提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "可进厂装货!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                    showall()
                    clearall()
                Else
                    Dim objcommandpassword As New SqlClient.SqlCommand
                    objcommandpassword.Connection = objconnection
                    objcommandpassword.CommandText = "update TRUCK_QUEUE set 可登记=1,已登记=0,可进厂=0,退回时间=@退回时间" & " where id=" & Val(IDID.Text)
                    objcommandpassword.Parameters.AddWithValue("@退回时间", sendsomething.getDateTime())

                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If

                    objcommandpassword.ExecuteNonQuery()
                    objconnection.Close()
                    MessageBox.Show("因未放行前车辆就已离开停车场，故该车辆被强制退回至可登记状态!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<车辆退回提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "因未放行前车辆就已离开停车场，故请重新登记排队!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                    showall()
                    clearall()

                End If



            Else



                MessageBox.Show("禁止插队/没有可操作记录", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If











        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub 其他货物可进厂ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 其他货物可进厂ToolStripMenuItem.Click
        Try
            If (Len(IDID.Text) > 0) Then

                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objcommandpassword.CommandText = "update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=1,进厂时间=@进厂时间" & " where id=" & Val(IDID.Text)
                objcommandpassword.Parameters.AddWithValue("@进厂时间", sendsomething.getDateTime())

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommandpassword.ExecuteNonQuery()
                objconnection.Close()
                MessageBox.Show("其他货物车辆设置完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<进厂装货提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "可进厂装货!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                showall()
                clearall()
            Else
                MessageBox.Show("没有可操作记录", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try


            Dim objcommandpassword As New SqlClient.SqlCommand
            objcommandpassword.Connection = objconnection
            objcommandpassword.CommandText = "update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=0,已完成=1,完成时间=@完成时间" & " where id=" & Val(IDID.Text)
            objcommandpassword.Parameters.AddWithValue("@完成时间", sendsomething.getDateTime())

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommandpassword.ExecuteNonQuery()
            objconnection.Close()
            MessageBox.Show("装车已完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            showall()
            clearall()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub 车辆退回ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 车辆退回ToolStripMenuItem.Click
        Try


            Dim objcommandpassword As New SqlClient.SqlCommand
            objcommandpassword.Connection = objconnection
            objcommandpassword.CommandText = "update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=0,已退回=1,退回时间=@退回时间" & " where id=" & Val(IDID.Text)
            objcommandpassword.Parameters.AddWithValue("@退回时间", sendsomething.getDateTime())

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommandpassword.ExecuteNonQuery()
            objconnection.Close()
            MessageBox.Show("车辆已退回,需贸易开票处重新计划！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)
            showall()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Try
            If (Len(IDID.Text) > 0) Then

                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objcommandpassword.CommandText = "update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=1,进厂时间=@进厂时间" & " where id=" & Val(IDID.Text)
                objcommandpassword.Parameters.AddWithValue("@进厂时间", sendsomething.getDateTime())

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommandpassword.ExecuteNonQuery()
                objconnection.Close()
                MessageBox.Show("自派车辆设置完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)


                sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<进厂装货提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "可进厂装货!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                showall()
                clearall()
            Else
                MessageBox.Show("没有可操作记录", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Tree_No = 1
        TreeView2.SelectedNode = Nothing
        If TreeView1.SelectedNode.Text = "已登记卸货车辆" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where   是否卸车=1 and 已登记=1  order by 登记时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "xiehuo")

            objdataview = New DataView(objdataset.Tables("xiehuo"))
            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = C5
            box2.Text = "已登记卸货车辆"
        End If

        '----------------------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "已登记43%粕车辆" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where   粕类=1 and 自派车 <>1 and 已登记=1  and ltrim(rtrim(货物名称))='丰苑豆粕 43(50 KG)' order by 登记时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "yidengji")

            objdataview = New DataView(objdataset.Tables("yidengji"))

            If objdataview.Count > 0 Then
                OK43 = objdataview.Item(0).Item(0)
            End If
            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = C1
            box2.Text = "已登记43%粕车辆"
        End If
        '--------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "已登记其他车辆" Then
            Dim objcommandpassword As New SqlClient.SqlCommand
            objcommandpassword.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where (粕类=1 and 自派车 <>1 and 已登记=1 and ltrim(rtrim(货物名称))<>'丰苑豆粕 43(50 KG)' and len(客户物料号)=0) order by 登记时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "yidengji")

            objdataview = New DataView(objdataset.Tables("yidengji"))

            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = C2
            box2.Text = "已登记其他车辆"

        End If

        '-------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "散货车辆42%" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where (客户物料号='豆粕-饲料类42（散粕)' or 客户物料号='豆粕-饲料类42（吨袋)'  or 客户物料号='丰苑豆粕 42(50 KG)' or 客户物料号='丰苑定制豆粕2（50KG)') and 已登记=1  order by 登记时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "sanhuo")

            objdataview = New DataView(objdataset.Tables("sanhuo"))

            If objdataview.Count > 0 Then
                OK43 = objdataview.Item(0).Item(0) '第一条记录一定是给OK43
            End If


            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = C1
            box2.Text = "散货车辆42%"
        End If

        '-------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "散货车辆43%" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where (客户物料号='豆粕-饲料类43（散粕)' or 客户物料号='豆粕-饲料类43（吨袋)') and 已登记=1  order by 登记时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "sanhuo")

            objdataview = New DataView(objdataset.Tables("sanhuo"))

            If objdataview.Count > 0 Then
                OK43 = objdataview.Item(0).Item(0) '第一条记录一定是给OK43
            End If


            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = C1
            box2.Text = "散货车辆43%"
        End If
        '-------------------------------------丰苑低纤维豆粕47（散粕）
        If TreeView1.SelectedNode.Text = "散货车辆47%" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where (客户物料号='丰苑低纤维豆粕47（散粕)' or 客户物料号='丰苑低纤维豆粕47（吨袋)' ) and 已登记=1  order by 登记时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "sanhuo")

            objdataview = New DataView(objdataset.Tables("sanhuo"))

            If objdataview.Count > 0 Then
                OK43 = objdataview.Item(0).Item(0) '第一条记录一定是给OK43
            End If


            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = C1
            box2.Text = "散货车辆47%"
        End If
        '---------------------------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "散货车辆46%" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where (客户物料号='豆粕-饲料类46（散粕)' or 客户物料号='豆粕-饲料类46（吨袋)' ) and 已登记=1  order by 登记时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "sanhuo")

            objdataview = New DataView(objdataset.Tables("sanhuo"))

            If objdataview.Count > 0 Then
                OK43 = objdataview.Item(0).Item(0) '第一条记录一定是给OK43
            End If


            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = C1
            box2.Text = "散货车辆46%"
        End If

        '------------------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "自派的车辆" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  粕类=1 and 自派车=1 and 已登记=1  order by 登记时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "yidengji")

            objdataview = New DataView(objdataset.Tables("yidengji"))

            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = C4
            box2.Text = "自派的车辆"
        End If
        '-------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "可进厂车辆" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  粕类=1 and 可进厂=1 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "kejinchang")

            objdataview = New DataView(objdataset.Tables("kejinchang"))

            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = C3
            box2.Text = "可进厂车辆"
        End If
        '-----------------------------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "已完成车辆" Then
            objdataadapter.SelectCommand.CommandText = "select top 100 * from TRUCK_QUEUE_BAK where  粕类=1 and 已完成=1  order by 完成时间 desc"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "yiwancheng1")

            objdataview = New DataView(objdataset.Tables("yiwancheng1"))
            yidengji.ContextMenuStrip = Nothing
            yidengji.DataSource = objdataview
            box2.Text = "已完成车辆"

        End If
        '---------------------------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "--超时车辆" Then
            objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where  粕类=1 and 可进厂=1 and  datediff(n,进厂时间,getdate())>120  order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "chaoshi")

            objdataview = New DataView(objdataset.Tables("chaoshi"))

            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = C3
            box2.Text = "超时车辆"

        End If

        '------------------------------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "--退回车辆" Then
            objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where  粕类=1 and 已退回=1 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "tuihui")

            objdataview = New DataView(objdataset.Tables("tuihui"))

            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = Nothing
            box2.Text = "退回车辆"

        End If

        '-------------------------------------------------------------------------------------------
        On Error Resume Next


        yidengji.Columns(0).Width = 0
        objconnection.Close()

    End Sub

  

    Private Sub chaxun_KeyDown(sender As Object, e As KeyEventArgs) Handles chaxun.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            If TreeView1.SelectedNode.Text = "已登记卸货车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  是否卸车=1 and 已登记=1 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "xiehuo")

                objdataview = New DataView(objdataset.Tables("xiehuo"))
                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C1
                box2.Text = "已登记卸货车辆"
            End If

            '----------------------------------------------------------------------------------- 43,46,47不给查询，一查就会影响放插队机制
            'If TreeView1.SelectedNode.Text = "已登记43%粕车辆" Then
            '    objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where   自派车 <>1 and 已登记=1 and ltrim(rtrim(货物名称))='丰苑豆粕 43(50 KG)' and 车号 like '%" & Trim(chaxun.Text) & "%'"

            '    If objconnection.State = ConnectionState.Closed Then
            '        objconnection.Open()
            '    End If
            '    objdataset = New DataSet
            '    objdataadapter.Fill(objdataset, "kedengji")

            '    objdataview = New DataView(objdataset.Tables("kedengji"))

            '    yidengji.DataSource = objdataview
            '    box2.Text = "已登记43%粕车辆"
            'End If
            '----------------------------------------------------------
            If TreeView1.SelectedNode.Text = "已登记其他车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  粕类=1 and 自派车 <>1 and 已登记=1 and ltrim(rtrim(货物名称))<>'丰苑豆粕 43(50 KG)' and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yidengji")

                objdataview = New DataView(objdataset.Tables("yidengji"))

                yidengji.DataSource = objdataview
                box2.Text = "已登记其他车辆"
            End If
            '----------------------------------------------------------
            If TreeView1.SelectedNode.Text = "自派的车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  粕类=1 and 自派车=1 and 已登记=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "kejinchang")

                objdataview = New DataView(objdataset.Tables("kejinchang"))

                yidengji.DataSource = objdataview
                box2.Text = "自派的车辆"
            End If
            '--------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "可进厂车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  可进厂=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yiwancheng")

                objdataview = New DataView(objdataset.Tables("yiwancheng"))

                yidengji.DataSource = objdataview
                box2.Text = "可进厂车辆"
            End If
            '-----------------------------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "已完成车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE_BAK where  已完成=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "chaoshi")

                objdataview = New DataView(objdataset.Tables("chaoshi"))

                yidengji.DataSource = objdataview

                box2.Text = "已完成车辆"

            End If
            '------------------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "--超时车辆" Then
                objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where  可进厂=1 and  datediff(n,进厂时间,getdate())>120 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "tuihui")

                objdataview = New DataView(objdataset.Tables("tuihui"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = Nothing
                box2.Text = "超时车辆"

            End If




            '-------------------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "--退回车辆" Then
                objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 已退回=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "tuihui")

                objdataview = New DataView(objdataset.Tables("tuihui"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = Nothing
                box2.Text = "退回车辆"

            End If
            '-------------------------------------------------------------------
            '--------------------------------------------------------------------
            'If TreeView1.SelectedNode.Text = "散货车辆46%" Then
            '    objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where (客户物料号='豆粕-饲料类46（散粕)' or 客户物料号='豆粕-饲料类46（吨袋)' ) and 已登记=1  order by 登记时间"
            '    If objconnection.State = ConnectionState.Closed Then
            '        objconnection.Open()
            '    End If
            '    objdataset = New DataSet
            '    objdataadapter.Fill(objdataset, "sanhuo")

            '    objdataview = New DataView(objdataset.Tables("sanhuo"))

            '    If objdataview.Count > 0 Then
            '        OK43 = objdataview.Item(0).Item(0) '第一条记录一定是给OK43
            '    End If


            '    yidengji.DataSource = objdataview

            '    box2.Text = "散货车辆46%"
            'End If
            ''-------------------------------------丰苑低纤维豆粕47（散粕）
            'If TreeView1.SelectedNode.Text = "散货车辆47%" Then
            '    objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where (客户物料号='丰苑低纤维豆粕47（散粕)' or 客户物料号='丰苑低纤维豆粕47（吨袋)' ) and 已登记=1  order by 登记时间"
            '    If objconnection.State = ConnectionState.Closed Then
            '        objconnection.Open()
            '    End If
            '    objdataset = New DataSet
            '    objdataadapter.Fill(objdataset, "sanhuo")

            '    objdataview = New DataView(objdataset.Tables("sanhuo"))

            '    If objdataview.Count > 0 Then
            '        OK43 = objdataview.Item(0).Item(0) '第一条记录一定是给OK43
            '    End If


            '    yidengji.DataSource = objdataview
            '    yidengji.ContextMenuStrip = C1
            '    box2.Text = "散货车辆47%"
            'End If

            '---------------------------------------------------------------------------------------------------------------------
            yidengji.Columns(0).Width = 0
            objconnection.Close()

        End If




        '-------------------------------------------------------------------------------------///////////////////////////////////////////////////////////22222222


    End Sub

  

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Try
            If (Len(IDID.Text) > 0) Then

                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objcommandpassword.CommandText = "update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=1,进厂时间=@进厂时间" & " where id=" & Val(IDID.Text)
                objcommandpassword.Parameters.AddWithValue("@进厂时间", sendsomething.getDateTime())

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommandpassword.ExecuteNonQuery()
                objconnection.Close()
                MessageBox.Show("卸货车辆进厂操作设置完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<进厂卸货提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "可进厂卸货!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                showall()
                clearall()
            Else
                MessageBox.Show("没有可操作记录", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Private Sub TreeView2_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView2.AfterSelect
    '    Tree_No = 2
    '    On Error Resume Next
    '    If TreeView2.SelectedNode.Text = "已登记车辆" Then
    '        Dim objcommandpassword As New SqlClient.SqlCommand
    '        objcommandpassword.Connection = objconnection
    '        objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  油脂=1  and 已登记=1 order by 登记时间"

    '        If objconnection.State = ConnectionState.Closed Then
    '            objconnection.Open()
    '        End If
    '        objdataset = New DataSet
    '        objdataadapter.Fill(objdataset, "kedengji")

    '        objdataview = New DataView(objdataset.Tables("kedengji"))
    '        yidengji.ContextMenuStrip = Oil
    '        yidengji.DataSource = objdataview
    '        box2.Text = "已登记油脂类车辆"
    '    End If


    '    '----------------------------------------------------------------------------------


    '    '-------------------------------------------------------------------
    '    If TreeView2.SelectedNode.Text = "可进厂车辆" Then
    '        objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 可进厂=1 and 油脂=1 order by 进厂时间"
    '        If objconnection.State = ConnectionState.Closed Then
    '            objconnection.Open()
    '        End If
    '        objdataset = New DataSet
    '        objdataadapter.Fill(objdataset, "kejinchang")

    '        objdataview = New DataView(objdataset.Tables("kejinchang"))

    '        yidengji.DataSource = objdataview
    '        yidengji.ContextMenuStrip = C3
    '        box2.Text = "可进厂车辆"
    '    End If
    '    '-----------------------------------------------------------------------------------------
    '    If TreeView2.SelectedNode.Text = "已完成车辆" Then

    '        objdataadapter.SelectCommand.CommandText = "select top 100 * from TRUCK_QUEUE_BAK where 已完成=1 and 油脂=1 order by 完成时间 desc"
    '        If objconnection.State = ConnectionState.Closed Then
    '            objconnection.Open()
    '        End If
    '        objdataset = New DataSet
    '        objdataadapter.Fill(objdataset, "yiwancheng2")

    '        objdataview = New DataView(objdataset.Tables("yiwancheng2"))
    '        yidengji.ContextMenuStrip = Nothing
    '        yidengji.DataSource = objdataview
    '        box2.Text = "已完成车辆"

    '    End If
    '    '---------------------------------------------------------------------------------------
    '    If TreeView2.SelectedNode.Text = "--超时车辆" Then
    '        objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 可进厂=1 and  datediff(n,进厂时间,getdate())>120 and 油脂=1 order by 进厂时间"
    '        If objconnection.State = ConnectionState.Closed Then
    '            objconnection.Open()
    '        End If
    '        objdataset = New DataSet
    '        objdataadapter.Fill(objdataset, "chaoshi")

    '        objdataview = New DataView(objdataset.Tables("chaoshi"))

    '        yidengji.DataSource = objdataview
    '        yidengji.ContextMenuStrip = C3
    '        box2.Text = "超时车辆"

    '    End If

    '    '------------------------------------------------------------------------------------------
    '    If TreeView2.SelectedNode.Text = "--退回车辆" Then
    '        objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 已退回=1 and 油脂=1 order by 进厂时间"
    '        If objconnection.State = ConnectionState.Closed Then
    '            objconnection.Open()
    '        End If
    '        objdataset = New DataSet
    '        objdataadapter.Fill(objdataset, "tuihui")

    '        objdataview = New DataView(objdataset.Tables("tuihui"))

    '        yidengji.DataSource = objdataview
    '        yidengji.ContextMenuStrip = Nothing
    '        box2.Text = "退回车辆"

    '    End If

    '    '-------------------------------------------------------------------------------------------



    '    yidengji.Columns(0).Width = 0
    '    objconnection.Close()
    'End Sub


    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        'Try
        If (Len(IDID.Text) > 0) Then

            Dim objcommandpassword As New SqlClient.SqlCommand
            objcommandpassword.Connection = objconnection
            objcommandpassword.CommandText = "update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=1,进厂时间=@进厂时间" & " where id=" & Val(IDID.Text)
            objcommandpassword.Parameters.AddWithValue("@进厂时间", sendsomething.getDateTime())

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommandpassword.ExecuteNonQuery()
            objconnection.Close()
            MessageBox.Show("油脂货物车辆设置完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<进厂装货提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "可进厂装货!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

            showall()
            clearall()
        Else
            MessageBox.Show("没有可操作记录", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        ' Catch ex As Exception
        'MessageBox.Show(ex.Message)
        '  End Try
    End Sub

    
    Private Sub TreeView3_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView3.AfterSelect
        Tree_No = 3
    End Sub

   
  
   

    Private Sub TreeView2_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView2.AfterSelect
        Tree_No = 2
        TreeView1.SelectedNode = Nothing
        On Error Resume Next
        If TreeView2.SelectedNode.Text = "已登记车辆" Then
            Dim objcommandpassword As New SqlClient.SqlCommand
            objcommandpassword.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  油脂=1  and 已登记=1 order by 登记时间"

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "kedengji")

            objdataview = New DataView(objdataset.Tables("kedengji"))
            yidengji.ContextMenuStrip = Oil
            yidengji.DataSource = objdataview
            box2.Text = "已登记油脂类车辆"
        End If


        '----------------------------------------------------------------------------------


        '-------------------------------------------------------------------
        If TreeView2.SelectedNode.Text = "可进厂车辆" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 可进厂=1 and 油脂=1 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "kejinchang")

            objdataview = New DataView(objdataset.Tables("kejinchang"))

            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = C3
            box2.Text = "可进厂车辆"
        End If
        '-----------------------------------------------------------------------------------------
        If TreeView2.SelectedNode.Text = "已完成车辆" Then

            objdataadapter.SelectCommand.CommandText = "select top 100 * from TRUCK_QUEUE_BAK where 已完成=1 and 油脂=1 order by 完成时间 desc"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "yiwancheng2")

            objdataview = New DataView(objdataset.Tables("yiwancheng2"))
            yidengji.ContextMenuStrip = Nothing
            yidengji.DataSource = objdataview
            box2.Text = "已完成车辆"

        End If
        '---------------------------------------------------------------------------------------
        If TreeView2.SelectedNode.Text = "--超时车辆" Then
            objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 可进厂=1 and  datediff(n,进厂时间,getdate())>120 and 油脂=1 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "chaoshi")

            objdataview = New DataView(objdataset.Tables("chaoshi"))

            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = C3
            box2.Text = "超时车辆"

        End If

        '------------------------------------------------------------------------------------------
        If TreeView2.SelectedNode.Text = "--退回车辆" Then
            objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 已退回=1 and 油脂=1 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "tuihui")

            objdataview = New DataView(objdataset.Tables("tuihui"))

            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = Nothing
            box2.Text = "退回车辆"

        End If

        '-------------------------------------------------------------------------------------------



        yidengji.Columns(0).Width = 0
        objconnection.Close()
    End Sub

  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim flag_park As String

        flag_park = VehicleinPark.VehicleInPark("VehicleInPark_yhwebs", Trim(chehao.Text))
        If flag_park = 1 Then
            MessageBox.Show("当前车辆正位于停车场", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("当前车辆已离开停车场", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If




    End Sub
End Class