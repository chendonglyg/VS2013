Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO


Module Module1



    Public objdataview As New DataView
    Public isadmin As Boolean = False
    Public computername As String
    Public username, forchangepassword As String
    Public storestation As String
    Public stationname As String
    Public dataviewuser As DataView
    Public formno As Integer
    Public jpry_m As String
    Public pdry_m As String
    Public formstr As String
    Public objconnection As New SqlConnection("Data Source= 222.189.4.146,1433;Initial Catalog = package;User ID=sa; Password=chen dong")

    Sub main()
        Dim frmLogon As New LoginForm1


        frmLogon.ShowDialog()

        If frmLogon.isok = True Then


            Application.Run(Mdi)




        End If


    End Sub

End Module
