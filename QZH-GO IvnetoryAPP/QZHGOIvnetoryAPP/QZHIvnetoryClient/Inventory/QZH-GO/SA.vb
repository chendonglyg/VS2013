Imports System.Data
Public Class SA
    Dim sr As IO.StreamReader
    Private Sub UsernameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameLabel.Click


    End Sub

    Private Sub SA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If IO.File.Exists(Application.StartupPath & " \sa.tx") = True Then

            sr = New System.IO.StreamReader(Application.StartupPath & "\sa.tx", True)


            sasa.Text = Trim(sr.ReadLine)
            sr.Peek()
            PasswordTextBox.Text = Trim(sr.ReadLine)

            sr.Close()
        End If




    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim xr As New IO.StreamWriter(Application.StartupPath & "\sa.tx", False)
        xr.WriteLine(sasa.Text)
        xr.WriteLine(PasswordTextBox.Text)
        xr.Flush()
        xr.Close()
        MessageBox.Show("设置完毕！")
        Me.Close()
    End Sub
End Class