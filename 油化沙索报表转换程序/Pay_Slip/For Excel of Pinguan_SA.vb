Public Class For_Excel_of_Pinguan_SA

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        opd.Filter = "EXCEL文件|*.xls;*.xlsx"

        opd.ShowDialog()

        TextBox1.Text = opd.FileName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        opd.Filter = "EXCEL文件|*.xls;*.xlsx"

        opd.ShowDialog()

        TextBox2.Text = opd.FileName
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        opd.Filter = "EXCEL文件|*.xls;*.xlsx"

        opd.ShowDialog()

        TextBox5.Text = opd.FileName
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        opd.Filter = "EXCEL文件|*.xls;*.xlsx"

        opd.ShowDialog()

        TextBox4.Text = opd.FileName
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Try

      
        If Len(TextBox1.Text) = 0 Or Len(TextBox2.Text) = 0 Then
            GoTo e
        End If



        Dim XLS As Object = CreateObject("Excel.Application")
        Dim tFilePath As String = Trim(TextBox1.Text)


        Dim XLS11 As Object = CreateObject("Excel.Application")
        Dim tFilePath11 As String = Trim(TextBox2.Text)




        Dim xlsBook As Object = XLS.WorkBooks.Open(tFilePath)
        Dim xlsBook11 As Object = XLS11.WorkBooks.Open(tFilePath11)


        XLS.Visible = False

        Dim xlssheet As Object = xlsBook.sheets(5)
        Dim xlssheet11 As Object = xlsBook11.sheets(1)

        pb.Minimum = 2
        pb.Maximum = 41


        Dim XlsRow As Integer = 2
        Dim i As Integer
        Dim XlsResult As Single
        Dim XlsName As String

        Do Until Len(xlssheet.cells(XlsRow, 13).value()) < 1 And Len(xlssheet.cells(XlsRow, 14).value()) < 1

            XlsResult = Val(xlssheet.cells(XlsRow, 14).value())
            XlsName = Trim(xlssheet.cells(XlsRow, 13).value())


            For i = 2 To 41
                pb.Minimum = i
                    If XlsName = Trim(xlssheet11.cells(5, i).value) Then

                        If XlsResult = 0 Then
                            xlssheet11.cells(Val(fromno.Text), i).value = ""
                        Else

                            xlssheet11.cells(Val(fromno.Text), i).value = XlsResult
                            ' MessageBox.Show(XlsName & XlsResult)
                        End If

                        Exit For
                    End If

                Next



            XlsRow += 1

        Loop


        ' xlssheet11.Range(xlssheet11.Cells(1, 1), xlssheet11.Cells(b + 1, 3)).Font.Name = "宋体"
        ' xlssheet11.Range(xlssheet11.Cells(1, 1), xlssheet11.Cells(b + 1, 3)).Font.size = 9

        pb.Visible = False
        XLS11.Visible = True
        '--------------------------------------------------------------------------
        xlssheet = Nothing '释放sheet对象
        xlssheet11 = Nothing

        xlsBook.Close()  '关闭文件
        xlsBook = Nothing
        xlsBook11.Close()  '关闭文件
        xlsBook11 = Nothing

        XLS.Quit() '关闭Excel
        XLS = Nothing

        XLS11.Quit() '关闭Excel
        XLS11 = Nothing


        Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("excel")



e:
            GC.Collect()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "异常提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

  



    Private Sub For_Excel_of_Pinguan_SA_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed


        Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("excel")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try


      
        If Len(TextBox4.Text) = 0 Or Len(TextBox5.Text) = 0 Then
            GoTo e
        End If



        Dim XLS As Object = CreateObject("Excel.Application")
        Dim tFilePath As String = Trim(TextBox5.Text)


        Dim XLS11 As Object = CreateObject("Excel.Application")
        Dim tFilePath11 As String = Trim(TextBox4.Text)




        Dim xlsBook As Object = XLS.WorkBooks.Open(tFilePath)
        Dim xlsBook11 As Object = XLS11.WorkBooks.Open(tFilePath11)


        XLS.Visible = False

        Dim xlssheet As Object = xlsBook.sheets(4)
        Dim xlssheet11 As Object = xlsBook11.sheets(2)

        pb.Minimum = 2
        pb.Maximum = 61


        Dim XlsRow As Integer = 2
        Dim i As Integer
        Dim XlsResult As Single
        Dim XlsName As String

        Do Until Len(xlssheet.cells(XlsRow, 13).value()) < 1 And Len(xlssheet.cells(XlsRow, 14).value()) < 1

            XlsResult = Val(xlssheet.cells(XlsRow, 14).value())
            XlsName = Trim(xlssheet.cells(XlsRow, 13).value())


            For i = 2 To 61
                pb.Minimum = i
                    If XlsName = Trim(xlssheet11.cells(5, i).value) Then
                        If XlsResult = 0 Then
                            xlssheet11.cells(Val(fromno.Text), i).value = ""
                        Else
                            xlssheet11.cells(Val(fromno.Text), i).value = XlsResult
                            ' MessageBox.Show(XlsName & XlsResult)
                        End If


                        Exit For

                    End If

            Next



            XlsRow += 1

        Loop


        ' xlssheet11.Range(xlssheet11.Cells(1, 1), xlssheet11.Cells(b + 1, 3)).Font.Name = "宋体"
        ' xlssheet11.Range(xlssheet11.Cells(1, 1), xlssheet11.Cells(b + 1, 3)).Font.size = 9

        pb.Visible = False
        XLS11.Visible = True
        '--------------------------------------------------------------------------
        xlssheet = Nothing '释放sheet对象
        xlssheet11 = Nothing

        xlsBook.Close()  '关闭文件
        xlsBook = Nothing
        xlsBook11.Close()  '关闭文件
        xlsBook11 = Nothing

        XLS.Quit() '关闭Excel
        XLS = Nothing

        XLS11.Quit() '关闭Excel
        XLS11 = Nothing


        Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("excel")



e:
            GC.Collect()



        Catch ex As Exception
            MessageBox.Show(ex.Message, "异常提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class