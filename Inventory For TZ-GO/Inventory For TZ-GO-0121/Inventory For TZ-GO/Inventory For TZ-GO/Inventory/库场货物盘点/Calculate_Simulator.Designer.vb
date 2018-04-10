<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculate_Simulator
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
        Me.wlbm = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.jpry = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pdry = New System.Windows.Forms.TextBox()
        Me.pdsj = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.bzxx = New System.Windows.Forms.TextBox()
        Me.ygbh = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ssgq = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.yp = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.QW = New System.Windows.Forms.TextBox()
        Me.YW = New System.Windows.Forms.TextBox()
        Me.QME = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bhxstxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bzwdtxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bzmdtxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'wlbm
        '
        Me.wlbm.Enabled = False
        Me.wlbm.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.wlbm.FormattingEnabled = True
        Me.wlbm.Location = New System.Drawing.Point(127, 144)
        Me.wlbm.Name = "wlbm"
        Me.wlbm.Size = New System.Drawing.Size(287, 29)
        Me.wlbm.TabIndex = 38
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(15, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 49)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "清空"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 231)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 17)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "监盘人员"
        '
        'jpry
        '
        Me.jpry.Enabled = False
        Me.jpry.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jpry.Location = New System.Drawing.Point(62, 229)
        Me.jpry.Name = "jpry"
        Me.jpry.Size = New System.Drawing.Size(98, 18)
        Me.jpry.TabIndex = 39
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 46)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "提交"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 17)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "盘点人员"
        '
        'pdry
        '
        Me.pdry.Enabled = False
        Me.pdry.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdry.Location = New System.Drawing.Point(62, 205)
        Me.pdry.Name = "pdry"
        Me.pdry.Size = New System.Drawing.Size(98, 18)
        Me.pdry.TabIndex = 37
        '
        'pdsj
        '
        Me.pdsj.Enabled = False
        Me.pdsj.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdsj.Location = New System.Drawing.Point(62, 183)
        Me.pdsj.Name = "pdsj"
        Me.pdsj.Size = New System.Drawing.Size(98, 18)
        Me.pdsj.TabIndex = 35
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 191)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 21)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "备注信息"
        '
        'bzxx
        '
        Me.bzxx.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.bzxx.Location = New System.Drawing.Point(17, 212)
        Me.bzxx.Name = "bzxx"
        Me.bzxx.Size = New System.Drawing.Size(397, 31)
        Me.bzxx.TabIndex = 35
        '
        'ygbh
        '
        Me.ygbh.Font = New System.Drawing.Font("幼圆", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ygbh.FormattingEnabled = True
        Me.ygbh.Location = New System.Drawing.Point(127, 61)
        Me.ygbh.Name = "ygbh"
        Me.ygbh.Size = New System.Drawing.Size(287, 41)
        Me.ygbh.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 183)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 17)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "盘点时间"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.Location = New System.Drawing.Point(13, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 21)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "物料编码"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 21)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "油罐编号"
        '
        'ssgq
        '
        Me.ssgq.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ssgq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ssgq.Enabled = False
        Me.ssgq.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ssgq.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ssgq.ForeColor = System.Drawing.Color.Red
        Me.ssgq.FormattingEnabled = True
        Me.ssgq.Items.AddRange(New Object() {"粮油罐区", "油化罐区", "沙索罐区", "板桥罐区", "营销罐区"})
        Me.ssgq.Location = New System.Drawing.Point(127, 17)
        Me.ssgq.Name = "ssgq"
        Me.ssgq.Size = New System.Drawing.Size(287, 39)
        Me.ssgq.TabIndex = 32
        Me.ssgq.Text = "泰州粮油罐区"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 21)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "所属罐区"
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
        Me.GroupBox3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(285, 309)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(166, 257)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "控制区"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.Location = New System.Drawing.Point(15, 127)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 46)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "退出"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.wlbm)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.yp)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.bzxx)
        Me.GroupBox2.Controls.Add(Me.ygbh)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ssgq)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 269)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "基础信息区"
        '
        'yp
        '
        Me.yp.Enabled = False
        Me.yp.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yp.FormattingEnabled = True
        Me.yp.Location = New System.Drawing.Point(127, 107)
        Me.yp.Name = "yp"
        Me.yp.Size = New System.Drawing.Size(287, 29)
        Me.yp.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(59, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 21)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "油品"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.QW)
        Me.GroupBox1.Controls.Add(Me.YW)
        Me.GroupBox1.Controls.Add(Me.QME)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.bhxstxt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.bzwdtxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.bzmdtxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.gd)
        Me.GroupBox1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 309)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 257)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "计算参数区"
        '
        'QW
        '
        Me.QW.Enabled = False
        Me.QW.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.QW.Location = New System.Drawing.Point(169, 86)
        Me.QW.Name = "QW"
        Me.QW.Size = New System.Drawing.Size(53, 29)
        Me.QW.TabIndex = 46
        '
        'YW
        '
        Me.YW.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.YW.Location = New System.Drawing.Point(67, 86)
        Me.YW.Name = "YW"
        Me.YW.Size = New System.Drawing.Size(53, 29)
        Me.YW.TabIndex = 45
        '
        'QME
        '
        Me.QME.AutoSize = True
        Me.QME.Location = New System.Drawing.Point(228, 96)
        Me.QME.Name = "QME"
        Me.QME.Size = New System.Drawing.Size(15, 14)
        Me.QME.TabIndex = 44
        Me.QME.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 21)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "变化系数"
        '
        'bhxstxt
        '
        Me.bhxstxt.Enabled = False
        Me.bhxstxt.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.bhxstxt.Location = New System.Drawing.Point(121, 213)
        Me.bhxstxt.Name = "bhxstxt"
        Me.bhxstxt.Size = New System.Drawing.Size(141, 31)
        Me.bhxstxt.TabIndex = 25
        Me.bhxstxt.Text = "0.00064"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 21)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "标准温度"
        '
        'bzwdtxt
        '
        Me.bzwdtxt.Enabled = False
        Me.bzwdtxt.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.bzwdtxt.Location = New System.Drawing.Point(121, 177)
        Me.bzwdtxt.Name = "bzwdtxt"
        Me.bzwdtxt.Size = New System.Drawing.Size(141, 31)
        Me.bzwdtxt.TabIndex = 23
        Me.bzwdtxt.Text = "20"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 21)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "标准密度"
        '
        'bzmdtxt
        '
        Me.bzmdtxt.Enabled = False
        Me.bzmdtxt.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.bzmdtxt.Location = New System.Drawing.Point(121, 141)
        Me.bzmdtxt.Name = "bzmdtxt"
        Me.bzmdtxt.Size = New System.Drawing.Size(141, 31)
        Me.bzmdtxt.TabIndex = 21
        Me.bzmdtxt.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 21)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "气温"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "油温"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "高度"
        '
        'gd
        '
        Me.gd.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.gd.Location = New System.Drawing.Point(67, 36)
        Me.gd.Name = "gd"
        Me.gd.Size = New System.Drawing.Size(126, 29)
        Me.gd.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(127, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(230, 28)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "SimulatorForCaculate"
        '
        'Calculate_Simulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 573)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Name = "Calculate_Simulator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents wlbm As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents jpry As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents pdry As System.Windows.Forms.TextBox
    Friend WithEvents pdsj As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents bzxx As System.Windows.Forms.TextBox
    Friend WithEvents ygbh As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ssgq As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents yp As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents QW As System.Windows.Forms.TextBox
    Friend WithEvents YW As System.Windows.Forms.TextBox
    Friend WithEvents QME As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bhxstxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bzwdtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bzmdtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gd As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
