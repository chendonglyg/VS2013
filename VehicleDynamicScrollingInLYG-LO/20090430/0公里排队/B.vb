Public Class PARKING

    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    '---------------------------------------------------------------------
    Dim getsomething As New lygport_outside.Service1SoapClient
    'Dim sendsomething As New sendmessage1710.CTEnterprisesSoapClient
    Dim sendsomething As New sendmessage.CTEnterprisesSoapClient
    Dim crytogram, vehicle, externo As String
    Dim veh_return, in_date, stre, stre_2, stre_3, phone_no As String
    Dim picture1, picture2 As Byte()
    Dim img As Image
    Private Sub showall()
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
        End If
        '-----------------------------------------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "--超时车辆" Then
            objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 可进厂=1 and  datediff(n,进厂时间,getdate())>120 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "chaoshi")

            objdataview = New DataView(objdataset.Tables("chaoshi"))

            kedengji.DataSource = objdataview

            Box2.Text = "超时车辆"

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

        End If

        '-------------------------------------------------------------------------------------------
        On Error Resume Next

        kedengji.Columns(0).Width = 0
        objconnection.Close()
        success.Text = ""
    End Sub

    

    Private Sub kedengji_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles kedengji.CellContentClick
        On Error Resume Next
        Dim p As New Net.NetworkInformation.Ping
        Dim pr As Net.NetworkInformation.PingReply

        'pr = p.Send(ipipip)

        'If pr.Status = Net.NetworkInformation.IPStatus.Success Then

        clearall()

        kehumingcheng.Text = Trim(kedengji.Rows(e.RowIndex).Cells(1).Value)
        IDID.Text = Trim(kedengji.Rows(e.RowIndex).Cells(0).Value)

        pinming.Text = Trim(kedengji.Rows(e.RowIndex).Cells(2).Value)
        tidanhao.Text = Trim(kedengji.Rows(e.RowIndex).Cells(3).Value)
        shuliang.Text = Trim(kedengji.Rows(e.RowIndex).Cells(5).Value)
        chehao.Text = Trim(kedengji.Rows(e.RowIndex).Cells(6).Value)
        vehicle = Trim(chehao.Text)
        dianhuahaoma.Text = Trim(kedengji.Rows(e.RowIndex).Cells(7).Value)

        beizhu.Text = kedengji.Rows(e.RowIndex).Cells(17).Value
        isReserved.Checked = kedengji.Rows(e.RowIndex).Cells(32).Value
        Reservedtime1.Text = kedengji.Rows(e.RowIndex).Cells(33).Value
        Reservedtime2.Text = kedengji.Rows(e.RowIndex).Cells(34).Value

        If TreeView1.SelectedNode.Text = "可登记" Then

            getinrecord(Trim(chehao.Text))

            ' stre = "success"

            If stre = "success" Then

                dengji.Enabled = True
                success.Text = "success"

                If isReserved.CheckState = CheckState.Checked Then
                    dengjiReserverd.Enabled = True
                Else
                    dengjiReserverd.Enabled = False

                End If

            Else
                dengji.Enabled = False
                PictureBox1.Image = Nothing
                PictureBox2.Image = Nothing
                success.Text = "Nothing"
            End If

        End If
        'Else
        'MessageBox.Show("至港方Web Services不能正常连接，请检查VPN线路！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

        '  dengji.Enabled = True
    End Sub



    Private Sub dengji_Click(sender As Object, e As EventArgs) Handles dengji.Click
        Try



            '不在判断是否有VPN即可登记

            If Len(IDID.Text) > 0 Then


                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objcommandpassword.CommandText = "update TRUCK_QUEUE set 可登记=0,已登记=1,登记时间=@登记时间,备注=@备注" & " where id=" & Val(IDID.Text)
                objcommandpassword.Parameters.AddWithValue("@登记时间", sendsomething.getDateTime())
                objcommandpassword.Parameters.AddWithValue("@备注", Trim(beizhu.Text))
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommandpassword.ExecuteNonQuery()
                objconnection.Close()
                MessageBox.Show("登记完成！（如没有选择记录，将不会有任何改变)", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

                '-------------------------------------------------------------------------------以上是登记，以下是报备-----------

                'InsertConsignVehicle()


                ''---------------------------------------------------------------------------------------------------------------------------以上是报备，以下是办理通行证
                'UpdateConsignVehicle()

                '-------------------------------------------------------------------------------------------------------------------------------------------------------------
                dengji.Enabled = False





                success.Text = ""
                showall()
                clearall()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
        End Try
    End Sub

    Private Sub B_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        dengjiReserverd.Enabled = False
        dengji.Enabled = False
        kedengji.AllowUserToAddRows = False '消除最后一行

    End Sub
    Private Sub clearall()
        For Each c As Windows.Forms.Control In Me.jichuxinxi.Controls
            If TypeOf c Is Windows.Forms.ComboBox Then
                c.Text = "请选择"
            ElseIf TypeOf c Is Windows.Forms.TextBox Then
                c.Text = ""
            End If
        Next
        isReserved.Checked = False

    End Sub


    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode.Text = "可登记" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 可登记=1 order by 推送时间 "
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "kedengji")

            objdataview = New DataView(objdataset.Tables("kedengji"))
            kedengji.ContextMenuStrip = Nothing
            kedengji.DataSource = objdataview
            Box2.Text = "可登记数据"
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
            kedengji.ContextMenuStrip = C1
            kedengji.DataSource = objdataview
            Box2.Text = "已登记数据"
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
            kedengji.ContextMenuStrip = Nothing
            kedengji.ContextMenuStrip = C2
            kedengji.DataSource = objdataview
            Box2.Text = "可进厂数据"
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
            kedengji.ContextMenuStrip = Nothing
            kedengji.DataSource = objdataview
            Box2.Text = "已完成数据"
        End If
        '-----------------------------------------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "--超时车辆" Then
            objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 可进厂=1 and  datediff(n,进厂时间,getdate())>120 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "chaoshi")

            objdataview = New DataView(objdataset.Tables("chaoshi"))
            kedengji.ContextMenuStrip = Nothing
            kedengji.DataSource = objdataview

            Box2.Text = "超时车辆"

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

        End If

        '-------------------------------------------------------------------------------------------
        On Error Resume Next

        kedengji.Columns(0).Width = 0
        objconnection.Close()
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        success.Text = ""
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

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles chaxun.KeyDown
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

            End If

            '-------------------------------------------------------------------------------------------

            kedengji.Columns(0).Width = 0
            objconnection.Close()

        End If

    End Sub




    Private Sub 粕可进厂ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnTOA.Click
        Try

            If Len(IDID.Text) >= 0 Then


                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objcommandpassword.CommandText = "update TRUCK_QUEUE set 可登记=1,已登记=0,可进厂=0,登记时间=@登记时间,备注=@备注" & " where id=" & Val(IDID.Text)
                objcommandpassword.Parameters.AddWithValue("@登记时间", Now)
                objcommandpassword.Parameters.AddWithValue("@备注", Trim(beizhu.Text))
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommandpassword.ExecuteNonQuery()
                objconnection.Close()
                MessageBox.Show("请返回可登记栏重新进行登记该车!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                showall()
                clearall()
                '-------------------------------------------------------------------------------以上是登记，以下是报备-----------



                '-------------------------------------------------------------------------------------------------------------------------------------------------------------
                dengji.Enabled = False

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
        End Try
    End Sub




    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        港务局测试一卡通专用.Show()
        港务局测试一卡通专用.chehao.Text = Trim(chehao.Text)
        港务局测试一卡通专用.dianhuahaoma.Text = Trim(dianhuahaoma.Text)
        isOneCardPass = 1


    End Sub

    
    Private Sub dengjiReserverd_Click(sender As Object, e As EventArgs) Handles dengjiReserverd.Click
        Dim timenow As Date


        timenow = sendsomething.getDateTime()

        If timenow > Trim(Reservedtime1.Text) And timenow < Trim(Reservedtime2.Text) Then
            Try



                '不在判断是否有VPN即可登记

                If Len(IDID.Text) > 0 Then


                    Dim objcommandpassword As New SqlClient.SqlCommand
                    objcommandpassword.Connection = objconnection
                    objcommandpassword.CommandText = "update TRUCK_QUEUE set 可登记=0,可进厂=1,登记时间=@登记时间,进厂时间=@进厂时间,备注=@备注" & " where id=" & Val(IDID.Text)
                    objcommandpassword.Parameters.AddWithValue("@登记时间", sendsomething.getDateTime())
                    objcommandpassword.Parameters.AddWithValue("@进厂时间", sendsomething.getDateTime())

                    objcommandpassword.Parameters.AddWithValue("@备注", Trim(beizhu.Text))
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If

                    objcommandpassword.ExecuteNonQuery()
                    objconnection.Close()
                    MessageBox.Show("预约车辆登记完成，可在停车场工作人员配卡后直接进厂装货.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<预约车辆进厂装货提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "可进厂装货!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                    '-------------------------------------------------------------------------------以上是登记，以下是报备-----------

                    'InsertConsignVehicle()


                    ''---------------------------------------------------------------------------------------------------------------------------以上是报备，以下是办理通行证
                    'UpdateConsignVehicle()

                    '-------------------------------------------------------------------------------------------------------------------------------------------------------------
                    dengji.Enabled = False





                    success.Text = ""
                    showall()
                    clearall()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            End Try
        Else
            MessageBox.Show("当前时间不在预约范围，请进入正常排队!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    
   
End Class