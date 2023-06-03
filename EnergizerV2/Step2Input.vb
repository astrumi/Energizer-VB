Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms

Public Class UCStep2Input

    Private ReadOnly _state As ProgramState
    ' Declare Dictionaries
    Private ReadOnly picBoxes As New Dictionary(Of String, PictureBox)
    Private ReadOnly lblFollows As New Dictionary(Of String, Label)
    Private ReadOnly lblLocs As New Dictionary(Of String, Label)
    Private ReadOnly isMouseDown As New Dictionary(Of String, Boolean)
    Private ReadOnly mouseDownY As New Dictionary(Of String, Integer)

    Private Const upperBound As Integer = 0
    Private Const lowerBound As Integer = 300

    ' Declare instance variables to store references to the textboxes
    Private txtMin As TextBox
    Private txtMid As TextBox
    Private txtMax As TextBox
    Private textBoxes As New Dictionary(Of String, TextBox)

    Private radOpt1 As RadioButton
    Private radOpt2 As RadioButton
    Private radOpt3 As RadioButton
    Private radioButtons As New Dictionary(Of String, RadioButton)

    Public Property CritName As String
        Get
            Return lblCritName.Text
        End Get
        Set(value As String)
            lblCritName.Text = value
        End Set
    End Property

    Public Sub New(state As ProgramState)
        ' This call is required by the designer.
        InitializeComponent()
        _state = state
        ' Add any initialization after the InitializeComponent() call.
        pnlDetails.Visible = False
        cmdExpandCollapse.Text = "Expand"
        cmdExpandCollapse.BackColor = SystemColors.Control
        cmdExpandCollapse.FlatAppearance.BorderColor = SystemColors.ControlDark
        cmdExpandCollapse.FlatAppearance.BorderSize = 0
    End Sub

    Public Sub InitializeAlternatives(altNames As List(Of String))
        ' Assign critName
        Me.CritName = CritName

        ' Populate the table view
        For Each alt As String In altNames
            ' Create the controls
            Dim lblAltName As New Label()
            lblAltName.Text = alt
            lblAltName.AutoSize = True

            ' Add radio buttons
            Dim radOpt1 As New RadioButton()
            Dim radOpt2 As New RadioButton()
            Dim radOpt3 As New RadioButton()

            radOpt1.AutoSize = True
            radOpt2.AutoSize = True
            radOpt3.AutoSize = True

            ' Add the radio buttons to the dictionary
            radioButtons.Add(alt & "min", radOpt1)
            radioButtons.Add(alt & "mid", radOpt2)
            radioButtons.Add(alt & "max", radOpt3)

            ' Add panel
            Dim pnlRadOpt As New FlowLayoutPanel()
            pnlRadOpt.AutoSize = True
            pnlRadOpt.Padding = New Padding(0)
            pnlRadOpt.FlowDirection = FlowDirection.LeftToRight
            pnlRadOpt.WrapContents = False

            ' Add radio buttons to the panel
            pnlRadOpt.Controls.Add(radOpt1)
            pnlRadOpt.Controls.Add(radOpt2)
            pnlRadOpt.Controls.Add(radOpt3)

            ' Add textboxes
            Dim txtMin As New TextBox()
            Dim txtMid As New TextBox()
            Dim txtMax As New TextBox()
            txtMin = New TextBox()
            txtMid = New TextBox()
            txtMax = New TextBox()

            txtMin.Enabled = False
            txtMin.Dock = DockStyle.Fill
            txtMin.TextAlign = HorizontalAlignment.Center
            AddHandler txtMin.KeyPress, AddressOf TextBox_KeyPress

            txtMid.Enabled = False
            txtMid.Dock = DockStyle.Fill
            txtMid.TextAlign = HorizontalAlignment.Center
            AddHandler txtMid.KeyPress, AddressOf TextBox_KeyPress

            txtMax.Enabled = False
            txtMax.Dock = DockStyle.Fill
            txtMax.TextAlign = HorizontalAlignment.Center
            AddHandler txtMax.KeyPress, AddressOf TextBox_KeyPress

            ' Add the TextBoxes to the dictionary
            textBoxes.Add(alt & "min", txtMin)
            textBoxes.Add(alt & "mid", txtMid)
            textBoxes.Add(alt & "max", txtMax)

            ' Add event handlers for the RadioButtons
            AddHandler radOpt1.CheckedChanged, Sub(s As Object, e1 As EventArgs)
                                                   txtMin.Text = ""
                                                   txtMax.Text = ""
                                                   txtMid.Enabled = radOpt1.Checked
                                               End Sub

            AddHandler radOpt2.CheckedChanged, Sub(s As Object, e2 As EventArgs)
                                                   txtMid.Text = ""
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

        Next


        ' Populate the ranking ladder
        Dim offset As Integer = 0

        ' List of colors
        Dim colors As List(Of Color) = New List(Of Color) From {Color.Navy, Color.OliveDrab, Color.LightSkyBlue, Color.LightSteelBlue, Color.DarkOrange, Color.Goldenrod, Color.LightSlateGray, Color.Maroon, Color.DodgerBlue, Color.DarkKhaki}

        For i As Integer = 0 To altNames.Count - 1
            Dim alt = altNames(i)

            ' Calculate the index of the color for this PictureBox
            Dim colorIndex As Integer = i Mod colors.Count

            ' Create the controls
            Dim picBox As New PictureBox With {
                .Size = New Size(30, 15),
                .BackColor = colors(colorIndex),  ' Use the color from the list
                .Location = New Point(0, offset),
                .BorderStyle = BorderStyle.None,
                .SizeMode = PictureBoxSizeMode.Zoom
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
                                                 'lblLoc.Text = alt & " " & picBox.Top.ToString()
                                                 Dim score As Integer = 100 - (picBox.Top / lowerBound) * 100
                                                 lblLoc.Text = alt & " " & score.ToString()
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

    Private Sub btnExpandCollapse_Click(sender As Object, e As EventArgs) Handles cmdExpandCollapse.Click
        pnlDetails.Visible = Not pnlDetails.Visible
        If pnlDetails.Visible Then
            cmdExpandCollapse.Text = "Collapse"
            cmdExpandCollapse.BackColor = SystemColors.ControlDark
            cmdExpandCollapse.FlatAppearance.BorderColor = SystemColors.ControlDarkDark
            cmdExpandCollapse.FlatAppearance.BorderSize = 1
        Else
            cmdExpandCollapse.Text = "Expand"
            cmdExpandCollapse.BackColor = SystemColors.Control
            cmdExpandCollapse.FlatAppearance.BorderColor = SystemColors.ControlDark
            cmdExpandCollapse.FlatAppearance.BorderSize = 0
        End If
    End Sub

    Private Sub pnlDetails_VisibleChanged(sender As Object, e As EventArgs) Handles pnlDetails.VisibleChanged
        If pnlDetails.Visible Then
            Me.Height = pnlOverview.Height + pnlDetails.Height
        Else
            Me.Height = pnlOverview.Height
        End If
    End Sub

    Public Function GetAlternativeValues() As Dictionary(Of String, MinMidMaxValues)
        Dim result As New Dictionary(Of String, MinMidMaxValues)
        For Each altName In _state.AltNames
            ' Retrieve TextBox controls from the Dictionary
            Dim txtMin As TextBox = textBoxes(altName & "min")
            Dim txtMid As TextBox = textBoxes(altName & "mid")
            Dim txtMax As TextBox = textBoxes(altName & "max")

            ' +takes empty as 0 +takes negatives +takes decimal
            Dim minVal As Double? = If(String.IsNullOrEmpty(txtMin.Text), Nothing, Double.Parse(txtMin.Text, CultureInfo.InvariantCulture))
            Dim midVal As Double? = If(String.IsNullOrEmpty(txtMid.Text), Nothing, Double.Parse(txtMid.Text, CultureInfo.InvariantCulture))
            Dim maxVal As Double? = If(String.IsNullOrEmpty(txtMax.Text), Nothing, Double.Parse(txtMax.Text, CultureInfo.InvariantCulture))

            result.Add(altName, New MinMidMaxValues(minVal, midVal, maxVal))
        Next
        Return result
    End Function

    Public Sub SetAlternativeValues(AltValues As Dictionary(Of String, MinMidMaxValues))
        For Each alt As String In AltValues.Keys
            Dim values As MinMidMaxValues = AltValues(alt)
            textBoxes(alt & "min").Text = values.Min.ToString()
            textBoxes(alt & "mid").Text = values.Mid.ToString()
            textBoxes(alt & "max").Text = values.Max.ToString()
        Next
    End Sub

    Public Sub ResetTable()
        ' Reset the radio buttons
        For Each radOpt1 In radioButtons.Values
            radOpt1.Checked = False
        Next
        For Each radOpt2 In radioButtons.Values
            radOpt2.Checked = False
        Next
        For Each radOpt3 In radioButtons.Values
            radOpt3.Checked = False
        Next

        ' Reset and disable the text boxes
        For Each txtMin In textBoxes.Values
            txtMin.Text = ""
            txtMin.Enabled = False
        Next
        For Each txtMid In textBoxes.Values
            txtMid.Text = ""
            txtMid.Enabled = False
        Next
        For Each txtMax In textBoxes.Values
            txtMax.Text = ""
            txtMax.Enabled = False
        Next
    End Sub

    Public Sub ResetRanking()
        For Each alt As String In picBoxes.Keys
            Dim picBox = picBoxes(alt)
            picBox.Top = 150
            Dim lblFollow = lblFollows(alt)
            lblFollow.Top = 150
            Dim lblLoc = lblLocs(alt)
            Dim score As Integer = 100 - (picBox.Top / lowerBound) * 100
            lblLoc.Text = alt & " " & score.ToString()
        Next
    End Sub

    Private Sub cmdTableReset_Click(sender As Object, e As EventArgs) Handles cmdTableReset.Click
        ResetTable()
    End Sub

    Private Sub cmdRankingReset_Click(sender As Object, e As EventArgs) Handles cmdRankingReset.Click
        ResetRanking()
    End Sub

End Class


' #################################################################################################
' #################################### ALTERNATIVE CODES BENCH ####################################
' #################################################################################################


'' attempt to update the radiobuttons & textboxes based on the empty values
'Public Sub SetAlternativeValues(AltValues As Dictionary(Of String, MinMidMaxValues))
'    'For Each alt In AltValues.Keys
'    '    Dim values = AltValues(alt)
'    For Each alt As String In AltValues.Keys
'        Dim values As MinMidMaxValues = AltValues(alt)
'        Dim minVal = values.Min
'        Dim midVal = values.Mid
'        Dim maxVal = values.Max

'        ' Identify how many empty strings exist in the dictionary
'        Dim emptyCount = 0
'        If Not minVal.HasValue OrElse minVal.Value = 0 Then emptyCount += 1
'        If Not midVal.HasValue OrElse midVal.Value = 0 Then emptyCount += 1
'        If Not maxVal.HasValue OrElse maxVal.Value = 0 Then emptyCount += 1

'        ' Check the corresponding radio button and enable the right textboxes
'        Select Case emptyCount
'            Case 2 ' Only 1 value exists
'                radOpt1.Checked = True
'                txtMid.Enabled = True
'                txtMid.Text = If(midVal.HasValue, midVal.ToString(), String.Empty)
'            Case 1 ' 2 values exist
'                radOpt2.Checked = True
'                txtMin.Enabled = True
'                txtMax.Enabled = True
'                txtMin.Text = If(minVal.HasValue, minVal.ToString(), String.Empty)
'                txtMax.Text = If(maxVal.HasValue, maxVal.ToString(), String.Empty)
'            Case 0 ' All values exist
'                radOpt3.Checked = True
'                txtMin.Enabled = True
'                txtMid.Enabled = True
'                txtMax.Enabled = True
'                txtMin.Text = minVal.ToString()
'                txtMid.Text = midVal.ToString()
'                txtMax.Text = maxVal.ToString()
'            Case Else ' Do nothing
'        End Select
'    Next
'End Sub


