<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_Total
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
        Me.dt12 = New System.Windows.Forms.DateTimePicker()
        Me.dt11 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.shdwlabel = New System.Windows.Forms.CheckBox()
        Me.shdw = New System.Windows.Forms.ComboBox()
        Me.huomingshou = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fhdwlabel = New System.Windows.Forms.CheckBox()
        Me.fhdw = New System.Windows.Forms.ComboBox()
        Me.fahuohehuoming = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.fahuozhi = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.baojianhaozhi = New System.Windows.Forms.ComboBox()
        Me.huomingfa = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chuanbo = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.huomingheshouhuo = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.huominghefahuo = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.huoming = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.danwei = New System.Windows.Forms.ComboBox()
        Me.dw = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dt12
        '
        Me.dt12.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dt12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt12.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt12.Location = New System.Drawing.Point(640, 75)
        Me.dt12.Name = "dt12"
        Me.dt12.Size = New System.Drawing.Size(141, 21)
        Me.dt12.TabIndex = 290
        '
        'dt11
        '
        Me.dt11.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dt11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt11.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt11.Location = New System.Drawing.Point(461, 75)
        Me.dt11.Name = "dt11"
        Me.dt11.Size = New System.Drawing.Size(141, 21)
        Me.dt11.TabIndex = 289
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(522, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 38)
        Me.Label1.TabIndex = 288
        Me.Label1.Text = "汇总报表打印"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.shdwlabel)
        Me.GroupBox1.Controls.Add(Me.shdw)
        Me.GroupBox1.Controls.Add(Me.huomingshou)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.fhdwlabel)
        Me.GroupBox1.Controls.Add(Me.fhdw)
        Me.GroupBox1.Controls.Add(Me.fahuohehuoming)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.fahuozhi)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.baojianhaozhi)
        Me.GroupBox1.Controls.Add(Me.huomingfa)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.chuanbo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.huomingheshouhuo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.huominghefahuo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.huoming)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1211, 134)
        Me.GroupBox1.TabIndex = 292
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询字段"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(734, 60)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(104, 17)
        Me.CheckBox1.TabIndex = 319
        Me.CheckBox1.Text = "是否为集装箱?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'shdwlabel
        '
        Me.shdwlabel.AutoSize = True
        Me.shdwlabel.Location = New System.Drawing.Point(495, 105)
        Me.shdwlabel.Name = "shdwlabel"
        Me.shdwlabel.Size = New System.Drawing.Size(74, 17)
        Me.shdwlabel.TabIndex = 318
        Me.shdwlabel.Text = "收货单位"
        Me.shdwlabel.UseVisualStyleBackColor = True
        '
        'shdw
        '
        Me.shdw.FormattingEnabled = True
        Me.shdw.Location = New System.Drawing.Point(570, 103)
        Me.shdw.Name = "shdw"
        Me.shdw.Size = New System.Drawing.Size(113, 21)
        Me.shdw.TabIndex = 317
        '
        'huomingshou
        '
        Me.huomingshou.FormattingEnabled = True
        Me.huomingshou.Location = New System.Drawing.Point(570, 76)
        Me.huomingshou.Name = "huomingshou"
        Me.huomingshou.Size = New System.Drawing.Size(113, 21)
        Me.huomingshou.TabIndex = 316
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(535, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 315
        Me.Label6.Text = "货名"
        '
        'fhdwlabel
        '
        Me.fhdwlabel.AutoSize = True
        Me.fhdwlabel.Location = New System.Drawing.Point(260, 107)
        Me.fhdwlabel.Name = "fhdwlabel"
        Me.fhdwlabel.Size = New System.Drawing.Size(74, 17)
        Me.fhdwlabel.TabIndex = 314
        Me.fhdwlabel.Text = "发货单位"
        Me.fhdwlabel.UseVisualStyleBackColor = True
        '
        'fhdw
        '
        Me.fhdw.FormattingEnabled = True
        Me.fhdw.Location = New System.Drawing.Point(335, 105)
        Me.fhdw.Name = "fhdw"
        Me.fhdw.Size = New System.Drawing.Size(113, 21)
        Me.fhdw.TabIndex = 313
        '
        'fahuohehuoming
        '
        Me.fahuohehuoming.AutoSize = True
        Me.fahuohehuoming.Location = New System.Drawing.Point(969, 59)
        Me.fahuohehuoming.Name = "fahuohehuoming"
        Me.fahuohehuoming.Size = New System.Drawing.Size(223, 17)
        Me.fahuohehuoming.TabIndex = 311
        Me.fahuohehuoming.TabStop = True
        Me.fahuohehuoming.Text = "按指定时间内发货单位+货名进行汇总"
        Me.fahuohehuoming.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(965, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(172, 20)
        Me.Label10.TabIndex = 310
        Me.Label10.Text = "按发货单位+货名汇总"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'fahuozhi
        '
        Me.fahuozhi.FormattingEnabled = True
        Me.fahuozhi.Location = New System.Drawing.Point(1022, 77)
        Me.fahuozhi.Name = "fahuozhi"
        Me.fahuozhi.Size = New System.Drawing.Size(124, 21)
        Me.fahuozhi.TabIndex = 309
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(966, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 308
        Me.Label9.Text = "发货单位:"
        '
        'baojianhaozhi
        '
        Me.baojianhaozhi.FormattingEnabled = True
        Me.baojianhaozhi.Location = New System.Drawing.Point(777, 102)
        Me.baojianhaozhi.Name = "baojianhaozhi"
        Me.baojianhaozhi.Size = New System.Drawing.Size(152, 21)
        Me.baojianhaozhi.TabIndex = 305
        '
        'huomingfa
        '
        Me.huomingfa.FormattingEnabled = True
        Me.huomingfa.Location = New System.Drawing.Point(335, 78)
        Me.huomingfa.Name = "huomingfa"
        Me.huomingfa.Size = New System.Drawing.Size(113, 21)
        Me.huomingfa.TabIndex = 304
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(725, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 302
        Me.Label8.Text = "报检号:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(730, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 20)
        Me.Label7.TabIndex = 301
        Me.Label7.Text = "按船舶汇总"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chuanbo
        '
        Me.chuanbo.AutoSize = True
        Me.chuanbo.Location = New System.Drawing.Point(734, 82)
        Me.chuanbo.Name = "chuanbo"
        Me.chuanbo.Size = New System.Drawing.Size(193, 17)
        Me.chuanbo.TabIndex = 300
        Me.chuanbo.TabStop = True
        Me.chuanbo.Text = "按报检号对货物名进行分类汇总"
        Me.chuanbo.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(300, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 296
        Me.Label12.Text = "货名"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(490, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 20)
        Me.Label5.TabIndex = 295
        Me.Label5.Text = "按货名+收货单位汇总"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'huomingheshouhuo
        '
        Me.huomingheshouhuo.AutoSize = True
        Me.huomingheshouhuo.Location = New System.Drawing.Point(494, 59)
        Me.huomingheshouhuo.Name = "huomingheshouhuo"
        Me.huomingheshouhuo.Size = New System.Drawing.Size(199, 17)
        Me.huomingheshouhuo.TabIndex = 294
        Me.huomingheshouhuo.TabStop = True
        Me.huomingheshouhuo.Text = "按指定时间内货名+收货单位汇总"
        Me.huomingheshouhuo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(270, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 20)
        Me.Label4.TabIndex = 292
        Me.Label4.Text = "按货名+发货单位汇总"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'huominghefahuo
        '
        Me.huominghefahuo.AutoSize = True
        Me.huominghefahuo.Location = New System.Drawing.Point(274, 59)
        Me.huominghefahuo.Name = "huominghefahuo"
        Me.huominghefahuo.Size = New System.Drawing.Size(181, 17)
        Me.huominghefahuo.TabIndex = 291
        Me.huominghefahuo.TabStop = True
        Me.huominghefahuo.Text = "按指定时间内发货单位名汇总"
        Me.huominghefahuo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(20, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 290
        Me.Label2.Text = "按货物分类汇总"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'huoming
        '
        Me.huoming.AutoSize = True
        Me.huoming.Location = New System.Drawing.Point(24, 59)
        Me.huoming.Name = "huoming"
        Me.huoming.Size = New System.Drawing.Size(205, 17)
        Me.huoming.TabIndex = 289
        Me.huoming.TabStop = True
        Me.huoming.Text = "按指定时间内货物名进行分类汇总"
        Me.huoming.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(608, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 20)
        Me.Label3.TabIndex = 293
        Me.Label3.Text = "至"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Image = Global.Balance.My.Resources.Resources.Hein30
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(366, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 60)
        Me.Button1.TabIndex = 294
        Me.Button1.Text = "打印汇总报表"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Image = Global.Balance.My.Resources.Resources.Toolbar11
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(747, 276)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 60)
        Me.Button2.TabIndex = 295
        Me.Button2.Text = "退出"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Image = Global.Balance.My.Resources.Resources.Hein18
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(206, 276)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(147, 60)
        Me.Button3.TabIndex = 296
        Me.Button3.Text = "查询"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(19, 342)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(1241, 410)
        Me.dgv.TabIndex = 297
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 325)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 14)
        Me.Label11.TabIndex = 298
        Me.Label11.Text = "预览区"
        '
        'danwei
        '
        Me.danwei.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.danwei.FormattingEnabled = True
        Me.danwei.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "筒仓", "粕库", "榨油厂", "精炼厂", "分提车间", "酸化油车间", "35T锅炉房", "75T锅炉房", "污水处理", "小包装罐区", "粮油罐区", "小包装成品库", "小包装辅料库", "IT"})
        Me.danwei.Location = New System.Drawing.Point(589, 106)
        Me.danwei.Name = "danwei"
        Me.danwei.Size = New System.Drawing.Size(85, 21)
        Me.danwei.TabIndex = 299
        '
        'dw
        '
        Me.dw.AutoSize = True
        Me.dw.Location = New System.Drawing.Point(536, 108)
        Me.dw.Name = "dw"
        Me.dw.Size = New System.Drawing.Size(53, 17)
        Me.dw.TabIndex = 315
        Me.dw.Text = "单位:"
        Me.dw.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.Image = Global.Balance.My.Resources.Resources.Hein30
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(557, 276)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(180, 60)
        Me.Button4.TabIndex = 316
        Me.Button4.Text = "打印采购分析表"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Report_Total
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 774)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dw)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.danwei)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dt12)
        Me.Controls.Add(Me.dt11)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Report_Total"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "汇总报表打印页面"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dt12 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt11 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents huoming As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents huomingheshouhuo As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents huominghefahuo As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chuanbo As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents huomingfa As System.Windows.Forms.ComboBox
    Friend WithEvents baojianhaozhi As System.Windows.Forms.ComboBox
    Friend WithEvents fahuohehuoming As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents fahuozhi As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents fhdw As System.Windows.Forms.ComboBox
    Friend WithEvents shdwlabel As System.Windows.Forms.CheckBox
    Friend WithEvents shdw As System.Windows.Forms.ComboBox
    Friend WithEvents huomingshou As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fhdwlabel As System.Windows.Forms.CheckBox
    Friend WithEvents danwei As System.Windows.Forms.ComboBox
    Friend WithEvents dw As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
