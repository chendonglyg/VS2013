Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32

Public Class TEL_EDIT
    Dim forreport As New SqlDataAdapter
    Public afterdel As String
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub TEL_EDIT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim objconnection As New SqlConnection("Data Source= 218.92.115.4,1433;Initial Catalog = tel_name;User ID=sa; Password=chen dong")
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from tel order by 电话号码"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "bm")

        objdataview = New DataView(objdataset.Tables("bm"))

        objconnection.Close()
        Me.TopMost = True


        dgv.DataSource = objdataview
        dgv.Columns(0).ReadOnly = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'On Error Resume Next
        Dim SCB As SqlCommandBuilder = New SqlCommandBuilder(objdataadapter)

        objdataadapter.Update(objdataset.Tables("bm"))




        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "bm")

        dgv.DataSource = objdataset.Tables("bm")
        MessageBox.Show("更新完毕")
    End Sub
End Class