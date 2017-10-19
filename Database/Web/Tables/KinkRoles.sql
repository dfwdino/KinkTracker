CREATE TABLE [Web].[KinkRoles] (
    [ID]    INT           IDENTITY (1, 1) NOT NULL,
    [LogID] INT           NULL,
    [Role]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_KinkRoles] PRIMARY KEY CLUSTERED ([ID] ASC)
);

