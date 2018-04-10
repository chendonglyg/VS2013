Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO.Ports
Imports System.Threading
Imports Microsoft.Win32
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine


Public Class MainB
    Dim RS232 As SerialPort

    Dim strReceive As String
    Delegate Sub HandleInterfaceUpdateDelegate(ByVal astring As String)
    Dim interfaceUpdateHandle As HandleInterfaceUpdateDelegate

    Dim zhupibiaozhi As Boolean = False

    Dim biaozhi As Boolean

    Dim forreport As New SqlDataAdapter

    Dim hejiziduan As Integer '存储字段名的index号,从0开始
    Public ziduan(100) As String '存储字段名


    Dim hejibiaozhi As Boolean
    Dim hejibiaozhirmb As Boolean
    Dim hejibiaozhidollor As Boolean

    Dim afterdel As String

    Dim objdataadapter As New SqlDataAdapter
    Dim objdataview As New DataView
    Dim objdataset As New DataSet


    Dim mBaudRate As Integer
    Dim mParity As IO.Ports.Parity
    Dim mDataBit As Integer
    Dim mStopbit As IO.Ports.StopBits
    Dim mPortName As String









    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub print_bangdan()
        Dim oRpt As New bangdan


        Dim stra As TextObject




        stra = oRpt.ReportDefinition.ReportObjects.Item("fhdw")
        stra.Text = fahuodanwei.Text.ToString

        stra = oRpt.ReportDefinition.ReportObjects.Item("shdw")
        stra.Text = shenqingdanwei.Text.ToString




        stra = oRpt.ReportDefinition.ReportObjects.Item("pm")
        stra.Text = huowuming.Text.ToString
        stra = oRpt.ReportDefinition.ReportObjects.Item("ph")
        stra.Text = piaohao.Text.ToString

        If maozhongshijian.Text > pizhongshijian.Text Then
            stra = oRpt.ReportDefinition.ReportObjects.Item("rcsj")
            stra.Text = pizhongshijian.Text.ToString
            stra = oRpt.ReportDefinition.ReportObjects.Item("ccsj")
            stra.Text = maozhongshijian.Text.ToString

        Else
            stra = oRpt.ReportDefinition.ReportObjects.Item("ccsj")
            stra.Text = pizhongshijian.Text.ToString
            stra = oRpt.ReportDefinition.ReportObjects.Item("rcsj")
            stra.Text = maozhongshijian.Text.ToString
        End If


        stra = oRpt.ReportDefinition.ReportObjects.Item("mzsby")
        stra.Text = maocao.Text.ToString

        stra = oRpt.ReportDefinition.ReportObjects.Item("pzsby")
        stra.Text = picao.Text.ToString


        stra = oRpt.ReportDefinition.ReportObjects.Item("mzgbd")
        stra.Text = maoguo.Text.ToString

        stra = oRpt.ReportDefinition.ReportObjects.Item("pzgbd")
        stra.Text = piguo.Text.ToString



        stra = oRpt.ReportDefinition.ReportObjects.Item("bdh")
        stra.Text = bangdanhao.Text.ToString
        stra = oRpt.ReportDefinition.ReportObjects.Item("ch")
        stra.Text = chehao.Text.ToString

        stra = oRpt.ReportDefinition.ReportObjects.Item("mz")
        stra.Text = maozhong.Text.ToString
        stra = oRpt.ReportDefinition.ReportObjects.Item("pz")
        stra.Text = pizhong.Text.ToString
        stra = oRpt.ReportDefinition.ReportObjects.Item("jz")
        stra.Text = jingzhong.Text.ToString

        stra = oRpt.ReportDefinition.ReportObjects.Item("js")
        stra.Text = jianshu.Text.ToString


        stra = oRpt.ReportDefinition.ReportObjects.Item("bdhm")
        stra.Text = stationname

        stra = oRpt.ReportDefinition.ReportObjects.Item("beizhu")
        stra.Text = beizhu.Text

        stra = oRpt.ReportDefinition.ReportObjects.Item("gh")
        stra.Text = siji.Text

        stra = oRpt.ReportDefinition.ReportObjects.Item("jzxh")
        stra.Text = yunshudanwei.Text

        stra = oRpt.ReportDefinition.ReportObjects.Item("jzxh2")
        stra.Text = xianghao2.Text

        stra = oRpt.ReportDefinition.ReportObjects.Item("xs")
        stra.Text = xiangshu.Text

        stra = oRpt.ReportDefinition.ReportObjects.Item("xz")
        stra.Text = xiangzhong.Text

        ReportView.Show()
        ReportView.CrystalReportViewer1.ReportSource = oRpt





    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print.Click
        print_bangdan()
    End Sub
    Private Sub setenable(ByVal cc As Control.ControlCollection)


        For Each ctl As Control In cc

            If TypeOf ctl Is TextBox Then

                ctl.Enabled = False

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '递归调用

            End If

        Next

        For Each ctl As Control In cc

            If TypeOf ctl Is ComboBox Then

                ctl.Enabled = False

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '递归调用

            End If

        Next

    End Sub



    Public Sub clearbindtextbox(ByVal cc As Control.ControlCollection)

        For Each ctl As Control In cc

            If TypeOf ctl Is TextBox Then

                ctl.DataBindings.Clear()

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '递归调用

            End If

        Next

        For Each ctl As Control In cc

            If TypeOf ctl Is ComboBox Then

                ctl.DataBindings.Clear()

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '递归调用

            End If

        Next

        beizhu.DataBindings.Clear()


    End Sub

    Public Sub bindfields()


        If objdataview.Count > 0 Then

       

            clearbindtextbox(Me.Controls)



            '-------------------------------------------------------------------------------------------------------------------



            chehao.DataBindings.Add("text", objdataview, "truckno")
            piaohao.DataBindings.Add("text", objdataview, "ticketno")

            huowuming.DataBindings.Add("text", objdataview, "product")
            guige.DataBindings.Add("text", objdataview, "specification")
            shenqingdanwei.DataBindings.Add("text", objdataview, "receiver")
            fahuodanwei.DataBindings.Add("text", objdataview, "sender")
            chuanming.DataBindings.Add("text", objdataview, "shipname")
            huowuliuxiang.DataBindings.Add("text", objdataview, "transporter")
            tidanhao.DataBindings.Add("text", objdataview, "pickupno")


            bowei.DataBindings.Add("text", objdataview, "berth")
            yunshudanwei.DataBindings.Add("text", objdataview, "motorcade")
            siji.DataBindings.Add("text", objdataview, "motormen")


            jianshu.DataBindings.Add("text", objdataview, "amount")
     
            bangdanhao.DataBindings.Add("text", objdataview, "balanceno")


            baojianhao.DataBindings.Add("text", objdataview, "contractno")


            maozhong.DataBindings.Add("text", objdataview, "gross")
            maozhongshijian.DataBindings.Add("text", objdataview, "grossdatetime")

            pizhong.DataBindings.Add("text", objdataview, "tare")
            pizhongshijian.DataBindings.Add("text", objdataview, "taredatetime")


            jingzhong.DataBindings.Add("text", objdataview, "net")


            maocao.DataBindings.Add("text", objdataview, "operator_gross")

            picao.DataBindings.Add("text", objdataview, "operator_tare")

            maoguo.DataBindings.Add("text", objdataview, "station_gross")
            piguo.DataBindings.Add("text", objdataview, "station_tare")
            beizhu.DataBindings.Add("text", objdataview, "备注")

            xianghao2.DataBindings.Add("text", objdataview, "motorcade2")
            xiangshu.DataBindings.Add("text", objdataview, "containernum")
            xiangzhong.DataBindings.Add("text", objdataview, "containerweight")

            '----------------------------------------------------------------------------------------------


        End If



    End Sub










    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        objdataadapter = New SqlDataAdapter
        objdataadapter.SelectCommand = New SqlCommand                         '汇总DGV的结果
        objdataadapter.SelectCommand.Connection = objconnection
   
        Dim dm11 As New Date
        dm11 = dt11.Value
        Dim dm12 As New Date
        dm12 = dt12.Value
        If c1.Checked = True Then
            objdataadapter.SelectCommand.CommandText = "select  * from trade where done=1 and outtime between '" & dt11.Value & " ' and  ' " & dt12.Value & "' "
        Else
            objdataadapter.SelectCommand.CommandText = "select  * from trade where done=1"

        End If


        If ch.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and truckno = '" & Trim(chehao.Text) & "'"

        End If

        If ph.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and ticketno = '" & Trim(piaohao.Text) & "'"
        End If

        If bdh.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and balanceno = '" & Trim(bangdanhao.Text) & "'"
        End If


        objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "order by outtime desc"



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If



        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "trade")
        objdataview = New DataView(objdataset.Tables("trade"))
        dgv.DataSource = Nothing
        dgv.AutoGenerateColumns = True
        dgv.DataSource = objdataview

        'Dim jishu As Integer
        'For jishu = 1 To objdataview.Count
        '    MessageBox.Show(objdataview.Item(jishu).Item(2))

        'Next
        bindfields()
        setenable(g3.Controls)

        ch.Checked = False
        ph.Checked = False
        bdh.Checked = False

        print.Enabled = True
    End Sub

 

    Private Sub MainB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.MdiParent = MDIParent1
    End Sub

  

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        setenable(g3.Controls)

        ch.Checked = False
        ph.Checked = False
        bdh.Checked = False
    End Sub

    Private Sub bdh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bdh.Click
        setenable(g3.Controls)
        bangdanhao.Enabled = True
        print.Enabled = False

    End Sub

 

    Private Sub ch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ch.Click
        setenable(g3.Controls)
        chehao.Enabled = True
        print.Enabled = False
    End Sub

 

    Private Sub ph_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ph.Click
        setenable(g3.Controls)
        piaohao.Enabled = True
        print.Enabled = False
    End Sub

 
End Class
