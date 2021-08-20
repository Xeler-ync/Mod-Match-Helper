<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.CheckedListBoxSelectMods = New System.Windows.Forms.CheckedListBox()
        Me.LabelModInfo = New System.Windows.Forms.Label()
        Me.ButtonTest1 = New System.Windows.Forms.Button()
        Me.ButtonMCBBS = New System.Windows.Forms.Button()
        Me.ButtonCurseForge = New System.Windows.Forms.Button()
        Me.ButtonReflashModInfo = New System.Windows.Forms.Button()
        Me.ButtonRemoveUselessDepend = New System.Windows.Forms.Button()
        Me.ButtonApplyAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckedListBoxSelectMods
        '
        Me.CheckedListBoxSelectMods.ColumnWidth = 2
        Me.CheckedListBoxSelectMods.FormattingEnabled = True
        Me.CheckedListBoxSelectMods.Location = New System.Drawing.Point(16, 15)
        Me.CheckedListBoxSelectMods.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckedListBoxSelectMods.Name = "CheckedListBoxSelectMods"
        Me.CheckedListBoxSelectMods.Size = New System.Drawing.Size(323, 404)
        Me.CheckedListBoxSelectMods.TabIndex = 0
        '
        'LabelModInfo
        '
        Me.LabelModInfo.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.LabelModInfo.Location = New System.Drawing.Point(348, 15)
        Me.LabelModInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelModInfo.Name = "LabelModInfo"
        Me.LabelModInfo.Size = New System.Drawing.Size(568, 405)
        Me.LabelModInfo.TabIndex = 2
        Me.LabelModInfo.Text = "Label1"
        '
        'ButtonTest1
        '
        Me.ButtonTest1.Location = New System.Drawing.Point(0, 1)
        Me.ButtonTest1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonTest1.Name = "ButtonTest1"
        Me.ButtonTest1.Size = New System.Drawing.Size(24, 24)
        Me.ButtonTest1.TabIndex = 3
        Me.ButtonTest1.Text = "Button1"
        Me.ButtonTest1.UseVisualStyleBackColor = True
        '
        'ButtonMCBBS
        '
        Me.ButtonMCBBS.Font = New System.Drawing.Font("宋体", 25.0!)
        Me.ButtonMCBBS.Location = New System.Drawing.Point(636, 428)
        Me.ButtonMCBBS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonMCBBS.Name = "ButtonMCBBS"
        Me.ButtonMCBBS.Size = New System.Drawing.Size(280, 55)
        Me.ButtonMCBBS.TabIndex = 4
        Me.ButtonMCBBS.Text = "MC百科"
        Me.ButtonMCBBS.UseVisualStyleBackColor = True
        '
        'ButtonCurseForge
        '
        Me.ButtonCurseForge.Font = New System.Drawing.Font("宋体", 25.0!)
        Me.ButtonCurseForge.Location = New System.Drawing.Point(348, 428)
        Me.ButtonCurseForge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonCurseForge.Name = "ButtonCurseForge"
        Me.ButtonCurseForge.Size = New System.Drawing.Size(280, 55)
        Me.ButtonCurseForge.TabIndex = 5
        Me.ButtonCurseForge.Text = "CurseForge"
        Me.ButtonCurseForge.UseVisualStyleBackColor = True
        '
        'ButtonReflashModInfo
        '
        Me.ButtonReflashModInfo.Location = New System.Drawing.Point(16, 428)
        Me.ButtonReflashModInfo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonReflashModInfo.Name = "ButtonReflashModInfo"
        Me.ButtonReflashModInfo.Size = New System.Drawing.Size(159, 54)
        Me.ButtonReflashModInfo.TabIndex = 6
        Me.ButtonReflashModInfo.Text = "刷新Mod信息"
        Me.ButtonReflashModInfo.UseVisualStyleBackColor = True
        '
        'ButtonRemoveUselessDepend
        '
        Me.ButtonRemoveUselessDepend.Location = New System.Drawing.Point(183, 428)
        Me.ButtonRemoveUselessDepend.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonRemoveUselessDepend.Name = "ButtonRemoveUselessDepend"
        Me.ButtonRemoveUselessDepend.Size = New System.Drawing.Size(157, 55)
        Me.ButtonRemoveUselessDepend.TabIndex = 7
        Me.ButtonRemoveUselessDepend.Text = "移除无用前置"
        Me.ButtonRemoveUselessDepend.UseVisualStyleBackColor = True
        '
        'ButtonApplyAll
        '
        Me.ButtonApplyAll.Location = New System.Drawing.Point(183, 247)
        Me.ButtonApplyAll.Name = "ButtonApplyAll"
        Me.ButtonApplyAll.Size = New System.Drawing.Size(75, 23)
        Me.ButtonApplyAll.TabIndex = 8
        Me.ButtonApplyAll.Text = "应用"
        Me.ButtonApplyAll.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 498)
        Me.Controls.Add(Me.ButtonApplyAll)
        Me.Controls.Add(Me.ButtonRemoveUselessDepend)
        Me.Controls.Add(Me.ButtonReflashModInfo)
        Me.Controls.Add(Me.ButtonCurseForge)
        Me.Controls.Add(Me.ButtonMCBBS)
        Me.Controls.Add(Me.ButtonTest1)
        Me.Controls.Add(Me.CheckedListBoxSelectMods)
        Me.Controls.Add(Me.LabelModInfo)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CheckedListBoxSelectMods As CheckedListBox
    Friend WithEvents LabelModInfo As Label
    Friend WithEvents ButtonTest1 As Button
    Friend WithEvents ButtonMCBBS As Button
    Friend WithEvents ButtonCurseForge As Button
    Friend WithEvents ButtonReflashModInfo As Button
    Friend WithEvents ButtonRemoveUselessDepend As Button
    Friend WithEvents ButtonApplyAll As Button
End Class
