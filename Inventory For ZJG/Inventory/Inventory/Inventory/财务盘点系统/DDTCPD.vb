Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class DDTCPD
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet

    Private Sub DDTCPD_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        MDIMain.GP.Visible = True

    End Sub
    Private Sub DDTCPD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain
        addcombobox()
        ''wlms.AutoCompleteMode = AutoCompleteMode.Suggest
        ''wlms.AutoCompleteSource = AutoCompleteSource.ListItems
        jpry.Text = username
        pdry.Text = username
        pdsj.Text = Now
        MDIMain.GP.Visible = False
    End Sub
    Private Sub addcombobox()


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from wlbm where right(ltrim(rtrim(物料描述)),2)='大豆'"



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "mission")

        objdataview = New DataView(objdataset.Tables("mission"))

        ' MessageBox.Show(objdataview.Count)
        wlms.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                wlms.Items.Add(objdataview.Item(a).Item("物料描述"))


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

    Private Sub wlms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wlms.SelectedIndexChanged
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料号 from wlbm where ltrim(rtrim(物料描述)) = '" & Trim(wlms.Text) & "'"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "dd")

        objdataview = New DataView(objdataset.Tables("dd"))


        wlbm.Items.Clear()

        If objdataview.Count >= 1 Then

            wlbm.Text = objdataview.Item(0).Item("物料号")

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch.SelectedIndexChanged
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from DDTCPD_1 where ltrim(rtrim(仓号)) = '" & Trim(ch.Text) & "'"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "ch")

        objdataview = New DataView(objdataset.Tables("ch"))


        wlbm.Items.Clear()

        If objdataview.Count >= 1 Then

            h1.Text = objdataview.Item(0).Item("仓顶高")

            h2.Text = objdataview.Item(0).Item("仓边高")

        End If
    End Sub


    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Dim rz As Integer

            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from DDTCPD_RONGZHONG"


            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "rongzhong")

            objdataview = New DataView(objdataset.Tables("rongzhong"))

            rz = Val(objdataview.Item(0).Item("rongzhong"))




            Dim objcommand As New SqlCommand


            'objcommand.Connection = objconnection
            'objcommand.CommandText = "delete ddtcpd where 仓号='" & Trim(ch.Text) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

            'If objconnection.State = ConnectionState.Closed Then
            '    objconnection.Open()
            'End If
            'objcommand.ExecuteNonQuery()

            Dim slsl As Single

            slsl = ((Val(h1.Text) - (Val(h3.Text) + Val(h5.Text)) / 2) - (Val(h2.Text) - (Val(h4.Text) + Val(h6.Text)) / 2)) * (rz / 3) + (Val(h2.Text) - (Val(h4.Text) + Val(h6.Text)) / 2 - 2.2) * rz + (2.2 * rz / 3)

        
            objcommand.Connection = objconnection
            objcommand.CommandText = "insert into DDTCPD (物料编码,物料描述,仓号,h1,h2,h3,h4,h5,h6,盘点时间,盘点人员,监盘人员,散粮数量,备注,时间分组值) values (@物料编码,@物料描述,@仓号,@h1,@h2,@h3,@h4,@h5,@h6,@盘点时间,@盘点人员,@监盘人员,@散粮数量,@备注,@时间分组值)"

            objcommand.Parameters.AddWithValue("@物料编码", Trim(wlbm.Text))
            objcommand.Parameters.AddWithValue("@物料描述", Trim(wlms.Text))
            objcommand.Parameters.AddWithValue("@仓号", Trim(ch.Text))

            objcommand.Parameters.AddWithValue("@h1", Val(h1.Text))
            objcommand.Parameters.AddWithValue("@h2", Val(h2.Text))
            objcommand.Parameters.AddWithValue("@h3", Val(h3.Text))

            objcommand.Parameters.AddWithValue("@h4", Val(h4.Text))
            objcommand.Parameters.AddWithValue("@h5", Val(h5.Text))
            objcommand.Parameters.AddWithValue("@h6", Val(h6.Text))

            objcommand.Parameters.AddWithValue("@盘点时间", Now)
            objcommand.Parameters.AddWithValue("@盘点人员", Trim(pdry.Text))
            objcommand.Parameters.AddWithValue("@监盘人员", Trim(jpry.Text))




            objcommand.Parameters.AddWithValue("@散粮数量", slsl)





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
End Class