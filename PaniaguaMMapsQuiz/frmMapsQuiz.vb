Public Class frmMapsQuiz
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Close()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        btnBusinessJourn.Visible = True
        btnEngineering.Visible = True
        lblCsit1.Visible = True
        lblCsit2.Visible = True
        btnNo.Enabled = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnEngineering_Click(sender As Object, e As EventArgs) Handles btnEngineering.Click
        picEngineering.Visible = True
        picMap.Visible = False
        picBusinessJournalism.Visible = False
        btnExit.Enabled = True
    End Sub

    Private Sub btnBusinessJourn_Click(sender As Object, e As EventArgs) Handles btnBusinessJourn.Click
        picBusinessJournalism.Visible = True
        picMap.Visible = False
        picEngineering.Visible = False
        btnExit.Enabled = True
    End Sub
   
End Class
