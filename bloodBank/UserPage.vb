Public Class UserPage
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ListOfBloodBank.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Donate.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you Want To exit", "BLOOD BANK SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()

        End If
    End Sub

    Private Sub UserPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class