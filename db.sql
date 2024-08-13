create database project;

use project;
CREATE TABLE employee (
    personID UNIQUEIDENTIFIER NOT NULL,
    firstname varchar(25) NOT NULL,
    lastname varchar(25) NOT NULL,
    phonenumber INT,
    email varchar(30) NOT NULL UNIQUE,
    startdate date,
    enddate date,
    active bit DEFAULT 1, --set default to active
    createdby varchar(25) NOT NULL,
    createdate DATE NOT NULL,
    modifiedby varchar(25) ,
    modifieddate date 
    PRIMARY KEY (personID)
);

CREATE TABLE department (
    deptID UNIQUEIDENTIFIER NOT NULL,
    deptname varchar(25) NOT NULL UNIQUE,
    abbreviation varchar(10) NOT NULL UNIQUE,
    createdby varchar(25) NOT NULL,
    createdate DATE NOT NULL,
    modifiedby varchar(25),
    modifieddate date 
    PRIMARY KEY (deptID)
);

CREATE TABLE assignment (
    assignmentID UNIQUEIDENTIFIER NOT NULL,
    personID UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES employee(personID),
    deptID UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES department(deptID),
    createdby varchar(25) NOT NULL,
    createdate DATE NOT NULL,
    modifiedby varchar(25),
    modifieddate date,
    PRIMARY KEY (assignmentID)
);

