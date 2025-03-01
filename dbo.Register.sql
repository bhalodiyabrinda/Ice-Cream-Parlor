CREATE TABLE [dbo].[Register] (
    [Id]       INT          NOT NULL,
    [Email]    VARCHAR (50) NOT NULL,
    [Username] VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NOT NULL,
    [Mobail]   INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

