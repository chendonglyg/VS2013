Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO.Ports
Public Class LoginForm1
    Dim sr As New Integer
    Dim srf As New Integer

    Dim forreport As New SqlDataAdapter

    Public isok As Boolean

    Dim objdataadapter As New SqlDataAdapter


    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Dim objcurrencymanager As System.Windows.Forms.CurrencyManager
    ' TODO: 插入代码，以使用提供的用户名和密码执行自定义的身份验证
    ' (请参见 http://go.microsoft.com/fwlink/?LinkId=35339)。 
    ' 随后自定义主体可附加到当前线程的主体，如下所示: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' 其中 CustomPrincipal 是用于执行身份验证的 IPrincipal 实现。 
    ' 随后，My.User 将返回 CustomPrincipal 对象中封装的标识信息
    ' 如用户名、显示名等

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sr As IO.StreamReader
        If IO.File.Exists(Application.StartupPath & " \ipaddress.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \ipaddress.txt", IO.FileMode.Create)
            fs.Close()

        End If

        sr = New System.IO.StreamReader(Application.StartupPath & "\ipaddress.txt", True)
        ipaddress.Items.Clear()
        Do While sr.Peek > 0
            ipaddress.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing





    End Sub

    Private Sub UsernameTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UsernameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

  

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


      
        dangqianlianjie = Trim(ipaddress.Text)
        objconnection = New SqlConnection("Data Source= " & Trim(ipaddress.Text) & "," & Trim(sqlport.Text) & ";Initial Catalog = toledo;User ID=sa; Password=chen dong")
        objconnectionmove = New SqlConnection("Data Source= " & Trim(ipaddress.Text) & "," & Trim(sqlport.Text) & ";Initial Catalog =  MoveStore;User ID=sa; Password=chen dong")




            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from users where username ='" & Trim(UsernameTextBox.Text) & "' and password ='" & Trim(PasswordTextBox.Text) & "'"

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "users")

            dataviewuser = New DataView(objdataset.Tables("users"))




        If dataviewuser.Count >= 1 Then '------------------用户存在

            If dataviewuser.Item(0).Item("module10") = False Then '-----------------------用户是第一次登陆


                FirstLogin.Show()
                FirstLogin.Username.Text = Trim(UsernameTextBox.Text)

            Else '----------------用户可以登陆
                MDIParent1.username.Text = "用户名:" & Trim(dataviewuser.Item(0).Item("username"))
                username = Trim(dataviewuser.Item(0).Item("username"))

                storestation = Trim(dataviewuser.Item(0).Item("station"))  '这是在用户界面设置的站点


                stationname = GetSetting("MyApp", "set", "times")    '这是在注册表里设置的位置


                If Len(stationname) = 0 Then

                    SaveSetting("MyApp", "set", "times", storestation)

                    MDIParent1.Stationname.Text = "用户位置:" & GetSetting("MyApp", "set", "times")

                    stationname = GetSetting("MyApp", "set", "times")
                Else

                    stationname = GetSetting("MyApp", "set", "times")

                End If







                If UsernameTextBox.Text = "admin" Then
                    isadmin = True
                Else
                    isadmin = False
                End If
                isok = True







                On Error Resume Next
                computername = Environment.MachineName

                Dim objcommanddel As New SqlCommand
                objcommanddel.Connection = objconnection
                objcommanddel.CommandText = "delete from loginfo where computername = '" & computername & "'"


                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommanddel.ExecuteNonQuery()




                If ipaddress.Text.Length > 0 Then
                    If ipaddress.FindString(ipaddress.Text) < 0 Then
                        Dim xr As New IO.StreamWriter(Application.StartupPath & "\ipaddress.txt", True)
                        xr.WriteLine(ipaddress.Text)
                        xr.Flush()
                        xr.Close()
                    End If
                End If
                objconnection.Close()
                Me.Close()

            End If



        Else
            isok = False
            MessageBox.Show("错误的用户名或者网络不可达!", "提醒", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub PasswordTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If

   
    End Sub

 
  
 
    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub ipaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ipaddress.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)

        End If
    End Sub


    Private Sub ipaddress_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ipaddress.SelectedIndexChanged

    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged

    End Sub
End Class
