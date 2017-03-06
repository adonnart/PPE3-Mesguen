/* ------------------- BASE ------------------- */ 
/* Creation de la base */
Create DATABASE VBMESGUEN;


/* ------------------- USER & PERMITIONS ------------------- */
/*Creation de l'utilisateur */
Create user Matt IDENTIFIED BY estran;

/* Permition de connection et allocation des droits */
Grant CONNECT, RESOURCE , DBA on VBMESGUEN to Matt;

/*Connection an tant qu'utilisateur*/
Connect Matt/estran;


/* ------------------- TABLES ------------------- */
/*Creation des tables*/
CREATE TABLE Lieu
(
LieuId INT(10) PRIMARY KEY,
LieuNom VARCHAR(20) NOT NULL,
LieuCoorGPS double(20) NULL, 
);

CREATE TABLE TypeClients
(
IdType INT(10) PRIMARY KEY,
CodeType VARCHAR(20)
NomType VARCHAR(20),
);

CREATE TABLE TypeProduits
(
IdTypeProduit INT(10) PRIMARY KEY,
LieuNom VARCHAR(20) NOT NULL,
LieuCoorGPS double(20) NULL, 
);

CREATE TABLE Clients
(
IdClient INT(10) PRIMARY KEY,
NomClient VARCHAR(20),
AddrClient VARCHAR(50),
VilleClient VARCHAR(20),
CpClient INT(5),
Description VARCHAR(128),
);

CREATE TABLE Produits
(
IdProduit INT(10) PRIMARY KEY,
CodeProduit VARCHAR(20) NOT NULL,
NomProduit VARCHAR(20),
Description VARCHAR(128), 
);

CREATE TABLE Commandes
(
IdCommandes LieuId INT(10) PRIMARY KEY,
ON DELETE CASCADE
);


/* ------------------- CLEFS ------------------- */
/*Clefs Primaires*/
/*
ALTER TABLE Lieu
ADD CONSTRAINTS pk_LieuId
PRIMARY KEY LieuId;

ALTER TABLE TypeClients
ADD CONSTRAINTS pk_TypeClients
PRIMARY KEY IdType;

ALTER TABLE TypeProduits
ADD CONSTRAINTS pk_TypeProduits
PRIMARY KEY IdTypeProduit ;

ALTER TABLE Clients
ADD CONSTRAINTS pk_Clients
PRIMARY KEY IdClient;

ALTER TABLE Produits
ADD CONSTRAINTS pk_Produits
PRIMARY KEY IdProduit;

ALTER TABLE Commandes
ADD CONSTRAINTS pk_IdCommandes
PRIMARY KEY LieuId;
*/

/* Clefs Etrangere*/
ALTER TABLE Clients 
ADD CONSTRAINTS fk_Clients_TypeClients
FOREIGN KEY(TypeClients)
REFERENCES TypeClients(IdType);

ALTER TABLE Produits 
ADD CONSTRAINTS fk_Produits_TypeProduits
FOREIGN KEY(TypeProduits)
REFERENCES TypeProduits(IdTypeProduit);

ALTER TABLE Commandes 
ADD CONSTRAINTS fk_Commandes_Lieu
FOREIGN KEY(Lieu)
REFERENCES Lieu(LieuId);

ALTER TABLE Commandes 
ADD CONSTRAINTS fk_Commandes_Produit
FOREIGN KEY(Produits)
REFERENCES Produits(IdProduit);

ALTER TABLE Commandes 
ADD CONSTRAINTS fk_Commandes_Clients
FOREIGN KEY(Clients)
REFERENCES Clients(IdClient);










