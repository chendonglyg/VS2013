Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Imports Microsoft.Win32
Imports System.Net
Imports System.Net.Sockets
Public Class Mission
    Inherits System.Windows.Forms.Form
    Dim ssgq As String
    Dim objdataadapter As New SqlDataAdapter
    Dim datatable As DataTable
    Dim BindingSourceSalaryItemSet As BindingSource

    Dim objdataview As New DataView
    Dim objdataset As New DataSet

    Private Sub Mission_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        MDIMain.GP.Visible = True

    End Sub

    Private Sub Mission_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter

    End Sub


    Private Sub Mission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain
        MDIMain.GP.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        opd.Filter = "EXCEL文件|*.xls;*xlsx"

        opd.ShowDialog()

        TextBox1.Text = opd.FileName
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If Len(TextBox1.Text) = 0 Then
                MessageBox.Show("请先选择物料导出模板", "提示", MessageBoxButtons.OK)
            Else
                If liangyou.Checked = True Then

                    ssgq = "粮油罐区"
                ElseIf youhua.Checked = True Then

                    ssgq = "油化罐区"
                ElseIf yingxiao.Checked = True Then

                    ssgq = "营销罐区"
                ElseIf banqiao.Checked = True Then

                    ssgq = "板桥罐区"
                Else
                    MessageBox.Show("必须选择所属罐区", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
                '---------------------------------------------------------------
                Dim da As New SqlDataAdapter("Select * from midu", objconnection)
                Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)
                Dim ds As New DataSet()
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey
                da.Fill(ds, "midu")
                Dim myRow As DataRow



                objdataadapter = New SqlDataAdapter
                objdataadapter.SelectCommand = New SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection



                objdataadapter.SelectCommand.CommandText = "delete midu where 所属罐区='" & ssgq & "'"

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataadapter.SelectCommand.ExecuteNonQuery()
                'MessageBox.Show("删除完毕！")

                '------------------------------------------------------------------


                Dim XLS As Object = CreateObject("Excel.Application")
                Dim tFilePath As String = Trim(TextBox1.Text)
                Dim xlsBook As Object = XLS.WorkBooks.Open(tFilePath)
                Dim xlssheet As Object = xlsBook.sheets(Val(sheetno.Text))

                Dim a, b As Integer
                a = Val(kaishi.Text)     '行数
                b = Val(jieshu.Text)

                pb.Minimum = a
                pb.Maximum = b

                Dim c As Integer

                For c = a To b
                    myRow = ds.Tables("midu").NewRow()
                    myRow("罐号名称") = Trim(xlssheet.cells(c, 1).value())
                    myRow("油品名称") = Trim(xlssheet.cells(c, 2).value())
                    myRow("物料编码") = Trim(xlssheet.cells(c, 3).value())
                    ''myRow("标准密度") = Val(xlssheet.cells(c, 4).value())
                    myRow("更新时间") = Now
                    myRow("更新标志") = 0
                    myRow("所属罐区") = ssgq


                    ds.Tables("midu").Rows.Add(myRow)


                    Application.DoEvents()
                    pb.Value = c
                    Application.DoEvents()
                Next

                da.Update(ds, "midu")
                MyCB = Nothing
                ds = Nothing
                da = Nothing


                Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("excel")




                '-------------------------------------------
                objdataadapter.SelectCommand = New SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection
                objdataadapter.SelectCommand.CommandText = "select * from midu where 所属罐区='" & ssgq & "'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "midu")
                objdataview = New DataView(objdataset.Tables("midu"))
                dgv.DataSource = objdataview
                MessageBox.Show("传输完成！共计:" & objdataview.Count & "笔记录", "提示", MessageBoxButtons.OK)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

  

End Class