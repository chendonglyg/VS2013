Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class Calculate_B
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Dim jieguo As Single


    Private Sub GQPD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.MdiParent = MDIMain

        jpry.Text = username
        pdry.Text = username
        pdsj.Text = Now

        ''addcombobox() 此处不需要导入任务了，改用全部罐号
        'yp.AutoCompleteMode = AutoCompleteMode.Suggest
        ' yp.AutoCompleteSource = AutoCompleteSource.ListItems

        ygbh.AutoCompleteMode = AutoCompleteMode.Suggest
        ygbh.AutoCompleteSource = AutoCompleteSource.ListItems

        'MessageBox.Show(FormatDateTime(pdsj.Text, DateFormat.ShortDate))

        LoadForYGBHCombo()

    End Sub
    Private Sub LoadForYGBHCombo()


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct(罐号名称) from TZ_InventoryWork where (len(罐号名称)>0) "




        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "TZ_InventoryWork")

        objdataview = New DataView(objdataset.Tables("TZ_InventoryWork"))

        ' MessageBox.Show(objdataview.Count)
        ygbh.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                ygbh.Items.Add(objdataview.Item(a).Item("罐号名称"))


            Next
        End If
    End Sub
    

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()

        '  ' http://218.92.115.4:20822/Service1.asmx
    End Sub

    Private Sub yp_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles yp.SelectedIndexChanged
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料号 from wlbm where ltrim(rtrim(物料描述)) = '" & Trim(yp.Text) & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "yp")
        objdataview = New DataView(objdataset.Tables("yp"))
        wlbm.Items.Clear()
        If objdataview.Count >= 1 Then
            wlbm.Text = objdataview.Item(0).Item("物料号")
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim MyService As New webservicesinNotebook.TZGO_CalculateMenuSoapClient

        Try
            Dim objcommand As New SqlCommand

            Dim PJWD As Single

            objcommand.Connection = objconnection
            objcommand.CommandText = "update TZ_InventoryData set 删除标志=1 where 油罐编号 = '" & Trim(ygbh.Text) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objcommand.ExecuteNonQuery()
            Dim WDXS As Single  '温度系数计算前置




            If QME.CheckState = CheckState.Checked Then
                PJWD = (7 * Val(YW.Text) + Val(QW.Text)) / 8
                WDXS = 1 + (PJWD - 20) * 0.000024            'PJWD原先是Val（YW.Text）
            Else
                PJWD = Val(YW.Text)
                WDXS = 1 + (PJWD - 20) * 0.000036           'PJWD原先是Val（YW.Text）
            End If


            Dim guancunjieguo As Single
            guancunjieguo = MyService.Calculate(Trim(yp.Text), Trim(wlbm.Text), Trim(username), Trim(ssgq.Text), Trim(bzxx.Text), Trim(ygbh.Text), Val(gd.Text), Val(YW.Text), Val(QW.Text), Val(bzmd.Text), Val(bzwd.Text), Val(bhxs.Text), WDXS) 'PJWD改成Val(YW.Text)

            MessageBox.Show("计算结果为:" & Math.Round(guancunjieguo / 1000, 3) & "吨", "计算完成提示！", MessageBoxButtons.OK, MessageBoxIcon.Information)

            MessageBox.Show("盘点数据已正确提交主数据库!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gd.Text = ""
        yw.Text = ""
        qw.Text = ""
        bzxx.Text = ""

    End Sub



    Private Sub ygbh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ygbh.SelectedIndexChanged
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料编码,油品名称,标准密度,标准温度 from TZ_InventoryWork where ltrim(rtrim(罐号名称)) = '" & Trim(ygbh.Text) & "'"

        On Error Resume Next

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "Density")
        objdataview = New DataView(objdataset.Tables("Density"))
        yp.Items.Clear()

        ' MessageBox.Show(objdataview.Count)
        If objdataview.Count >= 1 Then
            yp.Text = objdataview.Item(0).Item("油品名称")
            bzmd.Text = objdataview.Item(0).Item("标准密度")
            bzwd.Text = objdataview.Item(0).Item("标准温度")
            wlbm.Text = objdataview.Item(0).Item("物料编码")
        End If

        '-------------------------------------以下是密度严格从TZ_InventoryDensity读取， 其他信息从TZ_InventoryWork读取
        '
        'objdataadapter.SelectCommand = New SqlCommand
        'objdataadapter.SelectCommand.Connection = objconnection
        'objdataadapter.SelectCommand.CommandText = "select 物料编码,油品名称 from midu where rtrim(ltrim(罐号名称))='" & Trim(ygbh.Text) & "'"



        'If objconnection.State = ConnectionState.Closed Then
        '    objconnection.Open()
        'End If
        'objdataset = New DataSet
        'objdataadapter.Fill(objdataset, "ypmd")

        'objdataview = New DataView(objdataset.Tables("ypmd"))




        '' MessageBox.Show(objdataview.Count)
        'If objdataview.Count >= 1 Then

        '    yp.Text = objdataview.Item(0).Item("油品名称")
        '    wlbm.Text = objdataview.Item(0).Item("物料编码")
        'End If


        'objdataadapter.SelectCommand = New SqlCommand
        'objdataadapter.SelectCommand.Connection = objconnection
        'objdataadapter.SelectCommand.CommandText = "select 标准密度 from midu_wuliaobianma where rtrim(ltrim(物料编码))='" & Trim(wlbm.Text) & "'"



        'If objconnection.State = ConnectionState.Closed Then
        '    objconnection.Open()
        'End If
        'objdataset = New DataSet
        'objdataadapter.Fill(objdataset, "mi")

        'objdataview = New DataView(objdataset.Tables("mi"))




        '' MessageBox.Show(objdataview.Count)
        'If objdataview.Count >= 1 Then

        '    bzmd.Text = objdataview.Item(0).Item("标准密度")

        'End If


    End Sub




    Private Sub QME_CheckedChanged(sender As Object, e As EventArgs) Handles QME.CheckedChanged
        If QME.CheckState = CheckState.Checked Then
            qw.Enabled = True
        Else
            qw.Enabled = False
        End If

        QW.Text = ""
    End Sub

   
  
End Class
