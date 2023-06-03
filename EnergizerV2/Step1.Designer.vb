<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FStep1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FStep1))
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.txtResultCellRef = New System.Windows.Forms.TextBox()
        Me.lblResultStartCell = New System.Windows.Forms.Label()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdResultCellRef = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMatrixCellRef = New System.Windows.Forms.Label()
        Me.txtMatrixCellRef = New System.Windows.Forms.TextBox()
        Me.cmdAltListDelete = New System.Windows.Forms.Button()
        Me.cmdAltListChange = New System.Windows.Forms.Button()
        Me.cmdAltListUp = New System.Windows.Forms.Button()
        Me.cmdAltListAdd = New System.Windows.Forms.Button()
        Me.cmdAltListDown = New System.Windows.Forms.Button()
        Me.chkAltUniqueNames = New System.Windows.Forms.CheckBox()
        Me.lstAltList = New System.Windows.Forms.ListBox()
        Me.grpAltSection = New System.Windows.Forms.GroupBox()
        Me.cboMcdaMethod = New System.Windows.Forms.ComboBox()
        Me.cmdCritListDelete = New System.Windows.Forms.Button()
        Me.cmdCritListChange = New System.Windows.Forms.Button()
        Me.cmdCritListAdd = New System.Windows.Forms.Button()
        Me.cmdCritListUp = New System.Windows.Forms.Button()
        Me.cmdCritListDown = New System.Windows.Forms.Button()
        Me.chkCritUniqueNames = New System.Windows.Forms.CheckBox()
        Me.lstCritList = New System.Windows.Forms.ListBox()
        Me.grpCritSection = New System.Windows.Forms.GroupBox()
        Me.cmdMatrixCellRef = New System.Windows.Forms.Button()
        Me.lblMcdaMethod = New System.Windows.Forms.Label()
        Me.lblCritCount = New System.Windows.Forms.Label()
        Me.cmdMcdaOptions = New System.Windows.Forms.Button()
        Me.lblAltCount = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtCritCount = New System.Windows.Forms.TextBox()
        Me.cmdResetAll = New System.Windows.Forms.Button()
        Me.txtAltCount = New System.Windows.Forms.TextBox()
        Me.lblStep1 = New System.Windows.Forms.Label()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.lblStep1Desc = New System.Windows.Forms.Label()
        Me.lblMcdaDesc = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grpAltSection.SuspendLayout()
        Me.grpCritSection.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(294, 675)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancel.TabIndex = 21
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseMnemonic = False
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdNext
        '
        Me.cmdNext.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNext.Location = New System.Drawing.Point(375, 675)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(75, 22)
        Me.cmdNext.TabIndex = 22
        Me.cmdNext.Text = "Next >"
        Me.cmdNext.UseMnemonic = False
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'txtResultCellRef
        '
        Me.txtResultCellRef.Enabled = False
        Me.txtResultCellRef.Location = New System.Drawing.Point(139, 3)
        Me.txtResultCellRef.Name = "txtResultCellRef"
        Me.txtResultCellRef.Size = New System.Drawing.Size(237, 22)
        Me.txtResultCellRef.TabIndex = 16
        '
        'lblResultStartCell
        '
        Me.lblResultStartCell.AutoSize = True
        Me.lblResultStartCell.Enabled = False
        Me.lblResultStartCell.Location = New System.Drawing.Point(15, 6)
        Me.lblResultStartCell.Name = "lblResultStartCell"
        Me.lblResultStartCell.Size = New System.Drawing.Size(117, 13)
        Me.lblResultStartCell.TabIndex = 14
        Me.lblResultStartCell.Text = "Result Area Start Cell:"
        '
        'cmdHelp
        '
        Me.cmdHelp.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdHelp.Location = New System.Drawing.Point(35, 675)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(75, 22)
        Me.cmdHelp.TabIndex = 20
        Me.cmdHelp.Text = "&Help"
        Me.cmdHelp.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmdResultCellRef)
        Me.Panel2.Controls.Add(Me.txtResultCellRef)
        Me.Panel2.Controls.Add(Me.lblResultStartCell)
        Me.Panel2.Location = New System.Drawing.Point(35, 154)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(415, 35)
        Me.Panel2.TabIndex = 99
        '
        'cmdResultCellRef
        '
        Me.cmdResultCellRef.BackgroundImage = Global.EnergizerV2.My.Resources.Resources.iconZoom
        Me.cmdResultCellRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdResultCellRef.Enabled = False
        Me.cmdResultCellRef.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdResultCellRef.Location = New System.Drawing.Point(371, 0)
        Me.cmdResultCellRef.Name = "cmdResultCellRef"
        Me.cmdResultCellRef.Size = New System.Drawing.Size(25, 25)
        Me.cmdResultCellRef.TabIndex = 65
        Me.cmdResultCellRef.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.lblMcdaDesc)
        Me.Panel1.Controls.Add(Me.lblStep1Desc)
        Me.Panel1.Controls.Add(Me.cmdLoad)
        Me.Panel1.Controls.Add(Me.lblStep1)
        Me.Panel1.Controls.Add(Me.txtAltCount)
        Me.Panel1.Controls.Add(Me.cmdResetAll)
        Me.Panel1.Controls.Add(Me.txtCritCount)
        Me.Panel1.Controls.Add(Me.cmdSave)
        Me.Panel1.Controls.Add(Me.lblAltCount)
        Me.Panel1.Controls.Add(Me.cmdMcdaOptions)
        Me.Panel1.Controls.Add(Me.lblCritCount)
        Me.Panel1.Controls.Add(Me.lblMcdaMethod)
        Me.Panel1.Controls.Add(Me.cmdMatrixCellRef)
        Me.Panel1.Controls.Add(Me.grpCritSection)
        Me.Panel1.Controls.Add(Me.cboMcdaMethod)
        Me.Panel1.Controls.Add(Me.grpAltSection)
        Me.Panel1.Controls.Add(Me.txtMatrixCellRef)
        Me.Panel1.Controls.Add(Me.lblMatrixCellRef)
        Me.Panel1.Location = New System.Drawing.Point(12, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 650)
        Me.Panel1.TabIndex = 99
        '
        'lblMatrixCellRef
        '
        Me.lblMatrixCellRef.AutoSize = True
        Me.lblMatrixCellRef.Location = New System.Drawing.Point(37, 108)
        Me.lblMatrixCellRef.Name = "lblMatrixCellRef"
        Me.lblMatrixCellRef.Size = New System.Drawing.Size(118, 13)
        Me.lblMatrixCellRef.TabIndex = 15
        Me.lblMatrixCellRef.Text = "Matrix Cell Reference:"
        '
        'txtMatrixCellRef
        '
        Me.txtMatrixCellRef.Location = New System.Drawing.Point(161, 105)
        Me.txtMatrixCellRef.Name = "txtMatrixCellRef"
        Me.txtMatrixCellRef.Size = New System.Drawing.Size(237, 22)
        Me.txtMatrixCellRef.TabIndex = 1
        '
        'cmdAltListDelete
        '
        Me.cmdAltListDelete.Enabled = False
        Me.cmdAltListDelete.Location = New System.Drawing.Point(20, 288)
        Me.cmdAltListDelete.Name = "cmdAltListDelete"
        Me.cmdAltListDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdAltListDelete.TabIndex = 6
        Me.cmdAltListDelete.Text = "Delete"
        Me.cmdAltListDelete.UseVisualStyleBackColor = True
        '
        'cmdAltListChange
        '
        Me.cmdAltListChange.Enabled = False
        Me.cmdAltListChange.Location = New System.Drawing.Point(20, 259)
        Me.cmdAltListChange.Name = "cmdAltListChange"
        Me.cmdAltListChange.Size = New System.Drawing.Size(75, 23)
        Me.cmdAltListChange.TabIndex = 5
        Me.cmdAltListChange.Text = "Change"
        Me.cmdAltListChange.UseVisualStyleBackColor = True
        '
        'cmdAltListUp
        '
        Me.cmdAltListUp.Enabled = False
        Me.cmdAltListUp.Location = New System.Drawing.Point(101, 230)
        Me.cmdAltListUp.Name = "cmdAltListUp"
        Me.cmdAltListUp.Size = New System.Drawing.Size(75, 36)
        Me.cmdAltListUp.TabIndex = 7
        Me.cmdAltListUp.Text = "▲"
        Me.cmdAltListUp.UseVisualStyleBackColor = True
        '
        'cmdAltListAdd
        '
        Me.cmdAltListAdd.Location = New System.Drawing.Point(20, 230)
        Me.cmdAltListAdd.Name = "cmdAltListAdd"
        Me.cmdAltListAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAltListAdd.TabIndex = 4
        Me.cmdAltListAdd.Text = "Add"
        Me.cmdAltListAdd.UseVisualStyleBackColor = True
        '
        'cmdAltListDown
        '
        Me.cmdAltListDown.Enabled = False
        Me.cmdAltListDown.Location = New System.Drawing.Point(101, 275)
        Me.cmdAltListDown.Name = "cmdAltListDown"
        Me.cmdAltListDown.Size = New System.Drawing.Size(75, 36)
        Me.cmdAltListDown.TabIndex = 8
        Me.cmdAltListDown.Text = "▼"
        Me.cmdAltListDown.UseVisualStyleBackColor = True
        '
        'chkAltUniqueNames
        '
        Me.chkAltUniqueNames.AutoSize = True
        Me.chkAltUniqueNames.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAltUniqueNames.Enabled = False
        Me.chkAltUniqueNames.Location = New System.Drawing.Point(20, 195)
        Me.chkAltUniqueNames.Name = "chkAltUniqueNames"
        Me.chkAltUniqueNames.Size = New System.Drawing.Size(144, 30)
        Me.chkAltUniqueNames.TabIndex = 99
        Me.chkAltUniqueNames.TabStop = False
        Me.chkAltUniqueNames.Text = "Alternatives must have " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "unique names"
        Me.chkAltUniqueNames.UseVisualStyleBackColor = True
        '
        'lstAltList
        '
        Me.lstAltList.FormattingEnabled = True
        Me.lstAltList.Location = New System.Drawing.Point(20, 25)
        Me.lstAltList.Name = "lstAltList"
        Me.lstAltList.ScrollAlwaysVisible = True
        Me.lstAltList.Size = New System.Drawing.Size(156, 160)
        Me.lstAltList.TabIndex = 3
        '
        'grpAltSection
        '
        Me.grpAltSection.Controls.Add(Me.lstAltList)
        Me.grpAltSection.Controls.Add(Me.chkAltUniqueNames)
        Me.grpAltSection.Controls.Add(Me.cmdAltListDown)
        Me.grpAltSection.Controls.Add(Me.cmdAltListAdd)
        Me.grpAltSection.Controls.Add(Me.cmdAltListUp)
        Me.grpAltSection.Controls.Add(Me.cmdAltListChange)
        Me.grpAltSection.Controls.Add(Me.cmdAltListDelete)
        Me.grpAltSection.Location = New System.Drawing.Point(22, 176)
        Me.grpAltSection.Name = "grpAltSection"
        Me.grpAltSection.Size = New System.Drawing.Size(200, 325)
        Me.grpAltSection.TabIndex = 99
        Me.grpAltSection.TabStop = False
        Me.grpAltSection.Text = "List of Alternatives"
        '
        'cboMcdaMethod
        '
        Me.cboMcdaMethod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboMcdaMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMcdaMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMcdaMethod.FormattingEnabled = True
        Me.cboMcdaMethod.Location = New System.Drawing.Point(163, 513)
        Me.cboMcdaMethod.Name = "cboMcdaMethod"
        Me.cboMcdaMethod.Size = New System.Drawing.Size(162, 21)
        Me.cboMcdaMethod.TabIndex = 15
        '
        'cmdCritListDelete
        '
        Me.cmdCritListDelete.Enabled = False
        Me.cmdCritListDelete.Location = New System.Drawing.Point(20, 288)
        Me.cmdCritListDelete.Name = "cmdCritListDelete"
        Me.cmdCritListDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdCritListDelete.TabIndex = 12
        Me.cmdCritListDelete.Text = "Delete"
        Me.cmdCritListDelete.UseVisualStyleBackColor = True
        '
        'cmdCritListChange
        '
        Me.cmdCritListChange.Enabled = False
        Me.cmdCritListChange.Location = New System.Drawing.Point(20, 259)
        Me.cmdCritListChange.Name = "cmdCritListChange"
        Me.cmdCritListChange.Size = New System.Drawing.Size(75, 23)
        Me.cmdCritListChange.TabIndex = 11
        Me.cmdCritListChange.Text = "Change"
        Me.cmdCritListChange.UseVisualStyleBackColor = True
        '
        'cmdCritListAdd
        '
        Me.cmdCritListAdd.Location = New System.Drawing.Point(20, 230)
        Me.cmdCritListAdd.Name = "cmdCritListAdd"
        Me.cmdCritListAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdCritListAdd.TabIndex = 10
        Me.cmdCritListAdd.Text = "Add"
        Me.cmdCritListAdd.UseVisualStyleBackColor = True
        '
        'cmdCritListUp
        '
        Me.cmdCritListUp.Enabled = False
        Me.cmdCritListUp.Location = New System.Drawing.Point(101, 230)
        Me.cmdCritListUp.Name = "cmdCritListUp"
        Me.cmdCritListUp.Size = New System.Drawing.Size(75, 36)
        Me.cmdCritListUp.TabIndex = 13
        Me.cmdCritListUp.Text = "▲"
        Me.cmdCritListUp.UseVisualStyleBackColor = True
        '
        'cmdCritListDown
        '
        Me.cmdCritListDown.Enabled = False
        Me.cmdCritListDown.Location = New System.Drawing.Point(101, 275)
        Me.cmdCritListDown.Name = "cmdCritListDown"
        Me.cmdCritListDown.Size = New System.Drawing.Size(75, 36)
        Me.cmdCritListDown.TabIndex = 14
        Me.cmdCritListDown.Text = "▼"
        Me.cmdCritListDown.UseVisualStyleBackColor = True
        '
        'chkCritUniqueNames
        '
        Me.chkCritUniqueNames.AutoSize = True
        Me.chkCritUniqueNames.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkCritUniqueNames.Enabled = False
        Me.chkCritUniqueNames.Location = New System.Drawing.Point(20, 195)
        Me.chkCritUniqueNames.Name = "chkCritUniqueNames"
        Me.chkCritUniqueNames.Size = New System.Drawing.Size(121, 30)
        Me.chkCritUniqueNames.TabIndex = 99
        Me.chkCritUniqueNames.TabStop = False
        Me.chkCritUniqueNames.Text = "Criteria must have " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "unique names"
        Me.chkCritUniqueNames.UseVisualStyleBackColor = True
        '
        'lstCritList
        '
        Me.lstCritList.FormattingEnabled = True
        Me.lstCritList.Location = New System.Drawing.Point(20, 25)
        Me.lstCritList.Name = "lstCritList"
        Me.lstCritList.ScrollAlwaysVisible = True
        Me.lstCritList.Size = New System.Drawing.Size(156, 160)
        Me.lstCritList.TabIndex = 9
        '
        'grpCritSection
        '
        Me.grpCritSection.Controls.Add(Me.lstCritList)
        Me.grpCritSection.Controls.Add(Me.chkCritUniqueNames)
        Me.grpCritSection.Controls.Add(Me.cmdCritListDown)
        Me.grpCritSection.Controls.Add(Me.cmdCritListUp)
        Me.grpCritSection.Controls.Add(Me.cmdCritListAdd)
        Me.grpCritSection.Controls.Add(Me.cmdCritListChange)
        Me.grpCritSection.Controls.Add(Me.cmdCritListDelete)
        Me.grpCritSection.Location = New System.Drawing.Point(237, 176)
        Me.grpCritSection.Name = "grpCritSection"
        Me.grpCritSection.Size = New System.Drawing.Size(200, 325)
        Me.grpCritSection.TabIndex = 99
        Me.grpCritSection.TabStop = False
        Me.grpCritSection.Text = "List of Criteria"
        '
        'cmdMatrixCellRef
        '
        Me.cmdMatrixCellRef.BackColor = System.Drawing.SystemColors.Control
        Me.cmdMatrixCellRef.BackgroundImage = Global.EnergizerV2.My.Resources.Resources.iconTableSelect
        Me.cmdMatrixCellRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdMatrixCellRef.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMatrixCellRef.Location = New System.Drawing.Point(393, 103)
        Me.cmdMatrixCellRef.Name = "cmdMatrixCellRef"
        Me.cmdMatrixCellRef.Size = New System.Drawing.Size(25, 25)
        Me.cmdMatrixCellRef.TabIndex = 2
        Me.cmdMatrixCellRef.UseVisualStyleBackColor = True
        '
        'lblMcdaMethod
        '
        Me.lblMcdaMethod.AutoSize = True
        Me.lblMcdaMethod.Location = New System.Drawing.Point(39, 516)
        Me.lblMcdaMethod.Name = "lblMcdaMethod"
        Me.lblMcdaMethod.Size = New System.Drawing.Size(86, 13)
        Me.lblMcdaMethod.TabIndex = 99
        Me.lblMcdaMethod.Text = "MCDA Method:"
        '
        'lblCritCount
        '
        Me.lblCritCount.AutoSize = True
        Me.lblCritCount.Enabled = False
        Me.lblCritCount.Location = New System.Drawing.Point(254, 146)
        Me.lblCritCount.Name = "lblCritCount"
        Me.lblCritCount.Size = New System.Drawing.Size(82, 13)
        Me.lblCritCount.TabIndex = 99
        Me.lblCritCount.Text = "Criteria Count:"
        '
        'cmdMcdaOptions
        '
        Me.cmdMcdaOptions.Enabled = False
        Me.cmdMcdaOptions.Location = New System.Drawing.Point(342, 511)
        Me.cmdMcdaOptions.Name = "cmdMcdaOptions"
        Me.cmdMcdaOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdMcdaOptions.TabIndex = 16
        Me.cmdMcdaOptions.Text = "Options"
        Me.cmdMcdaOptions.UseVisualStyleBackColor = True
        '
        'lblAltCount
        '
        Me.lblAltCount.AutoSize = True
        Me.lblAltCount.Enabled = False
        Me.lblAltCount.Location = New System.Drawing.Point(37, 146)
        Me.lblAltCount.Name = "lblAltCount"
        Me.lblAltCount.Size = New System.Drawing.Size(105, 13)
        Me.lblAltCount.TabIndex = 99
        Me.lblAltCount.Text = "Alternatives Count:"
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSave.Location = New System.Drawing.Point(23, 613)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 22)
        Me.cmdSave.TabIndex = 17
        Me.cmdSave.Text = "&Save to Sheet"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'txtCritCount
        '
        Me.txtCritCount.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCritCount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCritCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCritCount.Enabled = False
        Me.txtCritCount.Location = New System.Drawing.Point(383, 146)
        Me.txtCritCount.Name = "txtCritCount"
        Me.txtCritCount.ReadOnly = True
        Me.txtCritCount.Size = New System.Drawing.Size(30, 15)
        Me.txtCritCount.TabIndex = 99
        Me.txtCritCount.TabStop = False
        '
        'cmdResetAll
        '
        Me.cmdResetAll.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdResetAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdResetAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdResetAll.Location = New System.Drawing.Point(363, 613)
        Me.cmdResetAll.Name = "cmdResetAll"
        Me.cmdResetAll.Size = New System.Drawing.Size(75, 22)
        Me.cmdResetAll.TabIndex = 19
        Me.cmdResetAll.Text = "Reset All"
        Me.cmdResetAll.UseMnemonic = False
        Me.cmdResetAll.UseVisualStyleBackColor = False
        '
        'txtAltCount
        '
        Me.txtAltCount.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtAltCount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAltCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAltCount.Enabled = False
        Me.txtAltCount.HideSelection = False
        Me.txtAltCount.Location = New System.Drawing.Point(168, 146)
        Me.txtAltCount.Name = "txtAltCount"
        Me.txtAltCount.ReadOnly = True
        Me.txtAltCount.Size = New System.Drawing.Size(30, 15)
        Me.txtAltCount.TabIndex = 99
        Me.txtAltCount.TabStop = False
        '
        'lblStep1
        '
        Me.lblStep1.AutoSize = True
        Me.lblStep1.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblStep1.Location = New System.Drawing.Point(7, 10)
        Me.lblStep1.Name = "lblStep1"
        Me.lblStep1.Size = New System.Drawing.Size(202, 17)
        Me.lblStep1.TabIndex = 99
        Me.lblStep1.Text = "Step 1: Set up decision problem"
        '
        'cmdLoad
        '
        Me.cmdLoad.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdLoad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLoad.Location = New System.Drawing.Point(129, 613)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(100, 22)
        Me.cmdLoad.TabIndex = 18
        Me.cmdLoad.Text = "&Load from Sheet"
        Me.cmdLoad.UseVisualStyleBackColor = False
        '
        'lblStep1Desc
        '
        Me.lblStep1Desc.AutoEllipsis = True
        Me.lblStep1Desc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep1Desc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStep1Desc.Location = New System.Drawing.Point(7, 38)
        Me.lblStep1Desc.Name = "lblStep1Desc"
        Me.lblStep1Desc.Size = New System.Drawing.Size(416, 49)
        Me.lblStep1Desc.TabIndex = 99
        Me.lblStep1Desc.Text = "The first step is to define the starting cell of the decision matrix on the sheet" &
    " and enter the names of the criteria and alternatives. These can be changed late" &
    "r if needed." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblMcdaDesc
        '
        Me.lblMcdaDesc.Font = New System.Drawing.Font("Segoe UI", 7.25!)
        Me.lblMcdaDesc.Location = New System.Drawing.Point(25, 542)
        Me.lblMcdaDesc.Name = "lblMcdaDesc"
        Me.lblMcdaDesc.Size = New System.Drawing.Size(412, 68)
        Me.lblMcdaDesc.TabIndex = 99
        '
        'FStep1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(484, 711)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FStep1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENERGIZER"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpAltSection.ResumeLayout(False)
        Me.grpAltSection.PerformLayout()
        Me.grpCritSection.ResumeLayout(False)
        Me.grpCritSection.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdHelp As Windows.Forms.Button
    Friend WithEvents cmdCancel As Windows.Forms.Button
    Friend WithEvents cmdNext As Windows.Forms.Button
    Friend WithEvents txtResultCellRef As Windows.Forms.TextBox
    Friend WithEvents lblResultStartCell As Windows.Forms.Label
    Friend WithEvents cmdResultCellRef As Windows.Forms.Button
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents lblMcdaDesc As Windows.Forms.Label
    Friend WithEvents lblStep1Desc As Windows.Forms.Label
    Friend WithEvents cmdLoad As Windows.Forms.Button
    Friend WithEvents lblStep1 As Windows.Forms.Label
    Friend WithEvents txtAltCount As Windows.Forms.TextBox
    Friend WithEvents cmdResetAll As Windows.Forms.Button
    Friend WithEvents txtCritCount As Windows.Forms.TextBox
    Friend WithEvents cmdSave As Windows.Forms.Button
    Friend WithEvents lblAltCount As Windows.Forms.Label
    Friend WithEvents cmdMcdaOptions As Windows.Forms.Button
    Friend WithEvents lblCritCount As Windows.Forms.Label
    Friend WithEvents lblMcdaMethod As Windows.Forms.Label
    Friend WithEvents cmdMatrixCellRef As Windows.Forms.Button
    Friend WithEvents grpCritSection As Windows.Forms.GroupBox
    Friend WithEvents lstCritList As Windows.Forms.ListBox
    Friend WithEvents chkCritUniqueNames As Windows.Forms.CheckBox
    Friend WithEvents cmdCritListDown As Windows.Forms.Button
    Friend WithEvents cmdCritListUp As Windows.Forms.Button
    Friend WithEvents cmdCritListAdd As Windows.Forms.Button
    Friend WithEvents cmdCritListChange As Windows.Forms.Button
    Friend WithEvents cmdCritListDelete As Windows.Forms.Button
    Friend WithEvents cboMcdaMethod As Windows.Forms.ComboBox
    Friend WithEvents grpAltSection As Windows.Forms.GroupBox
    Friend WithEvents lstAltList As Windows.Forms.ListBox
    Friend WithEvents chkAltUniqueNames As Windows.Forms.CheckBox
    Friend WithEvents cmdAltListDown As Windows.Forms.Button
    Friend WithEvents cmdAltListAdd As Windows.Forms.Button
    Friend WithEvents cmdAltListUp As Windows.Forms.Button
    Friend WithEvents cmdAltListChange As Windows.Forms.Button
    Friend WithEvents cmdAltListDelete As Windows.Forms.Button
    Friend WithEvents txtMatrixCellRef As Windows.Forms.TextBox
    Friend WithEvents lblMatrixCellRef As Windows.Forms.Label
End Class
