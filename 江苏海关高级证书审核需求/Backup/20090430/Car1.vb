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

                ClearTextBox(ctl.Controls) '�ݹ����

            End If

        Next

        For Each ctl As Control In cc

            If TypeOf ctl Is ComboBox Then

                CType(ctl, ComboBox).Text = String.Empty

            ElseIf ctl.Controls.Count > 0 Then

                ClearTextBox(ctl.Controls) '�ݹ����

            End If

        Next

    End Sub

    Public Sub clearbindtextbox(ByVal cc As Control.ControlCollection)

        For Each ctl As Control In cc

            If TypeOf ctl Is TextBox Then

                ctl.DataBindings.Clear()

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '�ݹ�������textbox��

            End If

        Next

        For Each ctl As Control In cc

            If TypeOf ctl Is ComboBox Then

                ctl.DataBindings.Clear()

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '�ݹ�������combobox��

            End If

        Next

        For Each ctl As Control In cc

            If TypeOf ctl Is MaskedTextBox Then

                ctl.DataBindings.Clear()

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '�ݹ�������combobox��

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
        objdataadapter.SelectCommand.CommandText = "select * from car_now where �ܼ� = '" & zhouji.Text & "'"


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


            clearbindtextbox(Me.Controls) '�������������textbox��combobox�İ�




            '----------------------------------------------------------------------------------------------

            chehao.DataBindings.Add("text", objdataview, "����")
            siji.DataBindings.Add("text", objdataview, "˾��")
            dianhua.DataBindings.Add("text", objdataview, "�绰")
            chexing.DataBindings.Add("text", objdataview, "����")

            renwumiaoshu.DataBindings.Add("text", objdataview, "��������")
            beizhu.DataBindings.Add("text", objdataview, "��ע")
            zhuangtai.DataBindings.Add("text", objdataview, "״̬")
            chekuang.DataBindings.Add("text", objdataview, "����")

            facheshijian.DataBindings.Add("text", objdataview, "�ƻ�����ʱ��")
            fanhuishijian.DataBindings.Add("text", objdataview, "�ƻ�����ʱ��")
            idtextbox.DataBindings.Add("text", objdataview, "id")



        End If



    End Sub

    Private Sub addtxt()
        Dim sr As IO.StreamReader
        sr = New System.IO.StreamReader(Application.StartupPath & "\����.txt", True)
        chehao.Items.Clear()
        Do While sr.Peek > 0
            chehao.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\˾��.txt", True)
        siji.Items.Clear()
        Do While sr.Peek > 0
            siji.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing


        sr = New System.IO.StreamReader(Application.StartupPath & "\����.txt", True)
        chexing.Items.Clear()
        Do While sr.Peek > 0
            chexing.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\�绰.txt", True)
        dianhua.Items.Clear()
        Do While sr.Peek > 0
            dianhua.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\״̬.txt", True)
        zhuangtai.Items.Clear()
        Do While sr.Peek > 0
            zhuangtai.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\����.txt", True)
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
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\����.txt", True)
                xr.WriteLine(chehao.Text)
                xr.Flush()
                xr.Close()
            End If
        End If


        If siji.Text.Length > 0 Then
            If siji.FindString(siji.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\˾��.txt", True)
                xr.WriteLine(siji.Text)
                xr.Flush()
                xr.Close()
            End If
        End If


        If chexing.Text.Length > 0 Then
            If chexing.FindString(chexing.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\����.txt", True)
                xr.WriteLine(chexing.Text)
                xr.Flush()
                xr.Close()
            End If
        End If



        If dianhua.Text.Length > 0 Then
            If dianhua.FindString(dianhua.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\�绰.txt", True)
                xr.WriteLine(dianhua.Text)
                xr.Flush()
                xr.Close()
            End If
        End If



        If zhuangtai.Text.Length > 0 Then
            If zhuangtai.FindString(zhuangtai.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\״̬.txt", True)
                xr.WriteLine(zhuangtai.Text)
                xr.Flush()
                xr.Close()
            End If
        End If



        If chekuang.Text.Length > 0 Then
            If chekuang.FindString(chekuang.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\����.txt", True)
                xr.WriteLine(chekuang.Text)
                xr.Flush()
                xr.Close()
            End If
        End If

    End Sub


    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub �༭ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �༭ToolStripMenuItem.Click

        If Len(idtextbox.Text) = 0 Then

            MessageBox.Show("�����ݿ��޸�!", "��ʾ", MessageBoxButtons.OK)
        Else
            fache.Enabled = True
            save.Enabled = True
            clearbindtextbox(Me.Controls)

        End If

    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If Len(idtextbox.Text) > 0 Then
            If (MessageBox.Show("��ȷ��Ҫ����˱ʼ�¼?(Y/N)", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK) Then


                ' Try


                Dim objcommand As New SqlCommand

                objcommand.Connection = objconnection
                objcommand.CommandText = "update car_now set �ܼ�=@�ܼ�,��������=@��������,�ƻ�����ʱ��=@�ƻ�����ʱ��,�ƻ�����ʱ��=@�ƻ�����ʱ��,״̬=@״̬,����=@����,��������=@��������,��ע=@��ע where id =" & Val(idtextbox.Text)

                dgv.Enabled = True
                Dim hm As New Date
                hm = DT1.Value
                hm.ToString("yyyy/MM/dd")


                objcommand.Parameters.AddWithValue("@��������", hm.Date)

                objcommand.Parameters.AddWithValue("@�ƻ�����ʱ��", Trim(facheshijian.Text))

                objcommand.Parameters.AddWithValue("@�ƻ�����ʱ��", Trim(fanhuishijian.Text))

                objcommand.Parameters.AddWithValue("@״̬", Trim(zhuangtai.Text))

                objcommand.Parameters.AddWithValue("@�ܼ�", Trim(zhouji.Text))



                objcommand.Parameters.AddWithValue("@����", Trim(chekuang.Text))

                objcommand.Parameters.AddWithValue("@��������", Trim(renwumiaoshu.Text))




                objcommand.Parameters.AddWithValue("@��ע", Val(beizhu.Text))



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
                MessageBox.Show("�ѱ��浫δ��Ϊ�����¼����浽���ݿ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                savetxt()

            End If
        End If



    End Sub

    Private Sub fache_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fache.Click
        If Len(idtextbox.Text) > 0 Then
            If (MessageBox.Show("��ȷ��Ҫ����˱ʼ�¼?(Y/N)", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK) Then


                ' Try


                Dim objcommand As New SqlCommand

                objcommand.Connection = objconnection
                objcommand.CommandText = "update car_now set �ܼ�=@�ܼ�,��������=@��������,�ƻ�����ʱ��=@�ƻ�����ʱ��,�ƻ�����ʱ��=@�ƻ�����ʱ��,״̬=@״̬,����=@����,��������=@��������,��ע=@��ע where id =" & Val(idtextbox.Text)

                dgv.Enabled = True
                Dim hm As New Date
                hm = DT1.Value
                hm.ToString("yyyy/MM/dd")


                objcommand.Parameters.AddWithValue("@��������", hm.Date)

                objcommand.Parameters.AddWithValue("@�ƻ�����ʱ��", Trim(facheshijian.Text))

                objcommand.Parameters.AddWithValue("@�ƻ�����ʱ��", Trim(fanhuishijian.Text))

                objcommand.Parameters.AddWithValue("@״̬", Trim(zhuangtai.Text))

                objcommand.Parameters.AddWithValue("@�ܼ�", Trim(zhouji.Text))



                objcommand.Parameters.AddWithValue("@����", Trim(chekuang.Text))

                objcommand.Parameters.AddWithValue("@��������", Trim(renwumiaoshu.Text))




                objcommand.Parameters.AddWithValue("@��ע", Val(beizhu.Text))



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
        objcommand1.CommandText = "insert into car_Events (�ܼ�,����,˾��,����,�绰,��������,�ƻ�����ʱ��,�ƻ�����ʱ��,״̬,����,��������,��ע)values(@�ܼ�,@����,@˾��,@����,@�绰,@��������,@�ƻ�����ʱ��,@�ƻ�����ʱ��,@״̬,@����,@��������,@��ע)"


        dgv.Enabled = True
        Dim hm1 As New Date
        hm1 = DT1.Value
        hm1.ToString("yyyy/MM/dd")


        objcommand1.Parameters.AddWithValue("@��������", hm1.Date)

        objcommand1.Parameters.AddWithValue("@�ƻ�����ʱ��", Trim(facheshijian.Text))

        objcommand1.Parameters.AddWithValue("@�ƻ�����ʱ��", Trim(fanhuishijian.Text))

        objcommand1.Parameters.AddWithValue("@״̬", Trim(zhuangtai.Text))


        objcommand1.Parameters.AddWithValue("@�ܼ�", Trim(zhouji.Text))

        objcommand1.Parameters.AddWithValue("@����", Trim(chehao.Text))

        objcommand1.Parameters.AddWithValue("@˾��", Trim(siji.Text))

        objcommand1.Parameters.AddWithValue("@����", Trim(chexing.Text))

        objcommand1.Parameters.AddWithValue("@�绰", Trim(dianhua.Text))




        objcommand1.Parameters.AddWithValue("@����", Trim(chekuang.Text))

        objcommand1.Parameters.AddWithValue("@��������", Trim(renwumiaoshu.Text))




        objcommand1.Parameters.AddWithValue("@��ע", Val(beizhu.Text))



        If (objconnection.State = ConnectionState.Closed) Then
            objconnection.Open()
        End If


        objcommand1.ExecuteNonQuery()

        objconnection.Close()

        MessageBox.Show("�ѱ��沢����Ϊ�����¼����浽���ݿ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub �˳�ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �˳�ToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class