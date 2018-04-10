
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports System.Runtime.InteropServices


Public Class CVRSDK

    <DllImport("termb.dll", EntryPoint:="CVR_InitComm", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function CVR_InitComm(Port As Integer) As Integer

    End Function

    ' Public Declare Function CVR_InitComm_GO Lib "termb.dll" Alias "CVR_InitComm" (Port As Int16) As Integer

    'Private Declare Function CVR_InitComm_GO Lib "termb.dll" Alias "CVR_InitComm" (ByVal Port As Integer) As Integer



    <DllImport("termb.dll", EntryPoint:="CVR_Authenticate", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function CVR_Authenticate() As Integer

    End Function




    <DllImport("termb.dll", EntryPoint:="CVR_Read_Content", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function CVR_Read_Content(Active As Integer) As Integer

    End Function


    <DllImport("termb.dll", EntryPoint:="CVR_CloseComm", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function CVR_CloseComm() As Integer

    End Function


    <DllImport("termb.dll", EntryPoint:="GetPeopleName", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetPeopleName(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    End Function


    <DllImport("termb.dll", EntryPoint:="GetPeopleNation", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetPeopleNation(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    End Function


    <DllImport("termb.dll", EntryPoint:="GetPeopleBirthday", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetPeopleBirthday(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    End Function

    <DllImport("termb.dll", EntryPoint:="GetPeopleAddress", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetPeopleAddress(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    End Function


    <DllImport("termb.dll", EntryPoint:="GetPeopleIDCode", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetPeopleIDCode(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    End Function


    <DllImport("termb.dll", EntryPoint:="GetDepartment", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetDepartment(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    End Function


    <DllImport("termb.dll", EntryPoint:="GetStartDate", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetStartDate(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    End Function

    <DllImport("termb.dll", EntryPoint:="GetEndDate", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetEndDate(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    End Function


    <DllImport("termb.dll", EntryPoint:="GetPeopleSex", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetPeopleSex(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    End Function


    <DllImport("termb.dll", EntryPoint:="CVR_GetSAMID", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function CVR_GetSAMID(ByRef strTmp As Byte) As Integer

    End Function


    <DllImport("termb.dll", EntryPoint:="GetManuID", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetManuID(ByRef strTmp As Byte) As Integer

    End Function


    '--------------------------------------------------------------------------
    '<DllImport("c:\windows\system32\termb.dll", EntryPoint:="CVR_InitComm", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function CVR_InitComm(Port As Integer) As Integer

    'End Function

    '' Public Declare Function CVR_InitComm_GO Lib "termb.dll" Alias "CVR_InitComm" (Port As Int16) As Integer

    ''Private Declare Function CVR_InitComm_GO Lib "termb.dll" Alias "CVR_InitComm" (ByVal Port As Integer) As Integer



    '<DllImport("c:\windows\system32\termb.dll", EntryPoint:="CVR_Authenticate", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function CVR_Authenticate() As Integer

    'End Function




    '<DllImport("c:\windows\system32\termb.dll", EntryPoint:="CVR_Read_Content", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function CVR_Read_Content(Active As Integer) As Integer

    'End Function


    '<DllImport("c:\windows\system32\termb.dll", EntryPoint:="CVR_CloseComm", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function CVR_CloseComm() As Integer

    'End Function


    '<DllImport("c:\windows\system32\termb.dll", EntryPoint:="GetPeopleName", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetPeopleName(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    'End Function


    '<DllImport("c:\windows\system32\termb.dll", EntryPoint:="GetPeopleNation", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetPeopleNation(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    'End Function


    '<DllImport("c:\windows\system32\termb.dll", EntryPoint:="GetPeopleBirthday", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetPeopleBirthday(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    'End Function

    '<DllImport("c:\windows\system32\termb.dll", EntryPoint:="GetPeopleAddress", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetPeopleAddress(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    'End Function


    '<DllImport("c:\windows\system32\termb.dll", EntryPoint:="GetPeopleIDCode", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetPeopleIDCode(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    'End Function


    '<DllImport("c:\windows\system32\termb.dll", EntryPoint:="GetDepartment", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetDepartment(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    'End Function


    '<DllImport("c:\windows\system32\termb.dll", EntryPoint:="GetStartDate", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetStartDate(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    'End Function

    '<DllImport("c:\windows\system32\termb.dll", EntryPoint:="GetEndDate", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetEndDate(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    'End Function


    '<DllImport("c:\windows\system32\termb.dll", EntryPoint:="GetPeopleSex", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetPeopleSex(ByRef strTmp As Byte, ByRef strLen As Integer) As Integer

    'End Function


    '<DllImport("c:\windows\system32\termb.dll", EntryPoint:="CVR_GetSAMID", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function CVR_GetSAMID(ByRef strTmp As Byte) As Integer

    'End Function


    '<DllImport("c:\windows\system32\termb.dll", EntryPoint:="GetManuID", CharSet:=CharSet.Auto, SetLastError:=False)> Public Shared Function GetManuID(ByRef strTmp As Byte) As Integer

    'End Function

    Private Sub fun(<Runtime.InteropServices.Out()> ByRef str As Integer, ByRef str2 As Integer)
        '首先：两者都是按地址传递的，使用后都将改变原来参数的数值。其次：ref可以把参数的数值传递进函数，但是out是要把参数清空，就是说你无法把一个数值从out传递进去的，out进去后，参数的数值为空，所以你必须初始化一次。这个就是两个的区别，或者说就像有的网友说的，ref是有进有出，out是只出不进。
    End Sub

End Class


