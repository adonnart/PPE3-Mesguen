<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CU03_modif_commande
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
        Me.SupprimerLignePanier = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AjouterProduit = New System.Windows.Forms.Button()
        Me.GridVilleArrivee = New System.Windows.Forms.DataGridView()
        Me.GridVilleDepart = New System.Windows.Forms.DataGridView()
        Me.Panier = New System.Windows.Forms.DataGridView()
        Me.GridListeProduits = New System.Windows.Forms.DataGridView()
        Me.AnnulerCommande = New System.Windows.Forms.Button()
        Me.ConfirmerCommande = New System.Windows.Forms.Button()
        Me.RechercheVilleArrivee = New System.Windows.Forms.TextBox()
        Me.ConfirmeRechercheVA = New System.Windows.Forms.Button()
        Me.ConfirmeRechercheVD = New System.Windows.Forms.Button()
        Me.RechercheVilleDepart = New System.Windows.Forms.TextBox()
        Me.PalettesPlus = New System.Windows.Forms.Button()
        Me.PalettesMoins = New System.Windows.Forms.Button()
        Me.NbPalettes = New System.Windows.Forms.TextBox()
        Me.SupprimerLigneNouveauPanier = New System.Windows.Forms.Button()
        Me.NouveauPanier = New System.Windows.Forms.DataGridView()
        Me.produitsSuppr = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.GridVilleArrivee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridVilleDepart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridListeProduits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NouveauPanier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.produitsSuppr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SupprimerLignePanier
        '
        Me.SupprimerLignePanier.Location = New System.Drawing.Point(352, 295)
        Me.SupprimerLignePanier.Name = "SupprimerLignePanier"
        Me.SupprimerLignePanier.Size = New System.Drawing.Size(75, 23)
        Me.SupprimerLignePanier.TabIndex = 44
        Me.SupprimerLignePanier.Text = "Supprimer"
        Me.SupprimerLignePanier.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(349, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Commande  : "
        '
        'AjouterProduit
        '
        Me.AjouterProduit.Location = New System.Drawing.Point(161, 150)
        Me.AjouterProduit.Name = "AjouterProduit"
        Me.AjouterProduit.Size = New System.Drawing.Size(75, 23)
        Me.AjouterProduit.TabIndex = 42
        Me.AjouterProduit.Text = "Ajouter"
        Me.AjouterProduit.UseVisualStyleBackColor = True
        '
        'GridVilleArrivee
        '
        Me.GridVilleArrivee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridVilleArrivee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridVilleArrivee.Location = New System.Drawing.Point(269, 361)
        Me.GridVilleArrivee.Name = "GridVilleArrivee"
        Me.GridVilleArrivee.Size = New System.Drawing.Size(240, 110)
        Me.GridVilleArrivee.TabIndex = 41
        '
        'GridVilleDepart
        '
        Me.GridVilleDepart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridVilleDepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridVilleDepart.Location = New System.Drawing.Point(13, 361)
        Me.GridVilleDepart.Name = "GridVilleDepart"
        Me.GridVilleDepart.Size = New System.Drawing.Size(240, 110)
        Me.GridVilleDepart.TabIndex = 40
        '
        'Panier
        '
        Me.Panier.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Panier.Location = New System.Drawing.Point(269, 179)
        Me.Panier.Name = "Panier"
        Me.Panier.Size = New System.Drawing.Size(240, 110)
        Me.Panier.TabIndex = 39
        '
        'GridListeProduits
        '
        Me.GridListeProduits.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridListeProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridListeProduits.Location = New System.Drawing.Point(13, 38)
        Me.GridListeProduits.Name = "GridListeProduits"
        Me.GridListeProduits.Size = New System.Drawing.Size(496, 95)
        Me.GridListeProduits.TabIndex = 38
        '
        'AnnulerCommande
        '
        Me.AnnulerCommande.Location = New System.Drawing.Point(269, 487)
        Me.AnnulerCommande.Name = "AnnulerCommande"
        Me.AnnulerCommande.Size = New System.Drawing.Size(75, 23)
        Me.AnnulerCommande.TabIndex = 37
        Me.AnnulerCommande.Text = "Annuler"
        Me.AnnulerCommande.UseVisualStyleBackColor = True
        '
        'ConfirmerCommande
        '
        Me.ConfirmerCommande.Location = New System.Drawing.Point(178, 487)
        Me.ConfirmerCommande.Name = "ConfirmerCommande"
        Me.ConfirmerCommande.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmerCommande.TabIndex = 36
        Me.ConfirmerCommande.Text = "Confirmer"
        Me.ConfirmerCommande.UseVisualStyleBackColor = True
        '
        'RechercheVilleArrivee
        '
        Me.RechercheVilleArrivee.Location = New System.Drawing.Point(269, 335)
        Me.RechercheVilleArrivee.Name = "RechercheVilleArrivee"
        Me.RechercheVilleArrivee.Size = New System.Drawing.Size(100, 20)
        Me.RechercheVilleArrivee.TabIndex = 35
        '
        'ConfirmeRechercheVA
        '
        Me.ConfirmeRechercheVA.Location = New System.Drawing.Point(375, 333)
        Me.ConfirmeRechercheVA.Name = "ConfirmeRechercheVA"
        Me.ConfirmeRechercheVA.Size = New System.Drawing.Size(36, 23)
        Me.ConfirmeRechercheVA.TabIndex = 34
        Me.ConfirmeRechercheVA.Text = "OK"
        Me.ConfirmeRechercheVA.UseVisualStyleBackColor = True
        '
        'ConfirmeRechercheVD
        '
        Me.ConfirmeRechercheVD.Location = New System.Drawing.Point(119, 333)
        Me.ConfirmeRechercheVD.Name = "ConfirmeRechercheVD"
        Me.ConfirmeRechercheVD.Size = New System.Drawing.Size(36, 23)
        Me.ConfirmeRechercheVD.TabIndex = 33
        Me.ConfirmeRechercheVD.Text = "OK"
        Me.ConfirmeRechercheVD.UseVisualStyleBackColor = True
        '
        'RechercheVilleDepart
        '
        Me.RechercheVilleDepart.Location = New System.Drawing.Point(13, 335)
        Me.RechercheVilleDepart.Name = "RechercheVilleDepart"
        Me.RechercheVilleDepart.Size = New System.Drawing.Size(100, 20)
        Me.RechercheVilleDepart.TabIndex = 32
        '
        'PalettesPlus
        '
        Me.PalettesPlus.Location = New System.Drawing.Point(140, 150)
        Me.PalettesPlus.Name = "PalettesPlus"
        Me.PalettesPlus.Size = New System.Drawing.Size(15, 23)
        Me.PalettesPlus.TabIndex = 29
        Me.PalettesPlus.Text = "+"
        Me.PalettesPlus.UseVisualStyleBackColor = True
        '
        'PalettesMoins
        '
        Me.PalettesMoins.Location = New System.Drawing.Point(119, 150)
        Me.PalettesMoins.Name = "PalettesMoins"
        Me.PalettesMoins.Size = New System.Drawing.Size(15, 23)
        Me.PalettesMoins.TabIndex = 28
        Me.PalettesMoins.Text = "-"
        Me.PalettesMoins.UseVisualStyleBackColor = True
        '
        'NbPalettes
        '
        Me.NbPalettes.Location = New System.Drawing.Point(13, 152)
        Me.NbPalettes.Name = "NbPalettes"
        Me.NbPalettes.Size = New System.Drawing.Size(100, 20)
        Me.NbPalettes.TabIndex = 27
        Me.NbPalettes.Text = "0"
        '
        'SupprimerLigneNouveauPanier
        '
        Me.SupprimerLigneNouveauPanier.Location = New System.Drawing.Point(95, 295)
        Me.SupprimerLigneNouveauPanier.Name = "SupprimerLigneNouveauPanier"
        Me.SupprimerLigneNouveauPanier.Size = New System.Drawing.Size(75, 23)
        Me.SupprimerLigneNouveauPanier.TabIndex = 46
        Me.SupprimerLigneNouveauPanier.Text = "Supprimer"
        Me.SupprimerLigneNouveauPanier.UseVisualStyleBackColor = True
        '
        'NouveauPanier
        '
        Me.NouveauPanier.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NouveauPanier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NouveauPanier.Location = New System.Drawing.Point(13, 179)
        Me.NouveauPanier.Name = "NouveauPanier"
        Me.NouveauPanier.Size = New System.Drawing.Size(240, 110)
        Me.NouveauPanier.TabIndex = 45
        '
        'produitsSuppr
        '
        Me.produitsSuppr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.produitsSuppr.Location = New System.Drawing.Point(144, 605)
        Me.produitsSuppr.Name = "produitsSuppr"
        Me.produitsSuppr.Size = New System.Drawing.Size(240, 95)
        Me.produitsSuppr.TabIndex = 47
        Me.produitsSuppr.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Client :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(459, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 50
        '
        'CU03_modif_commande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(522, 527)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.produitsSuppr)
        Me.Controls.Add(Me.SupprimerLigneNouveauPanier)
        Me.Controls.Add(Me.NouveauPanier)
        Me.Controls.Add(Me.SupprimerLignePanier)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AjouterProduit)
        Me.Controls.Add(Me.GridVilleArrivee)
        Me.Controls.Add(Me.GridVilleDepart)
        Me.Controls.Add(Me.Panier)
        Me.Controls.Add(Me.GridListeProduits)
        Me.Controls.Add(Me.AnnulerCommande)
        Me.Controls.Add(Me.ConfirmerCommande)
        Me.Controls.Add(Me.RechercheVilleArrivee)
        Me.Controls.Add(Me.ConfirmeRechercheVA)
        Me.Controls.Add(Me.ConfirmeRechercheVD)
        Me.Controls.Add(Me.RechercheVilleDepart)
        Me.Controls.Add(Me.PalettesPlus)
        Me.Controls.Add(Me.PalettesMoins)
        Me.Controls.Add(Me.NbPalettes)
        Me.Name = "CU03_modif_commande"
        Me.Text = "CU03_modif_commande"
        CType(Me.GridVilleArrivee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridVilleDepart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridListeProduits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NouveauPanier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.produitsSuppr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SupprimerLignePanier As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AjouterProduit As System.Windows.Forms.Button
    Friend WithEvents GridVilleArrivee As System.Windows.Forms.DataGridView
    Friend WithEvents GridVilleDepart As System.Windows.Forms.DataGridView
    Friend WithEvents Panier As System.Windows.Forms.DataGridView
    Friend WithEvents GridListeProduits As System.Windows.Forms.DataGridView
    Friend WithEvents AnnulerCommande As System.Windows.Forms.Button
    Friend WithEvents ConfirmerCommande As System.Windows.Forms.Button
    Friend WithEvents RechercheVilleArrivee As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmeRechercheVA As System.Windows.Forms.Button
    Friend WithEvents ConfirmeRechercheVD As System.Windows.Forms.Button
    Friend WithEvents RechercheVilleDepart As System.Windows.Forms.TextBox
    Friend WithEvents PalettesPlus As System.Windows.Forms.Button
    Friend WithEvents PalettesMoins As System.Windows.Forms.Button
    Friend WithEvents NbPalettes As System.Windows.Forms.TextBox
    Friend WithEvents SupprimerLigneNouveauPanier As System.Windows.Forms.Button
    Friend WithEvents NouveauPanier As System.Windows.Forms.DataGridView
    Friend WithEvents produitsSuppr As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
