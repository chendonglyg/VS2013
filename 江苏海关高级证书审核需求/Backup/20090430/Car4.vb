Imports System.Data.SqlClient
Imports System.Data
Public Class Car4
    Dim objconnection As New SqlConnection("Data Source= 10.229.196.7;Initial Catalog = package;User ID=sa; Password=chen dong")




    Private Sub ReportViewer1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim da = New SqlDataAdapter("select * from trade ", objconnection)


        'da.Fill(Me.packageDataSet.trade)



    End Sub

    Private Sub reportform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CrystalReportViewer1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class