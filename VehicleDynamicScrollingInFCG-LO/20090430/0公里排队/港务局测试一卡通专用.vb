Public Class 港务局测试一卡通专用
    Dim vehicle, stre_2, stre_3, phone_no As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '车辆申报
        If Color.Checked = True Then

            vehicle = Trim(chehao.Text) & "蓝"
        Else

            vehicle = Trim(chehao.Text)
        End If





        Dim insertsomething As New lygport_outside.Service1SoapClient


        phone_no = Trim(dianhuahaoma.Text)

        stre_2 = insertsomething.InsertConsignVehicle("siewn%%iu#$W*insert_yh", vehicle, phone_no)

        MessageBox.Show(stre_2, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)


        '注意:
        '(1)对于传入的参数vehicle，phone_no,均不能为空
        '(2)当strE返回的是success表明申报成功
        '        未申报成功原因请参照strE返回值的内容()
        '车辆放行

        Dim updatesomething As New lygport_outside.Service1SoapClient
        stre_3 = updatesomething.UpdateConsignVehicle("ygygdn%hjiu**W*update_yh", vehicle)

        MessageBox.Show(stre_3, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If isOneCardPass = 0 Then '说明此车是单独放行的
            '-------------------------------------------------------------------------------------------------

            Dim objcommand As New SqlClient.SqlCommand
            objcommand.Connection = objconnection

            objcommand.CommandText = "insert into TRUCK_QUEUE_PermitOCP (VehicleNo,TelNo,ColorStyle,Operator) values (@VehicleNo,@TelNo,@ColorStyle,@Operator)"

            objcommand.Parameters.AddWithValue("@VehicleNo", Trim(chehao.Text))
            objcommand.Parameters.AddWithValue("@TelNo", Trim(dianhuahaoma.Text))
            objcommand.Parameters.AddWithValue("@Operator", username)

            If Color.CheckState = CheckState.Checked Then
                objcommand.Parameters.AddWithValue("@ColorStyle", "蓝")
            Else
                objcommand.Parameters.AddWithValue("@ColorStyle", "黄")
            End If




            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommand.ExecuteNonQuery()

            MessageBox.Show("该笔放车信息已经保存数据库备查! ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub

  
    Private Sub Color_CheckedChanged(sender As Object, e As EventArgs) Handles Color.CheckedChanged
        If Color.Checked = True Then
            chehao.BackColor = Drawing.Color.Blue
        Else
            chehao.BackColor = Drawing.Color.Yellow

        End If
    End Sub

    Private Sub 港务局测试一卡通专用_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class