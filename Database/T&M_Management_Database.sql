/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008 R2                 */
/* Created on:     2024/12/9 13:16:04                           */
/*==============================================================*/
CREATE DATABASE [T&M];
GO

USE [T&M];
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DELIVERER')
            and   type = 'U')
   drop table DELIVERER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ORDERS')
            and   name  = 'BUY_FK'
            and   indid > 0
            and   indid < 255)
   drop index ORDERS.BUY_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ORDERS')
            and   name  = 'CHARGE_FK'
            and   indid > 0
            and   indid < 255)
   drop index ORDERS.CHARGE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ORDERS')
            and   name  = 'DELIVER_FK'
            and   indid > 0
            and   indid < 255)
   drop index ORDERS.DELIVER_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ORDERS')
            and   type = 'U')
   drop table ORDERS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STAFF')
            and   type = 'U')
   drop table STAFF
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TEA')
            and   type = 'U')
   drop table TEA
go


/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   CNAME                char(256)            null,
   CNO                  char(9)              not null,
   CPASS                char(256)            null,
   CSITE                char(256)            null,
   CTEL                 char(20)             null,
   constraint PK_CUSTOMER primary key nonclustered (CNO)
)
go

/*==============================================================*/
/* Table: ADMINISTRATOR                                              */
/*==============================================================*/
create table ADMINISTRATOR (
   ANAME                char(256)            null,
   ANO                  char(9)              not null,
   APASS                char(256)            null,
   primary key nonclustered (ANO)
)
go

/*==============================================================*/
/* Table: DELIVERER                                             */
/*==============================================================*/
create table DELIVERER (
   DNAME                char(256)            null,
   DNO                  char(9)              not null,
   DPASS                char(256)            null,
   DTEl                 char(20)             null,
   DTEMP                float                null,
   constraint PK_DELIVERER primary key nonclustered (DNO)
)
go

/*==============================================================*/
/* Table: ORDERS                                                */
/*==============================================================*/
create table ORDERS (
   ONO                  INTEGER				 PRIMARY KEY IDENTITY(1,1),
   CNO                  char(9)              not null,
   SNO                  char(9)              not null,
   DNO                  char(9)              null,
   TNO                  char(9)              not null,
   ONOTE                char(256)            null,
   OPAY                 char(256)            null,
   OSUM                 char(10)             null,
   OSTATUS              int                  null,
   OTIME                datetime             null,
)
go

/*==============================================================*/
/* Index: DELIVER_FK                                            */
/*==============================================================*/
create index DELIVER_FK on ORDERS (
DNO ASC
)
go

/*==============================================================*/
/* Index: CHARGE_FK                                             */
/*==============================================================*/
create index CHARGE_FK on ORDERS (
SNO ASC
)
go

/*==============================================================*/
/* Index: BUY_FK                                                */
/*==============================================================*/
create index BUY_FK on ORDERS (
CNO ASC
)
go

/*==============================================================*/
/* Table: STAFF                                                 */
/*==============================================================*/
create table STAFF (
   SNAME                char(256)            null,
   SNO                  char(9)              not null,
   SPASS                char(256)            null,
   constraint PK_STAFF primary key nonclustered (SNO)
)
go

/*==============================================================*/
/* Table: TEA                                                   */
/*==============================================================*/
create table TEA (
   TING                 char(256)            null,
   TNAME                 char(256)            null,
   TNO                  char(9)              not null,
   TP                   char(10)             null,
   constraint PK_TEA primary key nonclustered ("TNO")
)
go

