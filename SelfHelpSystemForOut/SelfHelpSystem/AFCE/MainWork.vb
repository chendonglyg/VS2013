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
    Dim sex As String       '�Ա�
    Dim people As String     '���壬����ʶ��ʱ����Ϊ��
    Dim birthday As String    '��������
    Dim address As String   '��ַ����ʶ����ʱ�������ǹ�������
    Dim number As String   '��ַ����ʶ����ʱ�������ǹ�������
    Dim signdate As String    'ǩ�����ڣ���ʶ����ʱ����������Ч���� 
    Dim validtermOfStart As String   '��Ч��ʼ���ڣ���ʶ����ʱΪ��
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

        '        ClearTextBox(ctl.Controls) '�ݹ����

        '    End If

        'Next

        'For Each ctl As Control In cc

        '    If TypeOf ctl Is Label Then

        '        CType(ctl, Label).Text = String.Empty

        '    ElseIf ctl.Controls.Count > 0 Then

        '        ClearTextBox(ctl.Controls) '�ݹ����

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
        showmessage.Text = "����ʱ�䳬ʱ,������ˢ��"

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
        LblSAMID.Text = "��ȫģ��ţ�" + System.Text.Encoding.GetEncoding("GB2312").GetString(samid).Replace("\0", "").Trim()
        lblValidDate.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(validtermOfStart).Replace("\0", "").Trim() + "-" + System.Text.Encoding.GetEncoding("GB2312").GetString(validtermOfEnd).Replace("\0", "").Trim()




        '-----------------------------------------------------------------------------------------------------------------------������ǰӦ����֤ͣ�������ݿ⣬ȷ���ó���ʻ��ͣ����------

      


        '-----------------------------------------���¿����������֤������������ʹ�ӡģʽ---lblIdCard.Text---------------������ǰӦ����֤ͣ�������ݿ⣬ȷ���ó���ʻ��ͣ����----------------------

        objdataadapter = New SqlClient.SqlDataAdapter
        objdataadapter.SelectCommand = New SqlClient.SqlCommand



        objdataadapter.SelectCommand.Connection = objconnection

        objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where �ɽ���=1 and ˾������֤='" & Trim(lblIdCard.Text) & "'"

        ' objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE "


        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "xdatatable")
        '------------------------------------------------------------------------��ѡ�����֤���truck���ж�Ӧ���ţ�Ȼ���жϹ�ȥ3��ó��Ƿ���ͣ������Ȼ�����жϸó��Ƿ�ʻ��ͣ����----
        Dim a, TempCar As String
        Dim VehicleParkQuit As New DataTable

        TempCar = Trim(objdataset.Tables("xdatatable").Rows(0).ItemArray("����")) '�����֤���truck���ж�Ӧ����

        a = VehicleinPark.VehiclePark(VehicleParkQuit, "VehiclePark_yhwebs", TempCar, 3) '������ȥ������ͣ�����ļ�¼


        If VehicleParkQuit.Rows.Count > 0 Then '�жϹ�ȥ72Сʱ�Ƿ���������ץ���׺ͱ���ϵͳ����


            Dim drOperate As DataRow = VehicleParkQuit.Rows(0)
            If Len(drOperate("out_time").ToString) > 0 Then '˵������ʻ���¼
                xdatatable = objdataset.Tables("xdatatable")
                If xdatatable.Rows.Count > 0 Then
                    showmessage.Text = "��ǰ��" & xdatatable.Rows.Count & "�ʿɴ�ӡ��¼"
                    PictureBox3.Enabled = True

                Else
                    showmessage.Text = "��ǰ�޼�¼�ɴ�ӡ"
                    PictureBox3.Enabled = False
                End If
            Else
                showmessage.Text = "���ĳ���Ŀǰ����ͣ��������ʻ�룡"
            End If


        Else
            showmessage.Text = "���ĳ�����ȥ72Сʱ��δ�����ͣ������"
        End If

        '--------------------------------------------------------------------------------------------------------------------------------------
        'xdatatable = objdataset.Tables("xdatatable")
        'If xdatatable.Rows.Count > 0 Then
        '    showmessage.Text = "��ǰ��" & xdatatable.Rows.Count & "�ʿɴ�ӡ��¼"
        '    PictureBox3.Enabled = True

        'Else
        '    showmessage.Text = "��ǰ�޼�¼�ɴ�ӡ"
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

                        StausMessage2.Text = "���������ɹ���"
                        filldata()



                    Else

                        StausMessage2.Text = "��������ʧ�ܣ�"

                    End If


                Else

                    StausMessage2.Text = "����ÿ�Ƭ..."
                End If



            Else

                StausMessage2.Text = ("��ʼ��ʧ�ܣ�")

            End If

            If TimeSum > 20 Then
                timer1.Enabled = False
                showmessage.Text = "����ʱ�䳬ʱ,������ˢ��"
                CVRSDK.CVR_CloseComm()
                PictureBox3.Enabled = False
                ClearTextBox(Me.Controls)

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        End Try
    End Sub

    Private Sub Setcolor(ByVal cc As Control.ControlCollection)
        For Each ctl As Control In cc

            If TypeOf ctl Is Label Then

                CType(ctl, Label).ForeColor = Color.Yellow

            ElseIf ctl.Controls.Count > 0 Then

                Setcolor(ctl.Controls) '�ݹ����

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

                SatusMessage.Text = "��ʼ���ɹ���" & iRetUSB

            Else

                SatusMessage.Text = "��ʼ��ʧ�ܣ�" & iRetUSB

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        End Try

    End Sub
    Private Sub MainWork_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Setcolor(Me.Controls)
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Opencvr100()  '��ʼ��������
        TimeSum = 0 'Ȼ���������0
        timer1.Enabled = True '�򿪼�����


        ClearTextBox(Me.Controls)
        showmessage.Text = "�뽫�������֤�����Ӧ��"

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click


        '------------------------------------------------------------------------------



        xdatatable.Columns.Add("ͼ��1", System.Type.GetType("System.Byte[]"))

        '---------------------------------------------------------------------
        Dim bc1 As DotNetBarcode = New DotNetBarcode(DotNetBarcode.Types.QRCode)
        Dim STRQR As String

        bc1.SaveFileType = DotNetBarcode.SaveFileTypes.Png

        ' STRQR = xdatatable.Rows(xdatatable.Rows.Count - 1)("˾������") & xdatatable.Rows(xdatatable.Rows.Count - 1)("˾������֤")
        STRQR = xdatatable.Rows(0)("˾������֤")

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



        xdatatable.Rows(xdatatable.Rows.Count - 1)("ͼ��1") = img_byte

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
        'Dim Field As CrystalDecisions.CrystalReports.Engine.FieldObject = oRpt.ReportDefinition.ReportObjects.Item("����1")
        '--------------------------------------------------------------------------------------------------------------------
        'Dim objcommandpassword As New SqlClient.SqlCommand
        'objcommandpassword.Connection = objconnection
        'objcommandpassword.CommandText = "Update TRUCK_QUEUE set �ɵǼ�=0,�ѵǼ�=0,�ɽ���=0,�����=1,���ʱ��=@���ʱ��,billflag=1,billtime=@billtime,billwho=@billwho" & " where �ɽ���=1 and ˾������֤='" & Trim(lblIdCard.Text) & "'"
        'objcommandpassword.Parameters.AddWithValue("@���ʱ��", sendsomething.getDateTime())
        'objcommandpassword.Parameters.AddWithValue("@billwho", "SelfHelp")
        'objcommandpassword.Parameters.AddWithValue("@billtime", sendsomething.getDateTime())



        'If objconnection.State = ConnectionState.Closed Then
        '    objconnection.Open()
        'End If

        'objcommandpassword.ExecuteNonQuery()


        ClearTextBox(Me.Controls)

    End Sub


End Class