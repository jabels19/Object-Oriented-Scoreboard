Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'message to show about box'

        MessageBox.Show("Soccer Team Score Keeper by Joel Black")
    End Sub

    Private Sub btnAddPlayer_Click(sender As Object, e As EventArgs) Handles btnAddPlayer.Click
        'calls add players1 function in main module'
        AddPlayers1()

    End Sub

    Private Sub btnViewPoints_Click(sender As Object, e As EventArgs) Handles btnViewPoints.Click
        If lstNames.Items.Count = 0 Or lstNames.SelectedIndex = -1 Then
            'gives error message if something typed in wrong'
            ErrorMessage()
        Else
            'calls the display name and display points funcitons'
            DisplayName()
            DisplayPoints()

        End If
    End Sub

    Private Sub btnAddPoints_Click(sender As Object, e As EventArgs) Handles btnAddPoints.Click
        If lstNames.Items.Count = 0 Or lstNames.SelectedIndex = -1 Then
            ErrorMessage()
        Else
            'calls the calculate, name, points fucntions'
            Calculate()
            DisplayName()
            DisplayPoints()

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits the applications'
        Me.Close()

    End Sub
End Class