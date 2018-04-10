<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bill4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bill4))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.axHWPostil1 = New AxHWPOSTILLib.AxHWPostil()
        Me.opd = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.spd = New System.Windows.Forms.SaveFileDialog()
        Me.Pathname = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.保存ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(101, 26)
        '
        '保存ToolStripMenuItem
        '
        Me.保存ToolStripMenuItem.Image = Global.OA.My.Resources.Resources.Osx23
        Me.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem"
        Me.保存ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.保存ToolStripMenuItem.Text = "保存"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(445, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 41)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "SaveToLocalDisk"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(281, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 41)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Sign"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'axHWPostil1
        '
        Me.axHWPostil1.Enabled = True
        Me.axHWPostil1.Location = New System.Drawing.Point(4, 58)
        Me.axHWPostil1.Name = "axHWPostil1"
        Me.axHWPostil1.OcxState = CType(resources.GetObject("axHWPostil1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axHWPostil1.Size = New System.Drawing.Size(1390, 481)
        Me.axHWPostil1.TabIndex = 5
        '
        'opd
        '
        Me.opd.FileName = "OpenFileDialog1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(83, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 40)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Download"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Pathname
        '
        Me.Pathname.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Pathname.Location = New System.Drawing.Point(606, 16)
        Me.Pathname.Name = "Pathname"
        Me.Pathname.Size = New System.Drawing.Size(529, 29)
        Me.Pathname.TabIndex = 9
        '
        'TEMP1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1384, 561)
        Me.Controls.Add(Me.Pathname)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.axHWPostil1)
        Me.Controls.Add(Me.Button3)
        Me.Name = "TEMP1"
        Me.Text = "LOADTEMPPDF"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 保存ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents axHWPostil1 As AxHWPOSTILLib.AxHWPostil
    Friend WithEvents opd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents spd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Pathname As System.Windows.Forms.TextBox
End Class
