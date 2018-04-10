Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Public Class XBZ_ZONE
    Inherits System.Windows.Forms.Form
    Dim afterdel As String
    Dim objdataadapter As New SqlDataAdapter
    Dim idid As String
    Dim datatable As DataTable
    Dim BindingSourceSalaryItemSet As BindingSource
    Dim ssgq As String
    Dim objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub TestForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = New SqlConnection("Data Source= 218.92.115.4,1433;Initial Catalog = package;User ID=sa; Password=chen dong")

        objdataadapter.SelectCommand.CommandText = "select * from ZONE "

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "ZONE")

        Dgv.DataSource = objdataset.Tables("ZONE")
        Dgv.Columns(1).Width = 217


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SCB As SqlCommandBuilder = New SqlCommandBuilder(objdataadapter)

        objdataadapter.Update(objdataset.Tables("zone"))


        Dim objcommand As New SqlCommand
        MessageBox.Show("保存完毕")
    End Sub
End Class