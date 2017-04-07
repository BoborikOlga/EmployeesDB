CREATE TABLE [dbo].[EmployeeData]
(
	[ID] INT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) COLLATE cyrillic_general_ci_as NOT NULL, 
    [Surname] VARCHAR(50) COLLATE cyrillic_general_ci_as NOT NULL, 
    [Position ] VARCHAR(50) COLLATE cyrillic_general_ci_as  NOT NULL, 
	[BornYear] INT NOT NULL,
    [Salary] MONEY NULL
)
