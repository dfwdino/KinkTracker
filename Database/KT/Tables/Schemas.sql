CREATE TABLE [KT].[Schemas] (
    [ID]    INT           IDENTITY (1, 1) NOT NULL,
    [LogID] INT           NULL,
    [Names] NVARCHAR (25) NOT NULL,
    CONSTRAINT [PK_Schemas] PRIMARY KEY CLUSTERED ([ID] ASC)
);

