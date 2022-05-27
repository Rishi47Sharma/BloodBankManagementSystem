Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32








Public Class loginPage

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
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password + ";" + "database =" + database
        Try
            sqlConn.Open()
            sqlQuery = "select hemail,hpassword from myconnector.hosinfo where hemail='" & TextBox1.Text & "' AND hpassword='" & TextBox2.Text & "'"
            sqlcmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlcmd.ExecuteReader

            If sqlRd.Read() = 0 Then
                MessageBox.Show("INVALID USER/PASSWORD")
            Else
                HospitalPage.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MessageBox.Show("")
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        hospRegiteration.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sqlConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password + ";" + "database =" + database
        Try
            sqlConn.Open()
            sqlQuery = "select uemail,upass from myconnector.userInfo where uemail='" & TextBox3.Text & "' AND upass='" & TextBox4.Text & "'"
            sqlcmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlcmd.ExecuteReader

            If sqlRd.Read() = 0 Then
                MessageBox.Show("INVALID USER/PASSWORD")
            Else
                UserPage.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MessageBox.Show("")
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UserRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ManagerRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sqlConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password + ";" + "database =" + database
        Try
            sqlConn.Open()
            sqlQuery = "select mid ,mpass from myconnector.maninfo where mid='" & TextBox6.Text & "' AND mpass='" & TextBox5.Text & "'"
            sqlcmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlcmd.ExecuteReader

            If sqlRd.Read() = 0 Then
                MessageBox.Show("INVALID USER/PASSWORD")
            Else
                ManagerPage.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MessageBox.Show("")
        Finally
            sqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        BloodBankRegitration.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub
End Class