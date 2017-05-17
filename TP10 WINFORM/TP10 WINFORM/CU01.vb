Public Class CU01
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As Collection

  

    Private Sub CU01_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CU02_choix.connectSub()

        connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.23.80)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));Uid=mesguen3;Pwd=Estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()

            'MessageBox.Show("ca marche")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
    End Sub
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
    End Sub
    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click
    End Sub
    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim query As String = "SELECT emplLoggin, emplMdp FROM employe WHERE emplLoggin='" & TextBox1.Text & "' AND emplMdp='" & TextBox2.Text & "'"
        donnee = New Collection

        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        While myReader.Read
            donnee.Add(myReader.GetString(0))
        End While

        If donnee.Count > 0 Then
            CU02_choix.Show()
            Me.Close()
        Else
            MessageBox.Show("Connexion Échouée")
        End If

        myConnection.Close()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub


End Class