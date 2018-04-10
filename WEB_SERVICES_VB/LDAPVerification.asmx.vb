Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.DirectoryServices

' 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class LDAPVerification
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function LoginYesOrNo(ByVal code As String, ByVal UsernameTextBox As String, ByVal PasswordTextBox As String) As Boolean
        Try
            If code = "sfjweoifj;wfjw;le%$#%$#%REGTFREGERGedwqe112423147321047(*^@^*&^" Then

                Dim username, userPwd As String

                Dim domain = New DirectoryEntry

                username = Trim(UsernameTextBox)
                userPwd = Trim(PasswordTextBox)


                domain.Path = String.Format("LDAP://10.229.17.17")


                domain.Username = username
                domain.Password = userPwd
                domain.AuthenticationType = AuthenticationTypes.Secure

                domain.RefreshCache()
                Return True
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

End Class