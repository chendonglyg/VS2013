Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Public Class OFFLINE
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Dim jieguo As Single
    Dim str_conn As String
    Dim localobjconnection As OleDb.OleDbConnection


    Dim a_objdataadapter As New OleDb.OleDbDataAdapter
    '---------------------------------------------
    Dim gaodu, gaodu1, gaodu2, gaodu3 As Single
    Dim youwen, youwen1, youwen2, youwen3 As Single
    Dim qiwen As Single = 18
    Dim guanhao As String = "8051"
    Dim up, down As Single
    '--------------------------------------
    Dim objconnection As New SqlConnection("Data Source= 10.229.56.14,1433;Initial Catalog = inventory;User ID=sa; Password=gz.1234")

    Dim m, cm, mm As Single
    Dim guancun, wenduxishu, miduxishu, temp, xiuzheng, mirong, lirong, haorong, zongrong, tiji As Single

    Private Sub OFFLINE_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        MDIMain.GP.Visible = True
    End Sub
    Private Sub OFFLINE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        jpry.Text = username
        pdry.Text = username
        pdsj.Text = Now

        ''addcombobox() 此处不需要导入任务了，改用全部罐号
        'yp.AutoCompleteMode = AutoCompleteMode.Suggest
        ' yp.AutoCompleteSource = AutoCompleteSource.ListItems

        ygbh.AutoCompleteMode = AutoCompleteMode.Suggest
        ygbh.AutoCompleteSource = AutoCompleteSource.ListItems

        'MessageBox.Show(FormatDateTime(pdsj.Text, DateFormat.ShortDate))

        MDIMain.GP.Visible = False
    End Sub

    Private Sub addpinming()


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct(罐号名称) from midu where (len(罐号名称)>0) and (所属罐区='" & ssgq.Text & "')"




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
    Private Sub addcombobox()


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 罐号 from mission where len(密度)>0 and  CONVERT(varchar(12) , 盘点时间, 112 )='" & Now.Date.ToString("yyyyMMdd") & "'"



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
                ygbh.Items.Add(objdataview.Item(a).Item("罐号"))


            Next
        End If



        'objdataadapter.SelectCommand = New SqlCommand
        'objdataadapter.SelectCommand.Connection = objconnection
        'objdataadapter.SelectCommand.CommandText = "select 物料描述 from wlbm "


        'If objconnection.State = ConnectionState.Closed Then
        '    objconnection.Open()
        'End If
        'objdataset = New DataSet
        'objdataadapter.Fill(objdataset, "yp")

        'objdataview = New DataView(objdataset.Tables("yp"))


        'yp.Items.Clear()
        ''On Error Resume Next
        'If objdataview.Count >= 1 Then
        '    For a = 0 To objdataview.Count - 1
        '        yp.Items.Add(objdataview.Item(a).Item("物料描述"))


        '    Next
        'End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

        '  ' http://218.92.115.4:20822/Service1.asmx
    End Sub

    Private Sub yp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yp.SelectedIndexChanged
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料号 from wlbm where ltrim(rtrim(物料描述)) = '" & Trim(yp.Text) & "'"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "yp")

        objdataview = New DataView(objdataset.Tables("yp"))


        wlbm.Items.Clear()

        If objdataview.Count >= 1 Then

            wlbm.Text = objdataview.Item(0).Item("物料号")

        End If


    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gd.Text = ""
        gd2.Text = ""
        gd3.Text = ""
        yw.Text = ""
        yw2.Text = ""
        yw3.Text = ""
        qw.Text = ""


    End Sub

    Private Sub ssgq_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ssgq.SelectedIndexChanged
        addpinming()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim temp As Integer


        'Dim MyService As New S1.Service1SoapClient
        ' Try




        '    Dim guancunjieguo As Single

        '    If sel_yewei.Checked = True Then
        '        guancunjieguo = MyService.Calculate(Val(gd2.Text), Val(gd3.Text), Val(yw2.Text), Val(yw3.Text), Trim(yp.Text), Trim(wlbm.Text), Trim(username), Trim(username), Trim(ssgq.Text), Trim(bzxx.Text), Trim(ygbh.Text), Val(gd.Text), Val(yw.Text), Val(qw.Text), Val(Trim(bzmd.Text)), Val(bzwd.Text), Val(bhxs.Text))
        '        MessageBox.Show("盘点数据已正确提交主数据库!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    ElseIf sel_chidu.Checked = True Then
        '        guancunjieguo = MyService.Calculate(Val(gg.Text) - Val(cd3.Text) + Val(cd4.Text), Val(gg.Text) - Val(cd5.Text) + Val(cd6.Text), Val(yw2.Text), Val(yw3.Text), Trim(yp.Text), Trim(wlbm.Text), Trim(username), Trim(username), Trim(ssgq.Text), Trim(bzxx.Text), Trim(ygbh.Text), Val(gg.Text) - Val(cd1.Text) + Val(cd2.Text), Val(yw.Text), Val(qw.Text), Val(Trim(bzmd.Text)), Val(bzwd.Text), Val(bhxs.Text))
        '        MessageBox.Show("盘点数据已正确提交主数据库!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Else
        '        MessageBox.Show("必须选择并填写一种打尺高度参数", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    End If





        '--------------------------------------------------------------------------------------以上是联机版


        guanhao = Trim(ygbh.Text)
        '高度分两类
        If sel_yewei.Checked = True Then
            gaodu1 = Val(gd.Text)
            gaodu2 = Val(gd2.Text)
            gaodu3 = Val(gd3.Text)
            gaodu = (Val(gd.Text) + Val(gd2.Text) + Val(gd3.Text)) / 3

        ElseIf sel_chidu.Checked = True Then
            gaodu1 = Val(gg.Text) - Val(cd1.Text) + Val(cd2.Text)
            gaodu2 = Val(gg.Text) - Val(cd3.Text) + Val(cd4.Text)
            gaodu3 = Val(gg.Text) - Val(cd5.Text) + Val(cd6.Text)

            gaodu = (Val(gg.Text) - Val(cd3.Text) + Val(cd4.Text) + Val(gg.Text) - Val(cd5.Text) + Val(cd6.Text) + Val(gg.Text) - Val(cd1.Text) + Val(cd2.Text)) / 3
        Else
            MessageBox.Show("必须选择并填写一种打尺高度参数", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GoTo err
        End If







        youwen = (Val(yw.Text) + Val(yw2.Text) + Val(yw3.Text)) / 3

        qiwen = Val(qw.Text)


        Select Case Trim(ygbh.Text)

            Case "TK101"

                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ101.mdb;Persist Security Info=False;")

            Case "TK104"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ104.mdb;Persist Security Info=False;")

            Case "TK105"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ105.mdb;Persist Security Info=False;")
            Case "TK106"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ106.mdb;Persist Security Info=False;")
            Case "TK107"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ107.mdb;Persist Security Info=False;")

            Case "TK202"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ202.mdb;Persist Security Info=False;")

            Case "TK203"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ203.mdb;Persist Security Info=False;")
            Case "TK205"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ205.mdb;Persist Security Info=False;")
            Case "TK206"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ206.mdb;Persist Security Info=False;")

            Case "TK207"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ207.mdb;Persist Security Info=False;")
            Case "TK209"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ209.mdb;Persist Security Info=False;")

            Case "TK217"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ217.mdb;Persist Security Info=False;")

            Case "TK218"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ218.mdb;Persist Security Info=False;")

            Case "TK219"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ219.mdb;Persist Security Info=False;")
            Case "TK220"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ220.mdb;Persist Security Info=False;")
            Case "TK221"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ221.mdb;Persist Security Info=False;")
            Case "TK222"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ222.mdb;Persist Security Info=False;")
            Case "TK223"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ223.mdb;Persist Security Info=False;")
            Case "TK224"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ224.mdb;Persist Security Info=False;")
            Case "TK225"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ225.mdb;Persist Security Info=False;")
            Case "TK226"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ226.mdb;Persist Security Info=False;")
            Case "TK301"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ301.mdb;Persist Security Info=False;")

            Case "TK302"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ302.mdb;Persist Security Info=False;")
            Case "TK303"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ303.mdb;Persist Security Info=False;")
            Case "TK304"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ304.mdb;Persist Security Info=False;")

            Case "TK305"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ305.mdb;Persist Security Info=False;")
            Case "TK801"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ801.mdb;Persist Security Info=False;")
            Case "TK802"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ802.mdb;Persist Security Info=False;")
            Case "TK1217"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ1217.mdb;Persist Security Info=False;")
            Case "TK1304"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZ1304.mdb;Persist Security Info=False;")
            Case "R8"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZR8.mdb;Persist Security Info=False;")
            Case "R10"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZR10.mdb;Persist Security Info=False;")
            Case "R11"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZR11.mdb;Persist Security Info=False;")
            Case "R12"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZR12.mdb;Persist Security Info=False;")

            Case "R13"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZR13.mdb;Persist Security Info=False;")
            Case "R14"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZR14.mdb;Persist Security Info=False;")
            Case "R15"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZR15.mdb;Persist Security Info=False;")
            Case "R16"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZR16.mdb;Persist Security Info=False;")
            Case "R17"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZR17.mdb;Persist Security Info=False;")
            Case "R18"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZR18.mdb;Persist Security Info=False;")
            Case "R19"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZR19.mdb;Persist Security Info=False;")
            Case "R20"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZR20.mdb;Persist Security Info=False;")
            Case "R21"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZR21.mdb;Persist Security Info=False;")
            Case "R22"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZR22.mdb;Persist Security Info=False;")
            Case "R25"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZR25.mdb;Persist Security Info=False;")
            Case "R2"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\GZR2.mdb;Persist Security Info=False;")
            Case Else

        End Select


        '----------------------------------------------------------------------------------------后添加

        localobjconnection = New OleDb.OleDbConnection(str_conn)


        If gaodu = 0 Then
            m = 0
            cm = 0
            mm = 0
            guancun = 0


        End If



        wenduxishu = 1 + (youwen - 20) * 0.000036
        miduxishu = Val(bzmd.Text) - (youwen - Val(bzwd.Text)) * Val(bhxs.Text) - 0.0011


        mirong = gaodu




        temp = mirong * 100
        temp = Int(temp)
        m = temp / 100

        a_objdataadapter.SelectCommand = New OleDb.OleDbCommand
        a_objdataadapter.SelectCommand.Connection = localobjconnection
        a_objdataadapter.SelectCommand.CommandText = "select * from zhengshu where m= " & m
      
        objdataset = New DataSet
        a_objdataadapter.Fill(objdataset, "m")
        objdataview = New DataView(objdataset.Tables("m"))

        If objdataview.Count >= 1 Then
            mirong = objdataview.Item(0).Row("米容") '有数据
        Else
            mirong = 0
        End If



        '--------------------------------------------------------------------------------------------------------------------------


        '开始查询毫米容量
        temp = gaodu * 1000
        temp = Int(temp) Mod 10
        mm = temp


        a_objdataadapter.SelectCommand = New OleDb.OleDbCommand
        a_objdataadapter.SelectCommand.Connection = localobjconnection
        a_objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
        If localobjconnection.State = ConnectionState.Closed Then
            localobjconnection.Open()
        End If
        objdataset = New DataSet
        a_objdataadapter.Fill(objdataset, "mm")
        objdataview = New DataView(objdataset.Tables("mm"))




        '----------------------
        Select Case guanhao

            Case "TK101"


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.078
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.079 To 0.228
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.229 To 0.328
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 0.329 To 0.336
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 0.337 To 0.773
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 0.774 To 1.394
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 1.395 To 2.576
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 2.577 To 2.898
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 2.899 To 4.401
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.402 To 5.905
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.906 To 7.409
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 7.41 To 8.914
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 8.915 To 10.418
                            haorong = objdataview.Item(0).Row("毫米13")


                        Case 10.419 To 11.921
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 11.922 To 13.424
                            haorong = objdataview.Item(0).Row("毫米15")


                        Case 13.425 To 14.324
                            haorong = objdataview.Item(0).Row("毫米16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



                '-------------------------------------------------------------



            Case "TK104"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.087
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.088 To 0.397
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.398 To 1.147
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.148 To 1.468
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.469 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.968
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.969 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.468
                            haorong = objdataview.Item(0).Row("毫米8")
                        Case 4.469 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.968
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.969 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6.0 To 7.468
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.469 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")


                        Case 7.5 To 8.968
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.969 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 9.0 To 10.468
                            haorong = objdataview.Item(0).Row("毫米16")
                        Case 10.469 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")
                        Case 10.5 To 11.968
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 11.969 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")
                        Case 12.0 To 13.468
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 13.469 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")
                        Case 13.5 To 14.57
                            haorong = objdataview.Item(0).Row("毫米22")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK105"


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.181
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.182 To 0.271
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.272 To 1.151
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.152 To 1.471
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.472 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.971
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.972 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.471
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.472 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.971
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.972 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6.0 To 7.471
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.472 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")


                        Case 7.5 To 8.971
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.972 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")


                        Case 9.0 To 10.471
                            haorong = objdataview.Item(0).Row("毫米16")
                        Case 10.472 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")
                        Case 10.5 To 11.971
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 11.972 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")
                        Case 12 To 13.471
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 13.472 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")
                        Case 13.5 To 14.571
                            haorong = objdataview.Item(0).Row("毫米22")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "TK106"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.168
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.169 To 0.258
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.259 To 1.138
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.139 To 1.458
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.459 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.958
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.959 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.458
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.459 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.958
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.959 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.458
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.459 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")


                        Case 7.5 To 8.958
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.959 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")


                        Case 9.0 To 10.458
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.459 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")
                        Case 19.5 To 11.958
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 11.959 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")
                        Case 12 To 13.458
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 13.459 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")
                        Case 13.5 To 14.558
                            haorong = objdataview.Item(0).Row("毫米22")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK107"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.0 To 0.096
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.097 To 0.276
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.277 To 1.156
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.157 To 1.476
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.477 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.973
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.974 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.469
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.47 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.967
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.968 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.466
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.467 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")


                        Case 7.5 To 8.961
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.962 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")
                        Case 9.0 To 10.457
                            haorong = objdataview.Item(0).Row("毫米16")
                        Case 10.458 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")
                        Case 10.5 To 11.957
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 11.958 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")
                        Case 12 To 13.457
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 13.458 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")
                        Case 13.5 To 14.545
                            haorong = objdataview.Item(0).Row("毫米22")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


                '----------------------------------------------------------------------------
            Case "TK202"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.135
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.136 To 0.255
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.256 To 1.135
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.136 To 1.448
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.449 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.946
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.947 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.44
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.441 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.94
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.941 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.438
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.439 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.933
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.934 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 9 To 10.431
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.432 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 10.5 To 11.927
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 11.928 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 12 To 13.419
                            haorong = objdataview.Item(0).Row("毫米20")

                        Case 13.42 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")

                        Case 13.5 To 14.56
                            haorong = objdataview.Item(0).Row("毫米22")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

                '----------------------------------------------------------------------------


            Case "TK203"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.147
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.148 To 0.267
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.268 To 1.147
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.148 To 1.46
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.461 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.959
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.96 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.456
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.457 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.956
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.957 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.452
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.453 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")
                        Case 7.5 To 8.948
                            haorong = objdataview.Item(0).Row("毫米14")
                        Case 8.949 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")
                        Case 9 To 10.443
                            haorong = objdataview.Item(0).Row("毫米16")
                        Case 10.444 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")
                        Case 10.5 To 11.943
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 11.944 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")
                        Case 12 To 13.441
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 13.442 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")
                        Case 13.5 To 14.583
                            haorong = objdataview.Item(0).Row("毫米22")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK205"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.13
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.131 To 0.25
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.251 To 1.13
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.131 To 1.447
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.448 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.947
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.948 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3 To 4.446
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.447 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.941
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.942 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.441
                            haorong = objdataview.Item(0).Row("毫米12")
                        Case 7.442 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")
                        Case 7.5 To 8.938
                            haorong = objdataview.Item(0).Row("毫米14")
                        Case 8.939 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")
                        Case 9 To 10.436
                            haorong = objdataview.Item(0).Row("毫米16")
                        Case 10.437 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")
                        Case 10.5 To 11.934
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 11.935 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")
                        Case 12 To 13.43
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 13.431 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")
                        Case 13.5 To 14.582
                            haorong = objdataview.Item(0).Row("毫米22")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK206"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.14
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.141 To 0.26
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.261 To 1.14
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.141 To 1.452
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.453 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.949
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.95 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3 To 4.444
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.445 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.944
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.945 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.441
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.442 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")


                        Case 7.5 To 8.937
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.938 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")


                        Case 9 To 10.435
                            haorong = objdataview.Item(0).Row("毫米16")


                        Case 10.436 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")
                        Case 10.5 To 11.933
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 11.934 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")
                        Case 12 To 13.431
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 13.432 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")
                        Case 13.5 To 14.572
                            haorong = objdataview.Item(0).Row("毫米22")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK207"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.0 To 0.165
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.166 To 0.285
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.286 To 1.165
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.166 To 1.482
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.483 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.981
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.982 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3 To 4.477
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.478 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.975
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.976 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.472
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.473 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.969
                            haorong = objdataview.Item(0).Row("毫米14")
                        Case 8.97 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")
                        Case 9 To 10.465
                            haorong = objdataview.Item(0).Row("毫米16")
                        Case 10.466 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")
                        Case 10.5 To 11.965
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 11.966 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")
                        Case 12 To 13.463
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 13.464 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")
                        Case 13.5 To 14.605
                            haorong = objdataview.Item(0).Row("毫米22")

                        Case 15 To 16.093
                            haorong = objdataview.Item(0).Row("毫米23")
                        Case 16.094 To 16.499
                            haorong = objdataview.Item(0).Row("毫米24")
                        Case 16.5 To 17.593
                            haorong = objdataview.Item(0).Row("毫米25")
                        Case 17.594 To 17.999
                            haorong = objdataview.Item(0).Row("毫米26")
                        Case 18 To 19.093
                            haorong = objdataview.Item(0).Row("毫米27")
                        Case 19.094 To 19.499
                            haorong = objdataview.Item(0).Row("毫米28")
                        Case 19.5 To 20.593
                            haorong = objdataview.Item(0).Row("毫米29")
                        Case 20.594 To 20.999
                            haorong = objdataview.Item(0).Row("毫米30")
                        Case 21 To 22.093
                            haorong = objdataview.Item(0).Row("毫米31")
                        Case 22.094 To 22.499
                            haorong = objdataview.Item(0).Row("毫米32")
                        Case 22.5 To 23.593
                            haorong = objdataview.Item(0).Row("毫米33")
                        Case 23.594 To 23.999
                            haorong = objdataview.Item(0).Row("毫米34")
                        Case 24 To 25.499
                            haorong = objdataview.Item(0).Row("毫米35")
                        Case 25 To 25.893
                            haorong = objdataview.Item(0).Row("毫米36")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK209"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.0 To 0.172
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.173 To 0.292
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.293 To 1.172
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.173 To 1.483
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.484 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.983
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.984 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3 To 4.482
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.483 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.978
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.979 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.476
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.477 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.976
                            haorong = objdataview.Item(0).Row("毫米14")
                        Case 8.977 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")
                        Case 9 To 10.471
                            haorong = objdataview.Item(0).Row("毫米16")
                        Case 10.472 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")
                        Case 10.5 To 11.967
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 11.968 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")
                        Case 12 To 13.464
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 13.465 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")
                        Case 13.5 To 14.606
                            haorong = objdataview.Item(0).Row("毫米22")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK217"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.0 To 0.184
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.185 To 0.381
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.382 To 1.475
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.476 To 1.499
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.5 To 2.975
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 2.976 To 2.999
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 3 To 4.475
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 4.476 To 4.499
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.5 To 5.975
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 5.976 To 5.999
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 6 To 7.475
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 7.476 To 7.499
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.5 To 8.975
                            haorong = objdataview.Item(0).Row("毫米13")


                        Case 8.976 To 8.999
                            haorong = objdataview.Item(0).Row("毫米14")
                        Case 9 To 10.475
                            haorong = objdataview.Item(0).Row("毫米15")
                        Case 10.476 To 10.499
                            haorong = objdataview.Item(0).Row("毫米16")
                        Case 10.5 To 11.975
                            haorong = objdataview.Item(0).Row("毫米17")
                        Case 11.976 To 11.999
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 12 To 13.475
                            haorong = objdataview.Item(0).Row("毫米19")
                        Case 13.476 To 13.499
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 13.5 To 14.975
                            haorong = objdataview.Item(0).Row("毫米21")
                        Case 14.976 To 14.999
                            haorong = objdataview.Item(0).Row("毫米22")
                        Case 15 To 16.475
                            haorong = objdataview.Item(0).Row("毫米23")
                        Case 16.476 To 16.499
                            haorong = objdataview.Item(0).Row("毫米24")
                        Case 16.5 To 17.975
                            haorong = objdataview.Item(0).Row("毫米25")
                        Case 17.976 To 17.999
                            haorong = objdataview.Item(0).Row("毫米26")
                        Case 18 To 19.475
                            haorong = objdataview.Item(0).Row("毫米27")
                        Case 19.476 To 19.499
                            haorong = objdataview.Item(0).Row("毫米28")
                        Case 19.5 To 20.175
                            haorong = objdataview.Item(0).Row("毫米29")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "TK218"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.0 To 0.187
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.188 To 0.384
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.385 To 1.149
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.15 To 1.467
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.468 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.967
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.968 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3 To 4.467
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.468 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.967
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.968 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.467
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.468 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.967
                            haorong = objdataview.Item(0).Row("毫米14")
                        Case 8.968 To 8.999

                            haorong = objdataview.Item(0).Row("毫米15")
                        Case 9 To 10.467
                            haorong = objdataview.Item(0).Row("毫米16")
                        Case 10.468 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")
                        Case 10.5 To 11.967
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 11.968 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")
                        Case 12 To 13.467
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 13.468 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")
                        Case 13.5 To 14.967
                            haorong = objdataview.Item(0).Row("毫米22")
                        Case 14.968 To 14.999
                            haorong = objdataview.Item(0).Row("毫米23")
                        Case 15 To 16.467
                            haorong = objdataview.Item(0).Row("毫米24")
                        Case 16.468 To 16.499
                            haorong = objdataview.Item(0).Row("毫米25")
                        Case 16.5 To 17.967
                            haorong = objdataview.Item(0).Row("毫米26")
                        Case 17.968 To 17.999
                            haorong = objdataview.Item(0).Row("毫米27")
                        Case 18 To 19.467
                            haorong = objdataview.Item(0).Row("毫米28")
                        Case 19.468 To 19.499
                            haorong = objdataview.Item(0).Row("毫米29")

                        Case 19.5 To 20.167
                            haorong = objdataview.Item(0).Row("毫米30")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK219"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.0 To 0.162
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.163 To 0.359
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.36 To 1.124
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.125 To 1.442
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.443 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.942
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.943 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3 To 4.442
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.443 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.942
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.943 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.442
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.443 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.942
                            haorong = objdataview.Item(0).Row("毫米14")


                        Case 8.943 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")
                        Case 9 To 10.442
                            haorong = objdataview.Item(0).Row("毫米16")
                        Case 10.443 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")
                        Case 10.5 To 11.942
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 11.943 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 12 To 13.442
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 13.443 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")
                        Case 13.5 To 14.942
                            haorong = objdataview.Item(0).Row("毫米22")
                        Case 14.943 To 14.999
                            haorong = objdataview.Item(0).Row("毫米23")
                        Case 15 To 16.442
                            haorong = objdataview.Item(0).Row("毫米24")
                        Case 16.443 To 16.499
                            haorong = objdataview.Item(0).Row("毫米25")
                        Case 16.5 To 17.942
                            haorong = objdataview.Item(0).Row("毫米26")
                        Case 17.943 To 17.999
                            haorong = objdataview.Item(0).Row("毫米27")
                        Case 18 To 19.442
                            haorong = objdataview.Item(0).Row("毫米28")

                        Case 19.443 To 19.499
                            haorong = objdataview.Item(0).Row("毫米29")
                        Case 19.5 To 20.142
                            haorong = objdataview.Item(0).Row("毫米30")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



                '----------------------------------------------------------------------------------------



            Case "TK220"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.0 To 0.182
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.183 To 0.379
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.38 To 1.144
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.145 To 1.465
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.466 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.965
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.966 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3 To 4.465
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.466 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.965
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.966 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.465
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.466 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.965
                            haorong = objdataview.Item(0).Row("毫米14")
                        Case 8.966 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")
                        Case 9 To 10.465
                            haorong = objdataview.Item(0).Row("毫米16")
                        Case 10.466 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")
                        Case 10.5 To 11.965
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 11.966 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 12 To 13.465
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 13.466 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")
                        Case 13.5 To 14.965
                            haorong = objdataview.Item(0).Row("毫米22")
                        Case 14.966 To 14.999
                            haorong = objdataview.Item(0).Row("毫米23")
                        Case 15 To 16.465
                            haorong = objdataview.Item(0).Row("毫米24")
                        Case 16.466 To 16.499
                            haorong = objdataview.Item(0).Row("毫米25")
                        Case 16.5 To 17.965
                            haorong = objdataview.Item(0).Row("毫米26")
                        Case 17.966 To 17.999
                            haorong = objdataview.Item(0).Row("毫米27")

                        Case 18 To 19.465
                            haorong = objdataview.Item(0).Row("毫米28")
                        Case 19.466 To 19.499
                            haorong = objdataview.Item(0).Row("毫米29")
                        Case 19.5 To 20.165
                            haorong = objdataview.Item(0).Row("毫米30")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK221"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.0 To 0.193
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.194 To 0.39
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.391 To 1.155
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.156 To 1.473
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.474 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.973
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.974 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3 To 4.473
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.474 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.973
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.974 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.473
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.474 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.973
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.974 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")
                        Case 9 To 10.473
                            haorong = objdataview.Item(0).Row("毫米16")
                        Case 10.474 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")
                        Case 10.5 To 11.973
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 11.974 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 12 To 13.473
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 13.474 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")
                        Case 13.5 To 14.973
                            haorong = objdataview.Item(0).Row("毫米22")
                        Case 14.974 To 14.999
                            haorong = objdataview.Item(0).Row("毫米23")
                        Case 15 To 16.473
                            haorong = objdataview.Item(0).Row("毫米24")
                        Case 16.474 To 16.499
                            haorong = objdataview.Item(0).Row("毫米25")
                        Case 16.5 To 17.973
                            haorong = objdataview.Item(0).Row("毫米26")
                        Case 17.974 To 17.999
                            haorong = objdataview.Item(0).Row("毫米27")
                        Case 18 To 19.473
                            haorong = objdataview.Item(0).Row("毫米28")

                        Case 19.474 To 19.499
                            haorong = objdataview.Item(0).Row("毫米29")
                        Case 19.5 To 20.173
                            haorong = objdataview.Item(0).Row("毫米30")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK222"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.178
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.179 To 0.375
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.376 To 1.14
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.141 To 1.475
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.476 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.975
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.976 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3 To 4.475
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.476 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.975
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.976 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.475
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.476 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")


                        Case 7.5 To 8.975
                            haorong = objdataview.Item(0).Row("毫米15")
                        Case 8.976 To 8.999
                            haorong = objdataview.Item(0).Row("毫米16")
                        Case 9 To 10.475
                            haorong = objdataview.Item(0).Row("毫米17")
                        Case 10.476 To 10.499
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 10.5 To 11.975
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 11.976 To 11.999
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 12 To 13.475
                            haorong = objdataview.Item(0).Row("毫米21")
                        Case 13.476 To 13.499
                            haorong = objdataview.Item(0).Row("毫米22")
                        Case 13.5 To 14.975
                            haorong = objdataview.Item(0).Row("毫米23")
                        Case 14.976 To 14.999
                            haorong = objdataview.Item(0).Row("毫米24")
                        Case 15 To 16.475
                            haorong = objdataview.Item(0).Row("毫米25")
                        Case 16.476 To 16.499
                            haorong = objdataview.Item(0).Row("毫米26")
                        Case 16.5 To 17.975
                            haorong = objdataview.Item(0).Row("毫米27")
                        Case 17.976 To 17.999
                            haorong = objdataview.Item(0).Row("毫米28")

                        Case 18 To 19.475
                            haorong = objdataview.Item(0).Row("毫米29")
                        Case 19.476 To 19.499
                            haorong = objdataview.Item(0).Row("毫米30")
                        Case 19.5 To 20.175
                            haorong = objdataview.Item(0).Row("毫米31")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "R10"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.0 To 0.421
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.422 To 1.171
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 1.172 To 1.464
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.465 To 1.499
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.5 To 2.963
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 2.964 To 2.999
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 3 To 4.458
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 4.459 To 4.499
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.5 To 5.958
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 5.959 To 5.999
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 6 To 7.455
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 7.456 To 7.499
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.5 To 8.952
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 8.953 To 8.999
                            haorong = objdataview.Item(0).Row("毫米14")


                        Case 9 To 10.45
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 10.451 To 10.499
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.5 To 11.949
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 11.95 To 11.999
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 12 To 13.445
                            haorong = objdataview.Item(0).Row("毫米19")
                        Case 13.446 To 13.499
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 13.5 To 14.587
                            haorong = objdataview.Item(0).Row("毫米21")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "R11"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.0 To 0.417
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.418 To 1.167
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 1.168 To 1.458
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.459 To 1.499
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.5 To 2.956
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 2.957 To 2.999
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 3 To 4.455
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 4.456 To 4.499
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.5 To 5.951
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 5.952 To 5.999
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 6 To 7.451
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 7.452 To 7.499
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.5 To 8.946
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 8.947 To 8.999
                            haorong = objdataview.Item(0).Row("毫米14")


                        Case 9 To 10.442
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 10.443 To 10.499
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.5 To 11.939
                            haorong = objdataview.Item(0).Row("毫米17")
                        Case 11.94 To 11.999
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 12 To 13.436
                            haorong = objdataview.Item(0).Row("毫米19")
                        Case 13.437 To 13.499
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 13.5 To 14.577
                            haorong = objdataview.Item(0).Row("毫米21")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "R12"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.196
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.197 To 0.371
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.372 To 1.454
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.455 To 1.499
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.5 To 2.953
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 2.954 To 2.999
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 3 To 4.448
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 4.449 To 4.499
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.5 To 5.948
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 5.949 To 5.999
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 6 To 7.445
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 7.446 To 7.499
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.5 To 8.942
                            haorong = objdataview.Item(0).Row("毫米13")


                        Case 8.943 To 8.999
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 9 To 10.44
                            haorong = objdataview.Item(0).Row("毫米15")


                        Case 10.441 To 10.499
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.5 To 11.939
                            haorong = objdataview.Item(0).Row("毫米17")
                        Case 11.94 To 11.999
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 12 To 13.435
                            haorong = objdataview.Item(0).Row("毫米19")
                        Case 13.436 To 13.499
                            haorong = objdataview.Item(0).Row("毫米20")

                        Case 13.5 To 14.577
                            haorong = objdataview.Item(0).Row("毫米21")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "R13"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.0 To 0.199
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.2 To 0.374
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.375 To 1.464
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.465 To 1.499
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.5 To 2.964
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 2.965 To 2.999
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 3 To 4.464
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 4.465 To 4.499
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.5 To 5.964
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 5.965 To 5.999
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 6 To 7.464
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 7.465 To 7.499
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.5 To 8.964
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 8.965 To 8.999
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 9 To 10.464
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 10.465 To 10.499
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.5 To 11.964
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 11.965 To 11.999
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 12 To 13.464
                            haorong = objdataview.Item(0).Row("毫米19")
                        Case 13.465 To 13.499
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 13.5 To 14.626
                            haorong = objdataview.Item(0).Row("毫米21")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "TK304"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.189
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.19 To 0.381
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.382 To 1.146
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.147 To 1.466
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.467 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.966
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.967 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.466
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.467 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.966
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.967 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6.0 To 7.466
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.467 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.966
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.967 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 9.0 To 10.466
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.467 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 10.5 To 11.966
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 11.967 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 12.0 To 13.466
                            haorong = objdataview.Item(0).Row("毫米20")

                        Case 13.467 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")

                        Case 13.5 To 14.966
                            haorong = objdataview.Item(0).Row("毫米22")

                        Case 14.967 To 14.999
                            haorong = objdataview.Item(0).Row("毫米23")

                        Case 15.0 To 15.466
                            haorong = objdataview.Item(0).Row("毫米24")

                        Case 15.467 To 16.499
                            haorong = objdataview.Item(0).Row("毫米25")

                        Case 16.5 To 17.966
                            haorong = objdataview.Item(0).Row("毫米26")

                        Case 17.967 To 17.999
                            haorong = objdataview.Item(0).Row("毫米27")

                        Case 18.0 To 19.466
                            haorong = objdataview.Item(0).Row("毫米28")

                        Case 19.467 To 19.499
                            haorong = objdataview.Item(0).Row("毫米29")

                        Case 19.5 To 20.166
                            haorong = objdataview.Item(0).Row("毫米30")





                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK305"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.169
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.17 To 0.359
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.36 To 1.124
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 0.833 To 1.398
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.125 To 1.449
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.45 To 1.499
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 1.5 To 2.949
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 2.95 To 2.999
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 3.0 To 4.449
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.45 To 4.499
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 4.5 To 5.949
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 5.95 To 5.999
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 6.0 To 7.449
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.45 To 7.499
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 7.5 To 8.949
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 8.95 To 8.999
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 9.0 To 10.449
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 10.45 To 10.499
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 10.5 To 11.949
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 11.95 To 11.999
                            haorong = objdataview.Item(0).Row("毫米20")

                        Case 12.0 To 13.449
                            haorong = objdataview.Item(0).Row("毫米21")

                        Case 13.45 To 13.499
                            haorong = objdataview.Item(0).Row("毫米22")

                        Case 13.5 To 14.949
                            haorong = objdataview.Item(0).Row("毫米23")

                        Case 14.95 To 14.999
                            haorong = objdataview.Item(0).Row("毫米24")

                        Case 15.0 To 16.449
                            haorong = objdataview.Item(0).Row("毫米25")

                        Case 16.45 To 16.499
                            haorong = objdataview.Item(0).Row("毫米26")

                        Case 16.5 To 17.949
                            haorong = objdataview.Item(0).Row("毫米27")

                        Case 17.95 To 17.999
                            haorong = objdataview.Item(0).Row("毫米28")

                        Case 18.0 To 19.449
                            haorong = objdataview.Item(0).Row("毫米29")

                        Case 19.45 To 19.499
                            haorong = objdataview.Item(0).Row("毫米30")

                        Case 19.5 To 20.149
                            haorong = objdataview.Item(0).Row("毫米31")





                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK801"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.128
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.129 To 0.193
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.194 To 1.499
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.5 To 2.999
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 3.0 To 3.493
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 3.494 To 4.499
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 4.5 To 5.293
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 5.294 To 5.999
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 6.0 To 7.093
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 7.094 To 7.499
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 7.5 To 8.593
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 8.594 To 8.999
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 9.0 To 10.093
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 10.094 To 10.499
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 10.5 To 11.593
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 11.594 To 11.999
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 12.0 To 13.093
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 13.094 To 13.499
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 13.5 To 14.593
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 14.594 To 14.999
                            haorong = objdataview.Item(0).Row("毫米20")

                        Case 15.0 To 16.093
                            haorong = objdataview.Item(0).Row("毫米21")

                        Case 16.094 To 16.499
                            haorong = objdataview.Item(0).Row("毫米22")

                        Case 16.5 To 17.593
                            haorong = objdataview.Item(0).Row("毫米23")

                        Case 17.594 To 17.999
                            haorong = objdataview.Item(0).Row("毫米24")

                        Case 18.0 To 19.093
                            haorong = objdataview.Item(0).Row("毫米25")

                        Case 19.094 To 19.499
                            haorong = objdataview.Item(0).Row("毫米26")

                        Case 19.5 To 20.593
                            haorong = objdataview.Item(0).Row("毫米27")

                        Case 20.594 To 20.999
                            haorong = objdataview.Item(0).Row("毫米28")

                        Case 21.0 To 22.093
                            haorong = objdataview.Item(0).Row("毫米29")

                        Case 22.094 To 22.499
                            haorong = objdataview.Item(0).Row("毫米30")

                        Case 22.5 To 23.593
                            haorong = objdataview.Item(0).Row("毫米31")

                        Case 23.594 To 23.999
                            haorong = objdataview.Item(0).Row("毫米32")

                        Case 24.0 To 25.499
                            haorong = objdataview.Item(0).Row("毫米33")

                        Case 25.5 To 25.893
                            haorong = objdataview.Item(0).Row("毫米34")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK802"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.112
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.113 To 0.177
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.178 To 1.499
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.5 To 1.677
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.678 To 2.999
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 3.0 To 3.477
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 3.478 To 4.499
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 4.5 To 5.277
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 5.278 To 5.999
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 6.0 To 7.077
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 7.078 To 7.499
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 7.5 To 8.577
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 8.578 To 8.999
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 9.0 To 10.077
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 10.078 To 10.499
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 10.5 To 11.577
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 11.578 To 11.999
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 12.0 To 13.077
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 13.078 To 13.499
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 13.5 To 14.577
                            haorong = objdataview.Item(0).Row("毫米20")

                        Case 14.578 To 14.999
                            haorong = objdataview.Item(0).Row("毫米21")

                        Case 15.0 To 16.077
                            haorong = objdataview.Item(0).Row("毫米22")

                        Case 16.078 To 16.499
                            haorong = objdataview.Item(0).Row("毫米23")

                        Case 16.5 To 17.577
                            haorong = objdataview.Item(0).Row("毫米24")

                        Case 17.578 To 17.999
                            haorong = objdataview.Item(0).Row("毫米25")

                        Case 18.0 To 19.077
                            haorong = objdataview.Item(0).Row("毫米26")

                        Case 19.078 To 19.499
                            haorong = objdataview.Item(0).Row("毫米27")

                        Case 19.5 To 20.577
                            haorong = objdataview.Item(0).Row("毫米28")

                        Case 20.578 To 20.999
                            haorong = objdataview.Item(0).Row("毫米29")

                        Case 21.0 To 22.077
                            haorong = objdataview.Item(0).Row("毫米30")

                        Case 22.078 To 22.499
                            haorong = objdataview.Item(0).Row("毫米31")

                        Case 22.5 To 23.999
                            haorong = objdataview.Item(0).Row("毫米32")

                        Case 24.0 To 25.499
                            haorong = objdataview.Item(0).Row("毫米33")

                        Case 25.5 To 25.877
                            haorong = objdataview.Item(0).Row("毫米34")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK1217"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.215
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.216 To 0.323
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.324 To 0.933
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 0.934 To 1.473
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.474 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.988
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.989 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.499
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.5 To 4.508
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.509 To 5.999
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 6.0 To 6.025
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6.026 To 7.499
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.5 To 7.542
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.543 To 8.999
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 9.0 To 9.062
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 9.063 To 10.077
                            haorong = objdataview.Item(0).Row("毫米16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK1304"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.219
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.22 To 0.319
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.32 To 0.934
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 0.935 To 1.469
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.47 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.969
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.97 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.469
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.47 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.969
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.97 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6.0 To 7.469
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.47 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.969
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.97 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 9.0 To 9.919
                            haorong = objdataview.Item(0).Row("毫米16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "R21"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.223
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.224 To 0.293
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.294 To 1.094
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.095 To 1.443
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.444 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.943
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.944 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.443
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.444 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.943
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.944 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6.0 To 7.443
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.444 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.943
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.944 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 9.0 To 10.443
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.444 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 10.5 To 11.943
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 11.944 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 12.0 To 13.443
                            haorong = objdataview.Item(0).Row("毫米20")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "R22"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.175
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.176 To 0.245
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.246 To 1.046
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.047 To 1.395
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.396 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.895
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.896 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.395
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.396 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.895
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.896 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6.0 To 7.395
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.396 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.895
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.896 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 9.0 To 10.395
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.396 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 10.5 To 11.895
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 11.896 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 12.0 To 13.395
                            haorong = objdataview.Item(0).Row("毫米20")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "R25"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.211
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.212 To 0.311
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.312 To 0.924
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 0.925 To 1.461
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.462 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.961
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.962 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.461
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.462 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.961
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.962 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6.0 To 7.461
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.462 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.961
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.962 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 9.0 To 10.461
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.462 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 10.5 To 11.961
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 11.962 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 12.0 To 13.461
                            haorong = objdataview.Item(0).Row("毫米20")

                        Case 13.462 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")

                        Case 13.5 To 14.623
                            haorong = objdataview.Item(0).Row("毫米22")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "TK223"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.174
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.175 To 0.371
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.372 To 1.136
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.137 To 1.466
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.467 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.966
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.967 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.466
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.467 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.966
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.967 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6.0 To 7.466
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.467 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.966
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.967 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 9.0 To 10.466
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.467 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 10.5 To 11.966
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 11.967 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 12.0 To 13.466
                            haorong = objdataview.Item(0).Row("毫米20")

                        Case 13.467 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")

                        Case 13.5 To 14.966
                            haorong = objdataview.Item(0).Row("毫米22")

                        Case 14.967 To 14.999
                            haorong = objdataview.Item(0).Row("毫米23")

                        Case 15.0 To 16.466
                            haorong = objdataview.Item(0).Row("毫米24")

                        Case 16.467 To 16.499
                            haorong = objdataview.Item(0).Row("毫米25")

                        Case 16.5 To 17.966
                            haorong = objdataview.Item(0).Row("毫米26")

                        Case 18.0 To 19.466
                            haorong = objdataview.Item(0).Row("毫米27")

                        Case 19.467 To 19.499
                            haorong = objdataview.Item(0).Row("毫米28")

                        Case 19.5 To 20.166
                            haorong = objdataview.Item(0).Row("毫米29")






                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK224"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.178
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.179 To 0.375
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.376 To 1.458
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.459 To 1.499
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.5 To 2.958
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 2.959 To 2.999
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 3.0 To 4.458
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 4.459 To 4.499
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.5 To 5.958
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 5.959 To 5.999
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 6.0 To 7.458
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 7.459 To 7.499
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.5 To 8.958
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 8.959 To 8.999
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 9.0 To 10.458
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 10.459 To 10.499
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.5 To 11.958
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 11.959 To 11.999
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 12.0 To 13.458
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 13.459 To 13.499
                            haorong = objdataview.Item(0).Row("毫米20")

                        Case 13.5 To 14.958
                            haorong = objdataview.Item(0).Row("毫米21")

                        Case 14.959 To 14.999
                            haorong = objdataview.Item(0).Row("毫米22")

                        Case 15.0 To 16.458
                            haorong = objdataview.Item(0).Row("毫米23")

                        Case 16.459 To 16.499
                            haorong = objdataview.Item(0).Row("毫米24")

                        Case 16.5 To 17.958
                            haorong = objdataview.Item(0).Row("毫米25")

                        Case 17.959 To 17.999
                            haorong = objdataview.Item(0).Row("毫米26")

                        Case 18.0 To 19.458
                            haorong = objdataview.Item(0).Row("毫米27")

                        Case 19.459 To 19.499
                            haorong = objdataview.Item(0).Row("毫米28")

                        Case 19.5 To 20.158
                            haorong = objdataview.Item(0).Row("毫米29")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK225"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.198
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.199 To 0.395
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.396 To 1.478
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.479 To 1.499
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.5 To 2.978
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 2.979 To 2.999
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 3.0 To 4.478
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 4.479 To 4.499
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.5 To 5.978
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 5.979 To 5.999
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 6.0 To 7.478
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 7.479 To 7.499
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.5 To 8.978
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 8.979 To 8.999
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 9.0 To 10.478
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 10.479 To 10.499
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.5 To 11.978
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 11.979 To 11.999
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 12.0 To 13.478
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 13.479 To 13.499
                            haorong = objdataview.Item(0).Row("毫米20")

                        Case 13.5 To 14.978
                            haorong = objdataview.Item(0).Row("毫米21")

                        Case 14.979 To 14.999
                            haorong = objdataview.Item(0).Row("毫米22")

                        Case 15.0 To 16.478
                            haorong = objdataview.Item(0).Row("毫米23")

                        Case 16.479 To 16.499
                            haorong = objdataview.Item(0).Row("毫米24")

                        Case 16.5 To 17.978
                            haorong = objdataview.Item(0).Row("毫米25")

                        Case 17.979 To 17.999
                            haorong = objdataview.Item(0).Row("毫米26")

                        Case 18.0 To 19.478
                            haorong = objdataview.Item(0).Row("毫米27")

                        Case 19.479 To 19.499
                            haorong = objdataview.Item(0).Row("毫米28")

                        Case 19.5 To 20.178
                            haorong = objdataview.Item(0).Row("毫米29")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK226"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.188
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.189 To 0.385
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.386 To 1.15
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.151 To 1.468
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.469 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.968
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.969 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.468
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.469 To 4.999
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.968
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.969 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6.0 To 7.468
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.469 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.968
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.969 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 9.0 To 10.468
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.469 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 10.5 To 11.968
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 11.969 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 12.0 To 13.468
                            haorong = objdataview.Item(0).Row("毫米20")

                        Case 13.469 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")

                        Case 13.5 To 14.968
                            haorong = objdataview.Item(0).Row("毫米22")

                        Case 14.969 To 14.999
                            haorong = objdataview.Item(0).Row("毫米23")

                        Case 15.0 To 16.468
                            haorong = objdataview.Item(0).Row("毫米24")

                        Case 16.469 To 16.499
                            haorong = objdataview.Item(0).Row("毫米25")

                        Case 16.5 To 17.968
                            haorong = objdataview.Item(0).Row("毫米26")

                        Case 17.969 To 17.999
                            haorong = objdataview.Item(0).Row("毫米27")

                        Case 18.0 To 19.468
                            haorong = objdataview.Item(0).Row("毫米28")

                        Case 19.469 To 19.499
                            haorong = objdataview.Item(0).Row("毫米29")

                        Case 19.5 To 20.168
                            haorong = objdataview.Item(0).Row("毫米30")






                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


                '--------------------------------------------------------------

            Case "TK301"


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.188
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.189 To 0.385
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.386 To 1.15
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.151 To 1.468
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.469 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.968
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.969 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3 To 4.468
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.469 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.968
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.969 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.468
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.469 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.968
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.969 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 9 To 10.468
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.469 To 10.499
                            haorong = objdataview.Item(0).Row("毫米18")
                        Case 10.5 To 11.968
                            haorong = objdataview.Item(0).Row("毫米19")
                        Case 11.969 To 11.999
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case 12 To 13.468
                            haorong = objdataview.Item(0).Row("毫米21")
                        Case 13.469 To 13.499
                            haorong = objdataview.Item(0).Row("毫米22")
                        Case 13.5 To 14.968
                            haorong = objdataview.Item(0).Row("毫米23")
                        Case 14.969 To 14.999
                            haorong = objdataview.Item(0).Row("毫米24")
                        Case 15 To 16.468
                            haorong = objdataview.Item(0).Row("毫米25")
                        Case 16.469 To 16.499
                            haorong = objdataview.Item(0).Row("毫米26")
                        Case 16.5 To 17.968
                            haorong = objdataview.Item(0).Row("毫米27")
                        Case 17.969 To 17.999
                            haorong = objdataview.Item(0).Row("毫米28")
                        Case 18 To 19.468
                            haorong = objdataview.Item(0).Row("毫米29")
                        Case 19.469 To 19.499
                            haorong = objdataview.Item(0).Row("毫米30")
                        Case 19.5 To 20.168
                            haorong = objdataview.Item(0).Row("毫米31")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK302"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.201
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.202 To 0.393
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.394 To 1.158
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.159 To 1.481
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.482 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.981
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.982 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.481
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.482 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.981
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.982 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6.0 To 7.481
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.482 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.981
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.982 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 9.0 To 10.481
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.482 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 10.5 To 11.981
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 11.982 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 12.0 To 13.481
                            haorong = objdataview.Item(0).Row("毫米20")

                        Case 13.482 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")

                        Case 13.5 To 14.981
                            haorong = objdataview.Item(0).Row("毫米22")

                        Case 14.982 To 14.999
                            haorong = objdataview.Item(0).Row("毫米23")

                        Case 15.0 To 16.481
                            haorong = objdataview.Item(0).Row("毫米24")

                        Case 16.482 To 16.499
                            haorong = objdataview.Item(0).Row("毫米25")

                        Case 16.5 To 17.981
                            haorong = objdataview.Item(0).Row("毫米26")

                        Case 17.982 To 17.999
                            haorong = objdataview.Item(0).Row("毫米27")

                        Case 18.0 To 19.481
                            haorong = objdataview.Item(0).Row("毫米28")

                        Case 19.482 To 19.499
                            haorong = objdataview.Item(0).Row("毫米29")

                        Case 19.5 To 20.181
                            haorong = objdataview.Item(0).Row("毫米30")





                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "TK303"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.189
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.19 To 0.379
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.38 To 1.474
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.475 To 1.499
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.5 To 2.974
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 2.975 To 2.999
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 3.0 To 4.474
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 4.475 To 4.499
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.5 To 5.974
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 5.975 To 5.999
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 6.0 To 7.474
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 7.475 To 7.499
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.5 To 8.974
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 8.975 To 8.999
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 9.0 To 10.474
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 10.475 To 10.499
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.5 To 11.974
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 11.975 To 11.999
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 12.0 To 13.474
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 13.475 To 13.499
                            haorong = objdataview.Item(0).Row("毫米20")

                        Case 13.5 To 14.974
                            haorong = objdataview.Item(0).Row("毫米21")

                        Case 14.975 To 14.999
                            haorong = objdataview.Item(0).Row("毫米22")

                        Case 15.0 To 16.474
                            haorong = objdataview.Item(0).Row("毫米23")

                        Case 16.475 To 16.499
                            haorong = objdataview.Item(0).Row("毫米24")

                        Case 16.5 To 17.974
                            haorong = objdataview.Item(0).Row("毫米25")

                        Case 17.975 To 17.999
                            haorong = objdataview.Item(0).Row("毫米26")

                        Case 18.0 To 19.474
                            haorong = objdataview.Item(0).Row("毫米27")

                        Case 19.475 To 19.499
                            haorong = objdataview.Item(0).Row("毫米28")

                        Case 19.5 To 20.174
                            haorong = objdataview.Item(0).Row("毫米29")





                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "R15"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.189
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.19 To 0.371
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.372 To 1.124
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.125 To 1.468
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.466 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.965
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.966 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.465
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.466 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.965
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.966 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6.0 To 7.465
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.466 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.965
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.966 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 9.0 To 10.465
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.466 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 10.5 To 11.965
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 11.966 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 12.0 To 13.465
                            haorong = objdataview.Item(0).Row("毫米20")

                        Case 13.466 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")

                        Case 13.5 To 14.627
                            haorong = objdataview.Item(0).Row("毫米22")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "R19"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.225
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.226 To 0.295
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.296 To 1.096
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.097 To 1.445
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.446 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.945
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.946 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.445
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.446 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.945
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.946 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6.0 To 7.445
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.446 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.945
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.946 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 9.0 To 10.445
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.446 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 10.5 To 11.945
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 11.946 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 12.0 To 13.445
                            haorong = objdataview.Item(0).Row("毫米20")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "R20"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.215
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.216 To 0.285
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.286 To 1.086
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.087 To 1.435
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.436 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.935
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.936 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3.0 To 4.435
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.436 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.935
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.936 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6.0 To 7.435
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.436 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.935
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.936 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 9.0 To 10.435
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.436 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 10.5 To 11.935
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 11.936 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 12.0 To 13.435
                            haorong = objdataview.Item(0).Row("毫米20")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If












                '-------------------------------------------------------------------------------以上由李沫完成
            Case "R8"


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.263
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.264 To 0.333
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.334 To 1.474
                            haorong = objdataview.Item(0).Row("毫米3")



                        Case 1.475 To 1.1499
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.5 To 2.97
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 2.971 To 2.999
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 3 To 4.468
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 4.469 To 4.499
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.5 To 5.968
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 5.969 To 5.999
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 6 To 7.468
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 7.469 To 7.499
                            haorong = objdataview.Item(0).Row("毫米12")


                        Case 7.5 To 8.967
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 8.968 To 8.999
                            haorong = objdataview.Item(0).Row("毫米14")


                        Case 9 To 10.46
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 10.461 To 10.499
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.5 To 11.958
                            haorong = objdataview.Item(0).Row("毫米17")


                        Case 11.959 To 11.999
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 12 To 13.456
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 13.457 To 13.499
                            haorong = objdataview.Item(0).Row("毫米20")

                        Case 13.5 To 14.6
                            haorong = objdataview.Item(0).Row("毫米21")





                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If




            Case "R14"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.18
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.181 To 0.275
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.276 To 1.129
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.13 To 1.483
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.484 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.983
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.984 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3 To 4.483
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.484 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.983
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.984 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.483
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.484 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.983
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.984 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 9 To 10.483
                            haorong = objdataview.Item(0).Row("毫米16")


                        Case 10.484 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")


                        Case 10.5 To 11.983
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 11.984 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 12 To 13.483
                            haorong = objdataview.Item(0).Row("毫米20")


                        Case 13.484 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")


                        Case 13.5 To 14.645
                            haorong = objdataview.Item(0).Row("毫米22")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "R17"



                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.182
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.183 To 0.364
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.365 To 1.12
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.121 To 1.458
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.459 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.958
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.959 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3 To 4.458
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.459 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 5 To 5.958
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.959 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.458
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.459 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")

                        Case 7.5 To 8.958
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.959 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")

                        Case 9 To 10.458
                            haorong = objdataview.Item(0).Row("毫米16")

                        Case 10.459 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 10.5 To 11.958
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 11.959 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 12 To 13.458
                            haorong = objdataview.Item(0).Row("毫米20")

                        Case 13.459 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")

                        Case 13.5 To 14.62
                            haorong = objdataview.Item(0).Row("毫米22")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "R16"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.09
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.091 To 0.352
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 353 To 1.105
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.106 To 1.448
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.449 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.948
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.949 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3 To 4.448
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.449 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.948
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.949 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.448
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.449 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")


                        Case 7.5 To 8.948
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.949 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")


                        Case 9 To 10.448
                            haorong = objdataview.Item(0).Row("毫米16")


                        Case 10.449 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")


                        Case 10.5 To 11.948
                            haorong = objdataview.Item(0).Row("毫米18")

                        Case 11.949 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")


                        Case 12 To 13.448
                            haorong = objdataview.Item(0).Row("毫米20")

                        Case 13.449 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")

                        Case 13.5 To 14.61
                            haorong = objdataview.Item(0).Row("毫米22")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "R18"




                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.095
                            haorong = objdataview.Item(0).Row("毫米1")

                        Case 0.096 To 0.357
                            haorong = objdataview.Item(0).Row("毫米2")

                        Case 0.358 To 1.11
                            haorong = objdataview.Item(0).Row("毫米3")

                        Case 1.111 To 1.445
                            haorong = objdataview.Item(0).Row("毫米4")

                        Case 1.446 To 1.499
                            haorong = objdataview.Item(0).Row("毫米5")

                        Case 1.5 To 2.945
                            haorong = objdataview.Item(0).Row("毫米6")

                        Case 2.946 To 2.999
                            haorong = objdataview.Item(0).Row("毫米7")

                        Case 3 To 4.445
                            haorong = objdataview.Item(0).Row("毫米8")

                        Case 4.446 To 4.499
                            haorong = objdataview.Item(0).Row("毫米9")

                        Case 4.5 To 5.945
                            haorong = objdataview.Item(0).Row("毫米10")

                        Case 5.946 To 5.999
                            haorong = objdataview.Item(0).Row("毫米11")

                        Case 6 To 7.445
                            haorong = objdataview.Item(0).Row("毫米12")

                        Case 7.446 To 7.499
                            haorong = objdataview.Item(0).Row("毫米13")


                        Case 7.5 To 8.945
                            haorong = objdataview.Item(0).Row("毫米14")

                        Case 8.946 To 8.999
                            haorong = objdataview.Item(0).Row("毫米15")


                        Case 9 To 10.445
                            haorong = objdataview.Item(0).Row("毫米16")


                        Case 10.446 To 10.499
                            haorong = objdataview.Item(0).Row("毫米17")

                        Case 10.5 To 11.945
                            haorong = objdataview.Item(0).Row("毫米18")


                        Case 11.946 To 11.999
                            haorong = objdataview.Item(0).Row("毫米19")

                        Case 12 To 13.445
                            haorong = objdataview.Item(0).Row("毫米20")


                        Case 13.446 To 13.499
                            haorong = objdataview.Item(0).Row("毫米21")

                        Case 13.5 To 14.607
                            haorong = objdataview.Item(0).Row("毫米22")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If







        End Select

        up = gaodu + 0.1
        down = gaodu
        up = chendong(up)
        down = chendong(down)



        Dim haolixishu As Integer = 0

        haolixishu = gaodu * 1000
        haolixishu = Int(haolixishu) Mod 100 '取出毫厘系数


        xiuzheng = (up - down) * haolixishu / 100 + down
        zongrong = mirong + haorong + xiuzheng
        tiji = zongrong * wenduxishu
        guancun = tiji * miduxishu




        MessageBox.Show("货重:" & Math.Round(guancun, 3) & "吨", "计算结果", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '-------------------------------------------------





        err:
    End Sub


    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cd1.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cd2.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cd3.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cd4.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If
    End Sub



    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cd5.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cd6.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If
    End Sub


    Private Sub ygbh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ygbh.SelectedIndexChanged
        'objdataadapter.SelectCommand = New SqlCommand
        'objdataadapter.SelectCommand.Connection = objconnection
        'objdataadapter.SelectCommand.CommandText = "select 物料编码,油品,密度 from mission where ltrim(rtrim(罐号)) = '" & Trim(ygbh.Text) & "' and CONVERT(varchar(12) , 盘点时间, 112 )='" & Now.Date.ToString("yyyyMMdd") & "'"


        'If objconnection.State = ConnectionState.Closed Then
        '    objconnection.Open()
        'End If
        'objdataset = New DataSet
        'objdataadapter.Fill(objdataset, "ypmd")

        'objdataview = New DataView(objdataset.Tables("ypmd"))


        'yp.Items.Clear()
        'bzmd.Text = ""
        '' MessageBox.Show(objdataview.Count)
        'If objdataview.Count >= 1 Then

        '    yp.Text = objdataview.Item(0).Item("油品")
        '    bzmd.Text = objdataview.Item(0).Item("密度")
        '    wlbm.Text = objdataview.Item(0).Item("物料编码")
        'End If



        On Error Resume Next
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料编码,油品名称,罐高 from midu where rtrim(ltrim(罐号名称))='" & Trim(ygbh.Text) & "'"



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "ypmd")

        objdataview = New DataView(objdataset.Tables("ypmd"))




        ' MessageBox.Show(objdataview.Count)
        If objdataview.Count >= 1 Then

            yp.Text = objdataview.Item(0).Item("油品名称")
            gg.Text = objdataview.Item(0).Item("罐高")
            wlbm.Text = objdataview.Item(0).Item("物料编码")
        End If

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        '  objdataadapter.SelectCommand.CommandText = "select 标准密度 from midu_wuliaobianma where rtrim(ltrim(物料编码))='" & Trim(wlbm.Text) & "'"

        objdataadapter.SelectCommand.CommandText = "select 标准密度,标准温度 from midu_wuliaobianma where rtrim(ltrim(油品名称))='" & Trim(yp.Text) & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "mi")

        objdataview = New DataView(objdataset.Tables("mi"))




        ' MessageBox.Show(objdataview.Count)
        If objdataview.Count >= 1 Then

            bzmd.Text = objdataview.Item(0).Item("标准密度")
            bzwd.Text = objdataview.Item(0).Item("标准温度")
        End If


    End Sub


    Function chendong(ByVal updown As Single) As Single
        Dim temp, m As Single

        temp = updown * 10
        temp = Int(temp)
        m = temp / 10

        a_objdataadapter.SelectCommand = New OleDb.OleDbCommand
        a_objdataadapter.SelectCommand.Connection = localobjconnection
        a_objdataadapter.SelectCommand.CommandText = "select * from xiuzheng where m= " & m
        If localobjconnection.State = ConnectionState.Closed Then
            localobjconnection.Open()
        End If
        objdataset = New DataSet
        a_objdataadapter.Fill(objdataset, "xiuzheng")
        objdataview = New DataView(objdataset.Tables("xiuzheng"))

        If objdataview.Count >= 1 Then
            updown = objdataview.Item(0).Row("修正") '有数据
        Else
            updown = 0
        End If


        Return updown

    End Function



End Class