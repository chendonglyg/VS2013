<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bill3
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bill3))
        Me.axHWPostil1 = New AxHWPOSTILLib.AxHWPostil()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.opd = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.spd = New System.Windows.Forms.SaveFileDialog()
        Me.Pathname = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'axHWPostil1
        '
        Me.axHWPostil1.Enabled = True
        Me.axHWPostil1.Location = New System.Drawing.Point(11, 68)
        Me.axHWPostil1.Name = "axHWPostil1"
        Me.axHWPostil1.OcxState = CType(resources.GetObject("axHWPostil1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axHWPostil1.Size = New System.Drawing.Size(1240, 481)
        Me.axHWPostil1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(220, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 41)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Sign"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(384, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 41)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "SaveToLocalDisk"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'opd
        '
        Me.opd.FileName = "OpenFileDialog1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(22, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 40)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Download"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Pathname
        '
        Me.Pathname.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Pathname.Location = New System.Drawing.Point(571, 24)
        Me.Pathname.Name = "Pathname"
        Me.Pathname.Size = New System.Drawing.Size(529, 29)
        Me.Pathname.TabIndex = 5
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1106, 20)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(153, 40)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "GO"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TEMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Pathname)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.axHWPostil1)
        Me.Name = "TEMP"
        Me.Text = "Maintenance_GS"
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents axHWPostil1 As AxHWPOSTILLib.AxHWPostil
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents opd As OpenFileDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents spd As SaveFileDialog
    Friend WithEvents Pathname As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
