Imports System.Data.SqlClient
Imports System.Data
Public Class Users
    Dim sr As New Integer
    Dim srf As New Integer

    Dim forreport As New SqlDataAdapter



    Dim objdataadapter As New SqlDataAdapter


    Dim objdataview As New DataView
    Dim objdataset As New DataSet

    Private Sub Users_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        MDIMain.GP.Visible = True
    End Sub
    Private Sub Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain
        MDIMain.GP.Visible = False
        filldatasetandview()
        bindfields()
     
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
        dgv.DataSource = objdataview
        dgv.Columns(2).Visible = False
        objconnection.Close()

    End Sub
    Private Sub bindfields()

        '  Try



        If objdataview.Count > 0 Then


            TextBox115.DataBindings.Clear()
            TextBox114.DataBindings.Clear()
            TextBox113.DataBindings.Clear()
            station.DataBindings.Clear()

            c6.DataBindings.Clear()
            c7.DataBindings.Clear()
            c5.DataBindings.Clear()
            c4.DataBindings.Clear()
            c2.DataBindings.Clear()
            c1.DataBindings.Clear()
            c8.DataBindings.Clear()
            c3.DataBindings.Clear()
            c9.DataBindings.Clear()
            c10.DataBindings.Clear()
            c11.DataBindings.Clear()





            TextBox115.DataBindings.Add("text", objdataview, "id")
            TextBox114.DataBindings.Add("text", objdataview, "username")
            TextBox113.DataBindings.Add("text", objdataview, "password")
            station.DataBindings.Add("text", objdataview, "station")

            c1.DataBindings.Add("checked", objdataview, "module1")
            c2.DataBindings.Add("checked", objdataview, "module2")
            c3.DataBindings.Add("checked", objdataview, "module3")
            c4.DataBindings.Add("checked", objdataview, "module4")
            c5.DataBindings.Add("checked", objdataview, "module5")
            c6.DataBindings.Add("checked", objdataview, "module6")
            c7.DataBindings.Add("checked", objdataview, "module7")

            c8.DataBindings.Add("checked", objdataview, "module8")

            c9.DataBindings.Add("checked", objdataview, "module9")
            c10.DataBindings.Add("checked", objdataview, "module10")
            c11.DataBindings.Add("checked", objdataview, "module11")
        End If

        ' Catch ex As Exception
        ' MessageBox.Show(ex.Message)


        ' End Try

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

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from users where username = '" & Trim(changepassword.Text) & "' and password ='" & Trim(TextBox1.Text) & "'"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "users")
        forreport = objdataadapter '供打印使用
        objdataview = New DataView(objdataset.Tables("users"))

        If objdataview.Count > 0 Then
            Dim objcommand0 As New SqlCommand
            objcommand0.Connection = objconnection
            objcommand0.CommandText = "update users set password = '" & Trim(TextBox3.Text) & "' where username ='" & Trim(changepassword.Text) & "'"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objcommand0.ExecuteNonQuery()

            MessageBox.Show("修改成功!", "提示")


        Else
            MessageBox.Show("您的旧密码不正确!")
            Me.Close()
        End If




        objconnection.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox113.Text.Length > 0 Then

            Dim objcommand0 As New SqlCommand
            objcommand0.Connection = objconnection
            objcommand0.CommandText = "update users set module1=0,module2=0,module3=0,module4=0,module5=0,module6=0,module7=0,module8=0,module9=0,module10=0,module11=0 where id=" & Val(TextBox115.Text)
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



            If c1.Checked = True Then '油品密度维护
                Dim objcommand As New SqlCommand
                objcommand.Connection = objconnection
                objcommand.CommandText = "update users set module1 = 1 where id=" & Val(TextBox115.Text)
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommand.ExecuteNonQuery()
                objconnection.Close()
            End If



            If c2.Checked = True Then '油品更改提醒
                Dim objcommand As New SqlCommand
                objcommand.Connection = objconnection
                objcommand.CommandText = "update users set module2 = 1 where id=" & Val(TextBox115.Text)
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommand.ExecuteNonQuery()
                objconnection.Close()
            End If




            If c3.Checked = True Then '用户管理设置
                Dim objcommand As New SqlCommand
                objcommand.Connection = objconnection
                objcommand.CommandText = "update users set module3 = 1 where id=" & Val(TextBox115.Text)
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommand.ExecuteNonQuery()
                objconnection.Close()
            End If

            If c4.Checked = True Then  '汇总报表
                Dim objcommand As New SqlCommand
                objcommand.Connection = objconnection
                objcommand.CommandText = "update users set module4 = 1 where id=" & Val(TextBox115.Text)
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommand.ExecuteNonQuery()
                objconnection.Close()
            End If


            If c5.Checked = True Then '其他设置
                Dim objcommand As New SqlCommand
                objcommand.Connection = objconnection
                objcommand.CommandText = "update users set module5 = 1 where id=" & Val(TextBox115.Text)
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommand.ExecuteNonQuery()
                objconnection.Close()
            End If



            If c6.Checked = True Then      '用户管理
                Dim objcommand As New SqlCommand
                objcommand.Connection = objconnection
                objcommand.CommandText = "update users set module6 = 1 where id=" & Val(TextBox115.Text)
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommand.ExecuteNonQuery()
                objconnection.Close()
            End If


            If C7.Checked = True Then      '用户管理
                Dim objcommand As New SqlCommand
                objcommand.Connection = objconnection
                objcommand.CommandText = "update users set module7 = 1 where id=" & Val(TextBox115.Text)
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommand.ExecuteNonQuery()
                objconnection.Close()
            End If



      



            If c8.Checked = True Then      '主表数据查询
                Dim objcommand As New SqlCommand
                objcommand.Connection = objconnection
                objcommand.CommandText = "update users set module8 = 1 where id=" & Val(TextBox115.Text)
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommand.ExecuteNonQuery()
                objconnection.Close()
            End If



            If c9.Checked = True Then      '主表数据查询
                Dim objcommand As New SqlCommand
                objcommand.Connection = objconnection
                objcommand.CommandText = "update users set module9 = 1 where id=" & Val(TextBox115.Text)
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommand.ExecuteNonQuery()
                objconnection.Close()
            End If


            If c10.Checked = True Then      '主表数据查询
                Dim objcommand As New SqlCommand
                objcommand.Connection = objconnection
                objcommand.CommandText = "update users set module10 = 1 where id=" & Val(TextBox115.Text)
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommand.ExecuteNonQuery()
                objconnection.Close()
            End If


            If c11.Checked = True Then      '主表数据查询
                Dim objcommand As New SqlCommand
                objcommand.Connection = objconnection
                objcommand.CommandText = "update users set module11 = 1 where id=" & Val(TextBox115.Text)
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommand.ExecuteNonQuery()
                objconnection.Close()
            End If






            MessageBox.Show("密码以及权限全部设置完毕!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            filldatasetandview()
            bindfields()
            dgv.DataSource = objdataview
        Else

            MessageBox.Show("密码不能为空!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If



    End Sub
End Class