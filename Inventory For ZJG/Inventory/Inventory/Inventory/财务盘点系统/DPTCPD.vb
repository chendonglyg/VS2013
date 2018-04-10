Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class DPTCPD
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Dim s1 As Single


    Private Sub DPTCPD_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        MDIMain.GP.Visible = True

    End Sub

    Private Sub DPTCPD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain
        jpry.Text = username
        pdry.Text = username
        pdsj.Text = Now
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from wlbm where 豆粕默认显示=1"


        MDIMain.GP.Visible = False

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
            Dim ss As Integer
            For ss = 0 To objdataview.Count - 1
                ListBox.Items.Add(objdataview.Item(ss).Item("物料描述"))


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

    Private Sub d_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles h4.TextChanged

    End Sub

    Private Sub ch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch.SelectedIndexChanged
        If ch.SelectedIndex = 0 Then
            s1 = 171.47
        End If
        If ch.SelectedIndex = 1 Then
            s1 = 171.19
        End If
        If ch.SelectedIndex = 2 Then
            s1 = 171.79
        End If
        If ch.SelectedIndex = 3 Then
            s1 = 171.48
        End If
    End Sub

    

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        addcombobox()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim panduan, cangcun, s2 As Single

            s2 = Val(h1.Text) + Val(h2.Text) + Val(h3.Text) + Val(h4.Text) + Val(h5.Text) + Val(h6.Text)
            panduan = (s1 - s2) / 6


            If panduan < 10 Then
                cangcun = (s1 - s2) / 6 * 207
            ElseIf ((panduan >= 10) And (panduan < 15)) Then
                cangcun = (s1 - s2) / 6 * 227
            ElseIf (panduan >= 15) Then
                cangcun = (s1 - s2) / 6 * 247
            End If

            Dim objcommand As New SqlCommand


            objcommand.Connection = objconnection
            objcommand.CommandText = "update DPTCPD set 删除标志=1 where 仓号='" & Trim(ch.Text) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objcommand.ExecuteNonQuery()







            objcommand = New SqlCommand

            objcommand.Connection = objconnection
            objcommand.CommandText = "insert into DPTCPD (物料编码,物料描述,规格,仓号,打尺a,打尺b,打尺c,打尺d,打尺e,打尺f,仓存,备注,盘点时间,盘点人员,监盘人员,时间分组值) values (@物料编码,@物料描述,@规格,@仓号,@打尺a,@打尺b,@打尺c,@打尺d,@打尺e,@打尺f,@仓存,@备注,@盘点时间,@盘点人员,@监盘人员,@时间分组值)"

            objcommand.Parameters.AddWithValue("@物料编码", Trim(wlbm.Text))
            objcommand.Parameters.AddWithValue("@物料描述", Trim(pz.Text))
            objcommand.Parameters.AddWithValue("@规格", Trim(gg.Text))

            objcommand.Parameters.AddWithValue("@仓号", Trim(ch.Text))
            objcommand.Parameters.AddWithValue("@打尺a", Val(h1.Text))
            objcommand.Parameters.AddWithValue("@打尺b", Val(h2.Text))

            objcommand.Parameters.AddWithValue("@打尺c", Trim(h3.Text))
            objcommand.Parameters.AddWithValue("@打尺d", Val(h4.Text))
            objcommand.Parameters.AddWithValue("@打尺e", Val(h5.Text))
            objcommand.Parameters.AddWithValue("@打尺f", Val(h6.Text))

            objcommand.Parameters.AddWithValue("@仓存", cangcun)



            objcommand.Parameters.AddWithValue("@盘点时间", Now)
            objcommand.Parameters.AddWithValue("@盘点人员", username)
            objcommand.Parameters.AddWithValue("@监盘人员", username)


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

    Private Sub wlbm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wlbm.SelectedIndexChanged

    End Sub
End Class