Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class ForCharlie
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlDataAdapter
    Private Sub ForCharlie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        opd.Filter = "EXCEL文件|*.xls;*xlsx"

        opd.ShowDialog()

        TextBox1.Text = opd.FileName
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Len(TextBox1.Text) = 0 Then
            MessageBox.Show("请先选择EXCEL模板", "提示", MessageBoxButtons.OK)
            Me.Close()
        Else

            '---------------------------------------------------------------
          

            '------------------------------------------------------------------


            Dim XLS As Object = CreateObject("Excel.Application")
            Dim tFilePath As String = Trim(TextBox1.Text)
            Dim xlsBook As Object = XLS.WorkBooks.Open(tFilePath)
            Dim xlssheet1 As Object = xlsBook.sheets(Val(sheet1.Text))
            Dim xlssheet2 As Object = xlsBook.sheets(Val(sheet2.Text))

            Dim a, b, c, d As Integer
            a = Val(sheet1_hang.Text)     'sheet1的行和列
            b = Val(sheet1_lie.Text)
            c = Val(sheet2_hang.Text)     'sheet2的行和列
            d = Val(sheet2_lie.Text)



            pb.Minimum = 1
            pb.Maximum = a * b * c * d + 1

            pb.Value = 1

            Dim meizhaodao As Boolean

            Dim jishu1, jishu2, jishu3, jishu4 As Integer

            For jishu1 = 1 To a
                For jishu2 = 1 To b
                    meizhaodao = True

                    If Len(Trim((xlssheet1.cells(jishu1, jishu2).value()))) <> 0 Then

                        For jishu3 = 1 To c
                            For jishu4 = 1 To d


                                If Len(xlssheet2.cells(jishu3, jishu4).value()) <> 0 Then

                                    If Trim(xlssheet1.cells(jishu1, jishu2).value()) = Trim(xlssheet2.cells(jishu3, jishu4).value()) Then


                                        meizhaodao = False

                                        GoTo jieshu1
                                    End If

                                End If



jieshu1:




                                Application.DoEvents()
                                pb.Value = pb.Value + 1
                                Application.DoEvents()
                            Next
                        Next

                    End If

                    If meizhaodao = True Then
                        xlssheet1.cells(jishu1, jishu2).Interior.ColorIndex = 3
                    End If



                Next
            Next


            XLS.Visible = True









            '-------------------------------------------

        End If





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("excel")
        For Each proc As System.Diagnostics.Process In pList
            Try
                proc.Kill()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

    End Sub
End Class