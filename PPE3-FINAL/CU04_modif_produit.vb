Public Class CU04_modif_produit

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myInsert As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    Private Sub CU04_modif_produit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.23.80)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));Uid=mesguen3;Pwd=Estran;"
        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim query As String = "SELECT PRODUITID, NOMPRODUIT FROM PRODUIT"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        nomPdtModif.DataSource = donnee

        nomPdtModif.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub enregistrerPdtModif_Click(sender As System.Object, e As System.EventArgs) Handles enregistrerPdtModif.Click

        Dim pdtId As Integer = nomPdtModif.SelectedRows(0).Cells(0).Value.ToString
        Dim codePdt As String = codePdtModif.Text
        Dim commPdt As String = commPdtModif.Text

        Dim req As String = "UPDATE PRODUIT SET CODEPRODUIT = '" & codePdt & "', COMMENTAIREPRODUIT = '" & commPdt & "' WHERE PRODUITID = '" & pdtId & "' "

        Dim reponse As MsgBoxResult
        Dim da As New Odbc.OdbcDataAdapter
        Dim cmd As New Odbc.OdbcCommand(req, myConnection)

        da.UpdateCommand = cmd
        da.UpdateCommand.ExecuteNonQuery()

        reponse = MsgBox("Mise à jour des informations effectuée." & vbCrLf & "Voulez-vous modifier d'autres produits ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)

        If reponse = MsgBoxResult.Yes Then
            Me.codePdtModif.Text = ""
            Me.commPdtModif.Text = ""
        ElseIf reponse = MsgBoxResult.No Then
            Dim choix As New CU02_choix
            choix.Show()
            Me.Close()
        End If

    End Sub

    Private Sub AnnulerModif_Click(sender As System.Object, e As System.EventArgs) Handles annulePdtModif.Click

        Dim response As MsgBoxResult
        response = MsgBox("Voulez-vous annuler la modification des informations ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Valider")
        If response = MsgBoxResult.Yes Then
            Dim choix As New CU02_choix
            choix.Show()
            Me.Close()
        ElseIf response = MsgBoxResult.No Then
            Me.Show()
        End If

    End Sub

End Class
