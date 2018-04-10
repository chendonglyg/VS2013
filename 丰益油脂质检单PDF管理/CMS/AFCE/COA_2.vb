Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Public Class COA_2




    Private Sub LABEL_BILL_Click(sender As Object, e As EventArgs) Handles LABEL_BILL.Click
        opd.Filter = "PDF文件|*.PDF"

        opd.ShowDialog()

        TXT_PATH.Text = opd.FileName

        ' filename.Text = opd.SafeFileName.Substring(0, Len(opd.SafeFileName) - 4)
        filename.Text = System.IO.Path.GetFileName(opd.FileName)

        'System.IO.Path.GetExtension("c:\windows\test.txt") '获取扩展名   
        'System.IO.Path.GetFileName("c:\windows\test.txt") '获取文件名   
        'System.IO.Path.GetDirectoryName("c:\windows\test.txt") '获取文件夹 




    End Sub

    Private Sub BUT_START_Click(sender As Object, e As EventArgs) Handles BUT_START.Click
        'Try



        Dim objcommanddel As New SqlClient.SqlCommand
        objcommanddel.Connection = objconnection
        objcommanddel.CommandText = "Delete from PrintInfo where filename='" & Trim(filename.Text) & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If

        objcommanddel.ExecuteNonQuery()


        '---------------------------------------------------------------------------------------------


        If Len(TXT_PATH.Text) > 0 Then

            Dim fi As IO.FileInfo
            Dim fs As IO.FileStream




            Dim da As New SqlClient.SqlDataAdapter("Select * from PrintInfo where id=0", objconnection)

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

            MessageBox.Show("COA质检单已成功发往库场!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            axHWPostil1.LoadFile(opd.FileName)
            axHWPostil1.SetPageMode(2, 0)
        End If


        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        'End Try


    End Sub

    Private Sub COA_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'objconnection = New SqlConnection("Data Source= '10.229.17.10,1433';Initial Catalog = LO_CMS;User ID='sa'; Password='chen dong'")
        axHWPostil1.ShowDefMenu = 0
        axHWPostil1.ShowScrollBarButton = 0
        axHWPostil1.ShowToolBar = 0


    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class