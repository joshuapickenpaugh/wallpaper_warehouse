Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Function SingleRollsNeeded(ByVal dblL As Double, ByVal dblW As Double,
                                       ByVal dblH As Double, ByVal dblRC As Double)

        'Declares local variable:
        Dim dblArea As Double
        Dim dblSRN As Double

        'Calculates:
        dblArea = dblL * dblW * dblH
        dblSRN = dblArea / dblRC
        'Add one more roll, just to be safe:
        dblSRN = dblSRN + 1

        Return dblSRN


    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Declares variables:
        Dim dblLength As Double
        Dim dblWidth As Double
        Dim dblHeigth As Double
        Dim dblRollCoverage As Double
        Dim dblSingleRollsNeeded As Double

        'Assigns variables to text boxes:
        Double.TryParse(txtLength.Text, dblLength)
        Double.TryParse(txtWidth.Text, dblWidth)
        Double.TryParse(txtHeight.Text, dblHeigth)
        Double.TryParse(txtRollCoverage.Text, dblRollCoverage)

        'Sends to function for calculation:
        dblSingleRollsNeeded = SingleRollsNeeded(dblLength, dblWidth, dblHeigth, dblRollCoverage)

        lblTotalRolls.Text = dblSingleRollsNeeded.ToString("N0")

    End Sub

    'Private Sub txtLength_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLength.KeyPress

    '    'Allows only numbers, ".", and the backspace key in the text boxes:
    '    If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
    '            e.KeyChar <> "." AndAlso
    '            e.KeyChar <> ControlChars.Back Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtLength_TextChanged(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtLength.TextChanged

    '    'Clears the label:
    '    lblTotalRolls.Text = ""

    'End Sub

    'Private Sub txtWidth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWidth.KeyPress

    '    'Allows only numbers, ".", and the backspace key in the text boxes:
    '    If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
    '            e.KeyChar <> "." AndAlso
    '            e.KeyChar <> ControlChars.Back Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtWidth_TextChanged(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtWidth.TextChanged

    '    'Clears the label:
    '    lblTotalRolls.Text = ""

    'End Sub

    'Private Sub txtHeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHeight.KeyPress

    '    'Allows only numbers, ".", and the backspace key in the text boxes:
    '    If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
    '            e.KeyChar <> "." AndAlso
    '            e.KeyChar <> ControlChars.Back Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtHeight_TextChanged(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtHeight.TextChanged

    '    'Clears the label:
    '    lblTotalRolls.Text = ""

    'End Sub

    'Private Sub txtRollCoverage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRollCoverage.KeyPress

    '    'Allows only numbers, ".", and the backspace key in the text boxes:
    '    If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
    '            e.KeyChar <> "." AndAlso
    '            e.KeyChar <> ControlChars.Back Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtRollCoverage_TextChanged(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtRollCoverage.TextChanged

    '    'Clears the label:
    '    lblTotalRolls.Text = ""

    'End Sub


End Class
