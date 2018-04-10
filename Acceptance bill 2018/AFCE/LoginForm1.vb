Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Imports System.Net
Imports System.Text
Imports System.DirectoryServices


Public Class LoginForm1
    Dim sr As New Integer
    Dim srf As New Integer
    Dim sa, sapassword As String
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



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()





    End Sub



    Private Sub UsernameTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UsernameTextBox.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub




    Private Sub PasswordTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try


            Dim username, userPwd As String

            Dim domain = New DirectoryEntry

            username = Trim(UsernameTextBox.Text)
            userPwd = Trim(PasswordTextBox.Text)



            domain.Path = String.Format("LDAP://wilmar.cn")



            domain.Username = username
            domain.Password = userPwd
            domain.AuthenticationType = AuthenticationTypes.Secure

            domain.RefreshCache()



            'MessageBox.Show("恭喜你,wilmar.cn合法用户!", "通过提示“, MessageBoxButtons.OK, MessageBoxIcon.Information)

            isok = True
            sa = "sa"
            sapassword = "chen dong"

            objconnection = New SqlConnection("Data Source= " & Trim(ipaddress.Text) & "," & Trim(sqlport.Text) & ";Initial Catalog = EnterpriseClusterOA;User ID=" & sa & "; Password=" & sapassword)

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If


            Me.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message， ”错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try
    End Sub

    Private Sub ipaddress_KeyDown(sender As Object, e As KeyEventArgs) Handles ipaddress.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub
End Class
