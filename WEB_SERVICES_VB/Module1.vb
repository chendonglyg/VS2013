﻿Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Module Module1

    Public objconnection As New SqlConnection("Data Source= 10.229.17.10,1433;Initial Catalog = package;User ID=sa; Password=chen dong")

    Public railway_connection As New SqlConnection("Data Source= 10.229.17.10,1433;Initial Catalog = inventory;User ID=sa; Password=chen dong")

    Public Assets_connection As New SqlConnection("Data Source= 10.229.17.10,1433;Initial Catalog = inventory;User ID=sa; Password=chen dong")

End Module
