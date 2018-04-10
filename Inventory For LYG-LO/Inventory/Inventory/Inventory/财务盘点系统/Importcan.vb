Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class Importcan
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New OleDb.OleDbDataAdapter
    Dim str_conn As String
    Public objconnection As OleDb.OleDbConnection

    Private Sub Importcan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        opd.Filter = "EXCEL文件|*.xls;*xlsx"

        opd.ShowDialog()

        TextBox1.Text = opd.FileName


    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & opdaccess.FileName & ";Persist Security Info=False;"
        If s1.Checked = True Then



            objconnection = New OleDb.OleDbConnection(str_conn)
            On Error Resume Next
            If Len(TextBox1.Text) = 0 Then
                MessageBox.Show("请先选择物料导出模板", "提示", MessageBoxButtons.OK)

            Else
                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = objconnection

                objdataadapter.SelectCommand.CommandText = "delete * from zhengshu "

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataadapter.SelectCommand.ExecuteNonQuery()
                MessageBox.Show("删除完毕！")







                '---------------------------------------------------------------
                Dim da As New OleDb.OleDbDataAdapter("Select * from zhengshu", str_conn)
                Dim MyCB As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(da)

                Dim ds As New DataSet
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey
                da.Fill(ds, "zhengshu")
                Dim myRow As DataRow


                Dim temp As Single


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
                    myRow = ds.Tables("zhengshu").NewRow()
                    myRow("m") = Math.Round(Val(xlssheet.cells(c, 1).value()) * 100) / 100
                    myRow("米容") = Math.Round(Val(xlssheet.cells(c, 2).value()) * 1000)
                    ds.Tables("zhengshu").Rows.Add(myRow)
                    Application.DoEvents()
                    pb.Value = c
                    Application.DoEvents()
                Next

                da.Update(ds, "zhengshu")
                MyCB = Nothing
                ds = Nothing
                da = Nothing

                xlsBook.Close(True)
                XLS.Quit()
                xlsBook = Nothing
                XLS = Nothing
                ProcessKill()

                MessageBox.Show("传输完成！", "提示", MessageBoxButtons.OK)










                '-------------------------------------------
                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = New OleDb.OleDbConnection(str_conn)
                objdataadapter.SelectCommand.CommandText = "select * from zhengshu "
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "zhengshu")
                objdataview = New DataView(objdataset.Tables("zhengshu"))
                dgv.DataSource = objdataview
                gongji.Text = ""

                gongji.Text = gongji.Text & objdataview.Count & "笔记录"
            End If


        End If






        If s2.Checked = True Then

            objconnection = New OleDb.OleDbConnection(str_conn)
            On Error Resume Next
            If Len(TextBox1.Text) = 0 Then
                MessageBox.Show("请先选择物料导出模板", "提示", MessageBoxButtons.OK)

            Else
                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = objconnection

                objdataadapter.SelectCommand.CommandText = "delete * from xiuzheng "

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataadapter.SelectCommand.ExecuteNonQuery()
                MessageBox.Show("删除完毕！")







                '---------------------------------------------------------------
                Dim da As New OleDb.OleDbDataAdapter("Select * from xiuzheng", str_conn)
                Dim MyCB As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(da)

                Dim ds As New DataSet
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey
                da.Fill(ds, "xiuzheng")
                Dim myRow As DataRow


                Dim temp As Single


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
                    myRow = ds.Tables("xiuzheng").NewRow()
                    myRow("m") = Math.Round(Val(xlssheet.cells(c, 1).value()) * 100) / 100
                    myRow("容量") = Math.Round(Val(xlssheet.cells(c, 2).value()) * 1000)
                    ds.Tables("xiuzheng").Rows.Add(myRow)
                    Application.DoEvents()
                    pb.Value = c
                    Application.DoEvents()
                Next

                da.Update(ds, "xiuzheng")
                MyCB = Nothing
                ds = Nothing
                da = Nothing

                xlsBook.Close(True)
                XLS.Quit()
                xlsBook = Nothing
                XLS = Nothing
                ProcessKill()

                MessageBox.Show("传输完成！", "提示", MessageBoxButtons.OK)










                '-------------------------------------------
                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = New OleDb.OleDbConnection(str_conn)
                objdataadapter.SelectCommand.CommandText = "select * from xiuzheng "
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "xiuzheng")
                objdataview = New DataView(objdataset.Tables("xiuzheng"))
                dgv.DataSource = objdataview
                gongji.Text = ""

                gongji.Text = gongji.Text & objdataview.Count & "笔记录"
            End If
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        opdaccess.Filter = "ACCESS文件|*.mdb"

        opdaccess.ShowDialog()

        TextBox2.Text = opdaccess.FileName




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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class