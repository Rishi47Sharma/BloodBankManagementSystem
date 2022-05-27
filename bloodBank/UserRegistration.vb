Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32





Public Class UserRegistration

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

    'Private Sub updateTable()
    '    sqlConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password + ";" + "database =" + database
    '    sqlConn.Open()
    '    sqlcmd.Connection = sqlConn
    '    sqlcmd.CommandText = "select * from userInfo"
    '    sqlRd = sqlcmd.ExecuteReader
    '    sqlDt.Load(sqlRd)
    '    sqlRd.Close()
    '    sqlConn.Close()
    '    DataGridView1.DataSource = sqlDt

    'End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password + ";" + "database =" + database
        Try
            sqlConn.Open()
            sqlQuery = "insert into myconnector.userInfo(uname, ucity, uphone, uemail, upass, ubg) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox1.SelectedItem.ToString() & "')"
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        loginPage.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub UserRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub UserRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    updateTable()
    'End Sub
End Class