Imports System.Windows.Forms

Imports System.Data.SqlClient
Imports Microsoft.Win32

Public Class MDIMain

    Dim StatusStrip As Object

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' 创建此子窗体的一个新实例。
        Dim ChildForm As New System.Windows.Forms.Form
        ' 在显示该窗体前使其成为此 MDI 窗体的子窗体。
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "窗口 " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
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



    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
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

    Private Sub 盘点报表打印ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        QZ_PrintSomething.Show()
    End Sub

    Private Sub 退出系统ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("是否确定退出系统?(Y/N)", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            End
        End If

    End Sub



    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End

    End Sub

    Private Sub 开始盘点ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KSPD.Click
        QZ_Inventory.Show()
    End Sub

    Private Sub SimulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimulatorToolStripMenuItem.Click
        CalculateSimulator.Show()
    End Sub

    Private Sub 盘点任务ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PDRW.Click
        QZ_Mission.Show()

    End Sub

    Private Sub 数据打印ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SJDY.Click
        QZ_PrintSomething.Show()
    End Sub

 
    Private Sub MDIMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isadmin = True Then
            PDRW.Enabled = True
            KSPD.Enabled = True
            SJDY.Enabled = True
            YHGL.Enabled = True
            TCPD.Enabled = True
        End If

        If Stationname = "粮油罐区" Then
            PDRW.Enabled = True
            KSPD.Enabled = True
            SJDY.Enabled = True
        End If


        If stationname = "筒仓" Then
            TCPD.Enabled = True
            SJDY.Enabled = True
        End If

    End Sub

    Private Sub 用户管理ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles YHGL.Click
        QZ_Users.Show()
    End Sub

    Private Sub 通常盘点ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TCPD.Click
        QZ_Silo.Show()
    End Sub

    Private Sub 退出系统ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 退出系统ToolStripMenuItem1.Click
        End
    End Sub
End Class
