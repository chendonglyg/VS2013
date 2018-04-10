Public Class wuliu

    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    '---------------------------------------------------------------------
    Dim getsomething As New lygport_outside.Service1SoapClient
    Dim crytogram, vehicle, externo As String
    Dim veh_return, in_date, stre, stre_2, stre_3, phone_no As String
    Dim picture1, picture2 As Byte()
    Dim img As Image
    Private Sub jichuxinxi_Enter(sender As Object, e As EventArgs) Handles jichuxinxi.Enter

    End Sub

   

    'Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
    '    If TreeView1.SelectedNode.Text = "可登记" Then
    '        objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 可登记=1 order by 推送时间 "
    '        If objconnection.State = ConnectionState.Closed Then
    '            objconnection.Open()
    '        End If
    '        objdataset = New DataSet
    '        objdataadapter.Fill(objdataset, "kedengji")

    '        objdataview = New DataView(objdataset.Tables("kedengji"))

    '        kedengji.DataSource = objdataview
    '        Box2.Text = "可登记数据"
    '    End If
    '    '----------------------------------------------------------
    '    If TreeView1.SelectedNode.Text = "已登记" Then
    '        objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 已登记=1 order by 登记时间"
    '        If objconnection.State = ConnectionState.Closed Then
    '            objconnection.Open()
    '        End If
    '        objdataset = New DataSet
    '        objdataadapter.Fill(objdataset, "yidengji")

    '        objdataview = New DataView(objdataset.Tables("yidengji"))

    '        kedengji.DataSource = objdataview
    '        Box2.Text = "已登记数据"
    '    End If
    '    '----------------------------------------------------------
    '    If TreeView1.SelectedNode.Text = "可进厂" Then
    '        objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 可进厂=1 order by 进厂时间"
    '        If objconnection.State = ConnectionState.Closed Then
    '            objconnection.Open()
    '        End If
    '        objdataset = New DataSet
    '        objdataadapter.Fill(objdataset, "kejinchang")

    '        objdataview = New DataView(objdataset.Tables("kejinchang"))

    '        kedengji.DataSource = objdataview
    '        Box2.Text = "可进厂数据"
    '    End If
    '    '--------------------------------------------------------------
    '    If TreeView1.SelectedNode.Text = "已完成" Then
    '        objdataadapter.SelectCommand.CommandText = "select top 100 * from TRUCK_QUEUE_BAK where 已完成=1 order by 完成时间 desc"
    '        If objconnection.State = ConnectionState.Closed Then
    '            objconnection.Open()
    '        End If
    '        objdataset = New DataSet
    '        objdataadapter.Fill(objdataset, "yiwancheng")

    '        objdataview = New DataView(objdataset.Tables("yiwancheng"))

    '        kedengji.DataSource = objdataview
    '        Box2.Text = "已完成数据"
    '    End If
    '    '-----------------------------------------------------------------------------------------------------
    '    If TreeView1.SelectedNode.Text = "--超时车辆" Then
    '        objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 可进厂=1 and  datediff(n,进厂时间,getdate())>120 order by 进厂时间"
    '        If objconnection.State = ConnectionState.Closed Then
    '            objconnection.Open()
    '        End If
    '        objdataset = New DataSet
    '        objdataadapter.Fill(objdataset, "chaoshi")

    '        objdataview = New DataView(objdataset.Tables("chaoshi"))

    '        kedengji.DataSource = objdataview

    '        Box2.Text = "超时车辆"

    '    End If
    '    '------------------------------------------------------------------------------------------
    '    If TreeView1.SelectedNode.Text = "--退回车辆" Then
    '        objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 已退回=1 order by 进厂时间"
    '        If objconnection.State = ConnectionState.Closed Then
    '            objconnection.Open()
    '        End If
    '        objdataset = New DataSet
    '        objdataadapter.Fill(objdataset, "tuihui")

    '        objdataview = New DataView(objdataset.Tables("tuihui"))

    '        kedengji.DataSource = objdataview
    '        kedengji.ContextMenuStrip = Nothing
    '        Box2.Text = "退回车辆"

    '    End If

    '    '-------------------------------------------------------------------------------------------
    '    On Error Resume Next

    '    kedengji.Columns(0).Width = 0
    '    objconnection.Close()
    'End Sub
    '之前的仪表显示暂时不用

    Private Sub Box2_Enter(sender As Object, e As EventArgs) Handles Box2.Enter

    End Sub

    Private Sub kedengji_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles yidengji.CellContentClick
        ' On Error Resume Next
        Dim p As New Net.NetworkInformation.Ping


        'pr = p.Send(ipipip)

        'If pr.Status = Net.NetworkInformation.IPStatus.Success Then


        kehumingcheng.Text = Trim(yidengji.Rows(e.RowIndex).Cells(1).Value)
        IDID.Text = Trim(yidengji.Rows(e.RowIndex).Cells(0).Value)

        pinming.Text = Trim(yidengji.Rows(e.RowIndex).Cells(2).Value)
        tidanhao.Text = Trim(yidengji.Rows(e.RowIndex).Cells(3).Value)
        shuliang.Text = Trim(yidengji.Rows(e.RowIndex).Cells(5).Value)
        chehao.Text = Trim(yidengji.Rows(e.RowIndex).Cells(6).Value)
        dianhuahaoma.Text = Trim(yidengji.Rows(e.RowIndex).Cells(7).Value)

        beizhu.Text = yidengji.Rows(e.RowIndex).Cells(17).Value

        getinrecord(chehao.Text)
        If stre = "success" Then


        Else

            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing
        End If


        'Else
        '    MessageBox.Show("至" & ipipip & "港方数据库不能正常连接，请检查VPN线路！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
    End Sub

    Private Sub D_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection


        yidengji.AllowUserToAddRows = False '消除最后一行
    End Sub
    
    Private Function getinrecord(forvehicle As String)
        '获取车辆进场信息
        ' On Error Resume Next
        'Try


        crytogram = "saduiugdsiu#$W*s_yh"


        externo = ""
        veh_return = getsomething.GetInRecord(crytogram, forvehicle, externo, in_date, picture1, picture2, stre, phone_no)


        If stre = "success" Then

            img = Image.FromStream(New System.IO.MemoryStream(picture1))
            PictureBox1.Image = img
            img = Image.FromStream(New System.IO.MemoryStream(picture2))
            PictureBox2.Image = img
        End If




        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try


        '  stre = "success" '全放行，慎用

        Return stre
    End Function

    Private Function InsertConsignVehicle()
        '车辆申报


        Dim insertsomething As New lygport_outside.Service1SoapClient

        If Color.Checked = True Then
            chehao.BackColor = Drawing.Color.Blue
            vehicle = Trim(chehao.Text) & "蓝"
        Else
            chehao.BackColor = Drawing.Color.Yellow
            vehicle = Trim(chehao.Text)
        End If



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
        If Color.Checked = True Then
            chehao.BackColor = Drawing.Color.Blue
            vehicle = Trim(chehao.Text) & "蓝"
        Else
            chehao.BackColor = Drawing.Color.Yellow
            vehicle = Trim(chehao.Text)
        End If
        '车辆放行
        Dim updatesomething As New lygport_outside.Service1SoapClient
        stre_3 = updatesomething.UpdateConsignVehicle("ygygdn%hjiu**W*update_yh", vehicle)

        If stre_3 = "success" Then
            MessageBox.Show("通行证已开始启用，请到隔壁进行绑定后方可入港！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(stre_3, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return stre_3
    End Function

    
    Private Sub chaxun_KeyDown(sender As Object, e As KeyEventArgs) Handles chaxun.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then

            If TreeView1.SelectedNode.Text = "可登记" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 粕类=1 and 可登记=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "xiehuo")

                objdataview = New DataView(objdataset.Tables("xiehuo"))
                yidengji.DataSource = objdataview

                Box2.Text = "可登记车辆"
            End If

            '------------------------------------------------

            If TreeView1.SelectedNode.Text = "已登记卸货车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  粕类=1 and 是否卸车=1 and 已登记=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "xiehuo")

                objdataview = New DataView(objdataset.Tables("xiehuo"))
                yidengji.DataSource = objdataview

                Box2.Text = "已登记卸货车辆"
            End If

            '-----------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "已登记43%粕车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where   自派车 <>1 and 已登记=1 and ltrim(rtrim(货物名称))='丰苑豆粕 43(50 KG)' and 车号 like '%" & Trim(chaxun.Text) & "%'"

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "kedengji")

                objdataview = New DataView(objdataset.Tables("kedengji"))

                yidengji.DataSource = objdataview
                Box2.Text = "已登记43%粕车辆"
            End If
            '----------------------------------------------------------

            '--------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "散货车辆46%" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where (客户物料号='豆粕-饲料类46（散粕)' or 客户物料号='豆粕-饲料类46（吨袋)' ) and 已登记=1  and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "sanhuo")

                objdataview = New DataView(objdataset.Tables("sanhuo"))


                yidengji.DataSource = objdataview

                Box2.Text = "散货车辆46%"
            End If
            ''-------------------------------------丰苑低纤维豆粕47（散粕）
            If TreeView1.SelectedNode.Text = "散货车辆47%" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where (客户物料号='丰苑低纤维豆粕47（散粕)' or 客户物料号='丰苑低纤维豆粕47（吨袋)' ) and 已登记=1  and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "sanhuo")

                objdataview = New DataView(objdataset.Tables("sanhuo"))


                yidengji.DataSource = objdataview

                Box2.Text = "散货车辆47%"
            End If

            '---------------------------------------------------------------------------------------------------------------------


            If TreeView1.SelectedNode.Text = "已登记其他车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where   自派车 <>1 and 已登记=1 and ltrim(rtrim(货物名称))<>'丰苑豆粕 43(50 KG)' and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yidengji")

                objdataview = New DataView(objdataset.Tables("yidengji"))

                yidengji.DataSource = objdataview
                Box2.Text = "已登记其他车辆"
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
                Box2.Text = "自派的车辆"
            End If
            '--------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "可进厂车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  粕类=1 and 可进厂=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yiwancheng")

                objdataview = New DataView(objdataset.Tables("yiwancheng"))

                yidengji.DataSource = objdataview
                Box2.Text = "可进厂车辆"
            End If
            '-----------------------------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "已完成车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE_BAK where  粕类=1 and 已完成=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "chaoshi")

                objdataview = New DataView(objdataset.Tables("chaoshi"))

                yidengji.DataSource = objdataview

                Box2.Text = "已完成车辆"

            End If
            '------------------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "--超时车辆" Then
                objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where  粕类=1 and 可进厂=1 and  datediff(n,进厂时间,getdate())>120 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "tuihui")

                objdataview = New DataView(objdataset.Tables("tuihui"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = Nothing
                Box2.Text = "超时车辆"

            End If




            '-------------------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "--退回车辆" Then
                objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 粕类=1 and 已退回=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "tuihui")

                objdataview = New DataView(objdataset.Tables("tuihui"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = Nothing
                Box2.Text = "退回车辆"

            End If

            yidengji.Columns(0).Width = 0
            objconnection.Close()

        End If




        '-------------------------------------------------------------------------------------///////////////////////////////////////////////////////////22222222




    End Sub
   
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

        TreeView2.SelectedNode = Nothing

        If TreeView1.SelectedNode.Text = "可登记" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where   粕类=1 and 可登记=1  order by 推送时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "kedengji")

            objdataview = New DataView(objdataset.Tables("kedengji"))
            yidengji.DataSource = objdataview

            Box2.Text = "可登记"
        End If
        '----------------------------------------------------------------------------------------------------------------------

        If TreeView1.SelectedNode.Text = "已登记卸货车辆" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where   是否卸车=1 and 已登记=1  order by 登记时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "xiehuo")

            objdataview = New DataView(objdataset.Tables("xiehuo"))
            yidengji.DataSource = objdataview

            Box2.Text = "已登记卸货车辆"
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

         
            yidengji.DataSource = objdataview

            Box2.Text = "已登记43%粕车辆"
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

            Box2.Text = "已登记其他车辆"

        End If
        '-------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "散货车辆" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where len(客户物料号)>1 and 已登记=1  order by 登记时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "sanhuo")

            objdataview = New DataView(objdataset.Tables("sanhuo"))

         

            yidengji.DataSource = objdataview

            Box2.Text = "散货车辆"
        End If
        '-------------------------------------
        If TreeView1.SelectedNode.Text = "自派的车辆" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  粕类=1 and 自派车=1 and 已登记=1  order by 登记时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "yidengji")

            objdataview = New DataView(objdataset.Tables("yidengji"))

            yidengji.DataSource = objdataview

            Box2.Text = "自派的车辆"
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

            Box2.Text = "可进厂车辆"
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
            Box2.Text = "已完成车辆"

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

            Box2.Text = "超时车辆"

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
            Box2.Text = "退回车辆"

        End If

        '-------------------------------------------------------------------------------------------
        On Error Resume Next


        yidengji.Columns(0).Width = 0
        objconnection.Close()
    End Sub

    Private Sub TreeView2_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView2.AfterSelect
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

            yidengji.DataSource = objdataview
            Box2.Text = "已登记油脂类车辆"
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

            Box2.Text = "可进厂车辆"
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
            Box2.Text = "已完成车辆"

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

            Box2.Text = "超时车辆"

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
            Box2.Text = "退回车辆"

        End If

        '-------------------------------------------------------------------------------------------



        yidengji.Columns(0).Width = 0
        objconnection.Close()
    End Sub

 
End Class