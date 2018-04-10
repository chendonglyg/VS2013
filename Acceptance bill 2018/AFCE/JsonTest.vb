Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net
Imports System.IO
Imports System.Text

Public Class JSON
    Dim forreport As New SqlDataAdapter
    Public afterdel As String
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim empData As String = "{'message':'mymessage','data':'mydata','age':18}"

        Dim empData_array As String = "{'employees': [ { 'firstName':'John' , 'lastName':'Doe' },{ 'firstName':'Anna' , 'lastName':'Smith' }, { 'firstName':'Peter' , 'lastName':'Jones' }]}"




        'Dim p As JObject = CType(JsonConvert.DeserializeObject(empData), JObject)
        Dim p_array As JObject = CType(JsonConvert.DeserializeObject(empData_array), JObject)

        ' MessageBox.Show(p.Item("message").ToString)


        '     /*下面是解析JArray的部分*/  
        'JArray jlist = JArray.Parse(jsonObj["result"]["pois"].ToString()); //将pois部分视为一个JObject，JArray解析这个JObject的字符串 

        Dim jlist As JArray = JArray.Parse(p_array("employees").ToString)
        Dim jobj As JObject = JObject.Parse(jlist(0).ToString)

        MessageBox.Show(jlist.Count)
        MessageBox.Show(jobj.Count)

        MessageBox.Show(jobj.Item("firstName").ToString)  '区分大小写，重要！！！！！！！！！！！！！





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim myHttpWebRequest As HttpWebRequest = WebRequest.Create("http://recognition.image.myqcloud.com/ocr/idcard")

        myHttpWebRequest.ContentType = "Application / JSON"

        myHttpWebRequest.ContentLength = 2000

        myHttpWebRequest.Method = "POST"



    End Sub
    Public Shared Function GetData(ByVal url As String, ByVal data As String) As String

        Dim request As HttpWebRequest = WebRequest.Create(url + "?" + data)
        request.Method = "GET"
        Dim sr As StreamReader = New StreamReader(request.GetResponse().GetResponseStream)
        Return sr.ReadToEnd
    End Function

    Public Shared Function PostData(ByVal url As String, ByVal data As String) As String

        ServicePointManager.Expect100Continue = False
        Dim request As HttpWebRequest = WebRequest.Create(url)
        '//Post请求方式  
        request.Method = "POST"

        '内容类型  
        request.ContentType = "application/x-www-form-urlencoded"
        '将URL编码后的字符串转化为字节  
        Dim encoding As New UTF8Encoding()
        Dim bys As Byte() = encoding.GetBytes(data)
        '设置请求的 ContentLength   
        request.ContentLength = bys.Length
        '获得请 求流  
        Dim newStream As Stream = request.GetRequestStream()
        newStream.Write(bys, 0, bys.Length)
        newStream.Close()
        '获得响应流  
        Dim sr As StreamReader = New StreamReader(request.GetResponse().GetResponseStream)
        Return sr.ReadToEnd
    End Function
End Class