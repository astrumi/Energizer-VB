Imports System.Windows.Forms
Imports Microsoft.Office.Interop
Imports System.Text.RegularExpressions

Public Class FStep1
    Private ReadOnly _state As ProgramState

    Public Sub New(state As ProgramState)
        InitializeComponent()
        _state = state        ' Store the state instance
    End Sub

    Private Sub FStep1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Alt#1 Assume we have a list of MCDA methods
        'Dim mcdaMethods As List(Of String) = New List(Of String) From {"AHP", "WSM", "WPM", "TOPSIS", "ELECTRE", "PROMETHEE"}
        '' Add MCDA methods to the ComboBox
        'For Each method As String In mcdaMethods
        '    cboMcdaMethod.Items.Add(method)
        'Next

        ' Alt#2 Adding the method list directly
        cboMcdaMethod.Items.AddRange(New String() {"AHP", "WSM", "WPM", "TOPSIS", "ELECTRE", "PROMETHEE"})
        cboMcdaMethod.SelectedIndex = 0                             ' Select the 0th item/index 1 by default

        If _state IsNot Nothing Then
            If _state.MatrixCellRef IsNot Nothing Then
                txtMatrixCellRef.Text = _state.MatrixCellRef
            End If
            If _state.AltNames IsNot Nothing Then
                lstAltList.Items.AddRange(_state.AltNames.ToArray())
            End If
            If _state.CritNames IsNot Nothing Then
                lstCritList.Items.AddRange(_state.CritNames.ToArray())
            End If
            If _state.McdaMethod IsNot Nothing Then
                cboMcdaMethod.SelectedItem = _state.McdaMethod
            End If
            txtAltCount.Text = lstAltList.Items.Count.ToString()    ' Update the count
            txtCritCount.Text = lstCritList.Items.Count.ToString()
            UpdateUniqueNamesCheckBox()                             ' Update the checkbox
        End If
    End Sub

    Private Sub SelectCell(sender As Object, e As EventArgs) Handles cmdResultCellRef.Click, cmdMatrixCellRef.Click
        Me.Hide()
        Dim result As Object
        result = Globals.ThisAddIn.Application.InputBox("Select a cell on the sheet", Type:=8)
        If TypeOf result Is Excel.Range Then
            Dim rng As Excel.Range = DirectCast(result, Excel.Range)
            If sender Is cmdMatrixCellRef Then
                txtMatrixCellRef.Text = rng.Address
            ElseIf sender Is cmdResultCellRef Then
                txtResultCellRef.Text = rng.Address
            End If
        End If
        Me.Show()
    End Sub

    Private Sub cmdAltListAdd_Click(sender As Object, e As EventArgs) Handles cmdAltListAdd.Click
        Dim input = GetValidInput("Enter the name of your alternative:", "Add an Alternative", "", lstAltList)
        If input IsNot Nothing Then
            lstAltList.Items.Add(input)
            txtAltCount.Text = lstAltList.Items.Count.ToString()    ' Update the count in the TextBox
            UpdateUniqueNamesCheckBox()                             ' Update the CheckBox
        End If
    End Sub

    Private Sub cmdCritListAdd_Click(sender As Object, e As EventArgs) Handles cmdCritListAdd.Click
        Dim input = GetValidInput("Enter the name of your criteria:", "Add a Criteria", "", lstCritList)
        If input IsNot Nothing Then
            lstCritList.Items.Add(input)
            txtCritCount.Text = lstCritList.Items.Count.ToString()  ' Update the count
            UpdateUniqueNamesCheckBox()                             ' Update the checkbox
        End If
    End Sub

    Private Sub cmdAltListChange_Click(sender As Object, e As EventArgs) Handles cmdAltListChange.Click
        If lstAltList.SelectedIndex <> -1 Then
            Dim currentName As String = lstAltList.SelectedItem.ToString()
            Dim input = GetValidInput("Change the name of your alternative:", "Change Alternative", currentName, lstAltList)
            If input IsNot Nothing Then
                lstAltList.Items(lstAltList.SelectedIndex) = input
                UpdateUniqueNamesCheckBox()                         ' Update the checkbox
            End If
        End If
    End Sub

    Private Sub cmdCritListChange_Click(sender As Object, e As EventArgs) Handles cmdCritListChange.Click
        If lstCritList.SelectedIndex <> -1 Then
            Dim currentName As String = lstCritList.SelectedItem.ToString()
            Dim input = GetValidInput("Change the name of your alternative:", "Change Alternative", currentName, lstCritList)
            If input IsNot Nothing Then
                lstCritList.Items(lstCritList.SelectedIndex) = input
                UpdateUniqueNamesCheckBox()                         ' Update the checkbox
            End If
        End If
    End Sub

    Private Sub cmdAltListDelete_Click(sender As Object, e As EventArgs) Handles cmdAltListDelete.Click
        lstAltList.Items.Remove(lstAltList.SelectedItem)
        txtAltCount.Text = lstAltList.Items.Count.ToString()        ' Update the count
        UpdateUniqueNamesCheckBox()                                 ' Update the checkbox
    End Sub

    Private Sub cmdCritListDelete_Click(sender As Object, e As EventArgs) Handles cmdCritListDelete.Click
        lstCritList.Items.Remove(lstCritList.SelectedItem)
        txtCritCount.Text = lstCritList.Items.Count.ToString()      ' Update the count
        UpdateUniqueNamesCheckBox()                                 ' Update the checkbox
    End Sub

    Private Sub cmdAltListUp_Click(sender As Object, e As EventArgs) Handles cmdAltListUp.Click
        MoveItem(lstAltList, -1)
    End Sub

    Private Sub cmdAltListDown_Click(sender As Object, e As EventArgs) Handles cmdAltListDown.Click
        MoveItem(lstAltList, 1)
    End Sub

    Private Sub cmdCritListUp_Click(sender As Object, e As EventArgs) Handles cmdCritListUp.Click
        MoveItem(lstCritList, -1)
    End Sub

    Private Sub cmdCritListDown_Click(sender As Object, e As EventArgs) Handles cmdCritListDown.Click
        MoveItem(lstCritList, 1)
    End Sub

    Private Sub lstAltList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAltList.SelectedIndexChanged
        If lstAltList.SelectedIndex = -1 Then                       ' If no item is selected, disable the buttons
            cmdAltListChange.Enabled = False
            cmdAltListDelete.Enabled = False
            cmdAltListUp.Enabled = False
            cmdAltListDown.Enabled = False
        Else                                                        ' If an item is selected, enable the buttons
            cmdAltListChange.Enabled = True
            cmdAltListDelete.Enabled = True
            cmdAltListUp.Enabled = lstAltList.SelectedIndex <> 0    ' Disable if first item is selected
            cmdAltListDown.Enabled = lstAltList.SelectedIndex <> lstAltList.Items.Count - 1 ' Disable if last item is selected
        End If
        txtAltCount.Text = lstAltList.Items.Count.ToString()        ' Update the count
    End Sub

    Private Sub lstCritList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCritList.SelectedIndexChanged
        If lstCritList.SelectedIndex = -1 Then                      ' If no item is selected, disable the buttons
            cmdCritListChange.Enabled = False
            cmdCritListDelete.Enabled = False
            cmdCritListUp.Enabled = False
            cmdCritListDown.Enabled = False
        Else                                                        ' If an item is selected, enable the buttons
            cmdCritListChange.Enabled = True
            cmdCritListDelete.Enabled = True
            cmdCritListUp.Enabled = lstCritList.SelectedIndex <> 0  ' Disable if first item is selected
            cmdCritListDown.Enabled = lstCritList.SelectedIndex <> lstCritList.Items.Count - 1 ' Disable if last item is selected
        End If
        txtCritCount.Text = lstCritList.Items.Count.ToString()      ' Update the count in the TextBox
    End Sub

    Private Sub UpdateUniqueNamesCheckBox()
        chkAltUniqueNames.Checked = HasUniqueNames(lstAltList)
        chkCritUniqueNames.Checked = HasUniqueNames(lstCritList)
    End Sub

    Private Function GetValidInput(prompt As String, title As String, defaultResponse As String, list As ListBox) As String
        Dim errorMessage As String = Nothing
        While True
            Dim input As String = InputBox(prompt, title, defaultResponse)
            If input = "" Then
                Return Nothing                                      ' Clicked Cancel or closed the InputBox
            ElseIf String.IsNullOrWhiteSpace(input) Then
                errorMessage = "Input cannot be blank. Please enter a valid name."
            ElseIf list.Items.Contains(input) Then
                errorMessage = "This name already exists. Please enter a unique name."
            Else
                Return input
            End If
            If errorMessage IsNot Nothing Then MessageBox.Show(errorMessage, "Invalid Input")
        End While
        Return Nothing
    End Function

    Private Function HasUniqueNames(lst As ListBox) As Boolean
        If lst.Items.Count = 0 Then                                 ' If the list is empty, return False
            Return False
        End If

        Dim names As New HashSet(Of String)
        For Each item As String In lst.Items
            If names.Contains(item) Then
                Return False
            Else
                names.Add(item)
            End If
        Next
        Return True
    End Function

    Private Sub MoveItem(lst As ListBox, direction As Integer)
        If lst.SelectedIndex >= 0 AndAlso lst.SelectedIndex + direction >= 0 AndAlso lst.SelectedIndex + direction < lst.Items.Count Then  ' Ensure there's an item selected and it's not the first or last item
            Dim selectedIndex As Integer = lst.SelectedIndex        ' Store the current selected index
            Dim selectedItem As Object = lst.SelectedItem           ' Store the current item
            lst.Items.RemoveAt(selectedIndex)                       ' Remove the current item
            lst.Items.Insert(selectedIndex + direction, selectedItem) ' Insert the item at the new location
            lst.SelectedIndex = selectedIndex + direction           ' Select the moved item
        End If
    End Sub

    Private Sub cboMcdaMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMcdaMethod.SelectedIndexChanged
        Select Case cboMcdaMethod.SelectedIndex
            Case 3, 4, 5                                            ' assuming the second and third options are at index 3 4 5
                cmdMcdaOptions.Enabled = True
            Case Else
                cmdMcdaOptions.Enabled = False
        End Select

        Select Case cboMcdaMethod.SelectedItem.ToString()
            Case "AHP"
                lblMcdaDesc.Text = "AHP (Analytic Hierarchy Process) is a structured method for organizing and analyzing complex decisions, useful when considering both qualitative and quantitative aspects."
            Case "WSM"
                lblMcdaDesc.Text = "WSM (Weighted Sum Model) involves assigning weights to criteria and summing these for each alternative. Ideal when dealing with mutually exclusive projects or alternatives."
            Case "WPM"
                lblMcdaDesc.Text = "WPM (Weighted Product Model) considers relative importance of criteria by multiplying performance scores raised to the power of assigned weights. Preferred where a benefit to one criterion doesn't compensate a loss in another."
            Case "TOPSIS"
                lblMcdaDesc.Text = "TOPSIS (Technique for Order of Preference by Similarity to Ideal Solution) compares each alternative with an ideal and negative-ideal solution. Suitable when best alternative is closest to the ideal solution and farthest from the negative-ideal solution."
            Case "ELECTRE"
                lblMcdaDesc.Text = "ELECTRE (Elimination and Choice Expressing Reality) eliminates alternatives based on a series of criteria. Best used when you want to eliminate options that do not meet certain minimum standards."
            Case "PROMETHEE"
                lblMcdaDesc.Text = "PROMETHEE (Preference Ranking Organisation Method for Enrichment Evaluations) handles multi-criteria decision-making problems by pairwise comparisons of alternatives. Suits situations where ranking alternatives based on a set of weighted criteria is needed."
        End Select
    End Sub

    Private Sub cmdMcdaOptions_Click(sender As Object, e As EventArgs) Handles cmdMcdaOptions.Click
        MessageBox.Show("This feature is currently in progress and is being developed to provide you with a richer, more intuitive user experience. 
Please check back in a future update.


The options window is akin to an advanced settings panel, designed for those who are familiar with the intricacies of the MCDA methods and would like to make custom adjustments. 

This will allow you to: 
- fine-tune the method according to your needs. 
- tweak the underlying algorithm parameters, adjust thresholds, and more. 
- personalize the MCDA tool to better align with your decision-making process. 

Please use it responsibly, as inappropriate changes could affect the reliability of the decision outcomes.")
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim xlApp As Excel.Application = Globals.ThisAddIn.Application  ' Get the Excel application and active workbook
        Dim xlWorkBook As Excel.Workbook = xlApp.ActiveWorkbook
        Dim xlWorkSheet As Excel.Worksheet = xlWorkBook.ActiveSheet

        Dim state As New ProgramState With {                        ' Initialize the ProgramState with values from the controls
        .MatrixCellRef = txtMatrixCellRef.Text,
        .AltNames = lstAltList.Items.Cast(Of String).ToList(),
        .CritNames = lstCritList.Items.Cast(Of String).ToList(),
        .McdaMethod = cboMcdaMethod.SelectedItem.ToString()
        }

        If ValidateInput() Then
            state.SaveState1ToSheet(xlWorkSheet)
            MessageBox.Show("Current state has been saved to the active worksheet.", "Save Successful")
        End If
    End Sub

    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click
        If String.IsNullOrEmpty(txtMatrixCellRef.Text) OrElse Not Regex.IsMatch(txtMatrixCellRef.Text, "^\$[A-Z]+\$\d+$") Then   ' Ensure MatrixCellRef is not null or empty and is in a valid format
            MessageBox.Show("MatrixCellRef must be a valid cell reference (e.g., $A$1).")
            Return
        End If

        Dim xlApp As Excel.Application = Globals.ThisAddIn.Application  ' Get the Excel application and active workbook
        Dim xlWorkBook As Excel.Workbook = xlApp.ActiveWorkbook
        Dim xlWorkSheet As Excel.Worksheet = xlWorkBook.ActiveSheet

        Try
            Dim state As New ProgramState
            state.LoadStateFromSheet(xlWorkSheet, txtMatrixCellRef.Text)

            cboMcdaMethod.SelectedItem = state.McdaMethod           ' Populate the controls with the loaded data
            lstAltList.Items.Clear()
            For Each altName As String In state.AltNames
                lstAltList.Items.Add(altName)
            Next
            lstCritList.Items.Clear()
            For Each critName As String In state.CritNames
                lstCritList.Items.Add(critName)
            Next
            txtAltCount.Text = lstAltList.Items.Count.ToString()    ' Update the count
            txtCritCount.Text = lstCritList.Items.Count.ToString()
            UpdateUniqueNamesCheckBox()                             ' Update the checkbox
            MessageBox.Show("State has been loaded from the active worksheet.", "Load Successful")
        Catch ex As Exception
            MessageBox.Show($"There was an error loading the state from the active worksheet. Please make sure the worksheet contains a valid saved state. Details: {ex.Message}", "Load Error")
        End Try
    End Sub

    Private Sub cmdResetAll_Click(sender As Object, e As EventArgs) Handles cmdResetAll.Click
        txtMatrixCellRef.Clear()
        txtResultCellRef.Clear()
        txtAltCount.Clear()
        txtCritCount.Clear()
        lstAltList.Items.Clear()
        lstCritList.Items.Clear()
        chkAltUniqueNames.Checked = False
        chkCritUniqueNames.Checked = False
        cboMcdaMethod.SelectedIndex = 0                             ' Select the 0th item/index 1 by default
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        MessageBox.Show("This feature is currently in progress and is being developed to provide you with a richer, more intuitive user experience. 
Please check back in a future update.


This window will provide you: 
- a step-by-step guide for navigating this form through a series of screenshots accompanied by clear instructions that aim to make the process straightforward, regardless of your level of familiarity with the system. 
- clarifications on the form fields, understand what information is required, and know what each part of the form does.")
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        If ValidateInput() Then                                     ' Proceed to the next step if the input is valid
            Dim state As New ProgramState With {                    ' Initialize the ProgramState with values from the controls
            .MatrixCellRef = txtMatrixCellRef.Text,                 ' ResultCellRef = txtResultCellRef.Text,
            .AltNames = lstAltList.Items.Cast(Of String).ToList(),
            .CritNames = lstCritList.Items.Cast(Of String).ToList(),
            .McdaMethod = cboMcdaMethod.SelectedItem.ToString()
        }

            Dim worksheet As Excel.Worksheet = Globals.ThisAddIn.Application.ActiveSheet  ' Save the state to the Excel sheet
            state.SaveState1ToSheet(worksheet)

            Me.Hide()
            Dim step2Form As FStep2Ver2 = New FStep2Ver2(state)             ' Proceed to the next step
            step2Form.ShowDialog()
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        ' Validate matrix cell reference format if it's inputted
        Dim matrixCellRefPattern As String = "^\$[A-Z]+\$\d+$"
        If Not Regex.IsMatch(txtMatrixCellRef.Text, matrixCellRefPattern) Then
            MessageBox.Show("Invalid matrix cell reference. Please enter a valid reference (e.g., $A$1).")
            Return False
        End If
        If String.IsNullOrEmpty(txtMatrixCellRef.Text) Then
            MessageBox.Show("Please enter the starting cell of the Decision Matrix.")
            Return False
        End If

        '' Validate result cell reference format
        'Dim resultCellRefPattern As String = "^\$[A-Z]+\$\d+$"
        'If Not Regex.IsMatch(txtResultCellRef.Text, resultCellRefPattern) Then
        '    MessageBox.Show("Invalid result cell reference. Please enter a valid reference (e.g., $A$1).")
        '    Return False
        'End If
        '' Check if the start cells for the result area has been entered
        'If String.IsNullOrEmpty(txtResultCellRef.Text) Then
        '    MessageBox.Show("Please enter the start cell for the result area.")
        '    Return False
        'End If

        ' Check if the alternatives and criteria lists are not empty
        If lstAltList.Items.Count = 0 Or lstCritList.Items.Count = 0 Then
            MessageBox.Show("Please add at least one alternative and one criteria.")
            Return False
        End If

        ' Check for unique names
        If Not chkAltUniqueNames.Checked Or Not chkCritUniqueNames.Checked Then
            MessageBox.Show("Please ensure all alternative and criteria names are unique.")
            Return False
        End If

        ' Check if an MCDA method has been selected
        If cboMcdaMethod.SelectedIndex = -1 Then
            MessageBox.Show("Please select an MCDA method.")
            Return False
        End If

        '' Check for empty alternatives or criteria (in case of import error)
        'For Each item As String In lstAltList.Items
        '    If String.IsNullOrEmpty(item) Then
        '        MessageBox.Show("Please ensure all alternatives are named.")
        '        Return False
        '    End If
        'Next
        'For Each item As String In lstCritList.Items
        '    If String.IsNullOrEmpty(item) Then
        '        MessageBox.Show("Please ensure all criteria are named.")
        '        Return False
        '    End If
        'Next
        Return True
    End Function
End Class


' #################################################################################################
' #################################### ALTERNATIVE CODES BENCH ####################################
' #################################################################################################

' reduce duplicate code for listbox control

'Private Sub cmdListAdd_Click(sender As Object, e As EventArgs) Handles cmdAltListAdd.Click, cmdCritListAdd.Click
'    Dim clickedButton As Button = CType(sender, Button)
'    Dim input As String
'    Dim listBoxToUpdate As ListBox
'    Dim textBoxToUpdate As TextBox

'    If clickedButton.Name = "cmdAltListAdd" Then
'        input = GetValidInput("Enter the name of your alternative:", "Add an Alternative", "", lstAltList)
'        listBoxToUpdate = lstAltList
'        textBoxToUpdate = txtAltCount
'    Else
'        input = GetValidInput("Enter the name of your criteria:", "Add a Criteria", "", lstCritList)
'        listBoxToUpdate = lstCritList
'        textBoxToUpdate = txtCritCount
'    End If

'    If input IsNot Nothing Then
'        listBoxToUpdate.Items.Add(input)
'        textBoxToUpdate.Text = listBoxToUpdate.Items.Count.ToString() ' Update the count in the TextBox
'        UpdateUniqueNamesCheckBox() ' Update the CheckBox
'    End If
'End Sub

'Private Sub cmdListChange_Click(sender As Object, e As EventArgs) Handles cmdAltListChange.Click, cmdCritListChange.Click
'    Dim clickedButton As Button = CType(sender, Button)
'    Dim listBoxToUpdate As ListBox

'    If clickedButton.Name = "cmdAltListChange" Then
'        listBoxToUpdate = lstAltList
'    Else
'        listBoxToUpdate = lstCritList
'    End If

'    If listBoxToUpdate.SelectedIndex <> -1 Then
'        Dim currentName As String = listBoxToUpdate.SelectedItem.ToString()
'        Dim input = GetValidInput("Change the name of your item:", "Change Item", currentName, listBoxToUpdate)
'        If input IsNot Nothing Then
'            listBoxToUpdate.Items(listBoxToUpdate.SelectedIndex) = input
'            UpdateUniqueNamesCheckBox() ' Update the CheckBox
'        End If
'    End If
'End Sub

'Private Sub cmdListDelete_Click(sender As Object, e As EventArgs) Handles cmdAltListDelete.Click, cmdCritListDelete.Click
'    Dim clickedButton As Button = CType(sender, Button)
'    Dim listBoxToUpdate As ListBox
'    Dim textBoxToUpdate As TextBox

'    If clickedButton.Name = "cmdAltListDelete" Then
'        listBoxToUpdate = lstAltList
'        textBoxToUpdate = txtAltCount
'    Else
'        listBoxToUpdate = lstCritList
'        textBoxToUpdate = txtCritCount
'    End If

'    listBoxToUpdate.Items.Remove(listBoxToUpdate.SelectedItem)          ' Remove the selected item from the list
'    textBoxToUpdate.Text = listBoxToUpdate.Items.Count.ToString()       ' Update the count in the TextBox
'    UpdateUniqueNamesCheckBox()                                         ' Update the CheckBox
'End Sub

'Private Sub cmdListOrder_Click(sender As Object, e As EventArgs) Handles cmdAltListUp.Click, cmdAltListDown.Click, cmdCritListUp.Click, cmdCritListDown.Click
'    Dim clickedButton As Button = CType(sender, Button)
'    Dim listBoxToUpdate As ListBox
'    Dim direction As Integer

'    If clickedButton.Name = "cmdAltListUp" OrElse clickedButton.Name = "cmdCritListUp" Then
'        direction = -1
'    Else
'        direction = 1
'    End If

'    If clickedButton.Name = "cmdAltListUp" OrElse clickedButton.Name = "cmdAltListDown" Then
'        listBoxToUpdate = lstAltList
'    Else
'        listBoxToUpdate = lstCritList
'    End If

'    MoveItem(listBoxToUpdate, direction)
'End Sub

' #################################################################################################

'Private Sub CreateDecisionMatrixWorksheet(state As ProgramState)
'    ' Get the Excel application and active workbook
'    Dim xlApp As Excel.Application = Globals.ThisAddIn.Application
'    Dim xlWorkBook As Excel.Workbook = xlApp.ActiveWorkbook

'    ' Save the current sheet to not lose focus
'    Dim currentWorksheet As Excel.Worksheet = xlApp.ActiveSheet

'    ' Define a base name for the worksheet
'    Dim baseWorksheetName As String = "Decision Matrix"
'    Dim worksheetName As String = baseWorksheetName
'    Dim suffix As Integer = 1

'    ' Check if a worksheet with the desired name already exists
'    While WorksheetExists(worksheetName, xlWorkBook)
'        Dim result As DialogResult = MessageBox.Show($"A worksheet named '{worksheetName}' already exists. Would you like to delete it?", "Worksheet Exists", MessageBoxButtons.YesNo)
'        If result = DialogResult.Yes Then
'            ' User chose to delete the existing worksheet
'            Dim existingWorksheet As Excel.Worksheet = xlWorkBook.Sheets(worksheetName)
'            existingWorksheet.Delete()
'        Else
'            ' User chose to keep the existing worksheet, so append a suffix to the new worksheet name
'            worksheetName = baseWorksheetName & " (" & suffix.ToString() & ")"
'            suffix += 1
'        End If
'    End While

'    ' Add a new worksheet at the end of the workbook
'    Dim xlWorkSheet As Excel.Worksheet = xlWorkBook.Sheets.Add(After:=xlWorkBook.Worksheets(xlWorkBook.Worksheets.Count))
'    xlWorkSheet.Name = worksheetName

'    xlWorkSheet.Cells(2, 1) = "Weights"

'    For i = 0 To state.CritNames.Items.Count - 1
'        xlWorkSheet.Cells(4, i * 3 + 2) = "Min"
'        xlWorkSheet.Cells(4, i * 3 + 3) = "Mid"
'        xlWorkSheet.Cells(4, i * 3 + 4) = "Max"
'    Next

'    For i = 0 To state.CritNames.Items.Count - 1
'        xlWorkSheet.Cells(3, i * 3 + 2) = state.CritNames.Items(i)
'        xlWorkSheet.Range(xlWorkSheet.Cells(3, i * 3 + 2), xlWorkSheet.Cells(3, i * 3 + 4)).Merge()
'        With xlWorkSheet.Range(xlWorkSheet.Cells(3, i * 3 + 2), xlWorkSheet.Cells(3, i * 3 + 4))
'            .Style = "Accent1"
'            .Font.Bold = True
'            .Merge()
'        End With
'    Next

'    For i = 0 To state.AltNames.Items.Count - 1
'        xlWorkSheet.Cells(i + 5, 1) = lstAltList.Items(i)
'        With xlWorkSheet.Cells(i + 5, 1)
'            .Style = "Accent3"
'        End With
'    Next

'    ' Adjust columns width
'    xlWorkSheet.Columns.AutoFit()

'    ' Go back to the original sheet
'    currentWorksheet.Activate()

'    ' Release COM objects
'    ReleaseObject(xlWorkSheet)
'End Sub

'' Function to check if a worksheet with the given name exists in the given workbook
'Private Function WorksheetExists(sheetName As String, book As Excel.Workbook) As Boolean
'    For Each sheet As Excel.Worksheet In book.Sheets
'        If sheet.Name = sheetName Then
'            Return True
'        End If
'    Next
'    ' Worksheet doesn't exist
'    Return False
'End Function

'Private Sub ReleaseObject(ByVal obj As Object)
'    Try
'        System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
'        obj = Nothing
'    Catch ex As Exception
'        obj = Nothing
'    Finally
'        GC.Collect()
'    End Try
'End Sub

' #################################################################################################
