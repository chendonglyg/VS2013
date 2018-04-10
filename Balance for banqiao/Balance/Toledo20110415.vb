Imports Microsoft.Win32
Imports System.Data.SqlClient
Public Class Toledo20110415
    Dim objdataadapter As New SqlDataAdapter
    Dim objdataview As New DataView
    Dim objdataset As New DataSet
    Dim objconnection2 As New SqlConnection("Data Source= 218.92.115.6,1433;Initial Catalog = toledo_upto20110415;User ID=sa; Password=chen dong")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        objdataadapter = New SqlDataAdapter
        objdataadapter.SelectCommand = New SqlCommand                         '汇总DGV的结果


        objdataadapter.SelectCommand.Connection = objconnection2

        Dim dm11 As New Date
        dm11 = dt11.Value
        Dim dm12 As New Date
        dm12 = dt12.Value
        If c1.Checked = True Then
            objdataadapter.SelectCommand.CommandText = "select  * from trade where 1=1 and grossdatetime between '" & dt11.Value & " ' and  ' " & dt12.Value & "' "
        Else
            objdataadapter.SelectCommand.CommandText = "select  * from trade where 1=1"

        End If


        If ch.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and truckno = '" & Trim(chehao.Text) & "'"

        End If

        If ph.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and ticketno = '" & Trim(piaohao.Text) & "'"
        End If

        If fh.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and sender = '" & Trim(fhfh.Text) & "'"
        End If

        If sh.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and receiver = '" & Trim(shsh.Text) & "'"
        End If

        objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "order by grossdatetime desc"



        If objconnection2.State = ConnectionState.Closed Then
            objconnection2.Open()
        End If



        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "toledo")
        objdataview = New DataView(objdataset.Tables("toledo"))
        dgv.DataSource = Nothing
        dgv.AutoGenerateColumns = True
        dgv.DataSource = objdataview

        shuliang.Text = "共计:" & objdataview.Count & "笔记录"
    End Sub

    Private Sub Toledo20110415_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        c1.Checked = True
    End Sub

    Private Sub c1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1.CheckedChanged
        c1.Checked = True
    End Sub

    Private Sub c1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1.Click
        c1.Checked = True
    End Sub
End Class