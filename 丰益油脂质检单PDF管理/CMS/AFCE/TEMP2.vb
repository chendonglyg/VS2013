Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class TEMP2
    Dim fi As FileInfo
    Public afterdel As String
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub Moveform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select �������� from Maintenance "

        Dim a As Integer
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "bm")

        objdataview = New DataView(objdataset.Tables("bm"))


        mubiaobumen.Items.Clear()
        'On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                mubiaobumen.Items.Add(objdataview.Item(a).Item("��������"))
            Next
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim hm As New Date
        hm = dt1.Value

        hm.ToString("yyyy/MM/dd")
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "insert into move (id,afce,�ʲ���,ԭʼ����,Ŀ�겿��,����ʱ��,��ע) values (@id,@afce,@�ʲ���,@ԭʼ����,@Ŀ�겿��,@����ʱ��,@��ע)"
        objdataadapter.SelectCommand.Parameters.AddWithValue("@id", Trim(ID.Text))
        objdataadapter.SelectCommand.Parameters.AddWithValue("@afce", Trim(afcehao.Text))
        objdataadapter.SelectCommand.Parameters.AddWithValue("@ԭʼ����", Trim(yuanshibumen.Text))
        objdataadapter.SelectCommand.Parameters.AddWithValue("@Ŀ�겿��", Trim(mubiaobumen.Text))
        objdataadapter.SelectCommand.Parameters.AddWithValue("@�ʲ���", Trim(zichanhao.Text))
        objdataadapter.SelectCommand.Parameters.AddWithValue("@����ʱ��", hm.Date)
        objdataadapter.SelectCommand.Parameters.AddWithValue("@��ע", Trim(beizhu.Text))
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataadapter.SelectCommand.ExecuteNonQuery()

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "update information1 set ʹ�ò��� ='" & Trim(mubiaobumen.Text) & "' where id=" & Val(ID.Text)
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataadapter.SelectCommand.ExecuteNonQuery()

        MessageBox.Show("��ɵ���!")


    End Sub
End Class