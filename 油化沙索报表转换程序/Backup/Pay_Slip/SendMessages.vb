
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO



Public Class Send_Messages

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        opd.Filter = "TXT文件|*.txt"

        opd.ShowDialog()

        TextBox1.Text = opd.FileName

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        opd.Filter = "EXCEL文件|*.xls"

        opd.ShowDialog()

        TextBox2.Text = opd.FileName
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
   


        On Error Resume Next


     
            Dim XLS As Object = CreateObject("Excel.Application")
            Dim tFilePath As String = Trim(TextBox2.Text)
        Dim tFilePathtxt As String = Trim(TextBox1.Text)


            Dim xlsBook As Object = XLS.WorkBooks.Open(tFilePath)

            XLS.Visible = False


        Dim xlssheet As Object = xlsBook.sheets(Val(sheetno.Text))
            Dim a As Integer
            a = 0


            pb.Maximum = Val(zuida.Text) + Val(weizhi.Text)
            zuidashu.Text = pb.Maximum
            pb.Minimum = 0

            pb.Value = Val(weizhi.Text)

            pb.Visible = True




        Dim sr As IO.StreamReader
        sr = New System.IO.StreamReader(tFilePathtxt)



        Dim riqi As Date
        Dim riqijishu As Integer
 

        riqijishu = 0



            Dim b As Integer '从B行开始的基数


        For b = 1 To Val(fromno.Text)

            sr.ReadLine()
        Next


        For b = Val(weizhi.Text) To pb.Maximum


            xlssheet.cells(b, 1).value = "'" & xlssheet.cells(b - 1, 1).value + 1


            xlssheet.cells(b, 2).value = "成功"



            riqi = xlssheet.cells(b - 1, 3).value()  '将上行日期给riqi变量

            If riqijishu < 70 Then

                xlssheet.cells(b, 3).value = "'" & riqi

                riqijishu = riqijishu + 1
            Else


                xlssheet.cells(b, 3).value = "'" & riqi.AddSeconds(17)

                riqijishu = 0

            End If



            xlssheet.cells(b, 5).value = "'" & xlssheet.cells(b - 1, 5).value






            If sr.Peek > 0 Then
                xlssheet.cells(b, 4).value = "'" & sr.ReadLine


            Else

                sr = New System.IO.StreamReader(tFilePathtxt)
                xlssheet.cells(b, 4).value = "'" & sr.ReadLine


            End If












            Application.DoEvents()

            dangqianshu.Text = b

            pb.Value = b
            Application.DoEvents()





        Next






        XLS.Visible = True



        ' xlsBook.Application.Quit()
        XLS = Nothing

        Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("excel")




        sr.Close()
        sr = Nothing


































        'xlssheet.Range(xlssheet.Cells(1, 1), xlssheet.Cells(b + 1, 3)).Font.Name = "宋体"
        'xlssheet.Range(xlssheet.Cells(1, 1), xlssheet.Cells(b + 1, 3)).Font.size = 9

        pb.Visible = False





    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pb.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Visible = False
    End Sub

    Private Sub zongliang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zongliang.TextChanged
        zuida.Text = Val(zongliang.Text) - Val(weizhi.Text)
    End Sub

    Private Sub weizhi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles weizhi.TextChanged
        zuida.Text = Val(zongliang.Text) - Val(weizhi.Text)
    End Sub
End Class
