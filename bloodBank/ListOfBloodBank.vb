Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32











Public Class ListOfBloodBank
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
    Private Sub updateTable()
        sqlConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password + ";" + "database =" + database
        sqlConn.Open()
        sqlcmd.Connection = sqlConn
        sqlcmd.CommandText = "select hname,hcity,hphone,hemail from hosinfo"
        sqlRd = sqlcmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        DataGridView1.DataSource = sqlDt

    End Sub







    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    Private Sub ListOfBloodBank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub


End Class