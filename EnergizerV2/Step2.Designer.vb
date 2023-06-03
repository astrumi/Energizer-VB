<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FStep2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FStep2))
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.lstCritSelect = New System.Windows.Forms.ListBox()
        Me.tabStep2 = New System.Windows.Forms.TabControl()
        Me.tabStep2a = New System.Windows.Forms.TabPage()
        Me.cmdTableReset = New System.Windows.Forms.Button()
        Me.lblMid = New System.Windows.Forms.Label()
        Me.tblAltValues = New System.Windows.Forms.TableLayoutPanel()
        Me.lblOption3 = New System.Windows.Forms.Label()
        Me.lblOption2 = New System.Windows.Forms.Label()
        Me.lblOption = New System.Windows.Forms.Label()
        Me.lblNode = New System.Windows.Forms.Label()
        Me.lblOption1 = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.cmdTableLoad = New System.Windows.Forms.Button()
        Me.cmdTableSave = New System.Windows.Forms.Button()
        Me.tabStep2b = New System.Windows.Forms.TabPage()
        Me.lblRankDesc4 = New System.Windows.Forms.Label()
        Me.lblRankDesc6 = New System.Windows.Forms.Label()
        Me.lblRankDesc2 = New System.Windows.Forms.Label()
        Me.lblRankDesc3 = New System.Windows.Forms.Label()
        Me.lblRankDesc7 = New System.Windows.Forms.Label()
        Me.lblRankDesc5 = New System.Windows.Forms.Label()
        Me.lblRankDesc1 = New System.Windows.Forms.Label()
        Me.pnlRankingLadder = New System.Windows.Forms.Panel()
        Me.lblTrackTick5 = New System.Windows.Forms.Label()
        Me.lblTrackTick2 = New System.Windows.Forms.Label()
        Me.lblTrackTick4 = New System.Windows.Forms.Label()
        Me.lblTrackTick3 = New System.Windows.Forms.Label()
        Me.lblTrackTick1 = New System.Windows.Forms.Label()
        Me.picLineTrack = New System.Windows.Forms.PictureBox()
        Me.pnlRankingLadderLoc = New System.Windows.Forms.Panel()
        Me.cmdRankingReset = New System.Windows.Forms.Button()
        Me.cmdRankingSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.pnlStep2 = New System.Windows.Forms.Panel()
        Me.lblStep2DescMinor = New System.Windows.Forms.Label()
        Me.lblStep2Desc = New System.Windows.Forms.Label()
        Me.lblStep2 = New System.Windows.Forms.Label()
        Me.tabStep2.SuspendLayout()
        Me.tabStep2a.SuspendLayout()
        Me.tabStep2b.SuspendLayout()
        Me.pnlRankingLadder.SuspendLayout()
        CType(Me.picLineTrack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStep2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdHelp
        '
        Me.cmdHelp.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelp.Location = New System.Drawing.Point(35, 675)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdHelp.TabIndex = 15
        Me.cmdHelp.Text = "&Help"
        Me.cmdHelp.UseVisualStyleBackColor = False
        '
        'cmdBack
        '
        Me.cmdBack.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBack.Location = New System.Drawing.Point(494, 675)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(75, 23)
        Me.cmdBack.TabIndex = 16
        Me.cmdBack.Text = "< Back"
        Me.cmdBack.UseMnemonic = False
        Me.cmdBack.UseVisualStyleBackColor = False
        '
        'cmdNext
        '
        Me.cmdNext.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNext.Location = New System.Drawing.Point(575, 675)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(75, 23)
        Me.cmdNext.TabIndex = 17
        Me.cmdNext.Text = "Next >"
        Me.cmdNext.UseMnemonic = False
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'lstCritSelect
        '
        Me.lstCritSelect.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lstCritSelect.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCritSelect.FormattingEnabled = True
        Me.lstCritSelect.HorizontalScrollbar = True
        Me.lstCritSelect.ItemHeight = 17
        Me.lstCritSelect.Location = New System.Drawing.Point(25, 100)
        Me.lstCritSelect.Name = "lstCritSelect"
        Me.lstCritSelect.Size = New System.Drawing.Size(150, 531)
        Me.lstCritSelect.TabIndex = 0
        '
        'tabStep2
        '
        Me.tabStep2.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.tabStep2.Controls.Add(Me.tabStep2a)
        Me.tabStep2.Controls.Add(Me.tabStep2b)
        Me.tabStep2.Location = New System.Drawing.Point(190, 100)
        Me.tabStep2.Multiline = True
        Me.tabStep2.Name = "tabStep2"
        Me.tabStep2.SelectedIndex = 0
        Me.tabStep2.Size = New System.Drawing.Size(450, 480)
        Me.tabStep2.TabIndex = 0
        '
        'tabStep2a
        '
        Me.tabStep2a.AutoScroll = True
        Me.tabStep2a.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tabStep2a.Controls.Add(Me.cmdTableReset)
        Me.tabStep2a.Controls.Add(Me.lblMid)
        Me.tabStep2a.Controls.Add(Me.tblAltValues)
        Me.tabStep2a.Controls.Add(Me.lblOption3)
        Me.tabStep2a.Controls.Add(Me.lblOption2)
        Me.tabStep2a.Controls.Add(Me.lblOption)
        Me.tabStep2a.Controls.Add(Me.lblNode)
        Me.tabStep2a.Controls.Add(Me.lblOption1)
        Me.tabStep2a.Controls.Add(Me.lblMin)
        Me.tabStep2a.Controls.Add(Me.lblMax)
        Me.tabStep2a.Controls.Add(Me.lblDivider)
        Me.tabStep2a.Controls.Add(Me.cmdTableLoad)
        Me.tabStep2a.Controls.Add(Me.cmdTableSave)
        Me.tabStep2a.Location = New System.Drawing.Point(4, 4)
        Me.tabStep2a.Name = "tabStep2a"
        Me.tabStep2a.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStep2a.Size = New System.Drawing.Size(442, 454)
        Me.tabStep2a.TabIndex = 0
        Me.tabStep2a.Text = "Table view"
        '
        'cmdTableReset
        '
        Me.cmdTableReset.Location = New System.Drawing.Point(259, 410)
        Me.cmdTableReset.Name = "cmdTableReset"
        Me.cmdTableReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdTableReset.TabIndex = 68
        Me.cmdTableReset.Text = "Reset"
        Me.cmdTableReset.UseVisualStyleBackColor = True
        '
        'lblMid
        '
        Me.lblMid.AutoSize = True
        Me.lblMid.Location = New System.Drawing.Point(299, 28)
        Me.lblMid.Name = "lblMid"
        Me.lblMid.Size = New System.Drawing.Size(27, 13)
        Me.lblMid.TabIndex = 6
        Me.lblMid.Text = "Mid"
        '
        'tblAltValues
        '
        Me.tblAltValues.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblAltValues.AutoScroll = True
        Me.tblAltValues.AutoSize = True
        Me.tblAltValues.ColumnCount = 5
        Me.tblAltValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblAltValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblAltValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.tblAltValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.tblAltValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.tblAltValues.Location = New System.Drawing.Point(21, 58)
        Me.tblAltValues.Margin = New System.Windows.Forms.Padding(1)
        Me.tblAltValues.Name = "tblAltValues"
        Me.tblAltValues.RowCount = 1
        Me.tblAltValues.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblAltValues.Size = New System.Drawing.Size(400, 340)
        Me.tblAltValues.TabIndex = 1
        '
        'lblOption3
        '
        Me.lblOption3.AutoSize = True
        Me.lblOption3.Location = New System.Drawing.Point(179, 28)
        Me.lblOption3.Name = "lblOption3"
        Me.lblOption3.Size = New System.Drawing.Size(13, 13)
        Me.lblOption3.TabIndex = 10
        Me.lblOption3.Text = "3"
        '
        'lblOption2
        '
        Me.lblOption2.AutoSize = True
        Me.lblOption2.Location = New System.Drawing.Point(159, 28)
        Me.lblOption2.Name = "lblOption2"
        Me.lblOption2.Size = New System.Drawing.Size(13, 13)
        Me.lblOption2.TabIndex = 9
        Me.lblOption2.Text = "2"
        '
        'lblOption
        '
        Me.lblOption.AutoSize = True
        Me.lblOption.Location = New System.Drawing.Point(141, 12)
        Me.lblOption.Name = "lblOption"
        Me.lblOption.Size = New System.Drawing.Size(49, 13)
        Me.lblOption.TabIndex = 7
        Me.lblOption.Text = "Options"
        '
        'lblNode
        '
        Me.lblNode.AutoSize = True
        Me.lblNode.Location = New System.Drawing.Point(23, 28)
        Me.lblNode.Name = "lblNode"
        Me.lblNode.Size = New System.Drawing.Size(35, 13)
        Me.lblNode.TabIndex = 7
        Me.lblNode.Text = "Node"
        '
        'lblOption1
        '
        Me.lblOption1.AutoSize = True
        Me.lblOption1.Location = New System.Drawing.Point(139, 28)
        Me.lblOption1.Name = "lblOption1"
        Me.lblOption1.Size = New System.Drawing.Size(13, 13)
        Me.lblOption1.TabIndex = 8
        Me.lblOption1.Text = "1"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(225, 28)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(27, 13)
        Me.lblMin.TabIndex = 6
        Me.lblMin.Text = "Min"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(369, 28)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(28, 13)
        Me.lblMax.TabIndex = 6
        Me.lblMax.Text = "Max"
        '
        'lblDivider
        '
        Me.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider.Location = New System.Drawing.Point(21, 48)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(400, 2)
        Me.lblDivider.TabIndex = 11
        '
        'cmdTableLoad
        '
        Me.cmdTableLoad.Location = New System.Drawing.Point(27, 410)
        Me.cmdTableLoad.Name = "cmdTableLoad"
        Me.cmdTableLoad.Size = New System.Drawing.Size(75, 23)
        Me.cmdTableLoad.TabIndex = 67
        Me.cmdTableLoad.Text = "Load"
        Me.cmdTableLoad.UseVisualStyleBackColor = True
        '
        'cmdTableSave
        '
        Me.cmdTableSave.Location = New System.Drawing.Point(340, 410)
        Me.cmdTableSave.Name = "cmdTableSave"
        Me.cmdTableSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdTableSave.TabIndex = 67
        Me.cmdTableSave.Text = "Save"
        Me.cmdTableSave.UseVisualStyleBackColor = True
        '
        'tabStep2b
        '
        Me.tabStep2b.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tabStep2b.Controls.Add(Me.lblRankDesc4)
        Me.tabStep2b.Controls.Add(Me.lblRankDesc6)
        Me.tabStep2b.Controls.Add(Me.lblRankDesc2)
        Me.tabStep2b.Controls.Add(Me.lblRankDesc3)
        Me.tabStep2b.Controls.Add(Me.lblRankDesc7)
        Me.tabStep2b.Controls.Add(Me.lblRankDesc5)
        Me.tabStep2b.Controls.Add(Me.lblRankDesc1)
        Me.tabStep2b.Controls.Add(Me.pnlRankingLadder)
        Me.tabStep2b.Controls.Add(Me.pnlRankingLadderLoc)
        Me.tabStep2b.Controls.Add(Me.cmdRankingReset)
        Me.tabStep2b.Controls.Add(Me.cmdRankingSave)
        Me.tabStep2b.Location = New System.Drawing.Point(4, 4)
        Me.tabStep2b.Name = "tabStep2b"
        Me.tabStep2b.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStep2b.Size = New System.Drawing.Size(442, 454)
        Me.tabStep2b.TabIndex = 1
        Me.tabStep2b.Text = "Ranking ladder"
        '
        'lblRankDesc4
        '
        Me.lblRankDesc4.AutoSize = True
        Me.lblRankDesc4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRankDesc4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblRankDesc4.Location = New System.Drawing.Point(33, 200)
        Me.lblRankDesc4.Name = "lblRankDesc4"
        Me.lblRankDesc4.Size = New System.Drawing.Size(45, 13)
        Me.lblRankDesc4.TabIndex = 11
        Me.lblRankDesc4.Text = "Average"
        Me.lblRankDesc4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRankDesc6
        '
        Me.lblRankDesc6.AutoSize = True
        Me.lblRankDesc6.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRankDesc6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblRankDesc6.Location = New System.Drawing.Point(26, 304)
        Me.lblRankDesc6.Name = "lblRankDesc6"
        Me.lblRankDesc6.Size = New System.Drawing.Size(51, 36)
        Me.lblRankDesc6.TabIndex = 11
        Me.lblRankDesc6.Text = "Significantly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Below" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Average"
        Me.lblRankDesc6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRankDesc2
        '
        Me.lblRankDesc2.AutoSize = True
        Me.lblRankDesc2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRankDesc2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblRankDesc2.Location = New System.Drawing.Point(26, 77)
        Me.lblRankDesc2.Name = "lblRankDesc2"
        Me.lblRankDesc2.Size = New System.Drawing.Size(51, 36)
        Me.lblRankDesc2.TabIndex = 11
        Me.lblRankDesc2.Text = "Significantly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Above" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Average"
        Me.lblRankDesc2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRankDesc3
        '
        Me.lblRankDesc3.AutoSize = True
        Me.lblRankDesc3.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRankDesc3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblRankDesc3.Location = New System.Drawing.Point(41, 150)
        Me.lblRankDesc3.Name = "lblRankDesc3"
        Me.lblRankDesc3.Size = New System.Drawing.Size(36, 36)
        Me.lblRankDesc3.TabIndex = 11
        Me.lblRankDesc3.Text = "Slightly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Above" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Average"
        Me.lblRankDesc3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRankDesc7
        '
        Me.lblRankDesc7.AutoSize = True
        Me.lblRankDesc7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRankDesc7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblRankDesc7.Location = New System.Drawing.Point(65, 371)
        Me.lblRankDesc7.Name = "lblRankDesc7"
        Me.lblRankDesc7.Size = New System.Drawing.Size(72, 13)
        Me.lblRankDesc7.TabIndex = 11
        Me.lblRankDesc7.Text = "Ranked Worst"
        '
        'lblRankDesc5
        '
        Me.lblRankDesc5.AutoSize = True
        Me.lblRankDesc5.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRankDesc5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblRankDesc5.Location = New System.Drawing.Point(41, 229)
        Me.lblRankDesc5.Name = "lblRankDesc5"
        Me.lblRankDesc5.Size = New System.Drawing.Size(36, 36)
        Me.lblRankDesc5.TabIndex = 11
        Me.lblRankDesc5.Text = "Slightly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Below" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Average"
        Me.lblRankDesc5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRankDesc1
        '
        Me.lblRankDesc1.AutoSize = True
        Me.lblRankDesc1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRankDesc1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblRankDesc1.Location = New System.Drawing.Point(67, 32)
        Me.lblRankDesc1.Name = "lblRankDesc1"
        Me.lblRankDesc1.Size = New System.Drawing.Size(63, 13)
        Me.lblRankDesc1.TabIndex = 11
        Me.lblRankDesc1.Text = "Ranked Best"
        Me.lblRankDesc1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlRankingLadder
        '
        Me.pnlRankingLadder.AutoScroll = True
        Me.pnlRankingLadder.Controls.Add(Me.lblTrackTick5)
        Me.pnlRankingLadder.Controls.Add(Me.lblTrackTick2)
        Me.pnlRankingLadder.Controls.Add(Me.lblTrackTick4)
        Me.pnlRankingLadder.Controls.Add(Me.lblTrackTick3)
        Me.pnlRankingLadder.Controls.Add(Me.lblTrackTick1)
        Me.pnlRankingLadder.Controls.Add(Me.picLineTrack)
        Me.pnlRankingLadder.Location = New System.Drawing.Point(80, 50)
        Me.pnlRankingLadder.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlRankingLadder.Name = "pnlRankingLadder"
        Me.pnlRankingLadder.Size = New System.Drawing.Size(150, 317)
        Me.pnlRankingLadder.TabIndex = 10
        '
        'lblTrackTick5
        '
        Me.lblTrackTick5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTrackTick5.Location = New System.Drawing.Point(0, 315)
        Me.lblTrackTick5.Name = "lblTrackTick5"
        Me.lblTrackTick5.Size = New System.Drawing.Size(40, 2)
        Me.lblTrackTick5.TabIndex = 19
        '
        'lblTrackTick2
        '
        Me.lblTrackTick2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTrackTick2.Location = New System.Drawing.Point(0, 82)
        Me.lblTrackTick2.Name = "lblTrackTick2"
        Me.lblTrackTick2.Size = New System.Drawing.Size(40, 2)
        Me.lblTrackTick2.TabIndex = 14
        '
        'lblTrackTick4
        '
        Me.lblTrackTick4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTrackTick4.Location = New System.Drawing.Point(0, 232)
        Me.lblTrackTick4.Name = "lblTrackTick4"
        Me.lblTrackTick4.Size = New System.Drawing.Size(40, 2)
        Me.lblTrackTick4.TabIndex = 15
        '
        'lblTrackTick3
        '
        Me.lblTrackTick3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTrackTick3.Location = New System.Drawing.Point(0, 157)
        Me.lblTrackTick3.Name = "lblTrackTick3"
        Me.lblTrackTick3.Size = New System.Drawing.Size(40, 2)
        Me.lblTrackTick3.TabIndex = 16
        '
        'lblTrackTick1
        '
        Me.lblTrackTick1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTrackTick1.Location = New System.Drawing.Point(0, 2)
        Me.lblTrackTick1.Name = "lblTrackTick1"
        Me.lblTrackTick1.Size = New System.Drawing.Size(40, 2)
        Me.lblTrackTick1.TabIndex = 13
        '
        'picLineTrack
        '
        Me.picLineTrack.BackgroundImage = Global.EnergizerV2.My.Resources.Resources.grad4
        Me.picLineTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLineTrack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picLineTrack.Location = New System.Drawing.Point(15, 0)
        Me.picLineTrack.Name = "picLineTrack"
        Me.picLineTrack.Size = New System.Drawing.Size(10, 317)
        Me.picLineTrack.TabIndex = 20
        Me.picLineTrack.TabStop = False
        '
        'pnlRankingLadderLoc
        '
        Me.pnlRankingLadderLoc.AutoScroll = True
        Me.pnlRankingLadderLoc.Location = New System.Drawing.Point(236, 50)
        Me.pnlRankingLadderLoc.Name = "pnlRankingLadderLoc"
        Me.pnlRankingLadderLoc.Size = New System.Drawing.Size(175, 317)
        Me.pnlRankingLadderLoc.TabIndex = 10
        '
        'cmdRankingReset
        '
        Me.cmdRankingReset.Location = New System.Drawing.Point(259, 410)
        Me.cmdRankingReset.Name = "cmdRankingReset"
        Me.cmdRankingReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdRankingReset.TabIndex = 3
        Me.cmdRankingReset.Text = "Reset"
        Me.cmdRankingReset.UseVisualStyleBackColor = True
        '
        'cmdRankingSave
        '
        Me.cmdRankingSave.Location = New System.Drawing.Point(340, 410)
        Me.cmdRankingSave.Name = "cmdRankingSave"
        Me.cmdRankingSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdRankingSave.TabIndex = 2
        Me.cmdRankingSave.Text = "Save"
        Me.cmdRankingSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(413, 675)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 17
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseMnemonic = False
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'pnlStep2
        '
        Me.pnlStep2.BackColor = System.Drawing.SystemColors.Control
        Me.pnlStep2.Controls.Add(Me.lblStep2DescMinor)
        Me.pnlStep2.Controls.Add(Me.tabStep2)
        Me.pnlStep2.Controls.Add(Me.lblStep2Desc)
        Me.pnlStep2.Controls.Add(Me.lstCritSelect)
        Me.pnlStep2.Controls.Add(Me.lblStep2)
        Me.pnlStep2.Location = New System.Drawing.Point(12, 0)
        Me.pnlStep2.Name = "pnlStep2"
        Me.pnlStep2.Size = New System.Drawing.Size(660, 660)
        Me.pnlStep2.TabIndex = 68
        '
        'lblStep2DescMinor
        '
        Me.lblStep2DescMinor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep2DescMinor.Location = New System.Drawing.Point(190, 591)
        Me.lblStep2DescMinor.Name = "lblStep2DescMinor"
        Me.lblStep2DescMinor.Size = New System.Drawing.Size(450, 60)
        Me.lblStep2DescMinor.TabIndex = 67
        Me.lblStep2DescMinor.Text = "Describe the active method of input."
        '
        'lblStep2Desc
        '
        Me.lblStep2Desc.AutoEllipsis = True
        Me.lblStep2Desc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep2Desc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStep2Desc.Location = New System.Drawing.Point(22, 48)
        Me.lblStep2Desc.Name = "lblStep2Desc"
        Me.lblStep2Desc.Size = New System.Drawing.Size(618, 50)
        Me.lblStep2Desc.TabIndex = 66
        Me.lblStep2Desc.Text = "For each alternative, under each criterion, either enter 1-3 numbers representing" &
    " a quantitative assessment or rank the alternatives using the ranking ladder."
        '
        'lblStep2
        '
        Me.lblStep2.AutoSize = True
        Me.lblStep2.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblStep2.Location = New System.Drawing.Point(37, 23)
        Me.lblStep2.Name = "lblStep2"
        Me.lblStep2.Size = New System.Drawing.Size(182, 17)
        Me.lblStep2.TabIndex = 20
        Me.lblStep2.Text = "Step 2: Valuate Alternatives"
        '
        'FStep2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(684, 711)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.pnlStep2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FStep2"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENERGIZER"
        Me.tabStep2.ResumeLayout(False)
        Me.tabStep2a.ResumeLayout(False)
        Me.tabStep2a.PerformLayout()
        Me.tabStep2b.ResumeLayout(False)
        Me.tabStep2b.PerformLayout()
        Me.pnlRankingLadder.ResumeLayout(False)
        CType(Me.picLineTrack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStep2.ResumeLayout(False)
        Me.pnlStep2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdHelp As Windows.Forms.Button
    Friend WithEvents cmdBack As Windows.Forms.Button
    Friend WithEvents cmdNext As Windows.Forms.Button
    Friend WithEvents tabStep2 As Windows.Forms.TabControl
    Friend WithEvents tabStep2a As Windows.Forms.TabPage
    Friend WithEvents tabStep2b As Windows.Forms.TabPage
    Friend WithEvents lstCritSelect As Windows.Forms.ListBox
    Friend WithEvents lblMin As Windows.Forms.Label
    Friend WithEvents lblMid As Windows.Forms.Label
    Friend WithEvents lblMax As Windows.Forms.Label
    Friend WithEvents lblNode As Windows.Forms.Label
    Friend WithEvents lblOption1 As Windows.Forms.Label
    Friend WithEvents lblOption2 As Windows.Forms.Label
    Friend WithEvents lblOption3 As Windows.Forms.Label
    Friend WithEvents cmdCancel As Windows.Forms.Button
    Friend WithEvents cmdRankingReset As Windows.Forms.Button
    Friend WithEvents cmdRankingSave As Windows.Forms.Button
    Friend WithEvents pnlStep2 As Windows.Forms.Panel
    Friend WithEvents lblStep2Desc As Windows.Forms.Label
    Friend WithEvents lblStep2 As Windows.Forms.Label
    Friend WithEvents tblAltValues As Windows.Forms.TableLayoutPanel
    Friend WithEvents lblOption As Windows.Forms.Label
    Friend WithEvents lblDivider As Windows.Forms.Label
    Friend WithEvents pnlRankingLadderLoc As Windows.Forms.Panel
    Friend WithEvents lblRankDesc7 As Windows.Forms.Label
    Friend WithEvents lblRankDesc1 As Windows.Forms.Label
    Friend WithEvents pnlRankingLadder As Windows.Forms.Panel
    Friend WithEvents lblTrackTick5 As Windows.Forms.Label
    Friend WithEvents lblTrackTick2 As Windows.Forms.Label
    Friend WithEvents lblTrackTick4 As Windows.Forms.Label
    Friend WithEvents lblTrackTick3 As Windows.Forms.Label
    Friend WithEvents lblTrackTick1 As Windows.Forms.Label
    Friend WithEvents lblRankDesc4 As Windows.Forms.Label
    Friend WithEvents lblRankDesc6 As Windows.Forms.Label
    Friend WithEvents lblRankDesc2 As Windows.Forms.Label
    Friend WithEvents lblRankDesc3 As Windows.Forms.Label
    Friend WithEvents lblRankDesc5 As Windows.Forms.Label
    Friend WithEvents picLineTrack As Windows.Forms.PictureBox
    Friend WithEvents cmdTableReset As Windows.Forms.Button
    Friend WithEvents cmdTableSave As Windows.Forms.Button
    Friend WithEvents cmdTableLoad As Windows.Forms.Button
    Friend WithEvents lblStep2DescMinor As Windows.Forms.Label
End Class
