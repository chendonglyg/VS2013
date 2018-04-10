Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Public Class useronline
    Dim afterdel As String
    Dim objdataadapter As New SqlDataAdapter
    Dim datatable As DataTable
    Dim BindingSourceSalaryItemSet As BindingSource

    Dim objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub useronline_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconn
        objdataadapter.SelectCommand.CommandText = "select * from loginfo"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "aa")

        dgv.DataSource = objdataset.Tables("aa")
    End Sub
End Class