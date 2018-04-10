Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Module Module1

    Public objconnection As SqlConnection
    Public isadmin As Boolean = False
    Public computername As String
    Public username, userPwd, Usergroup As String
    Public storestation As String
    Public stationname As String
    Public dataviewuser As DataView
    Public formno As Integer
    Public formstr As String

    Sub main()
        ' ÔËÐÐµÇÂ½´°Ìå()
        Dim frmLogon As New LoginForm1

        frmLogon.ShowDialog()

        If frmLogon.isok = True Then


            Application.Run(MDIParent1)




        End If


    End Sub

End Module
