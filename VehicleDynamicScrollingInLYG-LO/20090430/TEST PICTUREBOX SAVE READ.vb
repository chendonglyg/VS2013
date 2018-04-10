Imports System.Net.Sockets
Public Class TEST_READ_SAVE

    Dim objdataset As New DataSet
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim objdatatable As New DataTable

    Dim getsomething As New lygport_outside.Service1SoapClient

    Dim sendsomething As New sendmessage.CTEnterprisesSoapClient


    Dim crytogram, vehicle, externo As String
    Dim veh_return, in_date, stre, phone_no As String
    Dim picture1, picture2 As Byte()
    Dim img As Image





    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next



        crytogram = "saduiugdsiu#$W*s_yh"
        vehicle = "YH11111"
        'vehicle = "苏G39380"

        externo = ""

        veh_return = getsomething.GetInRecord(crytogram, vehicle, externo, in_date, picture1, picture2, stre, phone_no)

        If stre = "success" Then



            img = Image.FromStream(New System.IO.MemoryStream(picture1))
            PictureBox1.Image = img
            img = Image.FromStream(New System.IO.MemoryStream(picture2))
            PictureBox2.Image = img
            veh_return = Mid(veh_return, 1, Len(veh_return) - 1)
            result.Text = veh_return & vbCrLf & in_date & vbCrLf & phone_no & vbCrLf & stre & vbCrLf

        Else
            MessageBox.Show("车辆未进场或已离开", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sendsomething As New sendmessage.CTEnterprisesSoapClient


        '  Try




        Dim objcommand As New SqlClient.SqlCommand

        objcommand.Connection = objconnection
        objcommand.CommandText = "insert into TRUCK_QUEUE_IMAGE (提单号,车号,图像1,图像2,图1大小,图2大小,入场日期) values (@提单号,@车号,@图像1,@图像2,@图1大小,@图2大小,@入场日期)"

        objcommand.Parameters.AddWithValue("@提单号", "20160527")

        objcommand.Parameters.AddWithValue("@车号", vehicle)
        '0------------------------------------------------------------------------------
        Dim imageBytes As Byte()
        imageBytes = GetImageBytes(PictureBox1.Image)

        objcommand.Parameters.AddWithValue("@图像1", imageBytes)
        objcommand.Parameters.AddWithValue("@图1大小", imageBytes.Length)

        imageBytes = GetImageBytes(PictureBox2.Image)
        objcommand.Parameters.AddWithValue("@图像2", imageBytes)
        objcommand.Parameters.AddWithValue("@图2大小", imageBytes.Length)


        objcommand.Parameters.AddWithValue("@入场日期", in_date)



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
        objconnection.Close()

        MessageBox.Show("数据已经提交", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)



        'Catch ex As Exception
        ' MessageBox.Show(ex.Message)


        ' End Try
    End Sub

    Private Function GetImageBytes(image As Image)

        Dim mstream As New IO.MemoryStream

        image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

        Dim byteData() As Byte



        byteData = mstream.GetBuffer



        mstream.Position = 0
        mstream.Read(byteData, 0, byteData.Length)
        mstream.Close()
        Return byteData

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'On Error Resume Next

        objdataadapter = New SqlClient.SqlDataAdapter
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection

        objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE_IMAGE  where 车号='YH11111' "
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If

        objdataadapter.Fill(objdataset, "IMAGE")
        objdatatable = objdataset.Tables("IMAGE")




        crytogram = "saduiugdsiu#$W*s_yh"
        vehicle = "YH11111"
        'vehicle = "苏G39380"

        externo = ""

        ' veh_return = getsomething.GetInRecord(crytogram, vehicle, externo, in_date, picture1, picture2, stre, phone_no)

        If objdatatable.Rows.Count > 0 Then
            MessageBox.Show(objdatatable.Rows(0)("车号"))
            Dim bytedata() As Byte

            bytedata = objdatatable.Rows(0)("图像1")
            Dim imagedata As New IO.MemoryStream(bytedata)

            img = Image.FromStream(imagedata)


            PictureBox3.Image = img


        Else
            MessageBox.Show("车辆未进场或已离开", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub





    
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        MessageBox.Show(sendsomething.getDateTime())

    End Sub
End Class