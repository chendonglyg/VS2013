Imports System.Data.SqlClient
Imports System.Data

Public Class can_input
    'Dim objconnection As New SqlConnection("server = ;database=package;user id=sa;password=chen dong")
    Dim afterdel As String
    Dim objconnection As New SqlConnection("Data Source= lyg.yihai.com;Initial Catalog = package;User ID=sa; Password=chen dong")
    Dim sr As New Integer
    Dim srf As New Integer
    Dim idid As Integer
    Dim objdataAdapter As New SqlDataAdapter
    Dim objdataset As New DataSet

    Private Sub Can_input_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1
        Dim sr As IO.StreamReader
        youpin.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        youpin.AutoCompleteSource = AutoCompleteSource.ListItems
        chuanming.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        chuanming.AutoCompleteSource = AutoCompleteSource.ListItems
        jinkouhetonghao.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        jinkouhetonghao.AutoCompleteSource = AutoCompleteSource.ListItems
        dianzizhangcehao.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        dianzizhangcehao.AutoCompleteSource = AutoCompleteSource.ListItems




        sr = New System.IO.StreamReader(Application.StartupPath & "\can1.txt", True)
        youpin.Items.Clear()
        Do While sr.Peek > 0
            youpin.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\can2.txt", True)
        chuanming.Items.Clear()
        Do While sr.Peek > 0
            chuanming.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing


        sr = New System.IO.StreamReader(Application.StartupPath & "\can3.txt", True)
        dianzizhangcehao.Items.Clear()
        Do While sr.Peek > 0
            chuanming.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\can4.txt", True)
        jinkouhetonghao.Items.Clear()
        Do While sr.Peek > 0
            jinkouhetonghao.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing


        objdataAdapter.SelectCommand = New SqlCommand
        objdataAdapter.SelectCommand.Connection = objconnection
        objdataAdapter.SelectCommand.CommandText = "select * from can"
        afterdel = objdataAdapter.SelectCommand.CommandText
        objconnection.Open()
        objdataAdapter.Fill(objdataset, "can")
        Dim objdataview As New DataView(objdataset.Tables("can"))

        objdataview.Sort = "id desc"


        dgv.AutoGenerateColumns = True
        dgv.DataSource = objdataview


        Me.lurushijian.Text = Now()
        objconnection.Close()
    End Sub
    Private Sub bindfields()
        guanhao.DataBindings.Clear()
        youpin.DataBindings.Clear()
        chuanming.DataBindings.Clear()
        dianzizhangcehao.DataBindings.Clear()
        jinkouhetonghao.DataBindings.Clear()
        ruguanriqi.DataBindings.Clear()
        ruku.DataBindings.Clear()
        chuku.DataBindings.Clear()
        jinriguancun.DataBindings.Clear()
        dachishu.DataBindings.Clear()
        youwen.DataBindings.Clear()
        lurushijian.DataBindings.Clear()

        zuoriguancun.DataBindings.Clear()

        chuguanriqi.DataBindings.Clear()


        guanhao.DataBindings.Add("text", objdataview, "罐号")
        youpin.DataBindings.Add("text", objdataview, "油品")
        chuanming.DataBindings.Add("text", objdataview, "船名")
        dianzizhangcehao.DataBindings.Add("text", objdataview, "电子账册号")
        jinkouhetonghao.DataBindings.Add("text", objdataview, "进口合同号")
        ruguanriqi.DataBindings.Add("text", objdataview, "入罐日期")

        chuguanriqi.DataBindings.Add("text", objdataview, "出罐日期")


        ruku.DataBindings.Add("text", objdataview, "入库")
        chuku.DataBindings.Add("text", objdataview, "出库")
        jinriguancun.DataBindings.Add("text", objdataview, "今日罐存")
        zuoriguancun.DataBindings.Add("text", objdataview, "昨日罐存")
        dachishu.DataBindings.Add("text", objdataview, "打尺数")
        youwen.DataBindings.Add("text", objdataview, "油温")
        lurushijian.DataBindings.Add("text", objdataview, "录入时间")





    End Sub

    Private Sub ClearTextBox(ByVal cc As Control.ControlCollection)

        For Each ctl As Control In cc

            If TypeOf ctl Is ComboBox Then

                CType(ctl, ComboBox).Text = String.Empty

            ElseIf ctl.Controls.Count > 0 Then

                ClearTextBox(ctl.Controls) '递归调用

            End If

        Next

        For Each ctl As Control In cc

            If TypeOf ctl Is MaskedTextBox Then

                CType(ctl, MaskedTextBox).Text = String.Empty

            ElseIf ctl.Controls.Count > 0 Then

                ClearTextBox(ctl.Controls) '递归调用

            End If

        Next


        For Each ctl As Control In cc

            If TypeOf ctl Is TextBox Then

                CType(ctl, TextBox).Text = String.Empty

            ElseIf ctl.Controls.Count > 0 Then

                ClearTextBox(ctl.Controls) '递归调用

            End If

        Next

    End Sub



 
    Private Sub 保存记录ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If youpin.FindString(youpin.Text) < 0 Then
            Dim xr As New IO.StreamWriter(Application.StartupPath & "\can1.txt", True)
            xr.WriteLine(youpin.Text)
            xr.Flush()
            xr.Close()
        End If


        If chuanming.FindString(chuanming.Text) < 0 Then
            Dim xr As New IO.StreamWriter(Application.StartupPath & " \can2.txt", True)
            xr.WriteLine(chuanming.Text)
            xr.Flush()
            xr.Close()
        End If


        If dianzizhangcehao.FindString(youpin.Text) < 0 Then
            Dim xr As New IO.StreamWriter(Application.StartupPath & "\can3.txt", True)
            xr.WriteLine(dianzizhangcehao.Text)
            xr.Flush()
            xr.Close()
        End If


        If jinkouhetonghao.FindString(chuanming.Text) < 0 Then
            Dim xr As New IO.StreamWriter(Application.StartupPath & " \can4.txt", True)
            xr.WriteLine(jinkouhetonghao.Text)
            xr.Flush()
            xr.Close()
        End If











        Dim sr As New System.IO.StreamReader(Application.StartupPath & "\can1.txt", True)
        youpin.Items.Clear()
        Do While sr.Peek > 0
            youpin.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\can2.txt", True)
        chuanming.Items.Clear()
        Do While sr.Peek > 0
            chuanming.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing


        sr = New System.IO.StreamReader(Application.StartupPath & "\can3.txt", True)
        dianzizhangcehao.Items.Clear()
        Do While sr.Peek > 0
            dianzizhangcehao.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\can4.txt", True)
        jinkouhetonghao.Items.Clear()
        Do While sr.Peek > 0
            jinkouhetonghao.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        Dim hm As New Date
        Dim objcommand As New SqlCommand
        Try
            objcommand.Connection = objconnection
            objcommand.CommandText = "insert into can (出罐日期,罐号,油品,船名,电子账册号,进口合同号,入罐日期,入库,出库,今日罐存,打尺数,油温,录入时间,昨日罐存) values (@出罐日期,@罐号,@油品,@船名,@电子账册号,@进口合同号,@入罐日期,@入库,@出库,@今日罐存,@打尺数,@油温,@录入时间,@昨日罐存) "

            hm = chuguanriqi.Text
            hm.ToString("yyyy/MM/dd")

            objcommand.Parameters.AddWithValue("@出罐日期", hm.Date)
            objcommand.Parameters.AddWithValue("@罐号", guanhao.Text)
            objcommand.Parameters.AddWithValue("@油品", youpin.Text)
            objcommand.Parameters.AddWithValue("@船名", chuanming.Text)
            objcommand.Parameters.AddWithValue("@电子账册号", dianzizhangcehao.Text)
            objcommand.Parameters.AddWithValue("@进口合同号", jinkouhetonghao.Text)

            hm = ruguanriqi.Text
            hm.ToString("yyyy/MM/dd")
            objcommand.Parameters.AddWithValue("@入罐日期", hm.Date)





            objcommand.Parameters.AddWithValue("@入库", Val(ruku.Text))
            objcommand.Parameters.AddWithValue("@出库", Val(chuku.Text))
            objcommand.Parameters.AddWithValue("@今日罐存", Val(jinriguancun.Text))
            objcommand.Parameters.AddWithValue("@昨日罐存", Val(zuoriguancun.Text))
            objcommand.Parameters.AddWithValue("@打尺数", Val(dachishu.Text))
            objcommand.Parameters.AddWithValue("@油温", Val(youwen.Text))




            objcommand.Parameters.AddWithValue("@录入时间", lurushijian.Text)








            objconnection.Open()

            objcommand.ExecuteNonQuery()
            objdataset.Clear()



            objdataAdapter.Fill(objdataset, "trade")
            Dim objdataview As New DataView(objdataset.Tables("trade"))

            objdataview.Sort = "id desc"




            dgv.AutoGenerateColumns = True
            dgv.DataSource = objdataview



            objconnection.Close()
            MessageBox.Show("添加完成", "提示", MessageBoxButtons.OK)

        Catch ex As Exception


            MessageBox.Show(ex.Message)


        End Try
        objconnection.Close()
        lurushijian.Text = Now
        ClearTextBox(GroupBox1.Controls)

    End Sub

    Private Sub guanhao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        On Error Resume Next
        idid = Trim(dgv.Rows(e.RowIndex).Cells(0).Value)
    End Sub

    Private Sub dgv_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        On Error Resume Next
        idid = Trim(dgv.Rows(e.RowIndex).Cells(0).Value)
    End Sub

    Private Sub 删除记录ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles del.Click
        If (MessageBox.Show("您确认要删除ID号为:" & idid & "的主库记录？（Y/N)", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK) Then

            Dim objcommanddel As New SqlCommand
            objcommanddel.Connection = objconnection
            objcommanddel.CommandText = "delete from can where id=" & idid

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommanddel.ExecuteNonQuery()





            objdataAdapter.SelectCommand = New SqlCommand
            objdataAdapter.SelectCommand.Connection = objconnection
            objdataAdapter.SelectCommand.CommandText = afterdel
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataAdapter.Fill(objdataset, "can")
            objdataview = New DataView(objdataset.Tables("can"))
            dgv.DataSource = objdataview
            objconnection.Close()
        End If
    End Sub

    Private Sub 修改记录ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        objdataAdapter.SelectCommand = New SqlCommand
        objdataAdapter.SelectCommand.Connection = objconnection
        objdataAdapter.SelectCommand.CommandText = "select * from can where id=" & idid

        objconnection.Open()
        objdataset = New DataSet
        objdataAdapter.Fill(objdataset, "can")

        objdataview = New DataView(objdataset.Tables("can"))

        objconnection.Close()
        bindfields()



        dgv.DataSource = objdataview

        save.Enabled = False
        edit.Enabled = False
        del.Enabled = False
        update.Enabled = True
    End Sub

    Private Sub update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update.Click
        Try
            Dim hm As New Date
            Dim objcommand As New SqlCommand

            objcommand.Connection = objconnection
            objcommand.CommandText = "update can set  出罐日期=@出罐日期,罐号=@罐号,油品=@油品,船名=@船名,电子账册号=@电子账册号,进口合同号=@进口合同号,入罐日期=@入罐日期,入库=@入库,出库=@出库,今日罐存=@今日罐存,打尺数=@打尺数,油温=@油温,录入时间=@录入时间,昨日罐存=@昨日罐存 where id= " & idid

            hm = chuguanriqi.Text
            hm.ToString("yyyy/MM/dd")

            objcommand.Parameters.AddWithValue("@出罐日期", hm.Date)
            objcommand.Parameters.AddWithValue("@罐号", guanhao.Text)
            objcommand.Parameters.AddWithValue("@油品", youpin.Text)
            objcommand.Parameters.AddWithValue("@船名", chuanming.Text)
            objcommand.Parameters.AddWithValue("@电子账册号", dianzizhangcehao.Text)
            objcommand.Parameters.AddWithValue("@进口合同号", jinkouhetonghao.Text)
            hm = ruguanriqi.Text
            hm.ToString("yyyy/MM/dd")
            objcommand.Parameters.AddWithValue("@入罐日期", hm.Date)
            objcommand.Parameters.AddWithValue("@入库", Val(ruku.Text))
            objcommand.Parameters.AddWithValue("@出库", Val(chuku.Text))
            objcommand.Parameters.AddWithValue("@今日罐存", Val(jinriguancun.Text))
            objcommand.Parameters.AddWithValue("@昨日罐存", Val(zuoriguancun.Text))
            objcommand.Parameters.AddWithValue("@打尺数", Val(dachishu.Text))
            objcommand.Parameters.AddWithValue("@油温", Val(youwen.Text))
            objcommand.Parameters.AddWithValue("@录入时间", lurushijian.Text)
            objconnection.Open()
            objcommand.ExecuteNonQuery()

            save.Enabled = True
            edit.Enabled = True
            del.Enabled = True
            update.Enabled = False

            MessageBox.Show("更新完毕！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            objdataAdapter.SelectCommand = New SqlCommand
            objdataAdapter.SelectCommand.Connection = objconnection
            objdataAdapter.SelectCommand.CommandText = afterdel
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataAdapter.Fill(objdataset, "can")
            objdataview = New DataView(objdataset.Tables("can"))
            dgv.DataSource = objdataview
            objconnection.Close()

        Catch ex As Exception


            MessageBox.Show(ex.Message)
        End Try


    End Sub
End Class