Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class WLBM
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlDataAdapter

    Private Sub WLBM_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        MDIMain.GP.Visible = True

    End Sub
    Private Sub Test_Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain
        MDIMain.GP.Visible = False
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from wlbm "
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "wlbm")
        objdataview = New DataView(objdataset.Tables("wlbm"))
        dgv.DataSource = objdataview
        gongji.Text = gongji.Text & objdataview.Count & "笔记录"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        opd.Filter = "EXCEL文件|*.xls;*xlsx"

        opd.ShowDialog()

        TextBox1.Text = opd.FileName
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles OK.Click
        If Len(TextBox1.Text) = 0 Then
            MessageBox.Show("请先选择物料导出模板", "提示", MessageBoxButtons.OK)
            Me.Close()
        Else

            '---------------------------------------------------------------
            Dim da As New SqlDataAdapter("Select * from wlbm", objconnection)
            Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)
            Dim ds As New DataSet()
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey
            da.Fill(ds, "wlbm")
            Dim myRow As DataRow



            objdataadapter = New SqlDataAdapter
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection



            objdataadapter.SelectCommand.CommandText = "delete wlbm "

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataadapter.SelectCommand.ExecuteNonQuery()
            MessageBox.Show("删除完毕！")

            '------------------------------------------------------------------


            Dim XLS As Object = CreateObject("Excel.Application")
            Dim tFilePath As String = Trim(TextBox1.Text)
            Dim xlsBook As Object = XLS.WorkBooks.Open(tFilePath)
            Dim xlssheet As Object = xlsBook.sheets(1)

            Dim a, b As Integer
            a = Val(kaishi.Text)     '行数
            b = Val(jieshu.Text)

            pb.Minimum = a
            pb.Maximum = b

            Dim c As Integer

            For c = a To b
                myRow = ds.Tables("wlbm").NewRow()
                myRow("集团编号") = xlssheet.cells(c, 1).value()
                myRow("物料号") = xlssheet.cells(c, 2).value()
                myRow("旧物料号") = xlssheet.cells(c, 3).value()
                myRow("物料描述") = xlssheet.cells(c, 4).value()
                myRow("完整物料描述") = xlssheet.cells(c, 5).value()
                ds.Tables("wlbm").Rows.Add(myRow)


                Application.DoEvents()
                pb.Value = c
                Application.DoEvents()
            Next

            da.Update(ds, "wlbm")
            MyCB = Nothing
            ds = Nothing
            da = Nothing


            Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("excel")
            MessageBox.Show("传输完成！", "提示", MessageBoxButtons.OK)



            '-------------------------------------------
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from wlbm "
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "wlbm")
            objdataview = New DataView(objdataset.Tables("wlbm"))
            dgv.DataSource = objdataview
            gongji.Text = gongji.Text & objdataview.Count & "笔记录"
        End If
    End Sub
End Class