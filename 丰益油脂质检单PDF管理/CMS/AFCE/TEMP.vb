Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.Windows.Forms

Public Class TEMP
    Private Sub TEMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Resources As New System.ComponentModel.ComponentResourceManager(GetType(TEMP))

        Dim axHWPostil1 = New AxHWPOSTILLib.AxHWPostil()
        axHWPostil1.Enabled = True
        axHWPostil1.Location = New System.Drawing.Point(12, 68)
        axHWPostil1.Name = "axHWPostil1"
        axHWPostil1.OcxState = Resources.GetObject("axHWPostil1.OcxState")
        axHWPostil1.Size = New System.Drawing.Size(1240, 481)
        axHWPostil1.TabIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        axHWPostil1.Login("HWSEALDEMO**", 4, 65535, "DEMO", "")
        axHWPostil1.CurrAction = 2568
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        spd.Filter = "PDF文件|*.PDF"

        spd.ShowDialog()


        axHWPostil1.SaveTo(spd.FileName， “PDF”， 1)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        opd.Filter = "PDF文件|*.PDF"

        opd.ShowDialog()
        axHWPostil1.LoadFile(opd.FileName)
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        axHWPostil1.ShowDefMenu = 0


    End Sub
End Class