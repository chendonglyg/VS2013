<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIQ_Receipt
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.idid = New System.Windows.Forms.Label()
        Me.caozuoren = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.jichuxinxi = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.保存记录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出界面ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.hetonghao = New System.Windows.Forms.TextBox()
        Me.tidanshuliang = New System.Windows.Forms.TextBox()
        Me.baoguandanhao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.kuwei = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.FORSQL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HTHT = New System.Windows.Forms.Label()
        Me.BGBG = New System.Windows.Forms.Label()
        Me.jichuxinxi.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'idid
        '
        Me.idid.AutoSize = True
        Me.idid.Location = New System.Drawing.Point(12, 15)
        Me.idid.Name = "idid"
        Me.idid.Size = New System.Drawing.Size(17, 12)
        Me.idid.TabIndex = 181
        Me.idid.Text = "ID"
        '
        'caozuoren
        '
        Me.caozuoren.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.caozuoren.ForeColor = System.Drawing.Color.DarkRed
        Me.caozuoren.FormattingEnabled = True
        Me.caozuoren.Items.AddRange(New Object() {"顾红艳"})
        Me.caozuoren.Location = New System.Drawing.Point(78, 102)
        Me.caozuoren.Name = "caozuoren"
        Me.caozuoren.Size = New System.Drawing.Size(175, 29)
        Me.caozuoren.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.DarkRed
        Me.Label14.Location = New System.Drawing.Point(18, 110)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 21)
        Me.Label14.TabIndex = 207
        Me.Label14.Text = "操作人"
        '
        'jichuxinxi
        '
        Me.jichuxinxi.ContextMenuStrip = Me.ContextMenuStrip1
        Me.jichuxinxi.Controls.Add(Me.hetonghao)
        Me.jichuxinxi.Controls.Add(Me.caozuoren)
        Me.jichuxinxi.Controls.Add(Me.Label14)
        Me.jichuxinxi.Controls.Add(Me.tidanshuliang)
        Me.jichuxinxi.Controls.Add(Me.baoguandanhao)
        Me.jichuxinxi.Controls.Add(Me.Label1)
        Me.jichuxinxi.Controls.Add(Me.Label17)
        Me.jichuxinxi.Controls.Add(Me.Label24)
        Me.jichuxinxi.Controls.Add(Me.kuwei)
        Me.jichuxinxi.Controls.Add(Me.Label3)
        Me.jichuxinxi.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jichuxinxi.Location = New System.Drawing.Point(14, 289)
        Me.jichuxinxi.Name = "jichuxinxi"
        Me.jichuxinxi.Size = New System.Drawing.Size(302, 254)
        Me.jichuxinxi.TabIndex = 178
        Me.jichuxinxi.TabStop = False
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
        Me.保存记录ToolStripMenuItem.Text = "保存记录"
        '
        '退出界面ToolStripMenuItem
        '
        Me.退出界面ToolStripMenuItem.Name = "退出界面ToolStripMenuItem"
        Me.退出界面ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.退出界面ToolStripMenuItem.Text = "退出界面"
        '
        'hetonghao
        '
        Me.hetonghao.BackColor = System.Drawing.Color.White
        Me.hetonghao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hetonghao.Enabled = False
        Me.hetonghao.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.hetonghao.ForeColor = System.Drawing.Color.DarkRed
        Me.hetonghao.Location = New System.Drawing.Point(78, 35)
        Me.hetonghao.Name = "hetonghao"
        Me.hetonghao.Size = New System.Drawing.Size(175, 29)
        Me.hetonghao.TabIndex = 208
        '
        'tidanshuliang
        '
        Me.tidanshuliang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tidanshuliang.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tidanshuliang.ForeColor = System.Drawing.Color.Blue
        Me.tidanshuliang.Location = New System.Drawing.Point(78, 154)
        Me.tidanshuliang.Name = "tidanshuliang"
        Me.tidanshuliang.Size = New System.Drawing.Size(78, 29)
        Me.tidanshuliang.TabIndex = 11
        '
        'baoguandanhao
        '
        Me.baoguandanhao.BackColor = System.Drawing.Color.White
        Me.baoguandanhao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.baoguandanhao.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.baoguandanhao.ForeColor = System.Drawing.Color.DarkRed
        Me.baoguandanhao.Location = New System.Drawing.Point(78, 68)
        Me.baoguandanhao.Name = "baoguandanhao"
        Me.baoguandanhao.Size = New System.Drawing.Size(175, 29)
        Me.baoguandanhao.TabIndex = 175
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(4, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 21)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "提单数量"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkRed
        Me.Label17.Location = New System.Drawing.Point(5, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 21)
        Me.Label17.TabIndex = 177
        Me.Label17.Text = "报关单号"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.DarkRed
        Me.Label24.Location = New System.Drawing.Point(18, 38)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 21)
        Me.Label24.TabIndex = 115
        Me.Label24.Text = "合同号"
        '
        'kuwei
        '
        Me.kuwei.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.kuwei.ForeColor = System.Drawing.Color.Blue
        Me.kuwei.FormattingEnabled = True
        Me.kuwei.Items.AddRange(New Object() {"船库"})
        Me.kuwei.Location = New System.Drawing.Point(78, 187)
        Me.kuwei.Name = "kuwei"
        Me.kuwei.Size = New System.Drawing.Size(175, 29)
        Me.kuwei.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(0, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 21)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "库位/船库"
        '
        'dgv2
        '
        Me.dgv2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.ContextMenuStrip = Me.ContextMenuStrip2
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv2.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv2.Location = New System.Drawing.Point(17, 21)
        Me.dgv2.Name = "dgv2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv2.RowHeadersVisible = False
        Me.dgv2.RowTemplate.Height = 23
        Me.dgv2.Size = New System.Drawing.Size(882, 233)
        Me.dgv2.TabIndex = 144
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(149, 26)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.Red
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem3.Text = "删除报关单号"
        '
        'GroupBox2
        '
        Me.GroupBox2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox2.Controls.Add(Me.dgv2)
        Me.GroupBox2.Location = New System.Drawing.Point(331, 289)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(920, 265)
        Me.GroupBox2.TabIndex = 179
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Receipt"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(548, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 41)
        Me.Label4.TabIndex = 176
        Me.Label4.Text = "收货入船库"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(31, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1220, 10)
        Me.GroupBox1.TabIndex = 182
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = ">>"
        '
        'GroupBox3
        '
        Me.GroupBox3.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox3.Controls.Add(Me.dgv)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 99)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1237, 184)
        Me.GroupBox3.TabIndex = 180
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Purchase"
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv.Location = New System.Drawing.Point(12, 21)
        Me.dgv.Name = "dgv"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.Size = New System.Drawing.Size(1204, 147)
        Me.dgv.TabIndex = 144
        '
        'FORSQL
        '
        Me.FORSQL.BackColor = System.Drawing.Color.Red
        Me.FORSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FORSQL.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FORSQL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FORSQL.Location = New System.Drawing.Point(170, 75)
        Me.FORSQL.Name = "FORSQL"
        Me.FORSQL.Size = New System.Drawing.Size(157, 29)
        Me.FORSQL.TabIndex = 209
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(86, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 21)
        Me.Label2.TabIndex = 210
        Me.Label2.Text = "检索合同号"
        '
        'HTHT
        '
        Me.HTHT.AutoSize = True
        Me.HTHT.Location = New System.Drawing.Point(12, 3)
        Me.HTHT.Name = "HTHT"
        Me.HTHT.Size = New System.Drawing.Size(17, 12)
        Me.HTHT.TabIndex = 211
        Me.HTHT.Text = "HT"
        '
        'BGBG
        '
        Me.BGBG.AutoSize = True
        Me.BGBG.Location = New System.Drawing.Point(12, 27)
        Me.BGBG.Name = "BGBG"
        Me.BGBG.Size = New System.Drawing.Size(17, 12)
        Me.BGBG.TabIndex = 212
        Me.BGBG.Text = "BG"
        '
        'CIQ_Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.BGBG)
        Me.Controls.Add(Me.HTHT)
        Me.Controls.Add(Me.FORSQL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.idid)
        Me.Controls.Add(Me.jichuxinxi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CIQ_Receipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2.收货入船库"
        Me.jichuxinxi.ResumeLayout(False)
        Me.jichuxinxi.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents idid As System.Windows.Forms.Label
    Friend WithEvents caozuoren As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents jichuxinxi As System.Windows.Forms.GroupBox
    Friend WithEvents tidanshuliang As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents kuwei As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents baoguandanhao As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 保存记录ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出界面ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents hetonghao As System.Windows.Forms.TextBox
    Friend WithEvents FORSQL As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HTHT As System.Windows.Forms.Label
    Friend WithEvents BGBG As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
End Class
