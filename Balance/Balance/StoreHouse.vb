Imports System.Data.SqlClient
Imports System.Data
Public Class StoreHouse
    Dim sqlobjdataadapter As New SqlDataAdapter
    Dim olda, oldb As Integer

    Dim objdataview As New DataView
    Dim objdataviewgo As New DataView
    Dim objdataset As New DataSet
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        sqlobjdataadapter = New SqlDataAdapter
        sqlobjdataadapter.SelectCommand = New SqlCommand
        sqlobjdataadapter.SelectCommand.Connection = objconnection
        sqlobjdataadapter.SelectCommand.CommandText = "select  * from trade where storehouse1=0 and ticketno ='" & Trim(xiaopiaohao.Text) & "'"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        sqlobjdataadapter.Fill(objdataset, "lyg")
        objdataview = New DataView(objdataset.Tables("lyg"))
        dgvgo.DataSource = Nothing
        dgvgo.AutoGenerateColumns = True
        dgvgo.DataSource = objdataview



        If objdataview.Count = 1 Then '如果已经创建了该笔说明是未完成记录
            Dim objdatareader As SqlClient.SqlDataReader

            objdatareader = sqlobjdataadapter.SelectCommand.ExecuteReader

            While objdatareader.Read
                time1.Text = DateDiff("n", objdatareader.Item("intime"), Now)

            End While
            objdatareader.Close()
        End If

    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        'On Error Resume Next
        Try
            Dim index11 As Integer
            Dim idid As Integer
            index11 = dgvgo.CurrentCell.RowIndex


            idid = Val(dgvgo.Rows(index11).Cells("id").Value)



            '----------------------------------------------------------------------------------------------





            Dim objcommand As New SqlCommand

            objcommand.Connection = objconnection
            objcommand.CommandText = "update trade set 收货点=@station,库场收货人=@man,storehouse1=@storehouse1,storehouse1time=@storehouse1time where id =" & idid


            objcommand.Parameters.AddWithValue("@storehouse1", 1)

            objcommand.Parameters.AddWithValue("@storehouse1time", Now)

            objcommand.Parameters.AddWithValue("@man", username)

            objcommand.Parameters.AddWithValue("@station", storestation)



            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommand.ExecuteNonQuery()

            objconnection.Close()
            MessageBox.Show("确认收货完毕!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception


            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub StoreHouse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.MdiParent = MDIParent1
        sqlobjdataadapter = New SqlDataAdapter
        sqlobjdataadapter.SelectCommand = New SqlCommand
        sqlobjdataadapter.SelectCommand.Connection = objconnection
        sqlobjdataadapter.SelectCommand.CommandText = "select  * from trade where storehouse1=0"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        sqlobjdataadapter.Fill(objdataset, "lyg")
        objdataview = New DataView(objdataset.Tables("lyg"))
        dgvgo.DataSource = Nothing
        dgvgo.AutoGenerateColumns = True
        dgvgo.DataSource = objdataview



   
        sqlobjdataadapter.SelectCommand.CommandText = "select  top 100 * from trade where storehouse1=1 and 库场收货人 <> ''order by storehouse1time desc"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        sqlobjdataadapter.Fill(objdataset, "lyg")
        objdataview = New DataView(objdataset.Tables("lyg"))
        dgvgo2.DataSource = Nothing
        dgvgo2.AutoGenerateColumns = True
        dgvgo2.DataSource = objdataview






    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then

            sqlobjdataadapter = New SqlDataAdapter
            sqlobjdataadapter.SelectCommand = New SqlCommand
            sqlobjdataadapter.SelectCommand.Connection = objconnection
   
            If Len(TextBox1.Text) = 0 Then
                sqlobjdataadapter.SelectCommand.CommandText = "select  top 100 * from trade where storehouse1=1 and 库场收货人 <> ''order by storehouse1time desc"

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                sqlobjdataadapter.Fill(objdataset, "lyg")
                objdataview = New DataView(objdataset.Tables("lyg"))
                dgvgo2.DataSource = Nothing
                dgvgo2.AutoGenerateColumns = True
                dgvgo2.DataSource = objdataview

            Else

                sqlobjdataadapter.SelectCommand.CommandText = "select * from trade where storehouse1=1 and 库场收货人='" & Trim(TextBox1.Text) & "'order by storehouse1time desc"

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                sqlobjdataadapter.Fill(objdataset, "lyg")
                objdataview = New DataView(objdataset.Tables("lyg"))
                dgvgo2.DataSource = Nothing
                dgvgo2.AutoGenerateColumns = True
                dgvgo2.DataSource = objdataview

            End If

        End If
        shuliang.Text = "共计" & objdataview.Count & "笔"

    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then

            sqlobjdataadapter = New SqlDataAdapter
            sqlobjdataadapter.SelectCommand = New SqlCommand
            sqlobjdataadapter.SelectCommand.Connection = objconnection

            If Len(TextBox2.Text) = 0 Then
                sqlobjdataadapter.SelectCommand.CommandText = "select  top 100 * from trade where storehouse1=1 and 库场收货人 <> ''order by storehouse1time desc"

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                sqlobjdataadapter.Fill(objdataset, "lyg")
                objdataview = New DataView(objdataset.Tables("lyg"))
                dgvgo2.DataSource = Nothing
                dgvgo2.AutoGenerateColumns = True
                dgvgo2.DataSource = objdataview

            Else

                sqlobjdataadapter.SelectCommand.CommandText = "select * from trade where storehouse1=1 and 收货点='" & Trim(TextBox2.Text) & "'order by storehouse1time desc"

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                sqlobjdataadapter.Fill(objdataset, "lyg")
                objdataview = New DataView(objdataset.Tables("lyg"))
                dgvgo2.DataSource = Nothing
                dgvgo2.AutoGenerateColumns = True
                dgvgo2.DataSource = objdataview

            End If

        End If
        shuliang.Text = "共计" & objdataview.Count & "笔"
    End Sub

    
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then

            sqlobjdataadapter = New SqlDataAdapter
            sqlobjdataadapter.SelectCommand = New SqlCommand
            sqlobjdataadapter.SelectCommand.Connection = objconnection

            If Len(TextBox3.Text) = 0 Then
                sqlobjdataadapter.SelectCommand.CommandText = "select  top 100 * from trade where storehouse1=1 and 库场收货人 <> ''order by storehouse1time desc"

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                sqlobjdataadapter.Fill(objdataset, "lyg")
                objdataview = New DataView(objdataset.Tables("lyg"))
                dgvgo2.DataSource = Nothing
                dgvgo2.AutoGenerateColumns = True
                dgvgo2.DataSource = objdataview

            Else

                sqlobjdataadapter.SelectCommand.CommandText = "select * from trade where storehouse1=1 and 库场收货人 <> ''and product='" & Trim(TextBox3.Text) & "'order by storehouse1time desc"

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                sqlobjdataadapter.Fill(objdataset, "lyg")
                objdataview = New DataView(objdataset.Tables("lyg"))
                dgvgo2.DataSource = Nothing
                dgvgo2.AutoGenerateColumns = True
                dgvgo2.DataSource = objdataview

            End If


        End If
        shuliang.Text = "共计" & objdataview.Count & "笔"
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        sqlobjdataadapter = New SqlDataAdapter
        sqlobjdataadapter.SelectCommand = New SqlCommand
        sqlobjdataadapter.SelectCommand.Connection = objconnection
        sqlobjdataadapter.SelectCommand.CommandText = "select  * from trade where storehouse1=0"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        sqlobjdataadapter.Fill(objdataset, "lyg")
        objdataview = New DataView(objdataset.Tables("lyg"))
        dgvgo.DataSource = Nothing
        dgvgo.AutoGenerateColumns = True
        dgvgo.DataSource = objdataview




        sqlobjdataadapter.SelectCommand.CommandText = "select  top 100 * from trade where storehouse1=1 and 库场收货人 <> ''order by storehouse1time desc"

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        sqlobjdataadapter.Fill(objdataset, "lyg")
        objdataview = New DataView(objdataset.Tables("lyg"))
        dgvgo2.DataSource = Nothing
        dgvgo2.AutoGenerateColumns = True
        dgvgo2.DataSource = objdataview

    End Sub
End Class