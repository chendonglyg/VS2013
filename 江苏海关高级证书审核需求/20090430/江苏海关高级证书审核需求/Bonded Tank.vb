Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Public Class Bonded

    'Dim objconnection As New SqlConnection("server=(local);database=package;user id=sa;password=chen dong")

    Dim objconnection As New SqlConnection("Data Source= 218.92.115.4;Initial Catalog = package;User ID=sa; Password=chen dong")

    Dim forreport As New SqlDataAdapter

    Dim sr As New Integer
    Dim srf As New Integer

    Dim objdataAdapter As New SqlDataAdapter
    Dim objdataset As New DataSet




    Dim objdataview As New DataView

    Dim objcurrencymanager As System.Windows.Forms.CurrencyManager

   
 



    Private Sub Can_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      
        ruguanriqi.Text = Now
        chuguanriqi.Text = Now
        showall()



 
     
    End Sub

   

















    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Len(guanhao.Text) <> 0 And Len(youpin.Text) <> 0 And Len(chuanming.Text) <> 0 And Len(dianzizhangcehao.Text) <> 0 And Len(jinkouhetonghao.Text) <> 0 And Len(ruku.Text) <> 0 And Len(chuku.Text) <> 0 And Len(jinriguancun.Text) <> 0 And Len(zuoriguancun.Text) <> 0 And Len(dachishu.Text) <> 0 And Len(youwen.Text) <> 0 Then
            Try


                Dim objcommand As New SqlCommand



                objcommand.Connection = objconnection
                objcommand.CommandText = "insert into bonded (罐号,油品,船名,电子账册号,进口合同号,入罐日期,出罐日期,入库,出库,今日罐存,昨日罐存,打尺数,货物编号,录入时间) values (@罐号,@油品,@船名,@电子帐册号,@进口合同号,@入罐日期,@出罐日期,@入库,@出库,@今日罐存,@昨日罐存,@打尺数,@货物编号,@录入时间)"

                objcommand.Parameters.AddWithValue("@罐号", Trim(guanhao.Text))

                objcommand.Parameters.AddWithValue("@油品", Trim(youpin.Text))

                objcommand.Parameters.AddWithValue("@船名", Trim(chuanming.Text))

                objcommand.Parameters.AddWithValue("@电子帐册号", Trim(dianzizhangcehao.Text))

                objcommand.Parameters.AddWithValue("@进口合同号", Trim(jinkouhetonghao.Text))

                objcommand.Parameters.AddWithValue("@入罐日期", ruguanriqi.Value)
                objcommand.Parameters.AddWithValue("@出罐日期", chuguanriqi.Value)

                objcommand.Parameters.AddWithValue("@入库", Val(ruku.Text))

                objcommand.Parameters.AddWithValue("@出库", Val(chuku.Text))

                objcommand.Parameters.AddWithValue("@今日罐存", Val(jinriguancun.Text))

                objcommand.Parameters.AddWithValue("@昨日罐存", Val(zuoriguancun.Text))

                objcommand.Parameters.AddWithValue("@打尺数", Val(dachishu.Text))

                objcommand.Parameters.AddWithValue("@货物编号", Trim(youwen.Text))

                objcommand.Parameters.AddWithValue("@录入时间", Now)


                '-------------------------------------------------------------------------------------------------------------------------------



                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objcommand.ExecuteNonQuery()
                objconnection.Close()

                MessageBox.Show("数据已经提交", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                showall()


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else


            MessageBox.Show("作业票号不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If

    End Sub

    Private Sub showall()

        objdataAdapter.SelectCommand = New SqlCommand
        objdataAdapter.SelectCommand.Connection = objconnection
        objdataAdapter.SelectCommand.CommandText = "select top 200 * from bonded where 1=1 order by id desc "
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataAdapter.Fill(objdataset, "chuku")

        objdataview = New DataView(objdataset.Tables("chuku"))

        dgv.DataSource = objdataview
        jilushu.Text = "总计:" & objdataview.Count & "笔记录!"
        objconnection.Close()
    End Sub

    Private Sub guanhao_Click(sender As System.Object, e As System.EventArgs) Handles guanhao.Click
        guanhao.Text = ""

    End Sub


    Private Sub youpin_Click(sender As System.Object, e As System.EventArgs) Handles youpin.Click
        youpin.Text = ""
    End Sub

    Private Sub chuanming_Click(sender As System.Object, e As System.EventArgs) Handles chuanming.Click
        chuanming.Text = ""
    End Sub

    Private Sub dianzizhangcehao_Click(sender As System.Object, e As System.EventArgs) Handles dianzizhangcehao.Click
        dianzizhangcehao.Text = ""

    End Sub

    Private Sub chuku_Click(sender As System.Object, e As System.EventArgs) Handles chuku.Click
        chuku.Text = ""

    End Sub

    Private Sub ruku_Click(sender As System.Object, e As System.EventArgs) Handles ruku.Click
        ruku.Text = ""

    End Sub

    Private Sub jinriguancun_Click(sender As System.Object, e As System.EventArgs) Handles jinriguancun.Click
        jinriguancun.Text = ""

    End Sub

    Private Sub zuoriguancun_Click(sender As System.Object, e As System.EventArgs) Handles zuoriguancun.Click
        zuoriguancun.Text = ""

    End Sub

    Private Sub dachishu_Click(sender As System.Object, e As System.EventArgs) Handles dachishu.Click
        dachishu.Text = ""
    End Sub

    Private Sub youwen_Click(sender As System.Object, e As System.EventArgs) Handles youwen.Click
        youwen.Text = ""
    End Sub

    Private Sub ruku_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ruku.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("http://lyg.yihai.com:8501/")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Try

     
        Dim objcommand As New SqlCommand
        objcommand.Connection = objconnection
        objcommand.CommandText = "delete bonded where id = '" & Trim(idid.Text) & "'"


      
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
            MessageBox.Show("已删除!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            showall()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub idid_Click(sender As System.Object, e As System.EventArgs) Handles idid.Click
        idid.Text = ""

    End Sub

    Private Sub 修改保存ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 修改保存ToolStripMenuItem.Click
        Dim SCB As SqlCommandBuilder = New SqlCommandBuilder(objdataAdapter)

        objdataAdapter.Update(objdataset.Tables("chuku"))

        Dim objcommand As New SqlCommand
        MessageBox.Show("提醒完毕")
        showall()

    End Sub
End Class