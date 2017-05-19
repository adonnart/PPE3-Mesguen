<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CU03_commande
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
        Me.NbPalettes = New System.Windows.Forms.TextBox()
        Me.PalettesMoins = New System.Windows.Forms.Button()
        Me.PalettesPlus = New System.Windows.Forms.Button()
        Me.Recherche = New System.Windows.Forms.TextBox()
        Me.ConfirmeRechercheProduits = New System.Windows.Forms.Button()
        Me.RechercheVilleDepart = New System.Windows.Forms.TextBox()
        Me.ConfirmeRechercheVD = New System.Windows.Forms.Button()
        Me.ConfirmeRechercheVA = New System.Windows.Forms.Button()
        Me.RechercheVilleArrivee = New System.Windows.Forms.TextBox()
        Me.ConfirmerCommande = New System.Windows.Forms.Button()
        Me.AnnulerCommande = New System.Windows.Forms.Button()
        Me.GridListeProduits = New System.Windows.Forms.DataGridView()
        Me.Panier = New System.Windows.Forms.DataGridView()
        Me.GridVilleDepart = New System.Windows.Forms.DataGridView()
        Me.GridVilleArrivee = New System.Windows.Forms.DataGridView()
        Me.AjouterProduit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SupprimerLignePanier = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.GridListeProduits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridVilleDepart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridVilleArrivee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NbPalettes
        '
        Me.NbPalettes.Location = New System.Drawing.Point(12, 182)
        Me.NbPalettes.Name = "NbPalettes"
        Me.NbPalettes.Size = New System.Drawing.Size(100, 20)
        Me.NbPalettes.TabIndex = 2
        Me.NbPalettes.Text = "0"
        '
        'PalettesMoins
        '
        Me.PalettesMoins.Location = New System.Drawing.Point(118, 182)
        Me.PalettesMoins.Name = "PalettesMoins"
        Me.PalettesMoins.Size = New System.Drawing.Size(15, 19)
        Me.PalettesMoins.TabIndex = 3
        Me.PalettesMoins.Text = "-"
        Me.PalettesMoins.UseVisualStyleBackColor = True
        '
        'PalettesPlus
        '
        Me.PalettesPlus.Location = New System.Drawing.Point(139, 182)
        Me.PalettesPlus.Name = "PalettesPlus"
        Me.PalettesPlus.Size = New System.Drawing.Size(15, 19)
        Me.PalettesPlus.TabIndex = 4
        Me.PalettesPlus.Text = "+"
        Me.PalettesPlus.UseVisualStyleBackColor = True
        '
        'Recherche
        '
        Me.Recherche.Location = New System.Drawing.Point(12, 42)
        Me.Recherche.Name = "Recherche"
        Me.Recherche.Size = New System.Drawing.Size(100, 20)
        Me.Recherche.TabIndex = 7
        '
        'ConfirmeRechercheProduits
        '
        Me.ConfirmeRechercheProduits.Location = New System.Drawing.Point(118, 39)
        Me.ConfirmeRechercheProduits.Name = "ConfirmeRechercheProduits"
        Me.ConfirmeRechercheProduits.Size = New System.Drawing.Size(36, 23)
        Me.ConfirmeRechercheProduits.TabIndex = 8
        Me.ConfirmeRechercheProduits.Text = "OK"
        Me.ConfirmeRechercheProduits.UseVisualStyleBackColor = True
        '
        'RechercheVilleDepart
        '
        Me.RechercheVilleDepart.Location = New System.Drawing.Point(9, 352)
        Me.RechercheVilleDepart.Name = "RechercheVilleDepart"
        Me.RechercheVilleDepart.Size = New System.Drawing.Size(100, 20)
        Me.RechercheVilleDepart.TabIndex = 11
        '
        'ConfirmeRechercheVD
        '
        Me.ConfirmeRechercheVD.Location = New System.Drawing.Point(115, 352)
        Me.ConfirmeRechercheVD.Name = "ConfirmeRechercheVD"
        Me.ConfirmeRechercheVD.Size = New System.Drawing.Size(36, 23)
        Me.ConfirmeRechercheVD.TabIndex = 12
        Me.ConfirmeRechercheVD.Text = "OK"
        Me.ConfirmeRechercheVD.UseVisualStyleBackColor = True
        '
        'ConfirmeRechercheVA
        '
        Me.ConfirmeRechercheVA.Location = New System.Drawing.Point(115, 547)
        Me.ConfirmeRechercheVA.Name = "ConfirmeRechercheVA"
        Me.ConfirmeRechercheVA.Size = New System.Drawing.Size(36, 23)
        Me.ConfirmeRechercheVA.TabIndex = 13
        Me.ConfirmeRechercheVA.Text = "OK"
        Me.ConfirmeRechercheVA.UseVisualStyleBackColor = True
        '
        'RechercheVilleArrivee
        '
        Me.RechercheVilleArrivee.Location = New System.Drawing.Point(9, 550)
        Me.RechercheVilleArrivee.Name = "RechercheVilleArrivee"
        Me.RechercheVilleArrivee.Size = New System.Drawing.Size(100, 20)
        Me.RechercheVilleArrivee.TabIndex = 14
        '
        'ConfirmerCommande
        '
        Me.ConfirmerCommande.Location = New System.Drawing.Point(9, 732)
        Me.ConfirmerCommande.Name = "ConfirmerCommande"
        Me.ConfirmerCommande.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmerCommande.TabIndex = 17
        Me.ConfirmerCommande.Text = "Confirmer"
        Me.ConfirmerCommande.UseVisualStyleBackColor = True
        '
        'AnnulerCommande
        '
        Me.AnnulerCommande.Location = New System.Drawing.Point(267, 732)
        Me.AnnulerCommande.Name = "AnnulerCommande"
        Me.AnnulerCommande.Size = New System.Drawing.Size(75, 23)
        Me.AnnulerCommande.TabIndex = 18
        Me.AnnulerCommande.Text = "Annuler"
        Me.AnnulerCommande.UseVisualStyleBackColor = True
        '
        'GridListeProduits
        '
        Me.GridListeProduits.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridListeProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridListeProduits.Location = New System.Drawing.Point(12, 68)
        Me.GridListeProduits.Name = "GridListeProduits"
        Me.GridListeProduits.Size = New System.Drawing.Size(353, 95)
        Me.GridListeProduits.TabIndex = 20
        '
        'Panier
        '
        Me.Panier.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Panier.Location = New System.Drawing.Point(12, 211)
        Me.Panier.Name = "Panier"
        Me.Panier.Size = New System.Drawing.Size(240, 95)
        Me.Panier.TabIndex = 21
        '
        'GridVilleDepart
        '
        Me.GridVilleDepart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridVilleDepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridVilleDepart.Location = New System.Drawing.Point(11, 381)
        Me.GridVilleDepart.Name = "GridVilleDepart"
        Me.GridVilleDepart.Size = New System.Drawing.Size(352, 118)
        Me.GridVilleDepart.TabIndex = 22
        '
        'GridVilleArrivee
        '
        Me.GridVilleArrivee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridVilleArrivee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridVilleArrivee.Location = New System.Drawing.Point(9, 577)
        Me.GridVilleArrivee.Name = "GridVilleArrivee"
        Me.GridVilleArrivee.Size = New System.Drawing.Size(353, 118)
        Me.GridVilleArrivee.TabIndex = 23
        '
        'AjouterProduit
        '
        Me.AjouterProduit.Location = New System.Drawing.Point(178, 182)
        Me.AjouterProduit.Name = "AjouterProduit"
        Me.AjouterProduit.Size = New System.Drawing.Size(75, 23)
        Me.AjouterProduit.TabIndex = 24
        Me.AjouterProduit.Text = "Ajouter"
        Me.AjouterProduit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Client : "
        '
        'SupprimerLignePanier
        '
        Me.SupprimerLignePanier.Location = New System.Drawing.Point(290, 259)
        Me.SupprimerLignePanier.Name = "SupprimerLignePanier"
        Me.SupprimerLignePanier.Size = New System.Drawing.Size(75, 23)
        Me.SupprimerLignePanier.TabIndex = 26
        Me.SupprimerLignePanier.Text = "Supprimer"
        Me.SupprimerLignePanier.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 27
        '
        'CU03_commande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(377, 775)
        Me.Controls.Add(Me.Label2)
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
        Me.Controls.Add(Me.ConfirmeRechercheProduits)
        Me.Controls.Add(Me.Recherche)
        Me.Controls.Add(Me.PalettesPlus)
        Me.Controls.Add(Me.PalettesMoins)
        Me.Controls.Add(Me.NbPalettes)
        Me.Name = "CU03_commande"
        Me.Text = "CU03_commande"
        CType(Me.GridListeProduits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridVilleDepart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridVilleArrivee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NbPalettes As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Recherche As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmeRechercheProduits As System.Windows.Forms.Button
    Friend WithEvents RechercheVilleDepart As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmeRechercheVD As System.Windows.Forms.Button
    Friend WithEvents ConfirmeRechercheVA As System.Windows.Forms.Button
    Friend WithEvents RechercheVilleArrivee As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmerCommande As System.Windows.Forms.Button
    Friend WithEvents AnnulerCommande As System.Windows.Forms.Button
    Friend WithEvents GridListeProduits As System.Windows.Forms.DataGridView
    Friend WithEvents Panier As System.Windows.Forms.DataGridView
    Friend WithEvents GridVilleDepart As System.Windows.Forms.DataGridView
    Friend WithEvents GridVilleArrivee As System.Windows.Forms.DataGridView
    Friend WithEvents AjouterProduit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SupprimerLignePanier As System.Windows.Forms.Button
    Friend WithEvents PalettesMoins As System.Windows.Forms.Button
    Friend WithEvents PalettesPlus As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
