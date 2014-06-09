CREATE TABLE [dbo].[Zaposlenik]
(
	[IdZaposlenik] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [imeZaposlenik] VARCHAR(40) NOT NULL, 
    [prezimeZaposlenik] VARCHAR(40) NOT NULL, 
    [korisnickoIme] VARCHAR(20) NOT NULL, 
    [lozinka] VARCHAR(20) NOT NULL, 
    [email] VARCHAR(40) NOT NULL,
)
