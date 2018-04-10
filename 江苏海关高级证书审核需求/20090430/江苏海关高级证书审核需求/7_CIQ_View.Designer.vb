<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIQ_View
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.保存记录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出界面ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.jichuxinxi = New System.Windows.Forms.GroupBox()
        Me.hetonghao = New System.Windows.Forms.TextBox()
        Me.baoguandanhao = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.jichuxinxi.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(475, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 41)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "数据检索并打印"
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Location = New System.Drawing.Point(12, 205)
        Me.dgv.Name = "dgv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.Size = New System.Drawing.Size(1160, 344)
        Me.dgv.TabIndex = 145
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.保存记录ToolStripMenuItem, Me.退出界面ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 48)
        '
        '保存记录ToolStripMenuItem
        '
        Me.保存记录ToolStripMenuItem.Name = "保存记录ToolStripMenuItem"
        Me.保存记录ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.保存记录ToolStripMenuItem.Text = "打印数据"
        '
        '退出界面ToolStripMenuItem
        '
        Me.退出界面ToolStripMenuItem.Name = "退出界面ToolStripMenuItem"
        Me.退出界面ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.退出界面ToolStripMenuItem.Text = "退出界面"
        '
        'jichuxinxi
        '
        Me.jichuxinxi.Controls.Add(Me.hetonghao)
        Me.jichuxinxi.Controls.Add(Me.baoguandanhao)
        Me.jichuxinxi.Controls.Add(Me.Label17)
        Me.jichuxinxi.Controls.Add(Me.Label24)
        Me.jichuxinxi.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jichuxinxi.Location = New System.Drawing.Point(12, 73)
        Me.jichuxinxi.Name = "jichuxinxi"
        Me.jichuxinxi.Size = New System.Drawing.Size(385, 107)
        Me.jichuxinxi.TabIndex = 185
        Me.jichuxinxi.TabStop = False
        '
        'hetonghao
        '
        Me.hetonghao.BackColor = System.Drawing.Color.Red
        Me.hetonghao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hetonghao.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.hetonghao.ForeColor = System.Drawing.Color.DarkRed
        Me.hetonghao.Location = New System.Drawing.Point(128, 21)
        Me.hetonghao.Name = "hetonghao"
        Me.hetonghao.Size = New System.Drawing.Size(175, 29)
        Me.hetonghao.TabIndex = 226
        '
        'baoguandanhao
        '
        Me.baoguandanhao.BackColor = System.Drawing.Color.Red
        Me.baoguandanhao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.baoguandanhao.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.baoguandanhao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.baoguandanhao.Location = New System.Drawing.Point(128, 63)
        Me.baoguandanhao.Name = "baoguandanhao"
        Me.baoguandanhao.Size = New System.Drawing.Size(175, 29)
        Me.baoguandanhao.TabIndex = 175
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Enabled = False
        Me.Label17.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(16, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 21)
        Me.Label17.TabIndex = 177
        Me.Label17.Text = "原料报关单号"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Enabled = False
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(32, 25)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(90, 21)
        Me.Label24.TabIndex = 115
        Me.Label24.Text = "原料合同号"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Enabled = False
        Me.total.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.total.ForeColor = System.Drawing.Color.Red
        Me.total.Location = New System.Drawing.Point(12, 185)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(80, 17)
        Me.total.TabIndex = 227
        Me.total.Text = "原料报关单号"
        '
        'CIQ_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.jichuxinxi)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CIQ_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "7.数据检索并打印"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.jichuxinxi.ResumeLayout(False)
        Me.jichuxinxi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents jichuxinxi As System.Windows.Forms.GroupBox
    Friend WithEvents hetonghao As System.Windows.Forms.TextBox
    Friend WithEvents baoguandanhao As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 保存记录ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出界面ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents total As System.Windows.Forms.Label
End Class
