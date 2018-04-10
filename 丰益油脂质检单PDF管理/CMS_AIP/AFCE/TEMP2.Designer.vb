<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TEMP2
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.yuanshibumen = New System.Windows.Forms.TextBox
        Me.shenqingdanweil = New System.Windows.Forms.Label
        Me.mubiaobumen = New System.Windows.Forms.ComboBox
        Me.huowumingl = New System.Windows.Forms.Label
        Me.zichanhao = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.afcehao = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.beizhu = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dt1 = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ID = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "资产调拨界面"
        '
        'yuanshibumen
        '
        Me.yuanshibumen.Enabled = False
        Me.yuanshibumen.Location = New System.Drawing.Point(94, 97)
        Me.yuanshibumen.Name = "yuanshibumen"
        Me.yuanshibumen.Size = New System.Drawing.Size(114, 20)
        Me.yuanshibumen.TabIndex = 158
        '
        'shenqingdanweil
        '
        Me.shenqingdanweil.AutoSize = True
        Me.shenqingdanweil.Location = New System.Drawing.Point(36, 100)
        Me.shenqingdanweil.Name = "shenqingdanweil"
        Me.shenqingdanweil.Size = New System.Drawing.Size(55, 13)
        Me.shenqingdanweil.TabIndex = 157
        Me.shenqingdanweil.Text = "原始部门"
        '
        'mubiaobumen
        '
        Me.mubiaobumen.FormattingEnabled = True
        Me.mubiaobumen.Location = New System.Drawing.Point(311, 97)
        Me.mubiaobumen.Name = "mubiaobumen"
        Me.mubiaobumen.Size = New System.Drawing.Size(114, 21)
        Me.mubiaobumen.TabIndex = 155
        '
        'huowumingl
        '
        Me.huowumingl.AutoSize = True
        Me.huowumingl.Location = New System.Drawing.Point(252, 100)
        Me.huowumingl.Name = "huowumingl"
        Me.huowumingl.Size = New System.Drawing.Size(55, 13)
        Me.huowumingl.TabIndex = 156
        Me.huowumingl.Text = "目标部门"
        '
        'zichanhao
        '
        Me.zichanhao.Enabled = False
        Me.zichanhao.Location = New System.Drawing.Point(311, 53)
        Me.zichanhao.Name = "zichanhao"
        Me.zichanhao.Size = New System.Drawing.Size(114, 20)
        Me.zichanhao.TabIndex = 160
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(262, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 159
        Me.Label2.Text = "资产号"
        '
        'afcehao
        '
        Me.afcehao.Enabled = False
        Me.afcehao.Location = New System.Drawing.Point(94, 53)
        Me.afcehao.Name = "afcehao"
        Me.afcehao.Size = New System.Drawing.Size(114, 20)
        Me.afcehao.TabIndex = 162
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "AFCE"
        '
        'beizhu
        '
        Me.beizhu.Location = New System.Drawing.Point(94, 172)
        Me.beizhu.Name = "beizhu"
        Me.beizhu.Size = New System.Drawing.Size(368, 20)
        Me.beizhu.TabIndex = 164
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "备注"
        '
        'dt1
        '
        Me.dt1.Enabled = False
        Me.dt1.Location = New System.Drawing.Point(94, 146)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(114, 20)
        Me.dt1.TabIndex = 165
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "调拨时间"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(188, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 28)
        Me.Button1.TabIndex = 167
        Me.Button1.Text = "确定调拨"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(3, 5)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(18, 13)
        Me.ID.TabIndex = 168
        Me.ID.Text = "ID"
        '
        'Moveform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 258)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dt1)
        Me.Controls.Add(Me.beizhu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.afcehao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.zichanhao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.yuanshibumen)
        Me.Controls.Add(Me.shenqingdanweil)
        Me.Controls.Add(Me.mubiaobumen)
        Me.Controls.Add(Me.huowumingl)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Moveform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Moveform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents yuanshibumen As System.Windows.Forms.TextBox
    Friend WithEvents shenqingdanweil As System.Windows.Forms.Label
    Friend WithEvents mubiaobumen As System.Windows.Forms.ComboBox
    Friend WithEvents huowumingl As System.Windows.Forms.Label
    Friend WithEvents zichanhao As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents afcehao As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents beizhu As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.Label
End Class
