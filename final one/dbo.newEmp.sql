CREATE TABLE [dbo].[newEmp] (
    [Id]          INT          NOT NULL,
    [fname]       VARCHAR (50) NOT NULL,
    [lname]       VARCHAR (50) NOT NULL,
    [contact]     INT          NULL,
    [address]     VARCHAR (50) NOT NULL,
    [designation] VARCHAR (50) NOT NULL,
    [bsal]        INT          NOT NULL,
    [increment] INT NOT NULL, 
    [decrement] INT NOT NULL, 
    [netsal] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

