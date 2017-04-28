<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modifProduit
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
        Me.nomPdtModif = New System.Windows.Forms.DataGridView()
        Me.titreModifPdt = New System.Windows.Forms.Label()
        Me.nomPdtModifTxt = New System.Windows.Forms.Label()
        Me.codePdtModif = New System.Windows.Forms.TextBox()
        Me.codePdtTxt = New System.Windows.Forms.Label()
        Me.descPdtModifTxt = New System.Windows.Forms.Label()
        Me.descPdtModif = New System.Windows.Forms.TextBox()
        Me.enregistrerPdtModif = New System.Windows.Forms.Button()
        Me.annulePdtModif = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.nomPdtModif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nomPdtModif
        '
        Me.nomPdtModif.BackgroundColor = System.Drawing.Color.White
        Me.nomPdtModif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.nomPdtModif.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.nomPdtModif.Location = New System.Drawing.Point(213, 87)
        Me.nomPdtModif.Name = "nomPdtModif"
        Me.nomPdtModif.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.HighlightText
        Me.nomPdtModif.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.nomPdtModif.Size = New System.Drawing.Size(326, 171)
        Me.nomPdtModif.TabIndex = 0
        '
        'titreModifPdt
        '
        Me.titreModifPdt.AutoSize = True
        Me.titreModifPdt.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titreModifPdt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.titreModifPdt.Location = New System.Drawing.Point(266, 34)
        Me.titreModifPdt.Name = "titreModifPdt"
        Me.titreModifPdt.Size = New System.Drawing.Size(219, 24)
        Me.titreModifPdt.TabIndex = 1
        Me.titreModifPdt.Text = " Modification produit:"
        Me.titreModifPdt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'nomPdtModifTxt
        '
        Me.nomPdtModifTxt.AutoSize = True
        Me.nomPdtModifTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomPdtModifTxt.Location = New System.Drawing.Point(163, 87)
        Me.nomPdtModifTxt.Name = "nomPdtModifTxt"
        Me.nomPdtModifTxt.Size = New System.Drawing.Size(42, 16)
        Me.nomPdtModifTxt.TabIndex = 2
        Me.nomPdtModifTxt.Text = "Nom:"
        '
        'codePdtModif
        '
        Me.codePdtModif.Location = New System.Drawing.Point(213, 293)
        Me.codePdtModif.Name = "codePdtModif"
        Me.codePdtModif.Size = New System.Drawing.Size(326, 20)
        Me.codePdtModif.TabIndex = 3
        '
        'codePdtTxt
        '
        Me.codePdtTxt.AutoSize = True
        Me.codePdtTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codePdtTxt.Location = New System.Drawing.Point(158, 293)
        Me.codePdtTxt.Name = "codePdtTxt"
        Me.codePdtTxt.Size = New System.Drawing.Size(47, 16)
        Me.codePdtTxt.TabIndex = 4
        Me.codePdtTxt.Text = "Code:"
        '
        'descPdtModifTxt
        '
        Me.descPdtModifTxt.AutoSize = True
        Me.descPdtModifTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descPdtModifTxt.Location = New System.Drawing.Point(118, 326)
        Me.descPdtModifTxt.Name = "descPdtModifTxt"
        Me.descPdtModifTxt.Size = New System.Drawing.Size(87, 16)
        Me.descPdtModifTxt.TabIndex = 5
        Me.descPdtModifTxt.Text = "Description:"
        '
        'descPdtModif
        '
        Me.descPdtModif.AutoCompleteCustomSource.AddRange(New String() {"rrtty"})
        Me.descPdtModif.Location = New System.Drawing.Point(213, 326)
        Me.descPdtModif.Multiline = True
        Me.descPdtModif.Name = "descPdtModif"
        Me.descPdtModif.Size = New System.Drawing.Size(326, 154)
        Me.descPdtModif.TabIndex = 6
        '
        'enregistrerPdtModif
        '
        Me.enregistrerPdtModif.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enregistrerPdtModif.Location = New System.Drawing.Point(292, 486)
        Me.enregistrerPdtModif.Name = "enregistrerPdtModif"
        Me.enregistrerPdtModif.Size = New System.Drawing.Size(86, 23)
        Me.enregistrerPdtModif.TabIndex = 8
        Me.enregistrerPdtModif.Text = "Enregistrer"
        Me.enregistrerPdtModif.UseVisualStyleBackColor = True
        '
        'annulePdtModif
        '
        Me.annulePdtModif.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.annulePdtModif.Location = New System.Drawing.Point(384, 486)
        Me.annulePdtModif.Name = "annulePdtModif"
        Me.annulePdtModif.Size = New System.Drawing.Size(86, 23)
        Me.annulePdtModif.TabIndex = 9
        Me.annulePdtModif.Text = "Annuler"
        Me.annulePdtModif.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(337, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Client : "
        '
        'modifProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(750, 537)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.annulePdtModif)
        Me.Controls.Add(Me.enregistrerPdtModif)
        Me.Controls.Add(Me.descPdtModif)
        Me.Controls.Add(Me.descPdtModifTxt)
        Me.Controls.Add(Me.codePdtTxt)
        Me.Controls.Add(Me.codePdtModif)
        Me.Controls.Add(Me.nomPdtModifTxt)
        Me.Controls.Add(Me.titreModifPdt)
        Me.Controls.Add(Me.nomPdtModif)
        Me.Name = "modifProduit"
        Me.Text = "Modification produit"
        CType(Me.nomPdtModif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nomPdtModif As System.Windows.Forms.DataGridView
    Friend WithEvents titreModifPdt As System.Windows.Forms.Label
    Friend WithEvents nomPdtModifTxt As System.Windows.Forms.Label
    Friend WithEvents codePdtModif As System.Windows.Forms.TextBox
    Friend WithEvents codePdtTxt As System.Windows.Forms.Label
    Friend WithEvents descPdtModifTxt As System.Windows.Forms.Label
    Friend WithEvents descPdtModif As System.Windows.Forms.TextBox
    Friend WithEvents enregistrerPdtModif As System.Windows.Forms.Button
    Friend WithEvents annulePdtModif As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
