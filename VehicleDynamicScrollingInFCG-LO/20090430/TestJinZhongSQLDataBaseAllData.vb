Public Class TestJinZhongSQLDataBaseAllData
    Dim objdataset As New DataSet
    Dim objdatatable As New DataTable
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim objjinzhong As New SqlClient.SqlConnection
    Dim sa, jinzhongpassword, ipaddressvalues As String
    Dim is_shutdown As Boolean
    Dim i, RowCount As Integer

    Dim data_row As DataRow
    Private Sub TestJinZhongSQLDataBaseAllData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sa = "Interface_CLDT"
        jinzhongpassword = "Yikatong@)17"
        ipaddressvalues = "10.229.17.44"
        objjinzhong = New SqlClient.SqlConnection("Data Source= " & Trim(ipaddressvalues) & ";Initial Catalog = GoldBell_Wilmar;User ID=" & sa & "; Password=" & jinzhongpassword)
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objjinzhong
        objdataadapter.SelectCommand.CommandText = "select * from TaskInfoForOutSysCLDT where iscomplete=0"

        'sa = "Interface_CLDT"
        'jinzhongpassword = "Yikatong@)17"
        'ipaddressvalues = "10.229.12.61"
        'objjinzhong = New SqlClient.SqlConnection("Data Source= " & Trim(ipaddressvalues) & ";Initial Catalog = GoldBell_Wilmar_QAS ;User ID=" & sa & "; Password=" & jinzhongpassword)
        'objdataadapter.SelectCommand = New SqlClient.SqlCommand
        'objdataadapter.SelectCommand.Connection = objjinzhong
        'objdataadapter.SelectCommand.CommandText = "select * from TaskInfoForOutSysCLDT  where iscomplete=0 "





        If objjinzhong.State = ConnectionState.Closed = True Then
            objjinzhong.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "OneCardPass")


        objdatatable = objdataset.Tables("OneCardPass")
        DGV.DataSource = objdatatable

    End Sub
End Class