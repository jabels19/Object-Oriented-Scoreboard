Public Class AddPlayers
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        If Integer.TryParse(txtNumPlayers.Text, intNumberofPlayers) And
                intNumberofPlayers > 0 Then

            'arrays for names and points'
            'array siae is the number of players entered'

            ReDim strNames(intNumberofPlayers)
            ReDim Preserve strPoints(intNumberofPlayers)

            For intCount = 0 To intNumberofPlayers - 1

                'creates an input box and counts the number of players entered and adds 1'
                strNames(intCount) = InputBox("Enter player" & (intCount + 1) & "name")
                frmMainForm.lstNames.Items.Add(strNames((intCount)))
            Next
            Me.Close()
            frmMainForm.Show()
        Else

            'error to show if anything other than a positive integer is entered'
            MessageBox.Show("Please enter a positve Integer")

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmMainForm.Show()
    End Sub
End Class