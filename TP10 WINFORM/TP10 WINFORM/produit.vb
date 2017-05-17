<Serializable()> Public Class produit
    Private _numProduit As Integer
    'METHODES D'ACCES AUX DONNEES
    Public Property numProduit() As Integer
        Get
            Return Me._numProduit
        End Get
        Set(ByVal Value As Integer)
            Me._numProduit = Value
        End Set
    End Property
    Private _nomProduit As Integer
    'methode d acces aux donnees 
    Public Property nomProduit() As String
        Get
            Return Me._nomProduit
        End Get
        Set(value As String)
            Me._nomProduit = value
        End Set
    End Property
    Private _codeProduit As String
    'methode d acces aux donnees
    Public Property codeProduit() As String
        Get
            Return Me._codeProduit
        End Get
        Set(value As String)
            Me._codeProduit = value
        End Set
    End Property
    Private _descriptionProduit As String
    'methode d acces aux donnees
    Public Property descriptionProduit() As String
        Get
            Return Me._descriptionProduit
        End Get
        Set(value As String)
            Me._descriptionProduit = value
        End Set
    End Property
End Class
