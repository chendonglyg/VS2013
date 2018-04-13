Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.IO

Public Class MainWork

    Dim isclose As Boolean = False
    Dim iRetUSB, iRetCOM, TimeSum As Integer
    Dim oRpt As New CR88
    Dim sex As String       '性别
    Dim people As String     '民族，护照识别时此项为空
    Dim birthday As String    '出生日期
    Dim address As String   '地址，在识别护照时导出的是国籍简码
    Dim number As String   '地址，在识别护照时导出的是国籍简码
    Dim signdate As String    '签发日期，在识别护照时导出的是有效期至 
    Dim validtermOfStart As String   '有效起始日期，在识别护照时为空
    Dim validtermOfEnd As String
    Dim xdatatable As New DataTable
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim sendsomething As New SendMessage.CTEnterprisesSoapClient
    Dim VehicleinPark As New LYGPORT_OUTSIDE.Service1SoapClient

    Dim objconnection = New SqlClient.SqlConnection("Data Source= " & Trim("10.229") & "," & Trim("1433") & ";Initial Catalog = package;User ID=" & "" & "; Password=" & "")



    Private Sub ClearTextBox(ByVal cc As Control.ControlCollection)

        'For Each ctl As Control In cc

        '    If TypeOf ctl Is TextBox Then

        '        CType(ctl, TextBox).Text = String.Empty

        '    ElseIf ctl.Controls.Count > 0 Then

        '        ClearTextBox(ctl.Controls) '递归调用

        '    End If

        'Next

        'For Each ctl As Control In cc

        '    If TypeOf ctl Is Label Then

        '        CType(ctl, Label).Text = String.Empty

        '    ElseIf ctl.Controls.Count > 0 Then

        '        ClearTextBox(ctl.Controls) '递归调用

        '    End If

        'Next

        pictureBox1.ImageLocation = Nothing


        lblName.Text = ""

        lblAddress.Text = ""
        lblSex.Text = ""
        lblBirthday.Text = ""
        lblDept.Text = ""
        lblIdCard.Text = ""

        lblNation.Text = ""
        label11.Text = ""
        lblValidDate.Text = ""
        showmessage.Text = "操作时间超时,请重新刷卡"

    End Sub

    Private Sub filldata()


        pictureBox1.ImageLocation = Application.StartupPath + "\\zp.bmp"
        '-----------------------------------------------------------------------------------


        Dim length As Integer = 1
        Dim namestr(30) As Byte



        CVRSDK.GetPeopleName(namestr(0), length)



        Dim number(30) As Byte
        length = 1
        CVRSDK.GetPeopleIDCode(number(0), length)

        Dim people(30) As Byte
        length = 1
        CVRSDK.GetPeopleNation(people(0), length)



        Dim validtermOfStart(30) As Byte
        length = 1
        CVRSDK.GetStartDate(validtermOfStart(0), length)


        Dim birthday(30) As Byte
        length = 1
        CVRSDK.GetPeopleBirthday(birthday(0), length)

        Dim address(100) As Byte
        length = 1
        CVRSDK.GetPeopleAddress(address(0), length)


        Dim validtermOfEnd(30) As Byte
        length = 1
        CVRSDK.GetEndDate(validtermOfEnd(0), length)



        Dim signdate(30) As Byte
        length = 1
        CVRSDK.GetDepartment(signdate(0), length)


        Dim sex(30) As Byte
        length = 1
        CVRSDK.GetPeopleSex(sex(0), length)


        Dim samid(32) As Byte
        CVRSDK.CVR_GetSAMID(samid(0))


        lblName.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(namestr).Replace("\0", "").Trim()

        lblAddress.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(address).Replace("\0", "").Trim()
        lblSex.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(sex).Replace("\0", "").Trim()
        lblBirthday.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(birthday).Replace("\0", "").Trim()
        lblDept.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(signdate).Replace("\0", "").Trim()
        lblIdCard.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(number).Replace("\0", "").Trim()

        lblNation.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(people).Replace("\0", "").Trim()
        LblSAMID.Text = "安全模块号：" + System.Text.Encoding.GetEncoding("GB2312").GetString(samid).Replace("\0", "").Trim()
        lblValidDate.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(validtermOfStart).Replace("\0", "").Trim() + "-" + System.Text.Encoding.GetEncoding("GB2312").GetString(validtermOfEnd).Replace("\0", "").Trim()




        '-----------------------------------------------------------------------------------------------------------------------在搜索前应该验证停车场数据库，确定该车已驶离停车场------

      


        '-----------------------------------------以下可以利用身份证号码进行搜索和打印模式---lblIdCard.Text---------------在搜索前应该验证停车场数据库，确定该车已驶离停车场----------------------

        objdataadapter = New SqlClient.SqlDataAdapter
        objdataadapter.SelectCommand = New SqlClient.SqlCommand



        objdataadapter.SelectCommand.Connection = objconnection

        objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 可进厂=1 and 司机二代证='" & Trim(lblIdCard.Text) & "'"

        ' objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE "


        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "xdatatable")
        '------------------------------------------------------------------------首选用身份证抽出truck表中对应车号，然后判断过去3天该车是否在停车场，然后再判断该车是否驶离停车场----
        Dim a, TempCar As String
        Dim VehicleParkQuit As New DataTable

        TempCar = Trim(objdataset.Tables("xdatatable").Rows(0).ItemArray("车号")) '用身份证抽出truck表中对应车号

        a = VehicleinPark.VehiclePark(VehicleParkQuit, "VehiclePark_yhwebs", TempCar, 3) '看看过去三天在停车场的记录


        If VehicleParkQuit.Rows.Count > 0 Then '判断过去72小时是否进出入过，抓作弊和避免系统错误


            Dim drOperate As DataRow = VehicleParkQuit.Rows(0)
            If Len(drOperate("out_time").ToString) > 0 Then '说明车有驶离记录
                xdatatable = objdataset.Tables("xdatatable")
                If xdatatable.Rows.Count > 0 Then
                    showmessage.Text = "当前有" & xdatatable.Rows.Count & "笔可打印记录"
                    PictureBox3.Enabled = True

                Else
                    showmessage.Text = "当前无记录可打印"
                    PictureBox3.Enabled = False
                End If
            Else
                showmessage.Text = "您的车辆目前还在停车场，请驶离！"
            End If


        Else
            showmessage.Text = "您的车辆过去72小时内未进入过停车场！"
        End If

        '--------------------------------------------------------------------------------------------------------------------------------------
        'xdatatable = objdataset.Tables("xdatatable")
        'If xdatatable.Rows.Count > 0 Then
        '    showmessage.Text = "当前有" & xdatatable.Rows.Count & "笔可打印记录"
        '    PictureBox3.Enabled = True

        'Else
        '    showmessage.Text = "当前无记录可打印"
        '    PictureBox3.Enabled = False
        'End If


    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        Try

            TimeSum = TimeSum + 1


            If (iRetCOM = 1) Or (iRetUSB = 1) Then


                Dim authenticate As Integer = CVRSDK.CVR_Authenticate()


                If (authenticate = 1) Then

                    Dim readContent As Integer = CVRSDK.CVR_Read_Content(4)

                    If (readContent = 1) Then

                        StausMessage2.Text = "读卡操作成功！"
                        filldata()



                    Else

                        StausMessage2.Text = "读卡操作失败！"

                    End If


                Else

                    StausMessage2.Text = "请放置卡片..."
                End If



            Else

                StausMessage2.Text = ("初始化失败！")

            End If

            If TimeSum > 20 Then
                timer1.Enabled = False
                showmessage.Text = "操作时间超时,请重新刷卡"
                CVRSDK.CVR_CloseComm()
                PictureBox3.Enabled = False
                ClearTextBox(Me.Controls)

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        End Try
    End Sub

    Private Sub Setcolor(ByVal cc As Control.ControlCollection)
        For Each ctl As Control In cc

            If TypeOf ctl Is Label Then

                CType(ctl, Label).ForeColor = Color.Yellow

            ElseIf ctl.Controls.Count > 0 Then

                Setcolor(ctl.Controls) '递归调用

            End If

        Next
    End Sub

    Private Sub Opencvr100()
        Try
            Setcolor(Me.Controls)





            '-----------------------------------------------------------------

            Dim iport As Integer

            For iport = 1001 To 1016

                iRetUSB = CVRSDK.CVR_InitComm(iport)



                '  iRetUSB = CVRSDK.CVR_InitComm_GO(iport)
                'MessageBox.Show("iRetUSB:" & iRetUSB)
                If (iRetUSB = 1) Then
                    Exit For
                End If
            Next



            If (iRetUSB <> 1) Then
                For iport = 1 To 4
                    iRetCOM = CVRSDK.CVR_InitComm(iport)
                    'MessageBox.Show("iRetCOM:" & iRetCOM)
                    If (iRetCOM = 1) Then
                        Exit For
                    End If
                Next
            End If


            If ((iRetCOM = 1) Or (iRetUSB = 1)) Then

                SatusMessage.Text = "初始化成功！" & iRetUSB

            Else

                SatusMessage.Text = "初始化失败！" & iRetUSB

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        End Try

    End Sub
    Private Sub MainWork_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Setcolor(Me.Controls)
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Opencvr100()  '初始化读卡器
        TimeSum = 0 '然后计数器置0
        timer1.Enabled = True '打开计数器


        ClearTextBox(Me.Controls)
        showmessage.Text = "请将二代身份证放入感应区"

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click


        '------------------------------------------------------------------------------



        xdatatable.Columns.Add("图像1", System.Type.GetType("System.Byte[]"))

        '---------------------------------------------------------------------
        Dim bc1 As DotNetBarcode = New DotNetBarcode(DotNetBarcode.Types.QRCode)
        Dim STRQR As String

        bc1.SaveFileType = DotNetBarcode.SaveFileTypes.Png

        ' STRQR = xdatatable.Rows(xdatatable.Rows.Count - 1)("司机姓名") & xdatatable.Rows(xdatatable.Rows.Count - 1)("司机二代证")
        STRQR = xdatatable.Rows(0)("司机二代证")

        File.Delete("D:\barcode.png")

        bc1.QRSave(STRQR, "D:\barcode.png", 12)

        ' pictureBox1.ImageLocation = "D:\barcode.png"





        '--------------------------------------------------------------------

        Dim fsread As New IO.FileStream("D:\barcode.png", IO.FileMode.Open)

        Dim fsLen As Integer = fsread.Length

        Dim img_byte(fsLen) As Byte

        fsread.Read(img_byte, 0, fsread.Length)

        fsread.Close()
        fsread.Dispose()

        '----------------------------------------------------------------------------



        xdatatable.Rows(xdatatable.Rows.Count - 1)("图像1") = img_byte

        '-------------------------------------------------------------------------

        oRpt.SetDataSource(xdatatable)

        Print.Show()
        Print.CrystalReportViewer1.ReportSource = oRpt


        Print.Visible = False

        ' -------------------------------------------------------------------

        oRpt.PrintOptions.PrinterName = "Adobe PDF"
        oRpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA3
        oRpt.PrintToPrinter(1, True, 1, 0)


        'oRpt.PrintOptions.PrinterName = "GP-80160(Cut) Series"
        'oRpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'oRpt.PrintToPrinter(1, True, 1, 0)


        PictureBox3.Enabled = False

        '-----------------------------------------------------------------------------------------------

        'Dim Pic As CrystalDecisions.CrystalReports.Engine.PictureObject = oRpt.ReportDefinition.ReportObjects.Item("Pic")
        'Dim Pic As CrystalDecisions.CrystalReports.Engine.PictureObject = oRpt.ReportDefinition.ReportObjects.Item("Pic")
        'Dim Txt As CrystalDecisions.CrystalReports.Engine.TextObject = oRpt.ReportDefinition.ReportObjects.Item("Txt")
        'Dim Field As CrystalDecisions.CrystalReports.Engine.FieldObject = oRpt.ReportDefinition.ReportObjects.Item("车号1")
        '--------------------------------------------------------------------------------------------------------------------
        'Dim objcommandpassword As New SqlClient.SqlCommand
        'objcommandpassword.Connection = objconnection
        'objcommandpassword.CommandText = "Update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=0,已完成=1,完成时间=@完成时间,billflag=1,billtime=@billtime,billwho=@billwho" & " where 可进厂=1 and 司机二代证='" & Trim(lblIdCard.Text) & "'"
        'objcommandpassword.Parameters.AddWithValue("@完成时间", sendsomething.getDateTime())
        'objcommandpassword.Parameters.AddWithValue("@billwho", "SelfHelp")
        'objcommandpassword.Parameters.AddWithValue("@billtime", sendsomething.getDateTime())



        'If objconnection.State = ConnectionState.Closed Then
        '    objconnection.Open()
        'End If

        'objcommandpassword.ExecuteNonQuery()


        ClearTextBox(Me.Controls)

    End Sub


End Class