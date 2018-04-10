Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class Seal_B
    Dim forreport As New SqlDataAdapter
    Dim fi As FileInfo
    Public afterdel As String

    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Dim objcurrencymanager As System.Windows.Forms.CurrencyManager

    Private Sub input_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1
        Dim a As Integer


        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select �ʲ����� from Maintenance "


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "fl")

        objdataview = New DataView(objdataset.Tables("fl"))


        zichanfenlei.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                zichanfenlei.Items.Add(objdataview.Item(a).Item("�ʲ�����"))
            Next
        End If

        '-----------------------------------------------------------------------------
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select ��˾���� from Maintenance "


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "gs")

        objdataview = New DataView(objdataset.Tables("gs"))


        gongsimingcheng.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                gongsimingcheng.Items.Add(objdataview.Item(a).Item("��˾����"))
            Next
        End If

        '-------------------------------------------------------------------------------------
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select �������� from Maintenance "


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "bm")

        objdataview = New DataView(objdataset.Tables("bm"))


        shiyongbumen.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                shiyongbumen.Items.Add(objdataview.Item(a).Item("��������"))
            Next
        End If
        '-------------------------------------------------------------------------------------------------
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select ������ from Maintenance "


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "gg")

        objdataview = New DataView(objdataset.Tables("gg"))


        guigexinghao.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                guigexinghao.Items.Add(objdataview.Item(a).Item("������"))
            Next
        End If

    End Sub


    Private Sub ClearTextBox(ByVal cc As Control.ControlCollection)

        For Each ctl As Control In cc

            If TypeOf ctl Is TextBox Then

                CType(ctl, TextBox).Text = String.Empty

            ElseIf ctl.Controls.Count > 0 Then

                ClearTextBox(ctl.Controls) '�ݹ����

            End If

        Next

        For Each ctl As Control In cc

            If TypeOf ctl Is ComboBox Then

                CType(ctl, ComboBox).Text = String.Empty

            ElseIf ctl.Controls.Count > 0 Then

                ClearTextBox(ctl.Controls) '�ݹ����

            End If

        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Seal_A.Show()
    End Sub

    Private Sub ����¼��ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����¼��ToolStripMenuItem.Click
        ClearTextBox(Me.Controls)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If (MessageBox.Show("��ȷ��Ҫ����˱ʼ�¼?(Y/N)", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.OK) Then

            Try

                Dim da As New SqlDataAdapter("Select * from information1", objconnection)

                Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)

                Dim ds As New DataSet()

                da.MissingSchemaAction = MissingSchemaAction.AddWithKey

                Dim fs As New FileStream(opd.FileName, FileMode.OpenOrCreate, FileAccess.Read)
                Dim MyData(fs.Length) As Byte
                fs.Read(MyData, 0, fs.Length)



                fs.Close()


                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                Dim hm As New Date
                hm = dt1.Value
                hm.ToString("yyyy/MM/dd")



                da.Fill(ds, "information1")

                Dim myRow As DataRow

                myRow = ds.Tables("information1").NewRow()

                myRow("afce��") = Trim(afcehao.Text)
                myRow("pic") = MyData
                myRow("�ʲ���") = Trim(zichanhao.Text)
                myRow("��˾����") = Trim(gongsimingcheng.Text)
                myRow("��������") = Trim(fujianleixing.Text)
                myRow("�ļ���С") = fi.Length
                myRow("�ļ�����") = fi.Name
                myRow("�ļ�����") = fi.Extension
                myRow("�ʲ�����") = Trim(zichanfenlei.Text)
                myRow("�ʱ�������") = dt1.Value
                myRow("ʹ������") = Val(shiyongnianxian.Text)
                myRow("�ʲ�����") = Trim(zichanmingcheng.Text)

                myRow("����ͺ�") = Trim(guigexinghao.Text)

                myRow("����") = Trim(shuliang.Text)

                myRow("ʹ��״̬") = Trim(shiyongzhuangtai.Text)
                myRow("��Ʊ����") = Val(fapiaoshuliang.Text)
                myRow("��������") = Val(fujianshuliang.Text)

                myRow("ʹ�ò���") = Trim(shiyongbumen.Text)

                myRow("���ϱ�־") = False

                myRow("�ʲ�ԭֵ") = Val(zichanyuanzhi.Text)
                myRow("��ע") = Trim(beizhu.Text)

                ds.Tables("information1").Rows.Add(myRow)

                da.Update(ds, "information1")

                fs = Nothing
                MyCB = Nothing
                ds = Nothing
                da = Nothing


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try




            ClearTextBox(Me.Controls) '�������Ҫ���һ��������д��
            MessageBox.Show("�������!", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)




            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select top 1 id,afce��,����,ʹ������,��˾����,����ͺ�,ʹ��״̬,��Ʊ����,��������,�ʱ�������,�ʲ���,����ʱ��,ʵ�ʱ���ʱ��,���ϱ�־,�ʲ�����,�ʲ�����,ʹ�ò���,�ʲ�ԭֵ,��˾����,��������,�ļ�����,�ļ�����,�ļ���С,��ע from information1  order by id desc"


            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "information1")

            objdataview = New DataView(objdataset.Tables("information1"))
            'objcurrencymanager = CType(Me.BindingContext(objdataview), CurrencyManager)
            objconnection.Close()



            dgv.DataSource = objdataview





        End If


    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub





    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        opd.Filter = "�����ļ�|*.*"

        If opd.ShowDialog = System.Windows.Forms.DialogResult.OK Then

            fi = (New FileInfo(opd.FileName))


            lujing.Text = fi.FullName
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv.DataError
        On Error Resume Next
    End Sub
End Class
