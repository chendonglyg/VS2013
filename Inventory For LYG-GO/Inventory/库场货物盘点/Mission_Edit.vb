Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32

Public Class Mission_EDIT

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
        MDIMain.GP.Visible = False

    End Sub

    Private Sub Dgv_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Dgv.CellFormatting
        Dim dgv As DataGridView = CType(sender, DataGridView)

        '确认单元格的列
        'On Error Resume Next
        '根据单元格的值，变更背景色
        'If dgv.Rows(e.RowIndex).Cells("更新标志").Value = True Then
        '    e.CellStyle.BackColor = Color.Red
        'End If
        'dgv.Columns(0).ReadOnly = True
        'dgv.Columns(1).ReadOnly = True
        'dgv.Columns(2).ReadOnly = True
        'dgv.Columns(3).ReadOnly = True
        'dgv.Columns(4).ReadOnly = True
        'dgv.Columns(5).ReadOnly = True
        'dgv.Columns(6).ReadOnly = True
        'dgv.Columns(8).ReadOnly = True
    End Sub



    Private Sub Dgv_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv.CellMouseClick
        On Error Resume Next
        idid = Trim(Dgv.Rows(e.RowIndex).Cells(0).Value)
    End Sub


    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Dim SCB As SqlCommandBuilder = New SqlCommandBuilder(objdataadapter)

        objdataadapter.Update(objdataset.Tables("midu"))


        Dim objcommand As New SqlCommand
        MessageBox.Show("提醒完毕")
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        ssgq = "粮油罐区"
        opening()
    End Sub

    Private Sub opening()
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select id,罐号名称,油品名称,物料编码 from midu where 所属罐区='" & ssgq & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "midu")

        Dgv.DataSource = objdataset.Tables("midu")

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ssgq = "油化罐区"
        opening()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        ssgq = "营销罐区"
        opening()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        ssgq = "板桥罐区"
        opening()
    End Sub
End Class