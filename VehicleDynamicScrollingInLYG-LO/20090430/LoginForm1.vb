Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO.Ports
Imports System.Text.RegularExpressions

Public Class LoginForm1
    Public isok As Boolean
    ' TODO: 插入代码，以使用提供的用户名和密码执行自定义的身份验证
    ' (请参见 http://go.microsoft.com/fwlink/?LinkId=35339)。 
    ' 随后自定义主体可附加到当前线程的主体，如下所示: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' 其中 CustomPrincipal 是用于执行身份验证的 IPrincipal 实现。 
    ' 随后，My.User 将返回 CustomPrincipal 对象中封装的标识信息
    ' 如用户名、显示名等

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OKK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKK.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b, c As Boolean

        b = False
        c = False

        For a = 1 To Len(PasswordTextBox.Text)
            If (Regex.IsMatch(Mid(PasswordTextBox.Text, a, 1), "^[A-Za-z]+$")) Then
                b = True
            ElseIf (Regex.IsMatch(Mid(PasswordTextBox.Text, a, 1), "^\d+$")) Then
                c = True
            End If




        Next

        If (b And c And (Len(PasswordTextBox.Text) >= 6)) Then
            MessageBox.Show(" 数字和字母混合且6位长度")
        Else
            MessageBox.Show("不满足集团要求")
        End If

    End Sub
End Class
