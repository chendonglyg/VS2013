<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mission_EDIT
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.save = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.save.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("幼圆", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(390, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 24)
        Me.Label3.TabIndex = 279
        Me.Label3.Text = "罐区盘点任务维护"
        '
        'Dgv
        '
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.ContextMenuStrip = Me.save
        Me.Dgv.Location = New System.Drawing.Point(50, 78)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.RowTemplate.Height = 23
        Me.Dgv.Size = New System.Drawing.Size(935, 469)
        Me.Dgv.TabIndex = 280
        '
        'save
        '
        Me.save.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.save.Name = "ContextMenuStrip1"
        Me.save.Size = New System.Drawing.Size(153, 48)
        Me.save.Text = "大豆筒仓保存"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.Inventory.My.Resources.Resources.bq_040
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem3.Text = "更新数据"
        '
        'Mission_EDIT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 583)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Mission_EDIT"
        Me.Text = "益海（广州）盘点系统"
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.save.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Dgv As System.Windows.Forms.DataGridView
    Friend WithEvents save As System.Windows.Forms.ContextMenuStrip
End Class
