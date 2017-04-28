Public Class modifClient
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myInsert As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    'connexion à la base de donnees
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.220.18)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORA18)));Uid=SCOTT;Pwd=estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'affichage des noms de client
    Private Sub afficheNomPdtModif_Click(sender As System.Object, e As System.EventArgs) Handles afficheNomPdtModif.Click
        Dim query As String = "SELECT ID, NOMCLIENT FROM CLIENT"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        nomPdtModif.DataSource = donnee
    End Sub

    Private Sub enregistrerPdtModif_Click(sender As System.Object, e As System.EventArgs) Handles enregistrerPdtModif.Click
        Dim response As MsgBoxResult
        response = MsgBox("Voulez vous confirmer la mise à jour des infos client ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validation")
        If response = MsgBoxResult.Yes Then
            Dim cltId As Integer = nomCltModif.CurrentCell.Value
            Dim adrClt As String = adrCltModif.Text
            Dim descClt As String = descCltModif.Text
            Dim info As String = "Résumé des modifications : " & vbCrLf
            info += "n° de client : " & cltId & vbCrLf & "adresse client :" & vbCrLf & adrClt & vbCrLf & "description du client : " & vbCrLf & descClt & vbCrLf

            info = "UPDATE CLIENT SET ADRCLIENT='" & adrClt & "', DESCRIPTIONCLIENT='" & descClt & "' WHERE ID='" & cltId & "' "
            MsgBox(info)
            Dim da As New Odbc.OdbcDataAdapter

            Dim cmd As New Odbc.OdbcCommand(info, myConnection)

            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()

        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    'annulation du form
    Private Sub AnnulerCommande_Click(sender As System.Object, e As System.EventArgs) Handles annulePdtModif.Click
        'annuler et revenir au choix de l'action, ferme la fenetre en version solo
        Dim response As MsgBoxResult
        response = MsgBox("Voulez vous annuler la modifications des informations?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Valider")
        If response = MsgBoxResult.Yes Then
            Me.Show()
            Me.Close()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub descPdtModif_TextChanged(sender As System.Object, e As System.EventArgs) Handles descPdtModif.TextChanged

    End Sub

    Private Sub codePdtModif_TextChanged(sender As System.Object, e As System.EventArgs) Handles codePdtModif.TextChanged

    End Sub

    Private Sub nomPdtModif_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles nomPdtModif.CellContentClick

    End Sub
End Class
