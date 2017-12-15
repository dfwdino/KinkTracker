CREATE TABLE [KT].[UserOwners] (
    [ID]           INT      IDENTITY (1, 1) NOT NULL,
    [LogID]        INT      NULL,
    [DomID]        INT      NULL,
    [SubID]        INT      NULL,
    [RequestByID]  INT      NULL,
    [ApprovedByID] INT      NULL,
    [RequestTime]  DATETIME NULL,
    [ApprovedTime] DATETIME NULL,
    CONSTRAINT [PK_UserOwners] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_UserOwners_UserOwners-SubID] FOREIGN KEY ([SubID]) REFERENCES [KT].[Users] ([ID]),
    CONSTRAINT [FK_UserOwners_UsersApprovedBy] FOREIGN KEY ([ApprovedByID]) REFERENCES [KT].[Users] ([ID]),
    CONSTRAINT [FK_UserOwners_Users-DomID] FOREIGN KEY ([DomID]) REFERENCES [KT].[Users] ([ID]),
    CONSTRAINT [FK_UserOwners_UsersRequestBy] FOREIGN KEY ([RequestByID]) REFERENCES [KT].[Users] ([ID])
);



