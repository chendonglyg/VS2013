
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        opd.Filter = "EXCEL文件|*.xls;*xlsx"

        opd.ShowDialog()

        TextBox1.Text = opd.FileName

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        opd.Filter = "EXCEL文件|*.xls;*xlsx"

        opd.ShowDialog()

        TextBox2.Text = opd.FileName
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Len(TextBox1.Text) = 0 Or Len(TextBox2.Text) = 0 Then
            GoTo e
        End If



        On Error Resume Next
        Dim XLS As Object = CreateObject("Excel.Application")
        Dim tFilePath As String = Trim(TextBox1.Text)



        Dim xlsBook As Object = XLS.WorkBooks.Open(tFilePath)

        XLS.Visible = False


        Dim xlssheet As Object = xlsBook.sheets(1)
        Dim a As Integer
        a = 0
        Do While Len((xlssheet.cells(1 + a, 1).value)) > 0
            a = a + 1
        Loop


        pb.Maximum = a - 1
        pb.Minimum = 0

        pb.Value = 0

        pb.Visible = True




        Dim XLS11 As Object = CreateObject("Excel.Application")
        Dim tFilePath11 As String = Trim(TextBox2.Text)



        Dim xlsBook11 As Object = XLS11.WorkBooks.Open(tFilePath11)




        Dim xlssheet11 As Object = xlsBook11.sheets(1)
        xlssheet11.cells.clear()
        Dim b As Integer


        xlssheet11.warptext = True

        '标题
        xlssheet11.cells(b + 1, 1).value() = "短信内容"
        xlssheet11.cells(b + 1, 2).value() = "号码"
        ' xlssheet11.cells(b + 1, 3).value() = "联系人"

        xlssheet11.cells(b + 2, 1).value() = ""


        For b = 0 To a - 1


            If (Len(xlssheet.cells(2 + b, 2).value()) > 0) And (Trim(xlssheet.cells(2 + b, 2).value()) <> "-") Then
                xlssheet11.cells(b + 2, 1).value() = xlssheet11.cells(b + 2, 1).value() & "A" & xlssheet.cells(2 + b, 2).value()
            End If

            If (Len(xlssheet.cells(2 + b, 3).value()) > 0) And (Val(xlssheet.cells(2 + b, 3).value() > 0)) Then
                xlssheet11.cells(b + 2, 1).value() = xlssheet11.cells(b + 2, 1).value() & "B" & xlssheet.cells(2 + b, 3).value()
            End If

            If (Len(xlssheet.cells(2 + b, 5).value()) > 0) And (Val(xlssheet.cells(2 + b, 4).value() > 0)) Then
                xlssheet11.cells(b + 2, 1).value() = xlssheet11.cells(b + 2, 1).value() & "C" & xlssheet.cells(2 + b, 4).value()
            End If

            If (Len(xlssheet.cells(2 + b, 6).value()) > 0) And (Val(xlssheet.cells(2 + b, 5).value() > 0)) Then
                xlssheet11.cells(b + 2, 1).value() = xlssheet11.cells(b + 2, 1).value() & "D" & xlssheet.cells(2 + b, 5).value()
            End If


            If (Len(xlssheet.cells(2 + b, 7).value()) > 0) And (Val(xlssheet.cells(2 + b, 6).value() > 0)) Then
                xlssheet11.cells(b + 2, 1).value() = xlssheet11.cells(b + 2, 1).value() & "E" & xlssheet.cells(2 + b, 6).value()
            End If


            If (Len(xlssheet.cells(2 + b, 8).value()) > 0) And (Val(xlssheet.cells(2 + b, 7).value() > 0)) Then
                xlssheet11.cells(b + 2, 1).value() = xlssheet11.cells(b + 2, 1).value() & "F" & xlssheet.cells(2 + b, 7).value()
            End If

            If (Len(xlssheet.cells(2 + b, 9).value()) > 0) And (Val(xlssheet.cells(2 + b, 8).value() > 0)) Then
                xlssheet11.cells(b + 2, 1).value() = xlssheet11.cells(b + 2, 1).value() & "G" & xlssheet.cells(2 + b, 8).value()
            End If

            If (Len(xlssheet.cells(2 + b, 11).value()) > 0) And (Val(xlssheet.cells(2 + b, 10).value() > 0)) Then
                xlssheet11.cells(b + 2, 1).value() = xlssheet11.cells(b + 2, 1).value() & "H" & xlssheet.cells(2 + b, 10).value()
            End If

            If (Len(xlssheet.cells(2 + b, 12).value()) > 0) And (Val(xlssheet.cells(2 + b, 11).value() > 0)) Then
                xlssheet11.cells(b + 2, 1).value() = xlssheet11.cells(b + 2, 1).value() & "I" & xlssheet.cells(2 + b, 11).value()
            End If
            If (Len(xlssheet.cells(2 + b, 13).value()) > 0) And (Val(xlssheet.cells(2 + b, 12).value() > 0)) Then
                xlssheet11.cells(b + 2, 1).value() = xlssheet11.cells(b + 2, 1).value() & "J" & xlssheet.cells(2 + b, 12).value()
            End If
            If (Len(xlssheet.cells(2 + b, 14).value()) > 0) And (Val(xlssheet.cells(2 + b, 13).value() > 0)) Then
                xlssheet11.cells(b + 2, 1).value() = xlssheet11.cells(b + 2, 1).value() & "K" & xlssheet.cells(2 + b, 13).value()
            End If
            If (Len(xlssheet.cells(2 + b, 15).value()) > 0) And (Val(xlssheet.cells(2 + b, 14).value() > 0)) Then
                xlssheet11.cells(b + 2, 1).value() = xlssheet11.cells(b + 2, 1).value() & "L" & xlssheet.cells(2 + b, 14).value()
            End If
            If (Len(xlssheet.cells(2 + b, 16).value()) > 0) And (Val(xlssheet.cells(2 + b, 15).value() > 0)) Then
                xlssheet11.cells(b + 2, 1).value() = xlssheet11.cells(b + 2, 1).value() & "M" & xlssheet.cells(2 + b, 15).value()
            End If
            If (Len(xlssheet.cells(2 + b, 17).value()) > 0) And (Val(xlssheet.cells(2 + b, 16).value() > 0)) Then
                xlssheet11.cells(b + 2, 1).value() = xlssheet11.cells(b + 2, 1).value() & "N" & xlssheet.cells(2 + b, 16).value()
            End If
     













            xlssheet11.cells(b + 2, 2).value() = xlssheet.cells(2 + b, 17).value() '电话号码

            ' xlssheet11.cells(b + 2, 3).value() = xlssheet.cells(3 + b, 2).value() '联系人


            pb.Value = b

            Application.DoEvents()

        Next

        xlssheet11.Range(xlssheet11.Cells(1, 1), xlssheet11.Cells(b + 1, 3)).Font.Name = "宋体"
        xlssheet11.Range(xlssheet11.Cells(1, 1), xlssheet11.Cells(b + 1, 3)).Font.size = 9

        pb.Visible = False
        XLS11.Visible = True



        xlsBook.Application.Quit()
        XLS = Nothing

        XLS11 = Nothing
        Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("excel")
e:

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
End Class
