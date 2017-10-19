CREATE TABLE [KT].[Schemas] (
    [ID]    INT           IDENTITY (1, 1) NOT NULL,
    [LogID] INT           NULL,
    [Role]  NVARCHAR (25) NOT NULL,
    CONSTRAINT [PK_Schemas] PRIMARY KEY CLUSTERED ([ID] ASC)
);



