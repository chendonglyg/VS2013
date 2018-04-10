Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports CrystalDecisions.CrystalReports.Engine
Public Class Report_Total
    Dim afterdel As String

    Dim objdataadapter As New SqlDataAdapter
    Dim objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub Report_HZ1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Report_Total_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.MdiParent = MDIParent1
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        objdataadapter = New SqlDataAdapter
        objdataadapter.SelectCommand = New SqlCommand                         '汇总DGV的结果
        objdataadapter.SelectCommand.Connection = objconnection
        Dim dm11 As New Date
        dm11 = dt11.Value
        Dim dm12 As New Date
        dm12 = dt12.Value

        objdataadapter.SelectCommand.CommandText = "select  * from trade where done=1 and outtime between '" & dt11.Value & " ' and  ' " & dt12.Value & "' "

        If huoming.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText
        End If


        If huominghefahuo.Checked = True Then

            If fhdwlabel.Checked = True Then
                objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and (product like '%" & Trim(huomingfa.Text) & "%') and (sender like  '%" & Trim(fhdw.Text) & "%')"
            Else
                objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and product like '%" & Trim(huomingfa.Text) & "%' "
            End If


        End If


        If huomingheshouhuo.Checked = True Then

            If shdwlabel.Checked = True Then
                objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and product like '%" & Trim(huomingshou.Text) & "%' and receiver like '%" & Trim(shdw.Text) & "%'"
            Else
                objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and product like '%" & Trim(huomingshou.Text) & "%' "
            End If

        End If





        If chuanbo.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and contractno = '" & Trim(baojianhaozhi.Text) & "'"

        End If


        If fahuohehuoming.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and sender = '" & Trim(fahuozhi.Text) & "'"

        End If

        If dw.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and station = '" & Trim(danwei.Text) & "'"
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


    End Sub





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim stra As TextObject
        Dim straa As TextObject

        If huoming.Checked = True Then
            Dim oRpt As New huowufenleitongji
            oRpt.SetDataSource(objdataset.Tables("trade"))

            ReportView.Show()
            ReportView.CrystalReportViewer1.ReportSource = oRpt
            stra = oRpt.ReportDefinition.ReportObjects.Item("str100")
            stra.Text = dt11.Value
            straa = oRpt.ReportDefinition.ReportObjects.Item("str200")
            straa.Text = dt12.Value

        End If


        If huominghefahuo.Checked = True Then
            Dim oRpt As New huomingfahuodanwei
            oRpt.SetDataSource(objdataset.Tables("trade"))

            ReportView.Show()
            ReportView.CrystalReportViewer1.ReportSource = oRpt
            stra = oRpt.ReportDefinition.ReportObjects.Item("str100")
            stra.Text = dt11.Value
            straa = oRpt.ReportDefinition.ReportObjects.Item("str200")
            straa.Text = dt12.Value
        End If

        If huomingheshouhuo.Checked = True Then
            Dim oRpt As New huomingshouhuodanwei
            oRpt.SetDataSource(objdataset.Tables("trade"))

            ReportView.Show()
            ReportView.CrystalReportViewer1.ReportSource = oRpt
            stra = oRpt.ReportDefinition.ReportObjects.Item("str100")
            stra.Text = dt11.Value
            straa = oRpt.ReportDefinition.ReportObjects.Item("str200")
            straa.Text = dt12.Value
        End If


        If chuanbo.Checked = True Then
            Dim oRpt As New baojianhao
            oRpt.SetDataSource(objdataset.Tables("trade"))

            ReportView.Show()
            ReportView.CrystalReportViewer1.ReportSource = oRpt
            stra = oRpt.ReportDefinition.ReportObjects.Item("str100")
            stra.Text = dt11.Value
            straa = oRpt.ReportDefinition.ReportObjects.Item("str200")
            straa.Text = dt12.Value

        End If


        If fahuohehuoming.Checked = True Then
            Dim oRpt As New fahuodanweihuoming
            oRpt.SetDataSource(objdataset.Tables("trade"))

            ReportView.Show()
            ReportView.CrystalReportViewer1.ReportSource = oRpt
            stra = oRpt.ReportDefinition.ReportObjects.Item("str100")
            stra.Text = dt11.Value
            straa = oRpt.ReportDefinition.ReportObjects.Item("str200")
            straa.Text = dt12.Value
        End If



    




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim stra As TextObject
        Dim straa As TextObject


        Dim oRpt As New shouhuofenxi
        oRpt.SetDataSource(objdataset.Tables("trade"))

        ReportView.Show()
        ReportView.CrystalReportViewer1.ReportSource = oRpt

        stra = oRpt.ReportDefinition.ReportObjects.Item("str100")
        stra.Text = dt11.Value
        straa = oRpt.ReportDefinition.ReportObjects.Item("str200")
        straa.Text = dt12.Value
    End Sub
End Class