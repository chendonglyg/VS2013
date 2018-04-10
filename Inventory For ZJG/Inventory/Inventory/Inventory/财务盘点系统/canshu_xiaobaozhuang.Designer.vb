<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class canshu_xiaobaozhuang
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.保存更新ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.kaishi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sheetno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jieshu = New System.Windows.Forms.TextBox()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.opd = New System.Windows.Forms.OpenFileDialog()
        Me.s1 = New System.Windows.Forms.RadioButton()
        Me.s2 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgv.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Location = New System.Drawing.Point(15, 307)
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
        Me.dgv.Size = New System.Drawing.Size(522, 447)
        Me.dgv.TabIndex = 299
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.保存更新ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(123, 26)
        '
        '保存更新ToolStripMenuItem
        '
        Me.保存更新ToolStripMenuItem.Name = "保存更新ToolStripMenuItem"
        Me.保存更新ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.保存更新ToolStripMenuItem.Text = "保存更新"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(140, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 12)
        Me.Label8.TabIndex = 298
        Me.Label8.Text = "开始标号:"
        '
        'kaishi
        '
        Me.kaishi.Location = New System.Drawing.Point(142, 130)
        Me.kaishi.Name = "kaishi"
        Me.kaishi.Size = New System.Drawing.Size(75, 21)
        Me.kaishi.TabIndex = 297
        Me.kaishi.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(59, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 296
        Me.Label7.Text = "Sheet号:"
        '
        'sheetno
        '
        Me.sheetno.Location = New System.Drawing.Point(61, 130)
        Me.sheetno.Name = "sheetno"
        Me.sheetno.Size = New System.Drawing.Size(75, 21)
        Me.sheetno.TabIndex = 295
        Me.sheetno.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(222, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 12)
        Me.Label5.TabIndex = 294
        Me.Label5.Text = "结束标号:"
        '
        'jieshu
        '
        Me.jieshu.Location = New System.Drawing.Point(224, 130)
        Me.jieshu.Name = "jieshu"
        Me.jieshu.Size = New System.Drawing.Size(75, 21)
        Me.jieshu.TabIndex = 293
        '
        'pb
        '
        Me.pb.ForeColor = System.Drawing.Color.Red
        Me.pb.Location = New System.Drawing.Point(60, 192)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(443, 18)
        Me.pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pb.TabIndex = 291
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("黑体", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(53, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(411, 33)
        Me.Label3.TabIndex = 292
        Me.Label3.Text = "小包装物料编码导入及维护"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(287, 216)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 44)
        Me.Button4.TabIndex = 290
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(173, 216)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 44)
        Me.Button3.TabIndex = 289
        Me.Button3.Text = "Import"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(61, 154)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(442, 21)
        Me.TextBox1.TabIndex = 287
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(59, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 44)
        Me.Button1.TabIndex = 288
        Me.Button1.Text = "打开Excel文件"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'opd
        '
        Me.opd.FileName = "OpenFileDialog1"
        '
        's1
        '
        Me.s1.AutoSize = True
        Me.s1.Location = New System.Drawing.Point(62, 91)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(71, 16)
        Me.s1.TabIndex = 300
        Me.s1.TabStop = True
        Me.s1.Text = "覆盖导入"
        Me.s1.UseVisualStyleBackColor = True
        '
        's2
        '
        Me.s2.AutoSize = True
        Me.s2.Location = New System.Drawing.Point(209, 91)
        Me.s2.Name = "s2"
        Me.s2.Size = New System.Drawing.Size(71, 16)
        Me.s2.TabIndex = 301
        Me.s2.TabStop = True
        Me.s2.Text = "追加导入"
        Me.s2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(401, 216)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 44)
        Me.Button2.TabIndex = 302
        Me.Button2.Text = "显示"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("幼圆", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(61, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 14)
        Me.Label1.TabIndex = 303
        Me.Label1.Text = "第一列：物料编码 第二列：物料描述 "
        '
        'canshu_xiaobaozhuang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 773)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.s2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.s1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.kaishi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.sheetno)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.jieshu)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Name = "canshu_xiaobaozhuang"
        Me.Text = "益海（连云港）盘点系统"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents kaishi As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents sheetno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents jieshu As System.Windows.Forms.TextBox
    Friend WithEvents pb As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents opd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents s1 As System.Windows.Forms.RadioButton
    Friend WithEvents s2 As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 保存更新ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
