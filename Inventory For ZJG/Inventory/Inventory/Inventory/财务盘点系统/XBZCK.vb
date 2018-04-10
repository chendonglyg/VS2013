Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class XBZCK
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet

    Public connforcangku As New SqlConnection("Data Source=10.229.17.10 ;Initial Catalog =package ;User ID=sa; Password=chen dong")
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub XBZCK_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        MDIMain.GP.Visible = True
    End Sub

    Private Sub XBZCK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        Try
            kucundi.Text = "益海（连云港）粮油工业有限公司"
            Me.MdiParent = MDIMain
            MDIMain.GP.Visible = False

            '-----------------------------------------------------------------------------------------------------------------------
            'objdataadapter.SelectCommand = New SqlCommand
            'objdataadapter.SelectCommand.Connection = objconnection
            'objdataadapter.SelectCommand.CommandText = "select distinct(品牌) from canshu_xiaobaozhuang"
            'MDIMain.GP.Visible = False

            'jpry.Text = username
            'pdry.Text = username
            'pdsj.Text = Now

            'If objconnection.State = ConnectionState.Closed Then
            '    objconnection.Open()
            'End If
            'objdataset = New DataSet
            'objdataadapter.Fill(objdataset, "xiao")

            'objdataview = New DataView(objdataset.Tables("xiao"))

            '' MessageBox.Show(objdataview.Count)
            'pinpai.Items.Clear()
            ''On Error Resume Next
            'If objdataview.Count >= 1 Then
            '    For a = 0 To objdataview.Count - 1
            '        pinpai.Items.Add(objdataview.Item(a).Item("品牌"))


            '    Next
            'End If


            '-------------------------------------------------------------------------------------------------------------------------


            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = connforcangku 'New SqlConnection("Data Source= 10.229.17.10,1433;Initial Catalog = package;User ID=sa; Password=chen dong")
            objdataadapter.SelectCommand.CommandText = "select distinct(仓库) from zone"
            If connforcangku.State = ConnectionState.Closed Then
                connforcangku.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "cangku")

            objdataview = New DataView(objdataset.Tables("cangku"))

            ' MessageBox.Show(objdataview.Count)
            kucundi.Items.Clear()
            'On Error Resume Next
            If objdataview.Count >= 1 Then
                For a = 0 To objdataview.Count - 1
                    kucundi.Items.Add(objdataview.Item(a).Item("仓库"))


                Next
            End If



            objconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
     

    End Sub

    'Private Sub pinpai_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    objdataadapter.SelectCommand = New SqlCommand
    '    objdataadapter.SelectCommand.Connection = objconnection
    '    objdataadapter.SelectCommand.CommandText = "select distinct(油脂名称) from canshu_xiaobaozhuang where 品牌='" & pinpai.Text & "'"




    '    If objconnection.State = ConnectionState.Closed Then
    '        objconnection.Open()
    '    End If
    '    objdataset = New DataSet
    '    objdataadapter.Fill(objdataset, "xiao")

    '    objdataview = New DataView(objdataset.Tables("xiao"))

    '    ' MessageBox.Show(objdataview.Count)
    '    youpin.Items.Clear()
    '    'On Error Resume Next
    '    If objdataview.Count >= 1 Then
    '        For a = 0 To objdataview.Count - 1
    '            youpin.Items.Add(objdataview.Item(a).Item("油脂名称"))


    '        Next
    '    End If

    '    objconnection.Close()
    'End Sub

    'Private Sub youpin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    objdataadapter.SelectCommand = New SqlCommand
    '    objdataadapter.SelectCommand.Connection = objconnection
    '    objdataadapter.SelectCommand.CommandText = "select distinct(规格) from canshu_xiaobaozhuang where 油脂名称='" & youpin.Text & "'"




    '    If objconnection.State = ConnectionState.Closed Then
    '        objconnection.Open()
    '    End If
    '    objdataset = New DataSet
    '    objdataadapter.Fill(objdataset, "xiao")

    '    objdataview = New DataView(objdataset.Tables("xiao"))

    '    ' MessageBox.Show(objdataview.Count)
    '    guige.Items.Clear()
    '    'On Error Resume Next
    '    If objdataview.Count >= 1 Then
    '        For a = 0 To objdataview.Count - 1
    '            guige.Items.Add(objdataview.Item(a).Item("规格"))


    '        Next
    '    End If

    '    objconnection.Close()
    'End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        Try

        Dim objcommand As New SqlCommand

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from XBZCK where 物料描述='" & Trim(pinming.Text) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "' and 仓区='" & Trim(cangqu.Text) & "' and 货位 ='" & Trim(huowei.Text) & "'"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If

        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "panduan")

        objdataview = New DataView(objdataset.Tables("panduan"))

        If objdataview.Count >= 1 Then

                If MessageBox.Show("同货位下发现相同货物！是否覆盖保存（Y/N）？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    objcommand.Connection = objconnection
                    objcommand.CommandText = "delete XBZCK where 物料描述='" & Trim(pinming.Text) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "' and 库存地描述='" & Trim(kucundi.Text) & Trim(cangqu.Text) & Trim(huowei.Text) & "'"

                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objcommand.ExecuteNonQuery()

                End If



            End If



            objcommand.Connection = objconnection
            objcommand.CommandText = "insert into XBZCK (仓区,货位,物料描述,单位,库存地,库存地描述,盘点时间,盘点人员,监盘人员,时间分组值,实盘数量,备注,批号) values (@仓区,@货位,@物料描述,@单位,@库存地,@库存地描述,@盘点时间,@盘点人员,@监盘人员,@时间分组值,@实盘数量,@备注,@批号)"

            objcommand.Parameters.AddWithValue("@物料描述", Trim(pinming.Text))
            objcommand.Parameters.AddWithValue("@批号", Trim(pihao.Text))
            objcommand.Parameters.AddWithValue("@单位", Trim(danwei.Text))

            objcommand.Parameters.AddWithValue("@库存地", Trim(kucundi.Text))
            objcommand.Parameters.AddWithValue("@仓区", Trim(cangqu.Text))
            objcommand.Parameters.AddWithValue("@货位", Trim(huowei.Text))


            objcommand.Parameters.AddWithValue("@库存地描述", Trim(kucundi.Text) & Trim(cangqu.Text) & Trim(huowei.Text))
            objcommand.Parameters.AddWithValue("@备注", Trim(beizhu.Text))
            objcommand.Parameters.AddWithValue("@盘点时间", Now)
            objcommand.Parameters.AddWithValue("@盘点人员", username)
            objcommand.Parameters.AddWithValue("@监盘人员", username)

            objcommand.Parameters.AddWithValue("@实盘数量", Val(xiangshu.Text))


            objcommand.Parameters.AddWithValue("@时间分组值", Now.Date.ToString("yyyyMMdd"))

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objcommand.ExecuteNonQuery()


            MessageBox.Show("数据已经提交", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub danwei_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles danwei.SelectedIndexChanged
        sl.Text = danwei.Text

    End Sub

 

    Private Sub zonghe_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pinming.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    ''SendKeys.Send("{tab}")

        '    objdataadapter.SelectCommand = New SqlCommand
        '    objdataadapter.SelectCommand.Connection = objconnection
        '    objdataadapter.SelectCommand.CommandText = "select 物料描述 from canshu_xiaobaozhuang where 物料描述 like '%" & Trim(pinming.Text) & "%'"




        '    If objconnection.State = ConnectionState.Closed Then
        '        objconnection.Open()
        '    End If
        '    objdataset = New DataSet
        '    objdataadapter.Fill(objdataset, "zonghe")

        '    objdataview = New DataView(objdataset.Tables("zonghe"))

        '    ' MessageBox.Show(objdataview.Count)
        '    pinming.Items.Clear()
        '    'On Error Resume Next
        '    If objdataview.Count >= 1 Then
        '        For a = 0 To objdataview.Count - 1

        '            pinming.Items.Add(objdataview.Item(a).Item("物料描述"))


        '        Next
        '    End If

        '    objconnection.Close()

        'End If

        If e.KeyCode = Keys.Enter Then
            Dim MyService As New S3.Service3SoapClient
            Try



                Dim guancunjieguo As DataSet
                guancunjieguo = MyService.xbz_huoming(Trim(pinming.Text))


                objdataview = New DataView(guancunjieguo.Tables("zonghe"))

                pinming.Items.Clear()

                If objdataview.Count >= 1 Then
                    For a = 0 To objdataview.Count - 1

                        pinming.Items.Add(objdataview.Item(a).Item("物料描述"))


                    Next
                End If


            Catch ex As Exception
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End Try
        End If



    End Sub

    
    

    Private Sub kucundi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kucundi.SelectedIndexChanged
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = connforcangku
        objdataadapter.SelectCommand.CommandText = "select distinct(仓区) from zone where 仓库='" & Trim(kucundi.Text) & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "cangqu")

        objdataview = New DataView(objdataset.Tables("cangqu"))

        ' MessageBox.Show(objdataview.Count)
        cangqu.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                cangqu.Items.Add(objdataview.Item(a).Item("仓区"))


            Next
        End If
    End Sub

    Private Sub cangqu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cangqu.SelectedIndexChanged
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = connforcangku
        objdataadapter.SelectCommand.CommandText = "select 货位 from zone where 仓区='" & Trim(cangqu.Text) & "' and 仓库='" & Trim(kucundi.Text) & "'"




        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "huowei")

        objdataview = New DataView(objdataset.Tables("huowei"))

        ' MessageBox.Show(objdataview.Count)
        huowei.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                huowei.Items.Add(objdataview.Item(a).Item("货位"))


            Next
        End If
    End Sub

    Private Sub kucundi_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles kucundi.TextChanged
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = connforcangku
        objdataadapter.SelectCommand.CommandText = "select distinct(仓区) from zone where 仓库='" & Trim(kucundi.Text) & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "cangqu")

        objdataview = New DataView(objdataset.Tables("cangqu"))

        ' MessageBox.Show(objdataview.Count)
        cangqu.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                cangqu.Items.Add(objdataview.Item(a).Item("仓区"))


            Next
        End If
    End Sub

 
    Private Sub pinming_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pinming.SelectedIndexChanged
        Try



        objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = connforcangku
            objdataadapter.SelectCommand.CommandText = "select 物料编码,物料描述 from canshu_xiaobaozhuang where ltrim(rtrim(物料描述)) = '" & Trim(pinming.Text) & "'"



   If connforcangku.State = ConnectionState.Closed Then
                connforcangku.Open()
            End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "bianma")

        objdataview = New DataView(objdataset.Tables("bianma"))

            If objdataview.Count >= 1 Then
                wlbm.Text = (objdataview.Item(0).Item("物料编码"))
                wlms.Text = (objdataview.Item(0).Item("物料描述"))
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class