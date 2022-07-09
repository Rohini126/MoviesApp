CREATE TABLE [Actor] (
    [ActorId]               BIGINT              IDENTITY (1, 1) NOT NULL,
    [Actorname]             NVARCHAR (250)      NOT NULL,
    [ActorBio]              NVARCHAR (1000)     NULL,
    [Gender]                NVARCHAR (10)       NULL,
    [DateOfBirth]           DATETIME            NULL,
    [CreationDate]          DATETIME            NULL,
    [ModificationDate]      DATETIME            NULL,
    CONSTRAINT [PK_ACTOR_ID] PRIMARY KEY CLUSTERED ([ActorId] ASC),
   
);