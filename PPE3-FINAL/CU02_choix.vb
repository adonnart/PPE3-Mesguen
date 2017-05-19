Public Class CU02_choix

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myInsert As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    Private Sub CU02_choix_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.23.80)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));Uid=mesguen3;Pwd=Estran;"
        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim query As String = "SELECT * FROM CLIENT"

        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)

        DataGridView1.DataSource = donnee
        DataGridView1.Rows(0).Selected = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    'Commandes'
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim selectedRowCount As Integer = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)

        If selectedRowCount > 0 Then
            Dim commande As New CU03_listecommande
            commande.Label2.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            commande.Label3.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            commande.Show()
            Me.Close()
        Else
            MessageBox.Show("Sélectionnez un client.")
            Exit Sub
        End If

    End Sub

    'Produits'
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Dim produits As New CU04_modif_produit
        produits.Show()
        Me.Close()

    End Sub

    'Clients'
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Dim clients As New CU05_modif_client
        clients.Show()
        Me.Close()
 
    End Sub

    'Déconnexion'
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
            
        Me.Close()
            
    End Sub
        
End Class
