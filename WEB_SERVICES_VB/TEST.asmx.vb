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
Public Class Test
    Inherits System.Web.Services.WebService
    Dim objdataadapter As New SqlDataAdapter
    Dim objdataview As New DataView
    Dim objdatatable As New DataTable
    Dim objdataset As New DataSet
    Dim sendsomething As New ServiceReference1.CTEnterprisesSoapClient
    <WebMethod()> _
    Public Function LoadTruckList(ByVal code As String) As DataTable

        If code = "lkjflk&^*^UJ324kjhk2h242O*&*(^&*%^&$^%$#$%^&UHGFGHGKJGLKHKJkhflkdshflsfhsd" Then
            Dim temptable As New DataTable
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection

            objdataadapter.SelectCommand.CommandText = "SELECT TOP (100) * FROM [Package].[dbo].[TRUCK_QUEUE_BAK] order by 完成时间 desc"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "truck")
            temptable = objdataset.Tables("truck")

            Return temptable


        End If

        Return Nothing


    End Function
End Class

