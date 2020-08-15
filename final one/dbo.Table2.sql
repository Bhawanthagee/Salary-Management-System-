CREATE TABLE [dbo].[paymentTBL]
(
	[ID] INT NOT NULL primary KEY, 
    [bonus] INT NULL, 
    [OT] INT NULL, 
    [otherAdditions] INT NULL, 
    [load] INT NULL, 
    [otherReductions] INT NULL, 
    [basicsal] INT NOT NULL, 
    [netsal] INT NOT NULL
)
