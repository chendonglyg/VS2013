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
Public Class Service2
    Inherits System.Web.Services.WebService
    Dim siliang As Single
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New OleDb.OleDbDataAdapter
    '---------------------------------------------
    Dim gaodu As Single = 12.345
    Dim youwen As Single = 27
    Dim qiwen As Single = 18
    Dim bzmd As Single = 0.9226
    Dim bzwd As Single = 20
    Dim bhxs As Single = 0.000064

    Dim guanhao As String = "8051"


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
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
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
    Public Function Calculate(ByVal sjfzz As String, ByVal pdsj As String, ByVal gaodu2 As Single, ByVal gaodu3 As Single, ByVal youwen2 As Single, ByVal youwen3 As Single, ByVal yp As String, ByVal wlbm As String, ByVal pandianren As String, ByVal jianpanren As String, ByVal guanqu As String, ByVal beizhu As String, ByVal guanhao_w As String, ByVal gaodu_w As String, ByVal youwen_w As Single, ByVal qiwen_w As Single, ByVal bzmd_w As Single, ByVal bzwd_w As Integer, ByVal bhxs_w As Single) As Single

        guanhao = guanhao_w
        gaodu = (gaodu_w + gaodu2 + gaodu3) / 3
        youwen = (youwen_w + youwen2 + youwen3) / 3
        qiwen = qiwen_w
        bzmd = bzmd_w
        bzwd = bzwd_w
        bhxs = bhxs_w


        Select Case guanhao

            Case "8051"

                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8051.mdb;Persist Security Info=False;")

            Case "8052"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8052.mdb;Persist Security Info=False;")
            Case "8053"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8053.mdb;Persist Security Info=False;")
            Case "8054"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8054.mdb;Persist Security Info=False;")
            Case "8055"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8055.mdb;Persist Security Info=False;")
            Case "8056"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8056.mdb;Persist Security Info=False;")
            Case "8057"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8057.mdb;Persist Security Info=False;")
            Case "8058"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8058.mdb;Persist Security Info=False;")

            Case "80151"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\80151.mdb;Persist Security Info=False;")
            Case "80152"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\80152.mdb;Persist Security Info=False;")

            Case "80153"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\80153.mdb;Persist Security Info=False;")

            Case "8061"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8061.mdb;Persist Security Info=False;")

            Case "8062"
                siliang = 3286
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8062.mdb;Persist Security Info=False;")
            Case "8063"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8063.mdb;Persist Security Info=False;")
            Case "8064"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8064.mdb;Persist Security Info=False;")
            Case "8065"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8065.mdb;Persist Security Info=False;")
            Case "8066"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8066.mdb;Persist Security Info=False;")
            Case "8067"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8067.mdb;Persist Security Info=False;")
            Case "8068"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8068.mdb;Persist Security Info=False;")
            Case "8069"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8069.mdb;Persist Security Info=False;")
            Case "80610"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\80610.mdb;Persist Security Info=False;")






            Case "8101"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8101.mdb;Persist Security Info=False;")
            Case "8102"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8102.mdb;Persist Security Info=False;")
            Case "8103"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8103.mdb;Persist Security Info=False;")
            Case "8104"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8104.mdb;Persist Security Info=False;")
            Case "8105"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8105.mdb;Persist Security Info=False;")
            Case "8106"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8106.mdb;Persist Security Info=False;")
            Case "8107"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8107.mdb;Persist Security Info=False;")
            Case "8108"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8108.mdb;Persist Security Info=False;")
            Case "8109"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8109.mdb;Persist Security Info=False;")
            Case "8110"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8110.mdb;Persist Security Info=False;")
            Case "8111"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8111.mdb;Persist Security Info=False;")
            Case "8112"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8112.mdb;Persist Security Info=False;")
            Case "8113"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8113.mdb;Persist Security Info=False;")
            Case "8114"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8114.mdb;Persist Security Info=False;")
            Case "8115"
                siliang = 10094

                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8115.mdb;Persist Security Info=False;")
            Case "8116"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8116.mdb;Persist Security Info=False;")
            Case "8117"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8117.mdb;Persist Security Info=False;")
            Case "8118"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8118.mdb;Persist Security Info=False;")
            Case "8119"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8119.mdb;Persist Security Info=False;")
            Case "8120"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8120.mdb;Persist Security Info=False;")
            Case "8121"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8121.mdb;Persist Security Info=False;")
            Case "8122"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8122.mdb;Persist Security Info=False;")
            Case "8123"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8123.mdb;Persist Security Info=False;")
            Case "8124"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8124.mdb;Persist Security Info=False;")
            Case "8125"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8125.mdb;Persist Security Info=False;")
            Case "8126"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8126.mdb;Persist Security Info=False;")
            Case "8127"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8127.mdb;Persist Security Info=False;")

            Case "8201"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8201.mdb;Persist Security Info=False;")

            Case "8202"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8202.mdb;Persist Security Info=False;")
            Case "8203"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8203.mdb;Persist Security Info=False;")
            Case "8204"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8204.mdb;Persist Security Info=False;")
            Case "8205"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8205.mdb;Persist Security Info=False;")
            Case "8206"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8206.mdb;Persist Security Info=False;")
            Case "8207"
                siliang = 18576
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8207.mdb;Persist Security Info=False;")
            Case "8208"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8208.mdb;Persist Security Info=False;")
            Case "8209"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8209.mdb;Persist Security Info=False;")
            Case "8210"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8210.mdb;Persist Security Info=False;")
            Case "8211"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8211.mdb;Persist Security Info=False;")
            Case "8212"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8212.mdb;Persist Security Info=False;")
            Case "8213"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8213.mdb;Persist Security Info=False;")
            Case "8214"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8214.mdb;Persist Security Info=False;")
            Case "8215"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8215.mdb;Persist Security Info=False;")
            Case "8216"
                siliang = 47381
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8216.mdb;Persist Security Info=False;")
            Case "8217"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8217.mdb;Persist Security Info=False;")
            Case "8218"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8218.mdb;Persist Security Info=False;")
            Case "8219"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8219.mdb;Persist Security Info=False;")
            Case "8220"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8220.mdb;Persist Security Info=False;")


            Case "8301"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8301.mdb;Persist Security Info=False;")
            Case "8302"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8302.mdb;Persist Security Info=False;")
            Case "8303"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8303.mdb;Persist Security Info=False;")
            Case "8304"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8304.mdb;Persist Security Info=False;")
            Case "8305"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8305.mdb;Persist Security Info=False;")
            Case "8306"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8306.mdb;Persist Security Info=False;")
            Case "8307"
                siliang = 10000
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8307.mdb;Persist Security Info=False;")
            Case "8308"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8308.mdb;Persist Security Info=False;")
            Case "8309"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8309.mdb;Persist Security Info=False;")
            Case "8310"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8310.mdb;Persist Security Info=False;")
            Case "8311"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8311.mdb;Persist Security Info=False;")
            Case "8312"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8312.mdb;Persist Security Info=False;")
            Case "8313"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8313.mdb;Persist Security Info=False;")
            Case "8314"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8314.mdb;Persist Security Info=False;")

            Case "8401"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8401.mdb;Persist Security Info=False;")
            Case "8402"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8402.mdb;Persist Security Info=False;")
            Case "8501"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8501.mdb;Persist Security Info=False;")
                siliang = 41590
            Case "8502"
                siliang = 46400
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8502.mdb;Persist Security Info=False;")
            Case "8503"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8503.mdb;Persist Security Info=False;")
            Case "8504"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8504.mdb;Persist Security Info=False;")
            Case "8505"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\8505.mdb;Persist Security Info=False;")

            Case "T01"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T01.mdb;Persist Security Info=False;")
            Case "T02"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T02.mdb;Persist Security Info=False;")
            Case "T03"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T03.mdb;Persist Security Info=False;")
            Case "T04"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T04.mdb;Persist Security Info=False;")
            Case "T05"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T05.mdb;Persist Security Info=False;")
            Case "T06"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T06.mdb;Persist Security Info=False;")
            Case "T07"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T07.mdb;Persist Security Info=False;")
            Case "T08"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T08.mdb;Persist Security Info=False;")
            Case "T09"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T09.mdb;Persist Security Info=False;")
            Case "T10"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T10.mdb;Persist Security Info=False;")
            Case "T11"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T11.mdb;Persist Security Info=False;")
            Case "T12"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T12.mdb;Persist Security Info=False;")
            Case "T13"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T13.mdb;Persist Security Info=False;")
            Case "T14"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T14.mdb;Persist Security Info=False;")
            Case "T15"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T15.mdb;Persist Security Info=False;")
            Case "T16"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T16.mdb;Persist Security Info=False;")
            Case "T17"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\T17.mdb;Persist Security Info=False;")

            Case Else

        End Select





        '----------------------------------------------------------------------------------------

        localobjconnection = New OleDb.OleDbConnection(str_conn)

        '

        If gaodu = 0 Then
            m = 0
            cm = 0
            mm = 0
            guancun = 0


        End If

        'If gaodu > 14.324 Or gaodu < 0 Then
        '    MessageBox.Show("高度超出极限且不具备计算条件!", "警告", MessageBoxButtons.OK)
        '    Exit Sub
        'End If

        wenduxishu = 1 + (youwen - 20) * 0.000036
        miduxishu = bzmd - (youwen - bzwd) * bhxs - 0.0011


        mirong = gaodu

        objdataadapter.SelectCommand = New OleDb.OleDbCommand
        objdataadapter.SelectCommand.Connection = localobjconnection
        objdataadapter.SelectCommand.CommandText = "select * from zhengshu where m= " & mirong
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
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
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
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
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "cm")
        objdataview = New DataView(objdataset.Tables("cm"))



        '--------------------------------------------------------------------------------------------------------------------------






        Select Case guanhao

            Case "8051"


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.163
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.164 To 0.228
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.229 To 0.328
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.329 To 0.336
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.337 To 0.773
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 0.774 To 1.394
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.395 To 2.576
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.577 To 2.898
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.899 To 4.401
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.402 To 5.905
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.906 To 7.409
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.41 To 8.914
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.915 To 10.418
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.419 To 11.921
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.922 To 13.424
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 13.425 To 14.324
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.163
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.164 To 0.228
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.229 To 0.328
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.329 To 0.336
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.337 To 0.773
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 0.774 To 1.394
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.395 To 2.576
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.577 To 2.898
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.899 To 4.401
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.402 To 5.905
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.906 To 7.409
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.41 To 8.914
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.915 To 10.418
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.419 To 11.921
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.922 To 13.424
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 13.425 To 14.324
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If




            Case "8052"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.258
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.259 To 0.288
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.289 To 0.366
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.367 To 0.898
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.899 To 1.426
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.427 To 2.606
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 2.607 To 2.93
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.921 To 4.433
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.434 To 5.937
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 5.938 To 7.441
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.442 To 8.946
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 8.947 To 10.45
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.451 To 11.953
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 11.954 To 13.456
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.457 To 14.358
                            lirong = objdataview.Item(0).Row("厘容15")

                  




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                                  Case 0 To 0.258
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.259 To 0.288
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.289 To 0.366
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.367 To 0.898
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.899 To 1.426
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.427 To 2.606
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 2.607 To 2.93
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.921 To 4.433
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 4.434 To 5.937
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 5.938 To 7.441
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.442 To 8.946
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 8.947 To 10.45
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.451 To 11.953
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 11.954 To 13.456
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.457 To 14.358
                            haorong = objdataview.Item(0).Row("毫容15")





                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8053"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                            Case 0 To 0.15
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.151 To 0.215
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.216 To 0.315
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.316 To 0.323
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.324 To 0.855
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 0.856 To 1.369
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.37 To 2.563
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.564 To 2.873
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.874 To 4.376
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.377 To 5.88
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.89 To 7.384
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.385 To 8.889
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.89 To 10.393
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.394 To 11.896
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.897 To 13.399
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 13.4 To 14.299
                            lirong = objdataview.Item(0).Row("厘容16")


                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                           Case 0 To 0.15
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.151 To 0.215
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.216 To 0.315
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.316 To 0.323
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.324 To 0.855
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 0.856 To 1.369
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.37 To 2.563
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.564 To 2.873
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.874 To 4.376
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.377 To 5.88
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.89 To 7.384
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.385 To 8.889
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.89 To 10.393
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.394 To 11.896
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.897 To 13.399
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 13.4 To 14.299
                            haorong = objdataview.Item(0).Row("毫容16")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "8054"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.265
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.266 To 0.29
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.291 To 0.365
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.366 To 0.373
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.374 To 0.895
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 0.896 To 1.421
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.422 To 2.613
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.614 To 2.925
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.926 To 4.428
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.429 To 5.932
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.933 To 7.436
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.437 To 8.941
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.942 To 10.445
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.446 To 11.948
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.949 To 13.451
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 13.452 To 14.351
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.265
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.266 To 0.29
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.291 To 0.365
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.366 To 0.373
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.374 To 0.895
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 0.896 To 1.421
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.422 To 2.613
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.614 To 2.925
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.926 To 4.428
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.429 To 5.932
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.933 To 7.436
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.437 To 8.941
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.942 To 10.445
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.446 To 11.948
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.949 To 13.451
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 13.452 To 14.351
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8055"


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.04
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.041 To 0.129
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.13 To 0.69
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.691 To 1.14
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.141 To 2.637
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 2.638 To 4.133
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 4.134 To 5.628
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.629 To 7.126
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 7.127 To 8.619
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.62 To 10.113
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.114 To 11.613
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 11.614 To 13.11
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 13.111 To 13.87
                            lirong = objdataview.Item(0).Row("厘容13")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.04
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.041 To 0.129
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.13 To 0.69
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.691 To 1.14
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.141 To 2.637
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 2.638 To 4.133
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 4.134 To 5.628
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.629 To 7.126
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 7.127 To 8.619
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.62 To 10.113
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.114 To 11.613
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 11.614 To 13.11
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 13.111 To 13.87
                            haorong = objdataview.Item(0).Row("毫容13")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "8056"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.064
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.065 To 0.644
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.645 To 1.094
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.095 To 2.591
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.592 To 4.087
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.088 To 5.587
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.588 To 7.084
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.085 To 8.58
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.581 To 10.077
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.078 To 11.577
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.578 To 13.077
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.078 To 13.848
                            lirong = objdataview.Item(0).Row("厘容12")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.064
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.065 To 0.644
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.645 To 1.094
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.095 To 2.591
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.592 To 4.087
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.088 To 5.587
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.588 To 7.084
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.085 To 8.58
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.581 To 10.077
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.078 To 11.577
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.578 To 13.077
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.078 To 13.848
                            haorong = objdataview.Item(0).Row("毫容12")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8057"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.058
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.059 To 0.638
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.639 To 1.088
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.089 To 2.586
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.587 To 4.085
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.086 To 5.585
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.585 To 7.085
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.086 To 8.585
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.586 To 10.083
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.084 To 11.58
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.581 To 13.08
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.081 To 13.85
                            lirong = objdataview.Item(0).Row("厘容12")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.058
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.059 To 0.638
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.639 To 1.088
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.089 To 2.586
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.587 To 4.085
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.086 To 5.585
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.585 To 7.085
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.086 To 8.585
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.586 To 10.083
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.084 To 11.58
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.581 To 13.08
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.081 To 13.85
                            haorong = objdataview.Item(0).Row("毫容12")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8058"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.163
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.164 To 0.228
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.229 To 0.328
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.329 To 0.336
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.337 To 0.773
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 0.774 To 1.394
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.395 To 2.576
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.577 To 2.898
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.899 To 4.401
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.402 To 5.905
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.906 To 7.409
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.41 To 8.914
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.915 To 10.418
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.419 To 11.921
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.922 To 13.424
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 13.425 To 14.324
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.163
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.164 To 0.228
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.229 To 0.328
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.329 To 0.336
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.337 To 0.773
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 0.774 To 1.394
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.395 To 2.576
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.577 To 2.898
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.899 To 4.401
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.402 To 5.905
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.906 To 7.409
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.41 To 8.914
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.915 To 10.418
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.419 To 11.921
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.922 To 13.424
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 13.425 To 14.324
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "80151"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.302
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.303 To 0.902
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.903 To 1
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.001 To 1.11
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.111 To 1.357
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.358 To 2.865
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 2.866 To 4.375
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.376 To 5.884
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 5.885 To 7.397
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.398 To 8.907
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 8.908 To 10.418
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.419 To 11.93
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 11.931 To 13.435
                            lirong = objdataview.Item(0).Row("厘容13")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.302
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.303 To 0.902
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.903 To 1
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.001 To 1.11
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.111 To 1.357
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.358 To 2.865
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 2.866 To 4.375
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.376 To 5.884
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 5.885 To 7.397
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.398 To 8.907
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 8.908 To 10.418
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.419 To 11.93
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 11.931 To 13.435
                            haorong = objdataview.Item(0).Row("毫容13")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "80152"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.311
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.312 To 0.911
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.912 To 0.956
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.957 To 1.066
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.067 To 1.371
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.372 To 2.879
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 2.88 To 4.389
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.39 To 5.898
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 5.899 To 7.409
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.41 To 8.919
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 8.92 To 10.43
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.431 To 11.942
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 11.943 To 13.432
                            lirong = objdataview.Item(0).Row("厘容13")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.311
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.312 To 0.911
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.912 To 0.956
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.957 To 1.066
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.067 To 1.371
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.372 To 2.879
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 2.88 To 4.389
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.39 To 5.898
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 5.899 To 7.409
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.41 To 8.919
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 8.92 To 10.43
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.431 To 11.942
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 11.943 To 13.432
                            haorong = objdataview.Item(0).Row("毫容13")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "80153"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.225
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.226 To 0.825
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.826 To 0.956
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.957 To 1.066
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.067 To 1.299
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.3 To 2.807
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 2.808 To 4.317
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.318 To 5.826
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 5.827 To 7.339
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.34 To 8.849
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 8.85 To 10.36
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.361 To 11.872
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 11.873 To 13.382
                            lirong = objdataview.Item(0).Row("厘容13")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.225
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.226 To 0.825
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.826 To 0.956
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.957 To 1.066
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.067 To 1.299
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.3 To 2.807
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 2.808 To 4.317
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.318 To 5.826
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 5.827 To 7.339
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.34 To 8.849
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 8.85 To 10.36
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.361 To 11.872
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 11.873 To 13.382
                            haorong = objdataview.Item(0).Row("毫容13")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "8061"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.17
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.171 To 0.33
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.331 To 1.03
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.031 To 1.355
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.356 To 2.86
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 2.861 To 4.371
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 4.372 To 5.881
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.882 To 7.389
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 7.39 To 8.911
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.912 To 10.433
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.434 To 11.949
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 11.95 To 13.461
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 13.462 To 14.982
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 14.983 To 15.886
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.17
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.171 To 0.33
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.331 To 1.03
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.031 To 1.355
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.356 To 2.86
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 2.861 To 4.371
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 4.372 To 5.881
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.882 To 7.389
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 7.39 To 8.911
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.912 To 10.433
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.434 To 11.949
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 11.95 To 13.461
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 13.462 To 14.982
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 14.983 To 15.886
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8062"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.215
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.216 To 0.363
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.364 To 1.063
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.064 To 1.378
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.379 To 2.881
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 2.882 To 4.39
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 4.391 To 5.898
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.899 To 7.404
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 7.405 To 8.924
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.925 To 10.444
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.445 To 11.958
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 11.959 To 13.468
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 13.469 To 14.987
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 14.988 To 15.88
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.215
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.216 To 0.363
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.364 To 1.063
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.064 To 1.378
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.379 To 2.881
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 2.882 To 4.39
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 4.391 To 5.898
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.899 To 7.404
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 7.405 To 8.924
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.925 To 10.444
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.445 To 11.958
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 11.959 To 13.468
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 13.469 To 14.987
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 14.988 To 15.88
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8063"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.18
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.181 To 0.313
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.314 To 1.013
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.014 To 1.368
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.369 To 2.877
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 2.878 To 4.387
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 4.388 To 5.888
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.889 To 7.395
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 7.396 To 8.917
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.918 To 10.439
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.44 To 11.953
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 11.954 To 13.466
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 13.467 To 14.989
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 14.99 To 15.897
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.18
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.181 To 0.313
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.314 To 1.013
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.014 To 1.368
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.369 To 2.877
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 2.878 To 4.387
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 4.388 To 5.888
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.889 To 7.395
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 7.396 To 8.917
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.918 To 10.439
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.44 To 11.953
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 11.954 To 13.466
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 13.467 To 14.989
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 14.99 To 15.897
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8064"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.198
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.199 To 0.367
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.368 To 1.067
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.068 To 1.377
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.378 To 2.885
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 2.886 To 4.394
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 4.395 To 5.894
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.895 To 7.4
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 7.401 To 8.921
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.922 To 10.442
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.443 To 11.955
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 11.956 To 13.467
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 13.468 To 14.989
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 14.99 To 15.896
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.198
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.199 To 0.367
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.368 To 1.067
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.068 To 1.377
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.378 To 2.885
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 2.886 To 4.394
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 4.395 To 5.894
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.895 To 7.4
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 7.401 To 8.921
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.922 To 10.442
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.443 To 11.955
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 11.956 To 13.467
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 13.468 To 14.989
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 14.99 To 15.896
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8065"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.116
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.117 To 0.247
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.248 To 0.947
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.948 To 1.302
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.303 To 2.806
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 2.807 To 4.316
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 4.317 To 5.825
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.826 To 7.332
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 7.333 To 8.853
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.854 To 10.374
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.375 To 11.889
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 11.89 To 13.4
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 13.401 To 15.815
                            lirong = objdataview.Item(0).Row("厘容13")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.116
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.117 To 0.247
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.248 To 0.947
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.948 To 1.302
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.303 To 2.806
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 2.807 To 4.316
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 4.317 To 5.825
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.826 To 7.332
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 7.333 To 8.853
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.854 To 10.374
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.375 To 11.889
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 11.89 To 13.4
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 13.401 To 15.815
                            haorong = objdataview.Item(0).Row("毫容13")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8066"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.103
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.104 To 0.307
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.308 To 1.007
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.008 To 1.307
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.308 To 2.81
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 2.811 To 4.319
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 4.32 To 5.827
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.828 To 7.333
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 7.334 To 8.853
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.854 To 10.374
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.375 To 11.889
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 11.89 To 13.4
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 13.401 To 15.814
                            lirong = objdataview.Item(0).Row("厘容13")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.103
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.104 To 0.307
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.308 To 1.007
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.008 To 1.307
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.308 To 2.81
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 2.811 To 4.319
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 4.32 To 5.827
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.828 To 7.333
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 7.334 To 8.853
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.854 To 10.374
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.375 To 11.889
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 11.89 To 13.4
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 13.401 To 15.814
                            haorong = objdataview.Item(0).Row("毫容13")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8067"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.108
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.109 To 0.281
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.282 To 0.981
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.982 To 1.306
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.307 To 2.809
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 2.81 To 4.318
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 4.319 To 5.826
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.827 To 7.332
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 7.333 To 8.852
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.853 To 10.373
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.374 To 11.887
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 11.888 To 13.397
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 13.398 To 15.813
                            lirong = objdataview.Item(0).Row("厘容13")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.108
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.109 To 0.281
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.282 To 0.981
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.982 To 1.306
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.307 To 2.809
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 2.81 To 4.318
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 4.319 To 5.826
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.827 To 7.332
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 7.333 To 8.852
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.853 To 10.373
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.374 To 11.887
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 11.888 To 13.397
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 13.398 To 15.813
                            haorong = objdataview.Item(0).Row("毫容13")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8068"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.125
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.126 To 0.329
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.33 To 1.029
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.03 To 1.329
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.33 To 2.832
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 2.833 To 4.341
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 4.342 To 5.849
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.85 To 7.355
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 7.356 To 8.875
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.876 To 10.395
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.396 To 11.909
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 11.91 To 13.419
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 13.42 To 15.794
                            lirong = objdataview.Item(0).Row("厘容13")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.125
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.126 To 0.329
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.33 To 1.029
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.03 To 1.329
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.33 To 2.832
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 2.833 To 4.341
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 4.342 To 5.849
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.85 To 7.355
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 7.356 To 8.875
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.876 To 10.395
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.396 To 11.909
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 11.91 To 13.419
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 13.42 To 15.794
                            haorong = objdataview.Item(0).Row("毫容13")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8069"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.025
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.026 To 0.339
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.34 To 1.039
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.04 To 1.309
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.31 To 2.809
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 2.81 To 4.309
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 4.31 To 5.809
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.81 To 7.309
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 7.31 To 8.809
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.81 To 10.309
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.31 To 11.809
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 11.81 To 15.824
                            lirong = objdataview.Item(0).Row("厘容12")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.025
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.026 To 0.339
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.34 To 1.039
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.04 To 1.309
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.31 To 2.809
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 2.81 To 4.309
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 4.31 To 5.809
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.81 To 7.309
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 7.31 To 8.809
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.81 To 10.309
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.31 To 11.809
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 11.81 To 15.824
                            haorong = objdataview.Item(0).Row("毫容12")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "80610"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.25
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.251 To 0.296
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.297 To 0.996
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.997 To 1.316
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.317 To 2.816
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 2.817 To 4.316
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 4.317 To 5.816
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.817 To 7.316
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 7.317 To 8.816
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.817 To 10.316
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.317 To 11.816
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 11.817 To 13.316
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 13.317 To 14.816
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 14.817 To 15.736
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.25
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.251 To 0.296
                            haorong = objdataview.Item(0).Row("毫容2")


                        Case 0.297 To 0.996
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.997 To 1.316
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.317 To 2.816
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 2.817 To 4.316
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 4.317 To 5.816
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.817 To 7.316
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 7.317 To 8.816
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.817 To 10.316
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.317 To 11.816
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 11.817 To 13.316
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 13.317 To 14.816
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 14.817 To 15.736
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8101"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.289
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.29 To 0.3
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.301 To 0.894
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.895 To 1.411
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.412 To 2.914
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 2.915 To 3
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.001 To 4.416
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.417 To 5.922
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 5.923 To 7.426
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.427 To 8.931
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 8.932 To 10.432
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.433 To 11.935
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 11.936 To 13.438
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 13.439 To 14.338
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.289
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.29 To 0.3
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.301 To 0.894
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.895 To 1.411
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.412 To 2.914
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 2.915 To 3
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.001 To 4.416
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.417 To 5.922
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 5.923 To 7.426
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.427 To 8.931
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 8.932 To 10.432
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.433 To 11.935
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 11.936 To 13.438
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 13.439 To 14.338
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8102"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.29
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.291 To 0.3
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.301 To 0.89
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.891 To 1.404
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.405 To 2.907
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 2.908 To 3
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.001 To 4.409
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.41 To 5.915
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 5.916 To 7.419
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.42 To 8.924
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 8.925 To 10.425
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.426 To 11.928
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 11.929 To 13.431
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 13.432 To 14.331
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.29
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.291 To 0.3
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.301 To 0.89
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.891 To 1.404
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.405 To 2.907
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 2.908 To 3
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.001 To 4.409
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.41 To 5.915
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 5.916 To 7.419
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.42 To 8.924
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 8.925 To 10.425
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.426 To 11.928
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 11.929 To 13.431
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 13.432 To 14.331
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8103"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.241
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.242 To 0.251
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.252 To 0.296
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.297 To 0.359
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.36 To 0.896
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 0.897 To 1.406
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.407 To 2.649
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.65 To 2.91
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 5.911 To 4.413
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.414 To 5.917
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.918 To 7.421
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.422 To 8.926
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.927 To 10.43
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.431 To 11.933
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.934 To 13.436
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 13.437 To 14.336
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.241
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.242 To 0.251
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.252 To 0.296
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.297 To 0.359
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.36 To 0.896
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 0.897 To 1.406
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.407 To 2.649
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.65 To 2.91
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 5.911 To 4.413
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.414 To 5.917
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.918 To 7.421
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.422 To 8.926
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.927 To 10.43
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.431 To 11.933
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.934 To 13.436
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 13.437 To 14.336
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8104"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.232
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.233 To 0.3
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.301 To 0.832
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.833 To 1.398
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.399 To 2.902
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 2.903 To 3
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.001 To 4.405
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.406 To 5.909
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 5.91 To 7.413
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.414 To 8.918
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 8.919 To 10.422
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.423 To 11.925
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 11.926 To 13.428
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 13.429 To 14.328
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.232
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.233 To 0.3
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.301 To 0.832
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.833 To 1.398
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.399 To 2.902
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 2.903 To 3
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.001 To 4.405
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.406 To 5.909
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 5.91 To 7.413
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.414 To 8.918
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 8.919 To 10.422
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.423 To 11.925
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 11.926 To 13.428
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 13.429 To 14.328
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8105"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.06
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.061 To 0.64
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.641 To 1.05
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.051 To 1.09
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.091 To 1.139
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.14 To 1.34
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.341 To 1.43
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.431 To 2.586
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.587 To 4.083
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.084 To 5.579
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.58 To 7.079
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.08 To 8.576
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.577 To 10.074
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.075 To 11.573
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.574 To 13.073
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 13.074 To 13.843
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.06
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.061 To 0.64
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.641 To 1.05
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.051 To 1.09
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.091 To 1.139
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.14 To 1.34
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.341 To 1.43
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.431 To 2.586
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.587 To 4.083
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.084 To 5.579
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.58 To 7.079
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.08 To 8.576
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.577 To 10.074
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.075 To 11.573
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.574 To 13.073
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 13.074 To 13.843
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8106"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.113
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.114 To 0.633
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.634 To 1.042
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.043 To 1.082
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.083 To 1.132
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.133 To 1.332
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.333 To 1.422
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.423 To 2.578
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.579 To 4.075
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.076 To 5.573
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.574 To 7.072
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.073 To 8.572
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.573 To 10.072
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.073 To 11.572
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.573 To 13.069
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 13.07 To 13.839
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.113
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.114 To 0.633
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.634 To 1.042
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.043 To 1.082
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.083 To 1.132
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.133 To 1.332
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.333 To 1.422
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.423 To 2.578
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.579 To 4.075
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.076 To 5.573
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.574 To 7.072
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.073 To 8.572
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.573 To 10.072
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.073 To 11.572
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.573 To 13.069
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 13.07 To 13.839
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8107"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.12
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.121 To 0.64
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.641 To 1.048
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.049 To 1.088
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.089 To 1.137
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.138 To 1.338
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.339 To 1.427
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.428 To 2.585
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.586 To 4.081
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.082 To 5.579
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.58 To 7.078
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.079 To 8.576
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.577 To 10.076
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.077 To 11.576
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.577 To 13.076
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 13.077 To 13.846
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.12
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.121 To 0.64
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.641 To 1.048
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.049 To 1.088
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.089 To 1.137
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.138 To 1.338
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.339 To 1.427
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.428 To 2.585
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.586 To 4.081
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.082 To 5.579
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.58 To 7.078
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.079 To 8.576
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.577 To 10.076
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.077 To 11.576
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.577 To 13.076
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 13.077 To 13.846
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8108"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.163
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.164 To 0.228
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.229 To 0.328
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.329 To 0.336
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.337 To 0.773
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 0.774 To 1.394
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.395 To 2.576
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.577 To 2.898
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.899 To 4.401
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.402 To 5.905
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.906 To 7.409
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.41 To 8.914
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.915 To 10.418
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.419 To 11.921
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.922 To 13.424
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 13.425 To 14.324
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.163
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.164 To 0.228
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.229 To 0.328
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.329 To 0.336
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.337 To 0.773
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 0.774 To 1.394
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.395 To 2.576
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.577 To 2.898
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.899 To 4.401
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.402 To 5.905
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.906 To 7.409
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.41 To 8.914
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.915 To 10.418
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.419 To 11.921
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.922 To 13.424
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 13.425 To 14.324
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8109"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.12
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.121 To 0.638
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.639 To 1.048
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.049 To 1.088
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.089 To 1.137
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.138 To 1.338
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.339 To 1.427
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.428 To 2.587
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.588 To 4.085
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.086 To 5.581
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.582 To 7.078
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.079 To 8.578
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.579 To 10.075
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.076 To 11.574
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.575 To 13.074
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 13.075 To 13.834
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.12
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.121 To 0.638
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.639 To 1.048
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.049 To 1.088
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.089 To 1.137
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.138 To 1.338
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.339 To 1.427
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.428 To 2.587
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.588 To 4.085
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.086 To 5.581
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.582 To 7.078
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.079 To 8.578
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.579 To 10.075
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.076 To 11.574
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.575 To 13.074
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 13.075 To 13.834
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8110"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.035
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.036 To 0.111
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.112 To 0.63
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.631 To 1.04
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.041 To 1.08
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.081 To 1.129
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.13 To 1.33
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.331 To 1.419
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 1.42 To 2.576
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 2.577 To 4.074
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 4.075 To 5.574
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 5.575 To 7.074
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 7.075 To 8.574
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 8.575 To 10.071
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 10.072 To 11.569
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 11.57 To 13.066
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 13.067 To 13.826
                            lirong = objdataview.Item(0).Row("厘容17")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.035
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.036 To 0.111
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.112 To 0.63
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.631 To 1.04
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.041 To 1.08
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.081 To 1.129
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.13 To 1.33
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.331 To 1.419
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 1.42 To 2.576
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 2.577 To 4.074
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 4.075 To 5.574
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 5.575 To 7.074
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 7.075 To 8.574
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 8.575 To 10.071
                            haorong = objdataview.Item(0).Row("毫容14")


                        Case 10.072 To 11.569
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 11.57 To 13.066
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 13.067 To 13.826
                            haorong = objdataview.Item(0).Row("毫容17")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8111"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.055
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.056 To 0.131
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.132 To 0.65
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.651 To 1.06
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.061 To 1.1
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.101 To 1.149
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.15 To 1.35
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.351 To 1.439
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 1.44 To 2.596
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 2.597 To 4.094
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 4.095 To 5.591
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 5.592 To 7.083
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 7.084 To 8.58
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 8.581 To 10.078
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 10.079 To 11.578
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 11.579 To 13.077
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 13.078 To 13.837
                            lirong = objdataview.Item(0).Row("厘容17")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.055
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.056 To 0.131
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.132 To 0.65
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.651 To 1.06
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.061 To 1.1
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.101 To 1.149
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.15 To 1.35
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.351 To 1.439
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 1.44 To 2.596
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 2.597 To 4.094
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 4.095 To 5.591
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 5.592 To 7.083
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 7.084 To 8.58
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 8.581 To 10.078
                            haorong = objdataview.Item(0).Row("毫容14")


                        Case 10.079 To 11.578
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 11.579 To 13.077
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 13.078 To 13.837
                            haorong = objdataview.Item(0).Row("毫容17")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8112"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.163
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.164 To 0.228
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.229 To 0.328
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.329 To 0.336
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.337 To 0.773
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 0.774 To 1.394
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.395 To 2.576
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.577 To 2.898
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.899 To 4.401
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.402 To 5.905
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.906 To 7.409
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.41 To 8.914
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.915 To 10.418
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.419 To 11.921
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.922 To 13.424
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 13.425 To 14.324
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.163
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.164 To 0.228
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.229 To 0.328
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.329 To 0.336
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.337 To 0.773
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 0.774 To 1.394
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.395 To 2.576
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.577 To 2.898
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.899 To 4.401
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.402 To 5.905
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.906 To 7.409
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.41 To 8.914
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.915 To 10.418
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.419 To 11.921
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.922 To 13.424
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 13.425 To 14.324
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8113"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.053
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.054 To 0.206
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.207 To 0.288
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.289 To 0.988
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.989 To 1.398
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.399 To 1.818
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.819 To 1.875
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.876 To 2.235
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.236 To 2.292
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 2.293 To 2.903
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 2.904 To 4.412
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 4.413 To 5.911
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 5.912 To 7.413
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 7.414 To 8.912
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 8.913 To 10.412
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 10.413 To 11.918
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 11.919 To 13.427
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case 13.428 To 14.935
                            lirong = objdataview.Item(0).Row("厘容18")

                        Case 14.936 To 15.839
                            lirong = objdataview.Item(0).Row("厘容19")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.053
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.054 To 0.206
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.207 To 0.288
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.289 To 0.988
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.989 To 1.398
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.399 To 1.818
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.819 To 1.875
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.876 To 2.235
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.236 To 2.292
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 2.293 To 2.903
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 2.904 To 4.412
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 4.413 To 5.911
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 5.912 To 7.413
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 7.414 To 8.912
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 8.913 To 10.412
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 10.413 To 11.918
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 11.919 To 13.427
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case 13.428 To 14.935
                            haorong = objdataview.Item(0).Row("毫容18")

                        Case 14.936 To 15.839
                            haorong = objdataview.Item(0).Row("毫容19")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8114"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.155
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.156 To 0.331
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.332 To 1.031
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.032 To 1.331
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.332 To 1.751
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.752 To 1.808
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.809 To 2.168
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.169 To 2.225
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.226 To 2.837
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 2.838 To 4.347
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 4.348 To 5.847
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 5.848 To 7.35
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 7.351 To 8.85
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 8.851 To 10.351
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 10.352 To 11.858
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 11.859 To 13.368
                            lirong = objdataview.Item(0).Row("厘容16")


                        Case 13.369 To 14.877
                            lirong = objdataview.Item(0).Row("厘容17")


                        Case 14.878 To 15.782
                            lirong = objdataview.Item(0).Row("厘容18")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.155
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.156 To 0.331
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.332 To 1.031
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.032 To 1.331
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.332 To 1.751
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.752 To 1.808
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.809 To 2.168
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.169 To 2.225
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.226 To 2.837
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 2.838 To 4.347
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 4.348 To 5.847
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 5.848 To 7.35
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 7.351 To 8.85
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 8.851 To 10.351
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 10.352 To 11.858
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 11.859 To 13.368
                            haorong = objdataview.Item(0).Row("毫容16")


                        Case 13.369 To 14.877
                            haorong = objdataview.Item(0).Row("毫容17")


                        Case 14.878 To 15.782
                            haorong = objdataview.Item(0).Row("毫容18")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8115"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.183
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.184 To 0.329
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.33 To 1.029
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.03 To 1.319
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.32 To 1.549
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.55 To 1.606
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.607 To 1.926
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.927 To 1.983
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 1.984 To 2.825
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 2.826 To 4.335
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 4.336 To 5.835
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 5.836 To 7.338
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 7.339 To 8.838
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 8.839 To 10.339
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 10.34 To 11.846
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 11.847 To 13.356
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 13.357 To 14.865
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case 14.866 To 15.77
                            lirong = objdataview.Item(0).Row("厘容18")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.183
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.184 To 0.329
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.33 To 1.029
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.03 To 1.319
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.32 To 1.549
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.55 To 1.606
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.607 To 1.926
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.927 To 1.983
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 1.984 To 2.825
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 2.826 To 4.335
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 4.336 To 5.835
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 5.836 To 7.338
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 7.339 To 8.838
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 8.839 To 10.339
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 10.34 To 11.846
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 11.847 To 13.356
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 13.357 To 14.865
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case 14.866 To 15.77
                            haorong = objdataview.Item(0).Row("毫容18")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8116"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.013
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.014 To 0.152
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.153 To 0.43
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.431 To 1.13
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.131 To 1.345
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.346 To 1.575
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.576 To 1.632
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.633 To 1.952
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 1.953 To 2.009
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 2.01 To 2.851
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 2.852 To 4.361
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 4.362 To 5.861
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 5.862 To 7.364
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 7.365 To 8.865
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 8.866 To 10.365
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 10.366 To 11.871
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 11.872 To 13.38
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case 13.381 To 14.888
                            lirong = objdataview.Item(0).Row("厘容18")

                        Case 14.889 To 15.783
                            lirong = objdataview.Item(0).Row("厘容19")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.013
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.014 To 0.152
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.153 To 0.43
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.431 To 1.13
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.131 To 1.345
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.346 To 1.575
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.576 To 1.632
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.633 To 1.952
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 1.953 To 2.009
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 2.01 To 2.851
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 2.852 To 4.361
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 4.362 To 5.861
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 5.862 To 7.364
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 7.365 To 8.865
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 8.866 To 10.365
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 10.366 To 11.871
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 11.872 To 13.38
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case 13.381 To 14.888
                            haorong = objdataview.Item(0).Row("毫容18")

                        Case 14.889 To 15.783
                            haorong = objdataview.Item(0).Row("毫容19")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8117"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.039
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.04 To 0.639
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.64 To 1.089
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.09 To 2.589
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.59 To 4.089
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.09 To 5.589
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.59 To 7.089
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.09 To 8.589
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.59 To 10.089
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.09 To 11.589
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.59 To 13.089
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.09 To 14.589
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 14.59 To 16.089
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 16.09 To 17.589
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 17.59 To 19.089
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 19.09 To 20.589
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.039
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.04 To 0.639
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.64 To 1.089
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.09 To 2.589
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.59 To 4.089
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.09 To 5.589
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.59 To 7.089
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.09 To 8.589
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.59 To 10.089
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.09 To 11.589
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.59 To 13.089
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.09 To 14.589
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 14.59 To 16.089
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 16.09 To 17.589
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 17.59 To 19.089
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 19.09 To 20.589
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8118"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.049
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.05 To 0.649
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.65 To 1.099
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.1 To 2.599
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.6 To 4.099
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.1 To 5.599
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.6 To 7.099
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.1 To 8.599
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.6 To 10.099
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.1 To 11.599
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.6 To 13.099
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.1 To 14.599
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 14.6 To 16.099
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 16.1 To 17.599
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 17.6 To 19.099
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 19.1 To 20.599
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.049
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.05 To 0.649
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.65 To 1.099
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.1 To 2.599
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.6 To 4.099
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.1 To 5.599
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.6 To 7.099
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.1 To 8.599
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.6 To 10.099
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.1 To 11.599
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.6 To 13.099
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.1 To 14.599
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 14.6 To 16.099
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 16.1 To 17.599
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 17.6 To 19.099
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 19.1 To 20.599
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8119"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.025
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.026 To 0.625
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.626 To 1.075
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.076 To 2.575
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.576 To 4.075
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.076 To 5.575
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.576 To 7.075
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.076 To 8.575
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.576 To 10.075
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.076 To 11.575
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.576 To 13.075
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.076 To 14.575
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 14.576 To 16.075
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 16.076 To 17.575
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 17.576 To 19.075
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 19.076 To 20.575
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.025
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.026 To 0.625
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.626 To 1.075
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.076 To 2.575
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.576 To 4.075
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.076 To 5.575
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.576 To 7.075
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.076 To 8.575
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.576 To 10.075
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.076 To 11.575
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.576 To 13.075
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.076 To 14.575
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 14.576 To 16.075
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 16.076 To 17.575
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 17.576 To 19.075
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 19.076 To 20.575
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8120"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.073
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.074 To 0.673
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.674 To 1.123
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.124 To 2.623
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.624 To 4.123
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.124 To 5.623
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.624 To 7.123
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.124 To 8.623
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.624 To 10.123
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.124 To 11.623
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.624 To 13.123
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.124 To 14.623
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 14.624 To 16.123
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 16.124 To 17.623
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 17.624 To 19.123
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 19.124 To 20.623
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.073
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.074 To 0.673
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.674 To 1.123
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.124 To 2.623
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.624 To 4.123
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.124 To 5.623
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.624 To 7.123
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.124 To 8.623
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.624 To 10.123
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.124 To 11.623
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.624 To 13.123
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.124 To 14.623
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 14.624 To 16.123
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 16.124 To 17.623
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 17.624 To 19.123
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 19.124 To 20.623
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8121"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.04
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.041 To 0.64
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.641 To 1.09
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.091 To 2.59
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.591 To 4.09
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.091 To 5.59
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.591 To 7.09
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.091 To 8.59
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.591 To 10.09
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.091 To 11.59
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.591 To 13.09
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.091 To 14.59
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 14.591 To 16.09
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 16.091 To 17.59
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 17.591 To 19.09
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 19.091 To 20.59
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.04
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.041 To 0.64
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.641 To 1.09
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.091 To 2.59
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.591 To 4.09
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.091 To 5.59
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.591 To 7.09
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.091 To 8.59
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.591 To 10.09
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.091 To 11.59
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.591 To 13.09
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.091 To 14.59
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 14.591 To 16.09
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 16.091 To 17.59
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 17.591 To 19.09
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 19.091 To 20.59
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8122"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.065
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.066 To 0.665
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.666 To 1.115
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.116 To 2.615
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.616 To 4.115
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.116 To 5.615
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.616 To 7.115
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.116 To 8.615
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.616 To 10.115
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.116 To 11.615
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.616 To 13.115
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.116 To 14.615
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 14.616 To 16.115
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 16.116 To 17.615
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 17.616 To 19.115
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 19.116 To 20.615
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.065
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.066 To 0.665
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.666 To 1.115
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.116 To 2.615
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.616 To 4.115
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.116 To 5.615
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.616 To 7.115
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.116 To 8.615
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.616 To 10.115
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.116 To 11.615
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.616 To 13.115
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.116 To 14.615
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 14.616 To 16.115
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 16.116 To 17.615
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 17.616 To 19.115
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 19.116 To 20.615
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8123"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.142
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.143 To 0.281
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.282 To 0.391
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.392 To 0.742
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.743 To 1.481
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.482 To 3.281
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.282 To 5.081
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.082 To 6.881
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.882 To 8.681
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.682 To 10.481
                            lirong = objdataview.Item(0).Row("厘容10")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.142
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.143 To 0.281
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.282 To 0.391
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.392 To 0.742
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.743 To 1.481
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.482 To 3.281
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.282 To 5.081
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.082 To 6.881
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.882 To 8.681
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.682 To 10.481
                            haorong = objdataview.Item(0).Row("毫容10")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8124"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.152
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.153 To 0.275
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.276 To 0.385
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.386 To 0.752
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.753 To 1.467
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.468 To 3.267
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.268 To 5.067
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.068 To 6.867
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.868 To 8.667
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.668 To 10.467
                            lirong = objdataview.Item(0).Row("厘容10")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.152
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.153 To 0.275
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.276 To 0.385
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.386 To 0.752
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.753 To 1.467
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.468 To 3.267
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.268 To 5.067
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.068 To 6.867
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.868 To 8.667
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.668 To 10.467
                            haorong = objdataview.Item(0).Row("毫容10")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8125"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.206
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.207 To 0.816
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.817 To 1.176
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

                        Case 16.177 To 17.676
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.206
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.207 To 0.816
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.817 To 1.176
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

                        Case 16.177 To 17.676
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8126"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.211
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.212 To 0.821
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.822 To 1.181
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.182 To 2.681
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.682 To 4.181
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.182 To 5.681
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.682 To 7.181
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.182 To 8.681
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.682 To 10.181
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.182 To 11.681
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.682 To 13.181
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.182 To 14.681
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 14.682 To 16.181
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 16.182 To 17.681
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.211
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.212 To 0.821
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.822 To 1.181
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.182 To 2.681
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.682 To 4.181
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.182 To 5.681
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.682 To 7.181
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.182 To 8.681
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.682 To 10.181
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.182 To 11.681
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.682 To 13.181
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.182 To 14.681
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 14.682 To 16.181
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 16.182 To 17.681
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8127"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.194
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.195 To 0.804
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.805 To 1.164
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.165 To 2.664
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.665 To 4.164
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.165 To 5.664
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.665 To 7.164
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.165 To 8.664
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.665 To 10.164
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.165 To 11.664
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.665 To 13.164
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.165 To 14.664
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 14.665 To 17.664
                            lirong = objdataview.Item(0).Row("厘容13")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.194
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.195 To 0.804
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.805 To 1.164
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.165 To 2.664
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.665 To 4.164
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.165 To 5.664
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.665 To 7.164
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.165 To 8.664
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.665 To 10.164
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.165 To 11.664
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.665 To 13.164
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.165 To 14.664
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 14.665 To 17.664
                            haorong = objdataview.Item(0).Row("毫容13")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8201"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.012
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.013 To 0.274
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.275 To 0.3
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.301 To 0.45
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.451 To 0.874
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 0.875 To 1.386
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.387 To 2.89
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.891 To 4.393
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.394 To 4.5
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.501 To 5.897
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.898 To 7.401
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.402 To 8.906
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.907 To 10.41
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.411 To 11.913
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.914 To 13.416
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 13.417 To 14.316
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.012
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.013 To 0.274
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.275 To 0.3
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.301 To 0.45
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.451 To 0.874
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 0.875 To 1.386
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.387 To 2.89
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.891 To 4.393
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 4.394 To 4.5
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.501 To 5.897
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.898 To 7.401
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.402 To 8.906
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.907 To 10.41
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.411 To 11.913
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.914 To 13.416
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 13.417 To 14.316
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If


            Case "8202"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.0146
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.0147 To 0.254
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.225 To 0.276
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.277 To 0.866
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.867 To 1.381
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.382 To 2.882
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 2.883 To 4.056
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.057 To 4.372
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.373 To 5.877
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 5.878 To 7.381
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.382 To 8.886
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 8.887 To 10.39
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.391 To 11.892
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 11.893 To 13.397
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.398 To 14.297
                            lirong = objdataview.Item(0).Row("厘容15")






                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                                   Case 0 To 0.0146
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.0147 To 0.254
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.225 To 0.276
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.277 To 0.866
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.867 To 1.381
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.382 To 2.882
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 2.883 To 4.056
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.057 To 4.372
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 4.373 To 5.877
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 5.878 To 7.381
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.382 To 8.886
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 8.887 To 10.39
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.391 To 11.892
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 11.893 To 13.397
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.398 To 14.297
                            haorong = objdataview.Item(0).Row("豪容15")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If




            Case "8203"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.031
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.032 To 0.17
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.171 To 0.274
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.275 To 0.284
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.285 To 0.874
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 0.875 To 1.393
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.394 To 2.894
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.895 To 4.064
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.065 To 4.384
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.385 To 5.889
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.89 To 7.393
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.394 To 8.898
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.899 To 10.402
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.403 To 11.904
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.905 To 13.409
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 13.41 To 14.309
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.031
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.032 To 0.17
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.171 To 0.274
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.275 To 0.284
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.285 To 0.874
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 0.875 To 1.393
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.394 To 2.894
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.895 To 4.064
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 4.065 To 4.384
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.385 To 5.889
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.89 To 7.393
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.394 To 8.898
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.899 To 10.402
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.403 To 11.904
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.905 To 13.409
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 13.41 To 14.309
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8204"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.031
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.032 To 0.291
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.292 To 0.3
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.301 To 0.45
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.451 To 0.896
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 0.897 To 1.406
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.407 To 2.907
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.908 To 4.397
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.398 To 4.5
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.501 To 5.902
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.903 To 7.406
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.407 To 8.911
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.912 To 10.415
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 10.416 To 11.917
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.918 To 13.422
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 13.423 To 14.322
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.031
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.032 To 0.291
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.292 To 0.3
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.301 To 0.45
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.451 To 0.896
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 0.897 To 1.406
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.407 To 2.907
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.908 To 4.397
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 4.398 To 4.5
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.501 To 5.902
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.903 To 7.406
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.407 To 8.911
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.912 To 10.415
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 10.416 To 11.917
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.918 To 13.422
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 13.423 To 14.322
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8205"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.052
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.053 To 0.141
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.142 To 0.632
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.633 To 0.912
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.913 To 1.002
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.003 To 1.082
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.083 To 1.162
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.163 To 1.252
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 1.253 To 1.412
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 1.413 To 1.502
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 1.503 To 2.579
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 2.58 To 4.078
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 4.079 To 5.578
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 5.579 To 7.078
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 7.079 To 8.578
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 8.579 To 10.078
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 10.079 To 11.578
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case 11.579 To 13.076
                            lirong = objdataview.Item(0).Row("厘容18")

                        Case 13.077 To 13.846
                            lirong = objdataview.Item(0).Row("厘容19")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.052
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.053 To 0.141
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.142 To 0.632
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.633 To 0.912
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.913 To 1.002
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.003 To 1.082
                            haorong = objdataview.Item(0).Row("毫容6")


                        Case 1.083 To 1.162
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.163 To 1.252
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 1.253 To 1.412
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 1.413 To 1.502
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 1.503 To 2.579
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 2.58 To 4.078
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 4.079 To 5.578
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 5.579 To 7.078
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 7.079 To 8.578
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 8.579 To 10.078
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 10.079 To 11.578
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case 11.579 To 13.076
                            haorong = objdataview.Item(0).Row("毫容18")

                        Case 13.077 To 13.846
                            haorong = objdataview.Item(0).Row("毫容19")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8206"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.106
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.107 To 0.333
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.334 To 1.033
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.034 To 1.443
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.444 To 2.949
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 2.95 To 4.459
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 4.46 To 5.959
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.96 To 7.462
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 7.463 To 8.962
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.963 To 10.463
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.464 To 11.97
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 11.971 To 13.48
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 13.481 To 14.989
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 14.99 To 15.91
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.106
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.107 To 0.333
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.334 To 1.033
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.034 To 1.443
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.444 To 2.949
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 2.95 To 4.459
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.533 To 2.023
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.46 To 5.959
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 7.463 To 8.962
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.963 To 10.463
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.464 To 11.97
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 11.971 To 13.48
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 13.481 To 14.989
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 14.99 To 15.91
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8207"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.081
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.082 To 0.308
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.309 To 1.008
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.009 To 1.428
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.429 To 2.934
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 2.935 To 4.443
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 4.444 To 5.944
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.945 To 7.447
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 7.448 To 8.947
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.948 To 10.447
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.448 To 11.955
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 11.956 To 13.465
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 13.466 To 14.974
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 14.975 To 15.894
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.081
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.082 To 0.308
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.309 To 1.008
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.009 To 1.428
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.429 To 2.934
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 2.935 To 4.443
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 4.444 To 5.944
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.945 To 7.447
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 7.448 To 8.947
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.948 To 10.447
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.448 To 11.955
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 11.956 To 13.465
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 13.466 To 14.974
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 14.975 To 15.894
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8208"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.119
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.12 To 0.328
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.329 To 1.028
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.029 To 1.438
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.439 To 2.945
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 2.946 To 4.455
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 4.456 To 5.955
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.956 To 7.458
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 7.459 To 8.958
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.959 To 10.459
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.46 To 11.969
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 11.97 To 15.896
                            lirong = objdataview.Item(0).Row("厘容12")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.119
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.12 To 0.328
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.329 To 1.028
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.029 To 1.438
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.439 To 2.945
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 2.946 To 4.455
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 4.456 To 5.955
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.956 To 7.458
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 7.459 To 8.958
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.959 To 10.459
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.46 To 11.969
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 11.97 To 15.896
                            haorong = objdataview.Item(0).Row("毫容12")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8209"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.14
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.141 To 0.248
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.249 To 0.341
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.342 To 1.041
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.042 To 1.451
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.452 To 1.571
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.572 To 1.628
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.629 To 1.968
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 1.969 To 2.025
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 2.026 To 2.956
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 2.957 To 4.456
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 4.457 To 5.957
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 5.958 To 7.459
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 7.46 To 8.966
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 8.967 To 10.476
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 10.477 To 11.984
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case 11.985 To 13.487
                            lirong = objdataview.Item(0).Row("厘容18")

                        Case 13.488 To 14.992
                            lirong = objdataview.Item(0).Row("厘容19")

                        Case 14.993 To 16.495
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 16.496 To 17.997
                            lirong = objdataview.Item(0).Row("厘容20")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.14
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.141 To 0.248
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.329 To 1.028
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.249 To 0.341
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.042 To 1.451
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.452 To 1.571
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.572 To 1.628
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.629 To 1.968
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 1.969 To 2.025
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 2.026 To 2.956
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 2.957 To 4.456
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 4.457 To 5.957
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 5.958 To 7.459
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 7.46 To 8.966
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 8.967 To 10.476
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 10.477 To 11.984
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 11.985 To 13.487
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case 13.488 To 14.992
                            haorong = objdataview.Item(0).Row("毫容18")

                        Case 14.993 To 16.495
                            haorong = objdataview.Item(0).Row("毫容19")

                        Case 16.496 To 17.997
                            haorong = objdataview.Item(0).Row("毫容20")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8210"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.28
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.281 To 0.335
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.336 To 0.39
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.391 To 0.935
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.936 To 1.481
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.482 To 3.281
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.282 To 5.081
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.082 To 6.881
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.882 To 8.681
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.682 To 10.481
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.482 To 12.281
                            lirong = objdataview.Item(0).Row("厘容11")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.28
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.281 To 0.335
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.336 To 0.39
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.391 To 0.935
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.936 To 1.481
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.482 To 3.281
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.282 To 5.081
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.082 To 6.881
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.882 To 8.681
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.682 To 10.481
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.482 To 12.281
                            haorong = objdataview.Item(0).Row("毫容11")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8211"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.28
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.281 To 0.336
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.337 To 0.39
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.391 To 0.936
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.937 To 1.487
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.488 To 3.287
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.288 To 5.087
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.088 To 6.887
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.888 To 8.687
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.688 To 10.487
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.488 To 12.287
                            lirong = objdataview.Item(0).Row("厘容11")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.28
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.281 To 0.336
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.337 To 0.39
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.391 To 0.936
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.937 To 1.487
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.488 To 3.287
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.288 To 5.087
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.088 To 6.887
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.888 To 8.687
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.688 To 10.487
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.488 To 12.287
                            haorong = objdataview.Item(0).Row("毫容11")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8212"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.183
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.184 To 0.803
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.804 To 1.423
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.424 To 3.223
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.224 To 5.023
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.024 To 6.823
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.824 To 8.623
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.624 To 10.423
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.424 To 12.223
                            lirong = objdataview.Item(0).Row("厘容9")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.183
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.184 To 0.803
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.804 To 1.423
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.424 To 3.223
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.224 To 5.023
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.024 To 6.823
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.824 To 8.623
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.624 To 10.423
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.424 To 12.223
                            haorong = objdataview.Item(0).Row("毫容9")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8213"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.169
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.166 To 0.789
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.79 To 1.474
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.475 To 3.274
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.275 To 5.074
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.075 To 6.874
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.875 To 8.674
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.675 To 10.474
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.475 To 12.274
                            lirong = objdataview.Item(0).Row("厘容9")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.169
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.166 To 0.789
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.79 To 1.474
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.475 To 3.274
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.275 To 5.074
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.075 To 6.874
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.875 To 8.674
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.675 To 10.474
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.475 To 12.274
                            haorong = objdataview.Item(0).Row("毫容9")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8214"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.165
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.166 To 0.785
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.786 To 1.465
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.466 To 3.265
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.266 To 5.065
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.066 To 6.865
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.866 To 8.665
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.666 To 10.465
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.466 To 12.265
                            lirong = objdataview.Item(0).Row("厘容9")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.165
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.166 To 0.785
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.786 To 1.465
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.466 To 3.265
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.266 To 5.065
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.066 To 6.865
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.866 To 8.665
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.666 To 10.465
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.466 To 12.265
                            haorong = objdataview.Item(0).Row("毫容9")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8215"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.28
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.281 To 0.335
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.336 To 0.39
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.391 To 0.935
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.936 To 1.483
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.484 To 3.283
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.284 To 5.083
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.084 To 6.883
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.884 To 8.683
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.684 To 10.483
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.484 To 12.283
                            lirong = objdataview.Item(0).Row("厘容11")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.28
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.281 To 0.335
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.336 To 0.39
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.391 To 0.935
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.936 To 1.483
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.484 To 3.283
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.284 To 5.083
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.084 To 6.883
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.884 To 8.683
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.684 To 10.483
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.484 To 12.283
                            haorong = objdataview.Item(0).Row("毫容11")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8216"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.278
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.279 To 0.329
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.33 To 0.388
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.389 To 0.93
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.931 To 1.478
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.479 To 3.278
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.279 To 5.078
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.079 To 6.878
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.879 To 8.678
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.679 To 10.478
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.479 To 12.278
                            lirong = objdataview.Item(0).Row("厘容11")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.278
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.279 To 0.329
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.33 To 0.388
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.389 To 0.93
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.931 To 1.478
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.479 To 3.278
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.279 To 5.078
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.079 To 6.878
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.879 To 8.678
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.679 To 10.478
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.479 To 12.278
                            haorong = objdataview.Item(0).Row("毫容11")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
              Case "8217"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.103
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.104 To 0.788
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.789 To 1.473
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.474 To 3.273
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.274 To 5.073
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.074 To 6.873
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.874 To 8.673
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.674 To 10.473
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.474 To 12.273
                            lirong = objdataview.Item(0).Row("厘容9")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.103
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.104 To 0.788
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.789 To 1.473
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.474 To 3.273
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.274 To 5.073
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.074 To 6.873
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.874 To 8.673
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.674 To 10.473
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.474 To 12.273
                            haorong = objdataview.Item(0).Row("毫容9")


                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8218"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.027
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.271 To 0.324
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.325 To 0.38
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.381 To 0.924
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.925 To 1.468
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.469 To 3.269
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.27 To 5.069
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 5.07 To 6.869
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.87 To 8.669
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 8.67 To 10.469
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 10.47 To 12.269
                            lirong = objdataview.Item(0).Row("厘容11")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.027
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.271 To 0.324
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.325 To 0.38
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.381 To 0.924
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.925 To 1.468
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.469 To 3.269
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.27 To 5.069
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 5.07 To 6.869
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.87 To 8.669
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 8.67 To 10.469
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 10.47 To 12.269
                            haorong = objdataview.Item(0).Row("毫容11")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8219"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.172
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.173 To 0.787
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.788 To 1.472
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.473 To 3.272
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.273 To 5.072
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 5.073 To 5.873
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.873 To 8.672
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 8.673 To 10.472
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 10.473 To 12.272
                            lirong = objdataview.Item(0).Row("厘容9")





                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.172
                            haorong = objdataview.Item(0).Row("毫容1")

               
                        Case 0.173 To 0.787
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.788 To 1.472
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.473 To 3.272
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.273 To 5.072
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 5.073 To 5.873
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.873 To 8.672
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 8.673 To 10.472
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 10.473 To 12.272
                            haorong = objdataview.Item(0).Row("毫容9")





                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8220"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.205
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.206 To 0.815
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.816 To 1.195
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.196 To 2.695
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.696 To 4.195
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.196 To 5.695
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.696 To 7.195
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.196 To 8.695
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.696 To 10.195
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.196 To 11.695
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.696 To 13.195
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.196 To 14.695
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 14.696 To 16.195
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 16.196 To 17.695
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.205
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.206 To 0.815
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.816 To 1.195
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.196 To 2.695
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.696 To 4.195
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.196 To 5.695
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.696 To 7.195
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.196 To 8.695
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.696 To 10.195
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.196 To 11.695
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.696 To 13.195
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.196 To 14.695
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 14.696 To 16.195
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 16.196 To 17.695
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "8301"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.046
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.047 To 0.224
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.225 To 0.284
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.285 To 0.332
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.333 To 0.484
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 0.485 To 0.894
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 0.895 To 1.417
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.418 To 2.897
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.898 To 4.381
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.382 To 4.99
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 4.991 To 5.871
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 5.872 To 7.355
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 7.356 To 8.875
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 8.876 To 10.396
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 10.397 To 11.911
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 11.912 To 13.425
                            lirong = objdataview.Item(0).Row("厘容16")


                        Case 13.426 To 14.321
                            lirong = objdataview.Item(0).Row("厘容17")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.046
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.047 To 0.224
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.225 To 0.284
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.285 To 0.332
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.333 To 0.484
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 0.485 To 0.894
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 0.895 To 1.417
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.418 To 2.897
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.898 To 4.381
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.382 To 4.99
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 4.991 To 5.871
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 5.872 To 7.355
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 7.356 To 8.875
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 8.876 To 10.396
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 10.397 To 11.911
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 11.912 To 13.425
                            haorong = objdataview.Item(0).Row("毫容16")


                        Case 13.426 To 14.321
                            haorong = objdataview.Item(0).Row("毫容17")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8302"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.009
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.01 To 0.174
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.175 To 0.282
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.283 To 0.283
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 0.284 To 0.484
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 0.485 To 0.883
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 0.884 To 1.404
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.405 To 2.904
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.905 To 4.404
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.405 To 4.99
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 4.991 To 5.904
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 5.905 To 7.404
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 7.405 To 8.904
                            lirong = objdataview.Item(0).Row("厘容13")


                        Case 8.905 To 10.404
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 10.405 To 11.904
                            lirong = objdataview.Item(0).Row("厘容15")


                        Case 11.905 To 13.404
                            lirong = objdataview.Item(0).Row("厘容16")


                        Case 13.405 To 14.304
                            lirong = objdataview.Item(0).Row("厘容17")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.009
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.01 To 0.174
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.175 To 0.282
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.283 To 0.283
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 0.284 To 0.484
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 0.485 To 0.883
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 0.884 To 1.404
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.405 To 2.904
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.905 To 4.404
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.405 To 4.99
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 4.991 To 5.904
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 5.905 To 7.404
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 7.405 To 8.904
                            haorong = objdataview.Item(0).Row("毫容13")


                        Case 8.905 To 10.404
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 10.405 To 11.904
                            haorong = objdataview.Item(0).Row("毫容15")


                        Case 11.905 To 13.404
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 13.405 To 14.304
                            haorong = objdataview.Item(0).Row("毫容17")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8303"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.1
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.101 To 0.211
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.212 To 0.333
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.334 To 1.033
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.034 To 1.428
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.429 To 1.548
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.549 To 2.039
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.04 To 2.932
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.933 To 4.434
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.435 To 5.944
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.945 To 7.444
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.445 To 8.945
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.946 To 10.446
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 10.447 To 11.946
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.947 To 13.448
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 13.449 To 14.948
                            lirong = objdataview.Item(0).Row("厘容16")


                        Case 14.949 To 15.833
                            lirong = objdataview.Item(0).Row("厘容17")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.1
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.101 To 0.211
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.212 To 0.333
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.334 To 1.033
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.034 To 1.428
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.429 To 1.548
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.549 To 2.039
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.04 To 2.932
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.933 To 4.434
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.435 To 5.944
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.945 To 7.444
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.445 To 8.945
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.946 To 10.446
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 10.447 To 11.946
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.947 To 13.448
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 13.449 To 14.948
                            haorong = objdataview.Item(0).Row("毫容16")


                        Case 14.949 To 15.833
                            haorong = objdataview.Item(0).Row("毫容17")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8304"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.1
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.101 To 0.211
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.212 To 0.332
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.333 To 1.032
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.033 To 1.427
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.428 To 1.567
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.568 To 2.078
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.079 To 2.93
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.931 To 4.432
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.433 To 5.94
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.941 To 7.442
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.443 To 8.942
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.943 To 10.444
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 10.445 To 11.944
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.945 To 13.446
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 13.447 To 14.946
                            lirong = objdataview.Item(0).Row("厘容16")


                        Case 14.947 To 15.78
                            lirong = objdataview.Item(0).Row("厘容17")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.1
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.101 To 0.211
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.212 To 0.332
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.333 To 1.032
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.033 To 1.427
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.428 To 1.567
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.568 To 2.078
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.079 To 2.93
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.931 To 4.432
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.433 To 5.94
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.941 To 7.442
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.443 To 8.942
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.943 To 10.444
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 10.445 To 11.944
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.945 To 13.446
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 13.447 To 14.946
                            haorong = objdataview.Item(0).Row("毫容16")


                        Case 14.947 To 15.78
                            haorong = objdataview.Item(0).Row("毫容17")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8305"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.121
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.122 To 0.232
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.233 To 0.337
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.338 To 1.037
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.038 To 1.432
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.433 To 1.532
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.533 To 2.023
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.024 To 2.936
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.937 To 4.438
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.439 To 5.948
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.949 To 7.448
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.449 To 8.949
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.95 To 10.45
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 10.451 To 11.95
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.951 To 13.452
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 13.453 To 14.952
                            lirong = objdataview.Item(0).Row("厘容16")


                        Case 14.953 To 15.788
                            lirong = objdataview.Item(0).Row("厘容17")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.121
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.122 To 0.232
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.233 To 0.337
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.338 To 1.037
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.038 To 1.432
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.433 To 1.532
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.533 To 2.023
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.024 To 2.936
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.937 To 4.438
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.439 To 5.948
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.949 To 7.448
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.449 To 8.949
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.95 To 10.45
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 10.451 To 11.95
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.951 To 13.452
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 13.453 To 14.952
                            haorong = objdataview.Item(0).Row("毫容16")


                        Case 14.953 To 15.788
                            haorong = objdataview.Item(0).Row("毫容17")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8306"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.121
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.122 To 0.232
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.233 To 0.354
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.355 To 1.054
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.055 To 1.448
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.449 To 1.548
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.549 To 2.039
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 2.04 To 2.952
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.953 To 4.454
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 4.455 To 5.964
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 5.965 To 7.464
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 7.465 To 8.965
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 8.966 To 10.466
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 10.467 To 11.966
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 11.967 To 13.468
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 13.469 To 14.968
                            lirong = objdataview.Item(0).Row("厘容16")


                        Case 14.969 To 15.809
                            lirong = objdataview.Item(0).Row("厘容17")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.121
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.122 To 0.232
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.233 To 0.354
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.355 To 1.054
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.055 To 1.448
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.449 To 1.548
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.549 To 2.039
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 2.04 To 2.952
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.953 To 4.454
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 4.455 To 5.964
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 5.965 To 7.464
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 7.465 To 8.965
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 8.966 To 10.466
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 10.467 To 11.966
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 11.967 To 13.468
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 13.469 To 14.968
                            haorong = objdataview.Item(0).Row("毫容16")


                        Case 14.969 To 15.809
                            haorong = objdataview.Item(0).Row("毫容17")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8307"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.202
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.203 To 0.812
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.813 To 1.482
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.483 To 3.272
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.273 To 4.772
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.773 To 6.272
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.273 To 7.772
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.773 To 9.272
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 9.273 To 10.772
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.773 To 12.272
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 12.273 To 13.772
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.773 To 15.272
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 15.273 To 17.692
                            lirong = objdataview.Item(0).Row("厘容13")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.202
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.203 To 0.812
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.813 To 1.482
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.483 To 3.272
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.273 To 4.772
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.773 To 6.272
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.273 To 7.772
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.773 To 9.272
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 9.273 To 10.772
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.773 To 12.272
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 12.273 To 13.772
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.773 To 15.272
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 15.273 To 17.692
                            lirong = objdataview.Item(0).Row("厘容13")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8308"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.213
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.214 To 0.823
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.824 To 1.493
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.494 To 3.293
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.294 To 4.793
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.794 To 6.293
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.294 To 7.793
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.794 To 9.293
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 9.294 To 10.793
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.794 To 12.293
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 12.294 To 13.793
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.794 To 15.293
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 15.294 To 16.493
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 16.494 To 17.693
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.213
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.214 To 0.823
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.824 To 1.493
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.494 To 3.293
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.294 To 4.793
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.794 To 6.293
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.294 To 7.793
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.794 To 9.293
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 9.294 To 10.793
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.794 To 12.293
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 12.294 To 13.793
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.794 To 15.293
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 15.294 To 16.493
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 16.494 To 17.693
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8309"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.211
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.212 To 0.821
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.822 To 1.491
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.492 To 3.291
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.292 To 4.791
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.792 To 6.291
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.292 To 7.791
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.792 To 9.291
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 9.292 To 10.791
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.792 To 12.291
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 12.292 To 13.791
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.792 To 15.291
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 15.292 To 16.491
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 16.492 To 17.691
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.211
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.212 To 0.821
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.822 To 1.491
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.492 To 3.291
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.292 To 4.791
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.792 To 6.291
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.292 To 7.791
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.792 To 9.291
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 9.292 To 10.791
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.792 To 12.291
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 12.292 To 13.791
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.792 To 15.291
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 15.292 To 16.491
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 16.492 To 17.691
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8310"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.107
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.108 To 0.717
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.718 To 1.427
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.428 To 3.217
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.218 To 4.717
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.718 To 6.217
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.218 To 7.717
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.718 To 9.217
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 9.218 To 10.717
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.718 To 12.217
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 12.218 To 13.717
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.718 To 15.217
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 15.218 To 16.427
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 16.428 To 17.637
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.107
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.108 To 0.717
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.718 To 1.427
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.428 To 3.217
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.218 To 4.717
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.718 To 6.217
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.218 To 7.717
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.718 To 9.217
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 9.218 To 10.717
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.718 To 12.217
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 12.218 To 13.717
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.718 To 15.217
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 15.218 To 16.427
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 16.428 To 17.637
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8311"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.166
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.167 To 0.786
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.787 To 0.92
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.921 To 1.05
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.051 To 1.486
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.487 To 3.246
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.247 To 4.741
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.742 To 6.236
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.237 To 7.726
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.727 To 9.226
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 9.227 To 10.731
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.732 To 12.227
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 12.228 To 13.725
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 13.726 To 15.235
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 15.236 To 17.741
                            lirong = objdataview.Item(0).Row("厘容15")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.166
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.167 To 0.786
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.787 To 0.92
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.921 To 1.05
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.051 To 1.486
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.487 To 3.246
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.247 To 4.741
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.742 To 6.236
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.237 To 7.726
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.727 To 9.226
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 9.227 To 10.731
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.732 To 12.227
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 12.228 To 13.725
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 13.726 To 15.235
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 15.236 To 17.741
                            haorong = objdataview.Item(0).Row("毫容15")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8312"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.141
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.142 To 0.756
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.757 To 0.92
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.921 To 1.05
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.051 To 1.456
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.457 To 3.216
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.217 To 4.711
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.712 To 6.206
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.207 To 7.696
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.967 To 9.196
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 9.197 To 10.701
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.702 To 12.197
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 12.198 To 13.695
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 13.696 To 15.205
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 15.206 To 16.461
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 16.462 To 17.711
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.141
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.142 To 0.756
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.757 To 0.92
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.921 To 1.05
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.051 To 1.456
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.457 To 3.216
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.217 To 4.711
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.712 To 6.206
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.207 To 7.696
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.967 To 9.196
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 9.197 To 10.701
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.702 To 12.197
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 12.198 To 13.695
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 13.696 To 15.205
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 15.206 To 16.461
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 16.462 To 17.711
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8313"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.152
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.142 To 0.767
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.768 To 0.9
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.901 To 1.1
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.101 To 1.467
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.468 To 3.227
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.228 To 4.722
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.723 To 6.217
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.218 To 7.707
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.708 To 9.207
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 9.208 To 10.712
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.713 To 12.208
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 12.209 To 13.706
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 13.707 To 15.216
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 15.217 To 16.472
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 16.473 To 17.722
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.152
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.142 To 0.767
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.768 To 0.9
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.901 To 1.1
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.101 To 1.467
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.468 To 3.227
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.228 To 4.722
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.723 To 6.217
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.218 To 7.707
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.708 To 9.207
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 9.208 To 10.712
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.713 To 12.208
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 12.209 To 13.706
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 13.707 To 15.216
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 15.217 To 16.472
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 16.473 To 17.722
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8314"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.185
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.186 To 0.8
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.801 To 0.92
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 0.921 To 1.05
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.051 To 1.495
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.496 To 3.255
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 3.256 To 4.75
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 4.751 To 6.245
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 6.246 To 7.735
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 7.736 To 9.235
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 9.236 To 10.74
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 10.741 To 12.236
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 12.237 To 13.734
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 13.735 To 15.244
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 15.245 To 16.5
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 16.501 To 17.75
                            lirong = objdataview.Item(0).Row("厘容16")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.141
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.142 To 0.756
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.757 To 0.92
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 0.921 To 1.05
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.051 To 1.456
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.457 To 3.216
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 3.217 To 4.711
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 4.712 To 6.206
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 6.207 To 7.696
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 7.967 To 9.196
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 9.197 To 10.701
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 10.702 To 12.197
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 12.198 To 13.695
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 13.696 To 15.205
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 15.206 To 16.461
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 16.462 To 17.711
                            haorong = objdataview.Item(0).Row("毫容16")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8401"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.14
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.141 To 0.315
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.316 To 1.015
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.016 To 1.478
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.479 To 1.535
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.536 To 1.715
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.716 To 3.23
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 3.231 To 4.747
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 4.748 To 6.247
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 6.248 To 7.752
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 7.753 To 9.254
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 9.255 To 10.759
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 10.76 To 12.261
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 12.262 To 13.771
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 13.772 To 15.266
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 15.267 To 16.766
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 16.767 To 17.959
                            lirong = objdataview.Item(0).Row("厘容17")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.14
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.141 To 0.315
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.316 To 1.015
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.016 To 1.478
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.479 To 1.535
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.536 To 1.715
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.716 To 3.23
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 3.231 To 4.747
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 4.748 To 6.247
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 6.248 To 7.752
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 7.753 To 9.254
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 9.255 To 10.759
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 10.76 To 12.261
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 12.262 To 13.771
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 13.772 To 15.266
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 15.267 To 16.766
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 16.767 To 17.959
                            haorong = objdataview.Item(0).Row("毫容17")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "8402"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.145
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.146 To 0.321
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.322 To 1.021
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.022 To 1.472
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.473 To 1.529
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.53 To 1.729
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.73 To 1.949
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.95 To 2.006
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.007 To 3.244
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 3.245 To 4.761
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 4.762 To 6.261
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 6.262 To 7.766
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 7.767 To 9.268
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 9.269 To 10.773
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 10.774 To 12.275
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 12.276 To 13.785
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 13.786 To 15.28
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case 15.281 To 16.78
                            lirong = objdataview.Item(0).Row("厘容18")

                        Case 16.781 To 17.973
                            lirong = objdataview.Item(0).Row("厘容19")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.145
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.146 To 0.321
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.322 To 1.021
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.022 To 1.472
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.473 To 1.529
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.53 To 1.729
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.73 To 1.949
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.95 To 2.006
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.007 To 3.244
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 3.245 To 4.761
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 4.762 To 6.261
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 6.262 To 7.766
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 7.767 To 9.268
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 9.269 To 10.773
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 10.774 To 12.275
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 12.276 To 13.785
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 13.786 To 15.28
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case 15.281 To 16.78
                            haorong = objdataview.Item(0).Row("毫容18")

                        Case 16.781 To 17.973
                            haorong = objdataview.Item(0).Row("毫容19")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8501"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.143
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.144 To 0.333
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.334 To 1.033
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.034 To 1.553
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.554 To 1.61
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.611 To 1.773
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.774 To 1.896
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.897 To 1.953
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 1.954 To 3.234
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 3.235 To 4.732
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 4.733 To 6.236
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 6.237 To 7.738
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 7.739 To 9.241
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 9.242 To 10.746
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 10.747 To 12.253
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 12.254 To 13.763
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 13.764 To 15.259
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case 15.26 To 16.759
                            lirong = objdataview.Item(0).Row("厘容18")

                        Case 16.76 To 17.993
                            lirong = objdataview.Item(0).Row("厘容19")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.143
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.144 To 0.333
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.334 To 1.033
                            haorong = objdataview.Item(0).Row("毫容3")


                        Case 1.034 To 1.553
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.554 To 1.61
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.611 To 1.773
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.774 To 1.896
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.897 To 1.953
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 1.954 To 3.234
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 3.235 To 4.732
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 4.733 To 6.236
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 6.237 To 7.738
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 7.739 To 9.241
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 9.242 To 10.746
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 10.747 To 12.253
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 12.254 To 13.763
                            haorong = objdataview.Item(0).Row("毫容16")


                        Case 13.764 To 15.259
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case 15.26 To 16.759
                            haorong = objdataview.Item(0).Row("毫容18")

                        Case 16.76 To 17.993
                            haorong = objdataview.Item(0).Row("毫容19")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8502"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.084
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.085 To 0.325
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.326 To 1.025
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.026 To 1.545
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 1.546 To 1.602
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 1.603 To 1.725
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 1.726 To 1.945
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 1.946 To 2.002
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 2.003 To 3.227
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 3.228 To 4.724
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 4.725 To 6.227
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 6.228 To 7.728
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 7.729 To 9.232
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 9.233 To 10.739
                            lirong = objdataview.Item(0).Row("厘容14")

                        Case 10.74 To 12.245
                            lirong = objdataview.Item(0).Row("厘容15")

                        Case 12.246 To 13.753
                            lirong = objdataview.Item(0).Row("厘容16")

                        Case 13.754 To 15.251
                            lirong = objdataview.Item(0).Row("厘容17")

                        Case 15.252 To 16.752
                            lirong = objdataview.Item(0).Row("厘容18")

                        Case 16.753 To 17.987
                            lirong = objdataview.Item(0).Row("厘容19")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0.001 To 0.084
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.085 To 0.325
                            haorong = objdataview.Item(0).Row("毫容2")


                        Case 0.326 To 1.025
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.026 To 1.545
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 1.546 To 1.602
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 1.603 To 1.725
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 1.726 To 1.945
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 1.946 To 2.002
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 2.003 To 3.227
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 3.228 To 4.724
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 4.725 To 6.227
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 6.228 To 7.728
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 7.729 To 9.232
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 9.233 To 10.739
                            haorong = objdataview.Item(0).Row("毫容14")

                        Case 10.74 To 12.245
                            haorong = objdataview.Item(0).Row("毫容15")

                        Case 12.246 To 13.753
                            haorong = objdataview.Item(0).Row("毫容16")

                        Case 13.754 To 15.251
                            haorong = objdataview.Item(0).Row("毫容17")

                        Case 15.252 To 16.752
                            haorong = objdataview.Item(0).Row("毫容18")


                        Case 16.753 To 17.987
                            haorong = objdataview.Item(0).Row("毫容19")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8503"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.182
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.183 To 0.792
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.793 To 1.462
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.463 To 3.252
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.253 To 4.752
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.753 To 6.252
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.253 To 7.752
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.753 To 9.252
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 9.253 To 10.752
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.753 To 12.252
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 12.253 To 13.752
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.753 To 15.252
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 15.253 To 16.472
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 16.473 To 17.692
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.182
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.183 To 0.792
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.793 To 1.462
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.463 To 3.252
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.253 To 4.752
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.753 To 6.252
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.253 To 7.752
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.753 To 9.252
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 9.253 To 10.752
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.753 To 12.252
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 12.253 To 13.752
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.753 To 15.252
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 15.253 To 16.472
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 16.473 To 17.692
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8504"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.188
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.189 To 0.798
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.799 To 1.473
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.474 To 3.263
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.264 To 4.763
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.764 To 6.263
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.264 To 7.763
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.764 To 9.263
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 9.264 To 10.763
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.764 To 12.263
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 12.264 To 13.763
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.764 To 15.263
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 15.264 To 16.473
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 16.474 To 17.683
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.188
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.189 To 0.798
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.799 To 1.473
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.474 To 3.263
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.264 To 4.763
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.764 To 6.263
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.264 To 7.763
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.764 To 9.263
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 9.264 To 10.763
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.764 To 12.263
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 12.264 To 13.763
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.764 To 15.263
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 15.264 To 16.473
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 16.474 To 17.683
                            haorong = objdataview.Item(0).Row("毫容14")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If
            Case "8505"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.154
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.155 To 0.764
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.765 To 1.444
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.445 To 3.234
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 3.235 To 4.734
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.735 To 6.234
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 6.235 To 7.734
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.735 To 9.234
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 9.235 To 10.734
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.735 To 12.234
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 12.235 To 13.734
                            lirong = objdataview.Item(0).Row("厘容11")

                        Case 13.735 To 15.234
                            lirong = objdataview.Item(0).Row("厘容12")

                        Case 15.235 To 16.454
                            lirong = objdataview.Item(0).Row("厘容13")

                        Case 16.455 To 17.674
                            lirong = objdataview.Item(0).Row("厘容14")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.154
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.155 To 0.764
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.765 To 1.444
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.445 To 3.234
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 3.235 To 4.734
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.735 To 6.234
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 6.235 To 7.734
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.735 To 9.234
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 9.235 To 10.734
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.735 To 12.234
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 12.235 To 13.734
                            haorong = objdataview.Item(0).Row("毫容11")

                        Case 13.735 To 15.234
                            haorong = objdataview.Item(0).Row("毫容12")

                        Case 15.235 To 16.454
                            haorong = objdataview.Item(0).Row("毫容13")

                        Case 16.455 To 17.674
                            haorong = objdataview.Item(0).Row("毫容14")





                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T01"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.063
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.064 To 0.663
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.664 To 1.098
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.099 To 2.598
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.599 To 4.098
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.099 To 5.598
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.599 To 7.098
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.099 To 8.598
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.599 To 10.098
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.099 To 11.598
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.599 To 12.618
                            lirong = objdataview.Item(0).Row("厘容11")

                        




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.063
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.064 To 0.663
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.664 To 1.098
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.099 To 2.598
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.599 To 4.098
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.099 To 5.598
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.599 To 7.098
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.099 To 8.598
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.599 To 10.098
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.099 To 11.598
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.599 To 12.618
                            haorong = objdataview.Item(0).Row("毫容11")

                        




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T02"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.121
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.122 To 0.721
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.722 To 1.141
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.142 To 2.641
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.642 To 4.141
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.142 To 5.641
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.642 To 7.141
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.142 To 8.641
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.642 To 10.141
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.142 To 11.641
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.642 To 12.661
                            lirong = objdataview.Item(0).Row("厘容11")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.121
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.122 To 0.721
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.722 To 1.141
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.142 To 2.641
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.642 To 4.141
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.142 To 5.641
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.642 To 7.141
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.142 To 8.641
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.642 To 10.141
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.142 To 11.641
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.642 To 12.661
                            haorong = objdataview.Item(0).Row("毫容11")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T03"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.109
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.11 To 0.709
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.71 To 1.129
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.13 To 2.629
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.63 To 4.129
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.13 To 5.629
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.63 To 7.129
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.13 To 8.629
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.63 To 10.129
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.13 To 11.629
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.63 To 12.649
                            lirong = objdataview.Item(0).Row("厘容11")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.109
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.11 To 0.709
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.71 To 1.129
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.13 To 2.629
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.63 To 4.129
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.13 To 5.629
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.63 To 7.129
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.13 To 8.629
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.63 To 10.129
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.13 To 11.629
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.63 To 12.649
                            haorong = objdataview.Item(0).Row("毫容11")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T04"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.102
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.103 To 0.702
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.703 To 1.122
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.123 To 2.622
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.623 To 4.122
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.123 To 5.622
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.623 To 7.122
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.123 To 8.622
                            lirong = objdataview.Item(0).Row("厘容8")

                        Case 8.623 To 10.122
                            lirong = objdataview.Item(0).Row("厘容9")

                        Case 10.123 To 11.622
                            lirong = objdataview.Item(0).Row("厘容10")

                        Case 11.623 To 12.642
                            lirong = objdataview.Item(0).Row("厘容11")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.102
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.103 To 0.702
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.703 To 1.122
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.123 To 2.622
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.623 To 4.122
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.123 To 5.622
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.623 To 7.122
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.123 To 8.622
                            haorong = objdataview.Item(0).Row("毫容8")

                        Case 8.623 To 10.122
                            haorong = objdataview.Item(0).Row("毫容9")

                        Case 10.123 To 11.622
                            haorong = objdataview.Item(0).Row("毫容10")

                        Case 11.623 To 12.642
                            haorong = objdataview.Item(0).Row("毫容11")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T05"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.194
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.195 To 0.794
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.795 To 1.1204
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.1205 To 2.704
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.705 To 4.204
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.205 To 5.704
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.705 To 6.954
                            lirong = objdataview.Item(0).Row("厘容7")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.194
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.195 To 0.794
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.795 To 1.1204
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.1205 To 2.704
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.705 To 4.204
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.205 To 5.704
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.705 To 6.954
                            haorong = objdataview.Item(0).Row("毫容7")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T06"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.115
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.116 To 0.715
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.716 To 1.12
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.121 To 2.62
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.621 To 4.12
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.121 To 5.62
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.621 To 7.12
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.121 To 7.68
                            lirong = objdataview.Item(0).Row("厘容8")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.115
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.116 To 0.715
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.716 To 1.12
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.121 To 2.62
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.621 To 4.12
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.121 To 5.62
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.621 To 7.12
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.121 To 7.68
                            haorong = objdataview.Item(0).Row("毫容8")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T07"

                If objdataview.Count >= 1 Then
                    Select Case gaodu

                        Case 0 To 0.112
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.113 To 0.712
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.713 To 1.117
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.118 To 2.617
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.618 To 4.117
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.118 To 5.617
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.618 To 7.117
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.118 To 7.677
                            lirong = objdataview.Item(0).Row("厘容8")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.112
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.113 To 0.712
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.713 To 1.117
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.118 To 2.617
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.618 To 4.117
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.118 To 5.617
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.618 To 7.117
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.118 To 7.677
                            haorong = objdataview.Item(0).Row("毫容8")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T08"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.183
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.184 To 0.783
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.784 To 1.189
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.19 To 2.689
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.69 To 4.189
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.19 To 5.689
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.69 To 6.939
                            lirong = objdataview.Item(0).Row("厘容7")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.183
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.184 To 0.783
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.784 To 1.189
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.19 To 2.689
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.69 To 4.189
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.19 To 5.689
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.69 To 6.939
                            haorong = objdataview.Item(0).Row("毫容7")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T09"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.195
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.196 To 0.795
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.796 To 1.205
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.206 To 2.705
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.706 To 4.205
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.206 To 5.705
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.706 To 6.955
                            lirong = objdataview.Item(0).Row("厘容7")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.195
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.196 To 0.795
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.796 To 1.205
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.206 To 2.705
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.706 To 4.205
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.206 To 5.705
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.706 To 6.955
                            haorong = objdataview.Item(0).Row("毫容7")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T10"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.195
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.196 To 0.795
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.796 To 1.205
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.206 To 2.705
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.706 To 4.205
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.206 To 5.705
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.706 To 6.955
                            lirong = objdataview.Item(0).Row("厘容7")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.195
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.196 To 0.795
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.796 To 1.205
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.206 To 2.705
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.706 To 4.205
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.206 To 5.705
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.706 To 6.955
                            haorong = objdataview.Item(0).Row("毫容7")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T11"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.107
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.108 To 0.707
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.708 To 1.112
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.113 To 2.612
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.613 To 4.112
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.113 To 5.612
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.613 To 7.112
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.113 To 7.672
                            lirong = objdataview.Item(0).Row("厘容8")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.107
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.108 To 0.707
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.708 To 1.112
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.113 To 2.612
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.613 To 4.112
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.113 To 5.612
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.613 To 7.112
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.113 To 7.672
                            haorong = objdataview.Item(0).Row("毫容8")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T12"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.095
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.096 To 0.695
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.696 To 1.11
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.111 To 2.6
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.601 To 4.1
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.101 To 5.6
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.601 To 7.1
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.101 To 7.66
                            lirong = objdataview.Item(0).Row("厘容8")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.095
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.096 To 0.695
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.696 To 1.11
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.111 To 2.6
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.601 To 4.1
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.101 To 5.6
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.601 To 7.1
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.101 To 7.66
                            haorong = objdataview.Item(0).Row("毫容8")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T13"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.111
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.112 To 0.711
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.712 To 1.116
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.117 To 2.616
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.617 To 4.116
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.117 To 5.616
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.617 To 7.116
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.117 To 7.676
                            lirong = objdataview.Item(0).Row("厘容8")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.111
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.112 To 0.711
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.712 To 1.116
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.117 To 2.616
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.617 To 4.116
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.117 To 5.616
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.617 To 7.116
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.117 To 7.676
                            haorong = objdataview.Item(0).Row("毫容8")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T14"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.086
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.087 To 0.686
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.687 To 1.091
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.092 To 2.591
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.592 To 4.091
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.092 To 5.591
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.592 To 7.091
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.092 To 7.651
                            lirong = objdataview.Item(0).Row("厘容8")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.086
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.087 To 0.686
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.687 To 1.091
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.092 To 2.591
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.592 To 4.091
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.092 To 5.591
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.592 To 7.091
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.092 To 7.651
                            haorong = objdataview.Item(0).Row("毫容8")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T15"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.094
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.095 To 0.694
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.695 To 1.104
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.105 To 2.604
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.605 To 4.104
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.105 To 5.604
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.605 To 7.104
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.105 To 7.664
                            lirong = objdataview.Item(0).Row("厘容8")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.094
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.095 To 0.694
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.695 To 1.104
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.105 To 2.604
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.605 To 4.104
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.105 To 5.604
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.605 To 7.104
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.105 To 7.664
                            haorong = objdataview.Item(0).Row("毫容8")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T16"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.189
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.19 To 0.789
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.79 To 1.209
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.21 To 2.709
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.71 To 4.209
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.21 To 5.709
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.71 To 7.209
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.21 To 7.769
                            lirong = objdataview.Item(0).Row("厘容8")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.189
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.19 To 0.789
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.79 To 1.209
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.21 To 2.709
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.71 To 4.209
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.21 To 5.709
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.71 To 7.209
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.21 To 7.769
                            haorong = objdataview.Item(0).Row("毫容8")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case "T17"

                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.188
                            lirong = objdataview.Item(0).Row("厘容1")

                        Case 0.189 To 0.788
                            lirong = objdataview.Item(0).Row("厘容2")

                        Case 0.789 To 1.208
                            lirong = objdataview.Item(0).Row("厘容3")

                        Case 1.209 To 2.708
                            lirong = objdataview.Item(0).Row("厘容4")

                        Case 2.709 To 4.208
                            lirong = objdataview.Item(0).Row("厘容5")

                        Case 4.209 To 5.708
                            lirong = objdataview.Item(0).Row("厘容6")

                        Case 5.709 To 7.208
                            lirong = objdataview.Item(0).Row("厘容7")

                        Case 7.209 To 7.768
                            lirong = objdataview.Item(0).Row("厘容8")




                        Case Else
                            lirong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    lirong = 0 '只有一种情况，就是cm是0
                End If







                '开始查询毫米容量
                temp = gaodu * 1000
                temp = Int(temp) Mod 10
                mm = temp


                objdataadapter.SelectCommand = New OleDb.OleDbCommand
                objdataadapter.SelectCommand.Connection = localobjconnection
                objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "mm")
                objdataview = New DataView(objdataset.Tables("mm"))


                If objdataview.Count >= 1 Then
                    Select Case gaodu
                        Case 0 To 0.188
                            haorong = objdataview.Item(0).Row("毫容1")

                        Case 0.189 To 0.788
                            haorong = objdataview.Item(0).Row("毫容2")

                        Case 0.789 To 1.208
                            haorong = objdataview.Item(0).Row("毫容3")

                        Case 1.209 To 2.708
                            haorong = objdataview.Item(0).Row("毫容4")

                        Case 2.709 To 4.208
                            haorong = objdataview.Item(0).Row("毫容5")

                        Case 4.209 To 5.708
                            haorong = objdataview.Item(0).Row("毫容6")

                        Case 5.709 To 7.208
                            haorong = objdataview.Item(0).Row("毫容7")

                        Case 7.209 To 7.768
                            haorong = objdataview.Item(0).Row("毫容8")




                        Case Else
                            haorong = 0 '虽然cm不是0，但是范围超出了，也会是0
                    End Select
                Else
                    haorong = 0 '只有一种情况，就是cm是0
                End If

            Case Else

        End Select



    




        Dim haolixishu As Integer = 0

        haolixishu = gaodu * 1000
        haolixishu = Int(haolixishu) Mod 100 '取出毫厘系数




   

        xiuzheng = ((up - down) / 100 * haolixishu + down) * miduxishu
        zongrong = mirong + lirong + haorong + siliang

        tiji = zongrong * wenduxishu + xiuzheng
        guancun = tiji * miduxishu

    


        Dim objcommand As New SqlCommand

      
        objcommand.Connection = objconnection
        objcommand.CommandText = "delete GQPD where 油罐编号='" & guanhao & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()





        objcommand.Connection = objconnection
        objcommand.CommandText = "insert into GQPD (时间分组值,重量,所属罐区,物料编码,油罐编号,油品名称,打尺深度,打尺深度2,打尺深度3,油温,油温2,油温3,气温,备注,盘点时间,盘点人员,监盘人员,标准密度,标准温度,变化系数) values (@时间分组值,@重量,@所属罐区,@物料编码,@油罐编号,@油品名称,@打尺深度,@打尺深度2,@打尺深度3,@油温,@油温2,@油温3,@气温,@备注,@盘点时间,@盘点人员,@监盘人员,@标准密度,@标准温度,@变化系数)"

        objcommand.Parameters.AddWithValue("@所属罐区", guanqu)
        objcommand.Parameters.AddWithValue("@物料编码", wlbm)
        objcommand.Parameters.AddWithValue("@油罐编号", guanhao)

        objcommand.Parameters.AddWithValue("@油品名称", yp)
        objcommand.Parameters.AddWithValue("@打尺深度", gaodu_w)
        objcommand.Parameters.AddWithValue("@油温", youwen_w)

        objcommand.Parameters.AddWithValue("@打尺深度2", gaodu2)
        objcommand.Parameters.AddWithValue("@油温2", youwen2)
        objcommand.Parameters.AddWithValue("@打尺深度3", gaodu3)
        objcommand.Parameters.AddWithValue("@油温3", youwen3)




        objcommand.Parameters.AddWithValue("@气温", qiwen)
        objcommand.Parameters.AddWithValue("@备注", beizhu)
        objcommand.Parameters.AddWithValue("@重量", (guancun / 1000)) '单位是吨

        objcommand.Parameters.AddWithValue("@盘点时间", pdsj)
        objcommand.Parameters.AddWithValue("@盘点人员", pandianren)
        objcommand.Parameters.AddWithValue("@监盘人员", jianpanren)

        objcommand.Parameters.AddWithValue("@标准密度", bzmd)
        objcommand.Parameters.AddWithValue("@标准温度", bzwd)
        objcommand.Parameters.AddWithValue("@变化系数", bhxs)
        objcommand.Parameters.AddWithValue("@时间分组值", sjfzz) '这里和service1不同，这里不是及时的，而是已经保存的旧值
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
        objconnection.Close()


        Return guancun

    End Function

End Class