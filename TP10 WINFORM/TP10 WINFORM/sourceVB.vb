﻿'Module sourceVB
'    Dim cat As ADOX.Catalog
'    Dim tbl As ADOX.Table


'    Sub main()


'        Dim nomBase As String
'        nomBase = System.AppDomain.CurrentDomain.BaseDirectory()
'        nomBase = nomBase & txtNomBase.Text & ".mdb"

'        ' Creer la nouvelle database.
'        cat = New ADOX.Catalog
'        Try
'            cat.Create("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & nomBase & ";")

'        Catch ex As Exception
'            MessageBox.Show(ex.Message)
'            Exit Sub

'        End Try


'        tbl = New ADOX.Table
'        tbl.Name = txtNomTable.Text
'        cat.Tables.Append(tbl)


'        Dim nomBase As String
'        nomBase = System.AppDomain.CurrentDomain.BaseDirectory()
'        nomBase = nomBase & txtNomBase.Text & ".mdb"

'        If File.Exists(nomBase) Then
'            MsgBox(nomBase)
'            Kill(nomBase)
'        End If


'        tbl = Nothing
'        cat = Nothing


'    End Sub


'End Module
