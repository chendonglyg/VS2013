Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.MdiParent = MDIParent1

        If dataviewuser.Item(0).Item("privilage") = True Then
            message.Enabled = True

            showusers.Enabled = True

        Else
            message.Enabled = False

            showusers.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        baojianhaoweihu.Show()
    End Sub

    Private Sub message_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles message.Click
        SendMessage.Show()
    End Sub

  

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showusers.Click
        useronline.Show()


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        fordel.Show()
    End Sub

    Private Sub danweichushihua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles danweichushihua.Click
        SaveSetting("MyApp", "set", "times", Trim(station.Text))
        stationname = Trim(station.Text)
        MDIParent1.Stationname.Text = stationname


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SETBUND.Show()

    End Sub
End Class