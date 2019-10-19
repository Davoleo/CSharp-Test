CREATE TABLE [dbo].[Athletes]
(
	[uid] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] VARCHAR(20) NULL, 
    [age] INT NULL, 
    [keyCountry] INT NULL, 
    [taxCode] CHAR(16) NULL
)

GO


CREATE INDEX [IX_Table_Column] ON [dbo].[Athletes] ([keyCountry])
