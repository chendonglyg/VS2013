Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class ImportKCDW
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlDataAdapter

    Private Sub ImportKCDW_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        MDIMain.GP.Visible = True

    End Sub
    Private Sub ImportKCDW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain
        MDIMain.GP.Visible = False


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from kcdw "
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "kcdw")
        objdataview = New DataView(objdataset.Tables("kcdw"))
        dgv.DataSource = objdataview
        dgv.Columns(2).Width = 300

        gongji.Text = gongji.Text & objdataview.Count & "笔记录"



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        opd.Filter = "EXCEL文件|*.xls;*xlsx"

        opd.ShowDialog()

        TextBox1.Text = opd.FileName
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Len(TextBox1.Text) = 0 Then
            MessageBox.Show("请先选择物料导出模板", "提示", MessageBoxButtons.OK)
            Me.Close()
        Else

            '---------------------------------------------------------------
            Dim da As New SqlDataAdapter("Select * from KCDW", objconnection)
            Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)
            Dim ds As New DataSet()
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey
            da.Fill(ds, "kcdw")
            Dim myRow As DataRow



            objdataadapter = New SqlDataAdapter
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection



            objdataadapter.SelectCommand.CommandText = "delete kcdw "

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
                myRow = ds.Tables("kcdw").NewRow()
                myRow("库场") = xlssheet.cells(c, 1).value()
                myRow("跺位") = xlssheet.cells(c, 2).value()
                ''xlssheet.cells(c, 2).Interior.ColorIndex = 3
                ds.Tables("kcdw").Rows.Add(myRow)


                Application.DoEvents()
                pb.Value = c
                Application.DoEvents()
            Next

            da.Update(ds, "kcdw")
            MyCB = Nothing
            ds = Nothing
            da = Nothing


            Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("excel")
            MessageBox.Show("传输完成！", "提示", MessageBoxButtons.OK)



            '-------------------------------------------
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from kcdw "
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "kcdw")
            objdataview = New DataView(objdataset.Tables("kcdw"))
            dgv.DataSource = objdataview
            dgv.Columns(2).Width = 300
            gongji.Text = gongji.Text & objdataview.Count & "笔记录"
        End If


    End Sub

    Private Sub 保存更新ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 保存更新ToolStripMenuItem.Click
        Dim SCB As SqlCommandBuilder = New SqlCommandBuilder(objdataadapter)

        objdataadapter.Update(objdataset.Tables("kcdw"))
        Dim objcommand As New SqlCommand
        MessageBox.Show("提醒完毕")




        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from kcdw "
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "kcdw")
        objdataview = New DataView(objdataset.Tables("kcdw"))
        dgv.DataSource = objdataview
        dgv.Columns(2).Width = 300
        gongji.Text = gongji.Text & objdataview.Count & "笔记录"
    End Sub
End Class