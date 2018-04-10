Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports CrystalDecisions.CrystalReports.Engine
Public Class tarelist
    Dim afterdel As String
    Dim idid As String
    Dim objdataadapter As New SqlDataAdapter
    Dim objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub TareList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objdataadapter = New SqlDataAdapter
        objdataadapter.SelectCommand = New SqlCommand                         '汇总DGV的结果
        objdataadapter.SelectCommand.Connection = objconnection
 






        objdataadapter.SelectCommand.CommandText = "select  * from trucklist "







        objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "order by outtime desc"
        afterdel = objdataadapter.SelectCommand.CommandText
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "trucklist")
        objdataview = New DataView(objdataset.Tables("trucklist"))


        dgv.DataSource = Nothing
        dgv.AutoGenerateColumns = True
        dgv.DataSource = objdataview
    End Sub
End Class