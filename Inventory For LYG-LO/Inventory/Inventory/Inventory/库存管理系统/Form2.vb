Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.IO
Public Class Form2
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataview2 As New DataView
    Dim objdataadapter As New SqlDataAdapter
    Dim idid As Integer
    Dim oldcommand As String
    Dim biaozhi As Integer
    Private Sub RichTextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Top = Me.Height
        Label1.Left = Me.Width / 2 - Label1.Width

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label1.Top <= 0 - Label1.Height Then
            Label1.Top = Me.Height
            Label1.Text = Label1.Text & vbCrLf & Now
        End If

        Label1.Top = Label1.Top - 10






    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        End

    End Sub
End Class