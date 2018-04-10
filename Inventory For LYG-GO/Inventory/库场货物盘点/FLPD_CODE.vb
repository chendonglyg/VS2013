Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class FLPD_CODE
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlDataAdapter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        opd.Filter = "EXCEL文件|*.xls;*xlsx"

        opd.ShowDialog()

        TextBox1.Text = opd.FileName
    End Sub

    Private Sub FLPD_CODE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain
        MDIMain.GP.Visible = False
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        On Error Resume Next
        If Len(TextBox1.Text) = 0 Then
            MessageBox.Show("请先选择辅料导出模板", "提示", MessageBoxButtons.OK)
            Me.Close()
        Else

            '---------------------------------------------------------------
            Dim da As New SqlDataAdapter("Select * from flpd_code", objconnection)
            Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)
            Dim ds As New DataSet()
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey
            da.Fill(ds, "wlbm")
            Dim myRow As DataRow



            objdataadapter = New SqlDataAdapter
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection



            objdataadapter.SelectCommand.CommandText = "delete flpd_code "

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
                myRow("集团号") = xlssheet.cells(c, 1).value()
                myRow("物料号") = xlssheet.cells(c, 2).value()
                myRow("公司代码") = xlssheet.cells(c, 4).value()
                myRow("物料描述") = xlssheet.cells(c, 3).value()
                myRow("工厂") = xlssheet.cells(c, 4).value()
                myRow("库存地") = xlssheet.cells(c, 5).value()

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
            objdataadapter.SelectCommand.CommandText = "select * from flpd_code "
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "wlbm")
            objdataview = New DataView(objdataset.Tables("wlbm"))
            dgv.DataSource = objdataview
            gongji.Text = gongji.Text & objdataview.Count & "笔记录"
            xlsBook.Close(True)
            XLS.Quit()
            xlsBook = Nothing
            XLS = Nothing
            ProcessKill()
        End If
    End Sub
    Private Sub ProcessKill()
        Dim p As System.Diagnostics.Process
        p = New System.Diagnostics.Process
        For Each p In System.Diagnostics.Process.GetProcesses()
            If p.ProcessName.ToUpper() = "EXCEL" Then
                p.Kill()
            End If
        Next
    End Sub
End Class