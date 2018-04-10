Imports System.Data.SqlClient
Imports System.Data
Public Class Car1
    Dim sr As New Integer
    Dim srf As New Integer

    Dim forreport As New SqlDataAdapter

    Dim objconnection As New SqlConnection("Data Source= lyg.yihai.com;Initial Catalog = package;User ID=sa; Password=chen dong")


   


    Public afterdel As String

    Dim objdataadapter As New SqlDataAdapter
    Dim olda, oldb As Integer

    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub ClearTextBox(ByVal cc As Control.ControlCollection)

        For Each ctl As Control In cc

            If TypeOf ctl Is TextBox Then

                CType(ctl, TextBox).Text = String.Empty

            ElseIf ctl.Controls.Count > 0 Then

                ClearTextBox(ctl.Controls) '递归调用

            End If

        Next

        For Each ctl As Control In cc

            If TypeOf ctl Is ComboBox Then

                CType(ctl, ComboBox).Text = String.Empty

            ElseIf ctl.Controls.Count > 0 Then

                ClearTextBox(ctl.Controls) '递归调用

            End If

        Next

    End Sub

    Public Sub clearbindtextbox(ByVal cc As Control.ControlCollection)

        For Each ctl As Control In cc

            If TypeOf ctl Is TextBox Then

                ctl.DataBindings.Clear()

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '递归调用清除textbox绑定

            End If

        Next

        For Each ctl As Control In cc

            If TypeOf ctl Is ComboBox Then

                ctl.DataBindings.Clear()

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '递归调用清楚combobox绑定

            End If

        Next

        For Each ctl As Control In cc

            If TypeOf ctl Is MaskedTextBox Then

                ctl.DataBindings.Clear()

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '递归调用清楚combobox绑定

            End If

        Next



    End Sub

    Private Sub DT1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT1.ValueChanged

        If DT1.Value < Now Then

            DT1.Value = Now

        End If



        If (Weekday(DT1.Value)) <> 1 Then
            zhouji.Text = Weekday(DT1.Value) - 1

        Else
            zhouji.Text = "7"


        End If




        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from car_now where 周几 = '" & zhouji.Text & "'"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "car")

        objdataview = New DataView(objdataset.Tables("car"))
        dgv.DataSource = objdataview

        bindfields()

        fache.Enabled = False
        save.Enabled = False

    End Sub

    Public Sub bindfields()




        If objdataview.Count > 0 Then


            clearbindtextbox(Me.Controls) '解除本界面所有textbox和combobox的绑定




            '----------------------------------------------------------------------------------------------

            chehao.DataBindings.Add("text", objdataview, "车号")
            siji.DataBindings.Add("text", objdataview, "司机")
            dianhua.DataBindings.Add("text", objdataview, "电话")
            chexing.DataBindings.Add("text", objdataview, "车型")

            renwumiaoshu.DataBindings.Add("text", objdataview, "任务描述")
            beizhu.DataBindings.Add("text", objdataview, "备注")
            zhuangtai.DataBindings.Add("text", objdataview, "状态")
            chekuang.DataBindings.Add("text", objdataview, "车况")

            facheshijian.DataBindings.Add("text", objdataview, "计划发车时间")
            fanhuishijian.DataBindings.Add("text", objdataview, "计划返回时间")
            idtextbox.DataBindings.Add("text", objdataview, "id")



        End If



    End Sub

    Private Sub addtxt()
        Dim sr As IO.StreamReader
        sr = New System.IO.StreamReader(Application.StartupPath & "\车号.txt", True)
        chehao.Items.Clear()
        Do While sr.Peek > 0
            chehao.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\司机.txt", True)
        siji.Items.Clear()
        Do While sr.Peek > 0
            siji.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing


        sr = New System.IO.StreamReader(Application.StartupPath & "\车型.txt", True)
        chexing.Items.Clear()
        Do While sr.Peek > 0
            chexing.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\电话.txt", True)
        dianhua.Items.Clear()
        Do While sr.Peek > 0
            dianhua.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\状态.txt", True)
        zhuangtai.Items.Clear()
        Do While sr.Peek > 0
            zhuangtai.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\车况.txt", True)
        chekuang.Items.Clear()
        Do While sr.Peek > 0
            chekuang.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing


    End Sub
    Private Sub savetxt()
        If chehao.Text.Length > 0 Then
            If chehao.FindString(chehao.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\车号.txt", True)
                xr.WriteLine(chehao.Text)
                xr.Flush()
                xr.Close()
            End If
        End If


        If siji.Text.Length > 0 Then
            If siji.FindString(siji.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\司机.txt", True)
                xr.WriteLine(siji.Text)
                xr.Flush()
                xr.Close()
            End If
        End If


        If chexing.Text.Length > 0 Then
            If chexing.FindString(chexing.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\车型.txt", True)
                xr.WriteLine(chexing.Text)
                xr.Flush()
                xr.Close()
            End If
        End If



        If dianhua.Text.Length > 0 Then
            If dianhua.FindString(dianhua.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\电话.txt", True)
                xr.WriteLine(dianhua.Text)
                xr.Flush()
                xr.Close()
            End If
        End If



        If zhuangtai.Text.Length > 0 Then
            If zhuangtai.FindString(zhuangtai.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\状态.txt", True)
                xr.WriteLine(zhuangtai.Text)
                xr.Flush()
                xr.Close()
            End If
        End If



        If chekuang.Text.Length > 0 Then
            If chekuang.FindString(chekuang.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\车况.txt", True)
                xr.WriteLine(chekuang.Text)
                xr.Flush()
                xr.Close()
            End If
        End If

    End Sub


    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub 编辑ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 编辑ToolStripMenuItem.Click

        If Len(idtextbox.Text) = 0 Then

            MessageBox.Show("无数据可修改!", "提示", MessageBoxButtons.OK)
        Else
            fache.Enabled = True
            save.Enabled = True
            clearbindtextbox(Me.Controls)

        End If

    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If Len(idtextbox.Text) > 0 Then
            If (MessageBox.Show("您确定要保存此笔记录?(Y/N)", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK) Then


                ' Try


                Dim objcommand As New SqlCommand

                objcommand.Connection = objconnection
                objcommand.CommandText = "update car_now set 周几=@周几,发车日期=@发车日期,计划发车时间=@计划发车时间,计划返回时间=@计划返回时间,状态=@状态,车况=@车况,任务描述=@任务描述,备注=@备注 where id =" & Val(idtextbox.Text)

                dgv.Enabled = True
                Dim hm As New Date
                hm = DT1.Value
                hm.ToString("yyyy/MM/dd")


                objcommand.Parameters.AddWithValue("@发车日期", hm.Date)

                objcommand.Parameters.AddWithValue("@计划发车时间", Trim(facheshijian.Text))

                objcommand.Parameters.AddWithValue("@计划返回时间", Trim(fanhuishijian.Text))

                objcommand.Parameters.AddWithValue("@状态", Trim(zhuangtai.Text))

                objcommand.Parameters.AddWithValue("@周几", Trim(zhouji.Text))



                objcommand.Parameters.AddWithValue("@车况", Trim(chekuang.Text))

                objcommand.Parameters.AddWithValue("@任务描述", Trim(renwumiaoshu.Text))




                objcommand.Parameters.AddWithValue("@备注", Val(beizhu.Text))



                If (objconnection.State = ConnectionState.Closed) Then
                    objconnection.Open()
                End If


                objcommand.ExecuteNonQuery()

                objconnection.Close()






                objdataadapter.SelectCommand = New SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection
                objdataadapter.SelectCommand.CommandText = "select * from car_now where id =" & Val(idtextbox.Text)
                afterdel = objdataadapter.SelectCommand.CommandText

                If (objconnection.State = ConnectionState.Closed) Then
                    objconnection.Open()
                End If



                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "car")

                objdataview = New DataView(objdataset.Tables("car"))


                bindfields()
                dgv.DataSource = objdataview


                objconnection.Close()
                MessageBox.Show("已保存但未作为发车事件保存到数据库", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                savetxt()

            End If
        End If



    End Sub

    Private Sub fache_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fache.Click
        If Len(idtextbox.Text) > 0 Then
            If (MessageBox.Show("您确定要保存此笔记录?(Y/N)", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK) Then


                ' Try


                Dim objcommand As New SqlCommand

                objcommand.Connection = objconnection
                objcommand.CommandText = "update car_now set 周几=@周几,发车日期=@发车日期,计划发车时间=@计划发车时间,计划返回时间=@计划返回时间,状态=@状态,车况=@车况,任务描述=@任务描述,备注=@备注 where id =" & Val(idtextbox.Text)

                dgv.Enabled = True
                Dim hm As New Date
                hm = DT1.Value
                hm.ToString("yyyy/MM/dd")


                objcommand.Parameters.AddWithValue("@发车日期", hm.Date)

                objcommand.Parameters.AddWithValue("@计划发车时间", Trim(facheshijian.Text))

                objcommand.Parameters.AddWithValue("@计划返回时间", Trim(fanhuishijian.Text))

                objcommand.Parameters.AddWithValue("@状态", Trim(zhuangtai.Text))

                objcommand.Parameters.AddWithValue("@周几", Trim(zhouji.Text))



                objcommand.Parameters.AddWithValue("@车况", Trim(chekuang.Text))

                objcommand.Parameters.AddWithValue("@任务描述", Trim(renwumiaoshu.Text))




                objcommand.Parameters.AddWithValue("@备注", Val(beizhu.Text))



                If (objconnection.State = ConnectionState.Closed) Then
                    objconnection.Open()
                End If


                objcommand.ExecuteNonQuery()

                objconnection.Close()






                objdataadapter.SelectCommand = New SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection
                objdataadapter.SelectCommand.CommandText = "select * from car_now where id =" & Val(idtextbox.Text)
                afterdel = objdataadapter.SelectCommand.CommandText

                If (objconnection.State = ConnectionState.Closed) Then
                    objconnection.Open()
                End If



                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "car")

                objdataview = New DataView(objdataset.Tables("car"))


                bindfields()
                dgv.DataSource = objdataview


                objconnection.Close()


            End If
        End If

        '----------------------------------------------------------------------
        Dim objcommand1 As New SqlCommand

        objcommand1.Connection = objconnection
        objcommand1.CommandText = "insert into car_Events (周几,车号,司机,车型,电话,发车日期,计划发车时间,计划返回时间,状态,车况,任务描述,备注)values(@周几,@车号,@司机,@车型,@电话,@发车日期,@计划发车时间,@计划返回时间,@状态,@车况,@任务描述,@备注)"


        dgv.Enabled = True
        Dim hm1 As New Date
        hm1 = DT1.Value
        hm1.ToString("yyyy/MM/dd")


        objcommand1.Parameters.AddWithValue("@发车日期", hm1.Date)

        objcommand1.Parameters.AddWithValue("@计划发车时间", Trim(facheshijian.Text))

        objcommand1.Parameters.AddWithValue("@计划返回时间", Trim(fanhuishijian.Text))

        objcommand1.Parameters.AddWithValue("@状态", Trim(zhuangtai.Text))


        objcommand1.Parameters.AddWithValue("@周几", Trim(zhouji.Text))

        objcommand1.Parameters.AddWithValue("@车号", Trim(chehao.Text))

        objcommand1.Parameters.AddWithValue("@司机", Trim(siji.Text))

        objcommand1.Parameters.AddWithValue("@车型", Trim(chexing.Text))

        objcommand1.Parameters.AddWithValue("@电话", Trim(dianhua.Text))




        objcommand1.Parameters.AddWithValue("@车况", Trim(chekuang.Text))

        objcommand1.Parameters.AddWithValue("@任务描述", Trim(renwumiaoshu.Text))




        objcommand1.Parameters.AddWithValue("@备注", Val(beizhu.Text))



        If (objconnection.State = ConnectionState.Closed) Then
            objconnection.Open()
        End If


        objcommand1.ExecuteNonQuery()

        objconnection.Close()

        MessageBox.Show("已保存并已作为发车事件保存到数据库", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        savetxt()


    End Sub

    Private Sub Car1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        siji.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        siji.AutoCompleteSource = AutoCompleteSource.ListItems
        chexing.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        chexing.AutoCompleteSource = AutoCompleteSource.ListItems
        dianhua.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        dianhua.AutoCompleteSource = AutoCompleteSource.ListItems
        chehao.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        chehao.AutoCompleteSource = AutoCompleteSource.ListItems


        zhuangtai.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        zhuangtai.AutoCompleteSource = AutoCompleteSource.ListItems
        chekuang.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        chekuang.AutoCompleteSource = AutoCompleteSource.ListItems

    End Sub

    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class