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

 



    Private Sub 注销ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next

        Dim frmLogon As New LoginForm1

        frmLogon.ShowDialog()


    End Sub

  


  

    Private Sub zichanluru_Click(sender As Object, e As EventArgs) Handles COA2.Click
        COA_2.Show()

    End Sub

   
    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End

    End Sub

    Private Sub fujianguanli_Click(sender As Object, e As EventArgs) Handles COA3.Click
        COA_3.Show()
    End Sub

    Private Sub 内勤COA提交ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COA1.Click
        COA_1.Show()
    End Sub
    Private Sub 用户管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 用户管理ToolStripMenuItem.Click
        End

    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show(Usergroup)
        Select Case Usergroup
            Case "IT"

                COA1.Enabled = True
                COA2.Enabled = True
                COA3.Enabled = True
                COA4.Enabled = True
            Case "储运"
                COA3.Enabled = True
                COA4.Enabled = True
            Case "品管A"
                COA1.Enabled = True
            Case "品管B"
                COA2.Enabled = True

            Case Else


        End Select
    End Sub

    Private Sub COA查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COA4.Click
        COA_4.Show()
    End Sub
End Class
