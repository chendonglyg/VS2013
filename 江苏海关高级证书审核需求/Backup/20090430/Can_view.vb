Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Public Class Can_view

    'Dim objconnection As New SqlConnection("server=(local);database=package;user id=sa;password=chen dong")

    Dim objconnection As New SqlConnection("Data Source= lyg.yihai.com;Initial Catalog = package;User ID=sa; Password=chen dong")

    Dim forreport As New SqlDataAdapter

    Dim sr As New Integer
    Dim srf As New Integer

    Dim objdataAdapter As New SqlDataAdapter
    Dim objdataset As New DataSet




    Dim objdataview As New DataView

    Dim objcurrencymanager As System.Windows.Forms.CurrencyManager
    Private Sub filldatasetandview()
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from can order by ¼��ʱ�� desc "

        objconnection.Open()
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "trade")
        forreport = objdataadapter '����ӡʹ��
        objdataview = New DataView(objdataset.Tables("trade"))
        objcurrencymanager = CType(Me.BindingContext(objdataview), CurrencyManager)
        objconnection.Close()

    End Sub
    Private Sub bindfields()
        guanhao.DataBindings.Clear()
        youpin.DataBindings.Clear()
        chuanming.DataBindings.Clear()
        dianzizhangcehao.DataBindings.Clear()
        jinkouhetonghao.DataBindings.Clear()
        ruguanriqi.DataBindings.Clear()
        ruku.DataBindings.Clear()
        chuku.DataBindings.Clear()
        jinriguancun.DataBindings.Clear()
        dachishu.DataBindings.Clear()
        youwen.DataBindings.Clear()
        lurushijian.DataBindings.Clear()
        bianhao.DataBindings.Clear()
        zuoriguancun.DataBindings.Clear()

        chuguanriqi.DataBindings.Clear()

        bianhao.DataBindings.Add("text", objdataview, "id")
        guanhao.DataBindings.Add("text", objdataview, "�޺�")
        youpin.DataBindings.Add("text", objdataview, "��Ʒ")
        chuanming.DataBindings.Add("text", objdataview, "����")
        dianzizhangcehao.DataBindings.Add("text", objdataview, "�����˲��")
        jinkouhetonghao.DataBindings.Add("text", objdataview, "���ں�ͬ��")
        ruguanriqi.DataBindings.Add("text", objdataview, "�������")

        chuguanriqi.DataBindings.Add("text", objdataview, "��������")


        ruku.DataBindings.Add("text", objdataview, "���")
        chuku.DataBindings.Add("text", objdataview, "����")
        jinriguancun.DataBindings.Add("text", objdataview, "���չ޴�")
        zuoriguancun.DataBindings.Add("text", objdataview, "���չ޴�")
        dachishu.DataBindings.Add("text", objdataview, "�����")
        youwen.DataBindings.Add("text", objdataview, "����")
        lurushijian.DataBindings.Add("text", objdataview, "¼��ʱ��")

 



    End Sub
    Private Sub showposition()
        TextBox14.Text = objcurrencymanager.Position + 1 & " Of " & objcurrencymanager.Count

    End Sub



    Private Sub Can_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1
        Dim sr As IO.StreamReader
        sr = New System.IO.StreamReader(Application.StartupPath & "\can1.txt", True)

        youpin.Items.Clear()
        Do While sr.Peek > 0
            youpin.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\can2.txt", True)
        chuanming.Items.Clear()
        Do While sr.Peek > 0
            chuanming.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing


        sr = New System.IO.StreamReader(Application.StartupPath & "\can3.txt", True)
        dianzizhangcehao.Items.Clear()
        Do While sr.Peek > 0
            chuanming.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\can4.txt", True)
        jinkouhetonghao.Items.Clear()
        Do While sr.Peek > 0
            jinkouhetonghao.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing
        filldatasetandview()
        bindfields()
        showposition()
        forreport = objdataAdapter

        youpin.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        youpin.AutoCompleteSource = AutoCompleteSource.ListItems
        chuanming.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        chuanming.AutoCompleteSource = AutoCompleteSource.ListItems
        jinkouhetonghao.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        jinkouhetonghao.AutoCompleteSource = AutoCompleteSource.ListItems
        dianzizhangcehao.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        dianzizhangcehao.AutoCompleteSource = AutoCompleteSource.ListItems




        dgv.DataSource = objdataview
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub



    Private Sub guanhao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles guanhao.KeyDown
        If e.KeyCode = Keys.Enter Then
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from can where �޺� = '" & guanhao.Text & "'" & "order by ¼��ʱ�� desc "

            objconnection.Open()
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "trade")
            forreport = objdataadapter '����ӡʹ��
            objdataview = New DataView(objdataset.Tables("trade"))
            objcurrencymanager = CType(Me.BindingContext(objdataview), CurrencyManager)
            objconnection.Close()
            bindfields()
            showposition()
            forreport = objdataadapter


            dgv.DataSource = objdataview
        End If

    End Sub


 
    Private Sub guanhao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guanhao.SelectedIndexChanged

    End Sub

    Private Sub �˳�ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �˳�ToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        TextBox14.Text = objcurrencymanager.Position + 1 & " Of " & objcurrencymanager.Count
    End Sub
End Class