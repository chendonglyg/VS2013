Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.Windows.Forms
Public Class Bill4



    Private Sub TEMP1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Resources As New System.ComponentModel.ComponentResourceManager(GetType(Bill3))

        Dim axHWPostil1 = New AxHWPOSTILLib.AxHWPostil()
        axHWPostil1.Enabled = True
        axHWPostil1.Location = New System.Drawing.Point(12, 68)
        axHWPostil1.Name = "axHWPostil1"
        axHWPostil1.OcxState = Resources.GetObject("axHWPostil1.OcxState")
        axHWPostil1.Size = New System.Drawing.Size(1240, 481)
        axHWPostil1.TabIndex = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        axHWPostil1.LoadFile(Trim(Pathname.Text))
    End Sub
End Class