

--
-- Déclaration des séquences
--

DROP SEQUENCE EMPLOYE_EMPLID_SEQ;
DROP SEQUENCE LIEU_LIEUID_SEQ;
DROP SEQUENCE PHOTO_PHOTOID_SEQ;
DROP SEQUENCE REMORQUE_REQNUM_SEQ;
DROP SEQUENCE TOURNEE_TRNNUM_SEQ;
DROP SEQUENCE ETAPE_ETPID_SEQ;
DROP SEQUENCE CLIENT_CLIID_SEQ;
DROP SEQUENCE COMMANDE_CMDID_SEQ;

CREATE SEQUENCE EMPLOYE_EMPLID_SEQ START WITH 101 INCREMENT BY 1 nocache  nocycle order;
CREATE SEQUENCE LIEU_LIEUID_SEQ START WITH 101 INCREMENT BY 1 nocache nocycle order;
CREATE SEQUENCE PHOTO_PHOTOID_SEQ START WITH 101 INCREMENT BY 1 nocache nocycle order;
CREATE SEQUENCE REMORQUE_REQNUM_SEQ START WITH 101 INCREMENT BY 1 nocache nocycle order;
CREATE SEQUENCE TOURNEE_TRNNUM_SEQ START WITH 101 INCREMENT BY 1 nocache nocycle order;
CREATE SEQUENCE ETAPE_ETPID_SEQ START WITH 1 INCREMENT BY 1 nocache  nocycle order;
CREATE SEQUENCE CLIENT_CLIID_SEQ START WITH 1 INCREMENT BY 1 nocache  nocycle order;
CREATE SEQUENCE COMMANDE_CMDID_SEQ START WITH 1 INCREMENT BY 1 nocache  nocycle order;


ALTER TABLE etape DROP CONSTRAINT fk_etape_lieu ;
ALTER TABLE etape DROP CONSTRAINT fk_etape_tournee ;
ALTER TABLE lieu DROP CONSTRAINT fk_lieu_commune ;
ALTER TABLE photo DROP CONSTRAINT fk_photo_etape ;
ALTER TABLE tournee DROP CONSTRAINT fk_tournee_remorque ;
ALTER TABLE tournee DROP CONSTRAINT fk_tournee_empl ;
ALTER TABLE tournee DROP CONSTRAINT fk_tournee_vehicule ;
ALTER TABLE commande DROP CONSTRAINT fk_commande_tournee ;
ALTER TABLE commande DROP CONSTRAINT fk_commande_client ;
ALTER TABLE commande_produit DROP CONSTRAINT fk_commande_produit_produit ;
ALTER TABLE commande_produit DROP CONSTRAINT fk_commande_produit_commande ;


DROP TABLE commune ;
DROP TABLE employe ;
DROP TABLE etape ;
DROP TABLE lieu ;
DROP TABLE photo ;
DROP TABLE remorque ;
DROP TABLE tournee ;
DROP TABLE vehicule ;
DROP TABLE produit ;
DROP TABLE client ;
DROP TABLE commande ;
DROP TABLE commande_produit ;


--
-- Table structure for table commune
--
CREATE TABLE commune
(
  comId VARCHAR2(11) NOT NULL,
  comNom VARCHAR2(32) NOT NULL,
  CONSTRAINT PK_COMMUNE PRIMARY KEY  (comId) USING INDEX TABLESPACE VB_Mesguen_Index
) TABLESPACE VB_Mesguen_Data ;



--
-- Table structure for table employe
--
CREATE TABLE employe (
  emplId NUMBER(11,0) NOT NULL,
  emplNom VARCHAR2(60) NOT NULL,
  emplPrenom VARCHAR2(60) NOT NULL,
  emplTel VARCHAR2(10) NOT NULL,
  emplMail VARCHAR2(255) NOT NULL,
  emplLoggin VARCHAR2(255) NOT NULL,
  emplMdp VARCHAR2(255) NOT NULL,
  emplCat VARCHAR2(255) NOT NULL,
  emplGps VARCHAR2(255) DEFAULT NULL,
  CONSTRAINT PK_EMPLOYE PRIMARY KEY (emplId) USING INDEX TABLESPACE VB_Mesguen_Index
) TABLESPACE VB_Mesguen_Data ;

CREATE OR REPLACE TRIGGER EMPLOYE_TRG_BI
BEFORE INSERT ON employe
FOR EACH ROW
 WHEN (new.emplId IS NULL)
BEGIN
  SELECT EMPLOYE_EMPLID_SEQ.NEXTVAL
  INTO :new.emplId
  FROM dual;
END;
/

--
-- Table structure for table etape
--
CREATE TABLE etape (
  etpId NUMBER(11) NOT NULL,
  trnNum NUMBER(11,0) NOT NULL,
  lieuId NUMBER(11,0) NOT NULL,
  etpRDV date NOT NULL,
  etpRDVMin date DEFAULT NULL,
  etpRDVMax date DEFAULT NULL,
  etpHreArrivee date DEFAULT NULL,
  etpHreFin date DEFAULT NULL,
  etpCommentaire VARCHAR2(255) DEFAULT NULL,
  etpNbPalLiv NUMBER(4,0) DEFAULT NULL,
  etpNbPalLivEur NUMBER(4,0) DEFAULT NULL,
  etpNbPalChg NUMBER(4,0) DEFAULT NULL,
  etpNbPalChgEur NUMBER(4,0) DEFAULT NULL,
  etpEtat NUMBER(1,0) DEFAULT 0 NOT NULL,
  etpCheque NUMBER(4,0) DEFAULT NULL,
  CONSTRAINT PK_ETAPE PRIMARY KEY (etpId,trnNum) USING INDEX TABLESPACE VB_Mesguen_Index
) TABLESPACE VB_Mesguen_Data;

CREATE OR REPLACE TRIGGER ETAPE_ETPID_BI
BEFORE INSERT ON etape
FOR EACH ROW
 WHEN (new.etpId IS NULL)
BEGIN
  SELECT ETAPE_ETPID_SEQ.NEXTVAL
  INTO :new.etpId
  FROM dual;
END;
/



--
-- Table structure for table lieu
--
CREATE TABLE lieu (
  lieuId NUMBER(11,0) NOT NULL,
  comId VARCHAR2(11) NOT NULL,
  lieuNom VARCHAR2(30) NOT NULL,
  lieuAdresse VARCHAR2(60) NOT NULL,
  lieuTel VARCHAR2(10) NOT NULL,
  lieuMail VARCHAR2(30) NOT NULL,
  lieuGps VARCHAR2(255) DEFAULT NULL,
  CONSTRAINT PK_LIEU PRIMARY KEY (lieuId) USING INDEX TABLESPACE VB_Mesguen_Index
) TABLESPACE VB_Mesguen_Data;

CREATE OR REPLACE TRIGGER LIEU_TRG_BI
BEFORE INSERT ON lieu
FOR EACH ROW
 WHEN (new.lieuId IS NULL)
BEGIN
  SELECT LIEU_LIEUID_SEQ.NEXTVAL
  INTO :new.LieuId
  FROM dual;
END;
/



--
-- Table structure for table photo
--
CREATE TABLE photo (
  photoId NUMBER(11,0) NOT NULL,
  etpId NUMBER(11,0) NOT NULL,
  trnNum NUMBER(11,0) NOT NULL,
  etpPhoto VARCHAR2(60) NOT NULL,
  CONSTRAINT PK_PHOTO PRIMARY KEY (photoId) USING INDEX TABLESPACE VB_Mesguen_Index
) TABLESPACE VB_Mesguen_Data;


CREATE OR REPLACE TRIGGER PHOTO_PHOTOID_BI
BEFORE INSERT ON photo
FOR EACH ROW
 WHEN (new.photoId IS NULL)
BEGIN
  SELECT PHOTO_PHOTOID_SEQ.NEXTVAL
 INTO :new.photoId
  FROM dual;
END;
/



--
-- Table structure for table remorque
--
CREATE TABLE remorque (
  ReqNum NUMBER(10) NOT NULL,
  ReqLib VARCHAR2(30) DEFAULT NULL,
  CONSTRAINT PK_REMORQUE PRIMARY KEY (ReqNum) USING INDEX TABLESPACE VB_Mesguen_Index
) TABLESPACE VB_Mesguen_Data;

CREATE OR REPLACE TRIGGER REMORQUE_REQNUM_BI
BEFORE INSERT ON remorque
FOR EACH ROW
 WHEN (new.ReqNum IS NULL)
BEGIN
  SELECT REMORQUE_REQNUM_SEQ.NEXTVAL
  INTO :new.ReqNum
  FROM dual;
END;
/

--
-- Table structure for table tournee
--
CREATE TABLE tournee (
  trnNum NUMBER(11,0) NOT NULL,
  chfId NUMBER(11,0) NOT NULL,
  vehMat VARCHAR2(10) NOT NULL,
  trnCommentaire VARCHAR2(255) DEFAULT NULL,
  trnDepChf date NOT NULL,
  RmqNum NUMBER(10) DEFAULT NULL,
  CONSTRAINT PK_TOURNEE PRIMARY KEY (trnNum) USING INDEX TABLESPACE VB_Mesguen_Index
) TABLESPACE VB_Mesguen_Data;

CREATE OR REPLACE TRIGGER TOURNEE_TRNNUM_BI
BEFORE INSERT ON tournee
FOR EACH ROW
 WHEN (new.trnNum IS NULL)
BEGIN
  SELECT TOURNEE_TRNNUM_SEQ.NEXTVAL
  INTO :new.trnNum
  FROM dual;
END;
/


--
-- Table structure for table vehicule
--

CREATE TABLE vehicule (
  vehMat VARCHAR2(10) NOT NULL,
  vehMarque VARCHAR2(60) NOT NULL,
  vehKmCompteur NUMBER(11,0) NOT NULL,
  CONSTRAINT PK_VEHICULE PRIMARY KEY (vehMat) USING INDEX TABLESPACE VB_Mesguen_Index
) TABLESPACE VB_Mesguen_Data ;



--
-- Table structure for table Produit
--
CREATE TABLE produit (
  produitId NUMBER(10) NOT NULL,
  nomProduit VARCHAR2(60) NOT NULL,
  codeProduit VARCHAR2(10) NOT NULL,
  commentaireProduit VARCHAR2(255) NOT NULL,
  dispoProduit VARCHAR2(1) NOT NULL,
  CONSTRAINT PK_PRODUIT PRIMARY KEY (produitId) USING INDEX TABLESPACE VB_Mesguen_Index
) TABLESPACE VB_Mesguen_Data ;


--
-- Table structure for table Client
--
CREATE TABLE client (
  cliId NUMBER(10) NOT NULL,
  cliNom NUMBER(10) NOT NULL,
  cliAdresse1 VARCHAR2(255) NOT NULL,
  cliAdresse2 VARCHAR2(255) NULL,
  cliTel VARCHAR2(14) NOT NULL,
  cliDesc VARCHAR2(255) NOT NULL,
  CONSTRAINT PK_CLIENT PRIMARY KEY (cliId) USING INDEX TABLESPACE VB_Mesguen_Index
) TABLESPACE VB_Mesguen_Data ;

CREATE OR REPLACE TRIGGER CLIENT_TRG_BI
BEFORE INSERT ON client
FOR EACH ROW
 WHEN (new.cliId IS NULL)
BEGIN
  SELECT CLIENT_CLIID_SEQ.NEXTVAL
  INTO :new.cliId
  FROM dual;
END;
/

--
-- Table structure for table commande
--

CREATE TABLE commande (
  commandeId NUMBER(10) NOT NULL,
  nbproduits_total NUMBER(10) NOT NULL,
  trnNum NUMBER(11,0) NOT NULL,
  cliId NUMBER(11,0) NOT NULL,
  CONSTRAINT PK_COMMANDE PRIMARY KEY (commandeId) USING INDEX TABLESPACE VB_Mesguen_Index
) TABLESPACE VB_Mesguen_Data ;

CREATE OR REPLACE TRIGGER COMMANDE_TRG_BI
BEFORE INSERT ON commande
FOR EACH ROW
 WHEN (new.commandeId IS NULL)
BEGIN
  SELECT COMMANDE_CMDID_SEQ.NEXTVAL
  INTO :new.commandeId
  FROM dual;
END;
/



--
-- Table structure for table commande_produit
--
CREATE TABLE commande_produit (
  commandeId NUMBER(10) NOT NULL,
  produitId NUMBER(10) NOT NULL,
  nbProduit NUMBER(10) NOT NULL,
  CONSTRAINT PK_PCOMMANDE_PRODUIT PRIMARY KEY (commandeId, produitId) USING INDEX TABLESPACE VB_Mesguen_Index
) TABLESPACE VB_Mesguen_Data ;





--
-- Constraints for table etape
--
ALTER TABLE etape
    ADD CONSTRAINT fk_etape_lieu FOREIGN KEY (lieuId) REFERENCES lieu (lieuId) ON DELETE CASCADE;
ALTER TABLE etape
    ADD CONSTRAINT fk_etape_tournee FOREIGN KEY (trnNum) REFERENCES tournee (trnNum) ON DELETE CASCADE ;

--
-- Constraints for table lieu
--
ALTER TABLE lieu
  ADD CONSTRAINT fk_lieu_commune FOREIGN KEY (comId) REFERENCES commune (comId) ON DELETE CASCADE;

--
-- Constraints for table photo
--
ALTER TABLE photo
  ADD CONSTRAINT fk_photo_etape FOREIGN KEY (etpId, trnNum) REFERENCES etape (etpId, trnNum) ON DELETE CASCADE ;

--
-- Constraints for table tournee
--
ALTER TABLE tournee
    ADD CONSTRAINT fk_tournee_remorque FOREIGN KEY (RmqNum) REFERENCES remorque (ReqNum) ON DELETE CASCADE;
ALTER TABLE tournee
    ADD CONSTRAINT fk_tournee_empl FOREIGN KEY (chfId) REFERENCES employe (emplId) ON DELETE CASCADE;
ALTER TABLE tournee
    ADD CONSTRAINT fk_tournee_vehicule FOREIGN KEY (vehMat) REFERENCES vehicule (vehMat) ON DELETE CASCADE;

--
-- Constraints for table commande
--
ALTER TABLE commande
    ADD CONSTRAINT fk_commande_tournee FOREIGN KEY (trnNum) REFERENCES tournee (trnNum) ON DELETE CASCADE;
ALTER TABLE commande
    ADD CONSTRAINT fk_commande_client FOREIGN KEY (cliId) REFERENCES client (cliId) ON DELETE CASCADE;

--
-- Constraints for table commande_produit
--
ALTER TABLE commande_produit ADD CONSTRAINT fk_commande_produit_produit FOREIGN KEY (produitId) REFERENCES produit (produitId);
ALTER TABLE commande_produit ADD CONSTRAINT fk_commande_produit_commande FOREIGN KEY (commandeId) REFERENCES commande (commandeId) ON DELETE CASCADE;
