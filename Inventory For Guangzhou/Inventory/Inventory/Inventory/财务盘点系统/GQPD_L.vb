Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class GQPD_L
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Dim resel As String

    Private Sub GQPD_L_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        MDIMain.GP.Visible = True

    End Sub
    Private Sub GQPD_L_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain
        MDIMain.GP.Visible = False
    End Sub

    Private Sub clearbindtextbox(ByVal cc As Control.ControlCollection)

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

            If TypeOf ctl Is Label Then

                ctl.DataBindings.Clear()

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '递归调用清楚label绑定

            End If

        Next


    End Sub
    Public Sub bindfields()




        If objdataview.Count > 0 Then


            clearbindtextbox(Me.Controls) '解除本界面所有textbox的绑定



            '-------------------------------------------------------------------------------------------------------------------

            idid.DataBindings.Add("text", objdataview, "id")

            ssgq.DataBindings.Add("text", objdataview, "所属罐区")
            ygbh.DataBindings.Add("text", objdataview, "油罐编号")
            yp.DataBindings.Add("text", objdataview, "油品名称")
            '---------------------------------------------------------------------------------------------------------------------------




            '------------------------------------------------------------------------------------------------------------------------------

            wlbm.DataBindings.Add("text", objdataview, "物料编码")
            bzxx.DataBindings.Add("text", objdataview, "备注")
            gd.DataBindings.Add("text", objdataview, "打尺深度")
            gd2.DataBindings.Add("text", objdataview, "打尺深度2")
            gd3.DataBindings.Add("text", objdataview, "打尺深度3")
            yw.DataBindings.Add("text", objdataview, "油温")
            yw2.DataBindings.Add("text", objdataview, "油温2")
            yw3.DataBindings.Add("text", objdataview, "油温3")


            qw.DataBindings.Add("text", objdataview, "气温")

            bzmd.DataBindings.Add("text", objdataview, "标准密度")
            bzwd.DataBindings.Add("text", objdataview, "标准温度")
            bhxs.DataBindings.Add("text", objdataview, "变化系数")
            '----------------------------------------------------------------------------------------------

            pdsj.DataBindings.Add("text", objdataview, "盘点时间")
            pdry.DataBindings.Add("text", objdataview, "盘点人员")
            jpry.DataBindings.Add("text", objdataview, "监盘人员")
            sjfzz.DataBindings.Add("text", objdataview, "时间分组值")

        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        objdataadapter = New SqlDataAdapter
        objdataadapter.SelectCommand = New SqlCommand                         '汇总DGV的结果
        objdataadapter.SelectCommand.Connection = objconnection
        Dim dm11 As New Date
        dm11 = dt11.Value
        Dim dm12 As New Date
        dm12 = dt12.Value



        If gq.Checked = True Then
            objdataadapter.SelectCommand.CommandText = "select  * from gqpd where (删除标志 is null) and (盘点时间 between '" & dt11.Value & " ' and  ' " & dt12.Value & "')  and rtrim(所属罐区) = '粮油罐区'  "
        End If

        If yxgq.Checked = True Then
            objdataadapter.SelectCommand.CommandText = "select  * from gqpd where 删除标志=0 and (盘点时间 between '" & dt11.Value & " ' and  ' " & dt12.Value & "') and rtrim(所属罐区) = '营销罐区' "
        End If


   



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If

        resel = objdataadapter.SelectCommand.CommandText

        ''On Error Resume Next
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "pandian")
        objdataview = New DataView(objdataset.Tables("pandian"))
        dgv.DataSource = Nothing
        dgv.AutoGenerateColumns = True
        dgv.DataSource = objdataview
        objconnection.Close()
        clearbindtextbox(Me.Controls)
        bindfields()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim MyService As New S1.Service1SoapClient



            MyService.Calculate(Val(gd2.Text), Val(gd3.Text), Val(yw2.Text), Val(yw3.Text), Trim(yp.Text), Trim(wlbm.Text), Trim(username), Trim(username), Trim(ssgq.Text), Trim(bzxx.Text), Trim(ygbh.Text), Val(gd.Text), Val(yw.Text), Val(qw.Text), Val(Trim(bzmd.Text)), Val(bzwd.Text), Val(bhxs.Text))

            MessageBox.Show("盘点数据已正确提交主数据库!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)



            '------------------------------------------------------------

            Dim objcommand As New SqlCommand


            objcommand.Connection = objconnection
            objcommand.CommandText = "delete GQPD where id= " & Val(idid.Text)

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objcommand.ExecuteNonQuery()




            objdataadapter = New SqlDataAdapter
            objdataadapter.SelectCommand = New SqlCommand                         '汇总DGV的结果
            objdataadapter.SelectCommand.Connection = objconnection

            objdataadapter.SelectCommand.CommandText = resel







            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If



            ''On Error Resume Next
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "pandian")
            objdataview = New DataView(objdataset.Tables("pandian"))
            dgv.DataSource = Nothing
            dgv.AutoGenerateColumns = True
            dgv.DataSource = objdataview
            clearbindtextbox(Me.Controls)
            bindfields()

            objconnection.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim objcommand As New SqlCommand


        objcommand.Connection = objconnection
        objcommand.CommandText = "delete GQPD where id= " & Val(idid.Text)

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()

        MessageBox.Show("删除完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)



        objdataadapter = New SqlDataAdapter
        objdataadapter.SelectCommand = New SqlCommand                         '汇总DGV的结果
        objdataadapter.SelectCommand.Connection = objconnection

        objdataadapter.SelectCommand.CommandText = resel







        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If



        ''On Error Resume Next
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "pandian")
        objdataview = New DataView(objdataset.Tables("pandian"))
        dgv.DataSource = Nothing
        dgv.AutoGenerateColumns = True
        dgv.DataSource = objdataview
        clearbindtextbox(Me.Controls)
        bindfields()

        objconnection.Close()
    End Sub
End Class