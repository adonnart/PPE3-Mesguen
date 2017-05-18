Public Class modifProduit
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
        'connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.220.18)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORA18)));Uid=SCOTT;Pwd=estran;"

        connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.220.217)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORA17)));Uid=Matt;Pwd=estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim query As String = "SELECT PRODUITID, NOMPRODUIT,CODEPRODUIT FROM PRODUIT"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        nomPdtModif.DataSource = donnee

    End Sub


    Private Sub enregistrerPdtModif_Click(sender As System.Object, e As System.EventArgs) Handles enregistrerPdtModif.Click

        Dim reponse As MsgBoxResult
        
            Dim pdtId As Integer = nomPdtModif.CurrentCell.Value
            Dim codePdt As String = codePdtModif.Text
            Dim descPdt As String = descPdtModif.Text
            Dim info As String = "Résumé des modifications : " & vbCrLf
            info += "n° de produit : " & pdtId & vbCrLf & "code produit :" & vbCrLf & codePdt & vbCrLf & "description du produit : " & vbCrLf & descPdt & vbCrLf

        info = "UPDATE PRODUIT SET CODEPRODUIT='" & codePdt & "', COMMENTAIREPRODUIT='" & descPdt & "' WHERE PRODUITID='" & pdtId & "' "

            Dim da As New Odbc.OdbcDataAdapter

            Dim cmd As New Odbc.OdbcCommand(info, myConnection)


            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
        reponse = MsgBox("Mise à jour des informations produit effectuée!" & vbCrLf & " Voulez-vous modifier d'autres produits?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)

        If reponse = MsgBoxResult.Yes Then
            Me.codePdtModif.Text = ""
            Me.descPdtModif.Text = ""
        ElseIf reponse = MsgBoxResult.No Then
            Dim choix As New CU02_choix
            choix.Show()
            Me.Close()

        End If
        
    End Sub




    'annulation du form
    Private Sub AnnulerModif_Click(sender As System.Object, e As System.EventArgs) Handles annulePdtModif.Click
        'annuler et revenir au choix de l'action, ferme la fenetre en version solo
        Dim response As MsgBoxResult
        response = MsgBox("Voulez vous annuler la modifications des informations?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Valider")
        If response = MsgBoxResult.Yes Then
            Me.Show()
            Me.Close()
        ElseIf response = MsgBoxResult.No Then
            Dim choix As New CU02_choix
            choix.Show()
            Me.Close()
        End If
    End Sub

    Private Sub descPdtModif_TextChanged(sender As System.Object, e As System.EventArgs) Handles descPdtModif.TextChanged

    End Sub

    Private Sub codePdtModif_TextChanged(sender As System.Object, e As System.EventArgs) Handles codePdtModif.TextChanged

    End Sub

    Private Sub nomPdtModif_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles nomPdtModif.CellContentClick



    End Sub


End Class
