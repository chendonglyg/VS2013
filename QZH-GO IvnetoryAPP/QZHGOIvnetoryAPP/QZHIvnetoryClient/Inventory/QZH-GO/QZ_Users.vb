Imports System.Data.SqlClient
Imports System.Data
Public Class QZ_Users
    Dim sr As New Integer
    Dim srf As New Integer

    Dim forreport As New SqlDataAdapter



    Dim objdataadapter As New SqlDataAdapter


    Dim objdataview As New DataView
    Dim objdataset As New DataSet


    Private Sub Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.MdiParent = MDIMain

        filldatasetandview()
        bindfields()
        dgv.AllowUserToAddRows = False

    End Sub


    Private Sub filldatasetandview()
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from QZ_InventoryUsers  "

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "InventoryUsers")
        forreport = objdataadapter '����ӡʹ��
        objdataview = New DataView(objdataset.Tables("InventoryUsers"))
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






            TextBox115.DataBindings.Add("text", objdataview, "id")
            TextBox114.DataBindings.Add("text", objdataview, "username")
            TextBox113.DataBindings.Add("text", objdataview, "password")
            station.DataBindings.Add("text", objdataview, "station")


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
            Button3.Text = "�������û�"
            TextBox115.Text = ""
            TextBox114.Text = ""
            TextBox113.Text = ""

        Else



            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from QZ_InventoryUsers where username = '" & Trim(TextBox114.Text) & "'"

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "QZ_InventoryUsers")
            forreport = objdataadapter '����ӡʹ��
            objdataview = New DataView(objdataset.Tables("QZ_InventoryUsers"))

            If objdataview.Count > 0 Then


                MessageBox.Show("�û������ظ�!!", "����", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                If (TextBox114.Text.Length > 0) And (TextBox113.Text.Length > 0) Then
                    Dim objcommand As New SqlCommand
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objcommand.Connection = objconnection
                    objcommand.CommandText = "insert into QZ_InventoryUsers (username,password,station,ע��ʱ��) values (@username,@password,@station,@ע��ʱ��) "

                    Dim hm As New Date
                    hm = Now
                    hm.ToString("yyyy/MM/dd")

                    objcommand.Parameters.AddWithValue("@username", Trim(TextBox114.Text))

                    objcommand.Parameters.AddWithValue("@password", Trim(TextBox113.Text))
                    objcommand.Parameters.AddWithValue("@station", Trim(station.Text))


                    objcommand.Parameters.AddWithValue("@ע��ʱ��", hm.Date)


                    objcommand.ExecuteNonQuery()

                    MessageBox.Show("�������!", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If

                    filldatasetandview()
                    bindfields()
                    dgv.DataSource = objdataview

                    dgv.Enabled = True
                    Button3.Text = "�����û�"
                    TextBox114.Enabled = False
                Else
                    MessageBox.Show("Username����Password����Ϊ��", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                End If


            End If







        End If


    End Sub

 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from QZ_InventoryUsers where username = '" & Trim(changepassword.Text) & "' and password ='" & Trim(TextBox1.Text) & "'"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "QZ_InventoryUsers")
        forreport = objdataadapter '����ӡʹ��
        objdataview = New DataView(objdataset.Tables("QZ_InventoryUsers"))

        If objdataview.Count > 0 Then
            Dim objcommand0 As New SqlCommand
            objcommand0.Connection = objconnection
            objcommand0.CommandText = "update QZ_InventoryUsers set password = '" & Trim(TextBox3.Text) & "' where username ='" & Trim(changepassword.Text) & "'"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objcommand0.ExecuteNonQuery()

            MessageBox.Show("�޸ĳɹ�!", "��ʾ")


        Else
            MessageBox.Show("���ľ����벻��ȷ!")
            Me.Close()
        End If




        objconnection.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox113.Text.Length > 0 Then

            Dim objcommandpassword As New SqlCommand
            objcommandpassword.Connection = objconnection
            objcommandpassword.CommandText = "update QZ_InventoryUsers set  password=@password where id=" & Val(TextBox115.Text)
            objcommandpassword.Parameters.AddWithValue("@password", Trim(TextBox113.Text))
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objcommandpassword.ExecuteNonQuery()
            objconnection.Close()
            MessageBox.Show("�����Ѹ���!", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            filldatasetandview()
            bindfields()
            dgv.DataSource = objdataview
        Else

            MessageBox.Show("���벻��Ϊ��!!", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If

    End Sub


    Private Sub isShow_Click(sender As Object, e As EventArgs) Handles isShow.Click

        TextBox113.UseSystemPasswordChar = False


    End Sub

End Class