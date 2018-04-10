<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SETBUND
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pinpai = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tongxunkou = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bitelv = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.xiaoyanwei = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.shujuwei = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tingzhiwei = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(62, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(368, 73)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "应用到本机地磅"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pinpai
        '
        Me.pinpai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pinpai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pinpai.FormattingEnabled = True
        Me.pinpai.Items.AddRange(New Object() {"梅特勒托利多类型", "济南金钟类型"})
        Me.pinpai.Location = New System.Drawing.Point(145, 103)
        Me.pinpai.Name = "pinpai"
        Me.pinpai.Size = New System.Drawing.Size(285, 28)
        Me.pinpai.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "衡器品牌类型："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "通讯口："
        '
        'tongxunkou
        '
        Me.tongxunkou.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tongxunkou.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tongxunkou.FormattingEnabled = True
        Me.tongxunkou.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9"})
        Me.tongxunkou.Location = New System.Drawing.Point(145, 152)
        Me.tongxunkou.Name = "tongxunkou"
        Me.tongxunkou.Size = New System.Drawing.Size(285, 28)
        Me.tongxunkou.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "比特率："
        '
        'bitelv
        '
        Me.bitelv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bitelv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bitelv.FormattingEnabled = True
        Me.bitelv.Items.AddRange(New Object() {"1200", "2400", "3600", "4800", "9600", "12800"})
        Me.bitelv.Location = New System.Drawing.Point(145, 195)
        Me.bitelv.Name = "bitelv"
        Me.bitelv.Size = New System.Drawing.Size(285, 28)
        Me.bitelv.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "校验位："
        '
        'xiaoyanwei
        '
        Me.xiaoyanwei.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xiaoyanwei.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xiaoyanwei.FormattingEnabled = True
        Me.xiaoyanwei.Items.AddRange(New Object() {"Even", "Mark", "None", "Odd", "Space"})
        Me.xiaoyanwei.Location = New System.Drawing.Point(145, 239)
        Me.xiaoyanwei.Name = "xiaoyanwei"
        Me.xiaoyanwei.Size = New System.Drawing.Size(285, 28)
        Me.xiaoyanwei.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "数据位："
        '
        'shujuwei
        '
        Me.shujuwei.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.shujuwei.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shujuwei.FormattingEnabled = True
        Me.shujuwei.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.shujuwei.Location = New System.Drawing.Point(145, 283)
        Me.shujuwei.Name = "shujuwei"
        Me.shujuwei.Size = New System.Drawing.Size(285, 28)
        Me.shujuwei.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "停止位："
        '
        'tingzhiwei
        '
        Me.tingzhiwei.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tingzhiwei.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tingzhiwei.FormattingEnabled = True
        Me.tingzhiwei.Items.AddRange(New Object() {"None", "One", "OnePointFive", "Two"})
        Me.tingzhiwei.Location = New System.Drawing.Point(145, 326)
        Me.tingzhiwei.Name = "tingzhiwei"
        Me.tingzhiwei.Size = New System.Drawing.Size(285, 28)
        Me.tingzhiwei.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label8.Location = New System.Drawing.Point(138, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(248, 37)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "波特率设置界面"
        '
        'SETBUND
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(494, 492)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tingzhiwei)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.shujuwei)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.xiaoyanwei)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bitelv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tongxunkou)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pinpai)
        Me.Controls.Add(Me.Button1)
        Me.Name = "SETBUND"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "地磅参数设置"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pinpai As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tongxunkou As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bitelv As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents xiaoyanwei As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents shujuwei As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tingzhiwei As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
