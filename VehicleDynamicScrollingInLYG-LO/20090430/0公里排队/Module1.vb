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
    Public isOneCardPass As Boolean '用于记录放行的车辆是从可进厂里进入的，还是从系统菜单直接进入放行的 1是可进厂状态，0是直接进入

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
