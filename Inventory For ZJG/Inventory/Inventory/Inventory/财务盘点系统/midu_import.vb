Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Win32
Imports System.Net
Public Class midu_import
    Inherits System.Windows.Forms.Form
    Dim ssgq As String
    Dim objdataadapter As New SqlDataAdapter
    Dim datatable As DataTable
    Dim BindingSourceSalaryItemSet As BindingSource

    Dim objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub midu_import_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        opd.Filter = "EXCEL文件|*.xls;*xlsx"

        opd.ShowDialog()

        TextBox1.Text = opd.FileName
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim da As New SqlDataAdapter("Select * from midu_wuliaobianma_zjg", objconnection)
            Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)
            Dim ds As New DataSet()
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey
            da.Fill(ds, "midu_wuliaobianma")
            Dim myRow As DataRow



            objdataadapter = New SqlDataAdapter
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection



            objdataadapter.SelectCommand.CommandText = "delete midu_wuliaobianma_zjg "

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
                myRow = ds.Tables("midu_wuliaobianma").NewRow()

                myRow("油品名称") = Trim(xlssheet.cells(c, 1).value())
                myRow("物料编码") = Trim(xlssheet.cells(c, 2).value())
                myRow("标准密度") = Val(xlssheet.cells(c, 3).value())
                myRow("标准温度") = Val(xlssheet.cells(c, 4).value())


                ds.Tables("midu_wuliaobianma").Rows.Add(myRow)


                Application.DoEvents()
                pb.Value = c
                Application.DoEvents()
            Next

            da.Update(ds, "midu_wuliaobianma")
            MyCB = Nothing
            ds = Nothing
            da = Nothing


            Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("excel")




            '-------------------------------------------
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from midu_wuliaobianma_zjg"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "midu_wuliaobianma")
            objdataview = New DataView(objdataset.Tables("midu_wuliaobianma"))
            dgv.DataSource = objdataview
            MessageBox.Show("传输完成！共计:" & objdataview.Count & "笔记录", "提示", MessageBoxButtons.OK)

            objconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class