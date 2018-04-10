Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Win32
Public Class COA_1
    Dim forreport As New SqlDataAdapter
    Dim idid As Integer
    Public afterdel As String

    Dim objdataadapter As New SqlDataAdapter

    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub Assets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1
        Try
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select top 100 id,afce��,�ʲ���,��˾����,��������,�ļ�����,�ļ�����,�ļ���С,��ע from information1  order by id desc"
            afterdel = objdataadapter.SelectCommand.CommandText


            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "information1")

            objdataview = New DataView(objdataset.Tables("information1"))
            'objcurrencymanager = CType(Me.BindingContext(objdataview), CurrencyManager)
            objconnection.Close()



            dgv.DataSource = objdataview
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        On Error Resume Next
        idid = Trim(dgv.Rows(e.RowIndex).Cells(0).Value)
    End Sub

    Private Sub dgv_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        On Error Resume Next
        idid = Trim(dgv.Rows(e.RowIndex).Cells(0).Value)
    End Sub


    Private Sub ��ӡ���ʼ�¼ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ��ӡ���ʼ�¼ToolStripMenuItem.Click
        Try
            Dim sel As String
            sel = "Select pic,�ļ����� from information1 where id = " & idid
            Dim myRow As DataRow


            Dim da As New SqlDataAdapter(sel, objconnection)

            Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)
            Dim ds As New DataSet()



            da.Fill(ds, "information1")
            objdataview = New DataView(ds.Tables("information1"))

            If objdataview.Count > 0 Then

                myRow = ds.Tables("information1").Rows(0)



                Dim MyData() As Byte
                MyData = myRow("pic")

                Dim ArraySize As Integer
                ArraySize = MyData.GetUpperBound(0)

                sel = "c:\windows\temp\" & myRow("�ļ�����")


                Dim fs As New FileStream(sel, FileMode.OpenOrCreate, FileAccess.Write)
                fs.Write(MyData, 0, ArraySize)
                fs.Close()


                System.Diagnostics.Process.Start("iexplore.exe", sel)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub





    Private Sub CrystalB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Hello")
    End Sub


    Private Sub CrystalB_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        MessageBox.Show("Hello")
    End Sub




    Private Sub ToolStripTextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles afcehao.KeyDown
        If e.KeyCode = Keys.Enter Then

            objdataadapter = New SqlDataAdapter
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection



            objdataadapter.SelectCommand.CommandText = "select id,afce��,�ʲ���,��˾����,��������,�ļ�����,�ļ�����,�ļ���С,��ע from information1 where afce��='" & Trim(afcehao.Text) & "'"
            afterdel = objdataadapter.SelectCommand.CommandText
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "lyg")
            objdataview = New DataView(objdataset.Tables("lyg"))
            dgv.DataSource = Nothing
            dgv.AutoGenerateColumns = True
            dgv.DataSource = objdataview




        End If
    End Sub

    Private Sub zichanhao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zichanhao.Click

    End Sub

    Private Sub zichanhao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles zichanhao.KeyDown
        If e.KeyCode = Keys.Enter Then

            objdataadapter = New SqlDataAdapter
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection



            objdataadapter.SelectCommand.CommandText = "select id,afce��,�ʲ���,��˾����,��������,�ļ�����,�ļ�����,�ļ���С,��ע from information1 where �ʲ���='" & Trim(zichanhao.Text) & "'"
            afterdel = objdataadapter.SelectCommand.CommandText

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "lyg")
            objdataview = New DataView(objdataset.Tables("lyg"))
            dgv.DataSource = Nothing
            dgv.AutoGenerateColumns = True
            dgv.DataSource = objdataview




        End If
    End Sub

    Private Sub �޸ļ�¼ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �޸ļ�¼ToolStripMenuItem.Click
        On Error Resume Next
        Dim da As New SqlDataAdapter("Select * from information1 where id= " & idid, objconnection)

        Dim ds As New DataSet()

        da.MissingSchemaAction = MissingSchemaAction.AddWithKey



        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If


        da.Fill(ds, "information1")



    End Sub

    Private Sub ɾ����¼ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ɾ����¼ToolStripMenuItem.Click
        If (MessageBox.Show("��ȷ��Ҫ����˱ʼ�¼?(Y/N)", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK) Then


            objdataadapter = New SqlDataAdapter
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection



            objdataadapter.SelectCommand.CommandText = "delete  information1 where id=" & idid

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataadapter.SelectCommand.ExecuteNonQuery()
            MessageBox.Show("ɾ����ϣ�")

            objdataadapter = New SqlDataAdapter
            objdataadapter.SelectCommand = New SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection



            objdataadapter.SelectCommand.CommandText = afterdel
            afterdel = objdataadapter.SelectCommand.CommandText

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "afterdel")
            objdataview = New DataView(objdataset.Tables("afterdel"))
            dgv.DataSource = Nothing
            dgv.AutoGenerateColumns = True
            dgv.DataSource = objdataview

        End If

    End Sub

    Private Sub afcehao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles afcehao.Click

    End Sub

    Private Sub dgv_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv.DataError
        On Error Resume Next
    End Sub
End Class