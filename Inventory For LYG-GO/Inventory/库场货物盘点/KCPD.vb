Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class KCPD
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet

    Private Sub KCPD_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        MDIMain.GP.Visible = True

    End Sub
    Private Sub KCPD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain
        MDIMain.GP.Visible = False
        jpry.Text = username
        pdry.Text = username
        pdsj.Text = Now
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from wlbm where 库场默认显示=1"




        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "pz")

        objdataview = New DataView(objdataset.Tables("pz"))

        ' MessageBox.Show(objdataview.Count)
        ListBox.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                ListBox.Items.Add(objdataview.Item(a).Item("物料描述"))


            Next
        End If










        addkcpd()

        kc.AutoCompleteMode = AutoCompleteMode.Suggest
        kc.AutoCompleteSource = AutoCompleteSource.ListItems

        dw.AutoCompleteMode = AutoCompleteMode.Suggest
        dw.AutoCompleteSource = AutoCompleteSource.ListItems

        

        pdsj.Text = Now



        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from KCPD_1"



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "kc")

        objdataview = New DataView(objdataset.Tables("kc"))

        ' MessageBox.Show(objdataview.Count)
        gg.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                gg.Items.Add(objdataview.Item(a).Item("规格"))


            Next
        End If

    End Sub

    Private Sub addkcpd()

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct 库场 from kcdw "



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "kc")

        objdataview = New DataView(objdataset.Tables("kc"))

        ' MessageBox.Show(objdataview.Count)
        kc.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                kc.Items.Add(objdataview.Item(a).Item("库场"))


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
    Private Sub addcombobox()

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from wlbm where ltrim(rtrim(物料描述)) like '%" & Trim(TextBox1.Text) & "%'"



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "pz")

        objdataview = New DataView(objdataset.Tables("pz"))

        ' MessageBox.Show(objdataview.Count)
        ListBox.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                ListBox.Items.Add(objdataview.Item(a).Item("物料描述"))


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


    

    Private Sub ListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox.SelectedIndexChanged
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料号,物料描述 from wlbm where ltrim(rtrim(物料描述)) = '" & Trim(ListBox.SelectedItem) & "'"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "wlbm")

        objdataview = New DataView(objdataset.Tables("wlbm"))


        wlbm.Items.Clear()

        If objdataview.Count >= 1 Then
            pz.Text = objdataview.Item(0).Item("物料描述")
            wlbm.Text = objdataview.Item(0).Item("物料号")

        End If
    End Sub

    

   

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        addcombobox()
    End Sub

    Private Sub CX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CX.CheckedChanged
        If CX.Checked = True Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub gg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gg.SelectedIndexChanged
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 量,单位 from KCPD_1 where 规格='" & gg.Text & "'"




        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "kc")

        objdataview = New DataView(objdataset.Tables("kc"))

        liang.Text = objdataview.Item(0).Item("量")
        danwei.Text = objdataview.Item(0).Item("单位")



    End Sub

   

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try


            Dim objcommand As New SqlCommand


            objcommand.Connection = objconnection
            objcommand.CommandText = "delete kcpd where 物料编码='" & Trim(wlbm.Text) & "' and 垛位='" & Trim(dw.Text) & "' and 时间分组值='" & Now.Date.ToString("yyyymmdd") & "'"

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objcommand.ExecuteNonQuery()


            '删除当日同一个跺位+同一种货物

            objcommand.Connection = objconnection
            objcommand.CommandText = "insert into kcpd (物料编码,物料描述,库场,垛位,规格,单位,特殊库,件数,盘点时间,盘点人员,监盘人员,时间分组值,备注,重量) values (@物料编码,@物料描述,@库场,@垛位,@规格,@单位,@特殊库,@件数,@盘点时间,@盘点人员,@监盘人员,@时间分组值,@备注,@重量)"

            objcommand.Parameters.AddWithValue("@物料编码", Trim(wlbm.Text))
            objcommand.Parameters.AddWithValue("@物料描述", Trim(pz.Text))
            objcommand.Parameters.AddWithValue("@库场", Trim(kc.Text))

            objcommand.Parameters.AddWithValue("@垛位", Trim(dw.Text))
            objcommand.Parameters.AddWithValue("@规格", Trim(gg.Text))
            objcommand.Parameters.AddWithValue("@单位", Trim(dw.Text))

            objcommand.Parameters.AddWithValue("@特殊库", Trim(tsk.Text))
            objcommand.Parameters.AddWithValue("@件数", Val(js.Text))
            ''objcommand.Parameters.AddWithValue("@账面数量", Val(zmsl.Text))

            objcommand.Parameters.AddWithValue("@盘点时间", Now)
            objcommand.Parameters.AddWithValue("@盘点人员", username)
            objcommand.Parameters.AddWithValue("@监盘人员", username)
            objcommand.Parameters.AddWithValue("@重量", (Val(liang.Text) * Val(js.Text)))

            objcommand.Parameters.AddWithValue("@备注", Trim(bz.Text))
            objcommand.Parameters.AddWithValue("@时间分组值", Now.Date.ToString("yyyyMMdd"))
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objcommand.ExecuteNonQuery()
            objconnection.Close()

            MessageBox.Show("数据已经提交", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub kc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kc.SelectedIndexChanged
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 跺位 from kcdw where ltrim(rtrim(库场)) = '" & Trim(kc.Text) & "'"



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "dw")

        objdataview = New DataView(objdataset.Tables("dw"))

        ' MessageBox.Show(objdataview.Count)
        dw.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                dw.Items.Add(objdataview.Item(a).Item("跺位"))


            Next
        End If
    End Sub
End Class