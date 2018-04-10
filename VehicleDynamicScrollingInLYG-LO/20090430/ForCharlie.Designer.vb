<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForCharlie
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.opd = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sheet2_lie = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.sheet2_hang = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.sheet2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sheet1_lie = New System.Windows.Forms.TextBox()
        Me.sheet1_hang = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.sheet1 = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(81, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 31)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "选择模板"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("幼圆", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(259, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(780, 30)
        Me.TextBox1.TabIndex = 7
        '
        'pb
        '
        Me.pb.ForeColor = System.Drawing.Color.Red
        Me.pb.Location = New System.Drawing.Point(0, 197)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(1054, 18)
        Me.pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pb.TabIndex = 38
        '
        'opd
        '
        Me.opd.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(300, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "最大行"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.sheet2_lie)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.sheet2_hang)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.sheet2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.sheet1_lie)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.pb)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.sheet1_hang)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.sheet1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(28, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1054, 215)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "处理区域"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(498, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 14)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "进度条"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(30, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 12)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "第三步:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(451, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 12)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "最大列"
        '
        'sheet2_lie
        '
        Me.sheet2_lie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sheet2_lie.Font = New System.Drawing.Font("幼圆", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.sheet2_lie.Location = New System.Drawing.Point(498, 116)
        Me.sheet2_lie.Name = "sheet2_lie"
        Me.sheet2_lie.Size = New System.Drawing.Size(75, 30)
        Me.sheet2_lie.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(300, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 12)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "最大行"
        '
        'sheet2_hang
        '
        Me.sheet2_hang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sheet2_hang.Font = New System.Drawing.Font("幼圆", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.sheet2_hang.Location = New System.Drawing.Point(347, 116)
        Me.sheet2_hang.Name = "sheet2_hang"
        Me.sheet2_hang.Size = New System.Drawing.Size(75, 30)
        Me.sheet2_hang.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(94, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 12)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "目标数据SHEET号:"
        '
        'sheet2
        '
        Me.sheet2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sheet2.Font = New System.Drawing.Font("幼圆", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.sheet2.Location = New System.Drawing.Point(201, 116)
        Me.sheet2.Name = "sheet2"
        Me.sheet2.Size = New System.Drawing.Size(52, 30)
        Me.sheet2.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(30, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 12)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "第二步:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(30, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 12)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "第一步:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(451, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "最大列"
        '
        'sheet1_lie
        '
        Me.sheet1_lie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sheet1_lie.Font = New System.Drawing.Font("幼圆", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.sheet1_lie.Location = New System.Drawing.Point(498, 67)
        Me.sheet1_lie.Name = "sheet1_lie"
        Me.sheet1_lie.Size = New System.Drawing.Size(75, 30)
        Me.sheet1_lie.TabIndex = 39
        '
        'sheet1_hang
        '
        Me.sheet1_hang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sheet1_hang.Font = New System.Drawing.Font("幼圆", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.sheet1_hang.Location = New System.Drawing.Point(347, 67)
        Me.sheet1_hang.Name = "sheet1_hang"
        Me.sheet1_hang.Size = New System.Drawing.Size(75, 30)
        Me.sheet1_hang.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(86, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 12)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "准备核对的SHEET号:"
        '
        'sheet1
        '
        Me.sheet1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sheet1.Font = New System.Drawing.Font("幼圆", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.sheet1.Location = New System.Drawing.Point(201, 67)
        Me.sheet1.Name = "sheet1"
        Me.sheet1.Size = New System.Drawing.Size(52, 30)
        Me.sheet1.TabIndex = 34
        '
        'OK
        '
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OK.Location = New System.Drawing.Point(28, 319)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(490, 66)
        Me.OK.TabIndex = 10
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("幼圆", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(417, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 29)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "核对EXCEL数据任务"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(592, 320)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(490, 65)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "杀EXCEL所有进程"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ForCharlie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 401)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OK)
        Me.Name = "ForCharlie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ForCharlie"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents pb As System.Windows.Forms.ProgressBar
    Friend WithEvents opd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents sheet1_hang As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents sheet1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents sheet2_lie As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents sheet2_hang As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents sheet2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sheet1_lie As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
