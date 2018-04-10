Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Public Class COA_3
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter

    Private Sub COA_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'objconnection = New SqlConnection("Data Source= '10.229.17.10,1433';Initial Catalog = LO_CMS;User ID='sa'; Password='chen dong'")
        yidengji.AllowUserToAddRows = False '消除最后一行
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection




        axHWPostil1.ShowDefMenu = 0
        axHWPostil1.ShowScrollBarButton = 0
        axHWPostil1.ShowToolBar = 0
        IDID.Text = Nothing
        ShowData()

    End Sub

 

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        ShowData()
        axHWPostil1.CloseDoc(0)
    End Sub

    Private Sub ShowDataPDF()
        ing.Visible = True
        Try



            If Len(IDID.Text) > 0 Then



                Dim SEL As String = "C:\windows\temp\lkfjlksfjlflksjfkfjkslfj.PDF"

                System.IO.File.Delete(SEL)

                Dim SQLSEL As String = "Select id,filesdata from PrintInfo where id = " & IDID.Text

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
            ing.Visible = False
        End Try
        ing.Visible = False

    End Sub

    Private Sub yidengji_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles yidengji.CellClick
        'IDID.Text = Trim(yidengji.Rows(e.RowIndex).Cells(0).Value)
        'axHWPostil1.CloseDoc(0)
        'ShowDataPDF()
    End Sub

    Private Sub yidengji_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles yidengji.CellContentClick
        IDID.Text = Trim(yidengji.Rows(e.RowIndex).Cells(0).Value)
        Filename.Text = Trim(yidengji.Rows(e.RowIndex).Cells(1).Value)
        axHWPostil1.CloseDoc(0)
        ShowDataPDF()
    End Sub

  

    Private Sub ShowData()

        objdataadapter = New SqlClient.SqlDataAdapter
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandType = CommandType.Text

        objdataadapter.SelectCommand.CommandText = "select id,Filename as 文件列表 from PrintInfo"
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

   
    Private Sub 打印COAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打印COAToolStripMenuItem.Click
        Dim Errcode As Integer = -1104
        If axHWPostil1.PrintDoc(1, 1) <> Errcode Then

            PrintInfoBak()
            ShowData()
            axHWPostil1.CloseDoc(0)

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ShowDataPDF()
    End Sub

    Private Sub PrintInfoBak()

        Dim objcommandpassword As New SqlClient.SqlCommand
        objcommandpassword.Connection = objconnection
        objcommandpassword.CommandText = "Update PrintInfo set PrintYesNo=1 where id=" & Val(IDID.Text)

        'objcommandpassword.Parameters.AddWithValue("@备注", "该车在" & sendsomething.getDateTime() & "被退回停车场重新登记!")
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If

        objcommandpassword.ExecuteNonQuery()
        objconnection.Close()


        '--------------------------------------------------------------------------


        objdataadapter = New SqlClient.SqlDataAdapter
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandType = CommandType.StoredProcedure
        objdataadapter.SelectCommand.CommandText = "PrintInfoBAK"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataadapter.SelectCommand.ExecuteNonQuery()
        objconnection.Close()
        MessageBox.Show("COA单据已打印，记录已备份!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

    End Sub

    Private Sub 删除COAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除COAToolStripMenuItem.Click
        If MessageBox.Show("是否要删除文件:" & Filename.Text, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            Dim objcommanddel As New SqlClient.SqlCommand
            objcommanddel.Connection = objconnection
            objcommanddel.CommandText = "delete from PrintInfo where id=" & Val(IDID.Text)

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommanddel.ExecuteNonQuery()
            MessageBox.Show("您选择的记录已被删除!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If

        ShowData()

    End Sub

    Private Sub 另存为ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 另存为ToolStripMenuItem.Click
        axHWPostil1.SaveTo("", "", 0)
    End Sub
End Class