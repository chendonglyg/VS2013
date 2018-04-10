Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

' 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class Assets
    Inherits System.Web.Services.WebService
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim objdataview As New DataView
    Dim objdatatable As New DataTable
    Dim objdataset As New DataSet
    '<WebMethod()> _
    'Public Function Assets_Scan(ByVal Assets_No As String, ByVal code As String) As Boolean


    '    If code = "GFSGHJFDHGW%%kr2398745345@@@4982347fkjsdf" Then


    '        Try

    '            objdataadapter = New SqlClient.SqlDataAdapter
    '            objdataadapter.SelectCommand = New SqlClient.SqlCommand
    '            objdataadapter.SelectCommand.Connection = Assets_connection
    '            objdataadapter.SelectCommand.CommandType = CommandType.StoredProcedure

    '            objdataadapter.SelectCommand.CommandText = "ASSETS_SCAN"

    '            objdataadapter.SelectCommand.Parameters.AddWithValue("@assets_no", Trim(Assets_No))


    '            If objconnection.State = ConnectionState.Closed Then
    '                objconnection.Open()
    '            End If

    '            objdataadapter.SelectCommand.ExecuteNonQuery()



    '            Return True
    '        Catch ex As Exception
    '            Return ex.Message
    '        End Try
    '    End If

    'End Function

End Class