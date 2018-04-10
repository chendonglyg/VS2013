Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class QZ_PrintSomething
    Dim afterdel As String

    Dim objdataadapterforprint As New SqlDataAdapter
    Dim objdataviewforprint As New DataView
    Dim objdatasetforprint As New DataSet


    Private Sub PrintSomething_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        objdataadapterforprint = New SqlDataAdapter
        objdataadapterforprint.SelectCommand = New SqlCommand                         '汇总DGV的结果
        objdataadapterforprint.SelectCommand.Connection = objconnection

        dt12.Value = Now

        gq.Checked = True

        If gq.Checked = True Then
            objdataadapterforprint.SelectCommand.CommandText = "select  * from QZ_InventoryData where (盘点时间 between '" & dt11.Value & " ' and  ' " & dt12.Value & "') and rtrim(所属罐区) = '泉州粮油罐区' "
        End If

        'If yxgq.Checked = True Then
        '    objdataadapterforprint.SelectCommand.CommandText = "select  * from gqpd where (盘点时间 between '" & dt11.Value & " ' and  ' " & dt12.Value & "') and rtrim(所属罐区) = '营销罐区' "
        'End If


        'If dptc.Checked = True Then


        '    objdataadapterforprint.SelectCommand.CommandText = "select  * from dptcpd where (盘点时间 between '" & dt11.Value & " ' and  ' " & dt12.Value & "') and (删除标志=0)"


        'End If


        'If ddtc.Checked = True Then
        '    objdataadapterforprint.SelectCommand.CommandText = "select  * from ddtcpd where 盘点时间 between '" & dt11.Value & " ' and  ' " & dt12.Value & "' "


        'End If





        'If gckdp.Checked = True Then
        '    objdataadapterforprint.SelectCommand.CommandText = "select  * from kcpd where 盘点时间 between '" & dt11.Value & " ' and  ' " & dt12.Value & "' "

        'End If



        'If xbzck.Checked = True Or xbzck2.Checked = True Or xbzck3.Checked = True Then
        '    objdataadapterforprint.SelectCommand.CommandText = "select  * from xbzck where 盘点时间 between '" & dt11.Value & " ' and  ' " & dt12.Value & "'"
        'End If

        'If flpd.Checked = True Then
        '    objdataadapterforprint.SelectCommand.CommandText = "select  * from flpd where 盘点时间 between '" & dt11.Value & " ' and  ' " & dt12.Value & "' "
        'End If



        If seldel.Checked = True Then
            objdataadapterforprint.SelectCommand.CommandText = objdataadapterforprint.SelectCommand.CommandText & " or 删除标志=1 order by id desc"
        End If



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If


        Try
            objdatasetforprint = New DataSet
            objdataadapterforprint.Fill(objdatasetforprint, "QZ_InventoryData")
            objdataviewforprint = New DataView(objdatasetforprint.Tables("QZ_InventoryData"))
            dgv.DataSource = Nothing
            dgv.AutoGenerateColumns = True
            dgv.DataSource = objdataviewforprint
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        jilushu.Text = "共计" & objdataviewforprint.Count & "条记录"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim paramFields As New ParameterValues

        Dim discreteVal As New ParameterDiscreteValue





        If gq.Checked = True Or yxgq.Checked = True Then
            Dim oRpt As New CrystalReport1
            oRpt.SetDataSource(objdatasetforprint.Tables("QZ_InventoryData"))

            QZ_PrintSomethingDisplay.CrystalReportViewer1.ReportSource = oRpt

            discreteVal.Value = 111


            paramFields.Add(discreteVal)


            oRpt.DataDefinition.ParameterFields("canshu").ApplyCurrentValues(paramFields)


            QZ_PrintSomethingDisplay.Show()


        End If








    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub



End Class