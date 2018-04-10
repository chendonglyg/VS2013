<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoveStore
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ziduan = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.guanjianzi = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ipaddresslabel = New System.Windows.Forms.ToolStripLabel()
        Me.ipaddress = New System.Windows.Forms.ToolStripComboBox()
        Me.sqlportlabel = New System.Windows.Forms.ToolStripLabel()
        Me.sqlport = New System.Windows.Forms.ToolStripTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt12 = New System.Windows.Forms.DateTimePicker()
        Me.dt11 = New System.Windows.Forms.DateTimePicker()
        Me.bq = New System.Windows.Forms.RadioButton()
        Me.xbz = New System.Windows.Forms.RadioButton()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(442, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "益海（连云港）移库数据查询"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(23, 178)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.Size = New System.Drawing.Size(1227, 475)
        Me.dgv.TabIndex = 297
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(20, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 299
        Me.Label2.Text = "数据一览区"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ziduan, Me.ToolStripSeparator2, Me.ToolStripButton2, Me.guanjianzi, Me.ToolStripSeparator3, Me.ToolStripButton7, Me.ToolStripSeparator1, Me.ToolStripSeparator6, Me.ToolStripButton5, Me.ToolStripButton3, Me.ToolStripSeparator4, Me.ToolStripSeparator5, Me.ToolStripButton4, Me.ToolStripComboBox1, Me.ToolStripSeparator7, Me.ipaddresslabel, Me.ipaddress, Me.sqlportlabel, Me.sqlport})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1272, 25)
        Me.ToolStrip1.TabIndex = 300
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Balance.My.Resources.Resources.Hein18
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripButton1.Text = "选择字段"
        '
        'ziduan
        '
        Me.ziduan.Items.AddRange(New Object() {"票号", "车号", "司机", "货名"})
        Me.ziduan.Name = "ziduan"
        Me.ziduan.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Balance.My.Resources.Resources.Osx41
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripButton2.Text = "关键字"
        '
        'guanjianzi
        '
        Me.guanjianzi.Name = "guanjianzi"
        Me.guanjianzi.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Image = Global.Balance.My.Resources.Resources.车辆
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripButton7.Text = "查询"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = Global.Balance.My.Resources.Resources.Hein30
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripButton5.Text = "打印移库分析表"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.Balance.My.Resources.Resources.Hein30
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripButton3.Text = "打印移库明细表"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.Balance.My.Resources.Resources.Slayman3
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripButton4.Text = "退出"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ipaddresslabel
        '
        Me.ipaddresslabel.Name = "ipaddresslabel"
        Me.ipaddresslabel.Size = New System.Drawing.Size(67, 22)
        Me.ipaddresslabel.Text = "服务器地址"
        '
        'ipaddress
        '
        Me.ipaddress.Enabled = False
        Me.ipaddress.Name = "ipaddress"
        Me.ipaddress.Size = New System.Drawing.Size(121, 25)
        Me.ipaddress.Text = "218.92.115.4"
        '
        'sqlportlabel
        '
        Me.sqlportlabel.Name = "sqlportlabel"
        Me.sqlportlabel.Size = New System.Drawing.Size(31, 22)
        Me.sqlportlabel.Text = "端口"
        '
        'sqlport
        '
        Me.sqlport.Enabled = False
        Me.sqlport.Name = "sqlport"
        Me.sqlport.Size = New System.Drawing.Size(100, 25)
        Me.sqlport.Text = "1433"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(599, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 20)
        Me.Label3.TabIndex = 303
        Me.Label3.Text = "至"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dt12
        '
        Me.dt12.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt12.CustomFormat = "yyyy-MM-dd"
        Me.dt12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt12.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt12.Location = New System.Drawing.Point(631, 111)
        Me.dt12.Name = "dt12"
        Me.dt12.Size = New System.Drawing.Size(149, 35)
        Me.dt12.TabIndex = 302
        '
        'dt11
        '
        Me.dt11.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt11.CustomFormat = "yyyy-MM-dd"
        Me.dt11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt11.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt11.Location = New System.Drawing.Point(443, 111)
        Me.dt11.Name = "dt11"
        Me.dt11.Size = New System.Drawing.Size(149, 35)
        Me.dt11.TabIndex = 301
        '
        'bq
        '
        Me.bq.AutoSize = True
        Me.bq.Location = New System.Drawing.Point(463, 88)
        Me.bq.Name = "bq"
        Me.bq.Size = New System.Drawing.Size(73, 17)
        Me.bq.TabIndex = 304
        Me.bq.TabStop = True
        Me.bq.Text = "板桥数据"
        Me.bq.UseVisualStyleBackColor = True
        '
        'xbz
        '
        Me.xbz.AutoSize = True
        Me.xbz.Location = New System.Drawing.Point(631, 88)
        Me.xbz.Name = "xbz"
        Me.xbz.Size = New System.Drawing.Size(85, 17)
        Me.xbz.TabIndex = 305
        Me.xbz.TabStop = True
        Me.xbz.Text = "小包装数据"
        Me.xbz.UseVisualStyleBackColor = True
        '
        'MoveStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 673)
        Me.Controls.Add(Me.xbz)
        Me.Controls.Add(Me.bq)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dt12)
        Me.Controls.Add(Me.dt11)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MoveStore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "移库数据查询"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ziduan As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents guanjianzi As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt12 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt11 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ipaddresslabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ipaddress As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents sqlportlabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents sqlport As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents bq As System.Windows.Forms.RadioButton
    Friend WithEvents xbz As System.Windows.Forms.RadioButton
End Class
