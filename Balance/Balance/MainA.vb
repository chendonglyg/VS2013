Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO.Ports
Imports System.Threading
Imports Microsoft.Win32
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine


Public Class MainA
    Dim RS232 As SerialPort
    Dim bangfanghao As String
    Dim strReceive As String
    Delegate Sub HandleInterfaceUpdateDelegate(ByVal astring As String)
    Dim interfaceUpdateHandle As HandleInterfaceUpdateDelegate

    Dim zhupibiaozhi As Boolean = False

    Dim biaozhi As Boolean

    Dim forreport As New SqlDataAdapter

    Dim hejiziduan As Integer '存储字段名的index号,从0开始
    Public ziduan(100) As String '存储字段名

    Dim objdataadapter As New SqlDataAdapter


    Dim objdatareader As SqlClient.SqlDataReader
    Dim czfs As Boolean = False  '是否选择了承重方式
    Dim hejibiaozhi As Boolean
    Dim hejibiaozhirmb As Boolean
    Dim hejibiaozhidollor As Boolean

    Dim afterdel As Integer

    Dim objdataview As New DataView
    Dim objdataset As New DataSet


    Dim mBaudRate As Integer
    Dim mParity As IO.Ports.Parity
    Dim mDataBit As Integer
    Dim mStopbit As IO.Ports.StopBits
    Dim mPortName As String






    Private Sub SerialPort_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles sp.DataReceived
        On Error Resume Next

        If bangfanghao = "650" Or bangfanghao = "济南金钟类型" Then

            If sp.IsOpen Then
                Dim str As String = ""
                str = Me.sp.ReadLine()
                ' MessageBox.Show(str)

                interfaceUpdateHandle = New HandleInterfaceUpdateDelegate(AddressOf showtext)

                BeginInvoke(interfaceUpdateHandle, str.Substring(8, 6))
            End If

        Else




            If sp.IsOpen Then
                Dim bytesread As Integer
                bytesread = sp.ReadBufferSize
                Dim bytesdata(bytesread) As Byte
                Dim str As String = ""
                Dim a As Integer
                Dim firstbyte As Byte
                Dim bytedata As Byte



                firstbyte = Convert.ToByte(sp.ReadByte())
                'MessageBox.Show(firstbyte)
                If firstbyte = &H2 Then





                    bytesdata(0) = firstbyte


                    For a = 1 To bytesread

                        bytedata = Convert.ToByte(sp.ReadByte())
                        bytesdata(a) = bytedata
                        If bytedata = &HD Then
                            Exit For
                        End If

                    Next



                    str = System.Text.Encoding.Default.GetString(bytesdata)



                End If


                interfaceUpdateHandle = New HandleInterfaceUpdateDelegate(AddressOf showtext)

                If Len(str) > 0 Then
                    'MessageBox.Show(str)
                    BeginInvoke(interfaceUpdateHandle, str.Substring(4, 6))
                End If

                '
                'Thread.Sleep(200) '将当前线程挂起指定的时间
                'BeginInvoke(interfaceUpdateHandle, str.Substring(1, 2))

            End If





        End If





        'MessageBox.Show(ex.Message + ex.GetType().FullName)











    End Sub
#Region "Savetxt方法"
    Private Sub savetxt()
        'If chehao.Text.Length > 0 Then
        '    If chehao.FindString(chehao.Text) < 0 Then
        '        Dim xr As New IO.StreamWriter(Application.StartupPath & "\车号.txt", True)
        '        xr.WriteLine(chehao.Text)
        '        xr.Flush()
        '        xr.Close()
        '    End If
        'End If


        If baojianhao.Text.Length > 0 Then
            If baojianhao.FindString(baojianhao.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\报检号.txt", True)
                xr.WriteLine(baojianhao.Text)
                xr.Flush()
                xr.Close()
            End If
        End If

        If huowuming.Text.Length > 0 Then
            If huowuming.FindString(huowuming.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\货物名.txt", True)
                xr.WriteLine(huowuming.Text)
                xr.Flush()
                xr.Close()
            End If
        End If

        If guige.Text.Length > 0 Then
            If guige.FindString(guige.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\规格.txt", True)
                xr.WriteLine(guige.Text)
                xr.Flush()
                xr.Close()
            End If
        End If

        If shenqingdanwei.Text.Length > 0 Then
            If shenqingdanwei.FindString(shenqingdanwei.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\申请单位.txt", True)
                xr.WriteLine(shenqingdanwei.Text)
                xr.Flush()
                xr.Close()
            End If
        End If

        If fahuodanwei.Text.Length > 0 Then
            If fahuodanwei.FindString(fahuodanwei.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\发货单位.txt", True)
                xr.WriteLine(fahuodanwei.Text)
                xr.Flush()
                xr.Close()
            End If
        End If


        If chuanming.Text.Length > 0 Then
            If chuanming.FindString(chuanming.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\船名.txt", True)
                xr.WriteLine(chuanming.Text)
                xr.Flush()
                xr.Close()
            End If
        End If



        If huowuliuxiang.Text.Length > 0 Then
            If huowuliuxiang.FindString(huowuliuxiang.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\货物流向.txt", True)
                xr.WriteLine(huowuliuxiang.Text)
                xr.Flush()
                xr.Close()
            End If
        End If

        If tidanhao.Text.Length > 0 Then
            If tidanhao.FindString(tidanhao.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\提单号.txt", True)
                xr.WriteLine(tidanhao.Text)
                xr.Flush()
                xr.Close()
            End If
        End If



        If bowei.Text.Length > 0 Then
            If bowei.FindString(bowei.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\泊位.txt", True)
                xr.WriteLine(bowei.Text)
                xr.Flush()
                xr.Close()
            End If
        End If


        If bangdanhao.Text.Length > 0 Then
            If bangdanhao.FindString(bangdanhao.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\磅单号.txt", True)
                xr.WriteLine(bangdanhao.Text)
                xr.Flush()
                xr.Close()
            End If
        End If






        'If piaohao.Text.Length > 0 Then
        '    If piaohao.FindString(piaohao.Text) < 0 Then
        '        Dim xr As New IO.StreamWriter(Application.StartupPath & "\票号.txt", True)
        '        xr.WriteLine(piaohao.Text)
        '        xr.Flush()
        '        xr.Close()
        '    End If
        'End If








    End Sub
#End Region



#Region "Addtxt方法"

    Private Sub addtxt()
        Dim sr As IO.StreamReader
        'sr = New System.IO.StreamReader(Application.StartupPath & "\车号.txt", True)
        'chehao.Items.Clear()
        'Do While sr.Peek > 0
        '    chehao.Items.Add(sr.ReadLine)
        'Loop
        '' MessageBox.Show(sr.ReadToEnd)
        ''MessageBox.Show(OpenFileDialog1.FileName)
        'sr.Close()
        'sr = Nothing


        sr = New System.IO.StreamReader(Application.StartupPath & "\货物流向.txt", True)
        huowuliuxiang.Items.Clear()
        Do While sr.Peek > 0
            huowuliuxiang.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing


        sr = New System.IO.StreamReader(Application.StartupPath & "\报检号.txt", True)
        baojianhao.Items.Clear()
        Do While sr.Peek > 0
            baojianhao.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing




        sr = New System.IO.StreamReader(Application.StartupPath & "\货物名.txt", True)
        huowuming.Items.Clear()
        Do While sr.Peek > 0
            huowuming.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing



        sr = New System.IO.StreamReader(Application.StartupPath & "\规格.txt", True)
        guige.Items.Clear()
        Do While sr.Peek > 0
            guige.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing


        sr = New System.IO.StreamReader(Application.StartupPath & "\申请单位.txt", True)
        shenqingdanwei.Items.Clear()
        Do While sr.Peek > 0
            shenqingdanwei.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing




        sr = New System.IO.StreamReader(Application.StartupPath & "\发货单位.txt", True)
        fahuodanwei.Items.Clear()
        Do While sr.Peek > 0
            fahuodanwei.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing



        sr = New System.IO.StreamReader(Application.StartupPath & "\船名.txt", True)
        chuanming.Items.Clear()
        Do While sr.Peek > 0
            chuanming.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing






        sr = New System.IO.StreamReader(Application.StartupPath & "\提单号.txt", True)
        tidanhao.Items.Clear()
        Do While sr.Peek > 0
            tidanhao.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\泊位.txt", True)
        bowei.Items.Clear()
        Do While sr.Peek > 0
            bowei.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing


        sr = New System.IO.StreamReader(Application.StartupPath & "\磅单号.txt", True)
        bangdanhao.Items.Clear()
        Do While sr.Peek > 0
            bangdanhao.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing



        'sr = New System.IO.StreamReader(Application.StartupPath & "\票号.txt", True)
        'piaohao.Items.Clear()
        'Do While sr.Peek > 0
        '    piaohao.Items.Add(sr.ReadLine)
        'Loop
        '' MessageBox.Show(sr.ReadToEnd)
        ''MessageBox.Show(OpenFileDialog1.FileName)
        'sr.Close()
        'sr = Nothing


    End Sub
#End Region

    Private Sub setbund()



        Dim sr As IO.StreamReader
        sr = New System.IO.StreamReader(Application.StartupPath & "\波特率.txt", True)






        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
 


        bangfanghao = Trim(sr.ReadLine)
        sr.Peek()
        Me.sp.ReadTimeout = 1000
        Me.sp.WriteTimeout = 1000
        Me.sp.RtsEnable = True
        Me.sp.DtrEnable = True

        'mPortName = "COM4"  '欲开启的通讯端口   
        'mBaudRate = 1200  '比特率
        'mParity = Parity.Even   '校验位检查设定
        'mDataBit = 7    '数据位设定值
        'mStopbit = StopBits.One  '停止位设定值
        ''建立一个通讯端口对象


        mPortName = Trim(sr.ReadLine)
        sr.Peek()

        mBaudRate = Val(sr.ReadLine)
        sr.Peek()

        Select Case Trim(sr.ReadLine)
            Case "Even"
                mParity = Parity.Even   '校验位检查设定
            Case "Mark"
                mParity = Parity.Mark    '校验位检查设定
            Case "None"
                mParity = Parity.None    '校验位检查设定
            Case "Odd"
                mParity = Parity.Odd   '校验位检查设定
            Case "Space"
                mParity = Parity.Space    '校验位检查设定
        End Select
        sr.Peek()




        mDataBit = Val(sr.ReadLine)    '数据位设定值
        sr.Peek()

        Select Case Trim(sr.ReadLine)
            Case "None"
                mStopbit = StopBits.None    '停止位
            Case "One"
                mStopbit = StopBits.One
            Case "OnePointFive"
                mStopbit = StopBits.OnePointFive
            Case "Two"
                mStopbit = StopBits.Two
        End Select

        sr.Close()
        sr = Nothing


        Me.sp.PortName = mPortName
        Me.sp.BaudRate = mBaudRate
        Me.sp.Parity = mParity
        Me.sp.DataBits = mDataBit
        Me.sp.StopBits = mStopbit



        sp.ReadBufferSize = 36 '默认就是4096

        Try

            If sp.IsOpen = False Then


                sp.Open()
                sp.ReadExisting() '设置input从接收缓冲读取全数据
                sp.ReceivedBytesThreshold = 1 '设置引发OnComm事件的字节长度
                sp.DiscardInBuffer() '/清楚接受缓冲区

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + ex.GetType().FullName)
        End Try




    End Sub


#Region "Showtext方法"
    Private Sub showtext(ByVal astring As String)

        '  Me.rtxtshow.Text += astring & vbCrLf

        Me.weight.Text = Val(astring)


    End Sub
#End Region

    Private Sub MainA_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed


        If sp.IsOpen Then
            sp.DiscardInBuffer()
            sp.Close()

        End If
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            setbund()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        dellinshiku.Enabled = False
        Manual.Enabled = False
        moni.Enabled = False

        If dataviewuser.Item(0).Item("privilage") = True Then
            Manual.Enabled = True
            moni.Enabled = True
            dellinshiku.Enabled = True
        End If


        If dataviewuser.Item(0).Item("module9") = True Then

            dellinshiku.Enabled = True

        End If





        addtxt()
        'Me.MdiParent = MDIParent1


        Dim rkCurrentUser As RegistryKey = Registry.CurrentUser
        Dim rkTest As RegistryKey = rkCurrentUser.OpenSubKey("Control Panel\International", True)
        rkTest.SetValue("sShortDate", "yyyy/MM/dd")
        rkTest.Close()
        rkCurrentUser.Close()


        '这块是要随时更新临时库信息
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from trade where done=0 order by id desc "
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "trade")
        objdataview = New DataView(objdataset.Tables("trade"))
        dgv.DataSource = objdataview




    End Sub






    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        weight.Text = Int((150000 - 0 + 1) * Rnd() + 0)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles moni.Click
        Timer1.Enabled = True
    End Sub

    Private Sub ClearTextBox(ByVal cc As Control.ControlCollection)

        For Each ctl As Control In cc

            If TypeOf ctl Is ComboBox Then

                CType(ctl, ComboBox).Text = String.Empty

            ElseIf ctl.Controls.Count > 0 Then

                ClearTextBox(ctl.Controls) '递归调用

            End If

        Next



        For Each ctl As Control In cc

            If TypeOf ctl Is TextBox Then

                CType(ctl, TextBox).Text = String.Empty

            ElseIf ctl.Controls.Count > 0 Then

                ClearTextBox(ctl.Controls) '递归调用

            End If

        Next

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ClearTextBox(Me.GroupBox3.Controls)
        biaozhi = 0

        moni.Enabled = True
        bangdanhao.Text = Val(Now.Year & Format(Now.Month, "00") & Format(Now.Day, "00") & Format(Now.Hour, "00") & Format(Now.Minute, "00") & Format(Now.Second, "00"))

    End Sub

    Private Sub dushu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dushu.Click
        If Val(weight.Text) > 0 Then
            Button4.Enabled = True

        End If


        Dim tempweight As Integer
        tempweight = Val(weight.Text)





        If Manual.Checked = True Then '不用设置标志，手工置皮一次性完成记录的保存
            maozhong.Text = tempweight
            maozhongshijian.Text = Now
            jingzhong.Text = Val(maozhong.Text) - Val(pizhong.Text) - Val(xiangzhong.Text) - Val(xiangzhong2.Text)


            maocao.Text = username
            picao.Text = username
            maoguo.Text = stationname
            piguo.Text = stationname


        End If

        '---------------------------------------------------------------------------------------------
        If Tare.Checked = True Then '不用设置标志，只保存皮重到皮重库
            pizhong.Text = tempweight
            pizhongshijian.Text = Now
            picao.Text = username
            piguo.Text = stationname


        End If

        '---------------------------------------------------------------------------------------------

        If Standard.Checked = True Then '有两种情况，一种车号来自皮重库，一种来自配对模式的主库，来自皮重的不互换重量，来自配对主库的则按照配对模式来过磅

            If zhupibiaozhi = True Then
                maozhong.Text = tempweight
                maozhongshijian.Text = Now
                jingzhong.Text = Val(maozhong.Text) - Val(pizhong.Text) - Val(xiangzhong.Text) - Val(xiangzhong2.Text)

                maocao.Text = username
                maoguo.Text = stationname

            Else

                If biaozhi = 0 Then
                    maozhong.Text = tempweight
                    maozhongshijian.Text = Now
                    maocao.Text = username
                    maoguo.Text = stationname
                    bangdanhao.Text = Val(Now.Year & Format(Now.Month, "00") & Format(Now.Day, "00") & Format(Now.Hour, "00") & Format(Now.Minute, "00") & Format(Now.Second, "00"))
                Else


                    If Val(maozhong.Text) < tempweight Then
                        pizhong.Text = Val(maozhong.Text)
                        picao.Text = maocao.Text
                        piguo.Text = maoguo.Text
                        pizhongshijian.Text = Trim(maozhongshijian.Text)



                        maozhong.Text = tempweight
                        maocao.Text = username
                        maoguo.Text = stationname
                        maozhongshijian.Text = Now




                    Else
                        pizhong.Text = tempweight
                        pizhongshijian.Text = Now
                        picao.Text = username
                        piguo.Text = stationname
                    End If

                    jingzhong.Text = Val(maozhong.Text) - Val(pizhong.Text) - Val(xiangzhong.Text) - Val(xiangzhong2.Text)


                End If

            End If



        End If


        '------------------------------------------------------------------------------------
        If Twice.Checked = True Then

            If biaozhi = 0 Then
                maozhong.Text = tempweight
                maozhongshijian.Text = Now
                maocao.Text = username
                maoguo.Text = stationname
                bangdanhao.Text = Val(Now.Year & Format(Now.Month, "00") & Format(Now.Day, "00") & Format(Now.Hour, "00") & Format(Now.Minute, "00") & Format(Now.Second, "00"))
            Else


                If Val(maozhong.Text) < tempweight Then
                    pizhong.Text = Val(maozhong.Text)
                    picao.Text = maocao.Text
                    piguo.Text = maoguo.Text
                    pizhongshijian.Text = Trim(maozhongshijian.Text)


                    maozhong.Text = tempweight
                    maocao.Text = username
                    maoguo.Text = stationname
                    maozhongshijian.Text = Now




                Else
                    pizhong.Text = tempweight
                    pizhongshijian.Text = Now
                    picao.Text = username
                    piguo.Text = stationname
                End If

                jingzhong.Text = Val(maozhong.Text) - Val(pizhong.Text) - Val(xiangzhong.Text) - Val(xiangzhong2.Text)



            End If
        End If





    End Sub
    Private Sub savemove()
        Dim objdataadapter As New SqlDataAdapter
        If Trim(huowuliuxiang.Text) = "移库发货" Then

            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnectionmove
            objdataadapter.SelectCommand.CommandText = "select * from trade where truckno='" & Trim(chehao.Text) & "' and ticketno='" & Trim(piaohao.Text) & "'"

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "move1")
            objdataview = New DataView(objdataset.Tables("move1"))

            Dim objcommandmove As New SqlCommand

            If objdataview.Count = 0 Then '要创建，在前部分

                objcommandmove.Connection = objconnectionmove
                objcommandmove.CommandText = "insert into trade (operator_tare_1,station_tare_1,truckno,contractno,product,specification,receiver,sender,shipname,transporter,pickupno,berth,amount,balanceno,ticketno,operator_gross_1,station_gross_1,gross,grossdatetime,tare,taredatetime,net,motorcade,motormen,done,finaldatetime) values ( @operator_tare_1,@operator_tare_1,@truckno,@contractno,@product,@specification,@receiver,@sender,@shipname,@transporter,@pickupno,@berth,@amount,@balanceno,@ticketno,@operator_gross_1,@station_gross_1,@gross,@grossdatetime,@tare,@taredatetime,@net,@motorcade,@motormen,@done,@finaldatetime)"
                objcommandmove.Parameters.AddWithValue("@truckno", Trim(chehao.Text))
                objcommandmove.Parameters.AddWithValue("@contractno", Trim(baojianhao.Text))
                objcommandmove.Parameters.AddWithValue("@product", Trim(huowuming.Text))
                objcommandmove.Parameters.AddWithValue("@specification", Trim(guige.Text))
                objcommandmove.Parameters.AddWithValue("@sender", Trim(fahuodanwei.Text))
                objcommandmove.Parameters.AddWithValue("@receiver", Trim(shenqingdanwei.Text))

                objcommandmove.Parameters.AddWithValue("@shipname", Trim(chuanming.Text))
                objcommandmove.Parameters.AddWithValue("@transporter", Trim(huowuliuxiang.Text))
                objcommandmove.Parameters.AddWithValue("@pickupno", Trim(tidanhao.Text))

                objcommandmove.Parameters.AddWithValue("@berth", Trim(bowei.Text))
                objcommandmove.Parameters.AddWithValue("@amount", Val(jianshu.Text))
                objcommandmove.Parameters.AddWithValue("@balanceno", Trim(bangdanhao.Text))
                objcommandmove.Parameters.AddWithValue("@ticketno", Trim(piaohao.Text))

                objcommandmove.Parameters.AddWithValue("@motorcade", Trim(yunshudanwei.Text))
                objcommandmove.Parameters.AddWithValue("@motormen", Trim(siji.Text))



                objcommandmove.Parameters.AddWithValue("@operator_gross_1", Trim(maocao.Text))
                objcommandmove.Parameters.AddWithValue("@operator_tare_1", Trim(picao.Text))

                objcommandmove.Parameters.AddWithValue("@station_gross_1", Trim(maoguo.Text))
                objcommandmove.Parameters.AddWithValue("@station_tare_1", Trim(piguo.Text))

                objcommandmove.Parameters.AddWithValue("@gross", Val(maozhong.Text))
                objcommandmove.Parameters.AddWithValue("@grossdatetime", Trim(maozhongshijian.Text))
                objcommandmove.Parameters.AddWithValue("@tare", Val(pizhong.Text))
                objcommandmove.Parameters.AddWithValue("@taredatetime", Trim(pizhongshijian.Text))
                objcommandmove.Parameters.AddWithValue("@net", Val(jingzhong.Text))
                objcommandmove.Parameters.AddWithValue("@finaldatetime", Now)

                objcommandmove.Parameters.AddWithValue("@done", Val(1))




                If objconnectionmove.State = ConnectionState.Closed Then
                    objconnectionmove.Open()
                End If
                objcommandmove.ExecuteNonQuery()
                objconnectionmove.Close()
                MessageBox.Show("创建前数据完毕！")

            Else '要更新，也在前部分
                objcommandmove.Connection = objconnectionmove
                objcommandmove.CommandText = "update trade set operator_gross_1=@operator_gross_1,operator_tare_1=@operator_tare_1,station_gross_1=@station_gross_1,station_tare_1=@station_tare_1,gross=@gross,grossdatetime=@grossdatetime,tare=@tare,taredatetime=@taredatetime,net=@net,done=@done where truckno='" & Trim(chehao.Text) & "' and ticketno='" & Trim(piaohao.Text) & "'"



                objcommandmove.Parameters.AddWithValue("@operator_gross_1", Trim(maocao.Text))
                objcommandmove.Parameters.AddWithValue("@operator_tare_1", Trim(picao.Text))

                objcommandmove.Parameters.AddWithValue("@station_gross_1", Trim(maoguo.Text))
                objcommandmove.Parameters.AddWithValue("@station_tare_1", Trim(piguo.Text))

                objcommandmove.Parameters.AddWithValue("@gross", Val(maozhong.Text))
                objcommandmove.Parameters.AddWithValue("@grossdatetime", Trim(maozhongshijian.Text))
                objcommandmove.Parameters.AddWithValue("@tare", Val(pizhong.Text))
                objcommandmove.Parameters.AddWithValue("@taredatetime", Trim(pizhongshijian.Text))
                objcommandmove.Parameters.AddWithValue("@net", Val(jingzhong.Text))
                objcommandmove.Parameters.AddWithValue("@finaldatetime", Now)
                objcommandmove.Parameters.AddWithValue("@done", Val(1))



                If objconnectionmove.State = ConnectionState.Closed Then
                    objconnectionmove.Open()
                End If
                objcommandmove.ExecuteNonQuery()
                objconnection.Close()
                MessageBox.Show("更新前数据完毕！")

            End If



        End If



        '-------------------------------------------------------------------------------------------------------


        If Trim(huowuliuxiang.Text) = "移库收货" Then

            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnectionmove
            objdataadapter.SelectCommand.CommandText = "select * from trade where truckno='" & Trim(chehao.Text) & "' and ticketno='" & Trim(piaohao.Text) & "'"

            If objconnectionmove.State = ConnectionState.Closed Then
                objconnectionmove.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "move2")
            objdataview = New DataView(objdataset.Tables("move2"))

            Dim objcommandmove As New SqlCommand
            objcommandmove.Connection = objconnectionmove


            If objdataview.Count = 0 Then  '创建数据并且保存在后半部分


                objcommandmove.CommandText = "insert into trade (operator_tare_2,station_tare_2,truckno,contractno,product,specification,receiver,sender,shipname,transporter,pickupno,berth,amount,balanceno,ticketno,operator_gross_2,station_gross_2,gross2,grossdatetime2,tare2,taredatetime2,net2,motorcade,motormen,done,finaldatetime2) values ( @operator_tare_2,@operator_tare_2,@truckno,@contractno,@product,@specification,@receiver,@sender,@shipname,@transporter,@pickupno,@berth,@amount,@balanceno,@ticketno,@operator_gross_2,@station_gross_2,@gross2,@grossdatetime2,@tare2,@taredatetime2,@net2,@motorcade,@motormen,@done,@finaldatetime2)"
                objcommandmove.Parameters.AddWithValue("@truckno", Trim(chehao.Text))
                objcommandmove.Parameters.AddWithValue("@contractno", Trim(baojianhao.Text))
                objcommandmove.Parameters.AddWithValue("@product", Trim(huowuming.Text))
                objcommandmove.Parameters.AddWithValue("@specification", Trim(guige.Text))
                objcommandmove.Parameters.AddWithValue("@sender", Trim(fahuodanwei.Text))
                objcommandmove.Parameters.AddWithValue("@receiver", Trim(shenqingdanwei.Text))

                objcommandmove.Parameters.AddWithValue("@shipname", Trim(chuanming.Text))
                objcommandmove.Parameters.AddWithValue("@transporter", Trim(huowuliuxiang.Text))
                objcommandmove.Parameters.AddWithValue("@pickupno", Trim(tidanhao.Text))

                objcommandmove.Parameters.AddWithValue("@berth", Trim(bowei.Text))
                objcommandmove.Parameters.AddWithValue("@amount", Val(jianshu.Text))
                objcommandmove.Parameters.AddWithValue("@balanceno", Trim(bangdanhao.Text))
                objcommandmove.Parameters.AddWithValue("@ticketno", Trim(piaohao.Text))

                objcommandmove.Parameters.AddWithValue("@motorcade", Trim(yunshudanwei.Text))
                objcommandmove.Parameters.AddWithValue("@motormen", Trim(siji.Text))



                objcommandmove.Parameters.AddWithValue("@operator_gross_2", Trim(maocao.Text))
                objcommandmove.Parameters.AddWithValue("@operator_tare_2", Trim(picao.Text))

                objcommandmove.Parameters.AddWithValue("@station_gross_2", Trim(maoguo.Text))
                objcommandmove.Parameters.AddWithValue("@station_tare_2", Trim(piguo.Text))

                objcommandmove.Parameters.AddWithValue("@gross2", Val(maozhong.Text))
                objcommandmove.Parameters.AddWithValue("@grossdatetime2", Trim(maozhongshijian.Text))
                objcommandmove.Parameters.AddWithValue("@tare2", Val(pizhong.Text))
                objcommandmove.Parameters.AddWithValue("@taredatetime2", Trim(pizhongshijian.Text))
                objcommandmove.Parameters.AddWithValue("@net2", Val(jingzhong.Text))
                objcommandmove.Parameters.AddWithValue("@finaldatetime2", Now)

                objcommandmove.Parameters.AddWithValue("@done", Val(1))




                If objconnectionmove.State = ConnectionState.Closed Then
                    objconnectionmove.Open()
                End If
                objcommandmove.ExecuteNonQuery()
                objconnectionmove.Close()
                MessageBox.Show("在数据库中没有发现关于提单号、车号相同的移库发货数据，所以将创建移库收货数据完成！")


            Else '更新且后半部分
                objcommandmove.Connection = objconnectionmove
                objcommandmove.CommandText = "update trade set operator_gross_2=@operator_gross_2,operator_tare_2=@operator_tare_2,station_gross_2=@station_gross_2,station_tare_2=@station_tare_2,gross2=@gross2,grossdatetime2=@grossdatetime2,tare2=@tare2,taredatetime2=@taredatetime2,net2=@net2,finaldatetime2=@finaldatetime2 where truckno='" & Trim(chehao.Text) & "' and ticketno='" & Trim(piaohao.Text) & "'"



                objcommandmove.Parameters.AddWithValue("@operator_gross_2", Trim(maocao.Text))
                objcommandmove.Parameters.AddWithValue("@operator_tare_2", Trim(picao.Text))

                objcommandmove.Parameters.AddWithValue("@station_gross_2", Trim(maoguo.Text))
                objcommandmove.Parameters.AddWithValue("@station_tare_2", Trim(piguo.Text))

                objcommandmove.Parameters.AddWithValue("@gross2", Val(maozhong.Text))
                objcommandmove.Parameters.AddWithValue("@grossdatetime2", Trim(maozhongshijian.Text))
                objcommandmove.Parameters.AddWithValue("@tare2", Val(pizhong.Text))
                objcommandmove.Parameters.AddWithValue("@taredatetime2", Trim(pizhongshijian.Text))
                objcommandmove.Parameters.AddWithValue("@net2", Val(jingzhong.Text))
                objcommandmove.Parameters.AddWithValue("@finaldatetime2", Now)




                If objconnectionmove.State = ConnectionState.Closed Then
                    objconnectionmove.Open()
                End If
                objcommandmove.ExecuteNonQuery()
                objconnectionmove.Close()
                MessageBox.Show("更新后数据完毕！")
            End If

        End If

        objconnectionmove.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Len(stationname) = 0 Then
            MessageBox.Show("单位不能为空! 请到 <其他设置> - <单位初始化>中设置一下")
            Exit Sub
        End If
    

        If Len(chehao.Text) = 0 Then
            MessageBox.Show("车号不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Exit Sub
        End If

        If Len(jianshu.Text) = 0 Then
            MessageBox.Show("件数不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If

        Button4.Enabled = False
        moni.Enabled = False


        If Standard.Checked = True Then

            If zhupibiaozhi = True Then '皮重库确实有，那么一次性保存完毕

                Dim objcommand As New SqlCommand

                objcommand.Connection = objconnection
                objcommand.CommandText = "insert into trade (containerweight,station,operator_tare,station_tare,truckno,contractno,product,specification,receiver,sender,shipname,transporter,pickupno,berth,amount,balanceno,ticketno,operator_gross,station_gross,gross,grossdatetime,tare,taredatetime,net,motorcade,motormen,done,finaldatetime,outtime,备注,motorcade2,containernum) values (@containerweight,@station, @operator_tare,@operator_tare,@truckno,@contractno,@product,@specification,@receiver,@sender,@shipname,@transporter,@pickupno,@berth,@amount,@balanceno,@ticketno,@operator_gross,@station_gross,@gross,@grossdatetime,@tare,@taredatetime,@net,@motorcade,@motormen,@done,@finaldatetime,@outtime,@备注,@motorcade2,@containernum)"
                objcommand.Parameters.AddWithValue("@truckno", Trim(chehao.Text))
                objcommand.Parameters.AddWithValue("@contractno", Trim(baojianhao.Text))
                objcommand.Parameters.AddWithValue("@product", Trim(huowuming.Text))
                objcommand.Parameters.AddWithValue("@specification", Trim(guige.Text))
                objcommand.Parameters.AddWithValue("@sender", Trim(fahuodanwei.Text))
                objcommand.Parameters.AddWithValue("@receiver", Trim(shenqingdanwei.Text))
                objcommand.Parameters.AddWithValue("@station", stationname)
                objcommand.Parameters.AddWithValue("@shipname", Trim(chuanming.Text))
                objcommand.Parameters.AddWithValue("@transporter", Trim(huowuliuxiang.Text))
                objcommand.Parameters.AddWithValue("@pickupno", Trim(tidanhao.Text))
                objcommand.Parameters.AddWithValue("@motorcade2", Trim(xianghao2.Text)) '箱号2
                objcommand.Parameters.AddWithValue("@containernum", Trim(xiangshu.Text)) '箱数
                objcommand.Parameters.AddWithValue("@containerweight", Val(xiangzhong.Text)) '箱重



                objcommand.Parameters.AddWithValue("@berth", Trim(bowei.Text))
                objcommand.Parameters.AddWithValue("@amount", Val(jianshu.Text))
                objcommand.Parameters.AddWithValue("@balanceno", Trim(bangdanhao.Text))
                objcommand.Parameters.AddWithValue("@ticketno", Trim(piaohao.Text))

                objcommand.Parameters.AddWithValue("@motorcade", Trim(yunshudanwei.Text))
                objcommand.Parameters.AddWithValue("@motormen", Trim(siji.Text))



                objcommand.Parameters.AddWithValue("@operator_gross", Trim(maocao.Text))
                objcommand.Parameters.AddWithValue("@operator_tare", Trim(picao.Text))

                objcommand.Parameters.AddWithValue("@station_gross", Trim(maoguo.Text))
                objcommand.Parameters.AddWithValue("@station_tare", Trim(piguo.Text))

                objcommand.Parameters.AddWithValue("@gross", Val(maozhong.Text))
                objcommand.Parameters.AddWithValue("@grossdatetime", Trim(maozhongshijian.Text))
                objcommand.Parameters.AddWithValue("@tare", Val(pizhong.Text))
                objcommand.Parameters.AddWithValue("@taredatetime", Trim(pizhongshijian.Text))
                objcommand.Parameters.AddWithValue("@net", Val(jingzhong.Text))
                objcommand.Parameters.AddWithValue("@finaldatetime", Now)
                objcommand.Parameters.AddWithValue("@outtime", Now)
                objcommand.Parameters.AddWithValue("@done", Val(1))
                objcommand.Parameters.AddWithValue("@备注", Trim(beizhu.Text))

                savemove()



                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objcommand.ExecuteNonQuery()
                objconnection.Close()
                MessageBox.Show("标准来自皮重库保存到总库完毕！")
                print_bangdan()

                '这块是要随时更新临时库信息
                objdataadapter.SelectCommand = New SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection
                objdataadapter.SelectCommand.CommandText = "select * from trade where done=0 order by id desc "
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "trade")
                objdataview = New DataView(objdataset.Tables("trade"))
                dgv.DataSource = objdataview

            Else



                If (biaozhi = 0) Then
                    Dim objcommand As New SqlCommand

                    objcommand.Connection = objconnection
                    objcommand.CommandText = "insert into trade (containerweight,motorcade,motormen,station,storehouse1,truckno,contractno,product,specification,receiver,sender,shipname,transporter,pickupno,berth,amount,balanceno,ticketno,operator_gross,station_gross,gross,grossdatetime,intime,备注,motorcade2,containernum) values (@containerweight,@motorcade,@motormen,@station, @storehouse1,@truckno,@contractno,@product,@specification,@receiver,@sender,@shipname,@transporter,@pickupno,@berth,@amount,@balanceno,@ticketno,@operator_gross,@station_gross,@gross,@grossdatetime,@intime,@备注,@motorcade2,@containernum)"
                    objcommand.Parameters.AddWithValue("@truckno", Trim(chehao.Text))
                    objcommand.Parameters.AddWithValue("@contractno", Trim(baojianhao.Text))

                    objcommand.Parameters.AddWithValue("@sender", Trim(fahuodanwei.Text))
                    objcommand.Parameters.AddWithValue("@receiver", Trim(shenqingdanwei.Text))

                    objcommand.Parameters.AddWithValue("@product", Trim(huowuming.Text))
                    objcommand.Parameters.AddWithValue("@specification", Trim(guige.Text))
                    objcommand.Parameters.AddWithValue("@shipname", Trim(chuanming.Text))
                    objcommand.Parameters.AddWithValue("@ticketno", Trim(piaohao.Text))
                    objcommand.Parameters.AddWithValue("@station", stationname)

                    objcommand.Parameters.AddWithValue("@transporter", Trim(huowuliuxiang.Text))
                    objcommand.Parameters.AddWithValue("@pickupno", Trim(tidanhao.Text))
                    objcommand.Parameters.AddWithValue("@motorcade", Trim(yunshudanwei.Text))
                    objcommand.Parameters.AddWithValue("@motorcade2", Trim(xianghao2.Text)) '箱号2
                    objcommand.Parameters.AddWithValue("@containernum", Trim(xiangshu.Text)) '箱数
                    objcommand.Parameters.AddWithValue("@containerweight", Val(xiangzhong.Text)) '箱重


                    objcommand.Parameters.AddWithValue("@motormen", Trim(siji.Text))
                    objcommand.Parameters.AddWithValue("@berth", Trim(bowei.Text))
                    objcommand.Parameters.AddWithValue("@amount", Val(jianshu.Text))
                    objcommand.Parameters.AddWithValue("@balanceno", Trim(bangdanhao.Text))

                    objcommand.Parameters.AddWithValue("@operator_gross", Trim(maocao.Text))
                    objcommand.Parameters.AddWithValue("@station_gross", Trim(maoguo.Text))
                    objcommand.Parameters.AddWithValue("@intime", Now)
                    objcommand.Parameters.AddWithValue("@备注", Trim(beizhu.Text))
                    If Trim(huowuliuxiang.Text) = "收货" Then
                        objcommand.Parameters.AddWithValue("@storehouse1", 0)
                    Else
                        objcommand.Parameters.AddWithValue("@storehouse1", 1)
                    End If

                    objcommand.Parameters.AddWithValue("@gross", Val(maozhong.Text))
                    objcommand.Parameters.AddWithValue("@grossdatetime", Trim(maozhongshijian.Text))
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objcommand.ExecuteNonQuery()
                    objconnection.Close()
                    MessageBox.Show("标准称重方式保存到临时库完成！")

                    '这块是要随时更新临时库信息
                    objdataadapter.SelectCommand = New SqlCommand
                    objdataadapter.SelectCommand.Connection = objconnection
                    objdataadapter.SelectCommand.CommandText = "select * from trade where done=0 order by id desc "
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataset = New DataSet
                    objdataadapter.Fill(objdataset, "trade")
                    objdataview = New DataView(objdataset.Tables("trade"))
                    dgv.DataSource = objdataview

                End If


                If biaozhi Then


                    If storehouse1.Text = "True" Then
                        Dim objcommand As New SqlCommand

                        objcommand.Connection = objconnection
                        objcommand.CommandText = "update trade set containerweight=@containerweight,amount=@amount,motorcade=@motorcade,motorcade2=@motorcade2,containernum=@containernum,motormen=@motormen,ticketno=@ticketno,shipname=@shipname,specification=@specification,product=@product,outtime=@outtime,sender=@sender,receiver=@receiver,operator_gross=@operator_gross,operator_tare=@operator_tare,station_gross=@station_gross,station_tare=@station_tare,gross=@gross,grossdatetime=@grossdatetime,tare=@tare,taredatetime=@taredatetime,net=@net,done=@done,备注=@备注 where id ='" & Trim(tradeno.Text) & "'"



                        objcommand.Parameters.AddWithValue("@operator_gross", Trim(maocao.Text))
                        objcommand.Parameters.AddWithValue("@operator_tare", Trim(picao.Text))
                        objcommand.Parameters.AddWithValue("@amount", Val(jianshu.Text))
                        objcommand.Parameters.AddWithValue("@station_gross", Trim(maoguo.Text))
                        objcommand.Parameters.AddWithValue("@station_tare", Trim(piguo.Text))
                        objcommand.Parameters.AddWithValue("@sender", Trim(fahuodanwei.Text))
                        objcommand.Parameters.AddWithValue("@receiver", Trim(shenqingdanwei.Text))
                        objcommand.Parameters.AddWithValue("@motorcade2", Trim(xianghao2.Text)) '箱号2
                        objcommand.Parameters.AddWithValue("@containernum", Trim(xiangshu.Text)) '箱数
                        objcommand.Parameters.AddWithValue("@containerweight", Val(xiangzhong.Text)) '箱重

                        objcommand.Parameters.AddWithValue("@product", Trim(huowuming.Text))
                        objcommand.Parameters.AddWithValue("@specification", Trim(guige.Text))
                        objcommand.Parameters.AddWithValue("@shipname", Trim(chuanming.Text))
                        objcommand.Parameters.AddWithValue("@ticketno", Trim(piaohao.Text))
                        objcommand.Parameters.AddWithValue("@motorcade", Trim(yunshudanwei.Text))
                        objcommand.Parameters.AddWithValue("@motormen", Trim(siji.Text))
                        objcommand.Parameters.AddWithValue("@gross", Trim(maozhong.Text))
                        objcommand.Parameters.AddWithValue("@grossdatetime", Trim(maozhongshijian.Text))
                        objcommand.Parameters.AddWithValue("@tare", Trim(pizhong.Text))
                        objcommand.Parameters.AddWithValue("@taredatetime", Trim(pizhongshijian.Text))
                        objcommand.Parameters.AddWithValue("@net", Trim(jingzhong.Text))
                        objcommand.Parameters.AddWithValue("@finaldatetime", Now)
                        objcommand.Parameters.AddWithValue("@outtime", Now)
                        objcommand.Parameters.AddWithValue("@done", Val(1))
                        objcommand.Parameters.AddWithValue("@备注", Trim(beizhu.Text))

                        savemove()

                        If objconnection.State = ConnectionState.Closed Then
                            objconnection.Open()
                        End If
                        objcommand.ExecuteNonQuery()
                        objconnection.Close()
                        MessageBox.Show("标准称重模式二次称重更新到总库完毕！")
                        print_bangdan()

                        '这块是要随时更新临时库信息
                        objdataadapter.SelectCommand = New SqlCommand
                        objdataadapter.SelectCommand.Connection = objconnection
                        objdataadapter.SelectCommand.CommandText = "select * from trade where done=0 order by id desc "
                        If objconnection.State = ConnectionState.Closed Then
                            objconnection.Open()
                        End If
                        objdataset = New DataSet
                        objdataadapter.Fill(objdataset, "trade")
                        objdataview = New DataView(objdataset.Tables("trade"))
                        dgv.DataSource = objdataview
                    Else

                        MessageBox.Show("库场没有对该笔进行接收确认!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If '库场是否接收的end





                End If '非zhupibiaozhi中第二次承重的end


            End If 'zhutibiaozhi的end



        End If '标准承重的end






        '-----------------------------------------------------------------------------------------------------------------------------------------------------------
        If Twice.Checked = True Then
            If (biaozhi = 0) Then
                Dim objcommand As New SqlCommand

                objcommand.Connection = objconnection
                objcommand.CommandText = "insert into trade (containerweight,motorcade,motormen,station,storehouse1,truckno,contractno,product,specification,receiver,sender,shipname,transporter,pickupno,berth,amount,balanceno,ticketno,operator_gross,station_gross,gross,grossdatetime,intime,备注,motorcade2,containernum) values (@containerweight, @motorcade,@motormen,@station,@storehouse1,@truckno,@contractno,@product,@specification,@receiver,@sender,@shipname,@transporter,@pickupno,@berth,@amount,@balanceno,@ticketno,@operator_gross,@station_gross,@gross,@grossdatetime,@intime,@备注,@motorcade2,@containernum)"
                objcommand.Parameters.AddWithValue("@truckno", Trim(chehao.Text))
                objcommand.Parameters.AddWithValue("@contractno", Trim(baojianhao.Text))
                objcommand.Parameters.AddWithValue("@product", Trim(huowuming.Text))
                objcommand.Parameters.AddWithValue("@specification", Trim(guige.Text))
                objcommand.Parameters.AddWithValue("@sender", Trim(fahuodanwei.Text))
                objcommand.Parameters.AddWithValue("@receiver", Trim(shenqingdanwei.Text))
                objcommand.Parameters.AddWithValue("@station", stationname)
                objcommand.Parameters.AddWithValue("@shipname", Trim(chuanming.Text))
                objcommand.Parameters.AddWithValue("@transporter", Trim(huowuliuxiang.Text))
                objcommand.Parameters.AddWithValue("@pickupno", Trim(tidanhao.Text))
                objcommand.Parameters.AddWithValue("@motorcade", Trim(yunshudanwei.Text))
                objcommand.Parameters.AddWithValue("@motorcade2", Trim(xianghao2.Text)) '箱号2
                objcommand.Parameters.AddWithValue("@containernum", Trim(xiangshu.Text)) '箱数
                objcommand.Parameters.AddWithValue("@containerweight", Val(xiangzhong.Text)) '箱重
                objcommand.Parameters.AddWithValue("@motormen", Trim(siji.Text))
                objcommand.Parameters.AddWithValue("@berth", Trim(bowei.Text))
                objcommand.Parameters.AddWithValue("@amount", Val(jianshu.Text))
                objcommand.Parameters.AddWithValue("@balanceno", Trim(bangdanhao.Text))
                objcommand.Parameters.AddWithValue("@ticketno", Trim(piaohao.Text))
                objcommand.Parameters.AddWithValue("@operator_gross", Trim(maocao.Text))
                objcommand.Parameters.AddWithValue("@station_gross", Trim(maoguo.Text))
                objcommand.Parameters.AddWithValue("@intime", Now)
                objcommand.Parameters.AddWithValue("@备注", Trim(beizhu.Text))
                If huowuliuxiang.Text = "收货" Then
                    objcommand.Parameters.AddWithValue("@storehouse1", 0)
                Else
                    objcommand.Parameters.AddWithValue("@storehouse1", 1)
                End If
                objcommand.Parameters.AddWithValue("@gross", Val(maozhong.Text))
                objcommand.Parameters.AddWithValue("@grossdatetime", Trim(maozhongshijian.Text))
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objcommand.ExecuteNonQuery()
                objconnection.Close()
                MessageBox.Show("配对保存到临时库完毕！")
                '这块是要随时更新临时库信息
                objdataadapter.SelectCommand = New SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection
                objdataadapter.SelectCommand.CommandText = "select * from trade where done=0 order by id desc "
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "trade")
                objdataview = New DataView(objdataset.Tables("trade"))
                dgv.DataSource = objdataview
            End If


            If biaozhi Then
                If storehouse1.Text = "True" Then
                    Dim objcommand As New SqlCommand

                    objcommand.Connection = objconnection
                    objcommand.CommandText = "update trade set containerweight=@containerweight,containernum=@containernum,amount=@amount,motormen=@motormen,motorcade2=@motorcade2,motorcade=@motorcade,ticketno=@ticketno,shipname=@shipname,specification=@specification,product=@product,outtime=@outtime,sender=@sender,receiver=@receiver,operator_gross=@operator_gross,operator_tare=@operator_tare,station_gross=@station_gross,station_tare=@station_tare,gross=@gross,grossdatetime=@grossdatetime,tare=@tare,taredatetime=@taredatetime,net=@net,done=@done,备注=@备注 where id ='" & Trim(tradeno.Text) & "'"



                    objcommand.Parameters.AddWithValue("@operator_gross", Trim(maocao.Text))
                    objcommand.Parameters.AddWithValue("@operator_tare", Trim(picao.Text))
                    objcommand.Parameters.AddWithValue("@amount", Val(jianshu.Text))
                    objcommand.Parameters.AddWithValue("@sender", Trim(fahuodanwei.Text))
                    objcommand.Parameters.AddWithValue("@receiver", Trim(shenqingdanwei.Text))
                    objcommand.Parameters.AddWithValue("@station_gross", Trim(maoguo.Text))
                    objcommand.Parameters.AddWithValue("@station_tare", Trim(piguo.Text))
                    objcommand.Parameters.AddWithValue("@product", Trim(huowuming.Text))
                    objcommand.Parameters.AddWithValue("@specification", Trim(guige.Text))
                    objcommand.Parameters.AddWithValue("@shipname", Trim(chuanming.Text))
                    objcommand.Parameters.AddWithValue("@ticketno", Trim(piaohao.Text))
                    objcommand.Parameters.AddWithValue("@gross", Val(maozhong.Text))
                    objcommand.Parameters.AddWithValue("@grossdatetime", Trim(maozhongshijian.Text))
                    objcommand.Parameters.AddWithValue("@tare", Val(pizhong.Text))
                    objcommand.Parameters.AddWithValue("@taredatetime", Trim(pizhongshijian.Text))
                    objcommand.Parameters.AddWithValue("@net", Val(jingzhong.Text))
                    objcommand.Parameters.AddWithValue("@finaldatetime", Now)
                    objcommand.Parameters.AddWithValue("@outtime", Now)
                    objcommand.Parameters.AddWithValue("@done", Val(1))
                    objcommand.Parameters.AddWithValue("@motorcade", Trim(yunshudanwei.Text))
                    objcommand.Parameters.AddWithValue("@motorcade2", Trim(xianghao2.Text)) '箱号2
                    objcommand.Parameters.AddWithValue("@containernum", Trim(xiangshu.Text)) '箱数
                    objcommand.Parameters.AddWithValue("@containerweight", Val(xiangzhong.Text)) '箱重

                    objcommand.Parameters.AddWithValue("@motormen", Trim(siji.Text))

                    objcommand.Parameters.AddWithValue("@备注", Trim(beizhu.Text))

                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objcommand.ExecuteNonQuery()
                    objconnection.Close()
                    savemove()
                    MessageBox.Show("配对保存到总库完毕！")
                    print_bangdan()


                    '这块是要随时更新临时库信息
                    objdataadapter.SelectCommand = New SqlCommand
                    objdataadapter.SelectCommand.Connection = objconnection
                    objdataadapter.SelectCommand.CommandText = "select * from trade where done=0 order by id desc "
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataset = New DataSet
                    objdataadapter.Fill(objdataset, "trade")
                    objdataview = New DataView(objdataset.Tables("trade"))
                    dgv.DataSource = objdataview

                Else
                    MessageBox.Show("库场没有对该笔进行接收确认!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If '库场是否确认的end


            End If 'biaozhi的end



        End If 'twice的end



        '----------------------------------------------------------------------------------
        If Tare.Checked = True Then


            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from trucklist where truckno='" & Trim(chehao.Text) & "'"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "tare")
            objdataview = New DataView(objdataset.Tables("tare"))
            If objdataview.Count = 0 Then
                Dim objcommand As New SqlCommand

                objcommand.Connection = objconnection
                objcommand.CommandText = "insert into trucklist (truckno,tare,outtime,station_tare,operator_tare) values ( @truckno,@tare,@outtime,@station_tare,@operator_tare)"
                objcommand.Parameters.AddWithValue("@truckno", Trim(chehao.Text))
                objcommand.Parameters.AddWithValue("@tare", Val(pizhong.Text))
                objcommand.Parameters.AddWithValue("@outtime", Now)

                objcommand.Parameters.AddWithValue("@station_tare", Trim(piguo.Text))
                objcommand.Parameters.AddWithValue("@operator_tare", Trim(picao.Text))

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objcommand.ExecuteNonQuery()
                objconnection.Close()
                MessageBox.Show("保存到皮重库完毕！")

            Else

                Dim objcommand As New SqlCommand

                objcommand.Connection = objconnection
                objcommand.CommandText = "update trucklist set outtime=@outtime,truckno=@truckno,tare=@tare,station_tare=@station_tare,operator_tare=@operator_tare where truckno='" & Trim(chehao.Text) & "'"
                objcommand.Parameters.AddWithValue("@truckno", Trim(chehao.Text))
                objcommand.Parameters.AddWithValue("@tare", Val(pizhong.Text))
                objcommand.Parameters.AddWithValue("@outtime", Now)

                objcommand.Parameters.AddWithValue("@station_tare", Trim(piguo.Text))
                objcommand.Parameters.AddWithValue("@operator_tare", Trim(picao.Text))
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objcommand.ExecuteNonQuery()
                objconnection.Close()
                MessageBox.Show("更新到皮重库完毕！")

            End If
            '这块是要随时更新临时库信息
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from trade where done=0 order by id desc "
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "trade")
            objdataview = New DataView(objdataset.Tables("trade"))
            dgv.DataSource = objdataview

        End If


        '-------------------------------------------------------------------------------------------------------------------------------------------
        If Manual.Checked = True Then


            Dim objcommand As New SqlCommand

            objcommand.Connection = objconnection
            objcommand.CommandText = "insert into trade (containerweight,containernum,tare,taredatetime,net,done,motorcade,motormen,station,truckno,contractno,product,specification,receiver,sender,shipname,transporter,pickupno,berth,amount,balanceno,ticketno,operator_gross,station_gross,operator_tare,station_tare,gross,grossdatetime,outtime,备注,motorcade2) values (@containerweight,@containernum,@tare,@taredatetime,@net,@done,@motorcade,@motormen,@station, @truckno,@contractno,@product,@specification,@receiver,@sender,@shipname,@transporter,@pickupno,@berth,@amount,@balanceno,@ticketno,@operator_gross,@station_gross,@operator_tare,@station_tare,@gross,@grossdatetime,@outtime,@备注,@motorcade2)"
            objcommand.Parameters.AddWithValue("@truckno", Trim(chehao.Text))
            objcommand.Parameters.AddWithValue("@contractno", Trim(baojianhao.Text))
            objcommand.Parameters.AddWithValue("@product", Trim(huowuming.Text))
            objcommand.Parameters.AddWithValue("@specification", Trim(guige.Text))
            objcommand.Parameters.AddWithValue("@sender", Trim(fahuodanwei.Text))
            objcommand.Parameters.AddWithValue("@receiver", Trim(shenqingdanwei.Text))
            objcommand.Parameters.AddWithValue("@station", stationname)
            objcommand.Parameters.AddWithValue("@shipname", Trim(chuanming.Text))
            objcommand.Parameters.AddWithValue("@transporter", Trim(huowuliuxiang.Text))
            objcommand.Parameters.AddWithValue("@pickupno", Trim(tidanhao.Text))

            objcommand.Parameters.AddWithValue("@berth", Trim(bowei.Text))
            objcommand.Parameters.AddWithValue("@amount", Val(jianshu.Text))
            objcommand.Parameters.AddWithValue("@balanceno", Trim(bangdanhao.Text))
            objcommand.Parameters.AddWithValue("@ticketno", Trim(piaohao.Text))
            objcommand.Parameters.AddWithValue("@motorcade2", Trim(xianghao2.Text)) '箱号2
            objcommand.Parameters.AddWithValue("@containernum", Val(xiangshu.Text)) '箱数
            objcommand.Parameters.AddWithValue("@containerweight", Val(xiangzhong.Text)) '箱重
            objcommand.Parameters.AddWithValue("@motorcade", Trim(yunshudanwei.Text))
            objcommand.Parameters.AddWithValue("@motormen", Trim(siji.Text))


            objcommand.Parameters.AddWithValue("@operator_gross", Trim(maocao.Text))
            objcommand.Parameters.AddWithValue("@operator_tare", Trim(picao.Text))

            objcommand.Parameters.AddWithValue("@station_gross", Trim(maoguo.Text))
            objcommand.Parameters.AddWithValue("@station_tare", Trim(piguo.Text))

            objcommand.Parameters.AddWithValue("@gross", Val(maozhong.Text))

            objcommand.Parameters.AddWithValue("@grossdatetime", Trim(maozhongshijian.Text))

            objcommand.Parameters.AddWithValue("@tare", Val(pizhong.Text))
            objcommand.Parameters.AddWithValue("@taredatetime", Trim(pizhongshijian.Text))
            objcommand.Parameters.AddWithValue("@net", Val(jingzhong.Text))


            objcommand.Parameters.AddWithValue("@finaldatetime", Now)
            objcommand.Parameters.AddWithValue("@outtime", Now)
            objcommand.Parameters.AddWithValue("@done", Val(1))
            objcommand.Parameters.AddWithValue("@备注", Trim(beizhu.Text))
            savemove()


            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objcommand.ExecuteNonQuery()
            objconnection.Close()
            MessageBox.Show("手工保存到主库完毕！")
            print_bangdan()
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from trade where done=0 order by id desc "
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "trade")
            objdataview = New DataView(objdataset.Tables("trade"))

            dgv.DataSource = objdataview

        End If

        savetxt()
        addtxt()
        ClearTextBox(Me.GroupBox3.Controls)
    End Sub

    Private Sub chehao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chehao.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub





    Private Sub chehao_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chehao.LostFocus
        On Error Resume Next
        If czfs = False Then
            MessageBox.Show("请先选择承重方式再填写数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        pizhong.Text = ""

        bangdanhao.Text = Val(Now.Year & Format(Now.Month, "00") & Format(Now.Day, "00") & Format(Now.Hour, "00") & Format(Now.Minute, "00") & Format(Now.Second, "00"))
        '-------------------------------------------------------------------------------------------
        If Standard.Checked = True Then

            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from trucklist where truckno='" & Trim(chehao.Text) & "'"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "trucklist")
            objdataview = New DataView(objdataset.Tables("trucklist"))
            'On Error Resume Next

            If objdataview.Count = 0 Then
                zhupibiaozhi = False '采用标准读皮


                objdataadapter.SelectCommand = New SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection
                objdataadapter.SelectCommand.CommandText = "select * from trade where done=0 and truckno='" & Trim(chehao.Text) & "'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "trucklist")
                objdataview = New DataView(objdataset.Tables("trucklist"))

                If objdataview.Count = 1 Then '说明主库有数据
                    Dim objdatareader As SqlClient.SqlDataReader

                    objdatareader = objdataadapter.SelectCommand.ExecuteReader
                    While objdatareader.Read

                        chehao.Text = Trim(objdatareader.Item("truckno"))

                        baojianhao.Text = Trim(objdatareader.Item("contractno"))
                        huowuming.Text = Trim(objdatareader.Item("product"))
                        guige.Text = Trim(objdatareader.Item("specification"))
                        shenqingdanwei.Text = Trim(objdatareader.Item("receiver"))
                        fahuodanwei.Text = Trim(objdatareader.Item("sender"))
                        chuanming.Text = Trim(objdatareader.Item("shipname"))
                        huowuliuxiang.Text = Trim(objdatareader.Item("transporter"))
                        tidanhao.Text = Trim(objdatareader.Item("pickupno"))
                        bowei.Text = Trim(objdatareader.Item("berth"))

                        yunshudanwei.Text = Trim(objdatareader.Item("motorcade"))
                        xianghao2.Text = Trim(objdatareader.Item("motorcade2"))
                        xiangshu.Text = Trim(objdatareader.Item("containernum"))
                        xiangzhong.Text = Trim(objdatareader.Item("containerweight"))
                        siji.Text = Trim(objdatareader.Item("motormen"))
                        storehouse1.Text = Trim(objdatareader.Item("storehouse1"))

                        maozhong.Text = (objdatareader.Item("gross"))
                        maozhongshijian.Text = objdatareader.Item("grossdatetime")

                        'pizhong.Text = Trim(objdatareader.Item("tare"))
                        'pizhongshijian.Text = objdatareader.Item("taredatetime")
                        'jingzhong.Text = (objdatareader.Item("net"))

                        jianshu.Text = (objdatareader.Item("amount"))
                        bangdanhao.Text = Trim(objdatareader.Item("balanceno"))
                        piaohao.Text = Trim(objdatareader.Item("ticketno"))
                        beizhu.Text = Trim(objdatareader.Item("备注"))

                        maocao.Text = Trim(objdatareader.Item("operator_gross"))
                        picao.Text = Trim(objdatareader.Item("operator_tare"))
                        maoguo.Text = Trim(objdatareader.Item("station_gross"))
                        piguo.Text = Trim(objdatareader.Item("station_tare"))
                        tradeno.Text = (objdatareader.Item("id"))
                        time1.Text = DateDiff("n", objdatareader.Item("intime"), objdatareader.Item("outtime"))
                        time2.Text = 0
                        If huowuliuxiang.Text = "收货" Then
                            time2.Text = DateDiff("n", objdatareader.Item("storehouse1time"), objdatareader.Item("outtime"))
                        End If





                        biaozhi = 1
                    End While
                    objdatareader.Close()
                Else
                    biaozhi = 0


                End If




            Else '皮重库有值

                zhupibiaozhi = True '采用读皮重库
                Dim objdatareader As SqlClient.SqlDataReader

                objdatareader = objdataadapter.SelectCommand.ExecuteReader
                While objdatareader.Read
                    pizhong.Text = Trim(objdatareader.Item("tare"))
                    pizhongshijian.Text = objdatareader.Item("outtime")
                    picao.Text = Trim(objdatareader.Item("operator_tare"))

                    piguo.Text = Trim(objdatareader.Item("station_tare"))

                End While
                objdatareader.Close()

            End If


        End If




        If Tare.Checked = True Then

            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from trucklist where truckno='" & Trim(chehao.Text) & "'"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "trucklist")
            objdataview = New DataView(objdataset.Tables("trucklist"))
            'On Error Resume Next

            If objdataview.Count = 1 Then '如果已经创建了该笔说明是未完成记录
                Dim objdatareader As SqlClient.SqlDataReader

                objdatareader = objdataadapter.SelectCommand.ExecuteReader

                While objdatareader.Read

                    pizhong.Text = Trim(objdatareader.Item("tare"))
                    picao.Text = Trim(objdatareader.Item("operator_tare"))
                    pizhongshijian.Text = objdatareader.Item("outtime")
                    piguo.Text = Trim(objdatareader.Item("station_tare"))

                End While
                objdatareader.Close()



            End If
        End If









        If Twice.Checked = True Then '配对车号查询方式
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from trade where done=0 and truckno='" & Trim(chehao.Text) & "'"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "trade")
            objdataview = New DataView(objdataset.Tables("trade"))
            'On Error Resume Next

            If objdataview.Count = 1 Then '如果已经创建了该笔说明是未完成记录
                Dim objdatareader As SqlClient.SqlDataReader

                objdatareader = objdataadapter.SelectCommand.ExecuteReader

                While objdatareader.Read

                    chehao.Text = Trim(objdatareader.Item("truckno"))


                    yunshudanwei.Text = Trim(objdatareader.Item("motorcade"))
                    xianghao2.Text = Trim(objdatareader.Item("motorcade2"))
                    siji.Text = Trim(objdatareader.Item("motormen"))
                    xiangshu.Text = Trim(objdatareader.Item("containernum"))
                    xiangzhong.Text = Trim(objdatareader.Item("containerweight"))
                    baojianhao.Text = Trim(objdatareader.Item("contractno"))
                    huowuming.Text = Trim(objdatareader.Item("product"))
                    guige.Text = Trim(objdatareader.Item("specification"))
                    shenqingdanwei.Text = Trim(objdatareader.Item("receiver"))
                    fahuodanwei.Text = Trim(objdatareader.Item("sender"))
                    chuanming.Text = Trim(objdatareader.Item("shipname"))
                    huowuliuxiang.Text = Trim(objdatareader.Item("transporter"))
                    tidanhao.Text = Trim(objdatareader.Item("pickupno"))
                    bowei.Text = Trim(objdatareader.Item("berth"))

                    beizhu.Text = Trim(objdatareader.Item("备注"))
                    maozhong.Text = (objdatareader.Item("gross"))
                    maozhongshijian.Text = objdatareader.Item("grossdatetime")

                    storehouse1.Text = Trim(objdatareader.Item("storehouse1"))
                    'pizhong.Text = Trim(objdatareader.Item("tare"))
                    'pizhongshijian.Text = objdatareader.Item("taredatetime")
                    'jingzhong.Text = (objdatareader.Item("net"))

                    jianshu.Text = (objdatareader.Item("amount"))
                    bangdanhao.Text = Trim(objdatareader.Item("balanceno"))
                    piaohao.Text = Trim(objdatareader.Item("ticketno"))


                    maocao.Text = Trim(objdatareader.Item("operator_gross"))
                    picao.Text = Trim(objdatareader.Item("operator_tare"))
                    maoguo.Text = Trim(objdatareader.Item("station_gross"))
                    piguo.Text = Trim(objdatareader.Item("station_tare"))
                    tradeno.Text = (objdatareader.Item("id"))

                    time1.Text = DateDiff("n", objdatareader.Item("intime"), Now)
                    time2.Text = 0
                    If huowuliuxiang.Text = "收货" Then
                        time2.Text = DateDiff("n", objdatareader.Item("storehouse1time"), Now)
                    End If


                    biaozhi = 1
                End While
                objdatareader.Close()
            Else
                '如果没有找到该车的未完成记录就说明第一次过磅
                biaozhi = 0


            End If


            objconnection.Close()


        End If


    End Sub




    Private Sub print_bangdan()
        Dim oRpt As New bangdan


        Dim stra As TextObject



        stra = oRpt.ReportDefinition.ReportObjects.Item("fhdw")
        stra.Text = fahuodanwei.Text.ToString

        stra = oRpt.ReportDefinition.ReportObjects.Item("shdw")
        stra.Text = shenqingdanwei.Text.ToString




        stra = oRpt.ReportDefinition.ReportObjects.Item("pm")
        stra.Text = huowuming.Text.ToString
        stra = oRpt.ReportDefinition.ReportObjects.Item("ph")
        stra.Text = piaohao.Text.ToString

        If maozhongshijian.Text > pizhongshijian.Text Then
            stra = oRpt.ReportDefinition.ReportObjects.Item("rcsj")
            stra.Text = pizhongshijian.Text.ToString
            stra = oRpt.ReportDefinition.ReportObjects.Item("ccsj")
            stra.Text = maozhongshijian.Text.ToString

        Else
            stra = oRpt.ReportDefinition.ReportObjects.Item("ccsj")
            stra.Text = pizhongshijian.Text.ToString
            stra = oRpt.ReportDefinition.ReportObjects.Item("rcsj")
            stra.Text = maozhongshijian.Text.ToString
        End If


        stra = oRpt.ReportDefinition.ReportObjects.Item("mzsby")
        stra.Text = maocao.Text.ToString

        stra = oRpt.ReportDefinition.ReportObjects.Item("pzsby")
        stra.Text = picao.Text.ToString


        stra = oRpt.ReportDefinition.ReportObjects.Item("mzgbd")
        stra.Text = maoguo.Text.ToString

        stra = oRpt.ReportDefinition.ReportObjects.Item("pzgbd")
        stra.Text = piguo.Text.ToString



        stra = oRpt.ReportDefinition.ReportObjects.Item("bdh")
        stra.Text = bangdanhao.Text.ToString
        stra = oRpt.ReportDefinition.ReportObjects.Item("ch")
        stra.Text = chehao.Text.ToString

        stra = oRpt.ReportDefinition.ReportObjects.Item("mz")
        stra.Text = maozhong.Text.ToString
        stra = oRpt.ReportDefinition.ReportObjects.Item("pz")
        stra.Text = pizhong.Text.ToString
        stra = oRpt.ReportDefinition.ReportObjects.Item("jz")
        stra.Text = jingzhong.Text.ToString

        stra = oRpt.ReportDefinition.ReportObjects.Item("js")
        stra.Text = jianshu.Text.ToString


        stra = oRpt.ReportDefinition.ReportObjects.Item("bdhm")
        stra.Text = stationname

        stra = oRpt.ReportDefinition.ReportObjects.Item("beizhu")
        stra.Text = beizhu.Text

        stra = oRpt.ReportDefinition.ReportObjects.Item("gh")
        stra.Text = siji.Text

        stra = oRpt.ReportDefinition.ReportObjects.Item("jzxh")
        stra.Text = yunshudanwei.Text

        stra = oRpt.ReportDefinition.ReportObjects.Item("jzxh2")
        stra.Text = xianghao2.Text

        stra = oRpt.ReportDefinition.ReportObjects.Item("xs")
        stra.Text = xiangshu.Text

        stra = oRpt.ReportDefinition.ReportObjects.Item("xz")
        stra.Text = xiangzhong.Text

        ReportView.Show()
        ReportView.CrystalReportViewer1.ReportSource = oRpt





    End Sub



    Private Sub Manual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Manual.CheckedChanged
        czfs = True '承重方式已经选择
        Dim tempchehao As String
        tempchehao = chehao.Text
        ClearTextBox(Me.GroupBox3.Controls)
        chehao.Text = Trim(tempchehao)
        chehao_LostFocus(sender, e)


        If Manual.Checked = True Then
            pizhong.ReadOnly = False
            'maozhong.ReadOnly = False
            maocao.Text = username
            picao.Text = username
            maozhongshijian.Text = Now
            pizhongshijian.Text = Now
            Button4.Enabled = True
        End If

    End Sub


    Private Sub Tare_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tare.CheckedChanged
        czfs = True
        Dim tempchehao As String
        tempchehao = chehao.Text
        ClearTextBox(Me.GroupBox3.Controls)
        chehao.Text = Trim(tempchehao)
        chehao_LostFocus(sender, e)
        If Manual.Checked = False Then
            Button4.Enabled = False
            pizhong.ReadOnly = True
            maozhong.ReadOnly = True
        End If

    End Sub



    Private Sub Twice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Twice.CheckedChanged
        czfs = True
        Dim tempchehao As String
        tempchehao = chehao.Text
        'ClearTextBox(Me.GroupBox3.Controls)
        chehao.Text = Trim(tempchehao)
        chehao_LostFocus(sender, e)
        If Manual.Checked = False Then
            Button4.Enabled = False
            pizhong.ReadOnly = True
            maozhong.ReadOnly = True
        End If
    End Sub

    Private Sub Standard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Standard.CheckedChanged
        Dim tempchehao As String
        tempchehao = chehao.Text
        ' ClearTextBox(Me.GroupBox3.Controls)
        chehao.Text = Trim(tempchehao)
        ' chehao_LostFocus(sender, e)
        czfs = True
        If Manual.Checked = False Then
            Button4.Enabled = False
            pizhong.ReadOnly = True
            maozhong.ReadOnly = True
        End If
    End Sub

    Private Sub pizhong_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pizhong.TextChanged
        If Manual.Checked = True Then
            jingzhong.Text = Val(maozhong.Text) - Val(pizhong.Text) - Val(xiangzhong.Text) - Val(xiangzhong2.Text)
            pizhongshijian.Text = Now

        End If
    End Sub




    Private Sub piaohao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles piaohao.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub piaohao_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles piaohao.LostFocus
        ' Dim objdataadapter As New SqlDataAdapter
        If huowuliuxiang.Text = "移库收货" Then


            '分两种，一种本地过皮，一种本地过重
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from trade where done=0 and ticketno='" & Trim(piaohao.Text) & "'"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "trade")
            objdataview = New DataView(objdataset.Tables("trade"))




            If objdataview.Count = 0 Then '本地库没有皮重就采用移库基础数据
                biaozhi = 0





                objdataadapter.SelectCommand = New SqlCommand
                objdataadapter.SelectCommand.Connection = objconnectionmove

                objdataadapter.SelectCommand.CommandText = "select * from trade where ticketno='" & Trim(piaohao.Text) & "'"
                If objconnectionmove.State = ConnectionState.Closed Then
                    objconnectionmove.Open()
                End If


                objdatareader = objdataadapter.SelectCommand.ExecuteReader

                If objdatareader.HasRows Then
                    While objdatareader.Read

                        chehao.Text = Trim(objdatareader.Item("truckno"))



                        yunshudanwei.Text = Trim(objdatareader.Item("motorcade"))
                        siji.Text = Trim(objdatareader.Item("motormen"))

                        huowuming.Text = Trim(objdatareader.Item("product"))
                        guige.Text = Trim(objdatareader.Item("specification"))
                        shenqingdanwei.Text = Trim(objdatareader.Item("receiver"))
                        fahuodanwei.Text = Trim(objdatareader.Item("sender"))

                        ' huowuliuxiang.Text = Trim(objdatareader.Item("transporter"))


                    End While
                End If


                objdatareader.Close()

            Else '本地库有数据就用本地的



                Dim objdatareader As SqlClient.SqlDataReader

                objdatareader = objdataadapter.SelectCommand.ExecuteReader

                While objdatareader.Read

                    chehao.Text = Trim(objdatareader.Item("truckno"))


                    yunshudanwei.Text = Trim(objdatareader.Item("motorcade"))
                    xianghao2.Text = Trim(objdatareader.Item("motorcade2"))
                    siji.Text = Trim(objdatareader.Item("motormen"))
                    xiangshu.Text = Trim(objdatareader.Item("containernum"))
                    xiangzhong.Text = Trim(objdatareader.Item("containerweight"))
                    baojianhao.Text = Trim(objdatareader.Item("contractno"))
                    huowuming.Text = Trim(objdatareader.Item("product"))
                    guige.Text = Trim(objdatareader.Item("specification"))
                    shenqingdanwei.Text = Trim(objdatareader.Item("receiver"))
                    fahuodanwei.Text = Trim(objdatareader.Item("sender"))
                    chuanming.Text = Trim(objdatareader.Item("shipname"))
                    huowuliuxiang.Text = Trim(objdatareader.Item("transporter"))
                    tidanhao.Text = Trim(objdatareader.Item("pickupno"))
                    bowei.Text = Trim(objdatareader.Item("berth"))

                    beizhu.Text = Trim(objdatareader.Item("备注"))
                    maozhong.Text = (objdatareader.Item("gross"))
                    maozhongshijian.Text = objdatareader.Item("grossdatetime")

                    storehouse1.Text = Trim(objdatareader.Item("storehouse1"))
                    'pizhong.Text = Trim(objdatareader.Item("tare"))
                    'pizhongshijian.Text = objdatareader.Item("taredatetime")
                    'jingzhong.Text = (objdatareader.Item("net"))

                    jianshu.Text = (objdatareader.Item("amount"))
                    bangdanhao.Text = Trim(objdatareader.Item("balanceno"))
                    piaohao.Text = Trim(objdatareader.Item("ticketno"))


                    maocao.Text = Trim(objdatareader.Item("operator_gross"))
                    picao.Text = Trim(objdatareader.Item("operator_tare"))
                    maoguo.Text = Trim(objdatareader.Item("station_gross"))
                    piguo.Text = Trim(objdatareader.Item("station_tare"))
                    tradeno.Text = (objdatareader.Item("id"))

                    time1.Text = DateDiff("n", objdatareader.Item("intime"), Now)
                    time2.Text = 0
                    If huowuliuxiang.Text = "收货" Then
                        time2.Text = DateDiff("n", objdatareader.Item("storehouse1time"), Now)
                    End If


                    biaozhi = 1
                End While
                objdatareader.Close()
                biaozhi = 1
            End If


















        End If


    End Sub



   




    Private Sub baojianhao_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles baojianhao.LostFocus
        On Error Resume Next
        Dim objdatareader As SqlClient.SqlDataReader

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from baojianhaolist where 报检号='" & Trim(baojianhao.Text) & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If

        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "baojianhaolist")
        objdataview = New DataView(objdataset.Tables("baojianhaolist"))




        If objdataview.Count = 1 Then '说明主库有数据


            objdatareader = objdataadapter.SelectCommand.ExecuteReader
            While objdatareader.Read

                tidanhao.Text = Trim(objdatareader.Item("提单号"))
                bowei.Text = Trim(objdatareader.Item("泊位"))
                chuanming.Text = Trim(objdatareader.Item("船名"))
                huowuming.Text = Trim(objdatareader.Item("货物名"))
                guige.Text = Trim(objdatareader.Item("规格"))
                shenqingdanwei.Text = Trim(objdatareader.Item("申请单位"))
                fahuodanwei.Text = Trim(objdatareader.Item("发货单位"))
                yunshudanwei.Text = Trim(objdatareader.Item("运输单位"))
                siji.Text = Trim(objdatareader.Item("司机"))





            End While
            objdatareader.Close()
        Else
            'MessageBox.Show("没有符合的报检号记录或者报检号有重复", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If





    End Sub





    Private Sub huowuming_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles huowuming.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub


    Private Sub guige_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles guige.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub chuanming_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles shenqingdanwei.KeyDown, fahuodanwei.KeyDown, chuanming.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub siji_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles yunshudanwei.KeyDown, tidanhao.KeyDown, siji.KeyDown, jianshu.KeyDown, bowei.KeyDown, bangdanhao.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If sp.IsOpen Then
            sp.DiscardInBuffer()
            sp.Close()

        End If
        Me.Close()
    End Sub



    Private Sub Simple_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Simple.CheckedChanged
        czfs = True
        If Manual.Checked = False Then
            Button4.Enabled = False
            pizhong.ReadOnly = True
            maozhong.ReadOnly = True
        End If
    End Sub

    Private Sub 磅房号码250ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 磅房号码250ToolStripMenuItem.Click
        bangfanghao = "250"

        Me.sp.ReadTimeout = 1000
        Me.sp.WriteTimeout = 1000
        Me.sp.RtsEnable = True
        Me.sp.DtrEnable = True

        mPortName = "COM4"  '欲开启的通讯端口   
        mBaudRate = 1200  '比特率
        mParity = Parity.Even   '校验位检查设定
        mDataBit = 7    '数据位设定值
        mStopbit = StopBits.One  '停止位设定值
        '建立一个通讯端口对象



        Me.sp.PortName = mPortName
        Me.sp.BaudRate = mBaudRate
        Me.sp.Parity = mParity
        Me.sp.DataBits = mDataBit
        Me.sp.StopBits = mStopbit



        sp.ReadBufferSize = 36 '默认就是4096

        Try

            If sp.IsOpen = False Then


                sp.Open()
                sp.ReadExisting() '设置input从接收缓冲读取全数据
                sp.ReceivedBytesThreshold = 1 '设置引发OnComm事件的字节长度
                sp.DiscardInBuffer() '/清楚接受缓冲区

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + ex.GetType().FullName)
        End Try




    End Sub

    Private Sub 磅房650ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 磅房650ToolStripMenuItem.Click
        bangfanghao = "650"



        Me.sp.ReadTimeout = 1000
        Me.sp.WriteTimeout = 1000
        Me.sp.RtsEnable = True
        Me.sp.DtrEnable = True

        mPortName = "COM1"  '欲开启的通讯端口   
        mBaudRate = 2400  '比特率
        mParity = Parity.Even      '校验位检查设定
        mDataBit = 7    '数据位设定值
        mStopbit = StopBits.One  '停止位设定值



        '建立一个通讯端口对象



        Me.sp.PortName = mPortName
        Me.sp.BaudRate = mBaudRate
        Me.sp.Parity = mParity
        Me.sp.DataBits = mDataBit
        Me.sp.StopBits = mStopbit

        sp = New IO.Ports.SerialPort(mPortName, mBaudRate, mParity, mDataBit, mStopbit)


        'sp.ReadBufferSize = 36

        Try
            Me.sp.ReadTimeout = 1000
            Me.sp.WriteTimeout = 1000
            Me.sp.RtsEnable = True
            Me.sp.DtrEnable = True
            If sp.IsOpen = False Then
                'Thread.Sleep(1000)
                sp.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + ex.GetType().FullName)
        End Try





    End Sub

    Private Sub 磅房226ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 磅房226ToolStripMenuItem.Click
        bangfanghao = "226"


        Me.sp.ReadTimeout = 1000
        Me.sp.WriteTimeout = 1000
        Me.sp.RtsEnable = True
        Me.sp.DtrEnable = True

        mPortName = "COM1"  '欲开启的通讯端口   
        mBaudRate = 1200  '比特率
        mParity = Parity.Even    '校验位检查设定
        mDataBit = 7    '数据位设定值
        mStopbit = StopBits.One  '停止位设定值
        '建立一个通讯端口对象



        Me.sp.PortName = mPortName
        Me.sp.BaudRate = mBaudRate
        Me.sp.Parity = mParity
        Me.sp.DataBits = mDataBit
        Me.sp.StopBits = mStopbit



        sp.ReadBufferSize = 36 '默认就是4096

        Try

            If sp.IsOpen = False Then


                sp.Open()
                sp.ReadExisting() '设置input从接收缓冲读取全数据
                sp.ReceivedBytesThreshold = 1 '设置引发OnComm事件的字节长度
                sp.DiscardInBuffer() '/清楚接受缓冲区

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + ex.GetType().FullName)
        End Try



        '-----------------------------------------------------------------------------------------------





    End Sub

    Private Sub 开发区工业园ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 开发区工业园ToolStripMenuItem.Click
        bangfanghao = "1226"




        Me.sp.ReadTimeout = 1000
        Me.sp.WriteTimeout = 1000
        Me.sp.RtsEnable = True
        Me.sp.DtrEnable = True

        mPortName = "COM1"  '欲开启的通讯端口   
        mBaudRate = 1200  '比特率
        mParity = Parity.None   '校验位检查设定
        mDataBit = 8    '数据位设定值
        mStopbit = StopBits.One  '停止位设定值
        '建立一个通讯端口对象



        Me.sp.PortName = mPortName
        Me.sp.BaudRate = mBaudRate
        Me.sp.Parity = mParity
        Me.sp.DataBits = mDataBit
        Me.sp.StopBits = mStopbit



        sp.ReadBufferSize = 36 '默认就是4096

        Try

            If sp.IsOpen = False Then


                sp.Open()
                sp.ReadExisting() '设置input从接收缓冲读取全数据
                sp.ReceivedBytesThreshold = 1 '设置引发OnComm事件的字节长度
                sp.DiscardInBuffer() '/清楚接受缓冲区

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + ex.GetType().FullName)
        End Try


    End Sub

    Private Sub 打印临时库记录ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 打印临时库记录ToolStripMenuItem.Click
        Dim oRpt As New linshiku

        oRpt.SetDataSource(objdataset.Tables("trade"))

        ReportView.Show()
        ReportView.CrystalReportViewer1.ReportSource = oRpt
    End Sub





    Private Sub 隐藏ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 隐藏ToolStripMenuItem.Click
        dgv2.Visible = False
    End Sub

   


 
    Private Sub dgv_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        On Error Resume Next
        chehao.Text = dgv.Rows(e.RowIndex).Cells(3).Value

        afterdel = Val(dgv.Rows(e.RowIndex).Cells(0).Value)
    End Sub

    Private Sub dellinshiku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dellinshiku.Click
        If (MessageBox.Show("您确认要删除该笔临时库记录？（Y/N)", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK) Then

            Dim objcommanddel As New SqlCommand
            objcommanddel.Connection = objconnection
            objcommanddel.CommandText = "delete from trade where id =" & afterdel


            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommanddel.ExecuteNonQuery()




            '这块是要随时更新临时库信息
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from trade where done=0 order by id desc "
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "trade")
            objdataview = New DataView(objdataset.Tables("trade"))
            dgv.DataSource = objdataview
            objconnection.Close()
        End If


    End Sub

   

    Private Sub Manual_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Manual.LostFocus
        If Manual.Checked = False Then
            Button4.Enabled = False
            pizhong.ReadOnly = True
            maozhong.ReadOnly = True
        End If

    End Sub

    Private Sub maozhong_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maozhong.TextChanged
        If Manual.Checked = True Then
            jingzhong.Text = Val(maozhong.Text) - Val(pizhong.Text) - Val(xiangzhong.Text) - Val(xiangzhong2.Text)
            pizhongshijian.Text = Now

        End If
    End Sub

  
   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tarelist.Show()
    End Sub

    Private Sub 厦门中鹭植物油工业有限公司ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 厦门中鹭植物油工业有限公司ToolStripMenuItem.Click
        bangfanghao = "250"

        Me.sp.ReadTimeout = 1000
        Me.sp.WriteTimeout = 1000
        Me.sp.RtsEnable = True
        Me.sp.DtrEnable = True

        mPortName = "COM1"  '欲开启的通讯端口   
        mBaudRate = 2400  '比特率
        mParity = Parity.None   '校验位检查设定
        mDataBit = 7    '数据位设定值
        mStopbit = StopBits.One  '停止位设定值
        '建立一个通讯端口对象



        Me.sp.PortName = mPortName
        Me.sp.BaudRate = mBaudRate
        Me.sp.Parity = mParity
        Me.sp.DataBits = mDataBit
        Me.sp.StopBits = mStopbit



        sp.ReadBufferSize = 36 '默认就是4096

        Try

            If sp.IsOpen = False Then


                sp.Open()
                sp.ReadExisting() '设置input从接收缓冲读取全数据
                sp.ReceivedBytesThreshold = 1 '设置引发OnComm事件的字节长度
                sp.DiscardInBuffer() '/清楚接受缓冲区

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + ex.GetType().FullName)
        End Try

    End Sub

    Private Sub 周口地磅ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 周口地磅ToolStripMenuItem.Click
        bangfanghao = "250"

        Me.sp.ReadTimeout = 1000
        Me.sp.WriteTimeout = 1000
        Me.sp.RtsEnable = True
        Me.sp.DtrEnable = True

        mPortName = "COM1"  '欲开启的通讯端口   
        mBaudRate = 1200  '比特率
        mParity = Parity.None   '校验位检查设定
        mDataBit = 7    '数据位设定值
        mStopbit = StopBits.One  '停止位设定值
        '建立一个通讯端口对象



        Me.sp.PortName = mPortName
        Me.sp.BaudRate = mBaudRate
        Me.sp.Parity = mParity
        Me.sp.DataBits = mDataBit
        Me.sp.StopBits = mStopbit



        sp.ReadBufferSize = 36 '默认就是4096

        Try

            If sp.IsOpen = False Then


                sp.Open()
                sp.ReadExisting() '设置input从接收缓冲读取全数据
                sp.ReceivedBytesThreshold = 1 '设置引发OnComm事件的字节长度
                sp.DiscardInBuffer() '/清楚接受缓冲区

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + ex.GetType().FullName)
        End Try
    End Sub

    Private Sub xiangzhong_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xiangzhong.TextChanged
        If Manual.Checked = True Then
            jingzhong.Text = Val(maozhong.Text) - Val(pizhong.Text) - Val(xiangzhong.Text) - Val(xiangzhong2.Text)
            pizhongshijian.Text = Now

        End If
    End Sub

    Private Sub xiangshu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xiangshu.SelectedIndexChanged
        If Val(xiangshu.Text) = 0 Then
            xiangzhong.Text = 0
        End If
        If Val(xiangshu.Text) = 1 Then
            xiangzhong.Text = 2200
        End If

        If Val(xiangshu.Text) = 2 Then
            xiangzhong.Text = 4400
        End If

        If Manual.Checked = True Then
            jingzhong.Text = Val(maozhong.Text) - Val(pizhong.Text) - Val(xiangzhong.Text)
            pizhongshijian.Text = Now

        End If
    End Sub

    Private Sub 石家庄地磅ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 石家庄地磅ToolStripMenuItem.Click
        bangfanghao = "250"

        Me.sp.ReadTimeout = 1000
        Me.sp.WriteTimeout = 1000
        Me.sp.RtsEnable = True
        Me.sp.DtrEnable = True

        mPortName = "COM1"  '欲开启的通讯端口   
        mBaudRate = 9600  '比特率
        mParity = Parity.Even    '校验位检查设定
        mDataBit = 8   '数据位设定值
        mStopbit = StopBits.One  '停止位设定值
        '建立一个通讯端口对象



        Me.sp.PortName = mPortName
        Me.sp.BaudRate = mBaudRate
        Me.sp.Parity = mParity
        Me.sp.DataBits = mDataBit
        Me.sp.StopBits = mStopbit



        sp.ReadBufferSize = 36 '默认就是4096

        Try

            If sp.IsOpen = False Then


                sp.Open()
                sp.ReadExisting() '设置input从接收缓冲读取全数据
                sp.ReceivedBytesThreshold = 1 '设置引发OnComm事件的字节长度
                sp.DiscardInBuffer() '/清楚接受缓冲区

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + ex.GetType().FullName)
        End Try
    End Sub

    Private Sub jingzhong_TextChanged(sender As System.Object, e As System.EventArgs) Handles jingzhong.TextChanged

    End Sub

    Private Sub xiangzhong2_TextChanged(sender As System.Object, e As System.EventArgs) Handles xiangzhong2.TextChanged
        If Manual.Checked = True Then
            jingzhong.Text = Val(maozhong.Text) - Val(pizhong.Text) - Val(xiangzhong.Text) - Val(xiangzhong2.Text)
            pizhongshijian.Text = Now

        End If
    End Sub

    Private Sub 益海连云港板桥ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 益海连云港板桥ToolStripMenuItem.Click
        bangfanghao = "250"

        Me.sp.ReadTimeout = 1000
        Me.sp.WriteTimeout = 1000
        Me.sp.RtsEnable = True
        Me.sp.DtrEnable = True

        mPortName = "COM1"  '欲开启的通讯端口   
        mBaudRate = 9600  '比特率
        mParity = Parity.None     '校验位检查设定
        mDataBit = 8   '数据位设定值
        mStopbit = StopBits.One   '停止位设定值
        '建立一个通讯端口对象



        Me.sp.PortName = mPortName
        Me.sp.BaudRate = mBaudRate
        Me.sp.Parity = mParity
        Me.sp.DataBits = mDataBit
        Me.sp.StopBits = mStopbit



        sp.ReadBufferSize = 36 '默认就是4096

        Try

            If sp.IsOpen = False Then


                sp.Open()
                sp.ReadExisting() '设置input从接收缓冲读取全数据
                sp.ReceivedBytesThreshold = 1 '设置引发OnComm事件的字节长度
                sp.DiscardInBuffer() '/清楚接受缓冲区

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + ex.GetType().FullName)
        End Try
    End Sub
End Class
