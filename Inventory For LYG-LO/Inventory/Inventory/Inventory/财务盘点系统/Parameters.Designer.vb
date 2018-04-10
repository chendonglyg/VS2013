<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Para
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.DD = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.保存大豆筒仓修改ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KC = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgv_kc = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv_kcwl = New System.Windows.Forms.DataGridView()
        Me.kcwl = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DD.SuspendLayout()
        Me.KC.SuspendLayout()
        CType(Me.dgv_kc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_kcwl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kcwl.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.ContextMenuStrip = Me.DD
        Me.dgv.Location = New System.Drawing.Point(60, 104)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.Size = New System.Drawing.Size(300, 349)
        Me.dgv.TabIndex = 267
        '
        'DD
        '
        Me.DD.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.保存大豆筒仓修改ToolStripMenuItem})
        Me.DD.Name = "ContextMenuStrip1"
        Me.DD.Size = New System.Drawing.Size(171, 26)
        Me.DD.Text = "大豆筒仓保存"
        '
        '保存大豆筒仓修改ToolStripMenuItem
        '
        Me.保存大豆筒仓修改ToolStripMenuItem.Image = Global.Inventory.My.Resources.Resources.Hein28
        Me.保存大豆筒仓修改ToolStripMenuItem.Name = "保存大豆筒仓修改ToolStripMenuItem"
        Me.保存大豆筒仓修改ToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.保存大豆筒仓修改ToolStripMenuItem.Text = "保存大豆筒仓修改"
        '
        'KC
        '
        Me.KC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.KC.Name = "ContextMenuStrip1"
        Me.KC.Size = New System.Drawing.Size(171, 26)
        Me.KC.Text = "大豆筒仓保存"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Inventory.My.Resources.Resources.Hein28
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem1.Text = "保存库场规格修改"
        '
        'dgv_kc
        '
        Me.dgv_kc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kc.ContextMenuStrip = Me.KC
        Me.dgv_kc.Location = New System.Drawing.Point(427, 106)
        Me.dgv_kc.Name = "dgv_kc"
        Me.dgv_kc.RowTemplate.Height = 23
        Me.dgv_kc.Size = New System.Drawing.Size(335, 349)
        Me.dgv_kc.TabIndex = 269
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(104, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 12)
        Me.Label1.TabIndex = 270
        Me.Label1.Text = "大豆筒仓参数维护"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(538, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 12)
        Me.Label2.TabIndex = 271
        Me.Label2.Text = "库场规格参数维护"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(525, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 37)
        Me.Label3.TabIndex = 272
        Me.Label3.Text = "参数维护界面"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(832, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 12)
        Me.Label4.TabIndex = 274
        Me.Label4.Text = "库场物料参数维护"
        '
        'dgv_kcwl
        '
        Me.dgv_kcwl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kcwl.ContextMenuStrip = Me.kcwl
        Me.dgv_kcwl.Location = New System.Drawing.Point(833, 106)
        Me.dgv_kcwl.Name = "dgv_kcwl"
        Me.dgv_kcwl.RowTemplate.Height = 23
        Me.dgv_kcwl.Size = New System.Drawing.Size(415, 349)
        Me.dgv_kcwl.TabIndex = 273
        '
        'kcwl
        '
        Me.kcwl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.kcwl.Name = "ContextMenuStrip1"
        Me.kcwl.Size = New System.Drawing.Size(195, 26)
        Me.kcwl.Text = "大豆筒仓保存"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.Inventory.My.Resources.Resources.Hein28
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(194, 22)
        Me.ToolStripMenuItem2.Text = "保存库场物料参数修改"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(938, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(89, 18)
        Me.TextBox1.TabIndex = 275
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(1027, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 12)
        Me.Label5.TabIndex = 276
        Me.Label5.Text = "（重新查找前请先保存)"
        '
        'Para
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1274, 474)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgv_kcwl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_kc)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Para"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "益海（连云港）盘点系统"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DD.ResumeLayout(False)
        Me.KC.ResumeLayout(False)
        CType(Me.dgv_kc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_kcwl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kcwl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents DD As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 保存大豆筒仓修改ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KC As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgv_kc As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgv_kcwl As System.Windows.Forms.DataGridView
    Friend WithEvents kcwl As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
