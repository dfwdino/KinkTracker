CREATE TABLE [KT].[UserOwners] (
    [ID]    INT IDENTITY (1, 1) NOT NULL,
    [LogID] INT NULL,
    [DomID] INT NULL,
    [SubID] INT NULL,
    CONSTRAINT [PK_UserOwners] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_UserOwners_UserOwners-SubID] FOREIGN KEY ([SubID]) REFERENCES [KT].[UserOwners] ([ID]),
    CONSTRAINT [FK_UserOwners_Users-DomID] FOREIGN KEY ([DomID]) REFERENCES [KT].[Users] ([ID])
);

