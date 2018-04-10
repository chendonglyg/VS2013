Imports System.Windows.Forms
Imports Microsoft.Win32


Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripButton.Click
        ' 创建此子窗体的一个新实例。
        Dim ChildForm As New System.Windows.Forms.Form
        ' 在显示该窗体前使其成为此 MDI 窗体的子窗体。
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "窗口" & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: 在此处添加打开文件的代码。
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: 在此处添加代码，将窗体的当前内容保存到一个文件中。
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' 使用 My.Computer.Clipboard 将选择的文本或图像插入剪贴板
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' 使用 My.Computer.Clipboard 将选择的文本或图像插入剪贴板
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        '使用 My.Computer.Clipboard.GetText() 或 My.Computer.Clipboard.GetData 从剪贴板检索信息。
    End Sub

 

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' 关闭此父窗体的所有子窗体。
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer = 0

    Private Sub 录入界面ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 录入界面ToolStripMenuItem.Click
        Dim f1 As New input()
        f1.MdiParent = Me
        f1.Show()
    End Sub

    Private Sub 查询界面ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 查询界面ToolStripMenuItem.Click
        Dim f1 As New Find()
        f1.MdiParent = Me
        f1.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        person.Show()
    End Sub

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Dim rkCurrentUser As RegistryKey = Registry.CurrentUser


        Dim rkTest As RegistryKey = rkCurrentUser.OpenSubKey("Control Panel\International", True)

        rkTest.SetValue("sShortDate", "yyyy/MM/dd")

        rkTest.Close()
        rkCurrentUser.Close()






        If IO.File.Exists(Application.StartupPath & " \车号.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \车号.txt", IO.FileMode.Create)
            fs.Close()


        End If

        If IO.File.Exists(Application.StartupPath & " \电话.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \电话.txt", IO.FileMode.Create)
            fs.Close()
        End If


        If IO.File.Exists(Application.StartupPath & " \司机.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \司机.txt", IO.FileMode.Create)
            fs.Close()
        End If



        If IO.File.Exists(Application.StartupPath & " \车型.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \车型.txt", IO.FileMode.Create)
            fs.Close()
        End If


        If IO.File.Exists(Application.StartupPath & " \状态.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \状态.txt", IO.FileMode.Create)
            fs.Close()
        End If


        If IO.File.Exists(Application.StartupPath & " \车况.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \车况.txt", IO.FileMode.Create)
            fs.Close()
        End If


        '----------------------------------------------------------------------------------------------











        If IO.File.Exists(Application.StartupPath & " \1.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \1.txt", IO.FileMode.Create)
            fs.Close()


        End If

        If IO.File.Exists(Application.StartupPath & " \2.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \2.txt", IO.FileMode.Create)
            fs.Close()
        End If


        If IO.File.Exists(Application.StartupPath & " \3.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \3.txt", IO.FileMode.Create)
            fs.Close()
        End If



        If IO.File.Exists(Application.StartupPath & " \4.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \4.txt", IO.FileMode.Create)
            fs.Close()
        End If




        If IO.File.Exists(Application.StartupPath & " \5.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \5.txt", IO.FileMode.Create)
            fs.Close()
        End If


        If IO.File.Exists(Application.StartupPath & " \can1.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \can1.txt", IO.FileMode.Create) '油品
            fs.Close()
        End If

        If IO.File.Exists(Application.StartupPath & " \can2.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \can2.txt", IO.FileMode.Create) '船名
            fs.Close()
        End If

        If IO.File.Exists(Application.StartupPath & " \can3.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \can3.txt", IO.FileMode.Create) '电子帐测号
            fs.Close()
        End If

        If IO.File.Exists(Application.StartupPath & " \can4.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \can4.txt", IO.FileMode.Create) '进口合同号
            fs.Close()
        End If

    End Sub

    Private Sub 录入界面ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 录入界面ToolStripMenuItem1.Click
        can_input.Show()

    End Sub

    Private Sub 查询界面ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 查询界面ToolStripMenuItem1.Click
        Can_view.Show()

    End Sub

    Private Sub 喷码ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 喷码ToolStripMenuItem.Click

    End Sub

    Private Sub 总库场图ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub 发车事件管理ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 发车事件管理ToolStripMenuItem.Click
        Car1.Show()
    End Sub

    Private Sub 车辆信息管理ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 车辆信息管理ToolStripMenuItem.Click
        Car2.Show()
    End Sub

    Private Sub 信息汇总打印ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 信息汇总打印ToolStripMenuItem.Click
        car3.Show()
    End Sub
End Class
