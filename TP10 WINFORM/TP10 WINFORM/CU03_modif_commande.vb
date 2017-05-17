Public Class CU03_modif_commande

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myInsert As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable
    Dim temp As Integer


    Private Sub Form_Open(sender As System.Object, e As System.EventArgs) Handles Me.Load

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

        'CU02_choix.connectSub()

        connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.23.80)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));Uid=mesguen3;Pwd=Estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()

            'MessageBox.Show("ca marche")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try


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
        Dim query4 As String = "SELECT PRODUITID,NBPRODUIT FROM COMMANDE_PRODUIT where COMMANDEID = " & id_commande
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




    Private Sub Recherche_TextChanged(sender As System.Object, e As System.EventArgs) Handles Recherche.TextChanged

    End Sub

    Private Sub ConfirmeRechercheProduits_Click(sender As System.Object, e As System.EventArgs)

        Dim nom_prod As Integer = Recherche.Text
        Dim query As String = "SELECT * FROM PRODUIT where NOMPRODUIT = " & nom_prod
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        GridListeProduits.DataSource = donnee

    End Sub

    Private Sub GridListeProduits_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub




    Private Sub NbPalettes_TextChanged(sender As System.Object, e As System.EventArgs)

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

    Private Sub NouveauPanier_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles NouveauPanier.CellContentClick

    End Sub

    Private Sub SupprimerLigneNouveauPanier_Click(sender As System.Object, e As System.EventArgs) Handles SupprimerLigneNouveauPanier.Click

        For Each row As DataGridViewRow In Panier.SelectedRows
            NouveauPanier.Rows.Remove(row)
        Next



    End Sub




    Private Sub Panier_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub SupprimerLignePanier_Click(sender As System.Object, e As System.EventArgs) Handles SupprimerLignePanier.Click

        Dim response As MsgBoxResult
        response = MsgBox("Voulez vous Confirmer la suppression de cette ligne?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then

            Dim sb As New System.Text.StringBuilder()
            sb.Append(Panier.SelectedRows(0).Cells(0).Value.ToString)
            produitsSuppr.Rows.Add(New String() {sb.ToString, NbPalettes.Text})

            For Each row As DataGridViewRow In Panier.SelectedRows
                Panier.Rows.Remove(row)
            Next

        ElseIf response = MsgBoxResult.No Then

            Exit Sub

        End If

    End Sub

    Private Sub produitsSuppr_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles produitsSuppr.CellContentClick

    End Sub




    Private Sub RechercheVilleDepart_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ConfirmeRechercheVD_Click(sender As System.Object, e As System.EventArgs) Handles ConfirmeRechercheVD.Click

        Dim nom_ville As String = RechercheVilleDepart.Text.ToUpper
        Dim query As String = "SELECT LIEUID,LIEUNOM FROM LIEU where LIEUNOM = '" & nom_ville & "'"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        GridVilleDepart.DataSource = donnee

    End Sub

    Private Sub GridVilleDepart_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub




    Private Sub RechercheVilleArrivee_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ConfirmeRechercheVA_Click(sender As System.Object, e As System.EventArgs) Handles ConfirmeRechercheVA.Click

        Dim nom_ville As String = RechercheVilleDepart.Text.ToUpper
        Dim query As String = "SELECT LIEUID,LIEUNOM FROM LIEU where LIEUNOM = '" & nom_ville & "'"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        GridVilleDepart.DataSource = donnee

    End Sub

    Private Sub GridVilleArrivee_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridVilleArrivee.CellContentClick

    End Sub




    Private Sub ConfirmerCommande_Click(sender As System.Object, e As System.EventArgs) Handles ConfirmerCommande.Click
        Dim response As MsgBoxResult
        response = MsgBox("Voulez vous Confirmer la modification de commande?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then

            Dim no_commande As String = Label4.Text.Last()

            Dim nb_palettes_tot As Integer = 0
            Dim nb_palettes As Integer = 0
            Dim arrivee As String = "0"
            Dim depart As String = "0"
            Dim num_prod As Integer = 0

            Dim info As String = "0"

            Dim RowCount2 As Integer = Panier.Rows.Count
            If RowCount2 > 0 Then
                For i As Integer = 0 To Panier.Rows.Count - 2
                    nb_palettes_tot += Panier.Rows(i).Cells(1).Value
                Next
            End If
            RowCount2 = NouveauPanier.Rows.Count
            If RowCount2 > 0 Then
                For i As Integer = 0 To Panier.Rows.Count - 2
                    nb_palettes_tot += NouveauPanier.Rows(i).Cells(1).Value
                Next
            End If

            Dim selectedRowCount3 As Integer = GridVilleDepart.Rows.GetRowCount(DataGridViewElementStates.Selected)
            Dim selectedRowCount4 As Integer = GridVilleArrivee.Rows.GetRowCount(DataGridViewElementStates.Selected)

            If selectedRowCount3 > 0 And selectedRowCount4 > 0 Then
                depart = GridVilleDepart.SelectedRows(0).Cells(1).Value.ToString
                arrivee = GridVilleArrivee.SelectedRows(0).Cells(1).Value.ToString

            ElseIf selectedRowCount3 > 0 And selectedRowCount4 = 0 Then
                Dim query As String = "SELECT LIEUARRIVEE from commande where COMMANDEID = " & no_commande
                donnee = New DataTable
                myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
                myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
                myAdapter.Fill(donnee)
                arrivee = donnee.Rows(0)(0).ToString
                depart = GridVilleDepart.SelectedRows(0).Cells(1).Value.ToString

            ElseIf selectedRowCount3 = 0 And selectedRowCount4 > 0 Then
                Dim query As String = "SELECT LIEUDEPART from commande where COMMANDEID = " & no_commande
                donnee = New DataTable
                myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
                myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
                myAdapter.Fill(donnee)
                depart = donnee.Rows(0)(0).ToString
                arrivee = GridVilleArrivee.SelectedRows(0).Cells(1).Value.ToString

            ElseIf selectedRowCount3 = 0 And selectedRowCount4 = 0 Then
                Dim query As String = "SELECT LIEUDEPART,LIEUARRIVEE from commande where COMMANDEID = " & no_commande
                donnee = New DataTable
                myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
                myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
                myAdapter.Fill(donnee)
                arrivee = donnee.Rows(0)(0).ToString
                depart = donnee.Rows(0)(1).ToString


            End If


            info = "update COMMANDE set NBPRODUITS_TOTAL = " & nb_palettes_tot & ", LIEUDEPART = '" & depart & "', LIEUARRIVEE = '" & arrivee & "' where COMMANDEID = " & no_commande
            MessageBox.Show(info)
            Dim da As New Odbc.OdbcDataAdapter
            Dim cmd As New Odbc.OdbcCommand(info, myConnection)
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()

            If produitsSuppr.Rows.Count <= 2 Then
                For i As Integer = 0 To produitsSuppr.Rows.Count - 2

                    'MessageBox.Show(i)
                    info = "delete from COMMANDE_PRODUIT where COMMANDEID = " & no_commande & " and PRODUITID = " & produitsSuppr.Rows(i).Cells(0).Value

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
                    info = "INSERT INTO COMMANDE_PRODUIT values " & _
                    "(" & no_commande & " ," & num_prod & "," & nb_palettes & ")"
                    'MessageBox.Show(info)
                    da = New Odbc.OdbcDataAdapter
                    cmd = New Odbc.OdbcCommand(info, myConnection)
                    da.InsertCommand = cmd
                    da.InsertCommand.ExecuteNonQuery()

                Next
            End If

            MessageBox.Show("Insertion effectuée")

            Dim choix As New CU02_choix
            choix.Show()
            Me.Close()


        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub AnnulerCommande_Click(sender As System.Object, e As System.EventArgs) Handles AnnulerCommande.Click

        Dim response As MsgBoxResult
        response = MsgBox("Voulez vous arreter la prise de commande?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            Dim commande As New CU03_listecommande
            commande.Show()
            commande.Label2.Text = Label3.Text
            Me.Close()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

End Class