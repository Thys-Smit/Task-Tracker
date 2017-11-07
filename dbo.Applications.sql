USE [TaskTracker]
GO

/****** Object: Table [dbo].[Applications] Script Date: 2017/11/01 07:38:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Applications] (
    [IDApplication]   INT            IDENTITY (1, 1) NOT NULL,
    [ApplicationName] VARCHAR (100)  NOT NULL,
    [isActive]        BIT            NOT NULL,
    [AppRegex]        NVARCHAR (100) NULL,
    [Inactive]        BIT            NOT NULL
);


