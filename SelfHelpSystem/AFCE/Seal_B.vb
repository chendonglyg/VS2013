Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class Seal_B
    Dim forreport As New SqlDataAdapter
    Dim fi As FileInfo
    Public afterdel As String

    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Dim objcurrencymanager As System.Windows.Forms.CurrencyManager

    Private Sub input_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1
        Dim a As Integer


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 资产分类 from Maintenance "


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "fl")

        objdataview = New DataView(objdataset.Tables("fl"))


        zichanfenlei.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                zichanfenlei.Items.Add(objdataview.Item(a).Item("资产分类"))
            Next
        End If

        '-----------------------------------------------------------------------------
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 公司名称 from Maintenance "


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "gs")

        objdataview = New DataView(objdataset.Tables("gs"))


        gongsimingcheng.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                gongsimingcheng.Items.Add(objdataview.Item(a).Item("公司名称"))
            Next
        End If

        '-------------------------------------------------------------------------------------
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 部门名称 from Maintenance "


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "bm")

        objdataview = New DataView(objdataset.Tables("bm"))


        shiyongbumen.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                shiyongbumen.Items.Add(objdataview.Item(a).Item("部门名称"))
            Next
        End If
        '-------------------------------------------------------------------------------------------------
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 规格分类 from Maintenance "


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "gg")

        objdataview = New DataView(objdataset.Tables("gg"))


        guigexinghao.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                guigexinghao.Items.Add(objdataview.Item(a).Item("规格分类"))
            Next
        End If

    End Sub


    Private Sub ClearTextBox(ByVal cc As Control.ControlCollection)

        For Each ctl As Control In cc

            If TypeOf ctl Is TextBox Then

                CType(ctl, TextBox).Text = String.Empty

            ElseIf ctl.Controls.Count > 0 Then

                ClearTextBox(ctl.Controls) '递归调用

            End If

        Next

        For Each ctl As Control In cc

            If TypeOf ctl Is ComboBox Then

                CType(ctl, ComboBox).Text = String.Empty

            ElseIf ctl.Controls.Count > 0 Then

                ClearTextBox(ctl.Controls) '递归调用

            End If

        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Seal_A.Show()
    End Sub

    Private Sub 重新录入ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 重新录入ToolStripMenuItem.Click
        ClearTextBox(Me.Controls)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If (MessageBox.Show("您确定要保存此笔记录?(Y/N)", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.OK) Then

            Try

                Dim da As New SqlDataAdapter("Select * from information1", objconnection)

                Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)

                Dim ds As New DataSet()

                da.MissingSchemaAction = MissingSchemaAction.AddWithKey

                Dim fs As New FileStream(opd.FileName, FileMode.OpenOrCreate, FileAccess.Read)
                Dim MyData(fs.Length) As Byte
                fs.Read(MyData, 0, fs.Length)



                fs.Close()


                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                Dim hm As New Date
                hm = dt1.Value
                hm.ToString("yyyy/MM/dd")



                da.Fill(ds, "information1")

                Dim myRow As DataRow

                myRow = ds.Tables("information1").NewRow()

                myRow("afce号") = Trim(afcehao.Text)
                myRow("pic") = MyData
                myRow("资产号") = Trim(zichanhao.Text)
                myRow("公司名称") = Trim(gongsimingcheng.Text)
                myRow("附件类型") = Trim(fujianleixing.Text)
                myRow("文件大小") = fi.Length
                myRow("文件名称") = fi.Name
                myRow("文件类型") = fi.Extension
                myRow("资产分类") = Trim(zichanfenlei.Text)
                myRow("资本化日期") = dt1.Value
                myRow("使用年限") = Val(shiyongnianxian.Text)
                myRow("资产名称") = Trim(zichanmingcheng.Text)

                myRow("规格型号") = Trim(guigexinghao.Text)

                myRow("数量") = Trim(shuliang.Text)

                myRow("使用状态") = Trim(shiyongzhuangtai.Text)
                myRow("发票数量") = Val(fapiaoshuliang.Text)
                myRow("附件数量") = Val(fujianshuliang.Text)

                myRow("使用部门") = Trim(shiyongbumen.Text)

                myRow("报废标志") = False

                myRow("资产原值") = Val(zichanyuanzhi.Text)
                myRow("备注") = Trim(beizhu.Text)

                ds.Tables("information1").Rows.Add(myRow)

                da.Update(ds, "information1")

                fs = Nothing
                MyCB = Nothing
                ds = Nothing
                da = Nothing


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try




            ClearTextBox(Me.Controls) '保存后需要清空一下所有填写框
            MessageBox.Show("保存完毕!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)




            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select top 1 id,afce号,数量,使用年限,公司名称,规格型号,使用状态,发票数量,附件数量,资本化日期,资产号,报废时间,实际报废时间,报废标志,资产分类,资产名称,使用部门,资产原值,公司名称,附件类型,文件名称,文件类型,文件大小,备注 from information1  order by id desc"


            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "information1")

            objdataview = New DataView(objdataset.Tables("information1"))
            'objcurrencymanager = CType(Me.BindingContext(objdataview), CurrencyManager)
            objconnection.Close()



            dgv.DataSource = objdataview





        End If


    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub





    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        opd.Filter = "所有文件|*.*"

        If opd.ShowDialog = System.Windows.Forms.DialogResult.OK Then

            fi = (New FileInfo(opd.FileName))


            lujing.Text = fi.FullName
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv.DataError
        On Error Resume Next
    End Sub
End Class
