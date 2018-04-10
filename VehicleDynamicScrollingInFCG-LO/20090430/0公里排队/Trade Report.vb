Public Class Trade_Report
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Private Sub Trade_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      
      



    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dm11 As New Date
        dm11 = dt11.Value
        Dim dm12 As New Date
        dm12 = dt12.Value
        objdataadapter = New SqlClient.SqlDataAdapter
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection




        objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE_BAK where 1=1"


        objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & " and (完成时间 between  '" & dm11.ToString("yyyy/MM/dd") & "' and '" & dm12.ToString("yyyy/MM/dd") & "')"






        If cb1.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & " and 客户名称 = " & "'" & Trim(kehumingcheng.Text) & "'"
        End If

        If cb2.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & " and 货物名称 = '" & Trim(pinming.Text) & "'"
        End If

        If cb3.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & " and 车号 = '" & Trim(chehao.Text) & "'"
        End If





        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "TOTAL")
        objdataview = New DataView(objdataset.Tables("TOTAL"))
        dgv.DataSource = objdataview

        '-----------------------------------------------------------------------------------

    End Sub
    Private Sub addcombo()

        Application.DoEvents()

        kehumingcheng.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        kehumingcheng.AutoCompleteSource = AutoCompleteSource.ListItems

        Application.DoEvents()

        Dim a As Integer


        objdataadapter.SelectCommand = New System.Data.SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 客户名称 from DATA_QUEUE"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "kehu")

        objdataview = New DataView(objdataset.Tables("kehu"))
        Application.DoEvents()
        ' MessageBox.Show(objdataview.Count)
        kehumingcheng.Items.Clear()
        On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                If Len(objdataview.Item(a).Item("客户名称").ToString) <> 0 Then
                    Application.DoEvents()
                    kehumingcheng.Items.Add(Trim(objdataview.Item(a).Item("客户名称")))
                End If
            Next
        End If
        Application.DoEvents()

        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料名称 from DATA_QUEUE"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "wuliao")

        objdataview = New DataView(objdataset.Tables("wuliao"))

        ' MessageBox.Show(objdataview.Count)
        pinming.Items.Clear()


        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                If Len(objdataview.Item(a).Item("物料名称").ToString) <> 0 Then
                    pinming.Items.Add(Trim(objdataview.Item(a).Item("物料名称")))
                End If
            Next
        End If




        objconnection.Close()




    End Sub

  

 

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim stra As CrystalDecisions.CrystalReports.Engine.TextObject


        Dim oRpt As New PRINTLIST

        oRpt.SetDataSource(objdataset.Tables("TOTAL"))

        PRINT.Show()
        PRINT.CrystalReportViewer1.ReportSource = oRpt
        'stra = oRpt.ReportDefinition.ReportObjects.Item("str100")
        'stra.Text = "益海（连云港）粮油工业公司 停车场汇总表"
    End Sub

    Private Sub kehumingcheng_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kehumingcheng.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.DoEvents()

        Label1.Text = "正在读取数据"
        addcombo()
        Label1.Text = ""
    End Sub
End Class