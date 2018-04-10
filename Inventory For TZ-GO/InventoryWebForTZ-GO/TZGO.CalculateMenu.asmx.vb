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
Public Class TZGO_CalculateMenu
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


    Dim up, down As Single

    Dim CalculateClass1 As New TZGO_CalculateAndSave
    Dim CalculateClass2 As New TZGO_CalculateAndSave_2



    Dim str_conn As String
    Dim localobjconnection As OleDb.OleDbConnection
    '--------------------------------------
    Dim m, cm, mm As Single
    Dim guancun, wenduxishu, miduxishu, temp, xiuzheng, mirong, lirong, haorong, zongrong, tiji As Single


    <WebMethod()> _
    Public Function Calculate(ByVal YP As String, ByVal WLBM As String, ByVal PANDIANREN As String, ByVal GUANQU As String, ByVal BEIZHU As String, ByVal GUANHAO As String, ByVal GAODU As String, ByVal YOUWEN As String, ByVal QIWEN As String, ByVal BZMD As String, ByVal BZWD As String, ByVal BHXS As String, ByVal WDXS As Single) As Single
        Dim result As Single
        GUANQU = "泰州粮油罐区"
        Select Case GUANHAO
            '---------------------------------------------------------------------------------------------------------------

            Case "TK05-18"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK05-19"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK05-20"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK05-21"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK05-22"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK05-23"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK05-24"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK05-25"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK112"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK113"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK114"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK115"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK116"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK117"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK118"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK119"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK120"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK121"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK122"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK123"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK124"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
            Case "TK125"
                result = CalculateClass2.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)

            Case Else
                result = CalculateClass1.Calculate(YP, WLBM, PANDIANREN, GUANQU, BEIZHU, GUANHAO, GAODU, YOUWEN, QIWEN, BZMD, BZWD, BHXS, WDXS)
        End Select

        Return result
    End Function

End Class