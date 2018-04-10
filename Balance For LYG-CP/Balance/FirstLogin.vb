Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Data

Public Class FirstLogin

    Private Sub FirstLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Password1.Text = password2.Text Then


            Dim a As Integer
            Dim b, c As Boolean

            b = False
            c = False

            For a = 1 To Len(Password1.Text)
                If (Regex.IsMatch(Mid(Password1.Text, a, 1), "^[A-Za-z]+$")) Then
                    b = True
                ElseIf (Regex.IsMatch(Mid(Password1.Text, a, 1), "^\d+$")) Then
                    c = True
                End If




            Next



            If (b And c And (Len(Password1.Text) >= 6)) Then
                MessageBox.Show(" 已满足数字和字母混合且6位长度！")




                Dim objcommandpassword As New SqlCommand
                objcommandpassword.Connection = objconnection
                objcommandpassword.CommandText = "update users set  password=@password,module10=1 where username='" & Trim(Username.Text) & "'"

                objcommandpassword.Parameters.AddWithValue("@password", Trim(Password1.Text))
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommandpassword.ExecuteNonQuery()
                objconnection.Close()


                Me.Close()

            Else
                MessageBox.Show("密码不确定或复杂度不满足集团要求!")
            End If







        Else



            MessageBox.Show("两次密码不一致，请确认！")


        End If



    End Sub
End Class