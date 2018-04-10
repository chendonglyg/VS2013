Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO

' 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class TZGO_CalculateAndSave
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

    Dim BIAOZHICM, BIAOZHIMM As String



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
    Public Function Calculate(ByVal YP As String, ByVal WLBM As String, ByVal PANDIANREN As String, ByVal GUANQU As String, ByVal BEIZHU As String, ByVal GUANHAO As String, ByVal GAODU As String, ByVal YOUWEN As String, ByVal QIWEN As String, ByVal BZMD As String, ByVal BZWD As String, ByVal BHXS As String, ByVal WDXS As Single) As String
        'Public Function Calculate(ByVal YP As String, ByVal WLBM As String, ByVal PANDIANREN As String, ByVal GUANQU As String, ByVal BEIZHU As String, ByVal GUANHAO As String, ByVal GAODU As String, ByVal YOUWEN As String, ByVal QIWEN As String, ByVal BZMD As String, ByVal BZWD As String, ByVal BHXS As String, ByVal WDXS As Single) As Single

 
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


        mirong = VAL(GAODU)

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

        temp = VAL(GAODU) * 100
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

            Case "T101"


                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.015
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.016 To 0.715
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.716 To 1.269
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.27 To 3.069
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.07 To 4.871
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.872 To 6.672
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.673 To 8.473
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.474 To 10.275
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.276 To 12.077
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 12.078 To 13.578
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.579 To 15.079
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 15.08 To 16.581
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.582 To 18.085
                            lirong = objdataview.Item(0).Row("厘容13")






                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.015
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.016 To 0.715
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.716 To 1.269
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.27 To 3.069
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.07 To 4.871
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.872 To 6.672
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.673 To 8.473
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.474 To 10.275
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.276 To 12.077
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 12.078 To 13.578
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.579 To 15.079
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 15.08 To 16.581
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.582 To 18.085
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T102"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.043
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.044 To 0.743
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.744 To 1.383
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.384 To 3.183
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.184 To 4.985
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.986 To 6.786
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.787 To 8.857
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.858 To 10.389
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.39 To 12.191
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 12.192 To 13.692
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.693 To 15.193
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 15.194 To 16.695
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.696 To 18.199
                            lirong = objdataview.Item(0).Row("厘容13")






                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                              Case 0 To 0.043
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.044 To 0.743
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.744 To 1.383
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.384 To 3.183
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.184 To 4.985
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.986 To 6.786
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.787 To 8.857
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.858 To 10.389
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.39 To 12.191
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 12.192 To 13.692
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.693 To 15.193
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 15.194 To 16.695
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.696 To 18.199
                            haorong = objdataview.Item(0).Row("毫容13")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T102"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.043
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.044 To 0.743
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.744 To 1.383
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.384 To 3.183
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.184 To 4.985
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.986 To 6.786
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.787 To 8.857
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.858 To 10.389
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.39 To 12.191
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 12.192 To 13.692
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.693 To 15.193
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 15.194 To 16.695
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.696 To 18.199
                            lirong = objdataview.Item(0).Row("厘容13")






                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.043
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.044 To 0.743
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.744 To 1.383
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.384 To 3.183
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.184 To 4.985
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.986 To 6.786
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.787 To 8.857
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.858 To 10.389
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.39 To 12.191
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 12.192 To 13.692
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.693 To 15.193
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 15.194 To 16.695
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.696 To 18.199
                            haorong = objdataview.Item(0).Row("毫容13")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T103"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.035
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.036 To 0.735
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.736 To 1.395
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.396 To 3.196
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.197 To 4.997
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.998 To 6.798
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.799 To 8.899
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.86 To 10.401
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.402 To 12.203
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 12.204 To 13.704
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.705 To 15.205
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 15.206 To 16.707
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.708 To 18.211
                            lirong = objdataview.Item(0).Row("厘容13")






                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.035
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.036 To 0.735
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.736 To 1.395
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.396 To 3.196
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.197 To 4.997
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.998 To 6.798
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.799 To 8.899
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.86 To 10.401
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.402 To 12.203
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 12.204 To 13.704
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.705 To 15.205
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 15.206 To 16.707
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.708 To 18.211
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "T104"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.008
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.009 To 0.708
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.709 To 1.307
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.308 To 3.107
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.108 To 4.909
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.91 To 6.71
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.711 To 8.511
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.512 To 10.313
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.314 To 12.115
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 12.116 To 13.616
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.617 To 15.117
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 15.118 To 16.619
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.62 To 18.123
                            lirong = objdataview.Item(0).Row("厘容13")






                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.008
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.009 To 0.708
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.709 To 1.307
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.308 To 3.107
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.108 To 4.909
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.91 To 6.71
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.711 To 8.511
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.512 To 10.313
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.314 To 12.115
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 12.116 To 13.616
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.617 To 15.117
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 15.118 To 16.619
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.62 To 18.123
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T105"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.016
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.017 To 0.716
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.717 To 1.386
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.387 To 3.186
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.187 To 4.988
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.989 To 6.789
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.79 To 8.59
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.591 To 10.392
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.393 To 12.194
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 12.195 To 13.695
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.696 To 15.196
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 15.197 To 16.698
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.699 To 18.202
                            lirong = objdataview.Item(0).Row("厘容13")






                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.016
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.017 To 0.716
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.717 To 1.386
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.387 To 3.186
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.187 To 4.988
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.989 To 6.789
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.79 To 8.59
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.591 To 10.392
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.393 To 12.194
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 12.195 To 13.695
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.696 To 15.196
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 15.197 To 16.698
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.699 To 18.202
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "T106"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.013
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.014 To 0.713
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.714 To 1.099
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.01 To 2.611
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.612 To 4.126
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.127 To 5.637
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.638 To 7.152
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.153 To 8.672
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.673 To 10.187
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.188 To 11.707
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.708 To 13.212
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.213 To 14.718
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 14.719 To 16.233
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 16.234 To 17.753
                            lirong = objdataview.Item(0).Row("厘容14")






                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.013
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.014 To 0.713
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.714 To 1.099
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.01 To 2.611
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.612 To 4.126
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.127 To 5.637
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.638 To 7.152
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.153 To 8.672
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.673 To 10.187
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.188 To 11.707
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.708 To 13.212
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.213 To 14.718
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 14.719 To 16.233
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 16.234 To 17.753
                            haorong = objdataview.Item(0).Row("毫容14")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T107"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.003
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.004 To 0.703
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.704 To 1.083
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.084 To 2.595
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.596 To 4.11
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.111 To 5.621
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.622 To 7.136
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.137 To 8.656
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.657 To 10.171
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.172 To 11.691
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.692 To 13.196
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.197 To 14.702
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 14.703 To 16.217
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 16.218 To 17.737
                            lirong = objdataview.Item(0).Row("厘容14")





                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.003
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.004 To 0.703
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.704 To 1.083
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.084 To 2.595
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.596 To 4.11
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.111 To 5.621
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.622 To 7.136
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.137 To 8.656
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.657 To 10.171
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.172 To 11.691
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.692 To 13.196
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.197 To 14.702
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 14.703 To 16.217
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 16.218 To 17.737
                            haorong = objdataview.Item(0).Row("毫容14")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T108"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.01
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.011 To 0.7
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.701 To 1.15
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.151 To 2.66
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.661 To 4.17
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.171 To 5.688
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.689 To 7.189
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.19 To 8.709
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.71 To 10.233
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.234 To 11.743
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.744 To 13.253
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.254 To 15.218
                            lirong = objdataview.Item(0).Row("厘容12")

                     






                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                                  Case 0 To 0.01
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.011 To 0.7
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.701 To 1.15
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.151 To 2.66
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.661 To 4.17
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.171 To 5.688
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.689 To 7.189
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.19 To 8.709
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.71 To 10.233
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.234 To 11.743
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.744 To 13.253
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.254 To 15.218
                            haorong = objdataview.Item(0).Row("毫容12")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T109"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.135
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.136 To 0.735
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.736 To 1.187
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.188 To 2.697
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.698 To 4.207
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.208 To 6.725
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.726 To 7.226
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.227 To 8.746
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.747 To 10.27
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.271 To 11.78
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.78 To 13.29
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.291 To 15.255
                            lirong = objdataview.Item(0).Row("厘容12")







                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                       Case 0 To 0.135
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.136 To 0.735
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.736 To 1.187
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.188 To 2.697
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.698 To 4.207
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.208 To 6.725
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.726 To 7.226
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.227 To 8.746
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.747 To 10.27
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.271 To 11.78
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.78 To 13.29
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.291 To 15.255
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T110"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.01
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.011 To 0.7
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.701 To 1.15
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.15 To 2.66
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.661 To 4.17
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.171 To 5.688
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.689 To 7.189
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.19 To 8.709
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.71 To 10.233
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.234 To 11.743
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.744 To 13.253
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.254 To 15.218
                            lirong = objdataview.Item(0).Row("厘容12")

                    





                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                           Case 0 To 0.01
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.011 To 0.7
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.701 To 1.15
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.15 To 2.66
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.661 To 4.17
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.171 To 5.688
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.689 To 7.189
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.19 To 8.709
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.71 To 10.233
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.234 To 11.743
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.744 To 13.253
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.254 To 15.218
                            haorong = objdataview.Item(0).Row("毫容12")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T111"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.106
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.107 To 0.706
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.707 To 1.156
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.157 To 2.666
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.667 To 4.176
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.177 To 5.694
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.695 To 7.195
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.196 To 8.715
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.716 To 10.239
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.24 To 11.749
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.75 To 13.259
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.26 To 15.224
                            lirong = objdataview.Item(0).Row("厘容12")

                       






                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                       Case 0 To 0.106
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.107 To 0.706
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.707 To 1.156
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.157 To 2.666
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.667 To 4.176
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.177 To 5.694
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.695 To 7.195
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.196 To 8.715
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.716 To 10.239
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.24 To 11.749
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.75 To 13.259
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.26 To 15.224
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

                '-----------------------------------------------以上T1系，以下T2系----------------------------------------------


            Case "T201"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.616
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.617 To 1.016
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 1.017 To 1.146
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.147 To 1.206
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.207 To 1.331
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.332 To 1.391
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.392 To 2.526
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.527 To 4.037
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.038 To 5.545
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 5.546 To 7.052
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.053 To 8.552
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 8.553 To 10.058
                            lirong = objdataview.Item(0).Row("厘容12")


                        Case 10.059 To 11.568
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 11.569 To 13.068
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.069 To 14.564
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 14.565 To 16.068
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.069 To 17.573
                            lirong = objdataview.Item(0).Row("厘容17")





                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.616
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.617 To 1.016
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 1.017 To 1.146
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.147 To 1.206
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.207 To 1.331
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.332 To 1.391
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.392 To 2.526
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.527 To 4.037
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 4.038 To 5.545
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 5.546 To 7.052
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.053 To 8.552
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 8.553 To 10.058
                            haorong = objdataview.Item(0).Row("毫容12")


                        Case 10.059 To 11.568
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 11.569 To 13.068
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.069 To 14.564
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 14.565 To 16.068
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.069 To 17.573
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T202"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.4
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.401 To 1.1
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 1.101 To 1.7
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.701 To 1.757
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.758 To 1.957
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.958 To 2.016
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 2.017 To 2.61
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.611 To 4.128
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.129 To 5.638
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 5.639 To 7.153
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.154 To 8.667
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 8.668 To 10.187
                            lirong = objdataview.Item(0).Row("厘容12")


                        Case 10.188 To 11.707
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 11.708 To 13.21
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.211 To 14.71
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 14.711 To 16.215
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.216 To 17.72
                            lirong = objdataview.Item(0).Row("厘容17")





                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.4
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.401 To 1.1
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 1.101 To 1.7
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.701 To 1.757
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.758 To 1.957
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.958 To 2.016
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 2.017 To 2.61
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.611 To 4.128
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 4.129 To 5.638
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 5.639 To 7.153
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.154 To 8.667
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 8.668 To 10.187
                            haorong = objdataview.Item(0).Row("毫容12")


                        Case 10.188 To 11.707
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 11.708 To 13.21
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.211 To 14.71
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 14.711 To 16.215
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.216 To 17.72
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


                '---------------------------------------以上T2系，以下T3系-------------------------------
            Case "T301"


                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.621
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.622 To 1.381
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 1.382 To 3.181
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 3.182 To 4.981
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 4.982 To 6.781
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 6.782 To 8.581
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 8.582 To 10.091
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 10.092 To 11.596
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 11.597 To 13.101
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 13.102 To 14.606
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 14.607 To 16.111
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 16.112 To 17.616
                            lirong = objdataview.Item(0).Row("厘容12")


                  





                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                                 Case 0 To 0.621
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.622 To 1.381
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 1.382 To 3.181
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 3.182 To 4.981
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 4.982 To 6.781
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 6.782 To 8.581
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 8.582 To 10.091
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 10.092 To 11.596
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 11.597 To 13.101
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 13.102 To 14.606
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 14.607 To 16.111
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 16.112 To 17.616
                            haorong = objdataview.Item(0).Row("毫容12")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T302"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.132
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.133 To 0.832
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.833 To 1.382
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.383 To 3.183
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.184 To 4.984
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.985 To 6.785
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.786 To 8.586
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.587 To 10.087
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.088 To 11.588
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.589 To 13.089
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.09 To 14.59
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.591 To 16.091
                            lirong = objdataview.Item(0).Row("厘容12")








                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.132
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.133 To 0.832
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.833 To 1.382
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.383 To 3.183
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.184 To 4.984
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.985 To 6.785
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.786 To 8.586
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.587 To 10.087
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.088 To 11.588
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.589 To 13.089
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.09 To 14.59
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.591 To 16.091
                            haorong = objdataview.Item(0).Row("毫容12")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If




            Case "T303"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.044
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.045 To 0.744
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.745 To 1.395
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.396 To 3.196
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.197 To 4.997
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.998 To 6.798
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.799 To 8.599
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.6 To 10.1
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.101 To 11.601
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.602 To 13.102
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.103 To 14.603
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.604 To 16.104
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.105 To 17.606
                            lirong = objdataview.Item(0).Row("厘容13")






                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.044
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.045 To 0.744
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.745 To 1.395
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.396 To 3.196
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.197 To 4.997
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.998 To 6.798
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.799 To 8.599
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.6 To 10.1
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.101 To 11.601
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.602 To 13.102
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.103 To 14.603
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.604 To 16.104
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.105 To 17.606
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If




            Case "T304"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.042
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.043 To 0.742
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.743 To 1.382
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.383 To 3.183
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.184 To 4.984
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.985 To 6.785
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.786 To 8.586
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.587 To 10.087
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.088 To 11.588
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.589 To 13.089
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.09 To 14.59
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.591 To 16.091
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.092 To 17.593
                            lirong = objdataview.Item(0).Row("厘容13")






                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.042
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.043 To 0.742
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.743 To 1.382
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.383 To 3.183
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.184 To 4.984
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.985 To 6.785
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.786 To 8.586
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.587 To 10.087
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.088 To 11.588
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.589 To 13.089
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.09 To 14.59
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.591 To 16.091
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.092 To 17.593
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T305"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.635
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.636 To 1
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 1.001 To 1.011
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.012 To 1.1
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.101 To 1.25
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.251 To 1.35
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.351 To 2.519
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.52 To 4.036
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.037 To 5.548
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 5.549 To 7.064
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.065 To 8.576
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 8.577 To 10.096
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.097 To 11.616
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 11.617 To 13.123
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.124 To 14.63
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 14.631 To 16.135
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.136 To 17.64
                            lirong = objdataview.Item(0).Row("厘容17")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.635
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.636 To 1
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 1.001 To 1.011
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.012 To 1.1
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.101 To 1.25
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.251 To 1.35
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.351 To 2.519
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.52 To 4.036
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 4.037 To 5.548
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 5.549 To 7.064
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.065 To 8.576
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 8.577 To 10.096
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.097 To 11.616
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 11.617 To 13.123
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.124 To 14.63
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 14.631 To 16.135
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.136 To 17.64
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "T306"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.4
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.401 To 1.076
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 1.077 To 1.7
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.701 To 1.76
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.761 To 1.95
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.951 To 2.01
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 2.011 To 2.584
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.585 To 4.101
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.102 To 5.613
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 5.614 To 7.129
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.13 To 8.641
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 8.642 To 10.161
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.162 To 11.681
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 11.682 To 13.188
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.189 To 14.695
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 14.696 To 16.2
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.201 To 17.705
                            lirong = objdataview.Item(0).Row("厘容17")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                                Case 0 To 0.4
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.401 To 1.076
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 1.077 To 1.7
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.701 To 1.76
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.761 To 1.95
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.951 To 2.01
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 2.011 To 2.584
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.585 To 4.101
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 4.102 To 5.613
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 5.614 To 7.129
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.13 To 8.641
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 8.642 To 10.161
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.162 To 11.681
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 11.682 To 13.188
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.189 To 14.695
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 14.696 To 16.2
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.201 To 17.705
                            haorong = objdataview.Item(0).Row("毫容17")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
                '----------------------------以上T3系，以下T5系------------------------------------

            Case "T501"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.135
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.136 To 0.835
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.836 To 1.395
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.396 To 3.197
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.198 To 4.998
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.999 To 6.799
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.8 To 8.6
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.601 To 10.101
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.102 To 11.603
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.604 To 13.104
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.105 To 14.605
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.606 To 16.106
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.107 To 17.609
                            lirong = objdataview.Item(0).Row("厘容13")

                 




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.135

                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.136 To 0.835
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.836 To 1.395
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.396 To 3.197
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.198 To 4.998
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.999 To 6.799
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.8 To 8.6
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.601 To 10.101
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.102 To 11.603
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.604 To 13.104
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.105 To 14.605
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.606 To 16.106
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.107 To 17.609
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "T502"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.04
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.041 To 0.74
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.741 To 1.4
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.41 To 3.202
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.203 To 5.003
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.004 To 6.804
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.805 To 8.605
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.606 To 10.106
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.107 To 11.608
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.609 To 13.109
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.11 To 14.61
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.611 To 16.111
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.112 To 17.614
                            lirong = objdataview.Item(0).Row("厘容13")






                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.04
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.041 To 0.74
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.741 To 1.4
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.41 To 3.202
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.203 To 5.003
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.004 To 6.804
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.805 To 8.605
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.606 To 10.106
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.107 To 11.608
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.609 To 13.109
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.11 To 14.61
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.611 To 16.111
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.112 To 17.614
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T503"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.033
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.034 To 0.733
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.734 To 1.393
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.394 To 3.195
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.196 To 4.996
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.997 To 6.797
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.798 To 8.598
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.599 To 10.099
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.1 To 11.601
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.602 To 13.102
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.103 To 14.603
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.604 To 16.104
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.105 To 17.607
                            lirong = objdataview.Item(0).Row("厘容13")






                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.033
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.034 To 0.733
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.734 To 1.393
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.394 To 3.195
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.196 To 4.996
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.997 To 6.797
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.798 To 8.598
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.599 To 10.099
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.1 To 11.601
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.602 To 13.102
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.103 To 14.603
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.604 To 16.104
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.105 To 17.607
                            haorong = objdataview.Item(0).Row("毫容13")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T504"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.057
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.058 To 0.757
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.758 To 1.417
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.418 To 3.219
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.22 To 5.02
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.021 To 6.821
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.822 To 8.622
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.623 To 10.123
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.124 To 11.625
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.626 To 13.126
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.127 To 14.627
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.628 To 16.128
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.129 To 17.631
                            lirong = objdataview.Item(0).Row("厘容13")






                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.057
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.058 To 0.757
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.758 To 1.417
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.418 To 3.219
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.22 To 5.02
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.021 To 6.821
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.822 To 8.622
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.623 To 10.123
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.124 To 11.625
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.626 To 13.126
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.127 To 14.627
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.628 To 16.128
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.129 To 17.631
                            haorong = objdataview.Item(0).Row("毫容13")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T505"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.256
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.257 To 0.856
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.857 To 1.066
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.067 To 2.576
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.577 To 4.094
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.095 To 5.606
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.607 To 7.123
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.124 To 8.638
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.639 To 10.163
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.164 To 11.685
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.686 To 13.193
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.194 To 14.7
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 14.701 To 16.21
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 16.211 To 17.715
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.256
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.257 To 0.856
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.857 To 1.066
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.067 To 2.576
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.577 To 4.094
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.095 To 5.606
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.607 To 7.123
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.124 To 8.638
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.639 To 10.163
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.164 To 11.685
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.686 To 13.193
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.194 To 14.7
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 14.701 To 16.21
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 16.211 To 17.715
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T506"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.7
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.701 To 1.06
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 1.061 To 2.57
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 2.571 To 4.088
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 4.089 To 5.6
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.601 To 7.117
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 7.118 To 8.632
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.633 To 10.157
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.158 To 11.679
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.68 To 13.187
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.188 To 14.694
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.695 To 16.204
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.205 To 17.709
                            lirong = objdataview.Item(0).Row("厘容13")






                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.7
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.701 To 1.06
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 1.061 To 2.57
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 2.571 To 4.088
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 4.089 To 5.6
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.601 To 7.117
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 7.118 To 8.632
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.633 To 10.157
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.158 To 11.679
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.68 To 13.187
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.188 To 14.694
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.695 To 16.204
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.205 To 17.709
                            haorong = objdataview.Item(0).Row("毫容13")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "T507"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.7
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.701 To 1.045
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 1.046 To 2.555
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 2.556 To 4.073
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 4.074 To 5.585
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.586 To 7.102
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 7.103 To 8.617
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.618 To 10.142
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.143 To 11.664
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.665 To 13.172
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.173 To 14.679
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.68 To 16.189
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.19 To 17.694
                            lirong = objdataview.Item(0).Row("厘容13")






                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                                        Case 0 To 0.7
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.701 To 1.045
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 1.046 To 2.555
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 2.556 To 4.073
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 4.074 To 5.585
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.586 To 7.102
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 7.103 To 8.617
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.618 To 10.142
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.143 To 11.664
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.665 To 13.172
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.173 To 14.679
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.68 To 16.189
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.19 To 17.694
                            haorong = objdataview.Item(0).Row("毫容13")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "T508"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.667
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.668 To 1.067
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 1.068 To 1.19
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.191 To 1.26
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.261 To 1.4
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.401 To 1.47
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.471 To 2.577
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.578 To 4.095
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.096 To 5.607
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 5.608 To 7.124
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.125 To 8.639
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 8.64 To 10.164
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.165 To 11.686
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 11.687 To 13.194
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.195 To 14.701
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 14.702 To 16.211
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.212 To 17.716
                            lirong = objdataview.Item(0).Row("厘容17")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.667
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.668 To 1.067
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 1.068 To 1.19
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.191 To 1.26
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.261 To 1.4
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.401 To 1.47
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.471 To 2.577
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.578 To 4.095
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 4.096 To 5.607
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 5.608 To 7.124
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.125 To 8.639
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 8.64 To 10.164
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.165 To 11.686
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 11.687 To 13.194
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.195 To 14.701
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 14.702 To 16.211
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.212 To 17.716
                            haorong = objdataview.Item(0).Row("毫容17")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T509"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.667
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.668 To 1.075
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 1.076 To 1.2
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.201 To 1.26
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.261 To 1.41
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.411 To 1.47
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.471 To 2.585
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.586 To 4.103
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.104 To 5.615
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 5.616 To 7.132
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.133 To 8.647
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 8.648 To 10.172
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.173 To 11.694
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 11.695 To 13.202
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.203 To 14.709
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 14.71 To 16.219
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.22 To 17.724
                            lirong = objdataview.Item(0).Row("厘容17")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                              Case 0 To 0.667
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.668 To 1.075
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 1.076 To 1.2
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.201 To 1.26
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.261 To 1.41
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.411 To 1.47
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.471 To 2.585
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.586 To 4.103
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 4.104 To 5.615
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 5.616 To 7.132
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.133 To 8.647
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 8.648 To 10.172
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.173 To 11.694
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 11.695 To 13.202
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.203 To 14.709
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 14.71 To 16.219
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.22 To 17.724
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T510"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.66
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.661 To 0.696
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.697 To 1.067
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.068 To 1.27
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.271 To 1.4
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.401 To 1.47
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.471 To 2.577
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.578 To 4.095
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.096 To 5.607
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 5.608 To 7.124
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.125 To 8.639
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 8.64 To 10.164
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.165 To 11.686
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 11.687 To 13.194
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.195 To 14.701
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 14.702 To 16.211
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.212 To 17.716
                            lirong = objdataview.Item(0).Row("厘容17")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                                Case 0 To 0.66
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.661 To 0.696
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.697 To 1.067
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.068 To 1.27
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.271 To 1.4
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.401 To 1.47
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.471 To 2.577
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.578 To 4.095
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 4.096 To 5.607
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 5.608 To 7.124
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.125 To 8.639
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 8.64 To 10.164
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.165 To 11.686
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 11.687 To 13.194
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.195 To 14.701
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 14.702 To 16.211
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.212 To 17.716
                            haorong = objdataview.Item(0).Row("毫容17")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "T511"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.578
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.579 To 0.921
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.922 To 0.978
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.979 To 0.981
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.982 To 1.111
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.112 To 1.171
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.172 To 2.488
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.489 To 3.999
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4 To 5.507
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 5.508 To 7.014
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.015 To 8.514
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 8.515 To 10.02
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.021 To 11.53
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 11.531 To 13.026
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.027 To 14.526
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 14.527 To 16.03
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.031 To 17.535
                            lirong = objdataview.Item(0).Row("厘容17")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.578
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.579 To 0.921
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.922 To 0.978
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.979 To 0.981
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.982 To 1.111
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.112 To 1.171
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.172 To 2.488
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.489 To 3.999
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 4 To 5.507
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 5.508 To 7.014
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.015 To 8.514
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 8.515 To 10.02
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.021 To 11.53
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 11.531 To 13.026
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.027 To 14.526
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 14.527 To 16.03
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.031 To 17.535
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T512"
                If objdataview.Count >= 1 Then
                    Select Case Val(VAL(GAODU))
                        Case 0 To 0.58
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.581 To 0.965
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.966 To 1.52
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.521 To 1.585
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.586 To 1.72
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.721 To 1.785
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.786 To 2.475
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.476 To 3.993
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 3.994 To 5.505
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 5.506 To 7.022

                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.023 To 8.537
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 8.538 To 10.062
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.063 To 11.584
                            lirong = objdataview.Item(0).Row("厘容13")
                        Case 11.585 To 13.092
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.093 To 14.599
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 14.6 To 16.104
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.105 To 17.609
                            lirong = objdataview.Item(0).Row("厘容17")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select


                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If



                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                         Case 0 To 0.58
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.581 To 0.965
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.966 To 1.52
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.521 To 1.585
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.586 To 1.72
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.721 To 1.785
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.786 To 2.475
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.476 To 3.993
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 3.994 To 5.505
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 5.506 To 7.022
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.023 To 8.537
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 8.538 To 10.062
                            haorong = objdataview.Item(0).Row("毫容12")
                            BIAOZHIMM = "到过MM" & haorong
                        Case 10.063 To 11.584
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 11.585 To 13.092
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.093 To 14.599
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 14.6 To 16.104
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.105 To 17.609
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T513"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.586
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.587 To 0.986
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.987 To 1.133
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.134 To 1.193
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.194 To 1.323
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.324 To 1.383
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.384 To 2.496
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.497 To 4.007
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.008 To 5.515
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 5.516 To 7.022
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.023 To 8.522
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 8.523 To 10.028
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.029 To 11.538
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 11.539 To 13.038
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.039 To 14.534
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 14.535 To 16.038
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.039 To 17.543
                            lirong = objdataview.Item(0).Row("厘容17")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.586
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.587 To 0.986
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.987 To 1.133
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.134 To 1.193
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.194 To 1.323
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.324 To 1.383
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.384 To 2.496
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.497 To 4.007
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 4.008 To 5.515
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 5.516 To 7.022
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.023 To 8.522
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 8.523 To 10.028
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.029 To 11.538
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 11.539 To 13.038
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.039 To 14.534
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 14.535 To 16.038
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.039 To 17.543
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If




            Case "T514"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.4
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.401 To 1
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 1.001 To 1.7
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.701 To 1.76
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.761 To 1.96
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.961 To 2.02
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 2.021 To 2.51
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.511 To 4.028
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.029 To 5.54
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 5.541 To 7.057
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.058 To 8.572
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 8.573 To 10.097
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.098 To 11.619
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 11.62 To 13.127
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.128 To 14.634
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 14.635 To 16.139
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.14 To 17.644
                            lirong = objdataview.Item(0).Row("厘容17")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                                   Case 0 To 0.4
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.401 To 1
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 1.001 To 1.7
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.701 To 1.76
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.761 To 1.96
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.961 To 2.02
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 2.021 To 2.51
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.511 To 4.028
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 4.029 To 5.54
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 5.541 To 7.057
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.058 To 8.572
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 8.573 To 10.097
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.098 To 11.619
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 11.62 To 13.127
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.128 To 14.634
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 14.635 To 16.139
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.14 To 17.644
                            haorong = objdataview.Item(0).Row("毫容17")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T515"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.657
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.658 To 0.955
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.956 To 1.1
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.101 To 1.16
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.161 To 1.29
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.291 To 1.35
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.351 To 2.465
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.466 To 3.976
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 3.977 To 5.484
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 5.485 To 6.991
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 6.992 To 8.491
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 8.492 To 9.997
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 9.998 To 11.507
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 11.508 To 13.017
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.018 To 14.513
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 14.514 To 16.017
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.018 To 17.552
                            lirong = objdataview.Item(0).Row("厘容17")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.657
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.658 To 0.955
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.956 To 1.1
                            lirong = objdataview.Item(0).Row("毫容3")

                        Case 1.101 To 1.16
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.161 To 1.29
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.291 To 1.35
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.351 To 2.465
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.466 To 3.976
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 3.977 To 5.484
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 5.485 To 6.991
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 6.992 To 8.491
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 8.492 To 9.997
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 9.998 To 11.507
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 11.508 To 13.017
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.018 To 14.513
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 14.514 To 16.017
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.018 To 17.552
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "T516"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.57
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.571 To 0.929
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.93 To 1
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.001 To 1.1
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.101 To 1.25
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.251 To 1.35
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.351 To 2.447
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.448 To 3.959
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 3.96 To 5.476
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 5.477 To 6.991
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 6.992 To 8.516
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 8.517 To 10.038
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.039 To 11.546
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 11.547 To 13.053
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.054 To 14.558
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 14.559 To 16.063
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.064 To 17.568
                            lirong = objdataview.Item(0).Row("厘容17")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.57
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.571 To 0.929
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.93 To 1
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.001 To 1.1
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.101 To 1.25
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.251 To 1.35
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.351 To 2.447
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.448 To 3.959
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 3.96 To 5.476
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 5.477 To 6.991
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 6.992 To 8.516
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 8.517 To 10.038
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.039 To 11.546
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 11.547 To 13.053
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.054 To 14.558
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 14.559 To 16.063
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.064 To 17.568
                            haorong = objdataview.Item(0).Row("毫容17")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T517"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.76
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.761 To 0.776
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.777 To 1.176
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.177 To 2.676
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.677 To 4.176
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.177 To 5.676
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.677 To 7.176
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.177 To 8.676
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.677 To 10.176
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.177 To 11.676
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.677 To 13.176
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.177 To 14.676
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 14.677 To 16.176
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 14.177 To 17.676
                            lirong = objdataview.Item(0).Row("厘容14")



                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                                 Case 0 To 0.76
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.761 To 0.776
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.777 To 1.176
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.177 To 2.676
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.677 To 4.176
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.177 To 5.676
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.677 To 7.176
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.177 To 8.676
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.677 To 10.176
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.177 To 11.676
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.677 To 13.176
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.177 To 14.676
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 14.677 To 16.176
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 14.177 To 17.676
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "T518"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.081
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.082 To 0.781
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.782 To 1.186
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.187 To 2.704
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.705 To 4.216
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.217 To 5.733
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.734 To 7.248
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.249 To 8.773
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.774 To 10.295
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.296 To 11.803
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.804 To 13.31
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.311 To 14.815
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 14.816 To 17.825
                            lirong = objdataview.Item(0).Row("厘容13")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.081
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.082 To 0.781
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.782 To 1.186
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.187 To 2.704
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.705 To 4.216
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.217 To 5.733
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.734 To 7.248
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.249 To 8.773
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.774 To 10.295
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.296 To 11.803
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.804 To 13.31
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.311 To 14.815
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 14.816 To 17.825
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "T519"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.1
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.101 To 0.8
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.801 To 1.133
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.134 To 1.193
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.194 To 1.204
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.205 To 1.323
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.324 To 1.384
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.385 To 2.722
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.723 To 4.234
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.235 To 5.751
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.752 To 7.266
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.267 To 8.791
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.792 To 10.313
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.314 To 11.821
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.822 To 13.328
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 13.329 To 14.833
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 14.834 To 16.338
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case 16.339 To 17.843
                            lirong = objdataview.Item(0).Row("厘容18")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.1
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.101 To 0.8
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.801 To 1.133
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.134 To 1.193
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.194 To 1.204
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.205 To 1.323
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.324 To 1.384
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.385 To 2.722
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.723 To 4.234
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.235 To 5.751
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.752 To 7.266
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.267 To 8.791
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.792 To 10.313
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.314 To 11.821
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.822 To 13.328
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 13.329 To 14.833
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 14.834 To 16.338
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case 16.339 To 17.843
                            haorong = objdataview.Item(0).Row("毫容18")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If





            Case "T520"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.08
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.081 To 0.77
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.771 To 1.131
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.132 To 1.17
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.171 To 1.191
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.192 To 1.321
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.322 To 1.381
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.382 To 2.67
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.671 To 4.17
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.171 To 5.67
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.671 To 7.17
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.171 To 8.67
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.671 To 10.17
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.171 To 11.67
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.671 To 13.17
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 13.171 To 14.67
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 14.671 To 16.17
                            lirong = objdataview.Item(0).Row("厘容17")


                        Case 16.171 To 17.67
                            lirong = objdataview.Item(0).Row("厘容18")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.08
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.081 To 0.77
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.771 To 1.131
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.132 To 1.17
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.171 To 1.191
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.192 To 1.321
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.322 To 1.381
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.382 To 2.67
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.671 To 4.17
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.171 To 5.67
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.671 To 7.17
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.171 To 8.67
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.671 To 10.17
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.171 To 11.67
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.671 To 13.17
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 13.171 To 14.67
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 14.671 To 16.17
                            haorong = objdataview.Item(0).Row("毫容17")


                        Case 16.171 To 17.67
                            haorong = objdataview.Item(0).Row("毫容18")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T521"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.303
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.304 To 0.983
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.984 To 1.133
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.134 To 1.193
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.194 To 1.323
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.324 To 1.383
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.384 To 2.667
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.668 To 4.167
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.168 To 5.667
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 5.668 To 7.167
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.168 To 8.667
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 8.668 To 10.167
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.168 To 11.667
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 11.668 To 13.167
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.168 To 14.667
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 14.668 To 16.167
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.168 To 17.667
                            lirong = objdataview.Item(0).Row("厘容17")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.303
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.304 To 0.983
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.984 To 1.133
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.134 To 1.193
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.194 To 1.323
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.324 To 1.383
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.384 To 2.667
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.668 To 4.167
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 4.168 To 5.667
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 5.668 To 7.167
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.168 To 8.667
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 8.668 To 10.167
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.168 To 11.667
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 11.668 To 13.167
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.168 To 14.667
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 14.668 To 16.167
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.168 To 17.667
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T522"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.1
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.101 To 0.8
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.801 To 1.133
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.134 To 1.183
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.184 To 1.193
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.194 To 1.323
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.324 To 1.383
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.384 To 2.683
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.684 To 4.183
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.184 To 5.683
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.684 To 7.183
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.184 To 8.683
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.684 To 10.183
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.184 To 11.683
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.684 To 13.183
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 13.184 To 14.683
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 14.684 To 16.183
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case 16.184 To 17.683
                            lirong = objdataview.Item(0).Row("厘容18")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.1
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.101 To 0.8
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.801 To 1.133
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.134 To 1.183
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.184 To 1.193
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.194 To 1.323
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.324 To 1.383
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.384 To 2.683
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.684 To 4.183
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.184 To 5.683
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.684 To 7.183
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.184 To 8.683
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.684 To 10.183
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.184 To 11.683
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.684 To 13.183
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 13.184 To 14.683
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 14.684 To 16.183
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case 16.184 To 17.683
                            haorong = objdataview.Item(0).Row("毫容18")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T523"


                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.087
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.088 To 0.787
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.788 To 1.029
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.03 To 1.187
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.188 To 1.189
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.19 To 1.319
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.32 To 1.379
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.38 To 2.687
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.688 To 4.187
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.188 To 5.687
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.688 To 7.187
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.188 To 8.687
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.688 To 10.187
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.188 To 11.687
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.688 To 13.187
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 13.188 To 14.687
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 14.688 To 16.187
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case 16.188 To 17.687
                            lirong = objdataview.Item(0).Row("厘容18")

                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.087
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.088 To 0.787
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.788 To 1.029
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.03 To 1.187
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.188 To 1.189
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.19 To 1.319
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.32 To 1.379
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.38 To 2.687
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.688 To 4.187
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.188 To 5.687
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.688 To 7.187
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.188 To 8.687
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.688 To 10.187
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.188 To 11.687
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.688 To 13.187
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 13.188 To 14.687
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 14.688 To 16.187
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case 16.188 To 17.687
                            haorong = objdataview.Item(0).Row("毫容18")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T524"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.1
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.101 To 0.8
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.801 To 1.133
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.134 To 1.157
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.158 To 1.193
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.194 To 1.323
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.324 To 1.383
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.384 To 2.657
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.658 To 4.157
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.158 To 5.657
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.658 To 7.157
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.158 To 8.657
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.658 To 10.157
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.158 To 11.657
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.658 To 13.157
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 13.158 To 14.657
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 14.658 To 16.157
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case 16.158 To 17.657
                            lirong = objdataview.Item(0).Row("厘容18")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.1
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.101 To 0.8
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.801 To 1.133
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.134 To 1.157
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.158 To 1.193
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.194 To 1.323
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.324 To 1.383
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.384 To 2.657
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.658 To 4.157
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.158 To 5.657
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.658 To 7.157
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.158 To 8.657
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.658 To 10.157
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.158 To 11.657
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.658 To 13.157
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 13.158 To 14.657
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 14.658 To 16.157
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case 16.158 To 17.657
                            haorong = objdataview.Item(0).Row("毫容18")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If




                '--------------------------------以上T5系，以下T005系---------------------------------------
            Case "T005-1"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.14
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.141 To 2.1
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 2.101 To 4.06
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 4.061 To 6.02
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 6.021 To 7.98
                            lirong = objdataview.Item(0).Row("厘容5")

         


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.14
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.141 To 2.1
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 2.101 To 4.06
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 4.061 To 6.02
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 6.021 To 7.98
                            haorong = objdataview.Item(0).Row("毫容5")

                   

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "T005-2"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.14
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.141 To 2.1
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 2.101 To 4.06
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 4.061 To 6.02
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 6.021 To 7.975
                            lirong = objdataview.Item(0).Row("厘容5")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.14
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.141 To 2.1
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 2.101 To 4.06
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 4.061 To 6.02
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 6.021 To 7.975
                            haorong = objdataview.Item(0).Row("毫容5")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "T005-3"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.14
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.141 To 2.1
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 2.101 To 4.06
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 4.061 To 6.02
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 6.021 To 7.972
                            lirong = objdataview.Item(0).Row("厘容5")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.14
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.141 To 2.1
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 2.101 To 4.06
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 4.061 To 6.02
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 6.021 To 7.972
                            haorong = objdataview.Item(0).Row("毫容5")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "T005-4"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.14
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.141 To 2.1
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 2.101 To 4.06
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 4.061 To 6.02
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 6.021 To 7.974
                            lirong = objdataview.Item(0).Row("厘容5")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.14
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.141 To 2.1
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 2.101 To 4.06
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 4.061 To 6.02
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 6.021 To 7.974
                            haorong = objdataview.Item(0).Row("毫容5")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T005-5"
                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.14
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.141 To 2.1
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 2.101 To 4.06
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 4.061 To 6.02
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 6.021 To 7.976
                            lirong = objdataview.Item(0).Row("厘容5")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.14
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.141 To 2.1
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 2.101 To 4.06
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 4.061 To 6.02
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 6.021 To 7.976
                            haorong = objdataview.Item(0).Row("毫容5")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If






                '-------------------------以上是T005系，以下是T05系-----------------------------------------
            Case "T05-1"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.013
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.014 To 0.713
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.714 To 1.373
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.374 To 3.174
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.175 To 4.975
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.976 To 6.776
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.777 To 8.578
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.579 To 10.079
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 10.08 To 11.58
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.581 To 13.081
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.082 To 14.582
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.583 To 16.083
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.084 To 17.585
                            lirong = objdataview.Item(0).Row("厘容13")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.013
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.014 To 0.713
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.714 To 1.373
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.374 To 3.174
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.175 To 4.975
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.976 To 6.776
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.777 To 8.578
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.579 To 10.079
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 10.08 To 11.58
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.581 To 13.081
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.082 To 14.582
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.583 To 16.083
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.084 To 17.585
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "T05-2"


                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.005
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.006 To 0.705
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.706 To 1.365
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.366 To 3.166
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.167 To 4.967
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.968 To 6.768
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.769 To 8.57
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.571 To 10.071
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 10.072 To 11.572
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.573 To 13.073
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.074 To 14.574
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.575 To 16.075
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.076 To 17.577
                            lirong = objdataview.Item(0).Row("厘容13")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.005
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.006 To 0.705
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.706 To 1.365
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.366 To 3.166
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.167 To 4.967
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.968 To 6.768
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.769 To 8.57
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.571 To 10.071
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 10.072 To 11.572
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.573 To 13.073
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.074 To 14.574
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.575 To 16.075
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.076 To 17.577
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If




            Case "T05-3"  '修正表无需覆盖


                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.033
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.034 To 0.733
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.734 To 1.089
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.09 To 2.601
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.602 To 4.116
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.117 To 5.627
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.628 To 7.142
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.143 To 8.662
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 8.663 To 10.177
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.178 To 11.697
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.698 To 14.708
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.709 To 17.743
                            lirong = objdataview.Item(0).Row("厘容12")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                                 Case 0 To 0.033
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.034 To 0.733
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.734 To 1.089
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.09 To 2.601
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.602 To 4.116
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.117 To 5.627
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.628 To 7.142
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.143 To 8.662
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 8.663 To 10.177
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.178 To 11.697
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.698 To 14.708
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.709 To 17.743
                            haorong = objdataview.Item(0).Row("毫容12")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If




            Case "T05-4" '无需覆盖修正

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.033
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.034 To 0.733
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.734 To 1.101
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.102 To 2.613
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.614 To 4.128
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.129 To 5.639
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.64 To 7.154
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.155 To 8.674
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 8.675 To 10.189
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.19 To 11.709
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.71 To 14.72
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.721 To 17.755
                            lirong = objdataview.Item(0).Row("厘容12")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.033
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.034 To 0.733
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.734 To 1.101
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.102 To 2.613
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.614 To 4.128
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.129 To 5.639
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.64 To 7.154
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.155 To 8.674
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 8.675 To 10.189
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.19 To 11.709
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.71 To 14.72
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.721 To 17.755
                            haorong = objdataview.Item(0).Row("毫容12") '毫容



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If




            Case "T05-5" '修正表可用


                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.033
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.034 To 0.733
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.734 To 1.085
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.086 To 2.597
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.598 To 4.112
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.113 To 5.623
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.624 To 7.138
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.139 To 8.658
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 8.659 To 10.173
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.174 To 11.693
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.694 To 14.704
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.705 To 17.739
                            lirong = objdataview.Item(0).Row("厘容12")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.033
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.034 To 0.733
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.734 To 1.085
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.086 To 2.597
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.598 To 4.112
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.113 To 5.623
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.624 To 7.138
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.139 To 8.658
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 8.659 To 10.173
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.174 To 11.693
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.694 To 14.704
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.705 To 17.739
                            haorong = objdataview.Item(0).Row("毫容12")
                            '毫容



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "T05-6"   '修正表有效


                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.003
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.004 To 0.703
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.704 To 1.095
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.096 To 2.607
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.608 To 4.112
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.113 To 5.633
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.634 To 7.148
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.149 To 8.668
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 8.669 To 11.703
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.704 To 14.714
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 14.715 To 17.749
                            lirong = objdataview.Item(0).Row("厘容11")





                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                                 Case 0 To 0.003
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.004 To 0.703
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.704 To 1.095
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.096 To 2.607
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.608 To 4.112
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.113 To 5.633
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.634 To 7.148
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.149 To 8.668
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 8.669 To 11.703
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.704 To 14.714
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 14.715 To 17.749
                            haorong = objdataview.Item(0).Row("毫容11")

                            '毫容



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T05-7"


                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.013
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.014 To 0.713
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.714 To 1.062
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.063 To 2.574
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.575 To 4.089
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.09 To 5.6
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.601 To 7.115
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.116 To 8.635
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 8.636 To 11.67
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.671 To 14.681
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 14.682 To 17.716
                            lirong = objdataview.Item(0).Row("厘容11")





                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.013
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.014 To 0.713
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.714 To 1.062
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.063 To 2.574
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.575 To 4.089
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.09 To 5.6
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.601 To 7.115
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.116 To 8.635
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 8.636 To 11.67
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.671 To 14.681
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 14.682 To 17.716
                            haorong = objdataview.Item(0).Row("毫容11")

                            '毫容



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



                'Case "T05-8"
                'Case "T05-9"
                'Case "T05-10"


            Case "T05-11"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.703
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.704 To 1.103
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 1.104 To 2.613
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 2.614 To 4.131
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 4.132 To 5.643
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.644 To 7.16
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 7.161 To 8.675
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.676 To 10.2
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 10.201 To 11.722
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.723 To 13.23
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.231 To 14.737
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.738 To 16.247
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.248 To 17.752
                            lirong = objdataview.Item(0).Row("厘容13")



                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.703
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.704 To 1.103
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 1.104 To 2.613
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 2.614 To 4.131
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 4.132 To 5.643
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.644 To 7.16
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 7.161 To 8.675
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.676 To 10.2
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 10.201 To 11.722
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.723 To 13.23
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.231 To 14.737
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.738 To 16.247
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.248 To 17.752
                            haorong = objdataview.Item(0).Row("毫容13")

                            '毫容



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T05-12"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.013
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.014 To 0.713
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.714 To 1.113
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.114 To 2.623
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.624 To 4.141
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.142 To 5.653
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.654 To 7.17
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.171 To 8.685
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 8.686 To 10.21
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.211 To 11.732
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.733 To 13.24
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.241 To 14.747
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 14.748 To 16.257
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 16.258 To 17.762
                            lirong = objdataview.Item(0).Row("厘容14")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.013
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.014 To 0.713
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.714 To 1.113
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.114 To 2.623
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.624 To 4.141
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.142 To 5.653
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.654 To 7.17
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.171 To 8.685
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 8.686 To 10.21
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.211 To 11.732
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.733 To 13.24
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.241 To 14.747
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 14.748 To 16.257
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 16.258 To 17.762
                            haorong = objdataview.Item(0).Row("毫容14")

                            '毫容



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T05-13"


                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.645
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.646 To 1.045
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 1.046 To 2.555
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 2.556 To 4.073
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 4.074 To 5.585
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.586 To 7.102
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 7.103 To 8.617
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.618 To 10.142
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 10.143 To 11.664
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.665 To 13.172
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.173 To 14.679
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.68 To 16.189
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.19 To 17.694
                            lirong = objdataview.Item(0).Row("厘容13")



                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                                  Case 0 To 0.645
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.646 To 1.045
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 1.046 To 2.555
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 2.556 To 4.073
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 4.074 To 5.585
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.586 To 7.102
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 7.103 To 8.617
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.618 To 10.142
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 10.143 To 11.664
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.665 To 13.172
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.173 To 14.679
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.68 To 16.189
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.19 To 17.694
                            haorong = objdataview.Item(0).Row("毫容13")


                            '毫容



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If




            Case "T05-14"



                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.69
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.691 To 1.09
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 1.091 To 2.6
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 2.601 To 4.118
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 4.119 To 5.63
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.631 To 7.147
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 7.148 To 8.662
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.663 To 10.187
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 10.188 To 11.709
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.71 To 13.217
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.218 To 14.724
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.725 To 16.234
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.235 To 17.739
                            lirong = objdataview.Item(0).Row("厘容13")



                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                             Case 0 To 0.69
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.691 To 1.09
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 1.091 To 2.6
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 2.601 To 4.118
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 4.119 To 5.63
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.631 To 7.147
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 7.148 To 8.662
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.663 To 10.187
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 10.188 To 11.709
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.71 To 13.217
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.218 To 14.724
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.725 To 16.234
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.235 To 17.739
                            haorong = objdataview.Item(0).Row("毫容13")
                            '毫容



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If




            Case "T05-15"



                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.683
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.684 To 1.083
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 1.084 To 2.593
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 2.594 To 4.111
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 4.112 To 5.623
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.624 To 7.14
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 7.141 To 8.655
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.656 To 10.18
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 10.181 To 11.702
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.703 To 13.21
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.211 To 14.717
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.718 To 16.227
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.228 To 17.732
                            lirong = objdataview.Item(0).Row("厘容13")



                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.683
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.684 To 1.083
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 1.084 To 2.593
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 2.594 To 4.111
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 4.112 To 5.623
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.624 To 7.14
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 7.141 To 8.655
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.656 To 10.18
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 10.181 To 11.702
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.703 To 13.21
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.211 To 14.717
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.718 To 16.227
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.228 To 17.732
                            haorong = objdataview.Item(0).Row("毫容13")
                            '毫容



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T05-16"



                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.68
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.681 To 1.08
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 1.011 To 2.59
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 2.591 To 4.108
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 4.109 To 5.62
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.621 To 7.137
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 7.138 To 8.652
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.653 To 10.177
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 10.178 To 11.729
                            lirong = objdataview.Item(0).Row("厘容9")

                      



                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                         Case 0 To 0.68
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.681 To 1.08
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 1.011 To 2.59
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 2.591 To 4.108
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 4.109 To 5.62
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.621 To 7.137
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 7.138 To 8.652
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.653 To 10.177
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 10.178 To 11.729
                            haorong = objdataview.Item(0).Row("毫容9")
                            '毫容



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If





            Case "T05-17"



                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.68
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.681 To 1.08
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 1.081 To 2.59
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 2.591 To 4.108
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 4.109 To 5.62
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.621 To 7.137
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 7.138 To 8.652
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.653 To 10.177
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 10.178 To 11.699
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.7 To 13.207
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.208 To 14.714
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.715 To 16.224
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.225 To 17.729
                            lirong = objdataview.Item(0).Row("厘容13")



                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                           Case 0 To 0.68
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.681 To 1.08
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 1.081 To 2.59
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 2.591 To 4.108
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 4.109 To 5.62
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.621 To 7.137
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 7.138 To 8.652
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.653 To 10.177
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 10.178 To 11.699
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.7 To 13.207
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.208 To 14.714
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.715 To 16.224
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.225 To 17.729
                            haorong = objdataview.Item(0).Row("毫容13")



                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If




                '---------------------------------以上是T05系，以下是T0系+修正表需要规范+------------------------------------

            Case "T011"

                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.109
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.11 To 0.709
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.71 To 1.159
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.16 To 2.672
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.673 To 4.179
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.18 To 5.687
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.688 To 7.189
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.19 To 8.699
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.109
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.11 To 0.709
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.71 To 1.159
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.16 To 2.672
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.673 To 4.179
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.18 To 5.687
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.688 To 7.189
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.19 To 8.699
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T012"


                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.119
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.12 To 0.719
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.72 To 1.163
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.164 To 2.676
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.677 To 4.183
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.184 To 5.691
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.692 To 7.193
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.194 To 8.703
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.119
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.12 To 0.719
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.72 To 1.163
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.164 To 2.676
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.677 To 4.183
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.184 To 5.691
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.692 To 7.193
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.194 To 8.703
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If



            Case "T013"


                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.131
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.132 To 0.731
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.732 To 1.181
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.182 To 2.694
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.695 To 4.201
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.202 To 5.709
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.71 To 7.211
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.212 To 8.721
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.131
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.132 To 0.731
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.732 To 1.181
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.182 To 2.694
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.695 To 4.201
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.202 To 5.709
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.71 To 7.211
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.212 To 8.721
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If





            Case "T014"


                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.122
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.123 To 0.722
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.723 To 1.172
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.173 To 2.685
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.686 To 4.192
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.193 To 5.7
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.701 To 7.202
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.203 To 8.712
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.122
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.123 To 0.722
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.723 To 1.172
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.173 To 2.685
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.686 To 4.192
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.193 To 5.7
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.701 To 7.202
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.203 To 8.712
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If





            Case "T015"


                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.102
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.103 To 0.702
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.703 To 1.152
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.153 To 2.665
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.666 To 4.172
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.173 To 5.68
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.681 To 7.182
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.183 To 8.692
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.102
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.103 To 0.702
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.703 To 1.152
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.153 To 2.665
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.666 To 4.172
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.173 To 5.68
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.681 To 7.182
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.183 To 8.692
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If




            Case "T016"


                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.137
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.138 To 0.737
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.738 To 1.187
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.188 To 2.7
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.701 To 4.207
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.208 To 5.715
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.716 To 7.217
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.218 To 8.727
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                         Case 0 To 0.137
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.138 To 0.737
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.738 To 1.187
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.188 To 2.7
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.701 To 4.207
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.208 To 5.715
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.716 To 7.217
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.218 To 8.727
                            haorong = objdataview.Item(0).Row("毫容8")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If





            Case "T051"


                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.065
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.066 To 0.775
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.776 To 1.415
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.416 To 3.233
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.234 To 5.049
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.05 To 6.865
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.866 To 8.691
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.692 To 10.202
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 10.203 To 11.717
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.718 To 13.218
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.219 To 14.731
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.732 To 16.247
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.248 To 17.762
                            lirong = objdataview.Item(0).Row("厘容13")

                


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.065
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.066 To 0.775
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.776 To 1.415
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.416 To 3.233
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.234 To 5.049
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.05 To 6.865
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.866 To 8.691
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.692 To 10.202
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 10.203 To 11.717
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.718 To 13.218
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.219 To 14.731
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.732 To 16.247
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.248 To 17.762
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If





            Case "T052"


                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.067
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.068 To 0.777
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.778 To 1.417
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.419 To 3.235
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.236 To 5.051
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.052 To 6.867
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.868 To 8.693
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.694 To 10.204
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 10.205 To 11.719
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.72 To 13.22
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.221 To 14.733
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.735 To 16.249
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.25 To 17.764
                            lirong = objdataview.Item(0).Row("厘容13")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                          Case 0 To 0.067
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.068 To 0.777
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.778 To 1.417
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.419 To 3.235
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.236 To 5.051
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.052 To 6.867
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.868 To 8.693
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.694 To 10.204
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 10.205 To 11.719
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.72 To 13.22
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.221 To 14.733
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.735 To 16.249
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.25 To 17.764
                            haorong = objdataview.Item(0).Row("毫容13")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "T053"


                If objdataview.Count >= 1 Then
                    Select Case VAL(GAODU)
                        Case 0 To 0.055
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.056 To 0.765
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.766 To 1.405
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.406 To 3.223
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.224 To 5.039
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.04 To 6.855
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.856 To 8.681
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.682 To 10.192
                            lirong = objdataview.Item(0).Row("厘容8")


                        Case 10.193 To 11.707
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 11.708 To 13.208
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 13.209 To 14.721
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 14.722 To 16.237
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 16.238 To 17.752
                            lirong = objdataview.Item(0).Row("厘容13")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = VAL(GAODU) * 1000
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
                    Select Case VAL(GAODU)
                        Case 0 To 0.055
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.056 To 0.765
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.766 To 1.405
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.406 To 3.223
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.224 To 5.039
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.04 To 6.855
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.856 To 8.681
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.682 To 10.192
                            haorong = objdataview.Item(0).Row("毫容8")


                        Case 10.193 To 11.707
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 11.708 To 13.208
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 13.209 To 14.721
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 14.722 To 16.237
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 16.238 To 17.752
                            haorong = objdataview.Item(0).Row("毫容13")
                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

        End Select
        '------------------------------------------------------------------------------------下面是新增22个罐子













        Dim haolixishu As Integer = 0

        haolixishu = VAL(GAODU) * 1000
        haolixishu = Int(haolixishu) Mod 100 '取出毫厘系数


        up = VAL(GAODU) + 0.1
        down = VAL(GAODU)
        up = chendong(up)
        down = chendong(down)



        xiuzheng = ((up - down) / 100 * haolixishu + down) * miduxishu    '此处miduxishu已经-0.0011
        zongrong = mirong + lirong + haorong + siliang
        tiji = (zongrong + xiuzheng) * wenduxishu
        guancun = tiji * miduxishu




        Dim objcommand As New SqlCommand


        objcommand.Connection = objconnection
        objcommand.CommandText = "delete TZ_InventoryData where 油罐编号='" & GUANHAO & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()





        objcommand.Connection = objconnection
        objcommand.CommandText = "insert into TZ_InventoryData (时间分组值,重量,所属罐区,物料编码,油罐编号,油品名称,打尺深度,油温,气温,备注,盘点时间,盘点人员,标准密度,标准温度,变化系数) values (@时间分组值,@重量,@所属罐区,@物料编码,@油罐编号,@油品名称,@打尺深度,@油温,@气温,@备注,@盘点时间,@盘点人员,@标准密度,@标准温度,@变化系数)"

        objcommand.Parameters.AddWithValue("@所属罐区", GUANQU)    '来自于常量赋值
        objcommand.Parameters.AddWithValue("@物料编码", WLBM)     '来自于web services
        objcommand.Parameters.AddWithValue("@油罐编号", GUANHAO)    '来自于web services

        objcommand.Parameters.AddWithValue("@油品名称", YP)      '来自于web services
        objcommand.Parameters.AddWithValue("@打尺深度", Val(GAODU))   '现场录入
        objcommand.Parameters.AddWithValue("@油温", YOUWEN)

        objcommand.Parameters.AddWithValue("@气温", QIWEN)  '不需要
        objcommand.Parameters.AddWithValue("@备注", BEIZHU)  '现场录入
        objcommand.Parameters.AddWithValue("@重量", (guancun / 1000)) '单位是吨

        objcommand.Parameters.AddWithValue("@盘点时间", Now)     '自动生成
        objcommand.Parameters.AddWithValue("@盘点人员", PANDIANREN) ''来自于web services


        objcommand.Parameters.AddWithValue("@标准密度", BZMD)    ''来自于web services
        objcommand.Parameters.AddWithValue("@标准温度", BZWD)   '常量
        objcommand.Parameters.AddWithValue("@变化系数", BHXS)  '常量
        objcommand.Parameters.AddWithValue("@时间分组值", Now.Date.ToString("yyyyMMdd"))

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
        objconnection.Close()

        'Dim SHOWSTR As String
        'SHOWSTR = "米容:" & mirong & vbCrLf & "厘容:" & lirong & vbCrLf & "毫容:" & haorong & vbCrLf & "毫厘系数:" & haolixishu & vbCrLf & "密度系数:" & miduxishu & vbCrLf & "温度系数:" & wenduxishu & vbCrLf & "静压力修正:" & xiuzheng & vbCrLf & "总容量:" & zongrong & vbCrLf & "体积:" & tiji
        'Return SHOWSTR + "结果:" + Trim(guancun)

        Return guancun

    End Function

End Class