Public Class TestJinZhongSQLDataBase
    Dim objdataset, objdatasetiscomplete As New DataSet
    Dim objdatatable, objdatatableiscomplete As New DataTable
    Dim objdataview, objdataviewiscomplete As New DataView
    Dim objdataadapter, objdataadapteriscomplete As New SqlClient.SqlDataAdapter
    Dim objjinzhong, objjinzhongiscomplete As New SqlClient.SqlConnection


    Dim sa, jinzhongpassword, ipaddressvalues As String
    Dim is_shutdown As Boolean
    Dim i, RowCount As Integer

    Dim data_row, data_row_iscomplete As DataRow

    Private Sub TestJinZhongSQLDataBase_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = "27" Then
            End
        End If

    End Sub

  

   

    Private Sub TestJinZhongSQLDataBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 一卡通测试服务器地址：胡章艮 2-28 15:31数据库名称:  GoldBell_Wilmar 接口视图名称 : TaskInfoForOutSys

        '连接用户：Interface_DLFY  密码：Yikatong@)17
        Try
            sa = "Interface_CLDT"
            jinzhongpassword = "Yikatong@)17"
            ipaddressvalues = "10.229.17.44"

            objjinzhong = New SqlClient.SqlConnection("Data Source= " & Trim(ipaddressvalues) & ";Initial Catalog = GoldBell_Wilmar;User ID=" & sa & "; Password=" & jinzhongpassword)



            Dim p As New Net.NetworkInformation.Ping
            Dim pr As Net.NetworkInformation.PingReply

            pr = p.Send(ipaddressvalues)



            If pr.Status = Net.NetworkInformation.IPStatus.Success Then

                Total_record() '--------获取数据和总条目


                i = 0

                is_shutdown = False
            Else

                is_shutdown = True
                SHOWERROR.Visible = True
                dgv.DataSource = Nothing


            End If
            dgv.AllowUserToAddRows = False '消除最后一行
            '--------------------------------------------------------------------------------------------------------------------dgviscomplete显示的内容

            Total_Record_Iscomplete()


        Catch ex As Exception
            MessageBox.Show(ex.Message & "FROM LOAD")
        End Try
    End Sub





    Private Sub Total_Record_Iscomplete()
        Try
            TextBox1.Clear()
            objjinzhongiscomplete = New SqlClient.SqlConnection("Data Source= " & Trim(ipaddressvalues) & ";Initial Catalog = GoldBell_Wilmar;User ID=" & sa & "; Password=" & jinzhongpassword)

            objdataadapteriscomplete.SelectCommand = New SqlClient.SqlCommand
            objdataadapteriscomplete.SelectCommand.Connection = objjinzhongiscomplete
            objdataadapteriscomplete.SelectCommand.CommandText = "select Top 10 TruckNO as 车号,MaterialName as 物料,PlanWeigh as 计划重量,CreateTime as 制卡时间,FirstWeightTime as 一磅时间,SecondWeightTime as 二磅时间,MaterialName as 发货用时,CheckOutTime as 收卡时间, FinalNet as 净重 from TaskInfoForOutSysCLDT where iscomplete=1 and MaterialName not like '%" & _
                                                       "豆油" & "%'" & "and MaterialName not like '%" & "煤" & "%'" & "and MaterialName not like '%" & "粕" & _
                                                       "%'" & "and MaterialName not like '%" & "土" & "%'" & "and MaterialName not like '%" & "包装" & "%'" & "and MaterialName not like '%" & "编织" & "%'" & _
                                                       "and MaterialName not like '%" & "烧碱" & "%'" & "and MaterialName not like '%" & "银鹂" & "%'" & "and MaterialName not like '%" & "分提棕" & "%'" _
                                                       & "and MaterialName not like '%" & "金味" & "%'" & "and MaterialName not like '%" & "特油" & "%'" _
                                                        & "and MaterialName not like '%" & "RPOF" & "%'" & "and MaterialName not like '%" & "花旗" & "%'" & "and MaterialName not like '%" & "食用" & "%'" & "and MaterialName not like '%" & "起" & "%'" & "and MaterialName not like '%" & "菜" & "%' and MaterialName not in (select Name_GO from GamNotLikeName) order by checkouttime desc "


            'objdataadapteriscomplete.SelectCommand.CommandText = "select Top 30 TruckNO as 车号,MaterialName as 物料,PlanWeigh as 计划重量,CreateTime as 制卡时间,FirstWeightTime as 一磅时间,SecondWeightTime as 二磅时间,MaterialName as 发货用时,CheckOutTime as 收卡时间, FinalNet as 净重 from TaskInfoForOutSysCLDT where iscomplete=1 and MaterialName not in (select Name_GO from GamNotLikeName)"

            If objjinzhongiscomplete.State = ConnectionState.Closed Then
                objjinzhongiscomplete.Open()
            End If



            objdatasetiscomplete = New DataSet

            objdataadapteriscomplete.Fill(objdatasetiscomplete, "iscomplete")




            objdataviewiscomplete = New DataView(objdatasetiscomplete.Tables("iscomplete"))


            dgviscomplete.DataSource = objdatasetiscomplete.Tables("iscomplete")

            dgviscomplete.Columns(0).Width = 120
            dgviscomplete.Columns(1).Width = 190

            dgviscomplete.Columns(2).Width = 120
            dgviscomplete.Columns(3).Width = 150
            dgviscomplete.Columns(4).Width = 150
            dgviscomplete.Columns(5).Width = 150
            dgviscomplete.Columns(6).Width = 100
            dgviscomplete.Columns(7).Width = 150
            dgviscomplete.AllowUserToAddRows = False '消除最后一行
            Dim a As Integer
            Dim b, c As Date

            For a = 0 To objdataviewiscomplete.Count - 1


                b = objdatasetiscomplete.Tables("iscomplete").Rows(a).Item(4).ToString

                c = objdatasetiscomplete.Tables("iscomplete").Rows(a).Item(5).ToString
                'MessageBox.Show(b & c)

                objdatasetiscomplete.Tables("iscomplete").Rows(a).Item(6) = DateDiff(DateInterval.Minute, b, c) & "min"



            Next

            If objjinzhongiscomplete.State = ConnectionState.Open Then
                objjinzhongiscomplete.Close()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message & "FROM TOTAL RECORD ISCOMPLETE")
        End Try
    End Sub




    Private Sub Total_record()
        Try
            SHOWERROR.Visible = False


            '---------------

            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objjinzhong
            objdataadapter.SelectCommand.CommandText = "select TruckNO as 车号,MaterialName as 物料,PlanWeigh as 计划重量,CreateTime as 发卡时间,isfirstweight as 完成一磅,BeginTallyTime as 开始理货,EndTallyTime as 结束理货,IssecondWeight as 完成二磅 from TaskInfoForOutSysCLDT where iscomplete=0 and MaterialName not like '%" & _
                                                       "豆油" & "%'" & "and MaterialName not like '%" & "煤" & "%'" & "and MaterialName not like '%" & "粕" & _
                                                       "%'" & "and MaterialName not like '%" & "土" & "%'" & "and MaterialName not like '%" & "包装" & "%'" & "and MaterialName not like '%" & "编织" & "%'" & _
                                                       "and MaterialName not like '%" & "烧碱" & "%'" & "and MaterialName not like '%" & "银鹂" & "%'" & "and MaterialName not like '%" & "分提棕" & "%'" _
                                                       & "and MaterialName not like '%" & "金味" & "%'" & "and MaterialName not like '%" & "特油" & "%'" & "and MaterialName not like '%" & "花旗" & "%'" _
                                                       & "and MaterialName not like '%" & "RPOF" & "%'" & "and MaterialName not like '%" & "食用" & "%'" & "and MaterialName not like '%" & "起" & "%'" & "and MaterialName not like '%" & "菜" & "%' and MaterialName not in (select Name_GO from GamNotLikeName )"

            If objjinzhong.State = ConnectionState.Closed Then
                objjinzhong.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "OneCardPass")


            objdatatable = objdataset.Tables("OneCardPass")
            dgv.DataSource = objdatatable

            objdataview = New DataView(objdataset.Tables("OneCardPass"))
            showcount.Text = "共计" & objdataview.Count & "车"

            RowCount = objdataview.Count


            dgv.AllowUserToAddRows = False
            dgv.Columns(0).Width = 120
            dgv.Columns(1).Width = 230

            dgv.Columns(2).Width = 120
            dgv.Columns(3).Width = 200
            dgv.Columns(4).Width = 80
            dgv.Columns(5).Width = 200
            dgv.Columns(6).Width = 200
            dgv.Columns(7).Width = 80



            If objjinzhong.State = ConnectionState.Open Then
                objjinzhong.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & "FROM TOTALRECORD")
        End Try
    End Sub
    Private Sub showdatatable()

        Try
            objdatatable = objdataset.Tables("OneCardPass")
            data_row = objdatatable.NewRow
            data_row("车号") = objdataset.Tables("OneCardPass").Rows(0).Item(0).ToString
            data_row("物料") = objdataset.Tables("OneCardPass").Rows(0).Item(1).ToString

            data_row("计划重量") = objdataset.Tables("OneCardPass").Rows(0).Item(2).ToString
            data_row("发卡时间") = objdataset.Tables("OneCardPass").Rows(0).Item(3).ToString
            data_row("完成一磅") = objdataset.Tables("OneCardPass").Rows(0).Item(4).ToString

            data_row("开始理货") = objdataset.Tables("OneCardPass").Rows(0).Item(5).ToString
            data_row("结束理货") = objdataset.Tables("OneCardPass").Rows(0).Item(6).ToString
            data_row("完成二磅") = objdataset.Tables("OneCardPass").Rows(0).Item(7).ToString






            objdataset.Tables("OneCardPass").Rows.Add(data_row)
            objdataset.Tables("OneCardPass").Rows.RemoveAt(0)


            i = i + 1


            If i >= RowCount Then
                objdataadapter.SelectCommand = New SqlClient.SqlCommand
                objdataadapter.SelectCommand.Connection = objjinzhong
                objdataadapter.SelectCommand.CommandText = "select TruckNO as 车号,MaterialName as 物料,PlanWeigh as 计划重量,CreateTime as 发卡时间,isfirstweight as 完成一磅,BeginTallyTime as 开始理货,EndTallyTime as 结束理货,IssecondWeight as 完成二磅 from TaskInfoForOutSysCLDT where iscomplete=0 and MaterialName not like '%" & _
                                                           "豆油" & "%'" & "and MaterialName not like '%" & "煤" & "%'" & "and MaterialName not like '%" & "粕" & _
                                                           "%'" & "and MaterialName not like '%" & "土" & "%'" & "and MaterialName not like '%" & "包装" & "%'" & "and MaterialName not like '%" & "编织" & "%'" & _
                                                           "and MaterialName not like '%" & "烧碱" & "%'" & "and MaterialName not like '%" & "银鹂" & "%'" & "and MaterialName not like '%" & "分提棕" & "%'" _
                                                           & "and MaterialName not like '%" & "金味" & "%'" & "and MaterialName not like '%" & "特油" & "%'" & "and MaterialName not like '%" & "花旗" & "%'" _
                                                           & "and MaterialName not like '%" & "RPOF" & "%'" & "and MaterialName not like '%" & "食用" & "%'" & "and MaterialName not like '%" & "起" & "%'" & "and MaterialName not like '%" & "菜" & "%' and MaterialName not in (select Name_GO from GamNotLikeName)"


                If objjinzhong.State = ConnectionState.Closed = True Then
                    objjinzhong.Open()
                End If

                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "OneCardPass")


                objdatatable = objdataset.Tables("OneCardPass")

                dgv.DataSource = objdatatable


                objdataview = New DataView(objdataset.Tables("OneCardPass"))
                showcount.Text = "共计" & objdataview.Count & "车"
                RowCount = objdataview.Count


                dgv.AllowUserToAddRows = False
                dgv.Columns(0).Width = 120
                dgv.Columns(1).Width = 230

                dgv.Columns(2).Width = 120
                dgv.Columns(3).Width = 200
                dgv.Columns(4).Width = 80
                dgv.Columns(5).Width = 200
                dgv.Columns(6).Width = 200
                dgv.Columns(7).Width = 80
                i = 0
                Total_Record_Iscomplete()
            End If


            If objjinzhong.State = ConnectionState.Open Then
                objjinzhong.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & "FROM SHOWDATATABLE")
        End Try
    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Doit.Tick
        Try
            Dim p As New Net.NetworkInformation.Ping
            Dim pr As Net.NetworkInformation.PingReply


            pr = p.Send("10.229.17.44")

            If pr.Status = Net.NetworkInformation.IPStatus.Success Then
                SHOWERROR.Visible = False
                If is_shutdown = True Then

                    Total_record() '--------主要用于获取数据集的数目，用于滚动


                    i = 0

                    is_shutdown = False
                Else

                    showdatatable()
                    ' Total_Record_Iscomplete()   '不需要按照时钟更新
                End If

            Else

                is_shutdown = True
                SHOWERROR.Visible = True
                dgv.DataSource = Nothing

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & "FROM TIME_TICK")
        End Try
    End Sub





    Private Sub dgv_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv.CellFormatting

        If RowCount > 1 Then

            Try


                dgv.Rows(e.RowIndex).Cells("车号").Style.BackColor = Color.DarkGreen
                dgv.Rows(e.RowIndex).Cells("物料").Style.BackColor = Color.DarkGreen
                dgv.Rows(e.RowIndex).Cells("计划重量").Style.BackColor = Color.DarkGreen



                dgv.Rows(e.RowIndex).Cells("发卡时间").Style.BackColor = Color.DarkGreen


                If dgv.Rows(e.RowIndex).Cells("完成一磅").Value = 1 Then
                    dgv.Rows(e.RowIndex).Cells("完成一磅").Style.BackColor = Color.DarkGreen
                End If

                '  MessageBox.Show(dgv.Rows(e.RowIndex).Cells("开始理货").Value & Len(dgv.Rows(e.RowIndex).Cells("开始理货").Value))

                If dgv.Rows(e.RowIndex).Cells("开始理货").Value <> "1900/01/01" Then
                    dgv.Rows(e.RowIndex).Cells("开始理货").Style.BackColor = Color.DarkGreen

                End If

                If dgv.Rows(e.RowIndex).Cells("结束理货").Value <> "1900/01/01" Then
                    dgv.Rows(e.RowIndex).Cells("结束理货").Style.BackColor = Color.DarkGreen


                End If

                If dgv.Rows(e.RowIndex).Cells("完成二磅").Value = 1 Then
                    dgv.Rows(e.RowIndex).Cells("完成二磅").Style.BackColor = Color.DarkGreen
                End If


                'dgv.Columns(0).HeaderCell.Style.BackColor = Color.DarkGreen
            Catch ex As Exception
                MessageBox.Show(ex.Message & "FROM CELLFORMAT")
            End Try

        End If
    End Sub

   
  

   

    Private Sub dgv_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv.KeyDown
        If e.KeyCode = "27" Then
            End
        End If
    End Sub

   

   
    Private Sub TextBox1_DoubleClick(sender As Object, e As EventArgs) Handles TextBox1.DoubleClick
        TouchKeyboard1.ShowKeyboard(TextBox1, DevComponents.DotNetBar.Keyboard.TouchKeyboardStyle.Inline)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then

            objjinzhongiscomplete = New SqlClient.SqlConnection("Data Source= " & Trim(ipaddressvalues) & ";Initial Catalog = GoldBell_Wilmar;User ID=" & sa & "; Password=" & jinzhongpassword)

            objdataadapteriscomplete.SelectCommand = New SqlClient.SqlCommand
            objdataadapteriscomplete.SelectCommand.Connection = objjinzhongiscomplete
            objdataadapteriscomplete.SelectCommand.CommandText = "select  TruckNO as 车号,MaterialName as 物料,PlanWeigh as 计划重量,CreateTime as 制卡时间,FirstWeightTime as 一磅时间,SecondWeightTime as 二磅时间,MaterialName as 发货用时,CheckOutTime as 收卡时间, FinalNet as 净重 from TaskInfoForOutSysCLDT where TruckNO like '%" & Trim(TextBox1.Text) & "%' and DATEDIFF(day,CheckOutTime,getdate()) <=90 order by CheckOutTime desc"

            If objjinzhongiscomplete.State = ConnectionState.Closed Then
                objjinzhongiscomplete.Open()
            End If



            objdatasetiscomplete = New DataSet

            objdataadapteriscomplete.Fill(objdatasetiscomplete, "iscomplete")




            objdataviewiscomplete = New DataView(objdatasetiscomplete.Tables("iscomplete"))


            dgviscomplete.DataSource = objdatasetiscomplete.Tables("iscomplete")

            dgviscomplete.Columns(0).Width = 120
            dgviscomplete.Columns(1).Width = 190

            dgviscomplete.Columns(2).Width = 120
            dgviscomplete.Columns(3).Width = 150
            dgviscomplete.Columns(4).Width = 150
            dgviscomplete.Columns(5).Width = 150
            dgviscomplete.Columns(6).Width = 100
            dgviscomplete.Columns(7).Width = 150
            dgviscomplete.AllowUserToAddRows = False '消除最后一行

            Dim a As Integer
            Dim b, c As Date

            For a = 0 To objdataviewiscomplete.Count - 1
                On Error Resume Next

                b = objdatasetiscomplete.Tables("iscomplete").Rows(a).Item(4).ToString

                c = objdatasetiscomplete.Tables("iscomplete").Rows(a).Item(5).ToString
                'MessageBox.Show(b & c)

                objdatasetiscomplete.Tables("iscomplete").Rows(a).Item(6) = DateDiff(DateInterval.Minute, b, c) & "min"



            Next

            If objjinzhongiscomplete.State = ConnectionState.Open Then
                objjinzhongiscomplete.Close()
            End If
        End If

    End Sub

   
  
 
    

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class