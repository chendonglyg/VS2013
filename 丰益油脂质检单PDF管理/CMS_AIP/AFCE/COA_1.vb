Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Win32
Public Class COA_1

    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter

    Private Sub COA_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'objconnection = New SqlConnection("Data Source= '10.229.17.10,1433';Initial Catalog = LO_CMS;User ID='sa'; Password='chen dong'")
        yidengji.AllowUserToAddRows = False '消除最后一行
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection


        axHWPostil1.ShowDefMenu = 0
        axHWPostil1.ShowScrollBarButton = 0
        axHWPostil1.ShowToolBar = 0
        ShowData()

    End Sub

    Private Sub LABEL_BILL_Click(sender As Object, e As EventArgs) Handles LABEL_BILL.Click
        opd.Filter = "EXCEL文件|*.xls;*.xlsx"

        opd.ShowDialog()

        TXT_PATH.Text = opd.FileName

        ' filename.Text = opd.SafeFileName.Substring(0, Len(opd.SafeFileName) - 4)
        filename.Text = System.IO.Path.GetFileName(opd.FileName)

        'System.IO.Path.GetExtension("c:\windows\test.txt") '获取扩展名   
        'System.IO.Path.GetFileName("c:\windows\test.txt") '获取文件名   
        'System.IO.Path.GetDirectoryName("c:\windows\test.txt") '获取文件夹 
    End Sub

    Private Sub BUT_START_Click(sender As Object, e As EventArgs) Handles BUT_START.Click
        Try



            Dim objcommanddel As New SqlClient.SqlCommand
            objcommanddel.Connection = objconnection
            objcommanddel.CommandText = "Delete from ExcelInfo where Filename='" & Trim(filename.Text) & "'"

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommanddel.ExecuteNonQuery()


            '---------------------------------------------------------------------------------------------


            If Len(TXT_PATH.Text) > 0 Then

                Dim fi As IO.FileInfo
                Dim fs As IO.FileStream




                Dim da As New SqlClient.SqlDataAdapter("Select * from ExcelInfo where id=0", objconnection)

                Dim MyCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)

                Dim ds As New DataSet()

                da.MissingSchemaAction = MissingSchemaAction.AddWithKey


                Dim myRow As DataRow
                Dim fname As String



                For Each fname In opd.FileNames

                    fi = New IO.FileInfo(fname)

                    ''MessageBox.Show(fname)
                    fs = New IO.FileStream(fname, IO.FileMode.OpenOrCreate, IO.FileAccess.Read)

                    Dim MyData(fs.Length) As Byte

                    fs.Read(MyData, 0, fs.Length)

                    fs.Close()




                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If








                    da.Fill(ds, "UPLOADPDFFILE")

                    myRow = ds.Tables("UPLOADPDFFILE").NewRow()


                    myRow("filesdata") = MyData


                    ' myRow("附件类型") = Trim(fujianleixing.Text)
                    myRow("filesize") = fi.Length
                    myRow("filename") = fi.Name
                    myRow("filetype") = fi.Extension




                    myRow("UploadUser") = username



                    ds.Tables("UPLOADPDFFILE").Rows.Add(myRow)

                    da.Update(ds, "UPLOADPDFFILE")


                Next


                fs = Nothing
                MyCB = Nothing
                ds = Nothing
                da = Nothing

                MessageBox.Show("COA质检单已成功提交审核签章!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                axHWPostil1.LoadFile(opd.FileName)
                axHWPostil1.SetPageMode(2, 0)
                ShowData()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub yidengji_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles yidengji.CellContentClick
        IDID.Text = Trim(yidengji.Rows(e.RowIndex).Cells(0).Value)
        filename.Text = Trim(yidengji.Rows(e.RowIndex).Cells(1).Value)
        axHWPostil1.CloseDoc(0)
        ShowDataExcel()
    End Sub

    Private Sub ShowDataExcel()
        ing.Visible = True
        Try



            If Len(IDID.Text) > 0 Then



                Dim SEL As String = "C:\windows\temp\lkfjlksfjlflksjfkfjkslfj.xls"

                System.IO.File.Delete(SEL)

                Dim SQLSEL As String = "Select id,filesdata from ExcelInfo where id = " & IDID.Text

                Dim myRow As DataRow


                Dim da As New SqlClient.SqlDataAdapter(SQLSEL, objconnection)

                Dim MyCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
                Dim ds As New DataSet()

                da.Fill(ds, "COA")
                objdataview = New DataView(ds.Tables("COA"))

                If objdataview.Count > 0 Then

                    myRow = ds.Tables("COA").Rows(0)



                    Dim MyData() As Byte
                    MyData = myRow("Filesdata")

                    Dim ArraySize As Integer
                    ArraySize = MyData.GetUpperBound(0)




                    Dim fs As New IO.FileStream(SEL, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
                    fs.Write(MyData, 0, ArraySize)
                    fs.Close()


                    axHWPostil1.LoadFile(SEL)



                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ing.Visible = False
        End Try

        ing.Visible = False
    End Sub
    Private Sub ShowData()

        objdataadapter = New SqlClient.SqlDataAdapter
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandType = CommandType.Text

        objdataadapter.SelectCommand.CommandText = "select id,Filename as 文件列表 from ExcelInfo"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "COA")

        objdataview = New DataView(objdataset.Tables("COA"))

        yidengji.DataSource = objdataview

        yidengji.Columns(0).Width = 0
        yidengji.Columns(1).Width = 500

    End Sub


End Class