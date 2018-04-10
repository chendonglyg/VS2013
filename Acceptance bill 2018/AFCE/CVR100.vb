Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Threading


Public Class CVR100
    Dim isclose As Boolean = False
    Dim iRetUSB, iRetCOM As Integer

    Dim sex As String       '性别
    Dim people As String     '民族，护照识别时此项为空
    Dim birthday As String    '出生日期
    Dim address As String   '地址，在识别护照时导出的是国籍简码
    Dim number As String   '地址，在识别护照时导出的是国籍简码
    Dim signdate As String    '签发日期，在识别护照时导出的是有效期至 
    Dim validtermOfStart As String   '有效起始日期，在识别护照时为空
    Dim validtermOfEnd As String

 

   


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


    End Sub

    Private Sub TEMP2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try



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
        label11.Text = "安全模块号：" + System.Text.Encoding.GetEncoding("GB2312").GetString(samid).Replace("\0", "").Trim()
        lblValidDate.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(validtermOfStart).Replace("\0", "").Trim() + "-" + System.Text.Encoding.GetEncoding("GB2312").GetString(validtermOfEnd).Replace("\0", "").Trim()

    End Sub




    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Try



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

                    MessageBox.Show("未放卡或卡片放置不正确")
                End If



            Else

                MessageBox.Show("初始化失败！")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        End Try

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        isclose = True
        Try

            Dim isSuccess As Integer = CVRSDK.CVR_CloseComm()
            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        End Try
    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        'button1_Click(sender, e)
        Try



            If (iRetCOM = 1) Or (iRetUSB = 1) Then


                Dim authenticate As Integer = CVRSDK.CVR_Authenticate()


                If (authenticate = 1) Then

                    Dim readContent As Integer = CVRSDK.CVR_Read_Content(4)

                    If (readContent = 1) Then

                        StausMessage2.Text = "读卡操作成功！"
                        filldata()

                        timer1.Enabled = False

                    Else

                        StausMessage2.Text = "读卡操作失败！"

                    End If


                Else

                    StausMessage2.Text = "请放置卡片..."
                End If



            Else

                StausMessage2.Text = ("初始化失败！")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClearTextBox(Me.Controls)

        timer1.Enabled = True
    End Sub
End Class