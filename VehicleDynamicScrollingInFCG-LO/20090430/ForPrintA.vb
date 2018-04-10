Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32

Public Class ForPrintA

    Dim printbiaozhi As Integer = 100

    Dim forreport As New SqlDataAdapter
    Dim objdataadapter As New SqlDataAdapter
    Dim objdataviewaddcombo As New DataView
    Dim objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ForPrintA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        addcombo()
        rukudt1.Value = Now
        rukudt2.Value = Now

        chukudt1.Value = Now
        chukudt11.Value = Now
        chukudt2.Value = Now

        diaobodt1.Value = Now
        diaobodt2.Value = Now
    End Sub
    Private Sub addcombo()

        Dim a As Integer




        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct(仓库) from zone"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "cangku")

        objdataviewaddcombo = New DataView(objdataset.Tables("cangku"))

        ' MessageBox.Show(objdataview.Count)
        cangku.Items.Clear()

        'On Error Resume Next
        If objdataviewaddcombo.Count >= 1 Then
            For a = 0 To objdataviewaddcombo.Count - 1
                cangku.Items.Add(objdataviewaddcombo.Item(a).Item("仓库"))


            Next
        End If




        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct(品牌) from xbzpd_wuliaoku"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "xiao")

        objdataview = New DataView(objdataset.Tables("xiao"))

        ' MessageBox.Show(objdataview.Count)
        pinpai.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                pinpai.Items.Add(objdataview.Item(a).Item("品牌"))


            Next
        End If


  


        objconnection.Close()

    End Sub

    Private Sub Print1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print1.Click
        objdataadapter = New SqlDataAdapter
        objdataadapter.SelectCommand = New SqlCommand                         '汇总DGV的结果
        objdataadapter.SelectCommand.Connection = objconnection

        Dim dm11 As New Date
        dm11 = rukudt1.Value
        Dim dm12 As New Date
        dm12 = rukudt2.Value

        objdataadapter.SelectCommand.CommandText = "select  * from xbzpd_rukudan where  更新时间 between '" & rukudt1.Value & " ' and  ' " & rukudt2.Value & "' and 产品流向='" & Trim(cplx1.Text) & "'"


        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "rukudan")
        objdataview = New DataView(objdataset.Tables("rukudan"))
        dgv.DataSource = Nothing
        dgv.AutoGenerateColumns = True
        dgv.DataSource = objdataview
        '---------------------------------------------------------------------------------------------


        printbiaozhi = 1

    


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If printbiaozhi = 1 Then

            Dim oRpt As New CrystalReport4

            oRpt.SetDataSource(objdataset.Tables("rukudan"))


            PRINT.CrystalReportViewer1.ReportSource = oRpt
            PRINT.Show()


        End If

        If printbiaozhi = 2 Then

            Dim oRpt As New CrystalReport5

            oRpt.SetDataSource(objdataset.Tables("chukudan"))


            PRINT.CrystalReportViewer1.ReportSource = oRpt
            PRINT.Show()


        End If


        If printbiaozhi = 3 Then

            Dim oRpt As New CrystalReport6

            oRpt.SetDataSource(objdataset.Tables("diaobodan"))


            PRINT.CrystalReportViewer1.ReportSource = oRpt
            PRINT.Show()


        End If



        If printbiaozhi = 4 Then

            Dim oRpt As New CrystalReport3

            oRpt.SetDataSource(objdataset.Tables("kucun"))


            PRINT.CrystalReportViewer1.ReportSource = oRpt
            PRINT.Show()


        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        objdataadapter = New SqlDataAdapter
        objdataadapter.SelectCommand = New SqlCommand                         '汇总DGV的结果
        objdataadapter.SelectCommand.Connection = objconnection

        Dim dm11 As New Date
        dm11 = rukudt1.Value
        Dim dm12 As New Date
        dm12 = rukudt2.Value

        objdataadapter.SelectCommand.CommandText = "select  * from xbzpd_diaobodan where  更新时间 between '" & rukudt1.Value & " ' and  ' " & rukudt2.Value & "' and 产品流向= '" & Trim(cplx3.Text) & "'"


        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "diaobodan")
        objdataview = New DataView(objdataset.Tables("diaobodan"))
        dgv.DataSource = Nothing
        dgv.AutoGenerateColumns = True
        dgv.DataSource = objdataview
        '---------------------------------------------------------------------------------------------


        printbiaozhi = 3
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        objdataadapter = New SqlDataAdapter
        objdataadapter.SelectCommand = New SqlCommand                         '汇总DGV的结果
        objdataadapter.SelectCommand.Connection = objconnection

        objdataadapter.SelectCommand.CommandText = "select  * from xbzpd_lihuodan where 产品流向='" & Trim(cplx2.Text) & "'"
        
        Dim dm12 As New Date
        dm12 = chukudt2.Value

        If chukugz.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and 更新时间 between '" & chukudt1.Value & " ' and  ' " & chukudt11.Value & "'"


            '---------------------------------------------------------------------------------------------
        End If

        If chukusc.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and ('" & dm12 & "' between 生产日期s and 生产日期e )"


            '---------------------------------------------------------------------------------------------
        End If



        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "chukudan")
        objdataview = New DataView(objdataset.Tables("chukudan"))
        dgv.DataSource = Nothing
        dgv.AutoGenerateColumns = True
        dgv.DataSource = objdataview
        printbiaozhi = 2
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        objdataadapter = New SqlDataAdapter
        objdataadapter.SelectCommand = New SqlCommand                         '汇总DGV的结果
        objdataadapter.SelectCommand.Connection = objconnection

        Dim dm11 As New Date
        dm11 = rukudt1.Value
        Dim dm12 As New Date
        dm12 = rukudt2.Value

        objdataadapter.SelectCommand.CommandText = "select  * from xbzpd_kucun where 1=1"

        If pp.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and 品牌= '" & Trim(pinpai.Text) & "'"
        End If

        If cpmc.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and 产品名称= '" & Trim(chanpinmingcheng.Text) & "'"
        End If


        If ck.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and 仓库= '" & Trim(cangku.Text) & "'"
        End If



        If cq.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and 仓区= '" & Trim(cangqu.Text) & "'"
        End If



        If hw.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and 货位= '" & Trim(huowei.Text) & "'"
        End If


        If scxh.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and 生产线号= '" & Trim(shengchanxianhao.Text) & "'"
        End If

        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "kucun")
        objdataview = New DataView(objdataset.Tables("kucun"))
        dgv.DataSource = Nothing
        dgv.AutoGenerateColumns = True
        dgv.DataSource = objdataview
        '---------------------------------------------------------------------------------------------


        printbiaozhi = 4
    End Sub

    Private Sub pinpai_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pinpai.SelectedIndexChanged
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct(油脂名称) from XBZPD_WULIAOKU where 品牌='" & pinpai.Text & "'"




        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "xiao")

        objdataview = New DataView(objdataset.Tables("xiao"))

        ' MessageBox.Show(objdataview.Count)
        chanpinmingcheng.Items.Clear()
        chanpinmingcheng.Text = ""
        Dim a As Integer
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                chanpinmingcheng.Items.Add(objdataview.Item(a).Item("油脂名称"))

                chanpinmingcheng.Text = ""



            Next
        End If

        objconnection.Close()
    End Sub

    Private Sub cangku_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cangku.SelectedIndexChanged
        Dim a As Integer
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct(仓区) from zone where 仓库='" & Trim(cangku.Text) & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "cangqu")

        objdataview = New DataView(objdataset.Tables("cangqu"))

        ' MessageBox.Show(objdataview.Count)
        cangqu.Items.Clear()
        cangqu.Text = ""



        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                cangqu.Items.Add(objdataview.Item(a).Item("仓区"))


            Next
        End If

        huowei.Items.Clear()
        huowei.Text = ""
    End Sub

    Private Sub cangqu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cangqu.SelectedIndexChanged
        Dim a As Integer
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 货位 from zone where 仓区='" & cangqu.Text & "'and 仓库='" & Trim(cangku.Text) & "'"




        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "huowei")

        objdataview = New DataView(objdataset.Tables("huowei"))

        ' MessageBox.Show(objdataview.Count)
        huowei.Items.Clear()
        huowei.Text = ""

   

        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                huowei.Items.Add(objdataview.Item(a).Item("货位"))


            Next
        End If
    End Sub
End Class