Imports System.Data.SqlClient
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Public Class MoveStore
    Dim objdataadapter As New SqlDataAdapter
    Dim olda, oldb As Integer

    Dim objdataview As New DataView
    Dim objdataviewgo As New DataView
    Dim objdataset As New DataSet
    Private Sub MoveStore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Me.MdiParent = MDIParent1
        Dim sr As IO.StreamReader
        If IO.File.Exists(Application.StartupPath & " \ipaddress.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \ipaddress.txt", IO.FileMode.Create)
            fs.Close()

        End If

        sr = New System.IO.StreamReader(Application.StartupPath & "\ipaddress.txt", True)
        ipaddress.Items.Clear()
        Do While sr.Peek > 0
            ipaddress.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing
        dt11.Value = Now.AddMonths(-1).AddDays(-Now.Day + 1)

        dt12.Value = Now.AddMonths(0).AddDays(-Now.Day)



    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Try
            Dim objconnectionmove As New SqlConnection("Data Source= 218.92.115.4,1433;Initial Catalog = movestore;User ID=sa; Password=chen dong")
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnectionmove
            objdataadapter.SelectCommand.CommandText = "select * from trade  where mark='板桥' and finaldatetime2 between '" & dt11.Value & " ' and  ' " & dt12.Value & "' "

            If Trim(ziduan.Text) = "票号" Then
                objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and ticketno='" & Trim(guanjianzi.Text) & "'"
            End If
            If Trim(ziduan.Text) = "司机" Then
                objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and motormen='" & Trim(guanjianzi.Text) & "'"
            End If
            If Trim(ziduan.Text) = "车号" Then
                objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and truckno='" & Trim(guanjianzi.Text) & "'"
            End If
            If Trim(ziduan.Text) = "货名" Then
                objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and where product='" & Trim(guanjianzi.Text) & "'"
            End If

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If


            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "move")
            objdataview = New DataView(objdataset.Tables("move"))
            dgv.DataSource = objdataview
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim oRpt As New Movereport2
        oRpt.SetDataSource(objdataset.Tables("move"))

        ReportView.Show()
        ReportView.CrystalReportViewer1.ReportSource = oRpt
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Dim stra As TextObject
        Dim straa As TextObject


        Dim oRpt As New yikufenxi
        oRpt.SetDataSource(objdataset.Tables("move"))

        ReportView.Show()
        ReportView.CrystalReportViewer1.ReportSource = oRpt

        stra = oRpt.ReportDefinition.ReportObjects.Item("str100")
        stra.Text = dt11.Value
        straa = oRpt.ReportDefinition.ReportObjects.Item("str200")
        straa.Text = dt12.Value

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dt11_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt11.ValueChanged

    End Sub
End Class