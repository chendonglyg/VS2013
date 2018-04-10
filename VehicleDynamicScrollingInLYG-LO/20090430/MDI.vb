Imports System.Windows.Forms

Public Class Mdi

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

    Private Sub 库场仓区货位初始化ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 库场仓区货位初始化ToolStripMenuItem.Click
        XBZPD_RUKUDAN.Show()
    End Sub

    Private Sub 出库管理ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 出库管理ToolStripMenuItem.Click
        XBZPD_LIHUODAN.Show()
    End Sub

   

    Private Sub 小包装货物品种维护ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        XBZPD_WULIAOKU.Show()
    End Sub



    Private Sub Mdi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub 调拨管理ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 调拨管理ToolStripMenuItem.Click
        XBZPD_DIAOBODAN.Show()
    End Sub

    Private Sub 小包装仓区货位维护ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 小包装仓区货位维护ToolStripMenuItem.Click

        XBZPD_ZONE.Show()

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        XBZPD_WULIAOKU.Show()
    End Sub

    Private Sub 小包装物流公司维护ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 小包装物流公司维护ToolStripMenuItem.Click
        XBZPD_WULIUGONGSI.Show()
    End Sub

    Private Sub 报表汇总打印ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 报表汇总打印ToolStripMenuItem.Click
        ForPrintA.Show()
    End Sub
End Class
