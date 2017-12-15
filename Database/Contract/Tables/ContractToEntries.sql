CREATE TABLE [Contract].[ContractToEntries] (
    [ID]         INT IDENTITY (1, 1) NOT NULL,
    [LogID]      INT NULL,
    [ContractID] INT NOT NULL,
    [EntryID]    INT NOT NULL,
    CONSTRAINT [PK_ContractToEntries] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_ContractToEntries_Contracts] FOREIGN KEY ([ContractID]) REFERENCES [Contract].[Contracts] ([ID]),
    CONSTRAINT [FK_ContractToEntries_Entries] FOREIGN KEY ([EntryID]) REFERENCES [Contract].[Entries] ([ID]),
    CONSTRAINT [FK_ContractToEntries_Logs] FOREIGN KEY ([LogID]) REFERENCES [KT].[Logs] ([ID])
);

