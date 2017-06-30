
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/30/2017 14:08:59
-- Generated from EDMX file: C:\Users\Amir Reza\Source\Repos\SmartShop2\SmartShop\DbModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SmartShop];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Buy_Invoice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Buy] DROP CONSTRAINT [FK_Buy_Invoice];
GO
IF OBJECT_ID(N'[dbo].[FK_Buy_Invoice1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Buy] DROP CONSTRAINT [FK_Buy_Invoice1];
GO
IF OBJECT_ID(N'[dbo].[FK_Buy_Kala]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Buy] DROP CONSTRAINT [FK_Buy_Kala];
GO
IF OBJECT_ID(N'[dbo].[FK_Invoice_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Invoice] DROP CONSTRAINT [FK_Invoice_Customer];
GO
IF OBJECT_ID(N'[dbo].[FK_Invoice_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Invoice] DROP CONSTRAINT [FK_Invoice_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Kala_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Kala] DROP CONSTRAINT [FK_Kala_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Transaction_Invoice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transaction] DROP CONSTRAINT [FK_Transaction_Invoice];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Buy]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Buy];
GO
IF OBJECT_ID(N'[dbo].[Customer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customer];
GO
IF OBJECT_ID(N'[dbo].[Invoice]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Invoice];
GO
IF OBJECT_ID(N'[dbo].[Kala]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kala];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Transaction]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transaction];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Buys'
CREATE TABLE [dbo].[Buys] (
    [kala_id] int  NOT NULL,
    [invoice_id] int  NOT NULL,
    [quantity] int  NOT NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(100)  NOT NULL,
    [address] nvarchar(100)  NOT NULL,
    [phone] int  NOT NULL,
    [charj] int  NOT NULL
);
GO

-- Creating table 'Invoices'
CREATE TABLE [dbo].[Invoices] (
    [id] int IDENTITY(1,1) NOT NULL,
    [date] datetime  NOT NULL,
    [sellCrerk_id] int  NOT NULL,
    [customer_id] int  NOT NULL
);
GO

-- Creating table 'Kalas'
CREATE TABLE [dbo].[Kalas] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(100)  NOT NULL,
    [producer] nvarchar(100)  NOT NULL,
    [creatDate] datetime  NOT NULL,
    [expireDate] datetime  NOT NULL,
    [price] int  NOT NULL,
    [quantity] int  NOT NULL,
    [discount] int  NOT NULL,
    [seller] nvarchar(100)  NOT NULL,
    [submitDate] datetime  NOT NULL,
    [stockClerk_id] int  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [id] int IDENTITY(1,1) NOT NULL,
    [user1] nvarchar(100)  NOT NULL,
    [pass] nvarchar(100)  NOT NULL,
    [access] int  NOT NULL
);
GO

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [id] int IDENTITY(1,1) NOT NULL,
    [price] int  NOT NULL,
    [isChecked] bit  NOT NULL,
    [date] datetime  NOT NULL,
    [invoice_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [kala_id], [invoice_id] in table 'Buys'
ALTER TABLE [dbo].[Buys]
ADD CONSTRAINT [PK_Buys]
    PRIMARY KEY CLUSTERED ([kala_id], [invoice_id] ASC);
GO

-- Creating primary key on [id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Invoices'
ALTER TABLE [dbo].[Invoices]
ADD CONSTRAINT [PK_Invoices]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Kalas'
ALTER TABLE [dbo].[Kalas]
ADD CONSTRAINT [PK_Kalas]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [invoice_id] in table 'Buys'
ALTER TABLE [dbo].[Buys]
ADD CONSTRAINT [FK_Buy_Invoice]
    FOREIGN KEY ([invoice_id])
    REFERENCES [dbo].[Invoices]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Buy_Invoice'
CREATE INDEX [IX_FK_Buy_Invoice]
ON [dbo].[Buys]
    ([invoice_id]);
GO

-- Creating foreign key on [kala_id] in table 'Buys'
ALTER TABLE [dbo].[Buys]
ADD CONSTRAINT [FK_Buy_Kala]
    FOREIGN KEY ([kala_id])
    REFERENCES [dbo].[Kalas]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [customer_id] in table 'Invoices'
ALTER TABLE [dbo].[Invoices]
ADD CONSTRAINT [FK_Invoice_Customer]
    FOREIGN KEY ([customer_id])
    REFERENCES [dbo].[Customers]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Invoice_Customer'
CREATE INDEX [IX_FK_Invoice_Customer]
ON [dbo].[Invoices]
    ([customer_id]);
GO

-- Creating foreign key on [sellCrerk_id] in table 'Invoices'
ALTER TABLE [dbo].[Invoices]
ADD CONSTRAINT [FK_Invoice_User]
    FOREIGN KEY ([sellCrerk_id])
    REFERENCES [dbo].[Users]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Invoice_User'
CREATE INDEX [IX_FK_Invoice_User]
ON [dbo].[Invoices]
    ([sellCrerk_id]);
GO

-- Creating foreign key on [stockClerk_id] in table 'Kalas'
ALTER TABLE [dbo].[Kalas]
ADD CONSTRAINT [FK_Kala_User]
    FOREIGN KEY ([stockClerk_id])
    REFERENCES [dbo].[Users]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Kala_User'
CREATE INDEX [IX_FK_Kala_User]
ON [dbo].[Kalas]
    ([stockClerk_id]);
GO

-- Creating foreign key on [invoice_id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_Transaction_Invoice]
    FOREIGN KEY ([invoice_id])
    REFERENCES [dbo].[Invoices]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Transaction_Invoice'
CREATE INDEX [IX_FK_Transaction_Invoice]
ON [dbo].[Transactions]
    ([invoice_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------