CREATE TABLE [KT].[Users] (
    [ID]         INT           IDENTITY (1, 1) NOT NULL,
    [LogID]      INT           NULL,
    [FristName]  NVARCHAR (50) NOT NULL,
    [LastName]   NVARCHAR (50) NOT NULL,
    [KinkName]   NVARCHAR (50) NOT NULL,
    [KinkRoleID] INT           NOT NULL,
    [KTRoleID]   INT           CONSTRAINT [DF_Users_KTRoleID] DEFAULT ((2)) NOT NULL,
    [Password]   NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Users_KinkRoles] FOREIGN KEY ([KinkRoleID]) REFERENCES [Web].[KinkRoles] ([ID]),
    CONSTRAINT [FK_Users_Schemas] FOREIGN KEY ([KTRoleID]) REFERENCES [KT].[Schemas] ([ID])
);



