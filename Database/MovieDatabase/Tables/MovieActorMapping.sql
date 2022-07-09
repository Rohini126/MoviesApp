CREATE TABLE [dbo].[MovieActorMapping]
(
	[MappingId] BIGINT IDENTITY (1, 1) NOT NULL,
    [MovieXid] BIGINT NOT NULL, 
    [ActorXid] BIGINT NOT NULL,
    CONSTRAINT [PK_MovieActorMapping_ID] PRIMARY KEY CLUSTERED ([MappingId] ASC),
    CONSTRAINT [FK_ACTOR_XID] FOREIGN KEY ([ActorXid]) REFERENCES [Actor] ([ActorId]),
    CONSTRAINT [FK_MOVIE_XID] FOREIGN KEY ([MovieXid]) REFERENCES [Movie] ([MovieId]),

)
