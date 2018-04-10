Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

' 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class Railway
    Inherits System.Web.Services.WebService
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter

    <WebMethod()> _
    Public Function calculate_railway(ByVal chigao As Integer, ByVal wendu As Single, ByVal midu As Single, ByVal biaohao1 As String, ByVal biaohao2 As Integer, ByVal code As String) As Single
        If code = "fslfslfao342sfjfljljglfndgl23432414" Then



            Dim str_conn As String
            Dim localobjconnection As OleDb.OleDbConnection
            'Dim odbcobjconnection As Odbc.OdbcConnection

            Dim wenduxishu, miduxishu As Single

            ' Dim a_objdataadapter As New Odbc.OdbcDataAdapter
            Dim a_objdataadapter As New OleDb.OleDbDataAdapter
            '---------------------------------------------
            Dim youwen, gaodu, zongrong, guancun, tiji As Single
            Dim jieguo, capacity, coe As Single

            Try

                gaodu = chigao

                youwen = wendu



                '  str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Maindata.mdb;Persist Security Info=False;"    '将access文件固定在C盘是因为clickonce功能不能正确按照系统路径读取mdb文件，不过可以使用webservice功能实现；

                str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("\Maindata.mdb;Persist Security Info=False;")
                'odbc_conn = "{Driver=Microsoft Access Driver (*.mdb, *.accdb)};DBQ=" & Application.StartupPath & ("\Maindata.mdb;Persist Security Info=False;")

                localobjconnection = New OleDb.OleDbConnection(str_conn)
                ' odbcobjconnection = New Odbc.OdbcConnection(odbc_conn)





                wenduxishu = 1 + (youwen - 20) * 0.000024

                wenduxishu = 1

                miduxishu = Val(midu) - (youwen - 20) * 0.00064




                'a_objdataadapter.SelectCommand = New Odbc.OdbcCommand
                a_objdataadapter.SelectCommand = New OleDb.OleDbCommand

                ' a_objdataadapter.SelectCommand.Connection = odbcobjconnection
                a_objdataadapter.SelectCommand.Connection = localobjconnection
                a_objdataadapter.SelectCommand.CommandText = "select * from railway where 油高= " & gaodu
                'If odbcobjconnection.State = ConnectionState.Closed Then
                '    odbcobjconnection.Open()
                'End If

                If localobjconnection.State = ConnectionState.Closed Then
                    localobjconnection.Open()
                End If

                objdataset = New DataSet
                a_objdataadapter.Fill(objdataset, "m")
                objdataview = New DataView(objdataset.Tables("m"))

                If objdataview.Count >= 1 Then
                    Select Case biaohao1
                        Case "A0"
                            capacity = objdataview.Item(0).Row("A0容积")
                            coe = objdataview.Item(0).Row("A0系数")
                        Case "A1"
                            capacity = objdataview.Item(0).Row("A1容积")
                            coe = objdataview.Item(0).Row("A1系数")
                        Case "A2"
                            capacity = objdataview.Item(0).Row("A2容积")
                            coe = objdataview.Item(0).Row("A2系数")
                        Case "A3"
                            capacity = objdataview.Item(0).Row("A3容积")
                            coe = objdataview.Item(0).Row("A3系数")
                        Case "A4"
                            capacity = objdataview.Item(0).Row("A4容积")
                            coe = objdataview.Item(0).Row("A4系数")
                        Case "A5"
                            capacity = objdataview.Item(0).Row("A5容积")
                            coe = objdataview.Item(0).Row("A5系数")
                        Case "A6"
                            capacity = objdataview.Item(0).Row("A6容积")
                            coe = objdataview.Item(0).Row("A6系数")
                        Case "A7"
                            capacity = objdataview.Item(0).Row("A7容积")
                            coe = objdataview.Item(0).Row("A7系数")
                        Case "A8"
                            capacity = objdataview.Item(0).Row("A8容积")
                            coe = objdataview.Item(0).Row("A8系数")
                        Case "A9"
                            capacity = objdataview.Item(0).Row("A9容积")
                            coe = objdataview.Item(0).Row("A9系数")

                    End Select

                End If



                zongrong = coe * biaohao2 + capacity + 0.5

                tiji = zongrong * wenduxishu

                guancun = tiji * miduxishu

                jieguo = Math.Round(guancun / 1000, 3)

                Return jieguo

            Catch ex As Exception
                Return 0
            End Try


        End If



    End Function

End Class