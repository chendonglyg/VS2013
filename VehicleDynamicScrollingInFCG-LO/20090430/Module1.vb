Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO


Module Module1



    Public objdataview As New DataView
    Public isadmin As Boolean = False
    Public computername, ipaddressvalues, ipipip As String
    Public username, forchangepassword As String
    Public storestation As String
    Public stationname, private_data As String
    Public dataviewuser As DataView
    Public formno As Integer

    Public objconnection, objjinzhong As SqlConnection
    Sub main()
        Dim frmLogon As New LoginForm1

        On Error Resume Next
        frmLogon.ShowDialog()

        If frmLogon.isok = True Then


            Application.Run(Mdi)




        End If


    End Sub

End Module
