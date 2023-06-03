Imports System.Windows.Forms

Public Class FStep2Ver2
    Private ReadOnly _state As ProgramState
    Public Sub New(state As ProgramState)
        InitializeComponent()
        _state = state

        For Each crit As String In _state.CritNames
            Dim ucStep2Input As New UCStep2Input(_state)
            ucStep2Input.CritName = crit
            ucStep2Input.InitializeAlternatives(_state.AltNames)
            ' Assuming InitializeAlternatives now accepts a list of alternatives.
            flpCritList.Controls.Add(ucStep2Input)
        Next
    End Sub

    Private Sub cmdSaveMain_Click(sender As Object, e As EventArgs) Handles cmdSaveMain.Click
        Dim xlApp As Excel.Application = Globals.ThisAddIn.Application
        Dim xlWorkBook As Excel.Workbook = xlApp.ActiveWorkbook
        Dim xlWorkSheet As Excel.Worksheet = xlWorkBook.ActiveSheet

        ' Loop through each control in flpCritList.Controls
        For Each control As Control In flpCritList.Controls
            ' Try to cast the control to UCStep2Input
            Dim ucStep2Input As UCStep2Input = TryCast(control, UCStep2Input)
            If ucStep2Input IsNot Nothing Then
                ' If the cast was successful, get the values from the textboxes
                Dim AltValuesInner As Dictionary(Of String, MinMidMaxValues) = ucStep2Input.GetAlternativeValues()

                ' Check if the criterion already exists in the AltValues dictionary
                If _state.AltValues.ContainsKey(ucStep2Input.CritName) Then
                    ' If it does, update the value
                    _state.AltValues(ucStep2Input.CritName) = AltValuesInner
                Else
                    ' If it doesn't, add the new key-value pair
                    _state.AltValues.Add(ucStep2Input.CritName, AltValuesInner)
                End If
            End If
        Next

        ' Save the state to the worksheet
        _state.SaveState2ToSheet(xlWorkSheet)
        MessageBox.Show("Current state has been saved to the active worksheet.", "Save Successful")
    End Sub

    Private Sub cmdLoadMain_Click(sender As Object, e As EventArgs) Handles cmdLoadMain.Click
        ' Get the Excel application and active workbook
        Dim xlApp As Excel.Application = Globals.ThisAddIn.Application
        Dim xlWorkBook As Excel.Workbook = xlApp.ActiveWorkbook
        Dim xlWorkSheet As Excel.Worksheet = xlWorkBook.ActiveSheet

        Try
            ' Load the state from the worksheet
            _state.LoadStateFromSheet(xlWorkSheet)

            For Each ucStep2Input As UCStep2Input In flpCritList.Controls
                Dim altValues As New Dictionary(Of String, MinMidMaxValues)
                For Each altName In _state.AltNames
                    altValues.Add(altName, _state.AltValues(ucStep2Input.CritName)(altName))
                Next
                ucStep2Input.SetAlternativeValues(altValues)
            Next

            MessageBox.Show("State has been loaded from the active worksheet.", "Load Successful")
        Catch ex As Exception
            MessageBox.Show($"There was an error loading the state from the active worksheet. Please make sure the worksheet contains a valid saved state. Details: {ex.Message}", "Load Error")
        End Try
    End Sub

    Private Sub cmdResetMain_Click(sender As Object, e As EventArgs) Handles cmdResetMain.Click
        ' Loop through each UCStep2Input control in the FlowLayoutPanel
        For Each ctrl As Control In flpCritList.Controls
            If TypeOf ctrl Is UCStep2Input Then
                Dim uc As UCStep2Input = DirectCast(ctrl, UCStep2Input)
                uc.ResetTable()  ' Call the Reset method
                uc.ResetRanking() ' Call the ResetPicBoxes method
            End If
        Next
    End Sub

    Private Function ValidateInput() As Boolean
        Return True
    End Function

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        'Me.Hide()
        'Dim step3Form As New FStep3()
        'step3Form.ShowDialog()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Dim worksheet As Excel.Worksheet = Globals.ThisAddIn.Application.ActiveSheet

        ' Navigate back to FStep1, passing the same state instance
        Dim fStep1 As New FStep1(_state)
        Me.Hide()
        fStep1.ShowDialog()
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        MessageBox.Show("This feature is currently in progress and is being developed to provide you with a richer, more intuitive user experience. 
Please check back in a future update.


This window will provide you: 
- a step-by-step guide for navigating this form through a series of screenshots accompanied by clear instructions that aim to make the process straightforward, regardless of your level of familiarity with the system. 
- clarifications on the form fields, understand what information is required, and know what each part of the form does.")
    End Sub

End Class


' #################################################################################################
' #################################### ALTERNATIVE CODES BENCH ####################################
' #################################################################################################

'Private ReadOnly _state As ProgramState
'Private WithEvents _worker As BackgroundWorker

'Public Sub New(state As ProgramState)
'    InitializeComponent()
'    ' Store the state instance
'    _state = state

'    ' Create the BackgroundWorker
'    _worker = New BackgroundWorker()
'    _worker.WorkerReportsProgress = True
'    _worker.WorkerSupportsCancellation = False
'    AddHandler _worker.DoWork, AddressOf worker_DoWork
'    AddHandler _worker.ProgressChanged, AddressOf worker_ProgressChanged
'    AddHandler _worker.RunWorkerCompleted, AddressOf worker_RunWorkerCompleted

'End Sub

'Private Sub Step2Ver2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'    ' Show the loading dialog
'    Dim loadingDialog = New FLoading(_worker)
'    loadingDialog.ShowDialog()

'    ' Start the worker
'    _worker.RunWorkerAsync()
'End Sub

''Private Sub worker_DoWork(sender As Object, e As DoWorkEventArgs)
''    ' This code will be executed on a separate thread
''    Dim ucInputs As New List(Of UCStep2Input)

''    Dim i As Integer = 0
''    For Each crit As String In _state.CritNames
''        Dim ucStep2Input As New UCStep2Input()
''        ucStep2Input.CritName = crit
''        ucStep2Input.InitializeAlternatives(_state.AltNames)

''        ucInputs.Add(ucStep2Input)
''        i += 1
''        _worker.ReportProgress(i * 100 / _state.CritNames.Count, "Loading " & crit & "...")
''    Next
''    e.Result = ucInputs
''End Sub

'Private Sub worker_DoWork(sender As Object, e As DoWorkEventArgs)
'    ' This code will be executed on a separate thread

'    ' 25% of work - Loading data
'    ' Your data loading operation goes here...
'    _worker.ReportProgress(25, "Loading data...")

'    ' 50% of work - Initializing components
'    ' Your component initialization goes here...
'    _worker.ReportProgress(50, "Initializing components...")

'    ' 75% of work - Finishing up
'    ' The rest of your operation goes here...
'    _worker.ReportProgress(75, "Finishing up...")

'    For Each crit As String In _state.CritNames
'        Dim ucStep2Input As New UCStep2Input()
'        ucStep2Input.CritName = crit
'        ucStep2Input.InitializeAlternatives(_state.AltNames)
'        ' Assuming InitializeAlternatives now accepts a list of alternatives.
'        flpCritList.Controls.Add(ucStep2Input)
'    Next

'    ' 100% of work - Completed
'    _worker.ReportProgress(100, "Completed.")
'End Sub


'Private Sub worker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
'    ' Update the progress bar and label on the loading dialog
'    'FLoading.UpdateProgress(e.ProgressPercentage, e.UserState.ToString())
'End Sub

'Private Sub worker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
'    ' This code will be executed on the main thread
'    ' Add the UserControls to the FlowLayoutPanel
'    Dim ucInputs As List(Of UCStep2Input) = CType(e.Result, List(Of UCStep2Input))
'    For Each ucStep2Input As UCStep2Input In ucInputs
'        flpCritList.Controls.Add(ucStep2Input)
'    Next

'End Sub
