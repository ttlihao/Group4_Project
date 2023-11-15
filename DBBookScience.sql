-- Create the BookScience database
CREATE DATABASE BookScience;
USE BookScience;

-- Create the UserAccount table
CREATE TABLE UserAccount (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    UserName VARCHAR(50) NOT NULL,
    UserPassword VARCHAR(50) NOT NULL,
    UserAddress VARCHAR(100),
    UserPhone VARCHAR(15),
    RoleID INT
);

-- Create the Book table
CREATE TABLE Book (
    BookID INT IDENTITY(1,1) PRIMARY KEY,
    BookName VARCHAR(100) NOT NULL,
    BookDescription TEXT,
    Author VARCHAR(50),
    ReleaseDate DATE,
    IsActived BIT
);