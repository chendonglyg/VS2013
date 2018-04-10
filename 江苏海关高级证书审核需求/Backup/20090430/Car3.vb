Imports System.Data.SqlClient
Imports System.Data
Public Class car3
    Dim sr As New Integer
    Dim srf As New Integer

    Dim forreport As New SqlDataAdapter

    Dim objconnection As New SqlConnection("Data Source= lyg.yihai.com;Initial Catalog = package;User ID=sa; Password=chen dong")
    Public afterdel As String

    Dim objdataadapter As New SqlDataAdapter
    Dim olda, oldb As Integer

    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub Car3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1


    End Sub
    Private Sub ClearTextBox(ByVal cc As Control.ControlCollection)

        For Each ctl As Control In cc

            If TypeOf ctl Is TextBox Then

                CType(ctl, TextBox).Text = String.Empty

            ElseIf ctl.Controls.Count > 0 Then

                ClearTextBox(ctl.Controls) '递归调用

            End If

        Next

        For Each ctl As Control In cc

            If TypeOf ctl Is ComboBox Then

                CType(ctl, ComboBox).Text = String.Empty

            ElseIf ctl.Controls.Count > 0 Then

                ClearTextBox(ctl.Controls) '递归调用

            End If

        Next

    End Sub

    Public Sub clearbindtextbox(ByVal cc As Control.ControlCollection)

        For Each ctl As Control In cc

            If TypeOf ctl Is TextBox Then

                ctl.DataBindings.Clear()

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '递归调用清除textbox绑定

            End If

        Next

        For Each ctl As Control In cc

            If TypeOf ctl Is ComboBox Then

                ctl.DataBindings.Clear()

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '递归调用清楚combobox绑定

            End If

        Next

        For Each ctl As Control In cc

            If TypeOf ctl Is MaskedTextBox Then

                ctl.DataBindings.Clear()

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '递归调用清楚combobox绑定

            End If

        Next



    End Sub

 

  

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        Dim dm11 As New Date
        dm11 = DT11.Value
        Dim dm12 As New Date
        dm12 = dt12.Value


        If Checkchehao.CheckState = CheckState.Checked Then

            objdataadapter.SelectCommand.CommandText = "select * from car_events where 发车日期 between  '" & dm11.ToString("yyyy/MM/dd") & "' and '" & dm12.ToString("yyyy/MM/dd") & "'and 车号 ='" & chehao.Text & "'"
        Else
            objdataadapter.SelectCommand.CommandText = "select * from car_events where 发车日期 between  '" & dm11.ToString("yyyy/MM/dd") & "' and '" & dm12.ToString("yyyy/MM/dd") & "'"

        End If






        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "car")

        objdataview = New DataView(objdataset.Tables("car"))
        dgv.DataSource = objdataview


    End Sub


    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim oRpt As New CrystalReport1

        oRpt.SetDataSource(objdataset.Tables("car"))


        Car4.Show()
        Car4.CrystalReportViewer1.ReportSource = oRpt
    End Sub
End Class