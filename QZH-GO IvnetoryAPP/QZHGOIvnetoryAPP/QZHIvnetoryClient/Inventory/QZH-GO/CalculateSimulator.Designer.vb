<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculateSimulator
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.guanhao_tb = New System.Windows.Forms.ComboBox()
        Me.midu_tb = New System.Windows.Forms.TextBox()
        Me.youwen_tb = New System.Windows.Forms.TextBox()
        Me.yougao_tb = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.guanhao_tb_qz = New System.Windows.Forms.ComboBox()
        Me.midu_tb_qz = New System.Windows.Forms.TextBox()
        Me.youwen_tb_qz = New System.Windows.Forms.TextBox()
        Me.yougao_tb_qz = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(258, 65)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CALCULATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 21)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "油高"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 21)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "罐号"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 21)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "密度"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 21)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "油温"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.guanhao_tb)
        Me.GroupBox1.Controls.Add(Me.midu_tb)
        Me.GroupBox1.Controls.Add(Me.youwen_tb)
        Me.GroupBox1.Controls.Add(Me.yougao_tb)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 341)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "厦门中鹭罐区"
        '
        'guanhao_tb
        '
        Me.guanhao_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.guanhao_tb.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.guanhao_tb.FormattingEnabled = True
        Me.guanhao_tb.Items.AddRange(New Object() {"-----保温罐-----", "T058", "T059", "T103", "T104", "T105", "T106", "T107", "T203", "T204", "T205", "-----非保温罐-----", "R08", "R09", "T051", "T052", "T101", "T102", "T201", "T202", "T301", "T302", "T303"})
        Me.guanhao_tb.Location = New System.Drawing.Point(94, 47)
        Me.guanhao_tb.Name = "guanhao_tb"
        Me.guanhao_tb.Size = New System.Drawing.Size(160, 29)
        Me.guanhao_tb.TabIndex = 48
        '
        'midu_tb
        '
        Me.midu_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.midu_tb.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.midu_tb.Location = New System.Drawing.Point(94, 158)
        Me.midu_tb.Name = "midu_tb"
        Me.midu_tb.Size = New System.Drawing.Size(160, 33)
        Me.midu_tb.TabIndex = 47
        '
        'youwen_tb
        '
        Me.youwen_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.youwen_tb.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.youwen_tb.Location = New System.Drawing.Point(94, 120)
        Me.youwen_tb.Name = "youwen_tb"
        Me.youwen_tb.Size = New System.Drawing.Size(160, 33)
        Me.youwen_tb.TabIndex = 46
        '
        'yougao_tb
        '
        Me.yougao_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yougao_tb.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yougao_tb.Location = New System.Drawing.Point(94, 82)
        Me.yougao_tb.Name = "yougao_tb"
        Me.yougao_tb.Size = New System.Drawing.Size(160, 33)
        Me.yougao_tb.TabIndex = 45
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.guanhao_tb_qz)
        Me.GroupBox2.Controls.Add(Me.midu_tb_qz)
        Me.GroupBox2.Controls.Add(Me.youwen_tb_qz)
        Me.GroupBox2.Controls.Add(Me.yougao_tb_qz)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(431, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 341)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "泉州福海罐区"
        '
        'guanhao_tb_qz
        '
        Me.guanhao_tb_qz.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.guanhao_tb_qz.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.guanhao_tb_qz.FormattingEnabled = True
        Me.guanhao_tb_qz.Items.AddRange(New Object() {"-----保温罐-----", "T011", "T012", "T015", "T016", "T023", "T053", "T054", "T055", "T056", "T057", "T108", "-----非保温罐-----", "T052", "T013", "T014", "T021", "T022", "T051", "T102"})
        Me.guanhao_tb_qz.Location = New System.Drawing.Point(94, 46)
        Me.guanhao_tb_qz.Name = "guanhao_tb_qz"
        Me.guanhao_tb_qz.Size = New System.Drawing.Size(160, 29)
        Me.guanhao_tb_qz.TabIndex = 48
        '
        'midu_tb_qz
        '
        Me.midu_tb_qz.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.midu_tb_qz.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.midu_tb_qz.Location = New System.Drawing.Point(94, 158)
        Me.midu_tb_qz.Name = "midu_tb_qz"
        Me.midu_tb_qz.Size = New System.Drawing.Size(160, 33)
        Me.midu_tb_qz.TabIndex = 47
        '
        'youwen_tb_qz
        '
        Me.youwen_tb_qz.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.youwen_tb_qz.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.youwen_tb_qz.Location = New System.Drawing.Point(94, 120)
        Me.youwen_tb_qz.Name = "youwen_tb_qz"
        Me.youwen_tb_qz.Size = New System.Drawing.Size(160, 33)
        Me.youwen_tb_qz.TabIndex = 46
        '
        'yougao_tb_qz
        '
        Me.yougao_tb_qz.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.yougao_tb_qz.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yougao_tb_qz.Location = New System.Drawing.Point(94, 82)
        Me.yougao_tb_qz.Name = "yougao_tb_qz"
        Me.yougao_tb_qz.Size = New System.Drawing.Size(160, 33)
        Me.yougao_tb_qz.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 21)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "密度"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(34, 250)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(258, 65)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "CALCULATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 21)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "罐号"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 21)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "油温"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 21)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "油高"
        '
        'CalculateSimulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 388)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CalculateSimulator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "本地计量模拟器"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents midu_tb As System.Windows.Forms.TextBox
    Friend WithEvents youwen_tb As System.Windows.Forms.TextBox
    Friend WithEvents yougao_tb As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents midu_tb_qz As System.Windows.Forms.TextBox
    Friend WithEvents youwen_tb_qz As System.Windows.Forms.TextBox
    Friend WithEvents yougao_tb_qz As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents guanhao_tb As System.Windows.Forms.ComboBox
    Friend WithEvents guanhao_tb_qz As System.Windows.Forms.ComboBox
End Class
