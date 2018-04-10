Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Module Module1
    '---------------------------service1文件是主要计算文件，里面的删除只是致以删除标志
    '--------------------------2号文件是纠错覆盖文件，里面和1号唯一不同的是插入新记录前直接删除
    '-------------------------3号文件是手机使用的各种调用

    Public objconnection As New SqlConnection("Data Source=10.229.56.14;Initial Catalog =inventory;User ID=sa; Password=gz.1234")

End Module
