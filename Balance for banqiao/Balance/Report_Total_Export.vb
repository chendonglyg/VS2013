Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports CrystalDecisions.CrystalReports.Engine
Public Class Report_Total_Export
    Dim afterdel As String
    Dim idid As String
    Dim objdataadapter As New SqlDataAdapter
    Dim objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub Report_HZ1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Report_Total_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If dataviewuser.Item(0).Item("privilage") = True Then
            gxsj.Enabled = True
            scjl.Enabled = True
        Else
            gxsj.Enabled = False
            scjl.Enabled = False
        End If


        'Me.MdiParent = MDIParent1




        Dim sr As IO.StreamReader
        sr = New System.IO.StreamReader(Application.StartupPath & "\车号.txt", True)
        chehao.Items.Clear()
        Do While sr.Peek > 0
            chehao.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing



        sr = New System.IO.StreamReader(Application.StartupPath & "\报检号.txt", True)
        baojianhao.Items.Clear()
        Do While sr.Peek > 0
            baojianhao.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing




        sr = New System.IO.StreamReader(Application.StartupPath & "\货物名.txt", True)
        huoming.Items.Clear()
        Do While sr.Peek > 0
            huoming.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing





        sr = New System.IO.StreamReader(Application.StartupPath & "\申请单位.txt", True)
        shouhuodanwei.Items.Clear()
        Do While sr.Peek > 0
            shouhuodanwei.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing




        sr = New System.IO.StreamReader(Application.StartupPath & "\发货单位.txt", True)
        fahuodanwei.Items.Clear()
        Do While sr.Peek > 0
            fahuodanwei.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing



        sr = New System.IO.StreamReader(Application.StartupPath & "\船名.txt", True)
        chuanming.Items.Clear()
        Do While sr.Peek > 0
            chuanming.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing



        sr = New System.IO.StreamReader(Application.StartupPath & "\货物流向.txt", True)
        huowuliuxiang.Items.Clear()
        Do While sr.Peek > 0
            huowuliuxiang.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing






        sr = New System.IO.StreamReader(Application.StartupPath & "\票号.txt", True)
        piaohao.Items.Clear()
        Do While sr.Peek > 0
            piaohao.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing


    End Sub


    Private Sub totallirun()
        Dim lirun As Double
        Dim sr As Integer






        For sr = 0 To objdataview.Count - 1

            Dim newrow As DataRowView = objdataview.AddNew()

            newrow = objdataview.Item(sr)

            lirun = newrow("net") + lirun
       
        Next

        sumnet.Text = "净重总计:" & lirun & "KG"
  


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

    


        If chehao1.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and truckno like '%" & Trim(chehao.Text) & "%' "
        End If

        If huoming1.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and product like '%" & Trim(huoming.Text) & "%' "
        End If


        If piaohao1.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and ticketno = '" & Trim(piaohao.Text) & "'"

        End If


        If baojianhao1.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and contractno = '" & Trim(baojianhao.Text) & "'"
        End If


        If huowuliuxiang1.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and transporter = '" & Trim(huowuliuxiang.Text) & "'"
        End If


        If yunshudanwei1.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and motorcade = '" & Trim(yunshudanwei.Text) & "'"
        End If


        If shouhuodanwei1.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and receiver = '" & Trim(shouhuodanwei.Text) & "'"
        End If


        If fahuodanwei1.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and sender = '" & Trim(fahuodanwei.Text) & "'"
        End If

        If chuanming1.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and shipname = '" & Trim(chuanming.Text) & "'"
        End If







        Dim i As Integer

        objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "order by outtime desc"
        afterdel = objdataadapter.SelectCommand.CommandText
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "trade")
        objdataview = New DataView(objdataset.Tables("trade"))


        dgv.DataSource = Nothing
        dgv.AutoGenerateColumns = True
        dgv.DataSource = objdataview

        If objdataview.Count > 0 Then
            For i = 0 To 43
                dgv.Columns(i).ReadOnly = True
            Next
            dgv.Columns(19).ReadOnly = False '件数
            dgv.Columns(1).ReadOnly = False '票号

            dgv.Columns(5).ReadOnly = False '品名
            dgv.Columns(3).ReadOnly = False '车号

            dgv.Columns(8).ReadOnly = False '收货单位
            dgv.Columns(7).ReadOnly = False '发货单位

            dgv.Columns(33).ReadOnly = False '罐号



        End If





        totallirun()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oRpt As New zhubiao_export
        oRpt.SetDataSource(objdataset.Tables("trade"))

        ReportView.Show()
        ReportView.CrystalReportViewer1.ReportSource = oRpt
        ReportView.CrystalReportViewer1.ShowExportButton = True
    End Sub

    Private Sub 更新数据ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gxsj.Click
        If (MessageBox.Show("您确定要修改这批数据？（Y/N）", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK) Then

            Dim objcommanddel As New SqlCommand
            objcommanddel.Connection = objconnection
            objcommanddel.CommandText = "insert deltrade select * from trade where id =" & idid

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommanddel.ExecuteNonQuery()

      
            objcommanddel.CommandText = "update deltrade set 动作时间 = '" & Now & "',动作 = '修改操作' ,备注2 = 1 where (备注2=0 or 备注2 is null) and (id =" & idid & ")"


            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommanddel.ExecuteNonQuery()

            '以上要将原始数据保存到deltrade





            Dim SCB As SqlCommandBuilder = New SqlCommandBuilder(objdataadapter)
            If objdataview.Count > 0 Then
                objdataadapter.Update(objdataset.Tables("trade"))

                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "trade")

                dgv.DataSource = objdataset.Tables("trade")
                MessageBox.Show("更新完毕,请做记录!")

                objdataadapter = New SqlDataAdapter
                objdataadapter.SelectCommand = New SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection
                objdataadapter.SelectCommand.CommandText = afterdel


                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "trade")
                objdataview = New DataView(objdataset.Tables("trade"))
                dgv.DataSource = objdataview

                objconnection.Close()
            End If

        End If

    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        On Error Resume Next
        idid = Trim(dgv.Rows(e.RowIndex).Cells(0).Value)
    End Sub

    Private Sub 删除单笔记录ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scjl.Click
        If (MessageBox.Show("您确认要删除ID号为:" & idid & "的主库记录？（Y/N)", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK) Then

            Dim objcommanddel As New SqlCommand
            objcommanddel.Connection = objconnection
            objcommanddel.CommandText = "delete from trade where id=" & idid

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommanddel.ExecuteNonQuery()




            '这块是要随时更新临时库信息
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = afterdel
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "trade")
            objdataview = New DataView(objdataset.Tables("trade"))
            dgv.DataSource = objdataview
            objconnection.Close()
        End If

    End Sub
End Class