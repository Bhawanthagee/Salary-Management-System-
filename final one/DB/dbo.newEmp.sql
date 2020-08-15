CREATE TABLE [dbo].[newEmp] (
    [Id]          INT          NOT NULL,
    [fname]       VARCHAR (50) NOT NULL,
    [lname]       VARCHAR (50) NOT NULL,
    [contact]     INT          NULL,
    [address]     VARCHAR (50) NOT NULL,
    [designation] VARCHAR (50) NOT NULL,
    [bsal]        INT          NOT NULL,
    [bonus] INT NULL, 
    [other_reductions] INT NULL, 
    [Net_salary] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

