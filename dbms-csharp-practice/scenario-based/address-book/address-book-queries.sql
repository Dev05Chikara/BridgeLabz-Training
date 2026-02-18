CREATE DATABASE AddressBookDB;
GO

USE AddressBookDB;
GO

CREATE TABLE AddressBooks
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL UNIQUE
);
GO

CREATE TABLE Contacts
(
    Id INT PRIMARY KEY IDENTITY(1,1),

    AddressBookId INT NOT NULL,

    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Address NVARCHAR(200),
    City NVARCHAR(100),
    State NVARCHAR(100),
    Zip NVARCHAR(20),
    PhoneNumber NVARCHAR(20),
    Email NVARCHAR(100),

    CONSTRAINT FK_Contacts_AddressBooks
        FOREIGN KEY (AddressBookId)
        REFERENCES AddressBooks(Id)
        ON DELETE CASCADE
);
GO
