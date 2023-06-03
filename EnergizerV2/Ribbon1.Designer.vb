Partial Class Ribbon1
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'This call is required by the Component Designer.
        InitializeComponent()

    End Sub

    'Component overrides dispose to clean up the component list.
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

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tab1 = Me.Factory.CreateRibbonTab
        Me.Group1 = Me.Factory.CreateRibbonGroup
        Me.splbtnRun = Me.Factory.CreateRibbonSplitButton
        Me.btnRun = Me.Factory.CreateRibbonButton
        Me.btnLoadExample = Me.Factory.CreateRibbonButton
        Me.btnLoadTemplate = Me.Factory.CreateRibbonButton
        Me.btnAbout = Me.Factory.CreateRibbonButton
        Me.btnHelp = Me.Factory.CreateRibbonButton
        Me.Tab1.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
        Me.Tab1.Groups.Add(Me.Group1)
        Me.Tab1.Label = "TabAddIns"
        Me.Tab1.Name = "Tab1"
        '
        'Group1
        '
        Me.Group1.Items.Add(Me.splbtnRun)
        Me.Group1.Label = "ENERGIZER"
        Me.Group1.Name = "Group1"
        '
        'splbtnRun
        '
        Me.splbtnRun.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.splbtnRun.Image = Global.EnergizerV2.My.Resources.Resources.logoSquare
        Me.splbtnRun.Items.Add(Me.btnRun)
        Me.splbtnRun.Items.Add(Me.btnLoadExample)
        Me.splbtnRun.Items.Add(Me.btnLoadTemplate)
        Me.splbtnRun.Items.Add(Me.btnAbout)
        Me.splbtnRun.Items.Add(Me.btnHelp)
        Me.splbtnRun.Label = "Decision Analyzer"
        Me.splbtnRun.Name = "splbtnRun"
        '
        'btnRun
        '
        Me.btnRun.Image = Global.EnergizerV2.My.Resources.Resources.iconLightning1
        Me.btnRun.Label = "Run ENERGIZER"
        Me.btnRun.Name = "btnRun"
        Me.btnRun.ShowImage = True
        '
        'btnLoadExample
        '
        Me.btnLoadExample.Image = Global.EnergizerV2.My.Resources.Resources.IconTable
        Me.btnLoadExample.Label = "Load Example"
        Me.btnLoadExample.Name = "btnLoadExample"
        Me.btnLoadExample.ShowImage = True
        '
        'btnLoadTemplate
        '
        Me.btnLoadTemplate.Image = Global.EnergizerV2.My.Resources.Resources.IconTableLightning
        Me.btnLoadTemplate.Label = "Load Template"
        Me.btnLoadTemplate.Name = "btnLoadTemplate"
        Me.btnLoadTemplate.ShowImage = True
        '
        'btnAbout
        '
        Me.btnAbout.Image = Global.EnergizerV2.My.Resources.Resources.IconThreeDots
        Me.btnAbout.Label = "About Energizer"
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.ShowImage = True
        '
        'btnHelp
        '
        Me.btnHelp.Image = Global.EnergizerV2.My.Resources.Resources.iconQuestion
        Me.btnHelp.Label = "Help"
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.ShowImage = True
        '
        'Ribbon1
        '
        Me.Name = "Ribbon1"
        Me.RibbonType = "Microsoft.Excel.Workbook"
        Me.Tabs.Add(Me.Tab1)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents splbtnRun As RibbonSplitButton
    Friend WithEvents btnRun As RibbonButton
    Friend WithEvents btnLoadExample As RibbonButton
    Friend WithEvents btnLoadTemplate As RibbonButton
    Friend WithEvents btnAbout As RibbonButton
    Friend WithEvents btnHelp As RibbonButton
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property Ribbon1() As Ribbon1
        Get
            Return Me.GetRibbon(Of Ribbon1)()
        End Get
    End Property
End Class
