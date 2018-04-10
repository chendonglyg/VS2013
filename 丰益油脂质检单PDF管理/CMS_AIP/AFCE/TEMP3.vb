Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class TEMP3
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (MessageBox.Show("您确定要暂时保存此笔记录?(Y/N)", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK) Then





            Dim fs As New FileStream(opd.FileName, FileMode.OpenOrCreate, FileAccess.Read)
            Dim MyData(fs.Length) As Byte
            fs.Read(MyData, 0, fs.Length)



            '----------------------------------------------------------------------------------------------





            Dim objcommand As New SqlCommand

            objcommand.Connection = objconnection
            If selopen.Checked = False Then
                objcommand.CommandText = "update information1 set 资产分类=@资产分类,使用年限=@使用年限,规格型号=@规格型号,数量=@数量,使用状态=@使用状态,发票数量=@发票数量,附件数量=@附件数量,备注=@备注,附件类型=@附件类型 where id=" & Val(id.Text)
            Else
                objcommand.CommandText = "update information1 set 资产分类=@资产分类,使用年限=@使用年限,规格型号=@规格型号,数量=@数量,使用状态=@使用状态,发票数量=@发票数量,附件数量=@附件数量,备注=@备注,附件类型=@附件类型,pic=@pic where id=" & Val(id.Text)

            End If

            If selopen.Checked = False Then
                objcommand.Parameters.AddWithValue("@资产分类", Trim(zichanfenlei.Text))
                objcommand.Parameters.AddWithValue("@使用年限", Val(shiyongnianxian.Text))
                objcommand.Parameters.AddWithValue("@规格型号", Trim(guigexinghao.Text))
                objcommand.Parameters.AddWithValue("@数量", Trim(shuliang.Text))
                objcommand.Parameters.AddWithValue("@使用状态", Trim(shiyongzhuangtai.Text))
                objcommand.Parameters.AddWithValue("@发票数量", Trim(fapiaoshuliang.Text))
                objcommand.Parameters.AddWithValue("@附件数量", Trim(fujianshuliang.Text))
                objcommand.Parameters.AddWithValue("@备注", Trim(beizhu.Text))
                objcommand.Parameters.AddWithValue("@附件类型", Trim(fujianleixing.Text))

            Else
                objcommand.Parameters.AddWithValue("@资产分类", Trim(zichanfenlei.Text))
                objcommand.Parameters.AddWithValue("@使用年限", Val(shiyongnianxian.Text))
                objcommand.Parameters.AddWithValue("@规格型号", Trim(guigexinghao.Text))
                objcommand.Parameters.AddWithValue("@数量", Trim(shuliang.Text))
                objcommand.Parameters.AddWithValue("@使用状态", Trim(shiyongzhuangtai.Text))
                objcommand.Parameters.AddWithValue("@发票数量", Trim(fapiaoshuliang.Text))
                objcommand.Parameters.AddWithValue("@附件数量", Trim(fujianshuliang.Text))
                objcommand.Parameters.AddWithValue("@备注", Trim(beizhu.Text))
                objcommand.Parameters.AddWithValue("@附件类型", Trim(fujianleixing.Text))
                objcommand.Parameters.AddWithValue("@pic", MyData)
            End If














            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommand.ExecuteNonQuery()

            objconnection.Close()
            MessageBox.Show("修改完毕!")

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