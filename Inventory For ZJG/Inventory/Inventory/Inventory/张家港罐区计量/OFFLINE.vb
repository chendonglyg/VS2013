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
        ssgq.Text = "张家港罐区"
        'MessageBox.Show(FormatDateTime(pdsj.Text, DateFormat.ShortDate))

        MDIMain.GP.Visible = False
    End Sub

    Private Sub addpinming()

        Try


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select distinct(罐号名称) from midu_zjg where (len(罐号名称)>0) and (所属罐区='" & Trim(ssgq.Text) & "')"




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

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
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
        'objdataadapter.SelectCommand = New SqlCommand
        'objdataadapter.SelectCommand.Connection = objconnection
        'objdataadapter.SelectCommand.CommandText = "select 物料号 from wlbm where ltrim(rtrim(物料描述)) = '" & Trim(yp.Text) & "'"


        'If objconnection.State = ConnectionState.Closed Then
        '    objconnection.Open()
        'End If
        'objdataset = New DataSet
        'objdataadapter.Fill(objdataset, "yp")

        'objdataview = New DataView(objdataset.Tables("yp"))


        'wlbm.Items.Clear()

        'If objdataview.Count >= 1 Then

        '    wlbm.Text = objdataview.Item(0).Item("物料号")

        'End If


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
        'addpinming()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim temp As Integer


        'Dim MyService As New S1.Service1SoapClient
        Try






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
            'If sel_yewei.Checked = True Then
            gaodu = Val(gd.Text)
            '    gaodu2 = Val(gd2.Text)
            '    gaodu3 = Val(gd3.Text)
            '    gaodu = (Val(gd.Text) + Val(gd2.Text) + Val(gd3.Text)) / 3

            'ElseIf sel_chidu.Checked = True Then
            '    gaodu1 = Val(gg.Text) - Val(cd1.Text) + Val(cd2.Text)
            '    gaodu2 = Val(gg.Text) - Val(cd3.Text) + Val(cd4.Text)
            '    gaodu3 = Val(gg.Text) - Val(cd5.Text) + Val(cd6.Text)

            '    gaodu = (Val(gg.Text) - Val(cd3.Text) + Val(cd4.Text) + Val(gg.Text) - Val(cd5.Text) + Val(cd6.Text) + Val(gg.Text) - Val(cd1.Text) + Val(cd2.Text)) / 3
            'Else
            '    MessageBox.Show("必须选择并填写一种打尺高度参数", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    GoTo err
            'End If




            'youwen = (Val(yw.Text) + Val(yw2.Text) + Val(yw3.Text)) / 3
            youwen = Val(yw.Text)


            qiwen = Val(qw.Text)


            Select Case Trim(ygbh.Text)

                Case "T1-1"

                    str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\T1-1.mdb;Persist Security Info=False;")

                Case "T1-4"
                    str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\T1-4.mdb;Persist Security Info=False;")

                Case "T1-5"
                    str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\T1-5.mdb;Persist Security Info=False;")
                Case "T1-6"
                    str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\T1-6.mdb;Persist Security Info=False;")
                Case "T1-7"
                    str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\T1-7.mdb;Persist Security Info=False;")

                Case "T1-8"
                    str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\T1-8.mdb;Persist Security Info=False;")



                Case "T2-5"
                    str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\T2-5.mdb;Persist Security Info=False;")
                Case "T3-5"
                    str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\T3-5.mdb;Persist Security Info=False;")
                Case "T3-6"
                    str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\T3-6.mdb;Persist Security Info=False;")

                Case "T3-7"
                    str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & ("\mdb\T3-7.mdb;Persist Security Info=False;")


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

            a_objdataadapter.SelectCommand = New OleDb.OleDbCommand
            a_objdataadapter.SelectCommand.Connection = localobjconnection
            a_objdataadapter.SelectCommand.CommandText = "select * from zhengshu where m= " & mirong
            If localobjconnection.State = ConnectionState.Closed Then
                localobjconnection.Open()
            End If
            objdataset = New DataSet
            a_objdataadapter.Fill(objdataset, "m")
            objdataview = New DataView(objdataset.Tables("m"))

            If objdataview.Count >= 1 Then
                mirong = objdataview.Item(0).Row("米容") '有特殊数值
                GoTo NEXT1
            End If







            temp = mirong * 10
            temp = Int(temp)
            m = temp / 10

            a_objdataadapter.SelectCommand = New OleDb.OleDbCommand
            a_objdataadapter.SelectCommand.Connection = localobjconnection
            a_objdataadapter.SelectCommand.CommandText = "select * from zhengshu where m= " & m
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            a_objdataadapter.Fill(objdataset, "m")
            objdataview = New DataView(objdataset.Tables("m"))

            If objdataview.Count >= 1 Then
                mirong = objdataview.Item(0).Row("米容") '有数据
            Else
                mirong = 0
            End If

NEXT1:
            '------下面进行厘米的查询工作

            temp = gaodu * 100
            temp = Int(temp) Mod 10
            cm = temp

            a_objdataadapter.SelectCommand = New OleDb.OleDbCommand
            a_objdataadapter.SelectCommand.Connection = localobjconnection
            a_objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & cm
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            a_objdataadapter.Fill(objdataset, "cm")
            objdataview = New DataView(objdataset.Tables("cm"))


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
            Dim objdataview_mm As DataView
            objdataview_mm = New DataView(objdataset.Tables("mm"))




            '----------------------
            Select Case guanhao

                Case "T1-1"

                    If objdataview.Count >= 1 Then
                        Select Case gaodu
                            Case 0 To 1.432
                                lirong = objdataview.Item(0).Row("厘米1")

                            Case 1.433 To 3.224
                                lirong = objdataview.Item(0).Row("厘米2")

                            Case 3.225 To 4.17
                                lirong = objdataview.Item(0).Row("厘米3")

                            Case 4.171 To 4.967
                                lirong = objdataview.Item(0).Row("厘米4")

                            Case 4.968 To 6.737
                                lirong = objdataview.Item(0).Row("厘米5")

                            Case 6.738 To 7.928
                                lirong = objdataview.Item(0).Row("厘米6")

                            Case 7.929 To 9.13
                                lirong = objdataview.Item(0).Row("厘米7")

                            Case 9.131 To 10.325
                                lirong = objdataview.Item(0).Row("厘米8")

                            Case 10.326 To 11.515
                                lirong = objdataview.Item(0).Row("厘米9")

                            Case 11.516 To 12.639
                                lirong = objdataview.Item(0).Row("厘米10")

                            Case 12.64 To 13.662
                                lirong = objdataview.Item(0).Row("厘米11")





                            Case Else
                                lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        lirong = 0 '只有一种情况，就是cm是0
                    End If
                    '-------------------------------------------------------------------------------------------


                    If objdataview_mm.Count >= 1 Then


                        Select Case gaodu
                            Case 0 To 1.432
                                haorong = objdataview.Item(0).Row("毫米1")

                            Case 1.433 To 3.224
                                haorong = objdataview.Item(0).Row("毫米2")

                            Case 3.225 To 4.17
                                haorong = objdataview.Item(0).Row("毫米3")

                            Case 4.171 To 4.967
                                haorong = objdataview.Item(0).Row("毫米4")

                            Case 4.968 To 6.737
                                haorong = objdataview.Item(0).Row("毫米5")

                            Case 6.738 To 7.928
                                haorong = objdataview.Item(0).Row("毫米6")

                            Case 7.929 To 9.13
                                haorong = objdataview.Item(0).Row("毫米7")

                            Case 9.131 To 10.325
                                haorong = objdataview.Item(0).Row("毫米8")

                            Case 10.326 To 11.515
                                haorong = objdataview.Item(0).Row("毫米9")

                            Case 11.516 To 12.639
                                haorong = objdataview.Item(0).Row("毫米10")

                            Case 12.64 To 13.662
                                haorong = objdataview.Item(0).Row("毫米11")




                            Case Else
                                haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        haorong = 0 '只有一种情况，就是cm是0
                    End If



                    '-------------------------------------------------------------



                Case "T1-4"

                    If objdataview.Count >= 1 Then
                        Select Case gaodu
                            Case 0 To 0.1
                                lirong = objdataview.Item(0).Row("厘米1")

                            Case 0.101 To 0.7
                                lirong = objdataview.Item(0).Row("厘米2")

                            Case 0.701 To 0.95
                                lirong = objdataview.Item(0).Row("厘米3")

                            Case 0.951 To 1.54
                                lirong = objdataview.Item(0).Row("厘米4")

                            Case 1.541 To 3.3
                                lirong = objdataview.Item(0).Row("厘米5")

                            Case 3.301 To 5.05
                                lirong = objdataview.Item(0).Row("厘米6")

                            Case 5.051 To 6.82
                                lirong = objdataview.Item(0).Row("厘米7")

                            Case 6.821 To 7.01
                                lirong = objdataview.Item(0).Row("厘米8")

                            Case 7.011 To 8.58
                                lirong = objdataview.Item(0).Row("厘米9")

                            Case 8.581 To 10.34
                                lirong = objdataview.Item(0).Row("厘米10")

                            Case 10.341 To 12.14
                                lirong = objdataview.Item(0).Row("厘米11")





                            Case Else
                                lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        lirong = 0 '只有一种情况，就是cm是0
                    End If


                    If objdataview_mm.Count >= 1 Then
                        Select Case gaodu
                            Case 0 To 0.1
                                haorong = objdataview.Item(0).Row("毫米1")

                            Case 0.101 To 0.7
                                haorong = objdataview.Item(0).Row("毫米2")

                            Case 0.701 To 0.95
                                haorong = objdataview.Item(0).Row("毫米3")

                            Case 0.951 To 1.54
                                haorong = objdataview.Item(0).Row("毫米4")

                            Case 1.541 To 3.3
                                haorong = objdataview.Item(0).Row("毫米5")

                            Case 3.301 To 5.05
                                haorong = objdataview.Item(0).Row("毫米6")

                            Case 5.051 To 6.82
                                haorong = objdataview.Item(0).Row("毫米7")

                            Case 6.821 To 7.01
                                haorong = objdataview.Item(0).Row("毫米8")

                            Case 7.011 To 8.58
                                haorong = objdataview.Item(0).Row("毫米9")

                            Case 8.581 To 10.34
                                haorong = objdataview.Item(0).Row("毫米10")

                            Case 10.341 To 12.14
                                haorong = objdataview.Item(0).Row("毫米11")



                            Case Else
                                haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        haorong = 0 '只有一种情况，就是cm是0
                    End If



                Case "T1-5"


                    If objdataview.Count >= 1 Then
                        Select Case gaodu
                            Case 0 To 0.315
                                lirong = objdataview.Item(0).Row("厘米1")

                            Case 3.16 To 9.15
                                lirong = objdataview.Item(0).Row("厘米2")

                            Case 9.16 To 1.555
                                lirong = objdataview.Item(0).Row("厘米3")

                            Case 1.556 To 3.315
                                lirong = objdataview.Item(0).Row("厘米4")

                            Case 3.316 To 5.075
                                lirong = objdataview.Item(0).Row("厘米5")

                            Case 5.076 To 6.835
                                lirong = objdataview.Item(0).Row("厘米6")

                            Case 6.836 To 7.85
                                lirong = objdataview.Item(0).Row("厘米7")

                            Case 7.851 To 8.595
                                lirong = objdataview.Item(0).Row("厘米8")

                            Case 8.596 To 10.355
                                lirong = objdataview.Item(0).Row("厘米9")

                            Case 10.356 To 12.155
                                lirong = objdataview.Item(0).Row("厘米10")




                            Case Else
                                lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        lirong = 0 '只有一种情况，就是cm是0
                    End If


                    If objdataview_mm.Count >= 1 Then
                        Select Case gaodu
                            Case 0 To 0.315
                                haorong = objdataview.Item(0).Row("毫米1")

                            Case 3.16 To 9.15
                                haorong = objdataview.Item(0).Row("毫米2")

                            Case 9.16 To 1.555
                                haorong = objdataview.Item(0).Row("毫米3")

                            Case 1.556 To 3.315
                                haorong = objdataview.Item(0).Row("毫米4")

                            Case 3.316 To 5.075
                                haorong = objdataview.Item(0).Row("毫米5")

                            Case 5.076 To 6.835
                                haorong = objdataview.Item(0).Row("毫米6")

                            Case 6.836 To 7.85
                                haorong = objdataview.Item(0).Row("毫米7")

                            Case 7.851 To 8.595
                                haorong = objdataview.Item(0).Row("毫米8")

                            Case 8.596 To 10.355
                                haorong = objdataview.Item(0).Row("毫米9")

                            Case 10.356 To 12.155
                                haorong = objdataview.Item(0).Row("毫米10")



                            Case Else
                                haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        haorong = 0 '只有一种情况，就是cm是0
                    End If



                Case "T1-6"




                    If objdataview.Count >= 1 Then
                        Select Case gaodu
                            Case 0 To 0.167
                                lirong = objdataview.Item(0).Row("厘米1")

                            Case 0.168 To 0.277
                                lirong = objdataview.Item(0).Row("厘米2")

                            Case 0.278 To 0.782
                                lirong = objdataview.Item(0).Row("厘米3")

                            Case 0.783 To 1.543
                                lirong = objdataview.Item(0).Row("厘米4")

                            Case 1.544 To 3.298
                                lirong = objdataview.Item(0).Row("厘米5")

                            Case 3.299 To 4.765
                                lirong = objdataview.Item(0).Row("厘米6")

                            Case 4.766 To 5.277
                                lirong = objdataview.Item(0).Row("厘米7")

                            Case 5.278 To 6.233
                                lirong = objdataview.Item(0).Row("厘米8")

                            Case 6.234 To 7.701
                                lirong = objdataview.Item(0).Row("厘米9")

                            Case 7.702 To 9.171
                                lirong = objdataview.Item(0).Row("厘米10")

                            Case 9.172 To 10.641
                                lirong = objdataview.Item(0).Row("厘米11")

                            Case 10.642 To 12.172
                                lirong = objdataview.Item(0).Row("厘米12")




                            Case Else
                                lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        lirong = 0 '只有一种情况，就是cm是0
                    End If


                    If objdataview_mm.Count >= 1 Then
                        Select Case gaodu
                            Case 0 To 0.167
                                haorong = objdataview.Item(0).Row("毫米1")

                            Case 0.168 To 0.277
                                haorong = objdataview.Item(0).Row("毫米2")

                            Case 0.278 To 0.782
                                haorong = objdataview.Item(0).Row("毫米3")

                            Case 0.783 To 1.543
                                haorong = objdataview.Item(0).Row("毫米4")

                            Case 1.544 To 3.298
                                haorong = objdataview.Item(0).Row("毫米5")

                            Case 3.299 To 4.765
                                haorong = objdataview.Item(0).Row("毫米6")

                            Case 4.766 To 5.277
                                haorong = objdataview.Item(0).Row("毫米7")

                            Case 5.278 To 6.233
                                haorong = objdataview.Item(0).Row("毫米8")

                            Case 6.234 To 7.701
                                haorong = objdataview.Item(0).Row("毫米9")

                            Case 7.702 To 9.171
                                haorong = objdataview.Item(0).Row("毫米10")

                            Case 9.172 To 10.641
                                haorong = objdataview.Item(0).Row("毫米11")

                            Case 10.642 To 12.172
                                haorong = objdataview.Item(0).Row("毫米12")




                            Case Else
                                haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        haorong = 0 '只有一种情况，就是cm是0
                    End If

                Case "T1-7"




                    If objdataview.Count >= 1 Then
                        Select Case gaodu
                            Case 0.0 To 1.615
                                lirong = objdataview.Item(0).Row("厘米1")

                            Case 1.616 To 3.37
                                lirong = objdataview.Item(0).Row("厘米2")

                            Case 3.371 To 4.17
                                lirong = objdataview.Item(0).Row("厘米3")

                            Case 4.171 To 4.837
                                lirong = objdataview.Item(0).Row("厘米4")

                            Case 4.838 To 6.305
                                lirong = objdataview.Item(0).Row("厘米5")

                            Case 6.306 To 7.773
                                lirong = objdataview.Item(0).Row("厘米6")

                            Case 7.774 To 9.243
                                lirong = objdataview.Item(0).Row("厘米7")

                            Case 9.344 To 10.713
                                lirong = objdataview.Item(0).Row("厘米8")

                            Case 10.714 To 12.204
                                lirong = objdataview.Item(0).Row("厘米9")



                            Case Else
                                lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        lirong = 0 '只有一种情况，就是cm是0
                    End If




                    If objdataview_mm.Count >= 1 Then
                        Select Case gaodu
                            Case 0.0 To 1.615
                                haorong = objdataview.Item(0).Row("毫米1")

                            Case 1.616 To 3.37
                                haorong = objdataview.Item(0).Row("毫米2")

                            Case 3.371 To 4.17
                                haorong = objdataview.Item(0).Row("毫米3")

                            Case 4.171 To 4.837
                                haorong = objdataview.Item(0).Row("毫米4")

                            Case 4.838 To 6.305
                                haorong = objdataview.Item(0).Row("毫米5")

                            Case 6.306 To 7.773
                                haorong = objdataview.Item(0).Row("毫米6")

                            Case 7.774 To 9.243
                                haorong = objdataview.Item(0).Row("毫米7")

                            Case 9.344 To 10.713
                                haorong = objdataview.Item(0).Row("毫米8")

                            Case 10.714 To 12.204
                                haorong = objdataview.Item(0).Row("毫米9")



                            Case Else
                                haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        haorong = 0 '只有一种情况，就是cm是0
                    End If
                    '----------------------------------------------------------------------------
                Case "T1-8"

                    If objdataview.Count >= 1 Then
                        Select Case gaodu
                            Case 0 To 0.38
                                lirong = objdataview.Item(0).Row("厘米1")

                            Case 0.381 To 0.9
                                lirong = objdataview.Item(0).Row("厘米2")

                            Case 0.901 To 0.98
                                lirong = objdataview.Item(0).Row("厘米3")

                            Case 0.981 To 1.6
                                lirong = objdataview.Item(0).Row("厘米4")

                            Case 1.601 To 3.355
                                lirong = objdataview.Item(0).Row("厘米5")

                            Case 3.356 To 4.822
                                lirong = objdataview.Item(0).Row("厘米6")

                            Case 4.823 To 6.29
                                lirong = objdataview.Item(0).Row("厘米7")

                            Case 6.291 To 7.758
                                lirong = objdataview.Item(0).Row("厘米8")

                            Case 7.759 To 8.58
                                lirong = objdataview.Item(0).Row("厘米9")

                            Case 8.581 To 9.228
                                lirong = objdataview.Item(0).Row("厘米10")

                            Case 9.229 To 10.698
                                lirong = objdataview.Item(0).Row("厘米11")

                            Case 10.699 To 12.188
                                lirong = objdataview.Item(0).Row("厘米12")


                            Case Else
                                lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        lirong = 0 '只有一种情况，就是cm是0
                    End If

                    '----------------------------------------------------------------------------
                    If objdataview_mm.Count >= 1 Then
                        Select Case gaodu
                            Case 0 To 0.38
                                haorong = objdataview.Item(0).Row("毫米1")

                            Case 0.381 To 0.9
                                haorong = objdataview.Item(0).Row("毫米2")

                            Case 0.901 To 0.98
                                haorong = objdataview.Item(0).Row("毫米3")

                            Case 0.981 To 1.6
                                haorong = objdataview.Item(0).Row("毫米4")

                            Case 1.601 To 3.355
                                haorong = objdataview.Item(0).Row("毫米5")

                            Case 3.356 To 4.822
                                haorong = objdataview.Item(0).Row("毫米6")

                            Case 4.823 To 6.29
                                haorong = objdataview.Item(0).Row("毫米7")

                            Case 6.291 To 7.758
                                haorong = objdataview.Item(0).Row("毫米8")

                            Case 7.759 To 8.58
                                haorong = objdataview.Item(0).Row("毫米9")

                            Case 8.581 To 9.228
                                haorong = objdataview.Item(0).Row("毫米10")

                            Case 9.229 To 10.698
                                haorong = objdataview.Item(0).Row("毫米11")

                            Case 10.699 To 12.188
                                haorong = objdataview.Item(0).Row("毫米12")


                            Case Else
                                haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        haorong = 0 '只有一种情况，就是cm是0
                    End If


                Case "T2-5"




                    If objdataview.Count >= 1 Then
                        Select Case gaodu
                            Case 0 To 0.537
                                lirong = objdataview.Item(0).Row("厘米1")

                            Case 0.538 To 1.137
                                lirong = objdataview.Item(0).Row("厘米2")

                            Case 1.138 To 1.357
                                lirong = objdataview.Item(0).Row("厘米3")

                            Case 1.358 To 1.6
                                lirong = objdataview.Item(0).Row("厘米4")

                            Case 1.601 To 2.857
                                lirong = objdataview.Item(0).Row("厘米5")

                            Case 2.858 To 4.357
                                lirong = objdataview.Item(0).Row("厘米6")

                            Case 4.358 To 5.857
                                lirong = objdataview.Item(0).Row("厘米7")

                            Case 5.858 To 7.357
                                lirong = objdataview.Item(0).Row("毫米8")

                            Case 7.458 To 8.857
                                lirong = objdataview.Item(0).Row("厘米9")

                            Case 8.858 To 10.357
                                lirong = objdataview.Item(0).Row("厘米10")

                            Case 10.358 To 11.857
                                lirong = objdataview.Item(0).Row("厘米11")

                            Case 11.858 To 13.357
                                lirong = objdataview.Item(0).Row("厘米12")

                            Case 13.358 To 14.31
                                lirong = objdataview.Item(0).Row("厘米13")

                            Case 14.311 To 14.857
                                lirong = objdataview.Item(0).Row("厘米14")

                            Case 14.858 To 16.357
                                lirong = objdataview.Item(0).Row("厘米15")

                            Case 16.358 To 17.857
                                lirong = objdataview.Item(0).Row("厘米16")

                            Case 17.858 To 19.357
                                lirong = objdataview.Item(0).Row("厘米17")

                            Case 19.358 To 20.857
                                lirong = objdataview.Item(0).Row("厘米18")





                            Case Else
                                lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        lirong = 0 '只有一种情况，就是cm是0
                    End If



                    If objdataview_mm.Count >= 1 Then
                        Select Case gaodu
                            Case 0 To 0.537
                                haorong = objdataview.Item(0).Row("毫米1")

                            Case 0.538 To 1.137
                                haorong = objdataview.Item(0).Row("毫米2")

                            Case 1.138 To 1.357
                                haorong = objdataview.Item(0).Row("毫米3")

                            Case 1.358 To 1.6
                                haorong = objdataview.Item(0).Row("毫米4")

                            Case 1.601 To 2.857
                                haorong = objdataview.Item(0).Row("毫米5")

                            Case 2.858 To 4.357
                                haorong = objdataview.Item(0).Row("毫米6")

                            Case 4.358 To 5.857
                                haorong = objdataview.Item(0).Row("毫米7")

                            Case 5.858 To 7.357
                                haorong = objdataview.Item(0).Row("毫米8")

                            Case 7.458 To 8.857
                                haorong = objdataview.Item(0).Row("毫米9")

                            Case 8.858 To 10.357
                                haorong = objdataview.Item(0).Row("毫米10")

                            Case 10.358 To 11.857
                                haorong = objdataview.Item(0).Row("毫米11")

                            Case 11.858 To 13.357
                                haorong = objdataview.Item(0).Row("毫米12")

                            Case 13.358 To 14.31
                                haorong = objdataview.Item(0).Row("毫米13")

                            Case 14.311 To 14.857
                                haorong = objdataview.Item(0).Row("毫米14")

                            Case 14.858 To 16.357
                                haorong = objdataview.Item(0).Row("毫米15")

                            Case 16.358 To 17.857
                                haorong = objdataview.Item(0).Row("毫米16")

                            Case 17.858 To 19.357
                                haorong = objdataview.Item(0).Row("毫米17")

                            Case 19.358 To 20.857
                                haorong = objdataview.Item(0).Row("毫米18")





                            Case Else
                                haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        haorong = 0 '只有一种情况，就是cm是0
                    End If




                Case "T3-5"




                    If objdataview.Count >= 1 Then
                        Select Case gaodu
                            Case 0 To 0.089
                                lirong = objdataview.Item(0).Row("厘米1")

                            Case 0.09 To 0.699
                                lirong = objdataview.Item(0).Row("厘米2")

                            Case 0.7 To 0.724
                                lirong = objdataview.Item(0).Row("厘米3")

                            Case 0.725 To 1.594
                                lirong = objdataview.Item(0).Row("厘米4")

                            Case 1.595 To 3.352
                                lirong = objdataview.Item(0).Row("厘米5")

                            Case 3.353 To 5.109
                                lirong = objdataview.Item(0).Row("厘米6")

                            Case 5.11 To 6.784
                                lirong = objdataview.Item(0).Row("厘米7")

                            Case 6.785 To 6.869
                                lirong = objdataview.Item(0).Row("厘米8")

                            Case 6.87 To 8.629
                                lirong = objdataview.Item(0).Row("厘米9")

                            Case 8.63 To 10.389
                                lirong = objdataview.Item(0).Row("厘米10")

                            Case 10.39 To 11.289
                                lirong = objdataview.Item(0).Row("厘米11")

                            Case 11.29 To 13.049
                                lirong = objdataview.Item(0).Row("厘米12")



                            Case Else
                                lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        lirong = 0 '只有一种情况，就是cm是0
                    End If


                    If objdataview_mm.Count >= 1 Then
                        Select Case gaodu
                            Case 0 To 0.089
                                haorong = objdataview.Item(0).Row("毫米1")

                            Case 0.09 To 0.699
                                haorong = objdataview.Item(0).Row("毫米2")

                            Case 0.7 To 0.724
                                haorong = objdataview.Item(0).Row("毫米3")

                            Case 0.725 To 1.594
                                haorong = objdataview.Item(0).Row("毫米4")

                            Case 1.595 To 3.352
                                haorong = objdataview.Item(0).Row("毫米5")

                            Case 3.353 To 5.109
                                haorong = objdataview.Item(0).Row("毫米6")

                            Case 5.11 To 6.784
                                haorong = objdataview.Item(0).Row("毫米7")

                            Case 6.785 To 6.869
                                haorong = objdataview.Item(0).Row("毫米8")

                            Case 6.87 To 8.629
                                haorong = objdataview.Item(0).Row("毫米9")

                            Case 8.63 To 10.389
                                haorong = objdataview.Item(0).Row("毫米10")

                            Case 10.39 To 11.289
                                haorong = objdataview.Item(0).Row("毫米11")

                            Case 11.29 To 13.049
                                haorong = objdataview.Item(0).Row("毫米12")



                            Case Else
                                haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        haorong = 0 '只有一种情况，就是cm是0
                    End If



                Case "T3-6"



                    If objdataview.Count >= 1 Then
                        Select Case gaodu
                            Case 0 To 0.39
                                lirong = objdataview.Item(0).Row("厘米1")

                            Case 0.391 To 1.005
                                lirong = objdataview.Item(0).Row("厘米2")

                            Case 1.006 To 1.595
                                lirong = objdataview.Item(0).Row("厘米3")

                            Case 1.596 To 3.365
                                lirong = objdataview.Item(0).Row("厘米4")

                            Case 3.366 To 5.135
                                lirong = objdataview.Item(0).Row("厘米5")

                            Case 5.136 To 6.905
                                lirong = objdataview.Item(0).Row("厘米6")

                            Case 6.906 To 8.375
                                lirong = objdataview.Item(0).Row("厘米7")

                            Case 8.376 To 8.7
                                lirong = objdataview.Item(0).Row("厘米8")

                            Case 8.701 To 9.845
                                lirong = objdataview.Item(0).Row("厘米9")

                            Case 9.846 To 11.315
                                lirong = objdataview.Item(0).Row("厘米10")

                            Case 11.316 To 12.525
                                lirong = objdataview.Item(0).Row("厘米11")

                            Case 12.526 To 14.035
                                lirong = objdataview.Item(0).Row("厘米12")






                            Case Else
                                lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        lirong = 0 '只有一种情况，就是cm是0
                    End If


                    If objdataview_mm.Count >= 1 Then
                        Select Case gaodu
                            Case 0 To 0.39
                                haorong = objdataview.Item(0).Row("毫米1")

                            Case 0.391 To 1.005
                                haorong = objdataview.Item(0).Row("毫米2")

                            Case 1.006 To 1.595
                                haorong = objdataview.Item(0).Row("毫米3")

                            Case 1.596 To 3.365
                                haorong = objdataview.Item(0).Row("毫米4")

                            Case 3.366 To 5.135
                                haorong = objdataview.Item(0).Row("毫米5")

                            Case 5.136 To 6.905
                                haorong = objdataview.Item(0).Row("毫米6")

                            Case 6.906 To 8.375
                                haorong = objdataview.Item(0).Row("毫米7")

                            Case 8.376 To 8.7
                                haorong = objdataview.Item(0).Row("毫米8")

                            Case 8.701 To 9.845
                                haorong = objdataview.Item(0).Row("毫米9")

                            Case 9.846 To 11.315
                                haorong = objdataview.Item(0).Row("毫米10")

                            Case 11.316 To 12.525
                                haorong = objdataview.Item(0).Row("毫米11")

                            Case 12.526 To 14.035
                                haorong = objdataview.Item(0).Row("毫米12")






                            Case Else
                                haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        haorong = 0 '只有一种情况，就是cm是0
                    End If


                Case "T3-7"



                    If objdataview.Count >= 1 Then
                        Select Case gaodu
                            Case 0.0 To 0.24
                                lirong = objdataview.Item(0).Row("厘米1")

                            Case 0.241 To 0.86
                                lirong = objdataview.Item(0).Row("厘米2")

                            Case 0.861 To 1.622
                                lirong = objdataview.Item(0).Row("厘米3")

                            Case 1.623 To 3.392
                                lirong = objdataview.Item(0).Row("厘米4")

                            Case 3.393 To 5.162
                                lirong = objdataview.Item(0).Row("厘米5")

                            Case 5.163 To 6.932
                                lirong = objdataview.Item(0).Row("厘米6")

                            Case 6.933 To 8.35
                                lirong = objdataview.Item(0).Row("厘米7")

                            Case 8.351 To 8.402
                                lirong = objdataview.Item(0).Row("厘米8")

                            Case 8.403 To 9.872
                                lirong = objdataview.Item(0).Row("厘米9")

                            Case 9.873 To 11.342
                                lirong = objdataview.Item(0).Row("厘米10")

                            Case 11.343 To 12.552
                                lirong = objdataview.Item(0).Row("厘米11")

                            Case 12.553 To 14.062
                                lirong = objdataview.Item(0).Row("厘米12")


                            Case Else
                                lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                        End Select
                    Else
                        lirong = 0 '只有一种情况，就是cm是0
                    End If



                    If objdataview_mm.Count >= 1 Then
                        Select Case gaodu
                            Case 0.0 To 0.24
                                haorong = objdataview.Item(0).Row("毫米1")

                            Case 0.241 To 0.86
                                haorong = objdataview.Item(0).Row("毫米2")

                            Case 0.861 To 1.622
                                haorong = objdataview.Item(0).Row("毫米3")

                            Case 1.623 To 3.392
                                haorong = objdataview.Item(0).Row("毫米4")

                            Case 3.393 To 5.162
                                haorong = objdataview.Item(0).Row("毫米5")

                            Case 5.163 To 6.932
                                haorong = objdataview.Item(0).Row("毫米6")

                            Case 6.933 To 8.35
                                haorong = objdataview.Item(0).Row("毫米7")

                            Case 8.351 To 8.402
                                haorong = objdataview.Item(0).Row("毫米8")

                            Case 8.403 To 9.872
                                haorong = objdataview.Item(0).Row("毫米9")

                            Case 9.873 To 11.342
                                haorong = objdataview.Item(0).Row("毫米10")

                            Case 11.343 To 12.552
                                haorong = objdataview.Item(0).Row("毫米11")

                            Case 12.553 To 14.062
                                haorong = objdataview.Item(0).Row("毫米12")


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




            MessageBox.Show("货重:" & Math.Round(guancun / 1000, 3) & "吨", "计算结果", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '-------------------------------------------------

err:

        Catch ex As Exception
            MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
        End Try


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
        objdataadapter.SelectCommand.CommandText = "select 油品名称,罐高 from midu_zjg where rtrim(ltrim(罐号名称))='" & Trim(ygbh.Text) & "'"



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
        Else
            yp.Text = ""
            gg.Text = ""


        End If

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        '  objdataadapter.SelectCommand.CommandText = "select 标准密度 from midu_wuliaobianma where rtrim(ltrim(物料编码))='" & Trim(wlbm.Text) & "'"

        objdataadapter.SelectCommand.CommandText = "select 物料编码,标准密度 from midu_wuliaobianma_zjg where rtrim(ltrim(油品名称))='" & Trim(yp.Text) & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "mi")

        objdataview = New DataView(objdataset.Tables("mi"))




        ' MessageBox.Show(objdataview.Count)
        If objdataview.Count >= 1 Then

            bzmd.Text = objdataview.Item(0).Item("标准密度")

            wlbm.Text = objdataview.Item(0).Item("物料编码")
        Else
            bzmd.Text = ""

            wlbm.Text = ""
        End If


    End Sub


    Function chendong(ByVal updown As Single) As Single
        Dim a As Integer = 0
        temp = Int(updown)

        a_objdataadapter.SelectCommand = New OleDb.OleDbCommand
        a_objdataadapter.SelectCommand.Connection = localobjconnection
        a_objdataadapter.SelectCommand.CommandText = "select * from xiuzheng where m= " & temp
        If localobjconnection.State = ConnectionState.Closed Then
            localobjconnection.Open()
        End If
        objdataset = New DataSet
        a_objdataadapter.Fill(objdataset, "chendong")
        objdataview = New DataView(objdataset.Tables("chendong"))
        a = (Int(updown * 10)) Mod 10

        Select Case a
            Case 0
                updown = objdataview.Item(0).Row("f0")
            Case 1
                updown = objdataview.Item(0).Row("f1")
            Case 2
                updown = objdataview.Item(0).Row("f2")
            Case 3
                updown = objdataview.Item(0).Row("f3")
            Case 4
                updown = objdataview.Item(0).Row("f4")
            Case 5
                updown = objdataview.Item(0).Row("f5")
            Case 6
                updown = objdataview.Item(0).Row("f6")
            Case 7
                updown = objdataview.Item(0).Row("f7")
            Case 8
                updown = objdataview.Item(0).Row("f8")
            Case 9
                updown = objdataview.Item(0).Row("f9")

            Case Else
                updown = 0

        End Select

        Return updown

    End Function



   
End Class