Public Class CU03_modif_commande

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myInsert As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    Private Sub CU03_modif_commande_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.23.80)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));Uid=mesguen3;Pwd=Estran;"
        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim col1 As New DataGridViewTextBoxColumn
        col1.DataPropertyName = "PropertyName"
        col1.HeaderText = "produit"
        col1.Name = "produit"
        NouveauPanier.Columns.Add(col1)

        Dim col2 As New DataGridViewTextBoxColumn
        col2.DataPropertyName = "PropertyName"
        col2.HeaderText = "nb palettes"
        col2.Name = "nb palettes"
        NouveauPanier.Columns.Add(col2)

        Dim col3 As New DataGridViewTextBoxColumn
        col3.DataPropertyName = "PropertyName"
        col3.HeaderText = "idproduit"
        col3.Name = "idproduit"
        produitsSuppr.Columns.Add(col3)

        Dim query As String = "SELECT * FROM PRODUIT"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        GridListeProduits.DataSource = donnee

        Dim query2 As String = "SELECT LIEUID,LIEUNOM FROM LIEU"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query2, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        GridVilleDepart.DataSource = donnee

        Dim query3 As String = "SELECT LIEUID,LIEUNOM FROM LIEU"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query3, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        GridVilleArrivee.DataSource = donnee

        Dim id_commande As String = Label4.Text
        Dim query4 As String = "SELECT PRODUITID,NBPRODUIT FROM COMMANDE_PRODUIT WHERE COMMANDEID = " & id_commande
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query4, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        Panier.DataSource = donnee

        GridListeProduits.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Panier.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GridVilleDepart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GridVilleArrivee.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub PalettesMoins_Click(sender As System.Object, e As System.EventArgs) Handles PalettesMoins.Click

        NbPalettes.Text -= 1

    End Sub

    Private Sub PalettesPlus_Click(sender As System.Object, e As System.EventArgs) Handles PalettesPlus.Click

        NbPalettes.Text += 1

    End Sub

    Private Sub AjouterProduit_Click(sender As System.Object, e As System.EventArgs) Handles AjouterProduit.Click

        Dim sb As New System.Text.StringBuilder()
        sb.Append(GridListeProduits.SelectedRows(0).Cells(0).Value.ToString)
        NouveauPanier.Rows.Add(New String() {sb.ToString, NbPalettes.Text})

    End Sub

    'Supprimer Gauche'
    Private Sub SupprimerLigneNouveauPanier_Click(sender As System.Object, e As System.EventArgs) Handles SupprimerLigneNouveauPanier.Click

        For Each row As DataGridViewRow In Panier.SelectedRows
            NouveauPanier.Rows.Remove(row)
        Next

    End Sub

    'Supprimer Droite'
    Private Sub SupprimerLignePanier_Click(sender As System.Object, e As System.EventArgs) Handles SupprimerLignePanier.Click

        Dim response As MsgBoxResult
        response = MsgBox("Voulez vous confirmer la suppression de cette ligne ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
    
        If response = MsgBoxResult.Yes Then
            Dim sb As New System.Text.StringBuilder()
            sb.Append(Panier.SelectedRows(0).Cells(0).Value.ToString)
            produitsSuppr.Rows.Add(New String() {sb.ToString, NbPalettes.Text})
            For Each row As DataGridViewRow In Panier.SelectedRows
                Panier.Rows.Remove(row)
            Next
        End If

    End Sub

    'OK Gauche'
    Private Sub ConfirmeRechercheVD_Click(sender As System.Object, e As System.EventArgs) Handles ConfirmeRechercheVD.Click

        Dim nom_ville As String = RechercheVilleDepart.Text.ToUpper
        Dim query As String = "SELECT LIEUID,LIEUNOM FROM LIEU WHERE LIEUNOM = '" & nom_ville & "'"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        GridVilleDepart.DataSource = donnee

    End Sub

    'OK Droite'
    Private Sub ConfirmeRechercheVA_Click(sender As System.Object, e As System.EventArgs) Handles ConfirmeRechercheVA.Click

        Dim nom_ville As String = RechercheVilleArrivee.Text.ToUpper
        Dim query As String = "SELECT LIEUID,LIEUNOM FROM LIEU WHERE LIEUNOM = '" & nom_ville & "'"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        GridVilleArrivee.DataSource = donnee

    End Sub

    'Confirmer'
    Private Sub ConfirmerCommande_Click(sender As System.Object, e As System.EventArgs) Handles ConfirmerCommande.Click
    
        Dim response As MsgBoxResult
        response = MsgBox("Voulez vous confirmer la modification de la commande ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")

        If response = MsgBoxResult.Yes Then

            Dim no_commande As String = Label4.Text.Last()

            Dim nb_palettes_tot As Integer = 0
            Dim nb_palettes As Integer = 0
            Dim num_prod As Integer = 0
            Dim arrivee As String = "0"
            Dim depart As String = "0"
            Dim info As String = "0"

            Dim RowCount2 As Integer

            'Parcours comparaison entre Panier et NouveauPanier

            RowCount2 = Panier.Rows.Count
            If RowCount2 > 0 Then
                For i As Integer = 0 To Panier.Rows.Count - 2
                    nb_palettes_tot += Panier.Rows(i).Cells(1).Value
                Next
            End If

            RowCount2 = NouveauPanier.Rows.Count
            If RowCount2 > 0 Then
                For i As Integer = 0 To Panier.Rows.Count - 2
                    MessageBox.Show(i)
                    nb_palettes_tot += NouveauPanier.Rows(i).Cells(1).Value
                Next
            End If

            Dim selectedRowCount3 As Integer = GridVilleDepart.Rows.GetRowCount(DataGridViewElementStates.Selected)
            Dim selectedRowCount4 As Integer = GridVilleArrivee.Rows.GetRowCount(DataGridViewElementStates.Selected)

            If selectedRowCount3 > 0 And selectedRowCount4 > 0 Then
                depart = GridVilleDepart.SelectedRows(0).Cells(0).Value.ToString
                arrivee = GridVilleArrivee.SelectedRows(0).Cells(0).Value.ToString

            ElseIf selectedRowCount3 > 0 And selectedRowCount4 = 0 Then
                Dim query As String = "SELECT LIEUARRIVEE FROM COMMANDE WHERE COMMANDEID = " & no_commande
                donnee = New DataTable
                myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
                myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
                myAdapter.Fill(donnee)
                arrivee = donnee.Rows(0)(0).ToString
                depart = GridVilleDepart.SelectedRows(0).Cells(0).Value.ToString

            ElseIf selectedRowCount3 = 0 And selectedRowCount4 > 0 Then
                Dim query As String = "SELECT LIEUDEPART FROM COMMANDE WHERE COMMANDEID = " & no_commande
                donnee = New DataTable
                myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
                myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
                myAdapter.Fill(donnee)
                depart = donnee.Rows(0)(0).ToString
                arrivee = GridVilleArrivee.SelectedRows(0).Cells(0).Value.ToString

            ElseIf selectedRowCount3 = 0 And selectedRowCount4 = 0 Then
                Dim query As String = "SELECT LIEUDEPART,LIEUARRIVEE FROM COMMANDE WHERE COMMANDEID = " & no_commande
                donnee = New DataTable
                myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
                myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
                myAdapter.Fill(donnee)
                arrivee = donnee.Rows(0)(0).ToString
                depart = donnee.Rows(0)(1).ToString

            End If

            info = "UPDATE COMMANDE SET NBPRODUITS_TOTAL = " & nb_palettes_tot & ", LIEUDEPART = '" & depart & "', LIEUARRIVEE = '" & arrivee & "' WHERE COMMANDEID = " & no_commande
            MessageBox.Show(info)
            Dim da As New Odbc.OdbcDataAdapter
            Dim cmd As New Odbc.OdbcCommand(info, myConnection)
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()

            If produitsSuppr.Rows.Count <= 2 Then
                For i As Integer = 0 To produitsSuppr.Rows.Count - 2

                    info = "DELETE FROM COMMANDE_PRODUIT WHERE COMMANDEID = " & no_commande & " AND PRODUITID = " & produitsSuppr.Rows(i).Cells(0).Value
                    da = New Odbc.OdbcDataAdapter
                    cmd = New Odbc.OdbcCommand(info, myConnection)
                    da.DeleteCommand = cmd
                    da.DeleteCommand.ExecuteNonQuery()

                Next
            End If

            If NouveauPanier.Rows.Count <= 2 Then
                For i As Integer = 0 To NouveauPanier.Rows.Count - 2

                    num_prod = NouveauPanier.Rows(i).Cells(0).Value
                    nb_palettes = NouveauPanier.Rows(i).Cells(1).Value

                    Dim query As String = "SELECT COMMANDEID,PRODUITID FROM COMMANDE_PRODUIT WHERE COMMANDEID = " & no_commande & " AND PRODUITID = " & num_prod
                    donnee = New DataTable
                    myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
                    myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
                    myAdapter.Fill(donnee)

                    If donnee Is Nothing Then
                        info = "INSERT INTO COMMANDE_PRODUIT VALUES " & _
                        "(" & no_commande & " ," & num_prod & "," & nb_palettes & ")"
                        da = New Odbc.OdbcDataAdapter
                        cmd = New Odbc.OdbcCommand(info, myConnection)
                        da.InsertCommand = cmd
                        da.InsertCommand.ExecuteNonQuery()

                    Else
                        info = "UPDATE COMMANDE_PRODUIT SET NBPRODUIT = " & nb_palettes & "WHERE COMMANDEID = " & no_commande & " AND PRODUITID = " & num_prod
                        da = New Odbc.OdbcDataAdapter
                        cmd = New Odbc.OdbcCommand(info, myConnection)
                        da.InsertCommand = cmd
                        da.InsertCommand.ExecuteNonQuery()

                    End If

                Next
            End If

            MessageBox.Show("Insertion effectuée.")

            CU02_choix.Show()
            Me.Close()

        End If

    End Sub

    'Annuler'
    Private Sub AnnulerCommande_Click(sender As System.Object, e As System.EventArgs) Handles AnnulerCommande.Click

        Dim response As MsgBoxResult
        response = MsgBox("Voulez vous arrêter la prise de commande ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            CU02_choix.Show()
            Me.Close()
        End If

    End Sub

End Class