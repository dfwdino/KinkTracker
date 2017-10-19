CREATE TABLE [Contract].[Contracts] (
    [ID]        INT           IDENTITY (1, 1) NOT NULL,
    [LogID]     INT           NULL,
    [StartDate] DATE          NOT NULL,
    [EndDate]   DATE          NULL,
    [Title]     NVARCHAR (50) NULL,
    CONSTRAINT [PK_Contracts] PRIMARY KEY CLUSTERED ([ID] ASC)
);

