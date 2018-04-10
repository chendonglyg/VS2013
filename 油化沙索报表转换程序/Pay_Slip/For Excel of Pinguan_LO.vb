
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Public Class For_Excel_of_Pinguan_LO
    Dim c6, d As Integer
    Dim clocknum As Integer

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        opd.Filter = "EXCEL文件|*.xls;*.xlsx"

        opd.ShowDialog()

        TextBox1.Text = opd.FileName
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        opd.Filter = "EXCEL文件|*.xls;*.xlsx"

        opd.ShowDialog()

        TextBox2.Text = opd.FileName
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Len(TextBox1.Text) = 0 Or Len(TextBox2.Text) = 0 Then
            GoTo e
        End If



        On Error Resume Next
        Dim XLS As Object = CreateObject("Excel.Application")
        Dim tFilePath As String = Trim(TextBox1.Text)


        Dim XLS11 As Object = CreateObject("Excel.Application")
        Dim tFilePath11 As String = Trim(TextBox2.Text)




        Dim xlsBook As Object = XLS.WorkBooks.Open(tFilePath)
        Dim xlsBook11 As Object = XLS11.WorkBooks.Open(tFilePath11)


        XLS.Visible = False

        Dim xlssheet As Object = xlsBook.sheets(5)
        Dim xlssheet11 As Object = xlsBook11.sheets(2)

        Dim a As Integer
        a = 0
        Do While Len((xlssheet.cells(1 + a, 3).value)) > 0
            'MessageBox.Show(xlssheet.cells(1 + a, 2).value)
            a = a + 1
        Loop

        'MessageBox.Show(a)



        pb.Maximum = a - 1
        pb.Minimum = 0

        pb.Value = 0

        pb.Visible = True


        Dim b, C As Integer

        C = 24
        ' xlssheet11.warptext = True


        For b = 0 To a - 1



            If Trim((xlssheet.cells(2 + b, 13).value())) = "C6:0" Then

                xlssheet11.cells(Val(fromno.Text), C).value = Trim((xlssheet.cells(2 + b, 14).value()))

            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C7:0" Then

                xlssheet11.cells(Val(fromno.Text), C + 1).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If
            If Trim((xlssheet.cells(2 + b, 13).value())) = "C8:0" Then

                xlssheet11.cells(Val(fromno.Text), C + 2).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C9:0" Then

                xlssheet11.cells(Val(fromno.Text), C + 3).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If
            If Trim((xlssheet.cells(2 + b, 13).value())) = "C10:0" Then

                xlssheet11.cells(Val(fromno.Text), C + 4).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C11:0" Then

                xlssheet11.cells(Val(fromno.Text), C + 5).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If
            If Trim((xlssheet.cells(2 + b, 13).value())) = "C12:0" Then

                xlssheet11.cells(Val(fromno.Text), C + 6).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If
            If Trim((xlssheet.cells(2 + b, 13).value())) = "C13:0" Then

                xlssheet11.cells(Val(fromno.Text), C + 7).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If
            If Trim((xlssheet.cells(2 + b, 13).value())) = "C14:0" Then

                xlssheet11.cells(Val(fromno.Text), C + 8).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If
            If Trim((xlssheet.cells(2 + b, 13).value())) = "C15:0" Then

                xlssheet11.cells(Val(fromno.Text), C + 9).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C16:0" Then

                xlssheet11.cells(Val(fromno.Text), C + 10).value = Trim((xlssheet.cells(2 + b, 14).value()))

            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C16:1" Then

                xlssheet11.cells(Val(fromno.Text), C + 11).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If
            If Trim((xlssheet.cells(2 + b, 13).value())) = "C17:0" Then

                xlssheet11.cells(Val(fromno.Text), C + 12).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C18:0" Then

                xlssheet11.cells(Val(fromno.Text), C + 13).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C18:1" Then

                xlssheet11.cells(Val(fromno.Text), C + 14).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If


            If Trim((xlssheet.cells(2 + b, 13).value())) = "C18:2" Then

                xlssheet11.cells(Val(fromno.Text), C + 15).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C18:3" Then

                xlssheet11.cells(Val(fromno.Text), C + 16).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C20:0" Then

                xlssheet11.cells(Val(fromno.Text), C + 17).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C20:1" Then

                xlssheet11.cells(Val(fromno.Text), C + 18).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If








            pb.Value = b

            Application.DoEvents()

        Next

        ' xlssheet11.Range(xlssheet11.Cells(1, 1), xlssheet11.Cells(b + 1, 3)).Font.Name = "宋体"
        ' xlssheet11.Range(xlssheet11.Cells(1, 1), xlssheet11.Cells(b + 1, 3)).Font.size = 9

        pb.Visible = False


        XLS11.Visible = True




        xlsBook.Application.Quit()

        'xlsBook11.Application.save()

        xlsBook11.Application.Quit()


        xlsBook.close()
        xlsBook11.close()

        xlssheet = Nothing
        xlssheet11 = Nothing
        xlsBook = Nothing
        xlsBook11 = Nothing
        XLS = Nothing
        XLS11 = Nothing

e:
        GC.Collect()






    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        opd.Filter = "EXCEL文件|*.xls;*.xlsx"

        opd.ShowDialog()

        TextBox5.Text = opd.FileName
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        opd.Filter = "EXCEL文件|*.xls;*.xlsx"

        opd.ShowDialog()

        TextBox4.Text = opd.FileName
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        clocknum = 0
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        clocknum = 1
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        clocknum = 2
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        clocknum = 3
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        clocknum = 4
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        clocknum = 5
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        clocknum = 6
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        clocknum = 7
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        clocknum = 8
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        clocknum = 9
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        clocknum = 10
        d = 7

    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged
        clocknum = 11
    End Sub

    Private Sub RadioButton24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton24.CheckedChanged
        clocknum = 12
    End Sub

    Private Sub RadioButton23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton23.CheckedChanged
        clocknum = 13
    End Sub

    Private Sub RadioButton22_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton22.CheckedChanged
        clocknum = 14
    End Sub

    Private Sub RadioButton21_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton21.CheckedChanged
        clocknum = 15
    End Sub

    Private Sub RadioButton20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton20.CheckedChanged
        clocknum = 16
    End Sub

    Private Sub RadioButton19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton19.CheckedChanged
        clocknum = 17
    End Sub

    Private Sub RadioButton18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton18.CheckedChanged
        clocknum = 18
    End Sub

    Private Sub RadioButton17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton17.CheckedChanged
        clocknum = 19
    End Sub

    Private Sub RadioButton16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton16.CheckedChanged
        clocknum = 20
    End Sub

    Private Sub RadioButton15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton15.CheckedChanged
        clocknum = 21
    End Sub

    Private Sub RadioButton14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton14.CheckedChanged
        clocknum = 22
    End Sub

    Private Sub RadioButton13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton13.CheckedChanged
        clocknum = 23
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        On Error Resume Next

        c6 = Val(fromc6.Text)
        Select Case clocknum
            Case 0
                d = 21
            Case 1
                d = 22
            Case 2
                d = 23
            Case 3
                d = 24
            Case 4
                d = 25
            Case 5
                d = 26
            Case 6
                d = 27
            Case 7
                d = 28
            Case 8
                d = 6
            Case 9
                d = 6
            Case 10
                d = 7
            Case 11
                d = 8
            Case 12
                d = 9
            Case 13
                d = 10
            Case 14
                d = 11
            Case 15
                d = 12
            Case 16
                d = 13
            Case 17
                d = 14
            Case 18
                d = 15
            Case 19
                d = 16
            Case 20
                d = 17
            Case 21
                d = 18
            Case 22
                d = 19
            Case 23
                d = 20
        End Select


        If Len(TextBox5.Text) = 0 Or Len(TextBox4.Text) = 0 Then
            GoTo e
        End If



        Dim XLS As Object = CreateObject("Excel.Application")
        Dim tFilePath As String = Trim(TextBox5.Text)


        Dim XLS11 As Object = CreateObject("Excel.Application")
        Dim tFilePath11 As String = Trim(TextBox4.Text)




        Dim xlsBook As Object = XLS.WorkBooks.Open(tFilePath)
        Dim xlsBook11 As Object = XLS11.WorkBooks.Open(tFilePath11)


        XLS.Visible = False

        Dim xlssheet As Object = xlsBook.sheets(5)
        Dim xlssheet11 As Object = xlsBook11.sheets(1)

        Dim a As Integer
        a = 0
        Do While Len((xlssheet.cells(1 + a, 3).value)) > 0
            'MessageBox.Show(xlssheet.cells(1 + a, 2).value)
            a = a + 1
        Loop

        'MessageBox.Show(a)



        pb.Maximum = a - 1
        pb.Minimum = 0

        pb.Value = 0

        pb.Visible = True


        Dim b As Integer


        ' xlssheet11.warptext = True


        For b = 0 To a - 1



            If Trim((xlssheet.cells(2 + b, 13).value())) = "C6:0" Then

                xlssheet11.cells(c6 + 0, d).value = Trim((xlssheet.cells(2 + b, 14).value()))

            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C7:0" Then

                xlssheet11.cells(c6 + 1, d).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If
            If Trim((xlssheet.cells(2 + b, 13).value())) = "C8:0" Then

                xlssheet11.cells(c6 + 2, d).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C9:0" Then

                xlssheet11.cells(c6 + 3, d).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If
            If Trim((xlssheet.cells(2 + b, 13).value())) = "C10:0" Then

                xlssheet11.cells(c6 + 4, d).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C11:0" Then

                xlssheet11.cells(c6 + 5, d).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If
            If Trim((xlssheet.cells(2 + b, 13).value())) = "C12:0" Then

                xlssheet11.cells(c6 + 6, d).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If
            If Trim((xlssheet.cells(2 + b, 13).value())) = "C13:0" Then

                xlssheet11.cells(c6 + 7, d).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If
            If Trim((xlssheet.cells(2 + b, 13).value())) = "C14:0" Then

                xlssheet11.cells(c6 + 8, d).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If
            If Trim((xlssheet.cells(2 + b, 13).value())) = "C15:0" Then

                xlssheet11.cells(c6 + 9, d).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C16:0" Then

                xlssheet11.cells(c6 + 10, d).value = Trim((xlssheet.cells(2 + b, 14).value()))

            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C16:1" Then

                xlssheet11.cells(c6 + 11, d).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If
            If Trim((xlssheet.cells(2 + b, 13).value())) = "C17:0" Then

                xlssheet11.cells(c6 + 12, d).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C18:0" Then

                xlssheet11.cells(c6 + 13, d).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C18:1" Then

                xlssheet11.cells(c6 + 14, d).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If


            If Trim((xlssheet.cells(2 + b, 13).value())) = "C18:2" Then

                xlssheet11.cells(c6 + 15, d).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C18:3" Then

                xlssheet11.cells(c6 + 16, d).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C20:0" Then

                xlssheet11.cells(c6 + 17, d).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If

            If Trim((xlssheet.cells(2 + b, 13).value())) = "C20:1" Then

                xlssheet11.cells(c6 + 18, d).value = Trim((xlssheet.cells(2 + b, 14).value()))
            End If








            pb.Value = b

            Application.DoEvents()

        Next

        ' xlssheet11.Range(xlssheet11.Cells(1, 1), xlssheet11.Cells(b + 1, 3)).Font.Name = "宋体"
        ' xlssheet11.Range(xlssheet11.Cells(1, 1), xlssheet11.Cells(b + 1, 3)).Font.size = 9

        pb.Visible = False


        XLS11.Visible = True



        xlsBook.Application.Quit()


        xlsBook11.Application.Quit()

        xlsBook.close()
        xlsBook11.close()

        xlssheet = Nothing
        xlssheet11 = Nothing
        xlsBook = Nothing
        xlsBook11 = Nothing
        XLS = Nothing
        XLS11 = Nothing






e:
        GC.Collect()



    End Sub

    Private Sub fromc6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fromc6.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If

    End Sub



    Private Sub fromno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fromno.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c) Or Asc(e.KeyChar) = 46) Then
            '46表示按下的是.键  
            e.Handled = True
            'e.handled表示取消keypress事件  
        End If

    End Sub


    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim proc As Process
        Dim procs() As Process = Process.GetProcessesByName("excel")

        For Each proc In procs
            If Not proc.CloseMainWindow() Then
                proc.Kill()
            End If
        Next

    End Sub

    Private Sub For_Excel_of_Pinguan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub fromc6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fromc6.TextChanged

    End Sub

    Private Sub fromno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fromno.TextChanged

    End Sub
End Class