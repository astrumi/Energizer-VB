Imports Microsoft.Office.Interop.Excel

Public Class MinMidMaxValues
    Public Property Min As Double?
    Public Property Mid As Double?
    Public Property Max As Double?

    'Public Sub New(min As Double?, mid As Double?, max As Double?)
    Public Sub New(Optional ByVal min As Double = 0, Optional ByVal mid As Double = 0, Optional ByVal max As Double = 0)
        Me.Min = min
        Me.Mid = mid
        Me.Max = max
    End Sub
End Class

Public Class ProgramState
    Public Property MatrixCellRef As String
    Public Property StartingCellRef As String
    Public Property AltNames As List(Of String)
    Public Property CritNames As List(Of String)
    Public Property McdaMethod As String
    Public Property AltValues As New Dictionary(Of String, Dictionary(Of String, MinMidMaxValues))()
    Public Property CritWeights As New Dictionary(Of String, MinMidMaxValues)

    'Public Property ResultCellRef As String
    'Public Property McdaOptions As List(Of String)
    'Public Property EvaluationResult As String

    Public Sub SaveState1ToSheet(worksheet As Worksheet)
        StartingCellRef = MatrixCellRef
        Dim startingCell As Range = worksheet.Range(StartingCellRef)
        ' Headers
        worksheet.Cells(startingCell.Row, startingCell.Column).Value = "MCDA Method:"
        worksheet.Cells(startingCell.Row + 1, startingCell.Column).Value = "Weights"
        For i = 0 To CritNames.Count - 1
            worksheet.Cells(startingCell.Row + 3, startingCell.Column + i * 3 + 1).Value = "Min"
            worksheet.Cells(startingCell.Row + 3, startingCell.Column + i * 3 + 2).Value = "Mid"
            worksheet.Cells(startingCell.Row + 3, startingCell.Column + i * 3 + 3).Value = "Max"
        Next

        ' Contents
        worksheet.Cells(startingCell.Row, startingCell.Column + 1).Value = McdaMethod
        For i As Integer = 0 To CritNames.Count - 1
            worksheet.Cells(startingCell.Row + 2, startingCell.Column + i * 3 + 1).Value = CritNames(i)
            worksheet.Range(worksheet.Cells(startingCell.Row + 2, startingCell.Column + i * 3 + 1), worksheet.Cells(startingCell.Row + 2, startingCell.Column + i * 3 + 3)).Merge()
        Next
        For i As Integer = 0 To AltNames.Count - 1
            worksheet.Cells(startingCell.Row + i + 4, startingCell.Column).Value = AltNames(i)
        Next
        'worksheet.Columns(startingCell.Column).AutoFit()       ' autofit the first column, might be problematic if used with other content
    End Sub

    Public Sub SaveState2ToSheet(worksheet As Worksheet)
        ' Use the saved starting cell reference from FStep1
        Dim startingCell As Range = worksheet.Range(StartingCellRef)
        ' Save the alternative values
        For Each crit In CritNames
            Dim j As Integer = CritNames.IndexOf(crit)
            For Each alt In AltNames
                Dim i As Integer = AltNames.IndexOf(alt)
                Dim values As MinMidMaxValues = AltValues(crit)(alt)
                ' Each criterion has 3 columns (min, mid, max), so we need to offset by j * 3
                worksheet.Cells(startingCell.Row + i + 4, startingCell.Column + j * 3 + 1).Value = values?.Min
                worksheet.Cells(startingCell.Row + i + 4, startingCell.Column + j * 3 + 2).Value = values?.Mid
                worksheet.Cells(startingCell.Row + i + 4, startingCell.Column + j * 3 + 3).Value = values?.Max

                ' Number formatting
                ' Each criterion has 3 columns (min, mid, max), so we need to offset by j * 3
                Dim cellMin As Range = worksheet.Cells(startingCell.Row + i + 4, startingCell.Column + j * 3 + 1)
                Dim cellMid As Range = worksheet.Cells(startingCell.Row + i + 4, startingCell.Column + j * 3 + 2)
                Dim cellMax As Range = worksheet.Cells(startingCell.Row + i + 4, startingCell.Column + j * 3 + 3)
                cellMin.Value = values?.Min
                cellMid.Value = values?.Mid
                cellMax.Value = values?.Max
                ' Set the number format for the cells
                'cellMin.NumberFormat = "0.00"
                'cellMid.NumberFormat = "0.00"
                'cellMax.NumberFormat = "0.00"
                cellMin.NumberFormat = "_-* #,##0.00_-;-* #,##0.00_-;_-* ""-""_-;_-@_-"
                cellMid.NumberFormat = "_-* #,##0.00_-;-* #,##0.00_-;_-* ""-""_-;_-@_-"
                cellMax.NumberFormat = "_-* #,##0.00_-;-* #,##0.00_-;_-* ""-""_-;_-@_-"
            Next
        Next
    End Sub

    Public Sub LoadStateFromSheet(worksheet As Worksheet, Optional startingCellRef As String = Nothing)
        ' If a starting cell reference is provided, update the stored value
        If startingCellRef IsNot Nothing Then
            Me.StartingCellRef = startingCellRef
        End If
        ' Use the stored starting cell reference
        Dim startingCell As Range = worksheet.Range(Me.StartingCellRef)

        ' Read the MCDA method
        McdaMethod = worksheet.Cells(startingCell.Row, startingCell.Column + 1).Value

        ' Read the criterion names
        CritNames = New List(Of String)
        Dim j As Integer = 0
        While True
            Dim cellValue As Object = worksheet.Cells(startingCell.Row + 2, startingCell.Column + j * 3 + 1).Value
            If cellValue Is Nothing Then
                Exit While
            End If
            CritNames.Add(cellValue)
            j += 1
        End While

        ' Read the alternative names
        AltNames = New List(Of String)
        Dim i As Integer = 0
        While True
            Dim cellValue As Object = worksheet.Cells(startingCell.Row + i + 4, startingCell.Column).Value
            If cellValue Is Nothing Then
                Exit While
            End If
            AltNames.Add(cellValue)
            i += 1
        End While

        ' Read the altvalues from each criterion
        For Each crit As String In CritNames
            Dim altValuesDictionary As New Dictionary(Of String, MinMidMaxValues)
            For Each alt As String In AltNames
                Dim row As Integer = AltNames.IndexOf(alt) + startingCell.Row + 4
                Dim col As Integer = CritNames.IndexOf(crit) * 3 + startingCell.Column + 1
                Dim minVal As Double? = TryConvertToDouble(worksheet.Cells(row, col).Value)
                Dim midVal As Double? = TryConvertToDouble(worksheet.Cells(row, col + 1).Value)
                Dim maxVal As Double? = TryConvertToDouble(worksheet.Cells(row, col + 2).Value)
                altValuesDictionary.Add(alt, New MinMidMaxValues(minVal, midVal, maxVal))
            Next
            If AltValues.ContainsKey(crit) Then
                AltValues(crit) = altValuesDictionary
            Else
                AltValues.Add(crit, altValuesDictionary)
            End If
        Next

        ' Read the criterion weights
        Dim weightsRow As Integer = startingCell.Row + 1
        For Each crit As String In CritNames
            Dim col As Integer = CritNames.IndexOf(crit) * 3 + startingCell.Column + 1
            Dim minWeight As Double? = TryConvertToDouble(worksheet.Cells(weightsRow, col).Value)
            Dim midWeight As Double? = TryConvertToDouble(worksheet.Cells(weightsRow, col + 1).Value)
            Dim maxWeight As Double? = TryConvertToDouble(worksheet.Cells(weightsRow, col + 2).Value)
            Dim newWeights = New MinMidMaxValues(minWeight, midWeight, maxWeight)
            If CritWeights.ContainsKey(crit) Then
                CritWeights(crit) = newWeights
            Else
                CritWeights.Add(crit, newWeights)
            End If
        Next
    End Sub

    Private Function TryConvertToDouble(value As Object) As Double?
        Dim result As Double
        If Double.TryParse(value, result) Then
            Return result
        Else
            Return Nothing
        End If
    End Function
End Class




' #################################################################################################
' #################################### ALTERNATIVE CODES BENCH ####################################
' #################################################################################################

