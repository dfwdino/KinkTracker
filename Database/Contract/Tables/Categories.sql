CREATE TABLE [Contract].[Categories] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [LogID]    INT           NULL,
    [Category] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Title] PRIMARY KEY CLUSTERED ([ID] ASC)
);

