
Imports System.Data.SqlClient
Imports System.Data
Imports System.String


Public Class input
    'Dim objconnection As New SqlConnection("server = ;database=package;user id=sa;password=chen dong")

    Dim objconnection As New SqlConnection("Data Source= 218.92.113.9;Initial Catalog = package;User ID=sa; Password=chen dong")
    Dim sr As New Integer
    Dim srf As New Integer
    Dim str1 As String
    Dim objdataAdapter As New SqlDataAdapter
    Dim objdataset As New DataSet

    Dim combobox4b As New ComboBox


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1








        Dim sr As IO.StreamReader


        ComboBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        ComboBox4.AutoCompleteSource = AutoCompleteSource.ListItems


        sr = New System.IO.StreamReader(Application.StartupPath & "\1.txt", True)
        ComboBox1.Items.Clear()
        Do While sr.Peek > 0
            ComboBox1.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\2.txt", True)
        ComboBox2.Items.Clear()
        Do While sr.Peek > 0
            ComboBox2.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\3.txt", True)
        ComboBox3.Items.Clear()
        Do While sr.Peek > 0
            ComboBox3.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\4.txt", True)
        ComboBox4.Items.Clear()
        combobox4b.Items.Clear()
        Do While sr.Peek > 0
            str1 = sr.ReadLine
            ComboBox4.Items.Add(str1)


        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)





        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\5.txt", True)
        ComboBox5.Items.Clear()
        Do While sr.Peek > 0
            ComboBox5.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing





        scx1.Text = "1900-01-01"
        scx2.Text = "1900-01-01"
        scx3.Text = "1900-01-01"
        scx4.Text = "1900-01-01"
        scx5.Text = "1900-01-01"

        textbox11.Text = "1900-01-01 00:00:00"

        objdataAdapter.SelectCommand = New SqlCommand
        objdataAdapter.SelectCommand.Connection = objconnection
        objdataAdapter.SelectCommand.CommandText = "select * from trade"
        objconnection.Open()
        objdataAdapter.Fill(objdataset, "trade")
        Dim objdataview1 As New DataView(objdataset.Tables("trade"))

        objdataview1.Sort = "序号 desc"


        dgv.AutoGenerateColumns = True
        dgv.DataSource = objdataview1


        Me.TextBox1.Text = Now()


        objconnection.Close()
        Label1.Text = "限" & 300 - Len(TextBox12.Text) & "字"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

   




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click






        If ComboBox1.FindString(ComboBox1.Text) < 0 Then
            Dim xr As New IO.StreamWriter(Application.StartupPath & "\1.txt", True)
            xr.WriteLine(ComboBox1.Text)
            xr.Flush()
            xr.Close()
        End If


        If ComboBox2.FindString(ComboBox2.Text) < 0 Then
            Dim xr As New IO.StreamWriter(Application.StartupPath & " \2.txt", True)
            xr.WriteLine(ComboBox2.Text)
            xr.Flush()
            xr.Close()
        End If

        If ComboBox3.FindString(ComboBox3.Text) < 0 Then
            Dim xr As New IO.StreamWriter(Application.StartupPath & " \3.txt", True)
            xr.WriteLine(ComboBox3.Text)
            xr.Flush()
            xr.Close()
        End If

        If ComboBox4.FindString(ComboBox4.Text) < 0 Then
            Dim xr As New IO.StreamWriter(Application.StartupPath & " \4.txt", True)
            xr.WriteLine(ComboBox4.Text)
            xr.Flush()
            xr.Close()
        End If

        If ComboBox5.FindString(ComboBox5.Text) < 0 Then
            Dim xr As New IO.StreamWriter(Application.StartupPath & " \5.txt", True)
            xr.WriteLine(ComboBox5.Text)
            xr.Flush()
            xr.Close()
        End If










        Dim sr As New System.IO.StreamReader(Application.StartupPath & "\1.txt", True)
        ComboBox1.Items.Clear()
        Do While sr.Peek > 0
            ComboBox1.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\2.txt", True)
        ComboBox2.Items.Clear()
        Do While sr.Peek > 0
            ComboBox2.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\3.txt", True)
        ComboBox3.Items.Clear()
        Do While sr.Peek > 0
            ComboBox3.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\4.txt", True)
        ComboBox4.Items.Clear()
        Do While sr.Peek > 0
            ComboBox4.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\5.txt", True)
        ComboBox5.Items.Clear()
        Do While sr.Peek > 0
            ComboBox5.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing




















        Dim objcommand As New SqlCommand
        Try
            objcommand.Connection = objconnection
            objcommand.CommandText = "insert into trade (班组,品种名称,规格,生产线,生产线2,生产日期1,生产日期2,生产日期3,生产日期4,生产日期5,库位,车号,件数,客户名称,发货日期,录入时间,装车时间,货物喷码,版本号) values (@班组,@品种名称,@规格,@生产线,@生产线2,@生产日期1,@生产日期2,@生产日期3,@生产日期4,@生产日期5,@库位,@车号,@件数,@客户名称,@发货日期,@录入时间,@装车时间,@货物喷码,@版本号) "

            objcommand.Parameters.AddWithValue("@品种名称", ComboBox1.Text)
            objcommand.Parameters.AddWithValue("@班组", Val(banzu.Text))
            objcommand.Parameters.AddWithValue("@规格", ComboBox2.Text)
            objcommand.Parameters.AddWithValue("@生产线", scx.Text)
            objcommand.Parameters.AddWithValue("@生产线2", scx02.Text)
            Dim hm As New Date
            hm = scx1.Text
            hm.ToString("yyyy/MM/dd")


            objcommand.Parameters.AddWithValue("@生产日期1", hm.Date)

            hm = scx2.Text
            hm.ToString("yyyy/MM/dd")

            objcommand.Parameters.AddWithValue("@生产日期2", hm.Date)

            hm = scx3.Text
            hm.ToString("yyyy/MM/dd")

            objcommand.Parameters.AddWithValue("@生产日期3", hm.Date)

            hm = scx4.Text
            hm.ToString("yyyy/MM/dd")

            objcommand.Parameters.AddWithValue("@生产日期4", hm.Date)


            hm = scx5.Text
            hm.ToString("yyyy/MM/dd")


            objcommand.Parameters.AddWithValue("@生产日期5", hm.Date)



            objcommand.Parameters.AddWithValue("@库位", ComboBox3.Text)
            objcommand.Parameters.AddWithValue("@车号", ComboBox4.Text)
            objcommand.Parameters.AddWithValue("@件数", TextBox8.Text)
            objcommand.Parameters.AddWithValue("@客户名称", ComboBox5.Text)
            objcommand.Parameters.AddWithValue("@发货日期", DateTime2.Value)
            objcommand.Parameters.AddWithValue("@录入时间", TextBox1.Text)

            hm = TextBox1.Text
            hm.ToString("yyyy/MM/dd HH:mm:ss")



            objcommand.Parameters.AddWithValue("@装车时间", hm.Date)
            objcommand.Parameters.AddWithValue("@货物喷码", TextBox12.Text)

            objcommand.Parameters.AddWithValue("@版本号", "20090526")








            objconnection.Open()

            objcommand.ExecuteNonQuery()
            objdataset.Clear()

            objdataAdapter.Fill(objdataset, "trade")




            Dim objdataview As New DataView(objdataset.Tables("trade"))

            objdataview.Sort = "序号 desc"




            dgv.AutoGenerateColumns = True
            dgv.DataSource = objdataview



            objconnection.Close()


        Catch

            MessageBox.Show("日期可能输入错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            scx1.Text = "1900-01-01"
            scx2.Text = "1900-01-01"
            scx3.Text = "1900-01-01"
            scx4.Text = "1900-01-01"
            scx5.Text = "1900-01-01"

            textbox11.Text = "1900-01-01 00:00:00"
        End Try




    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        MessageBox.Show(ComboBox4.Items.Count)
        Me.TextBox1.Text = Now()
        ComboBox3.Text = ""

        ComboBox1.Text = ""



        ComboBox2.Text = ""

        ComboBox4.Text = ""

        TextBox8.Text = ""

        ComboBox5.Text = ""

        TextBox12.Text = ""

        scx1.Text = "1900-01-01"
        scx2.Text = "1900-01-01"
        scx3.Text = "1900-01-01"
        scx4.Text = "1900-01-01"
        scx5.Text = "1900-01-01"

        TextBox11.Text = ""

    End Sub

   



    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged
        Label1.Text = "限" & 300 - Len(TextBox12.Text) & "字"

    End Sub

   

    Private Sub scx1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles scx1.MouseClick
        scx1.Text = ""

    End Sub
    Private Sub scx2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles scx2.MouseClick
        scx2.Text = ""

    End Sub
    Private Sub scx3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles scx3.MouseClick
        scx3.Text = ""

    End Sub
    Private Sub scx4_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles scx4.MouseClick
        scx4.Text = ""

    End Sub
    Private Sub scx5_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles scx5.MouseClick
        scx5.Text = ""

    End Sub

    Private Sub textbox11_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles textbox11.MouseClick
        textbox11.Text = ""

    End Sub

    Private Sub scx4_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles scx4.MaskInputRejected

    End Sub

    Public Sub ku(ByVal Combo As ComboBox, ByVal e As KeyEventArgs)
        Dim strTyped As String
        Dim intFoundIndex As Integer
        Dim objFoundItem As Object
        Dim strFoundText As String
        Dim strAppendText As String
        '忽略这些基本操作键 	

        Select Case e.KeyCode
            Case Keys.Back, Keys.Left, Keys.Right, Keys.Up, Keys.Delete, Keys.Down, Keys.CapsLock, Keys.Control, Keys.ControlKey
                Return
        End Select
   






        srf = Combo.Text.Length
        '看看用户输入了些什么 	 
        strTyped = Combo.Text
        intFoundIndex = Combo.FindString(strTyped)

        '如果找到了的话…… 	 
        If intFoundIndex >= 0 Then
            '获取Combo下的匹配项 	 
            objFoundItem = Combo.Items(intFoundIndex)


            '获取匹配的字符串	 
            strFoundText = Combo.GetItemText(objFoundItem)

            '开始自动添加文本 	 
            strAppendText = strFoundText.Substring(strTyped.Length)
            Combo.Text = strTyped & strAppendText
            '选亮添加的文本 	 
            Combo.SelectionStart = strTyped.Length
            Combo.SelectionLength = strAppendText.Length

        End If



    End Sub


 

    Private Sub ComboBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox2.KeyDown
        If ComboBox2.Text.Length > sr Then
            ku(ComboBox2, e)
        End If
        sr = ComboBox2.Text.Length
    End Sub

    Private Sub ComboBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyUp
        If ComboBox1.Text.Length > sr Then
            ku(ComboBox1, e)
        End If
        sr = ComboBox1.Text.Length
    End Sub

    Private Sub ComboBox3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox3.KeyUp
        If ComboBox3.Text.Length > sr Then
            ku(ComboBox3, e)
        End If
        sr = ComboBox3.Text.Length
    End Sub

    Private Sub ComboBox4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox4.Click


    End Sub

    Private Sub ComboBox4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox4.KeyUp
      
    End Sub

    Private Sub ComboBox5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox5.Click
        ComboBox5.Text = ""
        sr = ComboBox5.Text.Length
    End Sub

  
    Private Sub ComboBox5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox5.KeyUp
        If ComboBox5.Text.Length > sr Then
            ku(ComboBox5, e)
        End If
        sr = ComboBox5.Text.Length

    End Sub

  
    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub
End Class
