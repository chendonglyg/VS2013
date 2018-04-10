Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO.Ports
Public Class LoginForm1
    Public isok As Boolean
    ' TODO: 插入代码，以使用提供的用户名和密码执行自定义的身份验证
    ' (请参见 http://go.microsoft.com/fwlink/?LinkId=35339)。 
    ' 随后自定义主体可附加到当前线程的主体，如下所示: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' 其中 CustomPrincipal 是用于执行身份验证的 IPrincipal 实现。 
    ' 随后，My.User 将返回 CustomPrincipal 对象中封装的标识信息
    ' 如用户名、显示名等



 

  

    Private Sub OKK_Click(sender As System.Object, e As System.EventArgs) Handles OKK.Click
        Dim objdataAdapter As New SqlDataAdapter
        Dim objdataset As New DataSet
        Dim objdataview As New DataView


        objconnection = New SqlConnection("Data Source= " & Trim(ipaddress.Text) & "," & Trim(sqlport.Text) & ";Initial Catalog = package;User ID= sa; Password=chen dong")
 

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from users where username ='" & Trim(UsernameTextBox.Text) & "' and password ='" & Trim(PasswordTextBox.Text) & "'"


        objconnection.Open()
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "users")

        dataviewuser = New DataView(objdataset.Tables("users"))




        If dataviewuser.Count >= 1 Then
            isok = True
            username = Trim(objdataset.Tables("users").Rows(0)("username"))
        Else

            MessageBox.Show("错误的用户名或者网络不可达!", "提醒", MessageBoxButtons.OK)
        End If

        objconnection.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub UsernameTextBox_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles UsernameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub PasswordTextBox_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub ipaddress_KeyDown(sender As Object, e As KeyEventArgs) Handles ipaddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub sqlport_KeyDown(sender As Object, e As KeyEventArgs) Handles sqlport.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub
End Class
