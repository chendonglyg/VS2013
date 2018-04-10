Public Class TestWindowsMediaPlay

    Private Sub TestWindowsMediaPlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    

    End Sub

    Private Sub isComing_Click(sender As Object, e As EventArgs) Handles isComing.Click
        AxWindowsMediaPlayer1.URL = "c:\123.mp3"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        AxWindowsMediaPlayer1.settings.autoStart = False
        AxWindowsMediaPlayer1.settings.playCount = 3
        AxWindowsMediaPlayer1.settings.volume = 100

        AxWindowsMediaPlayer1.uiMode = "FULL"


    End Sub
End Class