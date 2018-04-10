Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO.Ports
Imports System.Text.RegularExpressions

Public Class LoginForm1
    Public isok As Boolean

    Dim sr As New Integer
    Dim srf As New Integer

    Dim forreport As New SqlDataAdapter


    Dim objdataadapter As New SqlDataAdapter


    Public objdataview As New DataView
    Dim objdataset As New DataSet

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OKK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKK.Click
        Try
            ipipip = Trim(ipaddress.Text)
            username = Trim(UsernameTextBox.Text) '用于记录单独放行车辆的操作人员
        Dim sa, sapassword As String




        sa = "sa"
        sapassword = "chen dong"


            '----------------------------------------------------------------------------------------------------------------------

        objconnection = New SqlConnection("Data Source= " & Trim(ipaddress.Text) & "," & Trim(sqlport.Text) & ";Initial Catalog = package;User ID=" & sa & "; Password=" & sapassword)
        If ipaddress.Text.Length > 0 Then
            If ipaddress.FindString(ipaddress.Text) < 0 Then
                Dim xr As New IO.StreamWriter(Application.StartupPath & "\ipaddress.txt", True)
                xr.WriteLine(ipaddress.Text)
                xr.Flush()
                xr.Close()
            End If
        End If

            objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from users where username ='" & Trim(UsernameTextBox.Text) & "' and password ='" & Trim(PasswordTextBox.Text) & "'"


        objconnection.Open()
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "users")

        dataviewuser = New DataView(objdataset.Tables("users"))
      

        

            If dataviewuser.Count >= 1 Then


                private_data = Trim(objdataset.Tables("users").Rows(0)("station"))
                username = Trim(objdataset.Tables("users").Rows(0)("username"))

                If (System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList.Length) > 0 Then
                    For i As Integer = 0 To (System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList.Length) - 1

                        ipaddressvalues = ipaddressvalues + System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList(i).ToString + "/"


                    Next
                End If








                '----------------------------------------------------------------------------------^%^^%^%^%^^^%^^%
                'Dim NetworkInterfaces(), network As Net.NetworkInformation.NetworkInterface
                'NetworkInterfaces = Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()

                'If NetworkInterfaces.Length > 0 Then
                '    For Each network In NetworkInterfaces

                '        Mdi.ipipip.Text = Mdi.ipipip.Text +
                '        "MAC地址：" + network.GetPhysicalAddress().ToString() + Environment.NewLine +
                '             "网络连接：" + network.Name + Environment.NewLine +
                '           "网卡序列号：" + network.Id + Environment.NewLine +
                '     "网络类型：" + network.NetworkInterfaceType.ToString() + Environment.NewLine +
                '       "网络速度：" + (network.Speed / 1000000).ToString() + "MB" + Environment.NewLine

                '    Next
                'End If

                'network = NetworkInterfaces(0)
                'ipaddressvalues =
                '            "MAC地址：" + network.GetPhysicalAddress().ToString() + Environment.NewLine +
                '            "网络连接：" + network.Name + Environment.NewLine +
                '            "网卡序列号：" + network.Id + Environment.NewLine +
                '            "网络类型：" + network.NetworkInterfaceType.ToString() + Environment.NewLine +
                '            "网络速度：" + (network.Speed / 1000000).ToString() + "MB" + Environment.NewLine

                '----------------------------------------------------------------------------------------$%$%$%%$%%$%$
                Mdi.USERNAME.Text = "用户名:" & Trim(dataviewuser.Item(0).Item("username"))
                Mdi.IPADDRESSVALUES.Text = "IP和MAC地址:" & ipaddressvalues
                Mdi.COMPUTERNAME.Text = "计算机名:" & Environment.MachineName


                '  username = Trim(dataviewuser.Item(0).Item("username"))




                If UsernameTextBox.Text = "admin" Then
                    isadmin = True
                Else
                    isadmin = False
                End If
                isok = True

            Else
                isok = False
                MessageBox.Show("错误的用户名或者网络不可达!", "提醒", MessageBoxButtons.OK)
            End If





        objconnection.Close()
        Me.Close()

     

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b, c As Boolean

        b = False
        c = False

        For a = 1 To Len(PasswordTextBox.Text)
            If (Regex.IsMatch(Mid(PasswordTextBox.Text, a, 1), "^[A-Za-z]+$")) Then
                b = True
            ElseIf (Regex.IsMatch(Mid(PasswordTextBox.Text, a, 1), "^\d+$")) Then
                c = True
            End If




        Next

        If (b And c And (Len(PasswordTextBox.Text) >= 6)) Then
            MessageBox.Show(" 数字和字母混合且6位长度")
        Else
            MessageBox.Show("不满足集团要求")
        End If

    End Sub

    Private Sub UsernameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UsernameTextBox.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

   
    Private Sub PasswordTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTextBox.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub ipaddress_KeyDown(sender As Object, e As KeyEventArgs) Handles ipaddress.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub sqlport_KeyDown(sender As Object, e As KeyEventArgs) Handles sqlport.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

  
End Class
