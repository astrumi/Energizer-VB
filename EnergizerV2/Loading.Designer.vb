<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLoading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FLoading))
        Me.prgLoad = New System.Windows.Forms.ProgressBar()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'prgLoad
        '
        Me.prgLoad.Location = New System.Drawing.Point(12, 69)
        Me.prgLoad.Name = "prgLoad"
        Me.prgLoad.Size = New System.Drawing.Size(250, 23)
        Me.prgLoad.TabIndex = 0
        Me.prgLoad.UseWaitCursor = True
        '
        'lblLoad
        '
        Me.lblLoad.Location = New System.Drawing.Point(12, 43)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(250, 23)
        Me.lblLoad.TabIndex = 1
        Me.lblLoad.Text = "Label1"
        Me.lblLoad.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.prgLoad)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FLoading"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading..."
        Me.TopMost = True
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents prgLoad As Windows.Forms.ProgressBar
    Friend WithEvents lblLoad As Windows.Forms.Label
End Class
