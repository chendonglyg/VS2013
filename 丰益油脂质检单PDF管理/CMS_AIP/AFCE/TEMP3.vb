Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class TEMP3
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (MessageBox.Show("��ȷ��Ҫ��ʱ����˱ʼ�¼?(Y/N)", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK) Then





            Dim fs As New FileStream(opd.FileName, FileMode.OpenOrCreate, FileAccess.Read)
            Dim MyData(fs.Length) As Byte
            fs.Read(MyData, 0, fs.Length)



            '----------------------------------------------------------------------------------------------





            Dim objcommand As New SqlCommand

            objcommand.Connection = objconnection
            If selopen.Checked = False Then
                objcommand.CommandText = "update information1 set �ʲ�����=@�ʲ�����,ʹ������=@ʹ������,����ͺ�=@����ͺ�,����=@����,ʹ��״̬=@ʹ��״̬,��Ʊ����=@��Ʊ����,��������=@��������,��ע=@��ע,��������=@�������� where id=" & Val(id.Text)
            Else
                objcommand.CommandText = "update information1 set �ʲ�����=@�ʲ�����,ʹ������=@ʹ������,����ͺ�=@����ͺ�,����=@����,ʹ��״̬=@ʹ��״̬,��Ʊ����=@��Ʊ����,��������=@��������,��ע=@��ע,��������=@��������,pic=@pic where id=" & Val(id.Text)

            End If

            If selopen.Checked = False Then
                objcommand.Parameters.AddWithValue("@�ʲ�����", Trim(zichanfenlei.Text))
                objcommand.Parameters.AddWithValue("@ʹ������", Val(shiyongnianxian.Text))
                objcommand.Parameters.AddWithValue("@����ͺ�", Trim(guigexinghao.Text))
                objcommand.Parameters.AddWithValue("@����", Trim(shuliang.Text))
                objcommand.Parameters.AddWithValue("@ʹ��״̬", Trim(shiyongzhuangtai.Text))
                objcommand.Parameters.AddWithValue("@��Ʊ����", Trim(fapiaoshuliang.Text))
                objcommand.Parameters.AddWithValue("@��������", Trim(fujianshuliang.Text))
                objcommand.Parameters.AddWithValue("@��ע", Trim(beizhu.Text))
                objcommand.Parameters.AddWithValue("@��������", Trim(fujianleixing.Text))

            Else
                objcommand.Parameters.AddWithValue("@�ʲ�����", Trim(zichanfenlei.Text))
                objcommand.Parameters.AddWithValue("@ʹ������", Val(shiyongnianxian.Text))
                objcommand.Parameters.AddWithValue("@����ͺ�", Trim(guigexinghao.Text))
                objcommand.Parameters.AddWithValue("@����", Trim(shuliang.Text))
                objcommand.Parameters.AddWithValue("@ʹ��״̬", Trim(shiyongzhuangtai.Text))
                objcommand.Parameters.AddWithValue("@��Ʊ����", Trim(fapiaoshuliang.Text))
                objcommand.Parameters.AddWithValue("@��������", Trim(fujianshuliang.Text))
                objcommand.Parameters.AddWithValue("@��ע", Trim(beizhu.Text))
                objcommand.Parameters.AddWithValue("@��������", Trim(fujianleixing.Text))
                objcommand.Parameters.AddWithValue("@pic", MyData)
            End If














            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommand.ExecuteNonQuery()

            objconnection.Close()
            MessageBox.Show("�޸����!")

        End If


    End Sub

    Private Sub selopen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selopen.CheckedChanged
        If selopen.Checked = True Then
            open.Enabled = True
        Else
            open.Enabled = False
        End If
    End Sub

    Private Sub guigexinghao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guigexinghao.SelectedIndexChanged

    End Sub

    Private Sub dt1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt1.ValueChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class