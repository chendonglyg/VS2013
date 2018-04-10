<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintSomething
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt12 = New System.Windows.Forms.DateTimePicker()
        Me.dt11 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.xbzck3 = New System.Windows.Forms.RadioButton()
        Me.xbzck2 = New System.Windows.Forms.RadioButton()
        Me.flsj = New System.Windows.Forms.Label()
        Me.flpd = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.yxgq = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.xbzck = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gckdp = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ddtc = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dptc = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gq = New System.Windows.Forms.RadioButton()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.seldel = New System.Windows.Forms.CheckBox()
        Me.jilushu = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(516, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 20)
        Me.Label3.TabIndex = 297
        Me.Label3.Text = "至"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dt12
        '
        Me.dt12.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dt12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt12.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt12.Location = New System.Drawing.Point(548, 91)
        Me.dt12.Name = "dt12"
        Me.dt12.Size = New System.Drawing.Size(141, 21)
        Me.dt12.TabIndex = 296
        '
        'dt11
        '
        Me.dt11.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dt11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt11.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt11.Location = New System.Drawing.Point(369, 91)
        Me.dt11.Name = "dt11"
        Me.dt11.Size = New System.Drawing.Size(141, 21)
        Me.dt11.TabIndex = 295
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(419, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 38)
        Me.Label1.TabIndex = 294
        Me.Label1.Text = "盘点报表打印"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xbzck3)
        Me.GroupBox1.Controls.Add(Me.xbzck2)
        Me.GroupBox1.Controls.Add(Me.flsj)
        Me.GroupBox1.Controls.Add(Me.flpd)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.yxgq)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xbzck)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.gckdp)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ddtc)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dptc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.gq)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1019, 135)
        Me.GroupBox1.TabIndex = 298
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "区域选择"
        '
        'xbzck3
        '
        Me.xbzck3.AutoSize = True
        Me.xbzck3.Location = New System.Drawing.Point(806, 87)
        Me.xbzck3.Name = "xbzck3"
        Me.xbzck3.Size = New System.Drawing.Size(109, 17)
        Me.xbzck3.TabIndex = 309
        Me.xbzck3.TabStop = True
        Me.xbzck3.Text = "按盘点人员分组"
        Me.xbzck3.UseVisualStyleBackColor = True
        '
        'xbzck2
        '
        Me.xbzck2.AutoSize = True
        Me.xbzck2.Location = New System.Drawing.Point(806, 63)
        Me.xbzck2.Name = "xbzck2"
        Me.xbzck2.Size = New System.Drawing.Size(157, 17)
        Me.xbzck2.TabIndex = 308
        Me.xbzck2.TabStop = True
        Me.xbzck2.Text = "按货物种类打印简要小计"
        Me.xbzck2.UseVisualStyleBackColor = True
        '
        'flsj
        '
        Me.flsj.AutoSize = True
        Me.flsj.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flsj.ForeColor = System.Drawing.Color.Red
        Me.flsj.Location = New System.Drawing.Point(196, 85)
        Me.flsj.Name = "flsj"
        Me.flsj.Size = New System.Drawing.Size(76, 18)
        Me.flsj.TabIndex = 307
        Me.flsj.Text = "辅料数据"
        Me.flsj.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'flpd
        '
        Me.flpd.AutoSize = True
        Me.flpd.Location = New System.Drawing.Point(197, 103)
        Me.flpd.Name = "flpd"
        Me.flpd.Size = New System.Drawing.Size(205, 17)
        Me.flpd.TabIndex = 306
        Me.flpd.TabStop = True
        Me.flpd.Text = "按指定时间内对散粕筒仓盘点打印"
        Me.flpd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(11, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 18)
        Me.Label8.TabIndex = 305
        Me.Label8.Text = "营销罐区"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'yxgq
        '
        Me.yxgq.AutoSize = True
        Me.yxgq.Location = New System.Drawing.Point(12, 103)
        Me.yxgq.Name = "yxgq"
        Me.yxgq.Size = New System.Drawing.Size(181, 17)
        Me.yxgq.TabIndex = 304
        Me.yxgq.TabStop = True
        Me.yxgq.Text = "按指定时间内对罐区盘点打印"
        Me.yxgq.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(805, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 18)
        Me.Label6.TabIndex = 303
        Me.Label6.Text = "小包装仓库"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'xbzck
        '
        Me.xbzck.AutoSize = True
        Me.xbzck.Location = New System.Drawing.Point(806, 39)
        Me.xbzck.Name = "xbzck"
        Me.xbzck.Size = New System.Drawing.Size(157, 17)
        Me.xbzck.TabIndex = 302
        Me.xbzck.TabStop = True
        Me.xbzck.Text = "按货物种类打印明细小计"
        Me.xbzck.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(592, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 18)
        Me.Label7.TabIndex = 301
        Me.Label7.Text = "工厂库豆粕"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gckdp
        '
        Me.gckdp.AutoSize = True
        Me.gckdp.Location = New System.Drawing.Point(593, 39)
        Me.gckdp.Name = "gckdp"
        Me.gckdp.Size = New System.Drawing.Size(205, 17)
        Me.gckdp.TabIndex = 300
        Me.gckdp.TabStop = True
        Me.gckdp.Text = "对指定时间内工厂库豆粕盘点打印"
        Me.gckdp.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(401, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 18)
        Me.Label5.TabIndex = 295
        Me.Label5.Text = "大豆筒仓"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ddtc
        '
        Me.ddtc.AutoSize = True
        Me.ddtc.Location = New System.Drawing.Point(402, 39)
        Me.ddtc.Name = "ddtc"
        Me.ddtc.Size = New System.Drawing.Size(193, 17)
        Me.ddtc.TabIndex = 294
        Me.ddtc.TabStop = True
        Me.ddtc.Text = "按指定时间内大豆筒仓盘点打印"
        Me.ddtc.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(196, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 18)
        Me.Label4.TabIndex = 292
        Me.Label4.Text = "散粕筒仓"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dptc
        '
        Me.dptc.AutoSize = True
        Me.dptc.Location = New System.Drawing.Point(197, 39)
        Me.dptc.Name = "dptc"
        Me.dptc.Size = New System.Drawing.Size(205, 17)
        Me.dptc.TabIndex = 291
        Me.dptc.TabStop = True
        Me.dptc.Text = "按指定时间内对散粕筒仓盘点打印"
        Me.dptc.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(11, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 290
        Me.Label2.Text = "粮油罐区"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gq
        '
        Me.gq.AutoSize = True
        Me.gq.Location = New System.Drawing.Point(12, 39)
        Me.gq.Name = "gq"
        Me.gq.Size = New System.Drawing.Size(181, 17)
        Me.gq.TabIndex = 289
        Me.gq.TabStop = True
        Me.gq.Text = "按指定时间内对罐区盘点打印"
        Me.gq.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(22, 323)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(1019, 219)
        Me.dgv.TabIndex = 302
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(22, 269)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(332, 48)
        Me.Button3.TabIndex = 301
        Me.Button3.Text = "查询"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(680, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(361, 48)
        Me.Button2.TabIndex = 300
        Me.Button2.Text = "退出"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(360, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(314, 48)
        Me.Button1.TabIndex = 299
        Me.Button1.Text = "打印"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'seldel
        '
        Me.seldel.AutoSize = True
        Me.seldel.Location = New System.Drawing.Point(435, 64)
        Me.seldel.Name = "seldel"
        Me.seldel.Size = New System.Drawing.Size(182, 17)
        Me.seldel.TabIndex = 303
        Me.seldel.Text = "打印包含删除标志的所有记录"
        Me.seldel.UseVisualStyleBackColor = True
        '
        'jilushu
        '
        Me.jilushu.AutoSize = True
        Me.jilushu.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jilushu.ForeColor = System.Drawing.Color.Blue
        Me.jilushu.Location = New System.Drawing.Point(866, 545)
        Me.jilushu.Name = "jilushu"
        Me.jilushu.Size = New System.Drawing.Size(53, 12)
        Me.jilushu.TabIndex = 304
        Me.jilushu.Text = "记录数："
        '
        'PrintSomething
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 572)
        Me.Controls.Add(Me.jilushu)
        Me.Controls.Add(Me.seldel)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dt12)
        Me.Controls.Add(Me.dt11)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PrintSomething"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "益海（连云港）盘点系统"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt12 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt11 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gckdp As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ddtc As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dptc As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gq As System.Windows.Forms.RadioButton
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents yxgq As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents xbzck As System.Windows.Forms.RadioButton
    Friend WithEvents flsj As System.Windows.Forms.Label
    Friend WithEvents flpd As System.Windows.Forms.RadioButton
    Friend WithEvents seldel As System.Windows.Forms.CheckBox
    Friend WithEvents jilushu As System.Windows.Forms.Label
    Friend WithEvents xbzck3 As System.Windows.Forms.RadioButton
    Friend WithEvents xbzck2 As System.Windows.Forms.RadioButton
End Class
