
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32








Public Class RequestOFBlood
    Dim sqlConn As New MySqlConnection
    Dim sqlcmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlQuery As String


    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = "Admin@123"
    Dim database As String = "myconnector"


    Private bitmap As Bitmap

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        sqlConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password + ";" + "database =" + database
        Try
            sqlConn.Open()
            sqlQuery = "insert into myconnector.rblood(  btype, bhosp, bcity,bquatity) values('" & ComboBox1.SelectedItem.ToString() & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox1.Text & "')"
            sqlcmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlcmd.ExecuteReader
            sqlConn.Close()
            MessageBox.Show("Record Add Successfully")
        Catch ex As Exception
            MessageBox.Show("something went wrong")
        Finally
            sqlConn.Dispose()
        End Try
        'updateTable()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HospitalPage.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class