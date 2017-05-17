<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class affichProduit
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
        Me.NomBox = New System.Windows.Forms.ComboBox()
        Me.SocGrid = New System.Windows.Forms.DataGridView()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.SocGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomBox
        '
        Me.NomBox.FormattingEnabled = True
        Me.NomBox.Location = New System.Drawing.Point(12, 62)
        Me.NomBox.Name = "NomBox"
        Me.NomBox.Size = New System.Drawing.Size(370, 21)
        Me.NomBox.TabIndex = 0
        '
        'SocGrid
        '
        Me.SocGrid.BackgroundColor = System.Drawing.Color.White
        Me.SocGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SocGrid.Location = New System.Drawing.Point(12, 89)
        Me.SocGrid.Name = "SocGrid"
        Me.SocGrid.Size = New System.Drawing.Size(370, 311)
        Me.SocGrid.TabIndex = 1
        '
        'Modifier
        '
        Me.Modifier.Location = New System.Drawing.Point(409, 60)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(75, 23)
        Me.Modifier.TabIndex = 2
        Me.Modifier.Text = "Modifier"
        Me.Modifier.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sélection produit:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Client : "
        '
        'affichProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 415)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Modifier)
        Me.Controls.Add(Me.SocGrid)
        Me.Controls.Add(Me.NomBox)
        Me.Name = "affichProduit"
        Me.Text = "Test ORACLE"
        CType(Me.SocGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NomBox As System.Windows.Forms.ComboBox
    Friend WithEvents SocGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Modifier As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
