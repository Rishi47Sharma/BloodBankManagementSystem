
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32






Public Class BloodBankRegitration

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




    Private Sub BloodBankRegitration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sqlConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password + ";" + "database =" + database
        sqlConn.Open()
        sqlQuery = "insert into myconnector.bbank(bname, bcity, bphone, bemail ) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
        sqlcmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlcmd.ExecuteReader
            sqlConn.Close()
            MessageBox.Show("Record Add Successfully")



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        loginPage.Show()
        Me.Hide()
    End Sub
End Class