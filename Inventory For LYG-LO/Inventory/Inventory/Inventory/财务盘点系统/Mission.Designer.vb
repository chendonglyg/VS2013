<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mission
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.kaishi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sheetno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jieshu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.opd = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.banqiao = New System.Windows.Forms.RadioButton()
        Me.yingxiao = New System.Windows.Forms.RadioButton()
        Me.youhua = New System.Windows.Forms.RadioButton()
        Me.liangyou = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(130, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "开始标号:"
        '
        'kaishi
        '
        Me.kaishi.Location = New System.Drawing.Point(132, 113)
        Me.kaishi.Name = "kaishi"
        Me.kaishi.Size = New System.Drawing.Size(75, 20)
        Me.kaishi.TabIndex = 56
        Me.kaishi.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(49, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Sheet号:"
        '
        'sheetno
        '
        Me.sheetno.Location = New System.Drawing.Point(51, 113)
        Me.sheetno.Name = "sheetno"
        Me.sheetno.Size = New System.Drawing.Size(75, 20)
        Me.sheetno.TabIndex = 54
        Me.sheetno.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(212, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "结束标号:"
        '
        'jieshu
        '
        Me.jieshu.Location = New System.Drawing.Point(214, 113)
        Me.jieshu.Name = "jieshu"
        Me.jieshu.Size = New System.Drawing.Size(75, 20)
        Me.jieshu.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("幼圆", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(332, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(322, 24)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "罐号品名密度编码一次性导入"
        '
        'pb
        '
        Me.pb.ForeColor = System.Drawing.Color.Red
        Me.pb.Location = New System.Drawing.Point(50, 263)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(373, 20)
        Me.pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pb.TabIndex = 44
        '
        'opd
        '
        Me.opd.FileName = "OpenFileDialog1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(51, 139)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(373, 20)
        Me.TextBox1.TabIndex = 36
        '
        'dgv
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Location = New System.Drawing.Point(579, 114)
        Me.dgv.Name = "dgv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.Size = New System.Drawing.Size(414, 246)
        Me.dgv.TabIndex = 60
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(226, 306)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(172, 57)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(48, 306)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(172, 57)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "Import"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(430, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 49)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "打开Excel文件"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'banqiao
        '
        Me.banqiao.AutoSize = True
        Me.banqiao.Location = New System.Drawing.Point(235, 221)
        Me.banqiao.Name = "banqiao"
        Me.banqiao.Size = New System.Drawing.Size(73, 17)
        Me.banqiao.TabIndex = 286
        Me.banqiao.TabStop = True
        Me.banqiao.Text = "板桥罐区"
        Me.banqiao.UseVisualStyleBackColor = True
        '
        'yingxiao
        '
        Me.yingxiao.AutoSize = True
        Me.yingxiao.Location = New System.Drawing.Point(50, 221)
        Me.yingxiao.Name = "yingxiao"
        Me.yingxiao.Size = New System.Drawing.Size(73, 17)
        Me.yingxiao.TabIndex = 285
        Me.yingxiao.TabStop = True
        Me.yingxiao.Text = "营销罐区"
        Me.yingxiao.UseVisualStyleBackColor = True
        '
        'youhua
        '
        Me.youhua.AutoSize = True
        Me.youhua.Location = New System.Drawing.Point(235, 190)
        Me.youhua.Name = "youhua"
        Me.youhua.Size = New System.Drawing.Size(73, 17)
        Me.youhua.TabIndex = 284
        Me.youhua.TabStop = True
        Me.youhua.Text = "油化罐区"
        Me.youhua.UseVisualStyleBackColor = True
        '
        'liangyou
        '
        Me.liangyou.AutoSize = True
        Me.liangyou.Location = New System.Drawing.Point(50, 190)
        Me.liangyou.Name = "liangyou"
        Me.liangyou.Size = New System.Drawing.Size(73, 17)
        Me.liangyou.TabIndex = 283
        Me.liangyou.TabStop = True
        Me.liangyou.Text = "粮油罐区"
        Me.liangyou.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Inventory.My.Resources.Resources.罐区任务导入格式说明图
        Me.PictureBox1.Location = New System.Drawing.Point(48, 389)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(945, 278)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 287
        Me.PictureBox1.TabStop = False
        '
        'Mission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 688)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.banqiao)
        Me.Controls.Add(Me.yingxiao)
        Me.Controls.Add(Me.youhua)
        Me.Controls.Add(Me.liangyou)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.kaishi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.sheetno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.jieshu)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Mission"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "益海（连云港）盘点系统"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents kaishi As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents sheetno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents jieshu As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pb As System.Windows.Forms.ProgressBar
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents opd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents banqiao As System.Windows.Forms.RadioButton
    Friend WithEvents yingxiao As System.Windows.Forms.RadioButton
    Friend WithEvents youhua As System.Windows.Forms.RadioButton
    Friend WithEvents liangyou As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
