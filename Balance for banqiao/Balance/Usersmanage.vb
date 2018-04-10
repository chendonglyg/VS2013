Imports System.Data.SqlClient
Imports System.Data
Imports System.Text.RegularExpressions
Public Class USERMANAGE
    Dim sr As New Integer
    Dim srf As New Integer

    Dim forreport As New SqlDataAdapter



    Dim objdataadapter As New SqlDataAdapter


    Dim objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub USERMANAGE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainA.Close()
        'Me.MdiParent = MDIParent1

        filldatasetandview()
        bindfields()
        dgv.DataSource = objdataview
        dgv.Columns(2).Visible = False
    End Sub
    Private Sub filldatasetandview()
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from users  "

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "users")
        forreport = objdataadapter '供打印使用
        objdataview = New DataView(objdataset.Tables("users"))

        objconnection.Close()

    End Sub
    Private Sub bindfields()

        Try



            If objdataview.Count > 0 Then


                TextBox115.DataBindings.Clear()
                TextBox114.DataBindings.Clear()
                TextBox113.DataBindings.Clear()

                station.DataBindings.Clear()
                xitongmokuai.DataBindings.Clear()
                guobangjiemian.DataBindings.Clear()
                kuchangguanli.DataBindings.Clear()
                yikuguanli.DataBindings.Clear()
                huizongbaobiao.DataBindings.Clear()
                qitashezhi.DataBindings.Clear()
                yonghuguanli.DataBindings.Clear()
                buda.DataBindings.Clear()
                zhubiaochaxun.DataBindings.Clear()
                pizhongshanchu.DataBindings.Clear()






                TextBox115.DataBindings.Add("text", objdataview, "id")
                TextBox114.DataBindings.Add("text", objdataview, "username")
                TextBox113.DataBindings.Add("text", objdataview, "password")
                station.DataBindings.Add("text", objdataview, "station")
                xitongmokuai.DataBindings.Add("checked", objdataview, "privilage")

                guobangjiemian.DataBindings.Add("checked", objdataview, "module1")
                kuchangguanli.DataBindings.Add("checked", objdataview, "module2")
                yikuguanli.DataBindings.Add("checked", objdataview, "module3")
                huizongbaobiao.DataBindings.Add("checked", objdataview, "module4")
                qitashezhi.DataBindings.Add("checked", objdataview, "module5")
                yonghuguanli.DataBindings.Add("checked", objdataview, "module6")
                buda.DataBindings.Add("checked", objdataview, "module7")

                zhubiaochaxun.DataBindings.Add("checked", objdataview, "module8")

                pizhongshanchu.DataBindings.Add("checked", objdataview, "module9")


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox114.Enabled = False Then
            TextBox115.DataBindings.Clear()
            TextBox114.DataBindings.Clear()
            TextBox113.DataBindings.Clear()




            TextBox114.Enabled = True

            dgv.Enabled = False
            Button3.Text = "保存新用户"
            TextBox115.Text = ""
            TextBox114.Text = ""
            TextBox113.Text = ""

        Else



            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from users where username = '" & Trim(TextBox114.Text) & "'"

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "users")
            forreport = objdataadapter '供打印使用
            objdataview = New DataView(objdataset.Tables("users"))

            If objdataview.Count > 0 Then


                MessageBox.Show("用户名有重复!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                If (TextBox114.Text.Length > 0) And (TextBox113.Text.Length > 0) Then
                    Dim objcommand As New SqlCommand
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objcommand.Connection = objconnection
                    objcommand.CommandText = "insert into users (username,password,station,注册时间) values (@username,@password,@station,@注册时间) "

                    Dim hm As New Date
                    hm = Now
                    hm.ToString("yyyy/MM/dd")

                    objcommand.Parameters.AddWithValue("@username", Trim(TextBox114.Text))

                    objcommand.Parameters.AddWithValue("@password", Trim(TextBox113.Text))
                    objcommand.Parameters.AddWithValue("@station", Trim(station.Text))


                    objcommand.Parameters.AddWithValue("@注册时间", hm.Date)


                    objcommand.ExecuteNonQuery()

                    MessageBox.Show("增加完毕!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If

                    filldatasetandview()
                    bindfields()
                    dgv.DataSource = objdataview

                    dgv.Enabled = True
                    Button3.Text = "增加用户"
                    TextBox114.Enabled = False
                Else
                    MessageBox.Show("Username或者Password不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                End If


            End If







        End If





    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox115.Text.Length > 0 Then
            Dim objcommand As New SqlCommand
            objcommand.Connection = objconnection
            objcommand.CommandText = "delete from users where id=" & Val(TextBox115.Text)
            objconnection.Open()

            objcommand.ExecuteNonQuery()

            MessageBox.Show("删除完毕!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            objconnection.Close()

            filldatasetandview()
            bindfields()
            dgv.DataSource = objdataview

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a As Integer
        Dim b, c As Boolean

        b = False
        c = False

        For a = 1 To Len(TextBox113.Text)
            If (Regex.IsMatch(Mid(TextBox113.Text, a, 1), "^[A-Za-z]+$")) Then
                b = True
            ElseIf (Regex.IsMatch(Mid(TextBox113.Text, a, 1), "^\d+$")) Then
                c = True
            End If




        Next

        If (b And c And (Len(TextBox113.Text) >= 6)) Then
            MessageBox.Show(" 已满足数字和字母混合且6位长度！")


            '---------------------------------------------------------------------------
            MainA.Close()
            If TextBox113.Text.Length > 0 Then

                Dim objcommand0 As New SqlCommand
                objcommand0.Connection = objconnection
                objcommand0.CommandText = "update users set module1=0,module2=0,module3=0,module4=0,module5=0,module6=0,module7=0,module8=0,module9=0,module10=0,module11=0,module12=0,module13=0,module14=0,module15=0,module16=0,module17=0,module18=0,module19=0,privilage=0 where id=" & Val(TextBox115.Text)
                objconnection.Open()
                objcommand0.ExecuteNonQuery()
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If



                Dim objcommandpassword As New SqlCommand
                objcommandpassword.Connection = objconnection
                objcommandpassword.CommandText = "update users set  password=@password where id=" & Val(TextBox115.Text)
                objcommandpassword.Parameters.AddWithValue("@password", Trim(TextBox113.Text))
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommandpassword.ExecuteNonQuery()
                objconnection.Close()




                objcommandpassword.Connection = objconnection
                objcommandpassword.CommandText = "update users set  station=@station where id=" & Val(TextBox115.Text)
                objcommandpassword.Parameters.AddWithValue("@station", Trim(station.Text))
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommandpassword.ExecuteNonQuery()
                objconnection.Close()



                If guobangjiemian.Checked = True Then '过磅界面
                    Dim objcommand As New SqlCommand
                    objcommand.Connection = objconnection
                    objcommand.CommandText = "update users set module1 = 1 where id=" & Val(TextBox115.Text)
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If

                    objcommand.ExecuteNonQuery()
                    objconnection.Close()
                End If



                If kuchangguanli.Checked = True Then '库场管理
                    Dim objcommand As New SqlCommand
                    objcommand.Connection = objconnection
                    objcommand.CommandText = "update users set module2 = 1 where id=" & Val(TextBox115.Text)
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If

                    objcommand.ExecuteNonQuery()
                    objconnection.Close()
                End If




                If yikuguanli.Checked = True Then '移库管理
                    Dim objcommand As New SqlCommand
                    objcommand.Connection = objconnection
                    objcommand.CommandText = "update users set module3 = 1 where id=" & Val(TextBox115.Text)
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If

                    objcommand.ExecuteNonQuery()
                    objconnection.Close()
                End If

                If huizongbaobiao.Checked = True Then  '汇总报表
                    Dim objcommand As New SqlCommand
                    objcommand.Connection = objconnection
                    objcommand.CommandText = "update users set module4 = 1 where id=" & Val(TextBox115.Text)
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If

                    objcommand.ExecuteNonQuery()
                    objconnection.Close()
                End If


                If qitashezhi.Checked = True Then '其他设置
                    Dim objcommand As New SqlCommand
                    objcommand.Connection = objconnection
                    objcommand.CommandText = "update users set module5 = 1 where id=" & Val(TextBox115.Text)
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If

                    objcommand.ExecuteNonQuery()
                    objconnection.Close()
                End If



                If yonghuguanli.Checked = True Then      '用户管理
                    Dim objcommand As New SqlCommand
                    objcommand.Connection = objconnection
                    objcommand.CommandText = "update users set module6 = 1 where id=" & Val(TextBox115.Text)
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If

                    objcommand.ExecuteNonQuery()
                    objconnection.Close()
                End If





                If buda.Checked = True Then      '补打磅单
                    Dim objcommand As New SqlCommand
                    objcommand.Connection = objconnection
                    objcommand.CommandText = "update users set module7 = 1 where id=" & Val(TextBox115.Text)
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If

                    objcommand.ExecuteNonQuery()
                    objconnection.Close()
                End If



                If zhubiaochaxun.Checked = True Then      '主表数据查询
                    Dim objcommand As New SqlCommand
                    objcommand.Connection = objconnection
                    objcommand.CommandText = "update users set module8 = 1 where id=" & Val(TextBox115.Text)
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If

                    objcommand.ExecuteNonQuery()
                    objconnection.Close()
                End If



                If pizhongshanchu.Checked = True Then      '主表数据查询
                    Dim objcommand As New SqlCommand
                    objcommand.Connection = objconnection
                    objcommand.CommandText = "update users set module9 = 1 where id=" & Val(TextBox115.Text)
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If

                    objcommand.ExecuteNonQuery()
                    objconnection.Close()
                End If


                '------------------------------以下是系统模块,用户和最高权限


                If xitongmokuai.Checked = True Then
                    Dim objcommand As New SqlCommand
                    objcommand.Connection = objconnection
                    objcommand.CommandText = "update users set privilage = 1 where id=" & Val(TextBox115.Text)
                    objconnection.Open()
                    objcommand.ExecuteNonQuery()
                    objconnection.Close()
                End If



                '----------------------------------------------------------------10号字段负责判断初始密码是否被修改，False需要需要用户重写，True用户已完成修改初始





                MessageBox.Show("密码以及权限全部设置完毕!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                filldatasetandview()
                bindfields()
                dgv.DataSource = objdataview
            Else

                MessageBox.Show("密码不能为空!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If








        Else
            MessageBox.Show("不满足集团要求")
        End If


      






    End Sub


    Private Sub buda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buda.CheckedChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim objcommand As New SqlCommand
        objcommand.Connection = objconnection
        objcommand.CommandType = CommandType.StoredProcedure
        objcommand.CommandText = "updateusers1000"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If

        objcommand.ExecuteNonQuery()

        MessageBox.Show("已经更新各厂区用户表!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub
End Class
