Public Class View_it
    Dim objdataset1, objdataset2, objdataset3 As New DataSet
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim objdatatable1, objdatatable2, objdatatable3 As New DataTable
    Dim data_table1, data_table2, data_table3 As New DataTable
    Dim a, b, c, i, j, k As Integer
    Dim is_shutdown As Boolean   
    Dim data_row1, data_row2, data_row3 As DataRow
    Private Sub Total_record()
        SHOWERROR.Visible = False
        On Error Resume Next
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        '---------------
        objdataadapter.SelectCommand.CommandText = "select datename(mm,推送时间)+'月'+ datename(dd,推送时间)+'日' +datename(hh,推送时间)+':'+datename(mi,推送时间) as 推送时间,车号,货物名称,油脂 from TRUCK_QUEUE  where 可登记=1 order by 推送时间 "
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset1 = New DataSet
        objdataadapter.Fill(objdataset1, "kedengji")

        objdatatable1 = objdataset1.Tables("kedengji")

        objdataset1.Tables("kedengji").Columns.Add("名次", GetType(Integer))


        a = objdatatable1.Rows.Count

        objdatatable1.Columns("名次").SetOrdinal(1)


        For i = 1 To a

            objdatatable1.Rows(i - 1)("名次") = i

        Next


        DGV1.DataSource = objdatatable1







        '--------------------------------------------------------------------------------------------------------
        objdataadapter.SelectCommand.CommandText = "select datename(mm,登记时间)+'月'+ datename(dd,登记时间)+'日' +datename(hh,登记时间)+':'+datename(mi,登记时间) as 登记时间,车号,货物名称,油脂 from TRUCK_QUEUE where 已登记=1 order by 登记时间"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset2 = New DataSet
        objdataadapter.Fill(objdataset2, "yidengji")

        objdatatable2 = objdataset2.Tables("yidengji")
        b = objdatatable2.Rows.Count




        DGV2.DataSource = objdatatable2





        '-----------------------------------------------------------------------------------------------------------
        objdataadapter.SelectCommand.CommandText = "select datename(mm,进厂时间)+'月'+ datename(dd,进厂时间)+'日' +datename(hh,进厂时间)+':'+datename(n,进厂时间) as 放行时间,车号,货物名称,油脂 from TRUCK_QUEUE where 可进厂=1 order by 进厂时间"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset3 = New DataSet
        objdataadapter.Fill(objdataset3, "kejinchang")

        objdatatable3 = objdataset3.Tables("kejinchang")
        DGV3.DataSource = objdatatable3

        c = objdatatable3.Rows.Count

        On Error Resume Next
        DGV1.Columns(0).Width = 120
        DGV2.Columns(0).Width = 120
        DGV3.Columns(0).Width = 120





        DGV1.Columns(1).Width = 40
        DGV2.Columns(1).Width = 100
        DGV3.Columns(1).Width = 100

        DGV1.Columns(2).Width = 100
        DGV2.Columns(2).Width = 200
        DGV3.Columns(2).Width = 200




    End Sub

    
    Private Sub showdatatable1() '三秒触发一次,但查询SQL的周期为3秒*记录数量，大大提高了查询效率，减少了网络流量

        On Error Resume Next


        i = i + 1
        objdataset1.Tables("kedengji").Columns.Add("名次", GetType(Integer))

        data_table1 = objdataset1.Tables("kedengji")

        data_row1 = data_table1.NewRow

        data_row1("名次") = i
        data_row1("推送时间") = objdataset1.Tables("kedengji").Rows(0).Item(0)
        data_row1("车号") = objdataset1.Tables("kedengji").Rows(0).Item(2)
        data_row1("货物名称") = objdataset1.Tables("kedengji").Rows(0).Item(3)
        data_row1("油脂") = objdataset1.Tables("kedengji").Rows(0).Item(4)
        objdataset1.Tables("kedengji").Rows.Add(data_row1)
        objdataset1.Tables("kedengji").Rows.RemoveAt(0)





        If i >= a Then

            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select datename(mm,推送时间)+'月'+ datename(dd,推送时间)+'日' +datename(hh,推送时间)+':'+datename(mi,推送时间) as 推送时间,车号,货物名称,油脂 from TRUCK_QUEUE  where 可登记=1 order by 推送时间 "
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset1 = New DataSet
            objdataadapter.Fill(objdataset1, "kedengji")
            objdatatable1 = objdataset1.Tables("kedengji")
            If objdataset1.Tables("kedengji").Rows.Count > 0 Then

                a = objdatatable1.Rows.Count

                objdataset1.Tables("kedengji").Columns.Add("名次", GetType(Integer))


                a = objdatatable1.Rows.Count

                objdatatable1.Columns("名次").SetOrdinal(1)

                For i = 1 To a

                    objdatatable1.Rows(i - 1)("名次") = i

                Next
                i = 0

                DGV1.Columns(0).Width = 120

                DGV1.Columns(1).Width = 40

                DGV1.Columns(2).Width = 100
                DGV1.DataSource = objdatatable1
            Else
                DGV1.DataSource = Nothing
            End If

         



        End If

        '-------------------------------------------------------------------------------------------



        objconnection.Close()



    End Sub
    Private Sub showdatatable2()

        On Error Resume Next
        data_table2 = objdataset2.Tables("yidengji")
        data_row2 = data_table2.NewRow
        data_row2("登记时间") = objdataset2.Tables("yidengji").Rows(0).Item(0).ToString
        data_row2("车号") = objdataset2.Tables("yidengji").Rows(0).Item(1).ToString

        data_row2("货物名称") = objdataset2.Tables("yidengji").Rows(0).Item(2).ToString

        data_row2("油脂") = objdataset2.Tables("yidengji").Rows(0).Item(3)
        objdataset2.Tables("yidengji").Rows.Add(data_row2)
        objdataset2.Tables("yidengji").Rows.RemoveAt(0)


        j = j + 1

        If j >= b Then
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select datename(mm,登记时间)+'月'+ datename(dd,登记时间)+'日' +datename(hh,登记时间)+':'+datename(mi,登记时间) as 登记时间,车号,货物名称,油脂 from TRUCK_QUEUE  where 已登记=1 order by 登记时间 "
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset2 = New DataSet
            objdataadapter.Fill(objdataset2, "yidengji")
            objdatatable2 = objdataset2.Tables("yidengji")
            DGV2.DataSource = objdatatable2



            b = objdatatable2.Rows.Count


            j = 0


            DGV2.Columns(0).Width = 120


            DGV2.Columns(1).Width = 100



            DGV2.Columns(2).Width = 200

        End If

        objconnection.Close()
    End Sub
    Private Sub showdatatable3()
        On Error Resume Next
        data_table3 = objdataset3.Tables("kejinchang")
        data_row3 = data_table3.NewRow
        data_row3("放行时间") = objdataset3.Tables("kejinchang").Rows(0).Item(0)
        data_row3("车号") = objdataset3.Tables("kejinchang").Rows(0).Item(1)
        data_row3("货物名称") = objdataset3.Tables("kejinchang").Rows(0).Item(2)
        data_row3("油脂") = objdataset3.Tables("kejinchang").Rows(0).Item(3)
        objdataset3.Tables("kejinchang").Rows.Add(data_row3)

        objdataset3.Tables("kejinchang").Rows.RemoveAt(0)


        k = k + 1

        If k >= c Then
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select datename(mm,进厂时间)+'月'+ datename(dd,进厂时间)+'日' +datename(hh,进厂时间)+':'+datename(mi,进厂时间) as 放行时间,车号,货物名称,油脂 from TRUCK_QUEUE  where 可进厂=1 order by 进厂时间 "
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset3 = New DataSet
            objdataadapter.Fill(objdataset3, "kejinchang")
            objdatatable3 = objdataset3.Tables("kejinchang")
            DGV3.DataSource = objdatatable3



            c = objdatatable3.Rows.Count


            k = 0


            DGV3.Columns(0).Width = 120


            DGV3.Columns(1).Width = 100

            DGV3.Columns(2).Width = 200
        End If













        objconnection.Close()

    End Sub





    Private Sub View_it_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim p As New Net.NetworkInformation.Ping
        Dim pr As Net.NetworkInformation.PingReply

        pr = p.Send(ipipip)


        If pr.Status = Net.NetworkInformation.IPStatus.Success Then

            Total_record() '--------主要用于获取3个数据集的数目，用于滚动

            i = 0
            j = 0
            k = 0
            is_shutdown = False
       
        End If
        DGV2.AllowUserToAddRows = False '消除最后一行
        DGV1.AllowUserToAddRows = False '消除最后一行
        DGV3.AllowUserToAddRows = False '消除最后一行

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next

        Dim p As New Net.NetworkInformation.Ping
        Dim pr As Net.NetworkInformation.PingReply


        pr = p.Send(ipipip)

        If pr.Status = Net.NetworkInformation.IPStatus.Success Then
            SHOWERROR.Visible = False
            If is_shutdown = True Then

                Total_record() '--------主要用于获取3个数据集的数目，用于滚动

                i = 0
                j = 0
                k = 0
                is_shutdown = False
            Else

                showdatatable1()
                showdatatable2()
                showdatatable3()
            End If

        Else

            is_shutdown = True
            SHOWERROR.Visible = True
            DGV1.DataSource = Nothing
            DGV2.DataSource = Nothing
            DGV3.DataSource = Nothing

        End If

    End Sub



    


    Private Sub DGV1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV1.CellFormatting
        On Error Resume Next
        Dim dgv As DataGridView = CType(sender, DataGridView)

        '确认单元格的列




        '根据单元格的值，变更背景色
        If dgv.Rows(e.RowIndex).Cells("油脂").Value Is DBNull.Value Then

        Else


            e.CellStyle.BackColor = Color.Red

        End If
    End Sub
 

    Private Sub DGV2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV2.CellFormatting
        On Error Resume Next
        Dim dgv As DataGridView = CType(sender, DataGridView)

        '确认单元格的列




        '根据单元格的值，变更背景色
        If dgv.Rows(e.RowIndex).Cells("油脂").Value Is DBNull.Value Then

        Else


            e.CellStyle.BackColor = Color.Red

        End If
    End Sub

    Private Sub DGV3_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV3.CellFormatting
        On Error Resume Next
        Dim dgv As DataGridView = CType(sender, DataGridView)

        '确认单元格的列




        '根据单元格的值，变更背景色
        If dgv.Rows(e.RowIndex).Cells("油脂").Value Is DBNull.Value Then

        Else


            e.CellStyle.BackColor = Color.Red

        End If
    End Sub

    


 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

  
 
End Class