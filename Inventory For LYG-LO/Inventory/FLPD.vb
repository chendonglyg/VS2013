Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class FLPD
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet

    Private Sub FLPD_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        MDIMain.GP.Visible = True
    End Sub
    Private Sub FLPD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain
        MDIMain.GP.Visible = False
        jpry.Text = username
        pdry.Text = username
        pdsj.Text = Now
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct 物料描述 from FLPD_CODE"




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

        ''  kc.AutoCompleteMode = AutoCompleteMode.Suggest
        ''kc.AutoCompleteSource = AutoCompleteSource.ListItems

    

        pdsj.Text = Now



     
    End Sub
    Private Sub addkcpd()

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct 库存地 from FLPD_CODE "



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
                kc.Items.Add(objdataview.Item(a).Item("库存地"))


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
        objdataadapter.SelectCommand.CommandText = "select 物料号, 物料描述 from flpd_code where ltrim(rtrim(物料描述)) = '" & Trim(ListBox.SelectedItem) & "'"


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

    Private Sub CX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CX.CheckedChanged
        If CX.Checked = True Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub addcombobox()

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct 物料描述 from flpd_code where ltrim(rtrim(物料描述)) like '%" & Trim(TextBox1.Text) & "%'"



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

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        addcombobox()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try


            Dim objcommand As New SqlCommand


            objcommand.Connection = objconnection
            objcommand.CommandText = "delete flpd where 库存地='" & Trim(kc.Text) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "' and 物料编码='" & Trim(wlbm.Text) & "'"


            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objcommand.ExecuteNonQuery()


            objcommand.Connection = objconnection
            objcommand.CommandText = "insert into FLPD (物料编码,物料描述,库存地,工厂,单位,实盘数量及备注,盘点时间,盘点人员,监盘人员,时间分组值) values (@物料编码,@物料描述,@库存地,@工厂,@单位,@实盘数量及备注,@盘点时间,@盘点人员,@监盘人员,@时间分组值)"

            objcommand.Parameters.AddWithValue("@物料编码", Trim(wlbm.Text))
            objcommand.Parameters.AddWithValue("@物料描述", Trim(pz.Text))
            objcommand.Parameters.AddWithValue("@库存地", Trim(kc.Text))

            objcommand.Parameters.AddWithValue("@单位", Trim(gg.Text))

            objcommand.Parameters.AddWithValue("@工厂", Trim(gc.Text))


            objcommand.Parameters.AddWithValue("@实盘数量及备注", Trim(bz.Text))


            objcommand.Parameters.AddWithValue("@盘点时间", Now)
            objcommand.Parameters.AddWithValue("@盘点人员", username)
            objcommand.Parameters.AddWithValue("@监盘人员", username)


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
End Class