CREATE TABLE [dbo].[Bookmarks] (
    [Id]    INT            IDENTITY (1, 1) NOT NULL,
    [URL]   NVARCHAR (MAX) NOT NULL,
    [Title] VARCHAR (MAX)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

