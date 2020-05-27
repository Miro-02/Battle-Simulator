CREATE TABLE [dbo].[Books] (
    [Id]     INT         NOT NULL PRIMARY KEY IDENTITY,
    [Title]  NCHAR (30)  NOT NULL,
    [Author] NCHAR (30)  NOT NULL,
    [Genre]  NCHAR (30)  NOT NULL,
    [Year]   INT         NOT NULL,
    [Des]    NCHAR (500) NOT NULL,
    [Photo]  NCHAR (20)  NULL,
);

