<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CU05_modif_client
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nomCliModif = New System.Windows.Forms.DataGridView()
        Me.titreModifPdt = New System.Windows.Forms.Label()
        Me.nomPdtModifTxt = New System.Windows.Forms.Label()
        Me.adrCliModif = New System.Windows.Forms.TextBox()
        Me.adrCliTxt = New System.Windows.Forms.Label()
        Me.descPdtModifTxt = New System.Windows.Forms.Label()
        Me.descCliModif = New System.Windows.Forms.TextBox()
        Me.enregisterCliModif = New System.Windows.Forms.Button()
        Me.annulePdtModif = New System.Windows.Forms.Button()
        Me.telCliModif = New System.Windows.Forms.TextBox()
        Me.telCliTxt = New System.Windows.Forms.Label()
        CType(Me.nomCliModif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nomCliModif
        '
        Me.nomCliModif.BackgroundColor = System.Drawing.Color.White
        Me.nomCliModif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.nomCliModif.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.nomCliModif.Location = New System.Drawing.Point(213, 87)
        Me.nomCliModif.Name = "nomCliModif"
        Me.nomCliModif.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.HighlightText
        Me.nomCliModif.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.nomCliModif.Size = New System.Drawing.Size(326, 171)
        Me.nomCliModif.TabIndex = 0
        '
        'titreModifPdt
        '
        Me.titreModifPdt.AutoSize = True
        Me.titreModifPdt.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titreModifPdt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.titreModifPdt.Location = New System.Drawing.Point(277, 35)
        Me.titreModifPdt.Name = "titreModifPdt"
        Me.titreModifPdt.Size = New System.Drawing.Size(186, 24)
        Me.titreModifPdt.TabIndex = 1
        Me.titreModifPdt.Text = "Modification client"
        Me.titreModifPdt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nomPdtModifTxt
        '
        Me.nomPdtModifTxt.AutoSize = True
        Me.nomPdtModifTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomPdtModifTxt.Location = New System.Drawing.Point(160, 87)
        Me.nomPdtModifTxt.Name = "nomPdtModifTxt"
        Me.nomPdtModifTxt.Size = New System.Drawing.Size(47, 16)
        Me.nomPdtModifTxt.TabIndex = 2
        Me.nomPdtModifTxt.Text = "Nom :"
        '
        'adrCliModif
        '
        Me.adrCliModif.Location = New System.Drawing.Point(213, 264)
        Me.adrCliModif.Name = "adrCliModif"
        Me.adrCliModif.Size = New System.Drawing.Size(326, 20)
        Me.adrCliModif.TabIndex = 3
        '
        'adrCliTxt
        '
        Me.adrCliTxt.AutoSize = True
        Me.adrCliTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adrCliTxt.Location = New System.Drawing.Point(136, 265)
        Me.adrCliTxt.Name = "adrCliTxt"
        Me.adrCliTxt.Size = New System.Drawing.Size(71, 16)
        Me.adrCliTxt.TabIndex = 4
        Me.adrCliTxt.Text = "Adresse :"
        '
        'descPdtModifTxt
        '
        Me.descPdtModifTxt.AutoSize = True
        Me.descPdtModifTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descPdtModifTxt.Location = New System.Drawing.Point(103, 317)
        Me.descPdtModifTxt.Name = "descPdtModifTxt"
        Me.descPdtModifTxt.Size = New System.Drawing.Size(104, 16)
        Me.descPdtModifTxt.TabIndex = 5
        Me.descPdtModifTxt.Text = "Commentaire :"
        '
        'descCliModif
        '
        Me.descCliModif.AutoCompleteCustomSource.AddRange(New String() {"rrtty"})
        Me.descCliModif.Location = New System.Drawing.Point(213, 316)
        Me.descCliModif.Multiline = True
        Me.descCliModif.Name = "descCliModif"
        Me.descCliModif.Size = New System.Drawing.Size(326, 164)
        Me.descCliModif.TabIndex = 6
        '
        'enregisterCliModif
        '
        Me.enregisterCliModif.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enregisterCliModif.Location = New System.Drawing.Point(270, 486)
        Me.enregisterCliModif.Name = "enregisterCliModif"
        Me.enregisterCliModif.Size = New System.Drawing.Size(86, 23)
        Me.enregisterCliModif.TabIndex = 8
        Me.enregisterCliModif.Text = "Enregistrer"
        Me.enregisterCliModif.UseVisualStyleBackColor = True
        '
        'annulePdtModif
        '
        Me.annulePdtModif.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.annulePdtModif.Location = New System.Drawing.Point(377, 486)
        Me.annulePdtModif.Name = "annulePdtModif"
        Me.annulePdtModif.Size = New System.Drawing.Size(86, 23)
        Me.annulePdtModif.TabIndex = 9
        Me.annulePdtModif.Text = "Annuler"
        Me.annulePdtModif.UseVisualStyleBackColor = True
        '
        'telCliModif
        '
        Me.telCliModif.Location = New System.Drawing.Point(213, 290)
        Me.telCliModif.Name = "telCliModif"
        Me.telCliModif.Size = New System.Drawing.Size(326, 20)
        Me.telCliModif.TabIndex = 12
        '
        'telCliTxt
        '
        Me.telCliTxt.AutoSize = True
        Me.telCliTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telCliTxt.Location = New System.Drawing.Point(120, 291)
        Me.telCliTxt.Name = "telCliTxt"
        Me.telCliTxt.Size = New System.Drawing.Size(87, 16)
        Me.telCliTxt.TabIndex = 13
        Me.telCliTxt.Text = "Téléphone :"
        '
        'CU05_modif_client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(750, 537)
        Me.Controls.Add(Me.telCliTxt)
        Me.Controls.Add(Me.telCliModif)
        Me.Controls.Add(Me.annulePdtModif)
        Me.Controls.Add(Me.enregisterCliModif)
        Me.Controls.Add(Me.descCliModif)
        Me.Controls.Add(Me.descPdtModifTxt)
        Me.Controls.Add(Me.adrCliTxt)
        Me.Controls.Add(Me.adrCliModif)
        Me.Controls.Add(Me.nomPdtModifTxt)
        Me.Controls.Add(Me.titreModifPdt)
        Me.Controls.Add(Me.nomCliModif)
        Me.Name = "CU05_modif_client"
        Me.Text = "   "
        CType(Me.nomCliModif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nomCliModif As System.Windows.Forms.DataGridView
    Friend WithEvents titreModifPdt As System.Windows.Forms.Label
    Friend WithEvents nomPdtModifTxt As System.Windows.Forms.Label
    Friend WithEvents adrCliModif As System.Windows.Forms.TextBox
    Friend WithEvents adrCliTxt As System.Windows.Forms.Label
    Friend WithEvents descPdtModifTxt As System.Windows.Forms.Label
    Friend WithEvents descCliModif As System.Windows.Forms.TextBox
    Friend WithEvents enregisterCliModif As System.Windows.Forms.Button
    Friend WithEvents annulePdtModif As System.Windows.Forms.Button
    Friend WithEvents telCliModif As System.Windows.Forms.TextBox
    Friend WithEvents telCliTxt As System.Windows.Forms.Label
End Class
