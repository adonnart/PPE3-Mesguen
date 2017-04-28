Public Class modifClient
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myInsert As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    'Connexion à la base de donnees'
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.220.18)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORA18)));Uid=SCOTT;Pwd=estran;"
        myConnection.ConnectionString = connString
        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Affichage des noms des clients'
    Private Sub afficheNomCltModif_Click(sender As System.Object, e As System.EventArgs) Handles afficheNomCltModif.Click
        Dim query As String = "SELECT idCli, nomCli FROM CLIENT"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        nomPdtModif.DataSource = donnee
    End Sub

    'Enregistrement du client
    Private Sub enregistrerCltModif_Click(sender As System.Object, e As System.EventArgs) Handles enregistrerCltModif.Click
        Dim response As MsgBoxResult
        response = MsgBox("Voulez vous confirmer la mise à jour des infos client ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validation")
        If response = MsgBoxResult.Yes Then
            Dim idCli As Integer = nomCliModif.CurrentCell.Value
            Dim adrCli As String = adrCliModif.Text
            Dim descCli As String = descCliModif.Text
            Dim info As String = "Résumé des modifications : " & vbCrLf
            
            info += "N° : " & idCli & vbCrLf & "Nom :" & nomCli & vbCrLf & "Adresse :" & vbCrLf & adrCli & vbCrLf & "Description : " & vbCrLf & descClt & vbCrLf
            info = "UPDATE CLIENT SET ADRCLIENT='" & adrCli & "', DESCRIPTIONCLIENT='" & descCli & "' WHERE ID='" & idCli & "' "
            
            MsgBox(info)
            
            Dim da As New Odbc.OdbcDataAdapter
            Dim cmd As New Odbc.OdbcCommand(info, myConnection)

            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    'Annulation du formulaire'
    Private Sub AnnulerCommande_Click(sender As System.Object, e As System.EventArgs) Handles annuleCltModif.Click
        'Annuler et revenir au choix de l'action, ferme la fenetre en version solo'
        Dim response As MsgBoxResult
            response = MsgBox("Voulez-vous annuler la modification des informations ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Valider")
        If response = MsgBoxResult.Yes Then
            Me.Show()
            Me.Close()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub nomCltModif_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles nomCltModif.CellContentClick

    End Sub
    
    Private Sub adrCltModif_TextChanged(sender As System.Object, e As System.EventArgs) Handles adrCltModif.TextChanged

    End Sub
    
    Private Sub descCltModif_TextChanged(sender As System.Object, e As System.EventArgs) Handles descCltModif.TextChanged

    End Sub

End Class
