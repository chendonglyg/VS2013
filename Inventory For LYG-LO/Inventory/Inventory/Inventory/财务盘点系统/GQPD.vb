Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class GQPD
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Dim jieguo As Single

    Private Sub GQPD_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        MDIMain.GP.Visible = True

    End Sub
    Private Sub GQPD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain

        jpry.Text = username
        pdry.Text = username
        pdsj.Text = Now

        ''addcombobox() 此处不需要导入任务了，改用全部罐号
        'yp.AutoCompleteMode = AutoCompleteMode.Suggest
        ' yp.AutoCompleteSource = AutoCompleteSource.ListItems

        ygbh.AutoCompleteMode = AutoCompleteMode.Suggest
        ygbh.AutoCompleteSource = AutoCompleteSource.ListItems
      
        'MessageBox.Show(FormatDateTime(pdsj.Text, DateFormat.ShortDate))

        MDIMain.GP.Visible = False

    End Sub
    Private Sub addpinming()


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct(罐号名称) from midu where (len(罐号名称)>0) and (所属罐区='" & ssgq.Text & "')"




        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "mission")

        objdataview = New DataView(objdataset.Tables("mission"))

        ' MessageBox.Show(objdataview.Count)
        ygbh.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                ygbh.Items.Add(objdataview.Item(a).Item("罐号名称"))


            Next
        End If
    End Sub
    Private Sub addcombobox()


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 罐号 from mission where len(密度)>0 and  CONVERT(varchar(12) , 盘点时间, 112 )='" & Now.Date.ToString("yyyyMMdd") & "'"



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "mission")

        objdataview = New DataView(objdataset.Tables("mission"))

        ' MessageBox.Show(objdataview.Count)
        ygbh.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                ygbh.Items.Add(objdataview.Item(a).Item("罐号"))


            Next
        End If



        'objdataadapter.SelectCommand = New SqlCommand
        'objdataadapter.SelectCommand.Connection = objconnection
        'objdataadapter.SelectCommand.CommandText = "select 物料描述 from wlbm "


        'If objconnection.State = ConnectionState.Closed Then
        '    objconnection.Open()
        'End If
        'objdataset = New DataSet
        'objdataadapter.Fill(objdataset, "yp")

        'objdataview = New DataView(objdataset.Tables("yp"))


        'yp.Items.Clear()
        ''On Error Resume Next
        'If objdataview.Count >= 1 Then
        '    For a = 0 To objdataview.Count - 1
        '        yp.Items.Add(objdataview.Item(a).Item("物料描述"))


        '    Next
        'End If

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
        Dim MyService As New S1.Service1SoapClient
        Try


            'Dim objcommand As New SqlCommand
            'objcommand.Connection = objconnection
            'objcommand.CommandText = "update GQPD set 删除标志=1 where 油罐编号 = '" & Trim(ygbh.Text) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

            'If objconnection.State = ConnectionState.Closed Then
            '    objconnection.Open()
            'End If
            'objcommand.ExecuteNonQuery()


            Dim guancunjieguo As Single
            guancunjieguo = MyService.Calculate(Val(gd2.Text), Val(gd3.Text), Val(yw2.Text), Val(yw3.Text), Trim(yp.Text), Trim(wlbm.Text), Trim(username), Trim(username), Trim(ssgq.Text), Trim(bzxx.Text), Trim(ygbh.Text), Val(gd.Text), Val(yw.Text), Val(qw.Text), Val(Trim(bzmd.Text)), Val(bzwd.Text), Val(bhxs.Text))


            MessageBox.Show("盘点数据已正确提交主数据库!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ''MessageBox.Show(guancunjieguo)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
       gd.Text = ""
        gd2.Text = ""
        gd3.Text = ""
        yw.Text = ""
        yw2.Text = ""
        yw3.Text = ""
        qw.Text = ""


    End Sub

    Private Sub ygbh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ygbh.Click

       
    End Sub

    Private Sub ygbh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ygbh.SelectedIndexChanged
        'objdataadapter.SelectCommand = New SqlCommand
        'objdataadapter.SelectCommand.Connection = objconnection
        'objdataadapter.SelectCommand.CommandText = "select 物料编码,油品,密度 from mission where ltrim(rtrim(罐号)) = '" & Trim(ygbh.Text) & "' and CONVERT(varchar(12) , 盘点时间, 112 )='" & Now.Date.ToString("yyyyMMdd") & "'"


        'If objconnection.State = ConnectionState.Closed Then
        '    objconnection.Open()
        'End If
        'objdataset = New DataSet
        'objdataadapter.Fill(objdataset, "ypmd")

        'objdataview = New DataView(objdataset.Tables("ypmd"))


        'yp.Items.Clear()
        'bzmd.Text = ""
        '' MessageBox.Show(objdataview.Count)
        'If objdataview.Count >= 1 Then

        '    yp.Text = objdataview.Item(0).Item("油品")
        '    bzmd.Text = objdataview.Item(0).Item("密度")
        '    wlbm.Text = objdataview.Item(0).Item("物料编码")
        'End If

       
   
        On Error Resume Next
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料编码,油品名称 from midu where rtrim(ltrim(罐号名称))='" & Trim(ygbh.Text) & "'"



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "ypmd")

        objdataview = New DataView(objdataset.Tables("ypmd"))

       

      
        ' MessageBox.Show(objdataview.Count)
        If objdataview.Count >= 1 Then

            yp.Text = objdataview.Item(0).Item("油品名称")
            '' bzmd.Text = objdataview.Item(0).Item("标准密度")
            wlbm.Text = objdataview.Item(0).Item("物料编码")
        End If















        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 标准密度 from midu_wuliaobianma where rtrim(ltrim(物料编码))='" & Trim(wlbm.Text) & "'"



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "mi")

        objdataview = New DataView(objdataset.Tables("mi"))




        ' MessageBox.Show(objdataview.Count)
        If objdataview.Count >= 1 Then

            bzmd.Text = objdataview.Item(0).Item("标准密度")

        End If


    End Sub

    Private Sub ssgq_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ssgq.SelectedIndexChanged

        addpinming()

    End Sub

    Private Sub wlbm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wlbm.SelectedIndexChanged

    End Sub
End Class
