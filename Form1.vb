Public Class Form1


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim frm As New Form1
        frm.Show()

        Close()
    End Sub

    Private Sub RWUButton_Click(sender As Object, e As EventArgs) Handles RWUButton.Click
        Dim unused = Process.Start("ResetWinUpdate.bat")
    End Sub


    Private Sub NRButton_Click(sender As Object, e As EventArgs) Handles NRButton.Click
        Dim unused = Process.Start("ResetNetwork.bat")
    End Sub

    Private Sub GPUButton_Click(sender As Object, e As EventArgs) Handles GPUButton.Click
        Dim unused = Process.Start("GPUpdate.bat")
    End Sub

    Private Sub LQAButton_Click(sender As Object, e As EventArgs) Handles LQAButton.Click

    End Sub
End Class
