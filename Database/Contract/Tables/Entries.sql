CREATE TABLE [Contract].[Entries] (
    [ID]      INT            IDENTITY (1, 1) NOT NULL,
    [LogID]   INT            NULL,
    [Title]   NVARCHAR (50)  NOT NULL,
    [Entry]   NVARCHAR (MAX) NOT NULL,
    [OwnerID] INT            NOT NULL,
    CONSTRAINT [PK_Entries] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Entries_Users] FOREIGN KEY ([OwnerID]) REFERENCES [KT].[Users] ([ID])
);

