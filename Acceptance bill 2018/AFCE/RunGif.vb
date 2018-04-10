Imports QuartzTypeLib
Public Class RunGif



    '调用运动图像播放类型库Quartz.dll,在c:\windows\system32目录下  
    Private pMC As FilgraphManager '定义pMC为FilgraphManager对象  
    Private pVW As IVideoWindow '定义pVW为IVideoWindow对象  
    'Public pVP As IMediaPosition  
    'Public pBV As IBasicVideo  

    '播放GIF动画  
  

    '停止播放GIF动画  
  

  

    Private Sub RunGif_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Picture1.SizeMode = 3
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        pMC = New FilgraphManager
        pMC.Stop()
        'Set pVP = pMC  
        'pVP.StopTime = 0  
        pMC.RenderFile("")


        On Error GoTo Lhandle
        pMC.RenderFile("d:\TESTGIF.gif") '加载GIF动画，并在PictureBox中播放  
        'Set pVP = pMC  
        's = Str(pVP.Duration)  

        On Error Resume Next
        pVW = pMC
        pVW.WindowStyle = CLng(&H6000000)

        '限定图像在Picture1的大小中  
        pVW.Left = 0 : pVW.Top = 0
        pVW.Width = Picture1.Width
        pVW.Height = Picture1.Height

        pVW.Owner = Picture1.Handle  '在Picture1中播放  
        pVW.MessageDrain = Picture1.Handle '此行非常重要，用来定义图像的右键菜单所必须  
        pMC.Run() '一直播放  

        Exit Sub
Lhandle:
        MsgBox("加载文件错误！")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pMC.Stop()
        pVW = Nothing
        pMC = Nothing
    End Sub
End Class