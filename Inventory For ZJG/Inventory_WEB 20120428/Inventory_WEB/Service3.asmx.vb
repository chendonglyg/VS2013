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
Public Class Service3
    Inherits System.Web.Services.WebService

    Dim sr As New Integer
    Dim srf As New Integer

    Dim forreport As New SqlDataAdapter

    Public isok As Boolean

    Dim objdataadapter As New SqlDataAdapter
    Dim objdataview As New DataView

    Public dataviewuser As New DataView
    Dim objdataset As New DataSet

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hello World"
    End Function

    <WebMethod()> _
    Public Function validate(ByVal username As String, ByVal password As String) As Boolean



      


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from users where username ='" & Trim(username) & "' and password ='" & Trim(password) & "'"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If

        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "users")

        dataviewuser = New DataView(objdataset.Tables("users"))




        If dataviewuser.Count >= 1 Then
            Return True
        Else
            Return False

        End If






    End Function
    <WebMethod()> _
    Public Function addpinming(ByVal ssgq As String) As DataSet



        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct(罐号名称) from midu where (len(罐号名称)>0) and (所属罐区='" & ssgq & "')"




        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "mission")

        objdataview = New DataView(objdataset.Tables("mission"))

        ' MessageBox.Show(objdataview.Count)
        Return objdataset


    End Function
    <WebMethod()> _
    Public Function addcanshu(ByVal gqbh As String) As DataSet

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "SELECT midu.物料编码,midu_wuliaobianma.标准密度,midu.油品名称,midu_wuliaobianma.标准温度,midu.罐高 FROM midu left outer join midu_wuliaobianma on midu.油品名称=midu_wuliaobianma.油品名称 where rtrim(ltrim(罐号名称))='" & Trim(gqbh) & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "ypmd")

        objdataview = New DataView(objdataset.Tables("ypmd"))
        Return objdataset

    End Function


    <WebMethod()> _
    Public Function delygbh(ByVal gqbh As String) As Boolean

        Dim objcommand As New SqlCommand


        objcommand.Connection = objconnection
        objcommand.CommandText = "update GQPD set 删除标志=1 where 油罐编号 = '" & Trim(gqbh) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
        Return True


    End Function
    '------------------------------------------------------------------------以上用于罐区盘点，以下用于库场盘点

  <WebMethod()> _
 Public Function addkcload() As DataSet
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料描述 from wlbm where 库场默认显示=1"            '用于库场盘点的物料填充




        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "pz")

        objdataview = New DataView(objdataset.Tables("pz"))
        Return objdataset


    End Function
    <WebMethod()> _
    Public Function addkcwz() As DataSet

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct 库场 from kcdw "              '用于库场盘点的库场地填充



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "kc")

        objdataview = New DataView(objdataset.Tables("kc"))

        Return objdataset

    End Function

    <WebMethod()> _
    Public Function adddw(ByVal kc As String) As DataSet



        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 跺位 from kcdw where ltrim(rtrim(库场)) = '" & Trim(kc) & "'"    '跺位的填充



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "dw")
        Return objdataset
    End Function

    <WebMethod()> _
    Public Function addguige() As DataSet


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from KCPD_1"                   '用于库场盘点的规格填充



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "kc")

        '' objdataview = New DataView(objdataset.Tables("kc"))
        Return objdataset
    End Function
    <WebMethod()> _
    Public Function mohuscan(ByVal inputsel As String) As DataSet


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from wlbm where ltrim(rtrim(物料描述)) like '%" & Trim(inputsel) & "%'"        '模糊查询填充



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "pz")



        Return objdataset



    End Function
    <WebMethod()> _
    Public Function wlxx(ByVal inputsel As String) As DataSet


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料号 from wlbm where ltrim(rtrim(物料描述)) = '" & Trim(inputsel) & "'"        '选中物料描述自动填充物料号


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "wlbm")



        Return objdataset
    End Function


    <WebMethod()> _
    Public Function insertkcpd(ByVal wlbm As String, ByVal wlms As String, ByVal kc As String, ByVal dw As String, ByVal gg As String, ByVal danwei As String, ByVal tsk As String, ByVal js As Single, ByVal pdry As String, ByVal jpry As String, ByVal bz As String, ByVal zl As Single) As Boolean


        Dim objcommand As New SqlCommand



        objcommand.Connection = objconnection
        ''objcommand.CommandText = "delete kcpd where 库场='" & Trim(kc) & "' and 物料编码='" & Trim(wlbm) & "' and 垛位='" & Trim(dw) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"
        objcommand.CommandText = "update kcpd set 删除标志 = 1 where 库场='" & Trim(kc) & "' and 物料编码='" & Trim(wlbm) & "' and 垛位='" & Trim(dw) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()




        objcommand.Connection = objconnection
        objcommand.CommandText = "insert into kcpd (物料编码,物料描述,库场,垛位,规格,单位,特殊库,件数,盘点时间,盘点人员,监盘人员,时间分组值,备注,重量) values (@物料编码,@物料描述,@库场,@垛位,@规格,@单位,@特殊库,@件数,@盘点时间,@盘点人员,@监盘人员,@时间分组值,@备注,@重量)"

        objcommand.Parameters.AddWithValue("@物料编码", Trim(wlbm))
        objcommand.Parameters.AddWithValue("@物料描述", Trim(wlms))
        objcommand.Parameters.AddWithValue("@库场", Trim(kc))

        objcommand.Parameters.AddWithValue("@垛位", Trim(dw))
        objcommand.Parameters.AddWithValue("@规格", Trim(gg))
        objcommand.Parameters.AddWithValue("@单位", Trim(danwei))

        objcommand.Parameters.AddWithValue("@特殊库", Trim(tsk))
        objcommand.Parameters.AddWithValue("@件数", Val(js))
        ''objcommand.Parameters.AddWithValue("@账面数量", Val(zmsl.Text))

        objcommand.Parameters.AddWithValue("@盘点时间", Now)
        objcommand.Parameters.AddWithValue("@盘点人员", pdry)
        objcommand.Parameters.AddWithValue("@监盘人员", jpry)
        objcommand.Parameters.AddWithValue("@重量", Val(zl))

        objcommand.Parameters.AddWithValue("@备注", Trim(bz))
        objcommand.Parameters.AddWithValue("@时间分组值", Now.Date.ToString("yyyyMMdd"))

        ''这里是提交库场盘点
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
        objconnection.Close()

        Return True
    End Function


    <WebMethod()> _
    Public Function analyze(ByVal gg As String) As DataSet           '分解规格为量和单位
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 量,单位 from KCPD_1 where 规格='" & gg & "'"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "kc")
        Return objdataset


    End Function



    '-----------------------------------------------------------------------------------------------------------------------------------以上用于库场盘点，以下用于辅料盘点
    <WebMethod()> _
    Public Function addfl_wlms() As DataSet


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct 物料描述 from FLPD_CODE" '用于填充辅料的物料信息

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "pz")

        Return objdataset

    End Function


    <WebMethod()> _
    Public Function addfl_kcd() As DataSet


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct 库存地 from FLPD_CODE " '用于辅料盘点的填充库场地信息



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "kc")

        Return objdataset

    End Function


    <WebMethod()> _
    Public Function addfl_wlh(ByVal wlms As String) As DataSet

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料号 from flpd_code where ltrim(rtrim(物料描述)) = '" & Trim(wlms) & "'"      '用于填充辅料盘点物料号取决于物料描述


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "wlbm")

        Return objdataset

    End Function



    <WebMethod()> _
    Public Function insertflpd(ByVal wlbm As String, ByVal pz As String, ByVal kc As String, ByVal gg As String, ByVal gc As String, ByVal bz As String, ByVal username As String) As Boolean

        Dim objcommand As New SqlCommand           '提交辅料盘点数据


        'objcommand.Connection = objconnection
        'objcommand.CommandText = "delete flpd where 库存地='" & Trim(kc) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "' and 物料编码='" & Trim(wlbm) & "'"


        'If objconnection.State = ConnectionState.Closed Then
        '    objconnection.Open()
        'End If
        'objcommand.ExecuteNonQuery()


        objcommand.Connection = objconnection
        objcommand.CommandText = "insert into FLPD (物料编码,物料描述,库存地,工厂,单位,实盘数量及备注,盘点时间,盘点人员,监盘人员,时间分组值) values (@物料编码,@物料描述,@库存地,@工厂,@单位,@实盘数量及备注,@盘点时间,@盘点人员,@监盘人员,@时间分组值)"

        objcommand.Parameters.AddWithValue("@物料编码", Trim(wlbm))
        objcommand.Parameters.AddWithValue("@物料描述", Trim(pz))
        objcommand.Parameters.AddWithValue("@库存地", Trim(kc))

        objcommand.Parameters.AddWithValue("@单位", Trim(gg))

        objcommand.Parameters.AddWithValue("@工厂", Trim(gc))


        objcommand.Parameters.AddWithValue("@实盘数量及备注", Trim(bz))


        objcommand.Parameters.AddWithValue("@盘点时间", Now)
        objcommand.Parameters.AddWithValue("@盘点人员", username)
        objcommand.Parameters.AddWithValue("@监盘人员", username)


        objcommand.Parameters.AddWithValue("@时间分组值", Now.Date.ToString("yyyyMMdd"))
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
        objconnection.Close()




        Return True


    End Function




    '--------------------------------------------------以上用于辅料，以下用于大豆筒仓

    <WebMethod()> _
    Public Function ddwl() As DataSet             '寻找大豆物料
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from wlbm where right(ltrim(rtrim(物料描述)),2)='大豆'"



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "mission")

        Return objdataset
    End Function


    <WebMethod()> _
    Public Function ddwlh(ByVal wlms As String) As DataSet          '寻找大豆物料号
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料号 from wlbm where ltrim(rtrim(物料描述)) = '" & Trim(wlms) & "'"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "dd")
        Return objdataset
    End Function



    <WebMethod()> _
    Public Function insertddkcpd(ByVal wlbm As String, ByVal wlms As String, ByVal ch As String, ByVal h1 As Single, ByVal h2 As Single, ByVal h3 As Single, ByVal h4 As Single, ByVal h5 As Single, ByVal h6 As Single, ByVal pdry As String, ByVal jpry As String, ByVal bz As String) As Boolean
        Dim objcommand As New SqlCommand
        Dim slsljs As Single
        Dim rongzhong As Integer




        objcommand.Connection = objconnection
        objcommand.CommandText = "update ddtcpd set 删除标志 = 1 where 仓号='" & Trim(ch) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()



        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from DDTCPD_rongzhong"
          If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "rz")

        objdataview = New DataView(objdataset.Tables("rz"))


        rongzhong = Val(objdataview.Item(0).Item("rongzhong"))



  


        ''slsljs = ((Val(h1) - (Val(h3) + Val(h5)) / 2) - (Val(h2) - (Val(h4) + Val(h6)) / 2)) * rongzhong + (Val(h2) - (Val(h4) + Val(h6)) / 2 - 2.2) * rongzhong + (2.2 * rongzhong / 3)
        slsljs = ((Val(h1) - (Val(h3) + Val(h5)) / 2) - (Val(h2) - (Val(h4) + Val(h6)) / 2)) * rongzhong / 3 + (Val(h2) - (Val(h4) + Val(h6)) / 2 - 2.2) * rongzhong + (2.2 * rongzhong / 3)


        objcommand = New SqlCommand
        objcommand.Connection = objconnection
        objcommand.CommandText = "insert into DDTCPD (物料编码,物料描述,仓号,h1,h2,h3,h4,h5,h6,盘点时间,盘点人员,监盘人员,散粮数量,备注,时间分组值) values (@物料编码,@物料描述,@仓号,@h1,@h2,@h3,@h4,@h5,@h6,@盘点时间,@盘点人员,@监盘人员,@散粮数量,@备注,@时间分组值)"

        objcommand.Parameters.AddWithValue("@物料编码", Trim(wlbm))
        objcommand.Parameters.AddWithValue("@物料描述", Trim(wlms))
        objcommand.Parameters.AddWithValue("@仓号", Trim(ch))

        objcommand.Parameters.AddWithValue("@h1", Val(h1))
        objcommand.Parameters.AddWithValue("@h2", Val(h2))
        objcommand.Parameters.AddWithValue("@h3", Val(h3))

        objcommand.Parameters.AddWithValue("@h4", Val(h4))
        objcommand.Parameters.AddWithValue("@h5", Val(h5))
        objcommand.Parameters.AddWithValue("@h6", Val(h6))

        objcommand.Parameters.AddWithValue("@盘点时间", Now)
        objcommand.Parameters.AddWithValue("@盘点人员", Trim(pdry))
        objcommand.Parameters.AddWithValue("@监盘人员", Trim(jpry))




        objcommand.Parameters.AddWithValue("@散粮数量", slsljs)





        objcommand.Parameters.AddWithValue("@备注", Trim(bz))
        objcommand.Parameters.AddWithValue("@时间分组值", Now.Date.ToString("yyyyMMdd"))
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
        objconnection.Close()


        Return True

    End Function


    <WebMethod()> _
    Public Function adddd_cdcg(ByVal ch As String) As DataSet


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 仓顶高,仓边高 from DDTCPD_1 where ltrim(rtrim(仓号)) = '" & Trim(ch) & "'"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "ch")
        Return objdataset

    End Function



    '-------------------------------------------------------------------------------------以上是大豆筒仓，以下是小包装仓库
    '<WebMethod()> _
    'Public Function addxbz_pp() As DataSet
    '    objdataadapter.SelectCommand = New SqlCommand
    '    objdataadapter.SelectCommand.Connection = objconnection
    '    objdataadapter.SelectCommand.CommandText = "select distinct(品牌) from canshu_xiaobaozhuang"


    '    If objconnection.State = ConnectionState.Closed Then
    '        objconnection.Open()
    '    End If
    '    objdataset = New DataSet
    '    objdataadapter.Fill(objdataset, "xiao")

    '    Return objdataset
    'End Function


    '<WebMethod()> _
    'Public Function addxbz_yzmc(ByVal pinpai As String) As DataSet
    '    objdataadapter.SelectCommand = New SqlCommand
    '    objdataadapter.SelectCommand.Connection = objconnection
    '    objdataadapter.SelectCommand.CommandText = "select distinct(油脂名称) from canshu_xiaobaozhuang where 品牌='" & Trim(pinpai) & "'"




    '    If objconnection.State = ConnectionState.Closed Then
    '        objconnection.Open()
    '    End If
    '    objdataset = New DataSet
    '    objdataadapter.Fill(objdataset, "xiao")

    '    Return objdataset
    'End Function



    '<WebMethod()> _
    'Public Function addxbz_guige(ByVal youzhi As String) As DataSet
    '    objdataadapter.SelectCommand = New SqlCommand
    '    objdataadapter.SelectCommand.Connection = objconnection
    '    objdataadapter.SelectCommand.CommandText = "select distinct(规格) from canshu_xiaobaozhuang where 油脂名称='" & Trim(youzhi) & "'"




    '    If objconnection.State = ConnectionState.Closed Then
    '        objconnection.Open()
    '    End If
    '    objdataset = New DataSet
    '    objdataadapter.Fill(objdataset, "xiao")

    '    Return objdataset
    'End Function



    <WebMethod()> _
    Public Function insertxbz(ByVal pinming As String, ByVal dw As String, ByVal kcd As String, ByVal cangqu As String, ByVal huowei As String, ByVal pdry As String, ByVal jpry As String, ByVal spsl As Single, ByVal bz As String, ByVal ph As String) As Boolean

        Dim objcommand As New SqlCommand


        'objcommand.Connection = objconnection
        'objcommand.CommandText = "delete XBZCK where 物料描述='" & Trim(pinpai) & Trim(youpin) & Trim(guige) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

        'If objconnection.State = ConnectionState.Closed Then
        '    objconnection.Open()
        'End If
        'objcommand.ExecuteNonQuery()


        objcommand.Connection = objconnection
        objcommand.CommandText = "insert into XBZCK (仓区,货位,物料描述,单位,库存地,库存地描述,盘点时间,盘点人员,监盘人员,时间分组值,实盘数量,备注,批号) values (@仓区,@货位,@物料描述,@单位,@库存地,@库存地描述,@盘点时间,@盘点人员,@监盘人员,@时间分组值,@实盘数量,@备注,@批号)"

        objcommand.Parameters.AddWithValue("@物料描述", Trim(pinming))
        objcommand.Parameters.AddWithValue("@批号", Trim(ph))
        objcommand.Parameters.AddWithValue("@单位", Trim(dw))

        objcommand.Parameters.AddWithValue("@库存地", Trim(kcd))

        objcommand.Parameters.AddWithValue("@仓区", Trim(cangqu))
        objcommand.Parameters.AddWithValue("@货位", Trim(huowei))

        objcommand.Parameters.AddWithValue("@库存地描述", Trim(kcd) & Trim(cangqu) & Trim(huowei))

        objcommand.Parameters.AddWithValue("@备注", Trim(bz))
        objcommand.Parameters.AddWithValue("@盘点时间", Now)
        objcommand.Parameters.AddWithValue("@盘点人员", pdry)
        objcommand.Parameters.AddWithValue("@监盘人员", jpry)

        objcommand.Parameters.AddWithValue("@实盘数量", Val(spsl))


        objcommand.Parameters.AddWithValue("@时间分组值", Now.Date.ToString("yyyyMMdd"))

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
        objconnection.Close()


        Return True
    End Function




    <WebMethod()> _
    Public Function findwlbm(ByVal wlms As String) As DataSet


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料编码,物料描述 from canshu_xiaobaozhuang where ltrim(rtrim(物料描述)) = '" & Trim(wlms) & "'"




        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "bianma")

        Return objdataset

    End Function



    '<WebMethod()> _
    'Public Function findthree(ByVal wlms As String) As DataSet



    '    objdataadapter.SelectCommand = New SqlCommand
    '    objdataadapter.SelectCommand.Connection = objconnection
    '    objdataadapter.SelectCommand.CommandText = "select * from canshu_xiaobaozhuang where 物料描述= '" & Trim(wlms) & "'"




    '    If objconnection.State = ConnectionState.Closed Then
    '        objconnection.Open()
    '    End If
    '    objdataset = New DataSet
    '    objdataadapter.Fill(objdataset, "san")

    '    Return objdataset




    'End Function



    '------------------------------------------------------------------------------以上是小包装盘点，以下是豆粕筒仓盘点

    <WebMethod()> _
    Public Function adddp_wlms() As DataSet


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料描述 from wlbm where 豆粕默认显示=1"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "pz")

        Return objdataset
    End Function

    <WebMethod()> _
    Public Function adddp_wlbm(ByVal wlms As String) As DataSet



        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料号,物料描述 from wlbm where ltrim(rtrim(物料描述)) = '" & Trim(wlms) & "'"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "wlbm")
        Return objdataset
    End Function



    <WebMethod()> _
    Public Function insertdp(ByVal wlbm As String, ByVal wlms As String, ByVal gg As String, ByVal ch As String, ByVal dc1 As Single, ByVal dc2 As Single, ByVal dc3 As Single, ByVal dc4 As Single, ByVal dc5 As Single, ByVal dc6 As Single, ByVal bz As String, ByVal pdry As String, ByVal jpry As String) As Boolean



        Dim panduan, cangcun, s1, s2 As Single



        If ch = "1#" Then
            s1 = 171.47
        End If
        If ch = "2#" Then
            s1 = 171.19
        End If
        If ch = "3#" Then
            s1 = 171.79
        End If
        If ch = "4#" Then
            s1 = 171.48
        End If





        s2 = (Val(dc1) + Val(dc2) + Val(dc3) + Val(dc4) + Val(dc5) + Val(dc6))

        panduan = (s1 - s2) / 6


        If panduan < 10 Then
            cangcun = (s1 - s2) / 6 * 207
        ElseIf ((panduan >= 10) And (panduan < 15)) Then
            cangcun = (s1 - s2) / 6 * 227
        ElseIf (panduan >= 15) Then
            cangcun = (s1 - s2) / 6 * 247
        End If

        Dim objcommand As New SqlCommand


        objcommand.Connection = objconnection
        objcommand.CommandText = "update DPTCPD set 删除标志=1 where 仓号='" & Trim(ch) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()


        objcommand.Connection = objconnection
        objcommand.CommandText = "insert into DPTCPD (物料编码,物料描述,规格,仓号,打尺a,打尺b,打尺c,打尺d,打尺e,打尺f,仓存,备注,盘点时间,盘点人员,监盘人员,时间分组值) values (@物料编码,@物料描述,@规格,@仓号,@打尺a,@打尺b,@打尺c,@打尺d,@打尺e,@打尺f,@仓存,@备注,@盘点时间,@盘点人员,@监盘人员,@时间分组值)"

        objcommand.Parameters.AddWithValue("@物料编码", Trim(wlbm))
        objcommand.Parameters.AddWithValue("@物料描述", Trim(wlms))
        objcommand.Parameters.AddWithValue("@规格", Trim(gg))

        objcommand.Parameters.AddWithValue("@仓号", Trim(ch))
        objcommand.Parameters.AddWithValue("@打尺a", Val(dc1))
        objcommand.Parameters.AddWithValue("@打尺b", Val(dc2))

        objcommand.Parameters.AddWithValue("@打尺c", Trim(dc3))
        objcommand.Parameters.AddWithValue("@打尺d", Val(dc4))
        objcommand.Parameters.AddWithValue("@打尺e", Val(dc5))
        objcommand.Parameters.AddWithValue("@打尺f", Val(dc6))

        objcommand.Parameters.AddWithValue("@仓存", cangcun)



        objcommand.Parameters.AddWithValue("@盘点时间", Now)
        objcommand.Parameters.AddWithValue("@盘点人员", pdry)
        objcommand.Parameters.AddWithValue("@监盘人员", jpry)


        objcommand.Parameters.AddWithValue("@备注", Trim(bz))
        objcommand.Parameters.AddWithValue("@时间分组值", Now.Date.ToString("yyyyMMdd"))
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
        objconnection.Close()
        Return True
    End Function

    '-------------------------以下是小包装增加的几个函数功能（读仓区，读货位，模糊查询货物以及判断是否有同货位重复货物，覆盖同货位同货物
    <WebMethod()> _
    Public Function xbz_cangqu() As DataTable
        Dim connforcangku As New SqlConnection("Data Source= 10.229.17.10;Initial Catalog = package;User ID=sa; Password=chen dong")  '----------------小包装的仓区和货位以及模糊查询
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = connforcangku
        objdataadapter.SelectCommand.CommandText = "select distinct(仓区) from zone "
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "cangqu")

        Return objdataset.Tables("cangqu")
    End Function


    <WebMethod()> _
    Public Function xbz_kuwei(ByVal cangqu As String) As DataSet
        Dim connforcangku As New SqlConnection("Data Source= 10.229.17.10;Initial Catalog = package;User ID=sa; Password=chen dong")
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = connforcangku
        objdataadapter.SelectCommand.CommandText = "select distinct(货位) from zone where 仓区='" & Trim(cangqu) & "'"




        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "huowei")

        Return objdataset

    End Function



    <WebMethod()> _
    Public Function xbz_huoming(ByVal mohu As String) As DataSet


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料描述 from canshu_xiaobaozhuang where 物料描述 like '%" & Trim(mohu) & "%'"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "zonghe")

        Return objdataset
    End Function



    <WebMethod()> _
    Public Function xbz_panduan(ByVal pinming As String, ByVal cangqu As String, ByVal huowei As String) As Boolean

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from XBZCK where 物料描述='" & Trim(pinming) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "' and 仓区='" & cangqu & "' and 货位 ='" & huowei & "'"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If

        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "panduan")

        objdataview = New DataView(objdataset.Tables("panduan"))

        If objdataview.Count >= 1 Then
            Return True
        Else
            Return False


        End If



    End Function



    <WebMethod()> _
    Public Function updatexbz(ByVal pinming As String, ByVal dw As String, ByVal kcd As String, ByVal cangqu As String, ByVal huowei As String, ByVal pdry As String, ByVal jpry As String, ByVal spsl As Single, ByVal bz As String, ByVal ph As String) As Boolean

        Dim objcommand As New SqlCommand


        objcommand.Connection = objconnection
        objcommand.CommandText = "delete XBZCK where 物料描述='" & Trim(pinming) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "' and 仓区='" & Trim(cangqu) & "' and 货位 ='" & Trim(huowei) & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()


        objcommand.Connection = objconnection
        objcommand.CommandText = "insert into XBZCK (仓区,货位,物料描述,单位,库存地,库存地描述,盘点时间,盘点人员,监盘人员,时间分组值,实盘数量,备注,批号) values (@仓区,@货位,@物料描述,@单位,@库存地,@库存地描述,@盘点时间,@盘点人员,@监盘人员,@时间分组值,@实盘数量,@备注,@批号)"

        objcommand.Parameters.AddWithValue("@物料描述", Trim(pinming))
        objcommand.Parameters.AddWithValue("@批号", Trim(ph))
        objcommand.Parameters.AddWithValue("@单位", Trim(dw))

        objcommand.Parameters.AddWithValue("@库存地", Trim(kcd))

        objcommand.Parameters.AddWithValue("@仓区", Trim(cangqu))
        objcommand.Parameters.AddWithValue("@货位", Trim(huowei))

        objcommand.Parameters.AddWithValue("@库存地描述", Trim(kcd) & Trim(cangqu) & Trim(huowei))

        objcommand.Parameters.AddWithValue("@备注", Trim(bz))
        objcommand.Parameters.AddWithValue("@盘点时间", Now)
        objcommand.Parameters.AddWithValue("@盘点人员", pdry)
        objcommand.Parameters.AddWithValue("@监盘人员", jpry)

        objcommand.Parameters.AddWithValue("@实盘数量", Val(spsl))


        objcommand.Parameters.AddWithValue("@时间分组值", Now.Date.ToString("yyyyMMdd"))

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
        objconnection.Close()


        Return True
    End Function
End Class