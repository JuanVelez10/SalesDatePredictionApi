CREATE TABLE Account(
    Id UNIQUEIDENTIFIER PRIMARY KEY default NEWID(),
    Empid INT NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Password VARCHAR(100) NOT NULL,
    RoleType INT NOT NULL,
	FOREIGN KEY (Empid) REFERENCES HR.Employees(empid)
)
GO
CREATE TABLE [Message](
    Code INT NOT NULL,
    MessageType INT NOT NULL,
    [Message] VARCHAR(MAX) NOT NULL,
    PRIMARY KEY (Code,MessageType)
)
GO
DECLARE @IdAccount1 UNIQUEIDENTIFIER SET @IdAccount1=NEWID()
INSERT INTO Account VALUES (@IdAccount1,1,'sara@gmail.com','Janury5+',1)
DECLARE @IdAccount2 UNIQUEIDENTIFIER SET @IdAccount2=NEWID()
INSERT INTO Account VALUES (@IdAccount2,6,'paul@gmail.com','October31*',1)
GO
INSERT INTO Message VALUES
(1,2,'Oops, an error has occurred! Please contact our support team.'),
(2,2,'The minimum value must be less than the greater.'),
(3,2,'Does not exist.'),
(4,2,'Required.'),
(5,2,'It exceeds the allowed values.'),
(6,2,'The transaction was not processed.'),
(7,2,'It already exists.'),
(1,1,'Successful response.')