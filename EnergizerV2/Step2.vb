Imports System.Windows.Forms
Imports System.Drawing

Public Class FStep2

    Private ReadOnly _state As ProgramState
    ' Declare Dictionaries
    Private ReadOnly picBoxes As New Dictionary(Of String, PictureBox)
    Private ReadOnly lblFollows As New Dictionary(Of String, Label)
    Private ReadOnly lblLocs As New Dictionary(Of String, Label)
    Private ReadOnly isMouseDown As New Dictionary(Of String, Boolean)
    Private ReadOnly mouseDownY As New Dictionary(Of String, Integer)
    Private Const upperBound As Integer = 0
    Private Const lowerBound As Integer = 300

    Private _controlRefs As New Dictionary(Of String, Dictionary(Of String, CriteriaValues))


    Public Sub New(state As ProgramState)
        InitializeComponent()
        ' Store the state instance
        _state = state

        ' Populate lstCritSelect
        For Each crit As String In _state.CritNames
            lstCritSelect.Items.Add(crit)
        Next

        '' Initialize CriteriaControls
        '_state.CriteriaControls = New Dictionary(Of String, List(Of List(Of Control)))()
        'For Each crit As String In _state.CritNames
        '    _state.CriteriaControls.Add(crit, New List(Of List(Of Control))())
        'Next

    End Sub



    Private Sub FStep2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the table view
        For Each alt As String In _state.AltNames
            ' Create the controls
            Dim lblAltName As New Label()
            lblAltName.Text = alt
            lblAltName.AutoSize = True

            Dim radOpt1 As New RadioButton()
            'radOpt1.Margin = New Padding(0)
            radOpt1.AutoSize = True
            Dim radOpt2 As New RadioButton()
            'radOpt2.Margin = New Padding(0)
            radOpt2.AutoSize = True
            Dim radOpt3 As New RadioButton()
            'radOpt3.Margin = New Padding(0)
            radOpt3.AutoSize = True

            Dim pnlRadOpt As New FlowLayoutPanel()
            pnlRadOpt.AutoSize = True
            pnlRadOpt.Padding = New Padding(0)
            pnlRadOpt.FlowDirection = FlowDirection.LeftToRight
            pnlRadOpt.WrapContents = False

            ' Add radio buttons to the panel
            pnlRadOpt.Controls.Add(radOpt1)
            pnlRadOpt.Controls.Add(radOpt2)
            pnlRadOpt.Controls.Add(radOpt3)

            Dim txtMin As New TextBox()
            txtMin.Enabled = False
            txtMin.Dock = DockStyle.Fill
            txtMin.TextAlign = HorizontalAlignment.Center
            AddHandler txtMin.KeyPress, AddressOf TextBox_KeyPress
            Dim txtMid As New TextBox()
            txtMid.Enabled = False
            txtMid.Dock = DockStyle.Fill
            txtMid.TextAlign = HorizontalAlignment.Center
            AddHandler txtMid.KeyPress, AddressOf TextBox_KeyPress
            Dim txtMax As New TextBox()
            txtMax.Enabled = False
            txtMax.Dock = DockStyle.Fill
            txtMax.TextAlign = HorizontalAlignment.Center
            AddHandler txtMax.KeyPress, AddressOf TextBox_KeyPress


            ' Add event handlers for the RadioButtons
            AddHandler radOpt1.CheckedChanged, Sub(s As Object, e1 As EventArgs)
                                                   txtMid.Enabled = radOpt1.Checked
                                               End Sub

            AddHandler radOpt2.CheckedChanged, Sub(s As Object, e2 As EventArgs)
                                                   txtMin.Enabled = radOpt2.Checked
                                                   txtMax.Enabled = radOpt2.Checked
                                               End Sub

            AddHandler radOpt3.CheckedChanged, Sub(s As Object, e3 As EventArgs)
                                                   txtMin.Enabled = radOpt3.Checked
                                                   txtMid.Enabled = radOpt3.Checked
                                                   txtMax.Enabled = radOpt3.Checked
                                               End Sub

            ' Add a new row to the TableLayoutPanel
            tblAltValues.RowCount += 1
            tblAltValues.RowStyles.Add(New RowStyle(SizeType.AutoSize))

            ' Add the controls to the new row
            tblAltValues.Controls.Add(lblAltName, 0, tblAltValues.RowCount - 1)
            tblAltValues.Controls.Add(pnlRadOpt, 1, tblAltValues.RowCount - 1) ' Add the panel instead of individual radio buttons
            tblAltValues.Controls.Add(txtMin, 2, tblAltValues.RowCount - 1)
            tblAltValues.Controls.Add(txtMid, 3, tblAltValues.RowCount - 1)
            tblAltValues.Controls.Add(txtMax, 4, tblAltValues.RowCount - 1)

            ' +Add TextBoxes to the _controlRefs dictionary
            Dim critValues As New CriteriaValues With {.txtMin = txtMin, .txtMid = txtMid, .txtMax = txtMax}
            If Not _controlRefs.ContainsKey(alt) Then _controlRefs.Add(alt, New Dictionary(Of String, CriteriaValues))
            For Each crit As String In _state.CritNames
                _controlRefs(alt).Add(crit, critValues)
            Next

        Next


        ' Populate the ranking ladder
        Dim offset As Integer = 0
        ' List of colors
        Dim colors As List(Of Color) = New List(Of Color) From {Color.Red, Color.Blue, Color.Green, Color.Magenta, Color.Orange, Color.Yellow, Color.Purple, Color.Brown, Color.Cyan, Color.Lime}

        For i As Integer = 0 To _state.AltNames.Count - 1
            Dim alt = _state.AltNames(i)
            ' Calculate the index of the color for this PictureBox
            Dim colorIndex As Integer = i Mod colors.Count

            ' Create the controls
            Dim picBox As New PictureBox With {
                .Size = New Size(30, 15),
                .BorderStyle = BorderStyle.Fixed3D,
                .BackColor = colors(colorIndex),  ' Use the color from the list
                .Location = New Point(0, offset)
            }
            picBoxes.Add(alt, picBox)  ' add the PictureBox to the Dictionary

            Dim lblFollow As New Label With {
                .Text = alt,
                .AutoSize = True,
                .Location = New Point(35, offset)  ' place the label to the right of the PictureBox
            }
            lblFollows.Add(alt, lblFollow)  ' add the Label to the Dictionary

            Dim picBtnFocus As New PictureBox With {
            .Size = New Size(15, 15),
            .BackColor = colors(colorIndex),
            .Location = New Point(0, offset)
            }

            Dim lblLoc As New Label With {
                .Text = alt,
                .AutoSize = True,
                .Location = New Point(20, offset)  ' place the label below the PictureBox
            }
            lblLocs.Add(alt, lblLoc)  ' add the Label to the Dictionary

            ' Initialize the dictionaries for the PictureBox
            isMouseDown(alt) = False
            mouseDownY(alt) = 0

            ' Add event handlers for the PictureBox
            AddHandler picBox.MouseDown, Sub(s As Object, e1 As MouseEventArgs)
                                             If e1.Button = MouseButtons.Left Then
                                                 isMouseDown(alt) = True
                                                 mouseDownY(alt) = e1.Y
                                             End If
                                         End Sub

            AddHandler picBox.MouseMove, Sub(s As Object, e1 As MouseEventArgs)
                                             If isMouseDown(alt) Then
                                                 ' Compute the new top location within the bounds
                                                 Dim newTop = picBox.Top + e1.Y - mouseDownY(alt)
                                                 newTop = Math.Max(upperBound, Math.Min(lowerBound, newTop))

                                                 ' Set the new top location
                                                 picBox.Top = newTop
                                                 lblFollow.Top = newTop  ' adjust the label that follows the PictureBox

                                                 ' Update the label displaying the location
                                                 lblLoc.Text = alt & " " & picBox.Top.ToString()
                                             End If
                                         End Sub

            AddHandler picBtnFocus.Click, Sub(s As Object, e1 As EventArgs)
                                              picBoxes(alt).BringToFront()
                                              lblFollows(alt).BringToFront()
                                          End Sub

            AddHandler picBox.MouseUp, Sub(s As Object, e1 As MouseEventArgs)
                                           If e1.Button = MouseButtons.Left Then
                                               isMouseDown(alt) = False
                                           End If
                                       End Sub

            ' Add the controls to the form
            pnlRankingLadder.Controls.Add(picBox)
            pnlRankingLadder.Controls.Add(lblFollow)
            pnlRankingLadderLoc.Controls.Add(picBtnFocus)
            pnlRankingLadderLoc.Controls.Add(lblLoc)
            picBox.BringToFront()

            offset += 30      ' Increment the offset for the next control
        Next

    End Sub


    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim tb As TextBox = TryCast(sender, TextBox)
        If tb IsNot Nothing Then
            If Not (Char.IsControl(e.KeyChar) OrElse
                Char.IsDigit(e.KeyChar) OrElse
                (e.KeyChar = "."c AndAlso tb.Text.IndexOf("."c) < 0) OrElse
                (e.KeyChar = "-"c AndAlso tb.Text.Length = 0)) Then
                e.Handled = True
            End If

            ' Check existing text for decimal point and limit decimal places to 2
            If e.KeyChar = "."c OrElse Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar) Then
                Dim dpIndex As Integer = tb.Text.IndexOf("."c)
                If dpIndex > -1 AndAlso tb.Text.Length - dpIndex > 2 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub


    '' Function to get alternative values from tblAltValues
    'Private Function GetAlternativeValues() As List(Of AlternativeValues)
    '    Dim values As New List(Of AlternativeValues)

    '    For i = 0 To tblAltValues.RowCount - 1
    '        Dim lblAltName As Label = CType(tblAltValues.GetControlFromPosition(0, i), Label)
    '        Dim txtMin As TextBox = CType(tblAltValues.GetControlFromPosition(2, i), TextBox)
    '        Dim txtMid As TextBox = CType(tblAltValues.GetControlFromPosition(3, i), TextBox)
    '        Dim txtMax As TextBox = CType(tblAltValues.GetControlFromPosition(4, i), TextBox)

    '        Dim altValues As New AlternativeValues
    '        altValues.AltName = lblAltName.Text
    '        altValues.Min = If(txtMin.Enabled, txtMin.Text, "")
    '        altValues.Mid = If(txtMid.Enabled, txtMid.Text, "")
    '        altValues.Max = If(txtMax.Enabled, txtMax.Text, "")

    '        values.Add(altValues)
    '    Next
    '    Return values
    'End Function

    'Private Sub lstCritSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCritSelect.SelectedIndexChanged
    '    UpdateAltValuesTable()
    'End Sub


    Private Sub SaveTableValues()
        ' Clear the previous values
        _state.CritAltValues.Clear()

        ' For each criteria
        For Each crit As String In _state.CritNames
            ' Create a dictionary to hold the alternative values for this criteria
            Dim altValues As New Dictionary(Of String, List(Of Decimal))

            ' For each alternative
            For Each alt As String In _state.AltNames
                ' Get the values for this alternative and this criteria from the table
                ' TODO: Replace "GetValuesFromTable" with the actual logic to get the values from the table
                ' You will likely need to iterate over the controls of the tblAltValues control to find the TextBoxes for this alternative and criteria
                Dim values As List(Of Decimal) = GetValuesFromTable(crit, alt)

                ' If values are not null, add them to the dictionary
                If values IsNot Nothing Then
                    altValues.Add(alt, values)
                End If
            Next

            ' Add the alternative values to the state
            _state.CritAltValues.Add(crit, altValues)
        Next
    End Sub

    Private Sub LoadTableValues()
        ' For each criteria
        For Each crit As String In _state.CritNames
            ' Get the alternative values for this criteria
            Dim altValues As Dictionary(Of String, List(Of Decimal)) = Nothing
            If _state.CritAltValues.TryGetValue(crit, altValues) Then
                ' For each alternative
                For Each alt As String In _state.AltNames
                    ' Get the values for this alternative and this criteria
                    Dim values As List(Of Decimal) = Nothing
                    If altValues.TryGetValue(alt, values) Then
                        ' Set the values in the table
                        ' TODO: Replace "SetValuesInTable" with the actual logic to set the values in the table
                        ' You will likely need to iterate over the controls of the tblAltValues control to find the TextBoxes for this alternative and criteria, and then set their Text property
                        SetValuesInTable(crit, alt, values)
                    End If
                Next
            End If
        Next
    End Sub


    Private Function GetValuesFromTable(crit As String, alt As String) As List(Of Decimal)
        Dim values As New List(Of Decimal)

        ' Iterate over each row in the table layout
        For i As Integer = 0 To tblAltValues.RowCount - 1
            ' Get the alternative name label
            Dim lblAltName As Label = TryCast(tblAltValues.GetControlFromPosition(0, i), Label)
            If lblAltName IsNot Nothing AndAlso lblAltName.Text = alt Then
                ' If the alternative name matches, then get the TextBox values
                Dim txtMin As TextBox = TryCast(tblAltValues.GetControlFromPosition(2, i), TextBox)
                Dim txtMid As TextBox = TryCast(tblAltValues.GetControlFromPosition(3, i), TextBox)
                Dim txtMax As TextBox = TryCast(tblAltValues.GetControlFromPosition(4, i), TextBox)
                If txtMin IsNot Nothing And txtMin.Text <> "" Then values.Add(Decimal.Parse(txtMin.Text))
                If txtMid IsNot Nothing And txtMid.Text <> "" Then values.Add(Decimal.Parse(txtMid.Text))
                If txtMax IsNot Nothing And txtMax.Text <> "" Then values.Add(Decimal.Parse(txtMax.Text))
                Exit For
            End If
        Next

        Return values
    End Function

    Private Sub SetValuesInTable(crit As String, alt As String, values As List(Of Decimal))
        ' Iterate over each row in the table layout
        For i As Integer = 0 To tblAltValues.RowCount - 1
            ' Get the alternative name label
            Dim lblAltName As Label = TryCast(tblAltValues.GetControlFromPosition(0, i), Label)
            If lblAltName IsNot Nothing AndAlso lblAltName.Text = alt Then
                ' If the alternative name matches, then set the TextBox values
                Dim txtMin As TextBox = TryCast(tblAltValues.GetControlFromPosition(2, i), TextBox)
                Dim txtMid As TextBox = TryCast(tblAltValues.GetControlFromPosition(3, i), TextBox)
                Dim txtMax As TextBox = TryCast(tblAltValues.GetControlFromPosition(4, i), TextBox)
                Dim pnlRadOpt As FlowLayoutPanel = TryCast(tblAltValues.GetControlFromPosition(1, i), FlowLayoutPanel)
                Dim radOpt1 As RadioButton = TryCast(pnlRadOpt.Controls(0), RadioButton)
                Dim radOpt2 As RadioButton = TryCast(pnlRadOpt.Controls(1), RadioButton)
                Dim radOpt3 As RadioButton = TryCast(pnlRadOpt.Controls(2), RadioButton)
                If txtMin IsNot Nothing And values.Count > 0 Then
                    txtMin.Text = values(0).ToString()
                    radOpt2.Checked = True
                End If
                If txtMid IsNot Nothing And values.Count > 1 Then
                    txtMid.Text = values(1).ToString()
                    radOpt1.Checked = True
                End If
                If txtMax IsNot Nothing And values.Count > 2 Then
                    txtMax.Text = values(2).ToString()
                    radOpt3.Checked = True
                End If
                Exit For
            End If
        Next
    End Sub

    Private Sub cmdTableSave_Click(sender As Object, e As EventArgs) Handles cmdTableSave.Click
        ' Get the active worksheet
        Dim xlApp As Excel.Application = Globals.ThisAddIn.Application  ' Get the Excel application and active workbook
        Dim xlWorkBook As Excel.Workbook = xlApp.ActiveWorkbook
        Dim worksheet As Excel.Worksheet = xlWorkBook.ActiveSheet
        ' Save the table values to the state
        For Each crit As String In _state.CritNames
            For Each alt As String In _state.AltNames
                '_state.CritAltValues(crit)(alt) = GetValuesFromTable(crit, alt)
                ' Ensure that an entry exists in the dictionary
                If Not _state.CritAltValues.ContainsKey(crit) Then
                    _state.CritAltValues(crit) = New Dictionary(Of String, List(Of Decimal))()
                End If
                If Not _state.CritAltValues(crit).ContainsKey(alt) Then
                    _state.CritAltValues(crit)(alt) = New List(Of Decimal)()
                End If
                ' Now it's safe to access the entry
                _state.CritAltValues(crit)(alt) = GetValuesFromTable(crit, alt)
            Next
        Next
        ' Save the state to the worksheet
        _state.SaveState2ToSheet(worksheet)
    End Sub

    Private Sub cmdTableLoad_Click(sender As Object, e As EventArgs) Handles cmdTableLoad.Click
        ' Get the active worksheet
        Dim xlApp As Excel.Application = Globals.ThisAddIn.Application  ' Get the Excel application and active workbook
        Dim xlWorkBook As Excel.Workbook = xlApp.ActiveWorkbook
        Dim worksheet As Excel.Worksheet = xlWorkBook.ActiveSheet
        ' Load the state from the worksheet
        _state.LoadState2FromSheet(worksheet)
        ' Load the table values from the state
        For Each crit As String In _state.CritNames
            For Each alt As String In _state.AltNames
                SetValuesInTable(crit, alt, _state.CritAltValues(crit)(alt))
            Next
        Next
    End Sub




    Private Sub lstCritSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCritSelect.SelectedIndexChanged
        ' Get the selected criteria
        Dim selectedCrit As String = lstCritSelect.SelectedItem
        ' Iterate over each row in the table layout
        For i As Integer = 0 To tblAltValues.RowCount - 1
            ' Get the text boxes and radio buttons
            Dim txtMin As TextBox = TryCast(tblAltValues.GetControlFromPosition(2, i), TextBox)
            Dim txtMid As TextBox = TryCast(tblAltValues.GetControlFromPosition(3, i), TextBox)
            Dim txtMax As TextBox = TryCast(tblAltValues.GetControlFromPosition(4, i), TextBox)
            Dim pnlRadOpt As FlowLayoutPanel = TryCast(tblAltValues.GetControlFromPosition(1, i), FlowLayoutPanel)
            Dim radOpt1 As RadioButton = TryCast(pnlRadOpt.Controls(0), RadioButton)
            Dim radOpt2 As RadioButton = TryCast(pnlRadOpt.Controls(1), RadioButton)
            Dim radOpt3 As RadioButton = TryCast(pnlRadOpt.Controls(2), RadioButton)
            ' Enable/disable the text boxes based on the selected criteria
            txtMin.Enabled = radOpt2.Checked Or radOpt3.Checked
            txtMid.Enabled = radOpt1.Checked Or radOpt3.Checked
            txtMax.Enabled = radOpt2.Checked Or radOpt3.Checked
        Next
    End Sub


    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        Me.Hide()
        Dim step3Form As New FStep3()
        step3Form.ShowDialog()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    'Private Sub cmdLoadSave_Click(sender As Object, e As EventArgs) Handles cmdLoadSave.Click
    '    ' Call SaveStateToSheet when needed
    '    Dim altValues As List(Of AlternativeValues) = GetAlternativeValues()
    '    Dim worksheet As Excel.Worksheet = Globals.ThisAddIn.Application.ActiveSheet
    '    _state.SaveState2ToSheet(worksheet, altValues)
    'End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Dim worksheet As Excel.Worksheet = Globals.ThisAddIn.Application.ActiveSheet
        'Dim altValues As List(Of AlternativeValues) = GetAlternativeValues()
        '_state.SaveState2ToSheet(worksheet, altValues)

        ' Navigate back to FStep1, passing the same state instance
        Dim fStep1 As New FStep1(_state)
        Me.Hide()
        fStep1.Show()
    End Sub

    ' Validate the input before proceeding to the next step
    Private Function ValidateInput() As Boolean

        Return True
    End Function

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        MessageBox.Show("This feature is currently in progress and is being developed to provide you with a richer, more intuitive user experience. 
Please check back in a future update.


This window will provide you: 
- a step-by-step guide for navigating this form through a series of screenshots accompanied by clear instructions that aim to make the process straightforward, regardless of your level of familiarity with the system. 
- clarifications on the form fields, understand what information is required, and know what each part of the form does.")
    End Sub


End Class

Public Class CriteriaValues
    Public Property TxtMin As TextBox
    Public Property TxtMid As TextBox
    Public Property TxtMax As TextBox
End Class


' #################################################################################################
' #################################### ALTERNATIVE CODES BENCH ####################################
' #################################################################################################


'Private ReadOnly _step1Data As Step1Data
'Private ReadOnly _step1Form As FStep1

'Public Sub New(step1Data As Step1Data, step1Form As FStep1)
'    ' This call is required by the designer.
'    InitializeComponent()

'    ' Add any initialization after the InitializeComponent() call.

'    ' Store the step1Data instance
'    _step1Data = step1Data
'    _step1Form = step1Form

'    ' Populate lstCritSelect
'    For Each crit As String In _step1Data.CritNames
'        lstCritSelect.Items.Add(crit)
'    Next

'End Sub
' Then you can use _step1Data in the FStep2 form methods to access the data from FStep1



'Private Sub FStep2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'    For Each alt As String In _step1Data.AltNames

'Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
'    'Me.Hide()
'    'Dim step1Form As FStep1 = New FStep1()
'    'step1Form.Show()
'    _step1Form.Show()
'    Me.Hide()
'End Sub

'#4
'Private Sub FStep2_FormClosed(sender As Object, e As Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
'    Dim activeWorkbookName As String = Globals.ThisAddIn.Application.ActiveWorkbook.Name    ' Get the name of the active workbook
'    If Globals.ThisAddIn.ActiveForms.ContainsKey(activeWorkbookName) Then
'        Globals.ThisAddIn.ActiveForms(activeWorkbookName).Remove(Me)        ' Remove this form from the dictionary
'    End If
'    Me.Dispose() ' Dispose of the form
'End Sub

'Private Sub FStep2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
'    Dim activeWorkbookName As String = Globals.ThisAddIn.Application.ActiveWorkbook.Name
'    If Globals.ThisAddIn.ActiveForms.ContainsKey(activeWorkbookName) Then
'        Globals.ThisAddIn.ActiveForms.Remove(activeWorkbookName)
'    End If
'    Me.Dispose()
'End Sub
