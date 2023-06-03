<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FStep2Ver2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FStep2Ver2))
        Me.flpCritList = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblStep2Desc = New System.Windows.Forms.Label()
        Me.lblStep2 = New System.Windows.Forms.Label()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.cmdLoadMain = New System.Windows.Forms.Button()
        Me.cmdSaveMain = New System.Windows.Forms.Button()
        Me.cmdResetMain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'flpCritList
        '
        Me.flpCritList.AutoScroll = True
        Me.flpCritList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpCritList.Location = New System.Drawing.Point(15, 100)
        Me.flpCritList.Name = "flpCritList"
        Me.flpCritList.Size = New System.Drawing.Size(485, 535)
        Me.flpCritList.TabIndex = 0
        Me.flpCritList.WrapContents = False
        '
        'lblStep2Desc
        '
        Me.lblStep2Desc.AutoEllipsis = True
        Me.lblStep2Desc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep2Desc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStep2Desc.Location = New System.Drawing.Point(19, 38)
        Me.lblStep2Desc.Name = "lblStep2Desc"
        Me.lblStep2Desc.Size = New System.Drawing.Size(416, 49)
        Me.lblStep2Desc.TabIndex = 68
        Me.lblStep2Desc.Text = "For each alternative, under each criterion, either enter 1-3 numbers representing" &
    " a quantitative assessment or rank the alternatives using the ranking ladder."
        '
        'lblStep2
        '
        Me.lblStep2.AutoSize = True
        Me.lblStep2.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblStep2.Location = New System.Drawing.Point(19, 10)
        Me.lblStep2.Name = "lblStep2"
        Me.lblStep2.Size = New System.Drawing.Size(182, 17)
        Me.lblStep2.TabIndex = 67
        Me.lblStep2.Text = "Step 2: Valuate Alternatives"
        '
        'cmdHelp
        '
        Me.cmdHelp.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelp.Location = New System.Drawing.Point(35, 725)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdHelp.TabIndex = 69
        Me.cmdHelp.Text = "&Help"
        Me.cmdHelp.UseVisualStyleBackColor = False
        '
        'cmdBack
        '
        Me.cmdBack.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBack.Location = New System.Drawing.Point(314, 725)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(75, 23)
        Me.cmdBack.TabIndex = 70
        Me.cmdBack.Text = "< Back"
        Me.cmdBack.UseMnemonic = False
        Me.cmdBack.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(233, 725)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 71
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseMnemonic = False
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdNext
        '
        Me.cmdNext.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNext.Location = New System.Drawing.Point(395, 725)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(75, 23)
        Me.cmdNext.TabIndex = 72
        Me.cmdNext.Text = "Next >"
        Me.cmdNext.UseMnemonic = False
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'cmdLoadMain
        '
        Me.cmdLoadMain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdLoadMain.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLoadMain.Location = New System.Drawing.Point(141, 665)
        Me.cmdLoadMain.Name = "cmdLoadMain"
        Me.cmdLoadMain.Size = New System.Drawing.Size(100, 23)
        Me.cmdLoadMain.TabIndex = 69
        Me.cmdLoadMain.Text = "&Load from Sheet"
        Me.cmdLoadMain.UseVisualStyleBackColor = False
        '
        'cmdSaveMain
        '
        Me.cmdSaveMain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdSaveMain.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSaveMain.Location = New System.Drawing.Point(35, 665)
        Me.cmdSaveMain.Name = "cmdSaveMain"
        Me.cmdSaveMain.Size = New System.Drawing.Size(100, 23)
        Me.cmdSaveMain.TabIndex = 69
        Me.cmdSaveMain.Text = "&Save to Sheet"
        Me.cmdSaveMain.UseVisualStyleBackColor = False
        '
        'cmdResetMain
        '
        Me.cmdResetMain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdResetMain.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdResetMain.Location = New System.Drawing.Point(395, 665)
        Me.cmdResetMain.Name = "cmdResetMain"
        Me.cmdResetMain.Size = New System.Drawing.Size(75, 23)
        Me.cmdResetMain.TabIndex = 69
        Me.cmdResetMain.Text = "Reset All"
        Me.cmdResetMain.UseMnemonic = False
        Me.cmdResetMain.UseVisualStyleBackColor = False
        '
        'FStep2Ver2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(504, 761)
        Me.Controls.Add(Me.cmdResetMain)
        Me.Controls.Add(Me.cmdSaveMain)
        Me.Controls.Add(Me.cmdLoadMain)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.lblStep2Desc)
        Me.Controls.Add(Me.lblStep2)
        Me.Controls.Add(Me.flpCritList)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FStep2Ver2"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENERGIZER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents flpCritList As Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblStep2Desc As Windows.Forms.Label
    Friend WithEvents lblStep2 As Windows.Forms.Label
    Friend WithEvents cmdHelp As Windows.Forms.Button
    Friend WithEvents cmdBack As Windows.Forms.Button
    Friend WithEvents cmdCancel As Windows.Forms.Button
    Friend WithEvents cmdNext As Windows.Forms.Button
    Friend WithEvents cmdLoadMain As Windows.Forms.Button
    Friend WithEvents cmdSaveMain As Windows.Forms.Button
    Friend WithEvents cmdResetMain As Windows.Forms.Button
End Class
