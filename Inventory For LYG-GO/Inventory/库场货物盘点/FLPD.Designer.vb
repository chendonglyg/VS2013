<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLPD
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
        Me.tsk = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.jpry = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pdry = New System.Windows.Forms.TextBox()
        Me.pdsj = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CX = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pz = New System.Windows.Forms.TextBox()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.bz = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.wlbm = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.kc = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gc = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gg = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsk
        '
        Me.tsk.Font = New System.Drawing.Font("幼圆", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tsk.FormattingEnabled = True
        Me.tsk.Items.AddRange(New Object() {"LG"})
        Me.tsk.Location = New System.Drawing.Point(105, 114)
        Me.tsk.Name = "tsk"
        Me.tsk.Size = New System.Drawing.Size(119, 41)
        Me.tsk.TabIndex = 32
        Me.tsk.Text = "LG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 21)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "公司代码"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.jpry)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.pdry)
        Me.GroupBox3.Controls.Add(Me.pdsj)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(244, 282)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(219, 234)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "控制区"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("幼圆", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(15, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 50)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "清空"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "监盘人员"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("幼圆", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.Location = New System.Drawing.Point(15, 116)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 47)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "退出"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'jpry
        '
        Me.jpry.Enabled = False
        Me.jpry.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jpry.Location = New System.Drawing.Point(62, 211)
        Me.jpry.Name = "jpry"
        Me.jpry.Size = New System.Drawing.Size(98, 18)
        Me.jpry.TabIndex = 39
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("幼圆", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 47)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "提交"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "盘点人员"
        '
        'pdry
        '
        Me.pdry.Enabled = False
        Me.pdry.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdry.Location = New System.Drawing.Point(62, 189)
        Me.pdry.Name = "pdry"
        Me.pdry.Size = New System.Drawing.Size(98, 18)
        Me.pdry.TabIndex = 37
        '
        'pdsj
        '
        Me.pdsj.Enabled = False
        Me.pdsj.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdsj.Location = New System.Drawing.Point(62, 169)
        Me.pdsj.Name = "pdsj"
        Me.pdsj.Size = New System.Drawing.Size(98, 18)
        Me.pdsj.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "盘点时间"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CX)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.pz)
        Me.GroupBox2.Controls.Add(Me.ListBox)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.bz)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.wlbm)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.kc)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(455, 238)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "基础信息区"
        '
        'CX
        '
        Me.CX.AutoSize = True
        Me.CX.ForeColor = System.Drawing.Color.Red
        Me.CX.Location = New System.Drawing.Point(284, 15)
        Me.CX.Name = "CX"
        Me.CX.Size = New System.Drawing.Size(96, 15)
        Me.CX.TabIndex = 58
        Me.CX.Text = "物料模糊查询"
        Me.CX.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(283, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 35)
        Me.TextBox1.TabIndex = 57
        '
        'pz
        '
        Me.pz.Enabled = False
        Me.pz.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pz.Location = New System.Drawing.Point(101, 106)
        Me.pz.Name = "pz"
        Me.pz.Size = New System.Drawing.Size(176, 31)
        Me.pz.TabIndex = 56
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.ItemHeight = 12
        Me.ListBox.Location = New System.Drawing.Point(283, 69)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(169, 100)
        Me.ListBox.TabIndex = 41
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 186)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(217, 21)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "实盘数量和备注信息"
        '
        'bz
        '
        Me.bz.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.bz.Location = New System.Drawing.Point(17, 207)
        Me.bz.Name = "bz"
        Me.bz.Size = New System.Drawing.Size(397, 31)
        Me.bz.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(1, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 21)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "物料描述"
        '
        'wlbm
        '
        Me.wlbm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.wlbm.Enabled = False
        Me.wlbm.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.wlbm.FormattingEnabled = True
        Me.wlbm.Location = New System.Drawing.Point(101, 142)
        Me.wlbm.Name = "wlbm"
        Me.wlbm.Size = New System.Drawing.Size(176, 27)
        Me.wlbm.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(1, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 21)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "物料编码"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.Location = New System.Drawing.Point(22, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 21)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "库存地"
        '
        'kc
        '
        Me.kc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kc.Font = New System.Drawing.Font("幼圆", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.kc.FormattingEnabled = True
        Me.kc.Items.AddRange(New Object() {"粕库"})
        Me.kc.Location = New System.Drawing.Point(101, 20)
        Me.kc.Name = "kc"
        Me.kc.Size = New System.Drawing.Size(176, 41)
        Me.kc.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 21)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "单位"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tsk)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.gg)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 282)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 234)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "计算参数区"
        '
        'gc
        '
        Me.gc.Font = New System.Drawing.Font("幼圆", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.gc.FormattingEnabled = True
        Me.gc.Items.AddRange(New Object() {"LG01"})
        Me.gc.Location = New System.Drawing.Point(105, 158)
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(119, 41)
        Me.gc.TabIndex = 34
        Me.gc.Text = "LG01"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 21)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "工厂"
        '
        'gg
        '
        Me.gg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gg.Font = New System.Drawing.Font("幼圆", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.gg.FormattingEnabled = True
        Me.gg.Items.AddRange(New Object() {"MT(吨）", "KG（千克）", "BAG(包）", "BOT（瓶）", "BOX（箱）", "DRM（桶）", "PC（件)"})
        Me.gg.Location = New System.Drawing.Point(73, 30)
        Me.gg.Name = "gg"
        Me.gg.Size = New System.Drawing.Size(151, 41)
        Me.gg.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("幼圆", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(175, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 24)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "辅料盘点"
        '
        'FLPD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 529)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Name = "FLPD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "益海（连云港）盘点系统"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsk As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents jpry As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents pdry As System.Windows.Forms.TextBox
    Friend WithEvents pdsj As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CX As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents pz As System.Windows.Forms.TextBox
    Friend WithEvents ListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents bz As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents wlbm As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents kc As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gg As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
