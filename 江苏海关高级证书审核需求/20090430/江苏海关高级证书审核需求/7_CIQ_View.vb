Public Class CIQ_View
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim datatable As DataTable
    Dim objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub CIQ_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.AllowUserToAddRows = False

    End Sub


    Private Sub FORSQL_KeyDown(sender As Object, e As KeyEventArgs) Handles baoguandanhao.KeyDown
        If e.KeyCode = Keys.Enter Then
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandType = CommandType.Text
            If Len(baoguandanhao.Text) = 0 Then
              objdataadapter.SelectCommand.CommandText = "SELECT CIQ_Receipt.合同号,CIQ_Trade.报关单号," & _
              "CIQ_Trade.原料领用库位,CIQ_Trade.产品存放库位,CIQ_Trade.销售合同号,CIQ_Trade.日期,CIQ_Trade.提单号," & _
              "CIQ_Trade.客户名称,CIQ_Trade.件数,CIQ_Trade.重量,CIQ_Trade.品名,CIQ_Trade.运输方式 from CIQ_Receipt INNER JOIN CIQ_Trade ON CIQ_Receipt.报关单号 = CIQ_Trade.报关单号 " & _
              "where 1=1"
            Else
              objdataadapter.SelectCommand.CommandText = "SELECT CIQ_Receipt.合同号,CIQ_Trade.报关单号," & _
              "CIQ_Trade.原料领用库位,CIQ_Trade.产品存放库位,CIQ_Trade.销售合同号,CIQ_Trade.日期,CIQ_Trade.提单号," & _
              "CIQ_Trade.客户名称,CIQ_Trade.件数,CIQ_Trade.重量,CIQ_Trade.品名,CIQ_Trade.运输方式 from CIQ_Receipt INNER JOIN CIQ_Trade ON CIQ_Receipt.报关单号 = CIQ_Trade.报关单号 " & _
                  "where CIQ_Receipt.报关单号='" & Trim(baoguandanhao.Text) & "'"
            End If





            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "SQL")

            objdataview = New DataView(objdataset.Tables("SQL"))
            If objdataview.Count >= 1 Then
                dgv.DataSource = objdataview
                total.Text = "共计:" & objdataview.Count & "笔记录"
            Else
                MessageBox.Show("该报关单号无详细明细数据或报关单号不存在!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        End If

        objconnection.Close()
    End Sub

    Private Sub hetonghao_KeyDown(sender As Object, e As KeyEventArgs) Handles hetonghao.KeyDown
        If e.KeyCode = Keys.Enter Then
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandType = CommandType.Text
            If Len(hetonghao.Text) = 0 Then
                objdataadapter.SelectCommand.CommandText = "SELECT CIQ_Receipt.合同号,CIQ_Trade.报关单号," & _
            "CIQ_Trade.原料领用库位,CIQ_Trade.产品存放库位,CIQ_Trade.销售合同号,CIQ_Trade.日期,CIQ_Trade.提单号," & _
            "CIQ_Trade.客户名称,CIQ_Trade.件数,CIQ_Trade.重量,CIQ_Trade.品名,CIQ_Trade.运输方式 from CIQ_Receipt INNER JOIN CIQ_Trade ON CIQ_Receipt.报关单号 = CIQ_Trade.报关单号 " & _
            "where 1=1"
            Else
               objdataadapter.SelectCommand.CommandText = "SELECT CIQ_Receipt.合同号,CIQ_Trade.报关单号," & _
             "CIQ_Trade.原料领用库位,CIQ_Trade.产品存放库位,CIQ_Trade.销售合同号,CIQ_Trade.日期,CIQ_Trade.提单号," & _
             "CIQ_Trade.客户名称,CIQ_Trade.件数,CIQ_Trade.重量,CIQ_Trade.品名,CIQ_Trade.运输方式 from CIQ_Receipt INNER JOIN CIQ_Trade ON CIQ_Receipt.报关单号 = CIQ_Trade.报关单号 " & _
                 "where CIQ_Receipt.合同号='" & Trim(hetonghao.Text) & "'"
            End If





            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "SQL")

            objdataview = New DataView(objdataset.Tables("SQL"))
            If objdataview.Count >= 1 Then
                dgv.DataSource = objdataview
                total.Text = "共计:" & objdataview.Count & "笔记录"
            Else
                MessageBox.Show("该合同号无详细明细数据或合同号不存在!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        End If

        objconnection.Close()
    End Sub

    Private Sub 保存记录ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存记录ToolStripMenuItem.Click
        Dim oRpt As New CrystalReport1
        oRpt.SetDataSource(objdataset.Tables("SQL"))
        PRINT.Show()
        PRINT.CrystalReportViewer1.ReportSource = oRpt
        PRINT.CrystalReportViewer1.ShowExportButton = True
    End Sub

    Private Sub 退出界面ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出界面ToolStripMenuItem.Click
        Me.Close()
    End Sub

    
End Class