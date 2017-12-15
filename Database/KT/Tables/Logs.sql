CREATE TABLE [KT].[Logs] (
    [ID]         INT            IDENTITY (1, 1) NOT NULL,
    [CreatedOn]  DATETIME       CONSTRAINT [DF_Logs_CreatedOn] DEFAULT (getdate()) NOT NULL,
    [CreateByID] INT            NOT NULL,
    [OldValue]   NVARCHAR (MAX) NULL,
    [NewValue]   NVARCHAR (MAX) NOT NULL,
    [IPAddress]  NVARCHAR (50)  NOT NULL,
    [Broswer]    NVARCHAR (255) NOT NULL,
    [Lat]        FLOAT (53)     NULL,
    [Long]       FLOAT (53)     NULL,
    CONSTRAINT [PK_Logs] PRIMARY KEY CLUSTERED ([ID] ASC)
);



