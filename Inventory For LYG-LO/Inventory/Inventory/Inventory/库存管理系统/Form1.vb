Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class Form1
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Dim jieguo As Single

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ygbh.AutoCompleteMode = AutoCompleteMode.Suggest
        ygbh.AutoCompleteSource = AutoCompleteSource.ListItems
       
    End Sub

    Private Sub ssgq_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kuqu.SelectedIndexChanged
        addpinming()

    End Sub
    Private Sub addpinming()


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct(罐号名称) from midu where (len(罐号名称)>0) and (所属罐区='" & kuqu.Text & "')"




        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "mission")

        objdataview = New DataView(objdataset.Tables("mission"))

        ' MessageBox.Show(objdataview.Count)
        ygbh.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                ygbh.Items.Add(objdataview.Item(a).Item("罐号名称"))


            Next
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MyService As New for_oil_store.For_Oil_StoreSoapClient
        If Len(yw.Text) > 0 And Len(gd.Text) > 0 And Len(qw.Text) > 0 Then

            Try


                'Dim objcommand As New SqlCommand
                'objcommand.Connection = objconnection
                'objcommand.CommandText = "update GQPD set 删除标志=1 where 油罐编号 = '" & Trim(ygbh.Text) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

                'If objconnection.State = ConnectionState.Closed Then
                '    objconnection.Open()
                'End If
                'objcommand.ExecuteNonQuery()


                Dim guancunjieguo As Single
                guancunjieguo = MyService.Calculate(Trim(ygbh.Text), Val(gd.Text), Val(yw.Text), Val(qw.Text), Val(Trim(bzmd.Text)), Val(shiwen.Text), Val(bianxi.Text))

                shuliang.Text = Math.Round(guancunjieguo, 2)

                MessageBox.Show("盘点数据已正确提交主数据库!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ''MessageBox.Show(guancunjieguo)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End Try
        Else
            MessageBox.Show("关键值不能为空")


        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub



    Private Sub yp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yp.SelectedIndexChanged
   
    End Sub

    Private Sub ygbh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ygbh.SelectedIndexChanged
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料编码,油品名称 from midu where rtrim(ltrim(罐号名称))='" & Trim(ygbh.Text) & "'"



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "ypmd")

        objdataview = New DataView(objdataset.Tables("ypmd"))




        ' MessageBox.Show(objdataview.Count)
        If objdataview.Count >= 1 Then

            yp.Text = objdataview.Item(0).Item("油品名称")
            '' bzmd.Text = objdataview.Item(0).Item("标准密度")
            wlbm.Text = objdataview.Item(0).Item("物料编码")
        End If





        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 标准密度 from midu_wuliaobianma where rtrim(ltrim(物料编码))='" & Trim(wlbm.Text) & "'"



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "mi")

        objdataview = New DataView(objdataset.Tables("mi"))




        ' MessageBox.Show(objdataview.Count)
        If objdataview.Count >= 1 Then

            bzmd.Text = objdataview.Item(0).Item("标准密度")

        End If

        '---------------------------------------------------------------------------------
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 标准密度 from midu_wuliaobianma where rtrim(ltrim(物料编码))='" & Trim(wlbm.Text) & "'"



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "mi")

        objdataview = New DataView(objdataset.Tables("mi"))




        ' MessageBox.Show(objdataview.Count)
        If objdataview.Count >= 1 Then

            bzmd.Text = objdataview.Item(0).Item("标准密度")

        End If


    End Sub

    Private Sub gd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles gd.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If

    End Sub

   
    Private Sub yw_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles yw.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If

    End Sub

    Private Sub qw_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles qw.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If

    End Sub

  
    Private Sub yqhl_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles yqhl.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If

    End Sub

   
    Private Sub TextBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dian.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles shui.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If
    End Sub

    Private Sub TextBox8_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles kongqi.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles danqi.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles zhengqi.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim objcommand As New SqlCommand


        objcommand.Connection = objconnection
        objcommand.CommandText = "delete store_guanqu where 油罐编号='" & Trim(ygbh.Text) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()





        objcommand.Connection = objconnection
        objcommand.CommandText = "insert into store_guanqu (罐号,密度,船名,物料编码,数量,业务类型1,业务类型2,油高,氧气含量,倒入罐号,油温,油温入罐日期,气温,车间名称,试温,库区,蒸汽,氮气,空气,水,电,操作人员,操作时间,昨日数量,昨日氧气含量,昨日油温,时间分组值) values (@罐号,@密度,@船名,@物料编码,@数量,@业务类型1,@业务类型2,@油高,@氧气含量,@倒入罐号,@油温,@油温入罐日期,@气温,@车间名称,@试温,@库区,@蒸汽,@氮气,@空气,@水,@电,@操作人员,@操作时间,@昨日数量,@昨日氧气含量,@昨日油温,@时间分组值)"
        objcommand.Parameters.AddWithValue("@罐号", Trim(ygbh.Text))
        objcommand.Parameters.AddWithValue("@物料编码", Trim(wlbm.Text))


        objcommand.Parameters.AddWithValue("@密度", Val(bzmd.Text))
        objcommand.Parameters.AddWithValue("@船名", Trim(cm.Text))
        objcommand.Parameters.AddWithValue("@数量", Val(shuliang.Text))

        objcommand.Parameters.AddWithValue("@业务类型1", Trim(ywlx1.Text))
        objcommand.Parameters.AddWithValue("@业务类型2", Trim(ywlx2.Text))
        objcommand.Parameters.AddWithValue("@油高", Val(gd.Text))
        objcommand.Parameters.AddWithValue("@氧气含量", Val(yqhl.Text))
        objcommand.Parameters.AddWithValue("@倒入罐号", Trim(drgh.Text))

        objcommand.Parameters.AddWithValue("@油温", Val(yw.Text))
        objcommand.Parameters.AddWithValue("@油温入罐日期", dt1.Value)
        objcommand.Parameters.AddWithValue("@气温", Val(qw.Text))

        objcommand.Parameters.AddWithValue("@车间名称", Trim(cjmc.Text))
        objcommand.Parameters.AddWithValue("@试温", Val(shiwen.Text))
        objcommand.Parameters.AddWithValue("@库区", Trim(kuqu.Text))

        objcommand.Parameters.AddWithValue("@蒸汽", Val(zhengqi.Text))
        objcommand.Parameters.AddWithValue("@氮气", Val(danqi.Text))
        objcommand.Parameters.AddWithValue("@空气", Val(kongqi.Text))
        objcommand.Parameters.AddWithValue("@水", Val(shui.Text))
        objcommand.Parameters.AddWithValue("@电", Val(dian.Text))

        objcommand.Parameters.AddWithValue("@昨日打尺", Val(zrdc.Text))
        objcommand.Parameters.AddWithValue("@昨日油温", Val(zryw.Text))
        objcommand.Parameters.AddWithValue("@昨日含氧", Val(zrhy.Text))

        objcommand.Parameters.AddWithValue("@盘点人员", Val(pdry.Text))
        objcommand.Parameters.AddWithValue("@操作时间", Now)
        objcommand.Parameters.AddWithValue("@时间分组值", Now.Date.ToString("yyyyMMdd"))
    






        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()






        objconnection.Close()
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kongqi.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim qianyitian As String
        qianyitian = Now.AddDays(-1).ToString("yyyyMMdd")
        MessageBox.Show(qianyitian)

    End Sub
End Class