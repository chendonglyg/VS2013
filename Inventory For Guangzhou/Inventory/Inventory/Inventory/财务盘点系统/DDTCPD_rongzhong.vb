Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class DDTCPD_rongzhong
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub DDTCPD_rongzhong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from DDTCPD_RONGZHONG"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If

        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "rongzhong")

        objdataview = New DataView(objdataset.Tables("rongzhong"))

        rongzhong.Text = Val(objdataview.Item(0).Item("rongzhong"))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim objcommand As New SqlCommand

        objcommand.Connection = objconnection
        objcommand.CommandText = "update ddtcpd_rongzhong set rongzhong=" & Val(rongzhong.Text)
      
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
        objconnection.Close()
        MessageBox.Show("大豆筒仓容重更新完毕！")

    End Sub
End Class