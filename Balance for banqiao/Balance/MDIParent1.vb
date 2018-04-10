Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Microsoft.Win32

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' 创建此子窗体的一个新实例。
        Dim ChildForm As New System.Windows.Forms.Form
        ' 在显示该窗体前使其成为此 MDI 窗体的子窗体。
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "窗口" & m_ChildFormNumber

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

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
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



   
    Private Sub 通用程式ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guobangjiemian.Click
        MainA.Show()

    End Sub

    Private Sub 明细报表ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kuchangqueren.Click
        StoreHouse.Show()
    End Sub

    Private Sub MDIParent1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        On Error Resume Next
        Dim objcommanddel As New SqlCommand
        objcommanddel.Connection = objconn
        objcommanddel.CommandText = "delete from loginfo where computername = '" & computername & "'"


        If objconn.State = ConnectionState.Closed Then
            objconn.Open()
        End If

        objcommanddel.ExecuteNonQuery()
    End Sub



    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        SaveSetting("MyApp", "set", "times", Trim("板桥"))

        'On Error Resume Next
        Stationname.Text = "用户位置:" & GetSetting("MyApp", "set", "times")
        computername = Environment.MachineName



        Dim objcommandlog As New SqlCommand

        objcommandlog.Connection = objconn
        objcommandlog.CommandText = "insert into loginfo (logintime,operator,station,computername) values (@logintime,@operator,@station,@computername)"
        objcommandlog.Parameters.AddWithValue("@logintime", Now)
        objcommandlog.Parameters.AddWithValue("@operator", Trim(username.Text))
        objcommandlog.Parameters.AddWithValue("@station", Trim(Stationname.Text))
        objcommandlog.Parameters.AddWithValue("@computername", computername)

        If objconn.State = ConnectionState.Closed Then
            objconn.Open()
        End If
        objcommandlog.ExecuteNonQuery()
        objconn.Close()











        Dim objdataadapter As New SqlDataAdapter
        Dim objdataview As New DataView
        Dim objdataset As New DataSet


    
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select top 1 * from message order by time desc"


        If objconn.State = ConnectionState.Closed Then
            objconn.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "message")

        objdataview = New DataView(objdataset.Tables("message"))




        If objdataview.Count = 1 Then
            Me.neirong.Text = Trim(objdataview.Item(0).Item("context"))
            Me.fabuzhe.Text = "发布者:" & Trim(objdataview.Item(0).Item("name"))
            Me.fabushijian.Text = "发布时间:" & Trim(objdataview.Item(0).Item("time"))

        End If

        ''2010-10-10过期
        'Dim hm As New Date
        'hm = Now
        'hm.ToString("yyyy/MM/dd")

        'If hm.Date > "2010/10/10" Then
        '    End
        'End If
        ''---------------------------------------------------------------------------------------------------

        ''時間限制
        'Dim RemainDay As Long
        'RemainDay = GetSetting("frmLogin", "set", "day", 0)
        'If RemainDay = 30 Then
        '    MsgBox("30天試用期已過，請購買全功能版……")
        '    End
        'Else
        '    MsgBox("你現在試用的是試用版本,現在還剩下:" & 30 - RemainDay & "天，好好珍惜！")
        '    If Date.Now.Day - RemainDay > 0 Then
        '        RemainDay = RemainDay + 1
        '        SaveSetting("frmLogin", "set", "day", RemainDay)

        '    End If
        'End If


        ''次數限制
        Dim RemainDay1 As Long
        'RemainDay1 = GetSetting("MyApp", "set", "times", 0)
        'If RemainDay1 = 30 Then
        '    MsgBox("?用次?已?，?……")
        '    End
        'End If
        'MsgBox("現在剩下:" & 30 - RemainDay1 & "用次?，好好珍惜！")
        'RemainDay1 = RemainDay1 + 1
        ' SaveSetting("MyApp", "set", "times", RemainDay1)

        ' Me.import.Enabled = False




        '----------------------------------------------------------------------------------------------
        On Error Resume Next


        Me.guobangjiemian.Enabled = False
        Me.kuchangqueren.Enabled = False
        Me.yikuchaxun.Enabled = False
        Me.huizongbaobiao.Enabled = False
        Me.qitashezhi.Enabled = False  '出口全部模块默认全部为disable
        Me.yonghushezhi.Enabled = False
        Me.buda.Enabled = False
        Me.shujuchaxun.Enabled = False




        '---------------------------------------------------------------------------以下两个属于系统设置模块

        If dataviewuser.Item(0).Item("privilage") = True Then
            Me.guobangjiemian.Enabled = True
            Me.kuchangqueren.Enabled = True
            Me.yikuchaxun.Enabled = True
            Me.huizongbaobiao.Enabled = True
            Me.qitashezhi.Enabled = True
            Me.yonghushezhi.Enabled = True
            Me.buda.Enabled = True
            Me.shujuchaxun.Enabled = True
        End If




        If isadmin = True Then
            Me.guobangjiemian.Enabled = True
            Me.kuchangqueren.Enabled = True
            Me.yikuchaxun.Enabled = True
            Me.huizongbaobiao.Enabled = True
            Me.qitashezhi.Enabled = True
            Me.yonghushezhi.Enabled = True
            Me.buda.Enabled = True
            Me.shujuchaxun.Enabled = True
        End If





        '-------------------------------------------------------------------------------------

        If dataviewuser.Item(0).Item("module1") = True Then
            Me.guobangjiemian.Enabled = True

        End If

        If dataviewuser.Item(0).Item("module2") = True Then
            Me.kuchangqueren.Enabled = True

        End If


        If dataviewuser.Item(0).Item("module3") = True Then
            Me.yikuchaxun.Enabled = True

        End If

        If dataviewuser.Item(0).Item("module4") = True Then
            Me.huizongbaobiao.Enabled = True

        End If

        If dataviewuser.Item(0).Item("module5") = True Then
            Me.qitashezhi.Enabled = True

        End If


        If dataviewuser.Item(0).Item("module6") = True Then
            Me.yonghushezhi.Enabled = True

        End If

        If dataviewuser.Item(0).Item("module7") = True Then
            Me.buda.Enabled = True

        End If

        If dataviewuser.Item(0).Item("module8") = True Then
            Me.shujuchaxun.Enabled = True
        End If





        Dim rkCurrentUser As RegistryKey = Registry.CurrentUser


        Dim rkTest As RegistryKey = rkCurrentUser.OpenSubKey("Control Panel\International", True)

        rkTest.SetValue("sShortDate", "yyyy/MM/dd")

        rkTest.Close()
        rkCurrentUser.Close()






        If IO.File.Exists(Application.StartupPath & " \车号.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \车号.txt", IO.FileMode.Create)
            fs.Close()


        End If

        If IO.File.Exists(Application.StartupPath & " \报检号.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \报检号.txt", IO.FileMode.Create)
            fs.Close()
        End If


        If IO.File.Exists(Application.StartupPath & " \货物名.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \货物名.txt", IO.FileMode.Create)
            fs.Close()
        End If



        If IO.File.Exists(Application.StartupPath & " \规格.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \规格.txt", IO.FileMode.Create)
            fs.Close()
        End If




        If IO.File.Exists(Application.StartupPath & " \申请单位.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \申请单位.txt", IO.FileMode.Create)
            fs.Close()


        End If

        If IO.File.Exists(Application.StartupPath & " \发货单位.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \发货单位.txt", IO.FileMode.Create)
            fs.Close()
        End If


        If IO.File.Exists(Application.StartupPath & " \船名.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \船名.txt", IO.FileMode.Create)
            fs.Close()
        End If



        If IO.File.Exists(Application.StartupPath & " \货物流向.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \货物流向.txt", IO.FileMode.Create)
            fs.Close()
        End If



        If IO.File.Exists(Application.StartupPath & " \提单号.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \提单号.txt", IO.FileMode.Create)
            fs.Close()


        End If

        If IO.File.Exists(Application.StartupPath & " \泊位.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \泊位.txt", IO.FileMode.Create)
            fs.Close()
        End If


        If IO.File.Exists(Application.StartupPath & " \票号.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \票号.txt", IO.FileMode.Create)
            fs.Close()
        End If


        If IO.File.Exists(Application.StartupPath & " \磅单号.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \磅单号.txt", IO.FileMode.Create)
            fs.Close()
        End If


        If IO.File.Exists(Application.StartupPath & " \波特率.txt") = False Then
            Dim fs As New IO.FileStream(Application.StartupPath & " \波特率.txt", IO.FileMode.Create)
            fs.Close()
        End If

    End Sub

    Private Sub 移库查询ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yikuchaxun.Click
        MoveStore.Show()
    End Sub

    Private Sub 汇总报表ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles huizongbaobiao.Click
        Report_Total.Show()
    End Sub

    Private Sub 设置界面ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qitashezhi.Click
        Form1.Show()
    End Sub

    Private Sub 退出系统ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tuichuxitong.Click
        Me.Close()

    End Sub



    Private Sub 用户设置ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yonghushezhi.Click
        USERMANAGE.Show()
    End Sub

    Private Sub 注销ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 注销ToolStripMenuItem.Click
    

        On Error Resume Next

        Dim frmLogon As New LoginForm1

        frmLogon.ShowDialog()


        If frmLogon.isok = True Then

            Me.guobangjiemian.Enabled = False
            Me.kuchangqueren.Enabled = False
            Me.yikuchaxun.Enabled = False
            Me.huizongbaobiao.Enabled = False
            Me.qitashezhi.Enabled = False
            Me.yonghushezhi.Enabled = False
            Me.buda.Enabled = False
            Me.shujuchaxun.Enabled = False

            Dim frmChild As Form
            For Each frmChild In Me.MdiChildren
                frmChild.Close()
            Next

            If dataviewuser.Item(0).Item("privilage") = True Then
                Me.guobangjiemian.Enabled = True
                Me.kuchangqueren.Enabled = True
                Me.yikuchaxun.Enabled = True
                Me.huizongbaobiao.Enabled = True
                Me.qitashezhi.Enabled = True
                Me.yonghushezhi.Enabled = True
                Me.buda.Enabled = True
                Me.shujuchaxun.Enabled = True
            End If


            If isadmin = True Then

                Me.guobangjiemian.Enabled = True
                Me.kuchangqueren.Enabled = True
                Me.yikuchaxun.Enabled = True
                Me.huizongbaobiao.Enabled = True
                Me.qitashezhi.Enabled = True
                Me.yonghushezhi.Enabled = True
                Me.buda.Enabled = True
                Me.shujuchaxun.Enabled = True

            End If










            If dataviewuser.Item(0).Item("module1") = True Then
                Me.guobangjiemian.Enabled = True

            End If

            If dataviewuser.Item(0).Item("module2") = True Then
                Me.kuchangqueren.Enabled = True

            End If


            If dataviewuser.Item(0).Item("module3") = True Then
                Me.yikuchaxun.Enabled = True

            End If

            If dataviewuser.Item(0).Item("module4") = True Then
                Me.huizongbaobiao.Enabled = True

            End If

            If dataviewuser.Item(0).Item("module5") = True Then
                Me.qitashezhi.Enabled = True

            End If

            If dataviewuser.Item(0).Item("module6") = True Then
                Me.yonghushezhi.Enabled = True

            End If

            If dataviewuser.Item(0).Item("module7") = True Then
                Me.buda.Enabled = True
            End If

            If dataviewuser.Item(0).Item("module8") = True Then
                Me.shujuchaxun.Enabled = True
            End If




        End If

        Dim objcommanddel As New SqlCommand
        objcommanddel.Connection = objconn
        objcommanddel.CommandText = "delete from loginfo where computername = '" & computername & "'"


        If objconn.State = ConnectionState.Closed Then
            objconn.Open()
        End If

        objcommanddel.ExecuteNonQuery()

        Dim objcommandlog As New SqlCommand

        objcommandlog.Connection = objconn
        objcommandlog.CommandText = "insert into loginfo (logintime,operator,station,computername) values (@logintime,@operator,@station,@computername)"
        objcommandlog.Parameters.AddWithValue("@logintime", Now)
        objcommandlog.Parameters.AddWithValue("@operator", Trim(username.Text))
        objcommandlog.Parameters.AddWithValue("@station", Trim(Stationname.Text))
        objcommandlog.Parameters.AddWithValue("@computername", computername)

        If objconn.State = ConnectionState.Closed Then
            objconn.Open()
        End If
        objcommandlog.ExecuteNonQuery()
        objconn.Close()


    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buda.Click
        MainB.Show()
    End Sub

    Private Sub 数据查询ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shujuchaxun.Click
        Report_Total_Export.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim objdataadapter As New SqlDataAdapter
        Dim objdataview As New DataView
        Dim objdataset As New DataSet




        On Error Resume Next
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconn
        objdataadapter.SelectCommand.CommandText = "select top 1 * from message order by time desc"


        If objconn.State = ConnectionState.Closed Then
            objconn.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "message")

        objdataview = New DataView(objdataset.Tables("message"))

 


        If objdataview.Count = 1 Then
            Me.neirong.Text = Trim(objdataview.Item(0).Item("context"))
            Me.fabuzhe.Text = "发布者:" & Trim(objdataview.Item(0).Item("name"))
            Me.fabushijian.Text = "发布时间:" & Trim(objdataview.Item(0).Item("time"))

        End If


        objconn.Close()

    End Sub

    Private Sub 单位初始化ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 单位初始化ToolStripMenuItem.Click

    End Sub

    Private Sub Toledo数据查询ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Toledo数据查询ToolStripMenuItem.Click
        Toledo20110415.Show()
    End Sub
End Class
