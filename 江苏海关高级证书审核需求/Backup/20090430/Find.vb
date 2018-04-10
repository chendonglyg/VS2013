
Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32










Public Class Find
    'Dim objconnection As New SqlConnection("server=(local);database=package;user id=sa;password=chen dong")

    Dim objconnection As New SqlConnection("Data Source= 218.92.113.9;Initial Catalog = package;User ID=sa; Password=chen dong")

    Dim forreport As New SqlDataAdapter

   

    Dim objdataadapter As New SqlDataAdapter
 

    'Dim objdataview As New DataView
    Dim objdataset As New DataSet
    Dim objcurrencymanager As System.Windows.Forms.CurrencyManager

    Private Sub filldatasetandview()
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from trade order by 序号 desc"

        objconnection.Open()
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "trade")
        forreport = objdataadapter '供打印使用
        objdataview = New DataView(objdataset.Tables("trade"))
        objcurrencymanager = CType(Me.BindingContext(objdataview), CurrencyManager)
        objconnection.Close()

    End Sub

    Private Sub bindfields()
      




        TextBox1.DataBindings.Clear()
        TextBox2.DataBindings.Clear()
        TextBox3.DataBindings.Clear()
        TextBox4.DataBindings.Clear()
        TextBox5.DataBindings.Clear()
        TextBox6.DataBindings.Clear()
        TextBox7.DataBindings.Clear()
        TextBox8.DataBindings.Clear()
        TextBox9.DataBindings.Clear()
        TextBox10.DataBindings.Clear()
        TextBox11.DataBindings.Clear()
        TextBox12.DataBindings.Clear()
        TextBox18.DataBindings.Clear()
        TextBox19.DataBindings.Clear()
        TextBox20.DataBindings.Clear()
        TextBox21.DataBindings.Clear()
        TextBox22.DataBindings.Clear()
        TextBox23.DataBindings.Clear()
        TextBox24.DataBindings.Clear()

        TextBox1.DataBindings.Add("text", objdataview, "序号")
        TextBox18.DataBindings.Add("text", objdataview, "班组")
        TextBox2.DataBindings.Add("text", objdataview, "品种名称")





        TextBox3.DataBindings.Add("text", objdataview, "规格")
        TextBox4.DataBindings.Add("text", objdataview, "生产线")
        TextBox24.DataBindings.Add("text", objdataview, "生产线2")

        TextBox5.DataBindings.Add("text", objdataview, "生产日期1")
        TextBox19.DataBindings.Add("text", objdataview, "生产日期2")
        TextBox20.DataBindings.Add("text", objdataview, "生产日期3")
        TextBox21.DataBindings.Add("text", objdataview, "生产日期4")
        TextBox22.DataBindings.Add("text", objdataview, "生产日期5")

        TextBox23.DataBindings.Add("text", objdataview, "录入时间")

        TextBox6.DataBindings.Add("text", objdataview, "库位")
        TextBox7.DataBindings.Add("text", objdataview, "车号")
        TextBox8.DataBindings.Add("text", objdataview, "件数")
        TextBox9.DataBindings.Add("text", objdataview, "客户名称")
        TextBox10.DataBindings.Add("text", objdataview, "发货日期")

        TextBox11.DataBindings.Add("text", objdataview, "装车时间")
        TextBox12.DataBindings.Add("text", objdataview, "货物喷码")




    End Sub
    Private Sub showposition()
        TextBox14.Text = objcurrencymanager.Position + 1 & " Of " & objcurrencymanager.Count

    End Sub

    Private Sub Find_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1







        Button8.Enabled = False
        Button5.Enabled = False

        filldatasetandview()
        bindfields()
        showposition()
        forreport = objdataadapter


        DataGridView1.DataSource = objdataview




    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        objcurrencymanager.Position = 0
        showposition()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        objcurrencymanager.Position -= 1
        showposition()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        objcurrencymanager.Position += 1
        showposition()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        objcurrencymanager.Position = objcurrencymanager.Count - 1
        showposition()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim dm As New Date
        dm = DateTime1.Value


        objdataadapter = New SqlDataAdapter
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection

        objconnection.Open()
        objdataadapter.SelectCommand.CommandText = "select * from trade where 1=1"
        If c1.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & " and 品种名称 = " & "'" & TextBox13.Text & "'"
        End If

        If c2.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & " and 规格 = " & "'" & TextBox15.Text & "'"
        End If

        If c3.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & " and 生产线 = " & "'" & TextBox16.Text & "' or 生产线2= " & "'" & TextBox16.Text & "'"
        End If

        If c4.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & " and (convert(varchar(10),生产日期1,111) ='" & dm.ToString("yyyy/MM/dd") & "' or convert(varchar(10),生产日期2,111) ='" & dm.ToString("yyyy/MM/dd") & "' or convert(varchar(10),生产日期3,111) ='" & dm.ToString("yyyy/MM/dd") & "' or convert(varchar(10),生产日期4,111) ='" & dm.ToString("yyyy/MM/dd") & "' or convert(varchar(10),生产日期5,111) ='" & dm.ToString("yyyy/MM/dd") & "')"


        End If

        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "trade")





        forreport = objdataadapter '供打印使用




        objdataview = New DataView(objdataset.Tables("trade"))

        objcurrencymanager = CType(Me.BindingContext(objdataview), CurrencyManager)
        objconnection.Close()



        bindfields()


        showposition()
        DataGridView1.DataSource = objdataview




    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        filldatasetandview()
        bindfields()
        showposition()

    End Sub


    Private Sub c1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1.CheckedChanged
        If c1.Checked = True Then
            TextBox13.Enabled = True
            Button5.Enabled = True
        Else
            TextBox13.Enabled = False
            If (c1.Checked = False) And (c2.Checked = False) And (c3.Checked = False) And (c4.Checked = False) Then
                Button5.Enabled = False
            End If
        End If
        TextBox13.Text = ""



    End Sub

    Private Sub c2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2.CheckedChanged
        If c2.Checked = True Then
            TextBox15.Enabled = True
            Button5.Enabled = True
        Else
            TextBox15.Enabled = False
            If (c1.Checked = False) And (c2.Checked = False) And (c3.Checked = False) And (c4.Checked = False) Then
                Button5.Enabled = False
            End If
        End If
        TextBox15.Text = ""
    End Sub

    Private Sub c3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3.CheckedChanged
        If c3.Checked = True Then
            TextBox16.Enabled = True
            Button5.Enabled = True
        Else
            TextBox16.Enabled = False
            If (c1.Checked = False) And (c2.Checked = False) And (c3.Checked = False) And (c4.Checked = False) Then
                Button5.Enabled = False
            End If
        End If
        TextBox16.Text = ""
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub



    Private Sub C5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C5.CheckedChanged
        If C5.Checked = True Then
            TextBox17.Enabled = True
            Button8.Enabled = True
        Else
            TextBox17.Enabled = False
            Button8.Enabled = False
        End If
        TextBox16.Text = ""
    End Sub

    Private Sub c4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c4.CheckedChanged
        If c4.Checked = True Then
            DateTime1.Enabled = True
            Button5.Enabled = True
        Else
            DateTime1.Enabled = False
            If (c1.Checked = False) And (c2.Checked = False) And (c3.Checked = False) And (c4.Checked = False) Then
                Button5.Enabled = False
            End If
        End If


    End Sub



    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        objdataadapter = New SqlDataAdapter
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection

        objconnection.Open()
        objdataadapter.SelectCommand.CommandText = "select * from trade where 货物喷码 like '%" & Trim(TextBox17.Text) & "%' or 货物喷码 like '" & Trim(TextBox17.Text) & "%'"







        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "trade")
        objdataview = New DataView(objdataset.Tables("trade"))
        objcurrencymanager = CType(Me.BindingContext(objdataview), CurrencyManager)
        objconnection.Close()


        bindfields()
        showposition()


        DataGridView1.DataSource = objdataview

        forreport = objdataadapter '供打印使用




    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dm As New Date

        dm = DateTime1.Value




        objdataadapter = New SqlDataAdapter
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection

        objconnection.Open()
        ' objdataadapter.SelectCommand.CommandText = "select * from trade where 货物喷码 like '%" & Trim(TextBox17.Text) & "%' or 货物喷码 like '" & Trim(TextBox17.Text) & "%'"

        objdataadapter.SelectCommand.CommandText = "select * from trade where convert(varchar(30),生产日期1,111) ='" & dm.ToString("yyyy/MM/dd") & "' or convert(varchar(30),生产日期2,111) ='" & dm.ToString("yyyy/MM/dd") & "' or convert(varchar(30),生产日期3,111) ='" & dm.ToString("yyyy/MM/dd") & "' or convert(varchar(30),生产日期4,111) ='" & dm.ToString("yyyy/MM/dd") & "' or convert(varchar(30),生产日期5,111) ='" & dm.ToString("yyyy/MM/dd") & "'"











        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "trade")
        objdataview = New DataView(objdataset.Tables("trade"))
        objcurrencymanager = CType(Me.BindingContext(objdataview), CurrencyManager)
        objconnection.Close()


        bindfields()
        showposition()


        DataGridView1.DataSource = objdataview



    End Sub

    Private Sub reportview1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
 
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            Dim intpostion As Integer
            Dim objcommand As New SqlCommand


            intpostion = objcurrencymanager.Position - 1

            If intpostion < 0 Then
                intpostion = 0
            End If

            objcommand.Connection = objconnection
            objcommand.CommandText = "delete from trade where 序号=@序号"
            objcommand.Parameters.AddWithValue("@序号", BindingContext(objdataview).Current("序号")) '就删除当前这个序号指定的记录

            objconnection.Open()
            objcommand.ExecuteNonQuery()
            objconnection.Close()


            filldatasetandview()
            bindfields()

            objcurrencymanager.Position = intpostion

            showposition()
            DataGridView1.DataSource = objdataview
        Catch ex As Exception
            MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
       


    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click


        'Dim rk As RegistryKey = Registry.CurrentUser.CreateSubKey("RegistrySetValueExample")

        '' Create name/value pairs.
        '' Numeric values that cannot be interpreted as DWord (int) values
        '' are stored as strings.
        'rk.SetValue("LargeNumberValue1", CType(42, Long))
        'rk.SetValue("LargeNumberValue2", 42000000000)

        'rk.SetValue("DWordValue", 42)
        'rk.SetValue("MultipleStringValue", New String() {"One", "Two", "Three"})
        'rk.SetValue("BinaryValue", New Byte() {10, 43, 44, 45, 14, 255})

        '' This overload of SetValue does not support expanding strings. Use
        '' the overload that allows you to specify RegistryValueKind.
        'rk.SetValue("StringValue", "The path is %PATH%")



        Dim rkCurrentUser As RegistryKey = Registry.CurrentUser


        Dim rkTest As RegistryKey = rkCurrentUser.OpenSubKey("Control Panel\International", True)

        rkTest.SetValue("sShortDate", "yyyy-MM-dd")

        rkTest.Close()
        rkCurrentUser.Close()



    End Sub

    'Public Class Example
    '    Public Shared Sub Main()
    '        ' Delete and recreate the test key.
    '        Registry.CurrentUser.DeleteSubKey("RegistryOpenSubKeyExample", False)
    '        Dim rk As RegistryKey = Registry.CurrentUser.CreateSubKey("RegistryOpenSubKeyExample")
    '        rk.Close()

    '        ' Obtain an instance of RegistryKey for the CurrentUser registry 
    '        ' root. 
    '        Dim rkCurrentUser As RegistryKey = Registry.CurrentUser

    '        ' Obtain the test key (read-only) and display it.
    '        Dim rkTest As RegistryKey = rkCurrentUser.OpenSubKey("RegistryOpenSubKeyExample")
    '        Console.WriteLine("Test key: {0}", rkTest)
    '        rkTest.Close()
    '        rkCurrentUser.Close()

    '        ' Obtain the test key in one step, using the CurrentUser registry 
    '        ' root.
    '        rkTest = Registry.CurrentUser.OpenSubKey("RegistryOpenSubKeyExample")
    '        Console.WriteLine("Test key: {0}", rkTest)
    '        rkTest.Close()

    '        ' Obtain the test key in read/write mode.
    '        rkTest = Registry.CurrentUser.OpenSubKey("RegistryOpenSubKeyExample", True)
    '        rkTest.SetValue("TestName", "TestValue")
    '        Console.WriteLine("Test value for TestName: {0}", rkTest.GetValue("TestName"))
    '        rkTest.Close()
    '    End Sub 'Main
    'End Class 'Example

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim rkCurrentUser As RegistryKey = Registry.CurrentUser


        Dim rkTest As RegistryKey = rkCurrentUser.OpenSubKey("Control Panel\International", True)

        rkTest.SetValue("sShortDate", "yyyy/MM/dd")

        rkTest.Close()
        rkCurrentUser.Close()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    

    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click



    End Sub
End Class