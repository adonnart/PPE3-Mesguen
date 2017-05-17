Public Class CU05_modif_client

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myInsert As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    Private Sub CU05_modif_client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.23.80)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));Uid=mesguen3;Pwd=Estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim query As String = "SELECT CLIID, CLINOM FROM CLIENT"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        nomCliModif.DataSource = donnee

        nomCliModif.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub enregistrerCliModif_Click(sender As System.Object, e As System.EventArgs) Handles enregisterCliModif.Click

        Dim cltId As Integer = nomCliModif.SelectedRows(0).Cells(0).Value.ToString
        Dim adrClt As String = adrCliModif.Text
        Dim telClt As String = telCliModif.Text
        Dim commClt As String = descCliModif.Text

        Dim req As String = "UPDATE CLIENT SET CLIADRESSE = '" & adrClt & "', CLITEL = '" & telClt & "', CLIDESC = '" & commClt & "' WHERE CLIID = '" & cltId & "' "

        Dim reponse As MsgBoxResult
        Dim da As New Odbc.OdbcDataAdapter
        Dim cmd As New Odbc.OdbcCommand(req, myConnection)

        da.UpdateCommand = cmd
        da.UpdateCommand.ExecuteNonQuery()

        reponse = MsgBox("Mise à jour des informations effectuée." & vbCrLf & "Voulez-vous modifier d'autres clients ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)

        If reponse = MsgBoxResult.Yes Then
            Me.adrCliModif.Text = ""
            Me.telCliModif.Text = ""
            Me.descCliModif.Text = ""
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

    Private Sub nomCliModif_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles nomCliModif.CellContentClick

    End Sub
End Class