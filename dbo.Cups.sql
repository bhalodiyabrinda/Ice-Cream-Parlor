CREATE TABLE [dbo].[Cups] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [PackagingType] VARCHAR (50) NOT NULL,
    [Flavour]       VARCHAR (50) NOT NULL,
    [Adderss]       VARCHAR (50) NOT NULL,
    [Piece]         VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

