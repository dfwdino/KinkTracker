CREATE TABLE [Contract].[Contracts] (
    [ID]           INT           IDENTITY (1, 1) NOT NULL,
    [LogID]        INT           NULL,
    [StartDate]    DATE          NOT NULL,
    [EndDate]      DATE          NULL,
    [Title]        NVARCHAR (50) NULL,
    [OwnerID]      INT           NOT NULL,
    [AssignedToID] INT           NOT NULL,
    CONSTRAINT [PK_Contracts] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Contracts_Logs] FOREIGN KEY ([LogID]) REFERENCES [KT].[Logs] ([ID]),
    CONSTRAINT [FK_Contracts_Users_AssignedTo] FOREIGN KEY ([AssignedToID]) REFERENCES [KT].[Users] ([ID]),
    CONSTRAINT [FK_Contracts_Users_Owner] FOREIGN KEY ([OwnerID]) REFERENCES [KT].[Users] ([ID])
);



