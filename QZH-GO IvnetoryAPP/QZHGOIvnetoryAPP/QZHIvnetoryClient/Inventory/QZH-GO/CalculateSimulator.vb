
Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO

Public Class CalculateSimulator





    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter

    Dim objdataadapter_OLE As New OleDb.OleDbDataAdapter

    '----------------------------------------------------------------------------------------


    Dim str_conn As String
    Dim localobjconnection As OleDb.OleDbConnection
    '-----------------------------------------------------------------------------------------
    Dim m, cm, mm As Single
    Dim guancun, wenduxishu, quduanrongliang, temp, xiuzheng, mirong, lirong, haorong, zongrong, tiji As Single


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim gaodu As Single = Val(yougao_tb.Text)
        Dim youwen As Single = Val(youwen_tb.Text)

        Dim midu As Single = Val(midu_tb.Text)

        Dim guanhao As String = Trim(guanhao_tb.Text)



        str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath() & ("\MainData_XiaMen.accdb;Persist Security Info=False;")

        localobjconnection = New OleDb.OleDbConnection(str_conn)

        If Val(yougao_tb.Text) = 0 Then
            m = 0
            cm = 0
            mm = 0
            guancun = 0


        End If

        'If gaodu > 14.324 Or gaodu < 0 Then
        '    MessageBox.Show("高度超出极限且不具备计算条件!", "警告", MessageBoxButtons.OK)
        '    Exit Sub
        'End If



        temp = Val(yougao_tb.Text) * 100
        temp = Int(temp)
        m = temp / 100             '得出12.34


        temp = Val(yougao_tb.Text) * 1000
        temp = Int(temp) Mod 10
        mm = temp                       '得出5




        objdataadapter_OLE.SelectCommand = New OleDb.OleDbCommand
        objdataadapter_OLE.SelectCommand.Connection = localobjconnection


        Select Case Trim(guanhao_tb.Text)
            Case "R08"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from R08_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "R09"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from R09_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T051"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T051_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T052"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T052_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T058"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T058_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T059"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T059_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T101"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T101_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T102"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T102_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T103"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T103_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T104"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T104_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T105"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T105_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T106"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T106_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T107"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T107_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T201"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T201_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T202"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T202_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T203"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T203_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T204"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T204_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T205"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T205_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T301"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T301_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T302"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T302_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T303"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T303_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case Else
                MessageBox.Show("您输入的罐号没有定义!")
        End Select



        objdataset = New DataSet
        objdataadapter_OLE.Fill(objdataset, "容量")
        objdataview = New DataView(objdataset.Tables("容量"))

        If objdataview.Count >= 1 Then
            mirong = objdataview.Item(0).Row("容量")
            xiuzheng = objdataview.Item(0).Row("静压力修正")
            quduanrongliang = objdataview.Item(0).Row("区段容量")


        Else
            MessageBox.Show("您输入的数值超过油罐的极限", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GoTo err
        End If

        tiji = mirong + xiuzheng + quduanrongliang * mm
        tiji = tiji * wenduxishu

        guancun = Math.Round(tiji * midu, 3)
        ' guancun = Math.Round(tiji * midu / 1000, 3) 直接出吨，无需换算

        MessageBox.Show("结算结果为:" & guancun & "吨,且盘点数据已正确提交厦门中鹭主数据库!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)


        '-------------------------------------------
        Dim objcommand As New SqlClient.SqlCommand


        objcommand.Connection = objconnection          '这个webservices中只是对同样编号和时间分组值得数据进行了标记，而webserices2中则直接进行了删除，然后再插入
        objcommand.CommandText = "update GQPD_xiamen set 删除标志=1 where 油罐编号='" & Trim(guanhao_tb.Text) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()


        '-------------------------




        objcommand.Connection = objconnection
        objcommand.CommandText = "insert into GQPD_XiaMen (时间分组值,重量,所属罐区,物料编码,油罐编号,油品名称,打尺深度,油温,盘点时间,盘点人员,监盘人员,标准密度) values (@时间分组值,@重量,@所属罐区,@物料编码,@油罐编号,@油品名称,@打尺深度,@油温,@盘点时间,@盘点人员,@监盘人员,@标准密度)"

        objcommand.Parameters.AddWithValue("@所属罐区", "测试罐区")
        objcommand.Parameters.AddWithValue("@物料编码", "6.7777777")
        objcommand.Parameters.AddWithValue("@油罐编号", guanhao)

        objcommand.Parameters.AddWithValue("@油品名称", "测试油品")
        objcommand.Parameters.AddWithValue("@打尺深度", gaodu)
        objcommand.Parameters.AddWithValue("@油温", youwen)


        objcommand.Parameters.AddWithValue("@重量", guancun) '单位是吨

        objcommand.Parameters.AddWithValue("@盘点时间", Now)
        objcommand.Parameters.AddWithValue("@盘点人员", "CD")
        objcommand.Parameters.AddWithValue("@监盘人员", "CB")

        objcommand.Parameters.AddWithValue("@标准密度", Val(0.9226))

        objcommand.Parameters.AddWithValue("@时间分组值", Now.Date.ToString("yyyyMMdd"))
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()
err:

        objconnection.Close()

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim gaodu As Single = Val(yougao_tb_qz.Text)
        Dim youwen As Single = Val(youwen_tb_qz.Text)

        Dim midu As Single = Val(midu_tb_qz.Text)

        Dim guanhao As String = Trim(guanhao_tb_qz.Text)



        str_conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath() & ("\MainData_XiaMen.accdb;Persist Security Info=False;")

        localobjconnection = New OleDb.OleDbConnection(str_conn)

        If Val(gaodu) = 0 Then
            m = 0
            cm = 0
            mm = 0
            guancun = 0


        End If

        'If gaodu > 14.324 Or gaodu < 0 Then
        '    MessageBox.Show("高度超出极限且不具备计算条件!", "警告", MessageBoxButtons.OK)
        '    Exit Sub
        'End If



        temp = Val(gaodu) * 100
        temp = Int(temp)
        m = temp / 100             '得出12.34


        temp = Val(gaodu) * 1000
        temp = Int(temp) Mod 10
        mm = temp                       '得出5




        objdataadapter_OLE.SelectCommand = New OleDb.OleDbCommand
        objdataadapter_OLE.SelectCommand.Connection = localobjconnection


        Select Case Trim(guanhao)
            Case "T011"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T011_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T012"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T012_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T015"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T015_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T016"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T016_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T023"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T023_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T053"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T053_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T054"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T054_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T055"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T055_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T056"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T056_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T057"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T057_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024
            Case "T108"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T108_Y where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000036 '非保温是0.000024



            Case "T052"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T052_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T013"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T013_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T014"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T014_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T021"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T021_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T022"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T022_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T051"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T051_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024
            Case "T102"
                objdataadapter_OLE.SelectCommand.CommandText = "select * from T102_N where 液位高度= " & m
                wenduxishu = 1 + (youwen - 20) * 0.000024 '非保温是0.000024

            Case Else
                MessageBox.Show("您输入的罐号没有定义!")

        End Select



        objdataset = New DataSet
        objdataadapter_OLE.Fill(objdataset, "容量")
        objdataview = New DataView(objdataset.Tables("容量"))

        If objdataview.Count >= 1 Then
            mirong = objdataview.Item(0).Row("容量")
            xiuzheng = objdataview.Item(0).Row("静压力修正")
            quduanrongliang = objdataview.Item(0).Row("区段容量")
        Else
            MessageBox.Show("您输入的数值超过油罐的极限", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GoTo err
        End If

        tiji = mirong + xiuzheng + quduanrongliang * mm
        tiji = tiji * wenduxishu

        midu = (20 - youwen) * 0.00064 + midu
        guancun = Math.Round(tiji * midu, 3)
        ' guancun = Math.Round(tiji * midu / 1000, 3) 直接出吨，无需换算

        MessageBox.Show("结算结果为:" & guancun & "吨,且盘点数据已正确提交泉州罐区主数据库!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)


        '-------------------------------------------
        Dim objcommand As New SqlClient.SqlCommand


        objcommand.Connection = objconnection          '这个webservices中只是对同样编号和时间分组值得数据进行了标记，而webserices2中则直接进行了删除，然后再插入
        objcommand.CommandText = "update GQPD_QZ set 删除标志=1 where 油罐编号='" & Trim(guanhao_tb.Text) & "' and 时间分组值='" & Now.Date.ToString("yyyyMMdd") & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()


        '-------------------------




        objcommand.Connection = objconnection
        objcommand.CommandText = "insert into GQPD_QZ (时间分组值,重量,所属罐区,物料编码,油罐编号,油品名称,打尺深度,油温,盘点时间,盘点人员,监盘人员,标准密度) values (@时间分组值,@重量,@所属罐区,@物料编码,@油罐编号,@油品名称,@打尺深度,@油温,@盘点时间,@盘点人员,@监盘人员,@标准密度)"

        objcommand.Parameters.AddWithValue("@所属罐区", "测试罐区")
        objcommand.Parameters.AddWithValue("@物料编码", "6.7777777")
        objcommand.Parameters.AddWithValue("@油罐编号", guanhao)

        objcommand.Parameters.AddWithValue("@油品名称", "测试油品")
        objcommand.Parameters.AddWithValue("@打尺深度", gaodu)
        objcommand.Parameters.AddWithValue("@油温", youwen)


        objcommand.Parameters.AddWithValue("@重量", guancun) '单位是吨

        objcommand.Parameters.AddWithValue("@盘点时间", Now)
        objcommand.Parameters.AddWithValue("@盘点人员", "CD")
        objcommand.Parameters.AddWithValue("@监盘人员", "CB")

        objcommand.Parameters.AddWithValue("@标准密度", Val(0.9226))

        objcommand.Parameters.AddWithValue("@时间分组值", Now.Date.ToString("yyyyMMdd"))
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objcommand.ExecuteNonQuery()

err:

        objconnection.Close()


    End Sub

    Private Sub CalculateSimulator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
