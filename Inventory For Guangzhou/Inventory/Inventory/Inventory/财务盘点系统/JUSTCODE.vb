Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Public Class JUSTCODE
    Inherits System.Windows.Forms.Form
    Dim afterdel As String
    Dim objdataadapter As New SqlDataAdapter
    Dim idid As String
    Dim datatable As DataTable
    Dim BindingSourceSalaryItemSet As BindingSource
    Dim ssgq As String
    Dim objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub JUSTCODE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from codeformidu where code = '" & Trim(TextBox1.Text) & "'"



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "code")

        objdataview = New DataView(objdataset.Tables("code"))




        ' MessageBox.Show(objdataview.Count)
        If objdataview.Count >= 1 Then
            midu.Show()
            Me.Close()
        Else
            Me.Close()
        End If

    End Sub
End Class