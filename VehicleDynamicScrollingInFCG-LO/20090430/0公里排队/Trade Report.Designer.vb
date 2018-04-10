<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trade_Report
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

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.chehao = New System.Windows.Forms.TextBox()
        Me.pinming = New System.Windows.Forms.ComboBox()
        Me.kehumingcheng = New System.Windows.Forms.ComboBox()
        Me.dt12 = New System.Windows.Forms.DateTimePicker()
        Me.dt11 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 258)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1066, 358)
        Me.GroupBox2.TabIndex = 163
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "数据浏览区"
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Location = New System.Drawing.Point(14, 20)
        Me.dgv.Name = "dgv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.Size = New System.Drawing.Size(1040, 324)
        Me.dgv.TabIndex = 144
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Button2.Location = New System.Drawing.Point(122, 203)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(310, 55)
        Me.Button2.TabIndex = 160
        Me.Button2.Text = "检索"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(504, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 31)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "报表打印"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.cb3)
        Me.GroupBox1.Controls.Add(Me.cb2)
        Me.GroupBox1.Controls.Add(Me.cb1)
        Me.GroupBox1.Controls.Add(Me.chehao)
        Me.GroupBox1.Controls.Add(Me.pinming)
        Me.GroupBox1.Controls.Add(Me.kehumingcheng)
        Me.GroupBox1.Location = New System.Drawing.Point(122, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(899, 99)
        Me.GroupBox1.TabIndex = 177
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "检索参数区"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(316, 51)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 34)
        Me.Button4.TabIndex = 186
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cb3.Location = New System.Drawing.Point(696, 20)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(71, 31)
        Me.cb3.TabIndex = 185
        Me.cb3.Text = "车号"
        Me.cb3.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cb2.Location = New System.Drawing.Point(416, 20)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(111, 31)
        Me.cb2.TabIndex = 184
        Me.cb2.Text = "货物名称"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cb1.Location = New System.Drawing.Point(12, 20)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(111, 31)
        Me.cb1.TabIndex = 183
        Me.cb1.Text = "客户名称"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'chehao
        '
        Me.chehao.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.chehao.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chehao.ForeColor = System.Drawing.Color.Yellow
        Me.chehao.Location = New System.Drawing.Point(696, 52)
        Me.chehao.Name = "chehao"
        Me.chehao.Size = New System.Drawing.Size(178, 34)
        Me.chehao.TabIndex = 182
        '
        'pinming
        '
        Me.pinming.BackColor = System.Drawing.SystemColors.Info
        Me.pinming.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pinming.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.pinming.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pinming.FormattingEnabled = True
        Me.pinming.Location = New System.Drawing.Point(416, 51)
        Me.pinming.Name = "pinming"
        Me.pinming.Size = New System.Drawing.Size(264, 35)
        Me.pinming.TabIndex = 180
        '
        'kehumingcheng
        '
        Me.kehumingcheng.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kehumingcheng.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.kehumingcheng.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.kehumingcheng.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kehumingcheng.FormattingEnabled = True
        Me.kehumingcheng.Location = New System.Drawing.Point(12, 51)
        Me.kehumingcheng.Name = "kehumingcheng"
        Me.kehumingcheng.Size = New System.Drawing.Size(298, 35)
        Me.kehumingcheng.TabIndex = 177
        '
        'dt12
        '
        Me.dt12.CalendarFont = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dt12.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dt12.Location = New System.Drawing.Point(581, 64)
        Me.dt12.Name = "dt12"
        Me.dt12.Size = New System.Drawing.Size(207, 34)
        Me.dt12.TabIndex = 184
        '
        'dt11
        '
        Me.dt11.CalendarFont = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dt11.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dt11.Location = New System.Drawing.Point(311, 64)
        Me.dt11.Name = "dt11"
        Me.dt11.Size = New System.Drawing.Size(210, 34)
        Me.dt11.TabIndex = 183
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(523, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 27)
        Me.Label5.TabIndex = 178
        Me.Label5.Text = "-----"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Button1.Location = New System.Drawing.Point(754, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(330, 55)
        Me.Button1.TabIndex = 185
        Me.Button1.Text = "退出"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Button3.Location = New System.Drawing.Point(438, 203)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(310, 55)
        Me.Button3.TabIndex = 186
        Me.Button3.Text = "打印"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(200, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 31)
        Me.Label1.TabIndex = 187
        '
        'Trade_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1121, 627)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dt12)
        Me.Controls.Add(Me.dt11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "Trade_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trade_Report"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dt12 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt11 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chehao As System.Windows.Forms.TextBox
    Friend WithEvents pinming As System.Windows.Forms.ComboBox
    Friend WithEvents kehumingcheng As System.Windows.Forms.ComboBox
    Friend WithEvents cb3 As System.Windows.Forms.CheckBox
    Friend WithEvents cb2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
