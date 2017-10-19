CREATE TABLE [Contract].[CategoryOwners] (
    [ID]         INT IDENTITY (1, 1) NOT NULL,
    [LogID]      INT NULL,
    [CategoryID] INT NULL,
    [UsersID]    INT NULL,
    CONSTRAINT [PK_TitleOwners] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_TitleOwners_Titles] FOREIGN KEY ([CategoryID]) REFERENCES [Contract].[Categories] ([ID]),
    CONSTRAINT [FK_TitleOwners_Users] FOREIGN KEY ([UsersID]) REFERENCES [KT].[Users] ([ID])
);

