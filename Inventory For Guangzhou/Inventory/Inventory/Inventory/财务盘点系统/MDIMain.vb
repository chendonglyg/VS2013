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

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
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

    Private Sub 大豆筒仓盘点ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 大豆筒仓盘点ToolStripMenuItem.Click
        DDTCPD.Show()
    End Sub

    Private Sub 豆粕筒仓盘点ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 豆粕筒仓盘点ToolStripMenuItem.Click
        DPTCPD.Show()
    End Sub

    Private Sub 罐区盘点ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 罐区盘点ToolStripMenuItem.Click
        GQPD.Show()
    End Sub

    Private Sub 库场盘点ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 库场盘点ToolStripMenuItem.Click
        KCPD.Show()
    End Sub

    

    Private Sub MDIMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '----------------------------------------------------------------------------------------------
        On Error Resume Next




        '---------------------------------------------------------------------------以下两个属于系统设置模块






        If isadmin = True Then
            Me.c1.Enabled = True
            Me.c2.Enabled = True
            Me.c3.Enabled = True
            Me.c4.Enabled = True
            Me.c5.Enabled = True
            Me.c6.Enabled = True
            Me.c7.Enabled = True
            Me.c8.Enabled = True
            Me.c9.Enabled = True
            Me.c10.Enabled = True
            Me.c11.Enabled = True

        End If





        '-------------------------------------------------------------------------------------

        If dataviewuser.Item(0).Item("module1") = True Then
            Me.c1.Enabled = True

        End If

        If dataviewuser.Item(0).Item("module2") = True Then
            Me.c2.Enabled = True

        End If


        If dataviewuser.Item(0).Item("module3") = True Then
            Me.c3.Enabled = True

        End If

        If dataviewuser.Item(0).Item("module4") = True Then
            Me.c4.Enabled = True

        End If

        If dataviewuser.Item(0).Item("module5") = True Then
            Me.c5.Enabled = True

        End If


        If dataviewuser.Item(0).Item("module6") = True Then
            Me.c6.Enabled = True

        End If

        If dataviewuser.Item(0).Item("module7") = True Then
            Me.c7.Enabled = True

        End If

        If dataviewuser.Item(0).Item("module8") = True Then
            Me.c8.Enabled = True
        End If

        If dataviewuser.Item(0).Item("module9") = True Then
            Me.c9.Enabled = True
        End If


        If dataviewuser.Item(0).Item("module10") = True Then
            Me.c10.Enabled = True
        End If


        If dataviewuser.Item(0).Item("module11") = True Then
            Me.c11.Enabled = True
        End If



        Me.c1.Enabled = False
        Me.c2.Enabled = False
        Me.c3.Enabled = False
        Me.c4.Enabled = False
        Me.c10.Enabled = False
        Me.c11.Enabled = False

        Me.c8.Enabled = False
    End Sub

    Private Sub 用户管理ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 用户管理ToolStripMenuItem.Click
        Users.Show()
    End Sub



    Private Sub 盘点报表打印ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 盘点报表打印ToolStripMenuItem.Click
        PrintSomething.Show()
    End Sub

    Private Sub SAP物料编码模板导入ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAP物料编码模板导入ToolStripMenuItem.Click
        WLBM.Show()
    End Sub

    Private Sub 物料编码维护ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 物料编码维护ToolStripMenuItem.Click
        Mission.Show()
    End Sub

    Private Sub 库场跺位导入ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 库场跺位导入ToolStripMenuItem.Click
        ImportKCDW.Show()
    End Sub

    Private Sub 大豆筒仓参数维护ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 大豆筒仓参数维护ToolStripMenuItem.Click
        Para.Show()
    End Sub

    Private Sub 退出系统ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出系统ToolStripMenuItem.Click
        If MessageBox.Show("是否确定退出系统?(Y/N)", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            End
        End If

    End Sub

    Private Sub 参数维护ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1.Click
        Para.Show()
    End Sub

    Private Sub 罐区任务导入ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3.Click
        Mission.Show()
    End Sub

    Private Sub 用户管理设置ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c5.Click
        Users.Show()
    End Sub

    Private Sub 物料编码导入ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c4.Click
        WLBM.Show()

    End Sub

    Private Sub 库场跺位导入ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2.Click
        ImportKCDW.Show()
    End Sub

    Private Sub 罐号油品维护ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c6.Click
        Mission_EDIT.Show()
    End Sub

    Private Sub 油品更改提醒ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c7.Click

        JUSTCODE.Show()

        GP.Visible = False

    End Sub

    Private Sub 开发区仓库品种导入ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c8.Click
        canshu_xiaobaozhuang.Show()
    End Sub

    Private Sub 小包装仓库盘点ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 小包装仓库盘点ToolStripMenuItem.Click
        XBZCK.Show()
    End Sub

    Private Sub 罐区错误数据校正ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c9.Click
        GQPD_L.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Mission_EDIT.Show()
        GP.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        JUSTCODE.Show()

        GP.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GQPD.Show()
        GP.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
    PrintSomething.Show()
    End Sub

 

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Calculate.Show()


    End Sub

    Private Sub 辅料代码维护ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c10.Click
        FLPD_CODE.Show()
    End Sub

    Private Sub 辅料盘点ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 辅料盘点ToolStripMenuItem.Click
        FLPD.Show()
    End Sub

  

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Users.Show()
        Users.c21.Visible = False
        Users.changepassword.Visible = True
        Users.changepassword.Text = forchangepassword
        Users.Height = 345

    End Sub

    Private Sub 大豆筒仓容重维护ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c11.Click
        DDTCPD_rongzhong.Show()
    End Sub

    Private Sub 小包装库位信息维护ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c12.Click
        XBZ_ZONE.Show()
    End Sub

    Private Sub GP_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GP.Enter

    End Sub

    Private Sub 单机版未完成ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 单机版未完成ToolStripMenuItem.Click
        ' OFFLINE.Show()
        Calculate.Show()

    End Sub

    Private Sub 调试ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub 调试ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 调试ToolStripMenuItem.Click
        OFFLINE.Show()
    End Sub
End Class
