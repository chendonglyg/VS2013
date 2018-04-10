Imports system.windows.Forms.DialogResult
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class TEMP5
    Dim forreport As New SqlDataAdapter

    Dim fi As FileInfo
    Public afterdel As String

    Dim objdataadapter As New SqlDataAdapter


    Public objdataview As New DataView
    Dim objdataset As New DataSet

    Private Sub Upload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1
        Try
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select top 100 id,afce��,����,ʹ������,��˾����,����ͺ�,ʹ��״̬,��Ʊ����,��������,�ʱ�������,�ʲ���,����ʱ��,ʵ�ʱ���ʱ��,���ϱ�־,�ʲ�����,�ʲ�����,ʹ�ò���,�ʲ�ԭֵ,��˾����,��������,�ļ�����,�ļ�����,�ļ���С,��ע from information1  order by id desc"


            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "information1")

            objdataview = New DataView(objdataset.Tables("information1"))
            'objcurrencymanager = CType(Me.BindingContext(objdataview), CurrencyManager)
            objconnection.Close()



            DGV.DataSource = objdataview
            clearbindtextbox(Me.Controls)
            bindfields()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub clearbindtextbox(ByVal cc As Control.ControlCollection)

        For Each ctl As Control In cc

            If TypeOf ctl Is TextBox Then

                ctl.DataBindings.Clear()

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '�ݹ�������textbox��

            End If

        Next

        For Each ctl As Control In cc

            If TypeOf ctl Is ComboBox Then

                ctl.DataBindings.Clear()

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '�ݹ�������combobox��

            End If

        Next

        dt1.DataBindings.Clear()

    End Sub

    Public Sub bindfields()




        If objdataview.Count > 0 Then

            dt1.DataBindings.Clear()


            clearbindtextbox(Me.Controls) '�������������textbox�İ�



            '-------------------------------------------------------------------------------------------------------------------

            ID.DataBindings.Add("text", objdataview, "id")

            afcehao.DataBindings.Add("text", objdataview, "afce��")
            zichanhao.DataBindings.Add("text", objdataview, "�ʲ���")

            '---------------------------------------------------------------------------------------------------------------------------

 


            '------------------------------------------------------------------------------------------------------------------------------

            zichanfenlei.DataBindings.Add("text", objdataview, "�ʲ�����")
            dt1.DataBindings.Add("text", objdataview, "�ʱ�������")
            zichanmingcheng.DataBindings.Add("text", objdataview, "�ʲ�����")

            shiyongnianxian.DataBindings.Add("text", objdataview, "ʹ������")




            '----------------------------------------------------------------------------------------------------------------
            guigexinghao.DataBindings.Add("text", objdataview, "����ͺ�")
            shuliang.DataBindings.Add("text", objdataview, "����")

            gongsimingcheng.DataBindings.Add("text", objdataview, "��˾����")
            shiyongzhuangtai.DataBindings.Add("text", objdataview, "ʹ��״̬")
            fapiaoshuliang.DataBindings.Add("text", objdataview, "��Ʊ����")
    
            fujianshuliang.DataBindings.Add("text", objdataview, "��������")
            shiyongbumen.DataBindings.Add("text", objdataview, "ʹ�ò���")
            zichanyuanzhi.DataBindings.Add("text", objdataview, "�ʲ�ԭֵ")
            '----------------------------------------------------------------------------------------------

            beizhu.DataBindings.Add("text", objdataview, "��ע")
            fujianleixing.DataBindings.Add("text", objdataview, "��������")


        End If


    End Sub

    Private Sub dt1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt1.ValueChanged

    End Sub

    Private Sub afcehao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles afcehao.SelectedIndexChanged

    End Sub

    Private Sub zichanfenlei_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zichanfenlei.SelectedIndexChanged

    End Sub

    Private Sub zichanmingcheng_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zichanmingcheng.SelectedIndexChanged

    End Sub

    Private Sub gongsimingcheng_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gongsimingcheng.SelectedIndexChanged

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DGV_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        Dim dgv As DataGridView = CType(sender, DataGridView)

        'ȷ�ϵ�Ԫ�����


        If dgv.Rows(e.RowIndex).Cells("���ϱ�־").Value = True Then
            e.CellStyle.BackColor = Color.Red


        Else

            '���ݵ�Ԫ���ֵ���������ɫ
            If (Now > dgv.Rows(e.RowIndex).Cells("����ʱ��").Value) And (Len(dgv.Rows(e.RowIndex).Cells("id").Value) > 0) Then
                e.CellStyle.BackColor = Color.Yellow

            End If
        End If



    End Sub

    Private Sub DGV_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DGV.DataError
        On Error Resume Next
    End Sub

    Private Sub �ʲ�����ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �ʲ�����ToolStripMenuItem.Click
        TEMP2.Show()
        TEMP2.afcehao.Text = Trim(afcehao.Text)
        TEMP2.zichanhao.Text = Trim(zichanhao.Text)
        TEMP2.dt1.Value = Now
        TEMP2.yuanshibumen.Text = Trim(shiyongbumen.Text)
        TEMP2.ID.Text = Trim(ID.Text)

    End Sub

    Private Sub �ʲ�����ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �ʲ�����ToolStripMenuItem.Click
        If MessageBox.Show("ȷ��Ҫ���ϴ��ʲ�����Y/N��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = OK Then
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "update information1 set ���ϱ�־=1,ʵ�ʱ���ʱ�� = getdate() where id=" & ID.Text
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objdataadapter.SelectCommand.ExecuteNonQuery()

            MessageBox.Show("OK")


        End If
    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then

            objdataadapter = New SqlDataAdapter
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection



            objdataadapter.SelectCommand.CommandText = "select * from information1 where �ʲ���='" & Trim(zichanhao.Text) & "'"

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "lyg")
            objdataview = New DataView(objdataset.Tables("lyg"))
            DGV.DataSource = Nothing
            DGV.AutoGenerateColumns = True
            DGV.DataSource = objdataview




        End If
    End Sub

    Private Sub ToolStripTextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox2.Click

    End Sub

    Private Sub ToolStripTextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then

            objdataadapter = New SqlDataAdapter
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection



            objdataadapter.SelectCommand.CommandText = "select  id,afce��,����,ʹ������,��˾����,����ͺ�,ʹ��״̬,��Ʊ����,��������,�ʱ�������,�ʲ���,����ʱ��,ʵ�ʱ���ʱ��,���ϱ�־,�ʲ�����,�ʲ�����,ʹ�ò���,�ʲ�ԭֵ,��˾����,��������,�ļ�����,�ļ�����,�ļ���С,��ע from information1 where afce��='" & Trim(afcehao.Text) & "'"

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "lyg")
            objdataview = New DataView(objdataset.Tables("lyg"))
            DGV.DataSource = Nothing
            DGV.AutoGenerateColumns = True
            DGV.DataSource = objdataview




        End If
    End Sub

    Private Sub �ʲ�������¼ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �ʲ�������¼ToolStripMenuItem.Click
        objdataadapter = New SqlDataAdapter
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection



        objdataadapter.SelectCommand.CommandText = "select  id,afce��,����,ʹ������,��˾����,����ͺ�,ʹ��״̬,��Ʊ����,��������,�ʱ�������,�ʲ���,����ʱ��,ʵ�ʱ���ʱ��,���ϱ�־,�ʲ�����,�ʲ�����,ʹ�ò���,�ʲ�ԭֵ,��˾����,��������,�ļ�����,�ļ�����,�ļ���С,��ע from move where �ʲ��� ='" & Trim(zichanhao.Text) & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "move")
        objdataview = New DataView(objdataset.Tables("move"))
        TEMP4.Show()
        TEMP4.dgv.DataSource = Nothing
        TEMP4.dgv.AutoGenerateColumns = True
        TEMP4.dgv.DataSource = objdataview

    End Sub
End Class