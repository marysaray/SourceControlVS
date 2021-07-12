CREATE DATABASE StudentDB
GO

USE StudentDB
GO

CREATE TABLE Students
(
    StudentID  char(9)        NOT NULL PRIMARY KEY,
    FirstName  varchar(30)    NOT NULL,
    LastName   varchar(30)    NOT NULL,
    Email      varchar(150)   NOT NULL
)
