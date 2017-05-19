Public Class CU03_commande

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myInsert As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    Private Sub CU03_commande_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        Panier.Columns.Add(col1)

        Dim col2 As New DataGridViewTextBoxColumn
        col2.DataPropertyName = "PropertyName"
        col2.HeaderText = "nb_palettes"
        col2.Name = "nb_palettes"
        Panier.Columns.Add(col2)

        Dim query1 As String = "SELECT * FROM PRODUIT"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query1, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        GridListeProduits.DataSource = donnee

        Dim query2 As String = "SELECT LIEUID,LIEUNOM FROM LIEU"

        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query2, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        GridVilleDepart.DataSource = donnee

        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query2, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        GridVilleArrivee.DataSource = donnee

        Panier.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GridListeProduits.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GridVilleDepart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GridVilleArrivee.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub ConfirmeRechercheProduits_Click(sender As System.Object, e As System.EventArgs)

        Dim nom_prod As Integer = Recherche.Text
        Dim query As String = "SELECT * FROM PRODUIT WHERE NOMPRODUIT = " & nom_prod
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        GridListeProduits.DataSource = donnee

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
        Panier.Rows.Add(New String() {sb.ToString, NbPalettes.Text})

    End Sub

    Private Sub SupprimerLignePanier_Click(sender As System.Object, e As System.EventArgs) Handles SupprimerLignePanier.Click

        For Each row As DataGridViewRow In Panier.SelectedRows
            Panier.Rows.Remove(row)
        Next

    End Sub

    Private Sub ConfirmeRechercheVD_Click(sender As System.Object, e As System.EventArgs) Handles ConfirmeRechercheVD.Click

        Dim nom_ville As String = RechercheVilleDepart.Text
        Dim query As String = "SELECT LIEUID,LIEUNOM FROM LIEU WHERE LIEUNOM = '" & nom_ville & "'"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        GridVilleDepart.DataSource = donnee

    End Sub

    Private Sub ConfirmeRechercheVA_Click(sender As System.Object, e As System.EventArgs) Handles ConfirmeRechercheVA.Click

        Dim nom_ville As String = RechercheVilleDepart.Text.ToUpper
        Dim query As String = "SELECT LIEUID,LIEUNOM FROM LIEU WHERE LIEUNOM = '" & nom_ville & "'"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        GridVilleDepart.DataSource = donnee

    End Sub

    Private Sub ConfirmerCommande_Click(sender As System.Object, e As System.EventArgs) Handles ConfirmerCommande.Click
    
        Dim response As MsgBoxResult
        response = MsgBox("Voulez vous confirmer la prise de commande ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then

            Dim info As String
            'Dim no_commande As Integer = 0

            'Dim query As String = "SELECT count(*) from commande"
            'donnee = New DataTable
            'myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
            'myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
            'myAdapter.Fill(donnee)

            'If donnee.Rows(0)(0) = 0 Then
            '    no_commande = 1
            'Else
            '    query = "SELECT max(ID_COMMANDE) from commande"
            '    donnee = New DataTable
            '    myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
            '    myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
            '    myAdapter.Fill(donnee)

            '    Dim MaxId As Integer = donnee.Rows(0)(0)
            '    no_commande = MaxId + 1
            'End If

            Dim nb_palettes_tot As Integer = 0
            Dim nb_palettes As Integer = 0
            Dim num_prod As Integer = 0
            Dim arrivee As String = "0"
            Dim depart As String = "0"

            Dim selectedRowCount2 As Integer = Panier.Rows.GetRowCount(DataGridViewElementStates.Selected)
            If selectedRowCount2 > 0 Then
                For i As Integer = 0 To Panier.Rows.Count - 2
                   nb_palettes_tot += Panier.Rows(i).Cells(1).Value
                Next
            End If

            Dim selectedRowCount3 As Integer = GridVilleDepart.Rows.GetRowCount(DataGridViewElementStates.Selected)
            Dim selectedRowCount4 As Integer = GridVilleArrivee.Rows.GetRowCount(DataGridViewElementStates.Selected)

            If selectedRowCount3 > 0 And selectedRowCount4 > 0 Then
                depart = GridVilleDepart.SelectedRows(0).Cells(0).Value.ToString
                arrivee = GridVilleArrivee.SelectedRows(0).Cells(0).Value.ToString
            Else
                MessageBox.Show("Sélectionnez une ville de départ et d'arrivée.")
                Exit Sub
            End If

            Dim nom_client As String = Label2.Text
            Dim query As String = "SELECT CLIID FROM CLIENT WHERE CLINOM = '" & nom_client & "'"
            donnee = New DataTable
            myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
            myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
            myAdapter.Fill(donnee)
            Dim cliid As Integer = donnee.Rows(0)(0)

            info = "INSERT INTO COMMANDE (NBPRODUITS_TOTAL,TRNNUM,CLIID,LIEUDEPART,LIEUARRIVEE)" & _
                   "values (" & nb_palettes_tot & ",1," & cliid & ",'" & arrivee & "','" & depart & "')"

            Dim da As New Odbc.OdbcDataAdapter
            Dim cmd As New Odbc.OdbcCommand(info, myConnection)
            da.InsertCommand = cmd
            da.InsertCommand.ExecuteNonQuery()

            query = "SELECT MAX(COMMANDEID) FROM COMMANDE"
            donnee = New DataTable
            myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
            myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
            myAdapter.Fill(donnee)

            Dim MaxId As Integer = donnee.Rows(0)(0)

            For i As Integer = 0 To Panier.Rows.Count - 2
                num_prod = Panier.Rows(i).Cells(0).Value
                nb_palettes = Panier.Rows(i).Cells(1).Value
                info = "INSERT INTO COMMANDE_PRODUIT VALUES " & _
                "(" & MaxId & " ," & num_prod & "," & nb_palettes & ")"

                da = New Odbc.OdbcDataAdapter
                cmd = New Odbc.OdbcCommand(info, myConnection)
                da.InsertCommand = cmd
                da.InsertCommand.ExecuteNonQuery()
            Next

            MessageBox.Show("Insertion effectuée.")

            Dim choix As New CU02_choix
            choix.Show()
            Me.Close()

        End If
    
    End Sub

    Private Sub AnnulerCommande_Click(sender As System.Object, e As System.EventArgs) Handles AnnulerCommande.Click

        Dim response As MsgBoxResult
        response = MsgBox("Voulez vous arrêter la prise de commande ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            CU02_choix.Show()
            Me.Close()
        End If
        
    End Sub

End Class
