Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32



Module Module1
    Public isadmin As Boolean = False
    Public computername As String

    Public shezhisa As Boolean
    Public username, forchangepassword As String
    Public storestation As String
    Public stationname As String
    Public dataviewuser As DataView
    Public formno As Integer
    Public jpry_m As String
    Public pdry_m As String
    Public formstr As String
    Public objconnection As New SqlConnection("Data Source= 222.189.4.146,1433;Initial Catalog = inventory;User ID=sa; Password=chen dong")
    Public connforcangku As New SqlConnection("Data Source= 222.189.4.146,1433;Initial Catalog = package;User ID=sa; Password=chen dong")


    Sub main()
        shezhisa = False
        On Error Resume Next
        ' 运行登陆窗体()
        ''Dim frmLogon As New LoginForm1

        LoginForm1.ShowDialog()

        Do While LoginForm1.isok = False



            If LoginForm1.isok = True Then



                Exit Do

            End If

            If shezhisa = True Then
                Exit Do
            End If


            LoginForm1.ShowDialog()

        Loop


        If LoginForm1.isok = True Then
            Application.Run(MDIMain)




        End If


    End Sub
End Module
