Imports system.windows.Forms.DialogResult
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class TEMP5
    Dim forreport As New SqlDataAdapter

    Dim fi As FileInfo
    Public afterdel As String

    Dim objdataadapter As New SqlDataAdapter


    Public objdataview As New DataView
    Dim objdataset As New DataSet

    Private Sub Upload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1
        Try
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select top 100 id,afce号,数量,使用年限,公司名称,规格型号,使用状态,发票数量,附件数量,资本化日期,资产号,报废时间,实际报废时间,报废标志,资产分类,资产名称,使用部门,资产原值,公司名称,附件类型,文件名称,文件类型,文件大小,备注 from information1  order by id desc"


            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "information1")

            objdataview = New DataView(objdataset.Tables("information1"))
            'objcurrencymanager = CType(Me.BindingContext(objdataview), CurrencyManager)
            objconnection.Close()



            DGV.DataSource = objdataview
            clearbindtextbox(Me.Controls)
            bindfields()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

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

        dt1.DataBindings.Clear()

    End Sub

    Public Sub bindfields()




        If objdataview.Count > 0 Then

            dt1.DataBindings.Clear()


            clearbindtextbox(Me.Controls) '解除本界面所有textbox的绑定



            '-------------------------------------------------------------------------------------------------------------------

            ID.DataBindings.Add("text", objdataview, "id")

            afcehao.DataBindings.Add("text", objdataview, "afce号")
            zichanhao.DataBindings.Add("text", objdataview, "资产号")

            '---------------------------------------------------------------------------------------------------------------------------

 


            '------------------------------------------------------------------------------------------------------------------------------

            zichanfenlei.DataBindings.Add("text", objdataview, "资产分类")
            dt1.DataBindings.Add("text", objdataview, "资本化日期")
            zichanmingcheng.DataBindings.Add("text", objdataview, "资产名称")

            shiyongnianxian.DataBindings.Add("text", objdataview, "使用年限")




            '----------------------------------------------------------------------------------------------------------------
            guigexinghao.DataBindings.Add("text", objdataview, "规格型号")
            shuliang.DataBindings.Add("text", objdataview, "数量")

            gongsimingcheng.DataBindings.Add("text", objdataview, "公司名称")
            shiyongzhuangtai.DataBindings.Add("text", objdataview, "使用状态")
            fapiaoshuliang.DataBindings.Add("text", objdataview, "发票数量")
    
            fujianshuliang.DataBindings.Add("text", objdataview, "附件数量")
            shiyongbumen.DataBindings.Add("text", objdataview, "使用部门")
            zichanyuanzhi.DataBindings.Add("text", objdataview, "资产原值")
            '----------------------------------------------------------------------------------------------

            beizhu.DataBindings.Add("text", objdataview, "备注")
            fujianleixing.DataBindings.Add("text", objdataview, "附件类型")


        End If


    End Sub

    Private Sub dt1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt1.ValueChanged

    End Sub

    Private Sub afcehao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles afcehao.SelectedIndexChanged

    End Sub

    Private Sub zichanfenlei_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zichanfenlei.SelectedIndexChanged

    End Sub

    Private Sub zichanmingcheng_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zichanmingcheng.SelectedIndexChanged

    End Sub

    Private Sub gongsimingcheng_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gongsimingcheng.SelectedIndexChanged

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DGV_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        Dim dgv As DataGridView = CType(sender, DataGridView)

        '确认单元格的列


        If dgv.Rows(e.RowIndex).Cells("报废标志").Value = True Then
            e.CellStyle.BackColor = Color.Red


        Else

            '根据单元格的值，变更背景色
            If (Now > dgv.Rows(e.RowIndex).Cells("报废时间").Value) And (Len(dgv.Rows(e.RowIndex).Cells("id").Value) > 0) Then
                e.CellStyle.BackColor = Color.Yellow

            End If
        End If



    End Sub

    Private Sub DGV_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DGV.DataError
        On Error Resume Next
    End Sub

    Private Sub 资产调拨ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 资产调拨ToolStripMenuItem.Click
        TEMP2.Show()
        TEMP2.afcehao.Text = Trim(afcehao.Text)
        TEMP2.zichanhao.Text = Trim(zichanhao.Text)
        TEMP2.dt1.Value = Now
        TEMP2.yuanshibumen.Text = Trim(shiyongbumen.Text)
        TEMP2.ID.Text = Trim(ID.Text)

    End Sub

    Private Sub 资产报废ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 资产报废ToolStripMenuItem.Click
        If MessageBox.Show("确定要报废此资产？（Y/N）", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = OK Then
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "update information1 set 报废标志=1,实际报废时间 = getdate() where id=" & ID.Text
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objdataadapter.SelectCommand.ExecuteNonQuery()

            MessageBox.Show("OK")


        End If
    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then

            objdataadapter = New SqlDataAdapter
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection



            objdataadapter.SelectCommand.CommandText = "select * from information1 where 资产号='" & Trim(zichanhao.Text) & "'"

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "lyg")
            objdataview = New DataView(objdataset.Tables("lyg"))
            DGV.DataSource = Nothing
            DGV.AutoGenerateColumns = True
            DGV.DataSource = objdataview




        End If
    End Sub

    Private Sub ToolStripTextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox2.Click

    End Sub

    Private Sub ToolStripTextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then

            objdataadapter = New SqlDataAdapter
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection



            objdataadapter.SelectCommand.CommandText = "select  id,afce号,数量,使用年限,公司名称,规格型号,使用状态,发票数量,附件数量,资本化日期,资产号,报废时间,实际报废时间,报废标志,资产分类,资产名称,使用部门,资产原值,公司名称,附件类型,文件名称,文件类型,文件大小,备注 from information1 where afce号='" & Trim(afcehao.Text) & "'"

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "lyg")
            objdataview = New DataView(objdataset.Tables("lyg"))
            DGV.DataSource = Nothing
            DGV.AutoGenerateColumns = True
            DGV.DataSource = objdataview




        End If
    End Sub

    Private Sub 资产调拨纪录ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 资产调拨纪录ToolStripMenuItem.Click
        objdataadapter = New SqlDataAdapter
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection



        objdataadapter.SelectCommand.CommandText = "select  id,afce号,数量,使用年限,公司名称,规格型号,使用状态,发票数量,附件数量,资本化日期,资产号,报废时间,实际报废时间,报废标志,资产分类,资产名称,使用部门,资产原值,公司名称,附件类型,文件名称,文件类型,文件大小,备注 from move where 资产号 ='" & Trim(zichanhao.Text) & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "move")
        objdataview = New DataView(objdataset.Tables("move"))
        TEMP4.Show()
        TEMP4.dgv.DataSource = Nothing
        TEMP4.dgv.AutoGenerateColumns = True
        TEMP4.dgv.DataSource = objdataview

    End Sub
End Class