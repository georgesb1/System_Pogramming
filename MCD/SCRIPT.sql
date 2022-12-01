/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     29/11/2022 11:26:08                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ASSOCIER') and o.name = 'FK_ASSOCIER_ASSOCIER_RECETTES')
alter table ASSOCIER
   drop constraint FK_ASSOCIER_ASSOCIER_RECETTES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ASSOCIER') and o.name = 'FK_ASSOCIER_ASSOCIER2_COMMANDE')
alter table ASSOCIER
   drop constraint FK_ASSOCIER_ASSOCIER2_COMMANDE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FAIRE') and o.name = 'FK_FAIRE_FAIRE_MATERIEL')
alter table FAIRE
   drop constraint FK_FAIRE_FAIRE_MATERIEL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FAIRE') and o.name = 'FK_FAIRE_FAIRE2_DENREES')
alter table FAIRE
   drop constraint FK_FAIRE_FAIRE2_DENREES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FAIRE') and o.name = 'FK_FAIRE_FAIRE3_RESERVAT')
alter table FAIRE
   drop constraint FK_FAIRE_FAIRE3_RESERVAT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SATISFAIRE') and o.name = 'FK_SATISFAI_SATISFAIR_RESERVAT')
alter table SATISFAIRE
   drop constraint FK_SATISFAI_SATISFAIR_RESERVAT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SATISFAIRE') and o.name = 'FK_SATISFAI_SATISFAIR_FOURNISS')
alter table SATISFAIRE
   drop constraint FK_SATISFAI_SATISFAIR_FOURNISS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('UTILISER') and o.name = 'FK_UTILISER_UTILISER_DENREES')
alter table UTILISER
   drop constraint FK_UTILISER_UTILISER_DENREES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('UTILISER') and o.name = 'FK_UTILISER_UTILISER2_RECETTES')
alter table UTILISER
   drop constraint FK_UTILISER_UTILISER2_RECETTES
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ASSOCIER')
            and   name  = 'ASSOCIER2_FK'
            and   indid > 0
            and   indid < 255)
   drop index ASSOCIER.ASSOCIER2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ASSOCIER')
            and   name  = 'ASSOCIER_FK'
            and   indid > 0
            and   indid < 255)
   drop index ASSOCIER.ASSOCIER_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ASSOCIER')
            and   type = 'U')
   drop table ASSOCIER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('COMMANDE')
            and   type = 'U')
   drop table COMMANDE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DENREES')
            and   type = 'U')
   drop table DENREES
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FAIRE')
            and   name  = 'FAIRE3_FK'
            and   indid > 0
            and   indid < 255)
   drop index FAIRE.FAIRE3_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FAIRE')
            and   name  = 'FAIRE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index FAIRE.FAIRE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FAIRE')
            and   name  = 'FAIRE_FK'
            and   indid > 0
            and   indid < 255)
   drop index FAIRE.FAIRE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FAIRE')
            and   type = 'U')
   drop table FAIRE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FOURNISSEUR')
            and   type = 'U')
   drop table FOURNISSEUR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MATERIELS')
            and   type = 'U')
   drop table MATERIELS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RECETTES')
            and   type = 'U')
   drop table RECETTES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RESERVATIONS')
            and   type = 'U')
   drop table RESERVATIONS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SATISFAIRE')
            and   name  = 'SATISFAIRE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index SATISFAIRE.SATISFAIRE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SATISFAIRE')
            and   name  = 'SATISFAIRE_FK'
            and   indid > 0
            and   indid < 255)
   drop index SATISFAIRE.SATISFAIRE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SATISFAIRE')
            and   type = 'U')
   drop table SATISFAIRE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('UTILISER')
            and   name  = 'UTILISER2_FK'
            and   indid > 0
            and   indid < 255)
   drop index UTILISER.UTILISER2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('UTILISER')
            and   name  = 'UTILISER_FK'
            and   indid > 0
            and   indid < 255)
   drop index UTILISER.UTILISER_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('UTILISER')
            and   type = 'U')
   drop table UTILISER
go

/*==============================================================*/
/* Table: ASSOCIER                                              */
/*==============================================================*/
create table ASSOCIER (
   ID_RECETTE           int                  not null,
   ID_COMMANDE          int                  not null,
   constraint PK_ASSOCIER primary key (ID_RECETTE, ID_COMMANDE)
)
go

/*==============================================================*/
/* Index: ASSOCIER_FK                                           */
/*==============================================================*/
create index ASSOCIER_FK on ASSOCIER (
ID_RECETTE ASC
)
go

/*==============================================================*/
/* Index: ASSOCIER2_FK                                          */
/*==============================================================*/
create index ASSOCIER2_FK on ASSOCIER (
ID_COMMANDE ASC
)
go

/*==============================================================*/
/* Table: COMMANDE                                              */
/*==============================================================*/
create table COMMANDE (
   ID_COMMANDE          int                  not null,
   NOM_CLIENT           varchar(80)          null,
   NOM_COMMANDE         varchar(60)          null,
   NOMBRE_PERSONNE      int                  null,
   PRIX_COMMANDE        int                  null,
   constraint PK_COMMANDE primary key nonclustered (ID_COMMANDE)
)
go

/*==============================================================*/
/* Table: DENREES                                               */
/*==============================================================*/
create table DENREES (
   ID_DENREE            char(10)             not null,
   NOM_DENREE           char(10)             null,
   QTE_INITIALE         int                  null,
   QTE_RESTANTE         int                  null,
   constraint PK_DENREES primary key nonclustered (ID_DENREE)
)
go

/*==============================================================*/
/* Table: FAIRE                                                 */
/*==============================================================*/
create table FAIRE (
   ID_MATERIEL          int                  not null,
   ID_DENREE            char(10)             not null,
   ID_RESERVATION       int                  not null,
   constraint PK_FAIRE primary key (ID_MATERIEL, ID_DENREE, ID_RESERVATION)
)
go

/*==============================================================*/
/* Index: FAIRE_FK                                              */
/*==============================================================*/
create index FAIRE_FK on FAIRE (
ID_MATERIEL ASC
)
go

/*==============================================================*/
/* Index: FAIRE2_FK                                             */
/*==============================================================*/
create index FAIRE2_FK on FAIRE (
ID_DENREE ASC
)
go

/*==============================================================*/
/* Index: FAIRE3_FK                                             */
/*==============================================================*/
create index FAIRE3_FK on FAIRE (
ID_RESERVATION ASC
)
go

/*==============================================================*/
/* Table: FOURNISSEUR                                           */
/*==============================================================*/
create table FOURNISSEUR (
   ID_APPROVISIONNEMENT int                  not null,
   NOM_APPROVISIONNEMENT varchar(40)          null,
   DATE_COMMANDE        datetime             null,
   DATE_LIVRAISON       datetime             null,
   constraint PK_FOURNISSEUR primary key nonclustered (ID_APPROVISIONNEMENT)
)
go

/*==============================================================*/
/* Table: MATERIELS                                             */
/*==============================================================*/
create table MATERIELS (
   ID_MATERIEL          int                  not null,
   NOM_MATERIEL         varchar(30)          null,
   QTE_INITIALE         int                  null,
   QTE_RESTANTE         int                  null,
   constraint PK_MATERIELS primary key nonclustered (ID_MATERIEL)
)
go

/*==============================================================*/
/* Table: RECETTES                                              */
/*==============================================================*/
create table RECETTES (
   ID_RECETTE           int                  not null,
   CATEGORIE            varchar(60)          null,
   DESCRIPTION          varchar(80)          null,
   NOMBRE_PERSONNE      int                  null,
   constraint PK_RECETTES primary key nonclustered (ID_RECETTE)
)
go

/*==============================================================*/
/* Table: RESERVATIONS                                          */
/*==============================================================*/
create table RESERVATIONS (
   ID_RESERVATION       int                  not null,
   NOM_RESERVATION      varchar(40)          null,
   NOMBRE_PERSONNE      int                  null,
   DATE_COMMANDE        datetime             null,
   DATE_LIVRAISON       datetime             null,
   constraint PK_RESERVATIONS primary key nonclustered (ID_RESERVATION)
)
go

/*==============================================================*/
/* Table: SATISFAIRE                                            */
/*==============================================================*/
create table SATISFAIRE (
   ID_RESERVATION       int                  not null,
   ID_APPROVISIONNEMENT int                  not null,
   constraint PK_SATISFAIRE primary key (ID_RESERVATION, ID_APPROVISIONNEMENT)
)
go

/*==============================================================*/
/* Index: SATISFAIRE_FK                                         */
/*==============================================================*/
create index SATISFAIRE_FK on SATISFAIRE (
ID_RESERVATION ASC
)
go

/*==============================================================*/
/* Index: SATISFAIRE2_FK                                        */
/*==============================================================*/
create index SATISFAIRE2_FK on SATISFAIRE (
ID_APPROVISIONNEMENT ASC
)
go

/*==============================================================*/
/* Table: UTILISER                                              */
/*==============================================================*/
create table UTILISER (
   ID_DENREE            char(10)             not null,
   ID_RECETTE           int                  not null,
   constraint PK_UTILISER primary key (ID_DENREE, ID_RECETTE)
)
go

/*==============================================================*/
/* Index: UTILISER_FK                                           */
/*==============================================================*/
create index UTILISER_FK on UTILISER (
ID_DENREE ASC
)
go

/*==============================================================*/
/* Index: UTILISER2_FK                                          */
/*==============================================================*/
create index UTILISER2_FK on UTILISER (
ID_RECETTE ASC
)
go

alter table ASSOCIER
   add constraint FK_ASSOCIER_ASSOCIER_RECETTES foreign key (ID_RECETTE)
      references RECETTES (ID_RECETTE)
go

alter table ASSOCIER
   add constraint FK_ASSOCIER_ASSOCIER2_COMMANDE foreign key (ID_COMMANDE)
      references COMMANDE (ID_COMMANDE)
go

alter table FAIRE
   add constraint FK_FAIRE_FAIRE_MATERIEL foreign key (ID_MATERIEL)
      references MATERIELS (ID_MATERIEL)
go

alter table FAIRE
   add constraint FK_FAIRE_FAIRE2_DENREES foreign key (ID_DENREE)
      references DENREES (ID_DENREE)
go

alter table FAIRE
   add constraint FK_FAIRE_FAIRE3_RESERVAT foreign key (ID_RESERVATION)
      references RESERVATIONS (ID_RESERVATION)
go

alter table SATISFAIRE
   add constraint FK_SATISFAI_SATISFAIR_RESERVAT foreign key (ID_RESERVATION)
      references RESERVATIONS (ID_RESERVATION)
go

alter table SATISFAIRE
   add constraint FK_SATISFAI_SATISFAIR_FOURNISS foreign key (ID_APPROVISIONNEMENT)
      references FOURNISSEUR (ID_APPROVISIONNEMENT)
go

alter table UTILISER
   add constraint FK_UTILISER_UTILISER_DENREES foreign key (ID_DENREE)
      references DENREES (ID_DENREE)
go

alter table UTILISER
   add constraint FK_UTILISER_UTILISER2_RECETTES foreign key (ID_RECETTE)
      references RECETTES (ID_RECETTE)
go

