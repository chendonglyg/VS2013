Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Microsoft.Win32

Public Class MDIParent1
    Dim sr As New Integer
    Dim srf As New Integer

    Dim forreport As New SqlDataAdapter



    Dim objdataadapter As New SqlDataAdapter


    Dim objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click
        ' 创建此子窗体的一个新实例。
        Dim ChildForm As New System.Windows.Forms.Form
        ' 在显示该窗体前使其成为此 MDI 窗体的子窗体。
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "窗口" & m_ChildFormNumber

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



    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click

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

    Private m_ChildFormNumber As Integer

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next


        Dim cc As Control.ControlCollection = Me.Controls

        For Each ctl As Control In cc

            If TypeOf ctl Is ToolStrip Then

                ctl.Enabled = False


            End If

        Next




        '---------------------------------------------------------------------------以下两个属于系统设置模块

        If dataviewuser.Item(0).Item("privilage") = True Then


            For Each ctl As Control In cc

                If TypeOf ctl Is ToolStrip Then

                    ctl.Enabled = True


                End If

            Next

        End If


        If isadmin = True Then



            For Each ctl As Control In cc

                If TypeOf ctl Is ToolStrip Then

                    ctl.Enabled = True


                End If

            Next

        End If







        '-------------------------------------------------------------------------------------

        If dataviewuser.Item(0).Item("module1") = True Then
            Me.zichanluru.Enabled = True

        End If

        If dataviewuser.Item(0).Item("module2") = True Then
            Me.fujianguanli.Enabled = True

        End If




        If dataviewuser.Item(0).Item("module4") = True Then
            Me.zichanweihu.Enabled = True
            Me.bumenweihu.Enabled = True
            Me.gongsiweihu.Enabled = True
            Me.guigeweihu.Enabled = True

        End If

 


        '---------------------------------------------------------------------以上这块是按照设置的权限一个一个开出口子模块







        Dim rkCurrentUser As RegistryKey = Registry.CurrentUser


        Dim rkTest As RegistryKey = rkCurrentUser.OpenSubKey("Control Panel\International", True)

        rkTest.SetValue("sShortDate", "yyyy/MM/dd")

        rkTest.Close()
        rkCurrentUser.Close()




    End Sub



    Private Sub 注销ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next

        Dim frmLogon As New LoginForm1

        frmLogon.ShowDialog()


    End Sub

    Private Sub MDIParent1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged


        Me.Width = 1280
        Me.Height = 800
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub

    Private Sub MDIParent1_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Width = 1280
        Me.Height = 800
        Me.StartPosition = FormStartPosition.CenterScreen


    End Sub

    Private Sub MDIParent1_MaximumSizeChanged(sender As Object, e As EventArgs) Handles Me.MaximumSizeChanged
        Me.Width = 1280
        Me.Height = 800
        Me.StartPosition = FormStartPosition.CenterScreen


    End Sub


    Private Sub 用户管理ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 用户管理ToolStripMenuItem1.Click

    End Sub

    Private Sub zichanluru_Click(sender As Object, e As EventArgs) Handles zichanluru.Click
        Bill1.Show()

    End Sub
End Class
