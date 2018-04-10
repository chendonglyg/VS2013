Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.Windows.Forms

Public Class COA_4

    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Private Sub TEMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objconnection = New SqlConnection("Data Source= '222.189.4.146,1433';Initial Catalog = LO_CMS;User ID='sa'; Password='chen dong'")

        Dim Resources As New System.ComponentModel.ComponentResourceManager(GetType(COA_4))

      


        yidengji.AllowUserToAddRows = False '消除最后一行
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection




        axHWPostil1.ShowDefMenu = 0
        axHWPostil1.ShowScrollBarButton = 0
        axHWPostil1.ShowToolBar = 1
        IDID.Text = Nothing


    End Sub

    Private Sub ShowData()
        If Len(YearSum.Text) > 0 Then
            objdataadapter = New SqlClient.SqlDataAdapter
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandType = CommandType.Text

            objdataadapter.SelectCommand.CommandText = "select id,Filename as 可供打印的文件清单 from PrintInfoDone where Datename(yyyy,UploadTime)='" & Trim(YearSum.Text) & "' and FileName like '%" & Trim(FileName.Text) & "%'"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "COA")

            objdataview = New DataView(objdataset.Tables("COA"))

            yidengji.DataSource = objdataview

            yidengji.Columns(0).Width = 0
            yidengji.Columns(1).Width = 500
        Else
            MessageBox.Show("请先选择年度!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub


   

  



    Private Sub FileName_KeyDown(sender As Object, e As KeyEventArgs) Handles FileName.KeyDown
        If e.KeyCode = Keys.Enter Then


            ShowData()
        End If
    End Sub

    Private Sub yidengji_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles yidengji.CellContentClick
        IDID.Text = Trim(yidengji.Rows(e.RowIndex).Cells(0).Value)
        FileName.Text = Trim(yidengji.Rows(e.RowIndex).Cells(1).Value)
        axHWPostil1.CloseDoc(0)
        ShowDataPDF()
    End Sub

    Private Sub ShowDataPDF()

        Try



            If Len(IDID.Text) > 0 Then



                Dim SEL As String = "C:\windows\temp\lkfjlksfjlflksjfkfjkslfj.PDF"

                System.IO.File.Delete(SEL)

                Dim SQLSEL As String = "Select id,filesdata from PrintInfoDone where id = " & IDID.Text

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
                    axHWPostil1.SetPageMode(2, 0)


                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

        End Try


    End Sub

   
 
End Class