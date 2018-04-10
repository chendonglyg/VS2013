Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO.Ports
Imports System.Threading
Imports Microsoft.Win32
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class SETBUND
    Dim forreport As New SqlDataAdapter

    Public afterdel As String
    Dim a As Integer '附件数量计数器
    Dim somelujing(100, 4) As String
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet

    Private Sub SETBUND_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      



        'objdataadapter.SelectCommand = New SqlCommand
        'objdataadapter.SelectCommand.Connection = objconnection
        'objdataadapter.SelectCommand.CommandText = "select * from dibangcanshu order by id desc"

        'Me.TopMost = True
        'If objconnection.State = ConnectionState.Closed Then
        '    objconnection.Open()
        'End If
        'objdataset = New DataSet
        'objdataadapter.Fill(objdataset, "dc")

        'objdataview = New DataView(objdataset.Tables("dc"))

        'objconnection.Close()


        'dgv.DataSource = objdataview




        Dim sr As IO.StreamReader
        sr = New System.IO.StreamReader(Application.StartupPath & "\波特率.txt", True)


        pinpai.Text = sr.ReadLine
        sr.Peek()

        tongxunkou.Text = sr.ReadLine
        sr.Peek()

        bitelv.Text = sr.ReadLine
        sr.Peek()

        xiaoyanwei.Text = sr.ReadLine
        sr.Peek()

        shujuwei.Text = sr.ReadLine
        sr.Peek()

        tingzhiwei.Text = sr.ReadLine





        ' MessageBox.Show(sr.ReadToEnd)
        'MessageBox.Show(OpenFileDialog1.FileName)
        sr.Close()
        sr = Nothing
    End Sub


    Public Sub clearbindtextbox(ByVal cc As Control.ControlCollection)

        For Each ctl As Control In cc

            If TypeOf ctl Is TextBox Then

                ctl.DataBindings.Clear()

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '递归调用

            End If

        Next

        For Each ctl As Control In cc

            If TypeOf ctl Is ComboBox Then

                ctl.DataBindings.Clear()

            ElseIf ctl.Controls.Count > 0 Then

                clearbindtextbox(ctl.Controls) '递归调用

            End If

        Next




    End Sub
    Public Sub bindfields()


        If objdataview.Count > 0 Then



            clearbindtextbox(Me.Controls)



            '-------------------------------------------------------------------------------------------------------------------


            pinpai.DataBindings.Add("text", objdataview, "product_name")
            tongxunkou.DataBindings.Add("text", objdataview, "mportname")

            bitelv.DataBindings.Add("text", objdataview, "mbaudrate")
            xiaoyanwei.DataBindings.Add("text", objdataview, "mpartity")
            shujuwei.DataBindings.Add("text", objdataview, "mdatabit")
            tingzhiwei.DataBindings.Add("text", objdataview, "mstopbit")
           



        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      
        Dim xr As New IO.StreamWriter(Application.StartupPath & "\波特率.txt", False)

        xr.WriteLine(pinpai.Text)

        xr.WriteLine(tongxunkou.Text)

        xr.WriteLine(bitelv.Text)

        xr.WriteLine(xiaoyanwei.Text)

        xr.WriteLine(shujuwei.Text)

        xr.WriteLine(tingzhiwei.Text)


        xr.Flush()
        xr.Close()
        MessageBox.Show("设置已保存至本机", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
          
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class