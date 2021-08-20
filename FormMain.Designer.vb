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
        Me.ButtonReflashModInfo = New System.Windows.Forms.Button()
        Me.ButtonRemoveUselessDepend = New System.Windows.Forms.Button()
        Me.ButtonApplyAll = New System.Windows.Forms.Button()
        Me.PanelMoveForm = New System.Windows.Forms.Panel()
        Me.LabelMMH = New System.Windows.Forms.Label()
        Me.LabelClickMCbaike = New System.Windows.Forms.Label()
        Me.LabelClickCurseForge = New System.Windows.Forms.Label()
        Me.VScrollBarModList = New System.Windows.Forms.VScrollBar()
        Me.GroupBoxModList = New System.Windows.Forms.GroupBox()
        Me.CheckBoxMod13 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMod12 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMod11 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMod10 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMod9 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMod8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMod7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMod6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMod5 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMod4 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMod3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMod2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMod1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMod0 = New System.Windows.Forms.CheckBox()
        Me.PanelMoveForm.SuspendLayout()
        Me.GroupBoxModList.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckedListBoxSelectMods
        '
        Me.CheckedListBoxSelectMods.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBoxSelectMods.ColumnWidth = 2
        Me.CheckedListBoxSelectMods.FormattingEnabled = True
        Me.CheckedListBoxSelectMods.Location = New System.Drawing.Point(265, 53)
        Me.CheckedListBoxSelectMods.Name = "CheckedListBoxSelectMods"
        Me.CheckedListBoxSelectMods.Size = New System.Drawing.Size(242, 320)
        Me.CheckedListBoxSelectMods.TabIndex = 0
        '
        'LabelModInfo
        '
        Me.LabelModInfo.BackColor = System.Drawing.SystemColors.Control
        Me.LabelModInfo.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.LabelModInfo.Location = New System.Drawing.Point(259, 53)
        Me.LabelModInfo.Name = "LabelModInfo"
        Me.LabelModInfo.Size = New System.Drawing.Size(426, 324)
        Me.LabelModInfo.TabIndex = 2
        Me.LabelModInfo.Visible = False
        '
        'ButtonTest1
        '
        Me.ButtonTest1.Location = New System.Drawing.Point(-2, 42)
        Me.ButtonTest1.Name = "ButtonTest1"
        Me.ButtonTest1.Size = New System.Drawing.Size(18, 19)
        Me.ButtonTest1.TabIndex = 3
        Me.ButtonTest1.Text = "Button1"
        Me.ButtonTest1.UseVisualStyleBackColor = True
        '
        'ButtonReflashModInfo
        '
        Me.ButtonReflashModInfo.FlatAppearance.BorderSize = 0
        Me.ButtonReflashModInfo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonReflashModInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonReflashModInfo.Location = New System.Drawing.Point(10, 385)
        Me.ButtonReflashModInfo.Name = "ButtonReflashModInfo"
        Me.ButtonReflashModInfo.Size = New System.Drawing.Size(85, 43)
        Me.ButtonReflashModInfo.TabIndex = 6
        Me.ButtonReflashModInfo.Text = "刷新Mod信息"
        Me.ButtonReflashModInfo.UseVisualStyleBackColor = True
        '
        'ButtonRemoveUselessDepend
        '
        Me.ButtonRemoveUselessDepend.FlatAppearance.BorderSize = 0
        Me.ButtonRemoveUselessDepend.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonRemoveUselessDepend.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonRemoveUselessDepend.Location = New System.Drawing.Point(100, 383)
        Me.ButtonRemoveUselessDepend.Name = "ButtonRemoveUselessDepend"
        Me.ButtonRemoveUselessDepend.Size = New System.Drawing.Size(82, 44)
        Me.ButtonRemoveUselessDepend.TabIndex = 7
        Me.ButtonRemoveUselessDepend.Text = "移除无用前置"
        Me.ButtonRemoveUselessDepend.UseVisualStyleBackColor = True
        '
        'ButtonApplyAll
        '
        Me.ButtonApplyAll.FlatAppearance.BorderSize = 0
        Me.ButtonApplyAll.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonApplyAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonApplyAll.Location = New System.Drawing.Point(188, 383)
        Me.ButtonApplyAll.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonApplyAll.Name = "ButtonApplyAll"
        Me.ButtonApplyAll.Size = New System.Drawing.Size(64, 44)
        Me.ButtonApplyAll.TabIndex = 8
        Me.ButtonApplyAll.Text = "应用"
        Me.ButtonApplyAll.UseVisualStyleBackColor = True
        '
        'PanelMoveForm
        '
        Me.PanelMoveForm.BackColor = System.Drawing.SystemColors.Control
        Me.PanelMoveForm.Controls.Add(Me.LabelMMH)
        Me.PanelMoveForm.Location = New System.Drawing.Point(-2, -2)
        Me.PanelMoveForm.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMoveForm.Name = "PanelMoveForm"
        Me.PanelMoveForm.Size = New System.Drawing.Size(698, 45)
        Me.PanelMoveForm.TabIndex = 10
        '
        'LabelMMH
        '
        Me.LabelMMH.Font = New System.Drawing.Font("Corbel", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMMH.ForeColor = System.Drawing.Color.White
        Me.LabelMMH.Location = New System.Drawing.Point(11, 4)
        Me.LabelMMH.Name = "LabelMMH"
        Me.LabelMMH.Size = New System.Drawing.Size(170, 37)
        Me.LabelMMH.TabIndex = 0
        Me.LabelMMH.Text = "MMH v1.0"
        '
        'LabelClickMCbaike
        '
        Me.LabelClickMCbaike.Font = New System.Drawing.Font("宋体", 25.0!)
        Me.LabelClickMCbaike.Location = New System.Drawing.Point(475, 384)
        Me.LabelClickMCbaike.Name = "LabelClickMCbaike"
        Me.LabelClickMCbaike.Size = New System.Drawing.Size(210, 44)
        Me.LabelClickMCbaike.TabIndex = 12
        Me.LabelClickMCbaike.Text = "MC百科"
        Me.LabelClickMCbaike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelClickCurseForge
        '
        Me.LabelClickCurseForge.Font = New System.Drawing.Font("宋体", 25.0!)
        Me.LabelClickCurseForge.Location = New System.Drawing.Point(259, 383)
        Me.LabelClickCurseForge.Name = "LabelClickCurseForge"
        Me.LabelClickCurseForge.Size = New System.Drawing.Size(210, 44)
        Me.LabelClickCurseForge.TabIndex = 13
        Me.LabelClickCurseForge.Text = "CurseForge"
        Me.LabelClickCurseForge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VScrollBarModList
        '
        Me.VScrollBarModList.Location = New System.Drawing.Point(230, 59)
        Me.VScrollBarModList.Name = "VScrollBarModList"
        Me.VScrollBarModList.Size = New System.Drawing.Size(22, 309)
        Me.VScrollBarModList.TabIndex = 27
        Me.VScrollBarModList.Visible = False
        '
        'GroupBoxModList
        '
        Me.GroupBoxModList.Controls.Add(Me.CheckBoxMod13)
        Me.GroupBoxModList.Controls.Add(Me.CheckBoxMod12)
        Me.GroupBoxModList.Controls.Add(Me.CheckBoxMod11)
        Me.GroupBoxModList.Controls.Add(Me.CheckBoxMod10)
        Me.GroupBoxModList.Controls.Add(Me.CheckBoxMod9)
        Me.GroupBoxModList.Controls.Add(Me.CheckBoxMod8)
        Me.GroupBoxModList.Controls.Add(Me.CheckBoxMod7)
        Me.GroupBoxModList.Controls.Add(Me.CheckBoxMod6)
        Me.GroupBoxModList.Controls.Add(Me.CheckBoxMod5)
        Me.GroupBoxModList.Controls.Add(Me.CheckBoxMod4)
        Me.GroupBoxModList.Controls.Add(Me.CheckBoxMod3)
        Me.GroupBoxModList.Controls.Add(Me.CheckBoxMod2)
        Me.GroupBoxModList.Controls.Add(Me.CheckBoxMod1)
        Me.GroupBoxModList.Controls.Add(Me.CheckBoxMod0)
        Me.GroupBoxModList.Location = New System.Drawing.Point(16, 53)
        Me.GroupBoxModList.Name = "GroupBoxModList"
        Me.GroupBoxModList.Size = New System.Drawing.Size(211, 315)
        Me.GroupBoxModList.TabIndex = 28
        Me.GroupBoxModList.TabStop = False
        '
        'CheckBoxMod13
        '
        Me.CheckBoxMod13.Location = New System.Drawing.Point(1, 292)
        Me.CheckBoxMod13.Name = "CheckBoxMod13"
        Me.CheckBoxMod13.Size = New System.Drawing.Size(209, 24)
        Me.CheckBoxMod13.TabIndex = 40
        Me.CheckBoxMod13.UseVisualStyleBackColor = True
        '
        'CheckBoxMod12
        '
        Me.CheckBoxMod12.Location = New System.Drawing.Point(1, 270)
        Me.CheckBoxMod12.Name = "CheckBoxMod12"
        Me.CheckBoxMod12.Size = New System.Drawing.Size(209, 24)
        Me.CheckBoxMod12.TabIndex = 39
        Me.CheckBoxMod12.UseVisualStyleBackColor = True
        '
        'CheckBoxMod11
        '
        Me.CheckBoxMod11.Location = New System.Drawing.Point(1, 248)
        Me.CheckBoxMod11.Name = "CheckBoxMod11"
        Me.CheckBoxMod11.Size = New System.Drawing.Size(209, 24)
        Me.CheckBoxMod11.TabIndex = 38
        Me.CheckBoxMod11.UseVisualStyleBackColor = True
        '
        'CheckBoxMod10
        '
        Me.CheckBoxMod10.Location = New System.Drawing.Point(1, 226)
        Me.CheckBoxMod10.Name = "CheckBoxMod10"
        Me.CheckBoxMod10.Size = New System.Drawing.Size(209, 24)
        Me.CheckBoxMod10.TabIndex = 37
        Me.CheckBoxMod10.UseVisualStyleBackColor = True
        '
        'CheckBoxMod9
        '
        Me.CheckBoxMod9.Location = New System.Drawing.Point(1, 204)
        Me.CheckBoxMod9.Name = "CheckBoxMod9"
        Me.CheckBoxMod9.Size = New System.Drawing.Size(209, 24)
        Me.CheckBoxMod9.TabIndex = 36
        Me.CheckBoxMod9.UseVisualStyleBackColor = True
        '
        'CheckBoxMod8
        '
        Me.CheckBoxMod8.Location = New System.Drawing.Point(1, 182)
        Me.CheckBoxMod8.Name = "CheckBoxMod8"
        Me.CheckBoxMod8.Size = New System.Drawing.Size(209, 24)
        Me.CheckBoxMod8.TabIndex = 35
        Me.CheckBoxMod8.UseVisualStyleBackColor = True
        '
        'CheckBoxMod7
        '
        Me.CheckBoxMod7.Location = New System.Drawing.Point(1, 160)
        Me.CheckBoxMod7.Name = "CheckBoxMod7"
        Me.CheckBoxMod7.Size = New System.Drawing.Size(209, 24)
        Me.CheckBoxMod7.TabIndex = 34
        Me.CheckBoxMod7.UseVisualStyleBackColor = True
        '
        'CheckBoxMod6
        '
        Me.CheckBoxMod6.Location = New System.Drawing.Point(1, 138)
        Me.CheckBoxMod6.Name = "CheckBoxMod6"
        Me.CheckBoxMod6.Size = New System.Drawing.Size(209, 24)
        Me.CheckBoxMod6.TabIndex = 33
        Me.CheckBoxMod6.UseVisualStyleBackColor = True
        '
        'CheckBoxMod5
        '
        Me.CheckBoxMod5.Location = New System.Drawing.Point(1, 116)
        Me.CheckBoxMod5.Name = "CheckBoxMod5"
        Me.CheckBoxMod5.Size = New System.Drawing.Size(209, 24)
        Me.CheckBoxMod5.TabIndex = 32
        Me.CheckBoxMod5.UseVisualStyleBackColor = True
        '
        'CheckBoxMod4
        '
        Me.CheckBoxMod4.Location = New System.Drawing.Point(1, 95)
        Me.CheckBoxMod4.Name = "CheckBoxMod4"
        Me.CheckBoxMod4.Size = New System.Drawing.Size(209, 24)
        Me.CheckBoxMod4.TabIndex = 31
        Me.CheckBoxMod4.UseVisualStyleBackColor = True
        '
        'CheckBoxMod3
        '
        Me.CheckBoxMod3.Location = New System.Drawing.Point(1, 73)
        Me.CheckBoxMod3.Name = "CheckBoxMod3"
        Me.CheckBoxMod3.Size = New System.Drawing.Size(209, 24)
        Me.CheckBoxMod3.TabIndex = 30
        Me.CheckBoxMod3.UseVisualStyleBackColor = True
        '
        'CheckBoxMod2
        '
        Me.CheckBoxMod2.Location = New System.Drawing.Point(1, 51)
        Me.CheckBoxMod2.Name = "CheckBoxMod2"
        Me.CheckBoxMod2.Size = New System.Drawing.Size(209, 24)
        Me.CheckBoxMod2.TabIndex = 29
        Me.CheckBoxMod2.UseVisualStyleBackColor = True
        '
        'CheckBoxMod1
        '
        Me.CheckBoxMod1.Location = New System.Drawing.Point(1, 29)
        Me.CheckBoxMod1.Name = "CheckBoxMod1"
        Me.CheckBoxMod1.Size = New System.Drawing.Size(209, 24)
        Me.CheckBoxMod1.TabIndex = 28
        Me.CheckBoxMod1.UseVisualStyleBackColor = True
        '
        'CheckBoxMod0
        '
        Me.CheckBoxMod0.Location = New System.Drawing.Point(1, 7)
        Me.CheckBoxMod0.Name = "CheckBoxMod0"
        Me.CheckBoxMod0.Size = New System.Drawing.Size(209, 24)
        Me.CheckBoxMod0.TabIndex = 27
        Me.CheckBoxMod0.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(694, 437)
        Me.Controls.Add(Me.VScrollBarModList)
        Me.Controls.Add(Me.LabelClickCurseForge)
        Me.Controls.Add(Me.LabelClickMCbaike)
        Me.Controls.Add(Me.PanelMoveForm)
        Me.Controls.Add(Me.ButtonApplyAll)
        Me.Controls.Add(Me.ButtonRemoveUselessDepend)
        Me.Controls.Add(Me.ButtonReflashModInfo)
        Me.Controls.Add(Me.ButtonTest1)
        Me.Controls.Add(Me.CheckedListBoxSelectMods)
        Me.Controls.Add(Me.LabelModInfo)
        Me.Controls.Add(Me.GroupBoxModList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.Text = "MMH"
        Me.PanelMoveForm.ResumeLayout(False)
        Me.GroupBoxModList.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CheckedListBoxSelectMods As CheckedListBox
    Friend WithEvents LabelModInfo As Label
    Friend WithEvents ButtonTest1 As Button
    Friend WithEvents ButtonReflashModInfo As Button
    Friend WithEvents ButtonRemoveUselessDepend As Button
    Friend WithEvents ButtonApplyAll As Button
    Friend WithEvents PanelMoveForm As Panel
    Friend WithEvents LabelMMH As Label
    Friend WithEvents LabelClickMCbaike As Label
    Friend WithEvents LabelClickCurseForge As Label
    Friend WithEvents VScrollBarModList As VScrollBar
    Friend WithEvents GroupBoxModList As GroupBox
    Friend WithEvents CheckBoxMod13 As CheckBox
    Friend WithEvents CheckBoxMod12 As CheckBox
    Friend WithEvents CheckBoxMod11 As CheckBox
    Friend WithEvents CheckBoxMod10 As CheckBox
    Friend WithEvents CheckBoxMod9 As CheckBox
    Friend WithEvents CheckBoxMod8 As CheckBox
    Friend WithEvents CheckBoxMod7 As CheckBox
    Friend WithEvents CheckBoxMod6 As CheckBox
    Friend WithEvents CheckBoxMod5 As CheckBox
    Friend WithEvents CheckBoxMod4 As CheckBox
    Friend WithEvents CheckBoxMod3 As CheckBox
    Friend WithEvents CheckBoxMod2 As CheckBox
    Friend WithEvents CheckBoxMod1 As CheckBox
    Friend WithEvents CheckBoxMod0 As CheckBox
End Class
