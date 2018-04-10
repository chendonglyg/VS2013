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
Public Class _0KM
    Inherits System.Web.Services.WebService
    Dim objdataadapter As New SqlDataAdapter
    Dim objdataview As New DataView
    Dim objdatatable As New DataTable
    Dim objdataset As New DataSet
    Dim sendsomething As New ServiceReference1.CTEnterprisesSoapClient



    <WebMethod()> _
    Public Function Auth_User(ByVal username As String, ByVal password As String, ByVal code As String) As Integer
        On Error Resume Next
        If code = "WR@RWERF@#R%YGJGFHJFJ%$^%$^%$" Then

      

            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from users where ltrim(rtrim(username)) ='" & Trim(username) & "' and ltrim(rtrim(password)) ='" & Trim(password) & "'"

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "users")

            '    objdataview = New DataView(objdataset.Tables("users"))

            If objdataset.Tables("users").Rows.Count = 1 Then
                Return 1
            Else
                Return 0
            End If
        End If
    End Function
    <WebMethod()> _
    Public Function Load_TruckList(ByVal truck_no As String, ByVal code As String) As DataTable

        If code = "lkjflk&^*^UJGKJGLKHKJkhflkdshflsfhsd" Then
            Dim temptable As New DataTable
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection

            objdataadapter.SelectCommand.CommandText = "select 车号,客户名称,货物名称,提单数量,车号,电话号码,自派车 from TRUCK_QUEUE where (已完成 is null) and 车号='" & Trim(truck_no) & "'"
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
    <WebMethod()> _
    Public Function Change_Truck(ByVal truck_no_old As String, ByVal truck_no_new As String, ByVal tel_no As String, ByVal self As Boolean, ByVal kehumingcheng As String, ByVal pinming As String, ByVal shuliang As Integer, ByVal code As String) As Integer


        If code = "GFSGHJFDHGW%%kr2398745345@@@4982347fkjsdf" Then


            Try

                objdataadapter = New SqlClient.SqlDataAdapter
                objdataadapter.SelectCommand = New SqlClient.SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection
                objdataadapter.SelectCommand.CommandType = CommandType.StoredProcedure

                objdataadapter.SelectCommand.CommandText = "updatetruckno_app"

                objdataadapter.SelectCommand.Parameters.AddWithValue("@zipaiche", self)
                objdataadapter.SelectCommand.Parameters.AddWithValue("@chehao_old", truck_no_old)
                objdataadapter.SelectCommand.Parameters.AddWithValue("@chehao_new", truck_no_new)
                objdataadapter.SelectCommand.Parameters.AddWithValue("@dianhuahaoma", tel_no)

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objdataadapter.SelectCommand.ExecuteNonQuery()


                sendsomething.sendOneMessage(Trim(tel_no), "<<来自于手机端提交的车辆变更信息>>" & Trim(kehumingcheng) & "," & Trim(pinming) & ",提单量:" & Trim(shuliang) & "吨,车号已变更为:" & Trim(truck_no_new), "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                Return 1

            Catch ex As Exception
                Return ex.Message
            End Try
        End If
    End Function

End Class