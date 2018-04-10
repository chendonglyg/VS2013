Imports System.Data.SqlClient
Imports System.Data

Public Class Car2
    Dim sr As New Integer
    Dim srf As New Integer

    Dim forreport As New SqlDataAdapter

    Dim objconnection As New SqlConnection("Data Source= lyg.yihai.com;Initial Catalog = package;User ID=sa; Password=chen dong")
    Public afterdel As String

    Dim objdataadapter As New SqlDataAdapter
    Dim olda, oldb As Integer

    Public objdataview As New DataView
    Dim objdataset As New DataSet

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub 新建ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 新建ToolStripMenuItem.Click

    End Sub

    Private Sub Car2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1



        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from car_car"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "car")

        objdataview = New DataView(objdataset.Tables("car"))
        dgv.DataSource = objdataview



        ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBox2.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBox3.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBox4.AutoCompleteSource = AutoCompleteSource.ListItems


    
        addtxt()


    End Sub
    Private Sub addtxt()
        Dim sr As IO.StreamReader
        sr = New System.IO.StreamReader(Application.StartupPath & "\车号.txt", True)
        ComboBox1.Items.Clear()
        Do While sr.Peek > 0
            ComboBox1.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\司机.txt", True)
        ComboBox2.Items.Clear()
        Do While sr.Peek > 0
            ComboBox2.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing


        sr = New System.IO.StreamReader(Application.StartupPath & "\车型.txt", True)
        ComboBox3.Items.Clear()
        Do While sr.Peek > 0
            ComboBox3.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

        sr = New System.IO.StreamReader(Application.StartupPath & "\电话.txt", True)
        ComboBox4.Items.Clear()
        Do While sr.Peek > 0
            ComboBox4.Items.Add(sr.ReadLine)
        Loop
        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing

  


    End Sub
    Private Sub 新建ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 新建ToolStripMenuItem1.Click
        save.Enabled = True
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        TextBox4.Text = ""


    End Sub



    Private Sub savetxt()
        If ComboBox1.Text.Length > 0 Then
            If ComboBox1.FindString(ComboBox1.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\车号.txt", True)
                xr.WriteLine(ComboBox1.Text)
                xr.Flush()
                xr.Close()
            End If
        End If


        If ComboBox2.Text.Length > 0 Then
            If ComboBox2.FindString(ComboBox2.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\司机.txt", True)
                xr.WriteLine(ComboBox2.Text)
                xr.Flush()
                xr.Close()
            End If
        End If


        If ComboBox3.Text.Length > 0 Then
            If ComboBox3.FindString(ComboBox3.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\车型.txt", True)
                xr.WriteLine(ComboBox3.Text)
                xr.Flush()
                xr.Close()
            End If
        End If



        If ComboBox4.Text.Length > 0 Then
            If ComboBox4.FindString(ComboBox4.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\电话.txt", True)
                xr.WriteLine(ComboBox4.Text)
                xr.Flush()
                xr.Close()
            End If
        End If





    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If (MessageBox.Show("您确定要保存此笔记录?(Y/N)", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK) Then
          
            savetxt()
            addtxt()




            Dim objcommand As New SqlCommand
            ' Dim objdatareader As SqlDataReader


            objcommand.Connection = objconnection
            objcommand.CommandText = "insert into car_car (车号,司机,电话,车型,备注) values ( @车号,@司机,@电话,@车型,@备注)"




            objcommand.Parameters.AddWithValue("@车号", Trim(ComboBox1.Text))

            objcommand.Parameters.AddWithValue("@司机", Trim(ComboBox2.Text))

            objcommand.Parameters.AddWithValue("@电话", Trim(ComboBox4.Text))

            objcommand.Parameters.AddWithValue("@车型", Trim(ComboBox3.Text))

            objcommand.Parameters.AddWithValue("@备注", Trim(TextBox4.Text))




      


            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommand.ExecuteNonQuery()

            ' objdatareader = objcommand.ExecuteReader



            objconnection.Close()

            MessageBox.Show(" 保存完毕")




            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from car_car"


            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "car")

            objdataview = New DataView(objdataset.Tables("car"))
            dgv.DataSource = objdataview

            'objcurrencymanager = CType(Me.BindingContext(objdataview), CurrencyManager)
            objconnection.Close()

        End If
        save.Enabled = False
    End Sub

    Private Sub 删除ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除ToolStripMenuItem.Click
        If (MessageBox.Show("您确定要删除此笔记录?(Y/N)", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK) Then

            savetxt()
            addtxt()




            Dim objcommand As New SqlCommand

            objcommand.Connection = objconnection
            objcommand.CommandText = "delete from car_car where id=" & dgv.CurrentRow.Cells("id").Value



            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommand.ExecuteNonQuery()

            objconnection.Close()

            MessageBox.Show("删除完毕")


            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from car_car"


            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "car")

            objdataview = New DataView(objdataset.Tables("car"))
            dgv.DataSource = objdataview

            'objcurrencymanager = CType(Me.BindingContext(objdataview), CurrencyManager)
            objconnection.Close()
        End If




    End Sub

    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim objcommand As New SqlCommand
        Dim objdatareader As SqlDataReader


        objcommand.Connection = objconnection
        objcommand.CommandText = "select * from car_car "





        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If

        objcommand.ExecuteNonQuery()

        objdatareader = objcommand.ExecuteReader
        Do While objdatareader.Read
            MessageBox.Show(objdatareader.Item("司机"))

        Loop

    End Sub
End Class

