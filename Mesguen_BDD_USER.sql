/* ------------------- USER & PERMISSIONS ------------------- */
/* Creation de l'utilisateur */
Create user Matt IDENTIFIED BY estran;

/* Permission de connection et allocation des droits */
Grant CONNECT, RESOURCE , DBA  to Matt;

/* Connection an tant qu'utilisateur */
Connect Matt/estran;

/* TABLESPACE */
CREATE  TABLESPACE VB_Mesguen_Data
    DATAFILE 'C:/oracle/product/10.2.0/oradata/ORAVBMESGUEN/VB_Mesguen_Data_tbs01.dbf' SIZE 50M;

    CREATE  TABLESPACE VB_Mesguen_Index
    DATAFILE 'C:/oracle/product/10.2.0/oradata/ORAVBMESGUEN/VB_Mesguen_Index_tbs01.dbf' SIZE 20M;
