<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 港务局测试一卡通专用
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Color = New System.Windows.Forms.CheckBox()
        Me.dianhuahaoma = New System.Windows.Forms.TextBox()
        Me.chehao = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(12, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(496, 82)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "申报并放行车辆"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(4, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(92, 27)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "电话号码"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(44, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(52, 27)
        Me.Label2.TabIndex = 159
        Me.Label2.Text = "车号"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Color)
        Me.GroupBox1.Controls.Add(Me.dianhuahaoma)
        Me.GroupBox1.Controls.Add(Me.chehao)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 147)
        Me.GroupBox1.TabIndex = 163
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "车辆信息框"
        '
        'Color
        '
        Me.Color.AutoSize = True
        Me.Color.ForeColor = System.Drawing.Color.Red
        Me.Color.Location = New System.Drawing.Point(324, 40)
        Me.Color.Name = "Color"
        Me.Color.Size = New System.Drawing.Size(156, 16)
        Me.Color.TabIndex = 163
        Me.Color.Text = "蓝牌（不选默认为黄牌）"
        Me.Color.UseVisualStyleBackColor = True
        '
        'dianhuahaoma
        '
        Me.dianhuahaoma.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dianhuahaoma.Location = New System.Drawing.Point(102, 84)
        Me.dianhuahaoma.Name = "dianhuahaoma"
        Me.dianhuahaoma.ReadOnly = True
        Me.dianhuahaoma.Size = New System.Drawing.Size(217, 46)
        Me.dianhuahaoma.TabIndex = 162
        '
        'chehao
        '
        Me.chehao.BackColor = System.Drawing.Color.Yellow
        Me.chehao.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chehao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chehao.Location = New System.Drawing.Point(102, 22)
        Me.chehao.Name = "chehao"
        Me.chehao.ReadOnly = True
        Me.chehao.Size = New System.Drawing.Size(217, 46)
        Me.chehao.TabIndex = 161
        '
        '港务局测试一卡通专用
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(520, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "港务局测试一卡通专用"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "港务局一卡通系统申报"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dianhuahaoma As System.Windows.Forms.TextBox
    Friend WithEvents chehao As System.Windows.Forms.TextBox
    Friend WithEvents Color As System.Windows.Forms.CheckBox
End Class
