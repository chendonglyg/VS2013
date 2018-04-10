Imports System.Windows.Forms

Public Class Mdi
    Dim objdataadapter As New SqlClient.SqlDataAdapter

    Dim objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewWindowToolStripMenuItem.Click
        ' 创建此子窗体的一个新实例。
        Dim ChildForm As New System.Windows.Forms.Form
        ' 在显示该窗体前使其成为此 MDI 窗体的子窗体。
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "窗口 " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: 在此处添加打开文件的代码。
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: 在此处添加代码，将窗体的当前内容保存到一个文件中。
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' 使用 My.Computer.Clipboard 将选择的文本或图像插入剪贴板
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' 使用 My.Computer.Clipboard 将选择的文本或图像插入剪贴板
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        '使用 My.Computer.Clipboard.GetText() 或 My.Computer.Clipboard.GetData 从剪贴板检索信息。
    End Sub

   

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' 关闭此父窗体的所有子窗体。
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer


    Private Sub 出库管理ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CIQ_Receipt.Show()
    End Sub

   

 



    Private Sub Mdi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select top 1 * from CIQ_Message order by time desc"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "message")

        objdataview = New DataView(objdataset.Tables("message"))

        If objdataview.Count = 1 Then
            Me.neirong.Text = Trim(objdataview.Item(0).Item("context"))
            Me.fabuzhe.Text = "发布者:" & Trim(objdataview.Item(0).Item("name"))
            Me.fabushijian.Text = "发布时间:" & Trim(objdataview.Item(0).Item("time"))

        End If

        '-------------------------------------------------------------------------------------------------------------

        objdataadapter.SelectCommand.CommandText = "select  * from CIQ_Message order by time desc"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "message")

        objdataview = New DataView(objdataset.Tables("message"))
        dgv.DataSource = objdataview
        dgv.Columns(0).Width = 1
        dgv.Columns(1).Width = 650
        dgv.Columns(3).Width = 150
        objconnection.Close()
    End Sub

    Private Sub 调拨管理ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CIQ_Purchase.Show()
    End Sub

    Private Sub 小包装仓区货位维护ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 小包装仓区货位维护ToolStripMenuItem.Click

        CIQ_Unload.Show()

    End Sub

    Private Sub 产品管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Purchase.Click
        CIQ_Purchase.Show()
    End Sub

    Private Sub 收货入库ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Receipt.Click
        CIQ_Receipt.Show()
    End Sub

    Private Sub 卸船入库ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Unload.Click
        CIQ_Unload.Show()
    End Sub

    Private Sub 生产领用ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Production.Click
        CIQ_Production.Show()
    End Sub

    Private Sub 出库销售ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRADE.Click
        CIQ_Trade.Show()
    End Sub

    Private Sub 报表打印ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintALL.Click
        CIQ_View.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SENDSOMETHING.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select top 1 * from CIQ_Message order by time desc"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "message")

        objdataview = New DataView(objdataset.Tables("message"))




        If objdataview.Count = 1 Then
            Me.neirong.Text = Trim(objdataview.Item(0).Item("context"))
            Me.fabuzhe.Text = "发布者:" & Trim(objdataview.Item(0).Item("name"))
            Me.fabushijian.Text = "发布时间:" & Trim(objdataview.Item(0).Item("time"))

        End If

    End Sub
End Class
