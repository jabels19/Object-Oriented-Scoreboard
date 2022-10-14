Module MainModule
    'vairalbes to be used throughout program' 

    Public strPlayers As String
    Public intNumberofPlayers As Integer
    Public intIndex As Integer
    Public intTotalPoints As Integer

    'strNames() and strPoints as arrayswith ()

    Public strNames() As String
    Public strPoints() As Integer
    Public frmMainForm As New MainForm
    Public frmAddPlayers As New AddPlayers


    Public Sub AddPlayers1()
        MainForm.Hide()
        frmAddPlayers.ShowDialog()

    End Sub
    Public Sub DisplayName()
        'takes names entered from index'

        strPlayers = strNames(frmMainForm.lstNames.SelectedIndex)


    End Sub
    Public Sub DisplayPoints()

        'displays the players points'

        frmMainForm.lblPlayerPoints.Text = strPoints(frmMainForm.lstNames.SelectedIndex).ToString()
        frmMainForm.lblTotalPoints.Text = intTotalPoints.ToString()

    End Sub
    Public Sub Calculate()

        'takes the points and adds 1 to total points'
        intTotalPoints += 1
        strPoints(frmMainForm.lstNames.SelectedIndex) += 1

    End Sub
    Public Sub ErrorMessage()
        MessageBox.Show("Add player to list or select a player")
    End Sub
End Module
