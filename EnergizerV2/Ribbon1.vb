Imports System.Windows.Forms
Imports Microsoft.Office.Tools.Ribbon

Public Class Ribbon1

    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    Private Sub SplitButton1_Click(sender As Object, e As RibbonControlEventArgs) Handles splbtnRun.Click

        ''#1 if no validation
        'Dim step1Form As New FStep1()
        'step1Form.ShowDialog()

        ' with ProgramState
        Dim state As New ProgramState() ' Create a new state with default values
        Dim step1Form As New FStep1(state)
        step1Form.ShowDialog()

        ''#2 Get the name of the active workbook
        ''Dim activeWorkbookName As String = Globals.ThisAddIn.Application.ActiveWorkbook.Name

        '' Check if a form already exists for this workbook
        ''If Globals.ThisAddIn.ActiveForms.ContainsKey(activeWorkbookName) Then
        ''    ' Bring the existing form to the front
        ''    With Globals.ThisAddIn.ActiveForms(activeWorkbookName)
        ''        .BringToFront()
        ''        .WindowState = FormWindowState.Normal
        ''    End With
        ''Else
        ''    ' Create a new form and add it to the dictionary
        ''    Dim step1Form As New FStep1
        ''    Globals.ThisAddIn.ActiveForms.Add(activeWorkbookName, step1Form)

        ''    ' Show the new form
        ''    step1Form.Show()
        ''End If

        ''#3 Get the name of the active workbook
        'Dim activeWorkbookName As String = Globals.ThisAddIn.Application.ActiveWorkbook.Name

        '' Check if any forms already exist for this workbook
        'If Globals.ThisAddIn.ActiveForms.ContainsKey(activeWorkbookName) AndAlso Globals.ThisAddIn.ActiveForms(activeWorkbookName).Count > 0 Then
        '    ' Bring the most recently opened form to the front
        '    With Globals.ThisAddIn.ActiveForms(activeWorkbookName).Last()
        '        .BringToFront()
        '        .WindowState = FormWindowState.Normal
        '    End With
        'Else
        '    ' Create a new form and add it to the dictionary
        '    Dim newForm As New FStep1
        '    If Not Globals.ThisAddIn.ActiveForms.ContainsKey(activeWorkbookName) Then
        '        Globals.ThisAddIn.ActiveForms.Add(activeWorkbookName, New List(Of Form) From {newForm})
        '    Else
        '        Globals.ThisAddIn.ActiveForms(activeWorkbookName).Add(newForm)
        '    End If
        '    ' Show the new form
        '    newForm.Show()
        'End If

        ''#4
        'Dim activeWorkbookName As String = Globals.ThisAddIn.Application.ActiveWorkbook.Name
        'Dim activeForm As Form = Nothing

        'If Globals.ThisAddIn.ActiveForms.ContainsKey(activeWorkbookName) Then
        '    activeForm = Globals.ThisAddIn.ActiveForms(activeWorkbookName)
        '    activeForm.BringToFront()
        'Else
        '    activeForm = New FStep1()
        '    Globals.ThisAddIn.ActiveForms.Add(activeWorkbookName, activeForm)
        '    activeForm.Show()
        'End If

        ''#5
        'Dim activeWorkbookName As String = Globals.ThisAddIn.Application.ActiveWorkbook.Name

        'If Globals.ThisAddIn.ActiveForms.ContainsKey(activeWorkbookName) Then
        '    Dim activeFormsList As List(Of Form) = Globals.ThisAddIn.ActiveForms(activeWorkbookName)
        '    For Each activeForm As Form In activeFormsList
        '        If activeForm IsNot Nothing And Not activeForm.IsDisposed Then
        '            activeForm.BringToFront()
        '        End If
        '    Next
        'Else
        '    Dim newForm As New FStep1()
        '    Globals.ThisAddIn.ActiveForms.Add(activeWorkbookName, New List(Of Form) From {newForm})
        '    newForm.ShowDialog() ' Make the form modal
        'End If

    End Sub

    Private Sub btnRun_Click(sender As Object, e As RibbonControlEventArgs) Handles btnRun.Click
        Dim state As New ProgramState() ' Create a new state with default values
        Dim step1Form As New FStep1(state)
        step1Form.ShowDialog()
    End Sub

End Class
