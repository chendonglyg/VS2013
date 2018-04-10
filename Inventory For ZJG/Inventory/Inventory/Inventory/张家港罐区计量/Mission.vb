Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32

Public Class Mission

    Inherits System.Windows.Forms.Form
    Dim afterdel As String
    Dim objdataadapter As New SqlDataAdapter
    Dim idid As String
    Dim datatable As DataTable
    Dim BindingSourceSalaryItemSet As BindingSource
    Dim ssgq As String
    Dim objdataview As New DataView
    Dim objdataset As New DataSet

    Private Sub Parameter_CY_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        MDIMain.GP.Visible = True

    End Sub

    Private Sub Parameter_CY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ssgq = "粮油罐区"
        opening()
    End Sub





    Private Sub Dgv_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv.CellMouseClick
        On Error Resume Next
        idid = Trim(Dgv.Rows(e.RowIndex).Cells(0).Value)


    End Sub





    Private Sub opening()
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection

        objdataadapter.SelectCommand.CommandText = "select id,罐号名称,油品名称,罐高 from midu_zjg  "

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "midu")

        Dgv.DataSource = objdataset.Tables("midu")

    End Sub




    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim SCB As SqlCommandBuilder = New SqlCommandBuilder(objdataadapter)

        objdataadapter.Update(objdataset.Tables("midu"))


        Dim objcommand As New SqlCommand
        MessageBox.Show("提醒完毕")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Mission_import.Show()
    End Sub
End Class