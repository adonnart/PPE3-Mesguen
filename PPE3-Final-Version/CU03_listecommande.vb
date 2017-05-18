Public Class CU03_listecommande
    
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myInsert As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable
    Dim temp As Integer

    Private Sub CU03_listecommande_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.23.80)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));Uid=mesguen3;Pwd=Estran;"
        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim Client As String = Label3.Text

        Dim query As String = "SELECT COMMANDEID,NBPRODUITS_TOTAL,LIEUDEPART,LIEUARRIVEE FROM COMMANDE where CLIID = '" & Client & "'"

        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        DataGridView1.DataSource = donnee
        DataGridView1.Rows(0).Selected = True

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        
        Dim commande As New CU03_commande
        commande.Show()
        commande.Label2.Text = Label2.Text
        Me.Close()
        
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Dim selectedRowCount As Integer = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)

        If selectedRowCount > 0 Then
            
            Dim response As MsgBoxResult
            response = MsgBox("Voulez-vous supprimer cette commande ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")

            If response = MsgBoxResult.Yes Then
                Dim id_commande As Integer = DataGridView1.SelectedRows(0).Cells(0).Value.ToString

                Dim query As String = "DELETE FROM COMMANDE_PRODUIT WHERE COMMANDEID = " & id_commande
                Dim da As New Odbc.OdbcDataAdapter
                Dim cmd As New Odbc.OdbcCommand(query, myConnection)
                da.InsertCommand = cmd
                da.InsertCommand.ExecuteNonQuery()

                query = "DELETE FROM COMMANDE WHERE COMMANDEID = " & id_commande
                da = New Odbc.OdbcDataAdapter
                cmd = New Odbc.OdbcCommand(query, myConnection)
                da.InsertCommand = cmd
                da.InsertCommand.ExecuteNonQuery()

                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    DataGridView1.Rows.Remove(row)
                Next
                Exit Sub
            ElseIf response = MsgBoxResult.No Then
                Exit Sub
            End If
        Else
            MessageBox.Show("Veuillez selectionner une commande à supprimer.")
            Exit Sub
        End If
        
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        
        Dim selectedRowCount As Integer = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)

        If selectedRowCount > 0 Then
            Dim modif_commande As New CU03_modif_commande
            modif_commande.Label3.Text = Label2.Text
            modif_commande.Label4.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            modif_commande.Show()
            Me.Close()
        Else
            MessageBox.Show("Veuillez selectionner une commande à modifier.")
            Exit Sub
        End If
        
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
    
        CU02_choix.Show()
        Me.Close()
    
    End Sub
    
End Class
