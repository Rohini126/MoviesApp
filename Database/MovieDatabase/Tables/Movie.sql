CREATE TABLE [dbo].[Movie]
(
	[MovieId] BIGINT IDENTITY (1, 1) NOT NULL,
    [MovieName] NCHAR(250) NOT NULL, 
    [MoviePlot] NCHAR(1000) NULL, 
    [PosterData] NCHAR(500) NULL, 
    [ProducerXid] BIGINT NULL, 
    [ReleaseDate] DATETIME NULL, 
    [CreationDate] DATETIME NULL, 
    [ModificationDate] DATETIME NULL, 
    [status] TINYINT NULL,
    CONSTRAINT [PK_MOVIE_ID] PRIMARY KEY CLUSTERED ([MovieId] ASC),
    CONSTRAINT [FK_Producer_XID] FOREIGN KEY ([ProducerXid]) REFERENCES [Producer] ([producerId]),
)
