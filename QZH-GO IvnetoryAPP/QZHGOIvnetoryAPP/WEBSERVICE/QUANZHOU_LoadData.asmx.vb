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
Public Class QUANZHOU_LoadData
    Inherits System.Web.Services.WebService
    Dim objdataadapter As New SqlDataAdapter
    Dim objdataview As New DataView
    Public dataviewuser As New DataView
    Dim objdataset As New DataSet

    <WebMethod()> _
    Public Function Validate(ByVal username As String, ByVal password As String) As Boolean

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from QZ_InventoryUsers where username ='" & Trim(username) & "' and password ='" & Trim(password) & "'"
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
    Public Function GetParameters(ByVal TankNo As String) As DataSet

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "SELECT QZ_InventoryWork.油品名称,QZ_InventoryWork.物料编码,QZ_InventoryWork.标准密度,QZ_InventoryWork.标准温度 FROM QZ_InventoryWork left outer join QZ_InventoryDensity on QZ_InventoryWork.物料编码=QZ_InventoryDensity.物料编码 where rtrim(ltrim(罐号名称))='" & Trim(TankNo) & "'"
        '暂时不用TZ_InventoryDensity表中的密度管理


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "ypmd")

        objdataview = New DataView(objdataset.Tables("ypmd"))
        Return objdataset

    End Function


    <WebMethod()> _
    Public Function SetDelFlag(ByVal gqbh As String) As Boolean

        Dim objcommand As New SqlCommand
        objcommand.Connection = objconnection
        objcommand.CommandText = "Update QZ_InventoryData set 删除标志=1 where 油罐编号 = '" & Trim(gqbh) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
        Return True

    End Function




    <WebMethod()> _
    Public Function GetTankNo() As DataSet
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct(罐号名称) from QZ_InventoryWork "
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "mission")

        objdataview = New DataView(objdataset.Tables("mission"))

        ' MessageBox.Show(objdataview.Count)
        Return objdataset


    End Function


End Class