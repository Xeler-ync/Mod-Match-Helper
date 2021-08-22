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
        Me.PanelMoveForm = New System.Windows.Forms.Panel()
        Me.LabelMMH = New System.Windows.Forms.Label()
        Me.GroupBoxAdvancedMode = New System.Windows.Forms.GroupBox()
        Me.GroupBoxCheckBoxModList = New System.Windows.Forms.GroupBox()
        Me.CheckBoxMod13 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMod0 = New System.Windows.Forms.CheckBox()
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
        Me.VScrollBarModList = New System.Windows.Forms.VScrollBar()
        Me.LabelClickCurseForge = New System.Windows.Forms.Label()
        Me.LabelClickMCbaike = New System.Windows.Forms.Label()
        Me.ButtonApplyAll = New System.Windows.Forms.Button()
        Me.ButtonRemoveUselessDepend = New System.Windows.Forms.Button()
        Me.ButtonReflashModInfo = New System.Windows.Forms.Button()
        Me.ButtonTest1 = New System.Windows.Forms.Button()
        Me.LabelModInfo = New System.Windows.Forms.Label()
        Me.GroupBoxModList = New System.Windows.Forms.GroupBox()
        Me.LabelMod13 = New System.Windows.Forms.Label()
        Me.LabelMod12 = New System.Windows.Forms.Label()
        Me.LabelMod11 = New System.Windows.Forms.Label()
        Me.LabelMod10 = New System.Windows.Forms.Label()
        Me.LabelMod9 = New System.Windows.Forms.Label()
        Me.LabelMod8 = New System.Windows.Forms.Label()
        Me.LabelMod7 = New System.Windows.Forms.Label()
        Me.LabelMod6 = New System.Windows.Forms.Label()
        Me.LabelMod5 = New System.Windows.Forms.Label()
        Me.LabelMod4 = New System.Windows.Forms.Label()
        Me.LabelMod3 = New System.Windows.Forms.Label()
        Me.LabelMod2 = New System.Windows.Forms.Label()
        Me.LabelMod1 = New System.Windows.Forms.Label()
        Me.LabelMod0 = New System.Windows.Forms.Label()
        Me.GroupBoxEasyMode = New System.Windows.Forms.GroupBox()
        Me.LabelSelectedSettingsDescription = New System.Windows.Forms.Label()
        Me.LabelSelectedSettingsName = New System.Windows.Forms.Label()
        Me.LabelClickNextSettings = New System.Windows.Forms.Label()
        Me.LabelClickPreviousSettings = New System.Windows.Forms.Label()
        Me.PanelMoveForm.SuspendLayout()
        Me.GroupBoxAdvancedMode.SuspendLayout()
        Me.GroupBoxCheckBoxModList.SuspendLayout()
        Me.GroupBoxModList.SuspendLayout()
        Me.GroupBoxEasyMode.SuspendLayout()
        Me.SuspendLayout()
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
        'GroupBoxAdvancedMode
        '
        Me.GroupBoxAdvancedMode.Controls.Add(Me.GroupBoxCheckBoxModList)
        Me.GroupBoxAdvancedMode.Controls.Add(Me.VScrollBarModList)
        Me.GroupBoxAdvancedMode.Controls.Add(Me.LabelClickCurseForge)
        Me.GroupBoxAdvancedMode.Controls.Add(Me.LabelClickMCbaike)
        Me.GroupBoxAdvancedMode.Controls.Add(Me.ButtonApplyAll)
        Me.GroupBoxAdvancedMode.Controls.Add(Me.ButtonRemoveUselessDepend)
        Me.GroupBoxAdvancedMode.Controls.Add(Me.ButtonReflashModInfo)
        Me.GroupBoxAdvancedMode.Controls.Add(Me.ButtonTest1)
        Me.GroupBoxAdvancedMode.Controls.Add(Me.LabelModInfo)
        Me.GroupBoxAdvancedMode.Controls.Add(Me.GroupBoxModList)
        Me.GroupBoxAdvancedMode.Location = New System.Drawing.Point(-2, 36)
        Me.GroupBoxAdvancedMode.Name = "GroupBoxAdvancedMode"
        Me.GroupBoxAdvancedMode.Size = New System.Drawing.Size(698, 401)
        Me.GroupBoxAdvancedMode.TabIndex = 55
        Me.GroupBoxAdvancedMode.TabStop = False
        Me.GroupBoxAdvancedMode.Visible = False
        '
        'GroupBoxCheckBoxModList
        '
        Me.GroupBoxCheckBoxModList.Controls.Add(Me.CheckBoxMod13)
        Me.GroupBoxCheckBoxModList.Controls.Add(Me.CheckBoxMod0)
        Me.GroupBoxCheckBoxModList.Controls.Add(Me.CheckBoxMod12)
        Me.GroupBoxCheckBoxModList.Controls.Add(Me.CheckBoxMod11)
        Me.GroupBoxCheckBoxModList.Controls.Add(Me.CheckBoxMod10)
        Me.GroupBoxCheckBoxModList.Controls.Add(Me.CheckBoxMod9)
        Me.GroupBoxCheckBoxModList.Controls.Add(Me.CheckBoxMod8)
        Me.GroupBoxCheckBoxModList.Controls.Add(Me.CheckBoxMod7)
        Me.GroupBoxCheckBoxModList.Controls.Add(Me.CheckBoxMod6)
        Me.GroupBoxCheckBoxModList.Controls.Add(Me.CheckBoxMod5)
        Me.GroupBoxCheckBoxModList.Controls.Add(Me.CheckBoxMod4)
        Me.GroupBoxCheckBoxModList.Controls.Add(Me.CheckBoxMod3)
        Me.GroupBoxCheckBoxModList.Controls.Add(Me.CheckBoxMod2)
        Me.GroupBoxCheckBoxModList.Controls.Add(Me.CheckBoxMod1)
        Me.GroupBoxCheckBoxModList.Location = New System.Drawing.Point(22, 18)
        Me.GroupBoxCheckBoxModList.Name = "GroupBoxCheckBoxModList"
        Me.GroupBoxCheckBoxModList.Size = New System.Drawing.Size(17, 316)
        Me.GroupBoxCheckBoxModList.TabIndex = 78
        Me.GroupBoxCheckBoxModList.TabStop = False
        '
        'CheckBoxMod13
        '
        Me.CheckBoxMod13.Location = New System.Drawing.Point(2, 290)
        Me.CheckBoxMod13.Name = "CheckBoxMod13"
        Me.CheckBoxMod13.Size = New System.Drawing.Size(15, 24)
        Me.CheckBoxMod13.TabIndex = 77
        Me.CheckBoxMod13.UseVisualStyleBackColor = True
        '
        'CheckBoxMod0
        '
        Me.CheckBoxMod0.Location = New System.Drawing.Point(2, 4)
        Me.CheckBoxMod0.Name = "CheckBoxMod0"
        Me.CheckBoxMod0.Size = New System.Drawing.Size(15, 24)
        Me.CheckBoxMod0.TabIndex = 64
        Me.CheckBoxMod0.UseVisualStyleBackColor = True
        '
        'CheckBoxMod12
        '
        Me.CheckBoxMod12.Location = New System.Drawing.Point(2, 268)
        Me.CheckBoxMod12.Name = "CheckBoxMod12"
        Me.CheckBoxMod12.Size = New System.Drawing.Size(15, 24)
        Me.CheckBoxMod12.TabIndex = 76
        Me.CheckBoxMod12.UseVisualStyleBackColor = True
        '
        'CheckBoxMod11
        '
        Me.CheckBoxMod11.Location = New System.Drawing.Point(2, 246)
        Me.CheckBoxMod11.Name = "CheckBoxMod11"
        Me.CheckBoxMod11.Size = New System.Drawing.Size(15, 24)
        Me.CheckBoxMod11.TabIndex = 75
        Me.CheckBoxMod11.UseVisualStyleBackColor = True
        '
        'CheckBoxMod10
        '
        Me.CheckBoxMod10.Location = New System.Drawing.Point(2, 224)
        Me.CheckBoxMod10.Name = "CheckBoxMod10"
        Me.CheckBoxMod10.Size = New System.Drawing.Size(15, 24)
        Me.CheckBoxMod10.TabIndex = 74
        Me.CheckBoxMod10.UseVisualStyleBackColor = True
        '
        'CheckBoxMod9
        '
        Me.CheckBoxMod9.Location = New System.Drawing.Point(2, 202)
        Me.CheckBoxMod9.Name = "CheckBoxMod9"
        Me.CheckBoxMod9.Size = New System.Drawing.Size(15, 24)
        Me.CheckBoxMod9.TabIndex = 73
        Me.CheckBoxMod9.UseVisualStyleBackColor = True
        '
        'CheckBoxMod8
        '
        Me.CheckBoxMod8.Location = New System.Drawing.Point(2, 180)
        Me.CheckBoxMod8.Name = "CheckBoxMod8"
        Me.CheckBoxMod8.Size = New System.Drawing.Size(15, 24)
        Me.CheckBoxMod8.TabIndex = 72
        Me.CheckBoxMod8.UseVisualStyleBackColor = True
        '
        'CheckBoxMod7
        '
        Me.CheckBoxMod7.Location = New System.Drawing.Point(2, 158)
        Me.CheckBoxMod7.Name = "CheckBoxMod7"
        Me.CheckBoxMod7.Size = New System.Drawing.Size(15, 24)
        Me.CheckBoxMod7.TabIndex = 71
        Me.CheckBoxMod7.UseVisualStyleBackColor = True
        '
        'CheckBoxMod6
        '
        Me.CheckBoxMod6.Location = New System.Drawing.Point(2, 136)
        Me.CheckBoxMod6.Name = "CheckBoxMod6"
        Me.CheckBoxMod6.Size = New System.Drawing.Size(15, 24)
        Me.CheckBoxMod6.TabIndex = 70
        Me.CheckBoxMod6.UseVisualStyleBackColor = True
        '
        'CheckBoxMod5
        '
        Me.CheckBoxMod5.Location = New System.Drawing.Point(2, 114)
        Me.CheckBoxMod5.Name = "CheckBoxMod5"
        Me.CheckBoxMod5.Size = New System.Drawing.Size(15, 24)
        Me.CheckBoxMod5.TabIndex = 69
        Me.CheckBoxMod5.UseVisualStyleBackColor = True
        '
        'CheckBoxMod4
        '
        Me.CheckBoxMod4.Location = New System.Drawing.Point(2, 92)
        Me.CheckBoxMod4.Name = "CheckBoxMod4"
        Me.CheckBoxMod4.Size = New System.Drawing.Size(15, 24)
        Me.CheckBoxMod4.TabIndex = 68
        Me.CheckBoxMod4.UseVisualStyleBackColor = True
        '
        'CheckBoxMod3
        '
        Me.CheckBoxMod3.Location = New System.Drawing.Point(2, 70)
        Me.CheckBoxMod3.Name = "CheckBoxMod3"
        Me.CheckBoxMod3.Size = New System.Drawing.Size(15, 24)
        Me.CheckBoxMod3.TabIndex = 67
        Me.CheckBoxMod3.UseVisualStyleBackColor = True
        '
        'CheckBoxMod2
        '
        Me.CheckBoxMod2.Location = New System.Drawing.Point(2, 48)
        Me.CheckBoxMod2.Name = "CheckBoxMod2"
        Me.CheckBoxMod2.Size = New System.Drawing.Size(15, 24)
        Me.CheckBoxMod2.TabIndex = 66
        Me.CheckBoxMod2.UseVisualStyleBackColor = True
        '
        'CheckBoxMod1
        '
        Me.CheckBoxMod1.Location = New System.Drawing.Point(2, 26)
        Me.CheckBoxMod1.Name = "CheckBoxMod1"
        Me.CheckBoxMod1.Size = New System.Drawing.Size(15, 24)
        Me.CheckBoxMod1.TabIndex = 65
        Me.CheckBoxMod1.UseVisualStyleBackColor = True
        '
        'VScrollBarModList
        '
        Me.VScrollBarModList.Location = New System.Drawing.Point(238, 24)
        Me.VScrollBarModList.Name = "VScrollBarModList"
        Me.VScrollBarModList.Size = New System.Drawing.Size(22, 309)
        Me.VScrollBarModList.TabIndex = 62
        Me.VScrollBarModList.Visible = False
        '
        'LabelClickCurseForge
        '
        Me.LabelClickCurseForge.Font = New System.Drawing.Font("宋体", 25.0!)
        Me.LabelClickCurseForge.Location = New System.Drawing.Point(267, 348)
        Me.LabelClickCurseForge.Name = "LabelClickCurseForge"
        Me.LabelClickCurseForge.Size = New System.Drawing.Size(210, 44)
        Me.LabelClickCurseForge.TabIndex = 61
        Me.LabelClickCurseForge.Text = "CurseForge"
        Me.LabelClickCurseForge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelClickCurseForge.Visible = False
        '
        'LabelClickMCbaike
        '
        Me.LabelClickMCbaike.Font = New System.Drawing.Font("宋体", 25.0!)
        Me.LabelClickMCbaike.Location = New System.Drawing.Point(483, 349)
        Me.LabelClickMCbaike.Name = "LabelClickMCbaike"
        Me.LabelClickMCbaike.Size = New System.Drawing.Size(210, 44)
        Me.LabelClickMCbaike.TabIndex = 60
        Me.LabelClickMCbaike.Text = "MC百科"
        Me.LabelClickMCbaike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelClickMCbaike.Visible = False
        '
        'ButtonApplyAll
        '
        Me.ButtonApplyAll.FlatAppearance.BorderSize = 0
        Me.ButtonApplyAll.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonApplyAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonApplyAll.Location = New System.Drawing.Point(196, 348)
        Me.ButtonApplyAll.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonApplyAll.Name = "ButtonApplyAll"
        Me.ButtonApplyAll.Size = New System.Drawing.Size(64, 44)
        Me.ButtonApplyAll.TabIndex = 59
        Me.ButtonApplyAll.Text = "应用"
        Me.ButtonApplyAll.UseVisualStyleBackColor = True
        '
        'ButtonRemoveUselessDepend
        '
        Me.ButtonRemoveUselessDepend.FlatAppearance.BorderSize = 0
        Me.ButtonRemoveUselessDepend.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonRemoveUselessDepend.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonRemoveUselessDepend.Location = New System.Drawing.Point(108, 348)
        Me.ButtonRemoveUselessDepend.Name = "ButtonRemoveUselessDepend"
        Me.ButtonRemoveUselessDepend.Size = New System.Drawing.Size(82, 44)
        Me.ButtonRemoveUselessDepend.TabIndex = 58
        Me.ButtonRemoveUselessDepend.Text = "移除无用前置"
        Me.ButtonRemoveUselessDepend.UseVisualStyleBackColor = True
        '
        'ButtonReflashModInfo
        '
        Me.ButtonReflashModInfo.FlatAppearance.BorderSize = 0
        Me.ButtonReflashModInfo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonReflashModInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonReflashModInfo.Location = New System.Drawing.Point(18, 350)
        Me.ButtonReflashModInfo.Name = "ButtonReflashModInfo"
        Me.ButtonReflashModInfo.Size = New System.Drawing.Size(85, 43)
        Me.ButtonReflashModInfo.TabIndex = 57
        Me.ButtonReflashModInfo.Text = "刷新Mod信息"
        Me.ButtonReflashModInfo.UseVisualStyleBackColor = True
        '
        'ButtonTest1
        '
        Me.ButtonTest1.Location = New System.Drawing.Point(6, 7)
        Me.ButtonTest1.Name = "ButtonTest1"
        Me.ButtonTest1.Size = New System.Drawing.Size(18, 19)
        Me.ButtonTest1.TabIndex = 56
        Me.ButtonTest1.Text = "Button1"
        Me.ButtonTest1.UseVisualStyleBackColor = True
        '
        'LabelModInfo
        '
        Me.LabelModInfo.BackColor = System.Drawing.SystemColors.Control
        Me.LabelModInfo.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.LabelModInfo.Location = New System.Drawing.Point(267, 18)
        Me.LabelModInfo.Name = "LabelModInfo"
        Me.LabelModInfo.Size = New System.Drawing.Size(426, 324)
        Me.LabelModInfo.TabIndex = 55
        Me.LabelModInfo.Visible = False
        '
        'GroupBoxModList
        '
        Me.GroupBoxModList.Controls.Add(Me.LabelMod13)
        Me.GroupBoxModList.Controls.Add(Me.LabelMod12)
        Me.GroupBoxModList.Controls.Add(Me.LabelMod11)
        Me.GroupBoxModList.Controls.Add(Me.LabelMod10)
        Me.GroupBoxModList.Controls.Add(Me.LabelMod9)
        Me.GroupBoxModList.Controls.Add(Me.LabelMod8)
        Me.GroupBoxModList.Controls.Add(Me.LabelMod7)
        Me.GroupBoxModList.Controls.Add(Me.LabelMod6)
        Me.GroupBoxModList.Controls.Add(Me.LabelMod5)
        Me.GroupBoxModList.Controls.Add(Me.LabelMod4)
        Me.GroupBoxModList.Controls.Add(Me.LabelMod3)
        Me.GroupBoxModList.Controls.Add(Me.LabelMod2)
        Me.GroupBoxModList.Controls.Add(Me.LabelMod1)
        Me.GroupBoxModList.Controls.Add(Me.LabelMod0)
        Me.GroupBoxModList.Location = New System.Drawing.Point(39, 18)
        Me.GroupBoxModList.Name = "GroupBoxModList"
        Me.GroupBoxModList.Size = New System.Drawing.Size(221, 316)
        Me.GroupBoxModList.TabIndex = 63
        Me.GroupBoxModList.TabStop = False
        '
        'LabelMod13
        '
        Me.LabelMod13.Location = New System.Drawing.Point(0, 294)
        Me.LabelMod13.Name = "LabelMod13"
        Me.LabelMod13.Size = New System.Drawing.Size(653, 18)
        Me.LabelMod13.TabIndex = 54
        Me.LabelMod13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMod12
        '
        Me.LabelMod12.Location = New System.Drawing.Point(0, 272)
        Me.LabelMod12.Name = "LabelMod12"
        Me.LabelMod12.Size = New System.Drawing.Size(653, 18)
        Me.LabelMod12.TabIndex = 53
        Me.LabelMod12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMod11
        '
        Me.LabelMod11.Location = New System.Drawing.Point(0, 250)
        Me.LabelMod11.Name = "LabelMod11"
        Me.LabelMod11.Size = New System.Drawing.Size(653, 18)
        Me.LabelMod11.TabIndex = 52
        Me.LabelMod11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMod10
        '
        Me.LabelMod10.Location = New System.Drawing.Point(0, 228)
        Me.LabelMod10.Name = "LabelMod10"
        Me.LabelMod10.Size = New System.Drawing.Size(653, 18)
        Me.LabelMod10.TabIndex = 51
        Me.LabelMod10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMod9
        '
        Me.LabelMod9.Location = New System.Drawing.Point(0, 206)
        Me.LabelMod9.Name = "LabelMod9"
        Me.LabelMod9.Size = New System.Drawing.Size(653, 18)
        Me.LabelMod9.TabIndex = 50
        Me.LabelMod9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMod8
        '
        Me.LabelMod8.Location = New System.Drawing.Point(0, 184)
        Me.LabelMod8.Name = "LabelMod8"
        Me.LabelMod8.Size = New System.Drawing.Size(653, 18)
        Me.LabelMod8.TabIndex = 49
        Me.LabelMod8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMod7
        '
        Me.LabelMod7.Location = New System.Drawing.Point(0, 162)
        Me.LabelMod7.Name = "LabelMod7"
        Me.LabelMod7.Size = New System.Drawing.Size(653, 18)
        Me.LabelMod7.TabIndex = 48
        Me.LabelMod7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMod6
        '
        Me.LabelMod6.Location = New System.Drawing.Point(0, 140)
        Me.LabelMod6.Name = "LabelMod6"
        Me.LabelMod6.Size = New System.Drawing.Size(653, 18)
        Me.LabelMod6.TabIndex = 47
        Me.LabelMod6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMod5
        '
        Me.LabelMod5.Location = New System.Drawing.Point(0, 118)
        Me.LabelMod5.Name = "LabelMod5"
        Me.LabelMod5.Size = New System.Drawing.Size(653, 18)
        Me.LabelMod5.TabIndex = 46
        Me.LabelMod5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMod4
        '
        Me.LabelMod4.Location = New System.Drawing.Point(0, 97)
        Me.LabelMod4.Name = "LabelMod4"
        Me.LabelMod4.Size = New System.Drawing.Size(653, 18)
        Me.LabelMod4.TabIndex = 45
        Me.LabelMod4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMod3
        '
        Me.LabelMod3.Location = New System.Drawing.Point(0, 75)
        Me.LabelMod3.Name = "LabelMod3"
        Me.LabelMod3.Size = New System.Drawing.Size(653, 18)
        Me.LabelMod3.TabIndex = 44
        Me.LabelMod3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMod2
        '
        Me.LabelMod2.Location = New System.Drawing.Point(0, 53)
        Me.LabelMod2.Name = "LabelMod2"
        Me.LabelMod2.Size = New System.Drawing.Size(653, 18)
        Me.LabelMod2.TabIndex = 43
        Me.LabelMod2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMod1
        '
        Me.LabelMod1.Location = New System.Drawing.Point(0, 31)
        Me.LabelMod1.Name = "LabelMod1"
        Me.LabelMod1.Size = New System.Drawing.Size(653, 18)
        Me.LabelMod1.TabIndex = 42
        Me.LabelMod1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMod0
        '
        Me.LabelMod0.Location = New System.Drawing.Point(0, 9)
        Me.LabelMod0.Name = "LabelMod0"
        Me.LabelMod0.Size = New System.Drawing.Size(653, 18)
        Me.LabelMod0.TabIndex = 41
        Me.LabelMod0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxEasyMode
        '
        Me.GroupBoxEasyMode.Controls.Add(Me.LabelClickPreviousSettings)
        Me.GroupBoxEasyMode.Controls.Add(Me.LabelClickNextSettings)
        Me.GroupBoxEasyMode.Controls.Add(Me.LabelSelectedSettingsName)
        Me.GroupBoxEasyMode.Controls.Add(Me.LabelSelectedSettingsDescription)
        Me.GroupBoxEasyMode.Location = New System.Drawing.Point(-2, 36)
        Me.GroupBoxEasyMode.Name = "GroupBoxEasyMode"
        Me.GroupBoxEasyMode.Size = New System.Drawing.Size(698, 401)
        Me.GroupBoxEasyMode.TabIndex = 81
        Me.GroupBoxEasyMode.TabStop = False
        '
        'LabelSelectedSettingsDescription
        '
        Me.LabelSelectedSettingsDescription.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.LabelSelectedSettingsDescription.Location = New System.Drawing.Point(163, 176)
        Me.LabelSelectedSettingsDescription.Name = "LabelSelectedSettingsDescription"
        Me.LabelSelectedSettingsDescription.Size = New System.Drawing.Size(378, 149)
        Me.LabelSelectedSettingsDescription.TabIndex = 0
        Me.LabelSelectedSettingsDescription.Text = "适合新手玩家使用，包含小地图、游戏优化、皮肤补丁等"
        Me.LabelSelectedSettingsDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelSelectedSettingsName
        '
        Me.LabelSelectedSettingsName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelSelectedSettingsName.Font = New System.Drawing.Font("宋体", 40.0!)
        Me.LabelSelectedSettingsName.Location = New System.Drawing.Point(156, 45)
        Me.LabelSelectedSettingsName.Name = "LabelSelectedSettingsName"
        Me.LabelSelectedSettingsName.Size = New System.Drawing.Size(385, 113)
        Me.LabelSelectedSettingsName.TabIndex = 1
        Me.LabelSelectedSettingsName.Text = "新手推荐"
        Me.LabelSelectedSettingsName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelClickNextSettings
        '
        Me.LabelClickNextSettings.Font = New System.Drawing.Font("宋体", 150.0!)
        Me.LabelClickNextSettings.Location = New System.Drawing.Point(547, 36)
        Me.LabelClickNextSettings.Name = "LabelClickNextSettings"
        Me.LabelClickNextSettings.Size = New System.Drawing.Size(144, 339)
        Me.LabelClickNextSettings.TabIndex = 2
        Me.LabelClickNextSettings.Text = ">"
        Me.LabelClickNextSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelClickPreviousSettings
        '
        Me.LabelClickPreviousSettings.Font = New System.Drawing.Font("宋体", 150.0!)
        Me.LabelClickPreviousSettings.Location = New System.Drawing.Point(6, 36)
        Me.LabelClickPreviousSettings.Name = "LabelClickPreviousSettings"
        Me.LabelClickPreviousSettings.Size = New System.Drawing.Size(144, 339)
        Me.LabelClickPreviousSettings.TabIndex = 3
        Me.LabelClickPreviousSettings.Text = "<"
        Me.LabelClickPreviousSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(694, 437)
        Me.Controls.Add(Me.PanelMoveForm)
        Me.Controls.Add(Me.GroupBoxEasyMode)
        Me.Controls.Add(Me.GroupBoxAdvancedMode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.Text = "MMH"
        Me.PanelMoveForm.ResumeLayout(False)
        Me.GroupBoxAdvancedMode.ResumeLayout(False)
        Me.GroupBoxCheckBoxModList.ResumeLayout(False)
        Me.GroupBoxModList.ResumeLayout(False)
        Me.GroupBoxEasyMode.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMoveForm As Panel
    Friend WithEvents LabelMMH As Label
    Friend WithEvents GroupBoxAdvancedMode As GroupBox
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
    Friend WithEvents VScrollBarModList As VScrollBar
    Friend WithEvents LabelClickCurseForge As Label
    Friend WithEvents LabelClickMCbaike As Label
    Friend WithEvents ButtonApplyAll As Button
    Friend WithEvents ButtonRemoveUselessDepend As Button
    Friend WithEvents ButtonReflashModInfo As Button
    Friend WithEvents ButtonTest1 As Button
    Friend WithEvents LabelModInfo As Label
    Friend WithEvents GroupBoxModList As GroupBox
    Friend WithEvents LabelMod13 As Label
    Friend WithEvents LabelMod12 As Label
    Friend WithEvents LabelMod11 As Label
    Friend WithEvents LabelMod10 As Label
    Friend WithEvents LabelMod9 As Label
    Friend WithEvents LabelMod8 As Label
    Friend WithEvents LabelMod7 As Label
    Friend WithEvents LabelMod6 As Label
    Friend WithEvents LabelMod5 As Label
    Friend WithEvents LabelMod4 As Label
    Friend WithEvents LabelMod3 As Label
    Friend WithEvents LabelMod2 As Label
    Friend WithEvents LabelMod1 As Label
    Friend WithEvents LabelMod0 As Label
    Friend WithEvents GroupBoxEasyMode As GroupBox
    Friend WithEvents GroupBoxCheckBoxModList As GroupBox
    Friend WithEvents LabelSelectedSettingsName As Label
    Friend WithEvents LabelSelectedSettingsDescription As Label
    Friend WithEvents LabelClickPreviousSettings As Label
    Friend WithEvents LabelClickNextSettings As Label
End Class
