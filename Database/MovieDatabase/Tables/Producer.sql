CREATE TABLE [dbo].[Producer]
(
	[producerId] BIGINT IDENTITY (1, 1) NOT NULL,
    [ProducerName] NCHAR(250) NOT NULL, 
    [producerBio] NCHAR(1000) NULL, 
    [dateOfBirth] DATETIME NULL, 
    [Companyname] NCHAR(250) NULL, 
    [Gender] NCHAR(10) NULL, 
    [CreationDate] DATETIME NULL, 
    [ModificationDate] DATETIME NULL,
    CONSTRAINT [PK_PRODUCER_ID] PRIMARY KEY CLUSTERED ([producerId] ASC),

)
