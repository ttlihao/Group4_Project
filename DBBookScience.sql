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

-- Insert records into UserAccount
INSERT INTO UserAccount (UserName, UserPassword, UserAddress, UserPhone, RoleID)
VALUES
    ('Alice', 'password123', '123 Main St', '555-1234', 1),
    ('Bob', 'secret456', '456 Elm St', '555-5678', 2),
    ('Charlie', 'qwerty789', '789 Oak Ave', '555-9876', 1),
    ('Zara', 'zara123', '987 Pine Rd', '555-4321', 2);
