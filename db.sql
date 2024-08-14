create database project;

use project;
CREATE TABLE employee (
    personID UNIQUEIDENTIFIER NOT NULL, 
    firstname varchar(25) NOT NULL, --- required field per tech requirements
    lastname varchar(25) NOT NULL,--- required field per tech requirements
    phonenumber INT,
    email varchar(30) NOT NULL UNIQUE, --- must be unique and is a required field per tech requirements
    startdate date,
    enddate date,
    active bit DEFAULT 1, --set default to active pert tech requirements
    createdby varchar(25) NOT NULL,
    createdate DATE NOT NULL,
    modifiedby varchar(25) ,
    modifieddate date 
    PRIMARY KEY (personID)
);

CREATE TABLE department (
    deptID UNIQUEIDENTIFIER NOT NULL,
    deptname varchar(25) NOT NULL UNIQUE,  --  COMMENT must have unique dept name per technical requirements
    abbreviation varchar(10) NOT NULL UNIQUE,  --  COMMENT must have unique abbreviation per technical requirements
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

