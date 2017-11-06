USE [TaskTracker]
GO

/****** Object: Table [dbo].[Task] Script Date: 2017/11/01 07:39:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Task] (
    [IDTask]              INT           IDENTITY (1, 1) NOT NULL,
    [Application]         VARCHAR (100) NOT NULL,
    [CurrentSessionStart] DATETIME      NULL,
    [CurrentSessionEnd]   DATETIME      NULL,
    [TotalTime]           BIGINT        NULL,
    [TimeSpan]            TIME (7)      NULL
);


