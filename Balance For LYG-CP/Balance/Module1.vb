Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Module Module1

    Public objconnection As SqlConnection
    Public objconnectionmove As New SqlConnection("Data Source= 10.229.17.10,1433;Initial Catalog = movestore;User ID=sa; Password=chen dong")
    Public objconnectionmessage As New SqlConnection("Data Source= 10.229.17.6,1433;Initial Catalog = toledo;User ID=sa; Password=chen dong")
    Public dangqianlianjie As String

    Public objconn As SqlConnection
    Public isadmin As Boolean = False
    Public computername As String
    Public username As String
    Public storestation As String
    Public stationname As String
    Public dataviewuser As DataView
    Public formno As Integer
    Public formstr As String

    Sub main()

    
        '------------------------------------------



        ' ÔËÐÐµÇÂ½´°Ìå()
        Dim frmLogon As New LoginForm1

        frmLogon.ShowDialog()

        If frmLogon.isok = True Then


            Application.Run(MDIParent1)




        End If


    End Sub
End Module

