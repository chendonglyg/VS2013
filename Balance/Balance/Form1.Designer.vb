<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pd = New System.Windows.Forms.PrintDialog()
        Me.station = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.showusers = New System.Windows.Forms.Button()
        Me.danweichushihua = New System.Windows.Forms.Button()
        Me.message = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(252, 198)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(234, 87)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "设置波特率"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, -53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 48)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "设置总界面"
        '
        'pd
        '
        Me.pd.UseEXDialog = True
        '
        'station
        '
        Me.station.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.station.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.station.FormattingEnabled = True
        Me.station.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "筒仓", "粕库", "榨油厂", "精炼厂", "分提车间", "酸化油车间", "35T锅炉房", "75T锅炉房", "污水处理", "小包装罐区", "粮油罐区", "小包装成品库", "小包装辅料库", "IT", "财务", "管理"})
        Me.station.Location = New System.Drawing.Point(174, 200)
        Me.station.Name = "station"
        Me.station.Size = New System.Drawing.Size(70, 20)
        Me.station.TabIndex = 78
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.Balance.My.Resources.Resources.Osx10
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(252, 105)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(234, 87)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "已删除记录"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'showusers
        '
        Me.showusers.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.showusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showusers.Image = Global.Balance.My.Resources.Resources.Slayman3
        Me.showusers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.showusers.Location = New System.Drawing.Point(252, 12)
        Me.showusers.Name = "showusers"
        Me.showusers.Size = New System.Drawing.Size(234, 87)
        Me.showusers.TabIndex = 3
        Me.showusers.Text = "查看在线用户"
        Me.showusers.UseVisualStyleBackColor = False
        '
        'danweichushihua
        '
        Me.danweichushihua.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.danweichushihua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.danweichushihua.Image = Global.Balance.My.Resources.Resources.Tools
        Me.danweichushihua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.danweichushihua.Location = New System.Drawing.Point(12, 198)
        Me.danweichushihua.Name = "danweichushihua"
        Me.danweichushihua.Size = New System.Drawing.Size(234, 87)
        Me.danweichushihua.TabIndex = 2
        Me.danweichushihua.Text = "单位初始化"
        Me.danweichushihua.UseVisualStyleBackColor = False
        '
        'message
        '
        Me.message.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.message.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.message.Image = Global.Balance.My.Resources.Resources.Hein007
        Me.message.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.message.Location = New System.Drawing.Point(12, 105)
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(234, 87)
        Me.message.TabIndex = 1
        Me.message.Text = "发送新广播"
        Me.message.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Balance.My.Resources.Resources.Osx41
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(234, 87)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "报检号设置"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(495, 297)
        Me.Controls.Add(Me.station)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.showusers)
        Me.Controls.Add(Me.danweichushihua)
        Me.Controls.Add(Me.message)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "设置界面"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents message As System.Windows.Forms.Button
    Friend WithEvents danweichushihua As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents showusers As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pd As System.Windows.Forms.PrintDialog
    Friend WithEvents station As System.Windows.Forms.ComboBox
End Class
