Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Public Class midu
    Inherits System.Windows.Forms.Form
    Dim afterdel As String
    Dim objdataadapter As New SqlDataAdapter
    Dim idid As String
    Dim datatable As DataTable
    Dim BindingSourceSalaryItemSet As BindingSource
    Dim ssgq As String
    Dim objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub midu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from midu_wuliaobianma_zjg "

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "midu")

        Dgv.DataSource = objdataset.Tables("midu")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SCB As SqlCommandBuilder = New SqlCommandBuilder(objdataadapter)

        objdataadapter.Update(objdataset.Tables("midu"))


        Dim objcommand As New SqlCommand
        MessageBox.Show("提醒完毕")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        midu_import.Show()
    End Sub
End Class