Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO

' 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class TZGO_CalculateAndSave_2
    Inherits System.Web.Services.WebService
    Dim siliang As Single
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New OleDb.OleDbDataAdapter
    '---------------------------------------------
    'Dim gaodu As Single = 12.345
    'Dim youwen As Single = 27
    'Dim qiwen As Single = 18
    'Dim bzmd As Single = 0.9226
    'Dim bzwd As Single = 20
    'Dim bhxs As Single = 0.000064

    'Dim guanhao As String = "8051"


    Dim up, down As Single

    Dim str_conn As String
    Dim localobjconnection As OleDb.OleDbConnection
    '--------------------------------------
    Dim m, cm, mm As Single
    Dim guancun, wenduxishu, miduxishu, temp, xiuzheng, mirong, lirong, haorong, zongrong, tiji As Single
    
    Function chendong(updown As Single) As Single
        Dim a As Integer = 0
        temp = Int(updown)

        objdataadapter.SelectCommand = New OleDb.OleDbCommand
        objdataadapter.SelectCommand.Connection = localobjconnection
        objdataadapter.SelectCommand.CommandText = "select * from xiuzheng where m= " & temp
        If localobjconnection.State = ConnectionState.Closed Then
            localobjconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "chendong")
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

    <WebMethod()> _
    Public Function Calculate(ByVal YP As String, ByVal WLBM As String, ByVal PANDIANREN As String, ByVal GUANQU As String, ByVal BEIZHU As String, ByVal GUANHAO As String, ByVal GAODU As String, ByVal YOUWEN As String, ByVal QIWEN As String, ByVal BZMD As String, ByVal BZWD As String, ByVal BHXS As String, ByVal WDXS As Single) As Single

 
        GUANQU = "泰州粮油罐区"


        Select Case guanhao

            Case "T101"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T101.mdb;Persist Security Info=False;")
            Case "T102"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T102.mdb;Persist Security Info=False;")
            Case "T103"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T103.mdb;Persist Security Info=False;")
            Case "T104"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T104.mdb;Persist Security Info=False;")
            Case "T105"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T105.mdb;Persist Security Info=False;")
            Case "T106"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T106.mdb;Persist Security Info=False;")
            Case "T107"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T107.mdb;Persist Security Info=False;")
            Case "T108"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T108.mdb;Persist Security Info=False;")
            Case "T109"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T109.mdb;Persist Security Info=False;")
            Case "T110"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T110.mdb;Persist Security Info=False;")
            Case "T111"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T111.mdb;Persist Security Info=False;")



            Case "T201"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T201.mdb;Persist Security Info=False;")
            Case "T202"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T202.mdb;Persist Security Info=False;")


            Case "T301"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T301.mdb;Persist Security Info=False;")
            Case "T302"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T302.mdb;Persist Security Info=False;")
            Case "T303"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T303.mdb;Persist Security Info=False;")
            Case "T304"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T304.mdb;Persist Security Info=False;")
            Case "T305"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T305.mdb;Persist Security Info=False;")
            Case "T306"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T306.mdb;Persist Security Info=False;")



            Case "T501"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T501.mdb;Persist Security Info=False;")
            Case "T502"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T502.mdb;Persist Security Info=False;")
            Case "T503"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T503.mdb;Persist Security Info=False;")
            Case "T504"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T504.mdb;Persist Security Info=False;")
            Case "T505"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T505.mdb;Persist Security Info=False;")
            Case "T506"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T506.mdb;Persist Security Info=False;")
            Case "T507"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T507.mdb;Persist Security Info=False;")
            Case "T508"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T508.mdb;Persist Security Info=False;")
            Case "T509"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T509.mdb;Persist Security Info=False;")
            Case "T510"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T510.mdb;Persist Security Info=False;")
            Case "T511"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T511.mdb;Persist Security Info=False;")
            Case "T512"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T512.mdb;Persist Security Info=False;")
            Case "T513"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T513.mdb;Persist Security Info=False;")
            Case "T514"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T514.mdb;Persist Security Info=False;")
            Case "T515"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T515.mdb;Persist Security Info=False;")
            Case "T516"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T516.mdb;Persist Security Info=False;")
            Case "T517"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T517.mdb;Persist Security Info=False;")
            Case "T518"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T518.mdb;Persist Security Info=False;")
            Case "T519"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T519.mdb;Persist Security Info=False;")
            Case "T520"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T520.mdb;Persist Security Info=False;")
            Case "T521"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T521.mdb;Persist Security Info=False;")
            Case "T522"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T522.mdb;Persist Security Info=False;")
            Case "T523"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T523.mdb;Persist Security Info=False;")
            Case "T524"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T524.mdb;Persist Security Info=False;")


            Case "T005-1"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T005-1.mdb;Persist Security Info=False;")
            Case "T005-2"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T005-2.mdb;Persist Security Info=False;")
            Case "T005-3"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T005-3.mdb;Persist Security Info=False;")
            Case "T005-4"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T005-4.mdb;Persist Security Info=False;")
            Case "T005-5"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T005-5.mdb;Persist Security Info=False;")


            Case "T05-1"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T05-1.mdb;Persist Security Info=False;")
            Case "T05-2"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T05-2.mdb;Persist Security Info=False;")
            Case "T05-3"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T05-3.mdb;Persist Security Info=False;")
            Case "T05-4"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T05-4.mdb;Persist Security Info=False;")
            Case "T05-5"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T05-5.mdb;Persist Security Info=False;")
            Case "T05-6"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T05-6.mdb;Persist Security Info=False;")
            Case "T05-7"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T05-7.mdb;Persist Security Info=False;")
            Case "T05-11"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T05-11.mdb;Persist Security Info=False;")
            Case "T05-12"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T05-12.mdb;Persist Security Info=False;")
            Case "T05-13"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T05-13.mdb;Persist Security Info=False;")
            Case "T05-14"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T05-14.mdb;Persist Security Info=False;")
            Case "T05-15"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T05-15.mdb;Persist Security Info=False;")
            Case "T05-16"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T05-16.mdb;Persist Security Info=False;")
            Case "T05-17"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T05-17.mdb;Persist Security Info=False;")

            Case "T011"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T011.mdb;Persist Security Info=False;")
            Case "T012"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T012.mdb;Persist Security Info=False;")
            Case "T013"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T013.mdb;Persist Security Info=False;")
            Case "T014"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T014.mdb;Persist Security Info=False;")
            Case "T015"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T015.mdb;Persist Security Info=False;")
            Case "T016"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T016.mdb;Persist Security Info=False;")


            Case "T051"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T051.mdb;Persist Security Info=False;")
            Case "T052"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T052.mdb;Persist Security Info=False;")
            Case "T053"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T053.mdb;Persist Security Info=False;")
                '---------------------------------------------------------------------------------------------------------------

            Case "TK05-18"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK05-18.mdb;Persist Security Info=False;")
            Case "TK05-19"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK05-19.mdb;Persist Security Info=False;")
            Case "TK05-20"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK05-20.mdb;Persist Security Info=False;")
            Case "TK05-21"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK05-21.mdb;Persist Security Info=False;")
            Case "TK05-22"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK05-22.mdb;Persist Security Info=False;")
            Case "TK05-23"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK05-23.mdb;Persist Security Info=False;")
            Case "TK05-24"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK05-24.mdb;Persist Security Info=False;")
            Case "TK05-25"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK05-25.mdb;Persist Security Info=False;")


            Case "TK112"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK112.mdb;Persist Security Info=False;")
            Case "TK113"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK113.mdb;Persist Security Info=False;")
            Case "TK114"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK114.mdb;Persist Security Info=False;")
            Case "TK115"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK115.mdb;Persist Security Info=False;")
            Case "TK116"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK116.mdb;Persist Security Info=False;")
            Case "TK117"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK117.mdb;Persist Security Info=False;")
            Case "TK118"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK118.mdb;Persist Security Info=False;")
            Case "TK119"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK119.mdb;Persist Security Info=False;")
            Case "TK120"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK120.mdb;Persist Security Info=False;")
            Case "TK121"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK121.mdb;Persist Security Info=False;")
            Case "TK122"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK122.mdb;Persist Security Info=False;")
            Case "TK123"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK123.mdb;Persist Security Info=False;")
            Case "TK124"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK124.mdb;Persist Security Info=False;")
            Case "TK125"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\TK125.mdb;Persist Security Info=False;")

            Case Else



        End Select





        '----------------------------------------------------------------------------------------

        localobjconnection = New OleDb.OleDbConnection(str_conn)
        GAODU = Val(GAODU)
        YOUWEN = Val(YOUWEN)
        QIWEN = Val(QIWEN)
        BZMD = Val(BZMD)
        BZWD = Val(BZWD)
        BHXS = Val(BHXS)

        wenduxishu = WDXS


        If Val(GAODU) = 0 Then
            m = 0
            cm = 0
            mm = 0
            guancun = 0


        End If

        'If gaodu > 14.324 Or gaodu < 0 Then
        '    MessageBox.Show("高度超出极限且不具备计算条件!", "警告", MessageBoxButtons.OK)
        '    Exit Sub
        'End If




        miduxishu = BZMD - (YOUWEN - BZWD) * BHXS - 0.0011


        mirong = gaodu

        objdataadapter.SelectCommand = New OleDb.OleDbCommand
        objdataadapter.SelectCommand.Connection = localobjconnection
        objdataadapter.SelectCommand.CommandText = "select * from zhengshu where m= " & mirong
        If localobjconnection.State = ConnectionState.Closed Then
            localobjconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "m")
        objdataview = New DataView(objdataset.Tables("m"))

        If objdataview.Count >= 1 Then
            mirong = objdataview.Item(0).Row("米容") '有特殊数值
            GoTo NEXT1
        End If

        temp = mirong * 10
        temp = Int(temp)
        m = temp / 10

        objdataadapter.SelectCommand = New OleDb.OleDbCommand
        objdataadapter.SelectCommand.Connection = localobjconnection
        objdataadapter.SelectCommand.CommandText = "select * from zhengshu where m= " & m
        If localobjconnection.State = ConnectionState.Closed Then
            localobjconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "m")
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

        objdataadapter.SelectCommand = New OleDb.OleDbCommand
        objdataadapter.SelectCommand.Connection = localobjconnection
        objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & cm
        If localobjconnection.State = ConnectionState.Closed Then
            localobjconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "cm")
        objdataview = New DataView(objdataset.Tables("cm"))



        '--------------------------------------------------------------------------------------------------------------------------






        Select Case guanhao



            '------------------------------------------------------------------------------------下面是新增22个罐子


            Case "TK05-18"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.29
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.291 To 0.36
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.361 To 0.38
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If


                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.29
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.291 To 0.36
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.361 To 0.38
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容16")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "TK05-19"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.28
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.281 To 0.35
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.351 To 0.38
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If



                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.28
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.281 To 0.35
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.351 To 0.38
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容16")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "TK05-20"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.28
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.281 To 0.37
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.371 To 0.38
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))

                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.28
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.281 To 0.37
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.371 To 0.38
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容16")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "TK05-21"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.009
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.01 To 0.27
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.271 To 0.35
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.351 To 0.38
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.009
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.01 To 0.27
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.271 To 0.35
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.351 To 0.38
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容17")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "TK05-22 "


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.05
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.051 To 0.28
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.281 To 0.36
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.361 To 0.38
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))

                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.05
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.051 To 0.28
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.281 To 0.36
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.361 To 0.38
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容17")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "TK05-23"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.28
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.281 To 0.36
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.361 To 0.38
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容7")


                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.28
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.281 To 0.36
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.361 To 0.38
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容7")


                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容16")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "TK05-24"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.27
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.271 To 0.35
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.351 To 0.38
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容7")


                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.27
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.271 To 0.35
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.351 To 0.38
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容7")


                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容16")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "TK05-25"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.28
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.281 To 0.36
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.361 To 0.38
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容7")


                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.28
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.281 To 0.36
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.361 To 0.38
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容7")


                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容16")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "TK112"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.28
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.281 To 0.35
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.351 To 0.38
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.28
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.281 To 0.35
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.351 To 0.38
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容7")


                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容16")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "TK113"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.01
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.011 To 0.28
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.281 To 0.38
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.01
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.011 To 0.28
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.281 To 0.38
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容7")


                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容16")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "TK114"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.26
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.261 To 0.35
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.351 To 0.38
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.26
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.261 To 0.35
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.351 To 0.38
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容7")


                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容16")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "TK115"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.27
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.271 To 0.35
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.351 To 0.38
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.27
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.271 To 0.35
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.351 To 0.38
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容7")


                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容16")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "TK116 "


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.18
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.181 To 0.27
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.271 To 0.35
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.351 To 0.38
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.18
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.181 To 0.27
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.271 To 0.35
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.351 To 0.38
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容17")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "TK117"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.52
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.523 To 0.3
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.301 To 0.38
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.381 To 0.4
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.401 To 1.08
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.52
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.521 To 0.3
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.301 To 0.38
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.381 To 0.4
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.401 To 1.08
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容17")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "TK118"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.24
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.241 To 0.34
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.341 To 0.38
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.24
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.241 To 0.34
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.341 To 0.38
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容16")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "TK119"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.11
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.111 To 0.26
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.261 To 0.34
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.341 To 0.38
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.11
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.111 To 0.26
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.261 To 0.34
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.341 To 0.38
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容17")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If




            Case "TK120"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.003
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.004 To 0.24
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.241 To 0.33
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.331 To 0.38
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.003
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.004 To 0.24
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.241 To 0.33
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.331 To 0.38
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容17")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If





            Case "TK121"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.12
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.121 To 0.28
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.281 To 0.36
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.361 To 0.38
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If


                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.12
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.121 To 0.28
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.281 To 0.36
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.361 To 0.38
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容17")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If





            Case "TK122"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.03
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.031 To 0.3
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.301 To 0.38
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.381 To 0.4
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.401 To 1.08
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.03
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.031 To 0.3
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.301 To 0.38
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.381 To 0.4
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.401 To 1.08
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容17")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If





            Case "TK123"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.032
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.033 To 0.31
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.311 To 0.38
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.381 To 0.4
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.401 To 1.08
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.032
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.033 To 0.31
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.311 To 0.38
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.381 To 0.4
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.41 To 1.08
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容17")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If




            Case "TK124"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.27
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.271 To 0.37
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.371 To 0.38
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.27
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.271 To 0.37
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.371 To 0.38
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容16")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "TK125"


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.26
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.261 To 0.36
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.361 To 0.38
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.381 To 1.08
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.081 To 1.515
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.516 To 3.035
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.036 To 4.544
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.545 To 6.052
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.053 To 7.567
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.568 To 9.074
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 9.075 To 10.593
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.594 To 12.102
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 12.103 To 13.632
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 13.633 To 15.166
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 15.167 To 16.711
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 16.712 To 18.061
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = GAODU * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case GAODU
                        Case 0 To 0.26
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.261 To 0.36
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.361 To 0.38
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.381 To 1.08
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.081 To 1.515
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.516 To 3.035
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.036 To 4.544
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.545 To 6.052
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.053 To 7.567
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.568 To 9.074
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 9.075 To 10.593
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.594 To 12.102
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 12.103 To 13.632
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 13.633 To 15.166
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 15.167 To 16.711
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 16.712 To 18.061
                            haorong = objdataview.Item(0).Row("毫容16")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

                '--------------------------------------OLD CAN





        End Select











        Dim haolixishu As Integer = 0

        haolixishu = gaodu * 1000
        haolixishu = Int(haolixishu) Mod 100 '取出毫厘系数


        up = GAODU + 0.1
        down = GAODU
        up = chendong(up)
        down = chendong(down)



        xiuzheng = ((up - down) / 100 * haolixishu + down) * miduxishu    '此处miduxishu已经-0.0011
        zongrong = mirong + lirong + haorong + siliang
        tiji = (zongrong + xiuzheng) * wenduxishu
        guancun = tiji * miduxishu




        Dim objcommand As New SqlCommand


        objcommand.Connection = objconnection
        objcommand.CommandText = "delete TZ_InventoryData where 油罐编号='" & guanhao & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()





        objcommand.Connection = objconnection
        objcommand.CommandText = "insert into TZ_InventoryData (时间分组值,重量,所属罐区,物料编码,油罐编号,油品名称,打尺深度,油温,气温,备注,盘点时间,盘点人员,标准密度,标准温度,变化系数) values (@时间分组值,@重量,@所属罐区,@物料编码,@油罐编号,@油品名称,@打尺深度,@油温,@气温,@备注,@盘点时间,@盘点人员,@标准密度,@标准温度,@变化系数)"

        objcommand.Parameters.AddWithValue("@所属罐区", guanqu)    '来自于常量赋值
        objcommand.Parameters.AddWithValue("@物料编码", wlbm)     '来自于web services
        objcommand.Parameters.AddWithValue("@油罐编号", guanhao)    '来自于web services

        objcommand.Parameters.AddWithValue("@油品名称", yp)      '来自于web services
        objcommand.Parameters.AddWithValue("@打尺深度", GAODU)   '现场录入
        objcommand.Parameters.AddWithValue("@油温", YOUWEN)

        objcommand.Parameters.AddWithValue("@气温", qiwen)  '不需要
        objcommand.Parameters.AddWithValue("@备注", beizhu)  '现场录入
        objcommand.Parameters.AddWithValue("@重量", (guancun / 1000)) '单位是吨

        objcommand.Parameters.AddWithValue("@盘点时间", Now)     '自动生成
        objcommand.Parameters.AddWithValue("@盘点人员", pandianren) ''来自于web services


        objcommand.Parameters.AddWithValue("@标准密度", bzmd)    ''来自于web services
        objcommand.Parameters.AddWithValue("@标准温度", bzwd)   '常量
        objcommand.Parameters.AddWithValue("@变化系数", bhxs)  '常量
        objcommand.Parameters.AddWithValue("@时间分组值", Now.Date.ToString("yyyyMMdd"))

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
        objconnection.Close()


        Return guancun

    End Function



End Class