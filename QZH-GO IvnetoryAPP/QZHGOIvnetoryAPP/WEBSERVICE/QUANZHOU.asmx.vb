Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

' 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class QZCAN
    Inherits System.Web.Services.WebService


    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New OleDb.OleDbDataAdapter
    '----------------------------------------------------------------------------------------
    Dim gaodu As Single = 12.345
    Dim youwen As Single = 27
    Dim midu As Single = 0.9226
    Dim guanhao As String = "T058"
    Dim str_conn As String
    Dim localobjconnection As OleDb.OleDbConnection
    '-----------------------------------------------------------------------------------------
    Dim m, cm, mm As Single
    Dim guancun, wenduxishu, quduanrongliang, temp, xiuzheng, mirong, lirong, haorong, zongrong, tiji As Single
    <WebMethod()> _
    Public Function Calculate(ByVal guanqu As String, ByVal wlbm As String, ByVal youpin As String, ByVal beizhu As String, ByVal pandianren As String, ByVal jianpanren As String, ByVal gaodu As Single, ByVal youwen As Single, ByVal midu As Single, ByVal guanhao As String) As Single


        Dim objdataset As New DataSet
        Dim objdataview As New DataView
        Dim objdataadapter As New SqlClient.SqlDataAdapter
        Dim objdataadapter_OLE As New OleDb.OleDbDataAdapter


        str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\mdb\MainData_XiaMen.accdb;Persist Security Info=False;")

        localobjconnection = New OleDb.OleDbConnection(str_conn)

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

        temp = Val(gaodu) * 100
        temp = Int(temp)
        m = temp / 100             '得出12.34
        temp = Val(gaodu) * 1000
        temp = Int(temp) Mod 10
        mm = temp                       '得出5
        objdataadapter_OLE.SelectCommand = New OleDb.OleDbCommand
        objdataadapter_OLE.SelectCommand.Connection = localobjconnection
        Select Case Trim(guanhao)
            Case "R08"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from R08_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "R09"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from R09_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T051"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T051_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T052"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T052_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T058"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T058_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T059"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T059_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T101"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T101_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T102"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T102_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T103"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T103_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T104"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T104_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T105"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T105_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T106"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T106_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T107"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T107_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T201"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T201_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T202"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T202_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T203"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T203_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T204"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T204_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T205"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T205_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T301"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T301_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T302"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T302_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T303"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T303_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024


                '---------------------------------------------后续增加的
            Case "T0501"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T0501_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T0502"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T0502_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T0503"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T0503_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T0505"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T0505_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '保温是0.000036
            Case "T0506"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T0506_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '保温是0.000036
            Case "T0507"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T0507_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '保温是0.000036
            Case "T0508"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T0508_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '保温是0.000036

            Case "T401"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T401_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T402"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T402_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '保温是0.000036
            Case "T403"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T403_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '保温是0.000036
            Case "T1001"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T1001_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T1002"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T1002_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T1003"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T1003_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T1004"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T1004_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T1005"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T1005_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T1006"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T1006_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T013"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T013_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T014"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T014_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T021"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T021_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T022"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T022_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T108"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T108_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '保温是0.000036
            Case "T056"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T056_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '保温是0.000036
            Case "T055"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T055_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '保温是0.000036
            Case "T054"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T054_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '保温是0.000036
            Case "T053"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T053_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '保温是0.000036
            Case "T057"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T057_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '保温是0.000036
            Case "T016"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T016_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '保温是0.000036
            Case "T015"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T015_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '保温是0.000036
            Case "T012"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T012_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '保温是0.000036
            Case "T011"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T011_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '保温是0.000036
         

            Case Else

        End Select



        objdataset = New DataSet
        objdataadapter_OLE.Fill(objdataset, "容量")
        objdataview = New DataView(objdataset.Tables("容量"))

        If objdataview.Count >= 1 Then
            mirong = objdataview.Item(0).Row("容量")
            xiuzheng = objdataview.Item(0).Row("静压力修正")
            quduanrongliang = objdataview.Item(0).Row("区段容量")


        Else

            GoTo err
        End If

        tiji = mirong + xiuzheng + quduanrongliang * mm
        tiji = tiji * wenduxishu

        guancun = Math.Round(tiji * midu, 3)
        ' guancun = Math.Round(tiji * midu / 1000, 3) 直接出吨，无需换算



        '-------------------------------------------
        Dim objcommand As New SqlClient.SqlCommand


        objcommand.Connection = objconnection          '这个webservices中只是对同样编号和时间分组值得数据进行了标记，而webserices2中则直接进行了删除，然后再插入
        objcommand.CommandText = "Update QZ_InventoryData set 删除标志=1 where 油罐编号='" & Trim(guanhao) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()


        '-------------------------




        objcommand.Connection = objconnection
        objcommand.CommandText = "insert into QZ_InventoryData (时间分组值,重量,所属罐区,物料编码,油罐编号,油品名称,打尺深度,油温,盘点时间,盘点人员,监盘人员,标准密度) values (@时间分组值,@重量,@所属罐区,@物料编码,@油罐编号,@油品名称,@打尺深度,@油温,@盘点时间,@盘点人员,@监盘人员,@标准密度)"

        objcommand.Parameters.AddWithValue("@所属罐区", guanqu)
        objcommand.Parameters.AddWithValue("@物料编码", wlbm)
        objcommand.Parameters.AddWithValue("@油罐编号", guanhao)

        objcommand.Parameters.AddWithValue("@油品名称", youpin)
        objcommand.Parameters.AddWithValue("@打尺深度", gaodu)
        objcommand.Parameters.AddWithValue("@油温", youwen)


        objcommand.Parameters.AddWithValue("@重量", guancun) '单位是吨

        objcommand.Parameters.AddWithValue("@盘点时间", Now)
        objcommand.Parameters.AddWithValue("@盘点人员", pandianren)
        objcommand.Parameters.AddWithValue("@监盘人员", jianpanren)

        objcommand.Parameters.AddWithValue("@标准密度", midu)

        objcommand.Parameters.AddWithValue("@时间分组值", Now.Date.ToString("yyyyMMdd"))
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
err:

        objconnection.Close()
        Return guancun
    End Function


End Class