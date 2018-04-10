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
Public Class GZ
  Inherits System.Web.Services.WebService

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

    Function chendong(ByVal updown As Single) As Single


        temp = updown * 10
        temp = Int(temp)
        m = temp / 10

        objdataadapter.SelectCommand = New OleDb.OleDbCommand
        objdataadapter.SelectCommand.Connection = localobjconnection
        objdataadapter.SelectCommand.CommandText = "select * from xiuzheng where m= " & m
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "xiuzheng")
        objdataview = New DataView(objdataset.Tables("xiuzheng"))

        If objdataview.Count >= 1 Then
            updown = objdataview.Item(0).Row("修正") '有数据
        Else
            updown = 0
        End If


        Return updown

    End Function
    <WebMethod()> _
    Public Function HelloWorld() As String
       Return "Hello World"
    End Function

    <WebMethod()> _
    Public Function Calculate(ByVal gaodu2 As Single, ByVal gaodu3 As Single, ByVal youwen2 As Single, ByVal youwen3 As Single, ByVal yp As String, ByVal wlbm As String, ByVal pandianren As String, ByVal jianpanren As String, ByVal guanqu As String, ByVal beizhu As String, ByVal guanhao_w As String, ByVal gaodu_w As Single, ByVal youwen_w As Single, ByVal qiwen_w As Single, ByVal bzmd_w As Single, ByVal bzwd_w As Integer, ByVal bhxs_w As Single) As Single



        guanhao = guanhao_w
        gaodu = (gaodu_w + gaodu2 + gaodu3) / 3
        youwen = (youwen_w + youwen2 + youwen3) / 3
        qiwen = qiwen_w
        bzmd = bzmd_w
        bzwd = bzwd_w
        bhxs = bhxs_w
        '--------------------------------------------------------------------
        Select Case guanhao

            Case "TK101"

                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ101.mdb;Persist Security Info=False;")

            Case "TK104"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ104.mdb;Persist Security Info=False;")

            Case "TK105"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ105.mdb;Persist Security Info=False;")
            Case "TK106"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ106.mdb;Persist Security Info=False;")
            Case "TK107"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ107.mdb;Persist Security Info=False;")
            Case "TK203"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ203.mdb;Persist Security Info=False;")
            Case "TK205"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ205.mdb;Persist Security Info=False;")
            Case "TK206"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ206.mdb;Persist Security Info=False;")

            Case "TK207"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ207.mdb;Persist Security Info=False;")
            Case "TK209"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ209.mdb;Persist Security Info=False;")

            Case "TK217"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ217.mdb;Persist Security Info=False;")

            Case "TK218"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ218.mdb;Persist Security Info=False;")

            Case "TK219"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ219.mdb;Persist Security Info=False;")
            Case "TK220"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ220.mdb;Persist Security Info=False;")
            Case "TK221"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ221.mdb;Persist Security Info=False;")
            Case "TK222"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ222.mdb;Persist Security Info=False;")
            Case "TK223"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ223.mdb;Persist Security Info=False;")
            Case "TK224"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ224.mdb;Persist Security Info=False;")
            Case "TK225"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ225.mdb;Persist Security Info=False;")
            Case "TK226"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ226.mdb;Persist Security Info=False;")
            Case "TK301"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ301.mdb;Persist Security Info=False;")

            Case "TK302"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ302.mdb;Persist Security Info=False;")
            Case "TK303"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ303.mdb;Persist Security Info=False;")
            Case "TK304"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ304.mdb;Persist Security Info=False;")

            Case "TK305"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ305.mdb;Persist Security Info=False;")
            Case "TK801"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ801.mdb;Persist Security Info=False;")
            Case "TK802"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ802.mdb;Persist Security Info=False;")
            Case "TK1217"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ1217.mdb;Persist Security Info=False;")
            Case "TK1304"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZ1304.mdb;Persist Security Info=False;")
            Case "R8"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZR8.mdb;Persist Security Info=False;")
            Case "R10"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZR10.mdb;Persist Security Info=False;")
            Case "R11"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZR11.mdb;Persist Security Info=False;")
            Case "R12"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZR12.mdb;Persist Security Info=False;")

            Case "R13"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZR13.mdb;Persist Security Info=False;")
            Case "R14"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZR14.mdb;Persist Security Info=False;")
            Case "R15"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZR15.mdb;Persist Security Info=False;")
            Case "R16"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZR16.mdb;Persist Security Info=False;")
            Case "R17"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZR17.mdb;Persist Security Info=False;")
            Case "R18"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZR18.mdb;Persist Security Info=False;")
            Case "R19"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZR19.mdb;Persist Security Info=False;")
            Case "R20"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZR20.mdb;Persist Security Info=False;")
            Case "R21"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZR21.mdb;Persist Security Info=False;")
            Case "R22"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZR22.mdb;Persist Security Info=False;")
            Case "R25"
                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\GZR25.mdb;Persist Security Info=False;")

            Case Else

        End Select

        localobjconnection = New OleDb.OleDbConnection(str_conn)

        '

        If gaodu = 0 Then
            m = 0
            cm = 0
            mm = 0
            guancun = 0


        End If

        wenduxishu = 1 + (youwen - 20) * 0.000036
        miduxishu = bzmd - (youwen - bzwd) * bhxs - 0.0011


        mirong = gaodu


        temp = mirong * 100
        temp = Int(temp)
        m = temp / 100

        objdataadapter.SelectCommand = New OleDb.OleDbCommand
        objdataadapter.SelectCommand.Connection = localobjconnection
        objdataadapter.SelectCommand.CommandText = "select * from zhengshu where m= " & m

        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "m")
        objdataview = New DataView(objdataset.Tables("m"))

        If objdataview.Count >= 1 Then
            mirong = objdataview.Item(0).Row("米容") '有数据
        Else
            mirong = 0
        End If

        temp = gaodu * 1000
        temp = Int(temp) Mod 10
        mm = temp


        objdataadapter.SelectCommand = New OleDb.OleDbCommand
        objdataadapter.SelectCommand.Connection = localobjconnection
        objdataadapter.SelectCommand.CommandText = "select * from xiaoshu where m= " & mm

        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "mm")
        objdataview = New DataView(objdataset.Tables("mm"))

        '---------------------------------------------------------------------------------------


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


        '-------------------------------------------------------------------------------------------------------------
        up = gaodu + 0.1
        down = gaodu
        up = chendong(up)
        down = chendong(down)



        Dim haolixishu As Integer = 0

        haolixishu = gaodu * 1000
        haolixishu = Int(haolixishu) Mod 100 '取出毫厘系数


        xiuzheng = (up - down) * haolixishu / 100
        zongrong = mirong + haorong + xiuzheng
        tiji = zongrong * wenduxishu
        guancun = tiji * miduxishu


     




        Dim objcommand As New SqlCommand


        objcommand.Connection = objconnection
        objcommand.CommandText = "update GQPD set 删除标志=1 where 油罐编号='" & guanhao & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
        '----------------------------------------这里面在保存前只对已存在相同的记录做了删除标记，而services2里面则是完全删除记录




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
        objcommand.Parameters.AddWithValue("@重量", guancun) '单位是吨

        objcommand.Parameters.AddWithValue("@盘点时间", Now)
        objcommand.Parameters.AddWithValue("@盘点人员", pandianren)
        objcommand.Parameters.AddWithValue("@监盘人员", jianpanren)

        objcommand.Parameters.AddWithValue("@标准密度", bzmd)
        objcommand.Parameters.AddWithValue("@标准温度", bzwd)
        objcommand.Parameters.AddWithValue("@变化系数", bhxs)
        objcommand.Parameters.AddWithValue("@时间分组值", Now.Date.ToString("yyyyMMdd"))
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
        objconnection.Close()
        Return guancun

    End Function




    '------------------------------------------------------------
End Class