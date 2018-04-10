Public Class TestFrom

    Private Sub ToolStripContainer1_ContentPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripComboBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub btnClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click
        Dim ClickBtn As Button = CType(sender, Button)
        Dim TabIndex As Integer = ClickBtn.TabIndex

        If ClickBtn.Dock = DockStyle.Top Then
            For Each btn As Control In Panel1.Controls
                If btn.GetType.ToString.Equals("System.Windows.Forms.Button") Then
                    If btn.TabIndex > TabIndex Then btn.Dock = DockStyle.Bottom
                End If
            Next
        Else
            For Each btn As Control In Panel1.Controls
                If btn.GetType.ToString.Equals("System.Windows.Forms.Button") Then
                    If btn.TabIndex <= TabIndex Then btn.Dock = DockStyle.Top
                End If
            Next
        End If

        ListView1.Items.Clear()


        If ClickBtn.Name = "Button1" Then

            ListView1.Items.Add("1", "OK", 1)






        End If

    
    End Sub


  
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    


    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim s As ListViewItem = ListView1.SelectedItems.Item(0)
            If s.Text = "OK" Then
                MessageBox.Show("ok")
            End If
        End If
    End Sub

    Private Sub TestFrom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class