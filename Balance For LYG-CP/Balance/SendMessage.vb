Imports System.Data.SqlClient
Public Class SendMessage

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Len(context.Text) > 199 Then

            MessageBox.Show("�����ַ������ܶ���200", "����", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If
        Dim objcommand As New SqlCommand

        objcommand.Connection = objconnection
        objcommand.CommandText = "insert into message (context,name,time) values (@context,@name,@time)"
        objcommand.Parameters.AddWithValue("@context", Trim(context.Text))
        objcommand.Parameters.AddWithValue("@name", username)
        objcommand.Parameters.AddWithValue("@time", Now)


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
        objconnection.Close()
        MessageBox.Show("������ϣ�120���ɵ��������")
        Me.Close()
    End Sub



    Private Sub SendMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class