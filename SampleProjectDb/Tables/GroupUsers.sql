CREATE TABLE [dbo].[GroupUsers]
(
	[GroupId] INT NOT NULL, 
    [UserId] UNIQUEIDENTIFIER NOT NULL,

	CONSTRAINT [PK_GroupId_UserId] PRIMARY KEY ([GroupId], [UserId])
)
